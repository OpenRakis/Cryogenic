namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 12 — pure volume scaling.
/// Faithful port of <c>AdgComputeScaledVolumeFromAx</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c> (live disasm at
/// 564B:056E). Input AX → output AX, no side effects.
///
/// Expected outputs were derived by hand-running the original byte-wise
/// algorithm with constants <c>OneTwenty=0x78</c>, <c>F0Mask=0xF0</c>,
/// <c>HighNibbleWordMask=0x0FF0</c>.
/// </summary>
public sealed class AdgVolumeScalerTests {
	[Fact]
	public void Scale_Zero_ReturnsZero() {
		// Arrange + Act
		ushort result = AdgVolumeScaler.Scale(0x0000);

		// Assert
		Assert.Equal((ushort)0x0000, result);
	}

	[Fact]
	public void Scale_LowAlOnly_ReturnsAlScaled() {
		// Arrange — AL=0x40, AH=0x00. Algorithm collapses to:
		//   axOut = (0x80 * (0x40>>3)) >> 4 = (0x80 * 0x08) >> 4 = 0x40
		//   ah = 0; AX = 0x40 | 0 = 0x40
		const ushort input = 0x0040;

		// Act
		ushort result = AdgVolumeScaler.Scale(input);

		// Assert
		Assert.Equal((ushort)0x0040, result);
	}

	[Fact]
	public void Scale_BothBytes_AppliesAttenuation() {
		// Arrange — AX=0x4040 derived by hand: master 0x40, dynamics 0x40.
		// dl=0x08, first div mul1=0x220 → dh=0x02 saved.
		// Second pass clamps ah to 0x78, axOut = 0x40, OR ah(=0x02) → 0x42.
		const ushort input = 0x4040;

		// Act
		ushort result = AdgVolumeScaler.Scale(input);

		// Assert
		Assert.Equal((ushort)0x0042, result);
	}

	[Fact]
	public void Scale_MaxAlMinAh_PicksHighNibbleBand() {
		// Arrange — AL=0xFF, AH=0x00. dl=0x1F, second pass yields
		// axOut = 0x80 * 0x1F = 0xF80, >>4 = 0xF8, &0x0FF0 = 0x00F0
		// (mask zeros bits 0-3, dropping the low nibble),
		// savedHi = 0, AX = 0x00F0.
		const ushort input = 0x00FF;

		// Act
		ushort result = AdgVolumeScaler.Scale(input);

		// Assert
		Assert.Equal((ushort)0x00F0, result);
	}

	[Fact]
	public void Scale_HighAhSaturatesAndZeroesAlPath_ReturnsZero() {
		// Arrange — AL=0x00, AH=0xFF. dl=0, axOut=0; saved dh=0,
		// AX = 0.
		const ushort input = 0xFF00;

		// Act
		ushort result = AdgVolumeScaler.Scale(input);

		// Assert
		Assert.Equal((ushort)0x0000, result);
	}
}