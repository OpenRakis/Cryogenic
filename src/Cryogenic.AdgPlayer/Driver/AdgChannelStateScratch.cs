namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot ushort table holding the per-channel "state scratch"
/// word (DI + 0x021C in the original DNADG driver). Used by
/// <see cref="AdgScratchMaskClearer"/> as the input that selects
/// which bits get cleared in <see cref="AdgFadeScratchState"/>.
/// </summary>
public sealed class AdgChannelStateScratch {
    /// <summary>Number of channel slots in the scratch table.</summary>
    public const int ChannelCount = 18;

    private readonly ushort[] _scratch = new ushort[ChannelCount];

    /// <summary>Reads the state-scratch word for <paramref name="channelIndex"/>.</summary>
    public ushort Get(int channelIndex) {
        Validate(channelIndex);
        return _scratch[channelIndex];
    }

    /// <summary>Writes the state-scratch word for <paramref name="channelIndex"/>.</summary>
    public void Set(int channelIndex, ushort value) {
        Validate(channelIndex);
        _scratch[channelIndex] = value;
    }

    /// <summary>Resets every slot to zero.</summary>
    public void Reset() {
        Array.Clear(_scratch);
    }

    private static void Validate(int channelIndex) {
        if (channelIndex < 0 || channelIndex >= ChannelCount) {
            throw new ArgumentOutOfRangeException(nameof(channelIndex),
                channelIndex, "Channel index must be within [0,18).");
        }
    }
}
