namespace Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.CPU.Registers;
using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;

/// <summary>
/// Provides access to Dune game state values stored in emulated memory.
/// </summary>
/// <remarks>
/// <para>
/// This class provides read access to key game state values from the Dune CD game.
/// The memory offsets are based on the runtime mappings documented in the problem statement.
/// </para>
/// <para>
/// Memory layout reference (relative to DS segment 0x10ED):
/// </para>
/// <list type="table">
/// <listheader>
/// <term>Field Name</term>
/// <description>Offset and Details</description>
/// </listheader>
/// <item>
/// <term>Spice</term>
/// <description>0x009F-0x00A0 (2 bytes) - Total spice in kilograms</description>
/// </item>
/// <item>
/// <term>Charisma</term>
/// <description>0x0029 (1 byte) - Player charisma value (0x01-0xFF)</description>
/// </item>
/// <item>
/// <term>Contact Distance</term>
/// <description>0x1176 (1 byte) - Distance for contacting Fremen</description>
/// </item>
/// <item>
/// <term>Date &amp; Time</term>
/// <description>0x1174 (2 bytes) - Encoded date and time</description>
/// </item>
/// <item>
/// <term>Game Stage</term>
/// <description>0x002A (1 byte) - Current game progression stage</description>
/// </item>
/// </list>
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

    // Memory offsets are relative to DS segment base (typically 0x10ED at runtime)
    // The offsets below map to the documented save file runtime mappings

    /// <summary>
    /// Gets the total spice amount in kilograms.
    /// </summary>
    /// <remarks>
    /// Located at offset 0x009F-0x00A0 (2 bytes).
    /// Example: 0x01E7 = 43270 kg (raw value needs conversion).
    /// </remarks>
    public ushort Spice => UInt16[0x009F];

    /// <summary>
    /// Gets the player's charisma level.
    /// </summary>
    /// <remarks>
    /// Located at offset 0x0029 (1 byte).
    /// Value increases as player enlists more Fremen troops.
    /// Example: 0x50 = 25 charisma points.
    /// </remarks>
    public byte Charisma => UInt8[0x0029];

    /// <summary>
    /// Gets the contact distance for reaching Fremen sietches.
    /// </summary>
    /// <remarks>
    /// Located at offset 0x1176 (1 byte).
    /// Example: 0x32 = 50 distance units.
    /// </remarks>
    public byte ContactDistance => UInt8[0x1176];

    /// <summary>
    /// Gets the raw date and time value.
    /// </summary>
    /// <remarks>
    /// Located at offset 0x1174 (2 bytes).
    /// Encoded format: Example 0x6201 = 23rd day, 7h30.
    /// </remarks>
    public ushort DateTimeRaw => UInt16[0x1174];

    /// <summary>
    /// Gets the current game stage/progression.
    /// </summary>
    /// <remarks>
    /// <para>Located at offset 0x002A (1 byte).</para>
    /// <para>Known values:</para>
    /// <list type="bullet">
    /// <item><description>0x01: Start of game</description></item>
    /// <item><description>0x02-0x06: Various dialogue progression states</description></item>
    /// <item><description>0x4F: Can ride worms</description></item>
    /// <item><description>0x50: Have ridden a worm</description></item>
    /// </list>
    /// </remarks>
    public byte GameStage => UInt8[0x002A];

    /// <summary>
    /// Gets the game elapsed time from offset 0x2.
    /// </summary>
    /// <remarks>
    /// Located at offset 0x0002 (2 bytes).
    /// </remarks>
    public ushort GameElapsedTime => UInt16[0x0002];

    /// <summary>
    /// Decodes the day from the raw date/time value.
    /// </summary>
    /// <returns>The current day number.</returns>
    public int GetDay() {
        // The date encoding places day in the upper byte
        return (DateTimeRaw >> 8) & 0xFF;
    }

    /// <summary>
    /// Decodes the hour from the raw date/time value.
    /// </summary>
    /// <returns>The current hour (0-23).</returns>
    public int GetHour() {
        // Hour is encoded in bits 4-7 of the lower byte
        return (DateTimeRaw & 0xF0) >> 4;
    }

    /// <summary>
    /// Decodes the minutes from the raw date/time value.
    /// </summary>
    /// <returns>The current minutes (typically 0 or 30).</returns>
    public int GetMinutes() {
        // Minutes are encoded in bits 0-3 of the lower byte (in 30-min increments)
        return (DateTimeRaw & 0x0F) * 30;
    }

    /// <summary>
    /// Gets a formatted string representation of the game time.
    /// </summary>
    /// <returns>A string like "Day 23, 07:30".</returns>
    public string GetFormattedDateTime() {
        return $"Day {GetDay()}, {GetHour():D2}:{GetMinutes():D2}";
    }

    /// <summary>
    /// Gets the spice amount in a human-readable format with units.
    /// </summary>
    /// <returns>Spice amount in kilograms.</returns>
    public string GetFormattedSpice() {
        // The raw value appears to be in 10kg units based on the documentation
        return $"{Spice * 10} kg";
    }

    /// <summary>
    /// Gets a description of the current game stage.
    /// </summary>
    /// <returns>A human-readable description of the game stage.</returns>
    public string GetGameStageDescription() {
        return GameStage switch {
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
    }
}
