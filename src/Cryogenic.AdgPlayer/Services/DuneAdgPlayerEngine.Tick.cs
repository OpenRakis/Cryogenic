namespace Cryogenic.AdgPlayer.Services;

using Cryogenic.AdgPlayer.Driver;

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
	/// Advances the engine by one scheduler tick. Decrements each
	/// channel's wait counter (saturating at zero) and increments
	/// <see cref="TickCount"/>. Returns <c>true</c> when at least
	/// one channel is still active (non-zero pointer); <c>false</c>
	/// when every channel has reached its end-of-stream sentinel
	/// (signalling end-of-song).
	/// </summary>
	public bool Tick() {
		if (!HasSongLoaded) {
			throw new InvalidOperationException("No song loaded.");
		}
		_tickCount++;

		bool anyActive = false;
		int channelsToScan = Math.Min(AdgSongHeader_ChannelCount, AdgDriverState.ChannelCount);
		for (int i = 0; i < channelsToScan; i++) {
			ushort pointer = _state.EventPointers.Get(i);
			if (pointer == 0) {
				continue;
			}
			anyActive = true;
			ushort wait = _state.WaitCounters.Get(i);
			if (wait > 0) {
				_state.WaitCounters.Set(i, (ushort)(wait - 1));
			}
		}

		if (!anyActive) {
			IsPlaying = false;
		}
		return anyActive;
	}

	/// <summary>Mirrors <see cref="Cryogenic.AdgPlayer.Song.AdgSongHeader.ChannelCount"/> without taking a Song-namespace dependency in this file.</summary>
	private const int AdgSongHeader_ChannelCount = 9;
}