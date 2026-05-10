namespace Cryogenic.AdgPlayer.Services;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Song;

using System;

/// <summary>
/// Engine tick scaffold. Decrements per-channel wait counters and
/// counts emitted ticks. Event dispatch (NoteOn / NoteOff / etc.)
/// is deliberately deferred to a future cycle gated on live MCP
/// runtime evidence — this scaffold only provides the cadence and
/// the boundaries needed to wire a host loop and a "playing → end
/// of song" lifecycle without making unverified claims about the
/// emitted register stream.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
	private long _tickCount;

	/// <summary>Number of <see cref="Tick"/> invocations since last <see cref="Load(byte[])"/> or <see cref="Unload"/>.</summary>
	public long TickCount => _tickCount;

	/// <summary>
	/// Marks playback as started. Throws when no song is loaded
	/// or playback is already running.
	/// </summary>
	public void Play() {
		if (!HasSongLoaded) {
			throw new InvalidOperationException("No song loaded.");
		}
		if (IsPlaying) {
			throw new InvalidOperationException("Already playing.");
		}
		IsPlaying = true;
	}

	/// <summary>Marks playback as stopped (idempotent).</summary>
	public void StopPlayback() {
		IsPlaying = false;
	}

	/// <summary>
	/// Advances the engine by one scheduler tick. For each channel:
	/// decrements its wait counter (saturating at zero), then — when
	/// the counter has reached zero and the pointer is still active —
	/// dispatches events from the stream until either a new wait is
	/// set or the channel reaches end-of-stream.
	/// Returns <c>true</c> when at least one channel is still active
	/// after the tick (non-zero pointer); <c>false</c> when every
	/// channel has reached its end-of-stream sentinel (signalling
	/// end-of-song).
	/// </summary>
	public bool Tick() {
		if (!HasSongLoaded) {
			throw new InvalidOperationException("No song loaded.");
		}
		_tickCount++;

		// Mirrors dnadg:077E — AdgCheckLoopPoint_07DA runs at the very
		// top of the scheduler tick, before the per-channel wait
		// decrement loop. It either snapshots channel state at the
		// loop-start measure or rewinds to it at the loop-end measure.
		if (_songHeader is AdgSongHeader header) {
			AdgLoopPointChecker.Check(
				header,
				_state.LoopState,
				_state.LoopSnapshotStore,
				_state.WaitCounters,
				_state.EventPointers);
		}

		int channelsToScan = AdgDriverState.ChannelCount;
		for (int i = 0; i < channelsToScan; i++) {
			ushort pointer = _state.EventPointers.Get(i);
			if (pointer == 0) {
				continue;
			}
			ushort wait = _state.WaitCounters.Get(i);
			if (wait > 0) {
				_state.WaitCounters.Set(i, (ushort)(wait - 1));
			}
			if (_state.WaitCounters.Get(i) == 0) {
				DispatchEvents(i);
			} else {
				// Mirrors dnadg:07AD: when the channel is still
				// waiting after the decrement, the scheduler
				// advances the per-channel pitch accumulator and
				// (if armed) emits a vibrato register write.
				AdgPitchModulationAdvancer.Advance(
					i,
					_state.PitchBendCounters,
					_state.EventPointers,
					_state.PitchAccumulators,
					_state.PitchAccumulatorSteps,
					_pitchBendBody);
			}
		}

		bool anyActive = false;
		for (int i = 0; i < channelsToScan; i++) {
			if (_state.EventPointers.Get(i) != 0) {
				anyActive = true;
				break;
			}
		}

		// Mirrors AdgSchedulerTick_0756 dnadg:079D-07A8: subdivision——;
		// when it rolls to zero, reload to 0x60 and advance the measure word.
		// This keeps Measure/Subdivision in sync with playback regardless of
		// channel activity, exactly as the original ISR does.
		_state.MeasureClock.AdvanceSubdivision();

		if (!anyActive) {
			IsPlaying = false;
		}
		return anyActive;
	}

	/// <summary>Mirrors <see cref="Cryogenic.AdgPlayer.Song.AdgSongHeader.ChannelCount"/> without taking a Song-namespace dependency in this file.</summary>
	private const int AdgSongHeader_ChannelCount = 9;
}