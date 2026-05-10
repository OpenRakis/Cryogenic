namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Channel-indexed adapter that resolves the per-channel route via
/// <see cref="AdgChannelRoutingTable"/> and forwards the note-off emit
/// to <see cref="AdgNoteOffEmitter"/>, reading the cached A0/B0 word
/// from <see cref="AdgFrequencyWordCache"/>.
/// </summary>
public static class AdgChannelNoteOffEmitter {
	/// <summary>
	/// Emits a note-off for <paramref name="channelIndex"/> by
	/// re-writing the cached frequency word with the key-on bit
	/// already cleared.
	/// </summary>
	public static void Emit(IOplBus bus, AdgFrequencyWordCache frequencyWordCache,
		AdgChannelRoutingTable routingTable, int channelIndex) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(frequencyWordCache);
		ArgumentNullException.ThrowIfNull(routingTable);

		AdgNoteOffEmitter.Emit(bus,
			routingTable.ChannelRoutesAsArray(),
			frequencyWordCache.AsArray(),
			channelIndex);
	}
}