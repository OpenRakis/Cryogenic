namespace Cryogenic.AdgPlayer.Tests.Engine;

using Cryogenic.AdgPlayer.Services;

/// <summary>
/// Phase 1 — Engine skeleton: 18 OPL3 Gold channels, idle initial state.
/// Authoritative source: src/Cryogenic/Overrides/AdgDriverCode.cs and DNADG.UNHSQ.
/// </summary>
public sealed class DuneAdgPlayerEngineSkeletonTests {
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		DuneAdgPlayerEngine engine = new DuneAdgPlayerEngine();

		// Act
		int channelCount = engine.ChannelCount;

		// Assert
		Assert.Equal(18, channelCount);
	}

	[Fact]
	public void NewEngine_IsNotPlaying() {
		// Arrange
		DuneAdgPlayerEngine engine = new DuneAdgPlayerEngine();

		// Act
		bool isPlaying = engine.IsPlaying;

		// Assert
		Assert.False(isPlaying);
	}

	[Fact]
	public void NewEngine_HasNoLoadedSong() {
		// Arrange
		DuneAdgPlayerEngine engine = new DuneAdgPlayerEngine();

		// Act
		bool hasSong = engine.HasSongLoaded;

		// Assert
		Assert.False(hasSong);
	}

	[Fact]
	public void PitReloadValue_MatchesDnadgDriver() {
		// Arrange — DNADG programs the PIT with reload 0x1745 (≈181 Hz).
		// Source: AdgDriverCode.cs InstallTimer routine and DNADG.UNHSQ disasm.
		DuneAdgPlayerEngine engine = new DuneAdgPlayerEngine();

		// Act
		int reload = engine.PitReloadValue;

		// Assert
		Assert.Equal(0x1745, reload);
	}
}