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
	private int _instrumentLoadCount;
	private int _noteOnCount;

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
			// DNADP volume from song data: 0 = silent, 0x7F = loudest.
			byte vol = _channelVolume[ch];
			float normalized = vol / 127.0f;
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
			if (_channelWait[ch] == 0xFFFF) {
				continue;
			}
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
	/// DNADP dispatch: read event word (LODSW), extract bits 4-6 from low byte,
	/// dispatch to handler with high byte as payload. Handler then calls wait decoder.
	/// Loop if wait is zero (multiple events per tick).
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

			ushort eventWord = (ushort)(_songData[pointer] | (_songData[pointer + 1] << 8));
			_channelEventPointer[ch] = (ushort)(pointer + 2);
			byte eventLow = (byte)(eventWord & 0xFF);
			byte eventData = (byte)(eventWord >> 8);

			int handlerClass = (eventLow >> 4) & 0x07;

			switch (handlerClass) {
				case 0: // Note Off (0x8x)
					HandleNoteOff(ch, eventData);
					break;
				case 1: // Note On (0x9x)
					HandleNoteOn(ch, eventData);
					break;
				case 2: // Wait (0xAx)
				case 3: // Wait (0xBx) — same handler
					HandleWait(ch, eventData);
					break;
				case 4: // Program Change (0xCx)
					HandleProgramChange(ch, eventData);
					break;
				case 5: // Volume Modulation (0xDx)
					HandleVolumeModulation(ch, eventData);
					break;
				case 6: // Pitch Bend (0xEx)
					HandlePitchBend(ch, eventData);
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
	private void HandleNoteOff(int ch, byte noteData) {
		SkipChannelBytes(ch, 1);
		if (_channelWait[ch] == 0xFFFF) {
			return;
		}
		byte noteWithTranspose = (byte)(noteData + _channelTranspose[ch]);
		if (_channelNote[ch] == noteWithTranspose) {
			OplNoteOff(ch);
			_channelNote[ch] = 0;
		}

		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

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
	private void HandleNoteOn(int ch, byte noteData) {
		byte noteOnShapeByte;
		if (!TryReadAndSkipChannelByte(ch, out noteOnShapeByte)) {
			return;
		}
		ApplyNoteOnShaping0740(ch, noteOnShapeByte);
		byte note = (byte)(noteData + _channelTranspose[ch]);

		// If a note is already sounding on this channel, turn it off first
		if (_channelNote[ch] != 0) {
			OplNoteOff(ch);
		}

		_channelNote[ch] = note;

		// Log first note-ons with full OPL context
		if (_noteOnCount < 20) {
			int adjusted = note - 0x18;
			if (adjusted < 0 || adjusted >= 96) {
				adjusted = 0;
			}
			int octave = adjusted / 12;
			int semitone = adjusted % 12;
			ushort fnum = FrequencyTable[semitone];
			EmitLog($"NON ch{ch} note={note} trans={_channelTranspose[ch]} adj={adjusted} " +
				$"oct={octave} semi={semitone} fnum=0x{fnum:X3} " +
				$"inst={_channelInstrument[ch]} vol={_channelVolume[ch]} masterVol={_currentVolume}");
			_noteOnCount++;
		}

		OplNoteOn(ch, note);

		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"NON n={note} d={delta}";
		EmitEventFlow(ch, "NON", $"n={note}", delta, _channelEventPointer[ch]);
	}

	/// <summary>
	/// Wait handler (class 2/3, 0xAx/0xBx). Mirrors 0x08E1:
	/// Pure delta — no side effects, just reads the next wait value.
	/// </summary>
	private void HandleWait(int ch, byte waitSeed) {
		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"DO d={delta}";
		EmitEventFlow(ch, "DO", "", delta, _channelEventPointer[ch]);
	}

	/// <summary>
	/// Program Change handler (class 4, 0xCx). Mirrors 0x05AA:
	/// Reads instrument number, loads 40-byte instrument definition into OPL registers.
	/// </summary>
	private void HandleProgramChange(int ch, byte instrument) {

		_channelInstrument[ch] = instrument;

		// Dump raw instrument bytes for the first few loads to diagnose silence
		if (_instrumentLoadCount < 10) {
			int instOffset = _eventBaseOffset + instrument * 40;
			if (instOffset + 40 <= _songData.Length) {
				byte[] raw = _songData[instOffset..(instOffset + 40)];
				EmitLog($"PRG ch{ch} inst#{instrument} @0x{instOffset:X4}: " +
					$"modKSL=0x{raw[0]:X2} modChar=0x{raw[1]:X2} fb=0x{raw[2]:X2} " +
					$"modAD=0x{raw[3]:X2} modSR=0x{raw[4]:X2} modAMVIB=0x{raw[5]:X2} " +
					$"carAD=0x{raw[6]:X2} carSR=0x{raw[7]:X2} carKSL=0x{raw[8]:X2} " +
					$"carAMVIB=0x{raw[9]:X2} modKSR=0x{raw[0xA]:X2} carMULT=0x{raw[0xB]:X2} " +
					$"conn=0x{raw[0xC]:X2} wfMod=0x{raw[0x1A]:X2} wfCar=0x{raw[0x1B]:X2}");
			} else {
				EmitLog($"PRG ch{ch} inst#{instrument}: INVALID offset 0x{instOffset:X4} (songLen=0x{_songData.Length:X4})");
			}
			_instrumentLoadCount++;
		}

		OplWriteInstrument(ch, instrument);

		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"PRG i={instrument} d={delta}";
		EmitEventFlow(ch, "PRG", $"i={instrument}", delta, _channelEventPointer[ch]);
	}

	/// <summary>
	/// Volume/Envelope Modulation handler (class 5, 0xDx). Mirrors 0x06A8:
	/// Reads volume byte, updates carrier operator total level.
	/// </summary>
	private void HandleVolumeModulation(int ch, byte volumeData) {
		byte volume = (byte)(0x80 - volumeData);

		_channelVolume[ch] = volume;
		ApplyVolumeShaping06A8(ch, volumeData);

		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"VOL v={volume} d={delta}";
		EmitEventFlow(ch, "VOL", $"v={volume}", delta, _channelEventPointer[ch]);
	}

	/// <summary>
	/// Pitch Bend handler (class 6, 0xEx). Mirrors 0x07EA:
	/// Reads pitch bend value, adjusts frequency registers.
	/// </summary>
	private void HandlePitchBend(int ch, byte pitchBend) {

		OplPitchBend(ch, pitchBend);

		ushort delta = ReadWaitValue(ch);
		_channelWait[ch] = delta;

		_lastEventPerChannel[Math.Min(ch, _lastEventPerChannel.Length - 1)] = $"PB pb={pitchBend} d={delta}";
		EmitEventFlow(ch, "PB", $"pb={pitchBend}", delta, _channelEventPointer[ch]);
	}

	private void SkipChannelBytes(int ch, int count) {
		ushort pointer = _channelEventPointer[ch];
		if (pointer + count > _songData.Length) {
			_channelEventPointer[ch] = (ushort)_songData.Length;
			_channelWait[ch] = 0xFFFF;
			return;
		}
		_channelEventPointer[ch] = (ushort)(pointer + count);
	}

	private bool TryReadAndSkipChannelByte(int ch, out byte value) {
		value = 0;
		ushort pointer = _channelEventPointer[ch];
		if (pointer >= _songData.Length) {
			_channelEventPointer[ch] = (ushort)_songData.Length;
			_channelWait[ch] = 0xFFFF;
			return false;
		}
		value = _songData[pointer];
		_channelEventPointer[ch] = (ushort)(pointer + 1);
		return true;
	}

	/// <summary>
	/// End of Track handler (class 7, 0xFx). Mirrors 0x066F:
	/// Parks the channel with wait = 0xFFFF.
	/// For channel 0: handles tick flag management and song looping.
	/// </summary>
	private void HandleEndOfTrack(int ch) {
		_channelWait[ch] = 0xFFFF;
		ushort pointer = _channelEventPointer[ch];
		_channelEventPointer[ch] = pointer >= 2 ? (ushort)(pointer - 2) : (ushort)0;

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

		// Reset scheduler (driver path 0x066F -> 0x019B)
		ResetSchedulerState();

		if (_channelWait[0] > 0 && _channelWait[0] != 0xFFFF) {
			_channelWait[0]--;
		}
	}

	/// <summary>
	/// Reads a wait/delta value from the channel event stream.
	/// Mirrors DNADP decoder 0x08E1.
	///
	/// The driver does: push ax; xor ax,ax; es lodsb — clearing AH before
	/// entering the multi-byte loop. CX is also zeroed. The original AX is
	/// saved/restored across the call (push/pop) and has NO effect on the
	/// wait decode. All state is derived purely from the stream bytes.
	/// </summary>
	private ushort ReadWaitValue(int ch) {
		ushort pos = _channelEventPointer[ch];
		if (pos >= _songData.Length) {
			_channelEventPointer[ch] = (ushort)_songData.Length;
			return 0xFFFF;
		}

		byte first = _songData[pos++];
		if ((first & 0x80) == 0) {
			_channelEventPointer[ch] = pos;
			return first;
		}

		// Multi-byte variable-length encoding.
		// Driver state at entry to loop: AH=0 (from xor ax,ax), CX=0 (from xor cx,cx).
		// Bytes shift through CH←CL←AH←AL until a byte without bit7 is found.
		byte chReg = 0;
		byte clReg = 0;
		byte ahReg = first;
		byte alReg;

		while (true) {
			if (pos >= _songData.Length) {
				_channelEventPointer[ch] = (ushort)_songData.Length;
				return 0xFFFF;
			}

			alReg = _songData[pos++];
			if ((alReg & 0x80) != 0) {
				chReg = clReg;
				clReg = ahReg;
				ahReg = alReg;
				continue;
			}

			ushort ax = (ushort)((ahReg << 8) | alReg);
			ushort cx = (ushort)((chReg << 8) | clReg);
			ax &= 0x7F7F;
			cx &= 0x7F7F;

			cx = (ushort)((cx & 0xFF00) | (((cx & 0x00FF) << 1) & 0x00FF)); // shl cl,1
			cx = (ushort)(cx >> 1); // shr cx,1

			ax = (ushort)((ax & 0xFF00) | (((ax & 0x00FF) << 1) & 0x00FF)); // shl al,1
			ax = (ushort)((ax << 1) & 0xFFFF); // shl ax,1

			int carry = cx & 0x0001;
			cx = (ushort)(cx >> 1); // shr cx,1
			ax = (ushort)(((carry << 15) | (ax >> 1)) & 0xFFFF); // rcr ax,1

			carry = cx & 0x0001;
			cx = (ushort)(cx >> 1); // shr cx,1
			ax = (ushort)(((carry << 15) | (ax >> 1)) & 0xFFFF); // rcr ax,1

			_channelEventPointer[ch] = pos;
			return cx == 0 ? ax : (ushort)0xFFFF;
		}
	}

	/// <summary>
	/// Builds channel pointer table and reads initial deltas.
	/// Mirrors MidiBuildChannelTable: channel offsets at songDataOffset[0..16],
	/// relative to songDataOffset. Then reads first VLQ delta for each active channel.
	/// </summary>
	private void BuildChannelTable() {
		_activeChannelCount = 9;
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
			_channelReg90[i] = 0;
			_channelReg48[i] = 0;
			_channelReg7E[i] = 0;
			_channelRegA2[i] = 0;
			_channelRegC6[i] = 0;
			_channelRegB4[i] = 0;
			_channelRegD8[i] = 0;

			if (channelOffset != 0) {
				ushort absOffset = (ushort)(SongDataOffset + channelOffset);
				_channelEventPointer[i] = absOffset;
				_channelStartOffset[i] = absOffset;
			}
		}

		InitChannelDeltas();
	}

	/// <summary>
	/// Initializes all 9 channel waits and pointers from start offsets.
	/// Mirrors DNADP 0x0444: wait is set via 0x08E1 decode, then incremented by 1.
	/// </summary>
	private void InitChannelDeltas() {
		for (int i = 0; i < 9; i++) {
			ushort startOffset = _channelStartOffset[i];
			_channelEventPointer[i] = startOffset;
			_channelWait[i] = 0xFFFF;

			if (startOffset != 0) {
				ushort delta = ReadWaitValue(i);
				if (delta == 0xFFFF) {
					_channelWait[i] = 0xFFFF;
				} else {
					_channelWait[i] = (ushort)(delta + 1);
				}
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