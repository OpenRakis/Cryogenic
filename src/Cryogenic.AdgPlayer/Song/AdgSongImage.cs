namespace Cryogenic.AdgPlayer.Song;

using System;

/// <summary>
/// Immutable wrapper around a decompressed DNADG song image. Holds
/// the raw bytes plus a flag indicating whether the source was
/// HSQ-compressed at load time. Constructed by
/// <see cref="AdgSongLoader"/>; consumers (header parser, channel
/// pointer parser, engine) read straight from <see cref="Bytes"/>.
/// </summary>
public sealed class AdgSongImage {
	private readonly byte[] _bytes;

	/// <summary>Decompressed song bytes (length == header uncompressed size for HSQ inputs).</summary>
	public ReadOnlyMemory<byte> Bytes => _bytes;

	/// <summary>Length of the decompressed payload in bytes.</summary>
	public int Length => _bytes.Length;

	/// <summary>True when the source buffer began with a valid HSQ header.</summary>
	public bool WasCompressed { get; }

	/// <summary>Builds an image from an already-decompressed byte array.</summary>
	public AdgSongImage(byte[] bytes, bool wasCompressed) {
		ArgumentNullException.ThrowIfNull(bytes);
		_bytes = bytes;
		WasCompressed = wasCompressed;
	}

	/// <summary>Reads a single byte from the image at the supplied offset.</summary>
	public byte ReadByte(int offset) {
		if (offset < 0 || offset >= _bytes.Length) {
			throw new ArgumentOutOfRangeException(nameof(offset), offset, "Offset is outside the song image.");
		}
		return _bytes[offset];
	}

	/// <summary>Reads a little-endian 16-bit word from the image at the supplied offset.</summary>
	public ushort ReadUInt16(int offset) {
		if (offset < 0 || offset + 1 >= _bytes.Length) {
			throw new ArgumentOutOfRangeException(nameof(offset), offset, "Offset+1 is outside the song image.");
		}
		return (ushort)(_bytes[offset] | (_bytes[offset + 1] << 8));
	}
}
