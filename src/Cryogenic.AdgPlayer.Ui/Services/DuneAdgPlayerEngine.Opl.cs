namespace Cryogenic.AdgPlayer.Ui.Services;

/// <summary>
/// OPL register write operations for the ADG (AdLib Gold) standalone player.
/// Method names mirror the game driver equivalents in AdgDriverCode.cs for traceability.
/// The standalone player maps DNADG primary/secondary FM writes onto the two OPL3 banks
/// exposed by the NukedOPL3 core (0x000-0x0FF primary, 0x100-0x1FF secondary).
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
	private const ushort Opl3SecondaryBankBase = 0x0100;
	private const ushort GoldLogicalRegisterBase = 0x0200;

	/// <summary>Frequency word table: computed frequency for each logical channel (18 entries).</summary>
	private readonly ushort[] _adgFrequencyWordTable = new ushort[ChannelCount];

	/// <summary>
	/// Writes a value to an OPL register.
	/// Mirrors AdgWritePrimaryRegisterDirect in AdgDriverCode.cs.
	/// </summary>
	private void OplRegisterWrite(ushort register, byte value) {
		_opl.WriteRegister(register, value);
		TraceRegisterWrite(register, value);
	}

	/// <summary>
	/// Emits one logical register write into the diagnostics stream.
	/// </summary>
	private void TraceRegisterWrite(ushort register, byte value) {
		OplRegisterWritten?.Invoke(register, value, _totalTickCount);
	}

	/// <summary>
	/// Applies one AdLib Gold control-register write through the Spice86 Gold stack and records it in traces.
	/// </summary>
	private void GoldControlWrite(byte register, byte value) {
		_opl.WriteGoldControlRegister(register, value);
		TraceRegisterWrite((ushort)(GoldLogicalRegisterBase | register), value);
	}

	/// <summary>
	/// Computes the banked OPL3 register address for a DNADG routed write.
	/// Primary routes stay on bank 0; secondary routes keep the same per-bank register
	/// index but move to bank 1, matching AdgWriteRelativeGoldRegister in the override.
	/// </summary>
	private static ushort ComputeGoldBankedRegister(byte registerBase, sbyte route) {
		byte routedRegister = (byte)(registerBase + (byte)route);
		if (route < 0) {
			routedRegister = (byte)(routedRegister ^ 0x80);
			return (ushort)(Opl3SecondaryBankBase | routedRegister);
		}

		return routedRegister;
	}

	/// <summary>
	/// Applies a routed register write where route is the operator or channel offset
	/// added to the register base to yield the absolute OPL register address.
	/// Mirrors AdgWriteRelativeGoldRegister in AdgDriverCode.cs.
	/// </summary>
	private void AdgWriteRelativeGoldRegister(byte registerBase, byte registerValue, sbyte route) {
		OplRegisterWrite(ComputeGoldBankedRegister(registerBase, route), registerValue);
	}

	/// <summary>
	/// Writes frequency low and high bytes (A0+ch, B0+ch) to OPL.
	/// Mirrors AdgWriteFrequencyWord_10E0 in AdgDriverCode.cs.
	/// </summary>
	private void AdgWriteFrequencyWord(ushort channelIndex, ushort frequencyWord) {
		sbyte channelRoute = unchecked((sbyte)_channelRoute[channelIndex]);
		OplRegisterWrite(ComputeGoldBankedRegister(0xA0, channelRoute), Lo8(frequencyWord));
		OplRegisterWrite(ComputeGoldBankedRegister(0xB0, channelRoute), Hi8(frequencyWord));
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
	/// Initializes the OPL3 banks used by DNADG.
	/// Mirrors the FM-visible part of AdgInit_564B_04FF_0569AF.
	/// </summary>
	private void InitOplChip() {
		_opl.Reset();
		OplRegisterWrite(0x01, 0x20);
		OplRegisterWrite(0xBD, 0x00);
		OplRegisterWrite(0x08, 0x40);
		OplRegisterWrite(0x105, 0x01);
		OplRegisterWrite(0x104, 0x00);
	}

	/// <summary>
	/// Clears sustain/release across both FM banks before a new song starts.
	/// Mirrors AdgSilenceGoldChannels_0F53 in AdgDriverCode.cs.
	/// </summary>
	private void SilenceGoldChannels() {
		for (int registerOffset = 0; registerOffset <= 0x15; registerOffset++) {
			if (registerOffset == 0x06 || registerOffset == 0x07 || registerOffset == 0x0E || registerOffset == 0x0F) {
				continue;
			}

			ushort registerIndex = (ushort)(0x80 + registerOffset);
			OplRegisterWrite(registerIndex, 0xFF);
			OplRegisterWrite((ushort)(Opl3SecondaryBankBase | registerIndex), 0xFF);
		}
	}

	/// <summary>
	/// Writes a full instrument patch to the OPL for a channel.
	/// Mirrors AdgWriteInstrumentPatch_0F95 in AdgDriverCode.cs.
	/// </summary>
	private void InstrumentWrite(int ch, ushort instOff) {
		sbyte modRoute = unchecked((sbyte)_channelPrimaryOpRoute[ch]);
		sbyte carRoute = unchecked((sbyte)_channelSecondaryOpRoute[ch]);
		sbyte channelRoute = unchecked((sbyte)_channelRoute[ch]);

		ushort conn = Make16(SongByte16((ushort)(instOff + 0x0F)), SongByte16((ushort)(instOff + 0x1A)));
		conn = (ushort)(conn >> 1);
		conn = Make16((byte)~Lo8(conn), SongByte16((ushort)(instOff + 0x04)));
		conn = (ushort)(conn << 1);
		AdgWriteRelativeGoldRegister(0xC0, (byte)(Hi8(conn) & 0x0F), channelRoute);

		byte waveformMod = SongByte16((ushort)(instOff + 0x1C));
		WriteOperatorRegistersAdg(modRoute, instOff, waveformMod);

		byte waveformCar = SongByte16((ushort)(instOff + 0x1D));
		WriteOperatorRegistersAdg(carRoute, (ushort)(instOff + 0x0D), waveformCar);
	}

	/// <summary>
	/// Writes the OPL registers for one operator from ADG patch data.
	/// Mirrors AdgWriteInstrumentOperator_102C in AdgDriverCode.cs.
	/// route is the routed operator offset; patchOffset is the base in song data.
	/// </summary>
	private void WriteOperatorRegistersAdg(sbyte route, ushort patchOffset, byte waveform) {
		AdgWriteRelativeGoldRegister(0xE0, (byte)(waveform & 0x07), route);

		byte tlValue = (byte)((Make16(SongByte16((ushort)(patchOffset + 0x02)),
			(byte)(SongByte16((ushort)(patchOffset + 0x0A)) << 2)) >> 2) & 0xFF);
		AdgWriteRelativeGoldRegister(0x40, tlValue, route);

		ushort attackDecay = (ushort)(Make16(
			(byte)(SongByte16((ushort)(patchOffset + 0x08)) << 4),
			SongByte16((ushort)(patchOffset + 0x05))) << 4);
		AdgWriteRelativeGoldRegister(0x60, Hi8(attackDecay), route);

		ushort sustainRelease = (ushort)(Make16(
			(byte)(SongByte16((ushort)(patchOffset + 0x09)) << 4),
			SongByte16((ushort)(patchOffset + 0x06))) << 4);
		AdgWriteRelativeGoldRegister(0x80, Hi8(sustainRelease), route);

		ushort opFlags = 0;
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x0B)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x05)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x0A)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x09)), Hi8(opFlags)), 1);
		opFlags = Make16(SongByte16((ushort)(patchOffset + 0x01)), Hi8(opFlags));
		opFlags = (ushort)(opFlags & 0xF00F);
		AdgWriteRelativeGoldRegister(0x20, (byte)(Hi8(opFlags) | Lo8(opFlags)), route);
	}
}