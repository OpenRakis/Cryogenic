namespace Cryogenic.Mt32DriverDebug;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Memory-mapped view of the DNADP (AdLib Pro / OPL) driver state at its live segment.
/// All offsets are CS-relative within the driver image loaded at its segment.
/// </summary>
/// <remarks>
/// <para>Export table layout (offset 0x0000), same structure as DNMID:</para>
/// <code>
/// 0100: jmp Init         0103: jmp Open         0106: jmp Reset
/// 0109: jmp SetTickFlag  010C: jmp SetDynamics  010F: jmp Tick
/// 0112: jmp SetVolume
/// </code>
/// <para>Key state fields (CS-relative):</para>
/// <list type="bullet">
/// <item><description>0x0115..0x0118: song stream far pointer (shared with DNMID)</description></item>
/// <item><description>0x0119..0x011C: event stream far pointer (shared with DNMID)</description></item>
/// <item><description>0x011D: timer accumulator (shared)</description></item>
/// <item><description>0x011F: current measure (shared)</description></item>
/// <item><description>0x0121: current subdivision (shared)</description></item>
/// <item><description>0x0123: repeat counter (shared)</description></item>
/// <item><description>0x019A: status flags</description></item>
/// <item><description>0x019B: tick flag</description></item>
/// <item><description>0x019C: current volume</description></item>
/// <item><description>0x019D: target volume</description></item>
/// <item><description>0x019E: master volume</description></item>
/// <item><description>0x019F: fade bit pattern (word)</description></item>
/// <item><description>0x01A2: channel table base (9 words, stride 2)</description></item>
/// <item><description>0x02B0: extension patch bytes (.ADP)</description></item>
/// <item><description>0x02B3: OPL base port</description></item>
/// <item><description>0x03A8..0x03B0: song header cache</description></item>
/// </list>
/// </remarks>
public sealed class AdpDriverState : MemoryBasedDataStructure, IMusicDriverState {
	private const int ExportCount = 7;
	private const int ChannelCount = 9;
	private const int ExportStride = 3;
	private const ushort ChannelTableBase = 0x01A2;
	private const ushort ChannelPointerOffset = 0x12;

	/// <summary>
	/// Initializes a new instance backed by emulator memory at the given physical base address.
	/// </summary>
	/// <param name="memory">Emulated memory reader/writer.</param>
	/// <param name="driverSegment">The segment where the DNADP driver is loaded.</param>
	public AdpDriverState(IByteReaderWriter memory, ushort driverSegment)
		: base(memory, (uint)driverSegment << 4) {
	}

	// ── Identity ──

	/// <inheritdoc />
	public MusicDriverType DriverType => MusicDriverType.Dnadp;

	/// <inheritdoc />
	public string DriverName => "DNADP (AdLib)";

	// ── Song/Stream Pointers (shared layout with DNMID) ──

	/// <inheritdoc />
	public ushort SongStreamOffset => UInt16[0x0115];

	/// <inheritdoc />
	public ushort SongStreamSegment => UInt16[0x0117];

	/// <inheritdoc />
	public ushort EventStreamOffset => UInt16[0x0119];

	/// <inheritdoc />
	public ushort EventStreamSegment => UInt16[0x011B];

	// ── Timing (shared layout) ──

	/// <inheritdoc />
	public ushort TimerAccumulator => UInt16[0x011D];

	/// <inheritdoc />
	public byte TimerLow => UInt8[0x011E];

	/// <inheritdoc />
	public ushort Measure => UInt16[0x011F];

	/// <inheritdoc />
	public ushort Subdivision => UInt16[0x0121];

	/// <inheritdoc />
	public ushort RepeatCounter => UInt16[0x0123];

	// ── I/O Configuration ──

	/// <inheritdoc />
	public ushort BasePort {
		get {
			ushort port = UInt16[0x02B3];
			return port == 0 ? (ushort)0x0388 : port;
		}
	}

	/// <inheritdoc />
	public string BasePortLabel => "OPL Port";

	/// <inheritdoc />
	public ushort IoDelay => 0;

	// ── Status ──

	/// <inheritdoc />
	public byte StatusFlags => UInt8[0x019A];

	/// <inheritdoc />
	public bool IsPlaying => (StatusFlags & 0x80) != 0;

	/// <inheritdoc />
	public bool IsFading => (StatusFlags & 0x40) != 0;

	/// <inheritdoc />
	public byte TickFlag => UInt8[0x019B];

	/// <inheritdoc />
	public ushort FadeBitPattern => UInt16[0x019F];

	// ── Volume ──

	/// <inheritdoc />
	public byte CurrentVolume => UInt8[0x019C];

	/// <inheritdoc />
	public byte TargetVolume => UInt8[0x019D];

	/// <inheritdoc />
	public byte MasterVolume => UInt8[0x019E];

	// ── Channel Info ──

	/// <inheritdoc />
	public int ActiveChannelCount => ChannelCount;

	/// <inheritdoc />
	public int MaxChannels => ChannelCount;

	/// <inheritdoc />
	public int MaxBaseVolumeChannels => ChannelCount;

	/// <inheritdoc />
	public ushort GetChannelTickCounter(int channelIndex) {
		return UInt16[(uint)(ChannelTableBase + channelIndex * 2)];
	}

	/// <inheritdoc />
	public ushort GetChannelEventPointer(int channelIndex) {
		return UInt16[(uint)(ChannelTableBase + channelIndex * 2 + ChannelPointerOffset)];
	}

	/// <inheritdoc />
	public ushort GetChannelStartOffset(int channelIndex) {
		return UInt16[(uint)(ChannelTableBase + 0x24 + channelIndex * 2)];
	}

	/// <inheritdoc />
	public ushort GetSnapshotWait(int channelIndex) {
		return UInt16[(uint)(ChannelTableBase + 0xEA + channelIndex * 2)];
	}

	/// <inheritdoc />
	public ushort GetSnapshotPointer(int channelIndex) {
		return UInt16[(uint)(ChannelTableBase + 0xEA + 0x12 + channelIndex * 2)];
	}

	/// <inheritdoc />
	public byte GetChannelBaseVolume(int channelIndex) {
		return 0;
	}

	// ── File Extension Patch ──

	/// <inheritdoc />
	public byte ExtensionPatchByte0 => UInt8[0x02B0];

	/// <inheritdoc />
	public byte ExtensionPatchByte1 => UInt8[0x02B1];

	/// <inheritdoc />
	public byte ExtensionPatchByte2 => UInt8[0x02B2];

	// ── Song Header Cache ──

	/// <inheritdoc />
	public ushort HeaderSongSI => UInt16[0x03A8];

	/// <inheritdoc />
	public ushort HeaderSongES => UInt16[0x03AA];

	/// <inheritdoc />
	public ushort HeaderMarker0 => UInt16[0x03AC];

	/// <inheritdoc />
	public ushort HeaderMarker1 => UInt16[0x03AE];

	/// <inheritdoc />
	public ushort HeaderMarker2 => UInt16[0x03B0];

	// ── Export Table ──

	private static readonly string[] ExportNames = [
		"AdpInit", "AdpOpen", "AdpReset",
		"AdpSetTickFlag", "AdpSetDynamics",
		"AdpTick", "AdpSetVolume"
	];

	/// <inheritdoc />
	public int ExportEntryCount => ExportCount;

	/// <inheritdoc />
	public string GetExportName(int entryIndex) {
		return entryIndex < ExportNames.Length ? ExportNames[entryIndex] : $"Export{entryIndex}";
	}

	/// <inheritdoc />
	public ushort GetExportJumpTarget(int entryIndex) {
		return UInt16[(uint)(entryIndex * ExportStride + 1)];
	}

	/// <inheritdoc />
	public byte GetExportOpcode(int entryIndex) {
		return UInt8[(uint)(entryIndex * ExportStride)];
	}

	// ── Raw Memory Access ──

	/// <inheritdoc />
	public byte GetRawByte(uint offset) {
		return UInt8[offset];
	}
}