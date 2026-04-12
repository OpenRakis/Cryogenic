namespace Cryogenic.AdpPlayer.Services;

using System.Collections.Generic;

/// <summary>
/// OPL capture event type for FM synthesis golden capture.
/// Fundamentally different from MIDI: we capture raw port I/O, timer state, and audio samples.
/// </summary>
public enum OplCaptureEventType : byte {
	/// <summary>OPL register write (OUT 0x388 address, OUT 0x389 data).</summary>
	RegisterWrite = 0,

	/// <summary>OPL status read (IN 0x388 returns timer status byte).</summary>
	StatusRead = 1,

	/// <summary>Periodic audio sample snapshot (peak amplitude).</summary>
	AudioSample = 2
}

/// <summary>
/// Single OPL capture event. Shape is identical on player and override sides
/// so captures can be diffed mechanically.
/// </summary>
public sealed class OplCaptureEvent {
	/// <summary>Monotonic sequence number within this capture session.</summary>
	public required int Sequence { get; init; }

	/// <summary>Event type: RegisterWrite, StatusRead, or AudioSample.</summary>
	public required OplCaptureEventType Type { get; init; }

	/// <summary>Microseconds elapsed since capture start.</summary>
	public required long TimestampUs { get; init; }

	/// <summary>I/O port involved (0x388 address/status, 0x389 data).</summary>
	public required ushort Port { get; init; }

	/// <summary>OPL register address (0x00-0xFF for OPL2). Valid for RegisterWrite.</summary>
	public required byte Register { get; init; }

	/// <summary>Value written (RegisterWrite) or read back (StatusRead).</summary>
	public required byte Value { get; init; }

	/// <summary>OPL channel 0-8 if determinable, -1 otherwise.</summary>
	public required int Channel { get; init; }

	/// <summary>Song measure at time of event.</summary>
	public required ushort Measure { get; init; }

	/// <summary>Song subdivision at time of event.</summary>
	public required ushort Subdivision { get; init; }

	/// <summary>Engine tick index at time of event.</summary>
	public required int TickIndex { get; init; }

	/// <summary>
	/// For RegisterWrite to timer regs (0x02, 0x03, 0x04): the timer control context.
	/// Bit 0: Timer0 running, Bit 1: Timer1 running, Bit 6: Timer1 masked, Bit 7: Timer0 masked.
	/// For StatusRead: the raw status byte returned. For others: 0.
	/// </summary>
	public required byte TimerState { get; init; }

	/// <summary>For AudioSample events: peak amplitude 0.0-1.0. Otherwise 0.</summary>
	public required float AudioPeak { get; init; }
}

/// <summary>
/// Paginated dump of OPL capture events.
/// </summary>
public sealed class OplCaptureDump {
	public required bool IsCapturing { get; init; }
	public required DateTimeOffset StartedUtc { get; init; }
	public required DateTimeOffset? StoppedUtc { get; init; }
	public required int MaxEvents { get; init; }
	public required int EventCount { get; init; }
	public required int ReturnedEventCount { get; init; }
	public required int Offset { get; init; }
	public required int Limit { get; init; }
	public required int DroppedEvents { get; init; }
	public required string CurrentSongName { get; init; }
	public required string CurrentSongPath { get; init; }
	public required IReadOnlyList<OplCaptureEvent> Events { get; init; }
}

/// <summary>
/// Summary statistics for an OPL capture session.
/// </summary>
public sealed class OplCaptureSummary {
	public required bool IsCapturing { get; init; }
	public required DateTimeOffset StartedUtc { get; init; }
	public required DateTimeOffset? StoppedUtc { get; init; }
	public required int MaxEvents { get; init; }
	public required int EventCount { get; init; }
	public required int DroppedEvents { get; init; }
	public required string CurrentSongName { get; init; }
	public required string CurrentSongPath { get; init; }
	public required int RegisterWriteCount { get; init; }
	public required int StatusReadCount { get; init; }
	public required int AudioSampleCount { get; init; }
	public required IReadOnlyDictionary<byte, int> RegisterHistogram { get; init; }
	public required IReadOnlyDictionary<int, int> ChannelHistogram { get; init; }
}

/// <summary>
/// Diagnostics with signature hash for quick comparison between player and override captures.
/// </summary>
public sealed class OplCaptureDiagnostics {
	public required int EventCount { get; init; }
	public required int RegisterWriteCount { get; init; }
	public required int StatusReadCount { get; init; }
	public required IReadOnlyDictionary<byte, int> RegisterHistogram { get; init; }
	public required string SignatureHash { get; init; }
	public required IReadOnlyList<string> FirstEventSignatures { get; init; }
}