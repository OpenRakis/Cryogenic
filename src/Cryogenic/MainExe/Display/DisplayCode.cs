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
    private VgaDriverCode vgaDriver;
    private ExtraGlobalsOnDs globals;
    public DisplayCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine, VgaDriverCode vgaDriver) : base(functionInformations, "display", machine) {
        this.vgaDriver = vgaDriver;
        globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0x0579, "clearVgaOffset01A3F/clear_global_y_offset_ida", ClearVgaOffset01A3F_1ED_579_2449);
        DefineFunction(segment, 0x98F5, "clearUnknownValuesAndAX", ClearUnknownValuesAndAX_1ED_98F5_B7C5);
        DefineFunction(segment, 0x9901, "set479ETo0", Set479ETo0_1ED_9901_B7D1);
        DefineFunction(segment, 0xC07C, "setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida", SetVideoBufferSegmentDBD6_1ED_C07C_DF4C);
        DefineFunction(segment, 0xC085, "setDialogueVideoBufferSegmentDC32/set_backbuffer_as_frame_buffer_ida", SetDialogueVideoBufferSegmentDC32_1ED_C085_DF55);
        DefineFunction(segment, 0xC08E, "setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida", SetTextVideoBufferSegmentDBD8_1ED_C08E_DF5E);
        DefineFunction(segment, 0xC0AD, "clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida", ClearCurrentVideoBuffer_1ED_C0AD_DF7D);
        DefineFunction(segment, 0xD05F, "getCharacterCoordsXY", GetCharacterCoordsXY_1ED_D05F_EF2F);
        DefineFunction(segment, 0xD068, "setFontToIntro", SetFontToIntro_1ED_D068_EF38);
        DefineFunction(segment, 0xD075, "setFontToMenu", SetFontToMenu_1ED_D075_EF45);
        DefineFunction(segment, 0xD082, "setFontToBook", SetFontToBook_1ED_D082_EF52);
        DefineFunction(segment, 0xE270, "pushAll", PushAll_1ED_E270_10140);
        DefineFunction(segment, 0xE283, "popAll", PopAll_1ED_E283_10153);
    }

    // sets the gfx offset to 0
    public Action ClearVgaOffset01A3F_1ED_579_2449() {
        _logger.Debug("Clearing VGA offset");
        CheckVtableContainsExpected(SegmentRegisters.DsIndex, 0x3939, vgaDriver.GetBaseSegment(), 0x163);
        _state.SetAX(0);
        vgaDriver.UpdateVgaOffset01A3FromLineNumberAsAx_2538_163_254E3();
        return NearRet();
    }

    public Action ClearUnknownValuesAndAX_1ED_98F5_B7C5() {

        // Called after screen change (video, room, dialogue, map ...).
        // When set to 255, cannot enter orni and enter palace instead
        _logger.Debug("Before: 1C06:{@1C06}, 1BF8:{@1BF8}, 1BEA:{@1BEA}", globals.Get1138_1C06_Word16(), globals.Get1138_1BF8_Word16(), globals.Get1138_1BEA_Word16());
        globals.Set1138_1C06_Word16(0);

        // 128 after end of dialogue if character is in the room
        globals.Set1138_1BF8_Word16(0);

        // 128 after end of dialogue
        globals.Set1138_1BEA_Word16(0);

        // If not done, book videos will show a character on screen instead
        _state.SetAX(0);
        return NearRet();
    }

    public Action Set479ETo0_1ED_9901_B7D1() {

        // Called in intro when skipping scenes and in the book when clicking subjects or quitting.
        // Screen in intro becomes garbled when setting something else than 0.
        globals.Set1138_479E_Word16(0);
        return NearRet();
    }

    public Action SetVideoBufferSegmentDBD6_1ED_C07C_DF4C() {
        ushort value = globals.Get1138_DBD6_Word16_framebufferFront();
        return SetVideoBuffer(value, "setVideoBufferSegmentDBD6");
    }

    public Action SetDialogueVideoBufferSegmentDC32_1ED_C085_DF55() {
        ushort value = globals.Get1138_DC32_Word16_framebufferBack();
        return SetVideoBuffer(value, "setDialogueVideoBufferSegmentDC32");
    }

    public Action SetTextVideoBufferSegmentDBD8_1ED_C08E_DF5E() {
        ushort value = globals.Get1138_DBD8_Word16_screenBuffer();
        return SetVideoBuffer(value, "setTextVideoBufferSegmentDBD8");
    }

    private Action SetVideoBuffer(ushort value, string functionName) {
        ushort oldValue = globals.Get1138_DBDA_Word16_framebufferActive();
        if (value != oldValue) {
            globals.Set1138_DBDA_Word16_framebufferActive(value);
            _logger.Debug("{@FunctionName} value:{@Value}, oldValue:{@OldValue}", functionName, value, oldValue);
        }

        return NearRet();
    }

    public Action ClearCurrentVideoBuffer_1ED_C0AD_DF7D() {
        _state.SetES((byte)globals.Get1138_DBDA_Word16_framebufferActive());
        vgaDriver.FillWithZeroFor64000AtES_2538_118_25498();
        return NearRet();
    }

    public Action GetCharacterCoordsXY_1ED_D05F_EF2F() {
        ushort x = globals.Get1138_D82C_Word16_CharacterXCoord();
        ushort y = globals.Get1138_D82E_Word16_CharacterYCoord();
        _state.SetDX(x);
        _state.SetBX(y);
        _logger.Debug("getCharacterCoordsXY x:{@X} y:{@Y}", _state.GetDX(), _state.GetBX());
        return NearRet();
    }

    // intro and map fonts
    public Action SetFontToIntro_1ED_D068_EF38() {
        globals.Set1138_2518_Word16_FontRelated(0xD096);
        globals.Set1138_47A0_Word16_FontRelated(0xCEEC);
        return NearRet();
    }

    // menu fonts related
    public Action SetFontToMenu_1ED_D075_EF45() {
        globals.Set1138_2518_Word16_FontRelated(0xD12F);
        globals.Set1138_47A0_Word16_FontRelated(0xCF6C);
        return NearRet();
    }

    // book fonts related
    public Action SetFontToBook_1ED_D082_EF52() {
        globals.Set1138_2518_Word16_FontRelated(0xD0FF);
        globals.Set1138_47A0_Word16_FontRelated(0xCEEC);
        return NearRet();
    }

    public Action PushAll_1ED_E270_10140() {
        _logger.Debug("pushAll");
        _stack.Push(_state.GetBX());
        _stack.Push(_state.GetCX());
        _stack.Push(_state.GetDX());
        _stack.Push(_state.GetSI());
        _stack.Push(_state.GetDI());
        _stack.Push(_state.GetBP());
        ushort stackTop = _stack.Peek(0);

        // XCHG AX <-> Stack[0x0C]
        ushort stackPeek = _stack.Peek(0x0C);
        _stack.Poke(0x0C, _state.GetAX());

        // In the original assembly code, AX seems modified but it's not the case as it's restored to its original value
        // later.
        _stack.Push(stackPeek);
        _state.SetBP(stackTop);
        return NearRet();
    }

    public Action PopAll_1ED_E283_10153() {
        _logger.Debug("popAll");

        // Called in most changes related to display like scene change, displaying map, clicking on map, clicking on
        // characters ...
        // XCHG AX <-> Stack[0x0C] (or 0x0E if done before the pop)
        ushort ax = _stack.Pop();
        ushort stackPeek = _stack.Peek(0x0C);
        _stack.Poke(0x0C, ax);
        _state.SetAX(stackPeek);

        // Regular pops
        _state.SetBP(_stack.Pop());
        _state.SetDI(_stack.Pop());
        _state.SetSI(_stack.Pop());
        _state.SetDX(_stack.Pop());
        _state.SetCX(_stack.Pop());
        _state.SetBX(_stack.Pop());
        return NearRet();
    }
}
