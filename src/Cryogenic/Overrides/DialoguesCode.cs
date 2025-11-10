namespace Cryogenic.Overrides;

/// <summary>
/// Partial class containing dialogue system related overrides.
/// </summary>
/// <remarks>
/// Method names contain underscores to separate segment, offset, and linear addresses
/// for traceability back to the original DOS disassembly.
/// </remarks>
public partial class Overrides {
    /// <summary>
    /// Registers dialogue system function overrides with Spice86.
    /// </summary>
    public void DefineDialoguesCodeOverrides() {
        DefineFunction(cs1, 0xA1E8, IncUnknown47A8_1000_A1E8_01A1E8);
        DefineFunction(cs1, 0xA8B1, Unknown_1000_A8B1_01A8B1);
        DefineFunction(cs1, 0xC85B, InitDialogue_1000_C85B_01C85B);
    }

    /// <summary>
    /// Override for CS1:A1E8 - Increments an unknown dialogue-related counter at DS:47A8.
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <remarks>
    /// Called during dialogues, sometimes before the first text display and sometimes before
    /// the last text. The exact purpose of this counter is not yet fully understood.
    /// </remarks>
    public Action IncUnknown47A8_1000_A1E8_01A1E8(int gotoAddress) {
        // Called in dialogues, sometimes before first text display, sometimes before last text
        globalsOnDs.Set1138_47A8_Byte8((byte)(globalsOnDs.Get1138_47A8_Byte8() + 1));
        return NearRet();
    }

    /// <summary>
    /// Override for CS1:C85B - Initializes dialogue state variables.
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <remarks>
    /// Sets up initial dialogue state by copying a video-related index and configuring
    /// the time between face zoom animations (0x1770). This prepares the dialogue system
    /// for character conversations with animated portrait zooms.
    /// </remarks>
    public Action InitDialogue_1000_C85B_01C85B(int gotoAddress) {
        ushort value = this.globalsOnDs.Get1138_CE7A_Word16_VideoPlayRelatedIndex();
        this.globalsOnDs.Set1138_476E_Word16(value);
        this.globalsOnDs.Set1138_4772_Word16_TimeBetweenFaceZooms(0x1770);
        return NearRet();
    }

    /// <summary>
    /// Override for CS1:A8B1 - Performs a character conversion operation (possibly hex digit formatting).
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <remarks>
    /// Called when dialogue text changes (at the beginning and during dialogue), and when
    /// entering an ornithopter. Converts the lower 4 bits of AL to an ASCII character,
    /// likely for hex digit display (0-9, A-F). The resulting value doesn't appear to
    /// have a significant effect on gameplay.
    /// </remarks>
    public Action Unknown_1000_A8B1_01A8B1(int gotoAddress) {
        // Called when a dialogue text changes (beginning and during dialogue), and when entering an orni
        // Value does not seem to have any effect
        byte value = AL;
        value &= 0xF;
        value += 0x30;
        if (value > 0x39) {
            value += 0x7;
        }

        AL = value;
        return NearRet();
    }
}