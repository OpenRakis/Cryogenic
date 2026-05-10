namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgChannelPitchAccumulators"/>.
/// </summary>
public sealed class AdgChannelPitchAccumulatorsTests {
	/// <summary>The table holds 18 channel slots.</summary>
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		// Act
		int count = AdgChannelPitchAccumulators.ChannelCount;

		// Assert
		Assert.Equal(18, count);
	}

	/// <summary>The center value matches the original 0x40 reset.</summary>
	[Fact]
	public void CenterValue_IsHexFourty() {
		// Arrange
		// Act
		byte center = AdgChannelPitchAccumulators.CenterValue;

		// Assert
		Assert.Equal(0x40, center);
	}

	/// <summary>Slots default to zero.</summary>
	[Fact]
	public void Default_AllSlotsAreZero() {
		// Arrange
		AdgChannelPitchAccumulators accumulators = new();

		// Act
		// Assert
		for (int i = 0; i < AdgChannelPitchAccumulators.ChannelCount; i++) {
			Assert.Equal(0, accumulators.Get(i));
		}
	}

	/// <summary><c>Set</c>/<c>Get</c> store per channel.</summary>
	[Fact]
	public void SetGet_StoresValuePerChannel() {
		// Arrange
		AdgChannelPitchAccumulators accumulators = new();

		// Act
		accumulators.Set(2, 0x55);

		// Assert
		Assert.Equal(0x55, accumulators.Get(2));
	}

	/// <summary>
	/// <c>Center(channelIndex)</c> rewrites the slot to 0x40 (matches
	/// <c>mov byte ptr [DI+0xD8],0x40</c> at dnadg:0AAB).
	/// </summary>
	[Fact]
	public void Center_RewritesSlotToHexFourty() {
		// Arrange
		AdgChannelPitchAccumulators accumulators = new();
		accumulators.Set(5, 0x12);

		// Act
		accumulators.Center(5);

		// Assert
		Assert.Equal(0x40, accumulators.Get(5));
	}

	/// <summary><c>Reset</c> clears every slot.</summary>
	[Fact]
	public void Reset_ClearsAllSlots() {
		// Arrange
		AdgChannelPitchAccumulators accumulators = new();
		for (int i = 0; i < AdgChannelPitchAccumulators.ChannelCount; i++) {
			accumulators.Set(i, 0xAB);
		}

		// Act
		accumulators.Reset();

		// Assert
		for (int i = 0; i < AdgChannelPitchAccumulators.ChannelCount; i++) {
			Assert.Equal(0, accumulators.Get(i));
		}
	}
}