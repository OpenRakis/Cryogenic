namespace Cryogenic.AdpPlayer.Services;

using Serilog;

using Spice86.Audio.Filters;
using Spice86.Core.Emulator.CPU;
using Spice86.Core.Emulator.Devices.Sound;
using Spice86.Core.Emulator.IOPorts;
using Spice86.Core.Emulator.VM;
using Spice86.Core.Emulator.VM.Breakpoint;
using Spice86.Core.Emulator.VM.Clock;
using Spice86.Shared.Interfaces;

/// <summary>
/// OPL2 synthesizer wrapping the full Spice86 audio stack:
///   AudioEngine.CrossPlatform → SoftwareMixer → Opl3Fm (NukedOPL3Sharp)
///
/// This produces audio identical to the emulator. No NAudio dependency.
///
/// Write OPL2 registers via <see cref="WriteRegister"/>. Audio is rendered
/// by the SoftwareMixer's dedicated thread and output via Spice86.Audio
/// (WASAPI on Windows, ALSA on Linux, CoreAudio on macOS).
/// </summary>
public sealed partial class Opl2Synth : IDisposable {
	private readonly IPauseHandler _pauseHandler;
	private readonly SoftwareMixer _mixer;
	private readonly State _state;
	private readonly SampleDrivenClock _clock;
	private readonly IOPortDispatcher _ioPortDispatcher;
	private readonly Opl3Fm _opl;
	private readonly ILoggerService _loggerService;
	private readonly SoundChannel _clockChannel;
	private bool _disposed;
	private float _outputGain = 1.5f;
	private float _lastPeak = 0.0f;

	/// <summary>
	/// Fired after each audio render with the peak amplitude (0..1).
	/// Wired via periodic polling from the engine tick path.
	/// </summary>
	public event Action<float>? AudioPeakComputed;

	/// <summary>
	/// Fired after each render with interleaved stereo float samples.
	/// Used by the waveform display. The array may be reused across calls.
	/// Wired via periodic polling from the engine tick path.
	/// </summary>
	public event Action<float[], int>? AudioSamplesRendered;

	/// <summary>
	/// Called by the audio render path before each render with the frame count.
	/// The engine hooks this to advance PIT ticks in sync with the audio clock.
	/// </summary>
	public Action<int>? OnBeforeRender { get; set; }

	/// <summary>
	/// Gets or sets the output gain (0.0 .. 2.0). Default 1.5 matches emulator OPL gain.
	/// </summary>
	public float OutputGain {
		get => _outputGain;
		set => _outputGain = Math.Clamp(value, 0.0f, 2.0f);
	}

	/// <summary>
	/// Last peak amplitude from the most recent audio render (0..1).
	/// </summary>
	public float LastPeak => _lastPeak;

	/// <summary>
	/// Exposes the circular log sink for the MCP control server.
	/// </summary>
	public CircularLogSink LogSink => ((StandaloneLoggerService)_loggerService).Sink;

	/// <summary>
	/// Adds a debug entry to the Serilog circular buffer from external callers.
	/// </summary>
	public void LogDebug(string message) {
		((ILogger)_loggerService).Debug(message);
	}

	/// <summary>
	/// Creates the full Spice86 OPL2 audio pipeline as a standalone instance.
	/// Registers a clock pump channel with the mixer so the engine tick path
	/// runs in sync with the audio render thread (SDL backpressure).
	/// </summary>
	public Opl2Synth() {
		_pauseHandler = new StandalonePauseHandler();
		_mixer = new SoftwareMixer(AudioEngine.CrossPlatform, _pauseHandler);
		_state = new State(CpuModel.INTEL_8086);
		_clock = new SampleDrivenClock();
		_loggerService = new StandaloneLoggerService();

		AddressReadWriteBreakpoints breakpoints = new();
		_ioPortDispatcher = new IOPortDispatcher(breakpoints, _state, _loggerService, false);

		// Register the clock pump channel BEFORE Opl3Fm so it is iterated
		// first by MixSamples (Dictionary preserves insertion order in .NET).
		// Its handler advances engine ticks, which write OPL registers,
		// which feed Opl3Fm's FIFO via RenderUpToNow.
		_clockChannel = _mixer.AddChannel(
			ClockChannelCallback,
			48000,
			"EngineClock",
			new HashSet<ChannelFeature>());
		_clockChannel.Enable(true);

		OplConfig config = new(OplMode.Opl2, 0x388, false);
		_opl = new Opl3Fm(config, _mixer, _state, _clock, _ioPortDispatcher, false, _loggerService);

		// SoftwareMixer.AddChannel defaults to Enable(false) for uncached channels.
		// Opl3Fm relies on its Sleep/WakeUp mechanism, but that skips FIFO rendering
		// on the first wake, causing signal detection to miss real audio.
		// Force-enable the OPL channel so AudioCallback always runs.
		_opl.MixerChannel.Enable(true);
		((ILogger)_loggerService).Debug(
			"OPL channel force-enabled after init: IsEnabled={Enabled}",
			_opl.MixerChannel.IsEnabled);
	}

	/// <summary>
	/// Mixer-thread callback for the clock pump channel.
	/// Called by <see cref="SoftwareMixer"/> when it needs frames.
	/// Advances engine ticks (which write OPL registers via <see cref="WriteRegister"/>),
	/// then pushes silence frames since this channel produces no audio itself.
	/// Also computes estimated peak amplitude from current engine state.
	/// </summary>
	private void ClockChannelCallback(int framesRequested) {
		// Advance the sample-driven clock BEFORE engine ticks so that
		// Opl3Fm.WriteByte → RenderUpToNow sees the correct "now" and
		// renders the right number of FIFO frames for this block.
		_clock.Advance(framesRequested);

		// Keep the OPL channel alive: the Sleeper's MaybeSleep (runs at end of
		// MixSamples) can disable the channel after 500ms of undetected signal.
		// Re-enabling here ensures AudioCallback always runs on the next iteration.
		if (!_opl.MixerChannel.IsEnabled) {
			_opl.MixerChannel.Enable(true);
			((ILogger)_loggerService).Debug(
				"ClockPump: OPL channel was sleeping, re-enabled at clockMs={ClockMs:F1}",
				_clock.ElapsedTimeMs);
		}

		_clockCallbackCount++;
		if ((_clockCallbackCount % 500) == 1) {
			((ILogger)_loggerService).Debug(
				"ClockPump #{Count}: frames={Frames} clockMs={ClockMs:F1} onBefore={HasHook} oplEnabled={OplEnabled}",
				_clockCallbackCount, framesRequested, _clock.ElapsedTimeMs, OnBeforeRender is not null, _opl.MixerChannel.IsEnabled);
		}

		// Advance the engine (PIT ticks → OPL register writes → Opl3Fm FIFO fills).
		OnBeforeRender?.Invoke(framesRequested);

		// Produce silence so the mixer is satisfied.
		Span<float> silence = stackalloc float[2];
		for (int i = 0; i < framesRequested; i++) {
			_clockChannel.AddSamplesFloat(1, silence);
		}
	}

	private int _clockCallbackCount;
	private int _writeRegisterCount;

	/// <summary>
	/// Writes an OPL2 register. Equivalent to:
	///   out 0x388, register  (address latch)
	///   out 0x389, value     (data write)
	/// This triggers NukedOPL3Sharp cycle-accurate rendering.
	/// </summary>
	public void WriteRegister(byte register, byte value) {
		if (_disposed) {
			return;
		}
		_writeRegisterCount++;
		if (_writeRegisterCount <= 20 || (_writeRegisterCount % 200) == 0) {
			((ILogger)_loggerService).Debug(
				"OPL WriteReg #{Count}: reg=0x{Reg:X2} val=0x{Val:X2} clockMs={ClockMs:F1}",
				_writeRegisterCount, register, value, _clock.ElapsedTimeMs);
		}
		_opl.WriteByte(0x388, register);
		_opl.WriteByte(0x389, value);
	}

	/// <summary>
	/// Notifies subscribers of the current peak amplitude.
	/// Called periodically from the engine tick path since SoftwareMixer
	/// manages its own render thread and doesn't expose a callback hook.
	/// </summary>
	public void NotifyPeak(float peak) {
		_lastPeak = peak;
		AudioPeakComputed?.Invoke(peak);
	}

	/// <summary>
	/// Notifies subscribers with rendered audio samples for waveform display.
	/// </summary>
	public void NotifySamples(float[] samples, int count) {
		AudioSamplesRendered?.Invoke(samples, count);
	}

	/// <summary>
	/// Releases all resources: OPL chip, mixer thread, audio backend.
	/// </summary>
	public void Dispose() {
		if (_disposed) {
			return;
		}
		_disposed = true;
		OnBeforeRender = null;
		_opl.Dispose();
		_mixer.Dispose();
		_clock.Dispose();
		_pauseHandler.Dispose();
	}

	/// <summary>
	/// Sends a raw OPL test tone through the entire audio stack.
	/// Writes instrument + note-on directly, bypassing the engine entirely.
	/// Call <see cref="StopTestTone"/> to silence.
	/// </summary>
	public void PlayTestTone(int channel, byte note, byte volume) {
		int ch = Math.Clamp(channel, 0, 8);
		byte op1 = _testOp1Map[ch];
		byte op2 = _testOp2Map[ch];

		// Simple FM instrument: sine carrier, sine modulator, short attack, medium sustain
		WriteRegister((byte)(0x20 + op1), 0x21); // AM=0, VIB=0, EGT=1, KSR=0, MULT=1
		WriteRegister((byte)(0x20 + op2), 0x21);
		WriteRegister((byte)(0x40 + op1), 0x00); // Modulator: full volume (KSL=0, TL=0)
		WriteRegister((byte)(0x40 + op2), (byte)(volume & 0x3F)); // Carrier: user volume
		WriteRegister((byte)(0x60 + op1), 0xF0); // Fast attack, slow decay
		WriteRegister((byte)(0x60 + op2), 0xF0);
		WriteRegister((byte)(0x80 + op1), 0x77); // Medium sustain/release
		WriteRegister((byte)(0x80 + op2), 0x77);
		WriteRegister((byte)(0xE0 + op1), 0x00); // Sine wave
		WriteRegister((byte)(0xE0 + op2), 0x00);
		WriteRegister((byte)(0xC0 + ch), 0x01);  // FM synthesis, feedback=0

		// Note on: compute F-number from note
		int adjusted = Math.Clamp((int)note, 0, 95);
		int octave = adjusted / 12;
		int semitone = adjusted % 12;
		ushort fnum = _testFreqTable[semitone];
		WriteRegister((byte)(0xA0 + ch), (byte)(fnum & 0xFF));
		WriteRegister((byte)(0xB0 + ch), (byte)(0x20 | ((octave & 7) << 2) | ((fnum >> 8) & 3)));

		((ILogger)_loggerService).Debug(
			"TestTone ON: ch={Ch} note={Note} vol={Vol} fnum=0x{Fnum:X3} oct={Oct} oplEnabled={OplEnabled}",
			ch, note, volume, fnum, octave, _opl.MixerChannel.IsEnabled);
	}

	/// <summary>
	/// Stops the test tone on the given channel.
	/// </summary>
	public void StopTestTone(int channel) {
		int ch = Math.Clamp(channel, 0, 8);
		WriteRegister((byte)(0xB0 + ch), 0x00); // Key off
		((ILogger)_loggerService).Debug("TestTone OFF: ch={Ch}", ch);
	}

	/// <summary>
	/// Sends a short test beep: note on, then schedules note off after a delay.
	/// This is fire-and-forget, useful as a panic/diagnostic button.
	/// </summary>
	public void PlayTestBeep() {
		PlayTestTone(0, 60, 0x00); // Middle C, full volume on channel 0
		Task.Delay(500, CancellationToken.None).ContinueWith(_ => StopTestTone(0));
	}

	// Mini frequency table for test tones (same as engine's)
	private static readonly ushort[] _testFreqTable = [
		0x0157, 0x016C, 0x0181, 0x0198, 0x01B1, 0x01CB,
		0x01E6, 0x0203, 0x0222, 0x0243, 0x0266, 0x028A
	];
	private static readonly byte[] _testOp1Map = [0x00, 0x01, 0x02, 0x08, 0x09, 0x0A, 0x10, 0x11, 0x12];
	private static readonly byte[] _testOp2Map = [0x03, 0x04, 0x05, 0x0B, 0x0C, 0x0D, 0x13, 0x14, 0x15];
}