namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgChannelWaitCounters"/>.
/// </summary>
public sealed class AdgChannelWaitCountersTests {
	/// <summary>The table holds 18 channel slots.</summary>
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		// Act
		int count = AdgChannelWaitCounters.ChannelCount;

		// Assert
		Assert.Equal(18, count);
	}

	/// <summary>All counters are zero by default.</summary>
	[Fact]
	public void Default_AllCountersAreZero() {
		// Arrange
		AdgChannelWaitCounters counters = new();

		// Act
		// Assert
		for (int i = 0; i < AdgChannelWaitCounters.ChannelCount; i++) {
			Assert.Equal(0, counters.Get(i));
		}
	}

	/// <summary><c>Set</c> stores the value at the requested index without disturbing siblings.</summary>
	[Fact]
	public void Set_StoresValueAtIndex() {
		// Arrange
		AdgChannelWaitCounters counters = new();

		// Act
		counters.Set(3, 0x1234);
		counters.Set(17, 0xABCD);

		// Assert
		Assert.Equal(0x1234, counters.Get(3));
		Assert.Equal(0xABCD, counters.Get(17));
		Assert.Equal(0, counters.Get(0));
		Assert.Equal(0, counters.Get(2));
		Assert.Equal(0, counters.Get(4));
	}

	/// <summary>
	/// <c>Decrement</c> on a positive counter returns false (still ticking).
	/// </summary>
	[Fact]
	public void Decrement_PositiveCounter_DoesNotReportElapsed() {
		// Arrange
		AdgChannelWaitCounters counters = new();
		counters.Set(5, 3);

		// Act
		bool elapsed = counters.Decrement(5);

		// Assert
		Assert.False(elapsed);
		Assert.Equal(2, counters.Get(5));
	}

	/// <summary>
	/// <c>Decrement</c> from 1 to 0 reports elapsed (matches
	/// <c>jz</c> after <c>sub word ptr [DI],1</c> at dnadg:0762).
	/// </summary>
	[Fact]
	public void Decrement_FromOne_ReportsElapsed() {
		// Arrange
		AdgChannelWaitCounters counters = new();
		counters.Set(0, 1);

		// Act
		bool elapsed = counters.Decrement(0);

		// Assert
		Assert.True(elapsed);
		Assert.Equal(0, counters.Get(0));
	}

	/// <summary><c>Reset</c> clears every channel counter.</summary>
	[Fact]
	public void Reset_ClearsAllCounters() {
		// Arrange
		AdgChannelWaitCounters counters = new();
		for (int i = 0; i < AdgChannelWaitCounters.ChannelCount; i++) {
			counters.Set(i, (ushort)(i + 1));
		}

		// Act
		counters.Reset();

		// Assert
		for (int i = 0; i < AdgChannelWaitCounters.ChannelCount; i++) {
			Assert.Equal(0, counters.Get(i));
		}
	}

	/// <summary>Out-of-range index throws.</summary>
	[Fact]
	public void Get_OutOfRange_Throws() {
		// Arrange
		AdgChannelWaitCounters counters = new();

		// Act
		// Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => counters.Get(-1));
		Assert.Throws<ArgumentOutOfRangeException>(() => counters.Get(18));
	}
}