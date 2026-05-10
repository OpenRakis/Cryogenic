namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgChannelPitchTransposeSlots"/>.
/// </summary>
public sealed class AdgChannelPitchTransposeSlotsTests {
	/// <summary>The table holds 18 channel slots.</summary>
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		// Act
		int count = AdgChannelPitchTransposeSlots.ChannelCount;

		// Assert
		Assert.Equal(18, count);
	}

	/// <summary>Slots default to zero (no transpose).</summary>
	[Fact]
	public void Default_AllSlotsAreZero() {
		// Arrange
		AdgChannelPitchTransposeSlots slots = new();

		// Act
		// Assert
		for (int i = 0; i < AdgChannelPitchTransposeSlots.ChannelCount; i++) {
			Assert.Equal(0, slots.Get(i));
		}
	}

	/// <summary><c>Set</c>/<c>Get</c> store the per-channel transpose byte.</summary>
	[Fact]
	public void SetGet_StoresValuePerChannel() {
		// Arrange
		AdgChannelPitchTransposeSlots slots = new();

		// Act
		slots.Set(0, 0x0C);
		slots.Set(11, 0xF4);

		// Assert
		Assert.Equal(0x0C, slots.Get(0));
		Assert.Equal(0xF4, slots.Get(11));
	}

	/// <summary>
	/// <c>ApplyTo(channelIndex, note)</c> adds the transpose byte to
	/// the supplied note with native 8-bit wrap (<c>add AL,[DI+0x91]</c>).
	/// </summary>
	[Theory]
	[InlineData(0x40, 0x00, 0x40)]
	[InlineData(0x40, 0x0C, 0x4C)]
	[InlineData(0x10, 0xFF, 0x0F)]
	[InlineData(0x80, 0x80, 0x00)]
	public void ApplyTo_AddsTransposeWithEightBitWrap(int note, int transpose, int expected) {
		// Arrange
		AdgChannelPitchTransposeSlots slots = new();
		slots.Set(2, (byte)transpose);

		// Act
		byte transposed = slots.ApplyTo(2, (byte)note);

		// Assert
		Assert.Equal((byte)expected, transposed);
	}

	/// <summary><c>Reset</c> clears every slot.</summary>
	[Fact]
	public void Reset_ClearsAllSlots() {
		// Arrange
		AdgChannelPitchTransposeSlots slots = new();
		for (int i = 0; i < AdgChannelPitchTransposeSlots.ChannelCount; i++) {
			slots.Set(i, (byte)(0x10 + i));
		}

		// Act
		slots.Reset();

		// Assert
		for (int i = 0; i < AdgChannelPitchTransposeSlots.ChannelCount; i++) {
			Assert.Equal(0, slots.Get(i));
		}
	}
}