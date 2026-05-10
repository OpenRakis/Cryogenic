namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgChannelInstrumentSlots"/>.
/// </summary>
public sealed class AdgChannelInstrumentSlotsTests {
	/// <summary>The slot table holds 18 channel slots.</summary>
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		// Act
		int count = AdgChannelInstrumentSlots.ChannelCount;

		// Assert
		Assert.Equal(18, count);
	}

	/// <summary>All slots default to zero.</summary>
	[Fact]
	public void Default_AllSlotsAreZero() {
		// Arrange
		AdgChannelInstrumentSlots slots = new();

		// Act
		// Assert
		for (int i = 0; i < AdgChannelInstrumentSlots.ChannelCount; i++) {
			Assert.Equal(0, slots.Get(i));
		}
	}

	/// <summary><c>Set</c> writes the byte at the supplied channel index.</summary>
	[Fact]
	public void Set_StoresInstrumentAtIndex() {
		// Arrange
		AdgChannelInstrumentSlots slots = new();

		// Act
		slots.Set(4, 0x2B);
		slots.Set(17, 0xFF);

		// Assert
		Assert.Equal(0x2B, slots.Get(4));
		Assert.Equal(0xFF, slots.Get(17));
		Assert.Equal(0x00, slots.Get(0));
	}

	/// <summary><c>Reset</c> clears every slot.</summary>
	[Fact]
	public void Reset_ClearsAllSlots() {
		// Arrange
		AdgChannelInstrumentSlots slots = new();
		for (int i = 0; i < AdgChannelInstrumentSlots.ChannelCount; i++) {
			slots.Set(i, (byte)(0x10 + i));
		}

		// Act
		slots.Reset();

		// Assert
		for (int i = 0; i < AdgChannelInstrumentSlots.ChannelCount; i++) {
			Assert.Equal(0, slots.Get(i));
		}
	}

	/// <summary>Out-of-range access throws.</summary>
	[Fact]
	public void Get_OutOfRange_Throws() {
		// Arrange
		AdgChannelInstrumentSlots slots = new();

		// Act
		// Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => slots.Get(-1));
		Assert.Throws<ArgumentOutOfRangeException>(() => slots.Get(18));
	}
}