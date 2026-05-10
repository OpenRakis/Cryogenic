namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgEventOpcodeClassifier"/>.
/// </summary>
public sealed class AdgEventOpcodeClassifierTests {
	/// <summary>
	/// The classifier mirrors <c>and BX,0x0070 / shr BX,1 / shr BX,1 / shr BX,1</c>
	/// at dnadg:0784 which selects an 8-entry jump-table index.
	/// </summary>
	[Theory]
	[InlineData(0x0000, 0)]
	[InlineData(0x0010, 1)]
	[InlineData(0x0020, 2)]
	[InlineData(0x0030, 3)]
	[InlineData(0x0040, 4)]
	[InlineData(0x0050, 5)]
	[InlineData(0x0060, 6)]
	[InlineData(0x0070, 7)]
	public void Classify_ExtractsBits4Through6(int eventWord, int expectedSlot) {
		// Arrange
		// Act
		int slot = AdgEventOpcodeClassifier.Classify((ushort)eventWord);

		// Assert
		Assert.Equal(expectedSlot, slot);
	}

	/// <summary>Bits outside the 0x0070 mask must not influence the slot.</summary>
	[Theory]
	[InlineData(0xFF8F, 0)]
	[InlineData(0x12A3, 2)]
	[InlineData(0xABCD, 4)]
	[InlineData(0x80F0, 7)]
	public void Classify_IgnoresBitsOutsideMask(int eventWord, int expectedSlot) {
		// Arrange
		// Act
		int slot = AdgEventOpcodeClassifier.Classify((ushort)eventWord);

		// Assert
		Assert.Equal(expectedSlot, slot);
	}

	/// <summary>The classifier always returns one of 8 valid slots.</summary>
	[Fact]
	public void SlotCount_IsEight() {
		// Arrange
		// Act
		int count = AdgEventOpcodeClassifier.SlotCount;

		// Assert
		Assert.Equal(8, count);
	}
}