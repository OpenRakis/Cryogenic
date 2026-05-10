namespace Cryogenic.AdgPlayer.Tests.Util;

using Cryogenic.AdgPlayer.Util;

/// <summary>
/// Phase 17 — pure 16-bit rotate-right utility.
/// Faithful port of <c>RotateRight16</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>: count is masked
/// modulo 16; count of zero returns input unchanged.
/// </summary>
public sealed class Bits16Tests {
	[Theory]
	[InlineData((ushort)0x1234, 0, (ushort)0x1234)]
	[InlineData((ushort)0x1234, 4, (ushort)0x4123)]
	[InlineData((ushort)0x1234, 8, (ushort)0x3412)]
	[InlineData((ushort)0x0001, 1, (ushort)0x8000)]
	[InlineData((ushort)0xABCD, 16, (ushort)0xABCD)]
	[InlineData((ushort)0xABCD, 17, (ushort)0xD5E6)]
	[InlineData((ushort)0xABCD, -15, (ushort)0xD5E6)]
	[InlineData((ushort)0x0000, 7, (ushort)0x0000)]
	public void RotateRight_MatchesOriginal(ushort value, int count, ushort expected) {
		// Act
		ushort result = Bits16.RotateRight(value, count);

		// Assert
		Assert.Equal(expected, result);
	}
}