namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Tests for <see cref="AdgInstrumentPatchStateDecoder"/>. Validates
/// the bit-twiddling against the oracle in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c> lines 1551–1586.
/// </summary>
public sealed class AdgInstrumentPatchStateDecoderTests {
	/// <summary>
	/// A 2-op patch with patch type 0x00 round-trips the simple word
	/// reads (TlShaping at 0x1E, VolumeModulation at 0x26) and the
	/// pitch-mode / pitch-transpose split at 0x21..0x22.
	/// </summary>
	[Fact]
	public void Decode_2OpPatch_PopulatesSimpleSlots() {
		// Arrange
		byte[] patch = new byte[AdgInstrumentPatchStateDecoder.Patch2Length];
		patch[0x00] = 0x02;
		patch[0x1E] = 0x11;
		patch[0x1F] = 0x22;
		patch[0x21] = 0x55; // PitchMode
		patch[0x22] = 0xAA; // PitchTranspose
		patch[0x26] = 0x33;
		patch[0x27] = 0x44;

		// Act
		AdgInstrumentPatchStateDecoder.DecodedState decoded =
			AdgInstrumentPatchStateDecoder.Decode(patch);

		// Assert
		Assert.Equal((byte)0x02, decoded.PatchType);
		Assert.False(decoded.IsPatch4);
		Assert.Equal((ushort)0x2211, decoded.TlShaping);
		Assert.Equal((ushort)0x4433, decoded.VolumeModulation);
		Assert.Equal((byte)0x55, decoded.PitchMode);
		Assert.Equal((byte)0xAA, decoded.PitchTranspose);
	}

	/// <summary>
	/// Envelope shaping composes word
	/// <c>(patch[0x0A]&lt;&lt;8 | patch[0x17])</c> OR
	/// <c>ROR2((patch[0x0F]&amp;0x03)&lt;&lt;8 | (patch[0x02]&amp;0x03))</c>.
	/// With <c>0x0F=0x03</c> and <c>0x02=0x03</c>, the OR mask is
	/// <c>0x0303</c>, and after ROR2 of a 16-bit value it equals
	/// <c>0xC0C0</c>.
	/// </summary>
	[Fact]
	public void Decode_EnvShapingMask_RotateRight2() {
		byte[] patch = new byte[AdgInstrumentPatchStateDecoder.Patch2Length];
		patch[0x02] = 0x03;
		patch[0x0F] = 0x03;
		patch[0x0A] = 0x00;
		patch[0x17] = 0x00;

		AdgInstrumentPatchStateDecoder.DecodedState decoded =
			AdgInstrumentPatchStateDecoder.Decode(patch);

		Assert.Equal((ushort)0xC0C0, decoded.EnvShaping);
	}

	/// <summary>
	/// Connection shaping is composed via
	/// <c>AX = Make16(hi=~patch[0x0E], lo=patch[0x04])</c>,
	/// <c>AX = ROR1(AX) SHL 1</c>, then
	/// <c>AX = Make16(hi=patch[0x20], lo=Hi8(AX))</c>.
	/// With <c>patch[0x04]=0x00, patch[0x0E]=0x00 (~=0xFF),
	/// patch[0x20]=0x77</c>: AX = 0xFF00; ROR1 = 0x7F80;
	/// SHL1 = 0xFF00; Make16 = (hi=0x77, lo=0xFF) = 0x77FF.
	/// </summary>
	[Fact]
	public void Decode_ConnectionShaping_RotationAndShift() {
		byte[] patch = new byte[AdgInstrumentPatchStateDecoder.Patch2Length];
		patch[0x04] = 0x00;
		patch[0x0E] = 0x00;
		patch[0x20] = 0x77;

		AdgInstrumentPatchStateDecoder.DecodedState decoded =
			AdgInstrumentPatchStateDecoder.Decode(patch);

		Assert.Equal((ushort)0x77FF, decoded.ConnectionShaping);
	}

	/// <summary>
	/// Connection modulation places <c>patch[0x1B]</c> in the high
	/// byte and zero in the low byte (low half is initialised later
	/// by the envelope-setup routine).
	/// </summary>
	[Fact]
	public void Decode_ConnectionModulation_HighByteFromPatch1B() {
		byte[] patch = new byte[AdgInstrumentPatchStateDecoder.Patch2Length];
		patch[0x1B] = 0x9C;

		AdgInstrumentPatchStateDecoder.DecodedState decoded =
			AdgInstrumentPatchStateDecoder.Decode(patch);

		Assert.Equal((ushort)0x9C00, decoded.ConnectionModulation);
	}

	/// <summary>
	/// Pitch accumulator high byte + bend counter come from the
	/// 16-bit word at patch 0x23 (lo→bend counter, hi→accumulator).
	/// </summary>
	[Fact]
	public void Decode_PitchSeed_SplitsAcrossSlots() {
		byte[] patch = new byte[AdgInstrumentPatchStateDecoder.Patch2Length];
		patch[0x23] = 0x12; // bend counter
		patch[0x24] = 0x34; // accumulator high

		AdgInstrumentPatchStateDecoder.DecodedState decoded =
			AdgInstrumentPatchStateDecoder.Decode(patch);

		Assert.Equal((byte)0x12, decoded.PitchBendCounter);
		Assert.Equal((byte)0x34, decoded.PitchAccumulatorHigh);
	}

	/// <summary>
	/// 4-op patches populate the Patch4 tail (TlShaping at 0x46,
	/// VolumeModulation at 0x4E, EnvShaping from 0x32/0x3F masked
	/// with 0x37/0x2A).
	/// </summary>
	[Fact]
	public void Decode_4OpPatch_PopulatesPatch4Tail() {
		byte[] patch = new byte[AdgInstrumentPatchStateDecoder.Patch4Length];
		patch[0x00] = 0x04;
		patch[0x46] = 0xAB;
		patch[0x47] = 0xCD;
		patch[0x4E] = 0x11;
		patch[0x4F] = 0x22;
		// EnvShaping4: hi=patch[0x32], lo=patch[0x3F] OR
		// ROR2((patch[0x37]&0x03)<<8 | (patch[0x2A]&0x03)).
		patch[0x32] = 0x80;
		patch[0x3F] = 0x40;
		patch[0x37] = 0x00;
		patch[0x2A] = 0x00;

		AdgInstrumentPatchStateDecoder.DecodedState decoded =
			AdgInstrumentPatchStateDecoder.Decode(patch);

		Assert.True(decoded.IsPatch4);
		Assert.Equal((ushort)0xCDAB, decoded.Patch4TlShaping);
		Assert.Equal((ushort)0x2211, decoded.Patch4VolumeModulation);
		Assert.Equal((ushort)0x8040, decoded.Patch4EnvShaping);
	}

	/// <summary>
	/// A patch declared 4-op (byte 0x00 == 0x04) but shorter than
	/// <see cref="AdgInstrumentPatchStateDecoder.Patch4Length"/>
	/// raises an <see cref="ArgumentException"/>.
	/// </summary>
	[Fact]
	public void Decode_4OpPatch_TooShort_Throws() {
		byte[] patch = new byte[AdgInstrumentPatchStateDecoder.Patch2Length];
		patch[0x00] = 0x04;

		Assert.Throws<ArgumentException>(() =>
			AdgInstrumentPatchStateDecoder.Decode(patch));
	}

	/// <summary>
	/// A patch shorter than the basic 0x28-byte length raises an
	/// <see cref="ArgumentException"/>.
	/// </summary>
	[Fact]
	public void Decode_Patch2_TooShort_Throws() {
		byte[] patch = new byte[0x10];

		Assert.Throws<ArgumentException>(() =>
			AdgInstrumentPatchStateDecoder.Decode(patch));
	}
}
