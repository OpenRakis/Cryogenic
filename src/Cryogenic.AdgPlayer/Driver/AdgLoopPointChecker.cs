namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Song;

/// <summary>
/// Pure port of <c>AdgCheckLoopPoint_07DA</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c> (dnadg:07DA).
/// </summary>
/// <remarks>
/// The oracle behaves as follows (paraphrased from the override
/// body):
/// <list type="bullet">
///   <item>
///     If <c>LoopCounter == 0</c> and the active <c>Measure</c>
///     equals the song's <c>LoopStartMeasure</c> and the
///     <c>Subdivision</c> equals <c>0x60</c>, snapshot the channel
///     wait-counter / event-pointer tables and seed
///     <c>LoopCounter = LoopCount - 1</c>.
///   </item>
///   <item>
///     Otherwise, when <c>LoopCounter != 0</c> and the active
///     <c>Measure</c> equals the song's <c>LoopEndMeasure</c>,
///     decrement the loop counter, restore the snapshot, and rewind
///     the active measure to the song's <c>LoopStartMeasure</c>.
///   </item>
///   <item>Every other tick is a no-op.</item>
/// </list>
/// This component is pure: it reads/writes the supplied state
/// objects and the snapshot store; it never touches the OPL bus.
/// </remarks>
public static class AdgLoopPointChecker {
	/// <summary>
	/// Subdivision word required for the loop-start arming branch
	/// (matches <c>(byte)AdgImmediate.NinetySix</c> in the oracle).
	/// </summary>
	public const ushort LoopStartSubdivisionGate = 0x60;

	/// <summary>
	/// Single tick of the loop-point checker. See the type docs for
	/// the full state machine.
	/// </summary>
	/// <returns>
	/// One of the <see cref="AdgLoopPointAction"/> enum values
	/// describing what side effect was applied. Useful for tests
	/// and logging.
	/// </returns>
	public static AdgLoopPointAction Check(
		AdgSongHeader songHeader,
		AdgLoopState loopState,
		AdgLoopSnapshotStore snapshotStore,
		AdgChannelWaitCounters waitCounters,
		AdgChannelEventPointers eventPointers) {
		ArgumentNullException.ThrowIfNull(songHeader);
		ArgumentNullException.ThrowIfNull(loopState);
		ArgumentNullException.ThrowIfNull(snapshotStore);
		ArgumentNullException.ThrowIfNull(waitCounters);
		ArgumentNullException.ThrowIfNull(eventPointers);

		if (loopState.LoopCounter == 0) {
			if (loopState.Measure != songHeader.LoopStartMeasure) {
				return AdgLoopPointAction.None;
			}
			if (loopState.Subdivision != LoopStartSubdivisionGate) {
				return AdgLoopPointAction.None;
			}

			snapshotStore.Save(waitCounters, eventPointers);
			loopState.SetLoopCounter((ushort)(songHeader.LoopCount - 1));
			return AdgLoopPointAction.Snapshot;
		}

		if (loopState.Measure != songHeader.LoopEndMeasure) {
			return AdgLoopPointAction.None;
		}

		loopState.SetLoopCounter((ushort)(loopState.LoopCounter - 1));
		snapshotStore.Restore(waitCounters, eventPointers);
		loopState.SetMeasure(songHeader.LoopStartMeasure);
		return AdgLoopPointAction.Restore;
	}
}

/// <summary>
/// Outcome of a single <see cref="AdgLoopPointChecker.Check"/>
/// call.
/// </summary>
public enum AdgLoopPointAction {
	/// <summary>No loop-point side effect this tick.</summary>
	None,
	/// <summary>The loop-start branch fired and the snapshot was saved.</summary>
	Snapshot,
	/// <summary>The loop-end branch fired and the snapshot was restored.</summary>
	Restore,
}