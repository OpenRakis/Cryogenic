namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot byte table holding the per-channel pitch-bend tick
/// counter. Mirrors the byte at
/// <c>AdgChannelPitchBendCounterOffset</c> (DI+0xB4) in the
/// original DNADG driver. <see cref="Decrement"/> matches the
/// <c>dec byte ptr [DI+0xB4] / jnz</c> sequence the pitch
/// modulator uses to gate its update.
/// </summary>
public sealed class AdgChannelPitchBendCounters {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	private readonly byte[] _counters = new byte[ChannelCount];

	/// <summary>Reads the counter for <paramref name="channelIndex"/>.</summary>
	public byte Get(int channelIndex) {
		Validate(channelIndex);
		return _counters[channelIndex];
	}

	/// <summary>Writes the counter for <paramref name="channelIndex"/>.</summary>
	public void Set(int channelIndex, byte value) {
		Validate(channelIndex);
		_counters[channelIndex] = value;
	}

	/// <summary>
	/// Decrements the counter and returns <c>true</c> when it has
	/// just reached zero (the original <c>jz</c> after
	/// <c>dec byte ptr [DI+0xB4]</c>).
	/// </summary>
	public bool Decrement(int channelIndex) {
		Validate(channelIndex);
		byte next = (byte)(_counters[channelIndex] - 1);
		_counters[channelIndex] = next;
		return next == 0;
	}

	/// <summary>Resets every channel slot to zero.</summary>
	public void Reset() {
		Array.Clear(_counters);
	}

	private static void Validate(int channelIndex) {
		if (channelIndex < 0 || channelIndex >= ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(channelIndex),
				channelIndex, "Channel index must be within [0,18).");
		}
	}
}