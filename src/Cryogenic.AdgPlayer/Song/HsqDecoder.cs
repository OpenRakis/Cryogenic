namespace Cryogenic.AdgPlayer.Song;

using System;

/// <summary>
/// HSQ (LZ77 variant) decompressor for DNADG / DNADP music images
/// extracted from DUNE.DAT. Header layout: 2 bytes uncompressed
/// size (little-endian), 1 byte unused, 2 bytes compressed size,
/// 1 byte checksum byte such that the byte sum of the 6 header
/// bytes equals 0xAB. Faithful port of
/// <c>OpenRakis/tools/dune-ds/source/unhsq.c</c> mirrored from
/// <see cref="Cryogenic.AdpPlayer"/>'s internal
/// <c>TryDecompressHsq</c>.
/// </summary>
public static class HsqDecoder {
	/// <summary>Header byte-sum that identifies a valid HSQ stream.</summary>
	public const byte HsqChecksum = 0xAB;

	/// <summary>Maximum supported uncompressed size (1 MiB sanity cap).</summary>
	public const int MaxUncompressedSize = 0x100000;

	/// <summary>
	/// Returns <c>true</c> when <paramref name="source"/> starts
	/// with a valid 6-byte HSQ header (correct length and checksum).
	/// </summary>
	public static bool LooksLikeHsq(byte[] source) {
		ArgumentNullException.ThrowIfNull(source);
		if (source.Length < 6) {
			return false;
		}
		int uncompressedSize = source[0] | (source[1] << 8);
		if (uncompressedSize == 0 || uncompressedSize > MaxUncompressedSize) {
			return false;
		}
		int checksum = (source[0] + source[1] + source[2] + source[3] + source[4] + source[5]) & 0xFF;
		return checksum == HsqChecksum;
	}

	/// <summary>
	/// Decompresses an HSQ-compressed buffer. Throws when the header
	/// is invalid or the stream is truncated. Use
	/// <see cref="LooksLikeHsq"/> first when callers want a tolerant
	/// probe.
	/// </summary>
	public static byte[] Decompress(byte[] source) {
		ArgumentNullException.ThrowIfNull(source);
		if (!LooksLikeHsq(source)) {
			throw new InvalidHsqStreamException("Buffer does not start with a valid HSQ header.");
		}
		int uncompressedSize = source[0] | (source[1] << 8);
		return DecompressInternal(source, uncompressedSize);
	}

	/// <summary>
	/// Returns the decompressed payload when <paramref name="source"/>
	/// is HSQ-compressed; otherwise returns the input unchanged. This
	/// matches the convenience semantics used by the existing
	/// AdpPlayer / Mt32Player engines: songs may be stored either
	/// raw or HSQ-compressed inside DUNE.DAT.
	/// </summary>
	public static byte[] DecompressOrPassThrough(byte[] source) {
		ArgumentNullException.ThrowIfNull(source);
		if (!LooksLikeHsq(source)) {
			return source;
		}
		int uncompressedSize = source[0] | (source[1] << 8);
		return DecompressInternal(source, uncompressedSize);
	}

	private static byte[] DecompressInternal(byte[] source, int uncompressedSize) {
		byte[] output = new byte[uncompressedSize];
		int srcPos = 6;
		int dstPos = 0;
		int bitBuffer = 1;

		while (dstPos < uncompressedSize && srcPos < source.Length) {
			if (GetBit(source, ref srcPos, ref bitBuffer)) {
				if (srcPos >= source.Length) {
					break;
				}
				output[dstPos++] = source[srcPos++];
				continue;
			}

			int count;
			int offset;
			if (GetBit(source, ref srcPos, ref bitBuffer)) {
				if (srcPos + 1 >= source.Length) {
					break;
				}
				byte first = source[srcPos++];
				byte second = source[srcPos++];
				count = first & 7;
				int word = first | (second << 8);
				offset = (word >> 3) - 8192;
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
				count = GetBit(source, ref srcPos, ref bitBuffer) ? 2 : 0;
				count |= GetBit(source, ref srcPos, ref bitBuffer) ? 1 : 0;
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

		return output;
	}

	private static bool GetBit(byte[] source, ref int srcPos, ref int bitBuffer) {
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