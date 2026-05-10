namespace Cryogenic.AdgPlayer.Services;

/// <summary>
/// DNADG (AdLib Gold / OPL3) standalone player engine.
/// Authoritative source: src/Cryogenic/Overrides/AdgDriverCode.cs and DNADG.UNHSQ
/// (DUNE.DAT decompressed driver image, see doc/DUNECDVF/C/DUNECD/DUNE.DAT_).
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
	/// <summary>
	/// Number of logical channels managed by the DNADG driver. Maps to 18 OPL3 Gold
	/// physical channels through <c>AdgChannelRoutingTableOffset</c> (0x017F).
	/// </summary>
	public const int ChannelCountConst = 18;

	/// <summary>
	/// PIT reload value programmed by DNADG when installing the timer.
	/// 0x1745 ≈ 181 Hz tick rate.
	/// </summary>
	public const int PitReloadValueConst = 0x1745;

	/// <summary>Per-instance channel count (matches <see cref="ChannelCountConst"/>).</summary>
	public int ChannelCount => ChannelCountConst;

	/// <summary>True when a song is loaded and tick processing is active.</summary>
	public bool IsPlaying { get; private set; }

	/// <summary>True when a song image has been loaded into the engine.</summary>
	public bool HasSongLoaded { get; private set; }

	/// <summary>PIT reload value used by the driver tick scheduler.</summary>
	public int PitReloadValue => PitReloadValueConst;
}