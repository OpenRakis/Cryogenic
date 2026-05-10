namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Mutable holder of the four song-cursor words used by the DNADG
/// scheduler. Mirrors the four words at offsets 0x011E
/// (<c>AdgSongPointerOffset</c>), 0x0120 (<c>AdgSongSegmentOffset</c>),
/// 0x0122 (<c>AdgEventPointerOffset</c>) and 0x0124
/// (<c>AdgEventSegmentOffset</c>). The pointer words are 16-bit near
/// offsets within the song segment; the segment words are real-mode
/// segment selectors.
/// </summary>
public sealed class AdgSongPosition {
	private ushort _songPointer;
	private ushort _songSegment;
	private ushort _eventPointer;
	private ushort _eventSegment;

	/// <summary>Near offset of the next song-stream word.</summary>
	public ushort SongPointer => _songPointer;

	/// <summary>Real-mode segment of the song stream.</summary>
	public ushort SongSegment => _songSegment;

	/// <summary>Near offset of the next channel-event stream word.</summary>
	public ushort EventPointer => _eventPointer;

	/// <summary>Real-mode segment of the channel-event stream.</summary>
	public ushort EventSegment => _eventSegment;

	/// <summary>Replaces the song pointer word.</summary>
	public void SetSongPointer(ushort value) {
		_songPointer = value;
	}

	/// <summary>Replaces the song segment word.</summary>
	public void SetSongSegment(ushort value) {
		_songSegment = value;
	}

	/// <summary>Replaces the event pointer word.</summary>
	public void SetEventPointer(ushort value) {
		_eventPointer = value;
	}

	/// <summary>Replaces the event segment word.</summary>
	public void SetEventSegment(ushort value) {
		_eventSegment = value;
	}

	/// <summary>Restores every cursor word to zero.</summary>
	public void Reset() {
		_songPointer = 0;
		_songSegment = 0;
		_eventPointer = 0;
		_eventSegment = 0;
	}
}