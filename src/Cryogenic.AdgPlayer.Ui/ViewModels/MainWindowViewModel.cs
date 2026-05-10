namespace Cryogenic.AdgPlayer.Ui.ViewModels;

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
public sealed class MainWindowViewModel : ViewModelBase {
	/// <summary>Default constant displayed in the title bar.</summary>
	public const string DefaultTitleConst = "Cryogenic ADG Player — AdLib Gold OPL3";

	private string _title = DefaultTitleConst;

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
	public MainWindowViewModel() : this(new EmptyCatalog(), new AdgDriverState(), ObservableSerilogSink.Instance, static action => action()) {
	}

	/// <summary>Constructs the view model with explicit dependencies.</summary>
	public MainWindowViewModel(IAdgSongCatalog catalog, AdgDriverState driverState, ObservableSerilogSink logSink, Action<Action> dispatch) {
		ArgumentNullException.ThrowIfNull(catalog);
		ArgumentNullException.ThrowIfNull(driverState);
		ArgumentNullException.ThrowIfNull(logSink);
		ArgumentNullException.ThrowIfNull(dispatch);
		DriverState = driverState;
		Browser = new AdgBrowserViewModel(catalog);
		Transport = new AdgTransportViewModel(driverState);
		ChannelGrid = new AdgChannelGridViewModel(driverState);
		LogPanel = new AdgLogPanelViewModel(logSink, dispatch);
		OplBus = new OplCaptureBus(new RecordingOplBus());
		OplCapture = new AdgOplCaptureViewModel(OplBus, dispatch);
		Waveform = new AdgWaveformViewModel();
		Spectrum = new AdgSpectrumViewModel();
		Session = new AdgPlayerSessionViewModel(OplBus, dispatch);
		Browser.PropertyChanged += OnBrowserPropertyChanged;
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
}