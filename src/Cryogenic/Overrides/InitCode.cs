namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.ReverseEngineer;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides {
    public void DefineInitCodeOverrides() {
        DefineFunction(cs1, 0xDA53, VgaInitRelated_1000_DA53_01DA53);
    }

    public Action VgaInitRelated_1000_DA53_01DA53(int gotoAddress) {
        this.globalsOnDs.Set1138_DC6A_Word16(0);
        this.globalsOnDs.Set1138_46D7_Byte8(0);
        return NearRet();
    }
}