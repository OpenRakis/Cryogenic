namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.CPU;

// Method names contain _ to separate addresses.
public partial class Overrides {
    public void DefineDisplayCodeOverrides() {
        DefineFunction(cs1, 0x0579, ClearGlobalVgaOffset_1000_0579_010579);
        DefineFunction(cs1, 0x98F5, ClearUnknownValuesAndAX_1000_98F5_0198F5);
        DefineFunction(cs1, 0x9901, Set479ETo0_1000_9901_019901);
        DefineFunction(cs1, 0xC07C, SetFrontBufferAsActiveFrameBuffer_1000_C07C_01C07C);
        DefineFunction(cs1, 0xC085, SetBackBufferAsActiveFrameBuffer_1000_C085_01C085);
        DefineFunction(cs1, 0xC08E, SetTextBufferAsActiveFrameBuffer_1000_C08E_01C08E);
        DefineFunction(cs1, 0xC0AD, ClearCurrentVideoBuffer_1000_C0AD_01C0AD);
        DefineFunction(cs1, 0xD05F, GetCharacterCoordsXY_1000_D05F_01D05F);
        DefineFunction(cs1, 0xD068, SetFontToIntro_1000_D068_01D068);
        DefineFunction(cs1, 0xD075, SetFontToMenu_1000_D075_01D075);
        DefineFunction(cs1, 0xD082, SetFontToBook_1ED_D082_EF52);
        DefineFunction(cs1, 0xE270, PushAll_1000_E270_01E270);
        DefineFunction(cs1, 0xE283, PopAll_1000_E283_01E283);
    }

    public Action ClearCurrentVideoBuffer_1000_C0AD_01C0AD(int gotoAddress) {
        State.ES = globalsOnDs.Get1138_DBDA_Word16_framebufferActive();
        VgaFunc08FillWithZeroFor64000AtES_334B_0118_0335C8(0);
        return NearRet();
    }

    public Action ClearUnknownValuesAndAX_1000_98F5_0198F5(int gotoAddress) {
        // Called after screen change (video, room, dialogue, map ...).
        // When set to 255, cannot enter orni and enter palace instead
        _logger.Debug("Before: 1C06:{@1C06}, 1BF8:{@1BF8}, 1BEA:{@1BEA}", globalsOnDs.Get1138_1C06_Word16(), globalsOnDs.Get1138_1BF8_Word16(), globalsOnDs.Get1138_1BEA_Word16());
        globalsOnDs.Set1138_1C06_Word16(0);

        // 128 after end of dialogue if character is in the room
        globalsOnDs.Set1138_1BF8_Word16(0);

        // 128 after end of dialogue
        globalsOnDs.Set1138_1BEA_Word16(0);

        // If not done, book videos will show a character on screen instead
        AX = 0;
        return NearRet();
    }

    // sets the gfx offset to 0
    public Action ClearGlobalVgaOffset_1000_0579_010579(int gotoAddress) {
        _logger.Debug("Clearing VGA offset");
        CheckVtableContainsExpected(SegmentRegisters.DsIndex, 0x3939, cs2, 0x163);
        AX = 0;
        VgaFunc33UpdateVgaOffset01A3FromLineNumberAsAx_334B_0163_033613(0);
        return NearRet();
    }

    public Action GetCharacterCoordsXY_1000_D05F_01D05F(int gotoAddress) {
        ushort x = globalsOnDs.Get1138_D82C_Word16_CharacterXCoord();
        ushort y = globalsOnDs.Get1138_D82E_Word16_CharacterYCoord();
        DX = x;
        BX = y;
        _logger.Debug("getCharacterCoordsXY x:{@X} y:{@Y}", DX, BX);
        return NearRet();
    }

    public Action PopAll_1000_E283_01E283(int gotoAddress) {
        _logger.Debug("popAll");

        // Called in most changes related to display like scene change, displaying map, clicking on map, clicking on
        // characters ...
        // XCHG AX <-> Stack[0x0C] (or 0x0E if done before the pop)
        ushort ax = Stack.Pop();
        ushort stackPeek = Stack.Peek(0x0C);
        Stack.Poke(0x0C, ax);
        AX = stackPeek;

        // Regular pops
        BP = Stack.Pop();
        DI = Stack.Pop();
        SI = Stack.Pop();
        DX = Stack.Pop();
        CX = Stack.Pop();
        BX = Stack.Pop();
        return NearRet();
    }

    public Action PushAll_1000_E270_01E270(int gotoAddress) {
        _logger.Debug("pushAll");
        Stack.Push(BX);
        Stack.Push(CX);
        Stack.Push(DX);
        Stack.Push(SI);
        Stack.Push(DI);
        Stack.Push(BP);
        ushort stackTop = Stack.Peek(0);

        // XCHG AX <-> Stack[0x0C]
        ushort stackPeek = Stack.Peek(0x0C);
        Stack.Poke(0x0C, AX);

        // In the original assembly code, AX seems modified but it's not the case as it's restored to its original value
        // later.
        Stack.Push(stackPeek);
        BP = stackTop;
        return NearRet();
    }

    public Action Set479ETo0_1000_9901_019901(int gotoAddress) {
        // Called in intro when skipping scenes and in the book when clicking subjects or quitting.
        // Screen in intro becomes garbled when setting something else than 0.
        globalsOnDs.Set1138_479E_Word16(0);
        return NearRet();
    }

    public Action SetBackBufferAsActiveFrameBuffer_1000_C085_01C085(int gotoAddress) {
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
    public Action SetFontToIntro_1000_D068_01D068(int gotoAddress) {
        globalsOnDs.Set1138_2518_Word16_FontRelated(0xD096);
        globalsOnDs.Set1138_47A0_Word16_FontRelated(0xCEEC);
        return NearRet();
    }

    // menu fonts related
    public Action SetFontToMenu_1000_D075_01D075(int gotoAddress) {
        globalsOnDs.Set1138_2518_Word16_FontRelated(0xD12F);
        globalsOnDs.Set1138_47A0_Word16_FontRelated(0xCF6C);
        return NearRet();
    }

    public Action SetTextBufferAsActiveFrameBuffer_1000_C08E_01C08E(int gotoAddress) {
        ushort value = globalsOnDs.Get1138_DBD8_Word16_screenBuffer();
        return SetVideoBuffer(value, "setTextVideoBufferSegmentDBD8");
    }

    public Action SetFrontBufferAsActiveFrameBuffer_1000_C07C_01C07C(int gotoAddress) {
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