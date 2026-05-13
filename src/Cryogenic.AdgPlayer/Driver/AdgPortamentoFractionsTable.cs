namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Read-only 10-byte fractional adjustment table referenced by
/// <c>AdgPitchBendBody_0D8B</c> at offset <c>0x01D4</c> in the
/// DNADG driver image (portamento branch only).
///
/// The body addresses this table as <c>portamento[base + r]</c>
/// where <c>base ∈ {0,5}</c> (low semitones vs high semitones) and
/// <c>r ∈ [0,4]</c> is the modulo-5 remainder of the bend
/// magnitude. The index sweep covers <c>[0,9]</c>, so the table
/// holds 10 bytes.
///
/// Values are runtime-populated by the AdLib Gold driver init
/// (zero in the on-disk <c>.HSQ</c>); callers must supply the
/// correct byte sequence when constructing this table.
/// </summary>
public sealed class AdgPortamentoFractionsTable {
	/// <summary>Number of fraction bytes in the table.</summary>
	public const int EntryCount = 10;

	private readonly byte[] _entries;

	/// <summary>Constructs a portamento fraction table from <paramref name="entries"/>.</summary>
	public AdgPortamentoFractionsTable(byte[] entries) {
		ArgumentNullException.ThrowIfNull(entries);
		if (entries.Length != EntryCount) {
			throw new ArgumentException(
				$"Portamento fractions table must contain exactly {EntryCount} bytes.",
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

	/// <summary>
	/// Live-captured default fraction sequence taken from the
	/// runtime-initialised DNADG driver at <c>segment 0x5BAE,
	/// offset 0x01D4</c> (read_memory via Spice86 MCP). Two
	/// 5-byte sub-tables: low-semitone group (indices 0..4) and
	/// high-semitone group (indices 5..9).
	/// </summary>
	public static readonly byte[] DefaultEntries = new byte[] {
		0x00, 0x05, 0x0A, 0x0F, 0x14,
		0x00, 0x06, 0x0C, 0x12, 0x18,
	};

	/// <summary>
	/// Builds a portamento fraction table populated with
	/// <see cref="DefaultEntries"/>.
	/// </summary>
	public static AdgPortamentoFractionsTable CreateDefault() {
		return new AdgPortamentoFractionsTable(DefaultEntries);
	}
}