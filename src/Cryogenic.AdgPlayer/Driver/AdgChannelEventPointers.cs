namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot ushort table holding the per-channel event-stream cursor
/// (offset within the event segment). Mirrors the parallel word
/// array at <c>AdgChannelTableBase + 0x24</c> (0x0206..0x0229) in
/// the original DNADG driver. The scheduler reads the next event
/// word at <c>ES:[SI]</c> and bumps the slot by 2 (<c>add SI,2</c>
/// at dnadg:0772) before storing it back into the slot.
/// </summary>
public sealed class AdgChannelEventPointers {
	/// <summary>Number of channel slots in the pointer table.</summary>
	public const int ChannelCount = 18;

	private readonly ushort[] _pointers = new ushort[ChannelCount];

	/// <summary>Reads the event pointer for <paramref name="channelIndex"/>.</summary>
	public ushort Get(int channelIndex) {
		Validate(channelIndex);
		return _pointers[channelIndex];
	}

	/// <summary>Writes the event pointer for <paramref name="channelIndex"/>.</summary>
	public void Set(int channelIndex, ushort value) {
		Validate(channelIndex);
		_pointers[channelIndex] = value;
	}

	/// <summary>
	/// Adds 2 to the pointer (one consumed event word) with native
	/// 16-bit wrap-around and returns the new value.
	/// </summary>
	public ushort Advance(int channelIndex) {
		Validate(channelIndex);
		ushort next = (ushort)(_pointers[channelIndex] + 2);
		_pointers[channelIndex] = next;
		return next;
	}

	/// <summary>Resets every event pointer to zero.</summary>
	public void Reset() {
		Array.Clear(_pointers);
	}

	private static void Validate(int channelIndex) {
		if (channelIndex < 0 || channelIndex >= ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(channelIndex),
				channelIndex, "Channel index must be within [0,18).");
		}
	}
}