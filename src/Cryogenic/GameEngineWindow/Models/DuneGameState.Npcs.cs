namespace Cryogenic.GameEngineWindow.Models;

/// <summary>
/// NPC structure accessors for Dune game state.
/// </summary>
/// <remarks>
/// NPC structure (8 bytes per entry + 8 bytes padding = 16 bytes total, 16 NPCs max):
/// - Offset 0: Sprite identificator
/// - Offset 1: Field B
/// - Offset 2: Room location
/// - Offset 3: Type of place
/// - Offset 4: Field E
/// - Offset 5: Exact place
/// - Offset 6: For dialogue flag
/// - Offset 7: Field H
/// </remarks>
public partial class DuneGameState {
    public byte GetNpcSpriteId(int index) {
        if (index < 0 || index >= MaxNpcs) return 0;
        return UInt8[NpcBaseOffset + (index * NpcTotalEntrySize)];
    }

    public byte GetNpcRoomLocation(int index) {
        if (index < 0 || index >= MaxNpcs) return 0;
        return UInt8[NpcBaseOffset + (index * NpcTotalEntrySize) + 2];
    }

    public byte GetNpcPlaceType(int index) {
        if (index < 0 || index >= MaxNpcs) return 0;
        return UInt8[NpcBaseOffset + (index * NpcTotalEntrySize) + 3];
    }

    public byte GetNpcExactPlace(int index) {
        if (index < 0 || index >= MaxNpcs) return 0;
        return UInt8[NpcBaseOffset + (index * NpcTotalEntrySize) + 5];
    }

    public byte GetNpcDialogueFlag(int index) {
        if (index < 0 || index >= MaxNpcs) return 0;
        return UInt8[NpcBaseOffset + (index * NpcTotalEntrySize) + 6];
    }

    public static string GetNpcName(byte npcId) => npcId switch {
        0 => "None",
        1 => "Duke Leto Atreides",
        2 => "Jessica Atreides",
        3 => "Thufir Hawat",
        4 => "Duncan Idaho",
        5 => "Gurney Halleck",
        6 => "Stilgar",
        7 => "Liet Kynes",
        8 => "Chani",
        9 => "Harah",
        10 => "Baron Harkonnen",
        11 => "Feyd-Rautha",
        12 => "Emperor Shaddam IV",
        13 => "Harkonnen Captains",
        14 => "Smugglers",
        15 => "The Fremen",
        16 => "The Fremen",
        _ => $"NPC #{npcId}"
    };

    public static string GetNpcPlaceTypeDescription(byte placeType) => placeType switch {
        0 => "Not present",
        1 => "Palace room",
        2 => "Desert/Outside",
        _ => $"Type {placeType:X2}"
    };
}
