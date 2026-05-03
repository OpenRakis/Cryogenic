namespace Cryogenic.AdgPlayer.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

using System.IO;

/// <summary>
/// Represents one playlist entry in the ADG player.
/// Inherits from <see cref="ObservableObject"/> so that computed properties
/// (<see cref="CurrentTrackIcon"/>, <see cref="CurrentTrackTextColor"/>, <see cref="CurrentTrackIconColor"/>)
/// update the UI bindings whenever <see cref="IsCurrentTrack"/> changes.
/// </summary>
public sealed partial class PlaylistItem : ObservableObject {
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

    private bool _isCurrentTrack;

    /// <summary>
    /// Set to true when this is the currently playing track.
    /// Setter notifies bindings for computed display properties.
    /// </summary>
    public bool IsCurrentTrack {
        get => _isCurrentTrack;
        set {
            if (SetProperty(ref _isCurrentTrack, value)) {
                OnPropertyChanged(nameof(CurrentTrackIcon));
                OnPropertyChanged(nameof(CurrentTrackTextColor));
                OnPropertyChanged(nameof(CurrentTrackIconColor));
            }
        }
    }

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
