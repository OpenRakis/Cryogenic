namespace Cryogenic.Overrides;

/// <summary>
/// Partial class containing menu system overrides and constants for the Dune CD game.
/// </summary>
/// <remarks>
/// Method names contain underscores to separate segment, offset, and linear addresses
/// for traceability back to the original DOS disassembly.
/// </remarks>
public partial class Overrides {
    /// <summary>Menu type constant for the book/journal interface.</summary>
    public static readonly int MENU_TYPE_BOOK = 0x2032;

    /// <summary>Menu type constant for changing troop occupation assignments.</summary>
    public static readonly int MENU_TYPE_CHANGE_TROOP_OCCUPATION = 0x216E;

    /// <summary>Menu type constant for dialogue/conversation screens.</summary>
    public static readonly int MENU_TYPE_DIALOGUE = 0x1F7E;

    /// <summary>Menu type constant for the exit/quit game confirmation.</summary>
    public static readonly int MENU_TYPE_EXIT_DUNE = 0x20B6;

    /// <summary>Menu type constant for the flat strategic map view.</summary>
    public static readonly int MENU_TYPE_FLAT_MAP = 0x20F2;

    /// <summary>Menu type constant for the globe/planetary view.</summary>
    public static readonly int MENU_TYPE_GLOBE = 0x204A;

    /// <summary>Menu type constant for the load game screen.</summary>
    public static readonly int MENU_TYPE_LOAD_GAME = 0x208A;

    /// <summary>Menu type constant for the mirror/reflection interface.</summary>
    public static readonly int MENU_TYPE_MIRROR = 0x20C2;

    /// <summary>Menu type constant for the audio mixer settings.</summary>
    public static readonly int MENU_TYPE_MIXER = 0x201A;

    /// <summary>Menu type constant for the equipment modification screen.</summary>
    public static readonly int MENU_TYPE_MODIFY_EQUIPMENT = 0x2012;

    /// <summary>Menu type constant for troop movement interface.</summary>
    public static readonly int MENU_TYPE_MOVE_TROOP = 0x212E;

    /// <summary>Menu type constant for ornithopter map view (shares value with MOVE_TROOP).</summary>
    public static readonly int MENU_TYPE_ORNI_MAP = 0x212E;

    /// <summary>Menu type constant for the save game screen.</summary>
    public static readonly int MENU_TYPE_SAVE_GAME = 0x207A;

    /// <summary>Menu type constant for selecting troop occupation.</summary>
    public static readonly int MENU_TYPE_SELECT_TROOP_OCCUPATION = 0x215A;

    /// <summary>Menu type constant for talking to troop members.</summary>
    public static readonly int MENU_TYPE_TALKING_TO_TROOP = 0x210A;

    /// <summary>
    /// Menu type constant for the walk-around/exploration mode.
    /// </summary>
    /// <remarks>
    /// This value was found empirically; it may actually be an address to something else
    /// rather than a pure menu type identifier.
    /// </remarks>
    public static readonly int MENU_TYPE_WALK_AROUND = 0x1F0E;

    /// <summary>
    /// Registers menu-related function overrides with Spice86.
    /// </summary>
    public void DefineMenuCodeOverrides() {
        DefineFunction(cs1, 0xD316, MenuAnimationRelated_1000_D316_01D316);
        DefineFunction(cs1, 0xD41B, SetBpToCurrentMenuTypeForScreenAction_1000_D41B_01D41B);
    }

    /// <summary>
    /// Override for CS1:D316 - Handles menu animation state when a menu has a submenu.
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <remarks>
    /// This function is called when a menu has a submenu. It checks if menu animation is needed
    /// and sets the transition bitmask accordingly to control visual transitions.
    /// </remarks>
    public Action MenuAnimationRelated_1000_D316_01D316(int gotoAddress) {
        // called when a menu has a submenu
        int isAnimateMenuUneeded = globalsOnDs.Get1138_35A6_Word16_IsAnimateMenuUnneeded();
        byte value2 = globalsOnDs.Get1138_DCE6_Byte8_TransitionBitmask();
        _loggerService.Debug("isAnimateMenuUneeded={@IsAnimateMenuUneeded},DCE6={@DCE6}", isAnimateMenuUneeded, value2);
        if (isAnimateMenuUneeded == 0) {
            value2 |= 1;
            globalsOnDs.Set1138_DCE6_Byte8_TransitionBitmask(value2);
        }

        return NearRet();
    }

    /// <summary>
    /// Override for CS1:D41B - Sets the BP register to the current menu type for screen action handling.
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <exception cref="UnhandledOperationException">Thrown if SS != DS, indicating an untested code path.</exception>
    /// <remarks>
    /// If BP does not point to the correct menu type, the menu will still display but
    /// no actions will be clickable on the screen. This override ensures BP is correctly
    /// set from the global menu type state.
    /// </remarks>
    public Action SetBpToCurrentMenuTypeForScreenAction_1000_D41B_01D41B(int gotoAddress) {
        // If BP does not point to a correct menu type, menu is still OK but no action is clickable on the screen
        if (SS != DS) {
            throw FailAsUntested(
                "Was implemented considering base address is DS since I couldnt see a case where DS!=SS for this method, but you found one :)");
        }

        ushort value = globalsOnDs.GetMenuType();
        BP = value;
        return NearRet();
    }
}