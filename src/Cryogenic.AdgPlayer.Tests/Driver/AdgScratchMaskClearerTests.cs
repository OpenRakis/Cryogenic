namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Tests for <see cref="AdgScratchMaskClearer"/>, the pure port of
/// <c>AdgClearScratchMask_0ACD</c> from <c>AdgDriverCode.cs</c>.
/// </summary>
public sealed class AdgScratchMaskClearerTests {
	/// <summary>
	/// Wait counter below 0x0030 short-circuits the helper: nothing
	/// is mutated.
	/// </summary>
	[Fact]
	public void Clear_ShortWait_NoOp() {
		// Arrange
		AdgChannelStateScratch channelScratch = new();
		channelScratch.Set(3, 0x1234);
		AdgFadeScratchState fadeScratch = new();
		fadeScratch.SetPrimary(0xAAAA);
		fadeScratch.SetSecondary(0x5555);

		// Act — wait counter just under threshold.
		AdgScratchMaskClearer.Clear(channelScratch, fadeScratch,
			channelIndex: 3, waitCounter: 0x002F, nextEventByte: 0xFF);

		// Assert
		Assert.Equal(0x1234, channelScratch.Get(3));
		Assert.Equal(0xAAAA, fadeScratch.Primary);
		Assert.Equal(0x5555, fadeScratch.Secondary);
	}

	/// <summary>
	/// Long wait but next-event byte fails both gate conditions
	/// (not 0xFF, high nibble != 0xC0) → no-op.
	/// </summary>
	[Fact]
	public void Clear_GateRejected_NoOp() {
		// Arrange
		AdgChannelStateScratch channelScratch = new();
		channelScratch.Set(0, 0x4000);
		AdgFadeScratchState fadeScratch = new();
		fadeScratch.SetPrimary(0x00FF);

		// Act — high nibble 0xA0 fails 0xC0 match.
		AdgScratchMaskClearer.Clear(channelScratch, fadeScratch,
			channelIndex: 0, waitCounter: 0x0030, nextEventByte: 0xA5);

		// Assert
		Assert.Equal(0x4000, channelScratch.Get(0));
		Assert.Equal(0x00FF, fadeScratch.Primary);
	}

	/// <summary>
	/// Gate passes via terminator byte 0xFF; previous scratch with
	/// no high bit set in <c>~previousScratch</c> means high bit IS
	/// set in <c>previousScratch</c>, so the helper masks the
	/// <see cref="AdgFadeScratchState.Secondary"/> cell.
	/// </summary>
	[Fact]
	public void Clear_TerminatorByte_PrevScratchHighBitSet_MasksSecondary() {
		// Arrange — previous scratch = 0x8001 → ~ = 0x7FFE → high bit clear.
		AdgChannelStateScratch channelScratch = new();
		channelScratch.Set(5, 0x8001);
		AdgFadeScratchState fadeScratch = new();
		fadeScratch.SetPrimary(0xFFFF);
		fadeScratch.SetSecondary(0xFFFF);

		// Act
		AdgScratchMaskClearer.Clear(channelScratch, fadeScratch,
			channelIndex: 5, waitCounter: 0x0030, nextEventByte: 0xFF);

		// Assert
		Assert.Equal(0, channelScratch.Get(5));
		Assert.Equal(0xFFFF, fadeScratch.Primary);
		Assert.Equal(0x7FFE, fadeScratch.Secondary);
	}

	/// <summary>
	/// Gate passes via 0xC?-byte; previous scratch high bit clear →
	/// <c>~previousScratch</c> high bit set → helper masks the
	/// <see cref="AdgFadeScratchState.Primary"/> cell.
	/// </summary>
	[Fact]
	public void Clear_HighNibbleMatch_PrevScratchHighBitClear_MasksPrimary() {
		// Arrange — previous scratch = 0x0003 → ~ = 0xFFFC → high bit set.
		AdgChannelStateScratch channelScratch = new();
		channelScratch.Set(7, 0x0003);
		AdgFadeScratchState fadeScratch = new();
		fadeScratch.SetPrimary(0xFFFF);
		fadeScratch.SetSecondary(0xFFFF);

		// Act — 0xC4 matches the 0xC0 high-nibble gate.
		AdgScratchMaskClearer.Clear(channelScratch, fadeScratch,
			channelIndex: 7, waitCounter: 0x0040, nextEventByte: 0xC4);

		// Assert
		Assert.Equal(0, channelScratch.Get(7));
		Assert.Equal(0xFFFC, fadeScratch.Primary);
		Assert.Equal(0xFFFF, fadeScratch.Secondary);
	}

	/// <summary>
	/// Wait at exactly threshold (0x0030) passes the threshold check
	/// (the original is <c>jb</c>, i.e. unsigned less-than).
	/// </summary>
	[Fact]
	public void Clear_AtThreshold_ProcessesNormally() {
		// Arrange
		AdgChannelStateScratch channelScratch = new();
		channelScratch.Set(0, 0x0001);
		AdgFadeScratchState fadeScratch = new();
		fadeScratch.SetPrimary(0xFFFF);

		// Act
		AdgScratchMaskClearer.Clear(channelScratch, fadeScratch,
			channelIndex: 0, waitCounter: 0x0030, nextEventByte: 0xFF);

		// Assert — channel cleared, primary masked.
		Assert.Equal(0, channelScratch.Get(0));
		Assert.Equal(0xFFFE, fadeScratch.Primary);
	}

	/// <summary>
	/// The driver-state aggregate exposes the new scratch components
	/// and resets them via <see cref="AdgDriverState.Reset"/>.
	/// </summary>
	[Fact]
	public void DriverState_OwnsScratchComponents_AndResetClearsThem() {
		// Arrange
		AdgDriverState state = new();
		state.ChannelStateScratch.Set(2, 0xBEEF);
		state.FadeScratchState.SetPrimary(0xCAFE);
		state.FadeScratchState.SetSecondary(0xBABE);

		// Act
		state.Reset();

		// Assert
		Assert.Equal(0, state.ChannelStateScratch.Get(2));
		Assert.Equal(0, state.FadeScratchState.Primary);
		Assert.Equal(0, state.FadeScratchState.Secondary);
	}
}