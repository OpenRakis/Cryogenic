namespace Cryogenic.AdgPlayer.Ui.Playback;

using Cryogenic.AdgPlayer.Opl;

using System;
using System.Threading;

/// <summary>
/// Hosts the ADG driver tick loop. Owns a <see cref="Timer"/> that
/// fires at the DNADG PIT rate (~181 Hz) and forwards each tick to
/// the caller-supplied <see cref="OnTick"/> delegate, passing the
/// bound <see cref="IOplBus"/> so the engine writes can be observed
/// (and captured) by the UI. The host does not implement the driver
/// itself; it is a pure scheduler shell so the playback pipeline can
/// be exercised independently of the engine.
/// </summary>
public sealed class AdgPlaybackHost : IDisposable {
	/// <summary>PIT reload value programmed by DNADG (matches the engine constant).</summary>
	public const int PitReloadValueConst = 0x1745;

	/// <summary>Tick interval in milliseconds (~5.51 ms / 181 Hz).</summary>
	public const double TickIntervalMillisecondsConst = 1000.0 / 181.0;

	private readonly IOplBus _bus;
	private readonly Action<IOplBus> _onTick;
	private readonly object _stateLock = new();
	private Timer? _timer;
	private long _tickCount;
	private bool _isDisposed;

	/// <summary>True when the timer is currently running.</summary>
	public bool IsRunning { get; private set; }

	/// <summary>Number of ticks executed since construction.</summary>
	public long TickCount => Interlocked.Read(ref _tickCount);

	/// <summary>Tick interval in milliseconds.</summary>
	public double TickIntervalMilliseconds => TickIntervalMillisecondsConst;

	/// <summary>OPL bus forwarded to <see cref="OnTick"/> on each tick.</summary>
	public IOplBus Bus => _bus;

	/// <summary>Tick callback supplied to the constructor.</summary>
	public Action<IOplBus> OnTick => _onTick;

	/// <summary>Builds a host that will forward ticks to <paramref name="onTick"/> with <paramref name="bus"/>.</summary>
	public AdgPlaybackHost(IOplBus bus, Action<IOplBus> onTick) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(onTick);
		_bus = bus;
		_onTick = onTick;
	}

	/// <summary>
	/// Starts the timer. Throws when the host is already running or
	/// has been disposed.
	/// </summary>
	public void Start() {
		lock (_stateLock) {
			ThrowIfDisposed();
			if (IsRunning) {
				throw new InvalidOperationException("AdgPlaybackHost is already running.");
			}
			TimeSpan interval = TimeSpan.FromMilliseconds(TickIntervalMillisecondsConst);
			_timer = new Timer(static state => ((AdgPlaybackHost)state!).Tick(), this, interval, interval);
			IsRunning = true;
		}
	}

	/// <summary>
	/// Stops the timer and disposes the underlying timer instance.
	/// Idempotent; safe to call when the host is not running. Blocks
	/// until any in-flight tick callback has completed so callers can
	/// safely tear down dependent state immediately after returning.
	/// </summary>
	public void Stop() {
		Timer? timer;
		lock (_stateLock) {
			if (!IsRunning) {
				return;
			}
			timer = _timer;
			_timer = null;
			IsRunning = false;
		}
		if (timer is null) {
			return;
		}
		using ManualResetEvent drained = new(false);
		if (timer.Dispose(drained)) {
			drained.WaitOne();
		}
	}

	/// <summary>
	/// Executes a single tick synchronously by invoking <see cref="OnTick"/>
	/// with the bound bus and incrementing <see cref="TickCount"/>.
	/// Used by the timer and by tests that need to drive the host
	/// without touching the wall clock.
	/// </summary>
	public void Tick() {
		ThrowIfDisposed();
		_onTick(_bus);
		Interlocked.Increment(ref _tickCount);
	}

	/// <summary>Disposes the host, stopping the timer if running.</summary>
	public void Dispose() {
		Stop();
		_isDisposed = true;
	}

	private void ThrowIfDisposed() {
		if (_isDisposed) {
			throw new ObjectDisposedException(nameof(AdgPlaybackHost));
		}
	}
}