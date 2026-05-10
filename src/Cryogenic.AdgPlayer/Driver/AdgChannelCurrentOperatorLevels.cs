namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot 16-bit table holding the per-channel current operator
/// level word (<c>AdgChannelCurrentOperatorLevelOffset</c>,
/// DI+0xF0). Lo8 is the primary operator key-scale-and-output byte
/// (KSL bits 6-7 + TL bits 0-5); Hi8 is the secondary operator
/// equivalent. Updated by <c>AdgVolumeModulation_0B2E</c> and
/// <c>AdgEnvelopeSetup_0C47</c>.
/// </summary>
public sealed class AdgChannelCurrentOperatorLevels {
    /// <summary>Number of channel slots in the table.</summary>
    public const int ChannelCount = 18;

    private readonly ushort[] _slots = new ushort[ChannelCount];

    /// <summary>Reads the operator-level word for <paramref name="channelIndex"/>.</summary>
    public ushort Get(int channelIndex) {
        Validate(channelIndex);
        return _slots[channelIndex];
    }

    /// <summary>Writes the operator-level word for <paramref name="channelIndex"/>.</summary>
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
