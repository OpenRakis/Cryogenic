namespace Cryogenic.Overrides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class Overrides {

    public void DefineMT32DriverCodeOverrides() {
        DefineFunction(0xF000, 0x100, DNMID_entry_00, true, nameof(DNMID_entry_00));
        DefineFunction(0xF000, 0x100 + 0x17b, DNMID_entry_01, true, nameof(DNMID_entry_01));
        DefineFunction(0xF000, 0x1CB, DNMID_internal_function_00, true, nameof(DNMID_internal_function_00));
    }

    private Action DNMID_entry_01(int arg) {
        var result = Alu16.Xor(AX, AX);
        if (result == 0) {
            return NearJump(0x04);
        }
        Cpu.Out16(0x330, AX);
        return NearJump(0x0);
    }

    private Action DNMID_entry_00(int arg) {
        return DNMID_entry_01(0);
        //return NearJump(0x17b);
    }

    /// <summary>
    /// Never called...?!
    /// </summary>

    private Action DNMID_internal_function_00(int arg) {
        return NearRet();
    }
}
