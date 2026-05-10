namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 14 — fade-pattern selection from a 16-bit dynamics input.
/// Faithful port of the cascade inside
/// <c>AdgSetDynamics_564B_05BE_056A6E</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>:
///   pattern = Immediate
///   if (AX >= 0x0060) pattern = Slow
///   if (AX >= 0x00C0) pattern = Medium
///   if (AX >= 0x0180) pattern = Fast
///   if (AX >= 0x0300) pattern = Fastest
/// (Each comparison overrides the previous because the original code
/// uses a sequence of <c>cmp; mov BX,...</c> without early exit.)
/// </summary>
public sealed class AdgFadePatternSelectorTests {
	[Theory]
	[InlineData((ushort)0x0000, AdgFadePattern.Immediate)]
	[InlineData((ushort)0x005F, AdgFadePattern.Immediate)]
	[InlineData((ushort)0x0060, AdgFadePattern.Slow)]
	[InlineData((ushort)0x00BF, AdgFadePattern.Slow)]
	[InlineData((ushort)0x00C0, AdgFadePattern.Medium)]
	[InlineData((ushort)0x017F, AdgFadePattern.Medium)]
	[InlineData((ushort)0x0180, AdgFadePattern.Fast)]
	[InlineData((ushort)0x02FF, AdgFadePattern.Fast)]
	[InlineData((ushort)0x0300, AdgFadePattern.Fastest)]
	[InlineData((ushort)0xFFFF, AdgFadePattern.Fastest)]
	public void Select_PicksPatternByThreshold(ushort dynamicsAx, AdgFadePattern expected) {
		// Act
		AdgFadePattern result = AdgFadePatternSelector.Select(dynamicsAx);

		// Assert
		Assert.Equal(expected, result);
	}
}