namespace Cryogenic.AdgPlayer.Ui.ViewModels;

using Cryogenic.AdgPlayer.Driver;

using System;
using System.Collections.ObjectModel;

/// <summary>
/// View model for the 18-channel grid panel. Holds an
/// <see cref="ObservableCollection{T}"/> of
/// <see cref="AdgChannelRowViewModel"/> snapshots that mirror the
/// per-channel tables of a shared <see cref="AdgDriverState"/>.
/// </summary>
public sealed class AdgChannelGridViewModel : ViewModelBase {
	private readonly AdgDriverState _driverState;

	/// <summary>Per-channel snapshot rows in display order.</summary>
	public ObservableCollection<AdgChannelRowViewModel> Rows { get; } = new();

	/// <summary>Builds the grid view model around the supplied driver state.</summary>
	public AdgChannelGridViewModel(AdgDriverState driverState) {
		ArgumentNullException.ThrowIfNull(driverState);
		_driverState = driverState;
		for (int i = 0; i < AdgDriverState.ChannelCount; i++) {
			Rows.Add(BuildRow(i));
		}
	}

	/// <summary>Re-reads every channel and replaces the row snapshots in-place.</summary>
	public void Refresh() {
		for (int i = 0; i < AdgDriverState.ChannelCount; i++) {
			Rows[i] = BuildRow(i);
		}
	}

	private AdgChannelRowViewModel BuildRow(int index) {
		return new AdgChannelRowViewModel(
			index,
			_driverState.CurrentNotes.Get(index),
			_driverState.InstrumentSlots.Get(index),
			_driverState.PitchBendCounters.Get(index),
			_driverState.PitchAccumulators.Get(index),
			_driverState.PatchTypeSlots.IsFourOperator(index));
	}
}