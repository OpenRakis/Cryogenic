namespace Cryogenic.AdgPlayer.Ui.Audio;

using System;

/// <summary>
/// Pure-logic stereo peak-hold ring buffer used by the waveform
/// control. Down-samples interleaved float frames into a fixed-size
/// circular buffer of per-bucket peak amplitudes (one for left,
/// one for right) plus a slow-decay peak-hold envelope. Lives in a
/// non-UI namespace so it can be exercised by plain xUnit tests
/// without any Avalonia platform.
/// </summary>
public sealed class WaveformPeakBuffer {
	/// <summary>Default ring length (matches the historical AdpPlayer control).</summary>
	public const int DefaultDisplaySamples = 800;

	/// <summary>Per-tick decay coefficient applied to peak-hold values.</summary>
	public const float PeakDecay = 0.993f;

	private readonly float[] _left;
	private readonly float[] _right;
	private readonly float[] _leftPeak;
	private readonly float[] _rightPeak;
	private int _writeIndex;

	/// <summary>Length of the ring buffer.</summary>
	public int DisplaySamples { get; }

	/// <summary>Current monotonic write counter (number of buckets written since construction).</summary>
	public int WriteIndex => _writeIndex;

	/// <summary>Builds a ring buffer with <see cref="DefaultDisplaySamples"/> buckets.</summary>
	public WaveformPeakBuffer() : this(DefaultDisplaySamples) {
	}

	/// <summary>Builds a ring buffer with the supplied bucket count.</summary>
	public WaveformPeakBuffer(int displaySamples) {
		if (displaySamples <= 0) {
			throw new ArgumentOutOfRangeException(nameof(displaySamples), displaySamples, "Display sample count must be positive.");
		}
		DisplaySamples = displaySamples;
		_left = new float[displaySamples];
		_right = new float[displaySamples];
		_leftPeak = new float[displaySamples];
		_rightPeak = new float[displaySamples];
	}

	/// <summary>
	/// Pushes <paramref name="sampleCount"/> floats from
	/// <paramref name="interleaved"/> (L, R, L, R, ...) into the
	/// ring. Down-samples by collapsing groups of frames into one
	/// peak bucket. Returns the number of buckets actually written.
	/// </summary>
	public int PushSamples(float[] interleaved, int sampleCount) {
		ArgumentNullException.ThrowIfNull(interleaved);
		if (sampleCount < 0 || sampleCount > interleaved.Length) {
			throw new ArgumentOutOfRangeException(nameof(sampleCount), sampleCount, "Sample count out of range.");
		}

		int frames = sampleCount / 2;
		if (frames == 0) {
			return 0;
		}

		int step = Math.Max(1, frames / 8);
		int written = 0;
		for (int i = 0; i < frames; i += step) {
			float peakL = 0f;
			float peakR = 0f;
			int end = Math.Min(i + step, frames);
			for (int j = i; j < end; j++) {
				int idx = j * 2;
				if (idx + 1 < sampleCount) {
					float aL = Math.Abs(interleaved[idx]);
					float aR = Math.Abs(interleaved[idx + 1]);
					if (aL > peakL) {
						peakL = aL;
					}
					if (aR > peakR) {
						peakR = aR;
					}
				}
			}

			int wi = _writeIndex % DisplaySamples;
			_left[wi] = peakL;
			_right[wi] = peakR;
			if (peakL > _leftPeak[wi]) {
				_leftPeak[wi] = peakL;
			} else {
				_leftPeak[wi] *= PeakDecay;
			}
			if (peakR > _rightPeak[wi]) {
				_rightPeak[wi] = peakR;
			} else {
				_rightPeak[wi] *= PeakDecay;
			}
			_writeIndex++;
			written++;
		}
		return written;
	}

	/// <summary>Reads the bucket at the supplied index (0..DisplaySamples-1).</summary>
	public WaveformBucket GetBucket(int index) {
		if (index < 0 || index >= DisplaySamples) {
			throw new ArgumentOutOfRangeException(nameof(index), index, "Bucket index out of range.");
		}
		return new WaveformBucket(_left[index], _right[index], _leftPeak[index], _rightPeak[index]);
	}

	/// <summary>True when at least one bucket holds a non-trivial left amplitude.</summary>
	public bool HasLeftSignal(float threshold = 0.001f) {
		for (int i = 0; i < _left.Length; i++) {
			if (_left[i] > threshold) {
				return true;
			}
		}
		return false;
	}

	/// <summary>True when at least one bucket holds a non-trivial right amplitude.</summary>
	public bool HasRightSignal(float threshold = 0.001f) {
		for (int i = 0; i < _right.Length; i++) {
			if (_right[i] > threshold) {
				return true;
			}
		}
		return false;
	}

	/// <summary>
	/// Read-start index for a single-pass render: the oldest bucket
	/// that should be drawn at x=0.
	/// </summary>
	public int ReadStart() {
		return _writeIndex >= DisplaySamples ? _writeIndex - DisplaySamples : 0;
	}

	/// <summary>Clears every bucket and the write counter.</summary>
	public void Reset() {
		Array.Clear(_left);
		Array.Clear(_right);
		Array.Clear(_leftPeak);
		Array.Clear(_rightPeak);
		_writeIndex = 0;
	}
}
