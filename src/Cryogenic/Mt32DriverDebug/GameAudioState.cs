namespace Cryogenic.Mt32DriverDebug;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Memory-mapped view of game-level audio globals stored in the DS segment.
/// Uses a fixed DS base segment (0x1138, physical 0x11380) matching the generated GlobalsOnDs.
/// </summary>
/// <remarks>
/// <para>These are game-side state values, not DNMID driver-internal state.</para>
/// <list type="bullet">
/// <item><description>DS:0x2944 — cmdArgsAudio: audio driver mode selection byte</description></item>
/// <item><description>DS:0x39B3 — cmdArgMidi: MIDI configuration word</description></item>
/// <item><description>DS:0x39B7 — allocatorNextFreeOffset: memory allocator next free (dword ptr)</description></item>
/// <item><description>DS:0xCE68 — allocatorLastFreeSegment: allocator ceiling segment</description></item>
/// <item><description>DS:0xDBCD — IsSoundPresent: sound hardware detected flag</description></item>
/// <item><description>DS:0xDBCE — midiFunc5returnBx: MIDI init function return value</description></item>
/// </list>
/// </remarks>
public sealed class GameAudioState : MemoryBasedDataStructure {
	/// <summary>The DS segment value used by the game (0x1138).</summary>
	public const ushort GameDsSegment = 0x1138;

	/// <summary>
	/// Initializes a new instance backed by emulator memory at the DS physical base.
	/// </summary>
	/// <param name="memory">Emulated memory reader/writer.</param>
	public GameAudioState(IByteReaderWriter memory)
		: base(memory, (uint)GameDsSegment << 4) {
	}

	/// <summary>Audio driver mode selection byte (DS:0x2944).</summary>
	public byte CmdArgsAudio => UInt8[0x2944];

	/// <summary>MIDI configuration word (DS:0x39B3).</summary>
	public ushort CmdArgMidi => UInt16[0x39B3];

	/// <summary>Sound hardware detected flag (DS:0xDBCD). Non-zero = present.</summary>
	public byte IsSoundPresent => UInt8[0xDBCD];

	/// <summary>MIDI init function 5 return value in BX (DS:0xDBCE).</summary>
	public ushort MidiFunc5ReturnBx => UInt16[0xDBCE];

	/// <summary>Memory allocator next free offset (DS:0x39B7).</summary>
	public ushort AllocatorNextFreeOffset => UInt16[0x39B7];

	/// <summary>Memory allocator next free segment (DS:0x39B9).</summary>
	public ushort AllocatorNextFreeSegment => UInt16[0x39B9];

	/// <summary>Memory allocator last free (ceiling) segment (DS:0xCE68).</summary>
	public ushort AllocatorLastFreeSegment => UInt16[0xCE68];
}