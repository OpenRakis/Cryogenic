namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>Unit tests for <see cref="AdgFadePatternState"/>.</summary>
public sealed class AdgFadePatternStateTests {
	/// <summary>The byte defaults to zero.</summary>
	[Fact]
	public void Default_IsZero() {
		// Arrange
		AdgFadePatternState fade = new();

		// Act
		// Assert
		Assert.Equal(0, fade.Value);
	}

	/// <summary><c>Set</c> stores the fade pattern byte.</summary>
	[Fact]
	public void Set_StoresValue() {
		// Arrange
		AdgFadePatternState fade = new();

		// Act
		fade.Set(0x12);

		// Assert
		Assert.Equal(0x12, fade.Value);
	}

	/// <summary><c>Reset</c> clears the byte.</summary>
	[Fact]
	public void Reset_ClearsValue() {
		// Arrange
		AdgFadePatternState fade = new();
		fade.Set(0xAB);

		// Act
		fade.Reset();

		// Assert
		Assert.Equal(0, fade.Value);
	}

	/// <summary>The high-nibble increment matches the original 0x10 step.</summary>
	[Fact]
	public void HighNibbleIncrement_IsHexTen() {
		// Arrange
		// Act
		// Assert
		Assert.Equal(0x10, AdgFadePatternState.HighNibbleIncrement);
	}

	/// <summary>The high-nibble decrement matches the original 0x20 step.</summary>
	[Fact]
	public void HighNibbleDecrement_IsHexTwenty() {
		// Arrange
		// Act
		// Assert
		Assert.Equal(0x20, AdgFadePatternState.HighNibbleDecrement);
	}
}