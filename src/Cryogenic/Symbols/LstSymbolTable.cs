namespace Cryogenic.Symbols;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

/// <summary>
/// Provides fast address-based and name-based lookup over a parsed DNCDPRG.lst symbol set.
/// </summary>
/// <remarks>
/// The table is built once at construction time from a pre-parsed list of <see cref="LstSymbol"/>
/// entries produced by an <see cref="ILstSymbolParser"/>. All lookups then run in constant or
/// linear time without re-parsing the listing.
/// </remarks>
public sealed class LstSymbolTable : ILstSymbolTable {
	private readonly Dictionary<(string Segment, ushort Offset), LstSymbol> _byAddress;
	private readonly IReadOnlyList<LstSymbol> _allSymbols;
	private readonly IReadOnlyList<LstSymbol> _namedSymbols;

	/// <summary>
	/// Initializes the table from a pre-parsed list of symbols produced by <see cref="ILstSymbolParser"/>.
	/// </summary>
	/// <param name="symbols">
	/// All symbols to index. When two symbols share the same (segment, offset) key,
	/// the last one in the list wins for address-based lookup.
	/// </param>
	public LstSymbolTable(IReadOnlyList<LstSymbol> symbols) {
		_allSymbols = symbols;
		_namedSymbols = symbols.Where(static s => !s.IsAutoLabel).ToList();

		_byAddress = new Dictionary<(string, ushort), LstSymbol>(symbols.Count);
		foreach (LstSymbol sym in symbols) {
			_byAddress[(sym.Segment, sym.Offset)] = sym;
		}
	}

	/// <inheritdoc />
	public bool TryFindByAddress(string segment, ushort offset, [MaybeNullWhen(false)] out LstSymbol symbol) {
		return _byAddress.TryGetValue((segment, offset), out symbol);
	}

	/// <inheritdoc />
	public IReadOnlyList<LstSymbol> FindByName(string nameSubstring, bool includeAutoLabels = false) {
		IEnumerable<LstSymbol> source = includeAutoLabels ? _allSymbols : _namedSymbols;
		return source
			.Where(s => s.Name.Contains(nameSubstring, StringComparison.OrdinalIgnoreCase))
			.ToList();
	}

	/// <inheritdoc />
	public IReadOnlyList<LstSymbol> GetAll(bool includeAutoLabels = false) {
		return includeAutoLabels ? _allSymbols : _namedSymbols;
	}
}