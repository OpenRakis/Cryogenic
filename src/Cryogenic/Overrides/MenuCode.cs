namespace Cryogenic.Overrides;

// Method names contain _ to separate addresses.
public partial class Overrides {
    public static readonly int MENU_TYPE_BOOK = 0x2032;
    public static readonly int MENU_TYPE_CHANGE_TROOP_OCCUPATION = 0x216E;
    public static readonly int MENU_TYPE_DIALOGUE = 0x1F7E;
    public static readonly int MENU_TYPE_EXIT_DUNE = 0x20B6;
    public static readonly int MENU_TYPE_FLAT_MAP = 0x20F2;
    public static readonly int MENU_TYPE_GLOBE = 0x204A;
    public static readonly int MENU_TYPE_LOAD_GAME = 0x208A;
    public static readonly int MENU_TYPE_MIRROR = 0x20C2;
    public static readonly int MENU_TYPE_MIXER = 0x201A;
    public static readonly int MENU_TYPE_MODIFY_EQUIPMENT = 0x2012;
    public static readonly int MENU_TYPE_MOVE_TROOP = 0x212E;
    public static readonly int MENU_TYPE_ORNI_MAP = 0x212E;
    public static readonly int MENU_TYPE_SAVE_GAME = 0x207A;
    public static readonly int MENU_TYPE_SELECT_TROOP_OCCUPATION = 0x215A;
    public static readonly int MENU_TYPE_TALKING_TO_TROOP = 0x210A;

    // values I could find for MenuGlobalsOnDs.getMenuType, not sure they are not an address to something else.
    public static readonly int MENU_TYPE_WALK_AROUND = 0x1F0E;

    public void DefineMenuCodeOverrides() {
        DefineFunction(cs1, 0xD316, MenuAnimationRelated_1000_D316_01D316);
        DefineFunction(cs1, 0xD41B, SetBpToCurrentMenuTypeForScreenAction_1000_D41B_01D41B);
    }

    public Action MenuAnimationRelated_1000_D316_01D316(int gotoAddress) {
        // called when a menu has a submenu
        int isAnimateMenuUneeded = globalsOnDs.Get1138_35A6_Word16_IsAnimateMenuUnneeded();
        byte value2 = globalsOnDs.Get1138_DCE6_Byte8_TransitionBitmask();
        _logger.Debug("isAnimateMenuUneeded={@IsAnimateMenuUneeded},DCE6={@DCE6}", isAnimateMenuUneeded, value2);
        if (isAnimateMenuUneeded == 0) {
            value2 |= 1;
            globalsOnDs.Set1138_DCE6_Byte8_TransitionBitmask(value2);
        }

        return NearRet();
    }

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