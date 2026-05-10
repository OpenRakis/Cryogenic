namespace Cryogenic.AdgPlayer.Tests.Song;

using System;
using Cryogenic.AdgPlayer.Song;
using Xunit;

/// <summary>Tests for <see cref="AdgSongImage"/>.</summary>
public sealed class AdgSongImageTests {
	/// <summary>Length and bytes are exposed verbatim.</summary>
	[Fact]
	public void Constructor_ExposesBytesAndLength() {
		// Arrange
		byte[] data = new byte[] { 0x01, 0x02, 0x03 };

		// Act
		AdgSongImage image = new(data, wasCompressed: true);

		// Assert
		Assert.Equal(3, image.Length);
		Assert.True(image.WasCompressed);
		Assert.Equal(data, image.Bytes.ToArray());
	}

	/// <summary>ReadByte returns the byte at the offset.</summary>
	[Fact]
	public void ReadByte_ReturnsByte() {
		// Arrange
		AdgSongImage image = new(new byte[] { 0xAA, 0xBB, 0xCC }, false);

		// Act / Assert
		Assert.Equal(0xAA, image.ReadByte(0));
		Assert.Equal(0xBB, image.ReadByte(1));
		Assert.Equal(0xCC, image.ReadByte(2));
	}

	/// <summary>ReadUInt16 reads little-endian.</summary>
	[Fact]
	public void ReadUInt16_ReadsLittleEndian() {
		// Arrange
		AdgSongImage image = new(new byte[] { 0x34, 0x12, 0x78, 0x56 }, false);

		// Act / Assert
		Assert.Equal(0x1234, image.ReadUInt16(0));
		Assert.Equal(0x5678, image.ReadUInt16(2));
	}

	/// <summary>Out-of-range offsets throw.</summary>
	[Fact]
	public void ReadByte_OutOfRange_Throws() {
		// Arrange
		AdgSongImage image = new(new byte[] { 0x01 }, false);

		// Act / Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => image.ReadByte(-1));
		Assert.Throws<ArgumentOutOfRangeException>(() => image.ReadByte(1));
	}

	/// <summary>Out-of-range word reads throw.</summary>
	[Fact]
	public void ReadUInt16_OutOfRange_Throws() {
		// Arrange
		AdgSongImage image = new(new byte[] { 0x01, 0x02 }, false);

		// Act / Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => image.ReadUInt16(1));
		Assert.Throws<ArgumentOutOfRangeException>(() => image.ReadUInt16(-1));
	}

	/// <summary>Constructor rejects null buffer.</summary>
	[Fact]
	public void Constructor_NullBuffer_Throws() {
		// Act / Assert
		Assert.Throws<ArgumentNullException>(() => new AdgSongImage(null!, false));
	}
}
