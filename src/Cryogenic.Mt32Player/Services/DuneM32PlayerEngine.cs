namespace Cryogenic.Mt32Player.Services;

/// <summary>
/// Standalone M32 player engine whose core logic is a faithful copy of the
/// DNMID driver routines from MT32DriverCode.cs (the C# overrides that run
/// inside Spice86 and are proven correct by ear against live playback).
///
/// This file is intentionally a self-contained copy — it does NOT reference
/// MT32DriverCode.cs — so that changes to the emulator overrides can never
/// regress the standalone player, and vice-versa.
///
/// Song data layout (from MidiOpenInternal_F000_0250):
///   file[0..1]     = event base offset (relative to file start)
///   file[2..3]     = channel 0 offset (relative to file+2, the "songDataOffset")
///   file[4..5]     = channel 1 offset
///   ...
///   file[18..19]   = channel 8 offset
///   ...
///   file[0x2C..0x2D] = endMeasure     (songDataOffset + 0x2A)
///   file[0x2E..0x2F] = loopMeasure    (songDataOffset + 0x2C)
///   file[0x30..0x31] = loopRepeat     (songDataOffset + 0x2E)
///   file[0x32..0x33] = tickIncrement  (songDataOffset + 0x30)
///
/// Timer model:
///   PIT IRQ0 (~200 Hz, reload 0x1745)
///     TickInternal (030F):
///       dec byte [011E] (= high byte of word [011D], the accumulator)
///       if (highByte & 0x80) -> ProcessTick (adds tickIncrement to word [011D])
///       rol fadeBitPattern; if carry -> HandleFade
/// </summary>
public sealed partial class DuneM32PlayerEngine : IDisposable {
	// PIT reload value 0x1745 = 5957 -> 1193182 / 5957 = ~200.2 Hz -> ~4.99ms per tick.
	private const int PitReloadValue = 0x1745;
	private const int PitInputClock = 1193182;
	private const int SampleRate = 48000;

	// Threshold for audio-driven tick: one PIT tick = SampleRate * PitReloadValue ticks of PitInputClock.
	private const long SamplesPerTickThreshold = (long)SampleRate * PitReloadValue;

	// Offset 2 into the file, matching driver's songDataOffset = SI + 2.
	private const int SongDataOffset = 2;

	private readonly Mt32MidiSynth _synth;

	// Song data
	private byte[] _songData = [];

	// Driver state (mirrors DNMID CS-relative variables)
	private readonly ushort[] _channelWait = new ushort[9];
	private readonly ushort[] _channelEventPointer = new ushort[9];
	private readonly ushort[] _channelStartOffset = new ushort[9];
	private readonly ushort[] _snapshotWait = new ushort[9];
	private readonly ushort[] _snapshotPointer = new ushort[9];
	private readonly byte[] _channelBaseVolume = new byte[10];

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

	// Song header fields (read from songDataOffset-relative positions)
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

	// Event handler kind table (exact copy from MT32DriverCode)
	private enum EventHandlerKind {
		ThreeByteWithDelta,
		DeltaOnly,
		ThreeByteControlWithDelta,
		TwoByteWithDelta,
		SpecialControlFlow
	}

	private static readonly EventHandlerKind[] EventHandlerTable = [
		EventHandlerKind.ThreeByteWithDelta,        // type 0
        EventHandlerKind.ThreeByteWithDelta,        // type 1
        EventHandlerKind.DeltaOnly,                 // type 2
        EventHandlerKind.ThreeByteControlWithDelta, // type 3
        EventHandlerKind.TwoByteWithDelta,          // type 4
        EventHandlerKind.TwoByteWithDelta,          // type 5
        EventHandlerKind.ThreeByteWithDelta,        // type 6
        EventHandlerKind.SpecialControlFlow         // type 7
    ];

	public event Action<PlayerDiagnosticsSnapshot>? SnapshotProduced;
	public event Action<string>? LogProduced;
	public event Action<SongHeaderInfo>? HeaderInfoProduced;
	public event Action<EventFlowEntry>? EventFlowProduced;

	public DuneM32PlayerEngine(Mt32MidiSynth synth) {
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
	/// Loads an M32 file (optionally HSQ-compressed) and prepares driver state
	/// exactly matching MidiOpenInternal_F000_0250.
	///
	/// Driver flow:
	///   [013A] = AL (tick flag from common code)
	///   songDataOffset = SI + 2  (stored at [0115])
	///   eventOffset = SI + [ES:SI]  (stored at [0119])
	///   EnterUartMode (052F)
	///   BuildChannelTable (02AE) — reads initial deltas per channel
	///   masterVol -> currentVol, targetVol
	///   accumulator = 0, repeatCounter = 0
	///   ProcessTick (036F) — first tick
	///   statusFlags = 0x80
	/// </summary>
	public void Load(string path) {
		byte[] source = File.ReadAllBytes(path);
		byte[] data = TryDecompressHsq(source);
		if (data.Length < 0x40) {
			throw new InvalidDataException("M32 stream is too small after decode.");
		}

		_songData = data;
		_rawFileSize = source.Length;
		_wasCompressed = source.Length != data.Length;
		_currentSongPath = path;
		_currentSongName = Path.GetFileName(path);
		_songLayoutNote = DescribeSongLayout(data);

		// MidiOpenInternal_F000_0250 sequence:
		_tickFlag = 1;

		// Header fields at songDataOffset-relative offsets:
		//   endMeasure   = songDataOffset + 0x2A = file[0x2C]
		//   loopMeasure  = songDataOffset + 0x2C = file[0x2E]
		//   loopRepeat   = songDataOffset + 0x2E = file[0x30]
		//   tickIncrement = songDataOffset + 0x30 = file[0x32]
		_endMeasure = ReadU16(SongDataOffset + 0x2A);
		_loopMeasure = ReadU16(SongDataOffset + 0x2C);
		_loopRepeat = ReadU16(SongDataOffset + 0x2E);
		_tickIncrement = ReadU16(SongDataOffset + 0x30);
		if (_tickIncrement == 0) {
			_tickIncrement = 1;
		}

		EnterUartMode();
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

		ResetAudioDebug();
		for (int i = 0; i < _lastEventPerChannel.Length; i++) {
			_lastEventPerChannel[i] = "-";
		}

		EmitLog($"Loaded '{Path.GetFileName(path)}' ({source.Length}B raw -> {data.Length}B decoded)");
		EmitLog($"  Header: tickInc=0x{_tickIncrement:X4} ({_tickIncrement}), endMeasure={_endMeasure}, loopMeasure={_loopMeasure}, loopRepeat={_loopRepeat}");
		EmitLog($"  Timing: ~{_tickIncrement / 256.0:F2} PIT ticks/subdiv, ~{_tickIncrement / 256.0 * PitReloadValue / (double)PitInputClock * 1000.0:F2}ms/subdiv");
		EmitLog($"  firstWord=0x{ReadU16(0):X4}, activeChannels={_activeChannelCount}, accumAfterInit=0x{_accumulator:X4}");
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
	/// Sets master + current + target volume and sends per-channel CC7.
	/// Mirrors MidiSetVolumeInternal_F000_022B.
	/// </summary>
	public void SetMasterVolumeImmediate(byte volume) {
		_masterVolume = volume;
		_currentVolume = volume;
		_targetVolume = volume;
		_fadeBitPattern = 0xFFFF;
		for (int channel = 0; channel < 10; channel++) {
			byte scaled = (byte)((_currentVolume * _channelBaseVolume[channel]) >> 8);
			_synth.SendMidi3((byte)(0xB0 + channel), 0x07, scaled);
			RecordGoldenCaptureEvent("engine", "volume-immediate", (byte)(0xB0 + channel), 0x07, scaled, true, -1, 3, 0);
		}
	}

	public void Start() {
		if (!_isLoaded) {
			throw new InvalidOperationException("Load an M32 file first.");
		}
		if (_isPlaying) {
			return;
		}
		_sampleAccumulator = 0;
		_isPlaying = true;
		_isPaused = false;
		_synth.OnBeforeRender = AdvanceSamples;
		EmitLog($"Playback started (audio-driven, PIT ~{PitInputClock / (double)PitReloadValue:F1} Hz, ~{SamplesPerTickThreshold / (double)PitInputClock:F1} samples/tick).");
	}

	/// <summary>
	/// Pauses playback: stops tick advancement and silences sounding notes,
	/// but retains all song state so <see cref="Resume"/> continues seamlessly.
	/// </summary>
	public void Pause() {
		if (!_isPlaying || _isPaused) {
			return;
		}
		_synth.OnBeforeRender = null;
		SendAllNotesOff();
		_isPlaying = false;
		_isPaused = true;
		EmitLog("Playback paused.");
	}

	/// <summary>
	/// Resumes playback from a paused state. Re-hooks the audio callback
	/// so ticks are driven by the sample stream again.
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
		if (!_isPlaying && !_isPaused) {
			return;
		}
		_synth.OnBeforeRender = null;
		_isPlaying = false;
		_isPaused = false;
		SendAllNotesOff();
		EmitLog("Playback stopped.");
	}

	public void Dispose() {
		Stop();
	}

	public void PanicAllNotesOff() {
		SendAllNotesOff();
		AddRecentEvent("PANIC all notes off");
	}

	public void TriggerTestNote(byte channel, byte note, byte velocity, int durationMs) {
		int clampedDuration = Math.Clamp(durationMs, 40, 4000);
		byte clampedChannel = (byte)(channel & 0x0F);
		byte noteOn = (byte)(0x90 + clampedChannel);
		byte noteOff = (byte)(0x80 + clampedChannel);
		_synth.SendMidi3(noteOn, note, velocity);
		RecordGoldenCaptureEvent("inject", "test-note-on", noteOn, note, velocity, true, -1, -1, 0);
		_testNotesTriggered++;
		AddRecentEvent($"TEST ON ch={clampedChannel} note={note} vel={velocity}");
		Task.Run(async () => {
			await Task.Delay(clampedDuration);
			_synth.SendMidi3(noteOff, note, 0);
			RecordGoldenCaptureEvent("inject", "test-note-off", noteOff, note, 0, true, -1, -1, 0);
			AddRecentEvent($"TEST OFF ch={clampedChannel} note={note}");
		});
	}

	public void SendMidi3Diagnostic(byte status, byte data1, byte data2) {
		_synth.SendMidi3(status, data1, data2);
		TrackMidi(status, data1, data2, true);
		RecordGoldenCaptureEvent("inject", "midi3", status, data1, data2, true, -1, -1, 0);
	}

	public void SendMidi2Diagnostic(byte status, byte data1) {
		_synth.SendMidi2(status, data1);
		TrackMidi(status, data1, 0, false);
		RecordGoldenCaptureEvent("inject", "midi2", status, data1, 0, false, -1, -1, 0);
	}

	public void SendMidi1Diagnostic(byte status) {
		_synth.SendMidi1(status);
		TrackMidi(status, 0, 0, false);
		RecordGoldenCaptureEvent("inject", "midi1", status, 0, 0, false, -1, -1, 0);
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
			throw new InvalidDataException($"M32 read out of bounds at 0x{offset:X4} / len=0x{_songData.Length:X4}.");
		}
		return (ushort)(_songData[offset] | (_songData[offset + 1] << 8));
	}

	private static string DescribeSongLayout(byte[] data) {
		// Channel offsets start at byte 2 (songDataOffset)
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