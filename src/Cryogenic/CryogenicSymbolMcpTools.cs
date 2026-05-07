namespace Cryogenic;

using ModelContextProtocol.Server;

using Serilog;

using Cryogenic.Symbols;

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

/// <summary>
/// MCP tools that expose the embedded DNCDPRG.lst symbol table for live reverse-engineering work.
/// </summary>
/// <remarks>
/// <para>
/// This class is intentionally non-static so that an <see cref="ILstSymbolTable"/> can be supplied
/// through constructor injection. The symbol table is built once by the host and shared across all
/// tool invocations; no locking or lazy-initialisation is required because the table is effectively
/// frozen after construction.
/// </para>
/// <para>
/// The host (<see cref="DuneCdOverrideSupplier.GetMcpServices"/>) is responsible for instantiating
/// a single shared <see cref="ILstSymbolTable"/> and registering it as an MCP service so the
/// ModelContextProtocol activator can resolve this class via dependency injection.
/// </para>
/// </remarks>
[McpServerToolType]
public sealed class CryogenicSymbolMcpTools {
	private static readonly ILogger Logger = Log.ForContext<CryogenicSymbolMcpTools>();

	private readonly ILstSymbolTable _symbolTable;

	/// <summary>
	/// Initializes a new instance bound to the supplied symbol table.
	/// </summary>
	/// <param name="symbolTable">
	/// The pre-built, shared symbol table that backs all symbol lookup, search, and list tools.
	/// </param>
	public CryogenicSymbolMcpTools(ILstSymbolTable symbolTable) {
		_symbolTable = symbolTable;
	}

	/// <summary>
	/// Represents one symbol from the DNCDPRG.lst disassembly listing in MCP responses.
	/// </summary>
	public sealed class SymbolEntry {
		/// <summary>Gets the segment name as it appears in the listing (for example, "seg000").</summary>
		public required string Segment { get; init; }

		/// <summary>Gets the offset within the segment as a zero-padded hex string (for example, "00B0").</summary>
		public required string OffsetHex { get; init; }

		/// <summary>Gets the raw numeric offset value.</summary>
		public required int Offset { get; init; }

		/// <summary>Gets the symbol name.</summary>
		public required string Name { get; init; }

		/// <summary>
		/// Gets whether this is an auto-generated IDA label (name starts with "loc_" or "sub_").
		/// </summary>
		public required bool IsAutoLabel { get; init; }
	}

	/// <summary>
	/// Response payload for the symbol-lookup-by-address tool.
	/// </summary>
	/// <remarks>
	/// When no symbol is recorded at the queried address, <see cref="Found"/> is <c>false</c> and
	/// <see cref="Symbol"/> is populated with empty placeholder values. Callers must check
	/// <see cref="Found"/> before reading the symbol fields.
	/// </remarks>
	public sealed class SymbolLookupResponse {
		/// <summary>Gets whether a symbol was found at the requested address.</summary>
		public required bool Found { get; init; }

		/// <summary>Gets the segment queried.</summary>
		public required string Segment { get; init; }

		/// <summary>Gets the offset queried as a hex string.</summary>
		public required string OffsetHex { get; init; }

		/// <summary>Gets the matched symbol; empty placeholder when <see cref="Found"/> is <c>false</c>.</summary>
		public required SymbolEntry Symbol { get; init; }
	}

	/// <summary>
	/// Response payload for the symbol-search tool.
	/// </summary>
	public sealed class SymbolSearchResponse {
		/// <summary>Gets the substring that was searched.</summary>
		public required string Query { get; init; }

		/// <summary>Gets whether auto-labels were included in the search.</summary>
		public required bool IncludedAutoLabels { get; init; }

		/// <summary>Gets the total number of matches returned.</summary>
		public required int MatchCount { get; init; }

		/// <summary>Gets the list of matching symbols.</summary>
		public required IReadOnlyList<SymbolEntry> Matches { get; init; }
	}

	/// <summary>
	/// Response payload for the symbol-list tool.
	/// </summary>
	public sealed class SymbolListResponse {
		/// <summary>Gets whether auto-labels were included.</summary>
		public required bool IncludedAutoLabels { get; init; }

		/// <summary>Gets the total number of symbols returned.</summary>
		public required int Count { get; init; }

		/// <summary>Gets the complete symbol list.</summary>
		public required IReadOnlyList<SymbolEntry> Symbols { get; init; }
	}

	/// <summary>
	/// Looks up the symbol name defined at a specific segment and offset in the DNCDPRG.lst listing.
	/// </summary>
	/// <param name="segment">
	/// Segment name as it appears in the listing (for example, "seg000").
	/// </param>
	/// <param name="offset">
	/// Numeric offset within the segment (decimal or the integer representation of the hex offset).
	/// </param>
	/// <returns>A <see cref="SymbolLookupResponse"/> indicating whether a symbol was found.</returns>
	[McpServerTool(Name = "cryogenic_symbol_lookup", UseStructuredContent = true)]
	[Description("Look up the DNCDPRG.lst symbol defined at a given segment and offset. Parameters: segment (string, e.g. \"seg000\"), offset (int, decimal value of the hex offset, e.g. 0x00B0 = 176). Returns found flag, address, and symbol details.")]
	public SymbolLookupResponse CryogenicSymbolLookup(string segment, int offset) {
		Logger.Information("MCP tool invoked: cryogenic_symbol_lookup Segment={Segment}, Offset=0x{OffsetHex:X4}", segment, offset);
		ushort offsetValue = (ushort)offset;
		bool found = _symbolTable.TryFindByAddress(segment, offsetValue, out LstSymbol? sym);
		return new SymbolLookupResponse {
			Found = found,
			Segment = segment,
			OffsetHex = $"{offsetValue:X4}",
			Symbol = found ? ToSymbolEntry(sym!) : EmptySymbolEntry()
		};
	}

	/// <summary>
	/// Searches the DNCDPRG.lst symbol table for symbols whose names contain a given substring.
	/// </summary>
	/// <param name="nameSubstring">
	/// Case-insensitive substring to match against symbol names. Pass an empty string to list all.
	/// </param>
	/// <param name="includeAutoLabels">
	/// When <c>true</c>, includes IDA-generated labels (loc_, sub_).
	/// </param>
	/// <returns>A <see cref="SymbolSearchResponse"/> containing all matches.</returns>
	[McpServerTool(Name = "cryogenic_symbol_search", UseStructuredContent = true)]
	[Description("Search the DNCDPRG.lst symbol table by name substring. Parameters: nameSubstring (string, case-insensitive, empty = all), includeAutoLabels (bool, default false). Returns list of matching symbols with segment, offset, and name.")]
	public SymbolSearchResponse CryogenicSymbolSearch(string nameSubstring, bool includeAutoLabels) {
		Logger.Information("MCP tool invoked: cryogenic_symbol_search Query={Query}, IncludeAutoLabels={IncludeAutoLabels}", nameSubstring, includeAutoLabels);
		IReadOnlyList<LstSymbol> matches = _symbolTable.FindByName(nameSubstring, includeAutoLabels);
		return new SymbolSearchResponse {
			Query = nameSubstring,
			IncludedAutoLabels = includeAutoLabels,
			MatchCount = matches.Count,
			Matches = matches.Select(ToSymbolEntry).ToList()
		};
	}

	/// <summary>
	/// Returns all named symbols from the DNCDPRG.lst symbol table, optionally including auto-labels.
	/// </summary>
	/// <param name="includeAutoLabels">
	/// When <c>true</c>, includes IDA-generated labels (loc_, sub_).
	/// </param>
	/// <returns>A <see cref="SymbolListResponse"/> containing all symbols in listing order.</returns>
	[McpServerTool(Name = "cryogenic_symbols_list", UseStructuredContent = true)]
	[Description("List all symbols from the embedded DNCDPRG.lst disassembly. Parameters: includeAutoLabels (bool, default false — omit loc_/sub_ labels). Returns the full symbol set with segment, hex offset, and name.")]
	public SymbolListResponse CryogenicSymbolsList(bool includeAutoLabels) {
		Logger.Information("MCP tool invoked: cryogenic_symbols_list IncludeAutoLabels={IncludeAutoLabels}", includeAutoLabels);
		IReadOnlyList<LstSymbol> all = _symbolTable.GetAll(includeAutoLabels);
		return new SymbolListResponse {
			IncludedAutoLabels = includeAutoLabels,
			Count = all.Count,
			Symbols = all.Select(ToSymbolEntry).ToList()
		};
	}

	private static SymbolEntry ToSymbolEntry(LstSymbol sym) =>
		new() {
			Segment = sym.Segment,
			OffsetHex = $"{sym.Offset:X4}",
			Offset = sym.Offset,
			Name = sym.Name,
			IsAutoLabel = sym.IsAutoLabel
		};

	private static SymbolEntry EmptySymbolEntry() =>
		new() {
			Segment = string.Empty,
			OffsetHex = string.Empty,
			Offset = 0,
			Name = string.Empty,
			IsAutoLabel = false
		};
}
