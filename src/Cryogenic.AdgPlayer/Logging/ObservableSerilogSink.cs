namespace Cryogenic.AdgPlayer.Logging;

using Serilog.Core;
using Serilog.Events;

using System;
using System.Collections.Concurrent;

/// <summary>
/// Serilog sink that buffers log entries for display in the Avalonia UI.
/// Thread-safe — log events can arrive from any thread.
/// </summary>
public sealed class ObservableSerilogSink : ILogEventSink {
	/// <summary>
	/// Singleton instance shared between Serilog configuration and the ViewModel.
	/// </summary>
	public static readonly ObservableSerilogSink Instance = new();

	private readonly ConcurrentQueue<string> _queue = new();
	private const int MaxEntries = 2000;

	/// <summary>
	/// Fired on each new log event with the rendered message.
	/// May fire from any thread.
	/// </summary>
	public event Action<string>? LogReceived;

	public void Emit(LogEvent logEvent) {
		string rendered = $"[{logEvent.Timestamp:HH:mm:ss} {logEvent.Level.ToString().ToUpperInvariant()[..3]}] {logEvent.RenderMessage()}";
		if (logEvent.Exception is not null) {
			rendered += Environment.NewLine + logEvent.Exception;
		}

		_queue.Enqueue(rendered);
		while (_queue.Count > MaxEntries) {
			_queue.TryDequeue(out _);
		}

		LogReceived?.Invoke(rendered);
	}

	/// <summary>
	/// Drains all buffered entries.
	/// </summary>
	public string[] DrainAll() {
		return _queue.ToArray();
	}
}