namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Util;

/// <summary>
/// Pure 16-bit math port of <c>AdgPitchBendBody_0D8B</c>
/// (oracle <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>
/// dnadg:0D8B). Computes the new OPL frequency word for one
/// channel given the current note, the bend mode, the bend value,
/// and the three reference tables.
///
/// The result is the "pre-key-on" frequency word (block bits in
/// the upper byte, key-on bit cleared); callers add bit
/// <c>0x20</c> before emitting to OPL.
/// </summary>
public static class AdgPitchBendComputer {
    private const byte NoteBaseOffset = 0x18;
    private const byte SemitonesPerOctave = 12;
    private const byte BendCenter = 0x40;
    private const byte BlockShift = 2;

    /// <summary>
    /// Outcome of <see cref="Compute"/>. <see cref="Active"/> is
    /// <see langword="false"/> when the body's early-out fires
    /// (<c>currentNote == 0</c>).
    /// </summary>
    public readonly record struct Result(bool Active, ushort PreKeyOnFrequencyWord);

    /// <summary>Inactive sentinel — no emit, no cache update.</summary>
    public static readonly Result Inactive = new(false, 0);

    /// <summary>
    /// Computes the new frequency word for the current note plus
    /// bend value, gated on <paramref name="currentNote"/> != 0.
    /// </summary>
    public static Result Compute(
        byte currentNote,
        byte pitchMode,
        byte bendValue,
        AdgFrequencyLookupTable frequencyLookup,
        AdgPitchBendFractionsTable bendFractions,
        AdgPortamentoFractionsTable portamentoFractions) {
        ArgumentNullException.ThrowIfNull(frequencyLookup);
        ArgumentNullException.ThrowIfNull(bendFractions);
        ArgumentNullException.ThrowIfNull(portamentoFractions);

        if (currentNote == 0) {
            return Inactive;
        }

        // Decompose the (transposed) note into octave / semitone.
        byte noteOffset = (byte)(currentNote - NoteBaseOffset);
        byte octave = (byte)(noteOffset / SemitonesPerOctave);
        byte semitone = (byte)(noteOffset % SemitonesPerOctave);

        // AX is treated as a 16-bit value with Lo8 = bend value,
        // Hi8 = 0; the body then subtracts 0x40 (centre) to get a
        // signed delta in two's-complement.
        ushort ax = bendValue;
        bool negative = ax < BendCenter;
        ax = (ushort)(ax - BendCenter);

        ushort frequency;
        int adjustedLow;
        byte adjustedHigh;

        if (pitchMode == 0) {
            // === Pitch-bend mode ===
            byte fraction;
            if (negative) {
                ax = (ushort)(0 - ax);
                ax = Bits16.RotateRight(ax, 5);
                byte delta = (byte)(ax & 0xFF);
                if (semitone >= delta) {
                    semitone = (byte)(semitone - delta);
                } else {
                    semitone = (byte)(semitone + SemitonesPerOctave - delta);
                    octave = (byte)(octave - 1);
                    if ((octave & 0x80) != 0) {
                        octave = 0;
                        semitone = 0;
                    }
                }
                fraction = bendFractions.GetFraction(semitone);
                ushort mul = (ushort)(fraction * (byte)((ax >> 8) & 0xFF));
                byte adjustment = (byte)((mul >> 8) & 0xFF);
                frequency = frequencyLookup.GetFrequencyWord(semitone);
                adjustedLow = (frequency & 0xFF) - adjustment;
                adjustedHigh = (byte)(((frequency >> 8) & 0xFF) - (adjustedLow < 0 ? 1 : 0));
            } else {
                ax = (ushort)(ax + 1);
                ax = Bits16.RotateRight(ax, 5);
                byte delta = (byte)(ax & 0xFF);
                semitone = (byte)(semitone + delta);
                if (semitone >= SemitonesPerOctave) {
                    semitone = (byte)(semitone - SemitonesPerOctave);
                    octave = (byte)(octave + 1);
                }
                fraction = bendFractions.GetFraction(semitone + 1);
                ushort mul = (ushort)(fraction * (byte)((ax >> 8) & 0xFF));
                byte adjustment = (byte)((mul >> 8) & 0xFF);
                frequency = frequencyLookup.GetFrequencyWord(semitone);
                adjustedLow = (frequency & 0xFF) + adjustment;
                adjustedHigh = (byte)(((frequency >> 8) & 0xFF) + (adjustedLow > 0xFF ? 1 : 0));
            }
        } else {
            // === Portamento mode ===
            byte adjustment;
            if (negative) {
                ax = (ushort)(0 - ax);
                byte delta = (byte)(ax / 5);
                byte remainderPort = (byte)(ax % 5);
                if (semitone >= delta) {
                    semitone = (byte)(semitone - delta);
                } else {
                    semitone = (byte)(semitone + SemitonesPerOctave - delta);
                    octave = (byte)(octave - 1);
                    if ((octave & 0x80) != 0) {
                        octave = 0;
                        semitone = 0;
                    }
                }
                int portIndex = (semitone >= 6 ? 5 : 0) + remainderPort;
                adjustment = portamentoFractions.GetFraction(portIndex);
                frequency = frequencyLookup.GetFrequencyWord(semitone);
                adjustedLow = (frequency & 0xFF) - adjustment;
                adjustedHigh = (byte)(((frequency >> 8) & 0xFF) - (adjustedLow < 0 ? 1 : 0));
            } else {
                byte delta = (byte)(ax / 5);
                byte remainderPort = (byte)(ax % 5);
                semitone = (byte)(semitone + delta);
                if (semitone >= SemitonesPerOctave) {
                    semitone = (byte)(semitone - SemitonesPerOctave);
                    octave = (byte)(octave + 1);
                }
                int portIndex = (semitone >= 6 ? 5 : 0) + remainderPort;
                adjustment = portamentoFractions.GetFraction(portIndex);
                frequency = frequencyLookup.GetFrequencyWord(semitone);
                adjustedLow = (frequency & 0xFF) + adjustment;
                adjustedHigh = (byte)(((frequency >> 8) & 0xFF) + (adjustedLow > 0xFF ? 1 : 0));
            }
        }

        byte blockBits = (byte)(octave << BlockShift);
        ushort preKeyOn = (ushort)(((adjustedHigh | blockBits) << 8) | (adjustedLow & 0xFF));
        return new Result(true, preKeyOn);
    }
}
