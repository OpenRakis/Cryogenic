namespace Cryogenic.AdpPlayer.ViewModels;

using Avalonia.Controls;
using Avalonia.Platform.Storage;
using Avalonia.Threading;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Cryogenic.AdpPlayer.Logging;
using Cryogenic.AdpPlayer.Services;
using Cryogenic.AdpPlayer.Views;

using Serilog;

using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

/// <summary>
/// Main window view model: manages file loading, playback, volume, waveform,
/// channel events, OPL writes, and Serilog log display for the standalone ADP OPL3 player.
/// </summary>
public sealed partial class MainWindowViewModel : ViewModelBase, IDisposable {
	private static readonly ILogger Logger = Log.ForContext<MainWindowViewModel>();

	private static readonly string[] DefaultSongCandidates = {
		@"C:\Users\noalm\source\repos\Cryogenic\doc\DUNECDVF\C\DUNECD\DUNE.DAT_ARRAKIS.HSQ",
		@"C:\Users\noalm\source\repos\Cryogenic\doc\DUNECDVF\C\DUNECD\DUNE.DAT_ARRAKIS.ADG",
		@"C:\Jeux\DUNE\ARRAKIS.ADG",
		@"C:\Jeux\DUNE\ARRAKIS.HSQ"
	};

	private readonly Window _window;
	private DuneAdpPlayerEngine _engine;
	private WaveformControl _waveformControl;
	private readonly DispatcherTimer _statusTimer;
	private string _loadedPath = "";

	[ObservableProperty]
	private string _adgPath = ResolveDefaultSongPath();

	[ObservableProperty]
	private string _status = "Select an ADG/ADP file to play.";

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

	/// <summary>Channel events shown in the UI.</summary>
	public ObservableCollection<ChannelEventItem> ChannelEvents { get; } = new();

	/// <summary>OPL register writes shown in the UI.</summary>
	public ObservableCollection<OplWriteItem> OplWrites { get; } = new();

	/// <summary>Log entries shown in the UI log panel.</summary>
	public ObservableCollection<LogDisplayItem> Logs { get; } = new();

	/// <summary>
	/// Creates the view model, wires the Serilog UI sink.
	/// </summary>
	public MainWindowViewModel(Window window) {
		_window = window;
		_waveformControl = new WaveformControl();
		_engine = new DuneAdpPlayerEngine();

		WireSerilogSink();
		WireEngineEvents();

		_statusTimer = new DispatcherTimer {
			Interval = TimeSpan.FromMilliseconds(100)
		};
		_statusTimer.Tick += (_, _) => RefreshTransportState();
		_statusTimer.Start();

		// Set default file name
		if (File.Exists(AdgPath)) {
			SelectedFileName = Path.GetFileName(AdgPath);
			Status = "Default file found. Press Play.";
		}

		Logger.Information("ADP Player ready — OPL gain={OplGain:F1}x, tick rate={TickRate:F1} Hz",
			_engine.OplVolumeGain, _engine.TickRateHz);
	}

	/// <summary>
	/// Called by MainWindow code-behind to link the waveform control instance.
	/// </summary>
	public void RegisterWaveformControl(WaveformControl control) {
		_waveformControl = control;
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
	/// Opens a file picker for ADG/ADP files.
	/// </summary>
	[RelayCommand]
	private async System.Threading.Tasks.Task BrowseFileAsync() {
		if (_window.StorageProvider is null) {
			return;
		}

		System.Collections.Generic.IReadOnlyList<IStorageFile> picked =
			await _window.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions {
				Title = "Select ADG/ADP music file",
				AllowMultiple = false,
				FileTypeFilter = [
					new FilePickerFileType("Dune ADG/ADP") { Patterns = ["*.ADG", "*.ADP", "*.adg", "*.adp"] },
					new FilePickerFileType("All files") { Patterns = ["*"] }
				]
			});

		if (picked.Count > 0) {
			AdgPath = picked[0].Path.LocalPath;
			SelectedFileName = Path.GetFileName(AdgPath);
		}
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

			if (_loadedPath != AdgPath) {
				if (!TryLoadSelectedFile()) {
					return;
				}
			}

			ChannelEvents.Clear();
			OplWrites.Clear();
			_engine.Play();
			RefreshTransportState();
			Status = "Playing.";
			Logger.Information("Playing {File}", Path.GetFileName(AdgPath));
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
			});
		};

		_engine.AudioSamplesRendered += OnAudioSamplesRendered;
		_engine.ChannelEventDispatched += OnChannelEvent;
		_engine.OplRegisterWritten += OnOplWrite;
	}

	private void OnAudioSamplesRendered(float[] samples, int count) {
		_waveformControl.PushSamples(samples, count);
	}

	private static string ResolveDefaultSongPath() {
		for (int i = 0; i < DefaultSongCandidates.Length; i++) {
			string candidate = DefaultSongCandidates[i];
			if (File.Exists(candidate)) {
				return candidate;
			}
		}
		return DefaultSongCandidates[0];
	}

	private void OnChannelEvent(int channel, string eventType, string detail, long tick) {
		Dispatcher.UIThread.Post(() => {
			ChannelEventItem item = new ChannelEventItem {
				Channel = channel,
				EventType = eventType,
				Detail = detail,
				Tick = tick
			};
			ChannelEvents.Add(item);
			while (ChannelEvents.Count > 500) {
				ChannelEvents.RemoveAt(0);
			}
		});
	}

	private void OnOplWrite(ushort register, byte value, long tick) {
		// Only capture interesting registers (skip high-frequency freq writes to reduce noise)
		if (register >= 0xA0 && register <= 0xA8) {
			return; // Skip freq-low writes (too noisy)
		}

		Dispatcher.UIThread.Post(() => {
			OplWriteItem item = new OplWriteItem {
				Register = register,
				Value = value,
				Tick = tick
			};
			OplWrites.Add(item);
			while (OplWrites.Count > 500) {
				OplWrites.RemoveAt(0);
			}
		});
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

		if (!File.Exists(AdgPath)) {
			Status = "Selected file does not exist.";
			return false;
		}

		try {
			byte[] raw = File.ReadAllBytes(AdgPath);
			_engine.LoadSong(raw);
			_loadedPath = AdgPath;
			SelectedFileName = Path.GetFileName(AdgPath);
			UpdateHeaderInfo();
			Logger.Information("Loaded {File}", SelectedFileName);
			return true;
		} catch (Exception ex) {
			Status = $"Load failed: {ex.Message}";
			Logger.Error(ex, "Load failed");
			return false;
		}
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
}