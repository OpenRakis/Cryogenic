namespace Cryogenic.AdgPlayer.Song;

using System;

/// <summary>
/// Parses an <see cref="AdgSongImage"/> into an immutable
/// <see cref="AdgSongHeader"/>. Layout matches the shared ADG/ADP
/// song format described in
/// <c>docs/ADP_DRIVER_ADG_FORMAT_AND_ADL_ADG_PLAN.md</c> §4.3.
/// </summary>
public sealed class AdgSongHeaderParser {
	private const int TempoOffset = 0x30;
	private const int LoopStartOffset = 0x2A;
	private const int LoopEndOffset = 0x2C;
	private const int LoopCountOffset = 0x2E;

	/// <summary>Parses the header fields out of <paramref name="image"/>.</summary>
	public AdgSongHeader Parse(AdgSongImage image) {
		ArgumentNullException.ThrowIfNull(image);
		int dataBase = AdgSongHeader.DataBase;
		int channelCount = AdgSongHeader.ChannelCount;
		int minLength = dataBase + 0x32;
		if (image.Length < minLength) {
			throw new InvalidAdgSongException($"Song image is too short for header (need {minLength} bytes, got {image.Length}).");
		}

		ushort eventBase = image.ReadUInt16(0);
		ushort tempo = image.ReadUInt16(dataBase + TempoOffset);
		ushort loopStart = image.ReadUInt16(dataBase + LoopStartOffset);
		ushort loopEnd = image.ReadUInt16(dataBase + LoopEndOffset);
		ushort loopCount = image.ReadUInt16(dataBase + LoopCountOffset);

		ushort[] channelOffsets = new ushort[channelCount];
		bool[] channelActive = new bool[channelCount];
		int activeCount = 0;
		for (int i = 0; i < channelCount; i++) {
			ushort relative = image.ReadUInt16(dataBase + i * 2);
			channelOffsets[i] = relative;
			bool active = relative != 0;
			channelActive[i] = active;
			if (active) {
				activeCount++;
			}
		}

		int instrumentCount = 0;
		if (eventBase > dataBase + 0x32 && eventBase <= image.Length) {
			instrumentCount = (image.Length - eventBase) / AdgSongHeader.InstrumentRecordSize;
		}

		return new AdgSongHeader(
			rawFileSize: image.Length,
			wasCompressed: image.WasCompressed,
			eventBase: eventBase,
			tempo: tempo,
			loopStartMeasure: loopStart,
			loopEndMeasure: loopEnd,
			loopCount: loopCount,
			instrumentCount: instrumentCount,
			channelOffsets: channelOffsets,
			channelActive: channelActive,
			activeChannelCount: activeCount);
	}
}
