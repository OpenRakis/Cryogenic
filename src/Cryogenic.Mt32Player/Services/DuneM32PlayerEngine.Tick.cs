namespace Cryogenic.Mt32Player.Services;

/// <summary>
/// Tick/timer, channel processing, event dispatch, and all MIDI event handlers.
/// Faithfully mirrors DNMID routines 030F..05FF.
///
/// Key corrections vs. earlier buggy version:
/// - Accumulator: [0x011D] is a single 16-bit word; the high byte [0x011E] is
///   decremented by TickInternal, and ProcessTick adds tickIncrement to the full
///   word. These MUST be the same variable (_accumulator), not separate fields.
/// - VLQ: standard MIDI VLQ (result &lt;&lt; 7 | b &amp; 0x7F), not additive
/// - Channel wait: decrement-then-check, not check-then-decrement
/// - AdvanceSubdivision: dec first, then check == 0
/// - Measure starts at 1, not 0
/// - Channel offsets relative to SongDataOffset (byte 2)
/// - BuildChannelTable reads initial deltas (+ 1) from stream
/// - CheckSongEnd uses exact equality + subdivision == 0x60
/// </summary>
public sealed partial class DuneM32PlayerEngine {
	/// <summary>
	/// Called from the audio render callback with the number of audio frames
	/// about to be rendered. Advances the PIT tick accumulator and fires
	/// TickInternal at the correct rate relative to the sample clock.
	///
	/// This replaces OS-level timers entirely: timing is derived from the
	/// audio sample rate (48 kHz) and the PIT reload value (0x1745 = 5957).
	///
	///   samplesPerTick = SampleRate * PitReloadValue / PitInputClock
	///                  = 48000 * 5957 / 1193182 ≈ 239.8
	///
	/// Integer math: accumulate PitInputClock per frame, fire when ≥ threshold.
	/// </summary>
	public void AdvanceSamples(int frameCount) {
		if (!_isPlaying) {
			return;
		}
		_sampleAccumulator += (long)frameCount * PitInputClock;
		while (_sampleAccumulator >= SamplesPerTickThreshold) {
			_sampleAccumulator -= SamplesPerTickThreshold;
			TickInternal();
		}
	}

	/// <summary>
	/// Called once per PIT tick (~5ms). Mirrors MidiTickInternal_F000_030F exactly:
	///
	///   if (statusFlags &amp; 0x80) == 0: return
	///   dec byte [011E]  (= high byte of word [011D])
	///   if (highByte &amp; 0x80) != 0: ProcessTick()  (adds tickIncrement to word [011D])
	///   rol fadeBitPattern, 1
	///   if carry: HandleFade()
	///
	/// Critical: [011E] is the HIGH byte of the 16-bit accumulator at [011D].
	/// ProcessTick adds tickIncrement to the WORD [011D], setting the next countdown.
	/// They share the same 16-bit variable (_accumulator).
	/// </summary>
	private void TickInternal() {
		if ((_statusFlags & 0x80) == 0) {
			return;
		}
		_tickIndex++;

		// dec byte ptr DS:[0x011E] — decrement ONLY the high byte of _accumulator
		byte hiByte = (byte)(_accumulator >> 8);
		hiByte--;
		_accumulator = (ushort)((hiByte << 8) | (_accumulator & 0xFF));

		// jns skip — if high byte went negative (bit7 set), call ProcessTick
		if ((hiByte & 0x80) != 0) {
			ProcessTick();
		}

		// rol word [013B], 1; jnb skip  =>  if top bit was set, HandleFade
		bool carry = (_fadeBitPattern & 0x8000) != 0;
		_fadeBitPattern = (ushort)((_fadeBitPattern << 1) | (carry ? 1 : 0));
		if (carry) {
			HandleFade();
		}

		if ((_tickIndex % 200) == 0) {
			EmitSnapshot(_tickIndex);
		}
	}

	/// <summary>
	/// One scheduler cycle. Mirrors MidiProcessTick_F000_036F exactly:
	///
	///   add word ptr [011D], tickIncrement  (full 16-bit add to _accumulator)
	///   CheckSongEnd()
	///   for each channel:
	///     wait--; if wait != 0: continue
	///     ProcessChannel(ch) until wait != 0
	///   subdivision--; if 0 -> subdivision = 0x60, measure++
	///
	/// The add sets the HIGH byte of _accumulator, which TickInternal uses
	/// as the countdown to the next ProcessTick. Average PIT ticks between
	/// ProcessTick calls = tickIncrement / 256.
	/// </summary>
	private void ProcessTick() {
		_processTickCount++;
		_accumulator += _tickIncrement;
		CheckSongEnd();

		for (int ch = 0; ch < _activeChannelCount; ch++) {
			// Driver: tickCounter--; if (tickCounter != 0) skip
			_channelWait[ch]--;
			if (_channelWait[ch] != 0) {
				continue;
			}
			// Channel event pointer of 0 means inactive
			if (_channelEventPointer[ch] == 0) {
				continue;
			}
			ProcessChannel(ch);
		}

		AdvanceSubdivision();
	}

	/// <summary>
	/// Processes events for a single channel until a non-zero wait is obtained.
	/// Mirrors MidiProcessChannel: reads 2-byte event word, dispatches, loops.
	///
	/// Event word layout (little-endian):
	///   low byte  = status byte (type in bits 4-6)
	///   high byte = first data byte
	/// </summary>
	private void ProcessChannel(int ch) {
		int safetyLimit = 2000;
		while (safetyLimit-- > 0) {
			ushort pointer = _channelEventPointer[ch];
			if (pointer + 1 >= _songData.Length) {
				_channelWait[ch] = 0xFFFF;
				AddRecentEvent($"ch{ch}: pointer 0x{pointer:X4} past end, parking");
				return;
			}

			// Read event word (2 bytes, little-endian = same as sequential byte read)
			byte statusByte = _songData[pointer];
			byte dataByte = _songData[pointer + 1];
			ushort eventPointerAfterWord = (ushort)(pointer + 2);

			int typeIndex = (statusByte >> 4) & 0x07;
			if (typeIndex >= EventHandlerTable.Length) {
				_channelWait[ch] = 0xFFFF;
				return;
			}

			EventHandlerKind kind = EventHandlerTable[typeIndex];
			ushort nextPointer;

			switch (kind) {
				case EventHandlerKind.ThreeByteWithDelta:
					nextPointer = HandleThreeByteWithDelta(ch, eventPointerAfterWord, statusByte, dataByte);
					break;
				case EventHandlerKind.DeltaOnly:
					nextPointer = HandleDeltaOnly(ch, eventPointerAfterWord);
					break;
				case EventHandlerKind.ThreeByteControlWithDelta:
					nextPointer = HandleControlChangeWithDelta(ch, eventPointerAfterWord, statusByte, dataByte);
					break;
				case EventHandlerKind.TwoByteWithDelta:
					nextPointer = HandleTwoByteWithDelta(ch, eventPointerAfterWord, statusByte, dataByte);
					break;
				case EventHandlerKind.SpecialControlFlow:
					nextPointer = HandleSpecialControl(ch, pointer, statusByte);
					break;
				default:
					_channelWait[ch] = 0xFFFF;
					return;
			}

			_channelEventPointer[ch] = nextPointer;

			if (_channelWait[ch] != 0) {
				return;
			}
		}
	}

	/// <summary>
	/// 3-byte MIDI + VLQ delta. Mirrors MidiHandleThreeByteEventWithDelta.
	/// SI points past the event word. Read data2, then VLQ delta.
	/// Layout: [status, data1] (already read) | data2 | VLQ delta
	/// </summary>
	private ushort HandleThreeByteWithDelta(int ch, ushort si, byte statusByte, byte dataByte) {
		if (si >= _songData.Length) {
			_channelWait[ch] = 0xFFFF;
			return si;
		}
		byte data2 = _songData[si];
		si++;
		ushort delta = ReadVariableLengthDelta(ref si);
		_channelWait[ch] = delta;

		int midiCh3B = statusByte & 0x0F;
		_synth.SendMidi3(statusByte, dataByte, data2);
		TrackMidi(statusByte, dataByte, data2, true);
		RecordGoldenCaptureEvent("tick", "3byte", statusByte, dataByte, data2, true, ch, 3, delta);
		_lastEventPerChannel[Math.Min(midiCh3B, _lastEventPerChannel.Length - 1)] = $"3B {statusByte:X2} {dataByte:X2} {data2:X2} d={delta}";
		EmitEventFlow(midiCh3B, "3B", $"{statusByte:X2} {dataByte:X2} {data2:X2}", delta, si);
		return si;
	}

	/// <summary>
	/// Delta-only event (type 2). SI points past event word. Read VLQ delta.
	/// Mirrors MidiDispatchEvent -> MidiReadVariableLengthDeltaInternal for type 2.
	/// </summary>
	private ushort HandleDeltaOnly(int ch, ushort si) {
		ushort delta = ReadVariableLengthDelta(ref si);
		_channelWait[ch] = delta;

		RecordGoldenCaptureEvent("tick", "delta-only", 0, 0, 0, false, ch, -1, delta);
		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"DO d={delta}";
		EmitEventFlow(ch, "DO", "", delta, si);
		return si;
	}

	/// <summary>
	/// Control change with volume scaling (type 3). Mirrors MidiHandleControlChangeEventWithDelta.
	/// Layout: [status(0x3n), cc] (event word) | value | VLQ delta
	/// The real MIDI status is 0xBn (control change).
	/// </summary>
	private ushort HandleControlChangeWithDelta(int ch, ushort si, byte statusByte, byte cc) {
		if (si >= _songData.Length) {
			_channelWait[ch] = 0xFFFF;
			return si;
		}
		byte value = _songData[si];
		si++;
		ushort delta = ReadVariableLengthDelta(ref si);
		_channelWait[ch] = delta;

		// CC7 volume scaling
		if (cc == 0x07) {
			int channelIndex = statusByte & 0x0F;
			if (channelIndex < _channelBaseVolume.Length) {
				_channelBaseVolume[channelIndex] = value;
			}
			value = (byte)((_currentVolume * value) >> 8);
		}

		// Remap type-3 status (0x3n) to real MIDI CC (0xBn)
		byte realStatus = (byte)(0xB0 | (statusByte & 0x0F));
		_synth.SendMidi3(realStatus, cc, value);
		TrackMidi(realStatus, cc, value, true);
		int midiChCC = statusByte & 0x0F;
		RecordGoldenCaptureEvent("tick", "cc", realStatus, cc, value, true, ch, 3, delta);
		_lastEventPerChannel[Math.Min(midiChCC, _lastEventPerChannel.Length - 1)] = $"CC {realStatus:X2} cc={cc:X2} v={value:X2} d={delta}";
		EmitEventFlow(midiChCC, "CC", $"{realStatus:X2} cc={cc:X2} v={value:X2}", delta, si);
		return si;
	}

	/// <summary>
	/// 2-byte MIDI + VLQ delta. Mirrors MidiHandleTwoByteEventWithDelta.
	/// Event word already contains status + data1. Just read VLQ delta.
	/// </summary>
	private ushort HandleTwoByteWithDelta(int ch, ushort si, byte statusByte, byte dataByte) {
		ushort delta = ReadVariableLengthDelta(ref si);
		_channelWait[ch] = delta;

		int midiCh2B = statusByte & 0x0F;
		_synth.SendMidi2(statusByte, dataByte);
		TrackMidi(statusByte, dataByte, 0, false);
		RecordGoldenCaptureEvent("tick", "2byte", statusByte, dataByte, 0, false, ch, 2, delta);
		_lastEventPerChannel[Math.Min(midiCh2B, _lastEventPerChannel.Length - 1)] = $"2B {statusByte:X2} {dataByte:X2} d={delta}";
		EmitEventFlow(midiCh2B, "2B", $"{statusByte:X2} {dataByte:X2}", delta, si);
		return si;
	}

	/// <summary>
	/// Special control-flow event (type 7). Mirrors MidiHandleSpecialControlEvent.
	///
	/// The driver always:
	///   1. Parks the channel (wait = 0xFFFF)
	///   2. Backs up event pointer by 2 (to re-point at the event word)
	///   3. Only for channel 0: tick flag management, scheduler reset, CheckSongEnd
	///
	/// In the standalone player, we simplify the tick flag logic since we
	/// control the entire playback loop (no shared common code state).
	/// </summary>
	private ushort HandleSpecialControl(int ch, ushort pointer, byte statusByte) {
		// Park channel
		_channelWait[ch] = 0xFFFF;

		RecordGoldenCaptureEvent("tick", "special", statusByte, 0, 0, false, ch, 7, 0xFFFF);
		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = "SPECIAL";
		AddRecentEvent($"ch{ch}: special control 0x{statusByte:X2}");
		EmitEventFlow(ch, "SPEC", $"0x{statusByte:X2}", 0xFFFF, pointer);

		// Only channel 0 does tick flag management
		if (ch != 0) {
			// Pointer stays at event word (backup = return same pointer)
			return pointer;
		}

		// Channel 0: tick flag management (mirrors driver)
		_tickFlag--;
		if (_tickFlag == 0) {
			// Park all channels and stop
			for (int i = 0; i < 9; i++) {
				_channelWait[i] = 0xFFFF;
			}
			_statusFlags = (byte)(_statusFlags & 0x7F);
			SendAllNotesOff();
			EmitLog("Special control: tickFlag reached 0, stopping.");
			return pointer;
		}
		if ((_tickFlag & 0x80) != 0) {
			_tickFlag++;
		}

		// Reset scheduler and re-check song end
		ResetSchedulerState();
		CheckSongEnd();

		// After reset, decrement channel 0 wait by 1 (driver does [DI] = [DI] - 1)
		if (_channelWait[0] > 0) {
			_channelWait[0]--;
		}

		return pointer;
	}

	/// <summary>
	/// Builds the channel pointer table and reads initial deltas.
	/// Mirrors MidiBuildChannelTable_F000_02AE + MidiBuildChannelOffsets + MidiInitChannelDeltas.
	///
	/// Channel offsets are read from songDataOffset (byte 2) and are relative to songDataOffset.
	/// So absolute position in file = SongDataOffset + channelOffset.
	///
	/// After building offsets, reads the first VLQ delta for each active channel
	/// (the delta is at the start of each channel's event stream) and stores
	/// the result + 1 as the initial wait counter.
	/// </summary>
	private void BuildChannelTable() {
		_activeChannelCount = 0;
		_measure = 1;
		_subdivision = 0x60;

		// Phase 1: Build channel offsets (MidiBuildChannelOffsets)
		// Channel offsets at songDataOffset + 0, +2, +4 ... +16
		// Also populates _channelStartOffset[] for ResetSchedulerState to re-read.
		for (int i = 0; i < 9; i++) {
			ushort channelOffset = ReadU16(SongDataOffset + i * 2);
			_channelWait[i] = 0xFFFF;
			_channelEventPointer[i] = 0;
			_channelStartOffset[i] = 0;
			_snapshotWait[i] = 0;
			_snapshotPointer[i] = 0;
			_channelBaseVolume[i] = 0x60;

			if (channelOffset != 0) {
				_activeChannelCount++;
				ushort absOffset = (ushort)(SongDataOffset + channelOffset);
				_channelEventPointer[_activeChannelCount - 1] = absOffset;
				_channelStartOffset[_activeChannelCount - 1] = absOffset;
			}
		}

		// Phase 2: Read initial deltas for each active channel (MidiInitChannelDeltas)
		InitChannelDeltas();
	}

	/// <summary>
	/// Reads initial VLQ deltas for all 9 channel slots from _channelStartOffset.
	/// Mirrors MidiInitChannelDeltas at 02E0..030E: for each channel, reads
	/// the start offset from the offset table, resets wait to 0xFFFF, then
	/// if active reads VLQ delta and sets wait = delta + 1.
	/// </summary>
	private void InitChannelDeltas() {
		for (int i = 0; i < 9; i++) {
			ushort startOffset = _channelStartOffset[i];
			_channelEventPointer[i] = startOffset;
			_channelWait[i] = 0xFFFF;

			if (startOffset != 0) {
				ushort si = startOffset;
				ushort delta = ReadVariableLengthDelta(ref si);
				_channelWait[i] = (ushort)(delta + 1);
				_channelEventPointer[i] = si;
			}
		}
	}

	/// <summary>
	/// Resets measure and subdivision, then re-initializes all channel deltas
	/// from stored start offsets. Mirrors MidiResetSchedulerStateInternal at
	/// 02E0: sets measure=1, subdivision=0x60, then calls MidiInitChannelDeltas
	/// which re-reads channel offsets from the offset table and decodes fresh
	/// VLQ deltas for each active channel.
	/// </summary>
	private void ResetSchedulerState() {
		_measure = 1;
		_subdivision = 0x60;
		InitChannelDeltas();
	}

	/// <summary>
	/// Checks song end boundary and handles loop/repeat bookkeeping.
	/// Mirrors MidiCheckSongEndInternal_F000_03C7 exactly.
	///
	/// When repeatCounter == 0:
	///   if measure == endMeasure AND subdivision == 0x60:
	///     take snapshot, repeatCounter = loopRepeat - 1
	///
	/// When repeatCounter > 0:
	///   if measure == loopMeasure:
	///     repeatCounter--, restore snapshot, measure = endMeasure
	/// </summary>
	private void CheckSongEnd() {
		if (_repeatCounter == 0) {
			// Check if we've reached the end measure at subdivision 0x60
			if (_measure != _endMeasure) {
				return;
			}
			if (_subdivision != 0x60) {
				return;
			}
			// Take snapshot of channel state (0x12 words = 9 wait + 9 pointer)
			for (int i = 0; i < 9; i++) {
				_snapshotWait[i] = _channelWait[i];
				_snapshotPointer[i] = _channelEventPointer[i];
			}
			// Set repeat counter = loopRepeat - 1
			_repeatCounter = (ushort)(_loopRepeat - 1);
			EmitLog($"Song end reached: took snapshot, repeat={_repeatCounter}");
			return;
		}

		// repeatCounter > 0: check if we've reached the loop point
		if (_measure != _loopMeasure) {
			return;
		}
		_repeatCounter--;
		// Restore channel state from snapshot
		for (int i = 0; i < 9; i++) {
			_channelWait[i] = _snapshotWait[i];
			_channelEventPointer[i] = _snapshotPointer[i];
		}
		// Set measure to endMeasure (driver reads from song header)
		_measure = _endMeasure;
		EmitLog($"Loop: restored snapshot, measure={_measure}, repeat={_repeatCounter}");
	}

	/// <summary>
	/// Advances subdivision counter. Mirrors MidiAdvanceSubdivision exactly:
	///   subdivision--
	///   if (subdivision == 0): subdivision = 0x60, measure++
	/// Note: decrement FIRST, then check.
	/// </summary>
	private void AdvanceSubdivision() {
		_subdivision--;
		if (_subdivision == 0) {
			_subdivision = 0x60;
			_measure++;
		}
	}

	/// <summary>
	/// Reads a variable-length delta from the song stream.
	/// Standard MIDI VLQ format matching MidiReadVariableLengthDeltaInternal_F000_049B.
	///
	/// Algorithm: result = 0; loop { b = read(); result = (result << 7) | (b & 0x7F); if !(b & 0x80) break; }
	/// </summary>
	private ushort ReadVariableLengthDelta(ref ushort pos) {
		ushort result = 0;
		while (pos < _songData.Length) {
			byte b = _songData[pos++];
			result = (ushort)((result << 7) | (b & 0x7F));
			if ((b & 0x80) == 0) {
				break;
			}
			// Overflow guard
			if (result > 0x3FFF) {
				result = 0xFFFF;
				break;
			}
		}
		return result;
	}

	/// <summary>
	/// Fade toward target volume by +-3 per fade tick.
	/// Mirrors MidiHandleFade_F000_04D7.
	/// </summary>
	private void HandleFade() {
		int diff = _targetVolume - _currentVolume;
		if (diff == 0) {
			return;
		}
		if (Math.Abs(diff) <= 3) {
			_currentVolume = _targetVolume;
		} else {
			_currentVolume = (byte)(_currentVolume + (diff > 0 ? 3 : -3));
		}
		for (int channel = 0; channel < 10; channel++) {
			byte scaled = (byte)((_currentVolume * _channelBaseVolume[channel]) >> 8);
			_synth.SendMidi3((byte)(0xB0 + channel), 0x07, scaled);
		}
	}

	/// <summary>
	/// Sends CC 0x7B (All Notes Off) + pitch bend center to all 10 channels.
	/// Mirrors MidiEnterUartMode_F000_052F.
	/// </summary>
	private void EnterUartMode() {
		for (int channel = 0; channel < 10; channel++) {
			_synth.SendMidi3((byte)(0xB0 + channel), 0x7B, 0x00);
			_synth.SendMidi3((byte)(0xE0 + channel), 0x00, 0x40);
			_channelBaseVolume[channel] = 0x7F;
		}
	}

	/// <summary>
	/// Sends CC 0x7B + pitch bend center to silence all channels.
	/// </summary>
	private void SendAllNotesOff() {
		for (int channel = 0; channel < 10; channel++) {
			_synth.SendMidi3((byte)(0xB0 + channel), 0x7B, 0x00);
			_synth.SendMidi3((byte)(0xE0 + channel), 0x00, 0x40);
		}
	}

	/// <summary>
	/// Emits a live event flow entry to the UI for the event flow panel.
	/// </summary>
	private void EmitEventFlow(int ch, string kind, string detail, ushort delta, ushort pointer) {
		EventFlowProduced?.Invoke(new EventFlowEntry {
			TickIndex = _tickIndex,
			Channel = ch,
			Kind = kind,
			Detail = detail,
			Delta = delta,
			Pointer = pointer,
			Measure = _measure,
			Subdivision = _subdivision
		});
	}
}