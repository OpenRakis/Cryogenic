namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 16-bit running tempo accumulator stored at
/// <c>AdgTempoAccumulatorOffset</c> (0x0126) in the original DNADG
/// driver. Each scheduler tick adds the tempo word read from the
/// active song event ([BX+0x30] in dnadg:0763) and the sum wraps
/// modulo 2^16, matching the 8086 <c>add word</c> semantics.
/// </summary>
public sealed class AdgTempoAccumulator {
	private ushort _value;

	/// <summary>Current running tempo accumulator word.</summary>
	public ushort Value => _value;

	/// <summary>
	/// Adds <paramref name="delta"/> to the accumulator with natural
	/// 16-bit wrap-around (no exception on overflow).
	/// </summary>
	public void Add(ushort delta) {
		_value = (ushort)(_value + delta);
	}

	/// <summary>Restores the accumulator to zero.</summary>
	public void Reset() {
		_value = 0;
	}
}