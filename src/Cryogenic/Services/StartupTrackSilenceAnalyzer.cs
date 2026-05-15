namespace Cryogenic.Services;

using LibVLCSharp.Shared;

using System;
using System.Buffers;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

/// <summary>
/// Analyzes leading audio content to compute a conservative skip offset for startup playback.
/// </summary>
internal sealed class StartupTrackSilenceAnalyzer {
	private const uint AnalysisSampleRateHz = 44100;
	private const uint AnalysisChannelCount = 2;
	private const string AnalysisAudioFormat = "S16N";
	private const int AnalysisWindowMs = 45000;
	private const int AnalysisTimeoutMs = 15000;
	private const double SilenceThresholdRms = 0.01;
	private const double SustainWindowMs = 220.0;
	private const double OnsetPreRollMs = 120.0;

	private readonly LibVLC _libVlc;

	public StartupTrackSilenceAnalyzer(LibVLC libVlc) {
		_libVlc = libVlc;
	}

	/// <summary>
	/// Computes a per-track skip offset in milliseconds from decoded audio content.
	/// </summary>
	public TrackSilenceAnalysisResult Analyze(string trackPath) {
		using MediaPlayer analysisPlayer = new MediaPlayer(_libVlc);
		AnalysisAccumulator accumulator = new AnalysisAccumulator(AnalysisWindowMs, SilenceThresholdRms, SustainWindowMs);

		void PlayCallback(IntPtr data, IntPtr samples, uint count, long pts) {
			if (count == 0U) {
				return;
			}
			int frameCount = checked((int)count);
			double rms = ComputeRms(samples, frameCount);
			double chunkMs = frameCount * 1000.0 / AnalysisSampleRateHz;
			accumulator.AddChunk(rms, chunkMs);
		}

		analysisPlayer.SetAudioFormat(AnalysisAudioFormat, AnalysisSampleRateHz, AnalysisChannelCount);
		analysisPlayer.SetAudioCallbacks(PlayCallback, null, null, null, null);
		using Media media = new Media(_libVlc, trackPath, FromType.FromPath);
		analysisPlayer.Media = media;

		bool started = analysisPlayer.Play();
		if (!started) {
			throw new InvalidOperationException($"Could not start analysis playback for '{trackPath}'.");
		}

		Stopwatch stopwatch = Stopwatch.StartNew();
		while (stopwatch.ElapsedMilliseconds < AnalysisTimeoutMs) {
			SpinWait.SpinUntil(() => accumulator.ShouldStop);
		}
		analysisPlayer.Stop();

		if (!accumulator.HasSamples) {
			throw new InvalidOperationException($"No audio samples decoded while analyzing '{trackPath}'.");
		}

		long skipMs = 0;
		double confidence = 0.0;
		if (accumulator.HasOnset) {
			double rawSkip = accumulator.OnsetMs - OnsetPreRollMs;
			skipMs = Math.Max(0L, (long)Math.Round(rawSkip));
			confidence = Math.Min(1.0, 0.7 + accumulator.SustainAtOnsetMs / 500.0);
		}

		return new TrackSilenceAnalysisResult(skipMs, confidence);
	}

	private static double ComputeRms(IntPtr samples, int frameCount) {
		int totalSamples = checked(frameCount * (int)AnalysisChannelCount);
		short[] rentedBuffer = ArrayPool<short>.Shared.Rent(totalSamples);
		try {
			Marshal.Copy(samples, rentedBuffer, 0, totalSamples);
			double sumSquares = 0.0;
			for (int frame = 0; frame < frameCount; frame++) {
				int baseIndex = frame * (int)AnalysisChannelCount;
				double mono = 0.0;
				for (int channel = 0; channel < (int)AnalysisChannelCount; channel++) {
					mono += rentedBuffer[baseIndex + channel] / 32768.0;
				}
				mono /= AnalysisChannelCount;
				sumSquares += mono * mono;
			}
			return Math.Sqrt(sumSquares / frameCount);
		} finally {
			ArrayPool<short>.Shared.Return(rentedBuffer);
		}
	}

	private sealed class AnalysisAccumulator {
		private readonly Lock _lock = new Lock();
		private readonly int _analysisWindowMs;
		private readonly double _silenceThresholdRms;
		private readonly double _sustainWindowMs;
		private double _decodedMs;
		private double _sustainMs;

		public AnalysisAccumulator(int analysisWindowMs, double silenceThresholdRms, double sustainWindowMs) {
			_analysisWindowMs = analysisWindowMs;
			_silenceThresholdRms = silenceThresholdRms;
			_sustainWindowMs = sustainWindowMs;
		}

		public bool HasSamples { get; private set; }
		public bool HasOnset { get; private set; }
		public double OnsetMs { get; private set; }
		public double SustainAtOnsetMs { get; private set; }

		public bool ShouldStop {
			get {
				lock (_lock) {
					return HasOnset || _decodedMs >= _analysisWindowMs;
				}
			}
		}

		public void AddChunk(double rms, double chunkMs) {
			lock (_lock) {
				HasSamples = true;
				if (rms >= _silenceThresholdRms) {
					_sustainMs += chunkMs;
				} else {
					_sustainMs = 0.0;
				}

				double chunkEndMs = _decodedMs + chunkMs;
				if (!HasOnset && _sustainMs >= _sustainWindowMs) {
					HasOnset = true;
					OnsetMs = Math.Max(0.0, chunkEndMs - _sustainMs);
					SustainAtOnsetMs = _sustainMs;
				}

				_decodedMs = chunkEndMs;
			}
		}
	}
}

/// <summary>
/// Result of per-track silence analysis.
/// </summary>
[StructLayout(LayoutKind.Auto)]
internal readonly struct TrackSilenceAnalysisResult {
	public TrackSilenceAnalysisResult(long skipMs, double confidence) {
		SkipMs = skipMs;
		Confidence = confidence;
	}

	public long SkipMs { get; }
	public double Confidence { get; }
}
