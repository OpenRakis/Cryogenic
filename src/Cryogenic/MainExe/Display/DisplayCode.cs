namespace Cryogenic.Mainexe.Display;

using Cryogenic.Globals;
using Cryogenic.Vgadriver;

using Serilog;

using Spice86.Emulator.CPU;
using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class DisplayCode : CSharpOverrideHelper {
    private static readonly ILogger _logger = Log.Logger.ForContext<DisplayCode>();
    private ExtraGlobalsOnDs globals;
    private VgaDriverCode vgaDriver;

    public DisplayCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine, VgaDriverCode vgaDriver) : base(functionInformations, "display", machine) {
        this.vgaDriver = vgaDriver;
        globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0x0579, ClearGlobalVgaOffset_1ED_579_2449);
        DefineFunction(segment, 0x98F5, ClearUnknownValuesAndAX_1ED_98F5_B7C5);
        DefineFunction(segment, 0x9901, Set479ETo0_1ED_9901_B7D1);
        DefineFunction(segment, 0xC07C, SetFrontBufferAsActiveFrameBuffer_1ED_C07C_DF4C);
        DefineFunction(segment, 0xC085, SetBackBufferAsActiveFrameBuffer_1ED_C085_DF55);
        DefineFunction(segment, 0xC08E, SetTextBufferAsActiveFrameBuffer_1ED_C08E_DF5E);
        DefineFunction(segment, 0xC0AD, ClearCurrentVideoBuffer_1ED_C0AD_DF7D);
        DefineFunction(segment, 0xD05F, GetCharacterCoordsXY_1ED_D05F_EF2F);
        DefineFunction(segment, 0xD068, SetFontToIntro_1ED_D068_EF38);
        DefineFunction(segment, 0xD075, SetFontToMenu_1ED_D075_EF45);
        DefineFunction(segment, 0xD082, SetFontToBook_1ED_D082_EF52);
        DefineFunction(segment, 0xE270, PushAll_1ED_E270_10140);
        DefineFunction(segment, 0xE283, PopAll_1ED_E283_10153);
    }

    public Action ClearCurrentVideoBuffer_1ED_C0AD_DF7D(int gotoAddress) {
        State.ES = ((byte)globals.Get1138_DBDA_Word16_framebufferActive());
        vgaDriver.VgaFunc08FillWithZeroFor64000AtES_2538_118_25498(0);
        return NearRet();
    }

    public Action ClearUnknownValuesAndAX_1ED_98F5_B7C5(int gotoAddress) {
        // Called after screen change (video, room, dialogue, map ...).
        // When set to 255, cannot enter orni and enter palace instead
        _logger.Debug("Before: 1C06:{@1C06}, 1BF8:{@1BF8}, 1BEA:{@1BEA}", globals.Get1138_1C06_Word16(), globals.Get1138_1BF8_Word16(), globals.Get1138_1BEA_Word16());
        globals.Set1138_1C06_Word16(0);

        // 128 after end of dialogue if character is in the room
        globals.Set1138_1BF8_Word16(0);

        // 128 after end of dialogue
        globals.Set1138_1BEA_Word16(0);

        // If not done, book videos will show a character on screen instead
        State.AX = (0);
        return NearRet();
    }

    // sets the gfx offset to 0
    public Action ClearGlobalVgaOffset_1ED_579_2449(int gotoAddress) {
        _logger.Debug("Clearing VGA offset");
        CheckVtableContainsExpected(SegmentRegisters.DsIndex, 0x3939, vgaDriver.GetBaseSegment(), 0x163);
        State.AX = (0);
        vgaDriver.VgaFunc33UpdateVgaOffset01A3FromLineNumberAsAx_2538_163_254E3(0);
        return NearRet();
    }

    public Action GetCharacterCoordsXY_1ED_D05F_EF2F(int gotoAddress) {
        ushort x = globals.Get1138_D82C_Word16_CharacterXCoord();
        ushort y = globals.Get1138_D82E_Word16_CharacterYCoord();
        State.DX = (x);
        State.BX = (y);
        _logger.Debug("getCharacterCoordsXY x:{@X} y:{@Y}", State.DX, State.BX);
        return NearRet();
    }

    public Action PopAll_1ED_E283_10153(int gotoAddress) {
        _logger.Debug("popAll");

        // Called in most changes related to display like scene change, displaying map, clicking on map, clicking on
        // characters ...
        // XCHG AX <-> Stack[0x0C] (or 0x0E if done before the pop)
        ushort ax = Stack.Pop();
        ushort stackPeek = Stack.Peek(0x0C);
        Stack.Poke(0x0C, ax);
        State.AX = (stackPeek);

        // Regular pops
        State.BP = (Stack.Pop());
        State.DI = (Stack.Pop());
        State.SI = (Stack.Pop());
        State.DX = (Stack.Pop());
        State.CX = (Stack.Pop());
        State.BX = (Stack.Pop());
        return NearRet();
    }

    public Action PushAll_1ED_E270_10140(int gotoAddress) {
        _logger.Debug("pushAll");
        Stack.Push(State.BX);
        Stack.Push(State.CX);
        Stack.Push(State.DX);
        Stack.Push(State.SI);
        Stack.Push(State.DI);
        Stack.Push(State.BP);
        ushort stackTop = Stack.Peek(0);

        // XCHG AX <-> Stack[0x0C]
        ushort stackPeek = Stack.Peek(0x0C);
        Stack.Poke(0x0C, State.AX);

        // In the original assembly code, AX seems modified but it's not the case as it's restored to its original value
        // later.
        Stack.Push(stackPeek);
        State.BP = (stackTop);
        return NearRet();
    }

    public Action Set479ETo0_1ED_9901_B7D1(int gotoAddress) {
        // Called in intro when skipping scenes and in the book when clicking subjects or quitting.
        // Screen in intro becomes garbled when setting something else than 0.
        globals.Set1138_479E_Word16(0);
        return NearRet();
    }

    public Action SetBackBufferAsActiveFrameBuffer_1ED_C085_DF55(int gotoAddress) {
        ushort value = globals.Get1138_DC32_Word16_framebufferBack();
        return SetVideoBuffer(value, "setDialogueVideoBufferSegmentDC32");
    }

    // book fonts related
    public Action SetFontToBook_1ED_D082_EF52(int gotoAddress) {
        globals.Set1138_2518_Word16_FontRelated(0xD0FF);
        globals.Set1138_47A0_Word16_FontRelated(0xCEEC);
        return NearRet();
    }

    // intro and map fonts
    public Action SetFontToIntro_1ED_D068_EF38(int gotoAddress) {
        globals.Set1138_2518_Word16_FontRelated(0xD096);
        globals.Set1138_47A0_Word16_FontRelated(0xCEEC);
        return NearRet();
    }

    // menu fonts related
    public Action SetFontToMenu_1ED_D075_EF45(int gotoAddress) {
        globals.Set1138_2518_Word16_FontRelated(0xD12F);
        globals.Set1138_47A0_Word16_FontRelated(0xCF6C);
        return NearRet();
    }

    public Action SetTextBufferAsActiveFrameBuffer_1ED_C08E_DF5E(int gotoAddress) {
        ushort value = globals.Get1138_DBD8_Word16_screenBuffer();
        return SetVideoBuffer(value, "setTextVideoBufferSegmentDBD8");
    }

    public Action SetFrontBufferAsActiveFrameBuffer_1ED_C07C_DF4C(int gotoAddress) {
        ushort value = globals.Get1138_DBD6_Word16_framebufferFront();
        return SetVideoBuffer(value, "setVideoBufferSegmentDBD6");
    }

    private Action SetVideoBuffer(ushort value, string functionName) {
        ushort oldValue = globals.Get1138_DBDA_Word16_framebufferActive();
        if (value != oldValue) {
            globals.Set1138_DBDA_Word16_framebufferActive(value);
            _logger.Debug("{@FunctionName} value:{@Value}, oldValue:{@OldValue}", functionName, value, oldValue);
        }

        return NearRet();
    }
}