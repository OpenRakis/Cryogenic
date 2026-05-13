namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure math port of the TL-shaping passes inside
/// <c>AdgEnvelopeSetup_0C47</c> (oracle dnadg:0C47, lines 1592+
/// in <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>). Mirrors
/// the asm sequence:
/// <code>
/// shaping = tlShape.Lo8 (or .Hi8 for secondary)
/// scale   = inverseVelocity (or directVelocity if shaping &amp; 0x80)
/// shaping = -(shaping - 4)
/// scale   = scale &gt;&gt; shaping
/// new     = (level &amp; 0x3F) + scale, saturated at 0x3F
/// new    |= (level &amp; 0xC0)        // preserve KSL bits
/// </code>
/// Key contrast with <see cref="AdgVolumeModulationComputer"/>:
/// envelope shaping <strong>adds</strong> (attenuates upward) and
/// defaults to <strong>inverse</strong> velocity.
/// </summary>
public static class AdgEnvelopeTlShapingComputer {
	private const byte SignBit = 0x80;
	private const byte ShapingBias = 0x04;
	private const byte LevelMask = 0x3F;
	private const byte KeyScaleMask = 0xC0;

	/// <summary>
	/// Outcome of <see cref="ComputePrimary"/>. When
	/// <see cref="Active"/> is false the operator is untouched and
	/// the cached level byte is echoed back.
	/// </summary>
	public readonly record struct OperatorResult(bool Active, byte NewLevel);

	/// <summary>Primary operator TL-shaping pass.</summary>
	public static OperatorResult ComputePrimary(
		ushort currentOperatorLevel, ushort tlShape,
		byte directVelocity, byte inverseVelocity) {
		byte shaping = (byte)(tlShape & 0xFF);
		if (shaping == 0) {
			return new OperatorResult(false, (byte)(currentOperatorLevel & 0xFF));
		}
		byte scale = inverseVelocity;
		if ((shaping & SignBit) != 0) {
			shaping = (byte)(0 - shaping);
			scale = directVelocity;
		}
		byte shift = (byte)(0 - (byte)(shaping - ShapingBias));
		scale = (byte)(scale >> shift);
		byte level = (byte)(currentOperatorLevel & 0xFF);
		int sum = (level & LevelMask) + scale;
		byte tl = sum > LevelMask ? LevelMask : (byte)sum;
		byte newLevel = (byte)((level & KeyScaleMask) | tl);
		return new OperatorResult(true, newLevel);
	}

	/// <summary>
	/// Secondary operator TL-shaping pass. Reads Hi8 of
	/// <paramref name="tlShape"/> and writes Hi8 of the returned
	/// level. The secondary branch in the oracle computes the
	/// shift as <c>(byte)(4 - shaping)</c> (no <c>0 - …</c>
	/// negation around the subtraction) — identical arithmetic in
	/// practice when shaping has the sign bit clear.
	/// </summary>
	public static OperatorResult ComputeSecondary(
		ushort currentOperatorLevel, ushort tlShape,
		byte directVelocity, byte inverseVelocity) {
		byte shaping = (byte)((tlShape >> 8) & 0xFF);
		if (shaping == 0) {
			return new OperatorResult(false, (byte)((currentOperatorLevel >> 8) & 0xFF));
		}
		byte scale = inverseVelocity;
		if ((shaping & SignBit) != 0) {
			shaping = (byte)(0 - shaping);
			scale = directVelocity;
		}
		byte shift = (byte)(ShapingBias - shaping);
		scale = (byte)(scale >> shift);
		byte level = (byte)((currentOperatorLevel >> 8) & 0xFF);
		int sum = (level & LevelMask) + scale;
		byte tl = sum > LevelMask ? LevelMask : (byte)sum;
		byte newLevel = (byte)((level & KeyScaleMask) | tl);
		return new OperatorResult(true, newLevel);
	}
}