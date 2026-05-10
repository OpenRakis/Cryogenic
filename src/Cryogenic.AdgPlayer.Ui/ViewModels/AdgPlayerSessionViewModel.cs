namespace Cryogenic.AdgPlayer.Ui.ViewModels;

using CommunityToolkit.Mvvm.Input;

using Cryogenic.AdgPlayer.Opl;
using Cryogenic.AdgPlayer.Services;
using Cryogenic.AdgPlayer.Ui.Playback;

using System;
using System.IO;
using System.Windows.Input;

/// <summary>
/// Glue object that owns the <see cref="DuneAdgPlayerEngine"/>,
/// the <see cref="AdgPlaybackHost"/> driving its tick loop, and
/// the relay commands surfaced to the view (Load / Play / Stop).
/// All command-state notifications use
/// <see cref="IRelayCommand.NotifyCanExecuteChanged"/>.
/// </summary>
public sealed class AdgPlayerSessionViewModel : ViewModelBase, IDisposable {
	private readonly DuneAdgPlayerEngine _engine = new();
	private readonly AdgPlaybackHost _host;
	private readonly IOplBus _bus;
	private readonly Action<Action> _dispatch;

	/// <summary>The engine wired into this session.</summary>
	public DuneAdgPlayerEngine Engine => _engine;

	/// <summary>The playback host driving <see cref="DuneAdgPlayerEngine.Tick"/> at the DNADG cadence.</summary>
	public AdgPlaybackHost Host => _host;

	/// <summary>Loads the song bytes of <see cref="LoadCommand"/>'s argument.</summary>
	public IRelayCommand<string> LoadCommand { get; }

	/// <summary>Starts playback (engine + host).</summary>
	public IRelayCommand PlayCommand { get; }

	/// <summary>Stops playback (host + engine).</summary>
	public IRelayCommand StopCommand { get; }

	/// <summary>Builds the session with a synchronous (test) dispatcher.</summary>
	public AdgPlayerSessionViewModel(IOplBus bus) : this(bus, static action => action()) {
	}

	/// <summary>
	/// Builds the session around the supplied OPL bus and a UI-thread
	/// dispatcher used to marshal host-tick callbacks. The dispatcher
	/// must invoke the supplied <see cref="Action"/> on the same thread
	/// that owns the bound view-model state (UI thread in production).
	/// </summary>
	public AdgPlayerSessionViewModel(IOplBus bus, Action<Action> dispatch) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(dispatch);
		_bus = bus;
		_dispatch = dispatch;
		_engine.SetOplBus(_bus);
		_host = new AdgPlaybackHost(_bus, OnHostTick);
		LoadCommand = new RelayCommand<string>(OnLoad, CanLoad);
		PlayCommand = new RelayCommand(OnPlay, CanPlay);
		StopCommand = new RelayCommand(OnStop, CanStop);
	}

	private void OnHostTick(IOplBus bus) {
		// Marshal the engine tick to the dispatcher thread so the UI
		// observes consistent state on every PropertyChanged tick. The
		// bus parameter is reused for symmetry with the IOplBus contract.
		_dispatch(() => {
			if (!_engine.HasSongLoaded || !_engine.IsPlaying) {
				return;
			}
			bool stillRunning = _engine.Tick();
			if (!stillRunning) {
				_host.Stop();
				NotifyCommandsChanged();
			}
		});
	}

	private bool CanLoad(string? path) {
		return !string.IsNullOrWhiteSpace(path) && File.Exists(path);
	}

	private void OnLoad(string? path) {
		if (!CanLoad(path)) {
			return;
		}
		if (_host.IsRunning) {
			_host.Stop();
		}
		byte[] bytes = File.ReadAllBytes(path!);
		_engine.Load(bytes);
		NotifyCommandsChanged();
	}

	private bool CanPlay() {
		return _engine.HasSongLoaded && !_engine.IsPlaying;
	}

	private void OnPlay() {
		if (!CanPlay()) {
			return;
		}
		_engine.Play();
		_host.Start();
		NotifyCommandsChanged();
	}

	private bool CanStop() {
		return _engine.IsPlaying || _host.IsRunning;
	}

	private void OnStop() {
		if (_host.IsRunning) {
			_host.Stop();
		}
		_engine.StopPlayback();
		NotifyCommandsChanged();
	}

	private void NotifyCommandsChanged() {
		PlayCommand.NotifyCanExecuteChanged();
		StopCommand.NotifyCanExecuteChanged();
		LoadCommand.NotifyCanExecuteChanged();
	}

	/// <summary>Stops the host and releases the timer.</summary>
	public void Dispose() {
		_host.Dispose();
	}
}