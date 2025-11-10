namespace Cryogenic.Overrides;

using Spice86.Shared.Emulator.Memory;

using System;

public partial class Overrides {

    public void DefineMT32DriverCodeOverrides() {
        DefineFunction(0xF000, 0x100, DNMID_Driver_JumpTable, true, nameof(DNMID_Driver_JumpTable));
        DefineFunction(0xF000, 0x01CB, DNMID_internal_function_0xF000_0x1CB, true, nameof(DNMID_internal_function_0xF000_0x1CB));
    }

    private Action DNMID_Driver_JumpTable(int arg) {
        if(arg == 0) {
            NearCall(0xF000, 0x100, DNMID_internal_function_0xF000_0x1CB);
        }
        //jmp near ptr 01CBh (E9C800 (3))
        //jmp near ptr 0250h (E94A01 (3))
        //jmp near ptr 01E1h (E9D800 (3))
        //jmp near ptr 023Bh (E92F01 (3))
        //jmp near ptr 01EEh (E9DF00(3))
        //jmp near ptr 022Bh (E91601 (3))
        //jmp near ptr 022Bh (E91601 (3))
        return NearRet();
    }


    private Action DNMID_internal_function_0xF000_0x1CB(int arg) {
        //push DS
        Stack.Push16(DS);
        //mov AX,CS
        AX = CS;
        //mov DS,AX
        DS = AX;
        //mov AL,DS:[0x0139]
        AL = UInt8[new SegmentedAddress(DS, 0x0139)];
        //or AL,AL
        State.ZeroFlag = (AL == 0);
        //jns SHORT 0x033C
        if (!State.SignFlag) {
            //dec BYTE PTR DS:[0x011E]
            UInt16[DS, 0x011E] = Alu16.Dec(UInt16[DS, 0x011E]);
        }
        //call DS:0x0349
        //TODO
        NearCall(0xF000, 10, DS_0x0349);
        return NearRet();
    }

    private Action DS_0x0349(int arg) {
        return NearRet();
        // Implementation of DS:0x0349
    }
}
