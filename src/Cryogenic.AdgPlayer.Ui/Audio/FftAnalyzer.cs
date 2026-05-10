namespace Cryogenic.AdgPlayer.Ui.Audio;

using System;

/// <summary>
/// Minimal radix-2 Cooley-Tukey FFT used by the spectrum panel.
/// Operates on power-of-two sized real input via in-place complex
/// arrays. Lives in a non-UI namespace so unit tests don't need
/// any Avalonia platform.
/// </summary>
public sealed class FftAnalyzer {
	/// <summary>FFT size (power of two).</summary>
	public int Size { get; }

	private readonly float[] _window;
	private readonly float[] _real;
	private readonly float[] _imag;
	private readonly float[] _magnitudes;

	/// <summary>Builds an analyzer with the supplied FFT size.</summary>
	public FftAnalyzer(int size) {
		if (size < 2 || (size & (size - 1)) != 0) {
			throw new ArgumentOutOfRangeException(nameof(size), size, "FFT size must be a power of two greater than or equal to 2.");
		}
		Size = size;
		_window = new float[size];
		_real = new float[size];
		_imag = new float[size];
		_magnitudes = new float[(size / 2) + 1];
		for (int i = 0; i < size; i++) {
			_window[i] = 0.5f - (0.5f * MathF.Cos(2f * MathF.PI * i / (size - 1)));
		}
	}

	/// <summary>
	/// Computes the magnitude spectrum of the supplied real signal
	/// (length must equal <see cref="Size"/>) and returns a slice
	/// of length <c>Size/2 + 1</c> holding linear magnitudes.
	/// </summary>
	public ReadOnlySpan<float> Analyze(float[] samples) {
		ArgumentNullException.ThrowIfNull(samples);
		if (samples.Length != Size) {
			throw new ArgumentException($"Sample buffer length must equal FFT size ({Size}).", nameof(samples));
		}

		for (int i = 0; i < Size; i++) {
			_real[i] = samples[i] * _window[i];
			_imag[i] = 0f;
		}

		Transform(_real, _imag);

		int half = Size / 2;
		for (int k = 0; k <= half; k++) {
			float re = _real[k];
			float im = _imag[k];
			_magnitudes[k] = MathF.Sqrt((re * re) + (im * im));
		}
		return _magnitudes.AsSpan(0, half + 1);
	}

	/// <summary>
	/// Reduces a magnitude spectrum to <paramref name="bandCount"/>
	/// log-spaced bins, normalised to <c>[0,1]</c> against the
	/// largest bin in this call. Output buffer length must equal
	/// <paramref name="bandCount"/>.
	/// </summary>
	public void ReduceToBands(ReadOnlySpan<float> magnitudes, float[] bands) {
		ArgumentNullException.ThrowIfNull(bands);
		if (bands.Length == 0) {
			throw new ArgumentException("Bands buffer must be non-empty.", nameof(bands));
		}
		int bandCount = bands.Length;
		int spectrumLength = magnitudes.Length;
		float max = 0f;
		for (int b = 0; b < bandCount; b++) {
			int lo = (int)((long)b * (spectrumLength - 1) / bandCount);
			int hi = (int)((long)(b + 1) * (spectrumLength - 1) / bandCount);
			if (hi <= lo) {
				hi = lo + 1;
			}
			if (hi > spectrumLength) {
				hi = spectrumLength;
			}
			float sum = 0f;
			for (int i = lo; i < hi; i++) {
				sum += magnitudes[i];
			}
			float value = sum / (hi - lo);
			bands[b] = value;
			if (value > max) {
				max = value;
			}
		}
		if (max > 0f) {
			for (int b = 0; b < bandCount; b++) {
				bands[b] /= max;
			}
		}
	}

	private static void Transform(float[] real, float[] imag) {
		int n = real.Length;
		// Bit reversal.
		for (int i = 1, j = 0; i < n; i++) {
			int bit = n >> 1;
			for (; (j & bit) != 0; bit >>= 1) {
				j ^= bit;
			}
			j ^= bit;
			if (i < j) {
				(real[i], real[j]) = (real[j], real[i]);
				(imag[i], imag[j]) = (imag[j], imag[i]);
			}
		}
		// Butterflies.
		for (int len = 2; len <= n; len <<= 1) {
			float angle = -2f * MathF.PI / len;
			float wReal = MathF.Cos(angle);
			float wImag = MathF.Sin(angle);
			for (int i = 0; i < n; i += len) {
				float curReal = 1f;
				float curImag = 0f;
				int half = len >> 1;
				for (int k = 0; k < half; k++) {
					int aIdx = i + k;
					int bIdx = i + k + half;
					float tRe = (curReal * real[bIdx]) - (curImag * imag[bIdx]);
					float tIm = (curReal * imag[bIdx]) + (curImag * real[bIdx]);
					real[bIdx] = real[aIdx] - tRe;
					imag[bIdx] = imag[aIdx] - tIm;
					real[aIdx] += tRe;
					imag[aIdx] += tIm;
					float nextReal = (curReal * wReal) - (curImag * wImag);
					float nextImag = (curReal * wImag) + (curImag * wReal);
					curReal = nextReal;
					curImag = nextImag;
				}
			}
		}
	}
}