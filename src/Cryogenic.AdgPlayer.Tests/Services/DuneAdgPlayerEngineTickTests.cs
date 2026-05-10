namespace Cryogenic.AdgPlayer.Tests.Services;

using Cryogenic.AdgPlayer.Services;
using Cryogenic.AdgPlayer.Song;

using System;

using Xunit;

/// <summary>Tests for <see cref="DuneAdgPlayerEngine"/> Tick scaffold.</summary>
public sealed class DuneAdgPlayerEngineTickTests {
	private static byte[] BuildSong(ushort[] channelOffsets) {
		byte[] bytes = new byte[0x100];
		bytes[0] = 0x00;
		bytes[1] = 0x01;
		int dataBase = AdgSongHeader.DataBase;
		for (int i = 0; i < AdgSongHeader.ChannelCount; i++) {
			bytes[dataBase + i * 2] = (byte)(channelOffsets[i] & 0xFF);
			bytes[dataBase + i * 2 + 1] = (byte)(channelOffsets[i] >> 8);
		}
		return bytes;
	}

	/// <summary>Tick without a loaded song throws.</summary>
	[Fact]
	public void Tick_NoSong_Throws() {
		// Arrange
		DuneAdgPlayerEngine engine = new();

		// Act / Assert
		Assert.Throws<InvalidOperationException>(() => engine.Tick());
	}

	/// <summary>Play without song throws; Play after song succeeds.</summary>
	[Fact]
	public void Play_RequiresSong() {
		// Arrange
		DuneAdgPlayerEngine engine = new();

		// Act / Assert
		Assert.Throws<InvalidOperationException>(() => engine.Play());
		engine.Load(BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 }));
		engine.Play();
		Assert.True(engine.IsPlaying);
	}

	/// <summary>Play twice in a row throws.</summary>
	[Fact]
	public void Play_AlreadyPlaying_Throws() {
		// Arrange
		DuneAdgPlayerEngine engine = new();
		engine.Load(BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 }));
		engine.Play();

		// Act / Assert
		Assert.Throws<InvalidOperationException>(() => engine.Play());
	}

	/// <summary>StopPlayback is idempotent.</summary>
	[Fact]
	public void StopPlayback_Idempotent() {
		// Arrange
		DuneAdgPlayerEngine engine = new();
		engine.Load(BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 }));

		// Act
		engine.StopPlayback();
		engine.StopPlayback();

		// Assert
		Assert.False(engine.IsPlaying);
	}

	/// <summary>Tick increments TickCount.</summary>
	[Fact]
	public void Tick_IncrementsCount() {
		// Arrange
		DuneAdgPlayerEngine engine = new();
		engine.Load(BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 }));

		// Act
		engine.Tick();
		engine.Tick();
		engine.Tick();

		// Assert
		Assert.Equal(3L, engine.TickCount);
	}

	/// <summary>Tick decrements per-channel wait counters.</summary>
	[Fact]
	public void Tick_DecrementsWaitCounters() {
		// Arrange — channel 0 active, starts at wait=1.
		DuneAdgPlayerEngine engine = new();
		engine.Load(BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 }));
		Assert.Equal(1, engine.State.WaitCounters.Get(0));

		// Act
		engine.Tick();

		// Assert
		Assert.Equal(0, engine.State.WaitCounters.Get(0));
	}

	/// <summary>Tick returns true while any channel is active.</summary>
	[Fact]
	public void Tick_ReturnsTrue_WhenAnyChannelActive() {
		// Arrange — channel 0 relative offset 0x10 → absolute pointer
		// 0x12 (DataBase = 2). Stream: ReadWaitValue (0x0020) + 5.
		// After the first tick, the dispatcher seeds wait=5 and the
		// channel stays active.
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x20;
		bytes[0x13] = 0x00;
		bytes[0x14] = 0x05;
		DuneAdgPlayerEngine engine = new();
		engine.Load(bytes);

		// Act
		bool result = engine.Tick();

		// Assert
		Assert.True(result);
	}

	/// <summary>Tick returns false and stops playback when every channel pointer is zero.</summary>
	[Fact]
	public void Tick_ReturnsFalse_WhenAllChannelsExhausted() {
		// Arrange — all-zero pointers means inactive song.
		DuneAdgPlayerEngine engine = new();
		engine.Load(BuildSong(new ushort[9]));
		engine.Play();

		// Act
		bool result = engine.Tick();

		// Assert
		Assert.False(result);
		Assert.False(engine.IsPlaying);
	}

	/// <summary>Load resets TickCount.</summary>
	[Fact]
	public void Load_ResetsTickCount() {
		// Arrange
		DuneAdgPlayerEngine engine = new();
		engine.Load(BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 }));
		engine.Tick();
		engine.Tick();

		// Act
		engine.Load(BuildSong(new ushort[] { 0x20, 0, 0, 0, 0, 0, 0, 0, 0 }));

		// Assert
		Assert.Equal(0L, engine.TickCount);
	}
}