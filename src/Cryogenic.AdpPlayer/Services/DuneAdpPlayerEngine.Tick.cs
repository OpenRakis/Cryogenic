namespace Cryogenic.AdpPlayer.Services;

/// <summary>
/// Tick/timer, channel processing, event dispatch, and all DNADP OPL2 event handlers.
/// Faithfully mirrors DNADP routines decoded from the driver at segment 5BAE.
///
/// DNADP event handler table (CS:0125, 8 entries by bits 4-6):
///   0 (0x8x)  Note Off          at 0x065B
///   1 (0x9x)  Note On           at 0x062C
///   2 (0xAx)  Wait/Delta        at 0x08E1
///   3 (0xBx)  Wait/Delta (same) at 0x08E1
///   4 (0xCx)  Program Change    at 0x05AA
///   5 (0xDx)  Volume Mod        at 0x06A8
///   6 (0xEx)  Pitch Bend        at 0x07EA
///   7 (0xFx)  End of Track      at 0x066F
///
/// Timing model is identical to DNMID: PIT IRQ0 at ~200 Hz (reload 0x1745),
/// accumulator high-byte countdown, 0x60 subdivisions per measure.
/// </summary>
public sealed partial class DuneAdpPlayerEngine {
	private int _tickIndex;

	private int _advanceSamplesCallCount;

	/// <summary>
	/// Called from the audio render callback with the number of audio frames
	/// about to be rendered. Advances the PIT tick accumulator and fires
	/// TickInternal at the correct rate relative to the sample clock.
	///
	///   samplesPerTick = SampleRate * PitReloadValue / PitInputClock
	///                  = 48000 * 5957 / 1193182 ~ 239.8
	/// </summary>
	public void AdvanceSamples(int frameCount) {
		if (!_isPlaying) {
			return;
		}
		_advanceSamplesCallCount++;
		if (_advanceSamplesCallCount <= 5 || (_advanceSamplesCallCount % 500) == 0) {
			_synth.LogDebug($"AdvanceSamples #{_advanceSamplesCallCount}: frames={frameCount} accum={_sampleAccumulator} threshold={SamplesPerTickThreshold} tickIdx={_tickIndex} status=0x{_statusFlags:X2}");
		}
		_sampleAccumulator += (long)frameCount * PitInputClock;
		int ticksThisCall = 0;
		while (_sampleAccumulator >= SamplesPerTickThreshold) {
			_sampleAccumulator -= SamplesPerTickThreshold;
			TickInternal();
			ticksThisCall++;
		}
		if (_advanceSamplesCallCount <= 5 || (_advanceSamplesCallCount % 500) == 0) {
			_synth.LogDebug($"AdvanceSamples #{_advanceSamplesCallCount} done: ticks={ticksThisCall} tickIdx={_tickIndex} measure={_measure}/{_endMeasure} sub={_subdivision}");
		}

		// Compute and report peak/waveform after advancing ticks.
		float peak = EstimatePeakFromChannelState();
		_synth.NotifyPeak(peak);
		NotifyWaveformFromPeak(peak, frameCount);
	}

	/// <summary>
	/// Estimates audio peak amplitude (0..1) from the current OPL channel state.
	/// Uses per-channel note-on/off and volume (0x3F total-level) to approximate
	/// the instantaneous output level without reading actual audio samples.
	/// </summary>
	private float EstimatePeakFromChannelState() {
		float maxLevel = 0f;
		for (int ch = 0; ch < _activeChannelCount; ch++) {
			if (_channelNote[ch] == 0) {
				continue;
			}
			// OPL total level is inverted: 0 = max volume, 0x3F = silence.
			// Channel volume from DNADP is 0..0x3F in the song data.
			byte vol = _channelVolume[ch];
			float normalized = 1.0f - (vol / 63.0f);
			if (normalized > maxLevel) {
				maxLevel = normalized;
			}
		}
		// Scale by master volume (0..127 → 0..1).
		float masterScale = _currentVolume / 127.0f;
		return maxLevel * masterScale;
	}

	/// <summary>
	/// Generates a synthetic waveform from the peak envelope and pushes it
	/// to the synth for the waveform display. Produces interleaved stereo
	/// samples with amplitude matching the estimated peak.
	/// </summary>
	private void NotifyWaveformFromPeak(float peak, int frameCount) {
		int sampleCount = frameCount * 2;
		float[] buffer = _waveformBuffer;
		int count = Math.Min(sampleCount, buffer.Length);
		for (int i = 0; i < count; i += 2) {
			buffer[i] = peak;
			buffer[i + 1] = peak;
		}
		_synth.NotifySamples(buffer, count);
	}

	// Shared waveform buffer to avoid per-callback allocation.
	private readonly float[] _waveformBuffer = new float[4096];

	/// <summary>
	/// Called once per PIT tick (~5ms). Mirrors DNADP tick handler:
	///
	///   if (statusFlags &amp; 0x80) == 0: return
	///   dec byte [accumulator high byte]
	///   if (highByte &amp; 0x80) != 0: ProcessTick()
	///   rol fadeBitPattern, 1
	///   if carry: HandleFade()
	/// </summary>
	private void TickInternal() {
		if ((_statusFlags & 0x80) == 0) {
			return;
		}
		_tickIndex++;

		// dec byte ptr [accumHi] — decrement ONLY the high byte
		byte hiByte = (byte)(_accumulator >> 8);
		hiByte--;
		_accumulator = (ushort)((hiByte << 8) | (_accumulator & 0xFF));

		// jns skip — if high byte went negative (bit7 set), call ProcessTick
		if ((hiByte & 0x80) != 0) {
			ProcessTick();
		}

		// rol word [fadeBitPattern], 1; jnb skip
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
	/// One scheduler cycle. Mirrors DNADP ProcessTick at 0x04D3:
	///
	///   add word [accumulator], tickIncrement
	///   CheckSongEnd()
	///   for each channel: wait--; if wait != 0 continue; ProcessChannel(ch) until wait != 0
	///   subdivision--; if 0 -> subdivision = 0x60, measure++
	/// </summary>
	private void ProcessTick() {
		_processTickCount++;
		_accumulator += _tickIncrement;
		CheckSongEnd();

		for (int ch = 0; ch < _activeChannelCount; ch++) {
			_channelWait[ch]--;
			if (_channelWait[ch] != 0) {
				continue;
			}
			if (_channelEventPointer[ch] == 0) {
				continue;
			}
			ProcessChannel(ch);
		}

		AdvanceSubdivision();
	}

	/// <summary>
	/// Processes events for a single channel until a non-zero wait is obtained.
	/// DNADP dispatch: read event byte, extract bits 4-6 for handler class,
	/// dispatch to handler. Handler reads data + calls wait decoder (0x08E1).
	/// Loop if wait is zero (multiple events per tick).
	/// </summary>
	private void ProcessChannel(int ch) {
		int safetyLimit = 2000;
		while (safetyLimit-- > 0) {
			ushort pointer = _channelEventPointer[ch];
			if (pointer >= _songData.Length) {
				_channelWait[ch] = 0xFFFF;
				AddRecentEvent($"ch{ch}: pointer 0x{pointer:X4} past end, parking");
				return;
			}

			byte eventByte = _songData[pointer];
			_channelEventPointer[ch] = (ushort)(pointer + 1);

			int handlerClass = (eventByte >> 4) & 0x07;

			switch (handlerClass) {
				case 0: // Note Off (0x8x)
					HandleNoteOff(ch);
					break;
				case 1: // Note On (0x9x)
					HandleNoteOn(ch);
					break;
				case 2: // Wait (0xAx)
				case 3: // Wait (0xBx) — same handler
					HandleWait(ch);
					break;
				case 4: // Program Change (0xCx)
					HandleProgramChange(ch);
					break;
				case 5: // Volume Modulation (0xDx)
					HandleVolumeModulation(ch);
					break;
				case 6: // Pitch Bend (0xEx)
					HandlePitchBend(ch);
					break;
				case 7: // End of Track (0xFx)
					HandleEndOfTrack(ch);
					return;
			}

			if (_channelWait[ch] != 0) {
				return;
			}
		}
	}

	/// <summary>
	/// Note Off handler (class 0, 0x8x). Mirrors 0x065B:
	/// Clears key-on bit for the channel, then reads wait.
	/// </summary>
	private void HandleNoteOff(int ch) {
		OplNoteOff(ch);
		_channelNote[ch] = 0;

		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

		RecordGoldenCaptureEvent("tick", "NOF", 0, 0, (byte)ch, "NOF", ch, delta);
		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"NOF d={delta}";
		EmitEventFlow(ch, "NOF", "", delta, _channelEventPointer[ch]);
	}

	/// <summary>
	/// Note On handler (class 1, 0x9x). Mirrors 0x062C:
	/// 1. Read note byte from stream
	/// 2. If note already playing, do note-off first
	/// 3. Store note, add transpose, compute freq, write OPL registers
	/// 4. Read wait
	/// </summary>
	private void HandleNoteOn(int ch) {
		ushort pointer = _channelEventPointer[ch];
		if (pointer >= _songData.Length) {
			_channelWait[ch] = 0xFFFF;
			return;
		}
		byte note = _songData[pointer];
		_channelEventPointer[ch] = (ushort)(pointer + 1);

		// If a note is already sounding on this channel, turn it off first
		if (_channelNote[ch] != 0) {
			OplNoteOff(ch);
		}

		_channelNote[ch] = note;
		OplNoteOn(ch, note);

		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

		RecordGoldenCaptureEvent("tick", "NON", note, 0, (byte)ch, "NON", ch, delta);
		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"NON n={note} d={delta}";
		EmitEventFlow(ch, "NON", $"n={note}", delta, _channelEventPointer[ch]);
	}

	/// <summary>
	/// Wait handler (class 2/3, 0xAx/0xBx). Mirrors 0x08E1:
	/// Pure delta — no side effects, just reads the next wait value.
	/// </summary>
	private void HandleWait(int ch) {
		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

		RecordGoldenCaptureEvent("tick", "DO", 0, 0, (byte)ch, "DO", ch, delta);
		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"DO d={delta}";
		EmitEventFlow(ch, "DO", "", delta, _channelEventPointer[ch]);
	}

	/// <summary>
	/// Program Change handler (class 4, 0xCx). Mirrors 0x05AA:
	/// Reads instrument number, loads 40-byte instrument definition into OPL registers.
	/// </summary>
	private void HandleProgramChange(int ch) {
		ushort pointer = _channelEventPointer[ch];
		if (pointer >= _songData.Length) {
			_channelWait[ch] = 0xFFFF;
			return;
		}
		byte instrument = _songData[pointer];
		_channelEventPointer[ch] = (ushort)(pointer + 1);

		_channelInstrument[ch] = instrument;
		OplWriteInstrument(ch, instrument);

		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

		RecordGoldenCaptureEvent("tick", "PRG", instrument, 0, (byte)ch, "PRG", ch, delta);
		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"PRG i={instrument} d={delta}";
		EmitEventFlow(ch, "PRG", $"i={instrument}", delta, _channelEventPointer[ch]);
	}

	/// <summary>
	/// Volume/Envelope Modulation handler (class 5, 0xDx). Mirrors 0x06A8:
	/// Reads volume byte, updates carrier operator total level.
	/// </summary>
	private void HandleVolumeModulation(int ch) {
		ushort pointer = _channelEventPointer[ch];
		if (pointer >= _songData.Length) {
			_channelWait[ch] = 0xFFFF;
			return;
		}
		byte volume = _songData[pointer];
		_channelEventPointer[ch] = (ushort)(pointer + 1);

		_channelVolume[ch] = volume;
		OplSetVolume(ch, volume);

		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

		RecordGoldenCaptureEvent("tick", "VOL", volume, 0, (byte)ch, "VOL", ch, delta);
		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"VOL v={volume} d={delta}";
		EmitEventFlow(ch, "VOL", $"v={volume}", delta, _channelEventPointer[ch]);
	}

	/// <summary>
	/// Pitch Bend handler (class 6, 0xEx). Mirrors 0x07EA:
	/// Reads pitch bend value, adjusts frequency registers.
	/// </summary>
	private void HandlePitchBend(int ch) {
		ushort pointer = _channelEventPointer[ch];
		if (pointer >= _songData.Length) {
			_channelWait[ch] = 0xFFFF;
			return;
		}
		byte pitchBend = _songData[pointer];
		_channelEventPointer[ch] = (ushort)(pointer + 1);

		OplPitchBend(ch, pitchBend);

		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

		RecordGoldenCaptureEvent("tick", "PB", pitchBend, 0, (byte)ch, "PB", ch, delta);
		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"PB pb={pitchBend} d={delta}";
		EmitEventFlow(ch, "PB", $"pb={pitchBend}", delta, _channelEventPointer[ch]);
	}

	/// <summary>
	/// End of Track handler (class 7, 0xFx). Mirrors 0x066F:
	/// Parks the channel with wait = 0xFFFF.
	/// For channel 0: handles tick flag management and song looping.
	/// </summary>
	private void HandleEndOfTrack(int ch) {
		_channelWait[ch] = 0xFFFF;

		RecordGoldenCaptureEvent("tick", "EOT", 0, 0, (byte)ch, "EOT", ch, 0xFFFF);
		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = "EOT";
		AddRecentEvent($"ch{ch}: EOT");
		EmitEventFlow(ch, "EOT", "", 0xFFFF, _channelEventPointer[ch]);

		if (ch != 0) {
			return;
		}

		// Channel 0: tick flag management (mirrors driver at 0x066F)
		_tickFlag--;
		if (_tickFlag == 0) {
			for (int i = 0; i < 9; i++) {
				_channelWait[i] = 0xFFFF;
			}
			_statusFlags = (byte)(_statusFlags & 0x7F);
			AllNotesOff();
			_isPlaying = false;
			_synth.OnBeforeRender = null;
			EmitLog("EOT: tickFlag reached 0, stopping.");
			return;
		}
		if ((_tickFlag & 0x80) != 0) {
			_tickFlag++;
		}

		// Reset scheduler and re-check song end
		ResetSchedulerState();
		CheckSongEnd();

		if (_channelWait[0] > 0) {
			_channelWait[0]--;
		}
	}

	/// <summary>
	/// Reads a variable-length wait/delta value from the channel event stream.
	/// Mirrors the DNADP wait decoder at 0x08E1.
	///
	/// Uses standard VLQ encoding (same as DNMID) since both share
	/// the same song container format.
	/// </summary>
	private ushort ReadWaitValue(int ch) {
		ushort pos = _channelEventPointer[ch];
		ushort result = 0;
		while (pos < _songData.Length) {
			byte b = _songData[pos++];
			result = (ushort)((result << 7) | (b & 0x7F));
			if ((b & 0x80) == 0) {
				break;
			}
			if (result > 0x3FFF) {
				result = 0xFFFF;
				break;
			}
		}
		_channelEventPointer[ch] = pos;
		return result;
	}

	/// <summary>
	/// Builds channel pointer table and reads initial deltas.
	/// Mirrors MidiBuildChannelTable: channel offsets at songDataOffset[0..16],
	/// relative to songDataOffset. Then reads first VLQ delta for each active channel.
	/// </summary>
	private void BuildChannelTable() {
		_activeChannelCount = 0;
		_measure = 1;
		_subdivision = 0x60;

		for (int i = 0; i < 9; i++) {
			ushort channelOffset = ReadU16(SongDataOffset + i * 2);
			_channelWait[i] = 0xFFFF;
			_channelEventPointer[i] = 0;
			_channelStartOffset[i] = 0;
			_snapshotWait[i] = 0;
			_snapshotPointer[i] = 0;
			_channelVolume[i] = 0x3F;
			_channelNote[i] = 0;
			_channelTranspose[i] = 0;
			_channelInstrument[i] = 0;
			_channelStoredFreq[i] = 0;

			if (channelOffset != 0) {
				_activeChannelCount++;
				ushort absOffset = (ushort)(SongDataOffset + channelOffset);
				_channelEventPointer[_activeChannelCount - 1] = absOffset;
				_channelStartOffset[_activeChannelCount - 1] = absOffset;
			}
		}

		InitChannelDeltas();
	}

	/// <summary>
	/// Reads initial VLQ deltas for all 9 channel slots from _channelStartOffset.
	/// wait = delta + 1 on first load.
	/// </summary>
	private void InitChannelDeltas() {
		for (int i = 0; i < 9; i++) {
			ushort startOffset = _channelStartOffset[i];
			_channelEventPointer[i] = startOffset;
			_channelWait[i] = 0xFFFF;

			if (startOffset != 0) {
				ushort pos = startOffset;
				ushort result = 0;
				while (pos < _songData.Length) {
					byte b = _songData[pos++];
					result = (ushort)((result << 7) | (b & 0x7F));
					if ((b & 0x80) == 0) { break; }
					if (result > 0x3FFF) { result = 0xFFFF; break; }
				}
				_channelWait[i] = (ushort)(result + 1);
				_channelEventPointer[i] = pos;
			}
		}
	}

	/// <summary>
	/// Resets measure/subdivision and re-initializes channel deltas from start offsets.
	/// </summary>
	private void ResetSchedulerState() {
		_measure = 1;
		_subdivision = 0x60;
		InitChannelDeltas();
	}

	/// <summary>
	/// Checks song end boundary and handles loop/repeat bookkeeping.
	/// Identical to DNMID: endMeasure triggers snapshot, loopMeasure triggers restore.
	/// </summary>
	private void CheckSongEnd() {
		if (_repeatCounter == 0) {
			if (_measure != _endMeasure || _subdivision != 0x60) {
				return;
			}
			for (int i = 0; i < 9; i++) {
				_snapshotWait[i] = _channelWait[i];
				_snapshotPointer[i] = _channelEventPointer[i];
			}
			_repeatCounter = (ushort)(_loopRepeat - 1);
			EmitLog($"Song end reached: took snapshot, repeat={_repeatCounter}");
			return;
		}

		if (_measure != _loopMeasure) {
			return;
		}
		_repeatCounter--;
		for (int i = 0; i < 9; i++) {
			_channelWait[i] = _snapshotWait[i];
			_channelEventPointer[i] = _snapshotPointer[i];
		}
		_measure = _endMeasure;
		EmitLog($"Loop: restored snapshot, measure={_measure}, repeat={_repeatCounter}");
	}

	/// <summary>
	/// Advances subdivision counter: dec first, then check == 0.
	/// </summary>
	private void AdvanceSubdivision() {
		_subdivision--;
		if (_subdivision == 0) {
			_subdivision = 0x60;
			_measure++;
		}
	}

	/// <summary>
	/// Fade toward target volume by +-3 per fade tick.
	/// For OPL2: adjusts _currentVolume and re-applies carrier total level
	/// for all active channels.
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
		// Re-apply volume to all active channels via carrier total level
		for (int ch = 0; ch < _activeChannelCount; ch++) {
			OplSetVolume(ch, _channelVolume[ch]);
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