namespace Cryogenic.AdgPlayer.Driver;

using System.Buffers.Binary;
using System.IO;

/// <summary>
/// Immutable in-memory image of a Cryo audio driver binary (e.g. DNADG.UNHSQ
/// after HSQ decompression). Wraps the raw bytes and exposes typed accessors
/// at file offsets that map 1:1 to runtime segment offsets, since
/// DriverLoadToolbox loads these blobs as raw segments without a DOS PSP.
/// </summary>
public sealed class AdgDriverImage {
	private readonly byte[] _bytes;

	private AdgDriverImage(byte[] bytes) {
		_bytes = bytes;
	}

	/// <summary>Total length of the driver image in bytes.</summary>
	public int Length => _bytes.Length;

	/// <summary>Loads a driver image from a path on disk.</summary>
	public static AdgDriverImage FromFile(string path) {
		byte[] bytes = File.ReadAllBytes(path);
		return new AdgDriverImage(bytes);
	}

	/// <summary>Reads a single byte at <paramref name="offset"/>.</summary>
	public byte ReadByte(int offset) {
		if ((uint)offset >= (uint)_bytes.Length) {
			throw new ArgumentOutOfRangeException(nameof(offset));
		}
		return _bytes[offset];
	}

	/// <summary>Reads a little-endian 16-bit word at <paramref name="offset"/>.</summary>
	public ushort ReadWord(int offset) {
		if (offset < 0 || offset + 2 > _bytes.Length) {
			throw new ArgumentOutOfRangeException(nameof(offset));
		}
		return BinaryPrimitives.ReadUInt16LittleEndian(_bytes.AsSpan(offset, 2));
	}
}