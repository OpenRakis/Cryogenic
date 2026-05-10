namespace Cryogenic.AdgPlayer.Ui.ViewModels;

using Cryogenic.AdgPlayer.Driver;

using System;

/// <summary>
/// View model for the transport panel (Play/Stop) and the
/// master-volume / dynamics / fade pattern read-outs. Reads its
/// state from a shared <see cref="AdgDriverState"/> so that the
/// underlying driver is the single source of truth.
/// </summary>
public sealed class AdgTransportViewModel : ViewModelBase {
	private readonly AdgDriverState _driverState;
	private bool _isPlaying;
	private bool _hasSongLoaded;

	/// <summary>True when a song is loaded and the scheduler is running.</summary>
	public bool IsPlaying {
		get => _isPlaying;
		set => SetProperty(ref _isPlaying, value);
	}

	/// <summary>True after a song image has been loaded into the engine.</summary>
	public bool HasSongLoaded {
		get => _hasSongLoaded;
		set => SetProperty(ref _hasSongLoaded, value);
	}

	/// <summary>Live master volume byte from the shared driver state.</summary>
	public byte MasterVolume => _driverState.MasterVolume.Master;

	/// <summary>Live current volume byte (after fades / modulations).</summary>
	public byte CurrentVolume => _driverState.MasterVolume.Current;

	/// <summary>Live dynamics byte.</summary>
	public byte Dynamics => _driverState.Dynamics.Value;

	/// <summary>Live fade pattern byte.</summary>
	public byte FadePattern => _driverState.FadePatternState.Value;

	/// <summary>Constructs the transport view model around the shared driver state.</summary>
	public AdgTransportViewModel(AdgDriverState driverState) {
		ArgumentNullException.ThrowIfNull(driverState);
		_driverState = driverState;
	}

	/// <summary>
	/// Refreshes every read-only volume / dynamics property by raising
	/// <see cref="System.ComponentModel.INotifyPropertyChanged.PropertyChanged"/>
	/// for each of them. Called by the host engine whenever the driver
	/// mutates the underlying bytes.
	/// </summary>
	public void RefreshVolumeReadouts() {
		OnPropertyChanged(nameof(MasterVolume));
		OnPropertyChanged(nameof(CurrentVolume));
		OnPropertyChanged(nameof(Dynamics));
		OnPropertyChanged(nameof(FadePattern));
	}
}