namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 9 — note-on frequency word computation.
/// Faithful port of <c>AdgNoteOn_10A9</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// Original logic (pure transformation isolated here):
///   noteWord = rawPitch + 0x30
///   if (noteWord >= 0x60) noteWord = 0      ; out-of-range → silence
///   octave   = noteWord / 12
///   semitone = noteWord % 12
///   freq     = FrequencyLookupTable[semitone]
///   cached   = lo(freq) | (hi(freq) | (octave &lt;&lt; 2)) &lt;&lt; 8   ; stored in cache
///   noteOn   = cached with bit 0x20 set in hi byte               ; written to OPL
/// </summary>
public sealed class AdgNoteOnComputerTests {
	// 12-entry semitone frequency table from the runtime (offset 0x0142).
	// The actual driver values are overwritten at init; for this pure test we
	// use a synthetic table with distinguishable values per semitone.
	private static readonly ushort[] FrequencyLookup = {
		0x0157, 0x016B, 0x0181, 0x0198, 0x01B0, 0x01CA,
		0x01E5, 0x0202, 0x0220, 0x0241, 0x0263, 0x0287
	};

	[Fact]
	public void Compute_NormalPitch_PicksOctaveSemitoneAndSetsKeyOnBit() {
		// Arrange — rawPitch = 0x12 → noteWord = 0x42 → octave 5, semitone 6.
		// freq[6] = 0x01E5; cached hi gets octave (5) shifted left 2 = 0x14
		//   cached = lo(0x01E5)=0xE5, hi=0x01 | 0x14 = 0x15 → 0x15E5.
		// noteOn = 0x15E5 with hi byte | 0x20 = 0x35E5.
		const ushort rawPitch = 0x12;

		// Act
		AdgNoteOnFrequency result = AdgNoteOnComputer.Compute(rawPitch, FrequencyLookup);

		// Assert
		Assert.Equal((byte)5, result.Octave);
		Assert.Equal((byte)6, result.Semitone);
		Assert.Equal((ushort)0x15E5, result.CachedFrequencyWord);
		Assert.Equal((ushort)0x35E5, result.NoteOnFrequencyWord);
	}

	[Fact]
	public void Compute_PitchAtLowerEdge_ProducesOctaveZero() {
		// Arrange — rawPitch = 0xFFD0 (signed -0x30) wraps to noteWord 0:
		//   octave 0, semitone 0, freq[0]=0x0157, cached=0x0157, noteOn=0x2157.
		const ushort rawPitch = unchecked((ushort)-0x30);

		// Act
		AdgNoteOnFrequency result = AdgNoteOnComputer.Compute(rawPitch, FrequencyLookup);

		// Assert
		Assert.Equal((byte)0, result.Octave);
		Assert.Equal((byte)0, result.Semitone);
		Assert.Equal((ushort)0x0157, result.CachedFrequencyWord);
		Assert.Equal((ushort)0x2157, result.NoteOnFrequencyWord);
	}

	[Fact]
	public void Compute_PitchOutOfRange_ResetsToOctaveZeroSemitoneZero() {
		// Arrange — noteWord >= 0x60 forces noteWord = 0 (silence path).
		// rawPitch = 0x40 → 0x70 (>=0x60) → reset → octave 0, semitone 0.
		const ushort rawPitch = 0x40;

		// Act
		AdgNoteOnFrequency result = AdgNoteOnComputer.Compute(rawPitch, FrequencyLookup);

		// Assert
		Assert.Equal((byte)0, result.Octave);
		Assert.Equal((byte)0, result.Semitone);
		Assert.Equal((ushort)0x0157, result.CachedFrequencyWord);
		Assert.Equal((ushort)0x2157, result.NoteOnFrequencyWord);
	}

	[Fact]
	public void Compute_PitchJustBelowUpperLimit_StaysInRange() {
		// Arrange — rawPitch = 0x2F → noteWord = 0x5F (< 0x60), valid.
		// 0x5F / 12 = 7, 0x5F % 12 = 11.
		// freq[11] = 0x0287; octave 7 << 2 = 0x1C; cached hi = 0x02 | 0x1C = 0x1E.
		// cached = 0x1E87; noteOn = 0x3E87.
		const ushort rawPitch = 0x2F;

		// Act
		AdgNoteOnFrequency result = AdgNoteOnComputer.Compute(rawPitch, FrequencyLookup);

		// Assert
		Assert.Equal((byte)7, result.Octave);
		Assert.Equal((byte)11, result.Semitone);
		Assert.Equal((ushort)0x1E87, result.CachedFrequencyWord);
		Assert.Equal((ushort)0x3E87, result.NoteOnFrequencyWord);
	}

	[Fact]
	public void Compute_RejectsLookupTableOfWrongSize() {
		// Arrange
		ushort[] bad = new ushort[11];

		// Act + Assert
		Assert.Throws<ArgumentException>(() => AdgNoteOnComputer.Compute(0, bad));
	}

	[Fact]
	public void Compute_NullLookupTable_Throws() {
		// Act + Assert
		Assert.Throws<ArgumentNullException>(() => AdgNoteOnComputer.Compute(0, null!));
	}
}