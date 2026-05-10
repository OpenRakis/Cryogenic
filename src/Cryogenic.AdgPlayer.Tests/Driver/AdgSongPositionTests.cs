namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgSongPosition"/>.
/// </summary>
public sealed class AdgSongPositionTests {
	/// <summary>All four cursor words start at zero.</summary>
	[Fact]
	public void Default_AllCursorsAreZero() {
		// Arrange
		AdgSongPosition position = new();

		// Act
		// (read-only)

		// Assert
		Assert.Equal(0, position.SongPointer);
		Assert.Equal(0, position.SongSegment);
		Assert.Equal(0, position.EventPointer);
		Assert.Equal(0, position.EventSegment);
	}

	/// <summary>Each cursor setter writes its dedicated word.</summary>
	[Fact]
	public void Setters_StoreEachCursorIndependently() {
		// Arrange
		AdgSongPosition position = new();

		// Act
		position.SetSongPointer(0x1111);
		position.SetSongSegment(0x2222);
		position.SetEventPointer(0x3333);
		position.SetEventSegment(0x4444);

		// Assert
		Assert.Equal(0x1111, position.SongPointer);
		Assert.Equal(0x2222, position.SongSegment);
		Assert.Equal(0x3333, position.EventPointer);
		Assert.Equal(0x4444, position.EventSegment);
	}

	/// <summary><c>Reset</c> clears every cursor word.</summary>
	[Fact]
	public void Reset_ClearsAllCursors() {
		// Arrange
		AdgSongPosition position = new();
		position.SetSongPointer(0x1111);
		position.SetSongSegment(0x2222);
		position.SetEventPointer(0x3333);
		position.SetEventSegment(0x4444);

		// Act
		position.Reset();

		// Assert
		Assert.Equal(0, position.SongPointer);
		Assert.Equal(0, position.SongSegment);
		Assert.Equal(0, position.EventPointer);
		Assert.Equal(0, position.EventSegment);
	}
}