namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Holder for the rep-movs snapshot mirrored by
/// <c>AdgCheckLoopPoint_07DA</c> (oracle
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>, dnadg:07DA).
/// The driver copies <c>0x24</c> words (36 ushorts = 72 bytes) from
/// the channel-table base at <c>0x01E2</c> to its mirror cell at
/// <c>0x01E2 + 0x03B6 = 0x0598</c> when the loop start is reached
/// and copies the same range back when the loop end is hit. Within
/// the column-major layout used by DNADG those 36 words map exactly
/// to the 18 wait-counter words followed by the 18 event-pointer
/// words. This component owns those two arrays as opaque snapshot
/// state.
/// </summary>
public sealed class AdgLoopSnapshotStore {
	/// <summary>Total ushort words mirrored by the snapshot (matches <c>AdgLoopSnapshotWordCount = 0x24</c>).</summary>
	public const int SnapshotWordCount = 36;

	/// <summary>Number of channel slots covered by the snapshot.</summary>
	public const int ChannelCount = 18;

	private readonly ushort[] _waitCounters = new ushort[ChannelCount];
	private readonly ushort[] _eventPointers = new ushort[ChannelCount];
	private bool _hasSnapshot;

	/// <summary><c>true</c> after at least one <see cref="Save"/> call.</summary>
	public bool HasSnapshot => _hasSnapshot;

	/// <summary>Reads the snapshot wait-counter word for the channel.</summary>
	public ushort GetWaitCounter(int channelIndex) {
		Validate(channelIndex);
		return _waitCounters[channelIndex];
	}

	/// <summary>Reads the snapshot event-pointer word for the channel.</summary>
	public ushort GetEventPointer(int channelIndex) {
		Validate(channelIndex);
		return _eventPointers[channelIndex];
	}

	/// <summary>
	/// Captures the live <paramref name="waitCounters"/> /
	/// <paramref name="eventPointers"/> tables. Mirrors the source
	/// half of the rep-movs at dnadg:07F6.
	/// </summary>
	public void Save(AdgChannelWaitCounters waitCounters, AdgChannelEventPointers eventPointers) {
		ArgumentNullException.ThrowIfNull(waitCounters);
		ArgumentNullException.ThrowIfNull(eventPointers);
		for (int channelIndex = 0; channelIndex < ChannelCount; channelIndex++) {
			_waitCounters[channelIndex] = waitCounters.Get(channelIndex);
			_eventPointers[channelIndex] = eventPointers.Get(channelIndex);
		}
		_hasSnapshot = true;
	}

	/// <summary>
	/// Writes the saved snapshot back into
	/// <paramref name="waitCounters"/> /
	/// <paramref name="eventPointers"/>. Mirrors the destination
	/// half of the rep-movs at dnadg:0815.
	/// </summary>
	public void Restore(AdgChannelWaitCounters waitCounters, AdgChannelEventPointers eventPointers) {
		ArgumentNullException.ThrowIfNull(waitCounters);
		ArgumentNullException.ThrowIfNull(eventPointers);
		for (int channelIndex = 0; channelIndex < ChannelCount; channelIndex++) {
			waitCounters.Set(channelIndex, _waitCounters[channelIndex]);
			eventPointers.Set(channelIndex, _eventPointers[channelIndex]);
		}
	}

	/// <summary>Clears the snapshot and the stored words.</summary>
	public void Reset() {
		_hasSnapshot = false;
		for (int channelIndex = 0; channelIndex < ChannelCount; channelIndex++) {
			_waitCounters[channelIndex] = 0;
			_eventPointers[channelIndex] = 0;
		}
	}

	private static void Validate(int channelIndex) {
		if (channelIndex < 0 || channelIndex >= ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(channelIndex));
		}
	}
}