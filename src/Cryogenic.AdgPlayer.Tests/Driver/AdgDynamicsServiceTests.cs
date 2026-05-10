namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 16 — full <c>AdgSetDynamics_564B_05BE_056A6E</c> behavior
/// composed from <see cref="AdgVolumeScaler"/>,
/// <see cref="AdgFadePatternSelector"/>, <see cref="AdgVolumeState"/>
/// and <see cref="AdgPlaybackState"/>.
///
/// Faithful port of:
/// <code>
/// pushAx
/// AX = BX                       ; dynamics input
/// AdgComputeScaledVolumeFromAx
/// dynamics = lo(AX)
/// AX = savedAx
/// fadePattern = AdgFadePatternSelector.Select(AX)
/// if (status &amp; Active) status |= FadePending
/// </code>
/// </summary>
public sealed class AdgDynamicsServiceTests {
	[Fact]
	public void Apply_StoresScaledDynamicsLowByteAndPicksFadePattern() {
		// Arrange — dynamicsBx=0x4040 → scaled lo = 0x42 (cf. AdgVolumeScalerTests).
		// trackPositionAx=0x00C0 → Medium fade pattern.
		AdgVolumeState volume = new();
		AdgPlaybackState playback = new();
		AdgDynamicsService service = new(volume, playback);

		// Act
		service.Apply(dynamicsBx: 0x4040, trackPositionAx: 0x00C0);

		// Assert
		Assert.Equal((byte)0x42, volume.Dynamics);
		Assert.Equal(AdgFadePattern.Medium, volume.FadePattern);
	}

	[Fact]
	public void Apply_DoesNotMutateMasterVolume() {
		// Arrange — set a master volume baseline that should survive.
		AdgVolumeState volume = new();
		volume.SetVolume(0x4040); // master = dynamics = 0x42
		AdgPlaybackState playback = new();
		AdgDynamicsService service = new(volume, playback);

		// Act
		service.Apply(dynamicsBx: 0x0000, trackPositionAx: 0x0000);

		// Assert
		Assert.Equal((byte)0x42, volume.MasterVolume);
		// dynamics gets overwritten by the scaled new value (0).
		Assert.Equal((byte)0x00, volume.Dynamics);
	}

	[Fact]
	public void Apply_WhileActive_RaisesFadePending() {
		// Arrange
		AdgVolumeState volume = new();
		AdgPlaybackState playback = new();
		playback.SetActive();
		AdgDynamicsService service = new(volume, playback);

		// Act
		service.Apply(dynamicsBx: 0x0000, trackPositionAx: 0x0000);

		// Assert
		Assert.Equal(
			AdgPlaybackStatus.Active | AdgPlaybackStatus.FadePending,
			playback.Status);
	}

	[Fact]
	public void Apply_WhileIdle_LeavesPlaybackStatusUntouched() {
		// Arrange
		AdgVolumeState volume = new();
		AdgPlaybackState playback = new();
		AdgDynamicsService service = new(volume, playback);

		// Act
		service.Apply(dynamicsBx: 0x4040, trackPositionAx: 0x0300);

		// Assert
		Assert.Equal(AdgPlaybackStatus.None, playback.Status);
		Assert.Equal(AdgFadePattern.Fastest, volume.FadePattern);
	}

	[Fact]
	public void Constructor_NullVolumeState_Throws() {
		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			new AdgDynamicsService(null!, new AdgPlaybackState()));
	}

	[Fact]
	public void Constructor_NullPlaybackState_Throws() {
		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			new AdgDynamicsService(new AdgVolumeState(), null!));
	}
}