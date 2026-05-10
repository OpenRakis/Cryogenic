namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Emits the global note-off reset sequence for the 18 logical ADG channels.
/// Faithful port of <c>AdgResetInternal_0EBA</c> +
/// <c>AdgOplNoteOff_ResetHelper</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public static class AdgChannelResetEmitter {
	/// <summary>Number of logical ADG channels (0x12).</summary>
	public const int ChannelCount = 18;

	private const byte FrequencyLowRegisterBase = 0xA0;
	private const byte FrequencyHighRegisterBase = 0xB0;

	/// <summary>
	/// Writes the cached A0/B0 frequency-word pair for every channel in
	/// descending channel-index order (17 → 0), matching the original
	/// <c>for CX=0x12; CX!=0; CX--</c> loop.
	/// </summary>
	public static void EmitGlobalNoteOff(IOplBus bus, byte[] routingTable, ushort[] frequencyWords) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(routingTable);
		ArgumentNullException.ThrowIfNull(frequencyWords);
		if (routingTable.Length != ChannelCount) {
			throw new ArgumentException(
				$"Routing table must have exactly {ChannelCount} entries.", nameof(routingTable));
		}
		if (frequencyWords.Length != ChannelCount) {
			throw new ArgumentException(
				$"Frequency word table must have exactly {ChannelCount} entries.", nameof(frequencyWords));
		}

		for (int channelIndex = ChannelCount - 1; channelIndex >= 0; channelIndex--) {
			byte route = routingTable[channelIndex];
			ushort frequency = frequencyWords[channelIndex];

			AdgRoutedRegister low = AdgChannelRouter.Route(FrequencyLowRegisterBase, route);
			bus.WriteRegister(low.Chip, low.Register, (byte)(frequency & 0xFF));

			AdgRoutedRegister high = AdgChannelRouter.Route(FrequencyHighRegisterBase, route);
			bus.WriteRegister(high.Chip, high.Register, (byte)(frequency >> 8));
		}
	}
}