namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Software tick divider that gates the per-beat scheduler work. The
/// divider holds a reload <see cref="Period"/> and a running
/// <see cref="Counter"/>; <see cref="Tick"/> decrements the counter
/// and signals <c>true</c> exactly when the counter reaches zero,
/// reloading it back to <see cref="Period"/>. Mirrors the byte at
/// <c>AdgTickDividerOffset</c> (0x0127) in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public sealed class AdgTickDivider {
	private byte _period = 1;
	private byte _counter = 1;

	/// <summary>Reload value for the divider counter.</summary>
	public byte Period => _period;

	/// <summary>Current running counter value.</summary>
	public byte Counter => _counter;

	/// <summary>
	/// Replaces the divider period and resets the counter to it.
	/// </summary>
	public void Reload(byte period) {
		if (period == 0) {
			throw new ArgumentOutOfRangeException(nameof(period),
				"Tick divider period must be at least 1.");
		}
		_period = period;
		_counter = period;
	}

	/// <summary>
	/// Resets the divider to its default state (<see cref="Period"/> = 1,
	/// <see cref="Counter"/> = 1). Called from <c>AdgDriverState.Reset()</c>
	/// alongside every other component to provide whole-driver reset
	/// semantics matching <c>AdgEndOfTrack_0AF5</c>.
	/// </summary>
	public void Reset() {
		_period = 1;
		_counter = 1;
	}

	/// <summary>
	/// Decrements the counter and returns <c>true</c> when the counter
	/// has elapsed (reached zero), reloading it to <see cref="Period"/>.
	/// </summary>
	public bool Tick() {
		_counter--;
		if (_counter == 0) {
			_counter = _period;
			return true;
		}
		return false;
	}
}