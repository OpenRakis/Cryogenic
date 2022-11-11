namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.CPU;
using Spice86.Core.Emulator.ReverseEngineer;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {
    
    public void DefineSoundCodeOverrides() {
        DefineFunction(cs1, 0xAEB7, CallMidiFunc02_1ED_AEB7_CD87);
        DefineFunction(cs1, 0xAC30, CallPcmFunc05_1ED_AC30_CB00);
    }

    public Action CallPcmFunc05_1ED_AC30_CB00(int gotoAddress) {
        // Called at scene change
        CheckVtableContainsExpected(SegmentRegisters.DsIndex, 0x3999, cs3, 0x10C);
        ClearAL_4822_10C_4832C(0);
        return NearRet();
    }
    public Action CallMidiFunc02_1ED_AEB7_CD87(int gotoAddress) {
        // Called before videos
        CheckVtableContainsExpected(SegmentRegisters.DsIndex, 0x3975, cs4, 0x106);
        globalsOnDs.Set1138_DBCB_Byte8(0);
        ClearAL_482B_106_483B6(0);
        globalsOnDs.Set1138_DBCD_Byte8_IsSoundPresent(State.AL);
        return NearRet();
    }

}