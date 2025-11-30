namespace Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Provides access to Dune game state values stored in emulated memory.
/// </summary>
/// <remarks>
/// <para>
/// This partial class is the main entry point for Dune game state access.
/// Uses absolute memory addressing (0x11380 base) to ensure stable values regardless of
/// which code segment is currently executing. Offsets are taken from GlobalsOnDs.cs
/// which was generated from runtime memory access tracing.
/// </para>
/// <para>
/// Memory regions per madmoose's analysis (from sub_1B427_create_save_in_memory):
/// - 0x11380+0x0000: 4705 bytes (player state, dialogue, etc.)
/// - 0x11380+0xAA76: 4600 bytes (locations, troops, NPCs, smugglers)
/// - 0x11380+0xDCFE: 12671 bytes (2 bits for each of 50684 bytes)
/// - CS:00AA: 162 bytes (code segment data)
/// </para>
/// <para>
/// Note: These are raw memory values. The in-game display may calculate values differently.
/// For example, the displayed "CHARISMA" value may use a formula based on the raw byte value.
/// </para>
/// </remarks>
public partial class DuneGameState : MemoryBasedDataStructure {
    /// <summary>
    /// Absolute base address for Dune game data (segment 0x1138 * 16 = 0x11380).
    /// Using absolute address ensures values don't change depending on which code is executing.
    /// </summary>
    public const uint DuneDataBaseAddress = 0x11380;
    // Location array starts at DS:AA76 per madmoose analysis
    public const int LocationBaseOffset = 0xAA76;
    public const int LocationEntrySize = 28;
    public const int MaxLocations = 70;
    
    // Location status flags (from odrade)
    public const byte LocationStatusVegetation = 0x01;
    public const byte LocationStatusInBattle = 0x02;
    public const byte LocationStatusInventory = 0x10;
    public const byte LocationStatusWindtrap = 0x20;
    public const byte LocationStatusProspected = 0x40;
    public const byte LocationStatusUndiscovered = 0x80;
    
    // Troop array follows immediately after locations
    public const int TroopBaseOffset = LocationBaseOffset + (LocationEntrySize * MaxLocations);
    public const int TroopEntrySize = 27;
    public const int MaxTroops = 68;
    
    // NPC array follows troops (8 bytes per NPC + 8 bytes padding per odrade)
    public const int NpcBaseOffset = TroopBaseOffset + (TroopEntrySize * MaxTroops);
    public const int NpcEntrySize = 8;
    public const int NpcPadding = 8;
    public const int NpcTotalEntrySize = NpcEntrySize + NpcPadding; // 16 bytes total
    public const int MaxNpcs = 16;
    
    // Smuggler array follows NPCs (14 bytes per smuggler + 3 bytes padding per odrade)
    public const int SmugglerBaseOffset = NpcBaseOffset + (NpcTotalEntrySize * MaxNpcs);
    public const int SmugglerEntrySize = 14;
    public const int SmugglerPadding = 3;
    public const int SmugglerTotalEntrySize = SmugglerEntrySize + SmugglerPadding; // 17 bytes total
    public const int MaxSmugglers = 6;

    public DuneGameState(IByteReaderWriter memory) 
        : base(memory, DuneDataBaseAddress) {
    }

    // Core game state - offsets from GlobalsOnDs.cs (segment 0x1138)
    // These offsets are relative to DS register base
    
    /// <summary>Game elapsed time counter at DS:0002</summary>
    public ushort GameElapsedTime => UInt16[0x0002];
    
    /// <summary>
    /// Raw charisma/troops enlisted byte at DS:0029.
    /// This is NOT the displayed charisma value - the game calculates the display differently.
    /// Value progression: 0x00 at start, 0x01 after 1st troop, 0x02 after 2nd, etc.
    /// </summary>
    public byte CharismaRaw => UInt8[0x0029];
    
    /// <summary>
    /// Displayed charisma calculation: (raw_value * 2)
    /// At game start: 0 * 2 = 0
    /// After 5 troops: 5 * 2 = 10
    /// </summary>
    public int CharismaDisplayed => CharismaRaw * 2;
    
    /// <summary>Game stage/progress at DS:002A</summary>
    public byte GameStage => UInt8[0x002A];
    
    /// <summary>Total spice at DS:009F (multiply by 10 for kg display)</summary>
    public ushort Spice => UInt16[0x009F];
    
    /// <summary>Date/time packed value at DS:1174</summary>
    public ushort DateTimeRaw => UInt16[0x1174];
    
    /// <summary>Contact distance at DS:1176</summary>
    public byte ContactDistance => UInt8[0x1176];

    // HNM Video state - offsets from GlobalsOnDs.cs
    public byte HnmFinishedFlag => UInt8[0xDBE7];
    public ushort HnmFrameCounter => UInt16[0xDBE8];
    public ushort HnmCounter2 => UInt16[0xDBEA];
    public byte CurrentHnmResourceFlag => UInt8[0xDBFE];
    public ushort HnmVideoId => UInt16[0xDC00];
    public ushort HnmActiveVideoId => UInt16[0xDC02];
    public uint HnmFileOffset => UInt32[0xDC04];
    public uint HnmFileRemain => UInt32[0xDC08];

    // Display/framebuffer state - offsets from GlobalsOnDs.cs
    public ushort FramebufferFront => UInt16[0xDBD6];
    public ushort ScreenBuffer => UInt16[0xDBD8];
    public ushort FramebufferActive => UInt16[0xDBDA];
    public ushort FramebufferBack => UInt16[0xDC32];

    // Mouse/cursor state - offsets from GlobalsOnDs.cs
    public ushort MousePosY => UInt16[0xDC36];
    public ushort MousePosX => UInt16[0xDC38];
    public ushort MouseDrawPosY => UInt16[0xDC42];
    public ushort MouseDrawPosX => UInt16[0xDC44];
    public byte CursorHideCounter => UInt8[0xDC46];
    public ushort MapCursorType => UInt16[0xDC58];

    // Sound state - offsets from GlobalsOnDs.cs
    public byte IsSoundPresent => UInt8[0xDBCD];
    public ushort MidiFunc5ReturnBx => UInt16[0xDBCE];

    // Graphics transition
    public byte TransitionBitmask => UInt8[0xDCE6];

    // Player party/position state
    public byte Follower1Id => UInt8[0x0019];
    public byte Follower2Id => UInt8[0x001A];
    public byte CurrentRoomId => UInt8[0x001B];
    public ushort WorldPosX => UInt16[0x001C];
    public ushort WorldPosY => UInt16[0x001E];

    // Player resources
    public ushort WaterReserve => UInt16[0x0020];
    public ushort SpiceReserve => UInt16[0x0022];
    public uint Money => UInt32[0x0024];
    public byte MilitaryStrength => UInt8[0x002B];
    public byte EcologyProgress => UInt8[0x002C];

    // Dialogue state
    public byte CurrentSpeakerId => UInt8[0xDC8C];
    public ushort DialogueState => UInt16[0xDC8E];

    /// <summary>
    /// Get day from packed date/time.
    /// Format: high byte = day number (1-based)
    /// </summary>
    public int GetDay() {
        // Day is in high byte, add 1 because game displays "1st day" when byte is 0
        return ((DateTimeRaw >> 8) & 0xFF) + 1;
    }
    
    /// <summary>
    /// Get hour from packed date/time.
    /// Format: bits 4-7 of low byte = hour (0-23)
    /// </summary>
    public int GetHour() => (DateTimeRaw & 0xF0) >> 4;
    
    /// <summary>
    /// Get minutes from packed date/time.
    /// Format: bits 0-3 of low byte = minutes/30 (0-1 for :00 or :30)
    /// </summary>
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
            byte status = GetLocationStatus(i);
            // Location is discovered if UNDISCOVERED flag is NOT set
            if ((status & LocationStatusUndiscovered) == 0) count++;
        }
        return count;
    }

    public byte GetSietchStatus(int index) => GetLocationStatus(index);
    public ushort GetSietchSpiceField(int index) => (ushort)GetLocationSpiceAmount(index);
    public (ushort X, ushort Y) GetSietchCoordinates(int index) => GetLocationCoordinates(index);
    public int GetDiscoveredSietchCount() => GetDiscoveredLocationCount();
}
