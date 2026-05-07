namespace Cryogenic.Symbols;

using System.Collections.Generic;

/// <summary>
/// Provides address-based and name-based lookup over the DNCDPRG.lst symbol table.
/// </summary>
/// <remarks>
/// The table is populated from the IDA listing produced for DNCDPRG.EXE.
/// All lookups operate in O(1) or O(n) time over the pre-parsed symbol set.
/// </remarks>
public interface ILstSymbolTable {
	/// <summary>
	/// Finds a symbol at the given segment and offset.
	/// </summary>
	/// <param name="segment">
	/// Segment name as it appears in the listing (for example, "seg000").
	/// </param>
	/// <param name="offset">Offset within the segment.</param>
	/// <returns>
	/// The symbol defined at that address, or <c>null</c> if none is recorded.
	/// When multiple labels share the same address, the last-defined one is returned.
	/// </returns>
	LstSymbol? FindByAddress(string segment, ushort offset);

	/// <summary>
	/// Returns all symbols whose name contains <paramref name="nameSubstring"/>
	/// (case-insensitive, ordinal comparison).
	/// </summary>
	/// <param name="nameSubstring">Substring to match against symbol names.</param>
	/// <param name="includeAutoLabels">
	/// When <c>true</c>, includes auto-generated labels whose names start with "loc_" or "sub_".
	/// Defaults to <c>false</c> so only meaningful reverse-engineered names are returned.
	/// </param>
	/// <returns>All matching symbols ordered by segment then offset.</returns>
	IReadOnlyList<LstSymbol> FindByName(string nameSubstring, bool includeAutoLabels = false);

	/// <summary>
	/// Returns all symbols in the table.
	/// </summary>
	/// <param name="includeAutoLabels">
	/// When <c>true</c>, includes auto-generated labels (loc_, sub_).
	/// Defaults to <c>false</c>.
	/// </param>
	/// <returns>All symbols ordered by segment then offset.</returns>
	IReadOnlyList<LstSymbol> GetAll(bool includeAutoLabels = false);
}