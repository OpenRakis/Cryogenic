namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot byte table holding the per-channel pitch-bend mode flags.
/// Mirrors the byte at <c>AdgChannelPitchModeOffset</c> (DI+0x90)
/// in the original DNADG driver. Used by
/// <c>AdgPitchBend_0D86</c> / <c>AdgAdvancePitchModulation_07AD</c>
/// to gate the pitch modulation routine for each channel.
/// </summary>
public sealed class AdgChannelPitchModeSlots {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	private readonly byte[] _slots = new byte[ChannelCount];

	/// <summary>Reads the pitch-mode byte for <paramref name="channelIndex"/>.</summary>
	public byte Get(int channelIndex) {
		Validate(channelIndex);
		return _slots[channelIndex];
	}

	/// <summary>Writes the pitch-mode byte for <paramref name="channelIndex"/>.</summary>
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