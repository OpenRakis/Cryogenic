namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Channel-indexed adapter that resolves the per-channel routing
/// triplet via <see cref="AdgChannelRoutingTable"/> and forwards the
/// note-on emit to <see cref="AdgNoteOnEmitter"/>, persisting the
/// updated cached frequency word in
/// <see cref="AdgFrequencyWordCache"/>.
/// </summary>
public static class AdgChannelNoteOnEmitter {
	/// <summary>
	/// Emits a note-on for <paramref name="channelIndex"/> using
	/// <paramref name="rawPitch"/>; updates
	/// <paramref name="frequencyWordCache"/> with the new cached A0/B0
	/// word.
	/// </summary>
	public static void Emit(IOplBus bus, AdgFrequencyWordCache frequencyWordCache,
		AdgChannelRoutingTable routingTable, AdgFrequencyLookupTable frequencyLookup,
		int channelIndex, ushort rawPitch) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(frequencyWordCache);
		ArgumentNullException.ThrowIfNull(routingTable);
		ArgumentNullException.ThrowIfNull(frequencyLookup);

		AdgNoteOnEmitter.Emit(bus,
			routingTable.ChannelRoutesAsArray(),
			frequencyWordCache.AsArray(),
			frequencyLookup.AsArray(),
			channelIndex, rawPitch);
	}
}