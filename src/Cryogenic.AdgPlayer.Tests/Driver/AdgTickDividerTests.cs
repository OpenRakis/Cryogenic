namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 27a — Software tick divider that gates the per-beat scheduler
/// work. Decrements a byte counter; when the counter underflows from
/// 0 → 0xFF the divider has elapsed and reloads from a stored period.
/// Mirrors the byte at <c>AdgTickDividerOffset</c> (0x0127) in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c> and the
/// dec / jne / reload sequence in <c>AdgSchedulerTick_0756</c>.
/// </summary>
public sealed class AdgTickDividerTests {
	[Fact]
	public void DefaultPeriodIsOneAndCounterIsOne() {
		// Arrange + Act
		AdgTickDivider divider = new();

		// Assert
		Assert.Equal((byte)1, divider.Period);
		Assert.Equal((byte)1, divider.Counter);
	}

	[Fact]
	public void Reload_SetsPeriodAndCounter() {
		// Arrange
		AdgTickDivider divider = new();

		// Act
		divider.Reload(period: 6);

		// Assert
		Assert.Equal((byte)6, divider.Period);
		Assert.Equal((byte)6, divider.Counter);
	}

	[Fact]
	public void Tick_ReturnsFalseWhilePending() {
		// Arrange — period 3 → counter 3, ticks 1 & 2 should return false.
		AdgTickDivider divider = new();
		divider.Reload(period: 3);

		// Act + Assert
		Assert.False(divider.Tick());
		Assert.False(divider.Tick());
	}

	[Fact]
	public void Tick_ReturnsTrueAndReloadsOnExpiration() {
		// Arrange
		AdgTickDivider divider = new();
		divider.Reload(period: 3);

		// Act
		divider.Tick();
		divider.Tick();
		bool elapsed = divider.Tick();

		// Assert — third tick must signal the elapsed counter and
		// reload the counter back to the stored period.
		Assert.True(elapsed);
		Assert.Equal((byte)3, divider.Counter);
	}

	[Fact]
	public void Tick_PeriodOne_FiresOnEveryCall() {
		// Arrange
		AdgTickDivider divider = new();
		divider.Reload(period: 1);

		// Act + Assert
		Assert.True(divider.Tick());
		Assert.True(divider.Tick());
		Assert.True(divider.Tick());
	}

	[Fact]
	public void Reload_ZeroPeriod_Throws() {
		// Arrange
		AdgTickDivider divider = new();

		// Act + Assert — period 0 would create a non-progressing divider.
		Assert.Throws<ArgumentOutOfRangeException>(() => divider.Reload(0));
	}
}