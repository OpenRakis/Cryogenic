namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>Unit tests for <see cref="AdgPatchOffsetCalculator"/>.</summary>
public sealed class AdgPatchOffsetCalculatorTests {
	/// <summary>Patch stride matches the instrument record size (0x28).</summary>
	[Fact]
	public void PatchStride_IsHexTwentyEight() {
		// Arrange
		// Act
		// Assert
		Assert.Equal(0x28, AdgPatchOffsetCalculator.PatchStride);
	}

	/// <summary>The offset is <c>tableBase + index*0x28</c> with native 16-bit wrap.</summary>
	[Theory]
	[InlineData(0x1000, 0x00, 0x1000)]
	[InlineData(0x1000, 0x01, 0x1028)]
	[InlineData(0x0000, 0x10, 0x0280)]
	[InlineData(0xFFE0, 0x02, 0x0030)] // wraps in 16-bit
	public void OffsetFor_ReturnsBasePlusIndexTimesStride(int tableBase, int index, int expected) {
		// Arrange
		// Act
		ushort offset = AdgPatchOffsetCalculator.OffsetFor((ushort)tableBase, (byte)index);

		// Assert
		Assert.Equal((ushort)expected, offset);
	}
}