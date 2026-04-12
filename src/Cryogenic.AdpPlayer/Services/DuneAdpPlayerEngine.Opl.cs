namespace Cryogenic.AdpPlayer.Services;

/// <summary>
/// OPL2 register helpers, data tables, and instrument loading — a faithful
/// translation of the DNADP driver routines decoded from the Dune CD executable.
///
/// All register writes go through OplWrite(register, data) which calls
/// Opl2Synth.WriteRegister(), mirroring the driver's helper at 0x0AA2.
///
/// Tables decoded from live memory at segment 5BAE:
///   - FrequencyTable (0x0147): 12 F-number entries C..B
///   - Op1Map (0x0171): modulator operator offsets per channel
///   - Op2Map (0x017A): carrier operator offsets per channel
///   - OperatorPairTable (0x0135): (mod, car) pairs per channel
/// </summary>
public sealed partial class DuneAdpPlayerEngine {
	// ── F-number table (12 entries, semitones C through B) ──────────────
	// Decoded from CS:0147
	private static readonly ushort[] FrequencyTable = [
		0x0157, // C
		0x016C, // C#
		0x0181, // D
		0x0198, // D#
		0x01B1, // E
		0x01CB, // F
		0x01E6, // F#
		0x0203, // G
		0x0222, // G#
		0x0243, // A
		0x0266, // A#
		0x028A  // B
	];

	// ── Operator offset maps (9 entries each) ──────────────────────────
	// Decoded from CS:0171 (modulator) and CS:017A (carrier)
	private static readonly byte[] Op1Map = [0x00, 0x01, 0x02, 0x08, 0x09, 0x0A, 0x10, 0x11, 0x12]; // modulator
	private static readonly byte[] Op2Map = [0x03, 0x04, 0x05, 0x0B, 0x0C, 0x0D, 0x13, 0x14, 0x15]; // carrier
	private static readonly byte[] PitchTable183 = [0x13, 0x15, 0x15, 0x17, 0x19, 0x1A, 0x1B, 0x1D, 0x1F, 0x21, 0x23, 0x24, 0x25];
	private static readonly byte[] PitchTable190 = [0x00, 0x05, 0x0A, 0x0F, 0x14, 0x00, 0x06, 0x0C, 0x12, 0x18];

	/// <summary>
	/// Writes a single OPL2 register. Mirrors the driver helper at 0x0AA2:
	///   out 0x388, register; delay; out 0x389, data; delay
	/// Also records the write into the OPL golden capture buffer.
	/// </summary>
	private void OplWrite(byte register, byte data) {
		_synth.WriteRegister(register, data);
		TrackOplWrite(register, data);
		RecordOplRegisterWrite(register, data, OplRegisterToChannel(register));
	}

	/// <summary>
	/// Derives the OPL channel (0-8) from a register address, or -1 if not channel-specific.
	/// </summary>
	private static int OplRegisterToChannel(byte register) {
		int low = register & 0xFF;
		// 0xA0-0xA8, 0xB0-0xB8, 0xC0-0xC8: channel = low nibble
		if (low is >= 0xA0 and <= 0xA8) {
			return low - 0xA0;
		}
		if (low is >= 0xB0 and <= 0xB8) {
			return low - 0xB0;
		}
		if (low is >= 0xC0 and <= 0xC8) {
			return low - 0xC0;
		}
		// Operator registers: 0x20-0x35, 0x40-0x55, 0x60-0x75, 0x80-0x95, 0xE0-0xF5
		// Operator offset -> channel via reverse Op1Map/Op2Map lookup
		if (low is (>= 0x20 and <= 0x35) or (>= 0x40 and <= 0x55) or (>= 0x60 and <= 0x75) or (>= 0x80 and <= 0x95) or (>= 0xE0 and <= 0xF5)) {
			int opOffset = low & 0x1F;
			for (int ch = 0; ch < 9; ch++) {
				if (Op1Map[ch] == opOffset || Op2Map[ch] == opOffset) {
					return ch;
				}
			}
		}
		return -1;
	}

	/// <summary>
	/// Note-on: compute F-number and block from MIDI-style note, write freq registers + key-on.
	/// Mirrors 0x0A58 + 0x062C:
	///   note = rawNote + transpose - 0x18 (offset 24)
	///   octave = note / 12,  semitone = note % 12
	///   fnum = FrequencyTable[semitone]
	///   Write 0xA0+ch = fnum low 8 bits
	///   Write 0xB0+ch = 0x20 (key-on) | (octave &lt;&lt; 2) | (fnum >> 8)
	/// </summary>
	private void OplNoteOn(int ch, byte rawNote) {
		int adjusted = rawNote - 0x18;
		if (adjusted < 0 || adjusted >= 96) {
			adjusted = 0;
		}

		int octave = adjusted / 12;
		int semitone = adjusted % 12;

		ushort fnum = FrequencyTable[semitone];
		byte regALow = (byte)(fnum & 0xFF);
		byte regBHigh = (byte)(0x20 | ((octave & 0x07) << 2) | ((fnum >> 8) & 0x03));

		OplWrite((byte)(0xA0 + ch), regALow);
		OplWrite((byte)(0xB0 + ch), regBHigh);

		_channelStoredFreq[ch] = (ushort)((regBHigh << 8) | regALow);
	}

	/// <summary>
	/// Note-off: clear key-on bit in register 0xB0+ch.
	/// Mirrors 0x0A87: reads stored frequency, clears bit 5 (key-on), rewrites.
	/// </summary>
	private void OplNoteOff(int ch) {
		ushort stored = _channelStoredFreq[ch];
		byte regA = (byte)(stored & 0xFF);
		byte regB = (byte)((stored >> 8) & ~0x20);

		OplWrite((byte)(0xA0 + ch), regA);
		OplWrite((byte)(0xB0 + ch), regB);
	}

	/// <summary>
	/// Sets carrier operator total level (volume) with master volume scaling.
	/// Register 0x40+carrierOp where lower 6 bits = attenuation (0=loudest, 0x3F=silent).
	///
	/// Volume byte from event stream: 0 = silent, 0x7F = loudest.
	/// Conversion: attenuation = 0x3F - (volume * masterScale / 0x7F * 0x3F / 0xFF)
	/// </summary>
	private void OplSetVolume(int ch, byte volume) {
		// Scale by master volume
		int scaled = (volume * _currentVolume) / 0x7F;
		// Convert to OPL attenuation (0x3F = silent, 0 = max)
		int attenuation = 0x3F - ((scaled * 0x3F) / 0x7F);
		if (attenuation < 0) { attenuation = 0; }
		if (attenuation > 0x3F) { attenuation = 0x3F; }

		byte carrierOp = Op2Map[ch];
		// Preserve KSL bits (top 2 bits) set during instrument load.
		byte ksl = _channelCarrierKsl[ch];
		OplWrite((byte)(0x40 + carrierOp), (byte)((ksl & 0xC0) | (attenuation & 0x3F)));
	}

	private void ApplyNoteOnShaping0740(int ch, byte noteOnShapeByte) {
		byte al = (byte)(0x80 - noteOnShapeByte);
		byte volumeByte = al;
		byte sourceByte = noteOnShapeByte;

		ushort bx = _channelReg90[ch];
		ushort cx = _channelReg7E[ch];
		bx = ApplyTlShapingPair(ch, bx, cx, volumeByte, sourceByte, true);

		_channelRegA2[ch] = bx;
		ApplyConnectionShaping071D(ch, _channelRegB4[ch], volumeByte, sourceByte);
	}

	private void ApplyVolumeShaping06A8(int ch, byte volumeData) {
		byte al = (byte)(0x80 - volumeData);
		byte volumeByte = al;
		byte sourceByte = volumeData;

		ushort bx = _channelRegA2[ch];
		ushort cx = _channelRegC6[ch];
		bx = ApplyTlShapingPair(ch, bx, cx, volumeByte, sourceByte, false);

		_channelRegA2[ch] = bx;
		ApplyConnectionShaping071D(ch, _channelRegD8[ch], volumeByte, sourceByte);
	}

	private ushort ApplyTlShapingPair(int ch, ushort bx, ushort cx, byte volumeByte, byte sourceByte, bool addMode) {
		byte bl = (byte)(bx & 0xFF);
		byte bh = (byte)(bx >> 8);
		byte cl = (byte)(cx & 0xFF);
		byte chByte = (byte)(cx >> 8);

		if (cl != 0) {
			bl = ApplyTlShapingOneOperator(ch, true, bl, cl, volumeByte, sourceByte, addMode);
		}
		if (chByte != 0) {
			bh = ApplyTlShapingOneOperator(ch, false, bh, chByte, volumeByte, sourceByte, addMode);
		}

		return (ushort)(bl | (bh << 8));
	}

	private byte ApplyTlShapingOneOperator(int ch, bool modulator, byte tlWithKsl, byte scaleRaw, byte volumeByte, byte sourceByte, bool addMode) {
		int scaleSigned = unchecked((sbyte)scaleRaw);
		int value = sourceByte;
		if (scaleSigned < 0) {
			scaleSigned = -scaleSigned;
			value = volumeByte;
		}

		int shift = 4 - scaleSigned;
		if (shift < 0) {
			shift = 0;
		}
		if (shift > 7) {
			shift = 7;
		}
		value >>= shift;

		int tl = tlWithKsl & 0x3F;
		if (addMode) {
			tl += value;
			if (tl > 0x3F) {
				tl = 0x3F;
			}
		} else {
			tl -= value;
			if (tl < 0) {
				tl = 0;
			}
		}

		byte merged = (byte)((tlWithKsl & 0xC0) | (tl & 0x3F));
		byte op = modulator ? Op1Map[ch] : Op2Map[ch];
		OplWrite((byte)(0x40 + op), merged);
		return merged;
	}

	private void ApplyConnectionShaping071D(int ch, ushort cxWord, byte volumeByte, byte sourceByte) {
		byte cl = (byte)(cxWord & 0xFF);
		if (cl == 0) {
			return;
		}
		byte chByte = (byte)(cxWord >> 8);
		int scaleSigned = unchecked((sbyte)cl);
		int value = sourceByte;
		if (scaleSigned < 0) {
			scaleSigned = -scaleSigned;
			value = volumeByte;
		}

		int shift = 6 - scaleSigned;
		if (shift < 0) {
			shift = 0;
		}
		if (shift > 7) {
			shift = 7;
		}
		value >>= shift;
		value &= 0xFE;

		int outVal = value + chByte;
		if (outVal > 0x0F) {
			outVal = (outVal & 0x0F) | 0x0E;
		}

		OplWrite((byte)(0xC0 + ch), (byte)(outVal & 0xFF));
	}

	/// <summary>
	/// Pitch bend: adjusts F-number based on bend value.
	/// Mirrors 0x07EA: modifies frequency registers without affecting key-on state.
	/// </summary>
	private void OplPitchBend(int ch, byte bendValue) {
		if (_channelNote[ch] == 0) {
			return; // No active note to bend
		}

		int note = _channelNote[ch] - 0x18;
		if (note < 0 || note >= 96) {
			note = 0;
		}

		int octave = note / 12;
		int semitone = note % 12;
		int bend = bendValue - 0x40;
		ushort freqWord;

		if (_channelReg48[ch] == 0) {
			if (bend < 0) {
				int magnitude = (-bend) / 32;
				semitone -= magnitude;
				while (semitone < 0) {
					semitone += 12;
					octave--;
				}
				if (octave < 0) {
					octave = 0;
					semitone = 0;
				}
				int frac = ((-bend) & 0x1F) * PitchTable183[semitone] / 256;
				int baseFnum = FrequencyTable[semitone];
				freqWord = (ushort)Math.Max(0, baseFnum - frac);
			} else {
				int magnitude = (bend + 1) / 32;
				semitone += magnitude;
				while (semitone >= 12) {
					semitone -= 12;
					octave++;
				}
				int tableIndex = semitone + 1;
				if (tableIndex >= PitchTable183.Length) {
					tableIndex = PitchTable183.Length - 1;
				}
				int frac = (bend & 0x1F) * PitchTable183[tableIndex] / 256;
				int baseFnum = FrequencyTable[semitone];
				freqWord = (ushort)Math.Min(0x3FF, baseFnum + frac);
			}
		} else {
			if (bend < 0) {
				int positive = -bend;
				int magnitude = positive / 5;
				semitone -= magnitude;
				while (semitone < 0) {
					semitone += 12;
					octave--;
				}
				if (octave < 0) {
					octave = 0;
					semitone = 0;
				}
				int rem = positive % 5;
				int tableIndex = rem + (semitone >= 6 ? 5 : 0);
				int frac = PitchTable190[tableIndex];
				int baseFnum = FrequencyTable[semitone];
				freqWord = (ushort)Math.Max(0, baseFnum - frac);
			} else {
				int magnitude = bend / 5;
				semitone += magnitude;
				while (semitone >= 12) {
					semitone -= 12;
					octave++;
				}
				int rem = bend % 5;
				int tableIndex = rem + (semitone >= 6 ? 5 : 0);
				int frac = PitchTable190[tableIndex];
				int baseFnum = FrequencyTable[semitone];
				freqWord = (ushort)Math.Min(0x3FF, baseFnum + frac);
			}
		}

		byte high = (byte)(((freqWord >> 8) & 0x03) | ((octave & 0x0F) << 2));
		_channelStoredFreq[ch] = (ushort)(freqWord | (high << 8));
		high |= 0x20;

		OplWrite((byte)(0xA0 + ch), (byte)(freqWord & 0xFF));
		OplWrite((byte)(0xB0 + ch), high);
	}

	/// <summary>
	/// Writes a 40-byte instrument definition to OPL2 registers.
	/// Mirrors instwrite_09AB: reads instrument from song data at eventBaseOffset,
	/// writes 6 OPL registers per operator (modulator + carrier).
	///
	/// Instrument data layout (40 bytes, decoded from driver at 0x09AB):
	///   [0x00] KSL/Level modulator       -> reg 0x40+op1
	///   [0x01] AM/VIB/EG/KSR/MULT mod    -> reg 0x20+op1
	///   [0x02] Feedback/Connection bits   -> reg 0xC0+ch (combined with [0x0C])
	///   [0x03] Attack/Decay mod           -> reg 0x60+op1
	///   [0x04] Sustain/Release mod        -> reg 0x80+op1
	///   [0x05] AM/VIB flags mod           (combined into 0x20+op1)
	///   [0x06] Attack/Decay car           -> reg 0x60+op2
	///   [0x07] Sustain/Release car        -> reg 0x80+op2
	///   [0x08] KSL/Level carrier          -> reg 0x40+op2
	///   [0x09] AM/VIB/EG/KSR bits car     (combined into 0x20+op2)
	///   [0x0A] KSR bits mod               (combined into 0x20+op1)
	///   [0x0B] MULT car                   (combined into 0x20+op2)
	///   [0x0C] Connection bit             (combined into 0xC0+ch)
	///   ...
	///   [0x1A] Waveform modulator         -> reg 0xE0+op1
	///   [0x1B] Waveform carrier           -> reg 0xE0+op2
	/// </summary>
	private void OplWriteInstrument(int ch, byte instrumentIndex) {
		byte op1 = Op1Map[ch]; // modulator
		byte op2 = Op2Map[ch]; // carrier

		// Diagnostic: bypass song instrument data and use known-good test instrument
		if (UseTestInstruments) {
			OplWrite((byte)(0x20 + op1), 0x21); // AM=0, VIB=0, EGT=1, KSR=0, MULT=1
			OplWrite((byte)(0x20 + op2), 0x21);
			OplWrite((byte)(0x40 + op1), 0x00); // Modulator: full volume
			OplWrite((byte)(0x40 + op2), 0x00); // Carrier: full volume
			_channelCarrierKsl[ch] = 0x00;
			OplWrite((byte)(0x60 + op1), 0xF0); // Fast attack, slow decay
			OplWrite((byte)(0x60 + op2), 0xF0);
			OplWrite((byte)(0x80 + op1), 0x77); // Medium sustain/release
			OplWrite((byte)(0x80 + op2), 0x77);
			OplWrite((byte)(0xE0 + op1), 0x00); // Sine wave
			OplWrite((byte)(0xE0 + op2), 0x00);
			OplWrite((byte)(0xC0 + ch), 0x01);  // FM synthesis, feedback=0
			_channelReg90[ch] = 0;
			_channelReg48[ch] = 0;
			_channelReg7E[ch] = 0;
			_channelRegA2[ch] = 0;
			_channelRegC6[ch] = 0;
			_channelRegB4[ch] = 0;
			_channelRegD8[ch] = 0;
			return;
		}

		// Instrument data starts at eventBaseOffset in the song data
		int instOffset = _eventBaseOffset + instrumentIndex * 40;
		if (instOffset + 40 > _songData.Length) {
			return; // Invalid instrument index
		}

		// DNADP 09AB: feedback/connection write (C0+channel)
		// ProgramChange does ADD SI,2 at 5BAE:0624 before CALL 09AB, so all byte
		// references inside 09AB are relative to instOffset+2 in file terms.
		// FB from inst[0x04] bits 0-2, CNT from ~inst[0x0E] bit 0.
		byte fbConn = (byte)(((_songData[instOffset + 0x04] & 0x07) << 1) | ((~_songData[instOffset + 0x0E]) & 0x01));
		OplWrite((byte)(0xC0 + ch), fbConn);

		// Modulator: base at instOffset+0x02, waveform at instOffset+0x1C
		WriteOperatorFromDnadpInstrument(op1, instOffset + 0x02, _songData[instOffset + 0x1C], ch, false);
		// Carrier: base at instOffset+0x0F, waveform at instOffset+0x1D
		WriteOperatorFromDnadpInstrument(op2, instOffset + 0x0F, _songData[instOffset + 0x1D], ch, true);

		InitializeRuntimeStateFromInstrument05AA(ch, instOffset);
	}

	private void InitializeRuntimeStateFromInstrument05AA(int ch, int instOffset) {
		ushort ax;
		ushort bx;

		ax = ReadInstrumentWord(instOffset, 0x21);
		_channelReg48[ch] = (byte)(ax & 0xFF);
		// High byte of word at inst[0x21] is the per-channel transpose (stored at [DI+0x49]).
		// NoteOn adds this to the raw note value before frequency calculation.
		_channelTranspose[ch] = (byte)((ax >> 8) & 0xFF);

		byte ah = _songData[instOffset + 0x17];
		byte al = _songData[instOffset + 0x0A];
		byte bh = _songData[instOffset + 0x02];
		byte bl = _songData[instOffset + 0x0F];
		bx = (ushort)((bh << 8) | bl);
		bx &= 0x0303;
		bx = RotateRight16(bx, 2);
		ax = (ushort)((ah << 8) | al);
		ax |= bx;
		_channelReg90[ch] = ax;
		_channelRegA2[ch] = ax;

		ax = ReadInstrumentWord(instOffset, 0x1E);
		_channelReg7E[ch] = ax;

		ax = ReadInstrumentWord(instOffset, 0x26);
		_channelRegC6[ch] = ax;

		al = _songData[instOffset + 0x0E];
		al = (byte)~al;
		al = RotateRight8(al, 1);
		ah = _songData[instOffset + 0x04];
		ax = (ushort)((ah << 8) | al);
		ax = (ushort)((ax << 1) & 0xFFFF);
		al = _songData[instOffset + 0x20];
		ax = (ushort)((ax & 0xFF00) | al);
		_channelRegB4[ch] = ax;

		al = _songData[instOffset + 0x1B];
		ax = (ushort)((ax & 0xFF00) | al);
		_channelRegD8[ch] = ax;
	}

	private ushort ReadInstrumentWord(int instOffset, int relativeOffset) {
		int pos = instOffset + relativeOffset;
		byte low = _songData[pos];
		byte high = _songData[pos + 1];
		return (ushort)(low | (high << 8));
	}

	private static byte RotateRight8(byte value, int count) {
		int c = count & 7;
		return (byte)((value >> c) | (value << (8 - c)));
	}

	/// <summary>
	/// Writes one operator using the exact field layout used by DNADP 09AB.
	/// Base offsets are 0x00 (operator 1) and 0x0D (operator 2).
	/// </summary>
	private void WriteOperatorFromDnadpInstrument(byte operatorOffset, int baseOffset, byte waveformByte, int channel, bool isCarrier) {
		// 0xE0 + op: low 2 bits of waveform byte
		byte wave = (byte)(waveformByte & 0x03);
		OplWrite((byte)(0xE0 + operatorOffset), wave);

		// 0x40 + op: packed KSL/TL from bytes [+8] and [+0] (09E6..09F7)
		// Driver: mov ah,[si+8]; mov al,[si]; shl ah,1; shl ah,1; ror ax,1; ror ax,1
		byte ahKsl = (byte)(_songData[baseOffset + 0x08] << 2); // shl ah,1 twice
		ushort ax = (ushort)((ahKsl << 8) | _songData[baseOffset + 0x00]);
		ax = RotateRight16(ax, 2);
		byte reg40 = (byte)(ax >> 8);
		OplWrite((byte)(0x40 + operatorOffset), reg40);
		if (isCarrier) {
			_channelCarrierKsl[channel] = (byte)(reg40 & 0xC0);
		}

		// 0x60 + op: packed AD from bytes [+3] and [+6] (09FA..0A14)
		ax = (ushort)((_songData[baseOffset + 0x03] << 8) | (_songData[baseOffset + 0x06] << 4));
		ax = (ushort)(ax << 4);
		OplWrite((byte)(0x60 + operatorOffset), (byte)(ax >> 8));

		// 0x80 + op: packed SR from bytes [+4] and [+7] (0A17..0A31)
		ax = (ushort)((_songData[baseOffset + 0x04] << 8) | (_songData[baseOffset + 0x07] << 4));
		ax = (ushort)(ax << 4);
		OplWrite((byte)(0x80 + operatorOffset), (byte)(ax >> 8));

		// 0x20 + op: packed AM/VIB/EG/KSR/MULT chain (0A34..0A57)
		ax = (ushort)((ax & 0xFF00) | _songData[baseOffset + 0x0B]);
		ax = RotateRight16(ax, 1);
		ax = (ushort)((ax & 0xFF00) | _songData[baseOffset + 0x05]);
		ax = RotateRight16(ax, 1);
		ax = (ushort)((ax & 0xFF00) | _songData[baseOffset + 0x0A]);
		ax = RotateRight16(ax, 1);
		ax = (ushort)((ax & 0xFF00) | _songData[baseOffset + 0x09]);
		ax = RotateRight16(ax, 1);
		ax = (ushort)((ax & 0xFF00) | _songData[baseOffset + 0x01]);
		ax &= 0xF00F;
		byte reg20 = (byte)(((ax >> 8) & 0xFF) | (ax & 0xFF));
		OplWrite((byte)(0x20 + operatorOffset), reg20);
	}

	private static ushort RotateRight16(ushort value, int count) {
		int c = count & 15;
		return (ushort)((value >> c) | (value << (16 - c)));
	}

	/// <summary>
	/// Silences all 9 OPL channels by clearing key-on bits.
	/// </summary>
	private void AllNotesOff() {
		for (int ch = 0; ch < 9; ch++) {
			OplNoteOff(ch);
			_channelNote[ch] = 0;
		}
	}

	/// <summary>
	/// Initializes the OPL2 chip: reset all registers, enable waveform select.
	/// Called during Load before any instrument/note writes.
	/// </summary>
	private void InitOpl() {
		// Test register off
		OplWrite(0x01, 0x20); // Enable waveform select (WSE bit)
		OplWrite(0x08, 0x00); // CSW/NOTE-SEL off

		// Clear all channel and operator registers
		for (byte ch = 0; ch < 9; ch++) {
			OplWrite((byte)(0xA0 + ch), 0x00);
			OplWrite((byte)(0xB0 + ch), 0x00);
			OplWrite((byte)(0xC0 + ch), 0x00);
		}
		for (byte op = 0; op < 0x16; op++) {
			// Skip operator offsets that don't exist (0x06, 0x07, 0x0E, 0x0F)
			if ((op & 0x07) >= 0x06) { continue; }
			OplWrite((byte)(0x20 + op), 0x00);
			OplWrite((byte)(0x40 + op), 0x3F); // Max attenuation (silent)
			OplWrite((byte)(0x60 + op), 0xFF); // Fast attack/decay
			OplWrite((byte)(0x80 + op), 0xFF); // Fast sustain/release
			OplWrite((byte)(0xE0 + op), 0x00); // Sine waveform
		}

		// BD register: rhythm mode off, all percussion off
		OplWrite(0xBD, 0x00);
	}
}