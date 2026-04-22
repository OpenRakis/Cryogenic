namespace Cryogenic.Mt32DriverDebug;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Memory-mapped view of the DNMID MT-32 driver state at its live segment.
/// All offsets are CS-relative within the driver image loaded at segment 0x5BAE.
/// </summary>
/// <remarks>
/// <para>Export table layout (offset 0000):</para>
/// <code>
/// 0000: jmp 01CB (init)   0003: jmp 0250 (open)   0006: jmp 01E1 (reset)
/// 0009: jmp 023B (tick)   000C: jmp 01EE (vel)    000F: jmp 030F (tick)
/// 0012: jmp 022B (vol)
/// </code>
/// <para>Driver state fields (CS-relative):</para>
/// <list type="bullet">
/// <item><description>0x0115..0x0118: song stream far pointer (offset, segment)</description></item>
/// <item><description>0x0119..0x011C: event stream far pointer (offset, segment)</description></item>
/// <item><description>0x011D: timer accumulator</description></item>
/// <item><description>0x011F: current measure</description></item>
/// <item><description>0x0121: current subdivision</description></item>
/// <item><description>0x0123: repeat counter</description></item>
/// <item><description>0x0125: MIDI base port</description></item>
/// <item><description>0x0127: I/O delay</description></item>
/// <item><description>0x0139: status flags</description></item>
/// <item><description>0x013A: tick flag</description></item>
/// <item><description>0x013B: fade bit pattern (word)</description></item>
/// <item><description>0x013D: current volume</description></item>
/// <item><description>0x013E: target volume</description></item>
/// <item><description>0x013F: master volume</description></item>
/// <item><description>0x0140: active channel count</description></item>
/// <item><description>0x0142..0x0159: per-channel tick counters (9 words, stride 2)</description></item>
/// <item><description>0x0154..0x016B: per-channel event pointers (tick+0x12 each)</description></item>
/// <item><description>0x0166..0x017D: per-channel start offsets (9 words)</description></item>
/// <item><description>0x0178..0x018F: per-channel snapshot wait (loop restore, 9 words)</description></item>
/// <item><description>0x0193..0x01AA: per-channel snapshot pointer (loop restore, 9 words)</description></item>
/// <item><description>0x019C..0x01A5: per-channel base volumes (10 bytes)</description></item>
/// <item><description>0x01A5..0x01A7: file extension patch bytes (.M32)</description></item>
/// <item><description>0x0246..0x024F: song header cache (SI, ES, markers)</description></item>
/// </list>
/// </remarks>
public sealed class DnmidDriverState : MemoryBasedDataStructure, IMusicDriverState {
	private const int ExportCount = 7;
	private const int ChannelCount = 9;
	private const int BaseVolumeCount = 10;

	/// <summary>Stride between export entries (3 bytes per JMP SHORT).</summary>
	private const int ExportStride = 3;

	/// <summary>Offset from channel tick base to event pointer for the same channel.</summary>
	private const ushort ChannelPointerOffset = 0x12;

	/// <summary>
	/// Initializes a new instance backed by emulator memory at the given physical base address.
	/// </summary>
	/// <param name="memory">Emulated memory reader/writer.</param>
	/// <param name="driverSegment">The segment where the DNMID driver is loaded (e.g. 0x5BAE).</param>
	public DnmidDriverState(IByteReaderWriter memory, ushort driverSegment)
		: base(memory, (uint)driverSegment << 4) {
	}

	// ── Identity (IMusicDriverState) ──

	/// <inheritdoc />
	public MusicDriverType DriverType => MusicDriverType.Dnmid;

	/// <inheritdoc />
	public string DriverName => "DNMID (MT-32)";

	// ── Song/Stream Pointers ──

	/// <summary>Song stream offset (far pointer low word).</summary>
	public ushort SongStreamOffset => UInt16[0x0115];

	/// <summary>Song stream segment (far pointer high word).</summary>
	public ushort SongStreamSegment => UInt16[0x0117];

	/// <summary>Event stream offset (far pointer low word).</summary>
	public ushort EventStreamOffset => UInt16[0x0119];

	/// <summary>Event stream segment (far pointer high word).</summary>
	public ushort EventStreamSegment => UInt16[0x011B];

	// ── Timing ──

	/// <summary>Timer accumulator for tick timing.</summary>
	public ushort TimerAccumulator => UInt16[0x011D];

	/// <summary>Timer low byte, decremented each tick entry.</summary>
	public byte TimerLow => UInt8[0x011E];

	/// <summary>Current song measure (1-based).</summary>
	public ushort Measure => UInt16[0x011F];

	/// <summary>Current song subdivision (counts down from 0x60 per measure).</summary>
	public ushort Subdivision => UInt16[0x0121];

	/// <summary>Remaining loop repeat counter.</summary>
	public ushort RepeatCounter => UInt16[0x0123];

	// ── MIDI Configuration ──

	/// <summary>MPU-401 MIDI base I/O port (typically 0x330).</summary>
	public ushort MidiBasePort => UInt16[0x0125];

	/// <inheritdoc />
	public ushort BasePort => MidiBasePort;

	/// <inheritdoc />
	public string BasePortLabel => "MIDI Port";

	/// <summary>I/O settle delay value.</summary>
	public ushort IoDelay => UInt16[0x0127];

	// ── Status ──

	/// <summary>
	/// Driver status flags byte.
	/// Bit 7: playing, Bit 6: fade active.
	/// </summary>
	public byte StatusFlags => UInt8[0x0139];

	/// <summary>Whether the driver is actively playing (status bit 7 set).</summary>
	public bool IsPlaying => (StatusFlags & 0x80) != 0;

	/// <summary>Whether a fade operation is active (status bit 6 set).</summary>
	public bool IsFading => (StatusFlags & 0x40) != 0;

	/// <summary>Tick enable flag (set by game, consumed by driver each scheduler pass).</summary>
	public byte TickFlag => UInt8[0x013A];

	/// <summary>Fade bit-rotation pattern (16-bit, ROL'd each tick).</summary>
	public ushort FadeBitPattern => UInt16[0x013B];

	// ── Volume ──

	/// <summary>Current effective volume (0..127).</summary>
	public byte CurrentVolume => UInt8[0x013D];

	/// <summary>Target volume for fade convergence (0..127).</summary>
	public byte TargetVolume => UInt8[0x013E];

	/// <summary>Master volume set by game (0..127).</summary>
	public byte MasterVolume => UInt8[0x013F];

	// ── Channel Counts ──

	/// <summary>Number of active channels in the current song.</summary>
	public int ActiveChannelCount => UInt16[0x0140];

	/// <inheritdoc />
	public int MaxChannels => ChannelCount;

	/// <inheritdoc />
	public int MaxBaseVolumeChannels => BaseVolumeCount;

	// ── Per-Channel Arrays: Tick Counters ──

	/// <summary>
	/// Reads the tick counter for the given channel index (0-based).
	/// Returns 0xFFFF when the channel has reached end-of-stream.
	/// </summary>
	/// <param name="channelIndex">Channel index (0..8).</param>
	/// <returns>Current tick wait value for the channel.</returns>
	public ushort GetChannelTickCounter(int channelIndex) {
		return UInt16[(uint)(0x0142 + channelIndex * 2)];
	}

	/// <summary>
	/// Reads the event stream pointer for the given channel index (0-based).
	/// </summary>
	/// <param name="channelIndex">Channel index (0..8).</param>
	/// <returns>Current event stream offset for the channel.</returns>
	public ushort GetChannelEventPointer(int channelIndex) {
		return UInt16[(uint)(0x0142 + channelIndex * 2 + ChannelPointerOffset)];
	}

	/// <summary>
	/// Reads the original stream start offset for the given channel (0-based).
	/// Set at song open from the file header.
	/// </summary>
	/// <param name="channelIndex">Channel index (0..8).</param>
	/// <returns>Normalized start offset for the channel.</returns>
	public ushort GetChannelStartOffset(int channelIndex) {
		return UInt16[(uint)(0x0166 + channelIndex * 2)];
	}

	// ── Per-Channel Arrays: Loop Snapshots ──

	/// <summary>
	/// Reads the snapshot (saved) wait counter for loop restore.
	/// </summary>
	/// <param name="channelIndex">Channel index (0..8).</param>
	/// <returns>Saved tick wait for loop restore.</returns>
	public ushort GetSnapshotWait(int channelIndex) {
		return UInt16[(uint)(0x0178 + channelIndex * 2)];
	}

	/// <summary>
	/// Reads the snapshot (saved) event pointer for loop restore.
	/// </summary>
	/// <param name="channelIndex">Channel index (0..8).</param>
	/// <returns>Saved event pointer for loop restore.</returns>
	public ushort GetSnapshotPointer(int channelIndex) {
		return UInt16[(uint)(0x0193 + channelIndex * 2)];
	}

	// ── Per-Channel: Base Volumes ──

	/// <summary>
	/// Reads the base volume for the given MIDI channel (0-based, up to 10).
	/// Used for CC7 volume scaling during fade.
	/// </summary>
	/// <param name="channelIndex">Channel index (0..9).</param>
	/// <returns>Base volume byte (0..127).</returns>
	public byte GetChannelBaseVolume(int channelIndex) {
		return UInt8[(uint)(0x019C + channelIndex)];
	}

	// ── File Extension Patch ──

	/// <summary>First byte of the 3-byte file extension patch (.M32 suffix).</summary>
	public byte ExtensionPatchByte0 => UInt8[0x01A5];

	/// <summary>Second byte of the file extension patch.</summary>
	public byte ExtensionPatchByte1 => UInt8[0x01A6];

	/// <summary>Third byte of the file extension patch.</summary>
	public byte ExtensionPatchByte2 => UInt8[0x01A7];

	// ── Song Header Cache (populated at Open) ──

	/// <summary>Cached Song SI (file offset base) from last MidiOpen call.</summary>
	public ushort HeaderSongSI => UInt16[0x0246];

	/// <summary>Cached Song ES (segment) from last MidiOpen call.</summary>
	public ushort HeaderSongES => UInt16[0x0248];

	/// <summary>Cached marker 0 value [ES:SI].</summary>
	public ushort HeaderMarker0 => UInt16[0x024A];

	/// <summary>Cached marker 1 value [ES:SI+0x4000].</summary>
	public ushort HeaderMarker1 => UInt16[0x024C];

	/// <summary>Cached marker 2 value [ES:SI-0x8000].</summary>
	public ushort HeaderMarker2 => UInt16[0x024E];

	// ── Export Table ──

	private static readonly string[] ExportNames = [
		"MidiInit", "MidiOpen", "MidiReset",
		"MidiSetTimerTickFlag", "MidiSetVelocityMapping",
		"MidiTick", "MidiSetVolume"
	];

	/// <inheritdoc />
	public int ExportEntryCount => ExportCount;

	/// <inheritdoc />
	public string GetExportName(int entryIndex) {
		return entryIndex < ExportNames.Length ? ExportNames[entryIndex] : $"Export{entryIndex}";
	}

	/// <summary>
	/// Reads a raw byte from the export table region (offset 0x0000..0x0014).
	/// Each entry is a 3-byte JMP SHORT instruction.
	/// </summary>
	/// <param name="entryIndex">Export entry index (0..6).</param>
	/// <returns>The JMP target word at that entry.</returns>
	public ushort GetExportJumpTarget(int entryIndex) {
		return UInt16[(uint)(entryIndex * ExportStride + 1)];
	}

	/// <summary>
	/// Reads the opcode byte at the given export entry (should be 0xE9 for JMP near).
	/// </summary>
	/// <param name="entryIndex">Export entry index (0..6).</param>
	/// <returns>Opcode byte.</returns>
	public byte GetExportOpcode(int entryIndex) {
		return UInt8[(uint)(entryIndex * ExportStride)];
	}

	// ── Raw Memory Access ──

	/// <summary>
	/// Reads a raw byte at the given CS-relative offset. For hex dump views.
	/// </summary>
	/// <param name="offset">CS-relative offset.</param>
	/// <returns>Raw byte value.</returns>
	public byte GetRawByte(uint offset) {
		return UInt8[offset];
	}

	/// <summary>
	/// Reads a raw word (16-bit) at the given CS-relative offset.
	/// </summary>
	/// <param name="offset">CS-relative offset.</param>
	/// <returns>Raw word value.</returns>
	public ushort GetRawWord(uint offset) {
		return UInt16[offset];
	}
}