namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 27c — Mutable holder of the song-loop counters used by
/// <c>AdgCheckLoopPoint_07DA</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>. Tracks the active
/// measure, subdivision and loop counter words. Pure state; the
/// snapshot-rep-movs side effect is owned by a different component.
/// </summary>
public sealed class AdgLoopStateTests {
	[Fact]
	public void Defaults_AreZero() {
		// Arrange + Act
		AdgLoopState state = new();

		// Assert
		Assert.Equal((ushort)0, state.Measure);
		Assert.Equal((ushort)0, state.Subdivision);
		Assert.Equal((ushort)0, state.LoopCounter);
	}

	[Fact]
	public void Setters_StoreExactValues() {
		// Arrange
		AdgLoopState state = new();

		// Act
		state.SetMeasure(0x0040);
		state.SetSubdivision(0x0060);
		state.SetLoopCounter(0x0003);

		// Assert
		Assert.Equal((ushort)0x0040, state.Measure);
		Assert.Equal((ushort)0x0060, state.Subdivision);
		Assert.Equal((ushort)0x0003, state.LoopCounter);
	}

	[Fact]
	public void Reset_ZeroesAllFields() {
		// Arrange
		AdgLoopState state = new();
		state.SetMeasure(0x10);
		state.SetSubdivision(0x20);
		state.SetLoopCounter(0x30);

		// Act
		state.Reset();

		// Assert
		Assert.Equal((ushort)0, state.Measure);
		Assert.Equal((ushort)0, state.Subdivision);
		Assert.Equal((ushort)0, state.LoopCounter);
	}

	[Fact]
	public void DecrementLoopCounter_StopsAtZero() {
		// Arrange
		AdgLoopState state = new();
		state.SetLoopCounter(2);

		// Act
		bool first = state.DecrementLoopCounter();
		bool second = state.DecrementLoopCounter();
		bool third = state.DecrementLoopCounter();

		// Assert — true means a remaining loop was consumed;
		// false means no more loops remain.
		Assert.True(first);
		Assert.True(second);
		Assert.False(third);
		Assert.Equal((ushort)0, state.LoopCounter);
	}
}