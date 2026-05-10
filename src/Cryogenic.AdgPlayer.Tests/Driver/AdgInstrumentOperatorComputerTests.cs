namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 18 — pure 12-byte instrument-operator patch decode.
/// Faithful port of <c>AdgWriteInstrumentOperator_102C</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>, isolating the four
/// register-value computations that depend only on the 12 patch bytes
/// (offsets +0x00..+0x0B) plus an external waveform byte.
///
/// Original disasm (compressed):
/// <code>
/// waveform &amp;= 7
/// TL = (Make16(p[2], p[0xA]&lt;&lt;2) &gt;&gt; 2) &amp; 0xFF
/// AD = Hi8(Make16((p[8]&lt;&lt;4), p[5]) &lt;&lt; 4)
/// SR = Hi8(Make16((p[9]&lt;&lt;4), p[6]) &lt;&lt; 4)
/// flags = 0
/// flags = ROR16(Make16(p[0xB], Hi8(flags)), 1)
/// flags = ROR16(Make16(p[5],   Hi8(flags)), 1)
/// flags = ROR16(Make16(p[0xA], Hi8(flags)), 1)
/// flags = ROR16(Make16(p[9],   Hi8(flags)), 1)
/// flags = Make16(p[1], Hi8(flags))
/// flags &amp;= 0xF00F
/// OpFlags = Hi8(flags) | Lo8(flags)
/// </code>
/// </summary>
public sealed class AdgInstrumentOperatorComputerTests {
	[Fact]
	public void Compute_AllZeroPatch_ReturnsAllZero() {
		// Arrange
		byte[] patch = new byte[12];

		// Act
		AdgInstrumentOperatorRegisters result = AdgInstrumentOperatorComputer.Compute(patch, waveform: 0);

		// Assert
		Assert.Equal((byte)0, result.Waveform);
		Assert.Equal((byte)0, result.TotalLevel);
		Assert.Equal((byte)0, result.AttackDecay);
		Assert.Equal((byte)0, result.SustainRelease);
		Assert.Equal((byte)0, result.OpFlags);
	}

	[Fact]
	public void Compute_DistinctPatchBytes_ProducesExpectedRegisterValues() {
		// Arrange — patch bytes chosen so each contribution is visible:
		//   p[1]=0x05  → MULT nibble = 5, bit 0 ignored (not OpFlags top nibble)
		//   p[2]=0xC8  → TL = 0xC8 >> 2 = 0x32
		//   p[5]=0x71  → AD hi nibble = 1, EG bit (bit 0 of p[5]) = 1
		//   p[6]=0x83  → SR hi nibble = 3
		//   p[8]=0xA9  → AD lo nibble = 9
		//   p[9]=0x05  → SR lo nibble = 5, AM bit (bit 0 of p[9]) = 1
		//   p[0xA]=0x02 → VIB bit (bit 0) = 0
		//   p[0xB]=0x01 → KSR bit (bit 0) = 1
		// OpFlags top nibble = AM<<7 | VIB<<6 | EG<<5 | KSR<<4
		//                    = 0x80 | 0x00 | 0x20 | 0x10 = 0xB0
		// OpFlags lo nibble = p[1] & 0x0F = 0x05
		// OpFlags = 0xB5.
		byte[] patch = {
			0x00, 0x05, 0xC8, 0x00, 0x00, 0x71, 0x83, 0x00,
			0xA9, 0x05, 0x02, 0x01
		};

		// Act
		AdgInstrumentOperatorRegisters result = AdgInstrumentOperatorComputer.Compute(patch, waveform: 0x0F);

		// Assert
		Assert.Equal((byte)0x07, result.Waveform);     // 0x0F & 7
		Assert.Equal((byte)0x32, result.TotalLevel);
		Assert.Equal((byte)0x19, result.AttackDecay);
		Assert.Equal((byte)0x35, result.SustainRelease);
		Assert.Equal((byte)0xB5, result.OpFlags);
	}

	[Fact]
	public void Compute_WaveformIsMaskedToThreeBits() {
		// Arrange
		byte[] patch = new byte[12];

		// Act
		AdgInstrumentOperatorRegisters result = AdgInstrumentOperatorComputer.Compute(patch, waveform: 0xFF);

		// Assert
		Assert.Equal((byte)0x07, result.Waveform);
	}

	[Fact]
	public void Compute_OpFlagsTopNibbleAggregatesOneBitPerSourceByte() {
		// Arrange — only KSR bit set (p[0xB] bit 0).
		byte[] patch = new byte[12];
		patch[0x0B] = 0x01;

		// Act
		AdgInstrumentOperatorRegisters result = AdgInstrumentOperatorComputer.Compute(patch, waveform: 0);

		// Assert
		Assert.Equal((byte)0x10, result.OpFlags);
	}

	[Fact]
	public void Compute_PatchTooShort_Throws() {
		// Arrange
		byte[] patch = new byte[11];

		// Act + Assert
		Assert.Throws<ArgumentException>(() =>
			AdgInstrumentOperatorComputer.Compute(patch, waveform: 0));
	}

	[Fact]
	public void Compute_NullPatch_Throws() {
		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgInstrumentOperatorComputer.Compute(null!, waveform: 0));
	}
}