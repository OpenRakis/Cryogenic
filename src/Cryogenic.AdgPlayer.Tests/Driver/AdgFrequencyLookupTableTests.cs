namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 26a — Read-only typed wrapper around the 12-entry semitone
/// frequency lookup loaded from <c>AdgFrequencyLookupTableOffset</c>
/// (0x0142) in <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public sealed class AdgFrequencyLookupTableTests {
	private static ushort[] BuildLookup() {
		ushort[] lookup = new ushort[AdgFrequencyLookupTable.SemitoneCount];
		for (int i = 0; i < lookup.Length; i++) {
			lookup[i] = (ushort)(0x0100 + i);
		}
		return lookup;
	}

	[Fact]
	public void SemitoneCount_IsTwelve() {
		// Assert
		Assert.Equal(12, AdgFrequencyLookupTable.SemitoneCount);
	}

	[Fact]
	public void GetFrequencyWord_ReturnsValueAtSemitone() {
		// Arrange
		AdgFrequencyLookupTable table = new(BuildLookup());

		// Act
		ushort first = table.GetFrequencyWord(0);
		ushort last = table.GetFrequencyWord(11);

		// Assert
		Assert.Equal((ushort)0x0100, first);
		Assert.Equal((ushort)0x010B, last);
	}

	[Theory]
	[InlineData(-1)]
	[InlineData(12)]
	public void GetFrequencyWord_OutOfRange_Throws(int semitone) {
		// Arrange
		AdgFrequencyLookupTable table = new(BuildLookup());

		// Act + Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => table.GetFrequencyWord(semitone));
	}

	[Fact]
	public void Constructor_NullArray_Throws() {
		// Act + Assert
		Assert.Throws<ArgumentNullException>(() => new AdgFrequencyLookupTable(null!));
	}

	[Fact]
	public void Constructor_WrongLength_Throws() {
		// Arrange
		ushort[] tooShort = new ushort[11];

		// Act + Assert
		Assert.Throws<ArgumentException>(() => new AdgFrequencyLookupTable(tooShort));
	}

	[Fact]
	public void Constructor_DefensivelyCopiesArray() {
		// Arrange
		ushort[] source = BuildLookup();
		AdgFrequencyLookupTable table = new(source);

		// Act
		source[0] = 0xFFFF;

		// Assert
		Assert.Equal((ushort)0x0100, table.GetFrequencyWord(0));
	}

	[Fact]
	public void AsSpan_ReturnsAllTwelveValuesForLegacyConsumers() {
		// Arrange
		AdgFrequencyLookupTable table = new(BuildLookup());

		// Act
		ReadOnlySpan<ushort> span = table.AsSpan();

		// Assert
		Assert.Equal(12, span.Length);
		Assert.Equal((ushort)0x0105, span[5]);
	}
}