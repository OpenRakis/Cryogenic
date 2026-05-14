namespace Cryogenic.AdgPlayer.Ui.ViewModels;

using Avalonia.Controls;
using Avalonia.Platform.Storage;
using Avalonia.Threading;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Cryogenic.AdgPlayer.Ui.Logging;
using Cryogenic.AdgPlayer.Ui.Services;
using Cryogenic.AdgPlayer.Ui.Views;

using Serilog;

using System;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading;

/// <summary>
/// Main window view model: manages file loading, playback, volume, waveform,
/// channel events, OPL writes, and Serilog log display for the standalone ADG player UI.
/// </summary>
public sealed partial class MainWindowViewModel : ViewModelBase, IDisposable {
	private static readonly ILogger Logger = Log.ForContext<MainWindowViewModel>();

	private static readonly string[] DefaultDuneDatCandidates = [
		@"C:\Users\noalm\source\repos\Cryogenic\doc\DUNECDVF\C\DUNE.DAT",
		@"C:\Users\noalm\source\repos\Cryogenic\doc\DUNECDVF\C\DUNECD\DUNE.DAT",
	];

	private readonly Window _window;
	private DuneAdgPlayerEngine _engine;
	private WaveformControl _waveformControl;
	private VolumeFeedbackControl _volumeFeedbackControl;
	private readonly DispatcherTimer _statusTimer;
	private string _loadedPath = "";
	private int _playlistIndex = -1;
	private PlaylistItem? _currentlyPlayingTrack = null;
	private string _defaultDuneDatPath = "";
	private DuneDatReader? _duneDatReader;

	// Thread-safe queues used to throttle render-thread → UI thread bridging.
	private readonly ConcurrentQueue<OplWriteItem> _oplWritesQueue = new();
	private readonly ConcurrentQueue<ChannelEventItem> _channelEventsQueue = new();
	private long _totalOplWritesCount;
	private long _totalChannelEventsCount;
	private const int MaxUiOplWritesPerTick = 40;
	private const int MaxUiChannelEventsPerTick = 40;
	private const int MaxOplWritesPanelRows = 500;
	private const int MaxChannelEventsPanelRows = 500;
	private const int MaxBackpressureQueueDepth = 4000;

	[ObservableProperty]
	private string _adgPath = "";

	[ObservableProperty]
	private string _status = "Select an ADG/HSQ file to play.";

	[ObservableProperty]
	private string _driverIdentityText = "Driver identity: ADG UI shell (DNADP-compatible playback core) | ADG core proof source: Cryogenic.AdgPlayer + MCP runtime.";

	[ObservableProperty]
	private string _liveProofText = "Live proof: idle";

	[ObservableProperty]
	private bool _isPlaying;

	[ObservableProperty]
	private bool _isPaused;

	[ObservableProperty]
	private string _tickInfo = "Idle";

	// --- Volume controls ---

	[ObservableProperty]
	private int _masterVolume = 200;

	[ObservableProperty]
	private int _oplVolume = 150;

	[ObservableProperty]
	private string _selectedFileName = "No file selected";

	// --- Position/time ---

	[ObservableProperty]
	private string _positionText = "00:00.0 / Measure 0";

	// --- Header info ---

	[ObservableProperty]
	private string _headerInfo = "No song loaded.";

	// --- Volume feedback ---

	[ObservableProperty]
	private string _volumeInfo = "Master: 0 dB  |  OPL: 1.5x  |  Driver: --";

	// --- Channel state ---

	[ObservableProperty]
	private string _channelStateText = "";

	[ObservableProperty]
	private PlaylistItem? _selectedPlaylistItem;

	/// <summary>Channel events shown in the UI.</summary>
	public ObservableCollection<ChannelEventItem> ChannelEvents { get; } = new();

	/// <summary>OPL register writes shown in the UI.</summary>
	public ObservableCollection<OplWriteItem> OplWrites { get; } = new();

	/// <summary>Log entries shown in the UI log panel.</summary>
	public ObservableCollection<LogDisplayItem> Logs { get; } = new();

	/// <summary>Playlist entries shown in the UI.</summary>
	public ObservableCollection<PlaylistItem> Playlist { get; } = new();

	/// <summary>
	/// Creates the view model, wires the Serilog UI sink.
	/// </summary>
	public MainWindowViewModel(Window window) {
		_window = window;
		_waveformControl = new WaveformControl();
		_volumeFeedbackControl = new VolumeFeedbackControl();
		_engine = new DuneAdgPlayerEngine();

		WireSerilogSink();
		WireEngineEvents();

		_statusTimer = new DispatcherTimer {
			Interval = TimeSpan.FromMilliseconds(100)
		};
		_statusTimer.Tick += (_, _) => RefreshTransportState();
		_statusTimer.Start();

		InitializePlaylistFromDefaultDuneDat();

		// Set default file name
		if (File.Exists(AdgPath)) {
			SelectedFileName = Path.GetFileName(AdgPath);
			Status = "Default file found. Press Play.";
		}

		Logger.Information("ADG UI ready. Branding=ADG/AdLibGold/OPL3Gold proof mode, OPL gain={OplGain:F1}x, tick rate={TickRate:F1} Hz",
			_engine.OplVolumeGain, _engine.TickRateHz);
		Logger.Information("ADG core proof markers: DuneAdgPlayerEngine(ChannelCountConst=18, PIT=0x1745), AdgOplSynthesizer dual-bank writes (chip0/chip1), SoftwareMixer pipeline.");
		UpdateLiveProofText();
	}

	/// <summary>
	/// Called by MainWindow code-behind to link the waveform control instance.
	/// </summary>
	public void RegisterWaveformControl(WaveformControl control) {
		_waveformControl = control;
	}

	/// <summary>
	/// Called by MainWindow code-behind to link the volume feedback control instance.
	/// </summary>
	public void RegisterVolumeFeedbackControl(VolumeFeedbackControl control) {
		_volumeFeedbackControl = control;
	}

	/// <inheritdoc />
	public void Dispose() {
		ObservableSerilogSink.Instance.LogReceived -= OnSerilogMessage;
		_statusTimer.Stop();
		_engine.ChannelEventDispatched -= OnChannelEvent;
		_engine.OplRegisterWritten -= OnOplWrite;
		_engine.Dispose();
	}

	partial void OnMasterVolumeChanged(int value) {
		float gain = Math.Clamp(value, 0, 255) / 255f;
		_engine.SetOutputGain(gain);
		UpdateVolumeInfo();
	}

	partial void OnOplVolumeChanged(int value) {
		float gain = Math.Clamp(value, 0, 300) / 100f;
		_engine.SetOplVolumeGain(gain);
		UpdateVolumeInfo();
	}

	/// <summary>
	/// Opens a file picker for ADG/HSQ files.
	/// </summary>
	[RelayCommand]
	private async System.Threading.Tasks.Task BrowseFileAsync() {
		if (_window.StorageProvider is null) {
			return;
		}

		System.Collections.Generic.IReadOnlyList<IStorageFile> picked =
			await _window.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions {
				Title = "Select ADG/HSQ music file",
				AllowMultiple = true,
				FileTypeFilter = [
					new FilePickerFileType("Dune Music") { Patterns = ["*.AGD", "*.ADG", "*.HSQ", "*.ADP", "*.agd", "*.adg", "*.hsq", "*.adp"] },
					new FilePickerFileType("All files") { Patterns = ["*"] }
				]
			});

		if (picked.Count > 0) {
			for (int i = 0; i < picked.Count; i++) {
				AddPlaylistPath(picked[i].Path.LocalPath);
			}

			AdgPath = picked[0].Path.LocalPath;
			SelectedFileName = Path.GetFileName(AdgPath);
			for (int i = 0; i < Playlist.Count; i++) {
				if (string.Equals(Playlist[i].Path, AdgPath, StringComparison.OrdinalIgnoreCase)) {
					_playlistIndex = i;
					SelectedPlaylistItem = Playlist[i];
					break;
				}
			}
			UpdateAllPlaylistDisplays();
		}
	}

	/// <summary>
	/// Adds one or more music files to the playlist.
	/// </summary>
	[RelayCommand]
	private async System.Threading.Tasks.Task BrowsePlaylistFilesAsync() {
		if (_window.StorageProvider is null) {
			return;
		}

		System.Collections.Generic.IReadOnlyList<IStorageFile> picked =
			await _window.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions {
				Title = "Add songs to playlist",
				AllowMultiple = true,
				FileTypeFilter = [
					new FilePickerFileType("Dune Music") { Patterns = ["*.AGD", "*.ADG", "*.HSQ", "*.ADP", "*.agd", "*.adg", "*.hsq", "*.adp"] },
					new FilePickerFileType("All files") { Patterns = ["*"] }
				]
			});

		if (picked.Count == 0) {
			return;
		}

		for (int i = 0; i < picked.Count; i++) {
			string path = picked[i].Path.LocalPath;
			AddPlaylistPath(path);
		}

		if (SelectedPlaylistItem is null && Playlist.Count > 0) {
			SelectedPlaylistItem = Playlist[0];
			_playlistIndex = 0;
		}
		UpdateAllPlaylistDisplays();
	}

	[RelayCommand]
	private void PlaySelectedTrack() {
		if (SelectedPlaylistItem is null) {
			return;
		}
		for (int i = 0; i < Playlist.Count; i++) {
			if (ReferenceEquals(Playlist[i], SelectedPlaylistItem)) {
				_playlistIndex = i;
				break;
			}
		}

		AdgPath = SelectedPlaylistItem.Path;
		SelectedFileName = SelectedPlaylistItem.FileName;
		Play();
	}

	[RelayCommand]
	private void NextTrack() {
		if (Playlist.Count == 0) {
			return;
		}
		int nextIndex = _playlistIndex + 1;
		if (nextIndex >= Playlist.Count) {
			nextIndex = 0;
		}
		PlayPlaylistIndex(nextIndex);
	}

	[RelayCommand]
	private void PreviousTrack() {
		if (Playlist.Count == 0) {
			return;
		}
		int previousIndex = _playlistIndex - 1;
		if (previousIndex < 0) {
			previousIndex = Playlist.Count - 1;
		}
		PlayPlaylistIndex(previousIndex);
	}

	[RelayCommand]
	private void RemoveSelectedTrack() {
		if (SelectedPlaylistItem is null) {
			return;
		}
		int removedIndex = -1;
		for (int i = 0; i < Playlist.Count; i++) {
			if (ReferenceEquals(Playlist[i], SelectedPlaylistItem)) {
				removedIndex = i;
				break;
			}
		}
		if (removedIndex < 0) {
			return;
		}
		Playlist.RemoveAt(removedIndex);
		UpdateAllPlaylistDisplays();
		if (Playlist.Count == 0) {
			SelectedPlaylistItem = null;
			_playlistIndex = -1;
			return;
		}
		if (_playlistIndex > removedIndex) {
			_playlistIndex--;
		}
		if (_playlistIndex >= Playlist.Count) {
			_playlistIndex = Playlist.Count - 1;
		}
		SelectedPlaylistItem = Playlist[Math.Max(0, Math.Min(removedIndex, Playlist.Count - 1))];
	}

	[RelayCommand]
	private void ClearPlaylist() {
		Playlist.Clear();
		SelectedPlaylistItem = null;
		_playlistIndex = -1;
	}

	/// <summary>
	/// Loads the selected file into the driver without starting playback.
	/// </summary>
	[RelayCommand]
	private void Load() {
		if (!TryLoadSelectedFile()) {
			return;
		}

		Status = "Loaded.";
	}

	/// <summary>
	/// Loads and plays the selected file.
	/// </summary>
	[RelayCommand]
	private void Play() {
		try {
			if (_engine.IsPaused) {
				_engine.Resume();
				RefreshTransportState();
				Status = "Playing.";
				return;
			}

			if (_engine.IsPlaying) {
				_engine.Stop();
			}

			// If a playlist item is selected, play that; otherwise use AdgPath
			string fileToPlay = AdgPath;
			if (SelectedPlaylistItem is not null) {
				fileToPlay = SelectedPlaylistItem.Path;
				for (int i = 0; i < Playlist.Count; i++) {
					if (ReferenceEquals(Playlist[i], SelectedPlaylistItem)) {
						_playlistIndex = i;
						break;
					}
				}
			}

			if (_loadedPath != fileToPlay) {
				AdgPath = fileToPlay;
				if (!TryLoadSelectedFile()) {
					return;
				}
			}

			ClearUiEventQueuesAndCollections();
			_engine.Play();
			RefreshTransportState();
			Status = "Playing.";
			Logger.Information("Playing {File}", Path.GetFileName(AdgPath));

			// Update currently playing track visual indicator
			UpdateCurrentlyPlayingTrack();
		} catch (Exception ex) {
			Status = $"Play failed: {ex.Message}";
			Logger.Error(ex, "Play failed");
			RefreshTransportState();
		}
	}

	/// <summary>
	/// Pauses playback while preserving the current song state.
	/// </summary>
	[RelayCommand]
	private void Pause() {
		_engine.Pause();
		RefreshTransportState();
		if (IsPaused) {
			Status = "Paused.";
		}
	}

	/// <summary>
	/// Stops playback.
	/// </summary>
	[RelayCommand]
	private void Stop() {
		_engine.Stop();
		RefreshTransportState();
		Status = "Stopped.";
	}

	private void WireEngineEvents() {
		_engine.SongFinished += () => {
			Dispatcher.UIThread.Post(() => {
				RefreshTransportState();
				Status = "Finished.";
				TryAutoAdvancePlaylist();
			});
		};

		_engine.AudioSamplesRendered += OnAudioSamplesRendered;
		_engine.ChannelEventDispatched += OnChannelEvent;
		_engine.OplRegisterWritten += OnOplWrite;
	}

	private void OnAudioSamplesRendered(float[] samples, int count) {
		_waveformControl.PushSamples(samples, count);
		_volumeFeedbackControl.PushSamples(samples, count);
	}

	private void InitializePlaylistFromDefaultDuneDat() {
		_defaultDuneDatPath = ResolveDefaultDuneDatPath();
		if (!File.Exists(_defaultDuneDatPath)) {
			Status = "DUNE.DAT not found. Browse files to build playlist.";
			Logger.Warning("DUNE.DAT not found at any default candidate path.");
			return;
		}

		try {
			byte[] datBytes = File.ReadAllBytes(_defaultDuneDatPath);
			Logger.Information("DUNE.DAT loaded in memory: {Path} ({Bytes:N0} bytes)", _defaultDuneDatPath, datBytes.Length);
			_duneDatReader = new DuneDatReader(datBytes);
			Logger.Information("DUNE.DAT in-memory reader parsed {Count} archive entries (no disk extraction).", _duneDatReader.Entries.Count);
		} catch (Exception ex) {
			Status = $"DUNE.DAT parse failed: {ex.Message}";
			Logger.Error(ex, "Failed to parse DUNE.DAT in memory.");
			return;
		}

		System.Collections.Generic.IReadOnlyList<DuneDatReader.DatEntry> musicEntries = DiscoverMusicEntries(_duneDatReader);
		for (int i = 0; i < musicEntries.Count; i++) {
			DuneDatReader.DatEntry entry = musicEntries[i];
			byte[] payload = _duneDatReader.ReadEntryBytes(entry);
			AddPlaylistFromDatEntry(entry.Name, payload);
		}

		if (Playlist.Count == 0) {
			Status = "No music files discovered inside DUNE.DAT.";
			Logger.Warning("No music entries with HSQ+M32 pair discovered inside DUNE.DAT.");
			return;
		}

		SelectedPlaylistItem = Playlist[0];
		_playlistIndex = 0;
		AdgPath = Playlist[0].Path;
		SelectedFileName = Playlist[0].FileName;
		UpdateAllPlaylistDisplays();
		Status = $"Loaded {Playlist.Count} songs in-memory from DUNE.DAT.";
		Logger.Information("Auto playlist from DUNE.DAT (in-memory): {Count} tracks.", Playlist.Count);
	}

	private static string ResolveDefaultDuneDatPath() {
		for (int i = 0; i < DefaultDuneDatCandidates.Length; i++) {
			string candidate = DefaultDuneDatCandidates[i];
			if (File.Exists(candidate)) {
				return candidate;
			}
		}
		return DefaultDuneDatCandidates[0];
	}

	private static System.Collections.Generic.IReadOnlyList<DuneDatReader.DatEntry> DiscoverMusicEntries(DuneDatReader reader) {
		// Music payloads in DUNE.DAT are HSQ files that have a sibling M32 entry
		// (the General-MIDI version of the same song); use that as the strong rule
		// for music identification, archive-wide, without filesystem extraction.
		System.Collections.Generic.HashSet<string> m32BaseNames = new(StringComparer.OrdinalIgnoreCase);
		for (int i = 0; i < reader.Entries.Count; i++) {
			string name = reader.Entries[i].Name;
			if (name.EndsWith(".M32", StringComparison.OrdinalIgnoreCase)) {
				m32BaseNames.Add(name.Substring(0, name.Length - 4));
			}
		}

		System.Collections.Generic.List<DuneDatReader.DatEntry> result = new();
		for (int i = 0; i < reader.Entries.Count; i++) {
			DuneDatReader.DatEntry entry = reader.Entries[i];
			if (!entry.Name.EndsWith(".HSQ", StringComparison.OrdinalIgnoreCase)) {
				continue;
			}
			string baseName = entry.Name.Substring(0, entry.Name.Length - 4);
			if (m32BaseNames.Contains(baseName)) {
				result.Add(entry);
			}
		}

		result.Sort((a, b) => StringComparer.OrdinalIgnoreCase.Compare(a.Name, b.Name));
		return result;
	}

	private void AddPlaylistFromDatEntry(string name, byte[] bytes) {
		string syntheticPath = "dat://DUNE.DAT/" + name;
		for (int i = 0; i < Playlist.Count; i++) {
			if (string.Equals(Playlist[i].Path, syntheticPath, StringComparison.OrdinalIgnoreCase)) {
				return;
			}
		}
		PlaylistItem item = new PlaylistItem {
			Path = syntheticPath,
			Bytes = bytes,
			SourceName = name,
		};
		Playlist.Add(item);
		UpdatePlaylistItemDisplay(item, Playlist.Count);
		ExtractHeaderInfoForPlaylistItem(item);
	}

	// IMPORTANT: these handlers are called on the SoftwareMixer render thread
	// at OPL-render cadence (many thousands per second). We must never call
	// Dispatcher.UIThread.Post for each one — that floods the dispatcher and
	// freezes the UI. Instead we enqueue lock-free and let RefreshTransportState
	// (running on the UI thread at 100 ms) flush a bounded batch each tick.
	private void OnChannelEvent(int channel, string eventType, string detail, long tick) {
		ChannelEventItem item = new ChannelEventItem {
			Channel = channel,
			EventType = eventType,
			Detail = detail,
			Tick = tick,
		};
		_channelEventsQueue.Enqueue(item);
		Interlocked.Increment(ref _totalChannelEventsCount);
		DrainBackpressure(_channelEventsQueue);
	}

	private void OnOplWrite(ushort register, byte value, long tick) {
		OplWriteItem item = new OplWriteItem {
			Register = register,
			Value = value,
			Tick = tick,
		};
		_oplWritesQueue.Enqueue(item);
		Interlocked.Increment(ref _totalOplWritesCount);
		DrainBackpressure(_oplWritesQueue);
	}

	private static void DrainBackpressure<T>(ConcurrentQueue<T> queue) {
		while (queue.Count > MaxBackpressureQueueDepth) {
			queue.TryDequeue(out _);
		}
	}

	private void FlushUiEventQueues() {
		int addedOpl = 0;
		while (addedOpl < MaxUiOplWritesPerTick && _oplWritesQueue.TryDequeue(out OplWriteItem? oplItem)) {
			OplWrites.Add(oplItem);
			addedOpl++;
		}
		while (OplWrites.Count > MaxOplWritesPanelRows) {
			OplWrites.RemoveAt(0);
		}

		int addedCh = 0;
		while (addedCh < MaxUiChannelEventsPerTick && _channelEventsQueue.TryDequeue(out ChannelEventItem? chItem)) {
			ChannelEvents.Add(chItem);
			addedCh++;
		}
		while (ChannelEvents.Count > MaxChannelEventsPanelRows) {
			ChannelEvents.RemoveAt(0);
		}
	}

	private void ClearUiEventQueuesAndCollections() {
		while (_oplWritesQueue.TryDequeue(out _)) { }
		while (_channelEventsQueue.TryDequeue(out _)) { }
		Interlocked.Exchange(ref _totalOplWritesCount, 0);
		Interlocked.Exchange(ref _totalChannelEventsCount, 0);
		ChannelEvents.Clear();
		OplWrites.Clear();
	}

	private void WireSerilogSink() {
		ObservableSerilogSink sink = ObservableSerilogSink.Instance;
		sink.LogReceived += OnSerilogMessage;
		foreach (string line in sink.DrainAll()) {
			AddLog(line);
		}
	}

	private void OnSerilogMessage(string message) {
		Dispatcher.UIThread.Post(() => AddLog(message));
	}

	private void AddLog(string message) {
		string timestamp = DateTime.Now.ToString("HH:mm:ss");
		LogDisplayItem item = new() {
			Timestamp = timestamp,
			Message = message,
		};
		Logs.Add(item);
		while (Logs.Count > 600) {
			Logs.RemoveAt(0);
		}
	}

	private bool TryLoadSelectedFile() {
		if (string.IsNullOrWhiteSpace(AdgPath)) {
			Status = "Select a file first.";
			return false;
		}

		// If the active playlist item carries in-memory bytes (e.g. lifted from DUNE.DAT),
		// feed them directly to the engine — no disk I/O, no extraction folder, no HSQ decompression here.
		if (SelectedPlaylistItem is not null
			&& SelectedPlaylistItem.Bytes is not null
			&& string.Equals(SelectedPlaylistItem.Path, AdgPath, StringComparison.OrdinalIgnoreCase)) {
			try {
				_engine.LoadSong(SelectedPlaylistItem.Bytes);
				_loadedPath = SelectedPlaylistItem.Path;
				SelectedFileName = SelectedPlaylistItem.FileName;
				UpdateHeaderInfo();
				Logger.Information("Loaded in-memory {File} ({Bytes} bytes) from DUNE.DAT", SelectedFileName, SelectedPlaylistItem.Bytes.Length);
				return true;
			} catch (Exception ex) {
				Status = $"Load failed: {ex.Message}";
				Logger.Error(ex, "In-memory load failed for {File}", SelectedPlaylistItem.FileName);
				return false;
			}
		}

		string resolvedPath = ResolveAdpCompatiblePath(AdgPath);
		if (!File.Exists(resolvedPath)) {
			Status = "Selected file does not exist.";
			return false;
		}

		try {
			return TryLoadPath(resolvedPath);
		} catch (Exception ex) {
			Status = $"Load failed: {ex.Message}";
			Logger.Error(ex, "Load failed");
			return false;
		}
	}

	private bool TryLoadPath(string path) {
		if (string.IsNullOrWhiteSpace(path)) {
			return false;
		}

		string resolvedPath = ResolveAdpCompatiblePath(path);
		if (!File.Exists(resolvedPath)) {
			Status = "Selected file does not exist.";
			return false;
		}
		try {
			if (!string.Equals(path, resolvedPath, StringComparison.OrdinalIgnoreCase)) {
				Logger.Information("Source remapped to compatible HSQ payload: {Requested} -> {Resolved}", Path.GetFileName(path), Path.GetFileName(resolvedPath));
			}

			byte[] raw = File.ReadAllBytes(resolvedPath);
			_engine.LoadSong(raw);
			_loadedPath = resolvedPath;
			AdgPath = resolvedPath;
			SelectedFileName = Path.GetFileName(resolvedPath);
			UpdateHeaderInfo();
			Logger.Information("Loaded {File}", SelectedFileName);
			return true;
		} catch (Exception ex) {
			Status = $"Load failed: {ex.Message}";
			Logger.Error(ex, "Load failed");
			return false;
		}
	}

	private void AddPlaylistPath(string path) {
		if (string.IsNullOrWhiteSpace(path)) {
			return;
		}

		string resolvedPath = ResolveAdpCompatiblePath(path);
		if (!File.Exists(resolvedPath)) {
			return;
		}
		for (int i = 0; i < Playlist.Count; i++) {
			if (string.Equals(Playlist[i].Path, resolvedPath, StringComparison.OrdinalIgnoreCase)) {
				return;
			}
		}
		PlaylistItem item = new PlaylistItem { Path = resolvedPath };
		Playlist.Add(item);
		UpdatePlaylistItemDisplay(item, Playlist.Count);
		ExtractHeaderInfoForPlaylistItem(item);
	}

	private static string ResolveAdpCompatiblePath(string requestedPath) {
		if (string.IsNullOrWhiteSpace(requestedPath)) {
			return requestedPath;
		}

		string extension = Path.GetExtension(requestedPath);
		if (!string.Equals(extension, ".AGD", StringComparison.OrdinalIgnoreCase)
			&& !string.Equals(extension, ".ADG", StringComparison.OrdinalIgnoreCase)) {
			return requestedPath;
		}

		string? directory = Path.GetDirectoryName(requestedPath);
		if (string.IsNullOrWhiteSpace(directory)) {
			return requestedPath;
		}

		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(requestedPath);
		string hsqCandidate = Path.Combine(directory, fileNameWithoutExtension + ".HSQ");
		if (File.Exists(hsqCandidate)) {
			return hsqCandidate;
		}

		return requestedPath;
	}

	private void PlayPlaylistIndex(int index) {
		if (index < 0 || index >= Playlist.Count) {
			return;
		}
		_playlistIndex = index;
		SelectedPlaylistItem = Playlist[index];
		AdgPath = SelectedPlaylistItem.Path;
		SelectedFileName = SelectedPlaylistItem.FileName;
		Play();
		UpdateCurrentlyPlayingTrack();
	}

	private void TryAutoAdvancePlaylist() {
		if (Playlist.Count == 0) {
			return;
		}
		int currentIndex = _playlistIndex;
		if (currentIndex < 0 && !string.IsNullOrWhiteSpace(_loadedPath)) {
			for (int i = 0; i < Playlist.Count; i++) {
				if (string.Equals(Playlist[i].Path, _loadedPath, StringComparison.OrdinalIgnoreCase)) {
					currentIndex = i;
					break;
				}
			}
		}
		if (currentIndex < 0) {
			return;
		}
		int nextIndex = currentIndex + 1;
		if (nextIndex >= Playlist.Count) {
			Status = "Finished playlist.";
			return;
		}
		PlayPlaylistIndex(nextIndex);
	}

	private void UpdateHeaderInfo() {
		SongHeaderInfo? header = _engine.HeaderInfo;
		if (header == null) {
			HeaderInfo = "No header.";
			return;
		}

		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"File: {SelectedFileName}  ({header.RawFileSize} bytes{(header.WasHsqCompressed ? ", HSQ compressed" : ", raw")})");
		sb.AppendLine($"Data @{header.DataBase}  Events @0x{header.EventBase:X4}  Tempo=0x{header.Tempo:X4}  Instruments={header.InstrumentCount}");
		sb.AppendLine($"Channels: {header.ActiveChannelCount}/9 active  Loop: measure {header.LoopStartMeasure}→{header.LoopEndMeasure} x{header.LoopCount}");
		sb.Append("Offsets: ");
		for (int i = 0; i < 9; i++) {
			if (header.ChannelActive[i]) {
				sb.Append($"Ch{i}=0x{header.ChannelOffsets[i]:X4} ");
			} else {
				sb.Append($"Ch{i}=-- ");
			}
		}
		HeaderInfo = sb.ToString();
	}

	private void UpdateVolumeInfo() {
		float masterGain = Math.Clamp(MasterVolume, 0, 255) / 255f;
		float oplGain = Math.Clamp(OplVolume, 0, 300) / 100f;
		float combinedDb = masterGain * oplGain > 0 ? 20f * MathF.Log10(masterGain * oplGain) : -100f;
		VolumeInfo = $"Master: {masterGain:P0}  |  OPL: {oplGain:F2}x  |  Combined: {combinedDb:F1} dB  |  Driver vol: 0x{_engine.CurrentDriverVolume:X2}→0x{_engine.TargetDriverVolume:X2}";
	}

	private void RefreshTransportState() {
		FlushUiEventQueues();

		IsPlaying = _engine.IsPlaying;
		IsPaused = _engine.IsPaused;

		string transportState = IsPlaying ? "▶ Playing" : IsPaused ? "⏸ Paused" : "■ Idle";
		double elapsed = _engine.ElapsedSeconds;
		int minutes = (int)(elapsed / 60);
		double seconds = elapsed % 60;
		PositionText = $"{minutes:D2}:{seconds:05.1f}  |  Measure {_engine.CurrentMeasure}  Sub {_engine.CurrentSubdivision:X2}  |  Tick {_engine.TotalTickCount}";
		TickInfo = $"{transportState}  |  {_engine.TickRateHz:F1} Hz  |  {_engine.SampleRate} Hz";

		UpdateVolumeInfo();
		UpdateChannelState();
		UpdateLiveProofText();
	}

	private void UpdateLiveProofText() {
		string transportState = IsPlaying ? "playing" : IsPaused ? "paused" : "idle";
		long totalOpl = Interlocked.Read(ref _totalOplWritesCount);
		long totalCh = Interlocked.Read(ref _totalChannelEventsCount);
		string source = _duneDatReader is null ? "file" : "DUNE.DAT in-memory";
		LiveProofText = $"Live proof: state={transportState} | track={SelectedFileName} | source={source} | channelEvents={totalCh} | oplWrites={totalOpl} | UI engine channels=9 (DNADP lineage) | ADG core channels=18 (DNADG/AdLib Gold).";
	}

	private void UpdateChannelState() {
		if (!_engine.IsPlaying && !_engine.IsPaused) {
			ChannelStateText = "";
			return;
		}

		ChannelSnapshot[] snapshots = _engine.GetChannelSnapshots();
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < snapshots.Length; i++) {
			ChannelSnapshot s = snapshots[i];
			string active = s.IsActive ? "●" : "○";
			string inst = s.Instrument == 0xFF ? "--" : $"{s.Instrument:X2}";
			string freq = s.Frequency > 0 ? $"F={s.Frequency:X4}" : "F=----";
			sb.Append($"{active} Ch{i}: {s.NoteName,-4} I={inst} {freq} W={s.Wait:X4}");
			if (i < snapshots.Length - 1) {
				sb.Append("  |  ");
			}
		}
		ChannelStateText = sb.ToString();
	}

	private void UpdateCurrentlyPlayingTrack() {
		if (_currentlyPlayingTrack is not null) {
			_currentlyPlayingTrack.IsCurrentTrack = false;
		}

		if (_playlistIndex >= 0 && _playlistIndex < Playlist.Count) {
			_currentlyPlayingTrack = Playlist[_playlistIndex];
			_currentlyPlayingTrack.IsCurrentTrack = true;
		}
	}

	private void UpdatePlaylistItemDisplay(PlaylistItem item, int trackNumber) {
		item.Display = $"[{trackNumber:D2}] {item.FileName}";
	}

	private void UpdateAllPlaylistDisplays() {
		for (int i = 0; i < Playlist.Count; i++) {
			UpdatePlaylistItemDisplay(Playlist[i], i + 1);
		}
	}

	private void ExtractHeaderInfoForPlaylistItem(PlaylistItem item) {
		try {
			byte[] raw = item.Bytes ?? File.ReadAllBytes(item.Path);
			if (DuneAdgPlayerEngine.TryExtractHeaderInfo(raw, out SongHeaderInfo? headerInfo) && headerInfo is not null) {
				StringBuilder tooltip = new StringBuilder();
				tooltip.AppendLine($"File: {item.FileName}");
				tooltip.AppendLine($"Size: {headerInfo.RawFileSize} bytes ({(headerInfo.WasHsqCompressed ? "HSQ compressed" : "raw")})");
				tooltip.AppendLine($"Data @0x{headerInfo.DataBase:X4}  Events @0x{headerInfo.EventBase:X4}");
				tooltip.AppendLine($"Tempo: 0x{headerInfo.Tempo:X4}  Instruments: {headerInfo.InstrumentCount}");
				tooltip.AppendLine($"Channels: {headerInfo.ActiveChannelCount}/9 active");
				tooltip.Append($"Loop: Measure {headerInfo.LoopStartMeasure}→{headerInfo.LoopEndMeasure} (×{headerInfo.LoopCount})");
				item.Tooltip = tooltip.ToString();
			}
		} catch {
			item.Tooltip = $"Error loading header for {item.FileName}";
		}
	}
}