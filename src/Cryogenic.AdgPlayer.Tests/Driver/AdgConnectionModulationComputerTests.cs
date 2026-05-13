namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Tests for <see cref="AdgConnectionModulationComputer"/>. The
/// computer mirrors the connection-modulation tail of
/// <c>AdgVolumeModulation_0B2E</c> (oracle lines 1793 onward in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>).
/// </summary>
public sealed class AdgConnectionModulationComputerTests {
	/// <summary>
	/// B4.4b micro-cycle 1: when the rate (low byte of the
	/// connection-modulation slot) is zero, the routine exits
	/// immediately without computing a new connection byte. The
	/// returned result is inactive and the input current byte is
	/// echoed unchanged.
	/// </summary>
	[Fact]
	public void Compute_ZeroRate_ReturnsInactive() {
		// Arrange
		byte rate = 0;
		byte current = 0xAA;
		byte directVelocity = 0x40;
		byte inverseVelocity = (byte)(0x80 - directVelocity);

		// Act
		AdgConnectionModulationComputer.Result result =
			AdgConnectionModulationComputer.Compute(rate, current,
				directVelocity, inverseVelocity);

		// Assert
		Assert.False(result.Active);
		Assert.Equal((byte)0xAA, result.NewConnection);
	}

	/// <summary>
	/// B4.4b micro-cycle 2: positive-shaping path with clamp.
	/// Oracle trace with rate=0x04, current=0x02, velocity=0x70:
	/// shapingMode = (byte)(0 - (0x04 - 0x06)) = 0x02;
	/// scale = (0x70 &gt;&gt; 2) &amp; 0xFE = 0x1C;
	/// add current 0x02 -&gt; 0x1E; clamp &gt; 0x0F -&gt; (0x1E &amp; 0x0F) | 0x0E = 0x0E;
	/// merge (Hi &amp; 0x30) = 0 -&gt; final 0x0E.
	/// </summary>
	[Fact]
	public void Compute_PositiveShaping_ClampsAboveFifteen() {
		AdgConnectionModulationComputer.Result result =
			AdgConnectionModulationComputer.Compute(
				rate: 0x04, current: 0x02,
				directVelocity: 0x70, inverseVelocity: 0x10);

		Assert.True(result.Active);
		Assert.Equal((byte)0x0E, result.NewConnection);
	}

	/// <summary>
	/// B4.4b micro-cycle 3: negative-shaping path uses inverse
	/// velocity. Rate 0x84 has the sign bit set, so the routine
	/// inverts the shaping (0x84 -&gt; 0x7C) and picks the inverse
	/// velocity. Trace with rate=0x84, current=0x10, direct=0x70,
	/// inverse=0x10: inverted shaping = 0x7C; shapingMode =
	/// (byte)(0 - (0x7C - 0x06)) = 0x8A; (80286+) shift count is
	/// masked to 5 bits -&gt; 0x0A; 0x10 &gt;&gt; 0x0A = 0; +current 0x10
	/// = 0x10; clamp -&gt; 0x0E; merge (Hi &amp; 0x30) = 0x10 -&gt; 0x1E.
	/// </summary>
	[Fact]
	public void Compute_NegativeShaping_UsesInverseVelocity_AndPreservesHighNibble() {
		AdgConnectionModulationComputer.Result result =
			AdgConnectionModulationComputer.Compute(
				rate: 0x84, current: 0x10,
				directVelocity: 0x70, inverseVelocity: 0x10);

		Assert.True(result.Active);
		Assert.Equal((byte)0x1E, result.NewConnection);
	}
}