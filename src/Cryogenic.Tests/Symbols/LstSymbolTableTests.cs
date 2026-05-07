namespace Cryogenic.Tests.Symbols;

using AwesomeAssertions;

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

	/// <summary>Returns the symbol defined at the given address.</summary>
	[Fact]
	public void FindByAddress_ExistingNamedSymbol_ReturnsCorrectSymbol() {
		// Arrange
		ILstSymbolTable table = BuildTable(SampleSymbols());

		// Act
		LstSymbol? result = table.FindByAddress("seg000", 0x003A);

		// Assert
		result.Should().NotBeNull();
		result!.Name.Should().Be("exit_with_error");
	}

	/// <summary>Returns an auto-label at the given address.</summary>
	[Fact]
	public void FindByAddress_ExistingAutoLabel_ReturnsSymbol() {
		// Arrange
		ILstSymbolTable table = BuildTable(SampleSymbols());

		// Act
		LstSymbol? result = table.FindByAddress("seg000", 0x0056);

		// Assert
		result.Should().NotBeNull();
		result!.IsAutoLabel.Should().BeTrue();
	}

	/// <summary>Returns null when no symbol is defined at the address.</summary>
	[Fact]
	public void FindByAddress_NoSymbolAtAddress_ReturnsNull() {
		// Arrange
		ILstSymbolTable table = BuildTable(SampleSymbols());

		// Act
		LstSymbol? result = table.FindByAddress("seg000", 0x1234);

		// Assert
		result.Should().BeNull();
	}

	/// <summary>Returns null when the segment name does not exist in the table.</summary>
	[Fact]
	public void FindByAddress_UnknownSegment_ReturnsNull() {
		// Arrange
		ILstSymbolTable table = BuildTable(SampleSymbols());

		// Act
		LstSymbol? result = table.FindByAddress("seg999", 0x0000);

		// Assert
		result.Should().BeNull();
	}

	/// <summary>When two symbols share the same address, the last one in the list wins.</summary>
	[Fact]
	public void FindByAddress_DuplicateAddress_ReturnsLastDefined() {
		// Arrange
		IReadOnlyList<LstSymbol> symbols = [
			new LstSymbol { Segment = "seg000", Offset = 0x00D1, Name = "initialize_resources", IsAutoLabel = false },
			new LstSymbol { Segment = "seg000", Offset = 0x00D1, Name = "initialize_resources_alias", IsAutoLabel = false }
		];
		ILstSymbolTable table = BuildTable(symbols);

		// Act
		LstSymbol? result = table.FindByAddress("seg000", 0x00D1);

		// Assert
		result.Should().NotBeNull();
		result!.Name.Should().Be("initialize_resources_alias");
	}

	/// <summary>Returns symbols whose names contain the substring (case-insensitive).</summary>
	[Fact]
	public void FindByName_CaseInsensitiveSubstring_ReturnsMatches() {
		// Arrange
		ILstSymbolTable table = BuildTable(SampleSymbols());

		// Act
		IReadOnlyList<LstSymbol> result = table.FindByName("INTRO");

		// Assert
		result.Should().ContainSingle();
		result.Should().OnlyContain(s => s.Name.Contains("intro", StringComparison.OrdinalIgnoreCase));
	}

	/// <summary>By default, auto-labels are excluded from FindByName results.</summary>
	[Fact]
	public void FindByName_DefaultExcludesAutoLabels() {
		// Arrange
		ILstSymbolTable table = BuildTable(SampleSymbols());

		// Act
		IReadOnlyList<LstSymbol> result = table.FindByName("loc_");

		// Assert
		result.Should().BeEmpty();
	}

	/// <summary>When includeAutoLabels is true, auto-labels are included in the results.</summary>
	[Fact]
	public void FindByName_IncludeAutoLabels_ReturnsAutoLabels() {
		// Arrange
		ILstSymbolTable table = BuildTable(SampleSymbols());

		// Act
		IReadOnlyList<LstSymbol> result = table.FindByName("loc_", includeAutoLabels: true);

		// Assert
		result.Should().ContainSingle();
		result[0].IsAutoLabel.Should().BeTrue();
	}

	/// <summary>Returns an empty list when no name matches.</summary>
	[Fact]
	public void FindByName_NoMatch_ReturnsEmpty() {
		// Arrange
		ILstSymbolTable table = BuildTable(SampleSymbols());

		// Act
		IReadOnlyList<LstSymbol> result = table.FindByName("zzz_no_such_symbol");

		// Assert
		result.Should().BeEmpty();
	}

	/// <summary>An empty substring matches all symbols (subject to includeAutoLabels filter).</summary>
	[Fact]
	public void FindByName_EmptySubstring_ReturnsAllNamedSymbols() {
		// Arrange
		ILstSymbolTable table = BuildTable(SampleSymbols());

		// Act
		IReadOnlyList<LstSymbol> result = table.FindByName("");

		// Assert
		// All named symbols (not auto-labels): start, exit_with_error, initialize_resources, play_intro = 4
		result.Should().HaveCount(4);
	}

	/// <summary>GetAll without flag returns only named symbols.</summary>
	[Fact]
	public void GetAll_Default_ExcludesAutoLabels() {
		// Arrange
		ILstSymbolTable table = BuildTable(SampleSymbols());

		// Act
		IReadOnlyList<LstSymbol> result = table.GetAll();

		// Assert
		result.Should().HaveCount(4);
		result.Should().OnlyContain(s => !s.IsAutoLabel);
	}

	/// <summary>GetAll with includeAutoLabels=true returns the complete set.</summary>
	[Fact]
	public void GetAll_IncludeAutoLabels_ReturnsAllSymbols() {
		// Arrange
		ILstSymbolTable table = BuildTable(SampleSymbols());

		// Act
		IReadOnlyList<LstSymbol> result = table.GetAll(includeAutoLabels: true);

		// Assert
		result.Should().HaveCount(5);
	}

	/// <summary>GetAll on an empty table returns an empty list.</summary>
	[Fact]
	public void GetAll_EmptyTable_ReturnsEmpty() {
		// Arrange
		ILstSymbolTable table = BuildTable(new List<LstSymbol>());

		// Act
		IReadOnlyList<LstSymbol> result = table.GetAll(includeAutoLabels: true);

		// Assert
		result.Should().BeEmpty();
	}

	/// <summary>Parser output fed directly into the table produces correct lookup behaviour.</summary>
	[Fact]
	public void RoundTrip_ParserOutputIntoTable_FindByAddressWorks() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = [
			"seg000:0000  start:",
			"seg000:021c  play_intro2:                                 ; CODE XREF: seg000:0013",
			"seg000:0056  loc_00056:                                   ; CODE XREF: seg000:004c"
		];
		IReadOnlyList<LstSymbol> symbols = parser.Parse(lines);
		ILstSymbolTable table = BuildTable(symbols);

		// Act
		LstSymbol? sym = table.FindByAddress("seg000", 0x021C);

		// Assert
		sym.Should().NotBeNull();
		sym!.Name.Should().Be("play_intro2");
	}
}
