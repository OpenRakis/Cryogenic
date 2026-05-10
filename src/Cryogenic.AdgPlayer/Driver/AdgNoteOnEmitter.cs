namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Emits a note-on event for one logical ADG channel. Faithful port of the
/// post-arithmetic tail of <c>AdgNoteOn_10A9</c> +
/// <c>AdgWriteFrequencyWord_10E0</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public static class AdgNoteOnEmitter {
	private const int ChannelCount = AdgChannelResetEmitter.ChannelCount;
	private const byte FrequencyLowRegisterBase = 0xA0;
	private const byte FrequencyHighRegisterBase = 0xB0;

	/// <summary>
	/// Computes the OPL frequency words for <paramref name="rawPitch"/>,
	/// updates <paramref name="frequencyWordCache"/> at
	/// <paramref name="channelIndex"/>, and writes the routed A0/B0 pair
	/// to <paramref name="bus"/> with the key-on bit set.
	/// </summary>
	public static void Emit(
		IOplBus bus,
		byte[] routingTable,
		ushort[] frequencyWordCache,
		ushort[] frequencyLookup,
		int channelIndex,
		ushort rawPitch) {
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

		AdgNoteOnFrequency note = AdgNoteOnComputer.Compute(rawPitch, frequencyLookup);
		frequencyWordCache[channelIndex] = note.CachedFrequencyWord;

		byte route = routingTable[channelIndex];
		AdgRoutedRegister low = AdgChannelRouter.Route(FrequencyLowRegisterBase, route);
		bus.WriteRegister(low.Chip, low.Register, (byte)(note.NoteOnFrequencyWord & 0xFF));

		AdgRoutedRegister high = AdgChannelRouter.Route(FrequencyHighRegisterBase, route);
		bus.WriteRegister(high.Chip, high.Register, (byte)(note.NoteOnFrequencyWord >> 8));
	}
}