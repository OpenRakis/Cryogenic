namespace Cryogenic.Overrides;

using Cryogenic.Globals;
using Serilog;

using Spice86.Core.Emulator.CPU;
using Spice86.Core.Emulator.ReverseEngineer;
using Spice86.Core.Emulator.Memory;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {
    public void DefineDisplayCodeOverrides() {
        DefineFunction(cs1, 0x0579, ClearGlobalVgaOffset_1ED_579_2449);
        DefineFunction(cs1, 0x98F5, ClearUnknownValuesAndAX_1ED_98F5_B7C5);
        DefineFunction(cs1, 0x9901, Set479ETo0_1ED_9901_B7D1);
        DefineFunction(cs1, 0xC07C, SetFrontBufferAsActiveFrameBuffer_1ED_C07C_DF4C);
        DefineFunction(cs1, 0xC085, SetBackBufferAsActiveFrameBuffer_1ED_C085_DF55);
        DefineFunction(cs1, 0xC08E, SetTextBufferAsActiveFrameBuffer_1ED_C08E_DF5E);
        DefineFunction(cs1, 0xC0AD, ClearCurrentVideoBuffer_1ED_C0AD_DF7D);
        DefineFunction(cs1, 0xD05F, GetCharacterCoordsXY_1ED_D05F_EF2F);
        DefineFunction(cs1, 0xD068, SetFontToIntro_1ED_D068_EF38);
        DefineFunction(cs1, 0xD075, SetFontToMenu_1ED_D075_EF45);
        DefineFunction(cs1, 0xD082, SetFontToBook_1ED_D082_EF52);
        DefineFunction(cs1, 0xE270, PushAll_1ED_E270_10140);
        DefineFunction(cs1, 0xE283, PopAll_1ED_E283_10153);
    }

    public Action ClearCurrentVideoBuffer_1ED_C0AD_DF7D(int gotoAddress) {
        State.ES = globalsOnDs.Get1138_DBDA_Word16_framebufferActive();
        VgaFunc08FillWithZeroFor64000AtES_2538_118_25498(0);
        return NearRet();
    }

    public Action ClearUnknownValuesAndAX_1ED_98F5_B7C5(int gotoAddress) {
        // Called after screen change (video, room, dialogue, map ...).
        // When set to 255, cannot enter orni and enter palace instead
        _logger.Debug("Before: 1C06:{@1C06}, 1BF8:{@1BF8}, 1BEA:{@1BEA}", globalsOnDs.Get1138_1C06_Word16(), globalsOnDs.Get1138_1BF8_Word16(), globalsOnDs.Get1138_1BEA_Word16());
        globalsOnDs.Set1138_1C06_Word16(0);

        // 128 after end of dialogue if character is in the room
        globalsOnDs.Set1138_1BF8_Word16(0);

        // 128 after end of dialogue
        globalsOnDs.Set1138_1BEA_Word16(0);

        // If not done, book videos will show a character on screen instead
        State.AX = 0;
        return NearRet();
    }

    // sets the gfx offset to 0
    public Action ClearGlobalVgaOffset_1ED_579_2449(int gotoAddress) {
        _logger.Debug("Clearing VGA offset");
        CheckVtableContainsExpected(SegmentRegisters.DsIndex, 0x3939, cs2, 0x163);
        State.AX = 0;
        VgaFunc33UpdateVgaOffset01A3FromLineNumberAsAx_2538_163_254E3(0);
        return NearRet();
    }

    public Action GetCharacterCoordsXY_1ED_D05F_EF2F(int gotoAddress) {
        ushort x = globalsOnDs.Get1138_D82C_Word16_CharacterXCoord();
        ushort y = globalsOnDs.Get1138_D82E_Word16_CharacterYCoord();
        State.DX = x;
        State.BX = y;
        _logger.Debug("getCharacterCoordsXY x:{@X} y:{@Y}", State.DX, State.BX);
        return NearRet();
    }

    public Action PopAll_1ED_E283_10153(int gotoAddress) {
        _logger.Debug("popAll");

        // Called in most changes related to display like scene change, displaying map, clicking on map, clicking on
        // characters ...
        // XCHG AX <-> Stack[0x0C] (or 0x0E if done before the pop)
        ushort ax = Stack.Pop16();
        ushort stackPeek = Stack.Peek16(0x0C);
        Stack.Poke16(0x0C, ax);
        State.AX = stackPeek;

        // Regular pops
        State.BP = Stack.Pop16();
        State.DI = Stack.Pop16();
        State.SI = Stack.Pop16();
        State.DX = Stack.Pop16();
        State.CX = Stack.Pop16();
        State.BX = Stack.Pop16();
        return NearRet();
    }

    public Action PushAll_1ED_E270_10140(int gotoAddress) {
        _logger.Debug("pushAll");
        Stack.Push16(State.BX);
        Stack.Push16(State.CX);
        Stack.Push16(State.DX);
        Stack.Push16(State.SI);
        Stack.Push16(State.DI);
        Stack.Push16(State.BP);
        ushort stackTop = Stack.Peek16(0);

        // XCHG AX <-> Stack[0x0C]
        ushort stackPeek = Stack.Peek16(0x0C);
        Stack.Poke16(0x0C, State.AX);

        // In the original assembly code, AX seems modified but it's not the case as it's restored to its original value
        // later.
        Stack.Push16(stackPeek);
        State.BP = stackTop;
        return NearRet();
    }

    public Action Set479ETo0_1ED_9901_B7D1(int gotoAddress) {
        // Called in intro when skipping scenes and in the book when clicking subjects or quitting.
        // Screen in intro becomes garbled when setting something else than 0.
        globalsOnDs.Set1138_479E_Word16(0);
        return NearRet();
    }

    public Action SetBackBufferAsActiveFrameBuffer_1ED_C085_DF55(int gotoAddress) {
        ushort value = globalsOnDs.Get1138_DC32_Word16_framebufferBack();
        return SetVideoBuffer(value, "setDialogueVideoBufferSegmentDC32");
    }

    // book fonts related
    public Action SetFontToBook_1ED_D082_EF52(int gotoAddress) {
        globalsOnDs.Set1138_2518_Word16_FontRelated(0xD0FF);
        globalsOnDs.Set1138_47A0_Word16_FontRelated(0xCEEC);
        return NearRet();
    }

    // intro and map fonts
    public Action SetFontToIntro_1ED_D068_EF38(int gotoAddress) {
        globalsOnDs.Set1138_2518_Word16_FontRelated(0xD096);
        globalsOnDs.Set1138_47A0_Word16_FontRelated(0xCEEC);
        return NearRet();
    }

    // menu fonts related
    public Action SetFontToMenu_1ED_D075_EF45(int gotoAddress) {
        globalsOnDs.Set1138_2518_Word16_FontRelated(0xD12F);
        globalsOnDs.Set1138_47A0_Word16_FontRelated(0xCF6C);
        return NearRet();
    }

    public Action SetTextBufferAsActiveFrameBuffer_1ED_C08E_DF5E(int gotoAddress) {
        ushort value = globalsOnDs.Get1138_DBD8_Word16_screenBuffer();
        return SetVideoBuffer(value, "setTextVideoBufferSegmentDBD8");
    }

    public Action SetFrontBufferAsActiveFrameBuffer_1ED_C07C_DF4C(int gotoAddress) {
        ushort value = globalsOnDs.Get1138_DBD6_Word16_framebufferFront();
        return SetVideoBuffer(value, "setVideoBufferSegmentDBD6");
    }

    private Action SetVideoBuffer(ushort value, string functionName) {
        ushort oldValue = globalsOnDs.Get1138_DBDA_Word16_framebufferActive();
        if (value != oldValue) {
            globalsOnDs.Set1138_DBDA_Word16_framebufferActive(value);
            _logger.Debug("{@FunctionName} value:{@Value}, oldValue:{@OldValue}", functionName, value, oldValue);
        }

        return NearRet();
    }
}