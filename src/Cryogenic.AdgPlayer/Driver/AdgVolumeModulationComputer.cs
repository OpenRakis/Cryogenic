namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure math port of one operator's volume-scaling pass inside
/// <c>AdgVolumeModulation_0B2E</c> (oracle dnadg:0B2E). Mirrors
/// the asm sequence:
/// <code>
/// shaping = volumeShape.Lo8 (or .Hi8 for secondary)
/// scale   = directVelocity (or inverseVelocity if shaping &amp; 0x80)
/// shaping = -(shaping - 4)        // becomes (4 - shaping) modulo 256
/// scale   = scale &gt;&gt; shaping
/// new     = (level &amp; 0x3F) - scale, clamped at 0
/// new    |= (level &amp; 0xC0)        // preserve KSL bits
/// </code>
/// </summary>
public static class AdgVolumeModulationComputer {
	private const byte SignBit = 0x80;
	private const byte ShapingBias = 0x04;
	private const byte LevelMask = 0x3F;
	private const byte KeyScaleMask = 0xC0;

	/// <summary>
	/// Outcome of <see cref="ComputePrimary"/> /
	/// <see cref="ComputeSecondary"/>. <see cref="Active"/> is false
	/// when the corresponding shaping byte is zero — the operator is
	/// untouched and the cached level byte is returned unchanged.
	/// </summary>
	public readonly record struct OperatorResult(bool Active, byte NewLevel);

	/// <summary>
	/// Computes the new primary operator level from the current
	/// operator level word, the per-channel volume-modulation
	/// shape word, and the velocity bytes.
	/// </summary>
	public static OperatorResult ComputePrimary(
		ushort currentOperatorLevel, ushort volumeShape,
		byte directVelocity, byte inverseVelocity) {
		byte shaping = (byte)(volumeShape & 0xFF);
		if (shaping == 0) {
			return new OperatorResult(false, (byte)(currentOperatorLevel & 0xFF));
		}
		byte scale = directVelocity;
		if ((shaping & SignBit) != 0) {
			shaping = (byte)(0 - shaping);
			scale = inverseVelocity;
		}
		byte shift = (byte)(0 - (byte)(shaping - ShapingBias));
		scale = (byte)(scale >> shift);
		byte level = (byte)(currentOperatorLevel & 0xFF);
		byte tl = (byte)(level & LevelMask);
		tl = tl >= scale ? (byte)(tl - scale) : (byte)0;
		byte newLevel = (byte)((level & KeyScaleMask) | tl);
		return new OperatorResult(true, newLevel);
	}

	/// <summary>
	/// Computes the new secondary operator level from the current
	/// operator level word, the per-channel volume-modulation
	/// shape word, and the velocity bytes. The secondary branch
	/// uses Hi8 of <paramref name="volumeShape"/> and writes Hi8 of
	/// the returned level.
	/// </summary>
	public static OperatorResult ComputeSecondary(
		ushort currentOperatorLevel, ushort volumeShape,
		byte directVelocity, byte inverseVelocity) {
		byte shaping = (byte)((volumeShape >> 8) & 0xFF);
		if (shaping == 0) {
			return new OperatorResult(false, (byte)((currentOperatorLevel >> 8) & 0xFF));
		}
		byte scale = directVelocity;
		if ((shaping & SignBit) != 0) {
			shaping = (byte)(0 - shaping);
			scale = inverseVelocity;
		}
		byte shift = (byte)(ShapingBias - shaping);
		scale = (byte)(scale >> shift);
		byte level = (byte)((currentOperatorLevel >> 8) & 0xFF);
		byte tl = (byte)(level & LevelMask);
		tl = tl >= scale ? (byte)(tl - scale) : (byte)0;
		byte newLevel = (byte)((level & KeyScaleMask) | tl);
		return new OperatorResult(true, newLevel);
	}
}
