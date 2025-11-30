namespace Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Provides access to Dune game state values stored in emulated memory.
/// </summary>
/// <remarks>
/// <para>
/// This partial class is the main entry point for Dune game state access.
/// Uses absolute memory addressing to ensure stable values regardless of
/// which code segment is currently executing.
/// </para>
/// <para>
/// IMPORTANT: Different game structures reside at different memory segments:
/// - Player globals (spice, charisma, game stage): Segment 0x10ED → linear 0x10ED0
/// - Locations/Sietches structure: Segment 0x10FC → linear 0x10FC0
/// - Troops structure: Segment 0x9B05 → linear 0x9B050
/// - Display/HNM/Mouse data: Segment 0x1138 → linear 0x11380
/// </para>
/// <para>
/// Per madmoose's analysis (from sub_1B427_create_save_in_memory), savegame consists of:
/// - DS:[DCFE]: 12671 bytes (2 bits for each of 50684 bytes)
/// - CS:00AA: 162 bytes (code segment data)
/// - DS:AA76: 4600 bytes (locations, troops, NPCs, smugglers)
/// - DS:0000: 4705 bytes (player state, dialogue, etc.)
/// These DS/CS values refer to runtime register values, not fixed segments.
/// </para>
/// <para>
/// Note: Raw memory values may differ from displayed in-game values.
/// Example: Charisma raw value 0x50 (80) displays as 25 in-game.
/// </para>
/// </remarks>
public partial class DuneGameState : MemoryBasedDataStructure {
    /// <summary>
    /// Base address for player globals (spice, charisma, game stage, etc.).
    /// Segment 0x10ED * 16 = 0x10ED0.
    /// Per problem statement: Charisma at 10ED:0029, Spice at 10ED:009F, etc.
    /// </summary>
    public const uint PlayerGlobalsBaseAddress = 0x10ED0;
    
    /// <summary>
    /// Base address for locations/sietches structure.
    /// Segment 0x10FC * 16 = 0x10FC0.
    /// Per problem statement: Sietchs structure at 10FC:000F.
    /// </summary>
    public const uint LocationsBaseAddress = 0x10FC0;
    
    /// <summary>
    /// Base address for troops structure.
    /// Segment 0x9B05 * 16 = 0x9B050.
    /// Per problem statement: Troops structure at 9B05:0003.
    /// </summary>
    public const uint TroopsBaseAddress = 0x9B050;
    
    /// <summary>
    /// Base address for display/HNM/Mouse/Sound data.
    /// Segment 0x1138 * 16 = 0x11380.
    /// From GlobalsOnDs.cs: framebufferFront, mousePosX, hnmFrameCounter, etc.
    /// </summary>
    public const uint DisplayBaseAddress = 0x11380;
    
    // Location array structure
    public const int LocationArrayOffset = 0x000F;  // Offset from LocationsBaseAddress
    public const int LocationEntrySize = 28;
    public const int MaxLocations = 70;
    
    // Troop array structure  
    public const int TroopArrayOffset = 0x0003;  // Offset from TroopsBaseAddress
    public const int TroopEntrySize = 27;
    public const int MaxTroops = 68;
    
    // NPC and Smuggler arrays follow troops in memory
    public const int NpcEntrySize = 8;
    public const int NpcPadding = 8;
    public const int NpcTotalEntrySize = NpcEntrySize + NpcPadding; // 16 bytes total
    public const int MaxNpcs = 16;
    
    public const int SmugglerEntrySize = 14;
    public const int SmugglerPadding = 3;
    public const int SmugglerTotalEntrySize = SmugglerEntrySize + SmugglerPadding; // 17 bytes total
    public const int MaxSmugglers = 6;
    
    // Location status flags (from odrade)
    public const byte LocationStatusVegetation = 0x01;
    public const byte LocationStatusInBattle = 0x02;
    public const byte LocationStatusInventory = 0x10;
    public const byte LocationStatusWindtrap = 0x20;
    public const byte LocationStatusProspected = 0x40;
    public const byte LocationStatusUndiscovered = 0x80;

    public DuneGameState(IByteReaderWriter memory) 
        : base(memory, 0) {
        // Base address of 0 means UInt8[addr], UInt16[addr], UInt32[addr] read from absolute address
    }
    
    /// <summary>
    /// Read a byte from an absolute memory address.
    /// </summary>
    private byte ReadByte(uint absoluteAddress) => UInt8[absoluteAddress];
    
    /// <summary>
    /// Read a word (16-bit) from an absolute memory address.
    /// </summary>
    private ushort ReadWord(uint absoluteAddress) => UInt16[absoluteAddress];
    
    /// <summary>
    /// Read a dword (32-bit) from an absolute memory address.
    /// </summary>
    private uint ReadDword(uint absoluteAddress) => UInt32[absoluteAddress];

    // Core game state - these are at PlayerGlobalsBaseAddress (0x10ED0)
    // Offsets match the problem statement: 10ED:0029, 10ED:009F, etc.
    
    /// <summary>Game elapsed time counter at 10ED:0002</summary>
    public ushort GameElapsedTime => ReadWord(PlayerGlobalsBaseAddress + 0x0002);
    
    /// <summary>
    /// Raw charisma byte at 10ED:0029.
    /// Per problem statement: 0x50 (80) displays as 25 in-game.
    /// </summary>
    public byte CharismaRaw => ReadByte(PlayerGlobalsBaseAddress + 0x0029);
    
    /// <summary>
    /// Displayed charisma calculation.
    /// Per problem statement: 0x50 (80) → 25, so formula is approximately raw / 3.2 or (raw * 5) / 16.
    /// Using (raw * 5) / 16 as integer approximation.
    /// </summary>
    public int CharismaDisplayed => (CharismaRaw * 5) / 16;
    
    /// <summary>Game stage/progress at 10ED:002A</summary>
    public byte GameStage => ReadByte(PlayerGlobalsBaseAddress + 0x002A);
    
    /// <summary>Total spice at 10ED:009F</summary>
    public ushort Spice => ReadWord(PlayerGlobalsBaseAddress + 0x009F);
    
    /// <summary>Date/time packed value at 10ED:1174</summary>
    public ushort DateTimeRaw => ReadWord(PlayerGlobalsBaseAddress + 0x1174);
    
    /// <summary>Contact distance at 10ED:1176</summary>
    public byte ContactDistance => ReadByte(PlayerGlobalsBaseAddress + 0x1176);

    // HNM Video state - these are at DisplayBaseAddress (0x11380)
    public byte HnmFinishedFlag => ReadByte(DisplayBaseAddress + 0xDBE7);
    public ushort HnmFrameCounter => ReadWord(DisplayBaseAddress + 0xDBE8);
    public ushort HnmCounter2 => ReadWord(DisplayBaseAddress + 0xDBEA);
    public byte CurrentHnmResourceFlag => ReadByte(DisplayBaseAddress + 0xDBFE);
    public ushort HnmVideoId => ReadWord(DisplayBaseAddress + 0xDC00);
    public ushort HnmActiveVideoId => ReadWord(DisplayBaseAddress + 0xDC02);
    public uint HnmFileOffset => ReadDword(DisplayBaseAddress + 0xDC04);
    public uint HnmFileRemain => ReadDword(DisplayBaseAddress + 0xDC08);

    // Display/framebuffer state - at DisplayBaseAddress (0x11380)
    public ushort FramebufferFront => ReadWord(DisplayBaseAddress + 0xDBD6);
    public ushort ScreenBuffer => ReadWord(DisplayBaseAddress + 0xDBD8);
    public ushort FramebufferActive => ReadWord(DisplayBaseAddress + 0xDBDA);
    public ushort FramebufferBack => ReadWord(DisplayBaseAddress + 0xDC32);

    // Mouse/cursor state - at DisplayBaseAddress (0x11380)
    public ushort MousePosY => ReadWord(DisplayBaseAddress + 0xDC36);
    public ushort MousePosX => ReadWord(DisplayBaseAddress + 0xDC38);
    public ushort MouseDrawPosY => ReadWord(DisplayBaseAddress + 0xDC42);
    public ushort MouseDrawPosX => ReadWord(DisplayBaseAddress + 0xDC44);
    public byte CursorHideCounter => ReadByte(DisplayBaseAddress + 0xDC46);
    public ushort MapCursorType => ReadWord(DisplayBaseAddress + 0xDC58);

    // Sound state - at DisplayBaseAddress (0x11380)
    public byte IsSoundPresent => ReadByte(DisplayBaseAddress + 0xDBCD);
    public ushort MidiFunc5ReturnBx => ReadWord(DisplayBaseAddress + 0xDBCE);

    // Graphics transition - at DisplayBaseAddress (0x11380)
    public byte TransitionBitmask => ReadByte(DisplayBaseAddress + 0xDCE6);

    // Player party/position state - at PlayerGlobalsBaseAddress (0x10ED0)
    public byte Follower1Id => ReadByte(PlayerGlobalsBaseAddress + 0x0019);
    public byte Follower2Id => ReadByte(PlayerGlobalsBaseAddress + 0x001A);
    public byte CurrentRoomId => ReadByte(PlayerGlobalsBaseAddress + 0x001B);
    public ushort WorldPosX => ReadWord(PlayerGlobalsBaseAddress + 0x001C);
    public ushort WorldPosY => ReadWord(PlayerGlobalsBaseAddress + 0x001E);

    // Player resources - at PlayerGlobalsBaseAddress (0x10ED0)
    public ushort WaterReserve => ReadWord(PlayerGlobalsBaseAddress + 0x0020);
    public ushort SpiceReserve => ReadWord(PlayerGlobalsBaseAddress + 0x0022);
    public uint Money => ReadDword(PlayerGlobalsBaseAddress + 0x0024);
    public byte MilitaryStrength => ReadByte(PlayerGlobalsBaseAddress + 0x002B);
    public byte EcologyProgress => ReadByte(PlayerGlobalsBaseAddress + 0x002C);

    // Dialogue state - at DisplayBaseAddress (0x11380)
    public byte CurrentSpeakerId => ReadByte(DisplayBaseAddress + 0xDC8C);
    public ushort DialogueState => ReadWord(DisplayBaseAddress + 0xDC8E);

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
