namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot ushort table holding the per-channel total-level shaping
/// word (<c>AdgChannelTlShapingOffset</c> at dnadg:00FC). The low
/// byte drives the primary operator velocity scaling, the high byte
/// the secondary operator — both consumed by
/// <c>AdgEnvelopeSetup_0C47</c>.
/// </summary>
public sealed class AdgChannelTlShapingSlots {
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
