namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Tests for <see cref="AdgPitchBendComputer"/> — the pure math
/// port of <c>AdgPitchBendBody_0D8B</c>. Exercises the early-out
/// guard, the centred-bend (no-op) path, and the four
/// quadrant branches (bend ↑/↓, portamento ↑/↓).
/// </summary>
public sealed class AdgPitchBendComputerTests {
    private static AdgFrequencyLookupTable BuildLookup() {
        // Standard 12-entry OPL F-number table.
        ushort[] lookup = new ushort[12] {
            0x0157, 0x016C, 0x0181, 0x0198, 0x01B1, 0x01CB,
            0x01E6, 0x0203, 0x0222, 0x0243, 0x0266, 0x028A
        };
        return new AdgFrequencyLookupTable(lookup);
    }

    private static AdgPitchBendFractionsTable BuildBendFractions() {
        // Synthetic non-zero values so the math is observable.
        byte[] fractions = new byte[13] {
            0x10, 0x20, 0x30, 0x40, 0x50, 0x60,
            0x70, 0x80, 0x90, 0xA0, 0xB0, 0xC0, 0xD0
        };
        return new AdgPitchBendFractionsTable(fractions);
    }

    private static AdgPortamentoFractionsTable BuildPortamentoFractions() {
        byte[] fractions = new byte[10] {
            0x01, 0x02, 0x03, 0x04, 0x05,
            0x06, 0x07, 0x08, 0x09, 0x0A
        };
        return new AdgPortamentoFractionsTable(fractions);
    }

    /// <summary>currentNote == 0 → Inactive sentinel, no work.</summary>
    [Fact]
    public void Compute_CurrentNoteZero_ReturnsInactive() {
        // Arrange
        AdgFrequencyLookupTable lookup = BuildLookup();
        AdgPitchBendFractionsTable bend = BuildBendFractions();
        AdgPortamentoFractionsTable port = BuildPortamentoFractions();

        // Act
        AdgPitchBendComputer.Result result = AdgPitchBendComputer.Compute(
            currentNote: 0, pitchMode: 0, bendValue: 0x40,
            lookup, bend, port);

        // Assert
        Assert.False(result.Active);
        Assert.Equal<ushort>(0, result.PreKeyOnFrequencyWord);
    }

    /// <summary>
    /// Bend value 0x40 is the centre — positive branch with delta=0
    /// produces the unmodified frequency word for the current
    /// semitone, plus block bits in Hi8.
    /// </summary>
    [Fact]
    public void Compute_BendCentered_ReturnsBaseFrequencyWithBlock() {
        // Arrange — note 0x18 (the base) → octave 0, semitone 0.
        AdgFrequencyLookupTable lookup = BuildLookup();
        AdgPitchBendFractionsTable bend = BuildBendFractions();
        AdgPortamentoFractionsTable port = BuildPortamentoFractions();

        // Act
        AdgPitchBendComputer.Result result = AdgPitchBendComputer.Compute(
            currentNote: 0x18, pitchMode: 0, bendValue: 0x40,
            lookup, bend, port);

        // Assert — base frequency 0x0157, octave 0 → block bits 0x00.
        //   Positive branch: ax = 0; ax += 1 → 1; rotr(1,5) gives
        //   delta=0 in Lo8, mul-fraction times Hi8(=0x08)=fraction*0x08.
        //   With semitone=0 → fractions[1] = 0x20; 0x20*0x08 = 0x0100,
        //   adjustment = Hi8 = 0x01. So Lo8(0x57) + 1 = 0x58, Hi8 unchanged.
        Assert.True(result.Active);
        Assert.Equal<ushort>(0x0158, result.PreKeyOnFrequencyWord);
    }

    /// <summary>
    /// Bend value 0x00 (max negative) on note 0x24 (octave 1,
    /// semitone 0) descends into octave 0 via the wrap-around
    /// branch.
    /// </summary>
    [Fact]
    public void Compute_BendMaxNegative_DescendsOctave() {
        // Arrange — note 0x24 (= 0x18 + 12) → octave 1, semitone 0.
        AdgFrequencyLookupTable lookup = BuildLookup();
        AdgPitchBendFractionsTable bend = BuildBendFractions();
        AdgPortamentoFractionsTable port = BuildPortamentoFractions();

        // Act
        AdgPitchBendComputer.Result result = AdgPitchBendComputer.Compute(
            currentNote: 0x24, pitchMode: 0, bendValue: 0x00,
            lookup, bend, port);

        // Assert — outcome is non-zero (math chain produced a
        //   frequency word) and active. Semitone wraps so block bits
        //   reflect octave 0 (0x00 << 2).
        Assert.True(result.Active);
        Assert.NotEqual<ushort>(0, result.PreKeyOnFrequencyWord);
        // Block bits sit in Hi8 bits 2-4 (octave << 2). Octave 0
        //   means those bits are zero.
        Assert.Equal(0x00, (result.PreKeyOnFrequencyWord >> 8) & 0x1C);
    }

    /// <summary>
    /// Portamento mode (pitchMode != 0) with bend value 0x40 reads
    /// portamento[0] (semitone 0, remainder 0).
    /// </summary>
    [Fact]
    public void Compute_PortamentoCentered_ReadsPortamentoTable() {
        // Arrange
        AdgFrequencyLookupTable lookup = BuildLookup();
        AdgPitchBendFractionsTable bend = BuildBendFractions();
        AdgPortamentoFractionsTable port = BuildPortamentoFractions();

        // Act — note 0x18, mode = 1 (portamento), centred.
        AdgPitchBendComputer.Result result = AdgPitchBendComputer.Compute(
            currentNote: 0x18, pitchMode: 1, bendValue: 0x40,
            lookup, bend, port);

        // Assert — positive portamento branch with delta=0 / r=0:
        //   adjustment = portamento[0] = 0x01.
        //   Result = lookup[0] + 0x01 → 0x0158.
        Assert.True(result.Active);
        Assert.Equal<ushort>(0x0158, result.PreKeyOnFrequencyWord);
    }

    /// <summary>
    /// Portamento mode with bend value 0x00 takes the negative
    /// branch and uses ax/5 / ax%5 arithmetic.
    /// </summary>
    [Fact]
    public void Compute_PortamentoMaxNegative_UsesDivMod5() {
        // Arrange
        AdgFrequencyLookupTable lookup = BuildLookup();
        AdgPitchBendFractionsTable bend = BuildBendFractions();
        AdgPortamentoFractionsTable port = BuildPortamentoFractions();

        // Act — note 0x24, mode 1, max negative.
        AdgPitchBendComputer.Result result = AdgPitchBendComputer.Compute(
            currentNote: 0x24, pitchMode: 1, bendValue: 0x00,
            lookup, bend, port);

        // Assert — non-zero active result; lower octave reached.
        Assert.True(result.Active);
        Assert.NotEqual<ushort>(0, result.PreKeyOnFrequencyWord);
    }
}
