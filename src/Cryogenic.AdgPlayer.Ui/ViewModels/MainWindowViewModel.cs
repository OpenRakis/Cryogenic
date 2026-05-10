namespace Cryogenic.AdgPlayer.Ui.ViewModels;

using Cryogenic.AdgPlayer.Audio;
using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;
using Cryogenic.AdgPlayer.Ui.Logging;
using Cryogenic.AdgPlayer.Ui.Opl;
using Cryogenic.AdgPlayer.Ui.Services;

using System;
using System.Collections.Generic;

/// <summary>
/// View model for the main ADG player window. Holds the
/// window-level title and the panel-level view models composed
/// inside the window (DUNE.DAT browser and transport panel).
/// </summary>
public sealed class MainWindowViewModel : ViewModelBase, IDisposable {
	/// <summary>Default constant displayed in the title bar.</summary>
	public const string DefaultTitleConst = "Cryogenic ADG Player — AdLib Gold OPL3";

	private string _title = DefaultTitleConst;
	private readonly AdgOplSynthesizer? _synthesizer;

	/// <summary>Title displayed in the window's title bar.</summary>
	public string Title {
		get => _title;
		set => SetProperty(ref _title, value);
	}

	/// <summary>Shared driver state owned by the window scope.</summary>
	public AdgDriverState DriverState { get; }

	/// <summary>View model for the DUNE.DAT browser panel.</summary>
	public AdgBrowserViewModel Browser { get; }

	/// <summary>View model for the transport / volume / dynamics / fade panel.</summary>
	public AdgTransportViewModel Transport { get; }

	/// <summary>View model for the 18-channel grid panel.</summary>
	public AdgChannelGridViewModel ChannelGrid { get; }

	/// <summary>View model for the log panel.</summary>
	public AdgLogPanelViewModel LogPanel { get; }

	/// <summary>OPL capture bus used by the player engine to forward writes to the UI.</summary>
	public OplCaptureBus OplBus { get; }

	/// <summary>View model for the OPL register-write capture panel.</summary>
	public AdgOplCaptureViewModel OplCapture { get; }

	/// <summary>View model exposing the stereo waveform peak buffer.</summary>
	public AdgWaveformViewModel Waveform { get; }

	/// <summary>View model exposing the FFT spectrum buffer.</summary>
	public AdgSpectrumViewModel Spectrum { get; }

	/// <summary>Player session: engine + playback host + Play/Stop/Load commands.</summary>
	public AdgPlayerSessionViewModel Session { get; }

	/// <summary>Default constructor wires an empty in-memory catalog and a fresh driver state.</summary>
	public MainWindowViewModel() : this(new EmptyCatalog(), new AdgDriverState(), ObservableSerilogSink.Instance, static action => action(), new NullOplBus(), null) {
	}

	/// <summary>Constructs the view model with explicit dependencies and the in-memory <see cref="NullOplBus"/> sink (no audio output).</summary>
	public MainWindowViewModel(IAdgSongCatalog catalog, AdgDriverState driverState, ObservableSerilogSink logSink, Action<Action> dispatch)
		: this(catalog, driverState, logSink, dispatch, new NullOplBus(), null) {
	}

	/// <summary>Constructs the view model with explicit dependencies and an explicit OPL bus (used by production to inject <see cref="AdgOplSynthesizer"/>).</summary>
	public MainWindowViewModel(IAdgSongCatalog catalog, AdgDriverState driverState, ObservableSerilogSink logSink, Action<Action> dispatch, IOplBus innerBus, AdgOplSynthesizer? synthesizer) {
		ArgumentNullException.ThrowIfNull(catalog);
		ArgumentNullException.ThrowIfNull(driverState);
		ArgumentNullException.ThrowIfNull(logSink);
		ArgumentNullException.ThrowIfNull(dispatch);
		ArgumentNullException.ThrowIfNull(innerBus);
		DriverState = driverState;
		Browser = new AdgBrowserViewModel(catalog);
		Transport = new AdgTransportViewModel(driverState);
		ChannelGrid = new AdgChannelGridViewModel(driverState);
		LogPanel = new AdgLogPanelViewModel(logSink, dispatch);
		OplBus = new OplCaptureBus(innerBus);
		OplCapture = new AdgOplCaptureViewModel(OplBus, dispatch);
		Waveform = new AdgWaveformViewModel();
		Spectrum = new AdgSpectrumViewModel();
		Session = new AdgPlayerSessionViewModel(OplBus, dispatch);
		_synthesizer = synthesizer;
		if (_synthesizer is not null) {
			Session.PlaybackStarted += OnPlaybackStarted;
			Session.PlaybackStopped += OnPlaybackStopped;
		}
		Browser.PropertyChanged += OnBrowserPropertyChanged;
	}

	private void OnPlaybackStarted() {
		_synthesizer?.Start();
	}

	private void OnPlaybackStopped() {
		_synthesizer?.Stop();
	}

	private void OnBrowserPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e) {
		// Browser.SelectedIndex changes drive Session.LoadCommand.
		if (e.PropertyName != nameof(AdgBrowserViewModel.SelectedIndex)) {
			return;
		}
		if (!Browser.HasSelection) {
			return;
		}
		AdgBrowserItem item = Browser.GetSelectedItem();
		if (Session.LoadCommand.CanExecute(item.Path)) {
			Session.LoadCommand.Execute(item.Path);
		}
	}

	private sealed class EmptyCatalog : IAdgSongCatalog {
		public IReadOnlyList<AdgBrowserItem> Enumerate() {
			return Array.Empty<AdgBrowserItem>();
		}
	}

	/// <summary>Disposes the optional synthesizer and the player session.</summary>
	public void Dispose() {
		Session.Dispose();
		_synthesizer?.Dispose();
	}
}