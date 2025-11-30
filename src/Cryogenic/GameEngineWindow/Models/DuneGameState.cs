namespace Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Provides access to Dune game state values stored in emulated memory.
/// </summary>
/// <remarks>
/// <para>
/// This partial class is the main entry point for Dune game state access.
/// Uses absolute memory addressing at segment 0x1138 (linear 0x11380) which is the
/// DS segment during normal game execution. All offsets are from this single base.
/// </para>
/// <para>
/// Per madmoose's dune-rust savegame analysis and GlobalsOnDs.cs:
/// All game state data is in segment 0x1138 at various offsets:
/// - DS:0000-0x125F: Player state (4705 bytes) - charisma, game stage, sietches, etc.
/// - DS:AA76+: Troops, NPCs, Smugglers (4600 bytes)
/// - DS:DCFE+: Map data (12671 bytes)
/// - DS:DBD6+: Display/HNM/Mouse/Sound state
/// </para>
/// <para>
/// Offset sources:
/// - madmoose/dune-rust crates/savegame/src/data.rs: DataSegment structure
/// - GlobalsOnDs.cs: Runtime traced memory accesses at segment 0x1138
/// - debrouxl/odrade: Location, troop, NPC, smuggler structure definitions
/// </para>
/// <para>
/// Note: Raw memory values may differ from displayed in-game values.
/// Example: Charisma raw value 0x50 (80) displays as 25 in-game via formula (raw * 5) / 16.
/// </para>
/// </remarks>
public partial class DuneGameState : MemoryBasedDataStructure {
    /// <summary>
    /// Base address for all game state data.
    /// Segment 0x1138 * 16 = 0x11380.
    /// This is the DS segment value during normal game execution.
    /// </summary>
    public new const uint BaseAddress = 0x11380;
    
    // Player data offsets within DS segment (from madmoose dune-rust data.rs)
    public const int GameTimeOffset = 0x0002;         // game_time: u16
    public const int PersonsTravelingWithOffset = 0x0010;  // persons_traveling_with: u16
    public const int PersonsInRoomOffset = 0x0012;    // persons_in_room: u16
    public const int PersonsTalkingToOffset = 0x0014; // persons_talking_to: u16
    public const int SietchesAvailableOffset = 0x0027; // sietches_available: u8
    public const int CharismaOffset = 0x0029;         // charisma: u8
    public const int GamePhaseOffset = 0x002A;        // game_phase: u8
    public const int DaysLeftOffset = 0x00CF;         // days_left_until_spice_shipment: u8
    public const int UIHeadIndexOffset = 0x00E8;      // ui_head_index: u8
    
    // Sietches/Locations array (from madmoose dune-rust data.rs)
    public const int LocationArrayOffset = 0x0100;    // sietches: [Sietch; 70] at offset 0x100
    public const int LocationEntrySize = 28;          // sizeof(Sietch) = 28 bytes
    public const int MaxLocations = 70;
    
    // Troop/NPC/Smuggler arrays are at DS:AA76+ region (4600 bytes)
    // Offset from DS:0000 to start of troop data
    public const int TroopArrayOffset = 0xAA76;       // DS:AA76 per madmoose analysis
    public const int TroopEntrySize = 27;             // sizeof(Troop) per odrade
    public const int MaxTroops = 68;
    
    // NPC and Smuggler arrays follow troops in memory
    public const int NpcEntrySize = 8;
    public const int NpcPadding = 8;
    public const int NpcTotalEntrySize = NpcEntrySize + NpcPadding; // 16 bytes total per odrade
    public const int MaxNpcs = 16;
    
    public const int SmugglerEntrySize = 14;
    public const int SmugglerPadding = 3;
    public const int SmugglerTotalEntrySize = SmugglerEntrySize + SmugglerPadding; // 17 bytes total per odrade
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

    // Core game state - all at BaseAddress (0x11380) + offset
    // Offsets from madmoose dune-rust data.rs and GlobalsOnDs.cs
    
    /// <summary>Game elapsed time counter at DS:0002</summary>
    public ushort GameElapsedTime => ReadWord(BaseAddress + GameTimeOffset);
    
    /// <summary>
    /// Raw charisma byte at DS:0029.
    /// Per madmoose analysis: 0x50 (80) displays as 25 in-game.
    /// Formula: (raw * 5) / 16 gives approximately correct display value.
    /// </summary>
    public byte CharismaRaw => ReadByte(BaseAddress + CharismaOffset);
    
    /// <summary>
    /// Displayed charisma calculation.
    /// Formula derived from in-game observation: 0x50 (80) → 25
    /// Using (raw * 5) / 16 as integer approximation.
    /// </summary>
    public int CharismaDisplayed => (CharismaRaw * 5) / 16;
    
    /// <summary>Game stage/progress at DS:002A</summary>
    public byte GameStage => ReadByte(BaseAddress + GamePhaseOffset);
    
    /// <summary>Days left until spice shipment at DS:00CF</summary>
    public byte DaysLeftUntilSpiceShipment => ReadByte(BaseAddress + DaysLeftOffset);
    
    /// <summary>UI head index at DS:00E8</summary>
    public byte UIHeadIndex => ReadByte(BaseAddress + UIHeadIndexOffset);

    // HNM Video state - at BaseAddress + offset (from GlobalsOnDs.cs)
    public byte HnmFinishedFlag => ReadByte(BaseAddress + 0xDBE7);
    public ushort HnmFrameCounter => ReadWord(BaseAddress + 0xDBE8);
    public ushort HnmCounter2 => ReadWord(BaseAddress + 0xDBEA);
    public byte CurrentHnmResourceFlag => ReadByte(BaseAddress + 0xDBFE);
    public ushort HnmVideoId => ReadWord(BaseAddress + 0xDC00);
    public ushort HnmActiveVideoId => ReadWord(BaseAddress + 0xDC02);
    public uint HnmFileOffset => ReadDword(BaseAddress + 0xDC04);
    public uint HnmFileRemain => ReadDword(BaseAddress + 0xDC08);

    // Display/framebuffer state - at BaseAddress + offset (from GlobalsOnDs.cs)
    public ushort FramebufferFront => ReadWord(BaseAddress + 0xDBD6);
    public ushort ScreenBuffer => ReadWord(BaseAddress + 0xDBD8);
    public ushort FramebufferActive => ReadWord(BaseAddress + 0xDBDA);
    public ushort FramebufferBack => ReadWord(BaseAddress + 0xDC32);

    // Mouse/cursor state - at BaseAddress + offset (from GlobalsOnDs.cs)
    public ushort MousePosY => ReadWord(BaseAddress + 0xDC36);
    public ushort MousePosX => ReadWord(BaseAddress + 0xDC38);
    public ushort MouseDrawPosY => ReadWord(BaseAddress + 0xDC42);
    public ushort MouseDrawPosX => ReadWord(BaseAddress + 0xDC44);
    public byte CursorHideCounter => ReadByte(BaseAddress + 0xDC46);
    public ushort MapCursorType => ReadWord(BaseAddress + 0xDC58);

    // Sound state - at BaseAddress + offset (from GlobalsOnDs.cs)
    public byte IsSoundPresent => ReadByte(BaseAddress + 0xDBCD);
    public ushort MidiFunc5ReturnBx => ReadWord(BaseAddress + 0xDBCE);

    // Graphics transition - at BaseAddress + offset (from GlobalsOnDs.cs)
    public byte TransitionBitmask => ReadByte(BaseAddress + 0xDCE6);

    // Player party/position state - offsets need verification
    // These may be at different offsets in the DataSegment
    public byte Follower1Id => ReadByte(BaseAddress + PersonsTravelingWithOffset);
    public byte Follower2Id => ReadByte(BaseAddress + PersonsTravelingWithOffset + 1);
    public byte CurrentRoomId => ReadByte(BaseAddress + 0x0005); // current_location_and_room is at 0x04-0x05
    public ushort WorldPosX => ReadWord(BaseAddress + 0x001C);   // Needs verification
    public ushort WorldPosY => ReadWord(BaseAddress + 0x001E);   // Needs verification

    // Player resources - offsets need verification from actual game data
    public ushort WaterReserve => ReadWord(BaseAddress + 0x0020); // Needs verification
    public ushort SpiceReserve => ReadWord(BaseAddress + 0x0022); // Needs verification
    public uint Money => ReadDword(BaseAddress + 0x0024);         // Needs verification
    public byte MilitaryStrength => ReadByte(BaseAddress + 0x002B);
    public byte EcologyProgress => ReadByte(BaseAddress + 0x002C);
    
    // Spice - need to find correct offset
    public ushort Spice => ReadWord(BaseAddress + 0x009F);        // Needs verification
    
    // Date/time - from game time calculation
    public ushort DateTimeRaw => GameElapsedTime;
    
    // Contact distance - needs verification  
    public byte ContactDistance => ReadByte(BaseAddress + 0x1176); // Needs verification

    // Dialogue state - at BaseAddress + offset
    public byte CurrentSpeakerId => ReadByte(BaseAddress + 0xDC8C);
    public ushort DialogueState => ReadWord(BaseAddress + 0xDC8E);

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
    public (byte X, byte Y) GetSietchCoordinates(int index) => GetLocationCoordinates(index);
    
    /// <summary>
    /// Returns the count of discovered locations (including palaces, villages, sietches).
    /// Wrapper for GetDiscoveredLocationCount() for consistency with Sietch-named accessors.
    /// </summary>
    public int GetDiscoveredSietchCount() => GetDiscoveredLocationCount();
}
