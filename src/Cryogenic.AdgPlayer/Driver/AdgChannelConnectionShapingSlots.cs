namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot ushort table holding the per-channel connection-shaping
/// word (<c>AdgChannelConnectionShapingOffset</c> at dnadg:0168).
/// Composed from patch bytes 0x04 / ~0x0E (rotated and shifted) plus
/// patch byte 0x20 in the high byte. Consumed by
/// <c>AdgEnvelopeSetup_0C47</c> to compute the connection register
/// envelope contribution.
/// </summary>
public sealed class AdgChannelConnectionShapingSlots {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	private readonly ushort[] _slots = new ushort[ChannelCount];

	/// <summary>Reads the shaping word for <paramref name="channelIndex"/>.</summary>
	public ushort Get(int channelIndex) {
		Validate(channelIndex);
		return _slots[channelIndex];
	}

	/// <summary>Writes the shaping word for <paramref name="channelIndex"/>.</summary>
	public void Set(int channelIndex, ushort value) {
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