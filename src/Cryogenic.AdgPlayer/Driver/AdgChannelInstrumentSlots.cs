namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot byte table holding the current instrument number for
/// each channel. Mirrors the per-channel byte at
/// <c>AdgChannelInstrumentOffset</c> (DI+0x6C, base 0x024E) in the
/// original DNADG driver. Updated by <c>AdgProgramChange_0831</c>
/// and consulted on note-on.
/// </summary>
public sealed class AdgChannelInstrumentSlots {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	private readonly byte[] _slots = new byte[ChannelCount];

	/// <summary>Reads the instrument byte for <paramref name="channelIndex"/>.</summary>
	public byte Get(int channelIndex) {
		Validate(channelIndex);
		return _slots[channelIndex];
	}

	/// <summary>Writes the instrument byte for <paramref name="channelIndex"/>.</summary>
	public void Set(int channelIndex, byte value) {
		Validate(channelIndex);
		_slots[channelIndex] = value;
	}

	/// <summary>Resets every channel slot to zero.</summary>
	public void Reset() {
		Array.Clear(_slots);
	}

	private static void Validate(int channelIndex) {
		if (channelIndex < 0 || channelIndex >= ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(channelIndex),
				channelIndex, "Channel index must be within [0,18).");
		}
	}
}