namespace Cryogenic.AdgPlayer.Tests.Song;

using Cryogenic.AdgPlayer.Song;

using System.IO;

using Xunit;

/// <summary>Tests for <see cref="AdgSongLoader"/>.</summary>
public sealed class AdgSongLoaderTests {
	private static byte[] BuildLiteralHsqStream(byte a, byte b, byte c) {
		byte size_lo = 0x03;
		byte size_hi = 0x00;
		byte pad = 0x00;
		byte comp_lo = 0x00;
		byte comp_hi = 0x00;
		byte checksum = unchecked((byte)(0xAB - size_lo - size_hi - pad - comp_lo - comp_hi));
		byte bit_lo = 0x07;
		byte bit_hi = 0x00;
		return new byte[] {
			size_lo, size_hi, pad, comp_lo, comp_hi, checksum,
			bit_lo, bit_hi,
			a, b, c,
		};
	}

	/// <summary>Raw (non-HSQ) buffers pass straight through.</summary>
	[Fact]
	public void Load_RawBuffer_PassesThrough() {
		// Arrange
		AdgSongLoader loader = new();
		byte[] raw = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

		// Act
		AdgSongImage image = loader.Load(raw);

		// Assert
		Assert.False(image.WasCompressed);
		Assert.Equal(raw.Length, image.Length);
	}

	/// <summary>HSQ buffers are decompressed.</summary>
	[Fact]
	public void Load_HsqBuffer_Decompresses() {
		// Arrange
		AdgSongLoader loader = new();
		byte[] stream = BuildLiteralHsqStream(0x42, 0x43, 0x44);

		// Act
		AdgSongImage image = loader.Load(stream);

		// Assert
		Assert.True(image.WasCompressed);
		Assert.Equal(3, image.Length);
		Assert.Equal(0x42, image.ReadByte(0));
		Assert.Equal(0x43, image.ReadByte(1));
		Assert.Equal(0x44, image.ReadByte(2));
	}

	/// <summary>LoadFromFile reads bytes off disk and dispatches to <see cref="AdgSongLoader.Load(byte[])"/>.</summary>
	[Fact]
	public void LoadFromFile_RoundTrips() {
		// Arrange
		AdgSongLoader loader = new();
		string path = Path.Combine(Path.GetTempPath(), $"adg_loader_{System.Guid.NewGuid():N}.bin");
		byte[] payload = new byte[] { 0xDE, 0xAD, 0xBE, 0xEF };
		File.WriteAllBytes(path, payload);

		try {
			// Act
			AdgSongImage image = loader.LoadFromFile(path);

			// Assert
			Assert.False(image.WasCompressed);
			Assert.Equal(payload.Length, image.Length);
		} finally {
			File.Delete(path);
		}
	}
}