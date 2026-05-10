namespace Cryogenic.AdgPlayer.Ui.Tests.ViewModels;

using System;
using System.IO;

using Cryogenic.AdgPlayer.Opl;
using Cryogenic.AdgPlayer.Song;
using Cryogenic.AdgPlayer.Ui.ViewModels;

using Xunit;

/// <summary>Tests for <see cref="AdgPlayerSessionViewModel"/>.</summary>
public sealed class AdgPlayerSessionViewModelTests {
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

	/// <summary>Constructor wires engine bus to the supplied bus.</summary>
	[Fact]
	public void Constructor_WiresOplBus() {
		// Arrange
		RecordingOplBus bus = new();

		// Act
		using AdgPlayerSessionViewModel session = new(bus);

		// Assert
		Assert.Same(bus, session.Engine.OplBus);
		Assert.Same(bus, session.Host.Bus);
	}

	/// <summary>PlayCommand is disabled when no song is loaded.</summary>
	[Fact]
	public void PlayCommand_Disabled_WhenNoSong() {
		// Arrange
		using AdgPlayerSessionViewModel session = new(new RecordingOplBus());

		// Act / Assert
		Assert.False(session.PlayCommand.CanExecute(null));
	}

	/// <summary>LoadCommand is disabled with empty path.</summary>
	[Fact]
	public void LoadCommand_Disabled_WithBadPath() {
		// Arrange
		using AdgPlayerSessionViewModel session = new(new RecordingOplBus());

		// Act / Assert
		Assert.False(session.LoadCommand.CanExecute(""));
		Assert.False(session.LoadCommand.CanExecute(null));
		Assert.False(session.LoadCommand.CanExecute(@"C:\does-not-exist-zzz.bin"));
	}

	/// <summary>LoadCommand reads file bytes and seeds engine state.</summary>
	[Fact]
	public void LoadCommand_LoadsSong() {
		// Arrange
		using AdgPlayerSessionViewModel session = new(new RecordingOplBus());
		string path = Path.Combine(Path.GetTempPath(), $"adg_session_{Guid.NewGuid():N}.bin");
		File.WriteAllBytes(path, BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 }));

		try {
			// Act
			session.LoadCommand.Execute(path);

			// Assert
			Assert.True(session.Engine.HasSongLoaded);
			Assert.True(session.PlayCommand.CanExecute(null));
		} finally {
			File.Delete(path);
		}
	}

	/// <summary>PlayCommand starts playback and host; StopCommand stops both.</summary>
	[Fact]
	public void PlayThenStop_TogglesState() {
		// Arrange
		using AdgPlayerSessionViewModel session = new(new RecordingOplBus());
		string path = Path.Combine(Path.GetTempPath(), $"adg_session_{Guid.NewGuid():N}.bin");
		File.WriteAllBytes(path, BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 }));

		try {
			session.LoadCommand.Execute(path);

			// Act
			session.PlayCommand.Execute(null);
			Assert.True(session.Engine.IsPlaying);
			Assert.True(session.Host.IsRunning);

			session.StopCommand.Execute(null);

			// Assert
			Assert.False(session.Engine.IsPlaying);
			Assert.False(session.Host.IsRunning);
		} finally {
			File.Delete(path);
		}
	}

	/// <summary>Tick on a fully exhausted song stops playback automatically.</summary>
	[Fact]
	public void HostTick_AllChannelsEmpty_AutoStops() {
		// Arrange — song with every channel offset 0 → no active channels.
		using AdgPlayerSessionViewModel session = new(new RecordingOplBus());
		string path = Path.Combine(Path.GetTempPath(), $"adg_session_{Guid.NewGuid():N}.bin");
		File.WriteAllBytes(path, BuildSong(new ushort[9]));

		try {
			session.LoadCommand.Execute(path);
			session.PlayCommand.Execute(null);

			// Act — drive one synchronous tick.
			session.Host.Tick();

			// Assert
			Assert.False(session.Engine.IsPlaying);
			Assert.False(session.Host.IsRunning);
		} finally {
			File.Delete(path);
		}
	}

	/// <summary>Host-tick callback is routed through the supplied dispatcher.</summary>
	[Fact]
	public void HostTick_RoutesThroughDispatcher() {
		// Arrange — capture the dispatcher invocations.
		int dispatchCount = 0;
		Action<Action> dispatch = action => { dispatchCount++; action(); };
		using AdgPlayerSessionViewModel session = new(new RecordingOplBus(), dispatch);
		string path = Path.Combine(Path.GetTempPath(), $"adg_session_{Guid.NewGuid():N}.bin");
		File.WriteAllBytes(path, BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 }));

		try {
			session.LoadCommand.Execute(path);
			session.PlayCommand.Execute(null);

			// Act
			session.Host.Tick();

			// Assert
			Assert.Equal(1, dispatchCount);
		} finally {
			File.Delete(path);
		}
	}
}
