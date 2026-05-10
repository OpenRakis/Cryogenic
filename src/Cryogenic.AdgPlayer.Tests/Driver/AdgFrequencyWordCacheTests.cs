namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 26b — Mutable per-channel cache of the last A0/B0 frequency
/// word (without the key-on bit) used by note-off to re-emit the
/// previous tone with the key bit cleared. Mirrors the cached words
/// stored at <c>AdgFrequencyWordTableOffset</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public sealed class AdgFrequencyWordCacheTests {
	[Fact]
	public void DefaultEntries_AreZero() {
		// Arrange
		AdgFrequencyWordCache cache = new();

		// Assert — every channel starts at 0.
		for (int i = 0; i < AdgFrequencyWordCache.ChannelCount; i++) {
			Assert.Equal((ushort)0, cache.Get(i));
		}
	}

	[Fact]
	public void Set_StoresValueForChannel() {
		// Arrange
		AdgFrequencyWordCache cache = new();

		// Act
		cache.Set(7, 0x1234);

		// Assert
		Assert.Equal((ushort)0x1234, cache.Get(7));
		Assert.Equal((ushort)0, cache.Get(6));
		Assert.Equal((ushort)0, cache.Get(8));
	}

	[Fact]
	public void Reset_ClearsAllChannels() {
		// Arrange
		AdgFrequencyWordCache cache = new();
		for (int i = 0; i < AdgFrequencyWordCache.ChannelCount; i++) {
			cache.Set(i, (ushort)(0x4000 + i));
		}

		// Act
		cache.Reset();

		// Assert
		for (int i = 0; i < AdgFrequencyWordCache.ChannelCount; i++) {
			Assert.Equal((ushort)0, cache.Get(i));
		}
	}

	[Theory]
	[InlineData(-1)]
	[InlineData(18)]
	public void Get_OutOfRange_Throws(int channelIndex) {
		// Arrange
		AdgFrequencyWordCache cache = new();

		// Act + Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => cache.Get(channelIndex));
	}

	[Theory]
	[InlineData(-1)]
	[InlineData(18)]
	public void Set_OutOfRange_Throws(int channelIndex) {
		// Arrange
		AdgFrequencyWordCache cache = new();

		// Act + Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => cache.Set(channelIndex, 0));
	}
}