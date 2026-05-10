namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure helper that mirrors <c>add AL,[DI+AdgChannelPitchTransposeOffset]</c>
/// at dnadg:0A99/0ABE: applies the per-channel pitch-transpose byte to a
/// raw event note with native 8-bit wrap.
/// </summary>
public static class AdgNoteEventTransposer {
	/// <summary>Returns <c>(byte)(note + transpose)</c> with 8-bit wrap.</summary>
	public static byte Transpose(byte note, byte transpose) {
		return (byte)(note + transpose);
	}
}