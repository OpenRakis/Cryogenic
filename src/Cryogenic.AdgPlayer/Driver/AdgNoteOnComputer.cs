namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Result of computing the OPL frequency word for a note-on event.
/// </summary>
/// <param name="Octave">Octave (0..7) extracted from the raw pitch.</param>
/// <param name="Semitone">Semitone index (0..11) into the frequency lookup table.</param>
/// <param name="CachedFrequencyWord">
/// Word stored in the per-channel frequency table at
/// <c>AdgFrequencyWordTableOffset</c>. The hi byte already contains the
/// octave bits at positions 2..4 but does NOT have the key-on bit set.
/// </param>
/// <param name="NoteOnFrequencyWord">
/// Word actually written to OPL B0/A0 to trigger the note. Same as
/// <see cref="CachedFrequencyWord"/> with the key-on bit (0x20) set in
/// the hi byte.
/// </param>
public readonly record struct AdgNoteOnFrequency(
	byte Octave,
	byte Semitone,
	ushort CachedFrequencyWord,
	ushort NoteOnFrequencyWord);

/// <summary>
/// Pure transformation: converts a raw pitch byte into the OPL
/// frequency word pair used by note-on events. Faithful port of the pure
/// arithmetic inside <c>AdgNoteOn_10A9</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public static class AdgNoteOnComputer {
	private const int SemitonesPerOctave = 12;
	private const int LookupTableLength = SemitonesPerOctave;
	private const ushort PitchTransposeOffset = 0x30;
	private const ushort UpperPitchLimit = 0x60;
	private const byte KeyOnBit = 0x20;

	/// <summary>
	/// Computes the cached + note-on frequency words for <paramref name="rawPitch"/>
	/// using <paramref name="frequencyLookup"/> (12 entries: one per semitone).
	/// </summary>
	public static AdgNoteOnFrequency Compute(ushort rawPitch, ushort[] frequencyLookup) {
		ArgumentNullException.ThrowIfNull(frequencyLookup);
		if (frequencyLookup.Length != LookupTableLength) {
			throw new ArgumentException(
				$"Frequency lookup must have exactly {LookupTableLength} entries.",
				nameof(frequencyLookup));
		}

		ushort noteWord = (ushort)(rawPitch + PitchTransposeOffset);
		if (noteWord >= UpperPitchLimit) {
			noteWord = 0;
		}

		byte octave = (byte)(noteWord / SemitonesPerOctave);
		byte semitone = (byte)(noteWord % SemitonesPerOctave);

		ushort raw = frequencyLookup[semitone];
		byte rawLo = (byte)(raw & 0xFF);
		byte rawHi = (byte)(raw >> 8);
		byte cachedHi = (byte)(rawHi | (octave << 2));
		ushort cached = (ushort)(rawLo | (cachedHi << 8));
		ushort noteOn = (ushort)(rawLo | ((cachedHi | KeyOnBit) << 8));

		return new AdgNoteOnFrequency(octave, semitone, cached, noteOn);
	}
}