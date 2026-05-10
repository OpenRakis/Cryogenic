namespace Cryogenic.AdgPlayer.Tests.Driver;

using System.Collections.Generic;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Tests for <see cref="AdgPitchModulationAdvancer"/>, the pure
/// port of <c>AdgAdvancePitchModulation_07AD</c>.
/// </summary>
public sealed class AdgPitchModulationAdvancerTests {
	private sealed class RecordingBody : IAdgPitchBendBody {
		public List<(int Channel, ushort Bend)> Calls { get; } = new();
		public void Emit(int channelIndex, ushort bendWord) {
			Calls.Add((channelIndex, bendWord));
		}
	}

	/// <summary>
	/// Pitch bend counter at zero short-circuits: nothing changes
	/// and the body is not invoked.
	/// </summary>
	[Fact]
	public void Advance_CounterZero_NoOp() {
		// Arrange
		AdgChannelPitchBendCounters counters = new();
		AdgChannelEventPointers pointers = new();
		AdgChannelPitchAccumulators accumulators = new();
		AdgChannelPitchAccumulatorSteps steps = new();
		pointers.Set(2, 0x1234);
		accumulators.Set(2, 0x40);
		steps.Set(2, 0x05);
		RecordingBody body = new();

		// Act
		bool fired = AdgPitchModulationAdvancer.Advance(
			2, counters, pointers, accumulators, steps, body);

		// Assert
		Assert.False(fired);
		Assert.Empty(body.Calls);
		Assert.Equal(0x40, accumulators.Get(2));
	}

	/// <summary>
	/// Counter non-zero but event pointer zero: still skipped
	/// (mirrors dnadg:07B7 / 07B9).
	/// </summary>
	[Fact]
	public void Advance_PointerZero_NoOp() {
		// Arrange
		AdgChannelPitchBendCounters counters = new();
		AdgChannelEventPointers pointers = new();
		AdgChannelPitchAccumulators accumulators = new();
		AdgChannelPitchAccumulatorSteps steps = new();
		counters.Set(0, 5);
		RecordingBody body = new();

		// Act
		bool fired = AdgPitchModulationAdvancer.Advance(
			0, counters, pointers, accumulators, steps, body);

		// Assert
		Assert.False(fired);
		Assert.Empty(body.Calls);
		Assert.Equal(5, counters.Get(0));
	}

	/// <summary>
	/// Both guards pass: counter is decremented, accumulator value
	/// gains the step (8-bit wrap), step preserved, body is invoked
	/// with the step-in-AH / new-value-in-AL word.
	/// </summary>
	[Fact]
	public void Advance_GuardsPass_DecrementsAndDispatches() {
		// Arrange
		AdgChannelPitchBendCounters counters = new();
		AdgChannelEventPointers pointers = new();
		AdgChannelPitchAccumulators accumulators = new();
		AdgChannelPitchAccumulatorSteps steps = new();
		counters.Set(7, 3);
		pointers.Set(7, 0x0200);
		accumulators.Set(7, 0x40);
		steps.Set(7, 0x10);
		RecordingBody body = new();

		// Act
		bool fired = AdgPitchModulationAdvancer.Advance(
			7, counters, pointers, accumulators, steps, body);

		// Assert
		Assert.True(fired);
		Assert.Equal(2, counters.Get(7));
		Assert.Equal(0x50, accumulators.Get(7));
		Assert.Equal(0x10, steps.Get(7));
		(int channel, ushort bend) = Assert.Single(body.Calls);
		Assert.Equal(7, channel);
		Assert.Equal(0x1050, bend);
	}

	/// <summary>
	/// Accumulator addition wraps within a single byte (mirrors
	/// the <c>add AL,AH</c> at dnadg:07C5).
	/// </summary>
	[Fact]
	public void Advance_AccumulatorWrapsAtByteBoundary() {
		// Arrange
		AdgChannelPitchBendCounters counters = new();
		AdgChannelEventPointers pointers = new();
		AdgChannelPitchAccumulators accumulators = new();
		AdgChannelPitchAccumulatorSteps steps = new();
		counters.Set(1, 1);
		pointers.Set(1, 0x0100);
		accumulators.Set(1, 0xF0);
		steps.Set(1, 0x20);
		RecordingBody body = new();

		// Act
		AdgPitchModulationAdvancer.Advance(
			1, counters, pointers, accumulators, steps, body);

		// Assert
		Assert.Equal(0x10, accumulators.Get(1));
		(int channel, ushort bend) = Assert.Single(body.Calls);
		Assert.Equal(1, channel);
		Assert.Equal(0x2010, bend);
	}
}
