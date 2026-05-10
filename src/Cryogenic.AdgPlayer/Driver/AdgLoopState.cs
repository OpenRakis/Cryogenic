namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Mutable holder of the song-loop counters consumed by
/// <c>AdgCheckLoopPoint_07DA</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>. Keeps the active
/// measure, subdivision and remaining loop counter words. Pure state;
/// the snapshot rep-movs side effect is owned by a different
/// component.
/// </summary>
public sealed class AdgLoopState {
	private ushort _measure;
	private ushort _subdivision;
	private ushort _loopCounter;

	/// <summary>Active measure word.</summary>
	public ushort Measure => _measure;

	/// <summary>Active subdivision word (typically 0x60 ticks/measure).</summary>
	public ushort Subdivision => _subdivision;

	/// <summary>Remaining loop iterations.</summary>
	public ushort LoopCounter => _loopCounter;

	/// <summary>Replaces the active measure word.</summary>
	public void SetMeasure(ushort value) {
		_measure = value;
	}

	/// <summary>Replaces the active subdivision word.</summary>
	public void SetSubdivision(ushort value) {
		_subdivision = value;
	}

	/// <summary>Replaces the remaining loop counter.</summary>
	public void SetLoopCounter(ushort value) {
		_loopCounter = value;
	}

	/// <summary>Restores every field to zero.</summary>
	public void Reset() {
		_measure = 0;
		_subdivision = 0;
		_loopCounter = 0;
	}

	/// <summary>
	/// Decrements the loop counter when it is non-zero and returns
	/// <c>true</c> to signal that one more loop iteration was
	/// consumed; returns <c>false</c> when the counter is already at
	/// zero.
	/// </summary>
	public bool DecrementLoopCounter() {
		if (_loopCounter == 0) {
			return false;
		}
		_loopCounter--;
		return true;
	}
}