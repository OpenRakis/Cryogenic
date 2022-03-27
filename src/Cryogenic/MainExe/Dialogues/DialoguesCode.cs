namespace Cryogenic.Mainexe.Dialogues;

using Cryogenic.Globals;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class DialoguesCode : CSharpOverrideHelper {
    private ExtraGlobalsOnDs globals;

    public DialoguesCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine) : base(functionInformations, "dialogues", machine) {
        globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0xA1E8, IncUnknown47A8_1ED_A1E8_C0B8);
        DefineFunction(segment, 0xA8B1, Unknown_1ED_A8B1_C781);
        DefineFunction(segment, 0xC85B, InitDialogue_1ED_C85B_E72B);
    }

    public Action IncUnknown47A8_1ED_A1E8_C0B8(int gotoAddress) {
        // Called in dialogues, sometimes before first text display, sometimes before last text
        globals.Set1138_47A8_Byte8((byte)(globals.Get1138_47A8_Byte8() + 1));
        return NearRet();
    }

    public Action InitDialogue_1ED_C85B_E72B(int gotoAddress) {
        ushort value = this.globals.Get1138_CE7A_Word16_VideoPlayRelatedIndex();
        this.globals.Set1138_476E_Word16(value);
        this.globals.Set1138_4772_Word16_TimeBetweenFaceZooms(0x1770);
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