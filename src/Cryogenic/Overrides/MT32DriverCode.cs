namespace Cryogenic.Overrides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class Overrides {

    public void DefineMT32DriverCodeOverrides() {
        DefineFunction(0xF000, 0x100, DNMID_entry_00, true, nameof(DNMID_entry_00));
        DefineFunction(0xF000, 0x1CB, DNMID_internal_function_00, true, nameof(DNMID_internal_function_00));
    }

    private Action DNMID_entry_00(int arg) {
        return NearJump(0x17b);
    }

    /// <summary>
    /// Never called...?!
    /// </summary>

    private Action DNMID_internal_function_00(int arg) {
        return NearRet();
    }
}
