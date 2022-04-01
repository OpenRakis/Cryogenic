namespace Cryogenic.Overrides;

using Spice86.Emulator.ReverseEngineer;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {
    public void DefineDialoguesCodeOverrides() {
        DefineFunction(cs1, 0xA1E8, IncUnknown47A8_1ED_A1E8_C0B8);
        DefineFunction(cs1, 0xA8B1, Unknown_1ED_A8B1_C781);
        DefineFunction(cs1, 0xC85B, InitDialogue_1ED_C85B_E72B);
    }

    public Action IncUnknown47A8_1ED_A1E8_C0B8(int gotoAddress) {
        // Called in dialogues, sometimes before first text display, sometimes before last text
        globalsOnDs.Set1138_47A8_Byte8((byte)(globalsOnDs.Get1138_47A8_Byte8() + 1));
        return NearRet();
    }

    public Action InitDialogue_1ED_C85B_E72B(int gotoAddress) {
        ushort value = this.globalsOnDs.Get1138_CE7A_Word16_VideoPlayRelatedIndex();
        this.globalsOnDs.Set1138_476E_Word16(value);
        this.globalsOnDs.Set1138_4772_Word16_TimeBetweenFaceZooms(0x1770);
        return NearRet();
    }

    public Action Unknown_1ED_A8B1_C781(int gotoAddress) {
        // Called when a dialogue text changes (beginning and during dialogue), and when entering an orni
        // Value does not seem to have any effect
        byte value = State.AL;
        value &= 0xF;
        value += 0x30;
        if (value > 0x39) {
            value += 0x7;
        }

        State.AL = value;
        return NearRet();
    }
}