namespace Cryogenic.AdgPlayer.Ui.Logging;

using Serilog.Core;
using Serilog.Events;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

/// <summary>
/// Serilog sink that buffers log entries for display in the
/// Avalonia UI. Thread-safe — log events can arrive from any
/// thread. Subscribers are stored in a snapshot list so the
/// emit path never sees a null reference.
/// </summary>
public sealed class ObservableSerilogSink : ILogEventSink {
	/// <summary>Maximum buffered entries before old ones are evicted.</summary>
	public const int MaxEntries = 2000;

	/// <summary>Singleton instance shared between Serilog config and the view models.</summary>
	public static readonly ObservableSerilogSink Instance = new();

	private readonly ConcurrentQueue<string> _queue = new();
	private readonly object _subscriberLock = new();
	private List<Action<string>> _subscribers = new();

	/// <summary>Subscribes a handler to receive each rendered log entry as it arrives.</summary>
	public void Subscribe(Action<string> handler) {
		ArgumentNullException.ThrowIfNull(handler);
		lock (_subscriberLock) {
			List<Action<string>> next = new(_subscribers.Count + 1);
			next.AddRange(_subscribers);
			next.Add(handler);
			_subscribers = next;
		}
	}

	/// <summary>Removes a previously subscribed handler.</summary>
	public void Unsubscribe(Action<string> handler) {
		ArgumentNullException.ThrowIfNull(handler);
		lock (_subscriberLock) {
			List<Action<string>> next = new(_subscribers.Count);
			bool removed = false;
			foreach (Action<string> existing in _subscribers) {
				if (!removed && existing.Equals(handler)) {
					removed = true;
					continue;
				}
				next.Add(existing);
			}
			_subscribers = next;
		}
	}

	/// <inheritdoc />
	public void Emit(LogEvent logEvent) {
		ArgumentNullException.ThrowIfNull(logEvent);
		string rendered = Render(logEvent);
		_queue.Enqueue(rendered);
		while (_queue.Count > MaxEntries) {
			_queue.TryDequeue(out _);
		}
		List<Action<string>> snapshot = _subscribers;
		foreach (Action<string> subscriber in snapshot) {
			subscriber.Invoke(rendered);
		}
	}

	/// <summary>Snapshots every currently buffered entry.</summary>
	public string[] DrainAll() {
		return _queue.ToArray();
	}

	private static string Render(LogEvent logEvent) {
		string head = $"[{logEvent.Timestamp:HH:mm:ss} {logEvent.Level.ToString().ToUpperInvariant()[..3]}] {logEvent.RenderMessage()}";
		if (logEvent.Exception is null) {
			return head;
		}
		return head + Environment.NewLine + logEvent.Exception;
	}
}