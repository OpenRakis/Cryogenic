namespace Cryogenic.GameEngineWindow.Models;

/// <summary>
/// Troop structure accessors for Dune game state.
/// </summary>
/// <remarks>
/// Troop structure (27 bytes per entry, 68 max troops at 9B05:0003):
/// - Offset 0: Troop ID
/// - Offset 1: Next troop ID (for chains)
/// - Offset 2: Position in location
/// - Offset 3: Occupation type
/// - Offset 4-5: Field E (16-bit)
/// - Offset 6-9: Coordinates (4 bytes)
/// - Offset 10-17: Field G (8 bytes)
/// - Offset 18: Dissatisfaction
/// - Offset 19: Speech/dialogue state
/// - Offset 20: Field J
/// - Offset 21: Motivation
/// - Offset 22: Spice mining skill
/// - Offset 23: Army skill
/// - Offset 24: Ecology skill
/// - Offset 25: Equipment flags
/// - Offset 26: Population (x10)
/// </remarks>
public partial class DuneGameState {
    /// <summary>
    /// Get the absolute address for a troop entry.
    /// </summary>
    private uint GetTroopAddress(int index, int fieldOffset = 0) {
        return TroopsBaseAddress + (uint)TroopArrayOffset + (uint)(index * TroopEntrySize) + (uint)fieldOffset;
    }

    public byte GetTroopId(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return ReadByte(GetTroopAddress(index, 0));
    }

    public byte GetTroopNextId(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return ReadByte(GetTroopAddress(index, 1));
    }

    public byte GetTroopPosition(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return ReadByte(GetTroopAddress(index, 2));
    }

    public byte GetTroopOccupation(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return ReadByte(GetTroopAddress(index, 3));
    }

    public byte GetTroopDissatisfaction(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return ReadByte(GetTroopAddress(index, 18));
    }

    public byte GetTroopSpeech(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return ReadByte(GetTroopAddress(index, 19));
    }

    public byte GetTroopMotivation(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return ReadByte(GetTroopAddress(index, 21));
    }

    public byte GetTroopSpiceSkill(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return ReadByte(GetTroopAddress(index, 22));
    }

    public byte GetTroopArmySkill(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return ReadByte(GetTroopAddress(index, 23));
    }

    public byte GetTroopEcologySkill(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return ReadByte(GetTroopAddress(index, 24));
    }

    public byte GetTroopEquipment(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return ReadByte(GetTroopAddress(index, 25));
    }

    public ushort GetTroopPopulation(int index) {
        if (index < 0 || index >= MaxTroops) return 0;
        return (ushort)(ReadByte(GetTroopAddress(index, 26)) * 10);
    }

    public static string GetTroopOccupationDescription(byte occupation) {
        byte baseOccupation = (byte)(occupation & 0x7F);
        bool notHired = (occupation & 0x80) != 0;
        
        string desc = baseOccupation switch {
            0x00 => "Mining Spice (Fremen)",
            0x02 => "Waiting for Orders (Fremen)",
            0x0C => "Mining Spice (Harkonnen)",
            0x0D => "Prospecting (Harkonnen)",
            0x0E => "Waiting (Harkonnen)",
            0x0F => "Searching Equipment (Harkonnen)",
            0x1F => "Military Searching (Harkonnen)",
            _ when baseOccupation >= 0x10 && baseOccupation < 0x20 => "Special",
            _ when baseOccupation >= 0x40 && baseOccupation < 0x80 => "Moving",
            _ when occupation >= 0xA0 => "Complaining (Slaved)",
            _ => $"Unknown (0x{occupation:X2})"
        };
        
        if (notHired && baseOccupation < 0x10) {
            desc = "Not Hired - " + desc;
        }
        
        return desc;
    }

    public static bool IsTroopFremen(byte occupation) {
        // Fremen troops: occupation 0x00 (Mining Spice) or 0x02 (Waiting for Orders)
        // Also includes slaved Fremen (occupation >= 0xA0)
        byte baseOccupation = (byte)(occupation & 0x7F);
        return baseOccupation == 0x00 || baseOccupation == 0x02 || occupation >= 0xA0;
    }

    public static string GetTroopEquipmentDescription(byte equipment) {
        if (equipment == 0) return "None";
        
        var items = new System.Collections.Generic.List<string>();
        if ((equipment & 0x02) != 0) items.Add("Bulbs");
        if ((equipment & 0x04) != 0) items.Add("Atomics");
        if ((equipment & 0x08) != 0) items.Add("Weirding");
        if ((equipment & 0x10) != 0) items.Add("Laser");
        if ((equipment & 0x20) != 0) items.Add("Krys");
        if ((equipment & 0x40) != 0) items.Add("Ornithopter");
        if ((equipment & 0x80) != 0) items.Add("Harvester");
        
        return string.Join(", ", items);
    }

    public int GetActiveTroopCount() {
        int count = 0;
        for (int i = 0; i < MaxTroops; i++) {
            if (GetTroopOccupation(i) != 0) count++;
        }
        return count;
    }
}
