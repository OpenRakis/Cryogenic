namespace Cryogenic.AdgPlayer.Ui.Tests.ViewModels;

using System;

using Cryogenic.AdgPlayer.Ui.Audio;
using Cryogenic.AdgPlayer.Ui.ViewModels;

using Xunit;

/// <summary>Tests for <see cref="AdgSpectrumViewModel"/>.</summary>
public sealed class AdgSpectrumViewModelTests {
    /// <summary>A new view model has no signal and exposes its buffer.</summary>
    [Fact]
    public void NewViewModel_HasNoSignal() {
        // Arrange
        AdgSpectrumViewModel viewModel = new(new SpectrumBuffer(32, 4));

        // Act / Assert
        Assert.False(viewModel.HasSignal);
        Assert.NotNull(viewModel.Buffer);
    }

    /// <summary>PushAndRecompute raises a HasSignal change notification.</summary>
    [Fact]
    public void PushAndRecompute_RaisesHasSignalChange() {
        // Arrange
        AdgSpectrumViewModel viewModel = new(new SpectrumBuffer(32, 4));
        string? changed = null;
        viewModel.PropertyChanged += (_, e) => changed = e.PropertyName;
        float[] data = new float[64];
        for (int i = 0; i < 32; i++) {
            float v = MathF.Sin(2f * MathF.PI * 2 * i / 32);
            data[i * 2] = v;
            data[(i * 2) + 1] = v;
        }

        // Act
        viewModel.PushAndRecompute(data, data.Length);

        // Assert
        Assert.True(viewModel.HasSignal);
        Assert.Equal(nameof(AdgSpectrumViewModel.HasSignal), changed);
    }

    /// <summary>Reset clears the signal flag.</summary>
    [Fact]
    public void Reset_ClearsSignal() {
        // Arrange
        AdgSpectrumViewModel viewModel = new(new SpectrumBuffer(32, 4));
        float[] data = new float[64];
        for (int i = 0; i < data.Length; i++) {
            data[i] = 0.5f;
        }
        viewModel.PushAndRecompute(data, data.Length);

        // Act
        viewModel.Reset();

        // Assert
        Assert.False(viewModel.HasSignal);
    }
}
