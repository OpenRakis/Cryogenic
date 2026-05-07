namespace Cryogenic.Tests.Symbols;

using Cryogenic.Symbols;

using System.Collections.Generic;

/// <summary>
/// Unit tests for <see cref="LstSymbolTable"/>.
/// </summary>
public sealed class LstSymbolTableTests {
	/// <summary>Builds a table from an inline set of symbols for test isolation.</summary>
	private static ILstSymbolTable BuildTable(IReadOnlyList<LstSymbol> symbols) =>
		new LstSymbolTable(symbols);

	private static IReadOnlyList<LstSymbol> SampleSymbols() => [
		new LstSymbol { Segment = "seg000", Offset = 0x0000, Name = "start", IsAutoLabel = false },
		new LstSymbol { Segment = "seg000", Offset = 0x003A, Name = "exit_with_error", IsAutoLabel = false },
		new LstSymbol { Segment = "seg000", Offset = 0x0056, Name = "loc_00056", IsAutoLabel = true },
		new LstSymbol { Segment = "seg000", Offset = 0x00B0, Name = "initialize_resources", IsAutoLabel = false },
		new LstSymbol { Segment = "seg000", Offset = 0x0580, Name = "play_intro", IsAutoLabel = false },
	];

	// ── FindByAddress ────────────────────────────────────────────────────────

	/// <summary>Returns the symbol defined at the given address.</summary>
	[Fact]
	public void FindByAddress_ExistingNamedSymbol_ReturnsCorrectSymbol() {
		ILstSymbolTable table = BuildTable(SampleSymbols());
		LstSymbol? result = table.FindByAddress("seg000", 0x003A);
		Assert.NotNull(result);
		Assert.Equal("exit_with_error", result.Name);
	}

	/// <summary>Returns an auto-label at the given address.</summary>
	[Fact]
	public void FindByAddress_ExistingAutoLabel_ReturnsSymbol() {
		ILstSymbolTable table = BuildTable(SampleSymbols());
		LstSymbol? result = table.FindByAddress("seg000", 0x0056);
		Assert.NotNull(result);
		Assert.True(result.IsAutoLabel);
	}

	/// <summary>Returns null when no symbol is defined at the address.</summary>
	[Fact]
	public void FindByAddress_NoSymbolAtAddress_ReturnsNull() {
		ILstSymbolTable table = BuildTable(SampleSymbols());
		LstSymbol? result = table.FindByAddress("seg000", 0x1234);
		Assert.Null(result);
	}

	/// <summary>Returns null when the segment name does not exist in the table.</summary>
	[Fact]
	public void FindByAddress_UnknownSegment_ReturnsNull() {
		ILstSymbolTable table = BuildTable(SampleSymbols());
		LstSymbol? result = table.FindByAddress("seg999", 0x0000);
		Assert.Null(result);
	}

	/// <summary>When two symbols share the same address, the last one in the list wins.</summary>
	[Fact]
	public void FindByAddress_DuplicateAddress_ReturnsLastDefined() {
		IReadOnlyList<LstSymbol> symbols = [
			new LstSymbol { Segment = "seg000", Offset = 0x00D1, Name = "initialize_resources", IsAutoLabel = false },
			new LstSymbol { Segment = "seg000", Offset = 0x00D1, Name = "initialize_resources_alias", IsAutoLabel = false }
		];
		ILstSymbolTable table = BuildTable(symbols);
		LstSymbol? result = table.FindByAddress("seg000", 0x00D1);
		Assert.NotNull(result);
		Assert.Equal("initialize_resources_alias", result.Name);
	}

	// ── FindByName ───────────────────────────────────────────────────────────

	/// <summary>Returns symbols whose names contain the substring (case-insensitive).</summary>
	[Fact]
	public void FindByName_CaseInsensitiveSubstring_ReturnsMatches() {
		ILstSymbolTable table = BuildTable(SampleSymbols());
		IReadOnlyList<LstSymbol> result = table.FindByName("INTRO");
		Assert.Single(result);
		Assert.All(result, s => Assert.Contains("intro", s.Name, StringComparison.OrdinalIgnoreCase));
	}

	/// <summary>By default, auto-labels are excluded from FindByName results.</summary>
	[Fact]
	public void FindByName_DefaultExcludesAutoLabels() {
		ILstSymbolTable table = BuildTable(SampleSymbols());
		IReadOnlyList<LstSymbol> result = table.FindByName("loc_");
		Assert.Empty(result);
	}

	/// <summary>When includeAutoLabels is true, auto-labels are included in the results.</summary>
	[Fact]
	public void FindByName_IncludeAutoLabels_ReturnsAutoLabels() {
		ILstSymbolTable table = BuildTable(SampleSymbols());
		IReadOnlyList<LstSymbol> result = table.FindByName("loc_", includeAutoLabels: true);
		Assert.Single(result);
		Assert.True(result[0].IsAutoLabel);
	}

	/// <summary>Returns an empty list when no name matches.</summary>
	[Fact]
	public void FindByName_NoMatch_ReturnsEmpty() {
		ILstSymbolTable table = BuildTable(SampleSymbols());
		IReadOnlyList<LstSymbol> result = table.FindByName("zzz_no_such_symbol");
		Assert.Empty(result);
	}

	/// <summary>An empty substring matches all symbols (subject to includeAutoLabels filter).</summary>
	[Fact]
	public void FindByName_EmptySubstring_ReturnsAllNamedSymbols() {
		ILstSymbolTable table = BuildTable(SampleSymbols());
		IReadOnlyList<LstSymbol> result = table.FindByName("");
		// All named symbols (not auto-labels): start, exit_with_error, initialize_resources, play_intro = 4
		Assert.Equal(4, result.Count);
	}

	// ── GetAll ───────────────────────────────────────────────────────────────

	/// <summary>GetAll without flag returns only named symbols.</summary>
	[Fact]
	public void GetAll_Default_ExcludesAutoLabels() {
		ILstSymbolTable table = BuildTable(SampleSymbols());
		IReadOnlyList<LstSymbol> result = table.GetAll();
		Assert.All(result, s => Assert.False(s.IsAutoLabel));
		Assert.Equal(4, result.Count);
	}

	/// <summary>GetAll with includeAutoLabels=true returns the complete set.</summary>
	[Fact]
	public void GetAll_IncludeAutoLabels_ReturnsAllSymbols() {
		ILstSymbolTable table = BuildTable(SampleSymbols());
		IReadOnlyList<LstSymbol> result = table.GetAll(includeAutoLabels: true);
		Assert.Equal(5, result.Count);
	}

	/// <summary>GetAll on an empty table returns an empty list.</summary>
	[Fact]
	public void GetAll_EmptyTable_ReturnsEmpty() {
		ILstSymbolTable table = BuildTable(new List<LstSymbol>());
		IReadOnlyList<LstSymbol> result = table.GetAll(includeAutoLabels: true);
		Assert.Empty(result);
	}

	// ── Round-trip via parser ────────────────────────────────────────────────

	/// <summary>Parser output fed directly into the table produces correct lookup behaviour.</summary>
	[Fact]
	public void RoundTrip_ParserOutputIntoTable_FindByAddressWorks() {
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = [
			"seg000:0000  start:",
			"seg000:021c  play_intro2:                                 ; CODE XREF: seg000:0013",
			"seg000:0056  loc_00056:                                   ; CODE XREF: seg000:004c"
		];
		IReadOnlyList<LstSymbol> symbols = parser.Parse(lines);
		ILstSymbolTable table = BuildTable(symbols);

		LstSymbol? sym = table.FindByAddress("seg000", 0x021C);
		Assert.NotNull(sym);
		Assert.Equal("play_intro2", sym.Name);
	}
}
