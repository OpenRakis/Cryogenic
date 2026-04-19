namespace Cryogenic.AdpPlayer.Services;

using Serilog;

using System;

/// <summary>
/// Standalone DNADP (AdLib Pro / OPL) music player engine.
/// Faithfully ports the original driver logic from AdpDriverCode.cs
/// to run outside the Spice86 emulator using NukedOPL3Sharp for synthesis
/// and Spice86.Audio for playback.
/// </summary>
public sealed partial class DuneAdpPlayerEngine : IDisposable {
	private static readonly ILogger Logger = Log.ForContext<DuneAdpPlayerEngine>();

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
	private int _pitReloadValue = 0x1745;
	private long _samplesPerTickThreshold;
	private long _sampleAccumulator;

	// --- Song data ---
	private byte[] _songData = Array.Empty<byte>();
	private int _dataBase;
	private ushort _eventBase;

	// --- Global driver state ---
	private ushort _accumulator;
	private byte _statusFlags;
	private byte _tickFlag;
	private ushort _measure;
	private byte _subdivision;
	private ushort _repeatCounter;
	private byte _currentVolume;
	private byte _targetVolume;
	private byte _masterVolume;
	private ushort _fadeBitPattern;

	// --- Per-channel state (9 OPL2 channels) ---
	private const int ChannelCount = 9;
	private readonly ushort[] _channelWait = new ushort[ChannelCount];
	private readonly ushort[] _channelEventPointer = new ushort[ChannelCount];
	private readonly ushort[] _channelStartOffset = new ushort[ChannelCount];
	private readonly byte[] _channelInstrument = new byte[ChannelCount];
	private readonly byte[] _channelNote = new byte[ChannelCount];
	private readonly ushort[] _channelPitchBendFlag = new ushort[ChannelCount];
	private readonly byte[] _channelTranspose = new byte[ChannelCount];
	private readonly byte[] _channelVibratoCount = new byte[ChannelCount];
	private readonly byte[] _channelVibratoInit = new byte[ChannelCount];
	private readonly byte[] _channelVibratoPhase = new byte[ChannelCount];
	private readonly byte[] _channelVibratoSpeed = new byte[ChannelCount];
	private readonly ushort[] _channelTlShaping = new ushort[ChannelCount];
	private readonly ushort[] _channelEnvShaping = new ushort[ChannelCount];
	private readonly ushort[] _channelOperatorLevel = new ushort[ChannelCount];
	private readonly ushort[] _channelConnShaping = new ushort[ChannelCount];
	private readonly ushort[] _channelVolModShaping = new ushort[ChannelCount];
	private readonly ushort[] _channelConnMod = new ushort[ChannelCount];
	private readonly ushort[] _channelFreq = new ushort[ChannelCount];

	// --- Loop snapshot ---
	private readonly ushort[] _snapshotWait = new ushort[ChannelCount];
	private readonly ushort[] _snapshotPointer = new ushort[ChannelCount];

	// --- Static lookup tables (from driver binary, verified against runtime dump) ---

	/// <summary>OPL2 F-number table for one octave (C through B), 12 entries.</summary>
	private static readonly ushort[] FrequencyTable = {
		0x0157, 0x016C, 0x0181, 0x0198, 0x01B1, 0x01CB,
		0x01E6, 0x0203, 0x0222, 0x0243, 0x0266, 0x028A
	};

	/// <summary>Maps channel (0-8) to OPL register offset for modulator operator.</summary>
	private static readonly byte[] ModulatorOffsets = {
		0x00, 0x01, 0x02, 0x08, 0x09, 0x0A, 0x10, 0x11, 0x12
	};

	/// <summary>Maps channel (0-8) to OPL register offset for carrier operator.</summary>
	private static readonly byte[] CarrierOffsets = {
		0x03, 0x04, 0x05, 0x0B, 0x0C, 0x0D, 0x13, 0x14, 0x15
	};

	/// <summary>
	/// Operator pair table: interleaved (modulator, carrier) per channel.
	/// Channel N modulator = OperatorPairTable[N*2], carrier = OperatorPairTable[N*2+1].
	/// </summary>
	private static readonly byte[] OperatorPairTable = {
		0x00, 0x03, 0x01, 0x04, 0x02, 0x05,
		0x08, 0x0B, 0x09, 0x0C, 0x0A, 0x0D,
		0x10, 0x13, 0x11, 0x14, 0x12, 0x15
	};

	/// <summary>Non-portamento pitch bend fractions (13 entries, indexed 0-12).</summary>
	private static readonly byte[] PitchBendFractions = {
		0x13, 0x15, 0x15, 0x17, 0x19, 0x1A,
		0x1B, 0x1D, 0x1F, 0x21, 0x23, 0x24, 0x25
	};

	/// <summary>Portamento pitch bend fractions (two groups of 5).</summary>
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
					Transpose = _channelTranspose[i],
					Frequency = _channelFreq[i],
					PitchBendFlag = _channelPitchBendFlag[i],
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
	/// True when playback state is preserved but audio generation is paused.
	/// </summary>
	public bool IsPaused => _playing && _paused;

	/// <summary>
	/// Creates the engine with a custom OPL synthesizer (for testing).
	/// </summary>
	public DuneAdpPlayerEngine(OplSynthesizer opl) {
		_opl = opl;
		_samplesPerTickThreshold = (long)OplSynthesizer.NativeOplSampleRate * _pitReloadValue;
		_opl.OnBeforeRender = AdvanceSamples;
		Logger.Information("ADP engine created: {SampleRate} Hz native OPL, PIT reload 0x{PitReload:X4}",
			OplSynthesizer.NativeOplSampleRate, _pitReloadValue);
	}

	/// <summary>
	/// Creates the engine with default audio pipeline (SoftwareMixer at 49716 Hz native OPL rate).
	/// </summary>
	public DuneAdpPlayerEngine() {
		_opl = new OplSynthesizer();
		_samplesPerTickThreshold = (long)OplSynthesizer.NativeOplSampleRate * _pitReloadValue;
		_opl.OnBeforeRender = AdvanceSamples;
		_opl.AudioSamplesRendered += (samples, count) => AudioSamplesRendered?.Invoke(samples, count);
		Logger.Information("ADP engine created (default): {SampleRate} Hz native OPL via SoftwareMixer", OplSynthesizer.NativeOplSampleRate);
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

			InitOplChip();
			InitTotalLevels();
			BuildChannelTable();

			_currentVolume = _masterVolume;
			_targetVolume = _masterVolume;
			_accumulator = 0;
			_repeatCounter = 0;
			_tickFlag = 1;
			_totalTickCount = 0;
			_totalSamplesRendered = 0;

			ProcessTick();
			_statusFlags = 0x80;

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

	public void Dispose() {
		if (_disposed) {
			return;
		}
		_disposed = true;
		_playing = false;
		_paused = false;
		_opl.Dispose();
		Logger.Information("ADP engine disposed");
	}

	/// <summary>
	/// Parses song header metadata for UI display.
	/// </summary>
	private SongHeaderInfo ParseSongHeader(byte[] data, int dataBase, int eventBase, bool wasCompressed) {
		SongHeaderInfo info = new SongHeaderInfo {
			RawFileSize = data.Length,
			WasHsqCompressed = wasCompressed,
			DataBase = dataBase,
			EventBase = eventBase,
			InstrumentCount = eventBase > dataBase + 0x32 ? (data.Length - eventBase) / 0x28 : 0
		};

		if (data.Length >= dataBase + 0x32) {
			info.Tempo = SongWord(dataBase + 0x30);
			info.LoopStartMeasure = SongWord(dataBase + 0x2A);
			info.LoopEndMeasure = SongWord(dataBase + 0x2C);
			info.LoopCount = SongWord(dataBase + 0x2E);

			for (int i = 0; i < ChannelCount; i++) {
				ushort relative = SongWord(dataBase + i * 2);
				info.ChannelOffsets[i] = relative;
				info.ChannelActive[i] = relative != 0;
			}
		}

		int activeChannels = 0;
		for (int i = 0; i < ChannelCount; i++) {
			if (info.ChannelActive[i]) {
				activeChannels++;
			}
		}
		info.ActiveChannelCount = activeChannels;

		Logger.Information("Header: tempo=0x{Tempo:X4}, {ActiveCh} active channels, {InstCount} instruments, loop={LoopStart}-{LoopEnd}x{LoopCount}",
			info.Tempo, activeChannels, info.InstrumentCount, info.LoopStartMeasure, info.LoopEndMeasure, info.LoopCount);

		return info;
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
	public ushort[] ChannelOffsets { get; set; } = new ushort[9];
	public bool[] ChannelActive { get; set; } = new bool[9];
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