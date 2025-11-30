namespace Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.CPU.Registers;
using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Provides access to Dune game state values stored in emulated memory.
/// </summary>
/// <remarks>
/// This partial class is the main entry point for Dune game state access.
/// Memory regions per madmoose's analysis (from sub_1B427_create_save_in_memory):
/// - DS:DCFE: 12671 bytes (2 bits for each of 50684 bytes)
/// - CS:00AA: 162 bytes (code segment data)
/// - DS:AA76: 4600 bytes (locations, troops, NPCs, smugglers)
/// - DS:0000: 4705 bytes (player state, dialogue, etc.)
/// </remarks>
public partial class DuneGameState : MemoryBasedDataStructureWithDsBaseAddress {
    public const int LocationBaseOffset = 0xAA76;
    public const int LocationEntrySize = 28;
    public const int MaxLocations = 70;
    
    public const int TroopBaseOffset = LocationBaseOffset + (LocationEntrySize * MaxLocations);
    public const int TroopEntrySize = 27;
    public const int MaxTroops = 68;
    
    public const int NpcBaseOffset = TroopBaseOffset + (TroopEntrySize * MaxTroops);
    public const int NpcEntrySize = 16;
    public const int MaxNpcs = 16;
    
    public const int SmugglerBaseOffset = NpcBaseOffset + (NpcEntrySize * MaxNpcs);
    public const int SmugglerEntrySize = 17;
    public const int MaxSmugglers = 6;

    public DuneGameState(IByteReaderWriter memory, SegmentRegisters segmentRegisters) 
        : base(memory, segmentRegisters) {
    }

    public ushort GameElapsedTime => UInt16[0x0002];
    public byte Charisma => UInt8[0x0029];
    public byte GameStage => UInt8[0x002A];
    public ushort Spice => UInt16[0x009F];
    public ushort DateTimeRaw => UInt16[0x1174];
    public byte ContactDistance => UInt8[0x1176];

    public byte HnmFinishedFlag => UInt8[0xDBE7];
    public ushort HnmFrameCounter => UInt16[0xDBE8];
    public ushort HnmCounter2 => UInt16[0xDBEA];
    public byte CurrentHnmResourceFlag => UInt8[0xDBFE];
    public ushort HnmVideoId => UInt16[0xDC00];
    public ushort HnmActiveVideoId => UInt16[0xDC02];
    public uint HnmFileOffset => UInt32[0xDC04];
    public uint HnmFileRemain => UInt32[0xDC08];

    public ushort FramebufferFront => UInt16[0xDBD6];
    public ushort ScreenBuffer => UInt16[0xDBD8];
    public ushort FramebufferActive => UInt16[0xDBDA];
    public ushort FramebufferBack => UInt16[0xDC32];

    public ushort MousePosY => UInt16[0xDC36];
    public ushort MousePosX => UInt16[0xDC38];
    public ushort MouseDrawPosY => UInt16[0xDC42];
    public ushort MouseDrawPosX => UInt16[0xDC44];
    public byte CursorHideCounter => UInt8[0xDC46];
    public ushort MapCursorType => UInt16[0xDC58];

    public byte IsSoundPresent => UInt8[0xDBCD];
    public ushort MidiFunc5ReturnBx => UInt16[0xDBCE];

    public byte TransitionBitmask => UInt8[0xDCE6];

    public byte Follower1Id => UInt8[0x0019];
    public byte Follower2Id => UInt8[0x001A];
    public byte CurrentRoomId => UInt8[0x001B];
    public ushort WorldPosX => UInt16[0x001C];
    public ushort WorldPosY => UInt16[0x001E];

    public ushort WaterReserve => UInt16[0x0020];
    public ushort SpiceReserve => UInt16[0x0022];
    public uint Money => UInt32[0x0024];
    public byte MilitaryStrength => UInt8[0x002B];
    public byte EcologyProgress => UInt8[0x002C];

    public byte CurrentSpeakerId => UInt8[0xDC8C];
    public ushort DialogueState => UInt16[0xDC8E];

    public int GetDay() => (DateTimeRaw >> 8) & 0xFF;
    public int GetHour() => (DateTimeRaw & 0xF0) >> 4;
    public int GetMinutes() => (DateTimeRaw & 0x0F) * 30;
    public string GetFormattedDateTime() => $"Day {GetDay()}, {GetHour():D2}:{GetMinutes():D2}";
    public string GetFormattedSpice() => $"{Spice * 10} kg";

    public string GetGameStageDescription() => GameStage switch {
        0x01 => "Start of game",
        0x02 => "Learning about stillsuits",
        0x03 => "Stillsuit explanation",
        0x04 => "Stillsuit mechanics",
        0x05 => "Meeting spice prospectors",
        0x06 => "Got stillsuits",
        0x4F => "Can ride worms",
        0x50 => "Have ridden a worm",
        0x68 => "End game",
        _ => $"Stage 0x{GameStage:X2}"
    };

    public int GetDiscoveredLocationCount() {
        int count = 0;
        for (int i = 0; i < MaxLocations; i++) {
            if (GetLocationStatus(i) != 0) count++;
        }
        return count;
    }

    public byte GetSietchStatus(int index) => GetLocationStatus(index);
    public ushort GetSietchSpiceField(int index) => (ushort)GetLocationSpiceAmount(index);
    public (ushort X, ushort Y) GetSietchCoordinates(int index) => GetLocationCoordinates(index);
    public int GetDiscoveredSietchCount() => GetDiscoveredLocationCount();
}
