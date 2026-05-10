namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// One-byte fade-pattern state cell mirroring
/// <c>AdgFadePatternOffset</c> (0x01E0). The driver mutates the high
/// nibble in 0x10/0x20 steps to schedule fade-up and fade-down
/// sweeps. Distinct from <see cref="AdgFadePattern"/>, which enumerates
/// the cadence words burned into the song header.
/// </summary>
public sealed class AdgFadePatternState {
	/// <summary>High-nibble step used by fade-up routines.</summary>
	public const byte HighNibbleIncrement = 0x10;

	/// <summary>High-nibble step used by fade-down routines.</summary>
	public const byte HighNibbleDecrement = 0x20;

	/// <summary>Current fade pattern byte.</summary>
	public byte Value { get; private set; }

	/// <summary>Sets the fade pattern byte.</summary>
	public void Set(byte value) {
		Value = value;
	}

	/// <summary>Resets the byte to zero.</summary>
	public void Reset() {
		Value = 0;
	}
}