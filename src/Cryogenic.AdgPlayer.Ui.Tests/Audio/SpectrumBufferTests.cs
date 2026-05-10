namespace Cryogenic.AdgPlayer.Ui.Tests.Audio;

using System;

using Cryogenic.AdgPlayer.Ui.Audio;

using Xunit;

/// <summary>Tests for <see cref="SpectrumBuffer"/>.</summary>
public sealed class SpectrumBufferTests {
    /// <summary>A fresh buffer reports zero bands and zero size.</summary>
    [Fact]
    public void NewBuffer_HasZeroBands() {
        // Arrange
        SpectrumBuffer buffer = new(64, 8);

        // Act / Assert
        Assert.Equal(64, buffer.Size);
        Assert.Equal(8, buffer.BandCount);
        ReadOnlySpan<float> bands = buffer.Bands;
        for (int i = 0; i < bands.Length; i++) {
            Assert.Equal(0f, bands[i]);
        }
    }

    /// <summary>Pushing and recomputing produces non-zero bands for a sine signal.</summary>
    [Fact]
    public void PushAndRecompute_PopulatesBands() {
        // Arrange
        SpectrumBuffer buffer = new(64, 8);
        float[] data = new float[128];
        for (int i = 0; i < 64; i++) {
            float v = MathF.Sin(2f * MathF.PI * 4 * i / 64);
            data[i * 2] = v;
            data[(i * 2) + 1] = v;
        }

        // Act
        buffer.PushSamples(data, data.Length);
        buffer.Recompute();

        // Assert
        float maxBand = 0f;
        ReadOnlySpan<float> bands = buffer.Bands;
        for (int i = 0; i < bands.Length; i++) {
            if (bands[i] > maxBand) {
                maxBand = bands[i];
            }
        }
        Assert.Equal(1f, maxBand, 5);
    }

    /// <summary>Reset clears bands.</summary>
    [Fact]
    public void Reset_ClearsBands() {
        // Arrange
        SpectrumBuffer buffer = new(32, 4);
        float[] data = new float[64];
        for (int i = 0; i < data.Length; i++) {
            data[i] = 0.5f;
        }
        buffer.PushSamples(data, data.Length);
        buffer.Recompute();

        // Act
        buffer.Reset();

        // Assert
        ReadOnlySpan<float> bands = buffer.Bands;
        for (int i = 0; i < bands.Length; i++) {
            Assert.Equal(0f, bands[i]);
        }
    }

    /// <summary>Negative band counts are rejected.</summary>
    [Fact]
    public void Constructor_RejectsZeroBandCount() {
        // Act
        ArgumentOutOfRangeException ex = Assert.Throws<ArgumentOutOfRangeException>(() => new SpectrumBuffer(32, 0));

        // Assert
        Assert.Equal("bandCount", ex.ParamName);
    }

    /// <summary>Sample count overflow is rejected.</summary>
    [Fact]
    public void PushSamples_RejectsSampleCountOverflow() {
        // Arrange
        SpectrumBuffer buffer = new(32, 4);
        float[] data = new float[4];

        // Act / Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => buffer.PushSamples(data, 5));
    }
}
