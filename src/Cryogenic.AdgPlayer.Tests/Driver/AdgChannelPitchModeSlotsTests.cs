namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgChannelPitchModeSlots"/>.
/// </summary>
public sealed class AdgChannelPitchModeSlotsTests {
	/// <summary>The table holds 18 channel slots.</summary>
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		// Act
		int count = AdgChannelPitchModeSlots.ChannelCount;

		// Assert
		Assert.Equal(18, count);
	}

	/// <summary>Slots default to zero (mode disabled).</summary>
	[Fact]
	public void Default_AllSlotsAreZero() {
		// Arrange
		AdgChannelPitchModeSlots slots = new();

		// Act
		// Assert
		for (int i = 0; i < AdgChannelPitchModeSlots.ChannelCount; i++) {
			Assert.Equal(0, slots.Get(i));
		}
	}

	/// <summary><c>Set</c>/<c>Get</c> store the per-channel pitch-mode byte.</summary>
	[Fact]
	public void SetGet_StoresValuePerChannel() {
		// Arrange
		AdgChannelPitchModeSlots slots = new();

		// Act
		slots.Set(1, 0x40);
		slots.Set(12, 0x80);

		// Assert
		Assert.Equal(0x40, slots.Get(1));
		Assert.Equal(0x80, slots.Get(12));
	}

	/// <summary><c>Reset</c> clears every slot.</summary>
	[Fact]
	public void Reset_ClearsAllSlots() {
		// Arrange
		AdgChannelPitchModeSlots slots = new();
		for (int i = 0; i < AdgChannelPitchModeSlots.ChannelCount; i++) {
			slots.Set(i, 0xFF);
		}

		// Act
		slots.Reset();

		// Assert
		for (int i = 0; i < AdgChannelPitchModeSlots.ChannelCount; i++) {
			Assert.Equal(0, slots.Get(i));
		}
	}

	/// <summary>Out-of-range access throws.</summary>
	[Fact]
	public void Get_OutOfRange_Throws() {
		// Arrange
		AdgChannelPitchModeSlots slots = new();

		// Act
		// Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => slots.Get(-1));
		Assert.Throws<ArgumentOutOfRangeException>(() => slots.Get(18));
	}
}