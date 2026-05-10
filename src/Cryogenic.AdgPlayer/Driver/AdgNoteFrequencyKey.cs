namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure helper that converts an 8-bit MIDI-style note into the
/// frequency-table key consumed by <c>AdgNoteOn_10A9</c>. Reproduces
/// <c>(ushort)(note - 0x48)</c> at dnadg:0AAE.
/// </summary>
public static class AdgNoteFrequencyKey {
	/// <summary>Base note subtracted to obtain the frequency-table key.</summary>
	public const byte BaseNote = 0x48;

	/// <summary>Returns <c>(ushort)(note - 0x48)</c> with native 16-bit wrap.</summary>
	public static ushort ToFrequencyKey(byte note) {
		return (ushort)(note - BaseNote);
	}
}