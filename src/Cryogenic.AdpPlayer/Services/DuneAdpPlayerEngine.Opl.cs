namespace Cryogenic.AdpPlayer.Services;

using System;

/// <summary>
/// OPL register write operations: NoteOn/Off, frequency writes, instrument loading.
/// Faithfully ported from AdpDriverCode.cs OPL-related functions.
/// </summary>
public sealed partial class DuneAdpPlayerEngine {

	/// <summary>
	/// Writes a register/value pair to the OPL synthesizer.
	/// Mirrors AdpOplRegisterWrite_0AA2 (port 0x388/0x389).
	/// </summary>
	private void OplRegisterWrite(ushort register, byte value) {
		_opl.WriteRegister(register, value);
		OplRegisterWritten?.Invoke(register, value, _totalTickCount);
	}

	/// <summary>
	/// Writes frequency low and high bytes (A0+ch, B0+ch) to OPL.
	/// Mirrors AdpOplFrequencyWrite_0A8F.
	/// </summary>
	private void OplFrequencyWrite(int ch, ushort freqWord) {
		OplRegisterWrite((ushort)(0xA0 + ch), Lo8(freqWord));
		OplRegisterWrite((ushort)(0xB0 + ch), Hi8(freqWord));
	}

	/// <summary>
	/// Note on: converts raw pitch to octave/semitone, looks up frequency,
	/// writes with key-on bit.
	/// Mirrors AdpOplNoteOn_0A58.
	/// </summary>
	private void OplNoteOn(int ch, ushort rawPitch) {
		ushort ax = (ushort)(rawPitch + 0x30);
		if (ax >= 0x60) {
			ax = 0;
		}

		byte octave = (byte)(ax / 0x0C);
		byte semitone = (byte)(ax % 0x0C);

		ushort freq = FrequencyTable[semitone];
		byte blockBits = (byte)(octave << 2);
		freq = Make16(Lo8(freq), (byte)(Hi8(freq) | blockBits));

		_channelFreq[ch] = freq;
		OplFrequencyWrite(ch, (ushort)(freq | 0x2000));
	}

	/// <summary>
	/// Note off: writes stored frequency WITHOUT key-on bit.
	/// Mirrors AdpOplNoteOff_0A87.
	/// </summary>
	private void OplNoteOff(int ch) {
		ushort freq = _channelFreq[ch];
		OplFrequencyWrite(ch, freq);
	}

	/// <summary>
	/// Initializes OPL chip registers (waveform enable, rhythm off, OPL3 mode).
	/// Mirrors the init sequence from AdpInit_02D8.
	/// </summary>
	private void InitOplChip() {
		_opl.Reset();
		// Enable waveform select (register 0x01, bit 5)
		OplRegisterWrite(0x20, 0x01);
		// Rhythm mode off
		OplRegisterWrite(0xBD, 0x00);
		// CSM/keyboard split (register 0x08, bit 6)
		OplRegisterWrite(0x08, 0x40);
	}

	/// <summary>
	/// Writes 0xFF to all 18 operator sustain/release registers (0x80+offset).
	/// Mirrors AdpUnknown099A.
	/// </summary>
	private void InitTotalLevels() {
		for (int i = 0; i < 18; i++) {
			byte offset;
			if (i < 9) {
				offset = ModulatorOffsets[i];
			} else {
				offset = CarrierOffsets[i - 9];
			}
			OplRegisterWrite((ushort)(0x80 + offset), 0xFF);
		}
	}

	/// <summary>
	/// Writes a full instrument patch (40 bytes) to the OPL for a channel.
	/// Mirrors AdpInstrumentWrite_09AB and AdpInstrumentWriteLoop_09C3.
	/// </summary>
	private void InstrumentWrite(int ch, int patchOffset) {
		byte modOp = OperatorPairTable[ch * 2];
		byte carOp = OperatorPairTable[ch * 2 + 1];

		// Write modulator operator registers
		WriteOperatorRegisters(modOp, (byte)ch, patchOffset);

		// Write carrier operator registers (offset by 0x0D in the patch)
		byte waveformAh = SongByte(patchOffset + 0x1B - 2);
		WriteOperatorRegisters(carOp, (byte)ch, patchOffset + 0x0D);
	}

	/// <summary>
	/// Writes the 6 OPL registers for a single operator from instrument patch data.
	/// Mirrors the combined AdpInstrumentWriteLoop_09C3 + AdpInstrumentWriteLoopFrom09DC.
	/// Patch layout (relative to si, where si points to patch+2 for modulator):
	///   [0x00]=TL_level, [0x01]=MULT, [0x02]=connection/feedback, [0x03]=attack,
	///   [0x04]=sustain, [0x05]=KSR, [0x06]=decay, [0x07]=release,
	///   [0x08]=KSL, [0x09]=EG, [0x0A]=VIB, [0x0B]=AM, [0x0C]=waveform_half,
	///   [0x1A]=waveform (for first op), [0x1B]=waveform (for second op).
	/// </summary>
	private void WriteOperatorRegisters(byte opOffset, byte channel, int si) {
		// Connection/feedback (0xC0 + channel)
		// Only write for first operator (modulator)
		if (opOffset == OperatorPairTable[channel * 2]) {
			byte connAh = SongByte(si + 0x0C);
			byte connAl = 0;
			ushort connAx = Make16(connAl, connAh);
			connAx = (ushort)(connAx >> 1);
			connAh = SongByte(si + 0x02);
			connAl = (byte)~Lo8(connAx);
			connAx = (ushort)(Make16(connAl, connAh) << 1);
			connAh = (byte)(Hi8(connAx) & 0x0F);
			OplRegisterWrite((ushort)(0xC0 + channel), connAh);

			// Waveform from [si + 0x1A] & 0x03
			byte wave = (byte)(SongByte(si + 0x1A) & 0x03);
			OplRegisterWrite((ushort)(0xE0 + opOffset), wave);
		} else {
			// Carrier waveform from the caller (high byte has it)
			byte wave = (byte)(SongByte(si - 0x0D + 0x1B) & 0x03);
			OplRegisterWrite((ushort)(0xE0 + opOffset), wave);
		}

		// TL/KSL (0x40 + opOffset)
		byte tlAh = SongByte(si + 0x08);
		byte tlAl = SongByte(si);
		tlAh = (byte)(tlAh << 2);
		ushort tlRot = Make16(tlAl, tlAh);
		tlRot = (ushort)((tlRot >> 2) | (tlRot << 14));
		OplRegisterWrite((ushort)(0x40 + opOffset), Hi8(tlRot));

		// Attack/Decay (0x60 + opOffset)
		byte adAh = SongByte(si + 0x03);
		byte adAl = SongByte(si + 0x06);
		adAl = (byte)(adAl << 4);
		ushort adAx = (ushort)(Make16(adAl, adAh) << 4);
		OplRegisterWrite((ushort)(0x60 + opOffset), Hi8(adAx));

		// Sustain/Release (0x80 + opOffset)
		byte srAh = SongByte(si + 0x04);
		byte srAl = SongByte(si + 0x07);
		srAl = (byte)(srAl << 4);
		ushort srAx = (ushort)(Make16(srAl, srAh) << 4);
		OplRegisterWrite((ushort)(0x80 + opOffset), Hi8(srAx));

		// AM/VIB/EG/KSR/MULT (0x20 + opOffset)
		ushort axState = 0;
		byte amByte = SongByte(si + 0x0B);
		axState = Make16(amByte, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		byte ksrByte = SongByte(si + 0x05);
		axState = Make16(ksrByte, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		byte vibByte = SongByte(si + 0x0A);
		axState = Make16(vibByte, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		byte egByte = SongByte(si + 0x09);
		axState = Make16(egByte, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		byte multByte = SongByte(si + 0x01);
		axState = Make16(multByte, Hi8(axState));
		axState = (ushort)(axState & 0xF00F);
		OplRegisterWrite((ushort)(0x20 + opOffset), (byte)(Hi8(axState) | Lo8(axState)));
	}
}