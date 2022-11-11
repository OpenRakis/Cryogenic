namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Memory;
using Spice86.Core.Emulator.ReverseEngineer;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {

    public void DefineUnknownCodeOverrides() {
        DefineFunction(cs1, 0x0F66, NoOp_1ED_F66_2E36);
        DefineFunction(cs1, 0x5B99, MemCopy8BytesDsSIToDsDi_1ED_5B99_7A69);
        DefineFunction(cs1, 0x5BA0, MemCopy8BytesFrom1470ToD83C_1ED_5BA0_7A70);
        DefineFunction(cs1, 0x5BA8, MemCopy8Bytes_1ED_5BA8_7A78);
        DefineFunction(cs1, 0xAE2F, CheckPcmEnabled_1ED_AE2F_CCFF);
        DefineFunction(cs1, 0xAEC6, IsUnknownDBC80x100And2943BitmaskNonZero_1ED_AEC6_CD96);
        DefineFunction(cs1, 0xD443, "DispatcherJumpsToBX");
        DefineFunction(cs1, 0xD454, "DispatcherHelperDeterminesWhereToJump");
        DefineFunction(cs1, 0x4AC4, SetUnknown11CATo0_1ED_4AC4_6994);
        DefineFunction(cs1, 0x4ACA, SetUnknown11CATo1_1ED_4ACA_699A);
        DefineFunction(cs1, 0xABCC, IsUnknownDC2BZero_1ED_ABCC_CA9C);
        DefineFunction(cs1, 0xAE28, IsUnknownDBC80x100_1ED_AE28_CCF8);
        DefineFunction(cs1, 0xB2BE, SetUnknown2788To0_1ED_B2BE_D18E);
        DefineFunction(cs1, 0xD917, NoOp_1ED_D917_F7E7);
        DefineFunction(cs1, 0xDB44, ShlDXAndCXByAX_1ED_DB44_FA14);
        DefineFunction(cs1, 0xE26F, NoOp_1ED_E26F_1013F);
        DefineFunction(cs1, 0xE75B, UnknownStructCreation_1ED_E75B_1062B);
        DefineFunction(cs1, 0xE851, CheckUnknown39B9_1ED_E851_10721);
        DefineFunction(cs1, 0x3AE9, Fill47F8WithFF_1ED_3AE9_59B9);
        DefineFunction(cs1, 0xB2B9, Inc2788_1ED_B2B9_D189);
        DefineFunction(cs1, 0xDE4E, SetCEE8To0_1ED_DE4E_FD1E);
    }

    public Action CheckPcmEnabled_1ED_AE2F_CCFF(int gotoAddress) {
        ushort value = globalsOnDs.Get1138_DBC8_Word16();
        Cpu.Alu.And16(value, 1);
        return NearRet();
    }

    public Action SetCEE8To0_1ED_DE4E_FD1E(int gotoAddress) {
        // Called when skipping some intro screens
        globalsOnDs.Set1138_CEE8_Byte8_keyHit(0);
        return NearRet();
    }

    public Action Inc2788_1ED_B2B9_D189(int gotoAddress) {
        // Called when looking at miror or at book, value seems to be always 0 at call time.
        byte value = globalsOnDs.Get1138_2788_Byte8();
        globalsOnDs.Set1138_2788_Byte8((byte)(value + 1));
        return NearRet();
    }

    public Action Fill47F8WithFF_1ED_3AE9_59B9(int gotoAddress) {
        // Called when leaving or entering a scene. Does not seem to have any effect on game whatever the value is in this
        // area.
        uint address = MemoryUtils.ToPhysicalAddress(State.DS, 0x47F8);
        Memory.Memset(address, 0xFF, 2 * 0x2E);
        return NearRet();
    }

    public Action NoOp_1ED_F66_2E36(int gotoAddress) {
        // called before intro
        return NearRet();
    }

    public Action SetUnknown11CATo0_1ED_4AC4_6994(int gotoAddress) {
        // triggered when orni lifts off and lands
        globalsOnDs.Set1138_11CA_Byte8(0);
        return NearRet();
    }

    public Action SetUnknown11CATo1_1ED_4ACA_699A(int gotoAddress) {
        // triggered on orni map, flat map and discussion when displaying new dialogue on click and play screens and in
        // visions
        globalsOnDs.Set1138_11CA_Byte8(1);
        return NearRet();
    }

    public Action MemCopy8BytesDsSIToDsDi_1ED_5B99_7A69(int gotoAddress) {
        // Called on scene change (example dialogue, room change)
        State.ES = State.DS;
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(State.DS, State.SI);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(State.ES, State.DI);

        // Moves 4 words from source to dest, so 8 bytes
        Memory.MemCopy(sourceAddress, destinationAddress, 8);
        State.SI = (ushort)(State.SI + 8);
        State.DI = (ushort)(State.DI + 8);
        return NearRet();
    }

    public Action MemCopy8BytesFrom1470ToD83C_1ED_5BA0_7A70(int gotoAddress) {
        // Called on room change
        State.SI = 0x1470;
        State.DI = 0xD83C;
        return MemCopy8BytesDsSIToDsDi_1ED_5B99_7A69(0);
    }

    public Action MemCopy8Bytes_1ED_5BA8_7A78(int gotoAddress) {
        // Called on dialogue, screen change, intro demo and globe
        State.SI = 0x1470;
        State.DI = 0xD834;
        return MemCopy8BytesDsSIToDsDi_1ED_5B99_7A69(0);
    }

    public Action IsUnknownDBC80x100And2943BitmaskNonZero_1ED_AEC6_CD96(int gotoAddress) {
        // Called continuously
        int value = globalsOnDs.Get1138_2943_Byte8_cmdArgsMemory();
        bool res = true;
        if ((value & 0x10) == 0) {
            IsUnknownDBC80x100_1ED_AE28_CCF8(0);
            if (!State.ZeroFlag) {
                res = false;
            }
        }

        _logger.Debug("2943={@Value},res={@Res}", value, res);
        State.CarryFlag = res;
        if (res) {
            throw FailAsUntested($"isUnknownDBC80x100And2943BitmaskNonZero was called with a true result. value: {value}");
        }

        return NearRet();
    }

    public Action IsUnknownDC2BZero_1ED_ABCC_CA9C(int gotoAddress) {
        State.ZeroFlag = globalsOnDs.Get1138_DC2B_Byte8() == 0;
        return NearRet();
    }

    public Action IsUnknownDBC80x100_1ED_AE28_CCF8(int gotoAddress) {
        // Called constantly in game and at transitions during video
        ushort value = globalsOnDs.Get1138_DBC8_Word16();

        // Seems that this function is called with only JZ / JNZ, but not sure so call the real thing
        Cpu.Alu.Sub16(value, 0x100);
        if (value != 0) {
            throw FailAsUntested("isUnknownDBC80x100 was called with a non zero value: " + value);
        }

        return NearRet();
    }

    public Action SetUnknown2788To0_1ED_B2BE_D18E(int gotoAddress) {
        // Called when game is loaded or when landing with orni. Other values do not seem to have any effect.
        globalsOnDs.Set1138_2788_Byte8(0);
        return NearRet();
    }

    public Action NoOp_1ED_D917_F7E7(int gotoAddress) {
        // called after first globe display
        return NearRet();
    }

    public Action ShlDXAndCXByAX_1ED_DB44_FA14(int gotoAddress) {
        // Called before setting mouse parameters
        ushort shiftCount = State.AX;
        State.CX = (ushort)(State.CX << shiftCount);
        State.DX = (ushort)(State.DX << shiftCount);
        return NearRet();
    }

    public Action NoOp_1ED_E26F_1013F(int gotoAddress) {
        // called after or during most screen transitions
        return NearRet();
    }

    public Action UnknownStructCreation_1ED_E75B_1062B(int gotoAddress) {
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(State.ES, State.DI);
        Memory.SetUint16(destinationAddress, State.AX);
        Memory.SetUint8(destinationAddress + 2, State.DL);
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(State.DS, State.SI) + 0x10;
        Memory.MemCopy(sourceAddress, destinationAddress + 3, 3);
        Memory.MemCopy(sourceAddress + 4, destinationAddress + 6, 4);

        // 10 bytes copied in total
        State.DI = (ushort)(State.DI + 10);
        return NearRet();
    }

    public Action CheckUnknown39B9_1ED_E851_10721(int gotoAddress) {
        // Game stops if carry flag is unset
        ushort value = globalsOnDs.Get1138_39B9_Word16_allocatorNextFreeSegment();
        value += 0x2F13;
        Cpu.Alu.Sub16(value, globalsOnDs.Get1138_CE68_Word16_allocatorLastFreeSegment());
        return NearRet();
    }
}