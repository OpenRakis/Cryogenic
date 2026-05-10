namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot byte table holding the per-channel patch type
/// (<c>AdgChannelPatchTypeOffset</c>, DI+0x02D0). The original code
/// branches on <c>cmp byte ptr [DI+0x02D0],0x04</c> to enable the
/// four-operator (patch-4) shaping path; <see cref="IsFourOperator"/>
/// captures that test.
/// </summary>
public sealed class AdgChannelPatchTypeSlots {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	/// <summary>Patch type that triggers the four-operator path.</summary>
	public const byte FourOperatorMarker = 0x04;

	private readonly byte[] _slots = new byte[ChannelCount];

	/// <summary>Reads the patch type for <paramref name="channelIndex"/>.</summary>
	public byte Get(int channelIndex) {
		Validate(channelIndex);
		return _slots[channelIndex];
	}

	/// <summary>Writes the patch type for <paramref name="channelIndex"/>.</summary>
	public void Set(int channelIndex, byte value) {
		Validate(channelIndex);
		_slots[channelIndex] = value;
	}

	/// <summary>
	/// Returns <c>true</c> when the channel uses the four-operator
	/// patch (matches <c>cmp byte ptr [DI+0x02D0],0x04</c>).
	/// </summary>
	public bool IsFourOperator(int channelIndex) {
		Validate(channelIndex);
		return _slots[channelIndex] == FourOperatorMarker;
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