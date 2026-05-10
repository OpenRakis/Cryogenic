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
			case AdgEventOpcode.NoteOn:
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
