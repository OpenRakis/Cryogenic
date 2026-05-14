namespace Cryogenic.AdgPlayer.Ui.Services;

/// <summary>
/// OPL register write operations for the ADG (AdLib Gold) standalone player.
/// Method names mirror the game driver equivalents in AdgDriverCode.cs for traceability.
/// Single-chip OPL3 mode: all 9 channels use the primary chip registers 0x00–0xFF.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {

	/// <summary>Frequency word table: computed frequency for each channel (9 entries).</summary>
	private readonly ushort[] _adgFrequencyWordTable = new ushort[ChannelCount];

	/// <summary>
	/// Writes a value to an OPL register.
	/// Mirrors AdgWritePrimaryRegisterDirect in AdgDriverCode.cs.
	/// </summary>
	private void OplRegisterWrite(ushort register, byte value) {
		_opl.WriteRegister(register, value);
		OplRegisterWritten?.Invoke(register, value, _totalTickCount);
	}

	/// <summary>
	/// Applies a routed register write where route is the operator or channel offset
	/// added to the register base to yield the absolute OPL register address.
	/// Mirrors AdgWriteRelativeGoldRegister in AdgDriverCode.cs (primary chip path only).
	/// </summary>
	private void AdgWriteRelativeGoldRegister(byte registerBase, byte registerValue, sbyte route) {
		OplRegisterWrite((ushort)(registerBase + (byte)route), registerValue);
	}

	/// <summary>
	/// Writes frequency low and high bytes (A0+ch, B0+ch) to OPL.
	/// Mirrors AdgWriteFrequencyWord_10E0 in AdgDriverCode.cs.
	/// </summary>
	private void AdgWriteFrequencyWord(ushort channelIndex, ushort frequencyWord) {
		OplRegisterWrite((ushort)(0xA0 + channelIndex), Lo8(frequencyWord));
		OplRegisterWrite((ushort)(0xB0 + channelIndex), Hi8(frequencyWord));
	}

	/// <summary>
	/// Note on: converts raw pitch to octave/semitone, looks up frequency, writes with key-on bit.
	/// Mirrors AdgNoteOn_10A9 in AdgDriverCode.cs.
	/// </summary>
	private void AdgNoteOn(ushort channelIndex, ushort rawPitch) {
		ushort noteWord = (ushort)(rawPitch + 0x0030);
		if (noteWord >= 0x0060) {
			noteWord = 0;
		}

		byte octave = (byte)(noteWord / 12);
		byte semitone = (byte)(noteWord % 12);
		ushort frequencyWord = FrequencyTable[semitone];
		frequencyWord = Make16(Lo8(frequencyWord), (byte)(Hi8(frequencyWord) | (octave << 2)));
		_adgFrequencyWordTable[channelIndex] = frequencyWord;
		AdgWriteFrequencyWord(channelIndex, (ushort)(frequencyWord | 0x2000));
	}

	/// <summary>
	/// Note off: writes stored frequency WITHOUT key-on bit.
	/// Mirrors AdgNoteOff_10D8 in AdgDriverCode.cs.
	/// </summary>
	private void AdgNoteOff(ushort channelIndex) {
		ushort frequencyWord = _adgFrequencyWordTable[channelIndex];
		AdgWriteFrequencyWord(channelIndex, frequencyWord);
	}

	/// <summary>
	/// Initializes OPL chip registers (waveform enable, rhythm off).
	/// Mirrors the ADG init sequence from AdgDriverCode.cs.
	/// </summary>
	private void InitOplChip() {
		_opl.Reset();
		OplRegisterWrite(0x01, 0x20);   // Waveform select enable
		OplRegisterWrite(0xBD, 0x00);   // Rhythm mode off
		OplRegisterWrite(0x08, 0x40);   // CSM/keyboard split
	}

	/// <summary>
	/// Writes 0xFF to all 18 operator sustain/release registers.
	/// Mirrors AdgSilenceGoldChannels_0F53 in AdgDriverCode.cs.
	/// </summary>
	private void InitTotalLevels() {
		for (int i = 0; i < 9; i++) {
			OplRegisterWrite((ushort)(0x80 + ModulatorOffsets[i]), 0xFF);
			OplRegisterWrite((ushort)(0x80 + CarrierOffsets[i]), 0xFF);
		}
	}

	/// <summary>
	/// Writes a full instrument patch to the OPL for a channel.
	/// Mirrors AdgWriteInstrumentPatch_0F95 in AdgDriverCode.cs.
	/// Uses static routing (ModulatorOffsets/CarrierOffsets) in place of the
	/// dynamic routing table that AdgConfigureInstrumentRouting_090D builds in-game.
	/// </summary>
	private void InstrumentWrite(int ch, ushort instOff) {
		byte modRoute = ModulatorOffsets[ch];
		byte carRoute = CarrierOffsets[ch];

		// C0: feedback/connection — mirrors AdgWriteInstrumentPatch_0F95 connection path.
		// Fields: patchOffset+0x0F (lo), patchOffset+0x1A (hi), patchOffset+0x04 (feedback).
		ushort conn = Make16(SongByte16((ushort)(instOff + 0x0F)), SongByte16((ushort)(instOff + 0x1A)));
		conn = (ushort)(conn >> 1);
		conn = Make16((byte)~Lo8(conn), SongByte16((ushort)(instOff + 0x04)));
		conn = (ushort)(conn << 1);
		OplRegisterWrite((ushort)(0xC0 + ch), (byte)(Hi8(conn) & 0x0F));

		// Modulator operator — waveform from patchOffset+0x1C.
		byte waveformMod = SongByte16((ushort)(instOff + 0x1C));
		WriteOperatorRegistersAdg(modRoute, instOff, waveformMod);

		// Carrier operator — base at patchOffset+0x0D, waveform from patchOffset+0x1D.
		byte waveformCar = SongByte16((ushort)(instOff + 0x1D));
		WriteOperatorRegistersAdg(carRoute, (ushort)(instOff + 0x0D), waveformCar);
	}

	/// <summary>
	/// Writes the OPL registers for one operator from ADG patch data.
	/// Mirrors AdgWriteInstrumentOperator_102C in AdgDriverCode.cs.
	/// routeByte is the operator register offset; patchOffset is the base in song data.
	/// </summary>
	private void WriteOperatorRegistersAdg(byte routeByte, ushort patchOffset, byte waveform) {
		// E0: waveform select
		OplRegisterWrite((ushort)(0xE0 + routeByte), (byte)(waveform & 0x07));

		// 40: TL/KSL — Make16(lo=patchOffset+0x02, hi=(patchOffset+0x0A)<<2) >> 2, take low byte.
		byte tlValue = (byte)((Make16(SongByte16((ushort)(patchOffset + 0x02)),
			(byte)(SongByte16((ushort)(patchOffset + 0x0A)) << 2)) >> 2) & 0xFF);
		OplRegisterWrite((ushort)(0x40 + routeByte), tlValue);

		// 60: Attack/Decay — Make16(lo=(decay<<4), hi=attack) << 4, take high byte.
		ushort attackDecay = (ushort)(Make16(
			(byte)(SongByte16((ushort)(patchOffset + 0x08)) << 4),
			SongByte16((ushort)(patchOffset + 0x05))) << 4);
		OplRegisterWrite((ushort)(0x60 + routeByte), Hi8(attackDecay));

		// 80: Sustain/Release — same packing with sustain(+0x09)/release(+0x06).
		ushort sustainRelease = (ushort)(Make16(
			(byte)(SongByte16((ushort)(patchOffset + 0x09)) << 4),
			SongByte16((ushort)(patchOffset + 0x06))) << 4);
		OplRegisterWrite((ushort)(0x80 + routeByte), Hi8(sustainRelease));

		// 20: AM/VIB/EG/KSR/MULT — four RotateRight16-by-1 accumulations then mask.
		ushort opFlags = 0;
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x0B)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x05)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x0A)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x09)), Hi8(opFlags)), 1);
		opFlags = Make16(SongByte16((ushort)(patchOffset + 0x01)), Hi8(opFlags));
		opFlags = (ushort)(opFlags & 0xF00F);
		OplRegisterWrite((ushort)(0x20 + routeByte), (byte)(Hi8(opFlags) | Lo8(opFlags)));
	}
}