namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure mapping from a 16-bit dynamics value to an
/// <see cref="AdgFadePattern"/>. Faithful port of the threshold cascade
/// inside <c>AdgSetDynamics_564B_05BE_056A6E</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public static class AdgFadePatternSelector {
	private const ushort DynamicsThresholdSlow = 0x0060;
	private const ushort DynamicsThresholdMedium = 0x00C0;
	private const ushort DynamicsThresholdFast = 0x0180;
	private const ushort DynamicsThresholdFastest = 0x0300;

	/// <summary>
	/// Returns the fade cadence pattern selected by the original
	/// threshold cascade for <paramref name="dynamicsAx"/>.
	/// </summary>
	public static AdgFadePattern Select(ushort dynamicsAx) {
		AdgFadePattern pattern = AdgFadePattern.Immediate;
		if (dynamicsAx >= DynamicsThresholdSlow) {
			pattern = AdgFadePattern.Slow;
		}
		if (dynamicsAx >= DynamicsThresholdMedium) {
			pattern = AdgFadePattern.Medium;
		}
		if (dynamicsAx >= DynamicsThresholdFast) {
			pattern = AdgFadePattern.Fast;
		}
		if (dynamicsAx >= DynamicsThresholdFastest) {
			pattern = AdgFadePattern.Fastest;
		}
		return pattern;
	}
}