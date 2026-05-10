namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 15 — playback status flags + pending-fade transition.
/// Faithful port of <c>AdgPlaybackStatus</c> + the tail of
/// <c>AdgSetDynamics_564B_05BE_056A6E</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>:
///   if (status &amp; Active) status |= FadePending;
/// </summary>
public sealed class AdgPlaybackStateTests {
	[Fact]
	public void Initial_StatusIsNone() {
		// Arrange + Act
		AdgPlaybackState state = new();

		// Assert
		Assert.Equal(AdgPlaybackStatus.None, state.Status);
		Assert.False(state.IsActive);
	}

	[Fact]
	public void SetActive_RaisesActiveFlag() {
		// Arrange
		AdgPlaybackState state = new();

		// Act
		state.SetActive();

		// Assert
		Assert.True(state.IsActive);
		Assert.Equal(AdgPlaybackStatus.Active, state.Status);
	}

	[Fact]
	public void RequestFadeIfActive_WhenActive_SetsFadePending() {
		// Arrange
		AdgPlaybackState state = new();
		state.SetActive();

		// Act
		state.RequestFadeIfActive();

		// Assert
		Assert.Equal(
			AdgPlaybackStatus.Active | AdgPlaybackStatus.FadePending,
			state.Status);
	}

	[Fact]
	public void RequestFadeIfActive_WhenIdle_LeavesStatusUnchanged() {
		// Arrange — never SetActive(), so Active flag is clear.
		AdgPlaybackState state = new();

		// Act
		state.RequestFadeIfActive();

		// Assert
		Assert.Equal(AdgPlaybackStatus.None, state.Status);
	}

	[Fact]
	public void Clear_ResetsStatusToNone() {
		// Arrange
		AdgPlaybackState state = new();
		state.SetActive();
		state.RequestFadeIfActive();

		// Act
		state.Clear();

		// Assert
		Assert.Equal(AdgPlaybackStatus.None, state.Status);
		Assert.False(state.IsActive);
	}
}