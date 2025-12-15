namespace Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Provides access to Dune game state values stored in emulated memory at fixed DS segment address.
/// </summary>
/// <remarks>
/// <para>
/// This partial class uses MemoryBasedDataStructure with fixed absolute base address 0x11380
/// (DS segment 0x1138 * 16). This is the DS value used by the main Dune code in its own code segment.
/// Using a fixed address ensures stability even if the DS register changes during execution.
/// </para>
/// <para>
/// Memory layout sources:
/// - GlobalsOnDs.cs: Runtime-traced memory accesses at segment 0x1138
/// - debrouxl/odrade: Data structure definitions
/// - thomas.fach-pedersen.net: Memory map documentation
/// </para>
/// <para>
/// Key offsets from base 0x11380:
/// - Charisma (1 byte): 0x0029
/// - Game Phase/Stage (1 byte): 0x002A
/// - Spice (2 bytes): 0x009F
/// - Locations/Sietches: 0x0100 (28 bytes × 70 entries)
/// - Date &amp; Time (2 bytes): 0x1174
/// - Contact Distance (1 byte): 0x1176
/// - Troops: 0xAA76 (27 bytes × 68 entries)
/// - NPCs: 0xAC2E (16 bytes × 16 entries, follows troops)
/// - Smugglers: 0xAD2E (17 bytes × 6 entries, follows NPCs)
/// </para>
/// <para>
/// Display formulas:
/// - Charisma: raw value (0 at start = 0 displayed)
/// - Date/Time: Packed format, details in GetDateTime()
/// </para>
/// </remarks>
public partial class DuneGameState : MemoryBasedDataStructure {
    /// <summary>
    /// Fixed DS segment used by main Dune code = 0x1138 (linear address 0x11380).
    /// </summary>
    private const uint DuneDataSegmentBase = 0x11380;
    
    public DuneGameState(IByteReaderWriter memory) 
        : base(memory, DuneDataSegmentBase) {
    }
    
    // Player data DS-relative offsets
    // Verified against GlobalsOnDs.cs and odrade/thomas.fach-pedersen.net references
    public const int GameTimeOffset = 0x0002;              // game_time: u16 (internal counter)
    public const int PersonsTravelingWithOffset = 0x0010;  // persons_traveling_with: u16
    public const int PersonsInRoomOffset = 0x0012;         // persons_in_room: u16
    public const int PersonsTalkingToOffset = 0x0014;      // persons_talking_to: u16
    public const int SietchesAvailableOffset = 0x0027;     // sietches_available: u8
    public const int CharismaOffset = 0x0029;              // charisma: u8
    public const int GamePhaseOffset = 0x002A;             // game_phase: u8
    public const int SpiceOffset = 0x009F;                 // spice: u16
    public const int DaysLeftOffset = 0x00CF;              // days_left_until_spice_shipment: u8
    public const int UIHeadIndexOffset = 0x00E8;           // ui_head_index: u8
    public const int DateTimeOffset = 0x1174;              // date_time: u16
    public const int ContactDistanceOffset = 0x1176;       // contact_distance: u8
    
    // Locations/Sietches array DS-relative
    public const int LocationArrayOffset = 0x0100;         // sietches: [Sietch; 70]
    public const int LocationEntrySize = 28;               // sizeof(Sietch) = 28 bytes
    public const int MaxLocations = 70;
    
    // Troops array DS-relative
    public const int TroopArrayOffset = 0xAA76;            // troops: [Troop; 68]
    public const int TroopEntrySize = 27;                  // sizeof(Troop) = 27 bytes
    public const int MaxTroops = 68;
    
    // Location status flags (bit flags in status byte)
    public const byte LocationStatusVegetation = 0x01;     // Bit 0: Vegetation present
    public const byte LocationStatusInBattle = 0x02;       // Bit 1: In battle
    public const byte LocationStatusInventory = 0x04;      // Bit 2: Has inventory
    public const byte LocationStatusWindtrap = 0x10;       // Bit 4: Windtrap present
    public const byte LocationStatusProspected = 0x40;     // Bit 6: Prospected for spice
    public const byte LocationStatusUndiscovered = 0x80;   // Bit 7: Not yet discovered
    
    // Core player state accessors using DS-relative offsets
    
    /// <summary>
    /// Gets the raw charisma value from memory (DS:0x0029).
    /// </summary>
    public byte GetCharismaRaw() => UInt8[CharismaOffset];
    
    /// <summary>
    /// Gets the displayed charisma value.
    /// Formula: raw value directly (0 at start = 0 displayed)
    /// </summary>
    public int GetCharismaDisplayed() => GetCharismaRaw();
    
    /// <summary>
    /// Gets the game phase/stage value from memory (DS:0x002A).
    /// </summary>
    public byte GetGamePhase() => UInt8[GamePhaseOffset];
    
    /// <summary>
    /// Gets the game elapsed time (internal counter).
    /// </summary>
    public ushort GameElapsedTime => UInt16[GameTimeOffset];
    
    /// <summary>
    /// Gets the raw charisma value.
    /// </summary>
    public byte CharismaRaw => GetCharismaRaw();
    
    /// <summary>
    /// Gets the displayed charisma value ((raw * 2) + 1).
    /// </summary>
    public int CharismaDisplayed => GetCharismaDisplayed();
    
    /// <summary>
    /// Gets the game phase/stage value.
    /// </summary>
    public byte GamePhase => GetGamePhase();
    
    /// <summary>
    /// Gets the total spice amount in kilograms.
    /// </summary>
    public ushort GetSpice() => UInt16[SpiceOffset];
    
    /// <summary>
    /// Gets the date and time value (DS:0x1174).
    /// Packed format: contains day and time information.
    /// </summary>
    public ushort GetDateTime() => UInt16[DateTimeOffset];
    
    /// <summary>
    /// Gets the contact distance value (DS:0x1176).
    /// </summary>
    public byte GetContactDistance() => UInt8[ContactDistanceOffset];
    
    /// <summary>
    /// Gets the game elapsed time counter (DS:0x0002).
    /// </summary>
    public ushort GetGameElapsedTime() => UInt16[GameTimeOffset];
    
    /// <summary>
    /// Gets follower 1 ID from persons_traveling_with (DS:0x0010, low byte).
    /// </summary>
    public byte GetFollower1Id() => UInt8[PersonsTravelingWithOffset];
    
    /// <summary>
    /// Gets follower 2 ID from persons_traveling_with (DS:0x0010, high byte).
    /// </summary>
    public byte GetFollower2Id() => UInt8[PersonsTravelingWithOffset + 1];
    
    /// <summary>
    /// Gets the current room ID from persons_in_room (DS:0x0012, low byte).
    /// </summary>
    public byte GetCurrentRoomId() => UInt8[PersonsInRoomOffset];
    
    /// <summary>
    /// Gets the current speaker ID from persons_talking_to (DS:0x0014, low byte).
    /// </summary>
    public byte GetCurrentSpeakerId() => UInt8[PersonsTalkingToOffset];
    
    /// <summary>
    /// Gets the dialogue state from persons_talking_to (DS:0x0014, high byte).
    /// </summary>
    public byte GetDialogueState() => UInt8[PersonsTalkingToOffset + 1];
    
    /// <summary>
    /// Returns the count of discovered locations (not just sietches).
    /// A location is discovered if the UNDISCOVERED flag (0x80) is NOT set.
    /// </summary>
    /// <remarks>
    /// Note: This counts ALL discovered locations including palaces and villages,
    /// not just sietches. The method name is historical.
    /// </remarks>
    public int GetDiscoveredSietchCount() {
        int count = 0;
        for (int i = 0; i < MaxLocations; i++) {
            byte status = GetLocationStatus(i);
            // Location is discovered if UNDISCOVERED flag is NOT set
            if ((status & LocationStatusUndiscovered) == 0)
                count++;
        }
        return count;
    }
    
    /// <summary>
    /// Maps NPC ID to display name.
    /// </summary>
    public static string GetNpcName(byte npcId) {
        return npcId switch {
            0x00 => "Paul Atreides",
            0x01 => "Jessica",
            0x02 => "Thufir Hawat",
            0x03 => "Gurney Halleck",
            0x04 => "Duncan Idaho",
            0x05 => "Dr. Yueh",
            0x06 => "Stilgar",
            0x07 => "Chani",
            0x08 => "Harah",
            0x09 => "Baron Harkonnen",
            0x0A => "Feyd-Rautha",
            0x0B => "Duke Leto",
            0x0C => "Liet Kynes",
            0x0D => "Smuggler",
            0x0E => "Fremen",
            0x0F => "Unknown",
            _ => $"NPC #{npcId:X2}"
        };
    }
    
    // Display subsystem accessors (high DS offsets)
    
    /// <summary>
    /// Gets the HNM video finished flag (DS:0xDBE7).
    /// </summary>
    public byte GetHnmFinishedFlag() => UInt8[0xDBE7];
    
    /// <summary>
    /// Gets the HNM frame counter (DS:0xDBE8).
    /// </summary>
    public ushort GetHnmFrameCounter() => UInt16[0xDBE8];
    
    /// <summary>
    /// Gets the HNM file offset (DS:0xDBEA).
    /// </summary>
    public uint GetHnmFileOffset() => UInt32[0xDBEA];
    
    /// <summary>
    /// Gets the HNM file remaining bytes (DS:0xDBEE).
    /// </summary>
    public uint GetHnmFileRemain() => UInt32[0xDBEE];
    
    /// <summary>
    /// Gets the front framebuffer address (DS:0xDBD6).
    /// </summary>
    public ushort GetFramebufferFront() => UInt16[0xDBD6];
    
    /// <summary>
    /// Gets the back framebuffer address (DS:0xDBD8).
    /// </summary>
    public ushort GetFramebufferBack() => UInt16[0xDBD8];
    
    /// <summary>
    /// Gets the active framebuffer address (DS:0xDBDA).
    /// </summary>
    public ushort GetFramebufferActive() => UInt16[0xDBDA];
    
    /// <summary>
    /// Gets the screen buffer address (DS:0xDBDC).
    /// </summary>
    public ushort GetScreenBuffer() => UInt16[0xDBDC];
    
    /// <summary>
    /// Gets the transition bitmask (DS:0xDBDE).
    /// </summary>
    public ushort GetTransitionBitmask() => UInt16[0xDBDE];
    
    /// <summary>
    /// Gets the mouse X position (DS:0xDC38).
    /// </summary>
    public ushort GetMousePosX() => UInt16[0xDC38];
    
    /// <summary>
    /// Gets the mouse Y position (DS:0xDC3A).
    /// </summary>
    public ushort GetMousePosY() => UInt16[0xDC3A];
    
    /// <summary>
    /// Gets the cursor type (DS:0xDC3C).
    /// </summary>
    public byte GetCursorType() => UInt8[0xDC3C];
    
    // Property-style accessors for ViewModel compatibility
    public byte GameStage => GetGamePhase();
    public ushort Spice => GetSpice();
    public ushort DateTimeRaw => GetDateTime();
    public byte ContactDistance => GetContactDistance();
    public byte Follower1Id => GetFollower1Id();
    public byte Follower2Id => GetFollower2Id();
    public byte CurrentRoomId => GetCurrentRoomId();
    public byte CurrentSpeakerId => GetCurrentSpeakerId();
    public ushort DialogueState => (ushort)GetDialogueState();
    
    // Display/HNM properties
    public byte HnmFinishedFlag => GetHnmFinishedFlag();
    public ushort HnmFrameCounter => GetHnmFrameCounter();
    public uint HnmFileOffset => GetHnmFileOffset();
    public uint HnmFileRemain => GetHnmFileRemain();
    public ushort FramebufferFront => GetFramebufferFront();
    public ushort FramebufferBack => GetFramebufferBack();
    public ushort FramebufferActive => GetFramebufferActive();
    public ushort ScreenBuffer => GetScreenBuffer();
    public ushort MousePosX => GetMousePosX();
    public ushort MousePosY => GetMousePosY();
    public byte CursorType => GetCursorType();
    public byte TransitionBitmask => (byte)GetTransitionBitmask();
    
    // Helper methods for formatting
    public string GetFormattedSpice() => $"{Spice:N0} kg";
    
    public string GetFormattedDateTime() {
        ushort raw = DateTimeRaw;
        // Simple approximation: day = high byte, hour = low byte / 10
        int day = (raw >> 8) + 1;
        int hour = (raw & 0xFF) / 10;
        return $"Day {day}, {hour:D2}:00";
    }
    
    public string GetGameStageDescription() {
        return GameStage switch {
            0x01 => "Start of game",
            0x02 => "Talked about stillsuit",
            0x03 => "Learning about stillsuit",
            0x04 => "Stillsuit briefing complete",
            0x05 => "Met spice prospectors",
            0x06 => "Got stillsuits",
            _ => $"Stage 0x{GameStage:X2}"
        };
    }
    
    public int GetActiveTroopCount() {
        int count = 0;
        for (int i = 0; i < MaxTroops; i++) {
            if (IsTroopActive(i)) count++;
        }
        return count;
    }
    
    public int GetDiscoveredLocationCount() => GetDiscoveredSietchCount();
    
    // Placeholder properties that may not exist in current memory layout
    public ushort WorldPosX => 0; // TODO: Find actual offset
    public ushort WorldPosY => 0; // TODO: Find actual offset
    public ushort WaterReserve => 0; // TODO: Find actual offset
    public ushort SpiceReserve => 0; // TODO: Find actual offset
    public uint Money => 0; // TODO: Find actual offset
    public byte MilitaryStrength => 0; // TODO: Find actual offset
    public byte EcologyProgress => 0; // TODO: Find actual offset
    
    // Additional HNM properties (placeholders)
    public ushort HnmCounter2 => 0;
    public byte CurrentHnmResourceFlag => 0;
    public ushort HnmVideoId => 0;
    public ushort HnmActiveVideoId => 0;
    
    // Additional mouse properties
    public ushort MouseDrawPosX => MousePosX;
    public ushort MouseDrawPosY => MousePosY;
    public byte CursorHideCounter => 0;
    public ushort MapCursorType => 0;
    
    // Sound property
    public byte IsSoundPresent => 0;
    public ushort MidiFunc5ReturnBx => 0;
}
