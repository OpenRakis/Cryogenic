namespace Cryogenic.AdgPlayer.Services;

using Serilog;

using System;

/// <summary>
/// Standalone ADG player scaffold.
/// This project currently forks the AdpPlayer engine shape so the verified DNADG
/// runtime behavior can be ported into a dedicated application surface next.
/// </summary>
public sealed partial class DuneAdgPlayerEngine : IDisposable {
	private static readonly ILogger Logger = Log.ForContext<DuneAdgPlayerEngine>();

	// --- Audio pipeline ---
	private readonly OplSynthesizer _opl;
	private volatile bool _disposed;
	private volatile bool _playing;
	private volatile bool _paused;
	private volatile float _outputGain = 1.0f;
	private volatile float _oplVolumeGain = 1.5f;
	private readonly object _lock = new();
	private long _totalTickCount;
	private long _totalSamplesRendered;

	// --- PIT timing ---
	private const int PitInputClock = 1193182;
	private readonly int _pitReloadValue = 0x1745;
	private readonly long _samplesPerTickThreshold;
	private long _sampleAccumulator;

	// --- Song data ---
	private byte[] _songData = Array.Empty<byte>();
	private int _dataBase;
	private ushort _eventBase;

	// --- Global driver state ---
	private byte _statusFlags;
	private ushort _measure;
	private byte _subdivision;
	private byte _currentVolume = 0xFF;
	private byte _targetVolume = 0xFF;
	private byte _masterVolume = 0xFF;
	private ushort _fadeBitPattern;

	// --- Per-channel state (18 OPL3 Gold channels) ---
	private const int ChannelCount = 18;
	private readonly ushort[] _channelWait = new ushort[ChannelCount];
	private readonly ushort[] _channelEventPointer = new ushort[ChannelCount];
	private readonly ushort[] _channelStartOffset = new ushort[ChannelCount];
	private readonly byte[] _channelInstrument = new byte[ChannelCount];
	private readonly byte[] _channelNote = new byte[ChannelCount];
	private readonly ushort[] _channelPitchMode = new ushort[ChannelCount];
	private readonly byte[] _channelPitchTranspose = new byte[ChannelCount];
	private readonly byte[] _channelPitchBendCounter = new byte[ChannelCount];
	private readonly byte[] _channelPitchBendCounterInit = new byte[ChannelCount];
	private readonly byte[] _channelPitchBendSpeed = new byte[ChannelCount];
	private readonly byte[] _channelPitchAccumulator = new byte[ChannelCount];
	private readonly ushort[] _channelTlShaping = new ushort[ChannelCount];
	private readonly ushort[] _channelEnvShaping = new ushort[ChannelCount];
	private readonly ushort[] _channelCurrentOperatorLevel = new ushort[ChannelCount];
	private readonly ushort[] _channelPatch4EnvShaping = new ushort[ChannelCount];
	private readonly ushort[] _channelPatch4TlShaping = new ushort[ChannelCount];
	private readonly ushort[] _channelPatch4VolModShaping = new ushort[ChannelCount];
	private readonly ushort[] _channelPatch4CurrentOperatorLevel = new ushort[ChannelCount];
	private readonly ushort[] _channelConnShaping = new ushort[ChannelCount];
	private readonly ushort[] _channelVolModShaping = new ushort[ChannelCount];
	private readonly ushort[] _channelConnModulation = new ushort[ChannelCount];
	private readonly byte[] _channelConnectionCurrent = new byte[ChannelCount];
	private readonly byte[] _channelPatchType = new byte[ChannelCount];
	private readonly ushort[] _channelStateScratch = new ushort[ChannelCount];
	private readonly ushort[] _channelFrequencyWord = new ushort[ChannelCount];

	// --- Channel routing (18 logical → OPL3 Gold physical) ---
	private readonly byte[] _channelRoutingTable = new byte[ChannelCount];
	private readonly byte[] _channelRouteShadow = new byte[ChannelCount];
	private readonly byte[] _channelPrimaryRoute = new byte[ChannelCount];
	private readonly byte[] _channelSecondaryRoute = new byte[ChannelCount];

	// --- Loop snapshot (0x24 words = 36 entries, enough for 18 channels × 2) ---
	private readonly ushort[] _snapshotWait = new ushort[ChannelCount];
	private readonly ushort[] _snapshotPointer = new ushort[ChannelCount];

	// --- Global ADG state ---
	private ushort _fadeScratch;
	private ushort _fadeScratch2;
	private byte _surroundMask = 0x00;
	private byte _tickEnabled;
	private byte _loopCounter;
	/// <summary>16-bit tempo accumulator. Hi8 is decremented every PIT tick; ProcessTick
	/// fires when Hi8 reaches 0, then reloads Hi8 by adding tempoWord.
	/// Mirrors AdgTempoAccumulatorOffset (0x0126).</summary>
	private ushort _tempoAccumulator;

	// --- Static lookup tables (from DNADG driver binary, verified against runtime) ---

	/// <summary>
	/// Runtime channel-route seed table from DNADG memory image at 564B:017F.
	/// Captured from dump memory bytes at linear 0x5662F.
	/// </summary>
	private static readonly byte[] InitialChannelRoutes = {
		0x08, 0x07, 0x07, 0x06, 0x88, 0x88, 0x87, 0x86, 0x82,
		0x80, 0x81, 0x82, 0x83, 0x84, 0x85, 0x86, 0x87, 0x88
	};

	/// <summary>
	/// Runtime route-shadow seed table from DNADG memory image at 564B:0191.
	/// Captured from dump memory bytes at linear 0x56641.
	/// </summary>
	private static readonly byte[] InitialRouteShadows = {
		0x0B, 0x0A, 0x0A, 0x09, 0x8B, 0x8B, 0x8A, 0x89, 0x85,
		0x80, 0x81, 0x82, 0x83, 0x84, 0x85, 0x86, 0x87, 0x88
	};

	/// <summary>
	/// Runtime primary-operator route seed table from DNADG 564B:01A3.
	/// Captured from dump memory bytes at linear 0x56653.
	/// </summary>
	private static readonly byte[] InitialPrimaryRoutes = {
		0x12, 0x11, 0x11, 0x10, 0x92, 0x92, 0x91, 0x90, 0x82,
		0x80, 0x81, 0x82, 0x88, 0x89, 0x8A, 0x90, 0x91, 0x92
	};

	/// <summary>
	/// Runtime secondary-operator route seed table from DNADG 564B:01B5.
	/// Captured from dump memory bytes at linear 0x56665.
	/// </summary>
	private static readonly byte[] InitialSecondaryRoutes = {
		0x15, 0x14, 0x14, 0x13, 0x95, 0x95, 0x94, 0x93, 0x85,
		0x93, 0x84, 0x85, 0x8B, 0x8C, 0x8D, 0x93, 0x94, 0x95
	};

	/// <summary>OPL3 F-number lookup table for one octave (C through B), 12 entries.
	/// Matches values in DNADG driver at AdgFrequencyLookupTableOffset = 0x0142.</summary>
	private static readonly ushort[] FrequencyLookupTable = {
		0x0157, 0x016C, 0x0181, 0x0198, 0x01B1, 0x01CB,
		0x01E6, 0x0203, 0x0222, 0x0243, 0x0266, 0x028A
	};

	/// <summary>Non-portamento pitch bend fractions (13 entries, indexed 0-12).
	/// From DNADG driver at AdgPitchBendFractionsTableOffset = 0x01C7.</summary>
	private static readonly byte[] PitchBendFractions = {
		0x13, 0x15, 0x15, 0x17, 0x19, 0x1A,
		0x1B, 0x1D, 0x1F, 0x21, 0x23, 0x24, 0x25
	};

	/// <summary>Portamento pitch bend fractions (two groups of 5: semitone 0-5 and 6-11).
	/// From DNADG driver at AdgPortamentoFractionsTableOffset = 0x01D4.</summary>
	private static readonly byte[] PortamentoFractions = {
		0x00, 0x05, 0x0A, 0x0F, 0x14,
		0x00, 0x06, 0x0C, 0x12, 0x18
	};

	/// <summary>
	/// Fired when the song has finished playing (all channels ended and tickFlag reached 0).
	/// </summary>
	public event Action? SongFinished;

	/// <summary>
	/// Fired when audio samples have been rendered, for waveform display.
	/// </summary>
	public event Action<float[], int>? AudioSamplesRendered;

	/// <summary>
	/// Fired when an OPL register write occurs. Args: (register, value, tickCount).
	/// </summary>
	public event Action<ushort, byte, long>? OplRegisterWritten;

	/// <summary>
	/// Fired when a channel event is dispatched. Args: (channel, eventName, detail, tickCount).
	/// </summary>
	public event Action<int, string, string, long>? ChannelEventDispatched;

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
	/// Gets a snapshot of per-channel state for UI display.
	/// </summary>
	public ChannelSnapshot[] GetChannelSnapshots() {
		ChannelSnapshot[] snapshots = new ChannelSnapshot[ChannelCount];
		lock (_lock) {
			for (int i = 0; i < ChannelCount; i++) {
				snapshots[i] = new ChannelSnapshot {
					Channel = i,
					Wait = _channelWait[i],
					Instrument = _channelInstrument[i],
					Note = _channelNote[i],
					Transpose = _channelPitchTranspose[i],
					Frequency = _channelFrequencyWord[i],
					PitchBendFlag = _channelPitchMode[i],
					IsActive = _channelEventPointer[i] != 0 && _channelWait[i] != 0xFFFF
				};
			}
		}
		return snapshots;
	}

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
	/// Enables or disables AdLib Gold surround/stereo post-processing in standalone playback.
	/// Kept explicit so routing/dispatch parity can be validated in dry mode first.
	/// </summary>
	public void SetAdlibGoldPostProcessEnabled(bool enabled) {
		_opl.SetAdlibGoldPostProcessEnabled(enabled);
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
		Logger.Information("ADG engine scaffold created: {SampleRate} Hz native OPL, PIT reload 0x{PitReload:X4}",
			OplSynthesizer.NativeOplSampleRate, _pitReloadValue);
	}

	/// <summary>
	/// Creates the engine with default audio pipeline (SoftwareMixer at 49716 Hz native OPL rate).
	/// </summary>
	public DuneAdgPlayerEngine() {
		_opl = new OplSynthesizer();
		_samplesPerTickThreshold = (long)OplSynthesizer.NativeOplSampleRate * _pitReloadValue;
		_opl.OnBeforeRender = AdvanceSamples;
		_opl.AudioSamplesRendered += (samples, count) => AudioSamplesRendered?.Invoke(samples, count);
		Logger.Information("ADG engine scaffold created (default): {SampleRate} Hz native OPL via SoftwareMixer", OplSynthesizer.NativeOplSampleRate);
	}

	// --- Helpers ---

	private static byte Lo8(ushort value) {
		return (byte)(value & 0xFF);
	}

	private static byte Hi8(ushort value) {
		return (byte)(value >> 8);
	}

	private static ushort Make16(byte lo, byte hi) {
		return (ushort)(lo | (hi << 8));
	}

	private static ushort RotateRight16(ushort value, int count) {
		int n = count & 0x0F;
		if (n == 0) {
			return value;
		}
		return (ushort)((value >> n) | (value << (16 - n)));
	}

	private byte SongByte(int offset) {
		return _songData[offset];
	}

	private byte SongByte16(ushort offset) {
		return _songData[offset];
	}

	private ushort SongWord(int offset) {
		return (ushort)(_songData[offset] | (_songData[offset + 1] << 8));
	}

	private ushort SongWord16(ushort offset) {
		byte lo = SongByte16(offset);
		byte hi = SongByte16((ushort)(offset + 1));
		return Make16(lo, hi);
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
			_totalSamplesRendered += frameCount;
			_sampleAccumulator += (long)frameCount * PitInputClock;
			while (_sampleAccumulator >= _samplesPerTickThreshold) {
				_sampleAccumulator -= _samplesPerTickThreshold;
				_totalTickCount++;
				TickInternal();
			}
		}
	}

	/// <summary>
	/// Advances the engine by a fixed number of raw PIT ticks without requiring audio hardware.
	/// Each call to <see cref="TickInternal"/> corresponds to one PIT interrupt (at the configured
	/// PIT reload rate). Use this for headless inspection and MCP-driven testing.
	/// Has no effect when the engine is not in the playing state.
	/// </summary>
	public void AdvanceTicks(int tickCount) {
		if (!_playing || _paused) {
			return;
		}
		lock (_lock) {
			for (int i = 0; i < tickCount; i++) {
				_totalTickCount++;
				TickInternal();
			}
		}
	}

	/// <summary>
	/// Single driver tick. Mirrors AdgTick_564B_06F6_056BA6.
	/// Decrements Hi8 of _tempoAccumulator (the tick divider); calls ProcessTick only when
	/// the divider reaches 0. ProcessTick reloads Hi8 by adding tempoWord to _tempoAccumulator.
	/// Rotates fade pattern and calls FadeStep on carry-out.
	/// </summary>
	private void TickInternal() {
		if ((_statusFlags & 0x80) == 0) {
			return;
		}

		// ADG tick divider: Hi8 of _tempoAccumulator is decremented every PIT interrupt.
		// ProcessTick fires only when the divider reaches 0, matching the real driver.
		byte tickDivider = Hi8(_tempoAccumulator);
		tickDivider--;
		_tempoAccumulator = Make16(Lo8(_tempoAccumulator), tickDivider);

		if (tickDivider == 0) {
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

	/// <summary>
	/// Computes a packed ADG volume nibble byte from (al=low, ah=high) components.
	/// Faithfully ports AdgComputeScaledVolumeFromAx from 564B:056E.
	/// Returns Lo8(AX) as the packed volume byte stored to master/dynamics registers.
	/// </summary>
	private static byte ComputeAdgVolume(byte al, byte ah) {
		al = (byte)(al >> 1);
		al = (byte)(al >> 1);
		al = (byte)(al >> 1);
		byte dl = al;
		byte dh = ah;
		byte bl = 0x78;
		byte bh = 0xF0;

		if (ah > bl) {
			ah = bl;
		}

		ushort axDiv = Make16(0, ah);
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

		axDiv = Make16(0, ah);
		al = (byte)(axDiv / bh);
		ah = (byte)(axDiv % bh);

		ushort axOut = (ushort)(al * dl);
		axOut = (ushort)(axOut >> 1);
		axOut = (ushort)(axOut >> 1);
		axOut = (ushort)(axOut >> 1);
		axOut = (ushort)(axOut >> 1);

		ah = dh;
		axOut = (ushort)(axOut & 0x0FF0);
		return Lo8((ushort)(axOut | ah));
	}

	// --- Public API ---

	/// <summary>
	/// Loads a song from file, applying HSQ decompression if detected.
	/// </summary>
	public void LoadSong(byte[] fileData) {
		bool wasCompressed = false;
		byte[]? decompressed = TryDecompressHsq(fileData);
		byte[] data;
		if (decompressed != null) {
			data = decompressed;
			wasCompressed = true;
		} else {
			data = fileData;
		}
		lock (_lock) {
			bool wasPlaying = _playing;
			if (wasPlaying) {
				StopInternal();
			}

			_songData = data;
			_dataBase = 2;
			_eventBase = SongWord(0);

			HeaderInfo = ParseSongHeader(data, _dataBase, _eventBase, wasCompressed);

			Logger.Information("Song loaded: {Length} bytes, dataBase={DataBase}, eventBase=0x{EventBase:X4}",
				_songData.Length, _dataBase, _eventBase);
		}
	}

	/// <summary>
	/// Sets the master volume. Input is the raw AX value (AH=high, AL=low).
	/// Mirrors AdpSetVolume_0348.
	/// </summary>
	public void SetVolume(byte low, byte high) {
		lock (_lock) {
			byte packed = ComputeAdgVolume(low, high);
			_masterVolume = packed;
			_targetVolume = packed;
			_currentVolume = packed;
			_fadeBitPattern = 0xFFFF;
			_opl.ApplyGoldPackedVolume(packed);
		}
	}

	/// <summary>
	/// Sets the fade dynamics. Mirrors AdpSetDynamicsCurve_035B.
	/// </summary>
	public void SetDynamics(ushort fadeSpeed, byte volumeLow, byte volumeHigh) {
		lock (_lock) {
			byte packed = ComputeAdgVolume(volumeLow, volumeHigh);
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
		// Determine OPL actions outside the lock to avoid ABBA deadlock:
		// mixer thread holds mixer lock -> calls AdvanceSamples -> waits for _lock;
		// UI thread holds _lock -> calls _opl.Resume/Pause -> waits for mixer lock.
		bool shouldPauseFirst = false;
		bool shouldResume = false;

		lock (_lock) {
			if (_songData.Length == 0) {
				Logger.Warning("No song loaded");
				return;
			}

			if (_playing && _paused) {
				_paused = false;
				shouldResume = true;
				Logger.Information("Playback resumed");
			} else {
				if (_playing) {
					_playing = false;
					_paused = false;
					SilenceAllChannels();
					_statusFlags = 0;
					shouldPauseFirst = true;
				}

				InitOplChip();
				InitializeRoutingTables();
				UpdateGoldSurround();
				BuildChannelTable();

				_tempoAccumulator = 0;
				_currentVolume = _masterVolume;
				_targetVolume = _masterVolume;
				_opl.ApplyGoldPackedVolume(_currentVolume);
				_loopCounter = 0;
				_tickEnabled = 1;
				_fadeScratch = 0;
				_fadeScratch2 = 0;
				_surroundMask = 0xFF;
				_totalTickCount = 0;
				_totalSamplesRendered = 0;

				ProcessTick();
				_statusFlags = 0x80;

				_playing = true;
				_paused = false;
				shouldResume = true;
				Logger.Information("Playback started");
			}
		}

		if (shouldPauseFirst) {
			_opl.Pause();
		}
		if (shouldResume) {
			_opl.Resume();
		}
	}

	/// <summary>
	/// Pauses playback while preserving the current driver state.
	/// </summary>
	public void Pause() {
		bool shouldPause = false;
		lock (_lock) {
			if (!_playing || _paused) {
				return;
			}

			_paused = true;
			shouldPause = true;
			Logger.Information("Playback paused");
		}
		if (shouldPause) {
			_opl.Pause();
		}
	}

	/// <summary>
	/// Resumes playback after a pause.
	/// </summary>
	public void Resume() {
		bool shouldResume = false;
		lock (_lock) {
			if (!_playing || !_paused) {
				return;
			}

			_paused = false;
			shouldResume = true;
			Logger.Information("Playback resumed");
		}
		if (shouldResume) {
			_opl.Resume();
		}
	}

	/// <summary>
	/// Stops playback and silences all channels.
	/// </summary>
	public void Stop() {
		lock (_lock) {
			StopInternal();
		}
		_opl.Pause();
	}

	private void StopInternal() {
		_playing = false;
		_paused = false;
		SilenceAllChannels();
		_statusFlags = 0;
		Logger.Information("Playback stopped");
	}

	public void Dispose() {
		if (_disposed) {
			return;
		}
		_disposed = true;
		_playing = false;
		_paused = false;
		_opl.Dispose();
		Logger.Information("ADG engine scaffold disposed");
	}

	/// <summary>
	/// Parses song header metadata for UI display.
	/// </summary>
	private SongHeaderInfo ParseSongHeader(byte[] data, int dataBase, int eventBase, bool wasCompressed) {
		int channelCount = 18;
		int safeEventBase = eventBase;
		if (safeEventBase < 0 || safeEventBase > data.Length) {
			safeEventBase = data.Length;
		}

		SongHeaderInfo info = new SongHeaderInfo {
			RawFileSize = data.Length,
			WasHsqCompressed = wasCompressed,
			DataBase = dataBase,
			EventBase = eventBase,
			InstrumentCount = safeEventBase > dataBase + 0x32 ? (data.Length - safeEventBase) / 0x28 : 0
		};

		if (data.Length >= dataBase + 0x32) {
			info.Tempo = SongWord(dataBase + 0x30);
			info.LoopStartMeasure = SongWord(dataBase + 0x2A);
			info.LoopEndMeasure = SongWord(dataBase + 0x2C);
			info.LoopCount = SongWord(dataBase + 0x2E);

			int channelsToRead = Math.Min(channelCount, info.ChannelOffsets.Length);
			for (int i = 0; i < channelsToRead; i++) {
				int offset = dataBase + i * 2;
				if (offset + 1 >= data.Length) {
					break;
				}
				ushort relative = SongWord(offset);
				info.ChannelOffsets[i] = relative;
				info.ChannelActive[i] = relative != 0;
			}
		}

		int activeChannels = 0;
		for (int i = 0; i < info.ChannelActive.Length; i++) {
			if (info.ChannelActive[i]) {
				activeChannels++;
			}
		}
		info.ActiveChannelCount = activeChannels;

		Logger.Information("Header: tempo=0x{Tempo:X4}, {ActiveCh} active channels, {InstCount} instruments, loop={LoopStart}-{LoopEnd}x{LoopCount}",
			info.Tempo, activeChannels, info.InstrumentCount, info.LoopStartMeasure, info.LoopEndMeasure, info.LoopCount);

		return info;
	}

	/// <summary>
	/// Extracts song header info from raw file data without loading the full song.
	/// Handles both HSQ-compressed and raw ADP data.
	/// Does NOT create an engine instance — safe to call for playlist inspection.
	/// </summary>
	public static bool TryExtractHeaderInfo(byte[] fileData, out SongHeaderInfo? headerInfo) {
		headerInfo = null;
		if (fileData.Length < 2) {
			return false;
		}

		bool wasCompressed = false;
		byte[] data = fileData;

		// Try HSQ decompression using the static helper — no engine instantiation needed.
		byte[]? decompressed = TryDecompressHsq(fileData);
		if (decompressed != null) {
			data = decompressed;
			wasCompressed = true;
		}
		if (data.Length < 2) {
			return false;
		}

		int dataBase = 2;
		int eventBase = (ushort)(data[0] | (data[1] << 8));
		int safeEventBase = eventBase;
		if (safeEventBase < 0 || safeEventBase > data.Length) {
			safeEventBase = data.Length;
		}

		SongHeaderInfo info = new SongHeaderInfo {
			RawFileSize = data.Length,
			WasHsqCompressed = wasCompressed,
			DataBase = dataBase,
			EventBase = eventBase,
			InstrumentCount = safeEventBase > dataBase + 0x32 ? (data.Length - safeEventBase) / 0x28 : 0
		};

		if (data.Length >= dataBase + 0x32) {
			info.Tempo = (ushort)(data[dataBase + 0x30] | (data[dataBase + 0x31] << 8));
			info.LoopStartMeasure = (ushort)(data[dataBase + 0x2A] | (data[dataBase + 0x2B] << 8));
			info.LoopEndMeasure = (ushort)(data[dataBase + 0x2C] | (data[dataBase + 0x2D] << 8));
			info.LoopCount = (ushort)(data[dataBase + 0x2E] | (data[dataBase + 0x2F] << 8));

			for (int i = 0; i < info.ChannelOffsets.Length; i++) {
				int offset = dataBase + i * 2;
				if (offset + 1 >= data.Length) {
					break;
				}
				ushort relative = (ushort)(data[offset] | (data[offset + 1] << 8));
				info.ChannelOffsets[i] = relative;
				info.ChannelActive[i] = relative != 0;
			}
		}

		int activeChannels = 0;
		for (int i = 0; i < info.ChannelActive.Length; i++) {
			if (info.ChannelActive[i]) {
				activeChannels++;
			}
		}
		info.ActiveChannelCount = activeChannels;

		headerInfo = info;
		return true;
	}
}

/// <summary>
/// Parsed song header metadata for display.
/// </summary>
public sealed class SongHeaderInfo {
	public int RawFileSize { get; set; }
	public bool WasHsqCompressed { get; set; }
	public int DataBase { get; set; }
	public int EventBase { get; set; }
	public ushort Tempo { get; set; }
	public ushort LoopStartMeasure { get; set; }
	public ushort LoopEndMeasure { get; set; }
	public ushort LoopCount { get; set; }
	public int InstrumentCount { get; set; }
	public int ActiveChannelCount { get; set; }
	public ushort[] ChannelOffsets { get; set; } = new ushort[18];
	public bool[] ChannelActive { get; set; } = new bool[18];
}

/// <summary>
/// Snapshot of a single OPL channel's state for UI display.
/// </summary>
public sealed class ChannelSnapshot {
	public int Channel { get; set; }
	public ushort Wait { get; set; }
	public byte Instrument { get; set; }
	public byte Note { get; set; }
	public byte Transpose { get; set; }
	public ushort Frequency { get; set; }
	public ushort PitchBendFlag { get; set; }
	public bool IsActive { get; set; }

	/// <summary>
	/// Human-readable note name from MIDI-style note number.
	/// </summary>
	public string NoteName {
		get {
			if (Note == 0) {
				return "---";
			}
			string[] names = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
			int octave = (Note / 12) - 1;
			int semitone = Note % 12;
			return $"{names[semitone]}{octave}";
		}
	}
}