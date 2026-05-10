namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>Unit tests for <see cref="AdgNoteFrequencyKey"/>.</summary>
public sealed class AdgNoteFrequencyKeyTests {
	/// <summary>The base note constant matches <c>note - 0x48</c> at dnadg:0AAE.</summary>
	[Fact]
	public void BaseNote_IsFourtyEight() {
		// Arrange
		// Act
		// Assert
		Assert.Equal(0x48, AdgNoteFrequencyKey.BaseNote);
	}

	/// <summary>The frequency key is <c>note - 0x48</c> in 16-bit space.</summary>
	[Theory]
	[InlineData(0x48, 0x0000)]
	[InlineData(0x49, 0x0001)]
	[InlineData(0x60, 0x0018)]
	[InlineData(0x47, 0xFFFF)] // underflow wraps via ushort
	[InlineData(0x00, 0xFFB8)]
	public void ToFrequencyKey_SubtractsBaseNoteAsUshort(int note, int expected) {
		// Arrange
		// Act
		ushort key = AdgNoteFrequencyKey.ToFrequencyKey((byte)note);

		// Assert
		Assert.Equal((ushort)expected, key);
	}
}