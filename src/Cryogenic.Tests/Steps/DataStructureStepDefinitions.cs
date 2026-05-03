namespace Cryogenic.Tests.Steps;

using Cryogenic.OverrideLogic;
using Cryogenic.Tests.Harness;
using Reqnroll;
using Xunit;

/// <summary>
/// Reqnroll step definitions for data-structure manipulation BDD scenarios.
/// Exercises <see cref="DataStructureLogic"/> helpers that encode the pure logic
/// of specific game override methods.
/// </summary>
[Binding]
public sealed class DataStructureStepDefinitions {

	private readonly OverrideTestHarness _harness;
	private ushort[] _wordTable = [];
	private ushort _baseOffset;

	/// <summary>Initialises the step definitions with the scenario-scoped harness.</summary>
	public DataStructureStepDefinitions(OverrideTestHarness harness) {
		_harness = harness;
	}

	[Given(@"a word table containing \[(.+)\]")]
	public void GivenAWordTableContaining(string tableValues) {
		_wordTable = ParseWordList(tableValues);
	}

	[Given("an empty word table")]
	public void GivenAnEmptyWordTable() {
		_wordTable = [];
	}

	[Given("a base offset of {int}")]
	public void GivenABaseOffsetOf(int offset) {
		_baseOffset = (ushort)offset;
	}

	[When("I call AdjustOffsetTable")]
	public void WhenICallAdjustOffsetTable() {
		DataStructureLogic.AdjustOffsetTable(_wordTable, _baseOffset);
	}

	[Then(@"the word table should equal \[(.+)\]")]
	public void ThenTheWordTableShouldEqual(string expectedValues) {
		ushort[] expected = ParseWordList(expectedValues);
		Assert.Equal(expected, _wordTable);
	}

	[Then("the word table should be empty")]
	public void ThenTheWordTableShouldBeEmpty() {
		Assert.Empty(_wordTable);
	}

	private static ushort[] ParseWordList(string input) {
		return input
			.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
			.Select(s => ushort.Parse(s))
			.ToArray();
	}
}
