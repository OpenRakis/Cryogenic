namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Result of decoding one ADG variable-length wait value. The
/// value is saturated at 0xFFFF; <see cref="Overflowed"/> signals
/// that the unbounded accumulator exceeded that threshold (the
/// driver clamps to <c>0xFFFF</c> in that case at dnadg:0E92).
/// </summary>
/// <param name="Value">Decoded 16-bit wait counter value (saturated).</param>
/// <param name="BytesConsumed">Number of bytes consumed from the stream.</param>
/// <param name="Overflowed">True when saturation kicked in.</param>
public readonly record struct AdgWaitValueDecodeResult(ushort Value, int BytesConsumed, bool Overflowed);

/// <summary>
/// Pure decoder for the variable-length 7-bit wait values produced
/// by the song event stream. Mirrors <c>AdgReadWaitValue_0E7E</c>:
/// each byte contributes 7 bits to the accumulator (high-bit set
/// continues, clear terminates) and the result saturates to
/// <c>0xFFFF</c>.
/// </summary>
public static class AdgWaitValueDecoder {
	private const byte ContinuationBit = 0x80;
	private const byte ChunkMask = 0x7F;
	private const int ChunkShift = 7;

	/// <summary>
	/// Decodes a single wait value starting at
	/// <paramref name="startOffset"/> in <paramref name="stream"/>.
	/// </summary>
	public static AdgWaitValueDecodeResult Decode(byte[] stream, int startOffset) {
		ArgumentNullException.ThrowIfNull(stream);
		if (startOffset < 0 || startOffset >= stream.Length) {
			throw new ArgumentOutOfRangeException(nameof(startOffset),
				startOffset, "Start offset must lie inside the stream.");
		}

		uint accumulator = 0;
		bool overflowed = false;
		int cursor = startOffset;
		while (true) {
			if (cursor >= stream.Length) {
				throw new ArgumentException(
					"Wait-value stream ended before the terminating byte.",
					nameof(stream));
			}
			byte current = stream[cursor++];
			accumulator = (accumulator << ChunkShift) | (uint)(current & ChunkMask);
			if (accumulator > ushort.MaxValue) {
				overflowed = true;
			}
			if ((current & ContinuationBit) == 0) {
				break;
			}
		}

		ushort value = overflowed ? (ushort)0xFFFF : (ushort)accumulator;
		return new AdgWaitValueDecodeResult(value, cursor - startOffset, overflowed);
	}
}