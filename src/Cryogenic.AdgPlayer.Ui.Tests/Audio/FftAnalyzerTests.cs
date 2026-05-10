namespace Cryogenic.AdgPlayer.Ui.Tests.Audio;

using System;

using Cryogenic.AdgPlayer.Ui.Audio;

using Xunit;

/// <summary>Tests for <see cref="FftAnalyzer"/>.</summary>
public sealed class FftAnalyzerTests {
    /// <summary>Non-power-of-two and trivially small sizes are rejected.</summary>
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(3)]
    [InlineData(6)]
    public void Constructor_RejectsInvalidSize(int size) {
        // Act
        ArgumentOutOfRangeException ex = Assert.Throws<ArgumentOutOfRangeException>(() => new FftAnalyzer(size));

        // Assert
        Assert.Equal("size", ex.ParamName);
    }

    /// <summary>Sample length mismatch throws.</summary>
    [Fact]
    public void Analyze_RejectsMismatchedLength() {
        // Arrange
        FftAnalyzer fft = new(8);
        float[] data = new float[7];

        // Act / Assert
        Assert.Throws<ArgumentException>(() => fft.Analyze(data));
    }

    /// <summary>A pure DC signal concentrates energy at bin 0.</summary>
    [Fact]
    public void Analyze_DcSignal_ConcentratesAtBinZero() {
        // Arrange
        FftAnalyzer fft = new(64);
        float[] data = new float[64];
        for (int i = 0; i < data.Length; i++) {
            data[i] = 1f;
        }

        // Act
        ReadOnlySpan<float> spectrum = fft.Analyze(data);

        // Assert
        float bin0 = spectrum[0];
        float maxOther = 0f;
        for (int i = 1; i < spectrum.Length; i++) {
            if (spectrum[i] > maxOther) {
                maxOther = spectrum[i];
            }
        }
        Assert.True(bin0 > maxOther, $"DC bin {bin0} should dominate the rest (max {maxOther}).");
    }

    /// <summary>A mid-frequency sine concentrates energy in the matching bin range.</summary>
    [Fact]
    public void Analyze_SineSignal_PeaksAroundExpectedBin() {
        // Arrange
        const int size = 64;
        const int targetBin = 8; // 8 cycles across the window.
        FftAnalyzer fft = new(size);
        float[] data = new float[size];
        for (int i = 0; i < size; i++) {
            data[i] = MathF.Sin(2f * MathF.PI * targetBin * i / size);
        }

        // Act
        ReadOnlySpan<float> spectrum = fft.Analyze(data);

        // Assert
        int peakIndex = 0;
        float peak = 0f;
        for (int i = 0; i < spectrum.Length; i++) {
            if (spectrum[i] > peak) {
                peak = spectrum[i];
                peakIndex = i;
            }
        }
        Assert.InRange(peakIndex, targetBin - 1, targetBin + 1);
    }

    /// <summary>Reducing to bands normalises the largest bar to 1.</summary>
    [Fact]
    public void ReduceToBands_NormalisesMaxToOne() {
        // Arrange
        FftAnalyzer fft = new(32);
        float[] data = new float[32];
        for (int i = 0; i < data.Length; i++) {
            data[i] = MathF.Sin(2f * MathF.PI * 4 * i / data.Length);
        }
        ReadOnlySpan<float> spectrum = fft.Analyze(data);
        float[] bands = new float[8];

        // Act
        fft.ReduceToBands(spectrum, bands);

        // Assert
        float max = 0f;
        for (int i = 0; i < bands.Length; i++) {
            if (bands[i] > max) {
                max = bands[i];
            }
        }
        Assert.Equal(1f, max, 5);
    }

    /// <summary>An empty bands buffer is rejected.</summary>
    [Fact]
    public void ReduceToBands_RejectsEmptyBuffer() {
        // Arrange
        FftAnalyzer fft = new(8);
        float[] empty = Array.Empty<float>();

        // Act / Assert
        Assert.Throws<ArgumentException>(() => fft.ReduceToBands(fft.Analyze(new float[8]), empty));
    }
}
