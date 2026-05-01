namespace Cryogenic.AdgPlayer.Services;

using Serilog;

using System;

/// <summary>
/// Tick processing, event dispatch, and all DNADG event handlers.
/// Faithfully ported from AdgDriverCode.cs (AdgSchedulerTick_0756 and related handlers).
/// </summary>
public sealed partial class DuneAdgPlayerEngine {

	/// <summary>
	/// Copies the fixed initial routing tables into the per-channel mutable arrays.
	/// Called once at playback start so routing matches the OPL3 Gold channel layout.
	/// </summary>
	private void InitializeRoutingTables() {
		for (int i = 0; i < ChannelCount; i++) {
			_channelRoutingTable[i] = InitialChannelRoutes[i];
			_channelPrimaryRoute[i] = InitialPrimaryRoutes[i];
			_channelSecondaryRoute[i] = InitialSecondaryRoutes[i];
		}
	}

	/// <summary>
	/// Builds the 18-channel runtime state table from current song header.
	/// Mirrors AdgBuildChannelTable_068A.
	/// </summary>
	private void BuildChannelTable() {
		for (int i = 0; i < ChannelCount; i++) {
			ushort relative = SongWord(_dataBase + i * 2);
			ushort absolute = relative == 0 ? (ushort)0 : (ushort)(relative + _dataBase);
			_channelStartOffset[i] = absolute;
			_channelInstrument[i] = 0xFF;
			_channelNote[i] = 0;
			_channelStateScratch[i] = 0;
		}

		_measure = 1;
		_subdivision = 0x60;

		for (int ch = 0; ch < ChannelCount; ch++) {
			ushort ptr = _channelStartOffset[ch];
			_channelEventPointer[ch] = ptr;
			_channelWait[ch] = 0xFFFF;
			if (ptr != 0) {
				ReadWaitValue(ch);
				_channelWait[ch] = (ushort)(_channelWait[ch] + 1);
			}
		}

		_fadeScratch = 0;
		_fadeScratch2 = 0;
	}

	/// <summary>
	/// Main ADG scheduler tick. Advances tempo, checks loop, iterates all 18 channels.
	/// Mirrors AdgSchedulerTick_0756.
	/// </summary>
	private void ProcessTick() {
		LoopPointCheck();

		for (int ch = 0; ch < ChannelCount; ch++) {
			_channelWait[ch] = (ushort)(_channelWait[ch] - 1);

			if (_channelWait[ch] != 0) {
				AdvancePitchModulation(ch);
				continue;
			}

			while (_channelWait[ch] == 0) {
				ushort eventPointer = _channelEventPointer[ch];
				if (eventPointer == 0) {
					break;
				}

				ushort eventWord = SongWord16(eventPointer);
				_channelEventPointer[ch] = (ushort)(eventPointer + 2);
				DispatchEvent(ch, eventWord);
			}
		}

		_subdivision = (byte)(_subdivision - 1);
		if (_subdivision == 0) {
			_subdivision = 0x60;
			_measure = (ushort)(_measure + 1);
		}
	}

	/// <summary>
	/// Checks and manages ADG loop snapshot save/restore transitions.
	/// Mirrors AdgCheckLoopPoint_07DA.
	/// </summary>
	private void LoopPointCheck() {
		ushort loopStartMeasure = SongWord(_dataBase + 0x2A);
		ushort loopEndMeasure = SongWord(_dataBase + 0x2C);
		ushort loopRepeatCount = SongWord(_dataBase + 0x2E);

		if (_loopCounter == 0) {
			if (loopStartMeasure == _measure && _subdivision == 0x60) {
				for (int i = 0; i < ChannelCount; i++) {
					_snapshotWait[i] = _channelWait[i];
					_snapshotPointer[i] = _channelEventPointer[i];
				}
				_loopCounter = (byte)(loopRepeatCount - 1);
			}
		} else {
			if (loopEndMeasure == _measure) {
				_loopCounter--;
				for (int i = 0; i < ChannelCount; i++) {
					_channelWait[i] = _snapshotWait[i];
					_channelEventPointer[i] = _snapshotPointer[i];
				}
				_measure = loopStartMeasure;
			}
		}
	}

	/// <summary>
	/// Dispatches an ADG event word to the appropriate handler.
	/// Mirrors AdgDispatchObservedEvent_0756 (call word ptr DS:[BX+0x012E]).
	/// Handler index = (eventWord &amp; 0x0070) >> 4.
	/// </summary>
	private void DispatchEvent(int ch, ushort eventWord) {
		int handlerIndex = (eventWord & 0x0070) >> 4;
		switch (handlerIndex) {
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
			default:
				Logger.Warning("ADG scheduler: unhandled handler index {Index} on channel {Ch}", handlerIndex, ch);
				break;
		}
	}

	/// <summary>
	/// Decodes one ADG variable-length wait value from the song data stream.
	/// Uses 7-bit big-endian encoding with high-bit continuation.
	/// Mirrors AdgReadWaitValue_0E7E.
	/// </summary>
	private void ReadWaitValue(int ch) {
		ushort si = _channelEventPointer[ch];
		uint value = 0;
		bool overflow = false;

		while (true) {
			byte current = SongByte16(si);
			si = (ushort)(si + 1);
			value = (value << 7) | (uint)(current & 0x7F);
			if (value > 0xFFFF) {
				overflow = true;
			}
			if ((current & 0x80) == 0) {
				break;
			}
		}

		_channelWait[ch] = overflow ? (ushort)0xFFFF : (ushort)value;
		_channelEventPointer[ch] = si;
	}

	/// <summary>
	/// Advances pitch modulation counter for a waiting channel.
	/// Mirrors AdgAdvancePitchModulation_07AD.
	/// </summary>
	private void AdvancePitchModulation(int ch) {
		if (_channelPitchBendCounter[ch] == 0) {
			return;
		}
		if (_channelEventPointer[ch] == 0) {
			return;
		}

		_channelPitchBendCounter[ch] = (byte)(_channelPitchBendCounter[ch] - 1);
		byte accumulator = _channelPitchAccumulator[ch];
		byte speed = _channelPitchBendCounterInit[ch];
		accumulator = (byte)(accumulator + speed);
		_channelPitchAccumulator[ch] = accumulator;
		PitchBendBody(ch, Make16(accumulator, speed));
	}

	/// <summary>
	/// Clears the channel scratch mask when the event pointer advances past a safe threshold.
	/// Mirrors AdgClearScratchMask_0ACD.
	/// </summary>
	private void ClearScratchMask(int ch) {
		if (_channelWait[ch] < 0x0030) {
			return;
		}
		ushort ptr = _channelEventPointer[ch];
		if (ptr == 0) {
			return;
		}
		byte nextByte = SongByte16(ptr);
		if (nextByte != 0xFF && (nextByte & 0xF0) != 0xC0) {
			return;
		}

		ushort scratch = _channelStateScratch[ch];
		_channelStateScratch[ch] = 0;
		ushort mask = (ushort)~scratch;
		if ((mask & 0x8000) == 0) {
			_fadeScratch2 = (ushort)(_fadeScratch2 & mask);
		} else {
			_fadeScratch = (ushort)(_fadeScratch & mask);
		}
	}

	/// <summary>
	/// NoteOn event handler. Reads velocity, sets up envelope, writes frequency with key-on.
	/// Mirrors AdgNoteOn_0A82.
	/// </summary>
	private void NoteOn(int ch, ushort eventWord) {
		ushort si = _channelEventPointer[ch];
		byte velocity = SongByte16(si);
		si = (ushort)(si + 1);
		_channelEventPointer[ch] = si;
		ReadWaitValue(ch);

		EnvelopeSetup(ch, velocity);

		if (_channelNote[ch] != 0) {
			NoteOffOpl(ch);
		}

		byte note = (byte)(Hi8(eventWord) + _channelPitchTranspose[ch]);
		_channelNote[ch] = note;
		_channelPitchBendCounter[ch] = _channelPitchBendCounterInit[ch];
		_channelPitchAccumulator[ch] = 0x40;

		NoteOnOpl(ch, (ushort)(note - 0x48));
		ChannelEventDispatched?.Invoke(ch, "NoteOn",
			$"note={note:X2} vel={velocity:X2} inst={_channelInstrument[ch]:X2} tr={_channelPitchTranspose[ch]:X2}",
			_totalTickCount);
	}

	/// <summary>
	/// NoteOff event handler. Skips velocity byte, reads wait, clears note if matching.
	/// Mirrors AdgNoteOff_0AB6.
	/// </summary>
	private void NoteOff(int ch, ushort eventWord) {
		_channelEventPointer[ch] = (ushort)(_channelEventPointer[ch] + 1);
		ReadWaitValue(ch);

		byte note = (byte)(Hi8(eventWord) + _channelPitchTranspose[ch]);
		if (_channelNote[ch] != note) {
			return;
		}

		_channelNote[ch] = 0;
		ClearScratchMask(ch);
		NoteOffOpl(ch);
		ChannelEventDispatched?.Invoke(ch, "NoteOff", $"note={note:X2} inst={_channelInstrument[ch]:X2}", _totalTickCount);
	}

	/// <summary>
	/// ProgramChange event handler. Loads instrument patch and writes to OPL3 Gold.
	/// Mirrors AdgProgramChange_0831 with simplified fixed routing for standalone play.
	/// </summary>
	private void ProgramChange(int ch, ushort eventWord) {
		ReadWaitValue(ch);

		byte instrument = Hi8(eventWord);
		_channelInstrument[ch] = instrument;

		ushort patchOffset = (ushort)(_eventBase + instrument * 0x28);

		_channelPitchMode[ch] = SongWord16((ushort)(patchOffset + 0x21));
		_channelPitchTranspose[ch] = Hi8(_channelPitchMode[ch]);

		ushort ax = Make16(SongByte16((ushort)(patchOffset + 0x0A)), SongByte16((ushort)(patchOffset + 0x17)));
		ushort bx = Make16(SongByte16((ushort)(patchOffset + 0x0F)), SongByte16((ushort)(patchOffset + 0x02)));
		bx = (ushort)(bx & 0x0303);
		bx = RotateRight16(bx, 2);
		ax = (ushort)(ax | bx);
		_channelEnvShaping[ch] = ax;

		_channelTlShaping[ch] = SongWord16((ushort)(patchOffset + 0x1E));
		_channelVolModShaping[ch] = SongWord16((ushort)(patchOffset + 0x26));

		ax = Make16((byte)~SongByte16((ushort)(patchOffset + 0x0E)), SongByte16((ushort)(patchOffset + 0x04)));
		ax = RotateRight16(ax, 1);
		ax = (ushort)(ax << 1);
		ax = Make16(SongByte16((ushort)(patchOffset + 0x20)), Hi8(ax));
		_channelConnShaping[ch] = ax;

		ax = Make16(SongByte16((ushort)(patchOffset + 0x1B)), Hi8(ax));
		_channelConnModulation[ch] = ax;

		ax = SongWord16((ushort)(patchOffset + 0x23));
		_channelPitchBendCounterInit[ch] = Hi8(ax);
		_channelPitchBendCounter[ch] = 0;

		byte patchType = SongByte16(patchOffset);
		_channelPatchType[ch] = patchType;

		WriteInstrumentPatch(patchOffset, ch);
		ChannelEventDispatched?.Invoke(ch, "PgmChg", $"inst={instrument:X2}", _totalTickCount);
	}

	/// <summary>
	/// VolumeModulation event handler. Applies velocity-based modulation to operator TL registers.
	/// Mirrors AdgVolumeModulation_0B2E.
	/// </summary>
	private void VolumeModulation(int ch, ushort eventWord) {
		ReadWaitValue(ch);

		byte directVelocity = Hi8(eventWord);
		byte inverseVelocity = (byte)(0x80 - directVelocity);
		ushort operatorLevel = _channelCurrentOperatorLevel[ch];
		ushort volumeShape = _channelVolModShaping[ch];

		if (Lo8(volumeShape) != 0) {
			byte shaping = Lo8(volumeShape);
			byte scale = directVelocity;
			if ((shaping & 0x80) != 0) {
				shaping = (byte)(0 - shaping);
				scale = inverseVelocity;
			}
			shaping = (byte)(0 - (byte)(shaping - 4));
			scale = (byte)(scale >> shaping);
			byte value = (byte)(Lo8(operatorLevel) & 0x3F);
			value = value >= scale ? (byte)(value - scale) : (byte)0;
			value = (byte)((Lo8(operatorLevel) & 0xC0) | value);
			operatorLevel = Make16(value, Hi8(operatorLevel));
			WriteRelativeGoldRegister(0x40, value, unchecked((sbyte)_channelPrimaryRoute[ch]));
		}

		if (Hi8(volumeShape) != 0) {
			byte shaping = Hi8(volumeShape);
			byte scale = directVelocity;
			if ((shaping & 0x80) != 0) {
				shaping = (byte)(0 - shaping);
				scale = inverseVelocity;
			}
			byte shift = (byte)(4 - shaping);
			scale = (byte)(scale >> shift);
			byte value = (byte)(Hi8(operatorLevel) & 0x3F);
			value = value >= scale ? (byte)(value - scale) : (byte)0;
			value = (byte)((Hi8(operatorLevel) & 0xC0) | value);
			operatorLevel = Make16(Lo8(operatorLevel), value);
			WriteRelativeGoldRegister(0x40, value, unchecked((sbyte)_channelSecondaryRoute[ch]));
		}

		_channelCurrentOperatorLevel[ch] = operatorLevel;

		ushort connectionModulation = _channelConnModulation[ch];
		if (Lo8(connectionModulation) == 0) {
			return;
		}

		byte shapingMode = Lo8(connectionModulation);
		byte scaleConnection = directVelocity;
		if ((shapingMode & 0x80) != 0) {
			shapingMode = (byte)(0 - shapingMode);
			scaleConnection = inverseVelocity;
		}
		shapingMode = (byte)(0 - (byte)(shapingMode - 6));
		scaleConnection = (byte)(scaleConnection >> shapingMode);
		scaleConnection = (byte)(scaleConnection & 0xFE);
		scaleConnection = (byte)(scaleConnection + Hi8(connectionModulation));
		if (scaleConnection > 0x0F) {
			scaleConnection = (byte)((scaleConnection & 0x0F) | 0x0E);
		}
		scaleConnection = (byte)((scaleConnection & 0x0F) | (Hi8(connectionModulation) & 0x30) | 0x30);
		_channelConnectionCurrent[ch] = scaleConnection;
		WriteRelativeGoldRegister(0xC0, scaleConnection, unchecked((sbyte)_channelRoutingTable[ch]));
	}

	/// <summary>
	/// Envelope setup on note-on. Scales TL values by velocity and writes to OPL3 Gold.
	/// Mirrors AdgEnvelopeSetup_0C47.
	/// </summary>
	private void EnvelopeSetup(int ch, byte velocity) {
		byte directVelocity = velocity;
		byte inverseVelocity = (byte)(0x80 - velocity);
		ushort operatorLevel = _channelCurrentOperatorLevel[ch];
		ushort tlShaping = _channelTlShaping[ch];

		if (Lo8(tlShaping) != 0) {
			byte shaping = Lo8(tlShaping);
			byte scale = inverseVelocity;
			if ((shaping & 0x80) != 0) {
				shaping = (byte)(0 - shaping);
				scale = directVelocity;
			}
			shaping = (byte)(0 - (byte)(shaping - 4));
			scale = (byte)(scale >> shaping);
			byte value = (byte)((Lo8(operatorLevel) & 0x3F) + scale);
			if (value > 0x3F) {
				value = 0x3F;
			}
			value = (byte)((Lo8(operatorLevel) & 0xC0) | value);
			operatorLevel = Make16(value, Hi8(operatorLevel));
			WriteRelativeGoldRegister(0x40, value, unchecked((sbyte)_channelPrimaryRoute[ch]));
		}

		if (Hi8(tlShaping) != 0) {
			byte shaping = Hi8(tlShaping);
			byte scale = inverseVelocity;
			if ((shaping & 0x80) != 0) {
				shaping = (byte)(0 - shaping);
				scale = directVelocity;
			}
			byte shift = (byte)(4 - shaping);
			scale = (byte)(scale >> shift);
			byte value = (byte)((Hi8(operatorLevel) & 0x3F) + scale);
			if (value > 0x3F) {
				value = 0x3F;
			}
			value = (byte)((Hi8(operatorLevel) & 0xC0) | value);
			operatorLevel = Make16(Lo8(operatorLevel), value);
			WriteRelativeGoldRegister(0x40, value, unchecked((sbyte)_channelSecondaryRoute[ch]));
		}

		_channelCurrentOperatorLevel[ch] = operatorLevel;

		ushort connectionShape = _channelConnShaping[ch];
		if (Lo8(connectionShape) == 0) {
			_channelConnectionCurrent[ch] = Hi8(connectionShape);
			return;
		}

		byte connectionScaleMode = Lo8(connectionShape);
		byte connectionScale = inverseVelocity;
		if ((connectionScaleMode & 0x80) != 0) {
			connectionScaleMode = (byte)(0 - connectionScaleMode);
			connectionScale = directVelocity;
		}
		connectionScaleMode = (byte)(0 - (byte)(connectionScaleMode - 6));
		connectionScale = (byte)(connectionScale >> connectionScaleMode);
		connectionScale = (byte)(connectionScale & 0xFE);
		connectionScale = (byte)(connectionScale + Hi8(connectionShape));
		if (connectionScale > 0x0F) {
			connectionScale = (byte)((connectionScale & 0x0F) | 0x0E);
		}
		connectionScale = (byte)((connectionScale & 0x0F) | (Hi8(connectionShape) & 0x30) | 0x30);
		_channelConnectionCurrent[ch] = connectionScale;
		WriteRelativeGoldRegister(0xC0, connectionScale, unchecked((sbyte)_channelRoutingTable[ch]));
	}

	/// <summary>
	/// PitchBend event handler. Reads bend value and applies pitch modulation.
	/// Mirrors AdgPitchBend_0D86.
	/// </summary>
	private void PitchBend(int ch, ushort eventWord) {
		byte bendValue = Hi8(eventWord);
		ReadWaitValue(ch);
		PitchBendBody(ch, Make16(bendValue, bendValue));
		ChannelEventDispatched?.Invoke(ch, "PBend", $"val={bendValue:X2}", _totalTickCount);
	}

	/// <summary>
	/// Pitch bend computation body. Handles both portamento and non-portamento modes.
	/// Mirrors AdgPitchBendBody_0D8B.
	/// </summary>
	private void PitchBendBody(int ch, ushort input) {
		static void NormalizeSemitoneAndOctave(ref int semitoneValue, ref int octaveValue) {
			while (semitoneValue < 0) {
				semitoneValue += 12;
				octaveValue--;
			}

			while (semitoneValue >= 12) {
				semitoneValue -= 12;
				octaveValue++;
			}

			if (octaveValue < 0) {
				octaveValue = 0;
				semitoneValue = 0;
			}
		}

		byte note = _channelNote[ch];
		if (note == 0) {
			return;
		}

		ushort ax = Make16(Lo8(input), 0);
		byte rawNote = note;
		byte quotient = (byte)((rawNote - 0x18) / 12);
		byte remainder = (byte)((rawNote - 0x18) % 12);
		byte octave = quotient;
		byte semitone = remainder;

		if (Lo8(_channelPitchMode[ch]) == 0) {
			bool negative = ax < 0x0040;
			ax = (ushort)(ax - 0x0040);
			if (negative) {
				ax = (ushort)(0 - ax);
				ax = RotateRight16(ax, 5);
				byte delta = Lo8(ax);
				int semitoneValue = semitone - delta;
				int octaveValue = octave;
				NormalizeSemitoneAndOctave(ref semitoneValue, ref octaveValue);
				semitone = (byte)semitoneValue;
				octave = (byte)octaveValue;
				byte fraction = PitchBendFractions[semitone];
				ushort mul = (ushort)(fraction * Hi8(ax));
				byte adjustment = Hi8(mul);
				ushort frequency = FrequencyLookupTable[semitone];
				int result = Lo8(frequency) - adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) - (result < 0 ? 1 : 0)));
			} else {
				ax = (ushort)(ax + 1);
				ax = RotateRight16(ax, 5);
				byte delta = Lo8(ax);
				int semitoneValue = semitone + delta;
				int octaveValue = octave;
				NormalizeSemitoneAndOctave(ref semitoneValue, ref octaveValue);
				semitone = (byte)semitoneValue;
				octave = (byte)octaveValue;
				byte fraction = PitchBendFractions[semitone + 1];
				ushort mul = (ushort)(fraction * Hi8(ax));
				byte adjustment = Hi8(mul);
				ushort frequency = FrequencyLookupTable[semitone];
				int result = Lo8(frequency) + adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) + (result > 0xFF ? 1 : 0)));
			}
		} else {
			bool negative = ax < 0x0040;
			ax = (ushort)(ax - 0x0040);
			if (negative) {
				ax = (ushort)(0 - ax);
				byte delta = (byte)(ax / 5);
				byte remainderPort = (byte)(ax % 5);
				int semitoneValue = semitone - delta;
				int octaveValue = octave;
				NormalizeSemitoneAndOctave(ref semitoneValue, ref octaveValue);
				semitone = (byte)semitoneValue;
				octave = (byte)octaveValue;
				int tableBase = semitone >= 6 ? 5 : 0;
				byte adjustment = PortamentoFractions[tableBase + remainderPort];
				ushort frequency = FrequencyLookupTable[semitone];
				int result = Lo8(frequency) - adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) - (result < 0 ? 1 : 0)));
			} else {
				byte delta = (byte)(ax / 5);
				byte remainderPort = (byte)(ax % 5);
				int semitoneValue = semitone + delta;
				int octaveValue = octave;
				NormalizeSemitoneAndOctave(ref semitoneValue, ref octaveValue);
				semitone = (byte)semitoneValue;
				octave = (byte)octaveValue;
				int tableBase = semitone >= 6 ? 5 : 0;
				byte adjustment = PortamentoFractions[tableBase + remainderPort];
				ushort frequency = FrequencyLookupTable[semitone];
				int result = Lo8(frequency) + adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) + (result > 0xFF ? 1 : 0)));
			}
		}

		byte blockBits = (byte)(octave << 2);
		ax = Make16(Lo8(ax), (byte)(Hi8(ax) | blockBits));
		_channelFrequencyWord[ch] = ax;
		ax = Make16(Lo8(ax), (byte)(Hi8(ax) | 0x20));
		WriteFrequencyWord(ch, ax);
	}

	/// <summary>
	/// EndOfTrack event handler. Handles multi-track sequencing and song termination.
	/// Mirrors AdgEndOfTrack_0AF5.
	/// </summary>
	private void EndOfTrack(int ch) {
		_channelWait[ch] = 0xFFFF;
		byte pointerLo = Lo8(_channelEventPointer[ch]);
		_channelEventPointer[ch] = Make16((byte)(pointerLo - 2), Hi8(_channelEventPointer[ch]));

		if (ch != 0) {
			ClearScratchMask(ch);
			return;
		}

		_tickEnabled = (byte)(_tickEnabled - 1);
		if (_tickEnabled == 0) {
			for (int i = 0; i < ChannelCount; i++) {
				_channelWait[i] = 0xFFFF;
			}
			SilenceAllChannels();
			_statusFlags = 0;
			Logger.Information("Song finished (tickEnabled reached 0)");
			SongFinished?.Invoke();
			return;
		}

		if ((_tickEnabled & 0x80) != 0) {
			_tickEnabled = (byte)(_tickEnabled + 1);
		}

		// Rebuild scheduler state for loop
		_measure = 1;
		_subdivision = 0x60;
		_fadeScratch = 0;
		_fadeScratch2 = 0;
		for (int i = 0; i < ChannelCount; i++) {
			ushort ptr = _channelStartOffset[i];
			_channelEventPointer[i] = ptr;
			_channelWait[i] = 0xFFFF;
			_channelStateScratch[i] = 0;
			if (ptr != 0) {
				ReadWaitValue(i);
				_channelWait[i] = (ushort)(_channelWait[i] + 1);
			}
		}

		LoopPointCheck();
		_channelWait[0] = (ushort)(_channelWait[0] - 1);
	}

	/// <summary>
	/// FadeStep: approaches target volume one nibble at a time.
	/// Mirrors AdgFadeStep_0ECC.
	/// </summary>
	private void FadeStep() {
		byte current = _currentVolume;
		byte target = _targetVolume;

		if (current == target) {
			_fadeBitPattern = 0x0001;
			_statusFlags = (byte)(_statusFlags & 0xBF);
			return;
		}

		byte updated = current;
		byte currentLow = (byte)(updated & 0x0F);
		byte targetLow = (byte)(target & 0x0F);
		if (currentLow != targetLow) {
			updated = (byte)(updated + 1);
			if (currentLow > targetLow) {
				updated = (byte)(updated - 2);
			}
		}

		byte currentHigh = (byte)(updated & 0xF0);
		byte targetHigh = (byte)(target & 0xF0);
		if (currentHigh != targetHigh) {
			updated = (byte)(updated + 0x10);
			if (currentHigh > targetHigh) {
				updated = (byte)(updated - 0x20);
			}
		}

		_currentVolume = updated;

		if (updated == 0) {
			SilenceAllChannels();
			_statusFlags = 0;
		}
	}

	/// <summary>
	/// Silences all 18 OPL3 Gold channels by writing note-off frequency words.
	/// Mirrors AdgResetInternal_0EBA: iterates channels 17..0 skipping percussion slots.
	/// </summary>
	private void SilenceAllChannels() {
		for (int ch = ChannelCount - 1; ch >= 0; ch--) {
			if (ch == 6 || ch == 7 || ch == 14 || ch == 15) {
				continue;
			}
			NoteOffOpl(ch);
		}
	}
}


/// <summary>
/// Builds the channel table from song header data.
