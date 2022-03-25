namespace Cryogenic.Mainexe.Datastructures;

using Cryogenic.Globals;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class DatastructuresCode : CSharpOverrideHelper {
    private ExtraGlobalsOnDs globals;

    public DatastructuresCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine) : base(functionInformations, "datastructures", machine) {
        globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0x98, ConvertIndexTableToPointerTable_1ED_98_1F68);
        DefineFunction(segment, 0xC1F4, GetEsSiPointerToUnknown_1ED_C1F4_E0C4);
    }

    public Action ConvertIndexTableToPointerTable_1ED_98_1F68() {
        uint initialAddress = MemoryUtils.ToPhysicalAddress(State.ES, State.DI);

        // wtf
        int increment = State.DI;
        int count = UInt16[initialAddress] / 2;
        Uint16Array array = new Uint16Array(Memory, initialAddress, count);
        for (int i = 0; i < array.Length; i++) {
            var v = array.GetValueAt(i);
            array.SetValueAt(i, (ushort)(v + increment));
        }
        return NearRet();
    }

    public Action GetEsSiPointerToUnknown_1ED_C1F4_E0C4() {
        // TODO: create a proper data structure with more organized accessors when what this is is known better.
        int index = State.AX;
        SegmentedAddress baseAddress = globals.GetPtr1138_DBB0_Dword32_spriteSheetResourcePointer();
        int resOffset = baseAddress.Offset + UInt16[(uint)(baseAddress.ToPhysical() + index * 2)];
        State.ES = (baseAddress.Segment);
        State.SI = (ushort)resOffset;
        return NearRet();
    }
}