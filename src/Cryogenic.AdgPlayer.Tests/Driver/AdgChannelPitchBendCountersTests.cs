namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgChannelPitchBendCounters"/>.
/// </summary>
public sealed class AdgChannelPitchBendCountersTests {
	/// <summary>The table holds 18 channel slots.</summary>
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		// Act
		int count = AdgChannelPitchBendCounters.ChannelCount;

		// Assert
		Assert.Equal(18, count);
	}

	/// <summary>Slots default to zero.</summary>
	[Fact]
	public void Default_AllSlotsAreZero() {
		// Arrange
		AdgChannelPitchBendCounters counters = new();

		// Act
		// Assert
		for (int i = 0; i < AdgChannelPitchBendCounters.ChannelCount; i++) {
			Assert.Equal(0, counters.Get(i));
		}
	}

	/// <summary><c>Set</c>/<c>Get</c> store per channel.</summary>
	[Fact]
	public void SetGet_StoresValuePerChannel() {
		// Arrange
		AdgChannelPitchBendCounters counters = new();

		// Act
		counters.Set(7, 0x12);

		// Assert
		Assert.Equal(0x12, counters.Get(7));
	}

	/// <summary>
	/// <c>Decrement</c> on a positive counter returns false (still ticking).
	/// </summary>
	[Fact]
	public void Decrement_PositiveCounter_DoesNotReportElapsed() {
		// Arrange
		AdgChannelPitchBendCounters counters = new();
		counters.Set(3, 4);

		// Act
		bool elapsed = counters.Decrement(3);

		// Assert
		Assert.False(elapsed);
		Assert.Equal(3, counters.Get(3));
	}

	/// <summary>
	/// <c>Decrement</c> from 1 to 0 reports elapsed.
	/// </summary>
	[Fact]
	public void Decrement_FromOne_ReportsElapsed() {
		// Arrange
		AdgChannelPitchBendCounters counters = new();
		counters.Set(0, 1);

		// Act
		bool elapsed = counters.Decrement(0);

		// Assert
		Assert.True(elapsed);
		Assert.Equal(0, counters.Get(0));
	}

	/// <summary><c>Reset</c> clears every slot.</summary>
	[Fact]
	public void Reset_ClearsAllSlots() {
		// Arrange
		AdgChannelPitchBendCounters counters = new();
		for (int i = 0; i < AdgChannelPitchBendCounters.ChannelCount; i++) {
			counters.Set(i, 0xFF);
		}

		// Act
		counters.Reset();

		// Assert
		for (int i = 0; i < AdgChannelPitchBendCounters.ChannelCount; i++) {
			Assert.Equal(0, counters.Get(i));
		}
	}
}