namespace Cryogenic.Tests.Symbols;

using Cryogenic.Symbols;

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
		LstSymbolTableFactory factory = CreateFactory();
		ILstSymbolTable table = factory.Build();
		System.Collections.Generic.IReadOnlyList<LstSymbol> named = table.GetAll(includeAutoLabels: false);
		Assert.True(named.Count > 0, "Expected at least one named symbol from the embedded DNCDPRG.lst.");
	}

	/// <summary>
	/// The embedded listing contains the well-known 'start' symbol at offset 0x0000 of seg000.
	/// </summary>
	[Fact]
	public void Build_WithEmbeddedResource_ContainsStartSymbol() {
		LstSymbolTableFactory factory = CreateFactory();
		ILstSymbolTable table = factory.Build();
		LstSymbol? sym = table.FindByAddress("seg000", 0x0000);
		Assert.NotNull(sym);
		Assert.Equal("start", sym.Name);
		Assert.False(sym.IsAutoLabel);
	}

	/// <summary>
	/// The embedded listing contains 'play_intro' as a named function.
	/// </summary>
	[Fact]
	public void Build_WithEmbeddedResource_FindByNameLocatesPlayIntro() {
		LstSymbolTableFactory factory = CreateFactory();
		ILstSymbolTable table = factory.Build();
		System.Collections.Generic.IReadOnlyList<LstSymbol> results = table.FindByName("play_intro");
		Assert.NotEmpty(results);
		Assert.Contains(results, s => string.Equals(s.Name, "play_intro", System.StringComparison.Ordinal));
	}

	/// <summary>
	/// The total symbol count (including auto-labels) from the embedded resource is in the
	/// expected range (the listing has 3683 total labeled entries).
	/// </summary>
	[Fact]
	public void Build_WithEmbeddedResource_TotalCountIsInExpectedRange() {
		LstSymbolTableFactory factory = CreateFactory();
		ILstSymbolTable table = factory.Build();
		System.Collections.Generic.IReadOnlyList<LstSymbol> all = table.GetAll(includeAutoLabels: true);
		// Validate we're getting a realistic number — the committed listing has 3683 labeled entries.
		Assert.InRange(all.Count, 3000, 5000);
	}
}
