namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot byte table holding the per-channel note transpose
/// offset. Mirrors the byte at <c>AdgChannelPitchTransposeOffset</c>
/// (DI+0x91) in the original DNADG driver. Added to the raw event
/// note before note-on/off processing
/// (<c>add AL,[DI+0x91]</c> at dnadg:0A99 / dnadg:0ABE).
/// </summary>
public sealed class AdgChannelPitchTransposeSlots {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	private readonly byte[] _slots = new byte[ChannelCount];

	/// <summary>Reads the transpose byte for <paramref name="channelIndex"/>.</summary>
	public byte Get(int channelIndex) {
		Validate(channelIndex);
		return _slots[channelIndex];
	}

	/// <summary>Writes the transpose byte for <paramref name="channelIndex"/>.</summary>
	public void Set(int channelIndex, byte value) {
		Validate(channelIndex);
		_slots[channelIndex] = value;
	}

	/// <summary>
	/// Adds the channel transpose byte to <paramref name="note"/>
	/// with native 8-bit wrap. Mirrors the <c>add AL,[DI+0x91]</c>
	/// the driver performs on every note event.
	/// </summary>
	public byte ApplyTo(int channelIndex, byte note) {
		Validate(channelIndex);
		return (byte)(note + _slots[channelIndex]);
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