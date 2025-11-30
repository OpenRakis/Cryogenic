namespace Cryogenic.GameEngineWindow.Models;

/// <summary>
/// Smuggler structure accessors for Dune game state.
/// </summary>
/// <remarks>
/// Smuggler structure (14 bytes per entry + 3 bytes padding = 17 bytes total, 6 smugglers max).
/// Smugglers follow NPCs in memory.
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
    /// <summary>
    /// Get the absolute address for a smuggler entry.
    /// Smugglers follow NPCs in memory (after troops + NPCs).
    /// </summary>
    private uint GetSmugglerAddress(int index, int fieldOffset = 0) {
        uint npcsStart = TroopsBaseAddress + (uint)TroopArrayOffset + (uint)(MaxTroops * TroopEntrySize);
        uint smugglersStart = npcsStart + (uint)(MaxNpcs * NpcTotalEntrySize);
        return smugglersStart + (uint)(index * SmugglerTotalEntrySize) + (uint)fieldOffset;
    }

    public byte GetSmugglerRegion(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return ReadByte(GetSmugglerAddress(index, 0));
    }

    public byte GetSmugglerWillingnessToHaggle(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return ReadByte(GetSmugglerAddress(index, 1));
    }

    public byte GetSmugglerHarvesters(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return ReadByte(GetSmugglerAddress(index, 4));
    }

    public byte GetSmugglerOrnithopters(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return ReadByte(GetSmugglerAddress(index, 5));
    }

    public byte GetSmugglerKrysKnives(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return ReadByte(GetSmugglerAddress(index, 6));
    }

    public byte GetSmugglerLaserGuns(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return ReadByte(GetSmugglerAddress(index, 7));
    }

    public byte GetSmugglerWeirdingModules(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return ReadByte(GetSmugglerAddress(index, 8));
    }

    public ushort GetSmugglerHarvesterPrice(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return (ushort)(ReadByte(GetSmugglerAddress(index, 9)) * 10);
    }

    public ushort GetSmugglerOrnithopterPrice(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return (ushort)(ReadByte(GetSmugglerAddress(index, 10)) * 10);
    }

    public ushort GetSmugglerKrysKnifePrice(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return (ushort)(ReadByte(GetSmugglerAddress(index, 11)) * 10);
    }

    public ushort GetSmugglerLaserGunPrice(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return (ushort)(ReadByte(GetSmugglerAddress(index, 12)) * 10);
    }

    public ushort GetSmugglerWeirdingModulePrice(int index) {
        if (index < 0 || index >= MaxSmugglers) return 0;
        return (ushort)(ReadByte(GetSmugglerAddress(index, 13)) * 10);
    }

    public string GetSmugglerLocationName(int index) {
        byte region = GetSmugglerRegion(index);
        return GetLocationNameStr(region, 0x0A);
    }
}
