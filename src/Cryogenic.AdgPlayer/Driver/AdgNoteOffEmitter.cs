namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Emits a note-off event for one logical ADG channel by re-writing the
/// cached A0/B0 frequency word (which has the key-on bit cleared).
/// Faithful port of <c>AdgNoteOff_10D8</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public static class AdgNoteOffEmitter {
	private const int ChannelCount = AdgChannelResetEmitter.ChannelCount;
	private const byte FrequencyLowRegisterBase = 0xA0;
	private const byte FrequencyHighRegisterBase = 0xB0;

	/// <summary>
	/// Writes the cached A0/B0 pair for <paramref name="channelIndex"/>
	/// onto <paramref name="bus"/>, routed via
	/// <paramref name="routingTable"/>.
	/// </summary>
	public static void Emit(
		IOplBus bus,
		byte[] routingTable,
		ushort[] frequencyWordCache,
		int channelIndex) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(routingTable);
		ArgumentNullException.ThrowIfNull(frequencyWordCache);
		if (routingTable.Length != ChannelCount) {
			throw new ArgumentException(
				$"Routing table must have exactly {ChannelCount} entries.",
				nameof(routingTable));
		}
		if (frequencyWordCache.Length != ChannelCount) {
			throw new ArgumentException(
				$"Frequency word cache must have exactly {ChannelCount} entries.",
				nameof(frequencyWordCache));
		}
		if ((uint)channelIndex >= ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(channelIndex));
		}

		ushort cached = frequencyWordCache[channelIndex];
		byte route = routingTable[channelIndex];

		AdgRoutedRegister low = AdgChannelRouter.Route(FrequencyLowRegisterBase, route);
		bus.WriteRegister(low.Chip, low.Register, (byte)(cached & 0xFF));

		AdgRoutedRegister high = AdgChannelRouter.Route(FrequencyHighRegisterBase, route);
		bus.WriteRegister(high.Chip, high.Register, (byte)(cached >> 8));
	}
}