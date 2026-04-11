namespace Cryogenic.Mt32Player.Services;

public sealed class AudioDebugInfo {
	public required int SongDataLength { get; init; }
	public required ushort SongHeaderOffset { get; init; }
	public required ushort SongDataOffset { get; init; }
	public required string SongLayoutNote { get; init; }
	public required ushort SchedulerAccumulator { get; init; }
	public required ushort SongTickIncrement { get; init; }
	public required ushort FadeBitPattern { get; init; }
	public required int TickIndex { get; init; }
	public required ushort Measure { get; init; }
	public required ushort EndMeasure { get; init; }
	public required ushort Subdivision { get; init; }
	public required int TotalEventsDecoded { get; init; }
	public required int TestNotesTriggered { get; init; }
	public required int EventResyncCount { get; init; }
	public required bool LastSongPositionValid { get; init; }
	public required int SongPositionMismatchCount { get; init; }
	public required ushort[] ChannelWaitSnapshot { get; init; }
	public required ushort[] ChannelPointerSnapshot { get; init; }
	public required int[] EventTypeCounters { get; init; }
	public required int[] MidiStatusCounters { get; init; }
	public required string[] RecentEvents { get; init; }
}