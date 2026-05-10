namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot byte table holding the per-channel pitch accumulator.
/// Mirrors the byte at <c>AdgChannelPitchAccumulatorOffset</c>
/// (DI+0xD8) in the original DNADG driver. The accumulator is
/// re-centered to <see cref="CenterValue"/> (0x40) on every note-on
/// (dnadg:0AAB) and walked by the pitch modulation routine.
/// </summary>
public sealed class AdgChannelPitchAccumulators {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	/// <summary>Re-center value applied on note-on (0x40).</summary>
	public const byte CenterValue = 0x40;

	private readonly byte[] _slots = new byte[ChannelCount];

	/// <summary>Reads the accumulator for <paramref name="channelIndex"/>.</summary>
	public byte Get(int channelIndex) {
		Validate(channelIndex);
		return _slots[channelIndex];
	}

	/// <summary>Writes the accumulator for <paramref name="channelIndex"/>.</summary>
	public void Set(int channelIndex, byte value) {
		Validate(channelIndex);
		_slots[channelIndex] = value;
	}

	/// <summary>
	/// Resets the supplied slot to <see cref="CenterValue"/>. Mirrors
	/// the <c>mov byte ptr [DI+0xD8],0x40</c> on note-on.
	/// </summary>
	public void Center(int channelIndex) {
		Validate(channelIndex);
		_slots[channelIndex] = CenterValue;
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