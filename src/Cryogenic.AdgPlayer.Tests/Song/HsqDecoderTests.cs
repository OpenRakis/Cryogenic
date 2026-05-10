namespace Cryogenic.AdgPlayer.Tests.Song;

using Cryogenic.AdgPlayer.Song;

using System;

using Xunit;

/// <summary>Tests for <see cref="HsqDecoder"/>.</summary>
public sealed class HsqDecoderTests {
	/// <summary>
	/// Builds a minimal valid 3-literal HSQ stream:
	/// header(uncompressed=3) + bit-word(0x0007 = three '1' literal flags) + three literal bytes.
	/// Verified by hand-stepping <see cref="HsqDecoder"/>.
	/// </summary>
	private static byte[] BuildLiteralHsqStream(byte a, byte b, byte c) {
		// Header: uncompressed size = 3 (LE), pad zero, two zero bytes, then checksum so byte sum == 0xAB.
		byte size_lo = 0x03;
		byte size_hi = 0x00;
		byte pad = 0x00;
		byte comp_lo = 0x00;
		byte comp_hi = 0x00;
		byte checksum = unchecked((byte)(0xAB - size_lo - size_hi - pad - comp_lo - comp_hi));
		// Bit word with three '1' bits at the bottom -> three literal flags.
		byte bit_lo = 0x07;
		byte bit_hi = 0x00;
		return new byte[] {
			size_lo, size_hi, pad, comp_lo, comp_hi, checksum,
			bit_lo, bit_hi,
			a, b, c,
		};
	}

	/// <summary>Null buffer is rejected.</summary>
	[Fact]
	public void LooksLikeHsq_NullBuffer_Throws() {
		// Act / Assert
		Assert.Throws<ArgumentNullException>(() => HsqDecoder.LooksLikeHsq(null!));
	}

	/// <summary>Buffers shorter than the 6-byte header are not HSQ.</summary>
	[Fact]
	public void LooksLikeHsq_TooShort_ReturnsFalse() {
		// Arrange
		byte[] tiny = new byte[5];

		// Act / Assert
		Assert.False(HsqDecoder.LooksLikeHsq(tiny));
	}

	/// <summary>Buffers with the wrong checksum are rejected.</summary>
	[Fact]
	public void LooksLikeHsq_WrongChecksum_ReturnsFalse() {
		// Arrange
		byte[] header = new byte[] { 0x03, 0x00, 0x00, 0x00, 0x00, 0x00 };

		// Act / Assert
		Assert.False(HsqDecoder.LooksLikeHsq(header));
	}

	/// <summary>A valid handcrafted literal stream is recognised.</summary>
	[Fact]
	public void LooksLikeHsq_ValidStream_ReturnsTrue() {
		// Arrange
		byte[] stream = BuildLiteralHsqStream(0xAA, 0xBB, 0xCC);

		// Act / Assert
		Assert.True(HsqDecoder.LooksLikeHsq(stream));
	}

	/// <summary>Decompression of the literal stream yields the original 3 bytes.</summary>
	[Fact]
	public void Decompress_LiteralStream_RoundTripsBytes() {
		// Arrange
		byte[] stream = BuildLiteralHsqStream(0xAA, 0xBB, 0xCC);

		// Act
		byte[] result = HsqDecoder.Decompress(stream);

		// Assert
		Assert.Equal(new byte[] { 0xAA, 0xBB, 0xCC }, result);
	}

	/// <summary>Decompressing a non-HSQ buffer throws.</summary>
	[Fact]
	public void Decompress_NonHsq_Throws() {
		// Arrange
		byte[] notHsq = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

		// Act / Assert
		Assert.Throws<InvalidHsqStreamException>(() => HsqDecoder.Decompress(notHsq));
	}

	/// <summary>Pass-through returns the input unchanged when not HSQ.</summary>
	[Fact]
	public void DecompressOrPassThrough_NonHsq_ReturnsInput() {
		// Arrange
		byte[] raw = new byte[] { 1, 2, 3, 4, 5 };

		// Act
		byte[] result = HsqDecoder.DecompressOrPassThrough(raw);

		// Assert
		Assert.Same(raw, result);
	}

	/// <summary>Pass-through decompresses HSQ inputs.</summary>
	[Fact]
	public void DecompressOrPassThrough_HsqInput_Decompresses() {
		// Arrange
		byte[] stream = BuildLiteralHsqStream(0x10, 0x20, 0x30);

		// Act
		byte[] result = HsqDecoder.DecompressOrPassThrough(stream);

		// Assert
		Assert.Equal(new byte[] { 0x10, 0x20, 0x30 }, result);
	}

	/// <summary>Zero uncompressed size is rejected.</summary>
	[Fact]
	public void LooksLikeHsq_ZeroUncompressedSize_ReturnsFalse() {
		// Arrange — sum to 0xAB but size = 0.
		byte[] header = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0xAB };

		// Act / Assert
		Assert.False(HsqDecoder.LooksLikeHsq(header));
	}
}