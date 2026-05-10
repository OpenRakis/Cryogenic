namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgChannelCurrentNotes"/>.
/// </summary>
public sealed class AdgChannelCurrentNotesTests {
	/// <summary>The table holds 18 channel slots.</summary>
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		// Act
		int count = AdgChannelCurrentNotes.ChannelCount;

		// Assert
		Assert.Equal(18, count);
	}

	/// <summary>All slots default to zero (no active note).</summary>
	[Fact]
	public void Default_AllSlotsAreZero() {
		// Arrange
		AdgChannelCurrentNotes notes = new();

		// Act
		// Assert
		for (int i = 0; i < AdgChannelCurrentNotes.ChannelCount; i++) {
			Assert.Equal(0, notes.Get(i));
		}
	}

	/// <summary><c>Set</c> writes the note byte for the channel.</summary>
	[Fact]
	public void Set_StoresNoteAtIndex() {
		// Arrange
		AdgChannelCurrentNotes notes = new();

		// Act
		notes.Set(3, 0x48);
		notes.Set(17, 0x7F);

		// Assert
		Assert.Equal(0x48, notes.Get(3));
		Assert.Equal(0x7F, notes.Get(17));
		Assert.Equal(0x00, notes.Get(0));
	}

	/// <summary>
	/// <c>Clear</c> resets a single channel to 0 (matches the
	/// <c>mov byte ptr [DI+0x6D],0</c> after a note-off match at
	/// dnadg:0AC8).
	/// </summary>
	[Fact]
	public void Clear_ResetsOnlyTargetedChannel() {
		// Arrange
		AdgChannelCurrentNotes notes = new();
		notes.Set(2, 0x40);
		notes.Set(5, 0x60);

		// Act
		notes.Clear(2);

		// Assert
		Assert.Equal(0x00, notes.Get(2));
		Assert.Equal(0x60, notes.Get(5));
	}

	/// <summary><c>Reset</c> clears every slot.</summary>
	[Fact]
	public void Reset_ClearsAllSlots() {
		// Arrange
		AdgChannelCurrentNotes notes = new();
		for (int i = 0; i < AdgChannelCurrentNotes.ChannelCount; i++) {
			notes.Set(i, (byte)(0x40 + i));
		}

		// Act
		notes.Reset();

		// Assert
		for (int i = 0; i < AdgChannelCurrentNotes.ChannelCount; i++) {
			Assert.Equal(0, notes.Get(i));
		}
	}

	/// <summary>Out-of-range access throws.</summary>
	[Fact]
	public void Get_OutOfRange_Throws() {
		// Arrange
		AdgChannelCurrentNotes notes = new();

		// Act
		// Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => notes.Get(-1));
		Assert.Throws<ArgumentOutOfRangeException>(() => notes.Get(18));
	}
}