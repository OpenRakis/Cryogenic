namespace Cryogenic.AdgPlayer.Audio;

using Cryogenic.AdgPlayer.Opl;

using NukedOPL3Sharp;

using Serilog;

using Spice86.Audio.Filters;
using Spice86.Core.Emulator.Devices.Sound;
using Spice86.Core.Emulator.Devices.Sound.AdlibGoldOpl;
using Spice86.Core.Emulator.VM;

using System;
using System.Collections.Generic;

/// <summary>
/// OPL3 (AdLib Gold / dual-OPL3) synthesizer for the standalone ADG
/// player. Wraps <c>NukedOPL3Sharp.Opl3Chip</c> for synthesis and
/// Spice86's <see cref="SoftwareMixer"/> for the audio pipeline
/// (resampling 49716→native, master volume, filter chain). Implements
/// <see cref="IOplBus"/> so the engine can target it transparently
/// in place of the in-memory <see cref="NullOplBus"/> /
/// <see cref="RecordingOplBus"/> sinks.
/// </summary>
public sealed class AdgOplSynthesizer : IOplBus, IDisposable {
	private static readonly ILogger Logger = Log.ForContext<AdgOplSynthesizer>();

	/// <summary>Native OPL3 sample rate used by NukedOPL3Sharp.</summary>
	public const int NativeOplSampleRateConst = 49716;

	private readonly Opl3Chip _chip;
	private readonly AdlibGold _adlibGold;
	private readonly SoftwareMixer _mixer;
	private readonly SoundChannel _channel;
	private readonly NullPauseHandler _pauseHandler;
	private short[] _tempBuffer = new short[4096];
	private float[] _floatBuffer = new float[4096];
	private float[] _normalizedBuffer = new float[4096];
	private bool _disposed;

	/// <summary>
	/// Fires after each mixer batch with the normalized stereo float
	/// buffer (samples in [-1, +1], interleaved L/R) and the total
	/// sample count (frames × 2). UI visualizers (waveform / spectrum)
	/// subscribe here to render the live audio stream.
	/// </summary>
	public event Action<float[], int>? AudioSamplesRendered;

	/// <summary>Native OPL render rate exposed for diagnostics.</summary>
	public int NativeSampleRate => NativeOplSampleRateConst;

	/// <summary>
	/// Hook fired before each render batch with the number of frames
	/// the mixer is about to request. The engine subscribes to this
	/// to advance PIT timing locked to the audio clock.
	/// </summary>
	public Action<int>? OnBeforeRender { get; set; }

	/// <summary>Builds the synthesizer wired through Spice86's <see cref="AdlibGold"/>
	/// post-processor (Opl3Gold pipeline, identical to <c>Opl3Fm.RenderFrame</c>).</summary>
	public AdgOplSynthesizer() {
		_chip = new Opl3Chip();
		_chip.Reset((uint)NativeOplSampleRateConst);
		_adlibGold = new AdlibGold(NativeOplSampleRateConst);
		_pauseHandler = new NullPauseHandler();
		_mixer = new SoftwareMixer(AudioEngine.CrossPlatform, _pauseHandler);
		HashSet<ChannelFeature> features = new() {
			ChannelFeature.Stereo,
			ChannelFeature.Synthesizer,
		};
		_channel = _mixer.AddChannel(MixerCallback, NativeOplSampleRateConst, "OPL3", features);
		_channel.Enable(false);
		_channel.UserVolume = new Spice86.Audio.Common.AudioFrame(1.5f, 1.5f);
		_channel.AppVolume = new Spice86.Audio.Common.AudioFrame(1.0f, 1.0f);
		Logger.Information("ADG OPL3 synthesizer initialized: mode=Opl3Gold (required), rate={Rate} Hz, AdLibGold filter=ENABLED",
			NativeOplSampleRateConst);
	}

	/// <summary>Starts mixer output (channel enabled).</summary>
	public void Start() {
		_channel.Enable(true);
	}

	/// <summary>Stops mixer output (channel disabled).</summary>
	public void Stop() {
		_channel.Enable(false);
	}

	/// <summary>Sets the master output volume (0..1).</summary>
	public void SetMasterVolume(float volume) {
		float clamped = Math.Clamp(volume, 0.0f, 1.0f);
		_channel.AppVolume = new Spice86.Audio.Common.AudioFrame(clamped, clamped);
	}

	/// <summary>
	/// Writes a register on the OPL3 chip. <paramref name="chip"/> 0
	/// targets bank 0 (registers 0x000..0x0FF); chip 1 targets bank 1
	/// (registers 0x100..0x1FF) — the AdLib Gold dual-bank layout.
	/// </summary>
	public void WriteRegister(int chip, byte register, byte value) {
		if (chip is not (0 or 1)) {
			throw new ArgumentOutOfRangeException(nameof(chip),
				"OPL3 chip selector must be 0 (primary) or 1 (secondary).");
		}
		ushort fullRegister = (ushort)((chip << 8) | register);
		_chip.WriteRegisterBuffered(fullRegister, value);
	}

	/// <summary>Disposes the mixer and pause-handler shells.</summary>
	public void Dispose() {
		if (_disposed) {
			return;
		}
		_disposed = true;
		_channel.Enable(false);
		_adlibGold.Dispose();
		_mixer.Dispose();
		_pauseHandler.Dispose();
	}

	private void MixerCallback(int framesNeeded) {
		OnBeforeRender?.Invoke(framesNeeded);
		int sampleCount = framesNeeded * 2;
		if (_tempBuffer.Length < sampleCount) {
			_tempBuffer = new short[sampleCount];
			_floatBuffer = new float[sampleCount];
			_normalizedBuffer = new float[sampleCount];
		}
		Span<short> shortSpan = _tempBuffer.AsSpan(0, sampleCount);
		Span<float> floatSpan = _floatBuffer.AsSpan(0, sampleCount);
		_chip.GenerateStream(shortSpan);
		_adlibGold.Process(shortSpan, framesNeeded, floatSpan);
		for (int i = 0; i < sampleCount; i++) {
			_normalizedBuffer[i] = _floatBuffer[i] / 32768f;
		}
		_channel.AddSamplesFloat(framesNeeded, floatSpan);
		AudioSamplesRendered?.Invoke(_normalizedBuffer, sampleCount);
	}

	/// <summary>
	/// Minimal <see cref="IPauseHandler"/> that never pauses. The
	/// <see cref="SoftwareMixer"/> only subscribes to the events.
	/// </summary>
	private sealed class NullPauseHandler : IPauseHandler {
		public bool IsPaused => false;
#pragma warning disable CS0067
		public event Action? Pausing;
		public event Action? Paused;
		public event Action? Resumed;
#pragma warning restore CS0067

		public void RequestPause(string? reason = null) {
		}

		public void Resume() {
		}

		public void WaitIfPaused() {
		}

		public void Dispose() {
		}
	}
}