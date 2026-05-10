namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure helper that inverts the wait-counter table walk back into a
/// 0..17 channel index. Mirrors the three instructions at
/// dnadg:077A which the dispatcher uses to compute the channel
/// number before invoking an event handler:
/// <code>
/// mov DX,DI
/// sub DX,0x01E2
/// shr DX,1
/// </code>
/// </summary>
public static class AdgChannelIndexResolver {
	/// <summary>Base address of the wait-counter word table.</summary>
	public const ushort WaitCounterTableBase = 0x01E2;

	/// <summary>
	/// Converts a wait-counter table pointer back into a channel
	/// index. Throws when the pointer is outside the 18-slot range
	/// or is not word-aligned.
	/// </summary>
	public static int FromWaitCounterPointer(ushort pointer) {
		if (pointer < WaitCounterTableBase) {
			throw new ArgumentOutOfRangeException(nameof(pointer),
				pointer, "Pointer is below the wait-counter table base.");
		}
		ushort delta = (ushort)(pointer - WaitCounterTableBase);
		if ((delta & 1) != 0) {
			throw new ArgumentException(
				"Pointer must be word-aligned within the table.",
				nameof(pointer));
		}
		int channelIndex = delta >> 1;
		if (channelIndex >= AdgChannelWaitCounters.ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(pointer),
				pointer, "Pointer is past the last channel slot.");
		}
		return channelIndex;
	}
}