namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgTempoAccumulator"/>.
/// </summary>
public sealed class AdgTempoAccumulatorTests {
	/// <summary>The accumulator starts at zero.</summary>
	[Fact]
	public void Default_ValueIsZero() {
		// Arrange
		AdgTempoAccumulator accumulator = new();

		// Act
		ushort value = accumulator.Value;

		// Assert
		Assert.Equal(0, value);
	}

	/// <summary>Adding a delta increases <c>Value</c> by the delta.</summary>
	[Fact]
	public void Add_AccumulatesDelta() {
		// Arrange
		AdgTempoAccumulator accumulator = new();

		// Act
		accumulator.Add(0x1234);
		accumulator.Add(0x0010);

		// Assert
		Assert.Equal(0x1244, accumulator.Value);
	}

	/// <summary>Sums larger than 0xFFFF wrap modulo 2^16.</summary>
	[Fact]
	public void Add_WrapsOnUshortOverflow() {
		// Arrange
		AdgTempoAccumulator accumulator = new();
		accumulator.Add(0xFFFF);

		// Act
		accumulator.Add(0x0002);

		// Assert
		Assert.Equal(0x0001, accumulator.Value);
	}

	/// <summary><c>Reset</c> brings the accumulator back to zero.</summary>
	[Fact]
	public void Reset_RestoresZero() {
		// Arrange
		AdgTempoAccumulator accumulator = new();
		accumulator.Add(0x4000);

		// Act
		accumulator.Reset();

		// Assert
		Assert.Equal(0, accumulator.Value);
	}
}