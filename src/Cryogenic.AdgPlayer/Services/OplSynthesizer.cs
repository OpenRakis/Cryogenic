namespace Cryogenic.AdgPlayer.Services;

using NukedOPL3Sharp;

using Serilog;

using Spice86.Audio.Filters;
using Spice86.Core.Emulator.Devices.Sound;
using Spice86.Core.Emulator.Devices.Sound.AdlibGoldOpl;
using Spice86.Core.Emulator.VM;

using System;
using System.Collections.Generic;

/// <summary>
/// OPL synthesizer that uses NukedOPL3Sharp for OPL3 FM synthesis, the Spice86 AdlibGold
/// surround/stereo processor for the Opl3Gold signal path, and Spice86's SoftwareMixer
/// for the audio pipeline (resampling 49716→48000, noise gate, master volume, high-pass
/// filter, compressor, normalization). Mirrors Spice86's Opl3Fm.RenderFrame pattern exactly.
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
	private volatile bool _adlibGoldPostProcessEnabled;
	private float _masterGain = 1.0f;
	private float _goldLeftGain = 1.0f;
	private float _goldRightGain = 1.0f;
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
	/// Creates the OPL synthesizer backed by Spice86's SoftwareMixer and AdlibGold pipeline.
	/// Audio output starts immediately via the mixer's own thread.
	/// </summary>
	public OplSynthesizer() {
		_chip = new Opl3Chip();
		_chip.Reset((uint)NativeOplSampleRate);
		_adlibGold = new AdlibGold(NativeOplSampleRate);
		_adlibGoldPostProcessEnabled = true;

		_pauseHandler = new NullPauseHandler();
		_mixer = new SoftwareMixer(AudioEngine.CrossPlatform, _pauseHandler);

		HashSet<ChannelFeature> features = new HashSet<ChannelFeature> {
			ChannelFeature.Stereo,
			ChannelFeature.Synthesizer
		};
		_channel = _mixer.AddChannel(MixerCallback, NativeOplSampleRate, "OPL", features);
		_channel.Enable(true);
		// Match Spice86 Opl3Fm: Set0dbScalar(1.5f). Use a lower noise-gate threshold
		// for Opl3Gold (−80 dB) so quiet startup audio isn't gated out.
		_channel.UserVolume = new Spice86.Audio.Common.AudioFrame(1.5f, 1.5f);
		UpdateAppVolume();

		Logger.Information("OPL synthesizer initialized: {NativeRate} Hz, AdlibGold post-process {Mode}", NativeOplSampleRate, _adlibGoldPostProcessEnabled ? "enabled" : "disabled");
	}

	/// <summary>
	/// Enables or disables AdLib Gold post-processing (surround/stereo stage).
	/// Disabled by default in standalone mode until control-register parity is wired.
	/// </summary>
	public void SetAdlibGoldPostProcessEnabled(bool enabled) {
		_adlibGoldPostProcessEnabled = enabled;
	}

	/// <summary>
	/// Applies DNADG's packed FM volume byte to the Gold stereo stage.
	/// Mirrors the effective mixer behavior of Opl3Fm's AdLib Gold control writes.
	/// </summary>
	public void ApplyGoldPackedVolume(byte packedVolume) {
		byte leftControl = (byte)(((packedVolume & 0xF0) >> 3) | 0x01);
		byte rightControl = (byte)(((packedVolume & 0x0F) << 1) | 0x01);
		_goldLeftGain = (leftControl & 0x1F) / 31.0f;
		_goldRightGain = (rightControl & 0x1F) / 31.0f;
		UpdateAppVolume();
	}

	/// <summary>
	/// Writes one value to the AdLib Gold surround control processor.
	/// </summary>
	public void WriteGoldSurroundControl(byte value) {
		_adlibGold.SurroundControlWrite(value);
	}

	/// <summary>
	/// Applies DNADG's fixed Gold stereo-processor startup configuration.
	/// Mirrors the 1185 initialization writes used by the real driver.
	/// </summary>
	public void InitializeGoldHardware() {
		_adlibGold.StereoControlWrite(StereoProcessorControlReg.Bass, 0xFB);
		_adlibGold.StereoControlWrite(StereoProcessorControlReg.Treble, 0xF7);
		_adlibGold.StereoControlWrite(StereoProcessorControlReg.VolumeLeft, 0xF7);
		_adlibGold.StereoControlWrite(StereoProcessorControlReg.VolumeRight, 0xF7);
		ApplyGoldPackedVolume(0xFF);
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
		_masterGain = Math.Clamp(volume, 0.0f, 1.0f);
		UpdateAppVolume();
	}

	private void UpdateAppVolume() {
		_channel.AppVolume = new Spice86.Audio.Common.AudioFrame(_masterGain * _goldLeftGain, _masterGain * _goldRightGain);
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

		// Generate raw OPL3 PCM via NukedOPL3Sharp.
		_chip.GenerateStream(_tempBuffer.AsSpan(0, sampleCount));

		if (_adlibGoldPostProcessEnabled) {
			// Apply AdLib Gold surround + stereo post-processing, matching Spice86 Opl3Fm.RenderFrame.
			// Outputs short-scale float values (same amplitude as the raw shorts) ready for AddSamplesFloat.
			_adlibGold.Process(_tempBuffer.AsSpan(0, sampleCount), framesNeeded, _floatBuffer.AsSpan(0, sampleCount));
		} else {
			for (int i = 0; i < sampleCount; i++) {
				_floatBuffer[i] = _tempBuffer[i];
			}
		}

		for (int i = 0; i < sampleCount; i++) {
			_normalizedBuffer[i] = _floatBuffer[i] / 32768f;
		}

		_channel.AddSamplesFloat(framesNeeded, _floatBuffer.AsSpan(0, sampleCount));
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