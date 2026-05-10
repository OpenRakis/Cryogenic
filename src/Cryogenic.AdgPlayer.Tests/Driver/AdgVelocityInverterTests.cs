namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>Unit tests for <see cref="AdgVelocityInverter"/>.</summary>
public sealed class AdgVelocityInverterTests {
	/// <summary>The inverter mirrors <c>mov AL,0x80 / sub AL,velocity</c> at dnadg:0B30.</summary>
	[Theory]
	[InlineData(0x00, 0x80)]
	[InlineData(0x40, 0x40)]
	[InlineData(0x7F, 0x01)]
	[InlineData(0x80, 0x00)]
	[InlineData(0xFF, 0x81)]
	public void Inverse_ReturnsHexEightyMinusVelocityWithEightBitWrap(int velocity, int expected) {
		// Arrange
		// Act
		byte result = AdgVelocityInverter.Inverse((byte)velocity);

		// Assert
		Assert.Equal((byte)expected, result);
	}
}