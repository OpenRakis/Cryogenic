namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>Unit tests for <see cref="AdgMasterVolume"/>.</summary>
public sealed class AdgMasterVolumeTests {
	/// <summary>Master and current volumes default to zero.</summary>
	[Fact]
	public void Default_BothBytesAreZero() {
		// Arrange
		AdgMasterVolume volume = new();

		// Act
		// Assert
		Assert.Equal(0, volume.Master);
		Assert.Equal(0, volume.Current);
	}

	/// <summary><c>SetMaster</c> writes both master and current bytes (matches dnadg:066C).</summary>
	[Fact]
	public void SetMaster_AlsoSetsCurrent() {
		// Arrange
		AdgMasterVolume volume = new();

		// Act
		volume.SetMaster(0x40);

		// Assert
		Assert.Equal(0x40, volume.Master);
		Assert.Equal(0x40, volume.Current);
	}

	/// <summary><c>SetCurrent</c> only mutates the current byte.</summary>
	[Fact]
	public void SetCurrent_DoesNotTouchMaster() {
		// Arrange
		AdgMasterVolume volume = new();
		volume.SetMaster(0x60);

		// Act
		volume.SetCurrent(0x10);

		// Assert
		Assert.Equal(0x60, volume.Master);
		Assert.Equal(0x10, volume.Current);
	}

	/// <summary><c>RestoreCurrentFromMaster</c> resets current to the master value.</summary>
	[Fact]
	public void RestoreCurrentFromMaster_CopiesMasterIntoCurrent() {
		// Arrange
		AdgMasterVolume volume = new();
		volume.SetMaster(0x55);
		volume.SetCurrent(0x00);

		// Act
		volume.RestoreCurrentFromMaster();

		// Assert
		Assert.Equal(0x55, volume.Current);
	}
}