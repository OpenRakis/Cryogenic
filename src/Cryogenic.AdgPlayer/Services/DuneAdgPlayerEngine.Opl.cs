namespace Cryogenic.AdgPlayer.Services;

using System;

/// <summary>
/// OPL3 Gold register write operations: routing dispatch, note on/off, instrument loading.
/// Faithfully ported from AdgDriverCode.cs OPL-related functions.
/// Routing convention: route >= 0 → primary chip (A0+route); route &lt; 0 → secondary chip ((A0+(byte)route)^0x80).
/// </summary>
public sealed partial class DuneAdgPlayerEngine {

	/// <summary>
	/// Core ADG OPL3 Gold routed register write.
	/// Mirrors AdgWriteRelativeGoldRegister: adds route to registerBase,
	/// selects primary or secondary OPL3 chip based on sign of route.
	/// route >= 0 → primary chip, register = registerBase + route.
	/// route &lt; 0 → secondary chip, register = (registerBase + (byte)route) ^ 0x80, OPL3 reg 0x100+.
	/// </summary>
	private void WriteRelativeGoldRegister(byte registerBase, byte value, sbyte route) {
		byte routedRegister = (byte)(registerBase + (byte)route);
		ushort oplRegister;
		if (route < 0) {
			routedRegister = (byte)(routedRegister ^ 0x80);
			oplRegister = (ushort)(0x100 | routedRegister);
		} else {
			oplRegister = routedRegister;
		}

		_opl.WriteRegister(oplRegister, value);
		OplRegisterWritten?.Invoke(oplRegister, value, _totalTickCount);
	}

	/// <summary>
	/// Writes a channel-specific OPL3 Gold register using the channel routing table.
	/// Mirrors AdgWriteChannelRegister_10ED.
	/// </summary>
	private void WriteChannelRegister(byte registerBase, byte value, int channelIndex) {
		WriteRelativeGoldRegister(registerBase, value, unchecked((sbyte)_channelRoutingTable[channelIndex]));
	}

	/// <summary>
	/// Writes frequency low byte (A0+route) and high byte (B0+route) for a channel.
	/// Mirrors AdgWriteFrequencyWord_10E0.
	/// </summary>
	private void WriteFrequencyWord(int channelIndex, ushort frequencyWord) {
		WriteChannelRegister(0xA0, Lo8(frequencyWord), channelIndex);
		WriteChannelRegister(0xB0, Hi8(frequencyWord), channelIndex);
	}

	/// <summary>
	/// Note on: converts raw pitch to octave/semitone, looks up OPL3 frequency,
	/// stores it, and writes with key-on (bit 5 of B0 register).
	/// Mirrors AdgNoteOn_10A9.
	/// </summary>
	private void NoteOnOpl(int channelIndex, ushort rawPitch) {
		ushort noteWord = (ushort)(rawPitch + 0x30);
		if (noteWord >= 0x60) {
			noteWord = 0;
		}

		byte octave = (byte)(noteWord / 12);
		byte semitone = (byte)(noteWord % 12);
		ushort frequencyWord = FrequencyLookupTable[semitone];
		frequencyWord = Make16(Lo8(frequencyWord), (byte)(Hi8(frequencyWord) | (octave << 2)));
		_channelFrequencyWord[channelIndex] = frequencyWord;
		frequencyWord = Make16(Lo8(frequencyWord), (byte)(Hi8(frequencyWord) | 0x20));
		WriteFrequencyWord(channelIndex, frequencyWord);
	}

	/// <summary>
	/// Note off: writes the stored frequency word WITHOUT the key-on bit.
	/// Mirrors AdgNoteOff_10D8.
	/// </summary>
	private void NoteOffOpl(int channelIndex) {
		ushort frequencyWord = _channelFrequencyWord[channelIndex];
		WriteFrequencyWord(channelIndex, frequencyWord);
	}

	/// <summary>
	/// Writes one OPL3 Gold operator's registers from instrument patch data.
	/// Mirrors AdgWriteInstrumentOperator_102C.
	/// patchOffset points to the operator block within the 0x28-byte patch.
	/// waveform selects the OPL3 waveform (low 3 bits) for the E0 register.
	/// </summary>
	private void WriteInstrumentOperator(byte routeByte, ushort patchOffset, byte waveform) {
		sbyte route = unchecked((sbyte)routeByte);

		// E0+route: waveform (low 3 bits)
		WriteRelativeGoldRegister(0xE0, (byte)(waveform & 0x07), route);

		// 40+route: TL/KSL from patch bytes [0x02] (KSL) and [0x0A] (TL) — rotate-right-16 by 2
		byte tlValue = (byte)((Make16(SongByte16((ushort)(patchOffset + 0x02)), (byte)(SongByte16((ushort)(patchOffset + 0x0A)) << 2)) >> 2) & 0xFF);
		WriteRelativeGoldRegister(0x40, tlValue, route);

		// 60+route: attack/decay from [0x05] (attack) and [0x08] (decay nibble) — packed
		ushort attackDecay = (ushort)(Make16((byte)(SongByte16((ushort)(patchOffset + 0x08)) << 4), SongByte16((ushort)(patchOffset + 0x05))) << 4);
		WriteRelativeGoldRegister(0x60, Hi8(attackDecay), route);

		// 80+route: sustain/release from [0x09] (sustain nibble) and [0x06] (release)
		ushort sustainRelease = (ushort)(Make16((byte)(SongByte16((ushort)(patchOffset + 0x09)) << 4), SongByte16((ushort)(patchOffset + 0x06))) << 4);
		WriteRelativeGoldRegister(0x80, Hi8(sustainRelease), route);

		// 20+route: AM/VIB/EG/KSR/MULT packed flags
		ushort opFlags = 0;
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x0B)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x05)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x0A)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SongByte16((ushort)(patchOffset + 0x09)), Hi8(opFlags)), 1);
		opFlags = Make16(SongByte16((ushort)(patchOffset + 0x01)), Hi8(opFlags));
		opFlags = (ushort)(opFlags & 0xF00F);
		WriteRelativeGoldRegister(0x20, (byte)(Hi8(opFlags) | Lo8(opFlags)), route);
	}

	/// <summary>
	/// Writes a full instrument patch (0x28 bytes) to the OPL3 Gold for a channel.
	/// Mirrors AdgWriteInstrumentPatch_0F95.
	/// Uses channel routing table for the connection register, primary/secondary routes for operators.
	/// </summary>
	private void WriteInstrumentPatch(ushort patchOffset, int channelIndex) {
		byte channelRoute = _channelRoutingTable[channelIndex];
		byte primaryRoute = _channelPrimaryRoute[channelIndex];
		byte secondaryRoute = _channelSecondaryRoute[channelIndex];

		// C0+channelRoute: connection/feedback
		ushort connectionValue = Make16(SongByte16((ushort)(patchOffset + 0x0F)), SongByte16((ushort)(patchOffset + 0x1A)));
		connectionValue = (ushort)(connectionValue >> 1);
		connectionValue = Make16((byte)~Lo8(connectionValue), SongByte16((ushort)(patchOffset + 0x04)));
		connectionValue = (ushort)(connectionValue << 1);
		byte connectionByte = (byte)(Hi8(connectionValue) & 0x0F);
		_channelConnectionCurrent[channelIndex] = connectionByte;
		WriteRelativeGoldRegister(0xC0, connectionByte, unchecked((sbyte)channelRoute));

		// Modulator operator (primary route)
		WriteInstrumentOperator(primaryRoute, patchOffset, SongByte16((ushort)(patchOffset + 0x1C)));

		// Carrier operator (secondary route, patch offset + 0x0D)
		WriteInstrumentOperator(secondaryRoute, (ushort)(patchOffset + 0x0D), SongByte16((ushort)(patchOffset + 0x1D)));
	}

	/// <summary>
	/// Initializes OPL3 Gold chip: resets, enables waveform select, sets OPL3 mode on secondary.
	/// Mirrors the init sequence from AdgInitializeGoldHardware equivalents.
	/// </summary>
	private void InitOplChip() {
		_opl.Reset();

		// Primary chip: waveform select enable (reg 0x01, bit 5)
		_opl.WriteRegister(0x01, 0x20);
		// Primary chip: rhythm mode off
		_opl.WriteRegister(0xBD, 0x00);
		// Primary chip: CSM/keyboard split off
		_opl.WriteRegister(0x08, 0x00);

		// Secondary chip: OPL3 mode enable (reg 0x105)
		_opl.WriteRegister(0x105, 0x01);
		// Secondary chip: waveform select enable
		_opl.WriteRegister(0x101, 0x20);
		// Secondary chip: rhythm mode off
		_opl.WriteRegister(0x1BD, 0x00);
	}
}


/// <summary>
/// Writes a register/value pair to the OPL synthesizer.
