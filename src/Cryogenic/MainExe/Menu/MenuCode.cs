namespace Cryogenic.Mainexe.Menu;

using Cryogenic.Globals;

using Serilog;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class MenuCode : CSharpOverrideHelper {
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

    private static readonly ILogger _logger = Log.Logger.ForContext<MenuCode>();
    private ExtraGlobalsOnDs globals;

    public MenuCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine) : base(functionInformations, "mainCode", machine) {
        globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0xD316, "menuAnimationRelated", MenuAnimationRelated_1ED_D316_F1E6);
        DefineFunction(segment, 0xD41B, "setBpToCurrentMenuTypeForScreenAction", SetBpToCurrentMenuTypeForScreenAction_1ED_D41B_F2EB);
    }

    public Action MenuAnimationRelated_1ED_D316_F1E6() {
        // called when a menu has a submenu
        int isAnimateMenuUneeded = globals.Get1138_35A6_Word16_IsAnimateMenuUnneeded();
        byte value2 = globals.Get1138_DCE6_Byte8_TransitionBitmask();
        _logger.Debug("isAnimateMenuUneeded={@IsAnimateMenuUneeded},DCE6={@DCE6}", isAnimateMenuUneeded, value2);
        if (isAnimateMenuUneeded == 0) {
            value2 |= 1;
            globals.Set1138_DCE6_Byte8_TransitionBitmask(value2);
        }

        return NearRet();
    }

    public Action SetBpToCurrentMenuTypeForScreenAction_1ED_D41B_F2EB() {
        // If BP does not point to a correct menu type, menu is still OK but no action is clickable on the screen
        if (_state.GetSS() != _state.GetDS()) {
            FailAsUntested("Was implemented considering base address is DS since I couldnt see a case where DS!=SS for this method, but you found one :)");
        }

        ushort value = globals.GetMenuType();
        _state.SetBP(value);
        return NearRet();
    }
}