namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot ushort table holding the per-channel TL-shaping word for
/// the secondary (Patch4) operator pair
/// (<c>AdgChannelPatch4TlShapingOffset</c> at dnadg:0240). Mirrors
/// <see cref="AdgChannelTlShapingSlots"/> but applies to the second
/// operator pair (operator slots +0x08 relative to the primary
/// route). Only populated when the patch is a 4-operator patch.
/// </summary>
public sealed class AdgChannelPatch4TlShapingSlots {
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
