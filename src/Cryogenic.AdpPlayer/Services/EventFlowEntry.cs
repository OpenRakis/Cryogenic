namespace Cryogenic.AdpPlayer.Services;

/// <summary>
/// A single entry in the live event flow display.
/// One per dispatched OPL2/control event during playback.
/// </summary>
public sealed class EventFlowEntry {
	public required int TickIndex { get; init; }
	public required int Channel { get; init; }
	public required string Kind { get; init; }
	public required string Detail { get; init; }
	public required ushort Delta { get; init; }
	public required ushort Pointer { get; init; }
	public required ushort Measure { get; init; }
	public required ushort Subdivision { get; init; }

	public string Display => $"T{TickIndex} M{Measure}:{Subdivision:X2} ch{Channel} {Kind} {Detail} d={Delta}";
}