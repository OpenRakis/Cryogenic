namespace Cryogenic.AdgPlayer.Ui.ViewModels;

/// <summary>
/// Display item for one row in the log panel ListBox.
/// Built from a Serilog rendered message and the timestamp it
/// reached the UI thread.
/// </summary>
public sealed class LogDisplayItem {
	/// <summary>Timestamp string formatted as <c>HH:mm:ss</c>.</summary>
	public string Timestamp { get; }

	/// <summary>Rendered log message text.</summary>
	public string Message { get; }

	/// <summary>Builds an immutable display row.</summary>
	public LogDisplayItem(string timestamp, string message) {
		Timestamp = timestamp;
		Message = message;
	}
}