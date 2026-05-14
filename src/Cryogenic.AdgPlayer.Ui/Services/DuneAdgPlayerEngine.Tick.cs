namespace Cryogenic.AdgPlayer.Ui.Services;

using Serilog;

using System;

/// <summary>
/// Tick processing, event dispatch, and all music event handlers driving the ADG player engine.
/// Lineage: ported from AdpDriverCode.cs (AdpProcessTick_04D3 and related) in the parent Cryogenic project.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {

	/// <summary>
	/// Builds the channel table from song header data.
	/// Mirrors AdpBuildChannelTable_0413.
	/// </summary>
	private void BuildChannelTable() {
		// The song file header carries exactly SongHeaderChannelCount channel-start
		// pointers; the remaining logical channels stay inactive (pointer 0).
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
			// Routing scratch must start at 0 so ConfigureInstrumentRouting sees ~0 = 0xFFFF
			// (no-op mask) on the first ProgramChange. Mirrors AdgBuildChannelTable_068A's
			// initialization of per-channel state words.
			_channelRouteScratch[i] = 0;
			_channelRoute[i] = 0;
			_channelPrimaryOpRoute[i] = 0;
			_channelSecondaryOpRoute[i] = 0;
			_channelRouteShadow[i] = 0;
		}

		// Reset global voice-allocation bitmasks (BP / CX in the driver).
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
	/// iterates all 9 channels dispatching events.
	/// Mirrors AdpProcessTick_04D3.
	/// </summary>
	private void ProcessTick() {
		ushort tempoWord = SongWord(_dataBase + 0x30);
		_accumulator = (ushort)(_accumulator + tempoWord);

		LoopPointCheck();

		for (int ch = 0; ch < ChannelCount; ch++) {
			_channelWait[ch]--;

			if (_channelWait[ch] != 0) {
				// Channel still waiting — check vibrato
				if (_channelVibratoCount[ch] != 0 && _channelEventPointer[ch] != 0) {
					_channelVibratoCount[ch]--;
					byte phase = _channelVibratoPhase[ch];
					byte speed = _channelVibratoSpeed[ch];
					phase = (byte)(phase + speed);
					_channelVibratoPhase[ch] = phase;
					PitchBendBody(ch, Make16(phase, speed));
				}
			} else {
				// Wait expired — dispatch events until a new wait is set
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
	/// Reads a variable-length wait value from the ADG song data stream.
	/// Each byte contributes 7 bits; the high bit signals continuation.
	/// Mirrors AdgReadWaitValue_0E7E: value = (value &lt;&lt; 7) | (byte &amp; 0x7F) until MSB clears.
	/// </summary>
	private void ReadWaitValue(int ch) {
		ushort si = _channelEventPointer[ch];
		uint accumulator = 0;
		bool overflow = false;

		while (true) {
			byte current = SongByte16(si);
			si = (ushort)(si + 1);
			accumulator = (accumulator << 7) | (uint)(current & 0x7F);
			if (accumulator > ushort.MaxValue) {
				overflow = true;
			}
			if ((current & 0x80) == 0) {
				break;
			}
		}

		_channelWait[ch] = overflow ? ushort.MaxValue : (ushort)accumulator;
		_channelEventPointer[ch] = si;
	}

	/// <summary>
	/// NoteOn event handler. Reads velocity byte, sets up envelope,
	/// writes frequency to OPL with key-on.
	/// Mirrors AdpNoteOn_062C.
	/// </summary>
	private void NoteOn(int ch, ushort eventWord) {
		ushort si = _channelEventPointer[ch];
		byte velocity = SongByte16(si);
		si = (ushort)(si + 1);
		_channelEventPointer[ch] = si;

		ReadWaitValue(ch);

		EnvelopeSetup(ch, velocity);

		if (_channelCurrentNote[ch] != 0) {
			AdgNoteOff((ushort)ch);
		}

		byte noteFromEvent = Hi8(eventWord);
		byte note = (byte)(noteFromEvent + _channelPitchTranspose[ch]);
		_channelCurrentNote[ch] = note;
		_channelPitchBendCounter[ch] = (byte)(_channelPitchBendFlag[ch] >> 8);
		_channelPitchAccumulatorHi[ch] = 0x40;
		ushort rawPitch = (ushort)(note - 0x48);

		_channelVibratoCount[ch] = _channelVibratoInit[ch];
		_channelVibratoPhase[ch] = 0x40;

		AdgNoteOn((ushort)ch, rawPitch);
		ChannelEventDispatched?.Invoke(ch, "NoteOn", $"note={note:X2} vel={velocity:X2} raw={rawPitch:X4}", _totalTickCount);
	}

	/// <summary>
	/// NoteOff event handler. Reads wait, clears note if matching.
	/// Mirrors AdgNoteOff_0AB6.
	/// </summary>
	private void NoteOff(int ch, ushort eventWord) {
		_channelEventPointer[ch]++;
		ReadWaitValue(ch);

		byte noteFromEvent = (byte)(Hi8(eventWord) + _channelPitchTranspose[ch]);
		if (_channelCurrentNote[ch] == noteFromEvent) {
			_channelCurrentNote[ch] = 0;
			AdgNoteOff((ushort)ch);
			ChannelEventDispatched?.Invoke(ch, "NoteOff", $"note={noteFromEvent:X2}", _totalTickCount);
		}
	}

	/// <summary>
	/// ProgramChange event handler. Loads instrument patch and writes to OPL.
	/// Mirrors AdgProgramChange_0831.
	/// </summary>
	private void ProgramChange(int ch, ushort eventWord) {
		ReadWaitValue(ch);

		byte instrument = Hi8(eventWord);
		// Note: driver AdgProgramChange_0831 has NO duplicate-instrument early return.
		// Every ProgramChange must rerun ConfigureInstrumentRouting (which frees the channel's
		// previous voice allocation and reserves a new one) and rewrite the OPL patch registers.
		_channelInstrument[ch] = instrument;

		ushort patchOffset = (ushort)(_eventBase + instrument * 0x28);
		byte patchType = SongByte16(patchOffset);

		// Dynamic OPL routing: assign this logical channel to a physical OPL2 voice
		// (or report it as a secondary-chip allocation, which we collapse onto the primary).
		ConfigureInstrumentRouting(ch, patchType);

		_channelPatchType[ch] = patchType;
		if (patchType == 4) {
			ushort ax = Make16(SongByte16((ushort)(patchOffset + 0x32)), SongByte16((ushort)(patchOffset + 0x3F)));
			ushort bx = Make16(SongByte16((ushort)(patchOffset + 0x2A)), SongByte16((ushort)(patchOffset + 0x37)));
			bx = (ushort)(bx & 0x0303);
			bx = RotateRight16(bx, 2);
			ax = (ushort)(ax | bx);
			_channelPatch4EnvShaping[ch] = ax;
			_channelPatch4TlShaping[ch] = SongWord16((ushort)(patchOffset + 0x46));
			_channelPatch4VolumeModulation[ch] = SongWord16((ushort)(patchOffset + 0x4E));
		}

		ushort pitchModeWord = SongWord16((ushort)(patchOffset + 0x21));
		_channelPitchBendFlag[ch] = pitchModeWord;
		_channelPitchMode[ch] = Lo8(pitchModeWord);  // Extract pitch mode from low byte (patch[+0x21])
													 // Driver AdgProgramChange_0831 writes the full word at DI+AdgChannelPitchModeOffset (0x0090).
													 // Byte +0x90 = pitch mode (patch[+0x21]); byte +0x91 = pitch transpose (patch[+0x22]).
													 // NoteOn reads _channelPitchTranspose to offset the played note; without this init every note
													 // is transposed by 0 instead of the patch-defined transpose byte.
		_channelPitchTranspose[ch] = Hi8(pitchModeWord);

		ushort ax2 = Make16(SongByte16((ushort)(patchOffset + 0x0A)), SongByte16((ushort)(patchOffset + 0x17)));
		ushort bx2 = Make16(SongByte16((ushort)(patchOffset + 0x0F)), SongByte16((ushort)(patchOffset + 0x02)));
		bx2 = (ushort)(bx2 & 0x0303);
		bx2 = RotateRight16(bx2, 2);
		ax2 = (ushort)(ax2 | bx2);
		_channelEnvShaping[ch] = ax2;
		_channelTlShaping[ch] = SongWord16((ushort)(patchOffset + 0x1E));
		_channelVolModShaping[ch] = SongWord16((ushort)(patchOffset + 0x26));

		ushort ax3 = Make16((byte)~SongByte16((ushort)(patchOffset + 0x0E)), SongByte16((ushort)(patchOffset + 0x04)));
		ax3 = RotateRight16(ax3, 1);
		ax3 = (ushort)(ax3 << 1);
		ax3 = Make16(SongByte16((ushort)(patchOffset + 0x20)), Hi8(ax3));
		_channelConnShaping[ch] = ax3;

		ax3 = Make16(SongByte16((ushort)(patchOffset + 0x1B)), Hi8(ax3));
		_channelConnMod[ch] = ax3;

		ushort vibrato = SongWord16((ushort)(patchOffset + 0x23));
		_channelVibratoSpeed[ch] = Hi8(vibrato);
		_channelVibratoCount[ch] = 0;
		_channelVibratoInit[ch] = Lo8(vibrato);

		InstrumentWrite(ch, patchOffset);
		ChannelEventDispatched?.Invoke(ch, "ProgramChange", $"inst={instrument:X2} off=0x{patchOffset:X4}", _totalTickCount);
	}

	/// <summary>
	/// EnvelopeSetup for NoteOn. Adjusts TL and connection registers from velocity.
	/// Mirrors AdgEnvelopeSetup_0C47.
	/// </summary>
	private void EnvelopeSetup(int ch, byte velocity) {
		byte directVelocity = velocity;
		byte inverseVelocity = (byte)(0x80 - velocity);
		ushort operatorLevel = _channelOperatorLevel[ch];
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
			AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)_channelPrimaryOpRoute[ch]));
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
			AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)_channelSecondaryOpRoute[ch]));
		}

		_channelOperatorLevel[ch] = operatorLevel;
		if (_channelPatchType[ch] == 4) {
			ushort patch4OperatorLevel = _channelPatch4CurrentOperatorLevel[ch];
			ushort patch4TlShaping = _channelPatch4TlShaping[ch];

			if (Lo8(patch4TlShaping) != 0) {
				byte scale = inverseVelocity;
				byte shaping = Lo8(patch4TlShaping);
				if ((shaping & 0x80) != 0) {
					shaping = (byte)(0 - shaping);
					scale = directVelocity;
				}
				shaping = (byte)(0 - (byte)(shaping - 4));
				scale = (byte)(scale >> shaping);
				byte value = (byte)((Lo8(patch4OperatorLevel) & 0x3F) + scale);
				if (value > 0x3F) {
					value = 0x3F;
				}
				value = (byte)((Lo8(patch4OperatorLevel) & 0xC0) | value);
				patch4OperatorLevel = Make16(value, Hi8(patch4OperatorLevel));
				AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)(_channelPrimaryOpRoute[ch] + 0x08)));
			}

			if (Hi8(patch4TlShaping) != 0) {
				byte scale = inverseVelocity;
				byte shaping = Hi8(patch4TlShaping);
				if ((shaping & 0x80) != 0) {
					shaping = (byte)(0 - shaping);
					scale = directVelocity;
				}
				byte shift = (byte)(4 - shaping);
				scale = (byte)(scale >> shift);
				byte value = (byte)((Hi8(patch4OperatorLevel) & 0x3F) + scale);
				if (value > 0x3F) {
					value = 0x3F;
				}
				value = (byte)((Hi8(patch4OperatorLevel) & 0xC0) | value);
				patch4OperatorLevel = Make16(Lo8(patch4OperatorLevel), value);
				AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)(_channelSecondaryOpRoute[ch] + 0x08)));
			}

			_channelPatch4CurrentOperatorLevel[ch] = patch4OperatorLevel;
		}

		ushort connectionShape = _channelConnShaping[ch];
		if (Lo8(connectionShape) == 0) {
			_channelConnMod[ch] = (ushort)((_channelConnMod[ch] & 0x00FF) | (Hi8(connectionShape) << 8));
			return;
		}

		byte shapingMode = Lo8(connectionShape);
		byte scaleConnection = inverseVelocity;
		if ((shapingMode & 0x80) != 0) {
			shapingMode = (byte)(0 - shapingMode);
			scaleConnection = directVelocity;
		}
		shapingMode = (byte)(0 - (byte)(shapingMode - 6));
		scaleConnection = (byte)(scaleConnection >> shapingMode);
		scaleConnection = (byte)(scaleConnection & 0xFE);
		scaleConnection = (byte)(scaleConnection + Hi8(connectionShape));
		if (scaleConnection > 0x0F) {
			scaleConnection = (byte)((scaleConnection & 0x0F) | 0x0E);
		}
		_channelConnMod[ch] = (ushort)((_channelConnMod[ch] & 0x00FF) | (scaleConnection << 8));
		AdgWriteRelativeGoldRegister(0xC0, scaleConnection, unchecked((sbyte)_channelRoute[ch]));
	}

	/// <summary>
	/// VolumeModulation event handler. Applies velocity-based modulation to TL and connection registers.
	/// Mirrors AdgVolumeModulation_0B2E.
	/// </summary>
	private void VolumeModulation(int ch, ushort eventWord) {
		ReadWaitValue(ch);

		byte directVelocity = Hi8(eventWord);
		byte inverseVelocity = (byte)(0x80 - directVelocity);
		ushort operatorLevel = _channelOperatorLevel[ch];
		ushort volumeShape = _channelVolModShaping[ch];

		sbyte modRoute = unchecked((sbyte)_channelPrimaryOpRoute[ch]);
		sbyte carRoute = unchecked((sbyte)_channelSecondaryOpRoute[ch]);
		sbyte chanRoute = unchecked((sbyte)_channelRoute[ch]);

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
			AdgWriteRelativeGoldRegister(0x40, value, modRoute);
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
			AdgWriteRelativeGoldRegister(0x40, value, carRoute);
		}

		_channelOperatorLevel[ch] = operatorLevel;
		if (_channelPatchType[ch] == 4) {
			ushort patch4Level = _channelPatch4CurrentOperatorLevel[ch];
			ushort patch4Shape = _channelPatch4VolumeModulation[ch];

			if (Lo8(patch4Shape) != 0) {
				byte scale = directVelocity;
				byte shaping = Lo8(patch4Shape);
				if ((shaping & 0x80) != 0) {
					shaping = (byte)(0 - shaping);
					scale = inverseVelocity;
				}
				shaping = (byte)(0 - (byte)(shaping - 4));
				scale = (byte)(scale >> shaping);
				byte value = (byte)(Lo8(patch4Level) & 0x3F);
				value = value >= scale ? (byte)(value - scale) : (byte)0;
				value = (byte)((Lo8(patch4Level) & 0xC0) | value);
				patch4Level = Make16(value, Hi8(patch4Level));
				byte route = (byte)(_channelPrimaryOpRoute[ch] + 0x08);
				AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)route));
			}

			if (Hi8(patch4Shape) != 0) {
				byte scale = directVelocity;
				byte shaping = Hi8(patch4Shape);
				if ((shaping & 0x80) != 0) {
					shaping = (byte)(0 - shaping);
					scale = inverseVelocity;
				}
				byte shift = (byte)(4 - shaping);
				scale = (byte)(scale >> shift);
				byte value = (byte)(Hi8(patch4Level) & 0x3F);
				value = value >= scale ? (byte)(value - scale) : (byte)0;
				value = (byte)((Hi8(patch4Level) & 0xC0) | value);
				patch4Level = Make16(Lo8(patch4Level), value);
				byte route = (byte)(_channelSecondaryOpRoute[ch] + 0x08);
				AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)route));
			}

			_channelPatch4CurrentOperatorLevel[ch] = patch4Level;
		}

		ushort connectionMod = _channelConnMod[ch];
		if (Lo8(connectionMod) != 0) {
			byte shapingMode = Lo8(connectionMod);
			byte scaleConnection = directVelocity;
			if ((shapingMode & 0x80) != 0) {
				shapingMode = (byte)(0 - shapingMode);
				scaleConnection = inverseVelocity;
			}
			shapingMode = (byte)(0 - (byte)(shapingMode - 6));
			scaleConnection = (byte)(scaleConnection >> shapingMode);
			scaleConnection = (byte)(scaleConnection & 0xFE);
			scaleConnection = (byte)(scaleConnection + Hi8(connectionMod));
			if (scaleConnection > 0x0F) {
				scaleConnection = (byte)((scaleConnection & 0x0F) | 0x0E);
			}
			_channelConnMod[ch] = (ushort)((_channelConnMod[ch] & 0x00FF) | (scaleConnection << 8));
			AdgWriteRelativeGoldRegister(0xC0, scaleConnection, chanRoute);
		}
	}

	/// <summary>
	/// PitchBend event handler (from event dispatch).
	/// Mirrors AdgPitchBend_0D86.
	/// </summary>
	private void PitchBend(int ch, ushort eventWord) {
		byte bendValue = Hi8(eventWord);
		// DNADP 07EA semantics: mov al, ah before ReadWaitValue.
		// With AH already holding bendValue from eventWord, this yields AX = vvvv.
		// The bend body consumes full AX, so preserving this contract is critical.
		ReadWaitValue(ch);
		PitchBendBody(ch, Make16(bendValue, bendValue));
	}

	/// <summary>
	/// Pitch bend computation. Exact ADG driver implementation.
	/// Handles both portamento and non-portamento modes per patch configuration.
	/// Mirrors AdgPitchBendBody_0D8B.
	/// </summary>
	private void PitchBendBody(int ch, ushort input) {
		byte note = _channelCurrentNote[ch];
		if (note == 0) {
			return;
		}

		// Extract pitch bend value (low byte of input)
		byte pitchBendValue = Lo8(input);

		// Calculate octave and semitone from note
		int noteVal = pitchBendValue - 0x18;
		int octaveInt = noteVal / 12;
		int semitoneInt = noteVal % 12;
		// Normalize negative modulo result
		if (semitoneInt < 0) {
			semitoneInt += 12;
			octaveInt -= 1;
		}
		byte octave = (byte)(octaveInt & 0xFF);
		byte semitone = (byte)(semitoneInt & 0xFF);

		bool portamentoMode = Lo8(_channelPitchBendFlag[ch]) != 0;
		// Use accumulator as pitch bend input for interpolation
		ushort ax = Make16(pitchBendValue, 0);

		if (!portamentoMode) {
			// Non-portamento mode: use RotateRight16 for interpolation
			bool negative = ax < 0x0040;
			ax = (ushort)(ax - 0x0040);
			if (negative) {
				ax = (ushort)(0 - ax);
				ax = RotateRight16(ax, 5);
				byte delta = Lo8(ax);
				if (semitone >= delta) {
					semitone = (byte)(semitone - delta);
				} else {
					semitone = (byte)(semitone + 12 - delta);
					octave = (byte)(octave - 1);
					if ((octave & 0x80) != 0) {
						octave = 0;
						semitone = 0;
					}
				}

				byte fraction = PitchBendFractions[semitone];
				ushort mul = (ushort)(fraction * Hi8(ax));
				byte adjustment = Hi8(mul);
				ushort frequency = FrequencyTable[semitone];
				int result = Lo8(frequency) - adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) - (result < 0 ? 1 : 0)));
			} else {
				ax = (ushort)(ax + 1);
				ax = RotateRight16(ax, 5);
				byte delta = Lo8(ax);
				semitone = (byte)(semitone + delta);
				if (semitone >= 12) {
					semitone = (byte)(semitone - 12);
					octave = (byte)(octave + 1);
				}

				byte fraction = PitchBendFractions[semitone + 1];
				ushort mul = (ushort)(fraction * Hi8(ax));
				byte adjustment = Hi8(mul);
				ushort frequency = FrequencyTable[semitone];
				int result = Lo8(frequency) + adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) + (result > 0xFF ? 1 : 0)));
			}
		} else {
			// Portamento mode: divide by 5 for delta
			bool negative = ax < 0x0040;
			ax = (ushort)(ax - 0x0040);
			if (negative) {
				ax = (ushort)(0 - ax);
				byte delta = (byte)(ax / 5);
				byte remainderPort = (byte)(ax % 5);
				if (semitone >= delta) {
					semitone = (byte)(semitone - delta);
				} else {
					semitone = (byte)(semitone + 12 - delta);
					octave = (byte)(octave - 1);
					if ((octave & 0x80) != 0) {
						octave = 0;
						semitone = 0;
					}
				}

				ushort tableBase = (ushort)(semitone >= 6 ? 5 : 0);
				byte adjustment = PortamentoFractions[tableBase + remainderPort];
				ushort frequency = FrequencyTable[semitone];
				int result = Lo8(frequency) - adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) - (result < 0 ? 1 : 0)));
			} else {
				byte delta = (byte)(ax / 5);
				byte remainderPort = (byte)(ax % 5);
				semitone = (byte)(semitone + delta);
				if (semitone >= 12) {
					semitone = (byte)(semitone - 12);
					octave = (byte)(octave + 1);
				}

				ushort tableBase = (ushort)(semitone >= 6 ? 5 : 0);
				byte adjustment = PortamentoFractions[tableBase + remainderPort];
				ushort frequency = FrequencyTable[semitone];
				int result = Lo8(frequency) + adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) + (result > 0xFF ? 1 : 0)));
			}
		}

		byte blockBits = (byte)(octave << 2);
		ax = Make16(Lo8(ax), (byte)(Hi8(ax) | blockBits));
		_adgFrequencyWordTable[ch] = ax;
		ax = Make16(Lo8(ax), (byte)(Hi8(ax) | 0x20));
		AdgWriteFrequencyWord((ushort)ch, ax);
	}

	/// <summary>
	/// EndOfTrack event handler. Handles song looping and termination.
	/// Mirrors AdpEndOfTrack_066F.
	/// </summary>
	private void EndOfTrack(int ch) {
		_channelWait[ch] = 0xFFFF;
		ChannelEventDispatched?.Invoke(ch, "EndOfTrack", "", _totalTickCount);
		byte pointerLow = Lo8(_channelEventPointer[ch]);
		pointerLow = (byte)(pointerLow - 2);
		_channelEventPointer[ch] = Make16(pointerLow, Hi8(_channelEventPointer[ch]));

		if (ch != 0) {
			return;
		}

		_tickFlag--;
		if (_tickFlag == 0) {
			for (int i = 0; i < ChannelCount; i++) {
				_channelWait[i] = 0xFFFF;
			}
			AllNotesOff();
			_statusFlags = 0;
			Logger.Information("Song finished (tickFlag reached 0)");
			return;
		}
		if ((_tickFlag & 0x80) != 0) {
			_tickFlag++;
		}

		// Rebuild channel table for loop
		_measure = 1;
		_subdivision = 0x60;
		for (int i = 0; i < ChannelCount; i++) {
			ushort ptr = _channelStartOffset[i];
			_channelEventPointer[i] = ptr;
			_channelWait[i] = 0xFFFF;
			if (ptr != 0) {
				ReadWaitValue(i);
				_channelWait[i]++;
			}
		}

		LoopPointCheck();
		_channelWait[0]--;
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
	/// Turns off all 9 OPL channels.
	/// Mirrors AdpUnknown091B.
	/// </summary>
	private void AllNotesOff() {
		for (int ch = 0; ch < ChannelCount; ch++) {
			AdgNoteOff((ushort)ch);
		}
	}

	/// <summary>
	/// Dynamic OPL voice routing for a logical channel.
	/// Faithful port of <c>AdgConfigureInstrumentRouting_090D</c> from <c>AdgDriverCode.cs</c>:
	/// frees the channel's previous voice slot (via the scratch mask), then allocates a new
	/// physical OPL2 voice from one of three slot groups in either the primary or secondary
	/// (bit 7 set) chip allocation pools. The 18-logical-channel scheduler resolves to at most
	/// 9 physical primary voices plus 9 secondary voices; in the single-chip standalone player
	/// both pools collapse onto the same OPL2 channel set (see <c>AdgWriteRelativeGoldRegister</c>).
	/// </summary>
#pragma warning disable S907
	private void ConfigureInstrumentRouting(int ch, byte patchType) {
		ushort bp = _fadeScratch;
		ushort cx = _fadeScratch2;

		// Release this channel's previously held slot. AX = ~scratch; if high bit set the
		// previous allocation was primary (free in BP), else it was secondary (free in CX).
		ushort axMask = (ushort)~_channelRouteScratch[ch];
		if ((axMask & 0x8000) == 0) {
			cx = (ushort)(cx & axMask);
		} else {
			bp = (ushort)(bp & axMask);
		}

		ushort ax = 0;
		ushort bx;

		if (patchType == 4) {
			// 4-op instruments: try the three primary 4-op slots, then the three secondary ones.
			bx = 0x0009; ax = 0x0000;
			if ((bp & bx) != 0) { bp |= bx; goto WriteBack; }
			bx = 0x0012; ax = 0x0101;
			if ((bp & bx) != 0) { bp |= bx; goto WriteBack; }
			bx = 0x0024; ax = 0x0202;
			if ((bp & bx) != 0) { bp |= bx; goto WriteBack; }

			bx = 0x0009; ax = 0x8080;
			if ((cx & bx) != 0) {
				cx |= bx;
				bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
				goto WriteBack;
			}
			bx = 0x0012; ax = 0x8181;
			if ((cx & bx) != 0) {
				cx |= bx;
				bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
				goto WriteBack;
			}
			bx = 0x0024; ax = 0x8282;
			if ((cx & bx) != 0) {
				cx |= bx;
				bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
				goto WriteBack;
			}
		}

		// 2-op (and 4-op fallback): try upper-bank primary slots (channels 6/7/8) via lookup table,
		// otherwise pick from lower banks or the secondary chip.
		bx = (ushort)(~bp & 0x01C0);
		if (bx != 0) {
			bx = (ushort)(bx >> 4);
			(ax, bx) = AdgRoutingLookup(bx);
			bp = (ushort)(bp | bx);
		} else {
			bx = (ushort)~cx;
			if ((bx & 0x01C0) == 0) {
				// Both primary and secondary upper banks (ch 6/7/8) full: walk lower banks.
				byte bh = (byte)(((Lo8(bx) >> 3) ^ Lo8(bx)) & 0x07);
				if (bh != 0) {
					bool carryBh = (bh & 0x01) != 0;
					bh = (byte)(bh >> 1);
					if (carryBh) { goto ChooseSec0; }
					carryBh = (bh & 0x01) != 0;
					if (carryBh) { goto ChooseSec1; }
					goto ChooseSec2;
				}

				ax = bp;
				byte folded = (byte)((Lo8(ax) ^ (Lo8(ax) >> 3)) & 0x07);
				if (folded != 0) {
					bx = (ushort)~bp;
					bool cf = (folded & 0x01) != 0;
					folded = (byte)(folded >> 1);
					if (cf) { goto ChoosePri0; }
					cf = (folded & 0x01) != 0;
					if (cf) { goto ChoosePri1; }
					goto ChoosePri2;
				}

				bx = (ushort)(bx & 0x003F);
				if (bx == 0) {
					bx = (ushort)~bp;
					if ((bx & 0x0024) != 0) { goto ChoosePri2; }
					if ((bx & 0x0012) != 0) { goto ChoosePri1; }
					goto ChoosePri0;
				}

				if ((bx & 0x0024) != 0) { goto ChooseSec2; }
				if ((bx & 0x0012) != 0) { goto ChooseSec1; }
				goto ChooseSec0;
			}

			// Secondary upper bank has a free slot.
			bx = (ushort)((bx & 0x01C0) >> 4);
			(ax, bx) = AdgRoutingLookup(bx);
			ax = (ushort)(ax | 0x8080);
			cx = (ushort)(cx | bx);
			bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
		}
		goto WriteBack;

	ChoosePri0:
		ax = 0x0000;
		bx = (ushort)(bx & 0x0001);
		if (bx != 0) { bp = (ushort)(bp | bx); goto WriteBack; }
		ax = 0x0308;
		bx = Make16(0x08, Hi8(bx));
		bp = (ushort)(bp | bx);
		goto WriteBack;

	ChoosePri1:
		ax = 0x0101;
		bx = (ushort)(bx & 0x0002);
		if (bx != 0) { bp = (ushort)(bp | bx); goto WriteBack; }
		ax = 0x0409;
		bx = Make16(0x10, Hi8(bx));
		bp = (ushort)(bp | bx);
		goto WriteBack;

	ChoosePri2:
		ax = 0x0202;
		bx = (ushort)(bx & 0x0004);
		if (bx == 0) {
			ax = 0x050A;
			bx = Make16(0x20, Hi8(bx));
		}
		bp = (ushort)(bp | bx);
		goto WriteBack;

	ChooseSec0:
		ax = 0x8080;
		bx = (ushort)(bx & 0x0001);
		if (bx == 0) {
			ax = 0x8388;
			bx = Make16(0x08, Hi8(bx));
		}
		cx = (ushort)(cx | bx);
		bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
		goto WriteBack;

	ChooseSec1:
		ax = 0x8181;
		bx = (ushort)(bx & 0x0002);
		if (bx == 0) {
			ax = 0x8489;
			bx = Make16(0x10, Hi8(bx));
		}
		cx = (ushort)(cx | bx);
		bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
		goto WriteBack;

	ChooseSec2:
		ax = 0x8282;
		bx = (ushort)(bx & 0x0004);
		if (bx == 0) {
			ax = 0x858A;
			bx = Make16(0x20, Hi8(bx));
		}
		cx = (ushort)(cx | bx);
		bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));

	WriteBack:
		_channelRouteScratch[ch] = bx;
		_fadeScratch = bp;
		_fadeScratch2 = cx;
		_channelRoute[ch] = Hi8(ax);
		_channelPrimaryOpRoute[ch] = Lo8(ax);
		ax = (ushort)(ax + 0x0303);
		_channelRouteShadow[ch] = Hi8(ax);
		_channelSecondaryOpRoute[ch] = Lo8(ax);
	}
#pragma warning restore S907

	/// <summary>
	/// Routing lookup table at driver runtime offset 0x08ED (UNHSQ file offset 0x07ED).
	/// Indexed by <c>((~BP &amp; 0x01C0) &gt;&gt; 4)</c> ∈ {0x04, 0x08, 0x0C, 0x10, 0x14, 0x18, 0x1C}.
	/// Returns (AX, BX_out) where Hi8(AX) is the channel route, Lo8(AX) is the primary operator
	/// route, and BX_out is the BP slot-mask bit to set after allocation. Picks the highest
	/// numbered free OPL2 voice in the upper bank (8 &gt; 7 &gt; 6) when multiple are free.
	/// Source: DNADG.UNHSQ bytes verified against the runtime driver image.
	/// </summary>
	private static (ushort ax, ushort bxOut) AdgRoutingLookup(ushort index) {
		switch (index) {
			case 0x04: return (0x0610, 0x0040);  // channel 6 (mod 0x10, car 0x13)
			case 0x08: return (0x0711, 0x0080);  // channel 7 (mod 0x11, car 0x14)
			case 0x0C: return (0x0711, 0x0080);  // bits 6+7 free: prefer 7
			case 0x10: return (0x0812, 0x0100);  // channel 8 (mod 0x12, car 0x15)
			case 0x14: return (0x0812, 0x0100);  // bits 6+8 free: prefer 8
			case 0x18: return (0x0812, 0x0100);  // bits 7+8 free: prefer 8
			case 0x1C: return (0x0812, 0x0100);  // all three free: prefer 8
			default: return (0x0000, 0x0000);
		}
	}
}