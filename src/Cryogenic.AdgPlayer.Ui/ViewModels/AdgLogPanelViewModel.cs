namespace Cryogenic.AdgPlayer.Ui.ViewModels;

using Cryogenic.AdgPlayer.Ui.Logging;

using System;
using System.Collections.ObjectModel;

/// <summary>
/// View model for the log panel. Subscribes to a shared
/// <see cref="ObservableSerilogSink"/> and projects each rendered
/// message into an <see cref="ObservableCollection{T}"/> of
/// <see cref="LogDisplayItem"/>. Old entries are evicted past
/// <see cref="MaxDisplayedEntries"/> to keep the UI bounded.
/// </summary>
public sealed class AdgLogPanelViewModel : ViewModelBase, IDisposable {
	/// <summary>Hard cap on how many rows are kept in the panel.</summary>
	public const int MaxDisplayedEntries = 600;

	private readonly ObservableSerilogSink _sink;
	private readonly Action<Action> _dispatch;
	private readonly Action<string> _onMessage;
	private bool _disposed;

	/// <summary>Log rows displayed in the panel (oldest first).</summary>
	public ObservableCollection<LogDisplayItem> Logs { get; } = new();

	/// <summary>
	/// Builds the view model around a sink and a dispatch callback.
	/// The dispatch callback is invoked with each message append so
	/// the host can marshal to the UI thread (production code passes
	/// <c>Avalonia.Threading.Dispatcher.UIThread.Post</c>; tests pass
	/// a synchronous adapter).
	/// </summary>
	public AdgLogPanelViewModel(ObservableSerilogSink sink, Action<Action> dispatch) {
		ArgumentNullException.ThrowIfNull(sink);
		ArgumentNullException.ThrowIfNull(dispatch);
		_sink = sink;
		_dispatch = dispatch;
		_onMessage = OnMessage;
		foreach (string buffered in _sink.DrainAll()) {
			Append(buffered);
		}
		_sink.Subscribe(_onMessage);
	}

	/// <inheritdoc />
	public void Dispose() {
		if (_disposed) {
			return;
		}
		_disposed = true;
		_sink.Unsubscribe(_onMessage);
	}

	private void OnMessage(string message) {
		_dispatch.Invoke(() => Append(message));
	}

	private void Append(string message) {
		string timestamp = DateTime.Now.ToString("HH:mm:ss");
		Logs.Add(new LogDisplayItem(timestamp, message));
		while (Logs.Count > MaxDisplayedEntries) {
			Logs.RemoveAt(0);
		}
	}
}