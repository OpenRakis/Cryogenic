namespace Cryogenic.GameEngineWindow.Models;

/// <summary>
/// Partial class for Smuggler-related memory access.
/// </summary>
/// <remarks>
/// Smugglers array follows NPCs in memory at DS:0xAD2E (NPCs end at 0xAC2E + 16*16 = 0xAD2E).
/// 17 bytes per entry, 6 entries max.
/// Structure from odrade:
/// - Offset 0: location_index (u8)
/// - Offset 1: inventory_harvesters (u8)
/// - Offset 2: inventory_ornithopters (u8)
/// - Offset 3: inventory_weapons (u8)
/// - Offset 4-5: price_harvesters (u16)
/// - Offset 6-7: price_ornithopters (u16)
/// - Offset 8-9: price_weapons (u16)
/// - Offset 10: haggle_willingness (u8)
/// - And more fields...
/// Plus 3 bytes padding = 17 bytes total
/// </remarks>
public partial class DuneGameState {
    
    // Smugglers array DS-relative
    public const int SmugglerArrayOffset = 0xAD2E;         // After NPCs: 0xAC2E + 16*16
    public const int SmugglerEntrySize = 17;               // 14 bytes data + 3 bytes padding
    public const int MaxSmugglers = 6;
    
    /// <summary>
    /// Gets the base DS-relative offset for a smuggler entry.
    /// </summary>
    private int GetSmugglerOffset(int index) {
        if (index < 0 || index >= MaxSmugglers)
            throw new ArgumentOutOfRangeException(nameof(index), 
                $"Smuggler index must be between 0 and {MaxSmugglers - 1}");
        return SmugglerArrayOffset + (index * SmugglerEntrySize);
    }
    
    /// <summary>
    /// Gets the smuggler location index (DS:0xAD2E + index*17 + 0).
    /// </summary>
    public byte GetSmugglerLocationIndex(int index) => UInt8[GetSmugglerOffset(index)];
    
    /// <summary>
    /// Gets the smuggler harvester inventory count (DS:0xAD2E + index*17 + 1).
    /// </summary>
    public byte GetSmugglerInventoryHarvesters(int index) => UInt8[GetSmugglerOffset(index) + 1];
    
    /// <summary>
    /// Gets the smuggler ornithopter inventory count (DS:0xAD2E + index*17 + 2).
    /// </summary>
    public byte GetSmugglerInventoryOrnithopters(int index) => UInt8[GetSmugglerOffset(index) + 2];
    
    /// <summary>
    /// Gets the smuggler weapon inventory count (DS:0xAD2E + index*17 + 3).
    /// </summary>
    public byte GetSmugglerInventoryWeapons(int index) => UInt8[GetSmugglerOffset(index) + 3];
    
    /// <summary>
    /// Gets the smuggler harvester price (DS:0xAD2E + index*17 + 4, u16).
    /// </summary>
    public ushort GetSmugglerPriceHarvesters(int index) => UInt16[GetSmugglerOffset(index) + 4];
    
    /// <summary>
    /// Gets the smuggler ornithopter price (DS:0xAD2E + index*17 + 6, u16).
    /// </summary>
    public ushort GetSmugglerPriceOrnithopters(int index) => UInt16[GetSmugglerOffset(index) + 6];
    
    /// <summary>
    /// Gets the smuggler weapon price (DS:0xAD2E + index*17 + 8, u16).
    /// </summary>
    public ushort GetSmugglerPriceWeapons(int index) => UInt16[GetSmugglerOffset(index) + 8];
    
    /// <summary>
    /// Gets the smuggler haggle willingness (DS:0xAD2E + index*17 + 10).
    /// </summary>
    public byte GetSmugglerHaggleWillingness(int index) => UInt8[GetSmugglerOffset(index) + 10];
    
    // Alias methods for ViewModel compatibility
    public ushort GetSmugglerHarvesterPrice(int index) => GetSmugglerPriceHarvesters(index);
    public ushort GetSmugglerOrnithopterPrice(int index) => GetSmugglerPriceOrnithopters(index);
    public ushort GetSmugglerKrysKnifePrice(int index) => GetSmugglerPriceWeapons(index);
    public ushort GetSmugglerLaserGunPrice(int index) => GetSmugglerPriceWeapons(index);
    public ushort GetSmugglerWeirdingModulePrice(int index) => GetSmugglerPriceWeapons(index);
    
    public byte GetSmugglerRegion(int index) => GetSmugglerLocationIndex(index);
    public string GetSmugglerLocationName(int index) {
        byte locIndex = GetSmugglerLocationIndex(index);
        if (locIndex < MaxLocations) {
            return GetLocationNameStr(GetLocationNameFirst(locIndex), GetLocationNameSecond(locIndex));
        }
        return $"Location {locIndex}";
    }
    public byte GetSmugglerWillingnessToHaggle(int index) => GetSmugglerHaggleWillingness(index);
    public byte GetSmugglerHarvesters(int index) => GetSmugglerInventoryHarvesters(index);
    public byte GetSmugglerOrnithopters(int index) => GetSmugglerInventoryOrnithopters(index);
    public byte GetSmugglerKrysKnives(int index) => GetSmugglerInventoryWeapons(index);
    public byte GetSmugglerLaserGuns(int index) => GetSmugglerInventoryWeapons(index);
    public byte GetSmugglerWeirdingModules(int index) => GetSmugglerInventoryWeapons(index);
}
