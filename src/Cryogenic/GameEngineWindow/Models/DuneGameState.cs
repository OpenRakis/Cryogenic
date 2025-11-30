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

    #endregion
}
