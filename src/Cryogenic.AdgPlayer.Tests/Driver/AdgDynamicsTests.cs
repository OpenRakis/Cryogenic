namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>Unit tests for <see cref="AdgDynamics"/>.</summary>
public sealed class AdgDynamicsTests {
	/// <summary>The byte defaults to zero.</summary>
	[Fact]
	public void Default_IsZero() {
		// Arrange
		AdgDynamics dynamics = new();

		// Act
		// Assert
		Assert.Equal(0, dynamics.Value);
	}

	/// <summary><c>Set</c> stores the dynamics byte.</summary>
	[Fact]
	public void Set_StoresValue() {
		// Arrange
		AdgDynamics dynamics = new();

		// Act
		dynamics.Set(0x80);

		// Assert
		Assert.Equal(0x80, dynamics.Value);
	}

	/// <summary><c>Reset</c> clears the byte.</summary>
	[Fact]
	public void Reset_ClearsValue() {
		// Arrange
		AdgDynamics dynamics = new();
		dynamics.Set(0xAB);

		// Act
		dynamics.Reset();

		// Assert
		Assert.Equal(0, dynamics.Value);
	}

	/// <summary>The four BPM thresholds match the constants used at dnadg:0697.</summary>
	[Fact]
	public void Thresholds_MatchOriginalConstants() {
		// Arrange
		// Act
		// Assert
		Assert.Equal((ushort)0x0060, AdgDynamics.ThresholdSlow);
		Assert.Equal((ushort)0x00C0, AdgDynamics.ThresholdMedium);
		Assert.Equal((ushort)0x0180, AdgDynamics.ThresholdFast);
		Assert.Equal((ushort)0x0300, AdgDynamics.ThresholdFastest);
	}
}