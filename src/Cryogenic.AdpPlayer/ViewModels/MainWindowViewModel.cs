namespace Cryogenic.AdpPlayer.ViewModels;

using Avalonia.Controls;
using Avalonia.Platform.Storage;
using Avalonia.Threading;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Cryogenic.AdpPlayer.Services;
using Cryogenic.AdpPlayer.Views;

using System.Collections.ObjectModel;
using System.Text;

public sealed partial class MainWindowViewModel : ViewModelBase, IDisposable {
	private readonly Window _window;
	private Opl2Synth? _synth;
	private DuneAdpPlayerEngine? _player;
	private PlayerControlServer? _controlServer;
	private readonly Queue<int> _eventsHistory = new();
	private const int GraphWindow = 64;
	private const int MaxEventFlowEntries = 200;
	private WaveformControl? _waveformControl;

	[ObservableProperty]
	private string _songPath = @"C:\Users\noalm\source\repos\Cryogenic\doc\DUNECDVF\C\DUNECD\DUNE.DAT_\MORNING.AGD";

	[ObservableProperty]
	private string _status = "Select an ADP/AGD/HSQ song file.";

	[ObservableProperty]
	private bool _isPlaying;

	[ObservableProperty]
	private bool _isPaused;

	[ObservableProperty]
	private string _tickInfo = "Tick: -";

	[ObservableProperty]
	private string _eventGraph = string.Empty;

	[ObservableProperty]
	private string _transportInfo = "00:00 / 00:00";

	[ObservableProperty]
	private double _timelineProgress;

	[ObservableProperty]
	private int _masterVolume = 127;

	[ObservableProperty]
	private int _targetVolume = 127;

	[ObservableProperty]
	private double _outputGain = 2.0;

	[ObservableProperty]
	private double _audioPeak;

	[ObservableProperty]
	private string _serverEndpoint = "http://127.0.0.1:8766/";

	[ObservableProperty]
	private bool _serverRunning;

	// OPL Test panel properties
	[ObservableProperty]
	private int _testChannel;

	[ObservableProperty]
	private int _testNote = 60;

	[ObservableProperty]
	private int _testVolume;

	// Header panel structured properties
	[ObservableProperty]
	private string _headerFileName = "-";

	[ObservableProperty]
	private string _headerFileSize = "-";

	[ObservableProperty]
	private string _headerTiming = "-";

	[ObservableProperty]
	private string _headerStructure = "-";

	[ObservableProperty]
	private string _headerChannels = "-";

	public ObservableCollection<LogDisplayItem> Logs { get; } = new();
	public ObservableCollection<ChannelTrackerRowViewModel> TrackerRows { get; } = new();
	public ObservableCollection<EventFlowDisplayItem> EventFlow { get; } = new();

	public MainWindowViewModel(Window window) {
		_window = window;
		for (int i = 0; i < 9; i++) {
			TrackerRows.Add(new ChannelTrackerRowViewModel(i));
		}

		StartControlServer();
	}

	/// <summary>
	/// Called by MainWindow codebehind to link the waveform control instance.
	/// </summary>
	public void RegisterWaveformControl(WaveformControl control) {
		_waveformControl = control;
	}

	public void Dispose() {
		_controlServer?.Dispose();
		_player?.Dispose();
		_synth?.Dispose();
	}

	partial void OnOutputGainChanged(double value) {
		if (_synth is not null) {
			_synth.OutputGain = (float)value;
			AddLog($"Output gain set to {value:F2}.");
		}
	}

	partial void OnMasterVolumeChanged(int value) {
		if (_player is not null) {
			int clamped = Math.Clamp(value, 0, 127);
			_player.SetMasterVolumeImmediate((byte)clamped);
		}
	}

	partial void OnTargetVolumeChanged(int value) {
		if (_player is not null) {
			int clamped = Math.Clamp(value, 0, 127);
			_player.SetTargetVolume((byte)clamped);
		}
	}

	[RelayCommand]
	private async Task BrowseSongAsync() {
		if (_window.StorageProvider is null) {
			return;
		}

		FilePickerOpenOptions options = new() {
			Title = "Select Dune ADP/AGD song file",
			AllowMultiple = false,
			FileTypeFilter = [new FilePickerFileType("Dune ADP Songs") { Patterns = ["*.AGD", "*.HSQ", "*.M32", "*.*"] }]
		};

		// Start in the parent folder of the last loaded file
		if (!string.IsNullOrWhiteSpace(SongPath)) {
			string? parentDir = System.IO.Path.GetDirectoryName(SongPath);
			if (!string.IsNullOrEmpty(parentDir) && System.IO.Directory.Exists(parentDir)) {
				IStorageFolder? folder = await _window.StorageProvider.TryGetFolderFromPathAsync(parentDir);
				if (folder is not null) {
					options.SuggestedStartLocation = folder;
				}
			}
		}

		IReadOnlyList<IStorageFile> picked = await _window.StorageProvider.OpenFilePickerAsync(options);

		if (picked.Count > 0) {
			SongPath = picked[0].Path.LocalPath;
			Status = "Song file selected.";
		}
	}

	[RelayCommand]
	private void Load() {
		if (string.IsNullOrWhiteSpace(SongPath)) {
			Status = "Select a song file first.";
			return;
		}

		try {
			EnsurePlayerInitialized();
			if (_player is null) {
				return;
			}
			_player.Load(SongPath);
			Status = "Loaded.";
			AddLog($"Loaded file '{SongPath}'.");
		} catch (Exception ex) {
			Status = $"Load failed: {ex.Message}";
			AddLog(Status);
		}
	}

	[RelayCommand]
	private void Play() {
		try {
			if (string.IsNullOrWhiteSpace(SongPath)) {
				Status = "Select a song file first.";
				return;
			}

			EnsurePlayerInitialized();
			if (_player is null) {
				return;
			}
			if (_player.IsPlaying) {
				_player.Stop();
			}
			_player.Load(SongPath);
			_player.Start();
			IsPlaying = true;
			IsPaused = false;
			Status = "Playing.";
			AddLog("Playback started.");
		} catch (Exception ex) {
			Status = $"Play failed: {ex.Message}";
			IsPlaying = false;
			IsPaused = false;
			AddLog(Status);
		}
	}

	[RelayCommand]
	private void TogglePause() {
		if (_player is null) {
			return;
		}
		if (_player.IsPaused) {
			_player.Resume();
			IsPlaying = true;
			IsPaused = false;
			Status = "Playing.";
		} else if (_player.IsPlaying) {
			_player.Pause();
			IsPlaying = false;
			IsPaused = true;
			Status = "Paused.";
		}
	}

	[RelayCommand]
	private void Stop() {
		_player?.Stop();
		IsPlaying = false;
		IsPaused = false;
		Status = "Stopped.";
		AddLog("Playback stopped.");
	}

	[RelayCommand]
	private void StartControlServer() {
		try {
			_controlServer?.Dispose();
			_controlServer = new PlayerControlServer(
				getState: BuildState,
				play: Play,
				stop: Stop,
				load: LoadFromPath,
				setOutputGain: SetOutputGain,
				setMasterVolume: SetMasterVolume,
				setTargetVolume: SetTargetVolume,
				getAudioDebug: GetAudioDebug,
				resetAudioDebug: ResetAudioDebug,
				audioPanic: PanicAudio,
				getRawStreamDebug: GetRawStreamDebug,
				startGoldenCapture: StartGoldenCapture,
				stopGoldenCapture: StopGoldenCapture,
				resetGoldenCapture: ResetGoldenCapture,
				getGoldenCaptureSummary: GetGoldenCaptureSummary,
				dumpGoldenCapture: DumpGoldenCapture,
				diagnoseGoldenCapture: DiagnoseGoldenCapture,
				getRecentLogs: GetRecentLogs,
				clearLogs: ClearLogs,
				log: AddLog,
				prefix: ServerEndpoint);
			_controlServer.Start();
			ServerRunning = true;
		} catch (Exception ex) {
			ServerRunning = false;
			AddLog($"Control server start failed: {ex.Message}");
		}
	}

	[RelayCommand]
	private void StopControlServer() {
		_controlServer?.Stop();
		ServerRunning = false;
	}

	[RelayCommand]
	private void PlayTestTone() {
		EnsurePlayerInitialized();
		if (_synth is null) {
			return;
		}
		_synth.PlayTestTone(TestChannel, (byte)TestNote, (byte)TestVolume);
		AddLog($"Test tone ON: ch={TestChannel} note={TestNote} vol={TestVolume}.");
	}

	[RelayCommand]
	private void StopTestTone() {
		if (_synth is null) {
			return;
		}
		_synth.StopTestTone(TestChannel);
		AddLog($"Test tone OFF: ch={TestChannel}.");
	}

	[RelayCommand]
	private void PanicBeep() {
		EnsurePlayerInitialized();
		if (_synth is null) {
			return;
		}
		_synth.PlayTestBeep();
		AddLog("Panic beep fired (500ms test tone on ch0).");
	}

	[RelayCommand]
	private void PlayTestChord() {
		EnsurePlayerInitialized();
		if (_synth is null) {
			return;
		}
		// C major chord across 3 channels
		_synth.PlayTestTone(0, 48, 0x00); // C3
		_synth.PlayTestTone(1, 52, 0x00); // E3
		_synth.PlayTestTone(2, 55, 0x00); // G3
		AddLog("Test chord ON: C-E-G on ch0-1-2.");
	}

	[RelayCommand]
	private void StopAllTestTones() {
		if (_synth is null) {
			return;
		}
		for (int i = 0; i < 9; i++) {
			_synth.StopTestTone(i);
		}
		AddLog("All test tones OFF.");
	}

	private void EnsurePlayerInitialized() {
		if (_player is not null) {
			return;
		}

		try {
			_synth = new Opl2Synth();
			_synth.OutputGain = (float)OutputGain;
			_synth.AudioPeakComputed += OnAudioPeakComputed;
			_synth.AudioSamplesRendered += OnAudioSamplesRendered;

			_player = new DuneAdpPlayerEngine(_synth);
			_player.LogProduced += OnEngineLogProduced;
			_player.SnapshotProduced += OnSnapshotProduced;
			_player.HeaderInfoProduced += OnHeaderInfoProduced;
			_player.EventFlowProduced += OnEventFlowProduced;

			_player.SetMasterVolumeImmediate((byte)Math.Clamp(MasterVolume, 0, 127));
			_player.SetTargetVolume((byte)Math.Clamp(TargetVolume, 0, 127));

			AddLog("OPL2 Synth (NukedOPL3Sharp) initialized successfully.");
		} catch (Exception ex) {
			Status = $"Synth initialization failed: {ex.Message}";
			AddLog(Status);
			_synth = null;
			_player = null;
		}
	}

	private void OnAudioPeakComputed(float peak) {
		Dispatcher.UIThread.Post(() => {
			AudioPeak = Math.Round(peak, 3);
		});
	}

	private void OnEngineLogProduced(string logLine) {
		Dispatcher.UIThread.Post(() => {
			AddLog(logLine);
		});
	}

	private void OnAudioSamplesRendered(float[] samples, int sampleCount) {
		_waveformControl?.PushSamples(samples, sampleCount);
	}

	private void OnHeaderInfoProduced(SongHeaderInfo info) {
		Dispatcher.UIThread.Post(() => {
			HeaderFileName = $"{info.FileName}  ({(info.WasCompressed ? "HSQ" : "raw")})";
			HeaderFileSize = $"Raw: {info.RawFileSize:N0}B  Decoded: {info.DecodedSize:N0}B  FirstWord: 0x{info.FirstWord:X4}";
			HeaderTiming = $"TickInc: 0x{info.TickIncrement:X4} ({info.TickIncrement})  |  {info.PitTicksPerSubdivision:F2} PIT/sub  |  {info.MillisecondsPerSubdivision:F2}ms/sub  |  {info.MillisecondsPerMeasure:F1}ms/measure  |  Est: {info.EstimatedDurationSeconds:F1}s";
			HeaderStructure = $"End: {info.EndMeasure}  Loop: {info.LoopMeasure}  Repeat: {info.LoopRepeat}  Active: {info.ActiveChannelCount}/9";

			StringBuilder chInfo = new();
			foreach (ChannelHeaderInfo ch in info.Channels) {
				if (ch.Active) {
					chInfo.Append($"Ch{ch.Index}:0x{ch.RawOffset:X4}→0x{ch.AbsoluteOffset:X4} w={ch.InitialWait} p=0x{ch.InitialPointer:X4}  ");
				}
			}
			HeaderChannels = chInfo.Length > 0 ? chInfo.ToString().TrimEnd() : "No active channels";
		});
	}

	private void OnEventFlowProduced(EventFlowEntry entry) {
		Dispatcher.UIThread.Post(() => {
			EventFlowDisplayItem item = new() {
				Position = $"T{entry.TickIndex} M{entry.Measure}:{entry.Subdivision:X2}",
				ChannelLabel = $"ch{entry.Channel}",
				Kind = entry.Kind,
				Detail = entry.Detail,
				DeltaLabel = $"d={entry.Delta}",
				Channel = entry.Channel,
			};
			EventFlow.Add(item);
			while (EventFlow.Count > MaxEventFlowEntries) {
				EventFlow.RemoveAt(0);
			}
		});
	}

	private void OnSnapshotProduced(PlayerDiagnosticsSnapshot snapshot) {
		Dispatcher.UIThread.Post(() => {
			TickInfo = $"Tick: {snapshot.TickIndex}  Measure: {snapshot.Measure}/{snapshot.EndMeasure}  Sub: {snapshot.Subdivision}  Repeat: {snapshot.RepeatCounter}  Accum: 0x{snapshot.Accumulator:X4}  TickInc: 0x{snapshot.TickIncrement:X4}  PTicks: {snapshot.ProcessTickCount}  Chs: {snapshot.ActiveChannelCount}  Peak: {snapshot.AudioPeak:F3}";

			TimeSpan elapsed = TimeSpan.FromSeconds(snapshot.ElapsedSeconds);
			TimeSpan estimated = TimeSpan.FromSeconds(snapshot.EstimatedDurationSeconds);
			TransportInfo = $"{elapsed:mm\\:ss} / {estimated:mm\\:ss}";
			TimelineProgress = snapshot.TimelineProgress;

			for (int i = 0; i < 9; i++) {
				ChannelTrackerRowViewModel row = TrackerRows[i];
				row.Wait = i < snapshot.ChannelWait.Length ? snapshot.ChannelWait[i].ToString("X4") : "----";
				row.Pointer = i < snapshot.ChannelEventPointer.Length ? snapshot.ChannelEventPointer[i].ToString("X4") : "----";
				row.LastEvent = i < snapshot.LastEventPerChannel.Length ? snapshot.LastEventPerChannel[i] : "-";
			}

			_eventsHistory.Enqueue(snapshot.EventsDispatchedThisTick);
			while (_eventsHistory.Count > GraphWindow) {
				_eventsHistory.Dequeue();
			}
			EventGraph = BuildSparkline(_eventsHistory);

			IsPlaying = _player?.IsPlaying == true;
			IsPaused = _player?.IsPaused == true;
			if (!IsPlaying && !IsPaused && Status == "Playing.") {
				Status = "Idle.";
			}
		});
	}

	private static string BuildSparkline(IEnumerable<int> values) {
		int[] array = values.ToArray();
		if (array.Length == 0) {
			return string.Empty;
		}

		int max = Math.Max(1, array.Max());
		char[] levels = ['▁', '▂', '▃', '▄', '▅', '▆', '▇', '█'];
		StringBuilder builder = new(array.Length);
		foreach (int value in array) {
			int index = (int)Math.Round((double)value / max * (levels.Length - 1));
			index = Math.Clamp(index, 0, levels.Length - 1);
			builder.Append(levels[index]);
		}
		return builder.ToString();
	}

	private void AddLog(string message) {
		string timestamp = DateTime.Now.ToString("HH:mm:ss");
		LogDisplayItem item = new() {
			Timestamp = timestamp,
			Message = message,
		};
		Logs.Add(item);
		if (Logs.Count > 600) {
			Logs.RemoveAt(0);
		}
		Console.WriteLine($"{timestamp}  {message}");
	}

	private object BuildState() {
		AudioDebugInfo? audioDebug = _player?.GetAudioDebugInfo();
		return new {
			songPath = SongPath,
			isPlaying = IsPlaying,
			status = Status,
			tickInfo = TickInfo,
			timelineProgress = TimelineProgress,
			transportInfo = TransportInfo,
			masterVolume = MasterVolume,
			targetVolume = TargetVolume,
			outputGain = OutputGain,
			audioPeak = AudioPeak,
			serverEndpoint = ServerEndpoint,
			audioDebug = audioDebug
		};
	}

	private void LoadFromPath(string path) {
		SongPath = path;
		Load();
	}

	private void SetOutputGain(float gain) {
		OutputGain = Math.Clamp(gain, 0.0f, 2.0f);
	}

	private void SetMasterVolume(byte volume) {
		MasterVolume = Math.Clamp((int)volume, 0, 127);
	}

	private void SetTargetVolume(byte volume) {
		TargetVolume = Math.Clamp((int)volume, 0, 127);
	}

	private object GetAudioDebug() {
		if (_player is null) {
			return new {
				ready = false,
				reason = "Player not initialized."
			};
		}

		AudioDebugInfo debugInfo = _player.GetAudioDebugInfo();
		return new {
			ready = true,
			debugInfo
		};
	}

	private void ResetAudioDebug() {
		_player?.ResetAudioDebug();
		AddLog("Audio debug counters reset.");
	}

	private void PanicAudio() {
		_player?.PanicAllNotesOff();
		AddLog("Audio panic sent.");
	}

	private object GetRawStreamDebug(int channel, int before, int count) {
		if (_player is null) {
			return new {
				ready = false,
				reason = "Player not initialized."
			};
		}

		return _player.GetRawStreamDebug(channel, before, count);
	}

	private object StartGoldenCapture(int maxEvents) {
		EnsurePlayerInitialized();
		GoldenCaptureDump dump = _player!.StartGoldenCapture(maxEvents);
		AddLog($"Golden capture started (maxEvents={dump.MaxEvents}).");
		return dump;
	}

	private object StopGoldenCapture() {
		if (_player is null) {
			return new {
				ready = false,
				reason = "Player not initialized."
			};
		}

		object result = _player.StopGoldenCapture(includeEvents: false);
		AddLog("Golden capture stopped.");
		return result;
	}

	private object ResetGoldenCapture() {
		if (_player is null) {
			return new {
				ready = false,
				reason = "Player not initialized."
			};
		}

		GoldenCaptureDump dump = _player.ResetGoldenCapture();
		AddLog("Golden capture reset.");
		return dump;
	}

	private object GetGoldenCaptureSummary() {
		if (_player is null) {
			return new {
				ready = false,
				reason = "Player not initialized."
			};
		}

		return _player.GetGoldenCaptureSummary();
	}

	private object DumpGoldenCapture(int offset, int limit, string sourceFilter, string kindFilter) {
		if (_player is null) {
			return new {
				ready = false,
				reason = "Player not initialized."
			};
		}

		return _player.GetGoldenCaptureDump(offset, limit, sourceFilter, kindFilter);
	}

	private object DiagnoseGoldenCapture(int sampleSize) {
		if (_player is null) {
			return new { ready = false, reason = "Player not initialized." };
		}

		GoldenCaptureDiagnostics diagnostics = _player.GetGoldenCaptureDiagnostics(sampleSize);
		return new {
			ready = true,
			diagnostics
		};
	}

	private string[] GetRecentLogs(int count) {
		if (_synth is null) {
			return ["Synth not initialized."];
		}
		return _synth.LogSink.GetLatest(count);
	}

	private void ClearLogs() {
		if (_synth is not null) {
			_synth.LogSink.Clear();
		}
		AddLog("Serilog circular buffer cleared.");
	}
}