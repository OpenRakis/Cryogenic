namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Tests for <see cref="AdgEnvelopeTlShapingComputer"/>. Pure port
/// of the TL-shaping passes inside <c>AdgEnvelopeSetup_0C47</c>
/// (oracle lines 1592–1631 in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>).
/// </summary>
public sealed class AdgEnvelopeTlShapingComputerTests {
	/// <summary>Zero shaping byte ⇒ inactive, level echoed unchanged.</summary>
	[Fact]
	public void ComputePrimary_ZeroShaping_ReturnsInactive() {
		AdgEnvelopeTlShapingComputer.OperatorResult result =
			AdgEnvelopeTlShapingComputer.ComputePrimary(
				currentOperatorLevel: 0xAB12,
				tlShape: 0x4400,   // Lo=0 ⇒ primary inactive
				directVelocity: 0x40,
				inverseVelocity: 0x40);

		Assert.False(result.Active);
		Assert.Equal((byte)0x12, result.NewLevel);
	}

	/// <summary>
	/// B4.2b micro-cycle 2: positive shaping path. Defaults to
	/// <strong>inverse</strong> velocity (opposite of volume
	/// modulation). Trace tlShape=0x0003, level=0x0010, direct=0x40,
	/// inverse=0x40: shaping = (byte)(0 - (3 - 4)) = 0x01; scale =
	/// 0x40 &gt;&gt; 1 = 0x20; (0x10 &amp; 0x3F) + 0x20 = 0x30; not &gt; 0x3F;
	/// merge (0x10 &amp; 0xC0) = 0 → 0x30.
	/// </summary>
	[Fact]
	public void ComputePrimary_PositiveShaping_AddsWithoutSaturation() {
		AdgEnvelopeTlShapingComputer.OperatorResult result =
			AdgEnvelopeTlShapingComputer.ComputePrimary(
				currentOperatorLevel: 0x0010,
				tlShape: 0x0003,
				directVelocity: 0x40,
				inverseVelocity: 0x40);

		Assert.True(result.Active);
		Assert.Equal((byte)0x30, result.NewLevel);
	}

	/// <summary>
	/// B4.2b micro-cycle 3: positive shaping with saturation clamp
	/// at 0x3F. Trace tlShape=0x0004, level=0x0010 (KSL=0x00),
	/// inverse=0x40: shaping = (0 - (4-4)) = 0; scale = 0x40 &gt;&gt; 0 =
	/// 0x40; (0x10 &amp; 0x3F) + 0x40 = 0x50; &gt; 0x3F → saturate to
	/// 0x3F; merge 0 → 0x3F.
	/// </summary>
	[Fact]
	public void ComputePrimary_PositiveShaping_SaturatesAtThirtyFifteen() {
		AdgEnvelopeTlShapingComputer.OperatorResult result =
			AdgEnvelopeTlShapingComputer.ComputePrimary(
				currentOperatorLevel: 0x0010,
				tlShape: 0x0004,
				directVelocity: 0x40,
				inverseVelocity: 0x40);

		Assert.True(result.Active);
		Assert.Equal((byte)0x3F, result.NewLevel);
	}

	/// <summary>
	/// B4.2b micro-cycle 4: secondary operator branch with zero
	/// shaping (Hi8 of tlShape == 0) is inactive and echoes back
	/// the cached Hi8 level byte unchanged.
	/// </summary>
	[Fact]
	public void ComputeSecondary_ZeroShaping_ReturnsInactive() {
		AdgEnvelopeTlShapingComputer.OperatorResult result =
			AdgEnvelopeTlShapingComputer.ComputeSecondary(
				currentOperatorLevel: 0x55AA,
				tlShape: 0x0044,   // Hi=0 ⇒ secondary inactive
				directVelocity: 0x40,
				inverseVelocity: 0x40);

		Assert.False(result.Active);
		Assert.Equal((byte)0x55, result.NewLevel);
	}

	/// <summary>
	/// B4.2b micro-cycle 5: secondary positive-shaping path with
	/// saturation. tlShape=0x0400 (Hi=4), level=0x1000 (hi=0x10),
	/// inverse=0x40: shift = (4 - 4) = 0; scale = 0x40 &gt;&gt; 0 = 0x40;
	/// (0x10 &amp; 0x3F) + 0x40 = 0x50; saturate to 0x3F; merge KSL =
	/// 0x3F.
	/// </summary>
	[Fact]
	public void ComputeSecondary_PositiveShaping_SaturatesAndPreservesKsl() {
		AdgEnvelopeTlShapingComputer.OperatorResult result =
			AdgEnvelopeTlShapingComputer.ComputeSecondary(
				currentOperatorLevel: 0x1000,
				tlShape: 0x0400,
				directVelocity: 0x40,
				inverseVelocity: 0x40);

		Assert.True(result.Active);
		Assert.Equal((byte)0x3F, result.NewLevel);
	}
}