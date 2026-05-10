namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Result of a channel-route translation: which OPL3 chip to address and
/// which register index after route-offset application.
/// </summary>
public readonly record struct AdgRoutedRegister(int Chip, byte Register);

/// <summary>
/// Pure transformation that maps (OPL register base, channel route byte) to
/// the chip+register pair for an OPL3 write. Extracted from
/// <c>AdgWriteRoutedOplRegister</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
/// <remarks>
/// Routing rule observed live:
/// <code>
/// route = ChannelRoutingTable[channelIndex]
/// if (sbyte)route &lt; 0:
///     register = (base + route) XOR 0x80   ; chip = secondary (1)
/// else:
///     register = base + route              ; chip = primary  (0)
/// </code>
/// All arithmetic is byte-modular (mod 256).
/// </remarks>
public static class AdgChannelRouter {
	private const byte SecondaryRouteBit = 0x80;

	/// <summary>Routes <paramref name="registerBase"/> by <paramref name="route"/>.</summary>
	public static AdgRoutedRegister Route(byte registerBase, byte route) {
		byte sum = (byte)(registerBase + route);
		bool secondary = (route & SecondaryRouteBit) != 0;
		if (secondary) {
			byte register = (byte)(sum ^ SecondaryRouteBit);
			return new AdgRoutedRegister(1, register);
		}
		return new AdgRoutedRegister(0, sum);
	}
}