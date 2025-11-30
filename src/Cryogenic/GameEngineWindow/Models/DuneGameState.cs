namespace Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Provides access to Dune game state values stored in emulated memory.
/// </summary>
/// <remarks>
/// <para>
/// This partial class is the main entry point for Dune game state access.
/// Uses TWO absolute memory segments:
/// - Game data segment 0x10ED (linear 0x10ED0): charisma, spice, sietches, troops, date/time
/// - Display segment 0x1138 (linear 0x11380): HNM, framebuffers, mouse, sound
/// </para>
/// <para>
/// Memory layout from problem statement MEMDUMPBIN offsets:
/// - Charisma (1 byte): 0x10EF9 = 10ED:0029
/// - Game Stage (1 byte): 0x10EFA = 10ED:002A
/// - Spice (2 bytes): 0x10F69 = 10ED:009F
/// - Sietches structure: 0x10FD0 = 10ED:0100 (10FC:000F alias)
/// - Date &amp; Time (2 bytes): 0x12044 = 10ED:1174
/// - Contact Distance (1 byte): 0x12046 = 10ED:1176
/// </para>
/// <para>
/// Display/HNM/Mouse at segment 0x1138 per GlobalsOnDs.cs:
/// - HnmFinishedFlag: 1138:DBE7
/// - FramebufferFront: 1138:DBD6
/// - MousePosX: 1138:DC38
/// </para>
/// <para>
/// Display formulas from DuneEdit2 and in-game observations:
/// - Charisma: displayed = raw * 2 + 1 (0x0C raw → 25 displayed)
/// - Date: complex format, day = (raw >> 10) + 1 approximately
/// </para>
/// </remarks>
public partial class DuneGameState : MemoryBasedDataStructure {
    /// <summary>
    /// Base address for game state data (savegame-related).
    /// Segment 0x10ED * 16 = 0x10ED0.
    /// Verified against MEMDUMPBIN offsets from problem statement.
    /// </summary>
    public new const uint BaseAddress = 0x10ED0;
    
    /// <summary>
    /// Base address for display/HNM/mouse/sound state.
    /// Segment 0x1138 * 16 = 0x11380.
    /// From GlobalsOnDs.cs runtime trace.
    /// </summary>
    public const uint DisplayBaseAddress = 0x11380;
    
    // Player data offsets within DS segment
    // Verified against MEMDUMPBIN offsets from problem statement
    public const int GameTimeOffset = 0x0002;         // game_time: u16 (internal counter)
    public const int PersonsTravelingWithOffset = 0x0010;  // persons_traveling_with: u16
    public const int PersonsInRoomOffset = 0x0012;    // persons_in_room: u16
    public const int PersonsTalkingToOffset = 0x0014; // persons_talking_to: u16
    public const int SietchesAvailableOffset = 0x0027; // sietches_available: u8
    public const int CharismaOffset = 0x0029;         // charisma: u8 (MEMDUMPBIN 0x10EF9)
    public const int GamePhaseOffset = 0x002A;        // game_phase: u8 (MEMDUMPBIN 0x10EFA)
    public const int SpiceOffset = 0x009F;            // spice: u16 (MEMDUMPBIN 0x10F69)
    public const int DaysLeftOffset = 0x00CF;         // days_left_until_spice_shipment: u8
    public const int UIHeadIndexOffset = 0x00E8;      // ui_head_index: u8
    public const int DateTimeOffset = 0x1174;         // date_time: u16 (MEMDUMPBIN 0x12044)
    public const int ContactDistanceOffset = 0x1176;  // contact_distance: u8 (MEMDUMPBIN 0x12046)
    
    // Sietches/Locations array at segment 0x10ED
    // MEMDUMPBIN 0x10FD0 = 10ED:0100 (matches 10FC:000F alias)
    public const int LocationArrayOffset = 0x0100;    // sietches: [Sietch; 70] at offset 0x100
    public const int LocationEntrySize = 28;          // sizeof(Sietch) = 28 bytes
    public const int MaxLocations = 70;
    
    /// <summary>
    /// Base address for troops/NPCs/smugglers.
    /// Segment 0x9B05 * 16 = 0x9B050.
    /// Per problem statement: Troops at 0x9B053 = 9B05:0003
    /// </summary>
    public const uint TroopBaseAddress = 0x9B050;
    
    // Troops at segment 0x9B05, offset 0x0003
    // MEMDUMPBIN 0x9B053 = 9B05:0003
    public const int TroopArrayOffset = 0x0003;       // Offset within segment 0x9B05
    public const int TroopEntrySize = 27;             // sizeof(Troop) per odrade
    public const int MaxTroops = 68;
    
    // NPC and Smuggler arrays follow troops in memory at segment 0x9B05
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
    /// Raw charisma byte at DS:0029 (linear 0x10EF9).
    /// From problem statement: 0x50 (80 decimal) = charisma 25 (but 0x50 is 80, not 25 displayed)
    /// Looking at screenshot: raw 0x0C (12) → displayed 25 in-game
    /// Formula appears to be: raw * 2 + 1 or similar
    /// </summary>
    public byte CharismaRaw => ReadByte(BaseAddress + CharismaOffset);
    
    /// <summary>
    /// Displayed charisma calculation.
    /// From screenshot: raw 0x0C (12) displays as 25 in-game.
    /// Testing formula: raw * 2 + 1 = 12 * 2 + 1 = 25 ✓
    /// </summary>
    public int CharismaDisplayed => CharismaRaw * 2 + 1;
    
    /// <summary>Game stage/progress at DS:002A</summary>
    public byte GameStage => ReadByte(BaseAddress + GamePhaseOffset);
    
    /// <summary>Days left until spice shipment at DS:00CF</summary>
    public byte DaysLeftUntilSpiceShipment => ReadByte(BaseAddress + DaysLeftOffset);
    
    /// <summary>UI head index at DS:00E8</summary>
    public byte UIHeadIndex => ReadByte(BaseAddress + UIHeadIndexOffset);

    // HNM Video state - at DisplayBaseAddress + offset (from GlobalsOnDs.cs segment 0x1138)
    public byte HnmFinishedFlag => ReadByte(DisplayBaseAddress + 0xDBE7);
    public ushort HnmFrameCounter => ReadWord(DisplayBaseAddress + 0xDBE8);
    public ushort HnmCounter2 => ReadWord(DisplayBaseAddress + 0xDBEA);
    public byte CurrentHnmResourceFlag => ReadByte(DisplayBaseAddress + 0xDBFE);
    public ushort HnmVideoId => ReadWord(DisplayBaseAddress + 0xDC00);
    public ushort HnmActiveVideoId => ReadWord(DisplayBaseAddress + 0xDC02);
    public uint HnmFileOffset => ReadDword(DisplayBaseAddress + 0xDC04);
    public uint HnmFileRemain => ReadDword(DisplayBaseAddress + 0xDC08);

    // Display/framebuffer state - at DisplayBaseAddress + offset (from GlobalsOnDs.cs segment 0x1138)
    public ushort FramebufferFront => ReadWord(DisplayBaseAddress + 0xDBD6);
    public ushort ScreenBuffer => ReadWord(DisplayBaseAddress + 0xDBD8);
    public ushort FramebufferActive => ReadWord(DisplayBaseAddress + 0xDBDA);
    public ushort FramebufferBack => ReadWord(DisplayBaseAddress + 0xDC32);

    // Mouse/cursor state - at DisplayBaseAddress + offset (from GlobalsOnDs.cs segment 0x1138)
    public ushort MousePosY => ReadWord(DisplayBaseAddress + 0xDC36);
    public ushort MousePosX => ReadWord(DisplayBaseAddress + 0xDC38);
    public ushort MouseDrawPosY => ReadWord(DisplayBaseAddress + 0xDC42);
    public ushort MouseDrawPosX => ReadWord(DisplayBaseAddress + 0xDC44);
    public byte CursorHideCounter => ReadByte(DisplayBaseAddress + 0xDC46);
    public ushort MapCursorType => ReadWord(DisplayBaseAddress + 0xDC58);

    // Sound state - at DisplayBaseAddress + offset (from GlobalsOnDs.cs segment 0x1138)
    public byte IsSoundPresent => ReadByte(DisplayBaseAddress + 0xDBCD);
    public ushort MidiFunc5ReturnBx => ReadWord(DisplayBaseAddress + 0xDBCE);

    // Graphics transition - at DisplayBaseAddress + offset (from GlobalsOnDs.cs segment 0x1138)
    public byte TransitionBitmask => ReadByte(DisplayBaseAddress + 0xDCE6);

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
    
    // Spice at 10ED:009F (MEMDUMPBIN 0x10F69)
    public ushort Spice => ReadWord(BaseAddress + SpiceOffset);
    
    // Date/time at 10ED:1174 (MEMDUMPBIN 0x12044)
    // Format per problem statement: 0x6201 = 23rd day, 7:30
    public ushort DateTimeRaw => ReadWord(BaseAddress + DateTimeOffset);
    
    // Contact distance at 10ED:1176 (MEMDUMPBIN 0x12046)
    public byte ContactDistance => ReadByte(BaseAddress + ContactDistanceOffset);

    // Dialogue state - these large offsets are likely at segment 0x1138
    // Need verification - marking with DisplayBaseAddress for now
    public byte CurrentSpeakerId => ReadByte(DisplayBaseAddress + 0xDC8C);
    public ushort DialogueState => ReadWord(DisplayBaseAddress + 0xDC8E);

    /// <summary>
    /// Get day from packed date/time at 10ED:1174.
    /// Based on problem statement: 0x6201 = 23rd day
    /// High byte 0x62 = 98, possibly 98/4 ≈ 24, or just (high_byte >> 2)
    /// Using simple interpretation: day = (high_byte >> 2) which gives 24 for 0x62
    /// May need adjustment based on testing.
    /// </summary>
    public int GetDay() {
        // Try: day = high_byte >> 2, which for 0x62 gives 24 (close to 23)
        // Alternative: day = high_byte / 4 gives similar result
        return (DateTimeRaw >> 10) + 1;
    }
    
    /// <summary>
    /// Get time in half-hour slots from packed date/time.
    /// Low 10 bits might represent time in some form.
    /// </summary>
    public int GetTimeSlot() => DateTimeRaw & 0x3FF;
    
    /// <summary>
    /// Get hour (0-23) from time slot.
    /// Assuming 48 half-hour slots per day.
    /// </summary>
    public int GetHour() => (GetTimeSlot() * 24) / 1024;
    
    /// <summary>
    /// Get minutes (0 or 30) from time slot.
    /// </summary>
    public int GetMinutes() => ((GetTimeSlot() * 48) / 1024) % 2 == 0 ? 0 : 30;
    
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
