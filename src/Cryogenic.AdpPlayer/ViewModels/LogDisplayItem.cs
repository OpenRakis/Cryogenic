namespace Cryogenic.AdpPlayer.ViewModels;

/// <summary>
/// Display item for the log panel.
/// </summary>
public sealed class LogDisplayItem {
	/// <summary>Timestamp string (HH:mm:ss).</summary>
	public string Timestamp { get; set; } = "";

	/// <summary>Log message text.</summary>
	public string Message { get; set; } = "";
}