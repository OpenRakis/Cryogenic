namespace Cryogenic;

using ModelContextProtocol.Server;

using Serilog;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;

/// <summary>
/// Cryogenic-specific MCP tools exposed by Spice86.
/// </summary>
[McpServerToolType]
public static class CryogenicMcpTools {
	private static readonly ILogger Logger = Log.ForContext(typeof(CryogenicMcpTools));
	private static readonly Lock Mt32CallCounterLock = new();
	private static readonly Lock Mt32CaptureLock = new();
	private static readonly Dictionary<string, int> Mt32CallCounters = new(StringComparer.Ordinal);
	private static readonly Dictionary<ushort, int> Mt32ObservedSegmentCounters = new();
	private static readonly List<Mt32CapturedMidiEvent> Mt32CaptureEvents = [];
	private static readonly byte[] Mt32PendingData = new byte[2];
	private static readonly List<string> Mt32SongNameCandidates = [];
	private static bool Mt32CaptureEnabled;
	private static int Mt32CaptureMaxEvents = 20000;
	private static int Mt32CaptureDroppedEvents;
	private static int Mt32CapturedRawBytes;
	private static int Mt32CapturedDataPortBytes;
	private static int Mt32IgnoredControlPortBytes;
	private static int Mt32IgnoredWhenDisabledBytes;
	private static int Mt32SongOpenCount;
	private static ushort Mt32LastObservedCodeSegment;
	private static long Mt32CaptureStartTimestamp;
	private static DateTimeOffset Mt32CaptureStartedUtc;
	private static DateTimeOffset? Mt32CaptureStoppedUtc;
	private static int Mt32CaptureSequence;
	private static string Mt32CurrentSongName = "unknown";
	private static string Mt32CurrentSongSource = "none";
	private static ushort Mt32LastSongSegment;
	private static ushort Mt32LastSongOffset;
	private static byte Mt32RunningStatus;
	private static byte Mt32PendingStatus;
	private static int Mt32PendingExpectedDataCount;
	private static int Mt32PendingDataCount;
	private static bool Mt32InSysEx;

	/// <summary>
	/// Represents one captured MIDI event from live MT-32 UART output.
	/// </summary>
	public sealed class Mt32CapturedMidiEvent {
		/// <summary>
		/// Gets or sets the event sequence number in this capture session.
		/// </summary>
		public required int Sequence { get; init; }

		/// <summary>
		/// Gets or sets elapsed milliseconds since capture start.
		/// </summary>
		public required long ElapsedMilliseconds { get; init; }

		/// <summary>
		/// Gets or sets source CPU cycle count when this event was emitted.
		/// </summary>
		public required long CpuCycles { get; init; }

		/// <summary>
		/// Gets or sets the write port used by OUT DX,AL.
		/// </summary>
		public required ushort Port { get; init; }

		/// <summary>
		/// Gets or sets the live CS value at event capture.
		/// </summary>
		public required ushort Cs { get; init; }

		/// <summary>
		/// Gets or sets the live IP value at event capture.
		/// </summary>
		public required ushort Ip { get; init; }

		/// <summary>
		/// Gets or sets current song measure from DNMID state.
		/// </summary>
		public required ushort Measure { get; init; }

		/// <summary>
		/// Gets or sets current song subdivision from DNMID state.
		/// </summary>
		public required ushort Subdivision { get; init; }

		/// <summary>
		/// Gets or sets current repeat counter from DNMID state.
		/// </summary>
		public required ushort RepeatCounter { get; init; }

		/// <summary>
		/// Gets or sets current timer accumulator from DNMID state.
		/// </summary>
		public required ushort TimerAccumulator { get; init; }

		/// <summary>
		/// Gets or sets a flattened timeline tick index derived from measure/subdivision.
		/// </summary>
		public required int TimelineTick { get; init; }

		/// <summary>
		/// Gets or sets MIDI status byte.
		/// </summary>
		public required byte Status { get; init; }

		/// <summary>
		/// Gets or sets first MIDI data byte.
		/// </summary>
		public required byte Data1 { get; init; }

		/// <summary>
		/// Gets or sets second MIDI data byte when present.
		/// </summary>
		public required byte Data2 { get; init; }

		/// <summary>
		/// Gets or sets whether this event has a second data byte.
		/// </summary>
		public required bool HasData2 { get; init; }

		/// <summary>
		/// Gets or sets MIDI channel when status is channel voice (0-15), otherwise 255.
		/// </summary>
		public required byte Channel { get; init; }

		/// <summary>
		/// Gets or sets high-nibble status class.
		/// </summary>
		public required byte StatusClass { get; init; }
	}

	/// <summary>
	/// Structured response for capture status and optional event dump.
	/// </summary>
	public sealed class Mt32CaptureDumpResponse {
		/// <summary>
		/// Gets or sets whether capture is currently active.
		/// </summary>
		public required bool IsCapturing { get; init; }

		/// <summary>
		/// Gets or sets UTC capture start time.
		/// </summary>
		public required DateTimeOffset StartedUtc { get; init; }

		/// <summary>
		/// Gets or sets UTC capture stop time when stopped.
		/// </summary>
		public required DateTimeOffset? StoppedUtc { get; init; }

		/// <summary>
		/// Gets or sets maximum events retained in-memory.
		/// </summary>
		public required int MaxEvents { get; init; }

		/// <summary>
		/// Gets or sets retained event count.
		/// </summary>
		public required int EventCount { get; init; }

		/// <summary>
		/// Gets or sets count of dropped events after reaching max capacity.
		/// </summary>
		public required int DroppedEvents { get; init; }

		/// <summary>
		/// Gets or sets currently inferred song name.
		/// </summary>
		public required string CurrentSongName { get; init; }

		/// <summary>
		/// Gets or sets source used to infer current song name.
		/// </summary>
		public required string CurrentSongSource { get; init; }

		/// <summary>
		/// Gets or sets candidate song names observed during filename patching.
		/// </summary>
		public required IReadOnlyList<string> SongCandidates { get; init; }

		/// <summary>
		/// Gets or sets count of MT-32 open-song calls observed during capture.
		/// </summary>
		public required int SongOpenCount { get; init; }

		/// <summary>
		/// Gets or sets the last song stream segment observed at open-song entry.
		/// </summary>
		public required string LastSongSegment { get; init; }

		/// <summary>
		/// Gets or sets the last song stream offset observed at open-song entry.
		/// </summary>
		public required string LastSongOffset { get; init; }

		/// <summary>
		/// Gets or sets captured events.
		/// </summary>
		public required IReadOnlyList<Mt32CapturedMidiEvent> Events { get; init; }
	}

	/// <summary>
	/// Structured diagnostics for MT-32 capture parity analysis.
	/// </summary>
	public sealed class Mt32CaptureDiagnosticsResponse {
		/// <summary>
		/// Gets or sets raw byte count observed by hooks.
		/// </summary>
		public required int RawBytesObserved { get; init; }

		/// <summary>
		/// Gets or sets number of bytes captured from data port.
		/// </summary>
		public required int DataPortBytesObserved { get; init; }

		/// <summary>
		/// Gets or sets number of bytes ignored from control/status port writes.
		/// </summary>
		public required int ControlPortBytesIgnored { get; init; }

		/// <summary>
		/// Gets or sets number of bytes ignored because capture was disabled.
		/// </summary>
		public required int BytesIgnoredWhenDisabled { get; init; }

		/// <summary>
		/// Gets or sets retained MIDI event count.
		/// </summary>
		public required int MidiEventCount { get; init; }

		/// <summary>
		/// Gets or sets retained system/common event count (status >= F0).
		/// </summary>
		public required int SystemEventCount { get; init; }

		/// <summary>
		/// Gets or sets retained channel-voice event count.
		/// </summary>
		public required int ChannelVoiceEventCount { get; init; }

		/// <summary>
		/// Gets or sets status-class histogram as hex-keyed map ("0x9" etc).
		/// </summary>
		public required IReadOnlyDictionary<string, int> StatusClassHistogram { get; init; }

		/// <summary>
		/// Gets or sets compact signature hash of retained events for cross-side comparison.
		/// </summary>
		public required string SignatureHash { get; init; }

		/// <summary>
		/// Gets or sets first few event signatures for quick visual parity checks.
		/// </summary>
		public required IReadOnlyList<string> FirstEventSignatures { get; init; }
	}

	/// <summary>
	/// Structured response payload for the cryogenic_status tool.
	/// </summary>
	public sealed class CryogenicStatusResponse {
		/// <summary>
		/// Gets or sets the assembly name that provided the custom tools.
		/// </summary>
		public required string ToolAssembly { get; init; }

		/// <summary>
		/// Gets or sets remapped driver 1 segment (hex string).
		/// </summary>
		public required string Driver1Segment { get; init; }

		/// <summary>
		/// Gets or sets remapped driver 2 segment (hex string).
		/// </summary>
		public required string Driver2Segment { get; init; }

		/// <summary>
		/// Gets or sets remapped driver 3 segment (hex string).
		/// </summary>
		public required string Driver3Segment { get; init; }

		/// <summary>
		/// Gets or sets interrupt handler segment (hex string).
		/// </summary>
		public required string InterruptHandlerSegment { get; init; }

		/// <summary>
		/// Gets or sets the detected MIDI segment at runtime (hex string).
		/// </summary>
		public required string ActualMidiSegment { get; init; }
	}

	/// <summary>
	/// Structured response payload for counter reset operations.
	/// </summary>
	public sealed class CounterResetResponse {
		/// <summary>
		/// Gets or sets whether the reset operation succeeded.
		/// </summary>
		public required bool Success { get; init; }

		/// <summary>
		/// Gets or sets the number of entries removed from the counter map.
		/// </summary>
		public required int RemovedEntries { get; init; }

		/// <summary>
		/// Gets or sets the number of counted calls removed by reset.
		/// </summary>
		public required int RemovedCalls { get; init; }

		/// <summary>
		/// Gets or sets an operator-friendly status message.
		/// </summary>
		public required string Message { get; init; }
	}

	/// <summary>
	/// Records that an MT-32 override entry point was invoked.
	/// </summary>
	/// <param name="entryPoint">Entry point identifier (for example F000:0100).</param>
	public static void RecordMt32Call(string entryPoint) {
		int updatedCount = 0;
		lock (Mt32CallCounterLock) {
			if (Mt32CallCounters.TryGetValue(entryPoint, out int currentValue)) {
				updatedCount = currentValue + 1;
				Mt32CallCounters[entryPoint] = updatedCount;
			} else {
				updatedCount = 1;
				Mt32CallCounters[entryPoint] = updatedCount;
			}
		}
		//Logger.Debug("Recorded MT-32 override call. EntryPoint={EntryPoint}, Count={Count}", entryPoint, updatedCount);
	}

	/// <summary>
	/// Records that an MT-32 override entry point was invoked and tracks live runtime CS:IP sites.
	/// </summary>
	/// <param name="entryPoint">Stable logical entry identifier (for example F000:0100).</param>
	/// <param name="cs">Runtime code segment where the hook fired.</param>
	/// <param name="ip">Runtime instruction pointer where the hook fired.</param>
	public static void RecordMt32Call(string entryPoint, ushort cs, ushort ip) {
		RecordMt32Call(entryPoint);

		string runtimeEntryPoint = $"{cs:X4}:{ip:X4}";
		lock (Mt32CallCounterLock) {
			if (Mt32CallCounters.TryGetValue(runtimeEntryPoint, out int runtimeCurrentValue)) {
				Mt32CallCounters[runtimeEntryPoint] = runtimeCurrentValue + 1;
			} else {
				Mt32CallCounters[runtimeEntryPoint] = 1;
			}
		}

		RecordObservedMidiSegment(cs);
	}

	/// <summary>
	/// Records one raw MT-32 UART output byte and assembles MIDI messages for golden capture.
	/// </summary>
	public static void RecordMt32OutputByte(byte value, ushort port, ushort cs, ushort ip, long cycles, ushort measure, ushort subdivision, ushort repeatCounter, ushort timerAccumulator) {
		lock (Mt32CaptureLock) {
			RecordObservedMidiSegmentLocked(cs);
			Mt32CapturedRawBytes++;
			if (!Mt32CaptureEnabled) {
				Mt32IgnoredWhenDisabledBytes++;
				return;
			}
			if ((port & 0x0001) != 0) {
				// Odd MPU-401 port is status/control, not MIDI data stream.
				Mt32IgnoredControlPortBytes++;
				return;
			}
			Mt32CapturedDataPortBytes++;
			ProcessMt32OutputByteLocked(value, port, cs, ip, cycles, measure, subdivision, repeatCounter, timerAccumulator);
		}
	}

	/// <summary>
	/// Records a candidate MT-32 song filename observed in the driver patch-extension path.
	/// </summary>
	public static void RecordMt32SongNameCandidate(string songName, string source) {
		if (string.IsNullOrWhiteSpace(songName)) {
			return;
		}

		bool changedCurrentSong = false;
		lock (Mt32CaptureLock) {
			if (!Mt32SongNameCandidates.Contains(songName, StringComparer.OrdinalIgnoreCase)) {
				Mt32SongNameCandidates.Add(songName);
				if (Mt32SongNameCandidates.Count > 32) {
					Mt32SongNameCandidates.RemoveAt(0);
				}
			}

			changedCurrentSong = !string.Equals(Mt32CurrentSongName, songName, StringComparison.OrdinalIgnoreCase);
			if (changedCurrentSong) {
				Mt32CurrentSongName = songName;
				Mt32CurrentSongSource = source;
			}
		}

		if (changedCurrentSong) {
			Logger.Information("MT-32 song candidate recorded. SongName={SongName}, Source={Source}", songName, source);
		}
	}

	/// <summary>
	/// Records MT-32 open-song stream pointer context used for capture metadata.
	/// </summary>
	public static void RecordMt32SongOpen(ushort segment, ushort offset) {
		string selectedSongName = string.Empty;
		lock (Mt32CaptureLock) {
			RecordObservedMidiSegmentLocked(segment);
			Mt32SongOpenCount++;
			Mt32LastSongSegment = segment;
			Mt32LastSongOffset = offset;
			if (string.Equals(Mt32CurrentSongName, "unknown", StringComparison.Ordinal) && Mt32SongNameCandidates.Count > 0) {
				Mt32CurrentSongName = Mt32SongNameCandidates[^1];
				Mt32CurrentSongSource = "dnmid:open-song-fallback";
			}
			selectedSongName = Mt32CurrentSongName;
		}
		Logger.Information("MT-32 open-song observed. SongName={SongName}, Segment={SegmentHex}, Offset={OffsetHex}", selectedSongName, $"0x{segment:X4}", $"0x{offset:X4}");
	}

	private static void ProcessMt32OutputByteLocked(byte value, ushort port, ushort cs, ushort ip, long cycles, ushort measure, ushort subdivision, ushort repeatCounter, ushort timerAccumulator) {
		if (value >= 0xF8) {
			AppendMt32MidiEvent(value, 0, 0, false, port, cs, ip, cycles, measure, subdivision, repeatCounter, timerAccumulator);
			return;
		}

		if (Mt32InSysEx) {
			if (value == 0xF7) {
				AppendMt32MidiEvent(0xF7, 0, 0, false, port, cs, ip, cycles, measure, subdivision, repeatCounter, timerAccumulator);
				Mt32InSysEx = false;
			}
			return;
		}

		if ((value & 0x80) != 0) {
			if (value == 0xF0) {
				Mt32InSysEx = true;
				AppendMt32MidiEvent(0xF0, 0, 0, false, port, cs, ip, cycles, measure, subdivision, repeatCounter, timerAccumulator);
				return;
			}

			Mt32PendingStatus = value;
			Mt32PendingDataCount = 0;
			Mt32PendingExpectedDataCount = GetMidiDataLength(value);
			if (Mt32PendingExpectedDataCount == 0) {
				AppendMt32MidiEvent(value, 0, 0, false, port, cs, ip, cycles, measure, subdivision, repeatCounter, timerAccumulator);
				if (value < 0xF0) {
					Mt32RunningStatus = value;
				}
				return;
			}
			if (value < 0xF0) {
				Mt32RunningStatus = value;
			}
			return;
		}

		if (Mt32PendingExpectedDataCount == 0) {
			if (Mt32RunningStatus == 0) {
				return;
			}
			Mt32PendingStatus = Mt32RunningStatus;
			Mt32PendingExpectedDataCount = GetMidiDataLength(Mt32PendingStatus);
			Mt32PendingDataCount = 0;
		}

		if (Mt32PendingDataCount < Mt32PendingData.Length) {
			Mt32PendingData[Mt32PendingDataCount] = value;
		}
		Mt32PendingDataCount++;

		if (Mt32PendingDataCount >= Mt32PendingExpectedDataCount) {
			byte data1 = Mt32PendingDataCount > 0 ? Mt32PendingData[0] : (byte)0;
			byte data2 = Mt32PendingDataCount > 1 ? Mt32PendingData[1] : (byte)0;
			bool hasData2 = Mt32PendingExpectedDataCount > 1;
			AppendMt32MidiEvent(Mt32PendingStatus, data1, data2, hasData2, port, cs, ip, cycles, measure, subdivision, repeatCounter, timerAccumulator);
			Mt32PendingDataCount = 0;
			Mt32PendingExpectedDataCount = 0;
		}
	}

	private static int GetMidiDataLength(byte status) {
		if (status < 0x80) {
			return 0;
		}

		if (status < 0xF0) {
			int statusClass = status >> 4;
			return statusClass == 0xC || statusClass == 0xD ? 1 : 2;
		}

		return status switch {
			0xF1 => 1,
			0xF2 => 2,
			0xF3 => 1,
			0xF6 => 0,
			0xF8 => 0,
			0xFA => 0,
			0xFB => 0,
			0xFC => 0,
			0xFE => 0,
			0xFF => 0,
			_ => 0
		};
	}

	private static void AppendMt32MidiEvent(byte status, byte data1, byte data2, bool hasData2, ushort port, ushort cs, ushort ip, long cycles, ushort measure, ushort subdivision, ushort repeatCounter, ushort timerAccumulator) {
		if (Mt32CaptureEvents.Count >= Mt32CaptureMaxEvents) {
			Mt32CaptureDroppedEvents++;
			return;
		}

		long elapsedMs = 0;
		if (Mt32CaptureStartTimestamp != 0) {
			long elapsedTicks = Stopwatch.GetTimestamp() - Mt32CaptureStartTimestamp;
			elapsedMs = (elapsedTicks * 1000L) / Stopwatch.Frequency;
		}

		byte statusClass = (byte)(status >> 4);
		byte channel = status < 0xF0 ? (byte)(status & 0x0F) : (byte)255;
		int timelineTick = Math.Max(0, ((measure == 0 ? 0 : measure - 1) * 96) + (96 - Math.Min(96, (int)subdivision)));

		Mt32CapturedMidiEvent item = new() {
			Sequence = ++Mt32CaptureSequence,
			ElapsedMilliseconds = elapsedMs,
			CpuCycles = cycles,
			Port = port,
			Cs = cs,
			Ip = ip,
			Measure = measure,
			Subdivision = subdivision,
			RepeatCounter = repeatCounter,
			TimerAccumulator = timerAccumulator,
			TimelineTick = timelineTick,
			Status = status,
			Data1 = data1,
			Data2 = data2,
			HasData2 = hasData2,
			Channel = channel,
			StatusClass = statusClass
		};
		Mt32CaptureEvents.Add(item);
	}

	private static void RecordObservedMidiSegment(ushort segment) {
		lock (Mt32CaptureLock) {
			RecordObservedMidiSegmentLocked(segment);
		}
	}

	private static void RecordObservedMidiSegmentLocked(ushort segment) {
		if (segment == 0) {
			return;
		}

		Mt32LastObservedCodeSegment = segment;
		if (Mt32ObservedSegmentCounters.TryGetValue(segment, out int currentCount)) {
			Mt32ObservedSegmentCounters[segment] = currentCount + 1;
		} else {
			Mt32ObservedSegmentCounters[segment] = 1;
		}
	}

	private static ushort ResolveDiscoveredMidiSegmentLocked() {
		if (DriverLoadToolbox.ActualMidiSegment != 0) {
			return DriverLoadToolbox.ActualMidiSegment;
		}

		if (Mt32LastSongSegment != 0) {
			return Mt32LastSongSegment;
		}

		ushort bestSegment = 0;
		int bestCount = 0;
		foreach (KeyValuePair<ushort, int> pair in Mt32ObservedSegmentCounters) {
			if (pair.Value > bestCount) {
				bestCount = pair.Value;
				bestSegment = pair.Key;
			}
		}

		if (bestSegment != 0) {
			return bestSegment;
		}

		return Mt32LastObservedCodeSegment;
	}

	/// <summary>
	/// Returns a lightweight status payload for verifying Cryogenic MCP tool registration.
	/// </summary>
	/// <returns>Dictionary with tool registration and driver segment information.</returns>
	[McpServerTool(Name = "cryogenic_status", UseStructuredContent = true)]
	[Description("Read Cryogenic MCP extension state. Parameters: none (arguments must be {}). Returns tool assembly name, remapped driver segments, interrupt handler segment, and detected runtime MIDI segment.")]
	public static CryogenicStatusResponse CryogenicStatus() {
		string toolAssemblyName = typeof(CryogenicMcpTools).Assembly.GetName().Name ?? "unknown";
		Logger.Information("MCP tool invoked: cryogenic_status");
		ushort resolvedMidiSegment;
		lock (Mt32CaptureLock) {
			resolvedMidiSegment = ResolveDiscoveredMidiSegmentLocked();
		}
		CryogenicStatusResponse result = new() {
			ToolAssembly = toolAssemblyName,
			Driver1Segment = $"0x{DriverLoadToolbox.DRIVER1_SEGMENT:X4}",
			Driver2Segment = $"0x{DriverLoadToolbox.DRIVER2_SEGMENT:X4}",
			Driver3Segment = $"0x{DriverLoadToolbox.DRIVER3_SEGMENT:X4}",
			InterruptHandlerSegment = $"0x{DriverLoadToolbox.INTERRUPT_HANDLER_SEGMENT:X4}",
			ActualMidiSegment = $"0x{resolvedMidiSegment:X4}"
		};
		Logger.Debug("cryogenic_status result: {@Result}", result);
		return result;
	}

	/// <summary>
	/// Returns observed MT-32 override call counters gathered during this emulator session.
	/// </summary>
	/// <returns>Dictionary of entry point -> call count.</returns>
	[McpServerTool(Name = "cryogenic_mt32_call_counts", UseStructuredContent = true)]
	[Description("Read MT-32 override call counters for this emulator process. Parameters: none (arguments must be {}). Returns a dictionary keyed by exported entry point (for example F000:0100) with integer call counts.")]
	public static IReadOnlyDictionary<string, int> CryogenicMt32CallCounts() {
		Logger.Information("MCP tool invoked: cryogenic_mt32_call_counts");
		Dictionary<string, int> snapshot = new(StringComparer.Ordinal);
		lock (Mt32CallCounterLock) {
			foreach (KeyValuePair<string, int> pair in Mt32CallCounters) {
				snapshot[pair.Key] = pair.Value;
			}
		}
		Logger.Debug("cryogenic_mt32_call_counts returned {EntryCount} entries.", snapshot.Count);
		return snapshot;
	}

	/// <summary>
	/// Clears MT-32 call counters so a probe can start from a known zero baseline.
	/// </summary>
	/// <returns>Information about removed entries and calls.</returns>
	[McpServerTool(Name = "cryogenic_mt32_reset_call_counts", UseStructuredContent = true)]
	[Description("Reset MT-32 override call counters to zero for a clean measurement window. Parameters: none (arguments must be {}). Returns success, removed entry count, removed call count, and status message.")]
	public static CounterResetResponse CryogenicMt32ResetCallCounts() {
		Logger.Information("MCP tool invoked: cryogenic_mt32_reset_call_counts");
		int removedEntries = 0;
		int removedCalls = 0;
		lock (Mt32CallCounterLock) {
			removedEntries = Mt32CallCounters.Count;
			foreach (KeyValuePair<string, int> pair in Mt32CallCounters) {
				removedCalls += pair.Value;
			}
			Mt32CallCounters.Clear();
		}
		lock (Mt32CaptureLock) {
			Mt32ObservedSegmentCounters.Clear();
			Mt32LastObservedCodeSegment = 0;
		}

		CounterResetResponse result = new() {
			Success = true,
			RemovedEntries = removedEntries,
			RemovedCalls = removedCalls,
			Message = "MT-32 call counters reset"
		};
		Logger.Information("MT-32 counters reset. RemovedEntries={RemovedEntries}, RemovedCalls={RemovedCalls}", removedEntries, removedCalls);
		return result;
	}

	/// <summary>
	/// Starts a new MT-32 golden capture window from live UART traffic.
	/// </summary>
	[McpServerTool(Name = "cryogenic_mt32_capture_start", UseStructuredContent = true)]
	[Description("Start capturing MT-32 UART output as structured MIDI events. Parameters: maxEvents (int, optional style; pass 0 to use default 20000). Returns capture status.")]
	public static Mt32CaptureDumpResponse CryogenicMt32CaptureStart(int maxEvents) {
		lock (Mt32CaptureLock) {
			Mt32CaptureMaxEvents = maxEvents <= 0 ? 20000 : maxEvents;
			Mt32CaptureEvents.Clear();
			Mt32CaptureDroppedEvents = 0;
			Mt32CapturedRawBytes = 0;
			Mt32CapturedDataPortBytes = 0;
			Mt32IgnoredControlPortBytes = 0;
			Mt32IgnoredWhenDisabledBytes = 0;
			Mt32CaptureSequence = 0;
			Mt32CaptureStartedUtc = DateTimeOffset.UtcNow;
			Mt32CaptureStoppedUtc = null;
			Mt32CaptureStartTimestamp = Stopwatch.GetTimestamp();
			Mt32CaptureEnabled = true;
			Mt32SongNameCandidates.Clear();
			Mt32CurrentSongName = "unknown";
			Mt32CurrentSongSource = "none";
			Mt32SongOpenCount = 0;
			Mt32LastSongSegment = 0;
			Mt32LastSongOffset = 0;
			Mt32ObservedSegmentCounters.Clear();
			Mt32LastObservedCodeSegment = 0;
			Mt32RunningStatus = 0;
			Mt32PendingStatus = 0;
			Mt32PendingExpectedDataCount = 0;
			Mt32PendingDataCount = 0;
			Mt32InSysEx = false;
		}

		Logger.Information("MCP tool invoked: cryogenic_mt32_capture_start maxEvents={MaxEvents}", maxEvents);
		return CryogenicMt32CaptureDump();
	}

	/// <summary>
	/// Stops MT-32 capture and returns current capture status.
	/// </summary>
	[McpServerTool(Name = "cryogenic_mt32_capture_stop", UseStructuredContent = true)]
	[Description("Stop MT-32 UART golden capture. Parameters: none (arguments must be {}). Returns capture status and retained event count.")]
	public static Mt32CaptureDumpResponse CryogenicMt32CaptureStop() {
		lock (Mt32CaptureLock) {
			Mt32CaptureEnabled = false;
			Mt32CaptureStoppedUtc = DateTimeOffset.UtcNow;
		}

		Logger.Information("MCP tool invoked: cryogenic_mt32_capture_stop");
		return CryogenicMt32CaptureDump();
	}

	/// <summary>
	/// Clears MT-32 capture buffers and parser state.
	/// </summary>
	[McpServerTool(Name = "cryogenic_mt32_capture_reset", UseStructuredContent = true)]
	[Description("Reset MT-32 golden capture buffers and parser state. Parameters: none (arguments must be {}). Returns capture status after reset.")]
	public static Mt32CaptureDumpResponse CryogenicMt32CaptureReset() {
		lock (Mt32CaptureLock) {
			Mt32CaptureEvents.Clear();
			Mt32CaptureDroppedEvents = 0;
			Mt32CapturedRawBytes = 0;
			Mt32CapturedDataPortBytes = 0;
			Mt32IgnoredControlPortBytes = 0;
			Mt32IgnoredWhenDisabledBytes = 0;
			Mt32CaptureSequence = 0;
			Mt32SongNameCandidates.Clear();
			Mt32CurrentSongName = "unknown";
			Mt32CurrentSongSource = "none";
			Mt32SongOpenCount = 0;
			Mt32LastSongSegment = 0;
			Mt32LastSongOffset = 0;
			Mt32ObservedSegmentCounters.Clear();
			Mt32LastObservedCodeSegment = 0;
			Mt32RunningStatus = 0;
			Mt32PendingStatus = 0;
			Mt32PendingExpectedDataCount = 0;
			Mt32PendingDataCount = 0;
			Mt32InSysEx = false;
			Mt32CaptureStartTimestamp = Stopwatch.GetTimestamp();
			Mt32CaptureStartedUtc = DateTimeOffset.UtcNow;
			Mt32CaptureStoppedUtc = Mt32CaptureEnabled ? null : DateTimeOffset.UtcNow;
		}

		Logger.Information("MCP tool invoked: cryogenic_mt32_capture_reset");
		return CryogenicMt32CaptureDump();
	}

	/// <summary>
	/// Dumps MT-32 capture metadata and retained events.
	/// </summary>
	[McpServerTool(Name = "cryogenic_mt32_capture_dump", UseStructuredContent = true)]
	[Description("Dump MT-32 golden capture data (metadata + events). Parameters: none (arguments must be {}). Returns JSON-friendly capture payload.")]
	public static Mt32CaptureDumpResponse CryogenicMt32CaptureDump() {
		lock (Mt32CaptureLock) {
			List<Mt32CapturedMidiEvent> copy = new(Mt32CaptureEvents.Count);
			copy.AddRange(Mt32CaptureEvents);
			List<string> songCandidates = new(Mt32SongNameCandidates.Count);
			songCandidates.AddRange(Mt32SongNameCandidates);
			Mt32CaptureDumpResponse response = new() {
				IsCapturing = Mt32CaptureEnabled,
				StartedUtc = Mt32CaptureStartedUtc,
				StoppedUtc = Mt32CaptureStoppedUtc,
				MaxEvents = Mt32CaptureMaxEvents,
				EventCount = copy.Count,
				DroppedEvents = Mt32CaptureDroppedEvents,
				CurrentSongName = Mt32CurrentSongName,
				CurrentSongSource = Mt32CurrentSongSource,
				SongCandidates = songCandidates,
				SongOpenCount = Mt32SongOpenCount,
				LastSongSegment = $"0x{Mt32LastSongSegment:X4}",
				LastSongOffset = $"0x{Mt32LastSongOffset:X4}",
				Events = copy
			};
			return response;
		}
	}

	/// <summary>
	/// Produces actionable diagnostics for comparing ASM capture against reimplementation capture.
	/// </summary>
	[McpServerTool(Name = "cryogenic_mt32_capture_diagnose", UseStructuredContent = true)]
	[Description("Diagnose MT-32 capture quality and emit parity-friendly metrics. Parameters: sampleSize (int, optional, default 32). Returns byte-level filter counters, event-class histogram, event signature hash, and first event signatures.")]
	public static Mt32CaptureDiagnosticsResponse CryogenicMt32CaptureDiagnose(int sampleSize) {
		lock (Mt32CaptureLock) {
			int takeCount = sampleSize <= 0 ? 32 : sampleSize;
			if (takeCount > 256) {
				takeCount = 256;
			}

			Dictionary<string, int> histogram = new(StringComparer.Ordinal);
			int channelVoiceCount = 0;
			int systemCount = 0;
			List<string> signatures = new();
			ulong hash = 1469598103934665603UL;

			for (int i = 0; i < Mt32CaptureEvents.Count; i++) {
				Mt32CapturedMidiEvent ev = Mt32CaptureEvents[i];
				string key = $"0x{ev.StatusClass:X1}";
				if (histogram.TryGetValue(key, out int existing)) {
					histogram[key] = existing + 1;
				} else {
					histogram[key] = 1;
				}

				if (ev.Status < 0xF0) {
					channelVoiceCount++;
				} else {
					systemCount++;
				}

				hash ^= ev.Status;
				hash *= 1099511628211UL;
				hash ^= ev.Data1;
				hash *= 1099511628211UL;
				hash ^= ev.Data2;
				hash *= 1099511628211UL;

				if (signatures.Count < takeCount) {
					if (ev.HasData2) {
						signatures.Add($"{ev.Status:X2}:{ev.Data1:X2}:{ev.Data2:X2}@{ev.TimelineTick}");
					} else {
						signatures.Add($"{ev.Status:X2}:{ev.Data1:X2}:-@{ev.TimelineTick}");
					}
				}
			}

			return new Mt32CaptureDiagnosticsResponse {
				RawBytesObserved = Mt32CapturedRawBytes,
				DataPortBytesObserved = Mt32CapturedDataPortBytes,
				ControlPortBytesIgnored = Mt32IgnoredControlPortBytes,
				BytesIgnoredWhenDisabled = Mt32IgnoredWhenDisabledBytes,
				MidiEventCount = Mt32CaptureEvents.Count,
				SystemEventCount = systemCount,
				ChannelVoiceEventCount = channelVoiceCount,
				StatusClassHistogram = histogram,
				SignatureHash = $"0x{hash:X16}",
				FirstEventSignatures = signatures
			};
		}
	}

	// ═══════════════════════════════════════════════════════════════════
	// DNADP (AdLib Pro / OPL2) driver diagnostics
	// ═══════════════════════════════════════════════════════════════════

	private static readonly Lock AdpCallCounterLock = new();
	private static readonly Lock AdpOplCaptureLock = new();
	private static readonly Dictionary<string, int> AdpCallCounters = new(StringComparer.Ordinal);
	private static readonly List<OplCaptureEvent> AdpOplCaptureEvents = [];
	private static bool AdpOplCaptureEnabled;
	private static int AdpOplCaptureMaxEvents = 50000;
	private static int AdpOplCaptureDroppedEvents;
	private static long AdpOplCaptureStartTimestamp;
	private static int AdpOplCaptureSequence;
	private static DateTimeOffset AdpOplCaptureStartedUtc;
	private static DateTimeOffset? AdpOplCaptureStoppedUtc;
	private static ushort AdpLastSongSegment;
	private static ushort AdpLastSongOffset;
	private static ushort AdpLastMeasure;
	private static ushort AdpLastSubdivision;

	/// <summary>
	/// Records that a DNADP entry point or internal function was invoked.
	/// </summary>
	public static void RecordAdpCall(string entryPoint) {
		lock (AdpCallCounterLock) {
			if (AdpCallCounters.TryGetValue(entryPoint, out int current)) {
				AdpCallCounters[entryPoint] = current + 1;
			} else {
				AdpCallCounters[entryPoint] = 1;
			}
		}
	}

	/// <summary>
	/// Records a song open event with the ES:SI pointer to song data.
	/// </summary>
	public static void RecordAdpSongOpen(ushort segment, ushort offset) {
		lock (AdpCallCounterLock) {
			AdpLastSongSegment = segment;
			AdpLastSongOffset = offset;
		}
	}

	/// <summary>
	/// Records the current scheduler position (measure and subdivision).
	/// </summary>
	public static void RecordAdpSchedulerState(ushort measure, ushort subdivision) {
		lock (AdpCallCounterLock) {
			AdpLastMeasure = measure;
			AdpLastSubdivision = subdivision;
		}
	}

	/// <summary>
	/// Records an OPL register write from the DNADP driver.
	/// Shape matches the player-side OplCaptureEvent for mechanical diffing.
	/// </summary>
	public static void RecordAdpOplWrite(byte register, byte data, long cycles, int tickIndex) {
		lock (AdpOplCaptureLock) {
			if (!AdpOplCaptureEnabled) {
				return;
			}
			if (AdpOplCaptureEvents.Count >= AdpOplCaptureMaxEvents) {
				AdpOplCaptureDroppedEvents++;
				return;
			}
			long elapsedTicks = cycles - AdpOplCaptureStartTimestamp;
			long elapsedUs = elapsedTicks * 1_000_000 / Stopwatch.Frequency;

			byte timerState = 0;
			if (register == 0x02 || register == 0x03 || register == 0x04) {
				timerState = data;
			}

			AdpOplCaptureEvents.Add(new OplCaptureEvent {
				Sequence = AdpOplCaptureSequence++,
				Type = OplCaptureEventType.RegisterWrite,
				TimestampUs = elapsedUs,
				Port = 0x389,
				Register = register,
				Value = data,
				Channel = OplRegisterToChannel(register),
				Measure = AdpLastMeasure,
				Subdivision = AdpLastSubdivision,
				TickIndex = tickIndex,
				TimerState = timerState,
				AudioPeak = 0f
			});
		}
	}

	/// <summary>
	/// Records an OPL status read (IN 0x388) from the DNADP driver.
	/// </summary>
	public static void RecordAdpOplStatusRead(byte statusByte, long cycles, int tickIndex) {
		lock (AdpOplCaptureLock) {
			if (!AdpOplCaptureEnabled) {
				return;
			}
			if (AdpOplCaptureEvents.Count >= AdpOplCaptureMaxEvents) {
				AdpOplCaptureDroppedEvents++;
				return;
			}
			long elapsedTicks = cycles - AdpOplCaptureStartTimestamp;
			long elapsedUs = elapsedTicks * 1_000_000 / Stopwatch.Frequency;

			AdpOplCaptureEvents.Add(new OplCaptureEvent {
				Sequence = AdpOplCaptureSequence++,
				Type = OplCaptureEventType.StatusRead,
				TimestampUs = elapsedUs,
				Port = 0x388,
				Register = 0,
				Value = statusByte,
				Channel = -1,
				Measure = AdpLastMeasure,
				Subdivision = AdpLastSubdivision,
				TickIndex = tickIndex,
				TimerState = statusByte,
				AudioPeak = 0f
			});
		}
	}

	/// <summary>
	/// Derives the OPL channel (0-8) from a register address, or -1 if not channel-specific.
	/// Identical logic to the player-side OplRegisterToChannel.
	/// </summary>
	private static int OplRegisterToChannel(byte register) {
		int low = register & 0xFF;
		if (low is >= 0xA0 and <= 0xA8) {
			return low - 0xA0;
		}
		if (low is >= 0xB0 and <= 0xB8) {
			return low - 0xB0;
		}
		if (low is >= 0xC0 and <= 0xC8) {
			return low - 0xC0;
		}
		if (low is (>= 0x20 and <= 0x35) or (>= 0x40 and <= 0x55) or (>= 0x60 and <= 0x75) or (>= 0x80 and <= 0x95) or (>= 0xE0 and <= 0xF5)) {
			int opOffset = low & 0x1F;
			ReadOnlySpan<byte> op1Map = [0x00, 0x01, 0x02, 0x08, 0x09, 0x0A, 0x10, 0x11, 0x12];
			ReadOnlySpan<byte> op2Map = [0x03, 0x04, 0x05, 0x0B, 0x0C, 0x0D, 0x13, 0x14, 0x15];
			for (int ch = 0; ch < 9; ch++) {
				if (op1Map[ch] == opOffset || op2Map[ch] == opOffset) {
					return ch;
				}
			}
		}
		return -1;
	}

	/// <summary>
	/// OPL capture event type for FM synthesis golden capture.
	/// Same enum on both player and override sides.
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
	/// Single OPL capture event. Shape identical to player-side OplCaptureEvent.
	/// </summary>
	public sealed class OplCaptureEvent {
		public required int Sequence { get; init; }
		public required OplCaptureEventType Type { get; init; }
		public required long TimestampUs { get; init; }
		public required ushort Port { get; init; }
		public required byte Register { get; init; }
		public required byte Value { get; init; }
		public required int Channel { get; init; }
		public required ushort Measure { get; init; }
		public required ushort Subdivision { get; init; }
		public required int TickIndex { get; init; }
		public required byte TimerState { get; init; }
		public required float AudioPeak { get; init; }
	}

	/// <summary>
	/// Structured response for DNADP call count queries.
	/// </summary>
	public sealed class AdpCallCountsResponse {
		public required IReadOnlyDictionary<string, int> Entries { get; init; }
		public required ushort LastSongSegment { get; init; }
		public required ushort LastSongOffset { get; init; }
		public required ushort LastMeasure { get; init; }
		public required ushort LastSubdivision { get; init; }
	}

	/// <summary>
	/// Structured response for DNADP OPL capture dump.
	/// Shape matches player-side OplCaptureDump.
	/// </summary>
	public sealed class AdpOplCaptureDumpResponse {
		public required bool IsCapturing { get; init; }
		public required int EventCount { get; init; }
		public required int ReturnedEventCount { get; init; }
		public required int Offset { get; init; }
		public required int Limit { get; init; }
		public required int DroppedEvents { get; init; }
		public required DateTimeOffset StartedUtc { get; init; }
		public DateTimeOffset? StoppedUtc { get; init; }
		public required IReadOnlyList<OplCaptureEvent> Events { get; init; }
	}

	/// <summary>
	/// Returns call counts for all observed DNADP entry points and internal functions.
	/// </summary>
	[McpServerTool(Name = "cryogenic_adp_call_counts", UseStructuredContent = true)]
	public static AdpCallCountsResponse AdpCallCounts() {
		Logger.Information("MCP tool invoked: cryogenic_adp_call_counts");
		lock (AdpCallCounterLock) {
			return new AdpCallCountsResponse {
				Entries = new Dictionary<string, int>(AdpCallCounters, StringComparer.Ordinal),
				LastSongSegment = AdpLastSongSegment,
				LastSongOffset = AdpLastSongOffset,
				LastMeasure = AdpLastMeasure,
				LastSubdivision = AdpLastSubdivision
			};
		}
	}

	/// <summary>
	/// Resets all DNADP call counters to zero.
	/// </summary>
	[McpServerTool(Name = "cryogenic_adp_reset_call_counts", UseStructuredContent = true)]
	public static string AdpResetCallCounts() {
		Logger.Information("MCP tool invoked: cryogenic_adp_reset_call_counts");
		lock (AdpCallCounterLock) {
			AdpCallCounters.Clear();
			AdpLastSongSegment = 0;
			AdpLastSongOffset = 0;
			AdpLastMeasure = 0;
			AdpLastSubdivision = 0;
		}
		return "DNADP call counters reset.";
	}

	/// <summary>
	/// Starts capturing OPL register writes from the DNADP driver.
	/// </summary>
	[McpServerTool(Name = "cryogenic_adp_opl_capture_start", UseStructuredContent = true)]
	public static string AdpOplCaptureStart(
		[Description("Maximum OPL write events to capture before dropping. Default 50000.")]
		int maxEvents = 50000) {
		Logger.Information("MCP tool invoked: cryogenic_adp_opl_capture_start maxEvents={MaxEvents}", maxEvents);
		lock (AdpOplCaptureLock) {
			AdpOplCaptureEvents.Clear();
			AdpOplCaptureDroppedEvents = 0;
			AdpOplCaptureSequence = 0;
			AdpOplCaptureMaxEvents = maxEvents;
			AdpOplCaptureStartTimestamp = Stopwatch.GetTimestamp();
			AdpOplCaptureStartedUtc = DateTimeOffset.UtcNow;
			AdpOplCaptureStoppedUtc = null;
			AdpOplCaptureEnabled = true;
		}
		return $"DNADP OPL capture started. Max events: {maxEvents}";
	}

	/// <summary>
	/// Stops the DNADP OPL capture.
	/// </summary>
	[McpServerTool(Name = "cryogenic_adp_opl_capture_stop", UseStructuredContent = true)]
	public static string AdpOplCaptureStop() {
		Logger.Information("MCP tool invoked: cryogenic_adp_opl_capture_stop");
		lock (AdpOplCaptureLock) {
			AdpOplCaptureEnabled = false;
			AdpOplCaptureStoppedUtc = DateTimeOffset.UtcNow;
		}
		return "DNADP OPL capture stopped.";
	}

	/// <summary>
	/// Resets the DNADP OPL capture buffer.
	/// </summary>
	[McpServerTool(Name = "cryogenic_adp_opl_capture_reset", UseStructuredContent = true)]
	public static string AdpOplCaptureReset() {
		Logger.Information("MCP tool invoked: cryogenic_adp_opl_capture_reset");
		lock (AdpOplCaptureLock) {
			AdpOplCaptureEnabled = false;
			AdpOplCaptureEvents.Clear();
			AdpOplCaptureDroppedEvents = 0;
			AdpOplCaptureSequence = 0;
			AdpOplCaptureStoppedUtc = null;
		}
		return "DNADP OPL capture buffer reset.";
	}

	/// <summary>
	/// Dumps captured DNADP OPL register writes with timeline context.
	/// </summary>
	[McpServerTool(Name = "cryogenic_adp_opl_capture_dump", UseStructuredContent = true)]
	public static AdpOplCaptureDumpResponse AdpOplCaptureDump(
		[Description("Number of events to return from the start. Default 500.")]
		int take = 500) {
		Logger.Information("MCP tool invoked: cryogenic_adp_opl_capture_dump take={Take}", take);
		lock (AdpOplCaptureLock) {
			int count = Math.Min(take, AdpOplCaptureEvents.Count);
			List<OplCaptureEvent> page = AdpOplCaptureEvents.Take(count).ToList();
			return new AdpOplCaptureDumpResponse {
				IsCapturing = AdpOplCaptureEnabled,
				EventCount = AdpOplCaptureEvents.Count,
				ReturnedEventCount = page.Count,
				Offset = 0,
				Limit = take,
				DroppedEvents = AdpOplCaptureDroppedEvents,
				StartedUtc = AdpOplCaptureStartedUtc,
				StoppedUtc = AdpOplCaptureStoppedUtc,
				Events = page
			};
		}
	}
}