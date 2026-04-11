namespace Cryogenic.AdpPlayer.Services;

using Serilog;
using Serilog.Core;
using Serilog.Events;

using Spice86.Core.Emulator.CPU;
using Spice86.Core.Emulator.Devices.Sound;
using Spice86.Core.Emulator.IOPorts;
using Spice86.Core.Emulator.VM;
using Spice86.Core.Emulator.VM.Clock;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

/// <summary>
/// Minimal stub implementations of Spice86 interfaces needed to run
/// Opl3Fm outside the full emulator. These stubs provide the minimal
/// contracts so that the Spice86 audio pipeline (SoftwareMixer + Opl3Fm)
/// can be instantiated standalone.
/// </summary>
public sealed partial class Opl2Synth {
	/// <summary>
	/// No-op pause handler. The standalone player manages its own pause state.
	/// </summary>
	private sealed class StandalonePauseHandler : IPauseHandler {
		public bool IsPaused => false;
		public event Action? Pausing;
		public event Action? Paused;
		public event Action? Resumed;
		public void RequestPause(string? reason = null) { }
		public void Resume() { }
		public void WaitIfPaused() { }
		public void Dispose() { }

		/// <summary>
		/// Suppresses CS0067 (event never used) without removing the interface requirement.
		/// </summary>
		internal void SuppressWarnings() {
			Pausing?.Invoke();
			Paused?.Invoke();
			Resumed?.Invoke();
		}
	}

	/// <summary>
	/// Sample-count-driven emulated clock. Time advances in lockstep with the
	/// mixer thread's audio output, matching DOSBox Staging's PIC_FullIndex model
	/// rather than wall-clock time. This ensures Opl3Fm's RenderUpToNow produces
	/// correctly timed FIFO frames synchronized with the audio callback cadence.
	/// </summary>
	internal sealed class SampleDrivenClock : IEmulatedClock {
		private const double MixerSampleRate = 48000.0;
		private const double MsPerFrame = 1000.0 / MixerSampleRate;
		private double _elapsedMs;
		private bool _isPaused;

		public double ElapsedTimeMs => _elapsedMs;

		public DateTime StartTime { get; set; } = DateTime.UtcNow;

		public DateTime CurrentDateTime => StartTime + TimeSpan.FromMilliseconds(_elapsedMs);

		public bool IsPaused => _isPaused;

		/// <summary>
		/// Advances the clock by the given number of audio frames.
		/// Called from the clock pump channel callback before engine ticks run.
		/// </summary>
		public void Advance(int frames) {
			_elapsedMs += frames * MsPerFrame;
		}

		public void OnPause() {
			_isPaused = true;
		}

		public void OnResume() {
			_isPaused = false;
		}

		public void Dispose() {
			_isPaused = true;
		}
	}

	/// <summary>
	/// Minimal Serilog-based logger service for standalone player diagnostics.
	/// Routes OPL debug output to a circular buffer (for MCP inspection) and console.
	/// Set <see cref="LoggingLevelSwitch"/> to Debug to capture Spice86 audio stack logs.
	/// </summary>
	internal sealed class StandaloneLoggerService : ILoggerService {
		private readonly ILogger _inner;
		private readonly StandaloneLoggerPropertyBag _propertyBag = new();
		private readonly CircularLogSink _sink;

		public StandaloneLoggerService() {
			_sink = new CircularLogSink(512);
			LogLevelSwitch = new LoggingLevelSwitch(LogEventLevel.Debug);
			_inner = new LoggerConfiguration()
				.MinimumLevel.ControlledBy(LogLevelSwitch)
				.WriteTo.Sink(_sink)
				.WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss.fff} {Level:u3}] {Message:lj}{NewLine}{Exception}")
				.WriteTo.File(
					"logs/adpplayer.log",
					rollingInterval: RollingInterval.Day,
					outputTemplate: "[{Timestamp:HH:mm:ss.fff} {Level:u3}] {Message:lj}{NewLine}{Exception}",
					flushToDiskInterval: TimeSpan.FromSeconds(1),
					fileSizeLimitBytes: 50_000_000)
				.CreateLogger();
		}

		/// <summary>
		/// Returns the circular log sink so callers can read buffered entries.
		/// </summary>
		public CircularLogSink Sink => _sink;

		public LoggingLevelSwitch LogLevelSwitch { get; set; }
		public ILoggerPropertyBag LoggerPropertyBag => _propertyBag;
		public bool AreLogsSilenced { get; set; }

		public LoggerConfiguration CreateLoggerConfiguration() {
			return new LoggerConfiguration()
				.MinimumLevel.ControlledBy(LogLevelSwitch)
				.WriteTo.Console();
		}

		public ILoggerService WithLogLevel(LogEventLevel minimumLevel) {
			return this;
		}

		public void UseStderrForConsoleOutput() { }

		// ILogger delegation
		public void Write(LogEvent logEvent) {
			if (!AreLogsSilenced) {
				_inner.Write(logEvent);
			}
		}

		private sealed class StandaloneLoggerPropertyBag : ILoggerPropertyBag {
			public SegmentedAddress CsIp { get; set; }
			public int ContextIndex { get; set; }
		}
	}

	/// <summary>
	/// Thread-safe circular buffer Serilog sink. Captures the last N log entries
	/// for inspection via the MCP control server without filesystem I/O.
	/// </summary>
	public sealed class CircularLogSink : ILogEventSink {
		private readonly string[] _buffer;
		private readonly int _capacity;
		private int _head;
		private int _count;
		private readonly Lock _lock = new();

		public CircularLogSink(int capacity) {
			_capacity = capacity;
			_buffer = new string[capacity];
		}

		public void Emit(LogEvent logEvent) {
			string rendered = logEvent.RenderMessage();
			string line = $"[{logEvent.Timestamp:HH:mm:ss.fff}] [{logEvent.Level}] {rendered}";
			if (logEvent.Exception is not null) {
				line += $" | {logEvent.Exception.GetType().Name}: {logEvent.Exception.Message}";
			}
			lock (_lock) {
				_buffer[_head] = line;
				_head = (_head + 1) % _capacity;
				if (_count < _capacity) {
					_count++;
				}
			}
		}

		/// <summary>
		/// Returns all buffered log entries in chronological order, oldest first.
		/// </summary>
		public string[] GetEntries() {
			lock (_lock) {
				string[] result = new string[_count];
				int start = _count < _capacity ? 0 : _head;
				for (int i = 0; i < _count; i++) {
					result[i] = _buffer[(start + i) % _capacity];
				}
				return result;
			}
		}

		/// <summary>
		/// Returns the last N entries, newest first.
		/// </summary>
		public string[] GetLatest(int maxCount) {
			lock (_lock) {
				int n = Math.Min(maxCount, _count);
				string[] result = new string[n];
				for (int i = 0; i < n; i++) {
					int idx = (_head - 1 - i + _capacity) % _capacity;
					result[i] = _buffer[idx];
				}
				return result;
			}
		}

		/// <summary>
		/// Clears all buffered entries.
		/// </summary>
		public void Clear() {
			lock (_lock) {
				_head = 0;
				_count = 0;
				Array.Clear(_buffer);
			}
		}
	}
}