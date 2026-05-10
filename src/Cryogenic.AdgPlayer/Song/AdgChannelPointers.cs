namespace Cryogenic.AdgPlayer.Song;

using System;

/// <summary>
/// Resolves the absolute byte offsets of each channel's event
/// stream within an <see cref="AdgSongImage"/>. Mirrors the ADP
/// engine's <c>BuildChannelTable</c> logic: per-channel relative
/// offsets stored at <c>DataBase + i*2</c> are translated to
/// absolute offsets by adding <see cref="AdgSongHeader.DataBase"/>.
/// A relative offset of zero marks an inactive channel and yields
/// an absolute offset of zero.
/// </summary>
public sealed class AdgChannelPointers {
	private readonly ushort[] _absoluteOffsets;

	/// <summary>Number of channels (always <see cref="AdgSongHeader.ChannelCount"/>).</summary>
	public int ChannelCount => _absoluteOffsets.Length;

	/// <summary>Read-only view over the absolute event-stream offsets.</summary>
	public ReadOnlySpan<ushort> AbsoluteOffsets => _absoluteOffsets;

	/// <summary>Builds the absolute-offset table from a parsed header.</summary>
	public AdgChannelPointers(AdgSongHeader header) {
		ArgumentNullException.ThrowIfNull(header);
		_absoluteOffsets = new ushort[header.ChannelOffsets.Length];
		for (int i = 0; i < header.ChannelOffsets.Length; i++) {
			ushort relative = header.ChannelOffsets[i];
			_absoluteOffsets[i] = relative == 0 ? (ushort)0 : (ushort)(relative + AdgSongHeader.DataBase);
		}
	}

	/// <summary>Returns the absolute event-stream offset for <paramref name="channel"/>, or 0 when inactive.</summary>
	public ushort GetAbsoluteOffset(int channel) {
		if (channel < 0 || channel >= _absoluteOffsets.Length) {
			throw new ArgumentOutOfRangeException(nameof(channel), channel, "Channel index out of range.");
		}
		return _absoluteOffsets[channel];
	}

	/// <summary>True when the channel has a non-zero absolute offset.</summary>
	public bool IsChannelActive(int channel) {
		return GetAbsoluteOffset(channel) != 0;
	}
}