namespace Cryogenic.Mainexe;

using Cryogenic.Globals;

using Serilog;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class UnknownCode : CSharpOverrideHelper {
    private static readonly ILogger _logger = Log.Logger.ForContext<UnknownCode>();
    private ExtraGlobalsOnDs globals;
    public UnknownCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine) : base(functionInformations, "mainCode", machine) {
        globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0x0F66, "noOp", NoOp_1ED_F66_2E36);
        DefineFunction(segment, 0x5B99, "memCopy8BytesDsSIToDsDi", MemCopy8BytesDsSIToDsDi_1ED_5B99_7A69);
        DefineFunction(segment, 0x5BA0, "memCopy8BytesFrom1470ToD83C", MemCopy8BytesFrom1470ToD83C_1ED_5BA0_7A70);
        DefineFunction(segment, 0x5BA8, "memCopy8Bytes", MemCopy8Bytes_1ED_5BA8_7A78);
        DefineFunction(segment, 0xAE2F, "isUnknownDBC8And1/check_pcm_enabled_ida", IsUnknownDBC8And1_1ED_AE2F_CCFF);
        DefineFunction(segment, 0xAEC6, "isUnknownDBC80x100And2943BitmaskNonZero", IsUnknownDBC80x100And2943BitmaskNonZero_1ED_AEC6_CD96);
        DefineFunction(segment, 0xD443, "dispatcherJumpsToBX");
        DefineFunction(segment, 0xD454, "dispatcherHelperDeterminesWhereToJump");
        DefineFunction(segment, 0x4AC4, "setUnknown11CATo0", SetUnknown11CATo0_1ED_4AC4_6994);
        DefineFunction(segment, 0x4ACA, "setUnknown11CATo1", SetUnknown11CATo1_1ED_4ACA_699A);
        DefineFunction(segment, 0xABCC, "isUnknownDC2BZero", IsUnknownDC2BZero_1ED_ABCC_CA9C);
        DefineFunction(segment, 0xAE28, "isUnknownDBC80x100", IsUnknownDBC80x100_1ED_AE28_CCF8);
        DefineFunction(segment, 0xB2BE, "setUnknown2788To0", SetUnknown2788To0_1ED_B2BE_D18E);
        DefineFunction(segment, 0xD917, "noOp", NoOp_1ED_D917_F7E7);
        DefineFunction(segment, 0xDB44, "shlDXAndCXByAH", ShlDXAndCXByAH_1ED_DB44_FA14);
        DefineFunction(segment, 0xE26F, "noOp", NoOp_1ED_E26F_1013F);
        DefineFunction(segment, 0xE75B, "unknownStructCreation", UnknownStructCreation_1ED_E75B_1062B);
        DefineFunction(segment, 0xE851, "checkUnknown39B9", CheckUnknown39B9_1ED_E851_10721);
        DefineFunction(segment, 0x3AE9, "fill47F8WithFF", Fill47F8WithFF_1ED_3AE9_59B9);
        DefineFunction(segment, 0xB2B9, "inc2788", Inc2788_1ED_B2B9_D189);
        DefineFunction(segment, 0xDE4E, "setCEE8To0", SetCEE8To0_1ED_DE4E_FD1E);
    }

    public Action IsUnknownDBC8And1_1ED_AE2F_CCFF() {

        // Called upon action? in intro / dialogues / ...
        ushort value = globals.Get1138_DBC8_Word16();
        _cpu.GetAlu().And16(value, 1);
        return NearRet();
    }

    public Action SetCEE8To0_1ED_DE4E_FD1E() {

        // Called when skipping some intro screens
        globals.Set1138_CEE8_Byte8_keyHit(0);
        return NearRet();
    }

    public Action Inc2788_1ED_B2B9_D189() {

        // Called when looking at miror or at book, value seems to be always 0 at call time.
        byte value = globals.Get1138_2788_Byte8();
        globals.Set1138_2788_Byte8((byte)(value + 1));
        return NearRet();
    }

    public Action Fill47F8WithFF_1ED_3AE9_59B9() {

        // Called when leaving or entering a scene. Does not seem to have any effect on game whatever the value is in this
        // area.
        uint address = MemoryUtils.ToPhysicalAddress(_state.GetDS(), 0x47F8);
        _memory.Memset(address, 0xFF, 2 * 0x2E);
        return NearRet();
    }

    public Action NoOp_1ED_F66_2E36() {

        // called before intro
        return NearRet();
    }

    public Action SetUnknown11CATo0_1ED_4AC4_6994() {

        // triggered when orni lifts off and lands
        globals.Set1138_11CA_Byte8(0);
        return NearRet();
    }

    public Action SetUnknown11CATo1_1ED_4ACA_699A() {

        // triggered on orni map, flat map and discussion when displaying new dialogue on click and play screens and in
        // visions
        globals.Set1138_11CA_Byte8(1);
        return NearRet();
    }

    public Action MemCopy8BytesDsSIToDsDi_1ED_5B99_7A69() {

        // Called on scene change (example dialogue, room change)
        _state.SetES(_state.GetDS());
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(_state.GetDS(), _state.GetSI());
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(_state.GetES(), _state.GetDI());

        // Moves 4 words from source to dest, so 8 bytes
        _memory.MemCopy(sourceAddress, destinationAddress, 8);
        _state.SetSI((ushort)(_state.GetSI() + 8));
        _state.SetDI((ushort)(_state.GetDI() + 8));
        return NearRet();
    }

    public Action MemCopy8BytesFrom1470ToD83C_1ED_5BA0_7A70() {

        // Called on room change
        _state.SetSI(0x1470);
        _state.SetDI(0xD83C);
        return MemCopy8BytesDsSIToDsDi_1ED_5B99_7A69();
    }

    public Action MemCopy8Bytes_1ED_5BA8_7A78() {

        // Called on dialogue, screen change, intro demo and globe
        _state.SetSI(0x1470);
        _state.SetDI(0xD834);
        return MemCopy8BytesDsSIToDsDi_1ED_5B99_7A69();
    }

    public Action IsUnknownDBC80x100And2943BitmaskNonZero_1ED_AEC6_CD96() {

        // Called continuously
        int value = globals.Get1138_2943_Byte8_cmdArgsMemory();
        bool res = true;
        if ((value & 0x10) == 0) {
            IsUnknownDBC80x100_1ED_AE28_CCF8();
            if (!_state.GetZeroFlag()) {
                res = false;
            }
        }

        _logger.Debug("2943={@Value},res={@Res}", value, res);
        _state.SetCarryFlag(res);
        if (res) {
            FailAsUntested($"isUnknownDBC80x100And2943BitmaskNonZero was called with a true result. value: {value}");
        }

        return NearRet();
    }

    public Action IsUnknownDC2BZero_1ED_ABCC_CA9C() {
        _state.SetZeroFlag(globals.Get1138_DC2B_Byte8() == 0);
        return NearRet();
    }

    public Action IsUnknownDBC80x100_1ED_AE28_CCF8() {

        // Called constantly in game and at transitions during video
        ushort value = globals.Get1138_DBC8_Word16();

        // Seems that this function is called with only JZ / JNZ, but not sure so call the real thing
        _cpu.GetAlu().Sub16(value, 0x100);
        if (value != 0) {
            FailAsUntested("isUnknownDBC80x100 was called with a non zero value: " + value);
        }

        return NearRet();
    }

    public Action SetUnknown2788To0_1ED_B2BE_D18E() {

        // Called when game is loaded or when landing with orni. Other values do not seem to have any effect.
        globals.Set1138_2788_Byte8(0);
        return NearRet();
    }

    public Action NoOp_1ED_D917_F7E7() {

        // called after first globe display
        return NearRet();
    }

    public Action ShlDXAndCXByAH_1ED_DB44_FA14() {

        // Called at the beginning of the intro, could not see any effect because shiftCount is always 0.
        byte shiftCount = _state.GetAH();
        if (shiftCount != 0) {
            this.FailAsUntested("Called with a non zero value, could never see it called that way!");
        }

        _state.SetCX((ushort)(_state.GetCX() << shiftCount));
        _state.SetDX((ushort)(_state.GetDX() << shiftCount));
        return NearRet();
    }

    public Action NoOp_1ED_E26F_1013F() {

        // called after or during most screen transitions
        return NearRet();
    }

    public Action UnknownStructCreation_1ED_E75B_1062B() {
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(_state.GetES(), _state.GetDI());
        _memory.SetUint16(destinationAddress, _state.GetAX());
        _memory.SetUint8(destinationAddress + 2, _state.GetDL());
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(_state.GetDS(), _state.GetSI()) + 0x10;
        _memory.MemCopy(sourceAddress, destinationAddress + 3, 3);
        _memory.MemCopy(sourceAddress + 4, destinationAddress + 6, 4);

        // 10 bytes copied in total
        _state.SetDI((ushort)(_state.GetDI() + 10));
        return NearRet();
    }

    public Action CheckUnknown39B9_1ED_E851_10721() {

        // Game stops if carry flag is unset
        ushort value = globals.Get1138_39B9_Word16_allocatorNextFreeSegment();
        value += 0x2F13;
        _cpu.GetAlu().Sub16(value, globals.Get1138_CE68_Word16_allocatorLastFreeSegment());
        return NearRet();
    }
}
