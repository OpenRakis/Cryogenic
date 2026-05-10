namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Channel-indexed adapter that resolves the per-channel routing
/// triplet via <see cref="AdgChannelRoutingTable.GetEntry"/> and then
/// delegates to <see cref="AdgInstrumentPatchEmitter.Emit"/>. This is
/// the public surface the scheduler uses to program one logical
/// channel with an instrument patch.
/// </summary>
public static class AdgChannelInstrumentEmitter {
	/// <summary>
	/// Looks up the routing triplet for <paramref name="channelIndex"/>
	/// in <paramref name="routingTable"/> and emits the full instrument
	/// patch on <paramref name="bus"/>.
	/// </summary>
	public static void Emit(IOplBus bus, AdgSurroundMaskState surroundState,
		byte[] patch, AdgChannelRoutingTable routingTable, int channelIndex) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(routingTable);
		// AdgChannelRoutingTable.GetEntry validates channelIndex.
		// AdgInstrumentPatchEmitter.Emit validates surroundState/patch.

		AdgChannelRoutingEntry entry = routingTable.GetEntry(channelIndex);

		AdgInstrumentPatchEmitter.Emit(bus, surroundState, patch,
			entry.ChannelRoute, entry.PrimaryRoute, entry.SecondaryRoute);
	}
}