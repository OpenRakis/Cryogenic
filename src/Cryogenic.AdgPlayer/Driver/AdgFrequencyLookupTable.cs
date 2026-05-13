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

	/// <summary>
	/// Default 12-entry semitone fnum table baked into the DNADG
	/// driver image at offset 0x0142. Captured live via Spice86 MCP
	/// <c>read_memory</c> from segment 0x5BAE while ADG388 was
	/// playing (24 raw bytes: 57 01 6C 01 81 01 98 01 B1 01 CB 01
	/// E6 01 03 02 22 02 43 02 66 02 8A 02).
	/// </summary>
	public static readonly ushort[] DefaultFrequencyWords = new ushort[] {
		0x0157, 0x016C, 0x0181, 0x0198, 0x01B1, 0x01CB,
		0x01E6, 0x0203, 0x0222, 0x0243, 0x0266, 0x028A,
	};

	private readonly ushort[] _frequencyWords;

	/// <summary>Returns a fresh table seeded with <see cref="DefaultFrequencyWords"/>.</summary>
	public static AdgFrequencyLookupTable CreateDefault() {
		return new AdgFrequencyLookupTable(DefaultFrequencyWords);
	}

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