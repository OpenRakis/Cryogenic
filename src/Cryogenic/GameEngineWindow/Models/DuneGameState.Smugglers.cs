namespace Cryogenic.GameEngineWindow.Models;

/// <summary>
/// Smuggler structure accessors for Dune game state.
/// </summary>
/// <remarks>
/// Smuggler structure (14 bytes per entry + 3 bytes padding = 17 bytes total, 6 smugglers max):
/// - Offset 0: Region/location byte
/// - Offset 1: Willingness to haggle
/// - Offset 2: Field C
/// - Offset 3: Field D
/// - Offset 4: Harvesters in stock
/// - Offset 5: Ornithopters in stock
/// - Offset 6: Krys knives in stock
/// - Offset 7: Laser guns in stock
/// - Offset 8: Weirding modules in stock
/// - Offset 9: Harvester price (x10)
/// - Offset 10: Ornithopter price (x10)
/// - Offset 11: Krys knife price (x10)
/// - Offset 12: Laser gun price (x10)
/// - Offset 13: Weirding module price (x10)
/// </remarks>
public partial class DuneGameState {
    public byte GetSmugglerRegion(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize)];
    }

    public byte GetSmugglerWillingnessToHaggle(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize) + 1];
    }

    public byte GetSmugglerHarvesters(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize) + 4];
    }

    public byte GetSmugglerOrnithopters(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize) + 5];
    }

    public byte GetSmugglerKrysKnives(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize) + 6];
    }

    public byte GetSmugglerLaserGuns(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize) + 7];
    }

    public byte GetSmugglerWeirdingModules(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize) + 8];
    }

    public ushort GetSmugglerHarvesterPrice(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return (ushort)(UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize) + 9] * 10);
    }

    public ushort GetSmugglerOrnithopterPrice(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return (ushort)(UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize) + 10] * 10);
    }

    public ushort GetSmugglerKrysKnifePrice(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return (ushort)(UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize) + 11] * 10);
    }

    public ushort GetSmugglerLaserGunPrice(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return (ushort)(UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize) + 12] * 10);
    }

    public ushort GetSmugglerWeirdingModulePrice(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return (ushort)(UInt8[SmugglerBaseOffset + (index * SmugglerEntrySize) + 13] * 10);
    }

    public string GetSmugglerLocationName(int index) {
        byte region = GetSmugglerRegion(index);
        return GetLocationNameStr(region, 0x0A);
    }
}
