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
/// All eight opcode slots are now routed:
/// <see cref="AdgEventOpcode.NoteOff"/> (slot 0),
/// <see cref="AdgEventOpcode.NoteOn"/> (slot 1, state-only — full
/// OPL emit chain deferred to B4.2b),
/// <see cref="AdgEventOpcode.ReadWaitValue"/> (slots 2 and 3),
/// <see cref="AdgEventOpcode.ProgramChange"/> (slot 4, instrument-slot
/// + wait — patch-load deferred to B4.3b),
/// <see cref="AdgEventOpcode.VolumeModulation"/> (slot 5, wait-only
/// — OPL emit chain deferred to B4.4b),
/// <see cref="AdgEventOpcode.PitchBend"/> (slot 6, wait-only — OPL
/// emit chain deferred to B4.5b),
/// <see cref="AdgEventOpcode.EndOfTrack"/> (slot 7).
/// </remarks>
public sealed partial class DuneAdgPlayerEngine {

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
				HandleProgramChange(channelIndex, eventWord, stream);
				return;
			case AdgEventOpcode.VolumeModulation:
				HandleVolumeModulation(channelIndex, eventWord, stream);
				return;
			case AdgEventOpcode.PitchBend:
				HandlePitchBend(channelIndex, eventWord, stream);
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

	/// <summary>
	/// Faithful state-mutation port of <c>AdgEndOfTrack_0AF5</c>
	/// from <c>AdgDriverCode.cs</c> (line 1961). The handler:
	/// 1) writes <c>0xFFFF</c> into the channel's wait counter
	///    (DI+0): the per-channel done sentinel that prevents
	///    further dispatch;
	/// 2) zeroes the channel event pointer so the Tick scan skips
	///    this channel;
	/// 3) invokes <see cref="AdgScratchMaskClearer.Clear"/> with the
	///    terminator byte (the original loads the byte after the
	///    end-of-track word; in our model the channel is finished so
	///    we pass <see cref="AdgScratchMaskClearer.TerminatorByte"/>
	///    explicitly).
	/// The master-track reload + loop-point logic (channel-0 path
	/// in the original) is deferred to cycle B4.6b.
	/// </summary>
	private void HandleEndOfTrack(int channelIndex) {
		_state.WaitCounters.Set(channelIndex, 0xFFFF);
		_state.EventPointers.Set(channelIndex, 0);
		AdgScratchMaskClearer.Clear(_state.ChannelStateScratch,
			_state.FadeScratchState, channelIndex,
			_state.WaitCounters.Get(channelIndex),
			AdgScratchMaskClearer.TerminatorByte);
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

		// Step 6 — reload the per-channel pitch-bend counter from
		// its companion reload byte (DI+0xB4 ← DI+0xB5).
		_state.PitchBendCounters.Set(channelIndex,
			_state.PitchBendCounterReloads.Get(channelIndex));

		// Step 7 — recenter the pitch accumulator.
		_state.PitchAccumulators.Center(channelIndex);

		// Step 8 — full OPL note-on emit (mirrors AdgNoteOn_10A9 at
		// dnadg:10A9). Gated on routing-table + frequency-lookup
		// presence; envelope setup (AdgEnvelopeSetup_0C47) remains
		// deferred to a later cycle.
		if (_routingTable is not null && _frequencyLookupTable is not null) {
			ushort rawPitch = (ushort)(transposedNote - 0x48);
			AdgChannelNoteOnEmitter.Emit(_oplBus, _state.FrequencyWordCache,
				_routingTable, _frequencyLookupTable, channelIndex, rawPitch);
		}
	}

	/// <summary>
	/// Faithful state-mutation port of <c>AdgProgramChange_0831</c>
	/// from <c>AdgDriverCode.cs</c> (line 1542). Currently performs
	/// the two top-of-handler steps:
	/// 1) consume the variable-length wait value;
	/// 2) write the new instrument byte (Hi8 of the event word) into
	///    the per-channel instrument slot (DI+0x6C).
	/// The deep instrument-patch load + OPL register emission
	/// (<c>AdgConfigureInstrumentRouting_090D</c>,
	/// <c>AdgWriteInstrumentPatch_0F95</c>) is gated for cycle B4.3b.
	/// </summary>
	private void HandleProgramChange(int channelIndex, ushort eventWord, AdgInMemoryEventStream stream) {
		HandleReadWaitValue(channelIndex, stream);
		byte instrumentIndex = (byte)(eventWord >> 8);
		_state.InstrumentSlots.Set(channelIndex, instrumentIndex);
	}

	/// <summary>
	/// Faithful port of <c>AdgVolumeModulation_0B2E</c> from
	/// <c>AdgDriverCode.cs</c> (line 1708) covering the
	/// non-4op primary+secondary operator-level emit chain. The
	/// 4-op extension and the FeedbackConnection
	/// (<c>AdgChannelConnectionModulationOffset</c>) tail are
	/// deferred to a later cycle.
	///
	/// Sequence:
	/// 1. consume the variable-length wait value;
	/// 2. compute primary operator new level via
	///    <see cref="AdgVolumeModulationComputer.ComputePrimary"/>;
	///    on shape != 0 emit to KSL/TL register through the routing
	///    table's primary route and update Lo8 of the cached
	///    operator-level word;
	/// 3. same for the secondary operator (Hi8).
	/// Emit is gated on the routing table being bound — without it
	/// only the cached state is updated.
	/// </summary>
	private void HandleVolumeModulation(int channelIndex, ushort eventWord, AdgInMemoryEventStream stream) {
		HandleReadWaitValue(channelIndex, stream);
		byte directVelocity = (byte)(eventWord >> 8);
		byte inverseVelocity = (byte)(0x80 - directVelocity);
		ushort currentLevel = _state.CurrentOperatorLevels.Get(channelIndex);
		ushort volumeShape = _state.VolumeModulationSlots.Get(channelIndex);

		AdgVolumeModulationComputer.OperatorResult primary =
			AdgVolumeModulationComputer.ComputePrimary(
				currentLevel, volumeShape, directVelocity, inverseVelocity);
		AdgVolumeModulationComputer.OperatorResult secondary =
			AdgVolumeModulationComputer.ComputeSecondary(
				currentLevel, volumeShape, directVelocity, inverseVelocity);

		ushort newLevel = (ushort)((secondary.NewLevel << 8) | primary.NewLevel);
		_state.CurrentOperatorLevels.Set(channelIndex, newLevel);

		if (_routingTable is null) {
			return;
		}
		AdgChannelRoutingEntry entry = _routingTable.GetEntry(channelIndex);
		if (primary.Active) {
			AdgOperatorLevelEmitter.Emit(_oplBus, entry.PrimaryRoute, primary.NewLevel);
		}
		if (secondary.Active) {
			AdgOperatorLevelEmitter.Emit(_oplBus, entry.SecondaryRoute, secondary.NewLevel);
		}
	}

	/// <summary>
	/// Faithful port of <c>AdgPitchBend_0D86</c> from
	/// <c>AdgDriverCode.cs</c> (line 1925): consume the wait value,
	/// then forward to the configured <see cref="IAdgPitchBendBody"/>
	/// with <c>bendWord = (Hi8 &lt;&lt; 8) | Hi8</c> (matching
	/// <c>AX = Make16(Hi8(eventWord), Hi8(eventWord))</c> at
	/// dnadg:0D86). The default body
	/// (<see cref="NullAdgPitchBendBody"/>) is a no-op until the
	/// production <see cref="DefaultAdgPitchBendBody"/> is bound
	/// via <c>SetPitchBendBody(...)</c>.
	/// </summary>
	private void HandlePitchBend(int channelIndex, ushort eventWord, AdgInMemoryEventStream stream) {
		HandleReadWaitValue(channelIndex, stream);
		byte bendValue = (byte)(eventWord >> 8);
		ushort bendWord = (ushort)((bendValue << 8) | bendValue);
		_pitchBendBody.Emit(channelIndex, bendWord);
	}
}