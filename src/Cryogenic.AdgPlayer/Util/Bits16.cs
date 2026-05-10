namespace Cryogenic.AdgPlayer.Util;

/// <summary>
/// Pure 16-bit bit-twiddling helpers, faithfully ported from the
/// matching helpers in <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public static class Bits16 {
	private const int WordWidth = 16;
	private const int RotateMask = WordWidth - 1;

	/// <summary>
	/// Rotates <paramref name="value"/> right by <paramref name="count"/>
	/// bits (modulo 16). A rotate count of zero returns the input
	/// unchanged. Mirrors the original <c>RotateRight16</c> helper.
	/// </summary>
	public static ushort RotateRight(ushort value, int count) {
		int normalizedCount = count & RotateMask;
		if (normalizedCount == 0) {
			return value;
		}
		return (ushort)((value >> normalizedCount) | (value << (WordWidth - normalizedCount)));
	}
}