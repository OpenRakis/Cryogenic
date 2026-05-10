namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Read-only typed wrapper around the 12-entry semitone frequency
/// lookup loaded from <c>AdgFrequencyLookupTableOffset</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>. Indexed by
/// semitone (0..11).
/// </summary>
public sealed class AdgFrequencyLookupTable {
	/// <summary>Number of entries (one per semitone).</summary>
	public const int SemitoneCount = 12;

	private readonly ushort[] _frequencyWords;

	/// <summary>
	/// Builds the lookup from a 12-entry array. The array is copied so
	/// later mutations of <paramref name="frequencyWords"/> do not
	/// affect this table.
	/// </summary>
	public AdgFrequencyLookupTable(ushort[] frequencyWords) {
		ArgumentNullException.ThrowIfNull(frequencyWords);
		if (frequencyWords.Length != SemitoneCount) {
			throw new ArgumentException(
				$"Frequency lookup must contain exactly {SemitoneCount} entries.",
				nameof(frequencyWords));
		}
		_frequencyWords = (ushort[])frequencyWords.Clone();
	}

	/// <summary>
	/// Returns the OPL frequency word for the given semitone index.
	/// </summary>
	public ushort GetFrequencyWord(int semitone) {
		if (semitone < 0 || semitone >= SemitoneCount) {
			throw new ArgumentOutOfRangeException(nameof(semitone));
		}
		return _frequencyWords[semitone];
	}

	/// <summary>
	/// Returns a read-only span over the 12 frequency words for legacy
	/// consumers that still take a raw <see cref="ushort"/> array (for
	/// example <see cref="AdgNoteOnComputer.Compute"/>).
	/// </summary>
	public ReadOnlySpan<ushort> AsSpan() {
		return _frequencyWords;
	}

	/// <summary>
	/// Returns the underlying 12-entry array for internal callers that
	/// must pass a raw <see cref="ushort"/> array to legacy emitters.
	/// </summary>
	internal ushort[] AsArray() {
		return _frequencyWords;
	}
}