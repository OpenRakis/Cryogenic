namespace Cryogenic.GameEngineWindow.Models;

/// <summary>
/// Location/Sietch structure accessors for Dune game state.
/// </summary>
/// <remarks>
/// Location structure (28 bytes per entry, 70 max locations at DS:0100):
/// Per madmoose dune-rust data.rs - Sietch structure at offset 0x100 in DataSegment.
/// - Offset 0: first_name (region: 01-0C)
/// - Offset 1: last_name (type: 01-0B, 0A=village)
/// - Offset 2: desert
/// - Offset 3: map_x
/// - Offset 4: map_y
/// - Offset 5: map_u
/// - Offset 6: another_x
/// - Offset 7: another_y
/// - Offset 8: apparence (appearance type)
/// - Offset 9: troop_id (housed troop ID)
/// - Offset 10: status flags
/// - Offset 11: discoverable_at_phase
/// - Offset 12-15: unk1-unk4
/// - Offset 16: spice_field_id
/// - Offset 17: unk5 (spice amount in odrade)
/// - Offset 18: spice_density
/// - Offset 19: unk6
/// - Offset 20: nbr_moiss (harvesters)
/// - Offset 21: nbr_orni (ornithopters)
/// - Offset 22: nbr_knife (krys knives)
/// - Offset 23: nbr_guns (laser guns)
/// - Offset 24: nbr_mods (weirding modules)
/// - Offset 25: nbr_atoms (atomics)
/// - Offset 26: nbr_bulbs (bulbs)
/// - Offset 27: water
/// </remarks>
public partial class DuneGameState {
    /// <summary>
    /// Get the absolute address for a location entry.
    /// Locations are at BaseAddress + LocationArrayOffset (0x0100).
    /// </summary>
    private uint GetLocationAddress(int index, int fieldOffset = 0) {
        return BaseAddress + (uint)LocationArrayOffset + (uint)(index * LocationEntrySize) + (uint)fieldOffset;
    }

    public byte GetLocationNameFirst(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 0));
    }

    public byte GetLocationNameSecond(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 1));
    }

    public static string GetLocationNameStr(byte first, byte second) {
        string str = first switch {
            0x01 => "Arrakeen",
            0x02 => "Carthag",
            0x03 => "Tuono",
            0x04 => "Habbanya",
            0x05 => "Oxtyn",
            0x06 => "Tsympo",
            0x07 => "Bledan",
            0x08 => "Ergsun",
            0x09 => "Haga",
            0x0a => "Cielago",
            0x0b => "Sihaya",
            0x0c => "Celimyn",
            _ => $"Unknown({first:X2})"
        };

        str += second switch {
            0x01 => " (Atreides)",
            0x02 => " (Harkonnen)",
            0x03 => "-Tabr",
            0x04 => "-Timin",
            0x05 => "-Tuek",
            0x06 => "-Harg",
            0x07 => "-Clam",
            0x08 => "-Tsymyn",
            0x09 => "-Siet",
            0x0a => "-Pyons",
            0x0b => "-Pyort",
            _ => ""
        };

        return str;
    }

    public static string GetLocationTypeStr(byte second) => second switch {
        0x01 => "Atreides Palace",
        0x02 => "Harkonnen Palace",
        0x03 => "Sietch (Tabr)",
        0x04 => "Sietch (Timin)",
        0x05 => "Sietch (Tuek)",
        0x06 => "Sietch (Harg)",
        0x07 => "Sietch (Clam)",
        0x08 => "Sietch (Tsymyn)",
        0x09 => "Sietch (Siet)",
        0x0a => "Village (Pyons)",
        0x0b => "Sietch (Pyort)",
        _ => $"Unknown Type ({second:X2})"
    };

    public byte GetLocationAppearance(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 8));
    }

    public byte GetLocationHousedTroopId(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 9));
    }

    public byte GetLocationStatus(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 10));
    }

    public byte GetLocationSpiceFieldId(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 16));
    }

    public byte GetLocationSpiceAmount(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 17));
    }

    public byte GetLocationSpiceDensity(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 18));
    }

    public byte GetLocationHarvesters(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 20));
    }

    public byte GetLocationOrnithopters(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 21));
    }

    public byte GetLocationKrysKnives(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 22));
    }

    public byte GetLocationLaserGuns(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 23));
    }

    public byte GetLocationWeirdingModules(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 24));
    }

    public byte GetLocationAtomics(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 25));
    }

    public byte GetLocationBulbs(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 26));
    }

    public byte GetLocationWater(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return ReadByte(GetLocationAddress(index, 27));
    }

    /// <summary>
    /// Get location map coordinates (single byte values).
    /// Per madmoose dune-rust: map_x at offset 3, map_y at offset 4.
    /// </summary>
    public (byte X, byte Y) GetLocationCoordinates(int index) {
        if (index < 0 || index >= MaxLocations) return (0, 0);
        return (ReadByte(GetLocationAddress(index, 3)), ReadByte(GetLocationAddress(index, 4)));
    }
}
