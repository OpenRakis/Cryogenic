namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot ushort table holding the per-channel wait counter words
/// the scheduler decrements on each tick. Mirrors the word array at
/// <c>AdgChannelTableBase</c> (0x01E2..0x0205) in the original
/// DNADG driver. Each <c>AdgSchedulerTick_0756</c> iteration
/// decrements one slot (<c>sub word ptr [DI],1</c>); when the slot
/// reaches zero the channel pulls fresh events from the event
/// stream.
/// </summary>
public sealed class AdgChannelWaitCounters {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	private readonly ushort[] _counters = new ushort[ChannelCount];

	/// <summary>Reads the wait counter for <paramref name="channelIndex"/>.</summary>
	public ushort Get(int channelIndex) {
		Validate(channelIndex);
		return _counters[channelIndex];
	}

	/// <summary>Writes the wait counter for <paramref name="channelIndex"/>.</summary>
	public void Set(int channelIndex, ushort value) {
		Validate(channelIndex);
		_counters[channelIndex] = value;
	}

	/// <summary>
	/// Decrements the wait counter and returns <c>true</c> when it
	/// has just reached zero (the original <c>jz</c> after the
	/// <c>sub word ptr [DI],1</c> at dnadg:0762).
	/// </summary>
	public bool Decrement(int channelIndex) {
		Validate(channelIndex);
		ushort next = (ushort)(_counters[channelIndex] - 1);
		_counters[channelIndex] = next;
		return next == 0;
	}

	/// <summary>Resets every channel counter to zero.</summary>
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