namespace Cryogenic.Tests.Symbols;

using AwesomeAssertions;

using Cryogenic.Symbols;

using System.Collections.Generic;

/// <summary>
/// Integration tests for <see cref="LstSymbolTableFactory"/> that verify the embedded
/// DNCDPRG.lst resource can be loaded and produces a non-trivial symbol set.
/// </summary>
public sealed class LstSymbolTableFactoryTests {
	/// <summary>Factory under test, wired to the real parser.</summary>
	private static LstSymbolTableFactory CreateFactory() =>
		new(new LstSymbolParser());

	/// <summary>
	/// The factory loads the embedded resource and returns a table with a meaningful number
	/// of named symbols (the listing has 380 named symbols as of the committed resource).
	/// </summary>
	[Fact]
	public void Build_WithEmbeddedResource_ReturnsNonEmptyNamedSymbols() {
		// Arrange
		LstSymbolTableFactory factory = CreateFactory();

		// Act
		ILstSymbolTable table = factory.Build();
		IReadOnlyList<LstSymbol> named = table.GetAll(includeAutoLabels: false);

		// Assert
		named.Should().NotBeEmpty("the embedded DNCDPRG.lst should yield at least one named symbol");
	}

	/// <summary>
	/// The embedded listing contains the well-known 'start' symbol at offset 0x0000 of seg000.
	/// </summary>
	[Fact]
	public void Build_WithEmbeddedResource_ContainsStartSymbol() {
		// Arrange
		LstSymbolTableFactory factory = CreateFactory();
		ILstSymbolTable table = factory.Build();

		// Act
		LstSymbolLookup lookup = table.FindByAddress("seg000", 0x0000);

		// Assert
		lookup.Found.Should().BeTrue();
		lookup.Symbol.Name.Should().Be("start");
		lookup.Symbol.IsAutoLabel.Should().BeFalse();
	}

	/// <summary>
	/// The embedded listing contains 'play_intro' as a named function.
	/// </summary>
	[Fact]
	public void Build_WithEmbeddedResource_FindByNameLocatesPlayIntro() {
		// Arrange
		LstSymbolTableFactory factory = CreateFactory();
		ILstSymbolTable table = factory.Build();

		// Act
		IReadOnlyList<LstSymbol> results = table.FindByName("play_intro");

		// Assert
		results.Should().NotBeEmpty();
		results.Should().Contain(s => string.Equals(s.Name, "play_intro", System.StringComparison.Ordinal));
	}

	/// <summary>
	/// The total symbol count (including auto-labels) from the embedded resource is in the
	/// expected range (the listing has 3683 total labeled entries).
	/// </summary>
	[Fact]
	public void Build_WithEmbeddedResource_TotalCountIsInExpectedRange() {
		// Arrange
		LstSymbolTableFactory factory = CreateFactory();
		ILstSymbolTable table = factory.Build();

		// Act
		IReadOnlyList<LstSymbol> all = table.GetAll(includeAutoLabels: true);

		// Assert
		// The committed listing has 3683 labeled entries; allow a generous range.
		all.Should().HaveCountGreaterThanOrEqualTo(3000).And.HaveCountLessThanOrEqualTo(5000);
	}
}
