namespace Cryogenic.Tests.Steps;

using Cryogenic.OverrideLogic;
using Cryogenic.Tests.Harness;

using Reqnroll;

using Xunit;

/// <summary>
/// Reqnroll step definitions for intro-scene node direction BDD scenarios.
/// Exercises <see cref="IntroLogic.ComputeNodeDirectionByte"/> which encodes the
/// pure logic of <c>loc_001e0</c> (seg000:01E0).
/// </summary>
[Binding]
public sealed class IntroLogicStepDefinitions {

	private readonly OverrideTestHarness _harness;
	private byte _tileType;
	private byte _directionByte;
	private byte _result;

	/// <summary>Initialises the step definitions with the scenario-scoped harness.</summary>
	public IntroLogicStepDefinitions(OverrideTestHarness harness) {
		_harness = harness;
	}

	[Given("an intro node tile type of {int}")]
	public void GivenAnIntroNodeTileTypeOf(int tileType) {
		_tileType = (byte)tileType;
	}

	[Given("a current intro node direction byte of {int}")]
	public void GivenACurrentIntroNodeDirectionByteOf(int directionByte) {
		_directionByte = (byte)directionByte;
	}

	[When("I compute the intro node direction byte")]
	public void WhenIComputeTheIntroNodeDirectionByte() {
		_result = IntroLogic.ComputeNodeDirectionByte(_tileType, _directionByte);
	}

	[Then("the computed intro node direction byte should be {int}")]
	public void ThenTheComputedIntroNodeDirectionByteShouldBe(int expected) {
		Assert.Equal((byte)expected, _result);
	}
}