namespace Cryogenic.AdgPlayer.Services;

using Serilog;

/// <summary>
/// HSQ decompression for ADG/ADP music files from DUNE.DAT.
/// Many files are HSQ-compressed (LZ77 variant with a 6-byte header).
/// Ported from OpenRakis/tools/dune-ds/source/unhsq.c via the MT32 player.
/// Checksum: (byte0 + byte1 + byte2 + byte3 + byte4 + byte5) &amp; 0xFF == 0xAB
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
	private static readonly ILogger HsqLogger = Log.ForContext("Subsystem", "HSQ");

	/// <summary>
	/// Attempts HSQ decompression; returns null if the header is not a valid HSQ signature.
	/// </summary>
	private static byte[]? TryDecompressHsq(byte[] source) {
		if (source.Length < 6) {
			return null;
		}

		int uncompressedSize = source[0] | (source[1] << 8);
		if (uncompressedSize == 0 || uncompressedSize > 0x100000) {
			return null;
		}

		int checksum = (source[0] + source[1] + source[2] + source[3] + source[4] + source[5]) & 0xFF;
		if (checksum != 0xAB) {
			return null;
		}

		try {
			byte[] result = DecompressHsq(source, uncompressedSize);
			HsqLogger.Information("HSQ decompressed: {SrcLen} → {DstLen} bytes", source.Length, result.Length);
			return result;
		} catch (Exception ex) {
			HsqLogger.Warning(ex, "HSQ decompression failed, using raw data");
			return null;
		}
	}

	/// <summary>
	/// Core HSQ decompression. Faithful port of unhsq_unpack2 from OpenRakis.
	/// </summary>
	private static byte[] DecompressHsq(byte[] source, int uncompressedSize) {
		byte[] output = new byte[uncompressedSize];
		int srcPos = 6;
		int dstPos = 0;
		int bitBuffer = 1;

		while (dstPos < uncompressedSize && srcPos < source.Length) {
			if (HsqGetBit(source, ref srcPos, ref bitBuffer)) {
				if (srcPos >= source.Length) {
					break;
				}
				output[dstPos++] = source[srcPos++];
			} else {
				int count;
				int offset;

				if (HsqGetBit(source, ref srcPos, ref bitBuffer)) {
					if (srcPos + 1 >= source.Length) {
						break;
					}
					byte first = source[srcPos++];
					byte second = source[srcPos++];

					count = first & 7;
					int word = first | (second << 8);
					int offsetBits = word >> 3;
					offset = offsetBits - 8192;

					if (count == 0) {
						if (srcPos >= source.Length) {
							break;
						}
						count = source[srcPos++];
						if (count == 0) {
							break;
						}
					}
				} else {
					count = HsqGetBit(source, ref srcPos, ref bitBuffer) ? 2 : 0;
					count |= HsqGetBit(source, ref srcPos, ref bitBuffer) ? 1 : 0;

					if (srcPos >= source.Length) {
						break;
					}
					offset = source[srcPos++] - 256;
				}

				count += 2;
				int copyFrom = dstPos + offset;
				if (copyFrom < 0) {
					break;
				}

				for (int i = 0; i < count && dstPos < uncompressedSize; i++) {
					output[dstPos++] = output[copyFrom + i];
				}
			}
		}

		return output;
	}

	/// <summary>
	/// Reads one bit from the HSQ bit stream using the sentinel approach.
	/// </summary>
	private static bool HsqGetBit(byte[] source, ref int srcPos, ref int bitBuffer) {
		if (bitBuffer == 1) {
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