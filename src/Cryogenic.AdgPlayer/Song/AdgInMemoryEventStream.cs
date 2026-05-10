namespace Cryogenic.AdgPlayer.Song;

using System;

/// <summary>
/// Cursor-style reader over an <see cref="AdgSongImage"/> that
/// provides forward byte/word reads from an arbitrary absolute
/// offset. Used by the engine to consume events from a channel's
/// event stream without exposing the raw byte array.
/// </summary>
public sealed class AdgInMemoryEventStream {
	private readonly AdgSongImage _image;

	/// <summary>Builds a stream that reads from <paramref name="image"/>.</summary>
	public AdgInMemoryEventStream(AdgSongImage image) {
		ArgumentNullException.ThrowIfNull(image);
		_image = image;
	}

	/// <summary>Total bytes available.</summary>
	public int Length => _image.Length;

	/// <summary>Reads one byte at <paramref name="offset"/>.</summary>
	public byte ReadByte(int offset) {
		return _image.ReadByte(offset);
	}

	/// <summary>Reads a little-endian word at <paramref name="offset"/>.</summary>
	public ushort ReadUInt16(int offset) {
		return _image.ReadUInt16(offset);
	}

	/// <summary>Returns true when <paramref name="offset"/> is a valid byte offset.</summary>
	public bool InRange(int offset) {
		return offset >= 0 && offset < _image.Length;
	}

	/// <summary>Returns true when a 16-bit word can be read at <paramref name="offset"/>.</summary>
	public bool WordInRange(int offset) {
		return offset >= 0 && offset + 1 < _image.Length;
	}
}
