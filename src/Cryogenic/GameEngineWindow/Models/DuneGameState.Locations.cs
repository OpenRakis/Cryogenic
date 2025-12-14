namespace Cryogenic.GameEngineWindow.Models;

/// <summary>
/// Partial class for Location/Sietch-related memory access.
/// </summary>
/// <remarks>
/// Locations array is at DS:0x0100, 28 bytes per entry, 70 entries max.
/// Structure from odrade and thomas.fach-pedersen.net:
/// - Offset 0: name_first (u8)
/// - Offset 1: name_second (u8) - used to determine location type
/// - Offset 2: status (u8) - bit flags for vegetation, battle, discovered, etc.
/// - Offset 3: map_x (u8)
/// - Offset 4: map_y (u8)
/// - Offset 5: spice_field (u8)
/// - Offset 6: water (u8)
/// - And more fields...
/// </remarks>
public partial class DuneGameState {
    
    /// <summary>
    /// Gets the base DS-relative offset for a location entry.
    /// </summary>
    private int GetLocationOffset(int index) {
        if (index < 0 || index >= MaxLocations)
            throw new ArgumentOutOfRangeException(nameof(index), 
                $"Location index must be between 0 and {MaxLocations - 1}");
        return LocationArrayOffset + (index * LocationEntrySize);
    }
    
    /// <summary>
    /// Gets the first byte of the location name (DS:0x0100 + index*28 + 0).
    /// </summary>
    public byte GetLocationNameFirst(int index) => UInt8[GetLocationOffset(index)];
    
    /// <summary>
    /// Gets the second byte of the location name (DS:0x0100 + index*28 + 1).
    /// Used to determine location type (palace, village, sietch).
    /// </summary>
    public byte GetLocationNameSecond(int index) => UInt8[GetLocationOffset(index) + 1];
    
    /// <summary>
    /// Gets the location status flags (DS:0x0100 + index*28 + 2).
    /// Bit flags: 0x01=Vegetation, 0x02=InBattle, 0x04=Inventory, 
    ///            0x10=Windtrap, 0x40=Prospected, 0x80=Undiscovered
    /// </summary>
    public byte GetLocationStatus(int index) => UInt8[GetLocationOffset(index) + 2];
    
    /// <summary>
    /// Gets the location map X coordinate (DS:0x0100 + index*28 + 3).
    /// </summary>
    public byte GetLocationMapX(int index) => UInt8[GetLocationOffset(index) + 3];
    
    /// <summary>
    /// Gets the location map Y coordinate (DS:0x0100 + index*28 + 4).
    /// </summary>
    public byte GetLocationMapY(int index) => UInt8[GetLocationOffset(index) + 4];
    
    /// <summary>
    /// Gets the location coordinates as a tuple (X, Y).
    /// </summary>
    public (byte X, byte Y) GetLocationCoordinates(int index) {
        int offset = GetLocationOffset(index);
        return (UInt8[offset + 3], UInt8[offset + 4]);
    }
    
    /// <summary>
    /// Gets the spice field value (DS:0x0100 + index*28 + 5).
    /// </summary>
    public byte GetLocationSpiceField(int index) => UInt8[GetLocationOffset(index) + 5];
    
    /// <summary>
    /// Gets the water value (DS:0x0100 + index*28 + 6).
    /// </summary>
    public byte GetLocationWater(int index) => UInt8[GetLocationOffset(index) + 6];
    
    /// <summary>
    /// Gets the equipment value (DS:0x0100 + index*28 + 7).
    /// </summary>
    public byte GetLocationEquipment(int index) => UInt8[GetLocationOffset(index) + 7];
    
    /// <summary>
    /// Determines the location type based on name_second byte.
    /// </summary>
    public string GetLocationTypeStr(int index) {
        byte nameSecond = GetLocationNameSecond(index);
        return nameSecond switch {
            0x00 => "Atreides Palace",
            0x01 => "Harkonnen Palace",
            0x02 => "Village (Pyons)",
            >= 0x03 and <= 0x09 => "Sietch",
            0x0B => "Sietch",
            _ => $"Unknown (0x{nameSecond:X2})"
        };
    }
}
