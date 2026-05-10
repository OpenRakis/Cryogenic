namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgWaitValueDecoder"/>.
/// </summary>
public sealed class AdgWaitValueDecoderTests {
	private static byte[] Bytes(params int[] values) {
		byte[] result = new byte[values.Length];
		for (int i = 0; i < values.Length; i++) {
			result[i] = (byte)values[i];
		}
		return result;
	}

	/// <summary>A single byte without the continuation bit yields the byte value.</summary>
	[Theory]
	[InlineData(0x00, 0x0000)]
	[InlineData(0x01, 0x0001)]
	[InlineData(0x7F, 0x007F)]
	public void Decode_SingleByte_NoContinuation_YieldsByteValue(int b, int expected) {
		// Arrange
		byte[] stream = Bytes(b);

		// Act
		AdgWaitValueDecodeResult result = AdgWaitValueDecoder.Decode(stream, 0);

		// Assert
		Assert.Equal((ushort)expected, result.Value);
		Assert.Equal(1, result.BytesConsumed);
		Assert.False(result.Overflowed);
	}

	/// <summary>
	/// Two-byte sequence: <c>(byte0 &amp; 0x7F) &lt;&lt; 7 | (byte1 &amp; 0x7F)</c>.
	/// First byte has the high bit set to chain.
	/// </summary>
	[Fact]
	public void Decode_TwoBytes_AccumulatesSevenBitChunks() {
		// Arrange
		// 0x81 = 0x80 | 0x01 (continue, msb chunk = 1) ; 0x40 stops, lsb chunk = 0x40
		byte[] stream = Bytes(0x81, 0x40);

		// Act
		AdgWaitValueDecodeResult result = AdgWaitValueDecoder.Decode(stream, 0);

		// Assert
		Assert.Equal(0x00C0, result.Value);
		Assert.Equal(2, result.BytesConsumed);
		Assert.False(result.Overflowed);
	}

	/// <summary>
	/// Three-byte sequence: continues twice, accumulates three 7-bit
	/// chunks shifted left.
	/// </summary>
	[Fact]
	public void Decode_ThreeBytes_AccumulatesThreeChunks() {
		// Arrange
		// 0x81, 0x82, 0x03 -> ((1<<7)|2)<<7 | 3 = (130<<7) | 3 = 16640 + 3 = 16643 = 0x4103
		byte[] stream = Bytes(0x81, 0x82, 0x03);

		// Act
		AdgWaitValueDecodeResult result = AdgWaitValueDecoder.Decode(stream, 0);

		// Assert
		Assert.Equal(0x4103, result.Value);
		Assert.Equal(3, result.BytesConsumed);
		Assert.False(result.Overflowed);
	}

	/// <summary>
	/// Decoding starts from <paramref name="offset"/> rather than 0
	/// when given.
	/// </summary>
	[Fact]
	public void Decode_RespectsStartOffset() {
		// Arrange
		byte[] stream = Bytes(0xFF, 0xFF, 0x05, 0x00);

		// Act
		AdgWaitValueDecodeResult result = AdgWaitValueDecoder.Decode(stream, 2);

		// Assert
		Assert.Equal(0x0005, result.Value);
		Assert.Equal(1, result.BytesConsumed);
		Assert.False(result.Overflowed);
	}

	/// <summary>
	/// Values past 0xFFFF are saturated and the overflow flag is
	/// raised (matches the original 32-bit accumulator clamp).
	/// </summary>
	[Fact]
	public void Decode_OverflowSaturatesToUshortMax() {
		// Arrange
		// Four chunks, each 0x7F: ((0x7F<<7)|0x7F)<<7|0x7F<<7|0x7F = > 0xFFFF
		byte[] stream = Bytes(0xFF, 0xFF, 0xFF, 0x7F);

		// Act
		AdgWaitValueDecodeResult result = AdgWaitValueDecoder.Decode(stream, 0);

		// Assert
		Assert.Equal(0xFFFF, result.Value);
		Assert.Equal(4, result.BytesConsumed);
		Assert.True(result.Overflowed);
	}
}