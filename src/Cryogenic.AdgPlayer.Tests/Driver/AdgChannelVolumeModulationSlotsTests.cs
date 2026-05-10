namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>Unit tests for <see cref="AdgChannelVolumeModulationSlots"/>.</summary>
public sealed class AdgChannelVolumeModulationSlotsTests {
	/// <summary>The table holds 18 channel slots.</summary>
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		// Act
		// Assert
		Assert.Equal(18, AdgChannelVolumeModulationSlots.ChannelCount);
	}

	/// <summary>Slots default to zero.</summary>
	[Fact]
	public void Default_AllSlotsAreZero() {
		// Arrange
		AdgChannelVolumeModulationSlots slots = new();

		// Act
		// Assert
		for (int i = 0; i < AdgChannelVolumeModulationSlots.ChannelCount; i++) {
			Assert.Equal(0, slots.Get(i));
		}
	}

	/// <summary>Set/Get round-trip the per-channel ushort.</summary>
	[Fact]
	public void SetGet_StoresValuePerChannel() {
		// Arrange
		AdgChannelVolumeModulationSlots slots = new();

		// Act
		slots.Set(0, 0x1234);
		slots.Set(17, 0xCAFE);

		// Assert
		Assert.Equal(0x1234, slots.Get(0));
		Assert.Equal(0xCAFE, slots.Get(17));
	}

	/// <summary>Reset clears every slot.</summary>
	[Fact]
	public void Reset_ClearsAllSlots() {
		// Arrange
		AdgChannelVolumeModulationSlots slots = new();
		for (int i = 0; i < AdgChannelVolumeModulationSlots.ChannelCount; i++) {
			slots.Set(i, 0xFFFF);
		}

		// Act
		slots.Reset();

		// Assert
		for (int i = 0; i < AdgChannelVolumeModulationSlots.ChannelCount; i++) {
			Assert.Equal(0, slots.Get(i));
		}
	}
}