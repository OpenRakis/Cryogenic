namespace Cryogenic.AdgPlayer.Song;

using System;

/// <summary>
/// Parsed header of an ADG/ADP song image. The format is shared
/// between DNADP and DNADG (see
/// <c>docs/ADP_DRIVER_ADG_FORMAT_AND_ADL_ADG_PLAN.md</c> §4.3):
/// <list type="bullet">
///   <item>data base = 2 (event base word lives at offset 0..1).</item>
///   <item>+0x00..+0x11 — 9 channel relative offsets (word each).</item>
///   <item>+0x2A — loop start measure.</item>
///   <item>+0x2C — loop end measure.</item>
///   <item>+0x2E — loop count.</item>
///   <item>+0x30 — tempo word.</item>
///   <item>Instrument bank starts at <see cref="EventBase"/>;
///         fixed-size records of 0x28 bytes.</item>
/// </list>
/// Built by <see cref="AdgSongHeaderParser"/>.
/// </summary>
public sealed class AdgSongHeader {
	/// <summary>Number of melodic channels in the song format.</summary>
	public const int ChannelCount = 9;

	/// <summary>Offset (from start of decompressed image) where the channel-offset table begins.</summary>
	public const int DataBase = 2;

	/// <summary>Size in bytes of one instrument record in the bank.</summary>
	public const int InstrumentRecordSize = 0x28;

	private readonly ushort[] _channelOffsets;
	private readonly bool[] _channelActive;

	/// <summary>Total length of the decompressed image in bytes.</summary>
	public int RawFileSize { get; }

	/// <summary>True when the source buffer was HSQ-compressed.</summary>
	public bool WasCompressed { get; }

	/// <summary>Offset where the instrument bank begins (16-bit word at file offset 0).</summary>
	public ushort EventBase { get; }

	/// <summary>Tempo word at <c>DataBase + 0x30</c>.</summary>
	public ushort Tempo { get; }

	/// <summary>Loop start measure at <c>DataBase + 0x2A</c>.</summary>
	public ushort LoopStartMeasure { get; }

	/// <summary>Loop end measure at <c>DataBase + 0x2C</c>.</summary>
	public ushort LoopEndMeasure { get; }

	/// <summary>Loop count at <c>DataBase + 0x2E</c>.</summary>
	public ushort LoopCount { get; }

	/// <summary>Number of 0x28-byte instrument records that fit between <see cref="EventBase"/> and end of image.</summary>
	public int InstrumentCount { get; }

	/// <summary>Number of channels with a non-zero offset.</summary>
	public int ActiveChannelCount { get; }

	/// <summary>Per-channel relative offset (word). Length 9.</summary>
	public ReadOnlySpan<ushort> ChannelOffsets => _channelOffsets;

	/// <summary>Per-channel active flag (offset != 0). Length 9.</summary>
	public ReadOnlySpan<bool> ChannelActive => _channelActive;

	internal AdgSongHeader(
		int rawFileSize,
		bool wasCompressed,
		ushort eventBase,
		ushort tempo,
		ushort loopStartMeasure,
		ushort loopEndMeasure,
		ushort loopCount,
		int instrumentCount,
		ushort[] channelOffsets,
		bool[] channelActive,
		int activeChannelCount) {
		RawFileSize = rawFileSize;
		WasCompressed = wasCompressed;
		EventBase = eventBase;
		Tempo = tempo;
		LoopStartMeasure = loopStartMeasure;
		LoopEndMeasure = loopEndMeasure;
		LoopCount = loopCount;
		InstrumentCount = instrumentCount;
		_channelOffsets = channelOffsets;
		_channelActive = channelActive;
		ActiveChannelCount = activeChannelCount;
	}
}