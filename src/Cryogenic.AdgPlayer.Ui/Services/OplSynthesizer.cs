namespace Cryogenic.AdgPlayer.Ui.Services;

using NukedOPL3Sharp;

using Serilog;

using Spice86.Audio.Filters;
using Spice86.Core.Emulator.Devices.Sound;
using Spice86.Core.Emulator.Devices.Sound.AdlibGoldOpl;
using Spice86.Core.Emulator.VM;

using System;
using System.Collections.Generic;

/// <summary>
/// OPL synthesizer that uses NukedOPL3Sharp for synthesis and Spice86's
/// SoftwareMixer for the audio pipeline (resampling 49716→48000, noise gate,
/// master volume, high-pass filter, compressor, normalization).
/// This produces identical audio quality to the Spice86 emulator.
/// </summary>
public sealed class OplSynthesizer : IDisposable {
	private static readonly ILogger Logger = Log.ForContext<OplSynthesizer>();

	/// <summary>
	/// Native OPL3 sample rate used by NukedOPL3Sharp.
	/// The SoftwareMixer resamples from this rate to 48000 Hz output.
	/// </summary>
	public const int NativeOplSampleRate = 49716;

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
	/// Called before each render batch with the number of frames to generate.
	/// The engine hooks this to advance PIT timing at the native OPL rate.
	/// </summary>
	public Action<int>? OnBeforeRender;

	/// <summary>
	/// Called after each render batch with the interleaved stereo float buffer
	/// and the total sample count (frames × 2). Samples are at int16 amplitude.
	/// </summary>
	public event Action<float[], int>? AudioSamplesRendered;

	/// <summary>
	/// Creates the OPL synthesizer backed by Spice86's SoftwareMixer pipeline.
	/// Audio output starts immediately via the mixer's own thread.
	/// </summary>
	public OplSynthesizer() {
		_chip = new Opl3Chip();
		_chip.Reset((uint)NativeOplSampleRate);

		// AdLib Gold surround+stereo post-processor: required for Opl3Gold mode.
		// Surround (Ym7128B) adds wet signal to dry at 1.8× gain; default state is
		// near-silence wet — dry OPL signal always passes through unaffected.
		// StereoProcessor defaults to pass-through after Reset().
		_adlibGold = new AdlibGold(NativeOplSampleRate);

		_pauseHandler = new NullPauseHandler();
		_mixer = new SoftwareMixer(AudioEngine.CrossPlatform, _pauseHandler);

		HashSet<ChannelFeature> features = new HashSet<ChannelFeature> {
			ChannelFeature.Stereo,
			ChannelFeature.Synthesizer
		};
		_channel = _mixer.AddChannel(MixerCallback, NativeOplSampleRate, "OPL", features);
		_channel.Enable(true);
		_channel.UserVolume = new Spice86.Audio.Common.AudioFrame(1.5f, 1.5f);
		_channel.AppVolume = new Spice86.Audio.Common.AudioFrame(1.0f, 1.0f);

		Logger.Information("OPL synthesizer initialized: mode=Opl3Gold (required), native rate={Rate} Hz, AdLibGold=ENABLED", NativeOplSampleRate);
	}

	/// <summary>
	/// Writes a value to an OPL register (port 0x388/0x389 equivalent).
	/// Register address is 0x000–0x0FF for OPL2 bank 0.
	/// </summary>
	public void WriteRegister(ushort register, byte value) {
		// Match Spice86 Opl3Fm timing path: buffered register writes.
		_chip.WriteRegisterBuffered(register, value);
	}

	/// <summary>
	/// Resets the OPL chip to silence at the native sample rate.
	/// </summary>
	public void Reset() {
		_chip.Reset((uint)NativeOplSampleRate);
	}

	/// <summary>
	/// Sets the OPL driver volume gain via the mixer channel's UserVolume.
	/// Default is 1.5 matching Spice86's Opl3Fm Set0dbScalar.
	/// </summary>
	public void SetOplVolumeGain(float gain) {
		_channel.UserVolume = new Spice86.Audio.Common.AudioFrame(gain, gain);
	}

	/// <summary>
	/// Sets the master volume via the mixer channel's AppVolume.
	/// Range 0.0 (silence) to 1.0 (full).
	/// </summary>
	public void SetMasterVolume(float volume) {
		float clamped = Math.Clamp(volume, 0.0f, 1.0f);
		_channel.AppVolume = new Spice86.Audio.Common.AudioFrame(clamped, clamped);
	}

	/// <summary>
	/// Pauses audio output from the mixer.
	/// </summary>
	public void Pause() {
		_channel.Enable(false);
	}

	/// <summary>
	/// Resumes audio output from the mixer.
	/// </summary>
	public void Resume() {
		_channel.Enable(true);
	}

	/// <summary>
	/// Called by the SoftwareMixer thread when it needs more audio frames.
	/// Fires OnBeforeRender (for PIT tick advancement), renders OPL samples,
	/// and submits them to the mixer channel.
	/// </summary>
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

		// AdLib Gold surround+stereo chain — exact pipeline of Spice86 Opl3Fm.RenderFrame
		// under --OplMode Opl3Gold. Dry OPL signal is preserved; wet surround is added
		// at 1.8× before the stereo processor (pass-through at defaults).
		_adlibGold.Process(shortSpan, framesNeeded, floatSpan);

		for (int i = 0; i < sampleCount; i++) {
			_normalizedBuffer[i] = _floatBuffer[i] / 32768f;
		}

		_channel.AddSamplesFloat(framesNeeded, floatSpan);
		AudioSamplesRendered?.Invoke(_normalizedBuffer, sampleCount);
	}

	public void Dispose() {
		if (_disposed) {
			return;
		}
		_disposed = true;
		_adlibGold.Dispose();
		_mixer.Dispose();
		_pauseHandler.Dispose();
	}

	/// <summary>
	/// Minimal IPauseHandler stub for standalone use.
	/// The SoftwareMixer only subscribes to Pausing/Resumed events.
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