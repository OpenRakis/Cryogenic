namespace Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.CPU.Registers;
using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Provides access to Dune game state values stored in emulated memory.
/// </summary>
/// <remarks>
/// <para>
/// This class provides read access to live game state values from the Dune CD game memory.
/// The memory is read directly from the emulator at runtime, not from savegame files.
/// </para>
/// <para>
/// Memory regions per madmoose's analysis (from seg000:B427 sub_1B427_create_save_in_memory):
/// - From DS:[DCFE], 12671 bytes (2 bits for each byte of the next 50684 bytes)
/// - From CS:00AA, 162 bytes (includes some code)
/// - From DS:AA76, 4600 bytes
/// - From DS:0000, 4705 bytes
/// </para>
/// <para>
/// Memory layout reference (relative to DS segment):
/// </para>
/// </remarks>
public class DuneGameState : MemoryBasedDataStructureWithDsBaseAddress {
    /// <summary>
    /// Initializes a new instance of the <see cref="DuneGameState"/> class.
    /// </summary>
    /// <param name="memory">The memory reader/writer interface for accessing emulated memory.</param>
    /// <param name="segmentRegisters">The CPU segment registers used to calculate absolute addresses.</param>
    public DuneGameState(IByteReaderWriter memory, SegmentRegisters segmentRegisters) 
        : base(memory, segmentRegisters) {
    }

    #region Core Game State (DS:0000 region, 4705 bytes)
    
    /// <summary>
    /// Gets the game elapsed time from offset 0x2.
    /// </summary>
    public ushort GameElapsedTime => UInt16[0x0002];

    /// <summary>
    /// Gets the player's charisma level (offset 0x0029).
    /// Value increases as player enlists more Fremen troops.
    /// </summary>
    public byte Charisma => UInt8[0x0029];

    /// <summary>
    /// Gets the current game stage/progression (offset 0x002A).
    /// </summary>
    public byte GameStage => UInt8[0x002A];

    /// <summary>
    /// Gets the total spice amount (offset 0x009F, 2 bytes).
    /// </summary>
    public ushort Spice => UInt16[0x009F];

    /// <summary>
    /// Gets the raw date and time value (offset 0x1174, 2 bytes).
    /// </summary>
    public ushort DateTimeRaw => UInt16[0x1174];

    /// <summary>
    /// Gets the contact distance for reaching Fremen sietches (offset 0x1176).
    /// </summary>
    public byte ContactDistance => UInt8[0x1176];

    #endregion

    #region HNM Video State
    
    /// <summary>
    /// HNM finished flag (offset 0xDBE7).
    /// </summary>
    public byte HnmFinishedFlag => UInt8[0xDBE7];

    /// <summary>
    /// HNM frame counter (offset 0xDBE8, 2 bytes).
    /// </summary>
    public ushort HnmFrameCounter => UInt16[0xDBE8];

    /// <summary>
    /// HNM counter 2 (offset 0xDBEA, 2 bytes).
    /// </summary>
    public ushort HnmCounter2 => UInt16[0xDBEA];

    /// <summary>
    /// Current HNM resource flag (offset 0xDBFE).
    /// </summary>
    public byte CurrentHnmResourceFlag => UInt8[0xDBFE];

    /// <summary>
    /// HNM video ID (offset 0xDC00, 2 bytes).
    /// </summary>
    public ushort HnmVideoId => UInt16[0xDC00];

    /// <summary>
    /// HNM active video ID (offset 0xDC02, 2 bytes).
    /// </summary>
    public ushort HnmActiveVideoId => UInt16[0xDC02];

    /// <summary>
    /// HNM file offset (offset 0xDC04, 4 bytes).
    /// </summary>
    public uint HnmFileOffset => UInt32[0xDC04];

    /// <summary>
    /// HNM file remaining bytes (offset 0xDC08, 4 bytes).
    /// </summary>
    public uint HnmFileRemain => UInt32[0xDC08];

    #endregion

    #region Display and Graphics State
    
    /// <summary>
    /// Front framebuffer segment (offset 0xDBD6).
    /// </summary>
    public ushort FramebufferFront => UInt16[0xDBD6];

    /// <summary>
    /// Screen buffer segment (offset 0xDBD8).
    /// </summary>
    public ushort ScreenBuffer => UInt16[0xDBD8];

    /// <summary>
    /// Active framebuffer segment (offset 0xDBDA).
    /// </summary>
    public ushort FramebufferActive => UInt16[0xDBDA];

    /// <summary>
    /// Back framebuffer segment (offset 0xDC32).
    /// </summary>
    public ushort FramebufferBack => UInt16[0xDC32];

    #endregion

    #region Mouse and Cursor State
    
    /// <summary>
    /// Mouse Y position (offset 0xDC36).
    /// </summary>
    public ushort MousePosY => UInt16[0xDC36];

    /// <summary>
    /// Mouse X position (offset 0xDC38).
    /// </summary>
    public ushort MousePosX => UInt16[0xDC38];

    /// <summary>
    /// Mouse draw Y position (offset 0xDC42).
    /// </summary>
    public ushort MouseDrawPosY => UInt16[0xDC42];

    /// <summary>
    /// Mouse draw X position (offset 0xDC44).
    /// </summary>
    public ushort MouseDrawPosX => UInt16[0xDC44];

    /// <summary>
    /// Cursor hide counter (offset 0xDC46).
    /// </summary>
    public byte CursorHideCounter => UInt8[0xDC46];

    /// <summary>
    /// Map cursor type (offset 0xDC58).
    /// </summary>
    public ushort MapCursorType => UInt16[0xDC58];

    #endregion

    #region Sound State
    
    /// <summary>
    /// Is sound present flag (offset 0xDBCD).
    /// </summary>
    public byte IsSoundPresent => UInt8[0xDBCD];

    /// <summary>
    /// MIDI func5 return Bx (offset 0xDBCE).
    /// </summary>
    public ushort MidiFunc5ReturnBx => UInt16[0xDBCE];

    #endregion

    #region Transition and Effects State
    
    /// <summary>
    /// Transition bitmask (offset 0xDCE6).
    /// </summary>
    public byte TransitionBitmask => UInt8[0xDCE6];

    #endregion

    #region Sietch/Location Data (from DS:AA76 region - around 4600 bytes)
    
    // Sietch structure starts around DS:AA76, each sietch entry is approximately 28 bytes
    // Based on the savegame analysis, there are up to 70 sietches
    private const int SIETCH_BASE_OFFSET = 0xAA76;
    private const int SIETCH_ENTRY_SIZE = 28;
    private const int MAX_SIETCHES = 70;

    /// <summary>
    /// Gets the status byte for a sietch at the given index.
    /// </summary>
    /// <param name="index">Sietch index (0-69).</param>
    /// <returns>The status byte for the sietch.</returns>
    public byte GetSietchStatus(int index) {
        if (index < 0 || index >= MAX_SIETCHES) return 0;
        return UInt8[SIETCH_BASE_OFFSET + (index * SIETCH_ENTRY_SIZE)];
    }

    /// <summary>
    /// Gets the spice field amount at a sietch.
    /// </summary>
    /// <param name="index">Sietch index (0-69).</param>
    /// <returns>The spice field amount.</returns>
    public ushort GetSietchSpiceField(int index) {
        if (index < 0 || index >= MAX_SIETCHES) return 0;
        return UInt16[SIETCH_BASE_OFFSET + (index * SIETCH_ENTRY_SIZE) + 2];
    }

    /// <summary>
    /// Gets the coordinates for a sietch.
    /// </summary>
    /// <param name="index">Sietch index (0-69).</param>
    /// <returns>Tuple of (X, Y) coordinates.</returns>
    public (ushort X, ushort Y) GetSietchCoordinates(int index) {
        if (index < 0 || index >= MAX_SIETCHES) return (0, 0);
        var baseOffset = SIETCH_BASE_OFFSET + (index * SIETCH_ENTRY_SIZE);
        return (UInt16[baseOffset + 4], UInt16[baseOffset + 6]);
    }

    #endregion

    #region Troops Data (following Sietches in memory)
    
    // Troop structure follows sietches, each troop entry is approximately 27 bytes
    // Based on the savegame analysis, there can be up to 68 troops
    private const int TROOP_BASE_OFFSET = 0xAA76 + (SIETCH_ENTRY_SIZE * MAX_SIETCHES); // After sietches
    private const int TROOP_ENTRY_SIZE = 27;
    private const int MAX_TROOPS = 68;

    /// <summary>
    /// Gets the troop type/occupation for a troop at the given index.
    /// </summary>
    /// <param name="index">Troop index (0-67).</param>
    /// <returns>The troop occupation byte.</returns>
    public byte GetTroopOccupation(int index) {
        if (index < 0 || index >= MAX_TROOPS) return 0;
        return UInt8[TROOP_BASE_OFFSET + (index * TROOP_ENTRY_SIZE)];
    }

    /// <summary>
    /// Gets the troop location ID.
    /// </summary>
    /// <param name="index">Troop index (0-67).</param>
    /// <returns>The location ID where the troop is stationed.</returns>
    public byte GetTroopLocation(int index) {
        if (index < 0 || index >= MAX_TROOPS) return 0;
        return UInt8[TROOP_BASE_OFFSET + (index * TROOP_ENTRY_SIZE) + 1];
    }

    /// <summary>
    /// Gets the troop motivation level.
    /// </summary>
    /// <param name="index">Troop index (0-67).</param>
    /// <returns>The motivation level.</returns>
    public byte GetTroopMotivation(int index) {
        if (index < 0 || index >= MAX_TROOPS) return 0;
        return UInt8[TROOP_BASE_OFFSET + (index * TROOP_ENTRY_SIZE) + 4];
    }

    /// <summary>
    /// Gets the troop spice skill level.
    /// </summary>
    /// <param name="index">Troop index (0-67).</param>
    /// <returns>The spice harvesting skill level.</returns>
    public byte GetTroopSpiceSkill(int index) {
        if (index < 0 || index >= MAX_TROOPS) return 0;
        return UInt8[TROOP_BASE_OFFSET + (index * TROOP_ENTRY_SIZE) + 5];
    }

    /// <summary>
    /// Gets the troop army skill level.
    /// </summary>
    /// <param name="index">Troop index (0-67).</param>
    /// <returns>The army/combat skill level.</returns>
    public byte GetTroopArmySkill(int index) {
        if (index < 0 || index >= MAX_TROOPS) return 0;
        return UInt8[TROOP_BASE_OFFSET + (index * TROOP_ENTRY_SIZE) + 6];
    }

    /// <summary>
    /// Gets the troop ecology skill level.
    /// </summary>
    /// <param name="index">Troop index (0-67).</param>
    /// <returns>The ecology skill level.</returns>
    public byte GetTroopEcologySkill(int index) {
        if (index < 0 || index >= MAX_TROOPS) return 0;
        return UInt8[TROOP_BASE_OFFSET + (index * TROOP_ENTRY_SIZE) + 7];
    }

    /// <summary>
    /// Gets the troop equipment flags.
    /// </summary>
    /// <param name="index">Troop index (0-67).</param>
    /// <returns>Equipment flags byte.</returns>
    public byte GetTroopEquipment(int index) {
        if (index < 0 || index >= MAX_TROOPS) return 0;
        return UInt8[TROOP_BASE_OFFSET + (index * TROOP_ENTRY_SIZE) + 8];
    }

    /// <summary>
    /// Gets a description of the troop occupation.
    /// </summary>
    public static string GetTroopOccupationDescription(byte occupation) => occupation switch {
        0 => "Idle",
        1 => "Spice Harvesting",
        2 => "Military",
        3 => "Ecology",
        4 => "Moving",
        _ => $"Unknown (0x{occupation:X2})"
    };

    #endregion

    #region NPCs/Characters Data
    
    // NPCs include main characters like Paul's followers
    // These are at specific offsets in memory
    
    /// <summary>
    /// Follower 1 ID (offset 0x0019).
    /// </summary>
    public byte Follower1Id => UInt8[0x0019];

    /// <summary>
    /// Follower 2 ID (offset 0x001A).
    /// </summary>
    public byte Follower2Id => UInt8[0x001A];

    /// <summary>
    /// Current room/location ID (offset 0x001B).
    /// </summary>
    public byte CurrentRoomId => UInt8[0x001B];

    /// <summary>
    /// World map X position (offset 0x001C).
    /// </summary>
    public ushort WorldPosX => UInt16[0x001C];

    /// <summary>
    /// World map Y position (offset 0x001E).
    /// </summary>
    public ushort WorldPosY => UInt16[0x001E];

    /// <summary>
    /// Gets the NPC name from the character ID.
    /// </summary>
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

    #endregion

    #region Player Stats
    
    /// <summary>
    /// Player's water reserve (offset 0x0020, 2 bytes).
    /// </summary>
    public ushort WaterReserve => UInt16[0x0020];

    /// <summary>
    /// Spice reserve (personal, not total harvested) (offset 0x0022, 2 bytes).
    /// </summary>
    public ushort SpiceReserve => UInt16[0x0022];

    /// <summary>
    /// Money/Solaris amount (offset 0x0024, 4 bytes).
    /// </summary>
    public uint Money => UInt32[0x0024];

    /// <summary>
    /// Military strength indicator (offset 0x002B).
    /// </summary>
    public byte MilitaryStrength => UInt8[0x002B];

    /// <summary>
    /// Ecological progress indicator (offset 0x002C).
    /// </summary>
    public byte EcologyProgress => UInt8[0x002C];

    #endregion

    #region Dialogue State
    
    /// <summary>
    /// Current dialogue speaker ID (offset 0xDC8C).
    /// </summary>
    public byte CurrentSpeakerId => UInt8[0xDC8C];

    /// <summary>
    /// Dialogue state/flags (offset 0xDC8E).
    /// </summary>
    public ushort DialogueState => UInt16[0xDC8E];

    #endregion

    #region Helper Methods
    
    /// <summary>
    /// Decodes the day from the raw date/time value.
    /// </summary>
    public int GetDay() => (DateTimeRaw >> 8) & 0xFF;

    /// <summary>
    /// Decodes the hour from the raw date/time value.
    /// </summary>
    public int GetHour() => (DateTimeRaw & 0xF0) >> 4;

    /// <summary>
    /// Decodes the minutes from the raw date/time value.
    /// </summary>
    public int GetMinutes() => (DateTimeRaw & 0x0F) * 30;

    /// <summary>
    /// Gets a formatted string representation of the game time.
    /// </summary>
    public string GetFormattedDateTime() => $"Day {GetDay()}, {GetHour():D2}:{GetMinutes():D2}";

    /// <summary>
    /// Gets the spice amount in a human-readable format.
    /// </summary>
    public string GetFormattedSpice() => $"{Spice * 10} kg";

    /// <summary>
    /// Gets a description of the current game stage.
    /// </summary>
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

    /// <summary>
    /// Gets the number of active troops.
    /// </summary>
    public int GetActiveTroopCount() {
        int count = 0;
        for (int i = 0; i < MAX_TROOPS; i++) {
            if (GetTroopOccupation(i) != 0) count++;
        }
        return count;
    }

    /// <summary>
    /// Gets the number of discovered sietches.
    /// </summary>
    public int GetDiscoveredSietchCount() {
        int count = 0;
        for (int i = 0; i < MAX_SIETCHES; i++) {
            if (GetSietchStatus(i) != 0) count++;
        }
        return count;
    }

    #endregion
}
