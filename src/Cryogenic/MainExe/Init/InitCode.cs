namespace Cryogenic.Mainexe.Init;

using Cryogenic.Globals;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class InitCode : CSharpOverrideHelper {
    private ExtraGlobalsOnDs globals;
    public InitCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine) : base(functionInformations, "initRelated", machine) {
        globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0xDA53, VgaInitRelated_1ED_DA53_F923);
    }

    public Action VgaInitRelated_1ED_DA53_F923(int gotoAddress) {
        this.globals.Set1138_DC6A_Word16(0);
        this.globals.Set1138_46D7_Byte8(0);
        return NearRet();
    }
}