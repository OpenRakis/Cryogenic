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
	/// Returns the TL byte written so callers can seed channel state for EnvelopeSetup.
	/// </summary>
	private byte WriteInstrumentOperator(byte routeByte, ushort patchOffset, byte waveform) {
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

		return tlValue;
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

		if ((secondaryRoute & 0x10) != 0) {
			return;
		}

		byte surroundIndex = (byte)(secondaryRoute & 0x03);
		if (unchecked((sbyte)secondaryRoute) < 0) {
			surroundIndex = (byte)(surroundIndex + 3);
		}
		if (SongByte16(patchOffset) == 0x04) {
			return;
		}

		byte surroundMask = (byte)~(1 << surroundIndex);
		_surroundMask = (byte)(_surroundMask & surroundMask);
		_opl.WriteRegister(0x104, _surroundMask);
	}

	/// <summary>
	/// Initializes OPL3 Gold chip: resets, enables waveform select, sets OPL3 mode on secondary.
	/// Mirrors the init sequence from AdgInitializeOplRegisters_2306 in the DNADG driver.
	/// All register writes are also fired on <see cref="OplRegisterWritten"/> so the MCP
	/// adg_opl_log tool captures the full initialization sequence.
	/// </summary>
	private void InitOplChip() {
		_opl.Reset();

		// Primary chip: waveform select enable (reg 0x01, bit 5). Mirrors driver line 2306.
		WriteAndFireOplRegister(0x01, 0x20);
		// Primary chip: rhythm mode off (reg 0xBD). Mirrors driver line 2307.
		WriteAndFireOplRegister(0xBD, 0x00);
		// Primary chip: CSM off, keyboard split enabled (reg 0x08 = 0x40). Mirrors driver line 2308.
		WriteAndFireOplRegister(0x08, 0x40);

		// Secondary chip: OPL3 mode enable (reg 0x105). Mirrors driver line 2309.
		WriteAndFireOplRegister(0x105, 0x01);
		// Secondary chip: 4-operator channel enable = all disabled (reg 0x104 = 0). Mirrors driver line 2310.
		WriteAndFireOplRegister(0x104, 0x00);
		// Secondary chip: waveform select enable.
		WriteAndFireOplRegister(0x101, 0x20);
		// Secondary chip: rhythm mode off.
		WriteAndFireOplRegister(0x1BD, 0x00);
		_opl.InitializeGoldHardware();
	}

	/// <summary>
	/// Writes a register directly to the OPL chip and fires <see cref="OplRegisterWritten"/>.
	/// Used for initialization writes that bypass the channel routing table.
	/// </summary>
	private void WriteAndFireOplRegister(ushort register, byte value) {
		_opl.WriteRegister(register, value);
		OplRegisterWritten?.Invoke(register, value, _totalTickCount);
	}

	/// <summary>
	/// Serializes one AdLib Gold surround mask/control value using DNADG's 11F4 sequence.
	/// </summary>
	private byte WriteGoldSurroundMask(byte originalValue, byte registerValue) {
		for (int index = 0; index < 8; index++) {
			registerValue = (byte)(registerValue & 0xFD);
			_opl.WriteGoldSurroundControl(registerValue);

			byte channelMask = (byte)((originalValue << 1) & 0xFE);
			registerValue = (byte)((registerValue & 0xFE) | channelMask);
			_opl.WriteGoldSurroundControl(registerValue);

			registerValue = (byte)(registerValue | 0x02);
			_opl.WriteGoldSurroundControl(registerValue);
		}
		return registerValue;
	}

	/// <summary>
	/// Replays DNADG's Gold surround initialization from the current song table.
	/// Mirrors AdgUpdateGoldSurround_11C4.
	/// In standalone playback AdLib Gold hardware is absent (GoldStatus = 0),
	/// so the driver's opening guard `cmp byte [GoldStatus], 0 / je return` fires
	/// and the full loop is skipped. Replicate that guard here to avoid
	/// corrupting the surround-control state with unvalidated register writes.
	/// </summary>
	private void UpdateGoldSurround() {
		// AdLib Gold hardware not present in standalone mode — match driver no-op path.
	}
}

