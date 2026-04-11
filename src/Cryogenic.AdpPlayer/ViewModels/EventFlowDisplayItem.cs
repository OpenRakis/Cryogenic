namespace Cryogenic.AdpPlayer.ViewModels;

using Avalonia.Media;

/// <summary>
/// Rich display model for the Event Flow panel. Each event gets channel-colored
/// and kind-colored segments for a tracker-style visual.
/// </summary>
public sealed class EventFlowDisplayItem {
	private static readonly IBrush[] ChannelBrushes = [
		new SolidColorBrush(Color.FromRgb(0xFF, 0x6B, 0x6B)),  // ch0  red
		new SolidColorBrush(Color.FromRgb(0x4E, 0xCD, 0xC4)),  // ch1  teal
		new SolidColorBrush(Color.FromRgb(0x45, 0xB7, 0xD1)),  // ch2  sky
		new SolidColorBrush(Color.FromRgb(0x96, 0xCE, 0xB4)),  // ch3  mint
		new SolidColorBrush(Color.FromRgb(0xFF, 0xEA, 0xA7)),  // ch4  gold
		new SolidColorBrush(Color.FromRgb(0xDD, 0xA0, 0xDD)),  // ch5  plum
		new SolidColorBrush(Color.FromRgb(0x98, 0xD8, 0xC8)),  // ch6  sage
		new SolidColorBrush(Color.FromRgb(0xF7, 0xDC, 0x6F)),  // ch7  amber
		new SolidColorBrush(Color.FromRgb(0xBB, 0x8F, 0xCE)),  // ch8  violet
	];

	private static readonly IBrush DefaultChannelBrush = new SolidColorBrush(Color.FromRgb(0xC0, 0xC0, 0xC0));
	private static readonly IBrush KindNoteOn = new SolidColorBrush(Color.FromRgb(0x5C, 0xDB, 0x95));
	private static readonly IBrush KindNoteOff = new SolidColorBrush(Color.FromRgb(0xFF, 0x6B, 0x6B));
	private static readonly IBrush KindProgChg = new SolidColorBrush(Color.FromRgb(0xFF, 0xD9, 0x3D));
	private static readonly IBrush KindVolMod = new SolidColorBrush(Color.FromRgb(0x6C, 0x5C, 0xE7));
	private static readonly IBrush KindPitchBend = new SolidColorBrush(Color.FromRgb(0x45, 0xB7, 0xD1));
	private static readonly IBrush KindDO = new SolidColorBrush(Color.FromRgb(0x63, 0x6E, 0x72));
	private static readonly IBrush KindEOT = new SolidColorBrush(Color.FromRgb(0xFF, 0x6B, 0x6B));
	private static readonly IBrush KindDefault = new SolidColorBrush(Color.FromRgb(0xC0, 0xC0, 0xC0));

	public required string Position { get; init; }
	public required string ChannelLabel { get; init; }
	public required string Kind { get; init; }
	public required string Detail { get; init; }
	public required string DeltaLabel { get; init; }
	public int Channel { get; init; }

	public IBrush ChannelBrush => Channel >= 0 && Channel < ChannelBrushes.Length
		? ChannelBrushes[Channel]
		: DefaultChannelBrush;

	public IBrush KindBrush => Kind switch {
		"NON" => KindNoteOn,
		"NOF" => KindNoteOff,
		"PRG" => KindProgChg,
		"VOL" => KindVolMod,
		"PB" => KindPitchBend,
		"DO" => KindDO,
		"EOT" => KindEOT,
		_ => KindDefault,
	};
}