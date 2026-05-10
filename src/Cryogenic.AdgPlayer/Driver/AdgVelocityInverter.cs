namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure helper that mirrors <c>mov AL,0x80 / sub AL,velocity</c> at
/// dnadg:0B30 in <c>AdgVolumeModulation_0B2E</c>: the inverse-velocity
/// scaling factor used when the shaping byte requests a downward sweep.
/// </summary>
public static class AdgVelocityInverter {
	/// <summary>
	/// Returns <c>(byte)(0x80 - velocity)</c> with native 8-bit wrap.
	/// </summary>
	public static byte Inverse(byte velocity) {
		return (byte)(0x80 - velocity);
	}
}