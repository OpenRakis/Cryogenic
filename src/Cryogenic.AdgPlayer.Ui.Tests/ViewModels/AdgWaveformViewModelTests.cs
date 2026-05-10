namespace Cryogenic.AdgPlayer.Ui.Tests.ViewModels;

using Cryogenic.AdgPlayer.Ui.Audio;
using Cryogenic.AdgPlayer.Ui.ViewModels;

using Xunit;

/// <summary>Tests for <see cref="AdgWaveformViewModel"/>.</summary>
public sealed class AdgWaveformViewModelTests {
	/// <summary>A new view model has no signal and exposes its buffer.</summary>
	[Fact]
	public void NewViewModel_HasNoSignal() {
		// Arrange
		AdgWaveformViewModel viewModel = new();

		// Act / Assert
		Assert.False(viewModel.HasSignal);
		Assert.NotNull(viewModel.Buffer);
	}

	/// <summary>Pushing samples flips <see cref="AdgWaveformViewModel.HasSignal"/>.</summary>
	[Fact]
	public void PushSamples_RaisesHasSignalChange() {
		// Arrange
		AdgWaveformViewModel viewModel = new(new WaveformPeakBuffer(16));
		string? changed = null;
		viewModel.PropertyChanged += (_, e) => changed = e.PropertyName;
		float[] data = new float[2] { 0.5f, 0.5f };

		// Act
		viewModel.PushSamples(data, data.Length);

		// Assert
		Assert.True(viewModel.HasSignal);
		Assert.Equal(nameof(AdgWaveformViewModel.HasSignal), changed);
	}

	/// <summary>Reset clears signal flag.</summary>
	[Fact]
	public void Reset_ClearsSignal() {
		// Arrange
		AdgWaveformViewModel viewModel = new(new WaveformPeakBuffer(16));
		viewModel.PushSamples(new float[2] { 0.5f, 0.5f }, 2);

		// Act
		viewModel.Reset();

		// Assert
		Assert.False(viewModel.HasSignal);
	}
}