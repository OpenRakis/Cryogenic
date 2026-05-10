namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Util;

/// <summary>
/// The four OPL operator register values + waveform decoded from a
/// 12-byte instrument patch.
/// </summary>
/// <param name="Waveform">Waveform select (OPL3 register 0xE0 family),
/// masked to 3 bits.</param>
/// <param name="TotalLevel">Key-Scale Level / Total Level byte (OPL
/// register 0x40 family).</param>
/// <param name="AttackDecay">Attack/Decay byte (OPL register 0x60
/// family).</param>
/// <param name="SustainRelease">Sustain/Release byte (OPL register 0x80
/// family).</param>
/// <param name="OpFlags">Tremolo/Vibrato/EG/KSR/Multiplier flags
/// (OPL register 0x20 family).</param>
public readonly record struct AdgInstrumentOperatorRegisters(
	byte Waveform,
	byte TotalLevel,
	byte AttackDecay,
	byte SustainRelease,
	byte OpFlags);

/// <summary>
/// Pure decoder: turns a 12-byte ADG instrument-operator patch (offsets
/// +0x00..+0x0B) plus an external waveform byte into the five OPL
/// register values written by <c>AdgWriteInstrumentOperator_102C</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>. No emulator state.
/// </summary>
public static class AdgInstrumentOperatorComputer {
	/// <summary>Minimum number of patch bytes required.</summary>
	public const int RequiredPatchLength = 12;

	private const ushort OpFlagsMask = 0xF00F;

	/// <summary>
	/// Decodes <paramref name="patch"/> and <paramref name="waveform"/>
	/// into the five register values written by the original routine.
	/// </summary>
	public static AdgInstrumentOperatorRegisters Compute(byte[] patch, byte waveform) {
		ArgumentNullException.ThrowIfNull(patch);
		if (patch.Length < RequiredPatchLength) {
			throw new ArgumentException(
				$"Instrument patch must contain at least {RequiredPatchLength} bytes.",
				nameof(patch));
		}

		byte waveformOut = (byte)(waveform & 0x07);

		// TotalLevel: ((Make16(p[2], (p[0xA]<<2)&0xFF) >> 2) & 0xFF) reduces
		// to (p[2] >> 2) because (p[0xA]<<2)&0xFF has bits 0..1 cleared.
		byte rawTl = (byte)(patch[0x02] & 0xFF);
		byte totalLevel = (byte)(rawTl >> 2);

		// AttackDecay = Hi8(Make16((p[8]<<4)&0xFF, p[5]) << 4)
		//             = ((p[5] & 0x0F) << 4) | (p[8] & 0x0F)
		byte attackDecay = (byte)(((patch[0x05] & 0x0F) << 4) | (patch[0x08] & 0x0F));

		// SustainRelease (same shape with p[9] and p[6]).
		byte sustainRelease = (byte)(((patch[0x06] & 0x0F) << 4) | (patch[0x09] & 0x0F));

		// OpFlags: rotate four patch bytes through bit 15 (LSB-first), then
		// inject p[1] into the low byte, mask 0xF00F, OR Hi8|Lo8.
		ushort flags = 0;
		flags = Bits16.RotateRight((ushort)((flags & 0xFF00) | patch[0x0B]), 1);
		flags = Bits16.RotateRight((ushort)((flags & 0xFF00) | patch[0x05]), 1);
		flags = Bits16.RotateRight((ushort)((flags & 0xFF00) | patch[0x0A]), 1);
		flags = Bits16.RotateRight((ushort)((flags & 0xFF00) | patch[0x09]), 1);
		flags = (ushort)((flags & 0xFF00) | patch[0x01]);
		flags = (ushort)(flags & OpFlagsMask);
		byte opFlags = (byte)((byte)(flags >> 8) | (byte)(flags & 0xFF));

		return new AdgInstrumentOperatorRegisters(
			waveformOut, totalLevel, attackDecay, sustainRelease, opFlags);
	}
}