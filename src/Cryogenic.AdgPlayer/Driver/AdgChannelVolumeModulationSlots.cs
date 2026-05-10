namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot ushort table holding the per-channel volume-modulation
/// shape word (<c>AdgChannelVolumeModulationOffset</c>). The low byte
/// drives the primary operator shaping, the high byte the secondary
/// operator (see <c>AdgVolumeModulation_0B2E</c>).
/// </summary>
public sealed class AdgChannelVolumeModulationSlots {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	private readonly ushort[] _slots = new ushort[ChannelCount];

	/// <summary>Reads the shape word for <paramref name="channelIndex"/>.</summary>
	public ushort Get(int channelIndex) {
		Validate(channelIndex);
		return _slots[channelIndex];
	}

	/// <summary>Writes the shape word for <paramref name="channelIndex"/>.</summary>
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