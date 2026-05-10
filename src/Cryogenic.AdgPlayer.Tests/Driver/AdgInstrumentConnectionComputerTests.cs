namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 20 — Feedback/Connection register byte computed from a
/// 27-byte instrument patch. Faithful port of the connection decoder
/// inside <c>AdgWriteInstrumentPatch_0F95</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>:
/// <code>
/// w  = Make16(p[0x0F], p[0x1A])
/// w &gt;&gt;= 1
/// w  = Make16(~Lo8(w), p[0x04])
/// w &lt;&lt;= 1
/// connection = Hi8(w) &amp; 0x0F
/// </code>
/// Closed-form: <c>((p[0x04] &lt;&lt; 1) &amp; 0x0E) | (1 ^ (p[0x1A] &amp; 1))</c>.
/// Verified by hand against the assembly trace.
/// </summary>
public sealed class AdgInstrumentConnectionComputerTests {
	private static byte[] BuildPatch() {
		// Patch must contain at least 0x1B bytes (offsets 0x04, 0x0F, 0x1A
		// are read).
		return new byte[27];
	}

	[Fact]
	public void Compute_AllZero_ReturnsBit0Set() {
		// Arrange — derived from the inverted XOR with p[0x1A] bit 0.
		byte[] patch = BuildPatch();

		// Act
		byte result = AdgInstrumentConnectionComputer.Compute(patch);

		// Assert
		Assert.Equal((byte)0x01, result);
	}

	[Fact]
	public void Compute_Patch04Five_NoConnectionLsb_ReturnsB() {
		// Arrange — p[0x04]=0x05, p[0x1A] bit 0 = 0 → result 0x0B.
		byte[] patch = BuildPatch();
		patch[0x04] = 0x05;

		// Act
		byte result = AdgInstrumentConnectionComputer.Compute(patch);

		// Assert
		Assert.Equal((byte)0x0B, result);
	}

	[Fact]
	public void Compute_ConnectionLsbFlipsLowBit() {
		// Arrange — p[0x04]=0x05, p[0x1A] bit 0 = 1 → result 0x0A.
		byte[] patch = BuildPatch();
		patch[0x04] = 0x05;
		patch[0x1A] = 0x01;

		// Act
		byte result = AdgInstrumentConnectionComputer.Compute(patch);

		// Assert
		Assert.Equal((byte)0x0A, result);
	}

	[Fact]
	public void Compute_HighFeedback_ResultMaskedToFourBits() {
		// Arrange — p[0x04]=0xFF, p[0x1A]=0 → ((0xFE & 0x0E) | 1) = 0x0F.
		byte[] patch = BuildPatch();
		patch[0x04] = 0xFF;

		// Act
		byte result = AdgInstrumentConnectionComputer.Compute(patch);

		// Assert
		Assert.Equal((byte)0x0F, result);
	}

	[Fact]
	public void Compute_Patch0F_DoesNotAffectResult() {
		// Arrange — p[0x0F] influences only bits that get shifted out of
		// the final 0x0F nibble. Verified by hand: result stays 0x01.
		byte[] patch = BuildPatch();
		patch[0x0F] = 0xFF;

		// Act
		byte result = AdgInstrumentConnectionComputer.Compute(patch);

		// Assert
		Assert.Equal((byte)0x01, result);
	}

	[Fact]
	public void Compute_PatchTooShort_Throws() {
		// Arrange — must reach offset 0x1A (length >= 0x1B).
		byte[] patch = new byte[0x1A];

		// Act + Assert
		Assert.Throws<ArgumentException>(() =>
			AdgInstrumentConnectionComputer.Compute(patch));
	}

	[Fact]
	public void Compute_NullPatch_Throws() {
		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgInstrumentConnectionComputer.Compute(null!));
	}
}