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

	// OPL golden capture state
	private bool _isCapturing;
	private DateTimeOffset _captureStartedUtc;
	private DateTimeOffset? _captureStoppedUtc;
	private int _captureMaxEvents;
	private int _captureDroppedEvents;
	private int _captureSequence;
	private long _captureStartTicks;
	private List<OplCaptureEvent> _captureBuffer = new();

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
	/// Starts OPL golden capture, recording up to maxEvents port I/O events.
	/// </summary>
	public OplCaptureDump StartGoldenCapture(int maxEvents) {
		_captureBuffer = new List<OplCaptureEvent>(Math.Min(maxEvents, 100000));
		_captureMaxEvents = maxEvents;
		_captureDroppedEvents = 0;
		_captureSequence = 0;
		_captureStartTicks = System.Diagnostics.Stopwatch.GetTimestamp();
		_captureStartedUtc = DateTimeOffset.UtcNow;
		_captureStoppedUtc = null;
		_isCapturing = true;
		return BuildCaptureDump(0, 0);
	}

	/// <summary>
	/// Stops OPL golden capture and returns either a summary or full dump.
	/// </summary>
	public OplCaptureDump StopGoldenCapture(bool includeEvents) {
		_isCapturing = false;
		_captureStoppedUtc = DateTimeOffset.UtcNow;
		return BuildCaptureDump(0, includeEvents ? _captureBuffer.Count : 0);
	}

	/// <summary>
	/// Clears the OPL golden capture buffer.
	/// </summary>
	public OplCaptureDump ResetGoldenCapture() {
		_captureBuffer.Clear();
		_captureDroppedEvents = 0;
		_captureSequence = 0;
		_isCapturing = false;
		_captureStoppedUtc = null;
		_captureStartedUtc = DateTimeOffset.UtcNow;
		return BuildCaptureDump(0, 0);
	}

	/// <summary>
	/// Returns summary statistics of the OPL capture session.
	/// </summary>
	public OplCaptureSummary GetGoldenCaptureSummary() {
		int regWriteCount = 0;
		int statusReadCount = 0;
		int audioSampleCount = 0;
		Dictionary<byte, int> regHist = new();
		Dictionary<int, int> chanHist = new();
		foreach (OplCaptureEvent e in _captureBuffer) {
			switch (e.Type) {
				case OplCaptureEventType.RegisterWrite:
					regWriteCount++;
					regHist[e.Register] = regHist.GetValueOrDefault(e.Register) + 1;
					if (e.Channel >= 0) {
						chanHist[e.Channel] = chanHist.GetValueOrDefault(e.Channel) + 1;
					}
					break;
				case OplCaptureEventType.StatusRead:
					statusReadCount++;
					break;
				case OplCaptureEventType.AudioSample:
					audioSampleCount++;
					break;
			}
		}
		return new OplCaptureSummary {
			IsCapturing = _isCapturing,
			StartedUtc = _captureStartedUtc,
			StoppedUtc = _captureStoppedUtc,
			MaxEvents = _captureMaxEvents,
			EventCount = _captureBuffer.Count,
			DroppedEvents = _captureDroppedEvents,
			CurrentSongName = _currentSongName,
			CurrentSongPath = _currentSongPath,
			RegisterWriteCount = regWriteCount,
			StatusReadCount = statusReadCount,
			AudioSampleCount = audioSampleCount,
			RegisterHistogram = regHist,
			ChannelHistogram = chanHist
		};
	}

	/// <summary>
	/// Returns a paginated dump of OPL capture events.
	/// </summary>
	public OplCaptureDump GetGoldenCaptureDump(int offset, int limit) {
		return BuildCaptureDump(offset, limit);
	}

	/// <summary>
	/// Returns OPL capture diagnostics with signature hash for cross-side comparison.
	/// </summary>
	public OplCaptureDiagnostics GetGoldenCaptureDiagnostics(int sampleSize) {
		Dictionary<byte, int> regHist = new();
		int regWriteCount = 0;
		int statusReadCount = 0;
		int clampedSample = Math.Clamp(sampleSize, 1, 500);
		List<string> signatures = new();

		foreach (OplCaptureEvent e in _captureBuffer) {
			if (e.Type == OplCaptureEventType.RegisterWrite) {
				regWriteCount++;
				regHist[e.Register] = regHist.GetValueOrDefault(e.Register) + 1;
			} else if (e.Type == OplCaptureEventType.StatusRead) {
				statusReadCount++;
			}

			if (signatures.Count < clampedSample) {
				signatures.Add($"{e.Type}:{e.Register:X2}:{e.Value:X2}");
			}
		}

		string sigConcat = string.Join("|", signatures);
		byte[] hashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(sigConcat));
		string hash = Convert.ToHexString(hashBytes)[..16];

		return new OplCaptureDiagnostics {
			EventCount = _captureBuffer.Count,
			RegisterWriteCount = regWriteCount,
			StatusReadCount = statusReadCount,
			RegisterHistogram = regHist,
			SignatureHash = hash,
			FirstEventSignatures = signatures
		};
	}

	/// <summary>
	/// Records an OPL register write into the capture buffer.
	/// Called from <see cref="Opl2Synth.WriteRegister"/> path.
	/// </summary>
	private void RecordOplRegisterWrite(byte register, byte value, int channel) {
		if (!_isCapturing) {
			return;
		}
		if (_captureBuffer.Count >= _captureMaxEvents) {
			_captureDroppedEvents++;
			return;
		}

		long elapsedTicks = System.Diagnostics.Stopwatch.GetTimestamp() - _captureStartTicks;
		long elapsedUs = elapsedTicks * 1_000_000 / System.Diagnostics.Stopwatch.Frequency;

		byte timerState = 0;
		if (register == 0x02 || register == 0x03 || register == 0x04) {
			timerState = value;
		}

		_captureBuffer.Add(new OplCaptureEvent {
			Sequence = _captureSequence++,
			Type = OplCaptureEventType.RegisterWrite,
			TimestampUs = elapsedUs,
			Port = 0x389,
			Register = register,
			Value = value,
			Channel = channel,
			Measure = _measure,
			Subdivision = _subdivision,
			TickIndex = _tickIndex,
			TimerState = timerState,
			AudioPeak = 0f
		});
	}

	/// <summary>
	/// Records a periodic audio sample snapshot into the capture buffer.
	/// </summary>
	private void RecordOplAudioSample(float peak) {
		if (!_isCapturing) {
			return;
		}
		if (_captureBuffer.Count >= _captureMaxEvents) {
			_captureDroppedEvents++;
			return;
		}

		long elapsedTicks = System.Diagnostics.Stopwatch.GetTimestamp() - _captureStartTicks;
		long elapsedUs = elapsedTicks * 1_000_000 / System.Diagnostics.Stopwatch.Frequency;

		_captureBuffer.Add(new OplCaptureEvent {
			Sequence = _captureSequence++,
			Type = OplCaptureEventType.AudioSample,
			TimestampUs = elapsedUs,
			Port = 0,
			Register = 0,
			Value = 0,
			Channel = -1,
			Measure = _measure,
			Subdivision = _subdivision,
			TickIndex = _tickIndex,
			TimerState = 0,
			AudioPeak = peak
		});
	}

	private OplCaptureDump BuildCaptureDump(int offset, int limit) {
		int clampedOffset = Math.Clamp(offset, 0, Math.Max(0, _captureBuffer.Count - 1));
		int clampedLimit = Math.Clamp(limit, 0, 10000);
		List<OplCaptureEvent> page = _captureBuffer.Skip(clampedOffset).Take(clampedLimit).ToList();

		return new OplCaptureDump {
			IsCapturing = _isCapturing,
			StartedUtc = _captureStartedUtc,
			StoppedUtc = _captureStoppedUtc,
			MaxEvents = _captureMaxEvents,
			EventCount = _captureBuffer.Count,
			ReturnedEventCount = page.Count,
			Offset = clampedOffset,
			Limit = clampedLimit,
			DroppedEvents = _captureDroppedEvents,
			CurrentSongName = _currentSongName,
			CurrentSongPath = _currentSongPath,
			Events = page
		};
	}
}