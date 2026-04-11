namespace Cryogenic.Mt32DriverDebug.ViewModels;

using Avalonia.Threading;

using CommunityToolkit.Mvvm.ComponentModel;

using Spice86.Core.Emulator.Memory.ReaderWriter;

using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;

/// <summary>
/// View model for the live MT-32 driver debug window.
/// Polls <see cref="DnmidDriverState"/> and <see cref="GameAudioState"/> via a
/// DispatcherTimer and exposes strongly-typed properties for AXAML data-binding.
/// </summary>
/// <remarks>
/// <para>
/// This ViewModel is always active regardless of whether the C# MT-32 overrides
/// are enabled. It reads directly from emulator memory through
/// <see cref="DnmidDriverState"/> and <see cref="GameAudioState"/>.
/// </para>
/// <para>
/// Timer lifecycle is tied to visual tree attachment: the timer starts when
/// <see cref="StartPolling"/> is called (on window Loaded) and stops when
/// <see cref="StopPolling"/> is called (on window Closed/Unloaded).
/// </para>
/// </remarks>
public sealed partial class Mt32DriverWindowViewModel : Mt32DebugViewModelBase, IDisposable {
	private readonly DnmidDriverState _driverState;
	private readonly GameAudioState _gameAudio;
	private DispatcherTimer _pollTimer;
	private const int MaxLogEntries = 500;
	private const int PollIntervalMs = 100;

	// Track state changes for logging
	private bool _lastIsPlaying;
	private byte _lastStatusFlags;
	private ushort _lastMeasure;
	private int _pollCount;

	// ── Export table names ──
	private static readonly string[] ExportNames = [
		"MidiInit", "MidiOpen", "MidiReset",
		"MidiSetTimerTickFlag", "MidiSetVelocityMapping",
		"MidiTick", "MidiSetVolume"
	];

	// ══════════════════════════════════════════════════════
	//  TAB 1: Song Position & Transport
	// ══════════════════════════════════════════════════════

	/// <summary>Current measure (1-based).</summary>
	[ObservableProperty]
	private string _measure = "-";

	/// <summary>Current subdivision (hex, counts down from 0x60).</summary>
	[ObservableProperty]
	private string _subdivision = "-";

	/// <summary>Loop repeat counter.</summary>
	[ObservableProperty]
	private string _repeatCounter = "-";

	/// <summary>Timer accumulator value (hex).</summary>
	[ObservableProperty]
	private string _timerAccumulator = "-";

	/// <summary>Timer low byte (hex).</summary>
	[ObservableProperty]
	private string _timerLow = "-";

	/// <summary>Whether the driver is currently playing.</summary>
	[ObservableProperty]
	private bool _isPlaying;

	/// <summary>Whether a volume fade is active.</summary>
	[ObservableProperty]
	private bool _isFading;

	/// <summary>Combined transport/position summary line.</summary>
	[ObservableProperty]
	private string _transportInfo = "Not initialized";

	// ══════════════════════════════════════════════════════
	//  TAB 2: Volume & Fade
	// ══════════════════════════════════════════════════════

	/// <summary>Current effective volume (0..127).</summary>
	[ObservableProperty]
	private int _currentVolume;

	/// <summary>Target volume for fade (0..127).</summary>
	[ObservableProperty]
	private int _targetVolume;

	/// <summary>Master volume set by game (0..127).</summary>
	[ObservableProperty]
	private int _masterVolume;

	/// <summary>Fade bit-rotation pattern raw value.</summary>
	[ObservableProperty]
	private ushort _fadeBitPatternRaw;

	/// <summary>Fade bit-rotation pattern (hex).</summary>
	[ObservableProperty]
	private string _fadeBitPattern = "0000";

	/// <summary>Volume hierarchy summary (Master -> Current -> Target).</summary>
	[ObservableProperty]
	private string _volumeHierarchy = "-";

	/// <summary>Per-MIDI-channel base volumes (10 channels).</summary>
	public ObservableCollection<ChannelVolumeBarViewModel> ChannelVolumes { get; } = new();

	/// <summary>Fade bit pattern visual cells (16 bits).</summary>
	public ObservableCollection<FadeBitCellViewModel> FadeBits { get; } = new();

	// ══════════════════════════════════════════════════════
	//  TAB 3: Driver Status & I/O
	// ══════════════════════════════════════════════════════

	/// <summary>Full status flags byte (hex).</summary>
	[ObservableProperty]
	private string _statusFlags = "00";

	/// <summary>Status flags decoded as individual bits.</summary>
	[ObservableProperty]
	private string _statusFlagsBinary = "00000000";

	/// <summary>Tick enable flag.</summary>
	[ObservableProperty]
	private string _tickFlag = "0";

	/// <summary>Number of active channels in the current song.</summary>
	[ObservableProperty]
	private int _activeChannelCount;

	/// <summary>MIDI base port (hex, typically 0x330).</summary>
	[ObservableProperty]
	private string _midiPort = "-";

	/// <summary>MIDI data port (base+0, hex).</summary>
	[ObservableProperty]
	private string _midiDataPort = "-";

	/// <summary>MIDI control/status port (base+1, hex).</summary>
	[ObservableProperty]
	private string _midiControlPort = "-";

	/// <summary>I/O delay value (hex).</summary>
	[ObservableProperty]
	private string _ioDelay = "-";

	// ══════════════════════════════════════════════════════
	//  TAB 4: Song Pointers & Header Cache
	// ══════════════════════════════════════════════════════

	/// <summary>Song stream far pointer (segment:offset).</summary>
	[ObservableProperty]
	private string _songStreamPointer = "-";

	/// <summary>Event stream far pointer (segment:offset).</summary>
	[ObservableProperty]
	private string _eventStreamPointer = "-";

	/// <summary>Cached Song SI from header.</summary>
	[ObservableProperty]
	private string _headerSongSI = "-";

	/// <summary>Cached Song ES from header.</summary>
	[ObservableProperty]
	private string _headerSongES = "-";

	/// <summary>Header marker 0 value.</summary>
	[ObservableProperty]
	private string _headerMarker0 = "-";

	/// <summary>Header marker 1 value.</summary>
	[ObservableProperty]
	private string _headerMarker1 = "-";

	/// <summary>Header marker 2 value.</summary>
	[ObservableProperty]
	private string _headerMarker2 = "-";

	/// <summary>File extension patch bytes (.M32).</summary>
	[ObservableProperty]
	private string _extensionPatch = "-";

	/// <summary>Calculated physical address of song data.</summary>
	[ObservableProperty]
	private string _songPhysicalAddress = "-";

	/// <summary>Calculated physical address of event stream.</summary>
	[ObservableProperty]
	private string _eventPhysicalAddress = "-";

	// ══════════════════════════════════════════════════════
	//  TAB 5: Game Audio State (DS globals)
	// ══════════════════════════════════════════════════════

	/// <summary>Audio driver mode argument (DS:0x2944).</summary>
	[ObservableProperty]
	private string _cmdArgsAudio = "-";

	/// <summary>MIDI configuration argument (DS:0x39B3).</summary>
	[ObservableProperty]
	private string _cmdArgMidi = "-";

	/// <summary>Sound hardware present flag (DS:0xDBCD).</summary>
	[ObservableProperty]
	private string _isSoundPresent = "-";

	/// <summary>MIDI func5 return BX (DS:0xDBCE).</summary>
	[ObservableProperty]
	private string _midiFunc5ReturnBx = "-";

	/// <summary>Allocator next free pointer (segment:offset).</summary>
	[ObservableProperty]
	private string _allocatorNextFree = "-";

	/// <summary>Allocator ceiling segment (DS:0xCE68).</summary>
	[ObservableProperty]
	private string _allocatorCeiling = "-";

	/// <summary>Driver segment constants summary.</summary>
	[ObservableProperty]
	private string _driverSegments = "VGA=D000  PCM=E000  MIDI=F000→5BAE  IRQ=0800";

	// ══════════════════════════════════════════════════════
	//  TAB 6: Export Table
	// ══════════════════════════════════════════════════════

	/// <summary>Driver export/jump table entries.</summary>
	public ObservableCollection<ExportEntryViewModel> ExportEntries { get; } = new();

	// ══════════════════════════════════════════════════════
	//  TAB 7: Memory Inspector
	// ══════════════════════════════════════════════════════

	/// <summary>Hex dump of driver state region (0x0115..0x0154).</summary>
	[ObservableProperty]
	private string _hexDumpState = "";

	/// <summary>Hex dump of channel arrays (0x0142..0x01AC).</summary>
	[ObservableProperty]
	private string _hexDumpChannels = "";

	/// <summary>Hex dump of export table (0x0000..0x0014).</summary>
	[ObservableProperty]
	private string _hexDumpExports = "";

	/// <summary>Hex dump of header cache region (0x0246..0x0250).</summary>
	[ObservableProperty]
	private string _hexDumpHeaderCache = "";

	// ══════════════════════════════════════════════════════
	//  Channel Tracker + Logs + Status
	// ══════════════════════════════════════════════════════

	/// <summary>Per-channel tracker rows.</summary>
	public ObservableCollection<DriverChannelRowViewModel> TrackerRows { get; } = new();

	/// <summary>Log entries.</summary>
	public ObservableCollection<DriverLogDisplayItem> Logs { get; } = new();

	/// <summary>Status bar text.</summary>
	[ObservableProperty]
	private string _statusText = "Waiting for DNMID driver to load...";

	/// <summary>Polls per second counter display.</summary>
	[ObservableProperty]
	private string _pollRate = "0 polls/s";

	/// <summary>
	/// Creates the ViewModel bound to emulator memory.
	/// </summary>
	/// <param name="memory">Emulated memory reader/writer from Machine.Memory.</param>
	/// <param name="driverSegment">The segment where DNMID driver is loaded (e.g. 0x5BAE).</param>
	public Mt32DriverWindowViewModel(IByteReaderWriter memory, ushort driverSegment) {
		_driverState = new DnmidDriverState(memory, driverSegment);
		_gameAudio = new GameAudioState(memory);
		_pollTimer = new DispatcherTimer(
			TimeSpan.FromMilliseconds(PollIntervalMs),
			DispatcherPriority.Background,
			OnPollTimerTick);
		_pollTimer.IsEnabled = false;

		for (int i = 0; i < DnmidDriverState.MaxChannels; i++) {
			TrackerRows.Add(new DriverChannelRowViewModel(i));
		}

		for (int i = 0; i < DnmidDriverState.MaxBaseVolumeChannels; i++) {
			ChannelVolumes.Add(new ChannelVolumeBarViewModel(i));
		}

		for (int i = 0; i < 16; i++) {
			FadeBits.Add(new FadeBitCellViewModel(i));
		}

		for (int i = 0; i < DnmidDriverState.ExportEntryCount; i++) {
			ExportEntries.Add(new ExportEntryViewModel(i, ExportNames[i]));
		}

		AddLog("MT-32 driver debug window initialized.");
	}

	/// <summary>
	/// Starts periodic polling. Call from window Loaded event.
	/// </summary>
	public void StartPolling() {
		if (!_pollTimer.IsEnabled) {
			_pollTimer.IsEnabled = true;
			AddLog("Polling started.");
		}
	}

	/// <summary>
	/// Stops periodic polling. Call from window Closed/Unloaded event.
	/// </summary>
	public void StopPolling() {
		if (_pollTimer.IsEnabled) {
			_pollTimer.IsEnabled = false;
			AddLog("Polling stopped.");
		}
	}

	/// <summary>
	/// Releases timer resources.
	/// </summary>
	public void Dispose() {
		_pollTimer.IsEnabled = false;
	}

	/// <summary>
	/// Timer callback that reads driver state and updates all bound properties.
	/// </summary>
	private void OnPollTimerTick(object? sender, EventArgs e) {
		try {
			_pollCount++;
			ReadSongPosition();
			ReadVolumeAndFade();
			ReadDriverStatus();
			ReadSongPointers();
			ReadGameAudioGlobals();
			ReadExportTable();
			ReadHexDumps();
			UpdateChannelTracker();
			DetectStateChanges();
			UpdateStatusBar();
		} catch (Exception ex) {
			StatusText = $"Read error: {ex}";
		}
	}

	/// <summary>
	/// Reads song position fields from driver memory.
	/// </summary>
	private void ReadSongPosition() {
		ushort measure = _driverState.Measure;
		ushort subdivision = _driverState.Subdivision;
		ushort repeat = _driverState.RepeatCounter;
		ushort timerAcc = _driverState.TimerAccumulator;
		byte timerLo = _driverState.TimerLow;

		Measure = measure.ToString(CultureInfo.InvariantCulture);
		Subdivision = $"0x{subdivision:X2}";
		RepeatCounter = repeat.ToString(CultureInfo.InvariantCulture);
		TimerAccumulator = $"0x{timerAcc:X4}";
		TimerLow = $"0x{timerLo:X2}";

		TransportInfo = $"Measure {measure}  Sub 0x{subdivision:X2}  Rep {repeat}  Acc 0x{timerAcc:X4}  Vol {_driverState.CurrentVolume}/{_driverState.MasterVolume}";
	}

	/// <summary>
	/// Reads volume and fade state from driver memory.
	/// </summary>
	private void ReadVolumeAndFade() {
		CurrentVolume = _driverState.CurrentVolume;
		TargetVolume = _driverState.TargetVolume;
		MasterVolume = _driverState.MasterVolume;

		ushort fadePattern = _driverState.FadeBitPattern;
		FadeBitPatternRaw = fadePattern;
		FadeBitPattern = $"0x{fadePattern:X4}";

		VolumeHierarchy = $"Master({_driverState.MasterVolume}) → Current({_driverState.CurrentVolume}) → Target({_driverState.TargetVolume})";

		for (int i = 0; i < DnmidDriverState.MaxBaseVolumeChannels; i++) {
			ChannelVolumes[i].Volume = _driverState.GetChannelBaseVolume(i);
		}

		for (int i = 0; i < 16; i++) {
			FadeBits[i].IsSet = (fadePattern & (1 << (15 - i))) != 0;
		}
	}

	/// <summary>
	/// Reads driver status flags and I/O configuration from memory.
	/// </summary>
	private void ReadDriverStatus() {
		byte statusByte = _driverState.StatusFlags;
		StatusFlags = $"0x{statusByte:X2}";
		StatusFlagsBinary = Convert.ToString(statusByte, 2).PadLeft(8, '0');
		IsPlaying = _driverState.IsPlaying;
		IsFading = _driverState.IsFading;
		TickFlag = _driverState.TickFlag.ToString(CultureInfo.InvariantCulture);
		ActiveChannelCount = _driverState.ActiveChannelCount;

		ushort port = _driverState.MidiBasePort;
		MidiPort = $"0x{port:X4}";
		MidiDataPort = $"0x{port:X4}";
		MidiControlPort = $"0x{(port + 1):X4}";
		IoDelay = $"0x{_driverState.IoDelay:X4}";
	}

	/// <summary>
	/// Reads song and event stream pointers plus header cache from memory.
	/// </summary>
	private void ReadSongPointers() {
		ushort songOff = _driverState.SongStreamOffset;
		ushort songSeg = _driverState.SongStreamSegment;
		ushort evtOff = _driverState.EventStreamOffset;
		ushort evtSeg = _driverState.EventStreamSegment;

		SongStreamPointer = $"{songSeg:X4}:{songOff:X4}";
		EventStreamPointer = $"{evtSeg:X4}:{evtOff:X4}";
		SongPhysicalAddress = $"0x{((uint)songSeg << 4) + songOff:X5}";
		EventPhysicalAddress = $"0x{((uint)evtSeg << 4) + evtOff:X5}";

		HeaderSongSI = $"0x{_driverState.HeaderSongSI:X4}";
		HeaderSongES = $"0x{_driverState.HeaderSongES:X4}";
		HeaderMarker0 = $"0x{_driverState.HeaderMarker0:X4}";
		HeaderMarker1 = $"0x{_driverState.HeaderMarker1:X4}";
		HeaderMarker2 = $"0x{_driverState.HeaderMarker2:X4}";

		byte b0 = _driverState.ExtensionPatchByte0;
		byte b1 = _driverState.ExtensionPatchByte1;
		byte b2 = _driverState.ExtensionPatchByte2;
		ExtensionPatch = $"{(char)b0}{(char)b1}{(char)b2}  (0x{b0:X2} 0x{b1:X2} 0x{b2:X2})";
	}

	/// <summary>
	/// Reads game-level audio globals from DS segment.
	/// </summary>
	private void ReadGameAudioGlobals() {
		CmdArgsAudio = $"0x{_gameAudio.CmdArgsAudio:X2}";
		CmdArgMidi = $"0x{_gameAudio.CmdArgMidi:X4}";
		IsSoundPresent = _gameAudio.IsSoundPresent != 0 ? $"Yes (0x{_gameAudio.IsSoundPresent:X2})" : "No";
		MidiFunc5ReturnBx = $"0x{_gameAudio.MidiFunc5ReturnBx:X4}";
		AllocatorNextFree = $"{_gameAudio.AllocatorNextFreeSegment:X4}:{_gameAudio.AllocatorNextFreeOffset:X4}";
		AllocatorCeiling = $"0x{_gameAudio.AllocatorLastFreeSegment:X4}";
	}

	/// <summary>
	/// Reads the 7-entry export/jump table from driver base.
	/// </summary>
	private void ReadExportTable() {
		for (int i = 0; i < DnmidDriverState.ExportEntryCount; i++) {
			ExportEntryViewModel entry = ExportEntries[i];
			byte opcode = _driverState.GetExportOpcode(i);
			ushort target = _driverState.GetExportJumpTarget(i);
			entry.Opcode = $"0x{opcode:X2}";
			entry.Target = $"0x{target:X4}";
			entry.ResolvedAddress = $"5BAE:{(i * 3 + 3 + target):X4}";
		}
	}

	/// <summary>
	/// Reads hex dumps of key memory regions.
	/// </summary>
	private void ReadHexDumps() {
		HexDumpState = FormatHexDump(0x0115, 0x40);
		HexDumpChannels = FormatHexDump(0x0142, 0x6C);
		HexDumpExports = FormatHexDump(0x0000, 0x15);
		HexDumpHeaderCache = FormatHexDump(0x0246, 0x0A);
	}

	/// <summary>
	/// Updates the 9-channel tracker rows from current driver state.
	/// </summary>
	private void UpdateChannelTracker() {
		int activeCount = Math.Min((int)_driverState.ActiveChannelCount, DnmidDriverState.MaxChannels);
		for (int i = 0; i < DnmidDriverState.MaxChannels; i++) {
			DriverChannelRowViewModel row = TrackerRows[i];
			if (i < activeCount) {
				ushort tick = _driverState.GetChannelTickCounter(i);
				bool parked = tick == 0xFFFF;
				row.TickCounter = $"{tick:X4}";
				row.EventPointer = $"{_driverState.GetChannelEventPointer(i):X4}";
				row.StartOffset = $"{_driverState.GetChannelStartOffset(i):X4}";
				row.BaseVolume = _driverState.GetChannelBaseVolume(i).ToString(CultureInfo.InvariantCulture);
				row.SnapshotWait = $"{_driverState.GetSnapshotWait(i):X4}";
				row.SnapshotPointer = $"{_driverState.GetSnapshotPointer(i):X4}";
				row.IsParked = parked;
				row.Status = parked ? "Parked" : "Active";
			} else {
				row.TickCounter = "----";
				row.EventPointer = "----";
				row.StartOffset = "----";
				row.BaseVolume = "---";
				row.SnapshotWait = "----";
				row.SnapshotPointer = "----";
				row.IsParked = true;
				row.Status = "Idle";
			}
		}
	}

	/// <summary>
	/// Detects state transitions and logs them.
	/// </summary>
	private void DetectStateChanges() {
		byte currentFlags = _driverState.StatusFlags;
		bool currentPlaying = _driverState.IsPlaying;
		ushort currentMeasure = _driverState.Measure;

		if (currentPlaying != _lastIsPlaying) {
			AddLog(currentPlaying ? "Playback STARTED" : "Playback STOPPED");
			_lastIsPlaying = currentPlaying;
		}

		if (currentFlags != _lastStatusFlags && _lastStatusFlags != 0) {
			AddLog($"Status flags changed: 0x{_lastStatusFlags:X2} → 0x{currentFlags:X2}");
			_lastStatusFlags = currentFlags;
		}
		_lastStatusFlags = currentFlags;

		if (currentMeasure != _lastMeasure && currentMeasure > 0 && _lastMeasure > 0 && currentMeasure < _lastMeasure) {
			AddLog($"Song looped: measure {_lastMeasure} → {currentMeasure}");
		}
		_lastMeasure = currentMeasure;
	}

	/// <summary>
	/// Updates the status bar at the bottom of the window.
	/// </summary>
	private void UpdateStatusBar() {
		int activeCount = Math.Min((int)_driverState.ActiveChannelCount, DnmidDriverState.MaxChannels);
		byte statusByte = _driverState.StatusFlags;

		if (IsPlaying) {
			StatusText = $"Playing — {activeCount} channels active — Port {MidiPort}";
		} else if (statusByte != 0) {
			StatusText = $"Driver loaded — Status 0x{statusByte:X2} — Port {MidiPort}";
		} else {
			StatusText = $"Idle — Port {MidiPort}";
		}

		PollRate = $"{_pollCount * (1000 / PollIntervalMs) / Math.Max(_pollCount, 1)} polls/s";
	}

	/// <summary>
	/// Formats a hex dump of driver memory at the given offset and length.
	/// </summary>
	/// <param name="startOffset">CS-relative start offset.</param>
	/// <param name="length">Number of bytes to dump.</param>
	/// <returns>Formatted hex dump string.</returns>
	private string FormatHexDump(uint startOffset, int length) {
		StringBuilder sb = new();
		for (int row = 0; row < length; row += 16) {
			sb.Append($"{(startOffset + row):X4}: ");
			int cols = Math.Min(16, length - row);
			for (int col = 0; col < cols; col++) {
				sb.Append($"{_driverState.GetRawByte(startOffset + (uint)(row + col)):X2} ");
			}
			sb.AppendLine();
		}
		return sb.ToString();
	}

	/// <summary>
	/// Adds a timestamped log entry to the Logs collection.
	/// </summary>
	/// <param name="message">Log message text.</param>
	public void AddLog(string message) {
		string timestamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
		DriverLogDisplayItem item = new() {
			Timestamp = timestamp,
			Message = message,
		};
		Logs.Add(item);
		while (Logs.Count > MaxLogEntries) {
			Logs.RemoveAt(0);
		}
	}
}