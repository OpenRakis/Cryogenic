namespace Cryogenic.Mt32Player.Services;

/// <summary>
/// Structured header info for the currently loaded M32 song.
/// Populated once at Load time and displayed in the Header panel.
/// </summary>
public sealed class SongHeaderInfo {
	public required string FileName { get; init; }
	public required string FilePath { get; init; }
	public required int RawFileSize { get; init; }
	public required int DecodedSize { get; init; }
	public required bool WasCompressed { get; init; }
	public required ushort FirstWord { get; init; }
	public required ushort TickIncrement { get; init; }
	public required double PitTicksPerSubdivision { get; init; }
	public required double MillisecondsPerSubdivision { get; init; }
	public required double MillisecondsPerMeasure { get; init; }
	public required double EstimatedDurationSeconds { get; init; }
	public required ushort EndMeasure { get; init; }
	public required ushort LoopMeasure { get; init; }
	public required ushort LoopRepeat { get; init; }
	public required ushort ActiveChannelCount { get; init; }
	public required ChannelHeaderInfo[] Channels { get; init; }
}

/// <summary>
/// Per-channel header info from the channel offset table.
/// </summary>
public sealed class ChannelHeaderInfo {
	public required int Index { get; init; }
	public required ushort RawOffset { get; init; }
	public required ushort AbsoluteOffset { get; init; }
	public required ushort InitialWait { get; init; }
	public required ushort InitialPointer { get; init; }
	public required bool Active { get; init; }
}