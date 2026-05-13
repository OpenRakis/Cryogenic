namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Song;

using Xunit;

/// <summary>
/// Tests for <see cref="AdgLoopPointChecker"/>, the pure port of
/// <c>AdgCheckLoopPoint_07DA</c>.
/// </summary>
public sealed class AdgLoopPointCheckerTests {
	private static AdgSongHeader BuildHeader(ushort loopStart, ushort loopEnd, ushort loopCount) {
		ushort[] offsets = new ushort[AdgSongHeader.ChannelCount];
		bool[] active = new bool[AdgSongHeader.ChannelCount];
		return new AdgSongHeader(
			rawFileSize: 1024,
			wasCompressed: false,
			eventBase: 0x0200,
			tempo: 0x0042,
			loopStartMeasure: loopStart,
			loopEndMeasure: loopEnd,
			loopCount: loopCount,
			instrumentCount: 0,
			channelOffsets: offsets,
			channelActive: active,
			activeChannelCount: 0);
	}

	/// <summary>
	/// LoopCounter zero, Measure mismatches LoopStartMeasure: no
	/// state mutation, no snapshot taken.
	/// </summary>
	[Fact]
	public void Check_LoopCounterZero_MeasureMismatch_NoOp() {
		// Arrange
		AdgSongHeader header = BuildHeader(loopStart: 5, loopEnd: 10, loopCount: 4);
		AdgLoopState loopState = new();
		loopState.SetMeasure(3);
		loopState.SetSubdivision(0x60);
		loopState.SetLoopCounter(0);
		AdgLoopSnapshotStore store = new();
		AdgChannelWaitCounters waits = new();
		AdgChannelEventPointers pointers = new();

		// Act
		AdgLoopPointAction action = AdgLoopPointChecker.Check(
			header, loopState, store, waits, pointers);

		// Assert
		Assert.Equal(AdgLoopPointAction.None, action);
		Assert.False(store.HasSnapshot);
		Assert.Equal(0, loopState.LoopCounter);
		Assert.Equal(3, loopState.Measure);
	}

	/// <summary>
	/// LoopCounter zero, Measure matches but Subdivision is not
	/// 0x60: no snapshot taken (mirrors the dnadg:07E5 guard).
	/// </summary>
	[Fact]
	public void Check_LoopStartMeasure_WrongSubdivision_NoOp() {
		// Arrange
		AdgSongHeader header = BuildHeader(loopStart: 5, loopEnd: 10, loopCount: 4);
		AdgLoopState loopState = new();
		loopState.SetMeasure(5);
		loopState.SetSubdivision(0x30);
		loopState.SetLoopCounter(0);
		AdgLoopSnapshotStore store = new();
		AdgChannelWaitCounters waits = new();
		AdgChannelEventPointers pointers = new();

		// Act
		AdgLoopPointAction action = AdgLoopPointChecker.Check(
			header, loopState, store, waits, pointers);

		// Assert
		Assert.Equal(AdgLoopPointAction.None, action);
		Assert.False(store.HasSnapshot);
		Assert.Equal(0, loopState.LoopCounter);
	}

	/// <summary>
	/// LoopCounter zero, Measure matches loop start AND Subdivision
	/// is 0x60: snapshot saved, counter seeded with
	/// <c>LoopCount - 1</c>.
	/// </summary>
	[Fact]
	public void Check_LoopStartArmed_SnapshotTakenAndCounterSeeded() {
		// Arrange
		AdgSongHeader header = BuildHeader(loopStart: 5, loopEnd: 10, loopCount: 4);
		AdgLoopState loopState = new();
		loopState.SetMeasure(5);
		loopState.SetSubdivision(0x60);
		loopState.SetLoopCounter(0);
		AdgLoopSnapshotStore store = new();
		AdgChannelWaitCounters waits = new();
		AdgChannelEventPointers pointers = new();
		waits.Set(2, 0x0007);
		pointers.Set(2, 0x0123);

		// Act
		AdgLoopPointAction action = AdgLoopPointChecker.Check(
			header, loopState, store, waits, pointers);

		// Assert
		Assert.Equal(AdgLoopPointAction.Snapshot, action);
		Assert.True(store.HasSnapshot);
		Assert.Equal(3, loopState.LoopCounter);
		Assert.Equal(0x0007, store.GetWaitCounter(2));
		Assert.Equal(0x0123, store.GetEventPointer(2));
	}

	/// <summary>
	/// LoopCounter non-zero, Measure mismatches LoopEndMeasure: no
	/// op, counter unchanged.
	/// </summary>
	[Fact]
	public void Check_LoopCounterNonZero_MeasureMismatch_NoOp() {
		// Arrange
		AdgSongHeader header = BuildHeader(loopStart: 5, loopEnd: 10, loopCount: 4);
		AdgLoopState loopState = new();
		loopState.SetMeasure(7);
		loopState.SetSubdivision(0x60);
		loopState.SetLoopCounter(2);
		AdgLoopSnapshotStore store = new();
		AdgChannelWaitCounters waits = new();
		AdgChannelEventPointers pointers = new();

		// Act
		AdgLoopPointAction action = AdgLoopPointChecker.Check(
			header, loopState, store, waits, pointers);

		// Assert
		Assert.Equal(AdgLoopPointAction.None, action);
		Assert.Equal(2, loopState.LoopCounter);
		Assert.Equal(7, loopState.Measure);
	}

	/// <summary>
	/// LoopCounter non-zero, Measure equals LoopEndMeasure: counter
	/// is decremented, snapshot is restored, measure rewinds to
	/// LoopStartMeasure.
	/// </summary>
	[Fact]
	public void Check_LoopEndReached_RestoresSnapshotAndRewindsMeasure() {
		// Arrange
		AdgSongHeader header = BuildHeader(loopStart: 5, loopEnd: 10, loopCount: 4);
		AdgLoopState loopState = new();
		loopState.SetMeasure(5);
		loopState.SetSubdivision(0x60);
		loopState.SetLoopCounter(0);
		AdgLoopSnapshotStore store = new();
		AdgChannelWaitCounters waits = new();
		AdgChannelEventPointers pointers = new();
		waits.Set(0, 0x0011);
		pointers.Set(0, 0x0222);

		// Take a snapshot at the loop start.
		AdgLoopPointChecker.Check(header, loopState, store, waits, pointers);
		Assert.Equal(3, loopState.LoopCounter);

		// Mutate live state as if the song had played a few measures.
		waits.Set(0, 0xFFFF);
		pointers.Set(0, 0xAAAA);
		loopState.SetMeasure(10);

		// Act
		AdgLoopPointAction action = AdgLoopPointChecker.Check(
			header, loopState, store, waits, pointers);

		// Assert
		Assert.Equal(AdgLoopPointAction.Restore, action);
		Assert.Equal(2, loopState.LoopCounter);
		Assert.Equal(5, loopState.Measure);
		Assert.Equal(0x0011, waits.Get(0));
		Assert.Equal(0x0222, pointers.Get(0));
	}
}