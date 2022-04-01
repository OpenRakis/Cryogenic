namespace Cryogenic.Overrides;

using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {
    public void DefineDataStructureOverrides() {
        DefineFunction(cs1, 0x98, ConvertIndexTableToPointerTable_1ED_98_1F68);
        DefineFunction(cs1, 0xC1F4, GetEsSiPointerToUnknown_1ED_C1F4_E0C4);
    }

    public Action ConvertIndexTableToPointerTable_1ED_98_1F68(int gotoAddress) {
        uint initialAddress = MemoryUtils.ToPhysicalAddress(State.ES, State.DI);

        // wtf
        int increment = State.DI;
        int count = UInt16[initialAddress] / 2;
        Uint16Array array = new Uint16Array(Memory, initialAddress, count);
        for (int i = 0; i < array.Length; i++) {
            array[i] = (ushort)(array[i] + increment);
        }

        return NearRet();
    }

    public Action GetEsSiPointerToUnknown_1ED_C1F4_E0C4(int gotoAddress) {
        // TODO: create a proper data structure with more organized accessors when what this is is known better.
        int index = State.AX;
        SegmentedAddress baseAddress = globalsOnDs.GetPtr1138_DBB0_Dword32_spriteSheetResourcePointer();
        int resOffset = baseAddress.Offset + UInt16[(uint)(baseAddress.ToPhysical() + index * 2)];
        State.ES = baseAddress.Segment;
        State.SI = (ushort)resOffset;
        return NearRet();
    }
}