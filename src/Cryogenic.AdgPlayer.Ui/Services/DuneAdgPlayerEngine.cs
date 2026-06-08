namespace Cryogenic.AdgPlayer.Ui.Services;

using Serilog;

using System;

/// <summary>
/// Standalone ADG / AdLib Gold music player engine.
/// Lineage: ported from the AdpDriverCode.cs driver in the parent Cryogenic project;
/// runs outside the Spice86 emulator using NukedOPL3Sharp for synthesis
/// and Spice86.Audio for playback.
/// </summary>
public sealed partial class DuneAdgPlayerEngine : IDisposable {
	private static readonly ILogger Logger = Log.ForContext<DuneAdgPlayerEngine>();



	/// <summary>
	/// Current playback measure (1-based). Updated each tick.
	/// </summary>
	public int CurrentMeasure => _measure;

	/// <summary>
	/// Total ticks elapsed since playback started.
	/// </summary>
	public long TotalTickCount => _totalTickCount;

	/// <summary>
	/// Total audio samples rendered since playback started.
	/// </summary>
	public long TotalSamplesRendered => _totalSamplesRendered;

	/// <summary>
	/// Current elapsed time in seconds based on rendered samples at native OPL rate.
	/// </summary>
	public double ElapsedSeconds => (double)_totalSamplesRendered / OplSynthesizer.NativeOplSampleRate;

	/// <summary>
	/// Current driver volume (packed nibble byte).
	/// </summary>
	public byte CurrentDriverVolume => _currentVolume;

	/// <summary>
	/// Target driver volume (packed nibble byte).
	/// </summary>
	public byte TargetDriverVolume => _targetVolume;

	/// <summary>
	/// Master driver volume (packed nibble byte).
	/// </summary>
	public byte MasterDriverVolume => _masterVolume;

	/// <summary>
	/// Current output gain (0.0–1.0).
	/// </summary>
	public float OutputGain => _outputGain;

	/// <summary>
	/// Current OPL volume gain scalar.
	/// </summary>
	public float OplVolumeGain => _oplVolumeGain;

	/// <summary>
	/// Current subdivision within a measure (counts down from 0x60).
	/// </summary>
	public byte CurrentSubdivision => _subdivision;

	/// <summary>
	/// Native OPL sample rate (49716 Hz). Output is resampled to 48000 Hz by the mixer.
	/// </summary>
	public int SampleRate => OplSynthesizer.NativeOplSampleRate;

	/// <summary>
	/// PIT reload value.
	/// </summary>
	public int PitReloadValue => _pitReloadValue;

	/// <summary>
	/// Tick rate in Hz (PIT clock / reload value).
	/// </summary>
	public double TickRateHz => (double)PitInputClock / _pitReloadValue;

	/// <summary>
	/// Gets parsed song header info. Only valid after LoadSong.
	/// </summary>
	public SongHeaderInfo? HeaderInfo { get; private set; }

	/// <summary>
	/// True when the engine is actively generating audio.
	/// </summary>
	public bool IsPlaying => _playing && !_paused;

	/// <summary>
	/// Sets the output gain applied to all rendered samples.
	/// Range is 0.0 (silence) to 1.0 (full volume).
	/// </summary>
	public void SetOutputGain(float gain) {
		_outputGain = Math.Clamp(gain, 0.0f, 1.0f);
		_opl.SetMasterVolume(_outputGain);
	}

	/// <summary>
	/// Sets the OPL volume gain scalar (mirrors Spice86 Opl3Fm Set0dbScalar).
	/// Default is 1.5f matching Spice86 Opl3Fm. Applied via SoftwareMixer channel volume.
	/// </summary>
	public void SetOplVolumeGain(float gain) {
		_oplVolumeGain = Math.Clamp(gain, 0.0f, 5.0f);
		_opl.SetOplVolumeGain(_oplVolumeGain);
	}

	/// <summary>
	/// True when playback state is preserved but audio generation is paused.
	/// </summary>
	public bool IsPaused => _playing && _paused;

	/// <summary>
	/// Creates the engine with a custom OPL synthesizer (for testing).
	/// </summary>
	public DuneAdgPlayerEngine(OplSynthesizer opl) {
		_opl = opl;
		_samplesPerTickThreshold = (long)OplSynthesizer.NativeOplSampleRate * _pitReloadValue;
		_opl.OnBeforeRender = AdvanceSamples;
		_opl.AudioSamplesRendered += (buf, count) => AudioSamplesRendered?.Invoke(buf, count);
		Logger.Information("ADG engine created: {SampleRate} Hz native OPL, PIT reload 0x{PitReload:X4}",
			OplSynthesizer.NativeOplSampleRate, _pitReloadValue);
	}

	/// <summary>
	/// Creates the engine with default audio pipeline (SoftwareMixer at 49716 Hz native OPL rate).
	/// </summary>
	public DuneAdgPlayerEngine() {
		_opl = new OplSynthesizer();
		_samplesPerTickThreshold = (long)OplSynthesizer.NativeOplSampleRate * _pitReloadValue;
		_opl.AudioSamplesRendered += (buf, count) => AudioSamplesRendered?.Invoke(buf, count);
		_opl.OnBeforeRender = AdvanceSamples;
		Logger.Information("ADG engine created (default): {SampleRate} Hz native OPL via SoftwareMixer", OplSynthesizer.NativeOplSampleRate);
	}

	// --- PIT Timing ---

	/// <summary>
	/// Advances the PIT accumulator by the given number of audio frames.
	/// Called from the OPL synthesizer's OnBeforeRender hook on the render thread.
	/// </summary>
	private void AdvanceSamples(int frameCount) {
		if (!_playing || _paused) {
			return;
		}
		lock (_lock) {
			try {
				_totalSamplesRendered += frameCount;
				_sampleAccumulator += (long)frameCount * PitInputClock;
				while (_sampleAccumulator >= _samplesPerTickThreshold) {
					_sampleAccumulator -= _samplesPerTickThreshold;
					_totalTickCount++;
					TickInternal();
				}
			} catch (Exception ex) {
				Logger.Error(ex, "Exception in ADG tick; stopping playback");
				_playing = false;
			}
		}
	}

	/// <summary>
	/// Single driver tick. Mirrors AdpTickHandler_0473.
	/// Decrements the prescaler, fires ProcessTick on overflow,
	/// rotates the fade pattern, and calls FadeStep on carry.
	/// </summary>
	private void TickInternal() {
		if ((_statusFlags & 0x80) == 0) {
			return;
		}

		byte prescaler = Hi8(_accumulator);
		prescaler--;
		_accumulator = Make16(Lo8(_accumulator), prescaler);

		if ((prescaler & 0x80) != 0) {
			ProcessTick();
		}

		ushort fadePattern = _fadeBitPattern;
		bool carry = (fadePattern & 0x8000) != 0;
		fadePattern = (ushort)((fadePattern << 1) | (carry ? 1 : 0));
		_fadeBitPattern = fadePattern;

		if (carry) {
			FadeStep();
		}
	}

	// --- Volume Computation ---

	/// <summary>
	/// Computes a packed volume nibble byte from the raw two-component volume
	/// in (al, ah). Mirrors AdpResetInternalBody_030B.
	/// </summary>
	private static byte ComputeVolumeNibbles(byte al, byte ah) {
		al = (byte)(al >> 3);
		byte dl = al;
		byte dh = ah;
		byte bl = 0x78;
		byte bh = 0xF0;

		if (ah > bl) {
			ah = bl;
		}
		al = 0;
		ushort axDiv = Make16(al, ah);
		al = (byte)(axDiv / bh);
		ah = (byte)(axDiv % bh);
		ushort mul1 = (ushort)(al * dl);
		al = Lo8(mul1);
		ah = Hi8(mul1);

		byte temp = ah;
		ah = dh;
		dh = temp;

		ah = (byte)(ah - bh);
		ah = (byte)(0 - ah);
		if (ah > bl) {
			ah = bl;
		}

		al = 0;
		axDiv = Make16(al, ah);
		al = (byte)(axDiv / bh);
		ah = (byte)(axDiv % bh);
		ushort axOut = (ushort)(al * dl);
		axOut = (ushort)(axOut >> 4);

		ah = dh;
		axOut = (ushort)((axOut & 0x00F0) | ((ah & 0x0F) << 8));
		return (byte)((axOut & 0xF0) | (ah & 0x0F));
	}

	// --- Public API ---

	/// <summary>
	/// Sets the master volume. Input is the raw AX value (AH=high, AL=low).
	/// Mirrors AdpSetVolume_0348.
	/// </summary>
	public void SetVolume(byte low, byte high) {
		lock (_lock) {
			byte packed = ComputeVolumeNibbles(low, high);
			_masterVolume = packed;
			_targetVolume = packed;
			_fadeBitPattern = 0xFFFF;
		}
	}

	/// <summary>
	/// Sets the fade dynamics. Mirrors AdpSetDynamicsCurve_035B.
	/// </summary>
	public void SetDynamics(ushort fadeSpeed, byte volumeLow, byte volumeHigh) {
		lock (_lock) {
			byte packed = ComputeVolumeNibbles(volumeLow, volumeHigh);
			_targetVolume = packed;

			ushort fade;
			if (fadeSpeed < 0x0060) {
				fade = 0xFFFF;
			} else if (fadeSpeed < 0x00C0) {
				fade = 0xAAAA;
			} else if (fadeSpeed < 0x0180) {
				fade = 0x8888;
			} else if (fadeSpeed < 0x0300) {
				fade = 0x8080;
			} else {
				fade = 0x8000;
			}
			_fadeBitPattern = fade;

			if ((_statusFlags & 0x80) != 0) {
				_statusFlags = (byte)(_statusFlags | 0x40);
			}
		}
	}

	/// <summary>
	/// Opens and starts playing the loaded song. Mirrors AdpOpen_03B2.
	/// </summary>
	public void Play() {
		lock (_lock) {
			if (_songData.Length == 0) {
				Logger.Warning("No song loaded");
				return;
			}

			if (_playing && _paused) {
				_paused = false;
				_opl.Resume();
				Logger.Information("Playback resumed");
				return;
			}

			if (_playing) {
				StopInternal();
			}

			PreparePlaybackState();

			_playing = true;
			_paused = false;
			_opl.Resume();
			Logger.Information("Playback started");
		}
	}

	/// <summary>
	/// Pauses playback while preserving the current driver state.
	/// </summary>
	public void Pause() {
		lock (_lock) {
			if (!_playing || _paused) {
				return;
			}

			_paused = true;
			_opl.Pause();
			Logger.Information("Playback paused");
		}
	}

	/// <summary>
	/// Resumes playback after a pause.
	/// </summary>
	public void Resume() {
		lock (_lock) {
			if (!_playing || !_paused) {
				return;
			}

			_paused = false;
			_opl.Resume();
			Logger.Information("Playback resumed");
		}
	}

	/// <summary>
	/// Stops playback and silences all channels.
	/// </summary>
	public void Stop() {
		lock (_lock) {
			StopInternal();
		}
	}

	private void StopInternal() {
		_playing = false;
		_paused = false;
		AllNotesOff();
		_statusFlags = 0;
		_opl.Pause();
		Logger.Information("Playback stopped");
	}

	/// <summary>
	/// Prepares the DNADG runtime state for a fresh playback or headless trace run.
	/// Mirrors the observed open-song path in AdgOpenSong_564B_0626_056AD6.
	/// </summary>
	private void PreparePlaybackState() {
		InitOplChip();
		InitializeGoldHardware();
		SilenceGoldChannels();
		InitializeGoldSongControls();
		BuildChannelTable();

		_currentVolume = _masterVolume;
		ApplyMasterVolumeToGold();
		_targetVolume = _masterVolume;
		_accumulator = 0;
		_repeatCounter = 0;
		_sampleAccumulator = 0;
		_tickFlag = 0;
		_totalTickCount = 0;
		_totalSamplesRendered = 0;

		ProcessTick();
		_statusFlags = 0x80;
	}

	public void Dispose() {
		if (_disposed) {
			return;
		}
		_disposed = true;
		_playing = false;
		_paused = false;
		_opl.Dispose();
		Logger.Information("ADG engine disposed");
	}
}