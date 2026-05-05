namespace Cryogenic.Tests.Steps;

using Cryogenic.Tests.Harness;
using Reqnroll;
using Xunit;

/// <summary>
/// Reqnroll step definitions for reading and asserting x86 CPU register and flag state
/// via the <see cref="OverrideTestHarness"/>.
/// </summary>
[Binding]
public sealed class CpuStateStepDefinitions {

	private readonly OverrideTestHarness _harness;

	/// <summary>Initialises the step definitions with the scenario-scoped harness.</summary>
	public CpuStateStepDefinitions(OverrideTestHarness harness) {
		_harness = harness;
	}

	[Given("AX is {int}")]
	public void GivenAXIs(int value) => _harness.AX = (ushort)value;

	[Given("BX is {int}")]
	public void GivenBXIs(int value) => _harness.BX = (ushort)value;

	[Given("CX is {int}")]
	public void GivenCXIs(int value) => _harness.CX = (ushort)value;

	[Given("DX is {int}")]
	public void GivenDXIs(int value) => _harness.DX = (ushort)value;

	[Given("SI is {int}")]
	public void GivenSIIs(int value) => _harness.SI = (ushort)value;

	[Given("DI is {int}")]
	public void GivenDIIs(int value) => _harness.DI = (ushort)value;

	[Given("DS is {int}")]
	public void GivenDSIs(int value) => _harness.DS = (ushort)value;

	[Given("ES is {int}")]
	public void GivenESIs(int value) => _harness.ES = (ushort)value;

	[Then("AX should be {int}")]
	public void ThenAXShouldBe(int expected) => Assert.Equal((ushort)expected, _harness.AX);

	[Then("BX should be {int}")]
	public void ThenBXShouldBe(int expected) => Assert.Equal((ushort)expected, _harness.BX);

	[Then("CX should be {int}")]
	public void ThenCXShouldBe(int expected) => Assert.Equal((ushort)expected, _harness.CX);

	[Then("DX should be {int}")]
	public void ThenDXShouldBe(int expected) => Assert.Equal((ushort)expected, _harness.DX);

	[Then("SI should be {int}")]
	public void ThenSIShouldBe(int expected) => Assert.Equal((ushort)expected, _harness.SI);

	[Then("DI should be {int}")]
	public void ThenDIShouldBe(int expected) => Assert.Equal((ushort)expected, _harness.DI);

	[Then("the carry flag should be set")]
	public void ThenTheCarryFlagShouldBeSet() => Assert.True(_harness.CarryFlag);

	[Then("the carry flag should be clear")]
	public void ThenTheCarryFlagShouldBeClear() => Assert.False(_harness.CarryFlag);

	[Then("the zero flag should be set")]
	public void ThenTheZeroFlagShouldBeSet() => Assert.True(_harness.ZeroFlag);

	[Then("the zero flag should be clear")]
	public void ThenTheZeroFlagShouldBeClear() => Assert.False(_harness.ZeroFlag);
}
