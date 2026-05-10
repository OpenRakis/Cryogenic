namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Walks the per-channel event stream one 16-bit word at a time.
/// Mirrors the inner loop of <c>AdgSchedulerTick_0756</c>:
/// <code>
/// mov SI,[DI+0x24]
/// or SI,SI
/// je short skip
/// lods AX,ES:[SI]
/// add SI,2
/// mov [DI+0x24],SI
/// </code>
/// A <c>SI == 0</c> pointer signals end-of-stream for that channel
/// and yields <c>false</c> from <see cref="TryReadNext"/>.
/// </summary>
public sealed class AdgChannelEventReader {
	private readonly AdgChannelEventPointers _pointers;
	private readonly IAdgEventStream _stream;
	private readonly ushort _eventSegment;

	/// <summary>
	/// Builds a reader bound to the supplied pointer table, backing
	/// stream and event-segment selector. The event segment is
	/// captured once because the driver loads it from
	/// <c>AdgEventSegmentOffset</c> once per song open.
	/// </summary>
	public AdgChannelEventReader(AdgChannelEventPointers pointers, IAdgEventStream stream, ushort eventSegment) {
		ArgumentNullException.ThrowIfNull(pointers);
		ArgumentNullException.ThrowIfNull(stream);
		_pointers = pointers;
		_stream = stream;
		_eventSegment = eventSegment;
	}

	/// <summary>Event segment selector currently bound to the reader.</summary>
	public ushort EventSegment => _eventSegment;

	/// <summary>
	/// Attempts to read the next event word for
	/// <paramref name="channelIndex"/>. Returns <c>true</c> with the
	/// consumed word in <paramref name="eventWord"/> when a non-zero
	/// pointer was present (and bumps the pointer by 2). Returns
	/// <c>false</c> when the channel pointer is zero
	/// (end-of-stream).
	/// </summary>
	public bool TryReadNext(int channelIndex, out ushort eventWord) {
		ushort pointer = _pointers.Get(channelIndex);
		if (pointer == 0) {
			eventWord = 0;
			return false;
		}
		eventWord = _stream.ReadWord(_eventSegment, pointer);
		_pointers.Set(channelIndex, (ushort)(pointer + 2));
		return true;
	}
}