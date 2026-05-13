namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot 16-bit table holding the per-channel Patch4 (4-op)
/// current operator level word
/// (<c>AdgChannelPatch4CurrentOperatorLevelOffset</c>, DI+0x288).
/// Lo8 is the third-operator KSL/TL byte; Hi8 is the fourth-
/// operator KSL/TL byte. Updated by the 4-op branch of
/// <c>AdgVolumeModulation_0B2E</c>.
/// </summary>
public sealed class AdgChannelPatch4CurrentOperatorLevels {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	private readonly ushort[] _slots = new ushort[ChannelCount];

	/// <summary>Reads the Patch4 operator-level word for <paramref name="channelIndex"/>.</summary>
	public ushort Get(int channelIndex) {
		Validate(channelIndex);
		return _slots[channelIndex];
	}

	/// <summary>Writes the Patch4 operator-level word for <paramref name="channelIndex"/>.</summary>
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