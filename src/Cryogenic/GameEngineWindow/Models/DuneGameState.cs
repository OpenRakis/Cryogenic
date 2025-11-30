namespace Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.CPU.Registers;
using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Provides access to Dune game state values stored in emulated memory.
/// </summary>
public class DuneGameState : MemoryBasedDataStructureWithDsBaseAddress {
    private const int SietchBaseOffset = 0xAA76;
    private const int SietchEntrySize = 28;
    private const int MaxSietches = 70;
    private const int TroopBaseOffset = SietchBaseOffset + (SietchEntrySize * MaxSietches);
    private const int TroopEntrySize = 27;
    private const int MaxTroops = 68;

    public DuneGameState(IByteReaderWriter memory, SegmentRegisters segmentRegisters) 
        : base(memory, segmentRegisters) {
    }

    // Core game state
    public ushort GameElapsedTime => UInt16[0x0002];
    public byte Charisma => UInt8[0x0029];
    public byte GameStage => UInt8[0x002A];
    public ushort Spice => UInt16[0x009F];
    public ushort DateTimeRaw => UInt16[0x1174];
    public byte ContactDistance => UInt8[0x1176];

    // HNM Video state
    public byte HnmFinishedFlag => UInt8[0xDBE7];
    public ushort HnmFrameCounter => UInt16[0xDBE8];
    public ushort HnmCounter2 => UInt16[0xDBEA];
    public byte CurrentHnmResourceFlag => UInt8[0xDBFE];
    public ushort HnmVideoId => UInt16[0xDC00];
    public ushort HnmActiveVideoId => UInt16[0xDC02];
    public uint HnmFileOffset => UInt32[0xDC04];
    public uint HnmFileRemain => UInt32[0xDC08];

    // Display and graphics state
    public ushort FramebufferFront => UInt16[0xDBD6];
    public ushort ScreenBuffer => UInt16[0xDBD8];
    public ushort FramebufferActive => UInt16[0xDBDA];
    public ushort FramebufferBack => UInt16[0xDC32];

    // Mouse and cursor state
    public ushort MousePosY => UInt16[0xDC36];
    public ushort MousePosX => UInt16[0xDC38];
    public ushort MouseDrawPosY => UInt16[0xDC42];
    public ushort MouseDrawPosX => UInt16[0xDC44];
    public byte CursorHideCounter => UInt8[0xDC46];
    public ushort MapCursorType => UInt16[0xDC58];

    // Sound state
    public byte IsSoundPresent => UInt8[0xDBCD];
    public ushort MidiFunc5ReturnBx => UInt16[0xDBCE];

    // Transition and effects state
    public byte TransitionBitmask => UInt8[0xDCE6];

    // NPCs/Characters data
    public byte Follower1Id => UInt8[0x0019];
    public byte Follower2Id => UInt8[0x001A];
    public byte CurrentRoomId => UInt8[0x001B];
    public ushort WorldPosX => UInt16[0x001C];
    public ushort WorldPosY => UInt16[0x001E];

    // Player stats
    public ushort WaterReserve => UInt16[0x0020];
    public ushort SpiceReserve => UInt16[0x0022];
    public uint Money => UInt32[0x0024];
    public byte MilitaryStrength => UInt8[0x002B];
    public byte EcologyProgress => UInt8[0x002C];

    // Dialogue state
    public byte CurrentSpeakerId => UInt8[0xDC8C];
    public ushort DialogueState => UInt16[0xDC8E];

    // Sietch accessors
    public byte GetSietchStatus(int index) {
        if (index < 0 || index >= MaxSietches) return 0;
        return UInt8[SietchBaseOffset + (index * SietchEntrySize)];
    }

    public ushort GetSietchSpiceField(int index) {
        if (index < 0 || index >= MaxSietches) return 0;
        return UInt16[SietchBaseOffset + (index * SietchEntrySize) + 2];
    }

    public (ushort X, ushort Y) GetSietchCoordinates(int index) {
        if (index < 0 || index >= MaxSietches) return (0, 0);
        var baseOffset = SietchBaseOffset + (index * SietchEntrySize);
        return (UInt16[baseOffset + 4], UInt16[baseOffset + 6]);
    }

    // Troop accessors
    public byte GetTroopOccupation(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return UInt8[TroopBaseOffset + (index * TroopEntrySize)];
    }

    public byte GetTroopLocation(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return UInt8[TroopBaseOffset + (index * TroopEntrySize) + 1];
    }

    public byte GetTroopMotivation(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return UInt8[TroopBaseOffset + (index * TroopEntrySize) + 4];
    }

    public byte GetTroopSpiceSkill(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return UInt8[TroopBaseOffset + (index * TroopEntrySize) + 5];
    }

    public byte GetTroopArmySkill(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return UInt8[TroopBaseOffset + (index * TroopEntrySize) + 6];
    }

    public byte GetTroopEcologySkill(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return UInt8[TroopBaseOffset + (index * TroopEntrySize) + 7];
    }

    public byte GetTroopEquipment(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return UInt8[TroopBaseOffset + (index * TroopEntrySize) + 8];
    }

    public static string GetTroopOccupationDescription(byte occupation) => occupation switch {
        0 => "Idle",
        1 => "Spice Harvesting",
        2 => "Military",
        3 => "Ecology",
        4 => "Moving",
        _ => $"Unknown (0x{occupation:X2})"
    };

    public static string GetNpcName(byte npcId) => npcId switch {
        0 => "None",
        1 => "Paul Atreides",
        2 => "Jessica",
        3 => "Thufir Hawat",
        4 => "Gurney Halleck",
        5 => "Duncan Idaho",
        6 => "Stilgar",
        7 => "Chani",
        8 => "Harah",
        9 => "Liet-Kynes",
        10 => "Duke Leto",
        11 => "Baron Harkonnen",
        12 => "Feyd-Rautha",
        _ => $"NPC #{npcId}"
    };

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
        _ => $"Stage 0x{GameStage:X2}"
    };

    public int GetActiveTroopCount() {
        int count = 0;
        for (int i = 0; i < MaxTroops; i++) {
            if (GetTroopOccupation(i) != 0) count++;
        }
        return count;
    }

    public int GetDiscoveredSietchCount() {
        int count = 0;
        for (int i = 0; i < MaxSietches; i++) {
            if (GetSietchStatus(i) != 0) count++;
        }
        return count;
    }
}
