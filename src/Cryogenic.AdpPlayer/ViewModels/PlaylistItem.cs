namespace Cryogenic.AdpPlayer.ViewModels;

using System.IO;

/// <summary>
/// Represents one playlist entry in the ADP player.
/// </summary>
public sealed class PlaylistItem {
    public required string Path { get; init; }

    public string FileName => System.IO.Path.GetFileName(Path);

    public string Display => FileName;
}
