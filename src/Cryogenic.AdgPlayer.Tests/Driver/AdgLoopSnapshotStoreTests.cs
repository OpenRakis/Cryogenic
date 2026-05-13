namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Tests for <see cref="AdgLoopSnapshotStore"/>, the pure mirror of
/// the rep-movs in <c>AdgCheckLoopPoint_07DA</c>.
/// </summary>
public sealed class AdgLoopSnapshotStoreTests {
	/// <summary>Freshly constructed stores have <c>HasSnapshot=false</c>.</summary>
	[Fact]
	public void HasSnapshot_StartsFalse() {
		// Arrange
		AdgLoopSnapshotStore store = new();

		// Act / Assert
		Assert.False(store.HasSnapshot);
	}

	/// <summary>
	/// <see cref="AdgLoopSnapshotStore.Save"/> copies every wait
	/// counter and every event pointer and flips
	/// <see cref="AdgLoopSnapshotStore.HasSnapshot"/>.
	/// </summary>
	[Fact]
	public void Save_CapturesAllChannelWords() {
		// Arrange
		AdgChannelWaitCounters waits = new();
		AdgChannelEventPointers pointers = new();
		for (int i = 0; i < AdgLoopSnapshotStore.ChannelCount; i++) {
			waits.Set(i, (ushort)(0x1000 + i));
			pointers.Set(i, (ushort)(0x2000 + i));
		}
		AdgLoopSnapshotStore store = new();

		// Act
		store.Save(waits, pointers);

		// Assert
		Assert.True(store.HasSnapshot);
		for (int i = 0; i < AdgLoopSnapshotStore.ChannelCount; i++) {
			Assert.Equal((ushort)(0x1000 + i), store.GetWaitCounter(i));
			Assert.Equal((ushort)(0x2000 + i), store.GetEventPointer(i));
		}
	}

	/// <summary>
	/// <see cref="AdgLoopSnapshotStore.Restore"/> writes the saved
	/// words back into the live tables, overwriting whatever they
	/// currently hold.
	/// </summary>
	[Fact]
	public void Restore_WritesSavedWordsIntoLiveTables() {
		// Arrange
		AdgChannelWaitCounters waits = new();
		AdgChannelEventPointers pointers = new();
		for (int i = 0; i < AdgLoopSnapshotStore.ChannelCount; i++) {
			waits.Set(i, (ushort)(0x0100 + i));
			pointers.Set(i, (ushort)(0x0200 + i));
		}
		AdgLoopSnapshotStore store = new();
		store.Save(waits, pointers);

		// Mutate the live tables after the snapshot.
		for (int i = 0; i < AdgLoopSnapshotStore.ChannelCount; i++) {
			waits.Set(i, 0xDEAD);
			pointers.Set(i, 0xBEEF);
		}

		// Act
		store.Restore(waits, pointers);

		// Assert
		for (int i = 0; i < AdgLoopSnapshotStore.ChannelCount; i++) {
			Assert.Equal((ushort)(0x0100 + i), waits.Get(i));
			Assert.Equal((ushort)(0x0200 + i), pointers.Get(i));
		}
	}

	/// <summary>
	/// <see cref="AdgLoopSnapshotStore.Reset"/> clears the snapshot
	/// flag and zeroes all stored words.
	/// </summary>
	[Fact]
	public void Reset_ClearsSnapshot() {
		// Arrange
		AdgChannelWaitCounters waits = new();
		AdgChannelEventPointers pointers = new();
		waits.Set(5, 0x4242);
		pointers.Set(5, 0x9999);
		AdgLoopSnapshotStore store = new();
		store.Save(waits, pointers);

		// Act
		store.Reset();

		// Assert
		Assert.False(store.HasSnapshot);
		Assert.Equal(0, store.GetWaitCounter(5));
		Assert.Equal(0, store.GetEventPointer(5));
	}
}