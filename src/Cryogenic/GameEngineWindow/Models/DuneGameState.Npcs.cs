namespace Cryogenic.GameEngineWindow.Models;

/// <summary>
/// Partial class for NPC-related memory access.
/// </summary>
/// <remarks>
/// NPCs array follows troops in memory at DS:0xAC2E (troops end at 0xAA76 + 68*27 = 0xAC2E).
/// 16 bytes per entry, 16 entries max.
/// Structure from odrade:
/// - Offset 0: sprite_index (u8)
/// - Offset 1: room_index (u8)
/// - Offset 2: place_type (u8)
/// - Offset 3: dialogue_state (u8)
/// - And more fields...
/// Plus 8 bytes padding per entry = 16 bytes total
/// </remarks>
public partial class DuneGameState {
    
    // NPCs array DS-relative
    public const int NpcArrayOffset = 0xAC2E;              // After troops: 0xAA76 + 68*27
    public const int NpcEntrySize = 16;                    // 8 bytes data + 8 bytes padding
    public const int MaxNpcs = 16;
    
    /// <summary>
    /// Gets the base DS-relative offset for an NPC entry.
    /// </summary>
    private int GetNpcOffset(int index) {
        if (index < 0 || index >= MaxNpcs)
            throw new ArgumentOutOfRangeException(nameof(index), 
                $"NPC index must be between 0 and {MaxNpcs - 1}");
        return NpcArrayOffset + (index * NpcEntrySize);
    }
    
    /// <summary>
    /// Gets the NPC sprite index (DS:0xAC2E + index*16 + 0).
    /// </summary>
    public byte GetNpcSpriteIndex(int index) => UInt8[GetNpcOffset(index)];
    
    /// <summary>
    /// Gets the NPC room index (DS:0xAC2E + index*16 + 1).
    /// </summary>
    public byte GetNpcRoomIndex(int index) => UInt8[GetNpcOffset(index) + 1];
    
    /// <summary>
    /// Gets the NPC place type (DS:0xAC2E + index*16 + 2).
    /// </summary>
    public byte GetNpcPlaceType(int index) => UInt8[GetNpcOffset(index) + 2];
    
    /// <summary>
    /// Gets the NPC dialogue state (DS:0xAC2E + index*16 + 3).
    /// </summary>
    public byte GetNpcDialogueState(int index) => UInt8[GetNpcOffset(index) + 3];
}
