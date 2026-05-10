namespace Cryogenic.AdgPlayer.Tests.Song;

using Cryogenic.AdgPlayer.Song;
using Xunit;

/// <summary>Tests for <see cref="AdgSongHeaderParser"/> and <see cref="AdgSongHeader"/>.</summary>
public sealed class AdgSongHeaderParserTests {
	/// <summary>
	/// Builds a synthetic 9-channel song image with the supplied
	/// per-channel offsets, tempo, and loop fields. Layout follows
	/// docs/ADP_DRIVER_ADG_FORMAT_AND_ADL_ADG_PLAN.md §4.3.
	/// </summary>
	private static byte[] BuildHeaderBytes(
		ushort eventBase,
		ushort tempo,
		ushort loopStart,
		ushort loopEnd,
		ushort loopCount,
		ushort[] channelOffsets,
		int totalLength) {
		byte[] bytes = new byte[totalLength];
		bytes[0] = (byte)(eventBase & 0xFF);
		bytes[1] = (byte)(eventBase >> 8);
		int dataBase = AdgSongHeader.DataBase;
		for (int i = 0; i < AdgSongHeader.ChannelCount; i++) {
			bytes[dataBase + i * 2] = (byte)(channelOffsets[i] & 0xFF);
			bytes[dataBase + i * 2 + 1] = (byte)(channelOffsets[i] >> 8);
		}
		bytes[dataBase + 0x2A] = (byte)(loopStart & 0xFF);
		bytes[dataBase + 0x2A + 1] = (byte)(loopStart >> 8);
		bytes[dataBase + 0x2C] = (byte)(loopEnd & 0xFF);
		bytes[dataBase + 0x2C + 1] = (byte)(loopEnd >> 8);
		bytes[dataBase + 0x2E] = (byte)(loopCount & 0xFF);
		bytes[dataBase + 0x2E + 1] = (byte)(loopCount >> 8);
		bytes[dataBase + 0x30] = (byte)(tempo & 0xFF);
		bytes[dataBase + 0x30 + 1] = (byte)(tempo >> 8);
		return bytes;
	}

	/// <summary>Header constants reflect the shared ADG/ADP layout.</summary>
	[Fact]
	public void HeaderConstants_MatchSpec() {
		// Assert
		Assert.Equal(9, AdgSongHeader.ChannelCount);
		Assert.Equal(2, AdgSongHeader.DataBase);
		Assert.Equal(0x28, AdgSongHeader.InstrumentRecordSize);
	}

	/// <summary>A short image throws.</summary>
	[Fact]
	public void Parse_ShortImage_Throws() {
		// Arrange
		AdgSongImage image = new(new byte[10], false);
		AdgSongHeaderParser parser = new();

		// Act / Assert
		Assert.Throws<InvalidAdgSongException>(() => parser.Parse(image));
	}

	/// <summary>Tempo, loop fields, and event base are read at their documented offsets.</summary>
	[Fact]
	public void Parse_BasicFields() {
		// Arrange
		ushort[] offsets = new ushort[] { 0x100, 0x110, 0x120, 0, 0x140, 0, 0, 0, 0 };
		byte[] bytes = BuildHeaderBytes(
			eventBase: 0x0200,
			tempo: 0x1234,
			loopStart: 0x0001,
			loopEnd: 0x0010,
			loopCount: 0x0003,
			channelOffsets: offsets,
			totalLength: 0x0200 + 4 * AdgSongHeader.InstrumentRecordSize);
		AdgSongImage image = new(bytes, false);
		AdgSongHeaderParser parser = new();

		// Act
		AdgSongHeader header = parser.Parse(image);

		// Assert
		Assert.Equal(0x0200, header.EventBase);
		Assert.Equal(0x1234, header.Tempo);
		Assert.Equal(0x0001, header.LoopStartMeasure);
		Assert.Equal(0x0010, header.LoopEndMeasure);
		Assert.Equal(0x0003, header.LoopCount);
		Assert.Equal(4, header.InstrumentCount);
		Assert.Equal(bytes.Length, header.RawFileSize);
		Assert.False(header.WasCompressed);
	}

	/// <summary>Channel offsets are exposed verbatim and the active count matches non-zero entries.</summary>
	[Fact]
	public void Parse_ChannelOffsets_AreExposed() {
		// Arrange
		ushort[] offsets = new ushort[] { 0x0050, 0, 0x0060, 0x0070, 0, 0, 0x0080, 0, 0 };
		byte[] bytes = BuildHeaderBytes(
			eventBase: 0x0100,
			tempo: 0x0042,
			loopStart: 0,
			loopEnd: 0,
			loopCount: 0,
			channelOffsets: offsets,
			totalLength: 0x0100);
		AdgSongImage image = new(bytes, true);
		AdgSongHeaderParser parser = new();

		// Act
		AdgSongHeader header = parser.Parse(image);

		// Assert
		Assert.Equal(9, header.ChannelOffsets.Length);
		for (int i = 0; i < 9; i++) {
			Assert.Equal(offsets[i], header.ChannelOffsets[i]);
			Assert.Equal(offsets[i] != 0, header.ChannelActive[i]);
		}
		Assert.Equal(4, header.ActiveChannelCount);
		Assert.True(header.WasCompressed);
	}

	/// <summary>Instrument count is zero when EventBase points beyond the image.</summary>
	[Fact]
	public void Parse_InstrumentCount_ZeroWhenEventBaseBeyondImage() {
		// Arrange — total length below EventBase.
		ushort[] offsets = new ushort[9];
		byte[] bytes = BuildHeaderBytes(
			eventBase: 0x1000,
			tempo: 0,
			loopStart: 0,
			loopEnd: 0,
			loopCount: 0,
			channelOffsets: offsets,
			totalLength: 0x100);
		AdgSongImage image = new(bytes, false);
		AdgSongHeaderParser parser = new();

		// Act
		AdgSongHeader header = parser.Parse(image);

		// Assert
		Assert.Equal(0, header.InstrumentCount);
	}
}
