namespace Cryogenic.AdgPlayer.Ui.ViewModels;

using System.IO;

/// <summary>
/// Represents one playlist entry in the ADP player.
/// </summary>
public sealed class PlaylistItem {
	public required string Path { get; init; }

	/// <summary>
	/// Optional in-memory payload (HSQ/AGD/M32 bytes lifted out of DUNE.DAT
	/// without ever touching the filesystem). When non-null the player must
	/// feed these bytes to the engine instead of reading from <see cref="Path"/>.
	/// </summary>
	public byte[]? Bytes { get; init; }

	/// <summary>
	/// Optional display name (e.g. the original archive entry name).
	/// Falls back to the filename component of <see cref="Path"/>.
	/// </summary>
	public string? SourceName { get; init; }

	public string FileName => SourceName ?? System.IO.Path.GetFileName(Path);

	/// <summary>
	/// Display name including track number.
	/// </summary>
	public string Display { get; set; } = "";

	/// <summary>
	/// Tooltip text with detailed header information.
	/// </summary>
	public string Tooltip { get; set; } = "Hover to load info";

	/// <summary>
	/// Set to true when this is the currently playing track.
	/// </summary>
	public bool IsCurrentTrack { get; set; }

	/// <summary>
	/// Icon displayed for the currently playing track.
	/// </summary>
	public string CurrentTrackIcon => IsCurrentTrack ? "▶" : " ";

	/// <summary>
	/// Text color for the currently playing track.
	/// </summary>
	public string CurrentTrackTextColor => IsCurrentTrack ? "#58A6FF" : "#79C0FF";

	/// <summary>
	/// Icon color for the currently playing track.
	/// </summary>
	public string CurrentTrackIconColor => IsCurrentTrack ? "#58A6FF" : "#484F58";
}