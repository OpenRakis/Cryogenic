namespace Cryogenic.GameEngineWindow.Models;

/// <summary>
/// Location/Sietch structure accessors for Dune game state.
/// </summary>
/// <remarks>
/// Location structure (28 bytes per entry, 70 max locations):
/// - Offset 0: Name first byte (region: 01-0C)
/// - Offset 1: Name second byte (type: 01-0B, 0A=village)
/// - Offset 2-7: Coordinates (6 bytes)
/// - Offset 8: Appearance type
/// - Offset 9: Housed troop ID
/// - Offset 10: Status flags
/// - Offset 11-15: Stage for discovery
/// - Offset 16: Spice field ID
/// - Offset 17: Spice amount
/// - Offset 18: Spice density
/// - Offset 19: Field J
/// - Offset 20: Harvesters count
/// - Offset 21: Ornithopters count
/// - Offset 22: Krys knives count
/// - Offset 23: Laser guns count
/// - Offset 24: Weirding modules count
/// - Offset 25: Atomics count
/// - Offset 26: Bulbs count
/// - Offset 27: Water amount
/// </remarks>
public partial class DuneGameState {
    public byte GetLocationNameFirst(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize)];
    }

    public byte GetLocationNameSecond(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 1];
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
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 8];
    }

    public byte GetLocationHousedTroopId(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 9];
    }

    public byte GetLocationStatus(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 10];
    }

    public byte GetLocationSpiceFieldId(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 16];
    }

    public byte GetLocationSpiceAmount(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 17];
    }

    public byte GetLocationSpiceDensity(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 18];
    }

    public byte GetLocationHarvesters(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 20];
    }

    public byte GetLocationOrnithopters(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 21];
    }

    public byte GetLocationKrysKnives(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 22];
    }

    public byte GetLocationLaserGuns(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 23];
    }

    public byte GetLocationWeirdingModules(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 24];
    }

    public byte GetLocationAtomics(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 25];
    }

    public byte GetLocationBulbs(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 26];
    }

    public byte GetLocationWater(int index) {
        if (index < 0 || index >= MaxLocations) return 0;
        return UInt8[LocationBaseOffset + (index * LocationEntrySize) + 27];
    }

    public (ushort X, ushort Y) GetLocationCoordinates(int index) {
        if (index < 0 || index >= MaxLocations) return (0, 0);
        var baseOffset = LocationBaseOffset + (index * LocationEntrySize);
        return (UInt16[baseOffset + 2], UInt16[baseOffset + 4]);
    }
}
