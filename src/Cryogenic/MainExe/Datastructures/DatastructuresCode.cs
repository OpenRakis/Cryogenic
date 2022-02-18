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
        DefineFunction(segment, 0x98, "convertIndexTableToPointerTable/adjust_sub_resource_pointers_ida", ConvertIndexTableToPointerTable_1ED_98_1F68);
        DefineFunction(segment, 0xC1F4, "getEsSiPointerToUnknown", GetEsSiPointerToUnknown_1ED_C1F4_E0C4);
    }

    public Action ConvertIndexTableToPointerTable_1ED_98_1F68() {
        uint initialAddress = MemoryUtils.ToPhysicalAddress(_state.GetES(), _state.GetDI());

        // wtf
        int increment = _state.GetDI();
        int count = _memory.GetUint16(initialAddress) / 2;
        Uint16Array array = new Uint16Array(_memory, initialAddress, count);
        for (int i = 0; i < array.GetLength(); i++) {
            var v = array.GetValueAt(i);
            array.SetValueAt(i, (ushort)(v + increment));
        }
        return NearRet();
    }

    public Action GetEsSiPointerToUnknown_1ED_C1F4_E0C4() {
        // TODO: create a proper data structure with more organized accessors when what this is is known better.
        int index = _state.GetAX();
        SegmentedAddress baseAddress = globals.GetPtr1138_DBB0_Dword32_spriteSheetResourcePointer();
        int resOffset = baseAddress.GetOffset() + _memory.GetUint16((uint)(baseAddress.ToPhysical() + index * 2));
        _state.SetES(baseAddress.GetSegment());
        _state.SetSI((ushort)resOffset);
        return NearRet();
    }
}