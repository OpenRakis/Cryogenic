namespace Cryogenic.AdpPlayer.Services;

using Serilog;

using System;

/// <summary>
/// Tick processing, event dispatch, and all DNADP event handlers.
/// Faithfully ported from AdpDriverCode.cs (AdpProcessTick_04D3 and related).
/// </summary>
public sealed partial class DuneAdpPlayerEngine {

	/// <summary>
	/// Builds the channel table from song header data.
	/// Mirrors AdpBuildChannelTable_0413.
	/// </summary>
	private void BuildChannelTable() {
		for (int i = 0; i < ChannelCount; i++) {
			ushort relative = SongWord(_dataBase + i * 2);
			ushort absolute = relative == 0 ? (ushort)0 : (ushort)(relative + _dataBase);
			_channelStartOffset[i] = absolute;
		}

		for (int i = 0; i < ChannelCount; i++) {
			_channelInstrument[i] = 0xFF;
			_channelNote[i] = 0x00;
			_channelVibratoCount[i] = 0;
			_channelVibratoInit[i] = 0;
			_channelPitchBendFlag[i] = 0;
		}

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
	/// Reads a variable-length wait value from the song data stream.
	/// Updates channel wait and event pointer.
	/// Mirrors AdpReadWaitValue_08E1.
	/// </summary>
	private void ReadWaitValue(int ch) {
		ushort si = _channelEventPointer[ch];
		byte al = SongByte16(si);
		si = (ushort)(si + 1);
		ushort ax = al;

		if ((al & 0x80) != 0) {
			ushort cx = 0;
			byte ah = 0;
			do {
				byte previousCl = Lo8(cx);
				byte previousAh = ah;
				cx = Make16(previousAh, previousCl);
				ah = al;
				al = SongByte16(si);
				si = (ushort)(si + 1);
			} while ((al & 0x80) != 0);

			ax = (ushort)((al & 0x7F) | ((ah & 0x7F) << 8));
			cx = (ushort)(cx & 0x7F7F);

			byte cl = (byte)(Lo8(cx) << 1);
			cx = Make16(cl, Hi8(cx));
			cx = (ushort)(cx >> 1);

			byte lowAl = Lo8(ax);
			lowAl = (byte)(lowAl << 1);
			ax = Make16(lowAl, Hi8(ax));
			ax = (ushort)(ax << 1);

			bool carry = (cx & 0x0001) != 0;
			cx = (ushort)(cx >> 1);
			ax = (ushort)((ax >> 1) | (carry ? 0x8000 : 0));

			carry = (cx & 0x0001) != 0;
			cx = (ushort)(cx >> 1);
			ax = (ushort)((ax >> 1) | (carry ? 0x8000 : 0));

			if (cx != 0) {
				ax = 0xFFFF;
			}
		}

		_channelWait[ch] = ax;
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

		if (_channelNote[ch] != 0) {
			OplFrequencyWrite(ch, 0);
		}

		byte noteFromEvent = Hi8(eventWord);
		byte noteTranspose = Hi8(_channelPitchBendFlag[ch]);
		byte note = (byte)(noteFromEvent + noteTranspose);
		_channelNote[ch] = note;
		ushort rawPitch = (ushort)(note - 0x48);

		_channelVibratoCount[ch] = _channelVibratoInit[ch];
		_channelVibratoPhase[ch] = 0x40;

		OplNoteOn(ch, rawPitch);
		ChannelEventDispatched?.Invoke(ch, "NoteOn", $"note={note:X2} vel={velocity:X2} inst={_channelInstrument[ch]:X2} tr={noteTranspose:X2} pb={Lo8(_channelPitchBendFlag[ch]):X2} rp={rawPitch:X4}", _totalTickCount);
	}

	/// <summary>
	/// NoteOff event handler. Skips one byte, reads wait, clears note if matching.
	/// Mirrors AdpNoteOff_065B.
	/// </summary>
	private void NoteOff(int ch, ushort eventWord) {
		_channelEventPointer[ch]++;
		ReadWaitValue(ch);

		byte noteFromEvent = (byte)(Hi8(eventWord) + Hi8(_channelPitchBendFlag[ch]));
		if (_channelNote[ch] == noteFromEvent) {
			_channelNote[ch] = 0;
			OplNoteOff(ch);
		}
		ChannelEventDispatched?.Invoke(ch, "NoteOff", $"note={noteFromEvent:X2} inst={_channelInstrument[ch]:X2} tr={Hi8(_channelPitchBendFlag[ch]):X2}", _totalTickCount);
	}

	/// <summary>
	/// ProgramChange event handler. Loads instrument patch and writes to OPL.
	/// Mirrors AdpProgramChange_05AA.
	/// </summary>
	private void ProgramChange(int ch, ushort eventWord) {
		ReadWaitValue(ch);

		byte instrument = Hi8(eventWord);
		if (_channelInstrument[ch] == instrument) {
			return;
		}
		_channelInstrument[ch] = instrument;

		ushort instOff = (ushort)(_eventBase + instrument * 0x28);

		_channelPitchBendFlag[ch] = SongWord16((ushort)(instOff + 0x21));

		byte ah = SongByte16((ushort)(instOff + 0x17));
		byte al = SongByte16((ushort)(instOff + 0x0A));
		byte bh = SongByte16((ushort)(instOff + 0x02));
		byte bl = SongByte16((ushort)(instOff + 0x0F));
		ushort bx = (ushort)(Make16(bl, bh) & 0x0303);
		bx = (ushort)((bx >> 2) | (bx << 14));
		_channelEnvShaping[ch] = (ushort)(Make16(al, ah) | bx);

		_channelTlShaping[ch] = SongWord16((ushort)(instOff + 0x1E));
		_channelVolModShaping[ch] = SongWord16((ushort)(instOff + 0x26));

		al = SongByte16((ushort)(instOff + 0x0E));
		al = (byte)~al;
		al = (byte)((al >> 1) | (al << 7));
		ah = SongByte16((ushort)(instOff + 0x04));
		ushort ax = (ushort)(Make16(al, ah) << 1);
		al = SongByte16((ushort)(instOff + 0x20));
		ax = Make16(al, Hi8(ax));
		_channelConnShaping[ch] = ax;

		al = SongByte16((ushort)(instOff + 0x1B));
		_channelConnMod[ch] = Make16(al, Hi8(ax));

		ax = SongWord16((ushort)(instOff + 0x23));
		_channelVibratoSpeed[ch] = Hi8(ax);
		_channelVibratoCount[ch] = 0;
		_channelVibratoInit[ch] = Lo8(ax);

		InstrumentWrite(ch, (ushort)(instOff + 2));
		ChannelEventDispatched?.Invoke(ch, "PgmChg", $"inst={instrument:X2}", _totalTickCount);
	}

	/// <summary>
	/// VolumeModulation event handler. Applies velocity-based modulation
	/// to operator TL registers and connection.
	/// Mirrors AdpVolumeModulation_06A8.
	/// </summary>
	private void VolumeModulation(int ch, ushort eventWord) {
		ReadWaitValue(ch);

		byte velocityRaw = Hi8(eventWord);
		byte al = (byte)(0x80 - velocityRaw);
		byte ah = al;
		al = velocityRaw;

		// Swap: al = inverted velocity (0x80-raw), ah = raw velocity
		// Actually after the swap: al = raw, ah = inverted. Let me re-check.
		// Original: al = 0x80; sub al, ah → al = 0x80 - velocity; xchg al, ah → al = velocity, ah = 0x80-velocity
		byte velocity = velocityRaw;
		byte invertedVelocity = (byte)(0x80 - velocityRaw);

		ushort operatorLevel = _channelOperatorLevel[ch];
		ushort volModShape = _channelVolModShaping[ch];

		// Modulator TL (low byte of volModShape)
		if (Lo8(volModShape) != 0) {
			byte cl = Lo8(volModShape);
			byte scaleAl = velocity;
			if ((cl & 0x80) != 0) {
				cl = (byte)(0 - cl);
				scaleAl = invertedVelocity;
			}
			cl = (byte)(0 - (byte)(cl - 4));
			scaleAl = (byte)(scaleAl >> cl);
			byte reg = (byte)(Lo8(operatorLevel) & 0x3F);
			reg = reg >= scaleAl ? (byte)(reg - scaleAl) : (byte)0;
			byte flags = (byte)(Lo8(operatorLevel) & 0xC0);
			OplRegisterWrite((ushort)(0x40 + ModulatorOffsets[ch]), (byte)(reg | flags));
		}

		// Carrier TL (high byte of volModShape)
		if (Hi8(volModShape) != 0) {
			byte chByte = Hi8(volModShape);
			byte scaleAl = velocity;
			if ((chByte & 0x80) != 0) {
				chByte = (byte)(0 - chByte);
				scaleAl = invertedVelocity;
			}
			byte shr = (byte)(4 - chByte);
			scaleAl = (byte)(scaleAl >> shr);
			byte reg = (byte)(Hi8(operatorLevel) & 0x3F);
			reg = reg >= scaleAl ? (byte)(reg - scaleAl) : (byte)0;
			byte flags = (byte)(Hi8(operatorLevel) & 0xC0);
			OplRegisterWrite((ushort)(0x40 + CarrierOffsets[ch]), (byte)(reg | flags));
		}

		// Connection modulation
		ushort connMod = _channelConnMod[ch];
		if (Lo8(connMod) != 0) {
			byte cl = Lo8(connMod);
			byte scaleAl = velocity;
			if ((cl & 0x80) != 0) {
				cl = (byte)(0 - cl);
				scaleAl = invertedVelocity;
			}
			cl = (byte)(0 - (byte)(cl - 6));
			scaleAl = (byte)(scaleAl >> cl);
			scaleAl = (byte)(scaleAl & 0xFE);
			scaleAl = (byte)(scaleAl + Hi8(connMod));
			if (scaleAl > 0x0F) {
				scaleAl = (byte)((scaleAl & 0x0F) | 0x0E);
			}
			OplRegisterWrite((ushort)(0xC0 + ch), scaleAl);
		}
	}

	/// <summary>
	/// EnvelopeSetup for NoteOn. Adds to base TL instead of subtracting.
	/// Mirrors AdpEnvelopeSetup_0740.
	/// </summary>
	private void EnvelopeSetup(int ch, byte velocity) {
		byte ah = velocity;
		byte al = (byte)(0x80 - ah);

		ushort bx = _channelEnvShaping[ch];
		ushort cx = _channelTlShaping[ch];

		// Modulator TL
		if (Lo8(cx) != 0) {
			byte cl = Lo8(cx);
			byte scaleAl = al;
			if ((cl & 0x80) != 0) {
				cl = (byte)(0 - cl);
				scaleAl = ah;
			}
			cl = (byte)(0 - (byte)(cl - 4));
			scaleAl = (byte)(scaleAl >> cl);
			byte reg = (byte)(Lo8(bx) & 0x3F);
			reg = (byte)(reg + scaleAl);
			if (reg > 0x3F) {
				reg = 0x3F;
			}
			bx = (ushort)((bx & 0xFF00) | ((Lo8(bx) & 0xC0) | reg));
			OplRegisterWrite((ushort)(0x40 + ModulatorOffsets[ch]), Lo8(bx));
		}

		// Carrier TL
		if (Hi8(cx) != 0) {
			byte chByte = Hi8(cx);
			byte scaleAl = al;
			if ((chByte & 0x80) != 0) {
				chByte = (byte)(0 - chByte);
				scaleAl = ah;
			}
			byte shr = (byte)(4 - chByte);
			scaleAl = (byte)(scaleAl >> shr);
			byte reg = (byte)(Hi8(bx) & 0x3F);
			reg = (byte)(reg + scaleAl);
			if (reg > 0x3F) {
				reg = 0x3F;
			}
			bx = (ushort)((bx & 0x00FF) | (((Hi8(bx) & 0xC0) | reg) << 8));
			OplRegisterWrite((ushort)(0x40 + CarrierOffsets[ch]), Hi8(bx));
		}

		_channelOperatorLevel[ch] = bx;

		// Connection
		cx = _channelConnShaping[ch];
		if (Lo8(cx) == 0) {
			_channelConnMod[ch] = (ushort)((_channelConnMod[ch] & 0x00FF) | (Hi8(cx) << 8));
			return;
		}

		byte cl2 = Lo8(cx);
		byte scale = al;
		if ((cl2 & 0x80) != 0) {
			cl2 = (byte)(0 - cl2);
			scale = ah;
		}
		cl2 = (byte)(0 - (byte)(cl2 - 6));
		scale = (byte)(scale >> cl2);
		scale = (byte)(scale & 0xFE);
		scale = (byte)(scale + Hi8(cx));
		if (scale > 0x0F) {
			scale = (byte)((scale & 0x0F) | 0x0E);
		}
		_channelConnMod[ch] = (ushort)((_channelConnMod[ch] & 0x00FF) | (scale << 8));
		OplRegisterWrite((ushort)(0xC0 + ch), scale);
	}

	/// <summary>
	/// PitchBend event handler (from event dispatch).
	/// Mirrors AdpPitchBend_07EA.
	/// </summary>
	private void PitchBend(int ch, ushort eventWord) {
		byte bendValue = Hi8(eventWord);
		// DNADP 07EA semantics: mov al, ah before ReadWaitValue.
		// With AH already holding bendValue from eventWord, this yields AX = vvvv.
		// The bend body consumes full AX, so preserving this contract is critical.
		ReadWaitValue(ch);
		PitchBendBody(ch, Make16(bendValue, bendValue));
		ChannelEventDispatched?.Invoke(ch, "PBend", $"val={bendValue:X2}", _totalTickCount);
	}

	/// <summary>
	/// Pitch bend computation. Handles both portamento and non-portamento modes.
	/// Mirrors AdpPitchBendBody_07EF.
	/// </summary>
	private void PitchBendBody(int ch, ushort input) {
		byte cl = _channelNote[ch];
		byte chByte = 0;
		if (cl == 0) {
			return;
		}

		byte alInput = Lo8(input);
		ushort cx = Make16(cl, chByte);
		ushort ax = Make16(alInput, 0);
		ushort tempSwap = cx;
		cx = ax;
		ax = tempSwap;

		byte al = (byte)(Lo8(ax) - 0x18);
		byte ah = 0;
		byte bh = 0x0C;
		ushort divAx = Make16(al, ah);
		byte divQ = (byte)(divAx / bh);
		byte divR = (byte)(divAx % bh);
		ax = Make16(divQ, divR);

		tempSwap = cx;
		cx = ax;
		ax = tempSwap;
		cl = Lo8(cx);
		chByte = Hi8(cx);

		if ((_channelPitchBendFlag[ch] & 0xFF) == 0) {
			bool carryFromSub40 = ax < 0x0040;
			ax = (ushort)(ax - 0x0040);
			if (carryFromSub40) {
				ax = (ushort)(0 - ax);
				ax = RotateRight16(ax, 5);
				al = Lo8(ax);
				if (chByte >= al) {
					chByte = (byte)(chByte - al);
				} else {
					chByte = (byte)(chByte + 0x0C - al);
					cl = (byte)(cl - 1);
					if ((cl & 0x80) != 0) {
						cx = 0;
						cl = 0;
						chByte = 0;
					}
				}

				al = chByte;
				byte frac = PitchBendFractions[al];
				ah = Hi8(ax);
				ushort mul = (ushort)(frac * ah);
				al = Hi8(mul);
				byte oldCh = chByte;
				chByte = al;
				al = oldCh;
				ah = 0;
				ax = FrequencyTable[al];
				int subRes = Lo8(ax) - chByte;
				al = (byte)subRes;
				ah = (byte)(Hi8(ax) - (subRes < 0 ? 1 : 0));
				ax = Make16(al, ah);
			} else {
				ax = (ushort)(ax + 1);
				ax = RotateRight16(ax, 5);
				al = Lo8(ax);
				chByte = (byte)(chByte + al);
				if (chByte >= 0x0C) {
					chByte = (byte)(chByte - 0x0C);
					cl = (byte)(cl + 1);
				}

				al = chByte;
				byte frac = PitchBendFractions[(byte)(al + 1)];
				ah = Hi8(ax);
				ushort mul = (ushort)(frac * ah);
				al = Hi8(mul);

				byte oldCh = chByte;
				chByte = al;
				al = oldCh;
				ah = 0;
				ax = FrequencyTable[al];
				int addRes = Lo8(ax) + chByte;
				al = (byte)addRes;
				ah = (byte)(Hi8(ax) + (addRes > 0xFF ? 1 : 0));
				ax = Make16(al, ah);
			}
		} else {
			bool carryFromSub40 = ax < 0x0040;
			ax = (ushort)(ax - 0x0040);
			if (carryFromSub40) {
				ax = (ushort)(0 - ax);
				bh = 5;
				ushort divWord = ax;
				divQ = (byte)(divWord / bh);
				divR = (byte)(divWord % bh);
				if (chByte >= divQ) {
					chByte = (byte)(chByte - divQ);
				} else {
					chByte = (byte)(chByte + 0x0C - divQ);
					cl = (byte)(cl - 1);
					if ((cl & 0x80) != 0) {
						cx = 0;
						cl = 0;
						chByte = 0;
					}
				}

				al = divR;
				int tableBase = chByte >= 6 ? 5 : 0;
				byte frac = PortamentoFractions[tableBase + al];
				byte oldCh = chByte;
				chByte = frac;
				al = oldCh;
				ah = 0;
				ax = FrequencyTable[al];
				int subRes = Lo8(ax) - chByte;
				al = (byte)subRes;
				ah = (byte)(Hi8(ax) - (subRes < 0 ? 1 : 0));
				ax = Make16(al, ah);
			} else {
				bh = 5;
				ushort divWord = ax;
				divQ = (byte)(divWord / bh);
				divR = (byte)(divWord % bh);
				chByte = (byte)(chByte + divQ);
				if (chByte >= 0x0C) {
					chByte = (byte)(chByte - 0x0C);
					cl = (byte)(cl + 1);
				}

				al = divR;
				int tableBase = chByte >= 6 ? 5 : 0;
				byte frac = PortamentoFractions[tableBase + al];
				byte oldCh = chByte;
				chByte = frac;
				al = oldCh;
				ah = 0;
				ax = FrequencyTable[al];
				int addRes = Lo8(ax) + chByte;
				al = (byte)addRes;
				ah = (byte)(Hi8(ax) + (addRes > 0xFF ? 1 : 0));
				ax = Make16(al, ah);
			}
		}

		cl = (byte)(cl << 1);
		cl = (byte)(cl << 1);
		ah = (byte)(Hi8(ax) | cl);
		ax = Make16(Lo8(ax), ah);

		_channelFreq[ch] = ax;
		OplFrequencyWrite(ch, (ushort)(ax | 0x2000));
	}

	/// <summary>
	/// EndOfTrack event handler. Handles song looping and termination.
	/// Mirrors AdpEndOfTrack_066F.
	/// </summary>
	private void EndOfTrack(int ch) {
		_channelWait[ch] = 0xFFFF;
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
			SongFinished?.Invoke();
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
			OplNoteOff(ch);
		}
	}
}