namespace Cryogenic.Mt32DriverDebug;

/// <summary>
/// Abstraction over the in-memory state of any Dune music driver (DNMID or DNADP).
/// Both drivers share the same game-level contract (7 export entries, 9 channels,
/// song position, volume/fade, and per-channel tick/event arrays) but place their
/// internal fields at different CS-relative offsets.
/// </summary>
public interface IMusicDriverState {
	// ── Identity ──

	/// <summary>Which driver variant is loaded.</summary>
	MusicDriverType DriverType { get; }

	/// <summary>Human-readable name for the driver (e.g. "DNMID (MT-32)" or "DNADP (AdLib)").</summary>
	string DriverName { get; }

	// ── Song/Stream Pointers ──

	/// <summary>Song stream offset (far pointer low word).</summary>
	ushort SongStreamOffset { get; }

	/// <summary>Song stream segment (far pointer high word).</summary>
	ushort SongStreamSegment { get; }

	/// <summary>Event stream offset (far pointer low word).</summary>
	ushort EventStreamOffset { get; }

	/// <summary>Event stream segment (far pointer high word).</summary>
	ushort EventStreamSegment { get; }

	// ── Timing ──

	/// <summary>Timer accumulator for tick timing.</summary>
	ushort TimerAccumulator { get; }

	/// <summary>Timer low byte, decremented each tick entry.</summary>
	byte TimerLow { get; }

	/// <summary>Current song measure (1-based).</summary>
	ushort Measure { get; }

	/// <summary>Current song subdivision (counts down from 0x60 per measure).</summary>
	ushort Subdivision { get; }

	/// <summary>Remaining loop repeat counter.</summary>
	ushort RepeatCounter { get; }

	// ── I/O Configuration ──

	/// <summary>Base I/O port for the driver (MIDI port for DNMID, OPL port for DNADP).</summary>
	ushort BasePort { get; }

	/// <summary>I/O delay value (DNMID only; ADP returns 0).</summary>
	ushort IoDelay { get; }

	/// <summary>Label for the base port field (e.g. "MIDI Port" or "OPL Port").</summary>
	string BasePortLabel { get; }

	// ── Status ──

	/// <summary>Driver status flags byte. Bit 7: playing, Bit 6: fade active.</summary>
	byte StatusFlags { get; }

	/// <summary>Whether the driver is actively playing (status bit 7 set).</summary>
	bool IsPlaying { get; }

	/// <summary>Whether a fade operation is active (status bit 6 set).</summary>
	bool IsFading { get; }

	/// <summary>Tick enable flag.</summary>
	byte TickFlag { get; }

	/// <summary>Fade bit-rotation pattern (16-bit, ROL'd each tick).</summary>
	ushort FadeBitPattern { get; }

	// ── Volume ──

	/// <summary>Current effective volume.</summary>
	byte CurrentVolume { get; }

	/// <summary>Target volume for fade convergence.</summary>
	byte TargetVolume { get; }

	/// <summary>Master volume set by game.</summary>
	byte MasterVolume { get; }

	// ── Channel Info ──

	/// <summary>Number of active channels in the current song (conceptual, may be fixed 9 for ADP).</summary>
	int ActiveChannelCount { get; }

	/// <summary>Maximum channels this driver supports.</summary>
	int MaxChannels { get; }

	/// <summary>Number of volume slots for per-channel base volumes.</summary>
	int MaxBaseVolumeChannels { get; }

	/// <summary>Reads the tick counter for the given channel index (0-based).</summary>
	ushort GetChannelTickCounter(int channelIndex);

	/// <summary>Reads the event stream pointer for the given channel index (0-based).</summary>
	ushort GetChannelEventPointer(int channelIndex);

	/// <summary>Reads the original stream start offset for the given channel (0-based).</summary>
	ushort GetChannelStartOffset(int channelIndex);

	/// <summary>Reads the snapshot (saved) wait counter for loop restore.</summary>
	ushort GetSnapshotWait(int channelIndex);

	/// <summary>Reads the snapshot (saved) event pointer for loop restore.</summary>
	ushort GetSnapshotPointer(int channelIndex);

	/// <summary>Reads the base volume for the given channel (0-based).</summary>
	byte GetChannelBaseVolume(int channelIndex);

	// ── File Extension Patch ──

	/// <summary>First byte of the 3-byte file extension patch.</summary>
	byte ExtensionPatchByte0 { get; }

	/// <summary>Second byte of the file extension patch.</summary>
	byte ExtensionPatchByte1 { get; }

	/// <summary>Third byte of the file extension patch.</summary>
	byte ExtensionPatchByte2 { get; }

	// ── Song Header Cache ──

	/// <summary>Cached Song SI from last Open call.</summary>
	ushort HeaderSongSI { get; }

	/// <summary>Cached Song ES from last Open call.</summary>
	ushort HeaderSongES { get; }

	/// <summary>Cached marker 0 value.</summary>
	ushort HeaderMarker0 { get; }

	/// <summary>Cached marker 1 value.</summary>
	ushort HeaderMarker1 { get; }

	/// <summary>Cached marker 2 value.</summary>
	ushort HeaderMarker2 { get; }

	// ── Export Table ──

	/// <summary>Number of export table entries.</summary>
	int ExportEntryCount { get; }

	/// <summary>Export function name for the given entry index.</summary>
	string GetExportName(int entryIndex);

	/// <summary>Reads the JMP target word at the given export entry.</summary>
	ushort GetExportJumpTarget(int entryIndex);

	/// <summary>Reads the opcode byte at the given export entry.</summary>
	byte GetExportOpcode(int entryIndex);

	// ── Raw Memory Access ──

	/// <summary>Reads a raw byte at the given CS-relative offset.</summary>
	byte GetRawByte(uint offset);
}

/// <summary>
/// Identifies which music driver variant is loaded.
/// Determined at startup from the <c>-a</c> (ExeArgs) command-line argument prefix.
/// </summary>
public enum MusicDriverType {
	/// <summary>No music driver detected (no <c>-a</c> argument or unrecognized prefix).</summary>
	None,

	/// <summary>DNMID — MT-32 / General MIDI driver (prefix "MID").</summary>
	Dnmid,

	/// <summary>DNADP — AdLib Pro / Sound Blaster Pro OPL driver (prefix "ADP").</summary>
	Dnadp,

	/// <summary>DNADG — AdLib Gold OPL3 driver with surround (prefix "ADG").</summary>
	Dnadg,

	/// <summary>DNADL — Standard AdLib OPL2 driver (prefix "ADL").</summary>
	Dnadl
}

/// <summary>
/// Parses the <c>-a</c> (ExeArgs) command-line value to determine the active music driver.
/// </summary>
public static class MusicDriverDetection {
	/// <summary>
	/// Determines the <see cref="MusicDriverType"/> from the first token of the ExeArgs string.
	/// The game uses prefixes: MID (MT-32), ADP (AdLib Pro), ADG (AdLib Gold), ADL (AdLib).
	/// </summary>
	/// <param name="exeArgs">The value of <c>Configuration.ExeArgs</c>, e.g. "ADP330 SBP2227".</param>
	/// <returns>The detected driver type, or <see cref="MusicDriverType.None"/> if unrecognized.</returns>
	public static MusicDriverType DetectFromExeArgs(string exeArgs) {
		if (string.IsNullOrWhiteSpace(exeArgs)) {
			return MusicDriverType.None;
		}

		string firstToken = exeArgs.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
		string prefix = firstToken.Length >= 3 ? firstToken[..3].ToUpperInvariant() : firstToken.ToUpperInvariant();

		return prefix switch {
			"MID" => MusicDriverType.Dnmid,
			"ADP" => MusicDriverType.Dnadp,
			"ADG" => MusicDriverType.Dnadg,
			"ADL" => MusicDriverType.Dnadl,
			_ => MusicDriverType.None
		};
	}

	/// <summary>
	/// Returns <see langword="true"/> if the driver type uses OPL/FM synthesis (AdLib family).
	/// </summary>
	public static bool IsOplDriver(MusicDriverType driverType) {
		return driverType is MusicDriverType.Dnadp or MusicDriverType.Dnadg or MusicDriverType.Dnadl;
	}
}