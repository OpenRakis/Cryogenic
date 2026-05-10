namespace Cryogenic.AdgPlayer.Ui.Tests.Audio;

using Cryogenic.AdgPlayer.Ui.Audio;

using System;

using Xunit;

/// <summary>Tests for <see cref="WaveformPeakBuffer"/>.</summary>
public sealed class WaveformPeakBufferTests {
	/// <summary>A fresh buffer reports no signal on either channel.</summary>
	[Fact]
	public void EmptyBuffer_ReportsNoSignal() {
		// Arrange
		WaveformPeakBuffer buffer = new(64);

		// Act / Assert
		Assert.False(buffer.HasLeftSignal());
		Assert.False(buffer.HasRightSignal());
		Assert.Equal(0, buffer.WriteIndex);
		Assert.Equal(0, buffer.ReadStart());
	}

	/// <summary>Negative or zero capacity is rejected.</summary>
	[Theory]
	[InlineData(0)]
	[InlineData(-1)]
	public void Constructor_RejectsNonPositiveCapacity(int capacity) {
		// Act
		ArgumentOutOfRangeException ex = Assert.Throws<ArgumentOutOfRangeException>(() => new WaveformPeakBuffer(capacity));

		// Assert
		Assert.Equal("displaySamples", ex.ParamName);
	}

	/// <summary>Pushing interleaved frames bumps the write index by the bucket count.</summary>
	[Fact]
	public void PushSamples_AdvancesWriteIndex() {
		// Arrange
		WaveformPeakBuffer buffer = new(64);
		// 16 frames -> step = 16/8 = 2 -> 8 buckets.
		float[] data = new float[32];
		for (int i = 0; i < data.Length; i++) {
			data[i] = i % 2 == 0 ? 0.5f : -0.25f;
		}

		// Act
		int written = buffer.PushSamples(data, data.Length);

		// Assert
		Assert.Equal(8, written);
		Assert.Equal(8, buffer.WriteIndex);
	}

	/// <summary>Each bucket captures the absolute peak of its window per channel.</summary>
	[Fact]
	public void PushSamples_CapturesAbsolutePeakPerChannel() {
		// Arrange
		WaveformPeakBuffer buffer = new(64);
		float[] data = new float[16]; // 8 frames -> step 1 -> 8 buckets.
									  // Frame 0: L=+0.7 R=-0.3 (abs 0.7, 0.3).
		data[0] = 0.7f;
		data[1] = -0.3f;
		// Frame 1: L=-0.9 R=+0.4 (abs 0.9, 0.4).
		data[2] = -0.9f;
		data[3] = 0.4f;

		// Act
		buffer.PushSamples(data, data.Length);

		// Assert
		WaveformBucket b0 = buffer.GetBucket(0);
		Assert.Equal(0.7f, b0.Left, 5);
		Assert.Equal(0.3f, b0.Right, 5);
		WaveformBucket b1 = buffer.GetBucket(1);
		Assert.Equal(0.9f, b1.Left, 5);
		Assert.Equal(0.4f, b1.Right, 5);
	}

	/// <summary>Signal detectors flip when amplitudes exceed the threshold.</summary>
	[Fact]
	public void HasSignal_ReflectsRecordedAmplitudes() {
		// Arrange
		WaveformPeakBuffer buffer = new(32);
		float[] data = new float[2] { 0.6f, 0f };

		// Act
		buffer.PushSamples(data, data.Length);

		// Assert
		Assert.True(buffer.HasLeftSignal());
		Assert.False(buffer.HasRightSignal());
	}

	/// <summary>The ring wraps when more buckets than capacity are pushed.</summary>
	[Fact]
	public void PushSamples_WrapsRing() {
		// Arrange
		WaveformPeakBuffer buffer = new(4);
		// 16 frames -> step 2 -> 8 buckets, more than capacity (4).
		float[] data = new float[32];
		for (int i = 0; i < data.Length; i++) {
			data[i] = 0.1f * i;
		}

		// Act
		buffer.PushSamples(data, data.Length);

		// Assert
		Assert.Equal(8, buffer.WriteIndex);
		Assert.Equal(4, buffer.ReadStart());
	}

	/// <summary>Reset zeroes amplitudes and the write index.</summary>
	[Fact]
	public void Reset_ClearsState() {
		// Arrange
		WaveformPeakBuffer buffer = new(8);
		float[] data = new float[4] { 0.9f, 0.9f, 0.9f, 0.9f };
		buffer.PushSamples(data, data.Length);

		// Act
		buffer.Reset();

		// Assert
		Assert.Equal(0, buffer.WriteIndex);
		Assert.False(buffer.HasLeftSignal());
		Assert.False(buffer.HasRightSignal());
	}

	/// <summary>Bucket index out of range throws.</summary>
	[Fact]
	public void GetBucket_RejectsOutOfRangeIndex() {
		// Arrange
		WaveformPeakBuffer buffer = new(8);

		// Act / Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => buffer.GetBucket(-1));
		Assert.Throws<ArgumentOutOfRangeException>(() => buffer.GetBucket(8));
	}

	/// <summary>Sample count must fit inside the supplied buffer.</summary>
	[Fact]
	public void PushSamples_RejectsSampleCountOverflow() {
		// Arrange
		WaveformPeakBuffer buffer = new(8);
		float[] data = new float[4];

		// Act / Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => buffer.PushSamples(data, 5));
		Assert.Throws<ArgumentOutOfRangeException>(() => buffer.PushSamples(data, -1));
	}
}