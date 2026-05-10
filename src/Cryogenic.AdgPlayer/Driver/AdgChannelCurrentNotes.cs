namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot byte table holding the active note number for each
/// channel. Mirrors the per-channel byte at
/// <c>AdgChannelCurrentNoteOffset</c> (DI+0x6D, base 0x024F) in the
/// original DNADG driver. Updated by <c>AdgNoteOn_0A82</c>, cleared
/// by <c>AdgNoteOff_0AB6</c> when the released note matches.
/// </summary>
public sealed class AdgChannelCurrentNotes {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	private readonly byte[] _notes = new byte[ChannelCount];

	/// <summary>Reads the active note for <paramref name="channelIndex"/>.</summary>
	public byte Get(int channelIndex) {
		Validate(channelIndex);
		return _notes[channelIndex];
	}

	/// <summary>Writes the active note for <paramref name="channelIndex"/>.</summary>
	public void Set(int channelIndex, byte value) {
		Validate(channelIndex);
		_notes[channelIndex] = value;
	}

	/// <summary>
	/// Clears the active note for the supplied channel without
	/// touching siblings. Mirrors <c>mov byte ptr [DI+0x6D],0</c>
	/// after a note-off match at dnadg:0AC8.
	/// </summary>
	public void Clear(int channelIndex) {
		Validate(channelIndex);
		_notes[channelIndex] = 0;
	}

	/// <summary>Resets every channel slot to zero.</summary>
	public void Reset() {
		Array.Clear(_notes);
	}

	private static void Validate(int channelIndex) {
		if (channelIndex < 0 || channelIndex >= ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(channelIndex),
				channelIndex, "Channel index must be within [0,18).");
		}
	}
}