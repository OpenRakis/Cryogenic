namespace Cryogenic.GameEngineWindow.Models;

/// <summary>
/// Partial class for Troop-related memory access.
/// </summary>
/// <remarks>
/// Troops array is at DS:0xAA76, 27 bytes per entry, 68 entries max.
/// Structure from odrade:
/// - Offset 0: occupation (u8) - troop type
/// - Offset 1: position_in_sietch (u8)
/// - Offset 2: position_in_location (u8)
/// - Offset 3-4: population (u16)
/// - And more fields for skills, equipment, motivation...
/// </remarks>
public partial class DuneGameState {
    
    /// <summary>
    /// Gets the base DS-relative offset for a troop entry.
    /// </summary>
    private int GetTroopOffset(int index) {
        if (index < 0 || index >= MaxTroops)
            throw new ArgumentOutOfRangeException(nameof(index), 
                $"Troop index must be between 0 and {MaxTroops - 1}");
        return TroopArrayOffset + (index * TroopEntrySize);
    }
    
    /// <summary>
    /// Gets the troop occupation/type (DS:0xAA76 + index*27 + 0).
    /// </summary>
    public byte GetTroopOccupation(int index) => UInt8[GetTroopOffset(index)];
    
    /// <summary>
    /// Gets the troop position in sietch (DS:0xAA76 + index*27 + 1).
    /// </summary>
    public byte GetTroopPositionInSietch(int index) => UInt8[GetTroopOffset(index) + 1];
    
    /// <summary>
    /// Gets the troop position in location (DS:0xAA76 + index*27 + 2).
    /// </summary>
    public byte GetTroopPosition(int index) => UInt8[GetTroopOffset(index) + 2];
    
    /// <summary>
    /// Gets the troop population (DS:0xAA76 + index*27 + 3, u16).
    /// </summary>
    public ushort GetTroopPopulation(int index) => UInt16[GetTroopOffset(index) + 3];
    
    /// <summary>
    /// Gets the troop spice mining skill (DS:0xAA76 + index*27 + 5).
    /// </summary>
    public byte GetTroopSpiceSkill(int index) => UInt8[GetTroopOffset(index) + 5];
    
    /// <summary>
    /// Gets the troop army skill (DS:0xAA76 + index*27 + 6).
    /// </summary>
    public byte GetTroopArmySkill(int index) => UInt8[GetTroopOffset(index) + 6];
    
    /// <summary>
    /// Gets the troop ecology skill (DS:0xAA76 + index*27 + 7).
    /// </summary>
    public byte GetTroopEcologySkill(int index) => UInt8[GetTroopOffset(index) + 7];
    
    /// <summary>
    /// Gets the troop equipment level (DS:0xAA76 + index*27 + 8).
    /// </summary>
    public byte GetTroopEquipment(int index) => UInt8[GetTroopOffset(index) + 8];
    
    /// <summary>
    /// Gets the troop motivation level (DS:0xAA76 + index*27 + 9).
    /// </summary>
    public byte GetTroopMotivation(int index) => UInt8[GetTroopOffset(index) + 9];
    
    /// <summary>
    /// Gets the troop dissatisfaction level (DS:0xAA76 + index*27 + 10).
    /// </summary>
    public byte GetTroopDissatisfaction(int index) => UInt8[GetTroopOffset(index) + 10];
    
    /// <summary>
    /// Checks if a troop is Fremen (vs Harkonnen).
    /// Fremen occupations are 0x00 and 0x02 (without high bit flags).
    /// </summary>
    public bool IsTroopFremen(int index) {
        byte occupation = GetTroopOccupation(index);
        byte baseOccupation = (byte)(occupation & 0x7F);
        // Fremen occupations are 0x00 and 0x02, or slaved Fremen (occupation >= 0xA0)
        return baseOccupation == 0x00 || baseOccupation == 0x02 || occupation >= 0xA0;
    }
    
    /// <summary>
    /// Checks if a troop is active (population > 0).
    /// </summary>
    public bool IsTroopActive(int index) => GetTroopPopulation(index) > 0;
    
    /// <summary>
    /// Gets a description of the troop occupation.
    /// </summary>
    public static string GetTroopOccupationDescription(byte occupation) {
        byte baseOcc = (byte)(occupation & 0x0F);
        bool isSlaved = (occupation & 0x80) != 0;
        
        string desc = baseOcc switch {
            0x00 => "Fremen Troop",
            0x02 => "Fremen Warriors",
            0x0C => "Harkonnen Patrol",
            0x0D => "Harkonnen Troopers",
            0x0E => "Harkonnen Troop",
            0x0F => "Harkonnen Army",
            0x1F => "Harkonnen Elite",
            _ => $"Unknown (0x{occupation:X2})"
        };
        
        return isSlaved ? $"{desc} (Slaved)" : desc;
    }
    
    /// <summary>
    /// Gets a description of the troop equipment level.
    /// </summary>
    public static string GetTroopEquipmentDescription(byte equipment) {
        return equipment switch {
            0 => "None",
            1 => "Basic",
            2 => "Standard",
            3 => "Advanced",
            4 => "Elite",
            _ => $"Level {equipment}"
        };
    }
    
    // Aliases for ViewModel compatibility
    public byte GetTroopId(int index) => GetTroopOccupation(index);
}
