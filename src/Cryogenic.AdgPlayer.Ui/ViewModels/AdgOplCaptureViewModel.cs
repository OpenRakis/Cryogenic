namespace Cryogenic.AdgPlayer.Ui.ViewModels;

using Cryogenic.AdgPlayer.Opl;
using Cryogenic.AdgPlayer.Ui.Opl;

using System;
using System.Collections.ObjectModel;

/// <summary>
/// View model for the OPL register-write capture panel. Subscribes
/// to an <see cref="OplCaptureBus"/> and projects each forwarded
/// write into an <see cref="ObservableCollection{T}"/> of
/// <see cref="AdgOplWriteItem"/>. Old entries are evicted past
/// <see cref="MaxDisplayedEntries"/> to keep the UI bounded.
/// </summary>
public sealed class AdgOplCaptureViewModel : ViewModelBase, IDisposable {
	/// <summary>Hard cap on how many rows are kept in the panel.</summary>
	public const int MaxDisplayedEntries = 500;

	private readonly OplCaptureBus _bus;
	private readonly Action<Action> _dispatch;
	private readonly Action<OplWrite> _onWrite;
	private long _sequence;
	private bool _disposed;

	/// <summary>Captured OPL writes in order of arrival (oldest first).</summary>
	public ObservableCollection<AdgOplWriteItem> Writes { get; } = new();

	/// <summary>Builds the view model around the supplied capture bus and dispatch callback.</summary>
	public AdgOplCaptureViewModel(OplCaptureBus bus, Action<Action> dispatch) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(dispatch);
		_bus = bus;
		_dispatch = dispatch;
		_onWrite = OnWrite;
		_bus.Subscribe(_onWrite);
	}

	/// <inheritdoc />
	public void Dispose() {
		if (_disposed) {
			return;
		}
		_disposed = true;
		_bus.Unsubscribe(_onWrite);
	}

	private void OnWrite(OplWrite write) {
		long sequence = ++_sequence;
		_dispatch.Invoke(() => Append(sequence, write));
	}

	private void Append(long sequence, OplWrite write) {
		Writes.Add(new AdgOplWriteItem(sequence, write.Chip, write.Register, write.Value));
		while (Writes.Count > MaxDisplayedEntries) {
			Writes.RemoveAt(0);
		}
	}
}