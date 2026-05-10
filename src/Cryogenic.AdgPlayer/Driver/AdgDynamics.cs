namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// One-byte tempo-dynamics cell mirroring <c>AdgDynamicsOffset</c>
/// (0x04D7). The driver compares the tempo accumulator against the
/// thresholds exposed below to choose the active fade cadence.
/// </summary>
public sealed class AdgDynamics {
	/// <summary>Lower bound used for the slowest cadence (dnadg:0697).</summary>
	public const ushort ThresholdSlow = 0x0060;

	/// <summary>Bound between slow and medium cadences.</summary>
	public const ushort ThresholdMedium = 0x00C0;

	/// <summary>Bound between medium and fast cadences.</summary>
	public const ushort ThresholdFast = 0x0180;

	/// <summary>Bound above which the fastest cadence is selected.</summary>
	public const ushort ThresholdFastest = 0x0300;

	/// <summary>Current dynamics byte.</summary>
	public byte Value { get; private set; }

	/// <summary>Sets the dynamics byte.</summary>
	public void Set(byte value) {
		Value = value;
	}

	/// <summary>Resets the byte to zero.</summary>
	public void Reset() {
		Value = 0;
	}
}