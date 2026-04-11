namespace Cryogenic.Mt32DriverDebug.ViewModels;

using Avalonia.Media;

/// <summary>
/// Display item for the log panel in the MT-32 driver debug window.
/// Timestamps and messages are displayed with distinct colors; errors and hex content get special highlighting.
/// </summary>
public sealed class DriverLogDisplayItem {
	private static readonly IBrush TimeBrush = new SolidColorBrush(Color.FromRgb(0x3D, 0x8B, 0xFD));
	private static readonly IBrush NormalBrush = new SolidColorBrush(Color.FromRgb(0xC9, 0xD1, 0xD9));
	private static readonly IBrush ErrorBrush = new SolidColorBrush(Color.FromRgb(0xF8, 0x51, 0x49));
	private static readonly IBrush WarningBrush = new SolidColorBrush(Color.FromRgb(0xD2, 0x99, 0x22));
	private static readonly IBrush SuccessBrush = new SolidColorBrush(Color.FromRgb(0x3F, 0xB9, 0x50));
	private static readonly IBrush HexBrush = new SolidColorBrush(Color.FromRgb(0x79, 0xC0, 0xFF));

	/// <summary>Formatted timestamp string.</summary>
	public required string Timestamp { get; init; }

	/// <summary>Log message text.</summary>
	public required string Message { get; init; }

	/// <summary>Color brush for the timestamp column.</summary>
	public static IBrush TimestampBrush => TimeBrush;

	/// <summary>Color brush for the message column, determined by content keywords.</summary>
	public IBrush MessageBrush {
		get {
			if (Message.Contains("fail", StringComparison.OrdinalIgnoreCase) ||
				Message.Contains("error", StringComparison.OrdinalIgnoreCase)) {
				return ErrorBrush;
			}
			if (Message.Contains("warning", StringComparison.OrdinalIgnoreCase)) {
				return WarningBrush;
			}
			if (Message.Contains("init", StringComparison.OrdinalIgnoreCase) ||
				Message.Contains("loaded", StringComparison.OrdinalIgnoreCase) ||
				Message.Contains("attached", StringComparison.OrdinalIgnoreCase)) {
				return SuccessBrush;
			}
			if (Message.Contains("0x", StringComparison.OrdinalIgnoreCase)) {
				return HexBrush;
			}
			return NormalBrush;
		}
	}
}