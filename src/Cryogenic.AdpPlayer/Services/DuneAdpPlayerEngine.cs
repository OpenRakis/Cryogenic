namespace Cryogenic.AdpPlayer.Services;

/// <summary>
/// Standalone DNADP (AdLib/OPL2) player engine whose core logic is a faithful
/// translation of the DNADP driver routines decoded from the Dune CD executable.
///
/// This file is intentionally a self-contained copy — it does NOT reference
/// Cryogenic override code — so that changes to the emulator overrides can never
/// regress the standalone player, and vice-versa.
///
/// Song data layout (identical to DNMID / M32 format):
///   file[0..1]     = event base offset (relative to file start)
///   file[2..3]     = channel 0 offset (relative to songDataOffset = file+2)
///   file[4..5]     = channel 1 offset
///   ...
///   file[18..19]   = channel 8 offset
///   file[0x2C..0x2D] = endMeasure     (songDataOffset + 0x2A)
///   file[0x2E..0x2F] = loopMeasure    (songDataOffset + 0x2C)
///   file[0x30..0x31] = loopRepeat     (songDataOffset + 0x2E)
///   file[0x32..0x33] = tickIncrement  (songDataOffset + 0x30)
///
/// Timer model:
///   PIT IRQ0 (~200 Hz, reload 0x1745)
///     TickInternal:
///       dec high byte of accumulator
///       if bit7 set -> ProcessTick (adds tickIncrement to word accumulator)
///       rol fadeBitPattern; if carry -> HandleFade
/// </summary>
public sealed partial class DuneAdpPlayerEngine : IDisposable {
	// PIT reload value 0x1745 = 5957 -> 1193182 / 5957 = ~200.2 Hz -> ~4.99ms per tick.
	private const int PitReloadValue = 0x1745;
	private const int PitInputClock = 1193182;
	private const int SampleRate = 48000;

	// Threshold for audio-driven tick: one PIT tick = SampleRate * PitReloadValue ticks of PitInputClock.
	private const long SamplesPerTickThreshold = (long)SampleRate * PitReloadValue;



	// Offset 2 into the file, matching driver's songDataOffset = SI + 2.
	private const int SongDataOffset = 2;

	private readonly Opl2Synth _synth;

	// Song data
	private byte[] _songData = [];

	// Event base offset (points to instrument table in song data)
	private ushort _eventBaseOffset;

	// Driver state (mirrors DNADP CS-relative variables)
	private readonly ushort[] _channelWait = new ushort[9];
	private readonly ushort[] _channelEventPointer = new ushort[9];
	private readonly ushort[] _channelStartOffset = new ushort[9];
	private readonly ushort[] _snapshotWait = new ushort[9];
	private readonly ushort[] _snapshotPointer = new ushort[9];

	// Per-channel OPL state (DNADP SOA layout decoded from driver)
	private readonly byte[] _channelInstrument = new byte[9];
	private readonly byte[] _channelNote = new byte[9];
	private readonly byte[] _channelTranspose = new byte[9];
	private readonly ushort[] _channelStoredFreq = new ushort[9];
	private readonly byte[] _channelVolume = new byte[9];
	private readonly byte[] _channelCarrierKsl = new byte[9];
	private readonly ushort[] _channelReg90 = new ushort[9];
	private readonly byte[] _channelReg48 = new byte[9];
	private readonly ushort[] _channelReg7E = new ushort[9];
	private readonly ushort[] _channelRegA2 = new ushort[9];
	private readonly ushort[] _channelRegC6 = new ushort[9];
	private readonly ushort[] _channelRegB4 = new ushort[9];
	private readonly ushort[] _channelRegD8 = new ushort[9];

	private ushort _activeChannelCount;
	private ushort _accumulator;
	private ushort _measure;
	private ushort _subdivision;
	private ushort _repeatCounter;
	private ushort _tickIncrement;
	private ushort _fadeBitPattern;
	private byte _currentVolume;
	private byte _targetVolume;
	private byte _masterVolume;
	private byte _statusFlags;
	private byte _tickFlag;

	// Song header fields
	private ushort _endMeasure;
	private ushort _loopMeasure;
	private ushort _loopRepeat;

	// Audio-driven tick accumulator
	private long _sampleAccumulator;

	// Process tick counter for diagnostics
	private int _processTickCount;

	// Playback control
	private bool _isLoaded;
	private bool _isPlaying;
	private bool _isPaused;
	private int _rawFileSize;
	private bool _wasCompressed;

	public event Action<PlayerDiagnosticsSnapshot>? SnapshotProduced;
	public event Action<string>? LogProduced;
	public event Action<SongHeaderInfo>? HeaderInfoProduced;
	public event Action<EventFlowEntry>? EventFlowProduced;

	public DuneAdpPlayerEngine(Opl2Synth synth) {
		_synth = synth;
		_masterVolume = 0x7F;
		_currentVolume = 0x7F;
		_targetVolume = 0x7F;
		_fadeBitPattern = 0xFFFF;
		for (int i = 0; i < _lastEventPerChannel.Length; i++) {
			_lastEventPerChannel[i] = "-";
		}
	}

	public bool IsPlaying => _isPlaying;
	public bool IsPaused => _isPaused;
	public ushort EndMeasure => _endMeasure;
	public byte CurrentVolume => _currentVolume;
	public byte TargetVolume => _targetVolume;

	/// <summary>
	/// When true, replaces all song instrument data with a known-good test instrument.
	/// If sound appears during playback with this enabled, the instrument data parsing is wrong.
	/// </summary>
	public bool UseTestInstruments { get; set; }

	/// <summary>
	/// Loads a song file (optionally HSQ-compressed) and prepares driver state.
	/// </summary>
	public void Load(string path) {
		byte[] source = File.ReadAllBytes(path);
		byte[] data = TryDecompressHsq(source);
		if (data.Length < 0x40) {
			throw new InvalidDataException("Song stream is too small after decode.");
		}

		_songData = data;
		_rawFileSize = source.Length;
		_wasCompressed = source.Length != data.Length;
		_currentSongPath = path;
		_currentSongName = Path.GetFileName(path);
		_songLayoutNote = DescribeSongLayout(data);

		_tickFlag = 1;

		// Event base offset: file[0..1] stores raw offset; the driver subtracts 0x20
		// before using it (verified via MCP: far pointer at [0x0119] = file_value - 0x20).
		_eventBaseOffset = (ushort)(ReadU16(0) - 0x20);

		// Header fields at songDataOffset-relative offsets:
		_endMeasure = ReadU16(SongDataOffset + 0x2A);
		_loopMeasure = ReadU16(SongDataOffset + 0x2C);
		_loopRepeat = ReadU16(SongDataOffset + 0x2E);
		_tickIncrement = ReadU16(SongDataOffset + 0x30);
		if (_tickIncrement == 0) {
			_tickIncrement = 1;
		}

		// Initialize OPL2 chip
		InitOpl();

		BuildChannelTable();

		_currentVolume = _masterVolume;
		_targetVolume = _masterVolume;

		_accumulator = 0;
		_repeatCounter = 0;

		// First ProcessTick (driver calls this during OpenSong)
		ProcessTick();

		_statusFlags = 0x80;
		_isLoaded = true;
		_tickIndex = 0;
		_processTickCount = 0;
		_instrumentLoadCount = 0;
		_noteOnCount = 0;
		_advanceSamplesCallCount = 0;

		ResetAudioDebug();
		for (int i = 0; i < _lastEventPerChannel.Length; i++) {
			_lastEventPerChannel[i] = "-";
		}

		EmitLog($"Loaded '{Path.GetFileName(path)}' ({source.Length}B raw -> {data.Length}B decoded)");
		EmitLog($"  Header: tickInc=0x{_tickIncrement:X4} ({_tickIncrement}), endMeasure={_endMeasure}, loopMeasure={_loopMeasure}, loopRepeat={_loopRepeat}");
		EmitLog($"  Timing: ~{_tickIncrement / 256.0:F2} PIT ticks/subdiv, ~{_tickIncrement / 256.0 * PitReloadValue / (double)PitInputClock * 1000.0:F2}ms/subdiv");
		EmitLog($"  eventBase=0x{_eventBaseOffset:X4}, activeChannels={_activeChannelCount}, accumAfterInit=0x{_accumulator:X4}");
		for (int i = 0; i < 9; i++) {
			ushort chOff = ReadU16(SongDataOffset + i * 2);
			if (chOff != 0) {
				EmitLog($"  Ch{i}: offset=0x{chOff:X4} -> abs=0x{SongDataOffset + chOff:X4}, wait={_channelWait[i]}, ptr=0x{_channelEventPointer[i]:X4}");
			}
		}
		EmitHeaderInfo();
		EmitSnapshot(0);
	}

	public void SetTargetVolume(byte targetVolume) {
		_targetVolume = targetVolume;
		_fadeBitPattern = 0xFFFF;
	}

	/// <summary>
	/// Sets master + current + target volume immediately.
	/// </summary>
	public void SetMasterVolumeImmediate(byte volume) {
		_masterVolume = volume;
		_currentVolume = volume;
		_targetVolume = volume;
		_fadeBitPattern = 0xFFFF;
	}

	public void Start() {
		if (!_isLoaded) {
			throw new InvalidOperationException("Load a song file first.");
		}
		if (_isPlaying) {
			return;
		}
		_sampleAccumulator = 0;
		_isPlaying = true;
		_isPaused = false;
		_synth.OnBeforeRender = AdvanceSamples;
		_synth.LogDebug($"Start(): OnBeforeRender hooked, isPlaying={_isPlaying}");
		EmitLog($"Playback started (audio-driven, PIT ~{PitInputClock / (double)PitReloadValue:F1} Hz, ~{SamplesPerTickThreshold / (double)PitInputClock:F1} samples/tick).");
	}

	/// <summary>
	/// Pauses playback: stops tick advancement and silences sounding notes.
	/// </summary>
	public void Pause() {
		if (!_isPlaying || _isPaused) {
			return;
		}
		_synth.OnBeforeRender = null;
		AllNotesOff();
		_isPlaying = false;
		_isPaused = true;
		EmitLog("Playback paused.");
	}

	/// <summary>
	/// Resumes playback from a paused state.
	/// </summary>
	public void Resume() {
		if (!_isPaused) {
			return;
		}
		_sampleAccumulator = 0;
		_isPlaying = true;
		_isPaused = false;
		_synth.OnBeforeRender = AdvanceSamples;
		EmitLog("Playback resumed.");
	}

	public void Stop() {
		_synth.OnBeforeRender = null;
		_isPlaying = false;
		_isPaused = false;
		_statusFlags = 0;
		_sampleAccumulator = 0;
		AllNotesOff();
		EmitLog("Playback stopped.");
	}

	public void Dispose() {
		Stop();
	}

	public void PanicAllNotesOff() {
		AllNotesOff();
		AddRecentEvent("PANIC all notes off");
	}

	public object GetRawStreamDebug(int channel, int before, int count) {
		int clampedBefore = Math.Clamp(before, 0, 64);
		int clampedCount = Math.Clamp(count, 8, 256);
		int clampedChannel = Math.Clamp(channel, 0, 8);

		ushort pointer = _channelEventPointer[clampedChannel];
		int start = Math.Max(0, pointer - clampedBefore);
		int endExclusive = Math.Min(_songData.Length, start + clampedCount);
		byte[] window = _songData[start..endExclusive];

		int headerStart = 0;
		int headerCount = Math.Min(80, Math.Max(0, _songData.Length - headerStart));
		byte[] headerWindow = headerCount > 0 ? _songData[headerStart..(headerStart + headerCount)] : [];

		return new {
			channel = clampedChannel,
			pointer,
			wait = _channelWait[clampedChannel],
			windowStart = start,
			windowLength = window.Length,
			windowHex = BytesToHex(window),
			headerOffset = 0,
			headerHex = BytesToHex(headerWindow),
			songLayoutNote = _songLayoutNote
		};
	}

	// Memory access helper
	private ushort ReadU16(int offset) {
		if (offset + 1 >= _songData.Length) {
			throw new InvalidDataException($"Song read out of bounds at 0x{offset:X4} / len=0x{_songData.Length:X4}.");
		}
		return (ushort)(_songData[offset] | (_songData[offset + 1] << 8));
	}

	private static string DescribeSongLayout(byte[] data) {
		int activeCount = 0;
		for (int i = 0; i < 9; i++) {
			ushort ch = (ushort)(data[SongDataOffset + i * 2] | (data[SongDataOffset + i * 2 + 1] << 8));
			if (ch != 0) { activeCount++; }
		}
		ushort endMeasure = (ushort)(data[SongDataOffset + 0x2A] | (data[SongDataOffset + 0x2A + 1] << 8));
		ushort loopMeasure = (ushort)(data[SongDataOffset + 0x2C] | (data[SongDataOffset + 0x2C + 1] << 8));
		ushort loopRepeat = (ushort)(data[SongDataOffset + 0x2E] | (data[SongDataOffset + 0x2E + 1] << 8));
		ushort tickInc = (ushort)(data[SongDataOffset + 0x30] | (data[SongDataOffset + 0x30 + 1] << 8));
		ushort firstWord = (ushort)(data[0] | (data[1] << 8));
		return $"evtBase=0x{firstWord:X4}, {activeCount}ch, tickInc=0x{tickInc:X4}, end={endMeasure}, loop={loopMeasure}, repeat={loopRepeat}";
	}

	private static string BytesToHex(byte[] bytes) {
		if (bytes.Length == 0) {
			return string.Empty;
		}
		char[] chars = new char[bytes.Length * 3 - 1];
		int c = 0;
		for (int i = 0; i < bytes.Length; i++) {
			byte b = bytes[i];
			chars[c++] = (char)(((b >> 4) & 0xF) < 10 ? '0' + ((b >> 4) & 0xF) : 'A' + ((b >> 4) & 0xF) - 10);
			chars[c++] = (char)((b & 0xF) < 10 ? '0' + (b & 0xF) : 'A' + (b & 0xF) - 10);
			if (i != bytes.Length - 1) {
				chars[c++] = ' ';
			}
		}
		return new string(chars);
	}

	private void EmitLog(string message) {
		string line = $"[{DateTime.Now:HH:mm:ss.fff}] {message}";
		LogProduced?.Invoke(line);
	}

	/// <summary>
	/// Builds and emits a structured SongHeaderInfo for the UI header panel.
	/// </summary>
	private void EmitHeaderInfo() {
		double pitTicksPerSubdiv = _tickIncrement / 256.0;
		double msPerSubdiv = pitTicksPerSubdiv * PitReloadValue / (double)PitInputClock * 1000.0;
		double msPerMeasure = msPerSubdiv * 0x60;
		double estimatedSec = _endMeasure * msPerMeasure / 1000.0;

		ChannelHeaderInfo[] channels = new ChannelHeaderInfo[9];
		for (int i = 0; i < 9; i++) {
			ushort rawOff = ReadU16(SongDataOffset + i * 2);
			channels[i] = new ChannelHeaderInfo {
				Index = i,
				RawOffset = rawOff,
				AbsoluteOffset = (ushort)(rawOff != 0 ? SongDataOffset + rawOff : 0),
				InitialWait = _channelWait[i],
				InitialPointer = _channelEventPointer[i],
				Active = rawOff != 0
			};
		}

		SongHeaderInfo info = new() {
			FileName = _currentSongName,
			FilePath = _currentSongPath,
			RawFileSize = _rawFileSize,
			DecodedSize = _songData.Length,
			WasCompressed = _wasCompressed,
			FirstWord = ReadU16(0),
			TickIncrement = _tickIncrement,
			PitTicksPerSubdivision = pitTicksPerSubdiv,
			MillisecondsPerSubdivision = msPerSubdiv,
			MillisecondsPerMeasure = msPerMeasure,
			EstimatedDurationSeconds = estimatedSec,
			EndMeasure = _endMeasure,
			LoopMeasure = _loopMeasure,
			LoopRepeat = _loopRepeat,
			ActiveChannelCount = _activeChannelCount,
			Channels = channels
		};

		HeaderInfoProduced?.Invoke(info);
	}
}