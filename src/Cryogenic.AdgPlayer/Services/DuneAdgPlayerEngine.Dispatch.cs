namespace Cryogenic.AdgPlayer.Services;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Song;

using System;

/// <summary>
/// Engine event dispatch (B4): consumes the per-channel event
/// stream when its wait counter reaches zero and routes each
/// 16-bit event word to the matching opcode handler. This is the
/// inner body of <c>AdgSchedulerTick_0756</c>'s while-loop.
/// </summary>
/// <remarks>
/// Currently implemented opcodes:
/// <see cref="AdgEventOpcode.ReadWaitValue"/> (slots 2 and 3) and
/// <see cref="AdgEventOpcode.EndOfTrack"/> (slot 7). The remaining
/// musical opcodes (NoteOff, NoteOn, ProgramChange, VolumeModulation,
/// PitchBend) are gated on subsequent TDD cycles and currently raise
/// <see cref="UnhandledOpcodeEncountered"/> with a structured payload
/// instead of crashing — callers can catch this in tests, and
/// production code stops the affected channel by zeroing its pointer
/// to prevent runaway dispatch.
/// </remarks>
public sealed partial class DuneAdgPlayerEngine {

	/// <summary>
	/// Raised when the dispatcher encounters an opcode whose handler is
	/// not yet implemented. The affected channel's event pointer is
	/// zeroed after the event fires (the channel goes silent for the
	/// remainder of playback).
	/// </summary>
	public event Action<AdgUnhandledOpcodeArgs>? UnhandledOpcodeEncountered;

	/// <summary>
	/// Reads and dispatches events for <paramref name="channelIndex"/>
	/// until either a non-zero wait counter is set (paused) or the
	/// channel pointer is cleared (end-of-stream). Returns the number
	/// of events dispatched.
	/// </summary>
	public int DispatchEvents(int channelIndex) {
		if (_songImage is null) {
			throw new InvalidOperationException("No song loaded.");
		}
		AdgInMemoryEventStream stream = new(_songImage);

		int dispatched = 0;
		while (_state.WaitCounters.Get(channelIndex) == 0) {
			ushort pointer = _state.EventPointers.Get(channelIndex);
			if (pointer == 0) {
				return dispatched;
			}
			if (!stream.WordInRange(pointer)) {
				// Stream truncated — clear the pointer and stop.
				_state.EventPointers.Set(channelIndex, 0);
				return dispatched;
			}
			ushort eventWord = stream.ReadUInt16(pointer);
			_state.EventPointers.Set(channelIndex, (ushort)(pointer + 2));

			int slot = AdgEventOpcodeClassifier.Classify(eventWord);
			AdgEventOpcode opcode = AdgEventOpcodeRouter.Route(slot);
			DispatchOpcode(channelIndex, opcode, eventWord, stream);
			dispatched++;
		}
		return dispatched;
	}

	private void DispatchOpcode(int channelIndex, AdgEventOpcode opcode, ushort eventWord, AdgInMemoryEventStream stream) {
		switch (opcode) {
			case AdgEventOpcode.ReadWaitValue:
				HandleReadWaitValue(channelIndex, stream);
				return;
			case AdgEventOpcode.EndOfTrack:
				HandleEndOfTrack(channelIndex);
				return;
			case AdgEventOpcode.NoteOff:
				HandleNoteOff(channelIndex, eventWord, stream);
				return;
			case AdgEventOpcode.NoteOn:
				HandleNoteOn(channelIndex, eventWord, stream);
				return;
			case AdgEventOpcode.ProgramChange:
			case AdgEventOpcode.VolumeModulation:
			case AdgEventOpcode.PitchBend:
				RaiseUnhandledOpcode(channelIndex, opcode, eventWord);
				_state.EventPointers.Set(channelIndex, 0);
				return;
			default:
				throw new InvalidOperationException(
					$"ADG dispatcher reached unreachable opcode {opcode} on channel {channelIndex}.");
		}
	}

	private void HandleReadWaitValue(int channelIndex, AdgInMemoryEventStream stream) {
		ushort pointer = _state.EventPointers.Get(channelIndex);
		uint accumulator = 0;
		bool overflowed = false;
		int cursor = pointer;
		while (true) {
			if (!stream.InRange(cursor)) {
				// Stream truncated — bail out by clearing the channel.
				_state.EventPointers.Set(channelIndex, 0);
				return;
			}
			byte current = stream.ReadByte(cursor++);
			accumulator = (accumulator << 7) | (uint)(current & 0x7F);
			if (accumulator > ushort.MaxValue) {
				overflowed = true;
			}
			if ((current & 0x80) == 0) {
				break;
			}
		}
		ushort value = overflowed ? (ushort)0xFFFF : (ushort)accumulator;
		_state.WaitCounters.Set(channelIndex, value);
		_state.EventPointers.Set(channelIndex, (ushort)cursor);
	}

	private void HandleEndOfTrack(int channelIndex) {
		_state.EventPointers.Set(channelIndex, 0);
	}

	/// <summary>
	/// Faithful port of <c>AdgNoteOff_0AB6</c> from
	/// <c>AdgDriverCode.cs</c> (line 1948). Sequence:
	/// 1) skip the velocity byte that follows the event word;
	/// 2) consume the variable-length wait value
	///    (<c>AdgReadWaitValue_0E7E</c>);
	/// 3) compute the transposed note via the per-channel pitch
	///    transpose slot (DI+0x91);
	/// 4) bail out unless the channel's current note (DI+0x6D)
	///    matches the released note;
	/// 5) clear the current-note slot;
	/// 6) invoke <see cref="AdgScratchMaskClearer.Clear"/> using the
	///    next-event byte at the cursor as the gating byte;
	/// 7) emit an OPL key-off via
	///    <see cref="AdgChannelNoteOffEmitter"/> when a routing table
	///    is bound (otherwise state-only).
	/// </summary>
	private void HandleNoteOff(int channelIndex, ushort eventWord, AdgInMemoryEventStream stream) {
		ushort pointer = _state.EventPointers.Get(channelIndex);
		// Skip the velocity byte that immediately follows the event word.
		if (!stream.InRange(pointer)) {
			_state.EventPointers.Set(channelIndex, 0);
			return;
		}
		_state.EventPointers.Set(channelIndex, (ushort)(pointer + 1));

		// Variable-length wait value.
		HandleReadWaitValue(channelIndex, stream);

		byte rawNote = (byte)(eventWord >> 8);
		byte transposedNote = _state.PitchTransposeSlots.ApplyTo(channelIndex, rawNote);
		if (_state.CurrentNotes.Get(channelIndex) != transposedNote) {
			return;
		}
		_state.CurrentNotes.Clear(channelIndex);

		ushort cursor = _state.EventPointers.Get(channelIndex);
		byte nextEventByte = stream.InRange(cursor)
			? stream.ReadByte(cursor)
			: AdgScratchMaskClearer.TerminatorByte;
		AdgScratchMaskClearer.Clear(_state.ChannelStateScratch,
			_state.FadeScratchState, channelIndex,
			_state.WaitCounters.Get(channelIndex), nextEventByte);

		if (_routingTable is not null) {
			AdgChannelNoteOffEmitter.Emit(_oplBus, _state.FrequencyWordCache,
				_routingTable, channelIndex);
		}
	}

	/// <summary>
	/// Faithful state-mutation port of <c>AdgNoteOn_0A82</c> from
	/// <c>AdgDriverCode.cs</c> (line 1931). Sequence:
	/// 1) read velocity byte (one past the event word) and advance
	///    the cursor;
	/// 2) consume the variable-length wait value;
	/// 3) (deep helper <c>AdgEnvelopeSetup_0C47</c> deferred — only
	///    emits OPL register writes; tracked for B4.2b);
	/// 4) if the channel already holds a note, emit a key-off via
	///    <see cref="AdgChannelNoteOffEmitter"/> when routing is
	///    bound (otherwise state-only);
	/// 5) compute the transposed note, store it as the new current
	///    note (DI+0x6D);
	/// 6) recenter the channel pitch accumulator at 0x40
	///    (DI+0xD8);
	/// 7) (final OPL note-on via <c>AdgNoteOn_10A9</c> deferred to
	///    B4.2b — needs the full envelope/frequency lookup chain).
	/// </summary>
	private void HandleNoteOn(int channelIndex, ushort eventWord, AdgInMemoryEventStream stream) {
		ushort pointer = _state.EventPointers.Get(channelIndex);
		// Step 1 — skip the velocity byte (only consumed by the
		// envelope-setup helper, deferred to B4.2b).
		if (!stream.InRange(pointer)) {
			_state.EventPointers.Set(channelIndex, 0);
			return;
		}
		_state.EventPointers.Set(channelIndex, (ushort)(pointer + 1));

		// Step 2 — variable-length wait value.
		HandleReadWaitValue(channelIndex, stream);

		// Step 4 — if the channel already holds a note, key-off the
		// previous note (gated on routing-table presence so state-only
		// callers don't need to wire OPL).
		if (_state.CurrentNotes.Get(channelIndex) != 0 && _routingTable is not null) {
			AdgChannelNoteOffEmitter.Emit(_oplBus, _state.FrequencyWordCache,
				_routingTable, channelIndex);
		}

		// Step 5 — store the transposed current note.
		byte rawNote = (byte)(eventWord >> 8);
		byte transposedNote = _state.PitchTransposeSlots.ApplyTo(channelIndex, rawNote);
		_state.CurrentNotes.Set(channelIndex, transposedNote);

		// Step 6 — recenter the pitch accumulator.
		_state.PitchAccumulators.Center(channelIndex);

		// Step 7 — full OPL note-on emit deferred to B4.2b.
	}

	private void RaiseUnhandledOpcode(int channelIndex, AdgEventOpcode opcode, ushort eventWord) {
		UnhandledOpcodeEncountered?.Invoke(new AdgUnhandledOpcodeArgs(channelIndex, opcode, eventWord));
	}
}

/// <summary>
/// Payload supplied to <see cref="DuneAdgPlayerEngine.UnhandledOpcodeEncountered"/>.
/// </summary>
/// <param name="ChannelIndex">Channel whose stream produced the event.</param>
/// <param name="Opcode">Routed opcode (the handler is not yet implemented).</param>
/// <param name="EventWord">Raw 16-bit event word read from the stream.</param>
public readonly record struct AdgUnhandledOpcodeArgs(int ChannelIndex, AdgEventOpcode Opcode, ushort EventWord);
