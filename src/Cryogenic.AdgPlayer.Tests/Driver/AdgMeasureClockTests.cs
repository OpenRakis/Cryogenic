namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgMeasureClock"/>.
/// </summary>
public sealed class AdgMeasureClockTests {
	/// <summary>
	/// <c>Initialize</c> sets <see cref="AdgLoopState.Measure"/> to 1
	/// and <see cref="AdgLoopState.Subdivision"/> to 0x60, matching
	/// the original AdgReset/AdgOpenSong reload at dnadg:07A3.
	/// </summary>
	[Fact]
	public void Initialize_SetsMeasureToOneAndSubdivisionTo0x60() {
		// Arrange
		AdgLoopState loopState = new();
		AdgMeasureClock clock = new(loopState);

		// Act
		clock.Initialize();

		// Assert
		Assert.Equal(1, loopState.Measure);
		Assert.Equal(0x60, loopState.Subdivision);
	}

	/// <summary>
	/// While the subdivision counter has not yet rolled, advancing
	/// only decrements it without touching the measure word.
	/// </summary>
	[Fact]
	public void AdvanceSubdivision_DecrementsSubdivision_DoesNotRollMeasure() {
		// Arrange
		AdgLoopState loopState = new();
		AdgMeasureClock clock = new(loopState);
		clock.Initialize();

		// Act
		bool rolled = clock.AdvanceSubdivision();

		// Assert
		Assert.False(rolled);
		Assert.Equal(0x5F, loopState.Subdivision);
		Assert.Equal(1, loopState.Measure);
	}

	/// <summary>
	/// When the subdivision counter rolls from 1 to 0, it is
	/// reloaded to 0x60 and the measure word is incremented.
	/// </summary>
	[Fact]
	public void AdvanceSubdivision_OnRollover_ReloadsAndIncrementsMeasure() {
		// Arrange
		AdgLoopState loopState = new();
		AdgMeasureClock clock = new(loopState);
		clock.Initialize();
		for (int i = 0; i < 0x5F; i++) {
			clock.AdvanceSubdivision();
		}

		// Act
		bool rolled = clock.AdvanceSubdivision();

		// Assert
		Assert.True(rolled);
		Assert.Equal(0x60, loopState.Subdivision);
		Assert.Equal(2, loopState.Measure);
	}

	/// <summary>
	/// Two complete subdivision cycles bump the measure word by two.
	/// </summary>
	[Fact]
	public void AdvanceSubdivision_TwoFullCycles_IncrementsMeasureTwice() {
		// Arrange
		AdgLoopState loopState = new();
		AdgMeasureClock clock = new(loopState);
		clock.Initialize();

		// Act
		for (int i = 0; i < 0x60 * 2; i++) {
			clock.AdvanceSubdivision();
		}

		// Assert
		Assert.Equal(0x60, loopState.Subdivision);
		Assert.Equal(3, loopState.Measure);
	}
}