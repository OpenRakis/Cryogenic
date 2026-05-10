namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Per-channel routing triplet consumed by
/// <see cref="AdgInstrumentPatchEmitter"/>.
/// </summary>
/// <param name="ChannelRoute">
/// Route byte fed to the connection register write
/// (corresponds to <c>AdgChannelRoutingTableOffset</c> in the original
/// driver).
/// </param>
/// <param name="PrimaryRoute">
/// Route byte fed to the primary operator emit
/// (<c>AdgChannelPrimaryOperatorRouteOffset</c>).
/// </param>
/// <param name="SecondaryRoute">
/// Route byte fed to the secondary operator emit and the
/// surround-mask update
/// (<c>AdgChannelSecondaryOperatorRouteOffset</c>).
/// </param>
public readonly record struct AdgChannelRoutingEntry(
	byte ChannelRoute, byte PrimaryRoute, byte SecondaryRoute);

/// <summary>
/// Read-only wrapper over the three 18-byte per-channel route tables
/// loaded from the AdLib Gold driver segment. Defensively copies its
/// inputs so external mutations do not leak into the player.
/// </summary>
public sealed class AdgChannelRoutingTable {
	/// <summary>Number of logical channels (matches
	/// <c>AdgChannelResetEmitter.ChannelCount</c>).</summary>
	public const int ChannelCount = 18;

	private readonly byte[] _channelRoutes;
	private readonly byte[] _primaryRoutes;
	private readonly byte[] _secondaryRoutes;

	/// <summary>
	/// Builds the table from three 18-byte arrays. Each array is
	/// indexed by logical channel (0..17) and copied into the table.
	/// </summary>
	public AdgChannelRoutingTable(byte[] channelRoutes, byte[] primaryRoutes,
		byte[] secondaryRoutes) {
		ArgumentNullException.ThrowIfNull(channelRoutes);
		ArgumentNullException.ThrowIfNull(primaryRoutes);
		ArgumentNullException.ThrowIfNull(secondaryRoutes);
		EnsureExactLength(channelRoutes, nameof(channelRoutes));
		EnsureExactLength(primaryRoutes, nameof(primaryRoutes));
		EnsureExactLength(secondaryRoutes, nameof(secondaryRoutes));

		_channelRoutes = (byte[])channelRoutes.Clone();
		_primaryRoutes = (byte[])primaryRoutes.Clone();
		_secondaryRoutes = (byte[])secondaryRoutes.Clone();
	}

	/// <summary>
	/// Returns the routing triplet for <paramref name="channelIndex"/>.
	/// </summary>
	public AdgChannelRoutingEntry GetEntry(int channelIndex) {
		if (channelIndex < 0 || channelIndex >= ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(channelIndex));
		}

		return new AdgChannelRoutingEntry(
			_channelRoutes[channelIndex],
			_primaryRoutes[channelIndex],
			_secondaryRoutes[channelIndex]);
	}

	private static void EnsureExactLength(byte[] table, string name) {
		if (table.Length != ChannelCount) {
			throw new ArgumentException(
				$"Routing table must contain exactly {ChannelCount} entries.", name);
		}
	}

	/// <summary>
	/// Returns the underlying 18-entry channel-route array for internal
	/// callers that must pass a raw <see cref="byte"/> array to legacy
	/// emitters (for example <see cref="AdgNoteOnEmitter.Emit"/>).
	/// </summary>
	internal byte[] ChannelRoutesAsArray() {
		return _channelRoutes;
	}
}