namespace Cryogenic.AdgPlayer.Tests.Services;

using System;
using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Services;
using Cryogenic.AdgPlayer.Song;
using Xunit;

/// <summary>Tests for <see cref="DuneAdgPlayerEngine"/> Load partial.</summary>
public sealed class DuneAdgPlayerEngineLoadTests {
	private static byte[] BuildSongBytes(ushort eventBase, ushort tempo, ushort[] channelOffsets, int totalLength) {
		byte[] bytes = new byte[totalLength];
		bytes[0] = (byte)(eventBase & 0xFF);
		bytes[1] = (byte)(eventBase >> 8);
		int dataBase = AdgSongHeader.DataBase;
		for (int i = 0; i < AdgSongHeader.ChannelCount; i++) {
			bytes[dataBase + i * 2] = (byte)(channelOffsets[i] & 0xFF);
			bytes[dataBase + i * 2 + 1] = (byte)(channelOffsets[i] >> 8);
		}
		bytes[dataBase + 0x30] = (byte)(tempo & 0xFF);
		bytes[dataBase + 0x30 + 1] = (byte)(tempo >> 8);
		return bytes;
	}

	/// <summary>A freshly constructed engine is in an empty state.</summary>
	[Fact]
	public void DefaultState_NoSong() {
		// Arrange / Act
		DuneAdgPlayerEngine engine = new();

		// Assert
		Assert.False(engine.HasSongLoaded);
		Assert.False(engine.IsPlaying);
		Assert.Null(engine.SongImage);
		Assert.Null(engine.SongHeader);
		Assert.Null(engine.ChannelPointers);
	}

	/// <summary>Load with a null buffer throws.</summary>
	[Fact]
	public void Load_Null_Throws() {
		// Arrange
		DuneAdgPlayerEngine engine = new();

		// Act / Assert
		Assert.Throws<ArgumentNullException>(() => engine.Load(null!));
	}

	/// <summary>Load wires song state and seeds the driver event pointers.</summary>
	[Fact]
	public void Load_SeedsEventPointers() {
		// Arrange
		ushort[] offsets = new ushort[] { 0x0050, 0, 0x0060, 0, 0, 0, 0, 0, 0 };
		byte[] data = BuildSongBytes(0x0100, 0x0042, offsets, 0x0100);
		DuneAdgPlayerEngine engine = new();

		// Act
		engine.Load(data);

		// Assert
		Assert.True(engine.HasSongLoaded);
		Assert.False(engine.IsPlaying);
		Assert.NotNull(engine.SongImage);
		Assert.NotNull(engine.SongHeader);
		Assert.NotNull(engine.ChannelPointers);
		Assert.Equal(0x0050 + AdgSongHeader.DataBase, engine.State.EventPointers.Get(0));
		Assert.Equal(0, engine.State.EventPointers.Get(1));
		Assert.Equal(0x0060 + AdgSongHeader.DataBase, engine.State.EventPointers.Get(2));
	}

	/// <summary>Active channels start at wait-counter 1; inactive channels at 0.</summary>
	[Fact]
	public void Load_SeedsWaitCounters() {
		// Arrange
		ushort[] offsets = new ushort[] { 0x0050, 0, 0x0060, 0, 0, 0, 0, 0, 0 };
		byte[] data = BuildSongBytes(0x0100, 0x0042, offsets, 0x0100);
		DuneAdgPlayerEngine engine = new();

		// Act
		engine.Load(data);

		// Assert
		Assert.Equal(1, engine.State.WaitCounters.Get(0));
		Assert.Equal(0, engine.State.WaitCounters.Get(1));
		Assert.Equal(1, engine.State.WaitCounters.Get(2));
	}

	/// <summary>Loading a second song fully resets prior driver state.</summary>
	[Fact]
	public void Load_Twice_ResetsPriorState() {
		// Arrange
		ushort[] offsets1 = new ushort[] { 0x0050, 0x0060, 0, 0, 0, 0, 0, 0, 0 };
		ushort[] offsets2 = new ushort[] { 0, 0, 0x0070, 0, 0, 0, 0, 0, 0 };
		byte[] data1 = BuildSongBytes(0x0100, 0x0042, offsets1, 0x0100);
		byte[] data2 = BuildSongBytes(0x0100, 0x0042, offsets2, 0x0100);
		DuneAdgPlayerEngine engine = new();

		// Act
		engine.Load(data1);
		engine.Load(data2);

		// Assert — channel 0 (active in song 1) is now zero.
		Assert.Equal(0, engine.State.EventPointers.Get(0));
		Assert.Equal(0, engine.State.EventPointers.Get(1));
		Assert.Equal(0x0070 + AdgSongHeader.DataBase, engine.State.EventPointers.Get(2));
	}

	/// <summary>Unload clears the loaded state.</summary>
	[Fact]
	public void Unload_ClearsState() {
		// Arrange
		ushort[] offsets = new ushort[] { 0x0050, 0, 0, 0, 0, 0, 0, 0, 0 };
		byte[] data = BuildSongBytes(0x0100, 0x0042, offsets, 0x0100);
		DuneAdgPlayerEngine engine = new();
		engine.Load(data);

		// Act
		engine.Unload();

		// Assert
		Assert.False(engine.HasSongLoaded);
		Assert.Null(engine.SongImage);
		Assert.Equal(0, engine.State.EventPointers.Get(0));
	}

	/// <summary>HSQ-compressed input is decompressed transparently.</summary>
	[Fact]
	public void Load_HsqInput_Decompresses() {
		// Arrange — minimal HSQ literal stream covering a dummy 53-byte header (size 0x35).
		byte[] payload = new byte[0x35];
		payload[0] = 0x00; // eventBase low (no instruments)
		payload[1] = 0x01; // eventBase high → 0x0100 (beyond image, instrumentCount=0)
		payload[AdgSongHeader.DataBase + 0] = 0x10; // ch0 offset lo
		payload[AdgSongHeader.DataBase + 1] = 0x00; // ch0 offset hi → 0x0010
		// All other channels stay zero. Tempo at +0x30 stays zero.
		// Build literal HSQ wrapping `payload` (53 literal bytes).
		// 53 literals need 53 '1' bits = 4 bit-words (15 bits each = 60 bits ≥ 53).
		// Simpler: emit one bit-word covering 15 ones, repeat.
		System.Collections.Generic.List<byte> stream = [];
		// header: size = 0x35
		byte size_lo = 0x35;
		byte size_hi = 0x00;
		byte pad = 0x00;
		byte comp_lo = 0x00;
		byte comp_hi = 0x00;
		byte checksum = unchecked((byte)(0xAB - size_lo - size_hi - pad - comp_lo - comp_hi));
		stream.Add(size_lo);
		stream.Add(size_hi);
		stream.Add(pad);
		stream.Add(comp_lo);
		stream.Add(comp_hi);
		stream.Add(checksum);
		int written = 0;
		while (written < payload.Length) {
			int chunk = Math.Min(15, payload.Length - written);
			ushort bits = (ushort)((1 << chunk) - 1);
			stream.Add((byte)(bits & 0xFF));
			stream.Add((byte)(bits >> 8));
			for (int i = 0; i < chunk; i++) {
				stream.Add(payload[written + i]);
			}
			written += chunk;
		}
		byte[] hsq = stream.ToArray();
		DuneAdgPlayerEngine engine = new();

		// Act
		engine.Load(hsq);

		// Assert
		Assert.True(engine.HasSongLoaded);
		Assert.NotNull(engine.SongImage);
		Assert.True(engine.SongImage!.WasCompressed);
		Assert.Equal(0x10 + AdgSongHeader.DataBase, engine.State.EventPointers.Get(0));
	}
}
