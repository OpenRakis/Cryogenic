namespace Cryogenic.Mt32Player.Services;

using Mt32emu;

using Spice86.Audio.Backend.Audio;
using Spice86.Audio.Filters;

using System.IO.Compression;
using System.Linq;

public sealed class Mt32MidiSynth : MidiDeviceBase {
	private const int SampleRate = 48000;
	private const int FramesPerBuffer = 1024;
	private const int PrebufferMs = 25;

	private readonly Mt32Context _context;
	private readonly AudioPlayer _audioPlayer;
	private readonly Thread _renderThread;
	private readonly object _lock = new();
	private bool _disposed;
	private float _outputGain = 1.0f;
	private float _lastPeak;

	public event Action<float>? AudioPeakComputed;

	/// <summary>
	/// Called after each render with the interleaved float buffer and sample count.
	/// Used by the waveform display to capture live audio data.
	/// The array reference may be reused across calls — consumers must copy if needed.
	/// </summary>
	public event Action<float[], int>? AudioSamplesRendered;

	public Mt32MidiSynth(string romsPath) {
		if (string.IsNullOrWhiteSpace(romsPath)) {
			throw new ArgumentException("ROM path is required.", nameof(romsPath));
		}

		_context = new Mt32Context();
		if (!LoadRoms(romsPath)) {
			string details = ValidateRomPath(romsPath);
			throw new InvalidOperationException($"No MT-32 ROM found at '{romsPath}'. Details: {details}");
		}

		_context.AnalogOutputMode = Mt32GlobalState.GetBestAnalogOutputMode(SampleRate);
		_context.SetSampleRate(SampleRate);
		_context.OpenSynth();

		AudioPlayerFactory factory = new(AudioEngine.CrossPlatform);
		_audioPlayer = factory.CreatePlayer(SampleRate, FramesPerBuffer, PrebufferMs, allowNegotiate: false);
		_audioPlayer.Start();

		_renderThread = new Thread(RenderLoop) {
			IsBackground = true,
			Name = "Mt32RenderThread",
			Priority = ThreadPriority.AboveNormal
		};
		_renderThread.Start();
	}

	/// <summary>
	/// Validates whether ROM files exist at the given path.
	/// Returns a diagnostic message describing what was found.
	/// </summary>
	public static string ValidateRomPath(string romsPath) {
		if (string.IsNullOrWhiteSpace(romsPath)) {
			return "ROM path is empty.";
		}

		if (romsPath.EndsWith(".zip", StringComparison.OrdinalIgnoreCase)) {
			if (!File.Exists(romsPath)) {
				return $"ZIP file does not exist: '{romsPath}'";
			}

			try {
				using ZipArchive zip = new(File.OpenRead(romsPath), ZipArchiveMode.Read);
				int romCount = zip.Entries.Count(e => e.FullName.EndsWith(".ROM", StringComparison.OrdinalIgnoreCase));
				return romCount > 0 ? $"ZIP contains {romCount} ROM file(s)." : "ZIP exists but contains no .ROM files.";
			} catch (Exception ex) {
				return $"Failed to read ZIP: {ex.Message}";
			}
		}

		if (!Directory.Exists(romsPath)) {
			return $"Directory does not exist: '{romsPath}'";
		}

		string[] filesUppercase = Directory.GetFiles(romsPath, "*.ROM", SearchOption.TopDirectoryOnly);
		string[] filesLowercase = Directory.GetFiles(romsPath, "*.rom", SearchOption.TopDirectoryOnly);
		int totalRoms = filesUppercase.Length + filesLowercase.Length;

		if (totalRoms > 0) {
			return $"Directory exists with {totalRoms} ROM file(s).";
		}

		string[] allFiles = Directory.GetFiles(romsPath);
		return $"Directory exists but is empty (found {allFiles.Length} files total, 0 with .ROM extension).";
	}

	/// <summary>
	/// Gets or sets the audio output gain multiplier (0.0 to 2.0).
	/// Default is 1.0 (unity gain), matching the Spice86 mixer pipeline to ensure
	/// nominal/usable volume output. Adjust if output is too loud or too soft.
	/// </summary>
	public float OutputGain {
		get => _outputGain;
		set {
			float clamped = Math.Clamp(value, 0.0f, 2.0f);
			_outputGain = clamped;
		}
	}

	public float LastPeak => _lastPeak;

	/// <summary>
	/// Called by the audio render path before each Render with the frame count.
	/// The engine hooks this to advance PIT ticks and dispatch MIDI events
	/// in sync with the audio sample clock.
	/// </summary>
	public Action<int>? OnBeforeRender { get; set; }

	/// <summary>
	/// Sends a 3-byte MIDI message by packing status|data1|data2 into a uint32
	/// and calling PlayMessage directly. Bypasses MidiDeviceBase.SendByte to
	/// avoid the byte-assembly state machine and its thread-safety issues.
	/// </summary>
	public void SendMidi3(byte status, byte data1, byte data2) {
		if (_disposed) { return; }
		uint message = (uint)(status | (data1 << 8) | (data2 << 16));
		lock (_lock) {
			_context.PlayMessage(message);
		}
	}

	/// <summary>
	/// Sends a 2-byte MIDI message (e.g. program change, channel pressure).
	/// </summary>
	public void SendMidi2(byte status, byte data1) {
		if (_disposed) { return; }
		uint message = (uint)(status | (data1 << 8));
		lock (_lock) {
			_context.PlayMessage(message);
		}
	}

	public void SendMidi1(byte status) {
		if (_disposed) { return; }
		lock (_lock) {
			_context.PlayMessage(status);
		}
	}

	public int RenderFloatInterleaved(Span<float> output, int requestedFrames) {
		if (_disposed) {
			output.Clear();
			return 0;
		}

		int sampleCount = requestedFrames * 2;
		Span<float> destination = output[..sampleCount];
		destination.Clear();

		// Advance engine ticks BEFORE rendering so MIDI events
		// dispatched during tick processing take effect in this buffer.
		OnBeforeRender?.Invoke(requestedFrames);

		lock (_lock) {
			_context.Render(destination);
		}

		float peak = 0;
		if (_outputGain != 1.0f) {
			for (int i = 0; i < destination.Length; i++) {
				float v = destination[i] * _outputGain;
				if (v > 1.0f) {
					v = 1.0f;
				} else if (v < -1.0f) {
					v = -1.0f;
				}
				destination[i] = v;
				float a = Math.Abs(v);
				if (a > peak) {
					peak = a;
				}
			}
		} else {
			for (int i = 0; i < destination.Length; i++) {
				float a = Math.Abs(destination[i]);
				if (a > peak) {
					peak = a;
				}
			}
		}

		_lastPeak = peak;
		AudioPeakComputed?.Invoke(peak);
		AudioSamplesRendered?.Invoke(destination.ToArray(), sampleCount);

		return requestedFrames;
	}

	protected override void PlayShortMessage(uint message) {
		if (_disposed) {
			return;
		}

		lock (_lock) {
			_context.PlayMessage(message);
		}
	}

	protected override void PlaySysex(ReadOnlySpan<byte> data) {
		if (_disposed) {
			return;
		}

		lock (_lock) {
			_context.PlaySysex(data);
		}
	}

	protected override void Dispose(bool disposing) {
		if (_disposed) {
			return;
		}

		_disposed = true;

		if (disposing) {
			_renderThread.Join(millisecondsTimeout: 2000);
			_audioPlayer.Dispose();
			lock (_lock) {
				_context.Dispose();
			}
		}
	}

	private bool LoadRoms(string path) {
		if (!path.EndsWith(".zip", StringComparison.OrdinalIgnoreCase)) {
			if (!Directory.Exists(path)) {
				return false;
			}

			// Look for .ROM files (case-insensitive search on Windows)
			string[] files = Directory.GetFiles(path, "*.ROM", SearchOption.TopDirectoryOnly);
			if (files.Length == 0) {
				// Also try lowercase *.rom in case of filesystem issue
				files = Directory.GetFiles(path, "*.rom", SearchOption.TopDirectoryOnly);
				if (files.Length == 0) {
					return false;
				}
			}

			foreach (string file in files) {
				_context.AddRom(file);
			}

			return true;
		}

		using ZipArchive zip = new(File.OpenRead(path), ZipArchiveMode.Read);
		bool found = false;
		foreach (ZipArchiveEntry entry in zip.Entries) {
			if (!entry.FullName.EndsWith(".ROM", StringComparison.OrdinalIgnoreCase)) {
				continue;
			}

			using Stream stream = entry.Open();
			_context.AddRom(stream);
			found = true;
		}

		return found;
	}

	/// <summary>
	/// Dedicated render thread: renders MT-32 audio in <see cref="FramesPerBuffer"/>-frame
	/// chunks and pushes them to the Spice86.Audio player queue.
	/// <see cref="AudioPlayer.WriteData"/> blocks when the queue is full, providing
	/// natural backpressure without busy-waiting.
	/// </summary>
	private void RenderLoop() {
		float[] buffer = new float[FramesPerBuffer * 2];
		while (!_disposed) {
			Span<float> span = buffer.AsSpan();
			RenderFloatInterleaved(span, FramesPerBuffer);
			_audioPlayer.WriteData(span);
		}
	}
}
