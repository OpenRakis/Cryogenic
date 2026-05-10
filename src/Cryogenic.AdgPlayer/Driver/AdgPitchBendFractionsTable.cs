namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Read-only 13-byte semitone fraction table referenced by
/// <c>AdgPitchBendBody_0D8B</c> at offset <c>0x01C7</c> in the
/// DNADG driver image.
///
/// The table is indexed by either <c>semitone</c> (downward bend
/// branch) or <c>semitone + 1</c> (upward bend branch); since the
/// branches sweep <c>semitone</c> in <c>[0,11]</c>, the upward path
/// can read up to index 12 — so the table holds 13 bytes.
///
/// Values are runtime-populated by the AdLib Gold driver init code
/// (zero in the on-disk <c>.HSQ</c>); callers are responsible for
/// supplying the correct byte sequence when constructing this
/// table.
/// </summary>
public sealed class AdgPitchBendFractionsTable {
    /// <summary>Number of fraction bytes in the table.</summary>
    public const int EntryCount = 13;

    private readonly byte[] _entries;

    /// <summary>Constructs a fraction table from <paramref name="entries"/>.</summary>
    public AdgPitchBendFractionsTable(byte[] entries) {
        ArgumentNullException.ThrowIfNull(entries);
        if (entries.Length != EntryCount) {
            throw new ArgumentException(
                $"Pitch-bend fractions table must contain exactly {EntryCount} bytes.",
                nameof(entries));
        }
        _entries = (byte[])entries.Clone();
    }

    /// <summary>Reads the byte at <paramref name="index"/>.</summary>
    public byte GetFraction(int index) {
        if (index < 0 || index >= EntryCount) {
            throw new ArgumentOutOfRangeException(nameof(index),
                index, $"Index must be within [0,{EntryCount}).");
        }
        return _entries[index];
    }
}
