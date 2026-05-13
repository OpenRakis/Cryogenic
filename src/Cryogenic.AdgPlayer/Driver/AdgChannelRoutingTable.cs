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
/// Mutable wrapper over the four 18-byte per-channel route tables
/// maintained by <c>AdgConfigureInstrumentRouting_090D</c> in the
/// original DNADG driver. Each <c>ProgramChange</c> repopulates one
/// channel slot via <see cref="SetEntry"/>; downstream emitters
/// consume the table via <see cref="GetEntry"/> /
/// <see cref="GetRouteShadow"/>.
/// </summary>
public sealed class AdgChannelRoutingTable {
	/// <summary>Number of logical channels.</summary>
	public const int ChannelCount = 18;

	private readonly byte[] _channelRoutes;
	private readonly byte[] _primaryRoutes;
	private readonly byte[] _secondaryRoutes;
	private readonly byte[] _routeShadows;

	/// <summary>Builds a table with every slot zero-initialized.</summary>
	public AdgChannelRoutingTable() {
		_channelRoutes = new byte[ChannelCount];
		_primaryRoutes = new byte[ChannelCount];
		_secondaryRoutes = new byte[ChannelCount];
		_routeShadows = new byte[ChannelCount];
	}

	/// <summary>
	/// Builds the table from three 18-byte arrays (channel/primary/
	/// secondary); the route-shadow table is initialized to zero.
	/// Retained for tests that pre-seed hand-built triplets.
	/// </summary>
	public AdgChannelRoutingTable(byte[] channelRoutes, byte[] primaryRoutes,
		byte[] secondaryRoutes)
		: this(channelRoutes, primaryRoutes, secondaryRoutes, new byte[ChannelCount]) {
	}

	/// <summary>Builds the table from four 18-byte arrays.</summary>
	public AdgChannelRoutingTable(byte[] channelRoutes, byte[] primaryRoutes,
		byte[] secondaryRoutes, byte[] routeShadows) {
		ArgumentNullException.ThrowIfNull(channelRoutes);
		ArgumentNullException.ThrowIfNull(primaryRoutes);
		ArgumentNullException.ThrowIfNull(secondaryRoutes);
		ArgumentNullException.ThrowIfNull(routeShadows);
		EnsureExactLength(channelRoutes, nameof(channelRoutes));
		EnsureExactLength(primaryRoutes, nameof(primaryRoutes));
		EnsureExactLength(secondaryRoutes, nameof(secondaryRoutes));
		EnsureExactLength(routeShadows, nameof(routeShadows));

		_channelRoutes = (byte[])channelRoutes.Clone();
		_primaryRoutes = (byte[])primaryRoutes.Clone();
		_secondaryRoutes = (byte[])secondaryRoutes.Clone();
		_routeShadows = (byte[])routeShadows.Clone();
	}

	/// <summary>Returns the routing triplet for the channel.</summary>
	public AdgChannelRoutingEntry GetEntry(int channelIndex) {
		ValidateChannelIndex(channelIndex);
		return new AdgChannelRoutingEntry(
			_channelRoutes[channelIndex],
			_primaryRoutes[channelIndex],
			_secondaryRoutes[channelIndex]);
	}

	/// <summary>Returns the route-shadow byte (driver 0x0191) for the channel.</summary>
	public byte GetRouteShadow(int channelIndex) {
		ValidateChannelIndex(channelIndex);
		return _routeShadows[channelIndex];
	}

	/// <summary>Writes the four routing bytes for the channel.</summary>
	public void SetEntry(int channelIndex, byte channelRoute, byte primaryRoute,
		byte secondaryRoute, byte routeShadow) {
		ValidateChannelIndex(channelIndex);
		_channelRoutes[channelIndex] = channelRoute;
		_primaryRoutes[channelIndex] = primaryRoute;
		_secondaryRoutes[channelIndex] = secondaryRoute;
		_routeShadows[channelIndex] = routeShadow;
	}

	private static void EnsureExactLength(byte[] table, string name) {
		if (table.Length != ChannelCount) {
			throw new ArgumentException(
				$"Routing table must contain exactly {ChannelCount} entries.", name);
		}
	}

	private static void ValidateChannelIndex(int channelIndex) {
		if (channelIndex < 0 || channelIndex >= ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(channelIndex));
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