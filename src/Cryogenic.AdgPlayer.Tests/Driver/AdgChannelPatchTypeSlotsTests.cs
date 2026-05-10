namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>Unit tests for <see cref="AdgChannelPatchTypeSlots"/>.</summary>
public sealed class AdgChannelPatchTypeSlotsTests {
	/// <summary>The table holds 18 channel slots.</summary>
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		// Act
		// Assert
		Assert.Equal(18, AdgChannelPatchTypeSlots.ChannelCount);
	}

	/// <summary>The four-operator marker matches dnadg:08DC compare against 0x04.</summary>
	[Fact]
	public void FourOperatorMarker_IsFour() {
		// Arrange
		// Act
		// Assert
		Assert.Equal(0x04, AdgChannelPatchTypeSlots.FourOperatorMarker);
	}

	/// <summary>Slots default to zero.</summary>
	[Fact]
	public void Default_AllSlotsAreZero() {
		// Arrange
		AdgChannelPatchTypeSlots slots = new();

		// Act
		// Assert
		for (int i = 0; i < AdgChannelPatchTypeSlots.ChannelCount; i++) {
			Assert.Equal(0, slots.Get(i));
			Assert.False(slots.IsFourOperator(i));
		}
	}

	/// <summary><c>Set</c>/<c>Get</c> store the patch byte per channel.</summary>
	[Fact]
	public void SetGet_StoresValuePerChannel() {
		// Arrange
		AdgChannelPatchTypeSlots slots = new();

		// Act
		slots.Set(7, 0x04);

		// Assert
		Assert.Equal(0x04, slots.Get(7));
	}

	/// <summary><c>IsFourOperator</c> reports true only for <see cref="AdgChannelPatchTypeSlots.FourOperatorMarker"/>.</summary>
	[Theory]
	[InlineData(0x00, false)]
	[InlineData(0x02, false)]
	[InlineData(0x04, true)]
	[InlineData(0x05, false)]
	public void IsFourOperator_ChecksAgainstMarker(int patch, bool expected) {
		// Arrange
		AdgChannelPatchTypeSlots slots = new();
		slots.Set(0, (byte)patch);

		// Act
		bool result = slots.IsFourOperator(0);

		// Assert
		Assert.Equal(expected, result);
	}

	/// <summary>Reset clears every slot.</summary>
	[Fact]
	public void Reset_ClearsAllSlots() {
		// Arrange
		AdgChannelPatchTypeSlots slots = new();
		for (int i = 0; i < AdgChannelPatchTypeSlots.ChannelCount; i++) {
			slots.Set(i, 0x04);
		}

		// Act
		slots.Reset();

		// Assert
		for (int i = 0; i < AdgChannelPatchTypeSlots.ChannelCount; i++) {
			Assert.Equal(0, slots.Get(i));
		}
	}
}