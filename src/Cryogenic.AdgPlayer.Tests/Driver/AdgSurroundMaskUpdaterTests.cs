namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 22 — Pure update of the AdLib Gold surround mask byte and
/// matching write to the secondary chip's <c>SecondaryControl</c>
/// register (0x04). Faithful port of the surround tail of
/// <c>AdgWriteInstrumentPatch_0F95</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c> (lines 1313-1330).
/// </summary>
public sealed class AdgSurroundMaskUpdaterTests {
	[Fact]
	public void Compute_BypassWhenBit0x10Set() {
		// Arrange — secondaryRoute bit 0x10 means "no surround update".
		// Act
		AdgSurroundMaskUpdate update = AdgSurroundMaskUpdater.Compute(
			secondaryRoute: 0x10, patchTypeByte: 0x00, currentMask: 0xFF);

		// Assert
		Assert.False(update.ShouldEmit);
		Assert.Equal((byte)0xFF, update.NewMask);
	}

	[Fact]
	public void Compute_BypassWhenPatchTypeIsFour() {
		// Arrange — patch[0] == 4 short-circuits the surround update.
		// Act
		AdgSurroundMaskUpdate update = AdgSurroundMaskUpdater.Compute(
			secondaryRoute: 0x00, patchTypeByte: 0x04, currentMask: 0xFF);

		// Assert
		Assert.False(update.ShouldEmit);
		Assert.Equal((byte)0xFF, update.NewMask);
	}

	[Theory]
	[InlineData(0x00, 0)]   // index = 0
	[InlineData(0x01, 1)]
	[InlineData(0x02, 2)]
	[InlineData(0x03, 3)]
	[InlineData(0x80, 3)]   // bit 0x80 → +3
	[InlineData(0x81, 4)]
	[InlineData(0x82, 5)]
	[InlineData(0x83, 6)]
	public void Compute_IndexFromLowTwoBitsAndSignBit(byte secondaryRoute, int expectedBitIndex) {
		// Arrange — start with all bits set so we observe exactly one cleared.
		byte currentMask = 0xFF;
		byte expectedMask = (byte)(0xFF & ~(1 << expectedBitIndex));

		// Act
		AdgSurroundMaskUpdate update = AdgSurroundMaskUpdater.Compute(
			secondaryRoute, patchTypeByte: 0x00, currentMask);

		// Assert
		Assert.True(update.ShouldEmit);
		Assert.Equal(expectedMask, update.NewMask);
	}

	[Fact]
	public void Compute_PreservesAlreadyClearedBitsInCurrentMask() {
		// Arrange — only clears its own bit; pre-cleared bits stay cleared.
		// Act — secondaryRoute=0x02 → bit 2; mask 0xF0 → result 0xF0 & ~0x04 = 0xF0.
		AdgSurroundMaskUpdate update = AdgSurroundMaskUpdater.Compute(
			secondaryRoute: 0x02, patchTypeByte: 0x00, currentMask: 0xF0);

		// Assert
		Assert.True(update.ShouldEmit);
		Assert.Equal((byte)0xF0, update.NewMask);
	}

	[Fact]
	public void Compute_BitClearedFromPartiallyMaskedState() {
		// Arrange — secondaryRoute=0x83 → bit 6; mask 0x7F → 0x7F & ~0x40 = 0x3F.
		// Act
		AdgSurroundMaskUpdate update = AdgSurroundMaskUpdater.Compute(
			secondaryRoute: 0x83, patchTypeByte: 0x00, currentMask: 0x7F);

		// Assert
		Assert.True(update.ShouldEmit);
		Assert.Equal((byte)0x3F, update.NewMask);
	}
}