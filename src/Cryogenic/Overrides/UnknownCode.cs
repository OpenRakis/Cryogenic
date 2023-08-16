namespace Cryogenic.Overrides;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides {

    public void DefineUnknownCodeOverrides() {
        DefineFunction(cs1, 0x0F66, NoOp_1000_0F66_10F66);
        DefineFunction(cs1, 0x5B99, MemCopy8BytesDsSIToDsDi_1000_5B99_15B99);
        DefineFunction(cs1, 0x5BA0, MemCopy8BytesFrom1470ToD83C_1000_5BA0_15BA0);
        DefineFunction(cs1, 0x5BA8, MemCopy8Bytes_1000_5BA8_15BA8);
        DefineFunction(cs1, 0xAE2F, CheckPcmEnabled_1000_AE2F_1AE2F);
        DefineFunction(cs1, 0xAEC6, IsUnknownDBC80x100And2943BitmaskNonZero_1000_AEC6_1AEC6);
        DefineFunction(cs1, 0xD443, "DispatcherJumpsToBX");
        DefineFunction(cs1, 0xD454, "DispatcherHelperDeterminesWhereToJump");
        DefineFunction(cs1, 0x4AC4, SetUnknown11CATo0_1000_4AC4_14AC4);
        DefineFunction(cs1, 0x4ACA, SetUnknown11CATo1_1000_4ACA_14ACA);
        DefineFunction(cs1, 0xABCC, IsUnknownDC2BZero_1000_ABCC_1ABCC);
        DefineFunction(cs1, 0xAE28, IsUnknownDBC80x100_1000_AE28_1AE28);
        DefineFunction(cs1, 0xB2BE, SetUnknown2788To0_1000_B2BE_1B2BE);
        DefineFunction(cs1, 0xD917, NoOp_1000_D917_01D917);
        DefineFunction(cs1, 0xDB44, ShlDXAndCXByAX_1000_DB44_01DB44);
        DefineFunction(cs1, 0xE26F, NoOp_1000_E26F_01E26F);
        DefineFunction(cs1, 0xE75B, UnknownStructCreation_1000_E75B_01E75B);
        DefineFunction(cs1, 0xE851, CheckNextFreeMemorySegment39B9_1000_E851_01E851);
        DefineFunction(cs1, 0x3AE9, Fill47F8WithFF_1000_3AE9_013AE9);
        DefineFunction(cs1, 0xB2B9, Inc2788_1000_B2B9_01B2B9);
        DefineFunction(cs1, 0xDE4E, SetCEE8To0_1000_DE4E_01DE4E);
    }

    public Action CheckPcmEnabled_1000_AE2F_1AE2F(int gotoAddress) {
        ushort value = globalsOnDs.Get1138_DBC8_Word16();
        Cpu.Alu.And16(value, 1);
        return NearRet();
    }

    public Action SetCEE8To0_1000_DE4E_01DE4E(int gotoAddress) {
        // Called when skipping some intro screens
        globalsOnDs.Set1138_CEE8_Byte8_keyHit(0);
        return NearRet();
    }

    public Action Inc2788_1000_B2B9_01B2B9(int gotoAddress) {
        // Called when looking at miror or at book, value seems to be always 0 at call time.
        byte value = globalsOnDs.Get1138_2788_Byte8();
        globalsOnDs.Set1138_2788_Byte8((byte)(value + 1));
        return NearRet();
    }

    public Action Fill47F8WithFF_1000_3AE9_013AE9(int gotoAddress) {
        // Called when leaving or entering a scene. Does not seem to have any effect on game whatever the value is in this
        // area.
        uint address = MemoryUtils.ToPhysicalAddress(DS, 0x47F8);
        Memory.Memset8(address, 0xFF, 2 * 0x2E);
        return NearRet();
    }

    public Action NoOp_1000_0F66_10F66(int gotoAddress) {
        // called before intro
        return NearRet();
    }

    public Action SetUnknown11CATo0_1000_4AC4_14AC4(int gotoAddress) {
        // triggered when orni lifts off and lands
        globalsOnDs.Set1138_11CA_Byte8(0);
        return NearRet();
    }

    public Action SetUnknown11CATo1_1000_4ACA_14ACA(int gotoAddress) {
        // triggered on orni map, flat map and discussion when displaying new dialogue on click and play screens and in
        // visions
        globalsOnDs.Set1138_11CA_Byte8(1);
        return NearRet();
    }

    public Action MemCopy8BytesDsSIToDsDi_1000_5B99_15B99(int gotoAddress) {
        // Called on scene change (example dialogue, room change)
        ES = DS;
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(DS, SI);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(ES, DI);

        // Moves 4 words from source to dest, so 8 bytes
        Memory.MemCopy(sourceAddress, destinationAddress, 8);
        SI = (ushort)(SI + 8);
        DI = (ushort)(DI + 8);
        return NearRet();
    }

    public Action MemCopy8BytesFrom1470ToD83C_1000_5BA0_15BA0(int gotoAddress) {
        // Called on room change
        SI = 0x1470;
        DI = 0xD83C;
        return MemCopy8BytesDsSIToDsDi_1000_5B99_15B99(0);
    }

    public Action MemCopy8Bytes_1000_5BA8_15BA8(int gotoAddress) {
        // Called on dialogue, screen change, intro demo and globe
        SI = 0x1470;
        DI = 0xD834;
        return MemCopy8BytesDsSIToDsDi_1000_5B99_15B99(0);
    }

    public Action IsUnknownDBC80x100And2943BitmaskNonZero_1000_AEC6_1AEC6(int gotoAddress) {
        // Called continuously
        int value = globalsOnDs.Get1138_2943_Byte8_cmdArgsMemory();
        bool res = true;
        if ((value & 0x10) == 0) {
            IsUnknownDBC80x100_1000_AE28_1AE28(0);
            if (!ZeroFlag) {
                res = false;
            }
        }

        _loggerService.Debug("2943={@Value},res={@Res}", value, res);
        CarryFlag = res;
        if (res) {
            throw FailAsUntested($"isUnknownDBC80x100And2943BitmaskNonZero was called with a true result. value: {value}");
        }

        return NearRet();
    }

    public Action IsUnknownDC2BZero_1000_ABCC_1ABCC(int gotoAddress) {
        ZeroFlag = globalsOnDs.Get1138_DC2B_Byte8() == 0;
        return NearRet();
    }

    public Action IsUnknownDBC80x100_1000_AE28_1AE28(int gotoAddress) {
        // Called constantly in game and at transitions during video
        ushort value = globalsOnDs.Get1138_DBC8_Word16();

        // Seems that this function is called with only JZ / JNZ, but not sure so call the real thing
        Cpu.Alu.Sub16(value, 0x100);
        return NearRet();
    }

    public Action SetUnknown2788To0_1000_B2BE_1B2BE(int gotoAddress) {
        // Called when game is loaded or when landing with orni. Other values do not seem to have any effect.
        globalsOnDs.Set1138_2788_Byte8(0);
        return NearRet();
    }

    public Action NoOp_1000_D917_01D917(int gotoAddress) {
        // called after first globe display
        return NearRet();
    }

    public Action ShlDXAndCXByAX_1000_DB44_01DB44(int gotoAddress) {
        // Called before setting mouse parameters
        ushort shiftCount = AX;
        CX = (ushort)(CX << shiftCount);
        DX = (ushort)(DX << shiftCount);
        return NearRet();
    }

    public Action NoOp_1000_E26F_01E26F(int gotoAddress) {
        // called after or during most screen transitions
        return NearRet();
    }

    public Action UnknownStructCreation_1000_E75B_01E75B(int gotoAddress) {
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(ES, DI);
        Memory.UInt16[destinationAddress] = AX;
        Memory.UInt8[destinationAddress + 2] = DL;
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(DS, SI) + 0x10;
        Memory.MemCopy(sourceAddress, destinationAddress + 3, 3);
        Memory.MemCopy(sourceAddress + 4, destinationAddress + 6, 4);

        // 10 bytes copied in total
        DI = (ushort)(DI + 10);
        return NearRet();
    }

    public Action CheckNextFreeMemorySegment39B9_1000_E851_01E851(int gotoAddress) {
        // Game stops if carry flag is unset
        ushort value = globalsOnDs.Get1138_39B9_Word16_allocatorNextFreeSegment();
        value += 0x2F13;
        Cpu.Alu.Sub16(value, globalsOnDs.Get1138_CE68_Word16_allocatorLastFreeSegment());
        return NearRet();
    }
}