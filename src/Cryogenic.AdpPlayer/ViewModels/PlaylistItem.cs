namespace Cryogenic.AdpPlayer.ViewModels;

using System.IO;

/// <summary>
/// Represents one playlist entry in the ADP player.
/// </summary>
public sealed class PlaylistItem {
    public required string Path { get; init; }

    public string FileName => System.IO.Path.GetFileName(Path);

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
