namespace Cryogenic.AdgPlayer.ViewModels;

/// <summary>
/// Display item for channel events in the UI.
/// </summary>
public sealed class ChannelEventItem {
	/// <summary>Channel number (0-8).</summary>
	public int Channel { get; set; }

	/// <summary>Event type name (NoteOn, NoteOff, PgmChg, etc.).</summary>
	public string EventType { get; set; } = "";

	/// <summary>Event detail string.</summary>
	public string Detail { get; set; } = "";

	/// <summary>Tick count when event occurred.</summary>
	public long Tick { get; set; }

	/// <summary>Formatted display string.</summary>
	public string Display => $"[{Tick,8}] Ch{Channel} {EventType,-8} {Detail}";
}