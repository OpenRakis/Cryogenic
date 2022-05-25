namespace Cryogenic.Overrides;

using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides {
    public void DefineDataStructureOverrides() {
        DefineFunction(cs1, 0x98, ConvertIndexTableToPointerTable_1000_0098_010098);
        DefineFunction(cs1, 0xC1F4, GetEsSiPointerToUnknown_1000_C1F4_01C1F4);
    }

    public Action ConvertIndexTableToPointerTable_1000_0098_010098(int gotoAddress) {
        uint initialAddress = MemoryUtils.ToPhysicalAddress(ES, DI);

        // wtf
        int increment = DI;
        int count = UInt16[initialAddress] / 2;
        Uint16Array array = new Uint16Array(Memory, initialAddress, count);
        for (int i = 0; i < array.Length; i++) {
            array[i] = (ushort)(array[i] + increment);
        }

        return NearRet();
    }

    public Action GetEsSiPointerToUnknown_1000_C1F4_01C1F4(int gotoAddress) {
        // TODO: create a proper data structure with more organized accessors when what this is is known better.
        int index = AX;
        SegmentedAddress baseAddress = globalsOnDs.GetPtr1138_DBB0_Dword32_spriteSheetResourcePointer();
        int resOffset = baseAddress.Offset + UInt16[(uint)(baseAddress.ToPhysical() + index * 2)];
        ES = baseAddress.Segment;
        SI = (ushort)resOffset;
        return NearRet();
    }
}