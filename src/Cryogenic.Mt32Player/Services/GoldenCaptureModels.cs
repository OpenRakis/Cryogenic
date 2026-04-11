namespace Cryogenic.Mt32Player.Services;

using System.Collections.Generic;

public sealed class GoldenCaptureEvent {
	public required int Sequence { get; init; }
	public required string Source { get; init; }
	public required string Kind { get; init; }
	public required long ElapsedMilliseconds { get; init; }
	public required int TickIndex { get; init; }
	public required ushort Measure { get; init; }
	public required ushort Subdivision { get; init; }
	public required ushort RepeatCounter { get; init; }
	public required int TimelineTick { get; init; }
	public required byte Status { get; init; }
	public required byte Data1 { get; init; }
	public required byte Data2 { get; init; }
	public required bool HasData2 { get; init; }
	public required byte Channel { get; init; }
	public required byte StatusClass { get; init; }
	public required int StreamPointer { get; init; }
	public required int EventType { get; init; }
}

public sealed class GoldenCaptureDump {
	public required bool IsCapturing { get; init; }
	public required DateTimeOffset StartedUtc { get; init; }
	public required DateTimeOffset? StoppedUtc { get; init; }
	public required int MaxEvents { get; init; }
	public required int EventCount { get; init; }
	public required int ReturnedEventCount { get; init; }
	public required int Offset { get; init; }
	public required int Limit { get; init; }
	public required string SourceFilter { get; init; }
	public required string KindFilter { get; init; }
	public required int DroppedEvents { get; init; }
	public required string CurrentSongName { get; init; }
	public required string CurrentSongPath { get; init; }
	public required IReadOnlyList<GoldenCaptureEvent> Events { get; init; }
}

public sealed class GoldenCaptureSummary {
	public required bool IsCapturing { get; init; }
	public required DateTimeOffset StartedUtc { get; init; }
	public required DateTimeOffset? StoppedUtc { get; init; }
	public required int MaxEvents { get; init; }
	public required int EventCount { get; init; }
	public required int DroppedEvents { get; init; }
	public required string CurrentSongName { get; init; }
	public required string CurrentSongPath { get; init; }
	public required IReadOnlyDictionary<string, int> SourceHistogram { get; init; }
	public required IReadOnlyDictionary<string, int> KindHistogram { get; init; }
}

public sealed class GoldenCaptureDiagnostics {
	public required int EventCount { get; init; }
	public required int ChannelVoiceEventCount { get; init; }
	public required int SystemEventCount { get; init; }
	public required IReadOnlyDictionary<string, int> StatusClassHistogram { get; init; }
	public required string SignatureHash { get; init; }
	public required IReadOnlyList<string> FirstEventSignatures { get; init; }
}