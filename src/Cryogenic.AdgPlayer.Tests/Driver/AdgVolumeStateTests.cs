namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 13 — master volume / dynamics / fade-pattern state.
/// Faithful port of <c>AdgSetVolume_564B_05AB_056A5B</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>:
///   scaled = AdgVolumeScaler.Scale(ax)
///   masterVolume = lo(scaled)
///   dynamics     = lo(scaled)
///   fadePattern  = AdgFadePattern.Immediate (0xFFFF)
/// </summary>
public sealed class AdgVolumeStateTests {
	[Fact]
	public void Initial_StateIsZeroAndImmediateFade() {
		// Arrange + Act
		AdgVolumeState state = new();

		// Assert
		Assert.Equal((byte)0, state.MasterVolume);
		Assert.Equal((byte)0, state.Dynamics);
		Assert.Equal(AdgFadePattern.Immediate, state.FadePattern);
	}

	[Fact]
	public void SetVolume_StoresScaledLowByteIntoMasterAndDynamics() {
		// Arrange — Scale(0x4040) = 0x0042 (cf. AdgVolumeScalerTests).
		AdgVolumeState state = new();

		// Act
		state.SetVolume(0x4040);

		// Assert
		Assert.Equal((byte)0x42, state.MasterVolume);
		Assert.Equal((byte)0x42, state.Dynamics);
		Assert.Equal(AdgFadePattern.Immediate, state.FadePattern);
	}

	[Fact]
	public void SetVolume_AlwaysResetsFadePatternToImmediate() {
		// Arrange — corrupt fade pattern, ensure SetVolume restores it.
		AdgVolumeState state = new();
		state.SetFadePattern(AdgFadePattern.Slow);

		// Act
		state.SetVolume(0x0000);

		// Assert
		Assert.Equal(AdgFadePattern.Immediate, state.FadePattern);
	}

	[Fact]
	public void SetFadePattern_StoresGivenPattern() {
		// Arrange
		AdgVolumeState state = new();

		// Act
		state.SetFadePattern(AdgFadePattern.Medium);

		// Assert
		Assert.Equal(AdgFadePattern.Medium, state.FadePattern);
	}

	[Fact]
	public void SetVolume_TruncatesScaledHighByte() {
		// Arrange — Scale(0x00FF) = 0x00F0 → low byte 0xF0.
		AdgVolumeState state = new();

		// Act
		state.SetVolume(0x00FF);

		// Assert
		Assert.Equal((byte)0xF0, state.MasterVolume);
		Assert.Equal((byte)0xF0, state.Dynamics);
	}
}