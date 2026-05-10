namespace Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Abstraction for writing to OPL3 chip registers. The driver code depends
/// on this interface so production playback can target a real synthesizer
/// while tests record exact write sequences for register-level assertions.
/// </summary>
public interface IOplBus {
	/// <summary>
	/// Writes <paramref name="value"/> to <paramref name="register"/> on the
	/// selected OPL3 <paramref name="chip"/> (0 = primary, 1 = secondary).
	/// </summary>
	void WriteRegister(int chip, byte register, byte value);
}