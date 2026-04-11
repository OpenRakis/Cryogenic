namespace Cryogenic.AdpPlayer.Services;

public sealed class PlayerDiagnosticsSnapshot {
	public required int TickIndex { get; init; }
	public required ushort Measure { get; init; }
	public required ushort EndMeasure { get; init; }
	public required ushort Subdivision { get; init; }
	public required ushort RepeatCounter { get; init; }
	public required ushort Accumulator { get; init; }
	public required ushort TickIncrement { get; init; }
	public required int ProcessTickCount { get; init; }
	public required ushort ActiveChannelCount { get; init; }
	public required int EventsDispatchedThisTick { get; init; }
	public required double ElapsedSeconds { get; init; }
	public required double EstimatedDurationSeconds { get; init; }
	public required double TimelineProgress { get; init; }
	public required double AudioPeak { get; init; }
	public required ushort[] ChannelWait { get; init; }
	public required ushort[] ChannelEventPointer { get; init; }
	public required string[] LastEventPerChannel { get; init; }
}