namespace Cryogenic.AdgPlayer.Ui.Tests.ViewModels;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Ui.ViewModels;

using System.Collections.Generic;

using Xunit;

/// <summary>Unit tests for <see cref="AdgTransportViewModel"/>.</summary>
public sealed class AdgTransportViewModelTests {
	/// <summary>Defaults map to the zero-state driver values.</summary>
	[Fact]
	public void Constructor_StartsAtDriverDefaults() {
		// Arrange
		AdgDriverState state = new();
		AdgTransportViewModel viewModel = new(state);

		// Act
		// Assert
		Assert.False(viewModel.IsPlaying);
		Assert.False(viewModel.HasSongLoaded);
		Assert.Equal(0, viewModel.MasterVolume);
		Assert.Equal(0, viewModel.CurrentVolume);
		Assert.Equal(0, viewModel.Dynamics);
		Assert.Equal(0, viewModel.FadePattern);
	}

	/// <summary><c>RefreshVolumeReadouts</c> picks up driver state mutations.</summary>
	[Fact]
	public void RefreshVolumeReadouts_ReportsDriverStateMutations() {
		// Arrange
		AdgDriverState state = new();
		AdgTransportViewModel viewModel = new(state);
		HashSet<string> changed = new();
		viewModel.PropertyChanged += (_, e) => {
			if (e.PropertyName is not null) {
				changed.Add(e.PropertyName);
			}
		};
		state.MasterVolume.SetMaster(0x40);
		state.Dynamics.Set(0x55);
		state.FadePatternState.Set(0x80);

		// Act
		viewModel.RefreshVolumeReadouts();

		// Assert
		Assert.Equal(0x40, viewModel.MasterVolume);
		Assert.Equal(0x40, viewModel.CurrentVolume);
		Assert.Equal(0x55, viewModel.Dynamics);
		Assert.Equal(0x80, viewModel.FadePattern);
		Assert.Contains(nameof(AdgTransportViewModel.MasterVolume), changed);
		Assert.Contains(nameof(AdgTransportViewModel.CurrentVolume), changed);
		Assert.Contains(nameof(AdgTransportViewModel.Dynamics), changed);
		Assert.Contains(nameof(AdgTransportViewModel.FadePattern), changed);
	}

	/// <summary><c>IsPlaying</c> raises change notifications.</summary>
	[Fact]
	public void IsPlaying_Set_RaisesPropertyChanged() {
		// Arrange
		AdgDriverState state = new();
		AdgTransportViewModel viewModel = new(state);
		bool sawChange = false;
		viewModel.PropertyChanged += (_, e) => {
			if (e.PropertyName == nameof(AdgTransportViewModel.IsPlaying)) {
				sawChange = true;
			}
		};

		// Act
		viewModel.IsPlaying = true;

		// Assert
		Assert.True(viewModel.IsPlaying);
		Assert.True(sawChange);
	}

	/// <summary><c>HasSongLoaded</c> raises change notifications.</summary>
	[Fact]
	public void HasSongLoaded_Set_RaisesPropertyChanged() {
		// Arrange
		AdgDriverState state = new();
		AdgTransportViewModel viewModel = new(state);
		bool sawChange = false;
		viewModel.PropertyChanged += (_, e) => {
			if (e.PropertyName == nameof(AdgTransportViewModel.HasSongLoaded)) {
				sawChange = true;
			}
		};

		// Act
		viewModel.HasSongLoaded = true;

		// Assert
		Assert.True(viewModel.HasSongLoaded);
		Assert.True(sawChange);
	}
}