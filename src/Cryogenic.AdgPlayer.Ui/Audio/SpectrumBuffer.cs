namespace Cryogenic.AdgPlayer.Ui.Audio;

using System;

/// <summary>
/// Holds a fixed-size mono input buffer (the most recent
/// <c>Size</c> samples, mixed L+R) plus a band buffer that the
/// renderer reads. Decouples the FFT computation cadence from the
/// sample push cadence: callers <c>PushSamples</c> at any rate
/// while the analyzer recomputes <see cref="Bands"/> on
/// <see cref="Recompute"/>.
/// </summary>
public sealed class SpectrumBuffer {
	/// <summary>Default FFT size used by the spectrum panel.</summary>
	public const int DefaultFftSize = 512;

	/// <summary>Default band count rendered by the spectrum panel.</summary>
	public const int DefaultBandCount = 64;

	private readonly FftAnalyzer _analyzer;
	private readonly float[] _ring;
	private readonly float[] _scratch;
	private readonly float[] _bands;
	private int _writeIndex;

	/// <summary>FFT size (= ring buffer length).</summary>
	public int Size => _analyzer.Size;

	/// <summary>Number of bands exposed in <see cref="Bands"/>.</summary>
	public int BandCount => _bands.Length;

	/// <summary>Read-only view of the latest computed band magnitudes.</summary>
	public ReadOnlySpan<float> Bands => _bands;

	/// <summary>Builds a spectrum buffer with default sizes.</summary>
	public SpectrumBuffer() : this(DefaultFftSize, DefaultBandCount) {
	}

	/// <summary>Builds a spectrum buffer with explicit FFT and band sizes.</summary>
	public SpectrumBuffer(int fftSize, int bandCount) {
		if (bandCount <= 0) {
			throw new ArgumentOutOfRangeException(nameof(bandCount), bandCount, "Band count must be positive.");
		}
		_analyzer = new FftAnalyzer(fftSize);
		_ring = new float[fftSize];
		_scratch = new float[fftSize];
		_bands = new float[bandCount];
	}

	/// <summary>
	/// Mixes <paramref name="interleaved"/> down to mono and writes
	/// it into the ring buffer. Returns the number of mono frames
	/// pushed.
	/// </summary>
	public int PushSamples(float[] interleaved, int sampleCount) {
		ArgumentNullException.ThrowIfNull(interleaved);
		if (sampleCount < 0 || sampleCount > interleaved.Length) {
			throw new ArgumentOutOfRangeException(nameof(sampleCount), sampleCount, "Sample count out of range.");
		}
		int frames = sampleCount / 2;
		for (int i = 0; i < frames; i++) {
			float mono = (interleaved[i * 2] + interleaved[(i * 2) + 1]) * 0.5f;
			_ring[_writeIndex % _ring.Length] = mono;
			_writeIndex++;
		}
		return frames;
	}

	/// <summary>
	/// Snapshots the ring buffer in time order, runs the FFT, and
	/// fills <see cref="Bands"/>.
	/// </summary>
	public void Recompute() {
		int n = _ring.Length;
		int start = _writeIndex >= n ? _writeIndex - n : 0;
		for (int i = 0; i < n; i++) {
			_scratch[i] = _ring[(start + i) % n];
		}
		ReadOnlySpan<float> spectrum = _analyzer.Analyze(_scratch);
		_analyzer.ReduceToBands(spectrum, _bands);
	}

	/// <summary>Clears the ring and band buffers.</summary>
	public void Reset() {
		Array.Clear(_ring);
		Array.Clear(_scratch);
		Array.Clear(_bands);
		_writeIndex = 0;
	}
}