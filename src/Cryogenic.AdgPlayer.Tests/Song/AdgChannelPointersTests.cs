namespace Cryogenic.AdgPlayer.Tests.Song;

using System;
using Cryogenic.AdgPlayer.Song;
using Xunit;

/// <summary>Tests for <see cref="AdgChannelPointers"/> and <see cref="AdgInMemoryEventStream"/>.</summary>
public sealed class AdgChannelPointersTests {
	private static AdgSongHeader BuildHeader(ushort[] relativeOffsets) {
		bool[] active = new bool[relativeOffsets.Length];
		int activeCount = 0;
		for (int i = 0; i < relativeOffsets.Length; i++) {
			active[i] = relativeOffsets[i] != 0;
			if (active[i]) {
				activeCount++;
			}
		}
		return new AdgSongHeader(
			rawFileSize: 1024,
			wasCompressed: false,
			eventBase: 0x0200,
			tempo: 0x0042,
			loopStartMeasure: 0,
			loopEndMeasure: 0,
			loopCount: 0,
			instrumentCount: 0,
			channelOffsets: relativeOffsets,
			channelActive: active,
			activeChannelCount: activeCount);
	}

	/// <summary>Active relative offsets are translated by adding DataBase.</summary>
	[Fact]
	public void GetAbsoluteOffset_AddsDataBase() {
		// Arrange
		ushort[] offsets = new ushort[] { 0x0050, 0, 0x0060, 0, 0, 0, 0, 0, 0 };
		AdgChannelPointers pointers = new(BuildHeader(offsets));

		// Act / Assert
		Assert.Equal(0x0050 + AdgSongHeader.DataBase, pointers.GetAbsoluteOffset(0));
		Assert.Equal(0, pointers.GetAbsoluteOffset(1));
		Assert.Equal(0x0060 + AdgSongHeader.DataBase, pointers.GetAbsoluteOffset(2));
	}

	/// <summary>Active flag matches non-zero entries.</summary>
	[Fact]
	public void IsChannelActive_MatchesNonZero() {
		// Arrange
		ushort[] offsets = new ushort[] { 0x0050, 0, 0x0060, 0, 0, 0, 0, 0, 0 };
		AdgChannelPointers pointers = new(BuildHeader(offsets));

		// Act / Assert
		Assert.True(pointers.IsChannelActive(0));
		Assert.False(pointers.IsChannelActive(1));
		Assert.True(pointers.IsChannelActive(2));
	}

	/// <summary>Out-of-range channel index throws.</summary>
	[Fact]
	public void GetAbsoluteOffset_OutOfRange_Throws() {
		// Arrange
		ushort[] offsets = new ushort[9];
		AdgChannelPointers pointers = new(BuildHeader(offsets));

		// Act / Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => pointers.GetAbsoluteOffset(-1));
		Assert.Throws<ArgumentOutOfRangeException>(() => pointers.GetAbsoluteOffset(9));
	}

	/// <summary>EventStream forwards reads to the underlying image.</summary>
	[Fact]
	public void EventStream_ReadByte_AndUInt16() {
		// Arrange
		byte[] data = new byte[] { 0x11, 0x22, 0x33, 0x44 };
		AdgSongImage image = new(data, false);
		AdgInMemoryEventStream stream = new(image);

		// Act / Assert
		Assert.Equal(4, stream.Length);
		Assert.Equal(0x11, stream.ReadByte(0));
		Assert.Equal(0x4433, stream.ReadUInt16(2));
		Assert.True(stream.InRange(3));
		Assert.False(stream.InRange(4));
		Assert.True(stream.WordInRange(2));
		Assert.False(stream.WordInRange(3));
	}
}
