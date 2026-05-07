namespace Cryogenic.Symbols;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Provides address-based and name-based lookup over the DNCDPRG.lst symbol table.
/// </summary>
/// <remarks>
/// The table is populated from the IDA listing produced for DNCDPRG.EXE.
/// All lookups operate in O(1) or O(n) time over the pre-parsed symbol set.
/// </remarks>
public interface ILstSymbolTable {
	/// <summary>
	/// Attempts to find a symbol at the given segment and offset.
	/// </summary>
	/// <param name="segment">
	/// Segment name as it appears in the listing (for example, "seg000").
	/// </param>
	/// <param name="offset">Offset within the segment.</param>
	/// <param name="symbol">
	/// When this method returns <c>true</c>, contains the symbol defined at that address;
	/// when it returns <c>false</c>, the value is undefined and must not be read.
	/// When multiple labels share the same address, the last-defined one is returned.
	/// </param>
	/// <returns><c>true</c> when a symbol is recorded at that address; otherwise <c>false</c>.</returns>
	bool TryFindByAddress(string segment, ushort offset, [MaybeNullWhen(false)] out LstSymbol symbol);

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