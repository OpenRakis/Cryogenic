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
	private float[] _floatBuffer = new float[4096];
	private float[] _normalizedBuffer = new float[4096];
	private float _userMasterVolume = 1.0f;
	private byte _goldLeftVolume = 0xFF;
	private byte _goldRightVolume = 0xFF;
	private bool _disposed;

	/// <summary>
	/// Called before each render batch with the number of frames to generate.
	/// The engine hooks this to advance PIT timing at the native OPL rate.
	/// </summary>
	public Action<int>? OnBeforeRender;

	/// <summary>
	/// Fired after each render batch with the normalized float sample buffer and sample count.
	/// Consumers use this to drive VU meters or waveform displays.
	/// Buffer is reused on the next render; copy if needed beyond the handler scope.
	/// </summary>
	public event Action<float[], int>? AudioSamplesRendered;



	/// <summary>
	/// Creates the OPL synthesizer backed by Spice86's SoftwareMixer pipeline.
	/// Audio output starts immediately via the mixer's own thread.
	/// </summary>
	public OplSynthesizer() : this(AudioEngine.CrossPlatform) {
	}

	/// <summary>
	/// Creates the OPL synthesizer with the requested audio backend.
	/// Use <see cref="AudioEngine.Dummy"/> for headless validation and CI-safe tracing.
	/// </summary>
	public OplSynthesizer(AudioEngine audioEngine) {
		_chip = new Opl3Chip();
		_chip.Reset((uint)NativeOplSampleRate);
		_adlibGold = new AdlibGold(NativeOplSampleRate);

		_pauseHandler = new NullPauseHandler();
		_mixer = new SoftwareMixer(audioEngine, _pauseHandler);

		HashSet<ChannelFeature> features = new HashSet<ChannelFeature> {
			ChannelFeature.Stereo,
			ChannelFeature.Synthesizer
		};
		_channel = _mixer.AddChannel(MixerCallback, NativeOplSampleRate, "OPL", features);
		_channel.Enable(true);
		_channel.UserVolume = new Spice86.Audio.Common.AudioFrame(1.5f, 1.5f);
		ApplyEffectiveMasterVolume();

		Logger.Information("OPL synthesizer initialized: {NativeRate} Hz via SoftwareMixer pipeline ({AudioEngine}, AdLib Gold stack enabled)",
			NativeOplSampleRate, audioEngine);
	}

	/// <summary>
	/// Writes a value to an OPL register.
	/// Register address is 0x000-0x0FF for bank 0 and 0x100-0x1FF for bank 1.
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
		_userMasterVolume = Math.Clamp(volume, 0.0f, 1.0f);
		ApplyEffectiveMasterVolume();
	}

	/// <summary>
	/// Applies one AdLib Gold control-register write using the same register semantics as Spice86 Opl3Fm.
	/// </summary>
	public void WriteGoldControlRegister(byte register, byte value) {
		switch (register) {
			case 0x04:
				_adlibGold.StereoControlWrite(StereoProcessorControlReg.VolumeLeft, value);
				break;
			case 0x05:
				_adlibGold.StereoControlWrite(StereoProcessorControlReg.VolumeRight, value);
				break;
			case 0x06:
				_adlibGold.StereoControlWrite(StereoProcessorControlReg.Bass, value);
				break;
			case 0x07:
				_adlibGold.StereoControlWrite(StereoProcessorControlReg.Treble, value);
				break;
			case 0x08:
				_adlibGold.StereoControlWrite(StereoProcessorControlReg.SwitchFunctions, value);
				break;
			case 0x09:
				_goldLeftVolume = value;
				ApplyEffectiveMasterVolume();
				break;
			case 0x0A:
				_goldRightVolume = value;
				ApplyEffectiveMasterVolume();
				break;
			case 0x18:
				_adlibGold.SurroundControlWrite(value);
				break;
		}
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
		if (_floatBuffer.Length < sampleCount) {
			_floatBuffer = new float[sampleCount];
			_normalizedBuffer = new float[sampleCount];
		}

		short[] tempBuffer = System.Buffers.ArrayPool<short>.Shared.Rent(sampleCount);
		try {
			_chip.GenerateStream(tempBuffer.AsSpan(0, sampleCount));
			_adlibGold.Process(tempBuffer.AsSpan(0, sampleCount), framesNeeded, _floatBuffer.AsSpan(0, sampleCount));

			for (int i = 0; i < sampleCount; i++) {
				_normalizedBuffer[i] = tempBuffer[i] / 32768f;
				_normalizedBuffer[i] = _floatBuffer[i] / 32768f;
			}

			_channel.AddSamplesFloat(framesNeeded, _floatBuffer.AsSpan(0, sampleCount));
			AudioSamplesRendered?.Invoke(_normalizedBuffer, sampleCount);
		} finally {
			System.Buffers.ArrayPool<short>.Shared.Return(tempBuffer);
		}
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

	private void ApplyEffectiveMasterVolume() {
		float leftVolume = _userMasterVolume * ((_goldLeftVolume & 0x1F) / 31.0f);
		float rightVolume = _userMasterVolume * ((_goldRightVolume & 0x1F) / 31.0f);
		_channel.AppVolume = new Spice86.Audio.Common.AudioFrame(leftVolume, rightVolume);
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