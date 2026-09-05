namespace Cryogenic.AdgPlayer.Ui.Services;

/// <summary>
/// Tick processing and scheduler-only behavior for the ADG player engine.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
	/// <summary>
	/// Builds the channel table from song header data.
	/// Mirrors AdpBuildChannelTable_0413.
	/// </summary>
	private void BuildChannelTable() {
		for (int i = 0; i < SongHeaderChannelCount; i++) {
			ushort relative = SongWord(_dataBase + i * 2);
			ushort absolute = relative == 0 ? (ushort)0 : (ushort)(relative + _dataBase);
			_channelStartOffset[i] = absolute;
		}
		for (int i = SongHeaderChannelCount; i < ChannelCount; i++) {
			_channelStartOffset[i] = 0;
		}

		for (int i = 0; i < ChannelCount; i++) {
			_channelInstrument[i] = 0xFF;
			_channelCurrentNote[i] = 0x00;
			_channelPitchBendCounter[i] = 0;
			_channelPitchAccumulatorHi[i] = 0;
			_channelPitchTranspose[i] = 0;
			_channelPitchMode[i] = 0;
			_channelPatchType[i] = 0;
			_channelVibratoCount[i] = 0;
			_channelVibratoInit[i] = 0;
			_channelPitchBendFlag[i] = 0;
			_channelPatch4TlShaping[i] = 0;
			_channelPatch4EnvShaping[i] = 0;
			_channelPatch4CurrentOperatorLevel[i] = 0;
			_channelPatch4VolumeModulation[i] = 0;
			_channelRouteScratch[i] = 0;
			_channelRoute[i] = 0;
			_channelPrimaryOpRoute[i] = 0;
			_channelSecondaryOpRoute[i] = 0;
			_channelRouteShadow[i] = 0;
		}

		_fadeScratch = 0;
		_fadeScratch2 = 0;
		_measure = 1;
		_subdivision = 0x60;

		for (int ch = 0; ch < ChannelCount; ch++) {
			ushort ptr = _channelStartOffset[ch];
			_channelEventPointer[ch] = ptr;
			_channelWait[ch] = 0xFFFF;
			if (ptr != 0) {
				ReadWaitValue(ch);
				_channelWait[ch]++;
			}
		}
	}

	/// <summary>
	/// Main tick processing. Adds tempo to accumulator, checks loop points,
	/// and iterates all logical channels dispatching events.
	/// </summary>
	private void ProcessTick() {
		ushort tempoWord = SongWord(_dataBase + 0x30);
		_accumulator = (ushort)(_accumulator + tempoWord);

		LoopPointCheck();

		for (int ch = 0; ch < ChannelCount; ch++) {
			_channelWait[ch]--;

			if (_channelWait[ch] != 0) {
				if (_channelVibratoCount[ch] != 0 && _channelEventPointer[ch] != 0) {
					_channelVibratoCount[ch]--;
					byte phase = _channelVibratoPhase[ch];
					byte speed = _channelVibratoSpeed[ch];
					phase = (byte)(phase + speed);
					_channelVibratoPhase[ch] = phase;
					PitchBendBody(ch, Make16(phase, speed));
				}
			} else {
				while (_channelWait[ch] == 0) {
					ushort si = _channelEventPointer[ch];
					if (si == 0) {
						break;
					}
					ushort eventWord = SongWord16(si);
					_channelEventPointer[ch] = (ushort)(si + 2);
					byte handler = (byte)((eventWord >> 4) & 0x07);

					switch (handler) {
						case 0:
							NoteOff(ch, eventWord);
							break;
						case 1:
							NoteOn(ch, eventWord);
							break;
						case 2:
						case 3:
							ReadWaitValue(ch);
							break;
						case 4:
							ProgramChange(ch, eventWord);
							break;
						case 5:
							VolumeModulation(ch, eventWord);
							break;
						case 6:
							PitchBend(ch, eventWord);
							break;
						case 7:
							EndOfTrack(ch);
							break;
					}
				}
			}
		}

		_subdivision--;
		if (_subdivision == 0) {
			_subdivision = 0x60;
			_measure++;
		}
	}

	/// <summary>
	/// Checks and manages loop snapshot save/restore.
	/// Mirrors AdpLoopPointCheck_0553.
	/// </summary>
	private void LoopPointCheck() {
		if (_repeatCounter == 0) {
			ushort loopStartMeasure = SongWord(_dataBase + 0x2A);
			if (loopStartMeasure == _measure && _subdivision == 0x60) {
				for (int i = 0; i < ChannelCount; i++) {
					_snapshotWait[i] = _channelWait[i];
					_snapshotPointer[i] = _channelEventPointer[i];
				}
				ushort loopCount = SongWord(_dataBase + 0x2E);
				_repeatCounter = (ushort)(loopCount - 1);
			}
		} else {
			ushort loopEndMeasure = SongWord(_dataBase + 0x2C);
			if (loopEndMeasure == _measure) {
				_repeatCounter--;
				for (int i = 0; i < ChannelCount; i++) {
					_channelWait[i] = _snapshotWait[i];
					_channelEventPointer[i] = _snapshotPointer[i];
				}
				_measure = SongWord(_dataBase + 0x2A);
			}
		}
	}

	/// <summary>
	/// FadeStep: approaches target volume one nibble increment at a time.
	/// Mirrors AdpFadeStep_092D.
	/// </summary>
	private void FadeStep() {
		byte current = _currentVolume;
		byte target = _targetVolume;

		if (current == target) {
			_fadeBitPattern = 1;
			_statusFlags = (byte)(_statusFlags & 0xBF);
			return;
		}

		byte ah = current;
		byte lowCurrent = (byte)(current & 0x0F);
		byte lowTarget = (byte)(target & 0x0F);
		if (lowCurrent != lowTarget) {
			ah++;
			if (lowCurrent > lowTarget) {
				ah -= 2;
			}
		}

		byte outValue = ah;
		byte highOut = (byte)(ah & 0xF0);
		byte highTarget = (byte)(target & 0xF0);
		if (highOut != highTarget) {
			outValue = (byte)(outValue + 0x10);
			if (highOut > highTarget) {
				outValue = (byte)(outValue - 0x20);
			}
		}

		_currentVolume = outValue;

		if (outValue == 0) {
			AllNotesOff();
			_statusFlags = 0;
		}
	}

	/// <summary>
	/// Turns off all logical OPL channels.
	/// Mirrors AdpUnknown091B.
	/// </summary>
	private void AllNotesOff() {
		for (int ch = 0; ch < ChannelCount; ch++) {
			AdgNoteOff((ushort)ch);
		}
	}
}