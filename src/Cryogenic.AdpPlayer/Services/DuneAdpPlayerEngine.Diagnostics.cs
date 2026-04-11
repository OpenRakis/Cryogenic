namespace Cryogenic.AdpPlayer.Services;

using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Diagnostics, golden capture, audio debug info, and snapshot emission
/// for the DNADP OPL2 player engine.
/// </summary>
public sealed partial class DuneAdpPlayerEngine {
	// Diagnostics fields
	private string _currentSongPath = "";
	private string _currentSongName = "";
	private string _songLayoutNote = "";
	private readonly string[] _lastEventPerChannel = new string[9];

	// Audio debug counters
	private int _totalEventsDecoded;
	private int _totalOplWrites;
	private int _eventResyncCount;
	private int _songPositionMismatchCount;
	private bool _lastSongPositionValid = true;
	private readonly int[] _eventTypeCounters = new int[8];
	private readonly int[] _oplRegisterCounters = new int[256];
	private readonly string[] _recentEvents = new string[32];
	private int _recentEventIndex;

	// Golden capture state
	private bool _isCapturing;
	private DateTimeOffset _captureStartedUtc;
	private DateTimeOffset? _captureStoppedUtc;
	private int _captureMaxEvents;
	private int _captureDroppedEvents;
	private int _captureSequence;
	private List<GoldenCaptureEvent> _captureBuffer = new();

	/// <summary>
	/// Tracks an OPL2 register write for debug counters.
	/// </summary>
	private void TrackOplWrite(byte register, byte data) {
		_totalEventsDecoded++;
		_totalOplWrites++;
		if (register < _oplRegisterCounters.Length) {
			_oplRegisterCounters[register]++;
		}
	}

	private void AddRecentEvent(string description) {
		int index = _recentEventIndex % _recentEvents.Length;
		_recentEvents[index] = $"[{_tickIndex}] {description}";
		_recentEventIndex++;
	}

	private void EmitSnapshot(int tickIndex) {
		double secondsPerTick = (double)PitReloadValue / PitInputClock;
		double elapsed = tickIndex * secondsPerTick;
		double estimatedDuration = 0;
		if (_tickIncrement > 0 && _endMeasure > 0) {
			double pitTicksPerSubdivision = _tickIncrement / 256.0;
			double subdivisionsPerMeasure = 0x60;
			double totalSubdivisions = _endMeasure * subdivisionsPerMeasure;
			estimatedDuration = totalSubdivisions * pitTicksPerSubdivision * secondsPerTick;
		}
		double progress = estimatedDuration > 0 ? Math.Clamp(elapsed / estimatedDuration, 0, 1) : 0;

		PlayerDiagnosticsSnapshot snapshot = new() {
			TickIndex = tickIndex,
			Measure = _measure,
			EndMeasure = _endMeasure,
			Subdivision = _subdivision,
			RepeatCounter = _repeatCounter,
			Accumulator = _accumulator,
			TickIncrement = _tickIncrement,
			ProcessTickCount = _processTickCount,
			ActiveChannelCount = _activeChannelCount,
			EventsDispatchedThisTick = 0,
			ElapsedSeconds = elapsed,
			EstimatedDurationSeconds = estimatedDuration,
			TimelineProgress = progress,
			AudioPeak = _synth.LastPeak,
			ChannelWait = (ushort[])_channelWait.Clone(),
			ChannelEventPointer = (ushort[])_channelEventPointer.Clone(),
			LastEventPerChannel = (string[])_lastEventPerChannel.Clone()
		};

		SnapshotProduced?.Invoke(snapshot);
	}

	/// <summary>
	/// Returns current audio debug state for the control server and UI.
	/// </summary>
	public AudioDebugInfo GetAudioDebugInfo() {
		string[] recent = new string[_recentEvents.Length];
		int count = Math.Min(_recentEventIndex, _recentEvents.Length);
		for (int i = 0; i < count; i++) {
			int idx = (_recentEventIndex - count + i) % _recentEvents.Length;
			recent[i] = _recentEvents[idx] ?? "";
		}
		for (int i = count; i < recent.Length; i++) {
			recent[i] = "";
		}

		return new AudioDebugInfo {
			SongDataLength = _songData.Length,
			SongHeaderOffset = SongDataOffset,
			SongDataOffset = SongDataOffset,
			SongLayoutNote = _songLayoutNote,
			SchedulerAccumulator = _accumulator,
			SongTickIncrement = _tickIncrement,
			FadeBitPattern = _fadeBitPattern,
			TickIndex = _tickIndex,
			Measure = _measure,
			EndMeasure = _endMeasure,
			Subdivision = _subdivision,
			TotalEventsDecoded = _totalEventsDecoded,
			TestNotesTriggered = 0,
			EventResyncCount = _eventResyncCount,
			LastSongPositionValid = _lastSongPositionValid,
			SongPositionMismatchCount = _songPositionMismatchCount,
			ChannelWaitSnapshot = (ushort[])_channelWait.Clone(),
			ChannelPointerSnapshot = (ushort[])_channelEventPointer.Clone(),
			EventTypeCounters = (int[])_eventTypeCounters.Clone(),
			OplRegisterCounters = (int[])_oplRegisterCounters.Clone(),
			RecentEvents = recent
		};
	}

	/// <summary>
	/// Resets all audio debug counters.
	/// </summary>
	public void ResetAudioDebug() {
		_totalEventsDecoded = 0;
		_totalOplWrites = 0;
		_eventResyncCount = 0;
		_songPositionMismatchCount = 0;
		_lastSongPositionValid = true;
		Array.Clear(_eventTypeCounters);
		Array.Clear(_oplRegisterCounters);
		Array.Clear(_recentEvents);
		_recentEventIndex = 0;
	}

	/// <summary>
	/// Starts golden capture, recording up to maxEvents OPL events.
	/// </summary>
	public GoldenCaptureDump StartGoldenCapture(int maxEvents) {
		_captureBuffer = new List<GoldenCaptureEvent>(Math.Min(maxEvents, 100000));
		_captureMaxEvents = maxEvents;
		_captureDroppedEvents = 0;
		_captureSequence = 0;
		_captureStartedUtc = DateTimeOffset.UtcNow;
		_captureStoppedUtc = null;
		_isCapturing = true;
		return BuildCaptureDump(0, maxEvents, "", "");
	}

	/// <summary>
	/// Stops golden capture and returns either a summary or full dump.
	/// </summary>
	public GoldenCaptureDump StopGoldenCapture(bool includeEvents) {
		_isCapturing = false;
		_captureStoppedUtc = DateTimeOffset.UtcNow;
		return BuildCaptureDump(0, includeEvents ? _captureBuffer.Count : 0, "", "");
	}

	/// <summary>
	/// Clears the golden capture buffer and returns an empty dump.
	/// </summary>
	public GoldenCaptureDump ResetGoldenCapture() {
		_captureBuffer.Clear();
		_captureDroppedEvents = 0;
		_captureSequence = 0;
		_isCapturing = false;
		_captureStoppedUtc = null;
		_captureStartedUtc = DateTimeOffset.UtcNow;
		return BuildCaptureDump(0, 0, "", "");
	}

	/// <summary>
	/// Returns summary statistics of the golden capture without full event list.
	/// </summary>
	public GoldenCaptureSummary GetGoldenCaptureSummary() {
		Dictionary<string, int> sourceHist = new();
		Dictionary<string, int> kindHist = new();
		foreach (GoldenCaptureEvent e in _captureBuffer) {
			sourceHist[e.Source] = sourceHist.GetValueOrDefault(e.Source) + 1;
			kindHist[e.EventKind] = kindHist.GetValueOrDefault(e.EventKind) + 1;
		}
		return new GoldenCaptureSummary {
			IsCapturing = _isCapturing,
			StartedUtc = _captureStartedUtc,
			StoppedUtc = _captureStoppedUtc,
			MaxEvents = _captureMaxEvents,
			EventCount = _captureBuffer.Count,
			DroppedEvents = _captureDroppedEvents,
			CurrentSongName = _currentSongName,
			CurrentSongPath = _currentSongPath,
			SourceHistogram = sourceHist,
			KindHistogram = kindHist
		};
	}

	/// <summary>
	/// Returns a paginated, filtered dump of golden capture events.
	/// </summary>
	public GoldenCaptureDump GetGoldenCaptureDump(int offset, int limit, string sourceFilter, string kindFilter) {
		return BuildCaptureDump(offset, limit, sourceFilter, kindFilter);
	}

	/// <summary>
	/// Returns OPL event analysis: kind histogram, signature hash, first N signatures.
	/// </summary>
	public GoldenCaptureDiagnostics GetGoldenCaptureDiagnostics(int sampleSize) {
		Dictionary<string, int> kindHist = new();
		int noteOnCount = 0;
		int noteOffCount = 0;
		int clampedSample = Math.Clamp(sampleSize, 1, 500);
		List<string> signatures = new();

		foreach (GoldenCaptureEvent e in _captureBuffer) {
			kindHist[e.EventKind] = kindHist.GetValueOrDefault(e.EventKind) + 1;

			if (string.Equals(e.EventKind, "NON", StringComparison.Ordinal)) {
				noteOnCount++;
			} else if (string.Equals(e.EventKind, "NOF", StringComparison.Ordinal)) {
				noteOffCount++;
			}

			if (signatures.Count < clampedSample) {
				signatures.Add($"{e.EventKind}:{e.OplRegister:X2}:{e.OplValue:X2}");
			}
		}

		string sigConcat = string.Join("|", signatures);
		byte[] hashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(sigConcat));
		string hash = Convert.ToHexString(hashBytes)[..16];

		return new GoldenCaptureDiagnostics {
			EventCount = _captureBuffer.Count,
			OplWriteCount = _totalOplWrites,
			NoteOnCount = noteOnCount,
			NoteOffCount = noteOffCount,
			EventKindHistogram = kindHist,
			SignatureHash = hash,
			FirstEventSignatures = signatures
		};
	}

	/// <summary>
	/// Records a high-level engine event into the golden capture buffer.
	/// Parameters map to GoldenCaptureEvent's OPL-centric fields:
	///   data1 → OplRegister, data2 → OplValue, channel → OplChannel
	/// </summary>
	private void RecordGoldenCaptureEvent(string source, string kind, byte data1, byte data2, byte channelByte, string eventKind, int channel, int delta) {
		if (!_isCapturing) {
			return;
		}
		if (_captureBuffer.Count >= _captureMaxEvents) {
			_captureDroppedEvents++;
			return;
		}

		GoldenCaptureEvent evt = new() {
			Sequence = _captureSequence++,
			Source = source,
			Kind = kind,
			ElapsedMilliseconds = (long)(_tickIndex * 1000.0 * PitReloadValue / PitInputClock),
			TickIndex = _tickIndex,
			Measure = _measure,
			Subdivision = _subdivision,
			RepeatCounter = _repeatCounter,
			TimelineTick = _tickIndex,
			OplRegister = data1,
			OplValue = data2,
			OplChannel = channel,
			EventKind = eventKind,
			StreamPointer = channel >= 0 && channel < _channelEventPointer.Length ? _channelEventPointer[channel] : -1,
			EventType = 0
		};
		_captureBuffer.Add(evt);
	}

	private GoldenCaptureDump BuildCaptureDump(int offset, int limit, string sourceFilter, string kindFilter) {
		IEnumerable<GoldenCaptureEvent> filtered = _captureBuffer;
		if (!string.IsNullOrEmpty(sourceFilter)) {
			filtered = filtered.Where(e => string.Equals(e.Source, sourceFilter, StringComparison.OrdinalIgnoreCase));
		}
		if (!string.IsNullOrEmpty(kindFilter)) {
			filtered = filtered.Where(e => string.Equals(e.Kind, kindFilter, StringComparison.OrdinalIgnoreCase));
		}

		List<GoldenCaptureEvent> filteredList = filtered.ToList();
		int clampedOffset = Math.Clamp(offset, 0, Math.Max(0, filteredList.Count - 1));
		int clampedLimit = Math.Clamp(limit, 0, 10000);
		List<GoldenCaptureEvent> page = filteredList.Skip(clampedOffset).Take(clampedLimit).ToList();

		return new GoldenCaptureDump {
			IsCapturing = _isCapturing,
			StartedUtc = _captureStartedUtc,
			StoppedUtc = _captureStoppedUtc,
			MaxEvents = _captureMaxEvents,
			EventCount = _captureBuffer.Count,
			ReturnedEventCount = page.Count,
			Offset = clampedOffset,
			Limit = clampedLimit,
			SourceFilter = sourceFilter ?? "",
			KindFilter = kindFilter ?? "",
			DroppedEvents = _captureDroppedEvents,
			CurrentSongName = _currentSongName,
			CurrentSongPath = _currentSongPath,
			Events = page
		};
	}
}