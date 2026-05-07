namespace Cryogenic.Symbols;

/// <summary>
/// Represents a single labeled symbol entry from a DNCDPRG.lst disassembly listing.
/// </summary>
/// <remarks>
/// Each entry corresponds to a labeled line in the listing, for example:
/// <c>seg000:00B0  initialize_resources:  ; CODE XREF: seg000:0009</c>
/// </remarks>
public sealed record LstSymbol {
	/// <summary>
	/// Gets the segment name as it appears in the listing (for example, "seg000").
	/// </summary>
	public required string Segment { get; init; }

	/// <summary>
	/// Gets the offset within the segment, in hexadecimal integer form.
	/// </summary>
	public required ushort Offset { get; init; }

	/// <summary>
	/// Gets the symbol name exactly as it appears before the colon in the listing.
	/// </summary>
	public required string Name { get; init; }

	/// <summary>
	/// Gets whether this symbol is an auto-generated label (name starts with "loc_" or "sub_")
	/// rather than a meaningful reverse-engineered name.
	/// </summary>
	public required bool IsAutoLabel { get; init; }
}