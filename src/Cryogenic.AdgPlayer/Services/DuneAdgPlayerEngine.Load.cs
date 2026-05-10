namespace Cryogenic.AdgPlayer.Services;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Song;

using System;

/// <summary>
/// Engine load path: turns a raw / HSQ byte buffer into a parsed
/// song image and seeds the <see cref="AdgDriverState"/> with the
/// channel event pointers and per-channel wait counters expected
/// by the tick scheduler.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
	private AdgSongImage? _songImage;
	private AdgSongHeader? _songHeader;
	private AdgChannelPointers? _channelPointers;
	private readonly AdgDriverState _state = new();
	private readonly AdgSongLoader _loader = new();
	private readonly AdgSongHeaderParser _headerParser = new();

	/// <summary>Driver state aggregate (per-channel tables and singletons).</summary>
	public AdgDriverState State => _state;

	/// <summary>Currently loaded song image (null until <see cref="Load"/> succeeds).</summary>
	public AdgSongImage? SongImage => _songImage;

	/// <summary>Parsed header for the current song (null until <see cref="Load"/> succeeds).</summary>
	public AdgSongHeader? SongHeader => _songHeader;

	/// <summary>Resolved per-channel absolute offsets (null until <see cref="Load"/> succeeds).</summary>
	public AdgChannelPointers? ChannelPointers => _channelPointers;

	/// <summary>
	/// Loads a song from a raw byte buffer (HSQ-compressed or
	/// raw). On success: decompresses, parses the header, seeds
	/// the channel event pointers in the driver state and marks
	/// the engine as song-loaded but stopped.
	/// </summary>
	public void Load(byte[] source) {
		ArgumentNullException.ThrowIfNull(source);
		AdgSongImage image = _loader.Load(source);
		AdgSongHeader header = _headerParser.Parse(image);
		AdgChannelPointers pointers = new(header);

		_state.Reset();
		int channelsToSeed = Math.Min(pointers.ChannelCount, AdgDriverState.ChannelCount);
		for (int i = 0; i < channelsToSeed; i++) {
			ushort absolute = pointers.GetAbsoluteOffset(i);
			_state.EventPointers.Set(i, absolute);
			// Inactive channels stay at wait-counter 0; active channels start at 1
			// so the first ProcessTick decrement triggers an immediate event read.
			_state.WaitCounters.Set(i, absolute == 0 ? (ushort)0 : (ushort)1);
		}

		// Mirrors AdgResetSchedulerState_06B9 (dnadg:0573 / dnadg:067A): seed
		// measure=1 and subdivision=0x60 so the per-tick subdivision decrement
		// rolls over correctly into measure increments.
		_state.MeasureClock.Initialize();

		_songImage = image;
		_songHeader = header;
		_channelPointers = pointers;
		_tickCount = 0;
		HasSongLoaded = true;
		IsPlaying = false;
	}

	/// <summary>
	/// Clears the loaded song and resets driver state.
	/// </summary>
	public void Unload() {
		_state.Reset();
		_songImage = null;
		_songHeader = null;
		_channelPointers = null;
		_tickCount = 0;
		HasSongLoaded = false;
		IsPlaying = false;
	}
}