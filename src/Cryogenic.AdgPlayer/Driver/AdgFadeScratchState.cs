namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pair of global "fade scratch" ushort cells from the original
/// DNADG driver: <c>AdgFadeScratchOffset</c> (0x013E) and
/// <c>AdgFadeScratch2Offset</c> (0x0140). They accumulate per-channel
/// scratch bits and are cleared bit-by-bit by
/// <see cref="AdgScratchMaskClearer"/> based on the high bit of the
/// inverted per-channel scratch word.
/// </summary>
public sealed class AdgFadeScratchState {
    /// <summary>Primary cell (driver address 0x013E).</summary>
    public ushort Primary { get; private set; }

    /// <summary>Secondary cell (driver address 0x0140).</summary>
    public ushort Secondary { get; private set; }

    /// <summary>Replaces <see cref="Primary"/>.</summary>
    public void SetPrimary(ushort value) {
        Primary = value;
    }

    /// <summary>Replaces <see cref="Secondary"/>.</summary>
    public void SetSecondary(ushort value) {
        Secondary = value;
    }

    /// <summary>Clears both cells.</summary>
    public void Reset() {
        Primary = 0;
        Secondary = 0;
    }
}
