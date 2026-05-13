namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot byte table holding the per-channel pitch-bend counter
/// reload value. Mirrors the byte at
/// <c>AdgChannelPitchBendCounterOffset + 1</c> in the original
/// DNADG driver; on every note-on the live
/// <see cref="AdgChannelPitchBendCounters"/> entry is reloaded
/// from this slot:
/// <code>
/// mov AL,[DI+pitchBendCounter+1]
/// mov [DI+pitchBendCounter],AL
/// </code>
/// (oracle <c>AdgNoteOn_0A82</c> at dnadg:0AA0).
/// </summary>
public sealed class AdgChannelPitchBendCounterReloads {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	private readonly byte[] _slots = new byte[ChannelCount];

	/// <summary>Reads the reload byte for <paramref name="channelIndex"/>.</summary>
	public byte Get(int channelIndex) {
		Validate(channelIndex);
		return _slots[channelIndex];
	}

	/// <summary>Writes the reload byte for <paramref name="channelIndex"/>.</summary>
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