namespace Cryogenic.AdgPlayer.Ui.Services;

using System;

/// <summary>
/// OPL register write operations: NoteOn/Off, frequency writes, instrument loading.
/// Faithfully ported from AdpDriverCode.cs OPL-related functions.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {

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
	/// Initializes OPL chip registers and explicitly enables OPL3 (AdLib Gold)
	/// mode so that bank 1 / dual-OPL3 features are active. Every step is
	/// logged at Information level so the audio path is auditable from the UI
	/// log panel and the Serilog file sink.
	/// </summary>
	private void InitOplChip() {
		Logger.Information("OPL3 init BEGIN: synth=Opl3Chip (NukedOPL3) + Spice86.AdlibGold post-processor, native rate={Rate} Hz, mode=Opl3Gold (Opl3Fm.RenderFrame parity)", OplSynthesizer.NativeOplSampleRate);
		_opl.Reset();
		Logger.Information("OPL3 chip reset complete (rate={Rate} Hz, both banks cleared)", OplSynthesizer.NativeOplSampleRate);

		// AdLib Gold / OPL3 enable: bank 1 register 0x05 bit 0 = 1 -> OPL3 mode ON
		// (without this write the chip behaves as OPL2-compatible only).
		OplRegisterWrite(0x105, 0x01);
		Logger.Information("OPL3 mode ENABLE: reg 0x105 <- 0x01 (NEW=1, OPL3 features active, banks 0+1 addressable)");

		// 4-op connection mask: 0 -> all 9 bank-0 channels are 2-op, matching the
		// AdgPlayer core (no 4-op linking used by this driver).
		OplRegisterWrite(0x104, 0x00);
		Logger.Information("OPL3 4-op mask: reg 0x104 <- 0x00 (no 4-op linking, AdLib Gold/Opl3Gold default for DNADG)");

		// Waveform select enable (OPL2 register 0x01 bit 5).
		OplRegisterWrite(0x01, 0x20);
		Logger.Information("OPL waveform select: reg 0x001 <- 0x20 (WSE=1)");

		// Rhythm mode OFF and tremolo/vibrato depth both zeroed.
		OplRegisterWrite(0xBD, 0x00);
		Logger.Information("OPL rhythm: reg 0x0BD <- 0x00 (rhythm OFF, AM/VIB depth=0)");

		// CSM=0, NTS=1 (note-select keyboard split).
		OplRegisterWrite(0x08, 0x40);
		Logger.Information("OPL CSM/NTS: reg 0x008 <- 0x40 (CSM=0, NTS=1)");

		Logger.Information("OPL3 init COMPLETE. Identity=AdLib Gold / OPL3 Gold | banks=2 | channels=18 (9 per bank) | mixer=SoftwareMixer | resample=49716->48000 Hz");
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
	private void InstrumentWrite(int ch, ushort patchOffset) {
		byte modOp = OperatorPairTable[ch * 2];
		byte carOp = OperatorPairTable[ch * 2 + 1];

		// Write modulator operator registers
		WriteOperatorRegisters(modOp, (byte)ch, patchOffset);

		// Write carrier operator registers (offset by 0x0D in the patch)
		byte waveformAh = SongByte16((ushort)(patchOffset + 0x1B - 2));
		WriteOperatorRegisters(carOp, (byte)ch, (ushort)(patchOffset + 0x0D));
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
	private void WriteOperatorRegisters(byte opOffset, byte channel, ushort si) {
		// Connection/feedback (0xC0 + channel)
		// Only write for first operator (modulator)
		if (opOffset == OperatorPairTable[channel * 2]) {
			byte connAh = SongByte16((ushort)(si + 0x0C));
			byte connAl = 0;
			ushort connAx = Make16(connAl, connAh);
			connAx = (ushort)(connAx >> 1);
			connAh = SongByte16((ushort)(si + 0x02));
			connAl = (byte)~Lo8(connAx);
			connAx = (ushort)(Make16(connAl, connAh) << 1);
			connAh = (byte)(Hi8(connAx) & 0x0F);
			OplRegisterWrite((ushort)(0xC0 + channel), connAh);

			// Waveform from [si + 0x1A] & 0x03
			byte wave = (byte)(SongByte16((ushort)(si + 0x1A)) & 0x03);
			OplRegisterWrite((ushort)(0xE0 + opOffset), wave);
		} else {
			// Carrier waveform from the caller (high byte has it)
			byte wave = (byte)(SongByte16((ushort)(si - 0x0D + 0x1B)) & 0x03);
			OplRegisterWrite((ushort)(0xE0 + opOffset), wave);
		}

		// TL/KSL (0x40 + opOffset)
		byte tlAh = SongByte16((ushort)(si + 0x08));
		byte tlAl = SongByte16(si);
		tlAh = (byte)(tlAh << 2);
		ushort tlRot = Make16(tlAl, tlAh);
		tlRot = (ushort)((tlRot >> 2) | (tlRot << 14));
		OplRegisterWrite((ushort)(0x40 + opOffset), Hi8(tlRot));

		// Attack/Decay (0x60 + opOffset)
		byte adAh = SongByte16((ushort)(si + 0x03));
		byte adAl = SongByte16((ushort)(si + 0x06));
		adAl = (byte)(adAl << 4);
		ushort adAx = (ushort)(Make16(adAl, adAh) << 4);
		OplRegisterWrite((ushort)(0x60 + opOffset), Hi8(adAx));

		// Sustain/Release (0x80 + opOffset)
		byte srAh = SongByte16((ushort)(si + 0x04));
		byte srAl = SongByte16((ushort)(si + 0x07));
		srAl = (byte)(srAl << 4);
		ushort srAx = (ushort)(Make16(srAl, srAh) << 4);
		OplRegisterWrite((ushort)(0x80 + opOffset), Hi8(srAx));

		// AM/VIB/EG/KSR/MULT (0x20 + opOffset)
		ushort axState = 0;
		byte amByte = SongByte16((ushort)(si + 0x0B));
		axState = Make16(amByte, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		byte ksrByte = SongByte16((ushort)(si + 0x05));
		axState = Make16(ksrByte, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		byte vibByte = SongByte16((ushort)(si + 0x0A));
		axState = Make16(vibByte, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		byte egByte = SongByte16((ushort)(si + 0x09));
		axState = Make16(egByte, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		byte multByte = SongByte16((ushort)(si + 0x01));
		axState = Make16(multByte, Hi8(axState));
		axState = (ushort)(axState & 0xF00F);
		OplRegisterWrite((ushort)(0x20 + opOffset), (byte)(Hi8(axState) | Lo8(axState)));
	}
}