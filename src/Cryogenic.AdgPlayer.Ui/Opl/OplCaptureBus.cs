namespace Cryogenic.AdgPlayer.Ui.Opl;

using Cryogenic.AdgPlayer.Opl;

using System;
using System.Collections.Generic;

/// <summary>
/// <see cref="IOplBus"/> decorator that forwards every write to an
/// inner bus while raising the <see cref="WriteObserved"/> callbacks
/// for UI capture panels and waveform-feed sinks. The decorator never
/// drops or reorders writes; subscribers are notified in the same
/// thread that issued the write.
/// </summary>
public sealed class OplCaptureBus : IOplBus {
	private readonly IOplBus _inner;
	private readonly object _subscriberLock = new();
	private List<Action<OplWrite>> _subscribers = new();
	private long _sequence;

	/// <summary>Number of writes forwarded since construction.</summary>
	public long ObservedCount => _sequence;

	/// <summary>Builds the decorator around an inner OPL bus.</summary>
	public OplCaptureBus(IOplBus inner) {
		ArgumentNullException.ThrowIfNull(inner);
		_inner = inner;
	}

	/// <summary>Subscribes a handler invoked on every forwarded write.</summary>
	public void Subscribe(Action<OplWrite> handler) {
		ArgumentNullException.ThrowIfNull(handler);
		lock (_subscriberLock) {
			List<Action<OplWrite>> next = new(_subscribers.Count + 1);
			next.AddRange(_subscribers);
			next.Add(handler);
			_subscribers = next;
		}
	}

	/// <summary>Removes a previously subscribed handler.</summary>
	public void Unsubscribe(Action<OplWrite> handler) {
		ArgumentNullException.ThrowIfNull(handler);
		lock (_subscriberLock) {
			List<Action<OplWrite>> next = new(_subscribers.Count);
			bool removed = false;
			foreach (Action<OplWrite> existing in _subscribers) {
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
	public void WriteRegister(int chip, byte register, byte value) {
		_inner.WriteRegister(chip, register, value);
		_sequence++;
		List<Action<OplWrite>> snapshot = _subscribers;
		OplWrite write = new(chip, register, value);
		foreach (Action<OplWrite> subscriber in snapshot) {
			subscriber.Invoke(write);
		}
	}
}