namespace Cryogenic.Vgadriver;

using Cryogenic.Globals;

using Serilog;

using Spice86.Emulator.Devices.Video;
using Spice86.Emulator.Errors;
using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;
using Spice86.Utils;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class VgaDriverCode : CSharpOverrideHelper {
    private const ushort IMAGE_UNDER_MOUSE_CURSOR_START = 0xFA00;
    private const string MEMCPY_DS_TO_ES_FOR64000 = "memcpyDSToESFor64000";
    private static readonly ILogger _logger = Log.Logger.ForContext<VgaDriverCode>();
    private ushort baseSegment;
    private ExtraGlobalsOnCsSegment0x2538 globals;

    public VgaDriverCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, int programStartSegment, Machine machine) : base(functionInformations, "vgaDriver", machine) {
        baseSegment = (ushort)(programStartSegment + 0x234B);
        globals = new ExtraGlobalsOnCsSegment0x2538(machine);
        DefineFunction(baseSegment, 0x100, "setMode");
        DefineFunction(baseSegment, 0x103, "getInfoInAxCxBp", GetInfoInAxCxBp_2538_103_25483);
        DefineFunction(baseSegment, 0x109, "drawMouseCursor");
        DefineFunction(baseSegment, 0x10C, "restoreImageUnderMouseCursor", RestoreImageUnderMouseCursor_2538_10C_2548C);
        DefineFunction(baseSegment, 0x10F, "blit");
        DefineFunction(baseSegment, 0x118, "fillWithZeroFor64000AtES", FillWithZeroFor64000AtES_2538_118_25498);
        DefineFunction(baseSegment, 0x121, MEMCPY_DS_TO_ES_FOR64000, MemcpyDSToESFor64000_2538_121_254A1);
        DefineFunction(baseSegment, 0x124, "copyRectangle");
        DefineFunction(baseSegment, 0x12A, "copySquareOfPixelsSiIsSourceSegment", CopySquareOfPixelsSiIsSourceSegment_2538_12A_254AA);
        DefineFunction(baseSegment, 0x12D, MEMCPY_DS_TO_ES_FOR64000, MemcpyDSToESFor64000_2538_12D_254AD);
        DefineFunction(baseSegment, 0x130, "copySquareOfPixels", CopySquareOfPixels_2538_130_254B0);
        DefineFunction(baseSegment, 0x133, "copyframebufferExplodeAndCenter");
        DefineFunction(baseSegment, 0x13C, "noOp", NoOp_2538_13C_254BC);
        DefineFunction(baseSegment, 0x13F, "setPixel");
        DefineFunction(baseSegment, 0x163, "updateVgaOffset01A3FromLineNumberAsAx", UpdateVgaOffset01A3FromLineNumberAsAx_2538_163_254E3);
        DefineFunction(baseSegment, 0x16C, "generateTextureOutBP", GenerateTextureOutBP_2538_16C_254EC);
        DefineFunction(baseSegment, 0x17B, "copyPalette2toPalette1");
        DefineFunction(baseSegment, 0x9B8, "waitForRetrace", WaitForRetrace_2538_9B8_25D38);
        DefineFunction(baseSegment, 0xA21, "setBxCxPaletteRelated", SetBxCxPaletteRelated_2538_A21_25DA1);
        DefineFunction(baseSegment, 0xA58, "copyCsRamB5FToB2F", CopyCsRamB5FToB2F_2538_A58_25DD8);
        DefineFunction(baseSegment, 0xB68, "loadPalette", LoadPaletteInVgaDac_2538_B68_25EE8);
        DefineFunction(baseSegment, 0xC10, "setDiFromXYCordsDxBx", SetDiFromXYCordsDxBx_2538_C10_25F90);
        DefineFunction(baseSegment, 0x1B7C, MEMCPY_DS_TO_ES_FOR64000, MemcpyDSToESFor64000_2538_1B7C_26EFC);
        DefineFunction(baseSegment, 0x1B8E, "moveSquareOfPixels", MoveSquareOfPixels_2538_1B8E_26F0E);

        // called in globe, without it globe rotation works but stutters when clicking
        DefineFunction(baseSegment, 0x1D07, "unknownGlobeRelated");
        DefineFunction(baseSegment, 0x1D5A, "unknownGlobeInitRelated", UnknownGlobeInitRelated_2538_1D5A_270DA);
        DefineFunction(baseSegment, 0x2025, "unknownMapRelated");
        DefineFunction(baseSegment, 0x2343, "copyMapBlock", CopyMapBlock_2538_2343_276C3);
        DefineFunction(baseSegment, 0x253D, "retraceRelatedCalledOnEnterGlobe", RetraceRelatedCalledOnEnterGlobe_2538_253D_278BD);
        DefineFunction(baseSegment, 0x2572, "waitForRetraceInTransitions", WaitForRetraceInTransitions_2538_2572_278F2);
        DefineFunction(baseSegment, 0x261D, "waitForRetraceDuringIntroVideo", WaitForRetraceDuringIntroVideo_2538_261D_2799D);
        DefineFunction(baseSegment, 0x32C1, "generateMenuTransitionFrame");
    }

    public Action CopyCsRamB5FToB2F_2538_A58_25DD8() {
        _logger.Debug("copyCsRamB5FToB2F");

        // No jump
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(_state.CS, 0x5BF);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(_state.CS, 0x2BF);

        // 768 times (3 blocks of 256)
        _memory.MemCopy(sourceAddress, destinationAddress, 768);
        return NearRet();
    }

    public Action CopyMapBlock_2538_2343_276C3() {
        // 37 lines in ghidra
        ushort blockSize = _state.CX;
        uint baseSourceAddress = MemoryUtils.ToPhysicalAddress(_state.DS, _state.SI);
        uint baseDestinationAddress = MemoryUtils.ToPhysicalAddress(_state.ES, _state.DI);
        _logger.Debug("unknownMapCopyMapBlock blockSize={@BlockSize}, baseSourceAddress:{@BaseSourceAddress},baseDestinationAddress:{@BaseDestinationAddress}", blockSize, baseSourceAddress, baseDestinationAddress);
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < blockSize; j++) {
                byte value = _memory.GetUint8((uint)(baseSourceAddress + j + 400 * i));
                value = (byte)(((value >> 4) & 0xF) + 0x10);
                _memory.SetUint8((uint)(baseDestinationAddress + j + 320 * i), value);
            }
        }

        // point to next block
        _state.SI = ((ushort)(_state.SI + 4 * 400));
        _state.DI = ((ushort)(_state.DI + 4 * 320));
        return NearRet();
    }

    public Action CopySquareOfPixels_2538_130_254B0() {
        // 26F0E
        return MoveSquareOfPixels_2538_1B8E_26F0E();
    }

    public Action CopySquareOfPixelsSiIsSourceSegment_2538_12A_254AA() {
        // 26F0C
        _state.DS = (_state.SI);
        return MoveSquareOfPixels_2538_1B8E_26F0E();
    }

    public Action FillWithZeroFor64000AtES_2538_118_25498() {
        // 26D77
        uint address = MemoryUtils.ToPhysicalAddress(_state.ES, 0);
        _logger.Debug("fillWithZeroFor64000AtES address:{@Address}", address);
        _memory.Memset(address, 0, 64000);
        return FarRet();
    }

    // when disabled floors disappear in some rooms.
    public Action GenerateTextureOutBP_2538_16C_254EC() {
        // 28D69, 30 lines in ghidra
        uint destinationBaseAddress = MemoryUtils.ToPhysicalAddress(_state.ES, 0);
        ushort initialColor = _state.AX;
        ushort colorIncrement = _state.DI;
        ushort xorNoise = _state.BP;
        ushort xorNoisePattern = _state.SI;
        ushort length = _state.CX;
        SetDiFromXYCordsDxBx_2538_C10_25F90();
        ushort destinationOffsetAddress = _state.DI;
        int direction = _state.DirectionFlag ? -1 : 1;
        if (_logger.IsEnabled(Serilog.Events.LogEventLevel.Debug)) {
            _logger.Debug("generateFloors xy:{@X},{@Y} destinationBaseAddress:{@DestinationBaseAddress},destinationOffsetAddress:{@DestinationOffsetAddress}," + "colorIncrement:{@ColorIncrement},initialColor:{@InitialColor},xorNoise:{@XorNoise},xorNoisePattern:{@XorNoisePattern},length:{@Length},direction:{@Direction}", _state.DX, _state.BX, destinationBaseAddress, destinationOffsetAddress, colorIncrement, initialColor, xorNoise, xorNoisePattern, length, direction);
        }

        uint destinationAddress = destinationBaseAddress + destinationOffsetAddress;
        for (int i = 0; i < length; i++) {
            bool shouldXor = (xorNoise & 1) == 1;
            xorNoise >>= 1;
            if (shouldXor) {
                xorNoise ^= xorNoisePattern;
            }

            byte valueToStore = (byte)(ConvertUtils.Uint8((byte)((xorNoise & 0x3) - 1)) + ConvertUtils.Uint8((byte)(initialColor >> 8)));
            _memory.SetUint8((uint)(destinationAddress + i * direction), valueToStore);
            initialColor += colorIncrement;
        }

        // Needed for next calls
        _state.BP = (xorNoise);
        return FarRet();
    }

    public ushort GetBaseSegment() {
        return baseSegment;
    }

    public Action GetInfoInAxCxBp_2538_103_25483() {
        // 25D59
        _logger.Debug("getInfoInAxCxBp");
        _state.AX = (MemoryMap.GraphicVideoMemorySegment);
        _state.CX = (IMAGE_UNDER_MOUSE_CURSOR_START);
        _state.BP = (0);
        return FarRet();
    }

    public Action LoadPaletteInVgaDac_2538_B68_25EE8() {
        // No jump, 49 lines in ghidra
        try {
            VgaCard vgaCard = _machine.VgaCard;
            uint baseAddress = MemoryUtils.ToPhysicalAddress(_state.ES, _state.DX);
            byte writeIndex = _state.BL;
            ushort numberOfColors = _state.CX;
            byte loadMode = globals.Get2538_01BD_Byte8_PaletteLoadMode();
            _logger.Debug("loadPaletteInVgaDac, baseAddress:{@BaseAddress}, writeIndex:{@Writeindex}, loadMode:{@LoadMode}, numberOfColors:{@NumberOfColors}", baseAddress, writeIndex, loadMode, numberOfColors);
            vgaCard.SetVgaWriteIndex(writeIndex);
            if (loadMode == 0) {
                for (ushort i = 0; i < numberOfColors * 3; i++) {
                    byte value = _memory.GetUint8(baseAddress + i);
                    vgaCard.RgbDataWrite(value);
                }
            } else {
                // Untested ... 25f29 in ghidra, 2538:BA9 in dosbox, probably wrong
                FailAsUntested("This palette code path was converted to java but never executed...");
                for (ushort i = 0; i < numberOfColors * 3; i += 3) {
                    byte r = (byte)(_memory.GetUint8(baseAddress + i) & 0x3F);
                    byte g = (byte)(_memory.GetUint8(baseAddress + i + 1) & 0x3F);
                    byte b = (byte)(_memory.GetUint8(baseAddress + i + 2) & 0x3F);
                    byte value = (byte)((r * 5 + g * 9 + b * 2) >> 4);
                    vgaCard.RgbDataWrite(value);
                    vgaCard.RgbDataWrite(value);
                    vgaCard.RgbDataWrite(value);
                }
            }

            return NearRet();
        } catch (InvalidColorIndexException e) {
            throw new UnrecoverableException(e.Message);
        }
    }

    public Action MemcpyDSToESFor64000_2538_121_254A1() {
        return MemcpyDSToESFor64000_2538_1B7C_26EFC();
    }

    public Action MemcpyDSToESFor64000_2538_12D_254AD() {
        // 26EFC, seems used when moving rooms
        return MemcpyDSToESFor64000_2538_1B7C_26EFC();
    }

    public Action MemcpyDSToESFor64000_2538_1B7C_26EFC() {
        // No jump, 22 lines in ghidra
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(_state.DS, 0);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(_state.ES, 0);
        _logger.Debug("memcpyDSToESFor64000 sourceAddress:{@SourceAddress},destinationAddress:{@DestinationAddress}", sourceAddress, destinationAddress);
        _memory.MemCopy(sourceAddress, destinationAddress, 64000);
        return FarRet();
    }

    public Action MoveSquareOfPixels_2538_1B8E_26F0E() {
        // No jump, 30 instructions 67 lines in ghidra
        // warning: we dont set registers at the end but no idea if their values are used or not.
        SetDiFromXYCordsDxBx_2538_C10_25F90();
        ushort baseOffsetDi = _state.DI;
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(_state.DS, baseOffsetDi);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(_state.ES, baseOffsetDi);
        ushort rowCount = _state.BP;
        ushort columnCount = _state.AX;
        _logger.Debug("moveSquareOfPixels sourceBuffer:{@SourceBuffer}, destinationBuffer:{@DestinationBuffer},startX:{@StartX},startY:{@StartY},columnCount:{@ColumnCount},rowCount:{@RowCount}", _state.DS, _state.ES, _state.DX, _state.BX, columnCount, rowCount);
        for (ushort y = 0; y < columnCount; y++) {
            for (ushort x = 0; x < rowCount; x++) {
                byte value = _memory.GetUint8((uint)(sourceAddress + y * 320 + x));
                _memory.SetUint8((uint)(destinationAddress + y * 320 + x), value);
            }
        }

        return FarRet();
    }

    public Action NoOp_2538_13C_254BC() {
        return FarRet();
    }

    /// <summary>
    /// Restores image under mouse cursor. No input apart from globals and no output.
    /// </summary>
    public Action RestoreImageUnderMouseCursor_2538_10C_2548C() {
        // 26CC0
        ushort mouseCursorAddressInVram = this.globals.Get2538_018A_Word16_MouseCursorAddressInVram();
        ushort columns = this.globals.Get2538_018C_Word16_ColumnsOfMouseCursorCount();
        ushort lines = this.globals.Get2538_018E_Word16_LinesOfMouseCursorCount();
        _logger.Debug("restoreImageUnderMouseCursor mouseCursorAddressInVram:{@MouseCursorAddressInVram},columns:{@Columns},lines:{@Lines}", mouseCursorAddressInVram, columns, lines);
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(MemoryMap.GraphicVideoMemorySegment, IMAGE_UNDER_MOUSE_CURSOR_START);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(MemoryMap.GraphicVideoMemorySegment, mouseCursorAddressInVram);
        for (ushort i = 0; i < lines; i++) {
            _memory.MemCopy((uint)(sourceAddress + columns * i), (uint)(destinationAddress + 320 * i), columns);
        }

        return FarRet();
    }

    public Action RetraceRelatedCalledOnEnterGlobe_2538_253D_278BD() {
        return NearRet();
    }

    public Action SetBxCxPaletteRelated_2538_A21_25DA1() {
        // No jump
        _state.BX = ((ushort)(_state.BX / 3));
        ushort unknownValue = _state.CX;
        if (unknownValue < 0x300) {
            _state.CX = ((ushort)(unknownValue / 3));
            return NearRet();
        }

        // crashes when executed, but never reached...
        _state.CX = (0x100);
        return NearRet();
    }

    public Action Unknown_2538_109_25489_notyet() {
        // 26C08, 80 lines in ghidra
        return FarRet();
    }

    public Action Unknown_2538_10F_2548F() {
        // 262DB, 600 lines in ghidra
        return FarRet();
    }

    public Action Unknown_2538_112_25492() {
        // 267D2, 1200 lines in ghidra
        return FarRet();
    }

    public Action Unknown_2538_115_25495() {
        // 26F75, 88 lines in ghidra
        return FarRet();
    }

    public Action Unknown_2538_11B_2549B() {
        // 26CF9, 70 lines in ghidra, calls unknown_2538_11E_2549E with AX=0
        return FarRet();
    }

    public Action Unknown_2538_11E_2549E() {
        // 26CFB, 70 lines in ghidra
        return FarRet();
    }

    public Action Unknown_2538_148_254C8() {
        // 27087, 117 lines in ghidra
        return FarRet();
    }

    public Action Unknown_2538_14B_254CB() {
        // 54 lines in ghidra, calls out
        return FarRet();
    }

    public Action Unknown_2538_169_254E9() {
        // 26105, 70 lines in ghidra
        return FarRet();
    }

    public Action Unknown_2538_1ADC_26E5C() {
        _logger.Debug("unknown");

        // No jump, 125 lines in ghidra
        return NearRet();
    }

    public Action UnknownGlobeInitRelated_2538_1D5A_270DA() {
        // no jump
        globals.Set2538_1CA6_Word16_UnknownGlobeRelated(_state.DI);
        globals.Set2538_1EA6_Word16_UnknownGlobeRelated(0xFEDD);
        globals.Set2538_1F29_Word16_UnknownGlobeRelated(0xFE5A);
        globals.Set2538_1CAE_Word16_UnknownGlobeRelated(0x6360 - 1);
        globals.Set2538_1CB0_Word16_UnknownGlobeRelated(0x6360);
        globals.Set2538_1CB2_Word16_UnknownGlobeRelated(0x6360);
        _state.DS = (_state.SS);
        _state.CarryFlag = true;
        return FarRet();
    }

    // line number in AX, offset address in 01A3
    public Action UpdateVgaOffset01A3FromLineNumberAsAx_2538_163_254E3() {
        // 25F86
        ushort lineNumber = _state.AX;
        this.globals.Set2538_01A3_Word16_VgaOffset((ushort)(lineNumber * 320));
        _logger.Debug("updateVgaOffset01A3FromLineNumberAsAx lineNumber:{@LineNumber},vgaOffset01A3:{@VgaOffset01A3}", lineNumber, globals.Get2538_01A3_Word16_VgaOffset());
        return FarRet();
    }

    public Action WaitForRetrace_2538_9B8_25D38() {
        // no jump, 28 lines in ghidra, part of the function is not executed in the logs and DX is always 3DA.
        // Wait for retrace.
        VgaCard vgaCard = _machine.VgaCard;
        while (!vgaCard.TickRetrace())
            ;
        _state.CarryFlag = true;
        return NearRet();
    }

    public Action WaitForRetraceDuringIntroVideo_2538_261D_2799D() {
        // Calls 0x2538_2572_278F2 when 01A1 is not 0 which we dont need
        return NearRet();
    }

    public Action WaitForRetraceInTransitions_2538_2572_278F2() {
        // Calls part of 0x2538_253D_278BD which we dont need
        return NearRet();
    }

    private Action SetDiFromXYCordsDxBx_2538_C10_25F90() {
        ushort x = _state.DX;
        ushort y = _state.BX;
        int offset = globals.Get2538_01A3_Word16_VgaOffset();
        if (y >= 200) {
            y = 199;
        }

        ushort res = (ushort)(320 * y + x + offset);
        _state.DI = (res);
        _logger.Debug("setDiFromXYCordsDxBx x:{@X},y:{@Y},offset:{@Offset},res:{@Res}", x, y, offset, res);
        return NearRet();
    }
}