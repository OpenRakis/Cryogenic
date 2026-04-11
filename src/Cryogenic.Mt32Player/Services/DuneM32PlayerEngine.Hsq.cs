namespace Cryogenic.Mt32Player.Services;

/// <summary>
/// HSQ decompression for Dune M32 files. Many .M32 files in DUNE.DAT
/// are HSQ-compressed (LZ77 variant with a 6-byte header).
///
/// Reference implementation: OpenRakis/tools/dune-ds/source/unhsq.c
/// Checksum: (byte0 + byte1 + byte2 + byte3 + byte4 + byte5) & 0xFF == 0xAB
/// </summary>
public sealed partial class DuneM32PlayerEngine {
	/// <summary>
	/// Attempts HSQ decompression; returns original bytes if header
	/// is not a valid HSQ signature.
	/// </summary>
	private static byte[] TryDecompressHsq(byte[] source) {
		if (source.Length < 6) {
			return source;
		}

		// HSQ header: bytes 0-1 = uncompressed size (LE)
		int uncompressedSize = source[0] | (source[1] << 8);
		if (uncompressedSize == 0 || uncompressedSize > 0x100000) {
			return source;
		}

		// HSQ checksum: sum of all 6 header bytes must equal 0xAB
		int checksum = (source[0] + source[1] + source[2] + source[3] + source[4] + source[5]) & 0xFF;
		if (checksum != 0xAB) {
			return source;
		}

		try {
			byte[] result = DecompressHsq(source, uncompressedSize);
			return result;
		} catch {
			return source;
		}
	}

	/// <summary>
	/// Core HSQ decompression. Faithful port of unhsq_unpack2 from OpenRakis.
	/// </summary>
	private static byte[] DecompressHsq(byte[] source, int uncompressedSize) {
		byte[] output = new byte[uncompressedSize];
		int srcPos = 6;
		int dstPos = 0;
		int bitBuffer = 1; // sentinel: q=1 forces reload on first getbit

		while (dstPos < uncompressedSize && srcPos < source.Length) {
			if (HsqGetBit(source, ref srcPos, ref bitBuffer)) {
				// Literal byte
				if (srcPos >= source.Length) { break; }
				output[dstPos++] = source[srcPos++];
			} else {
				int count;
				int offset;

				if (HsqGetBit(source, ref srcPos, ref bitBuffer)) {
					// Long match
					if (srcPos + 1 >= source.Length) { break; }
					byte first = source[srcPos++];
					byte second = source[srcPos++];

					// count = low 3 bits of first byte
					count = first & 7;
					// offset = (word >> 3) sign-extended to 13 bits (negative)
					int word = first | (second << 8);
					int offsetBits = word >> 3;
					offset = offsetBits - 8192; // equivalent to 0xFFFFE000 | offsetBits

					if (count == 0) {
						// Extended count: read next byte
						if (srcPos >= source.Length) { break; }
						count = source[srcPos++];
						if (count == 0) { break; } // end of compressed data
					}
				} else {
					// Short match: 2 bits for count, 1 byte for offset
					count = HsqGetBit(source, ref srcPos, ref bitBuffer) ? 2 : 0;
					count |= HsqGetBit(source, ref srcPos, ref bitBuffer) ? 1 : 0;

					if (srcPos >= source.Length) { break; }
					offset = source[srcPos++] - 256; // 0xFFFFFF00 | byte
				}

				count += 2;
				int copyFrom = dstPos + offset;
				if (copyFrom < 0) { break; }

				for (int i = 0; i < count && dstPos < uncompressedSize; i++) {
					output[dstPos++] = output[copyFrom + i];
				}
			}
		}

		return output;
	}

	/// <summary>
	/// Reads one bit from the HSQ bit stream using the sentinel approach.
	/// Matches unhsq_getbit from OpenRakis exactly:
	///   q starts at 1 (sentinel). When q==1, reload 16 bits | 0x10000.
	///   Return low bit, shift right.
	/// </summary>
	private static bool HsqGetBit(byte[] source, ref int srcPos, ref int bitBuffer) {
		if (bitBuffer == 1) {
			// Sentinel hit: reload 16 bits from source
			if (srcPos + 1 >= source.Length) {
				return false;
			}
			bitBuffer = 0x10000 | source[srcPos] | (source[srcPos + 1] << 8);
			srcPos += 2;
		}

		bool bit = (bitBuffer & 1) != 0;
		bitBuffer >>= 1;
		return bit;
	}
}