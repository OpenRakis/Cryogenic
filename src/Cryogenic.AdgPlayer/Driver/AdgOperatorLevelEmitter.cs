namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Routed register write to the OPL3 Key-Scale-and-Output
/// (Total Level) register pair. Wraps the pattern
/// <code>
/// AdgWriteRouteSelectedRegister_1101(KeyScaleAndOutput, value, route);
/// </code>
/// used throughout the operator-level emit sites of the original
/// DNADG driver.
/// </summary>
public static class AdgOperatorLevelEmitter {
    /// <summary>
    /// OPL3 Key-Scale-and-Output (a.k.a. KSL/TL) register base
    /// (<c>0x40</c>). Operator routing offsets are added via
    /// <see cref="AdgChannelRouter"/>.
    /// </summary>
    public const byte KeyScaleAndOutputRegisterBase = 0x40;

    /// <summary>
    /// Routes <paramref name="operatorRoute"/> into a chip+register
    /// pair off the KSL/TL base and writes
    /// <paramref name="newLevel"/>.
    /// </summary>
    public static void Emit(IOplBus bus, byte operatorRoute, byte newLevel) {
        ArgumentNullException.ThrowIfNull(bus);
        AdgRoutedRegister routed = AdgChannelRouter.Route(
            KeyScaleAndOutputRegisterBase, operatorRoute);
        bus.WriteRegister(routed.Chip, routed.Register, newLevel);
    }
}
