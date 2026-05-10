namespace Cryogenic.AdgPlayer.Song;

using System;
using System.IO;

/// <summary>
/// Loads a DNADG song image from a byte buffer or file path. Handles
/// HSQ-compressed and raw inputs transparently: when the header
/// signature matches an HSQ stream, the loader decompresses; when it
/// does not, the buffer is wrapped as-is.
/// </summary>
public sealed class AdgSongLoader {
	/// <summary>
	/// Builds an <see cref="AdgSongImage"/> from a raw byte buffer.
	/// </summary>
	public AdgSongImage Load(byte[] source) {
		ArgumentNullException.ThrowIfNull(source);
		bool compressed = HsqDecoder.LooksLikeHsq(source);
		byte[] payload = compressed ? HsqDecoder.Decompress(source) : source;
		return new AdgSongImage(payload, compressed);
	}

	/// <summary>
	/// Reads <paramref name="path"/> from disk and builds an
	/// <see cref="AdgSongImage"/>.
	/// </summary>
	public AdgSongImage LoadFromFile(string path) {
		ArgumentNullException.ThrowIfNull(path);
		byte[] bytes = File.ReadAllBytes(path);
		return Load(bytes);
	}
}