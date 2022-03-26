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
    private static readonly ILogger _logger = Log.Logger.ForContext<VgaDriverCode>();
    private ushort baseSegment;
    private ExtraGlobalsOnCsSegment0x2538 globals;

    public VgaDriverCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, int programStartSegment, Machine machine) : base(functionInformations, "vgaDriver", machine) {
        baseSegment = (ushort)(programStartSegment + 0x234B);
        globals = new ExtraGlobalsOnCsSegment0x2538(machine, baseSegment);
        DefineFunction(baseSegment, 0x100, "VgaFunc00SetMode");
        DefineFunction(baseSegment, 0x103, VgaFunc01GetInfoInAxCxBp_2538_103_25483);
        DefineFunction(baseSegment, 0x109, "VgaFunc03DrawMouseCursor");
        DefineFunction(baseSegment, 0x10C, VgaFunc04RestoreImageUnderMouseCursor_2538_10C_2548C);
        DefineFunction(baseSegment, 0x10F, "VgaFunc05Blit");
        DefineFunction(baseSegment, 0x118, VgaFunc08FillWithZeroFor64000AtES_2538_118_25498);
        DefineFunction(baseSegment, 0x121, VgaFunc11MemcpyDSToESFor64000_2538_121_254A1);
        DefineFunction(baseSegment, 0x124, "VgaFunc12CopyRectangle");
        DefineFunction(baseSegment, 0x12A, VgaFunc14CopySquareOfPixelsSiIsSourceSegment_2538_12A_254AA);
        DefineFunction(baseSegment, 0x12D, VgaFunc15MemcpyDSToESFor64000_2538_12D_254AD);
        DefineFunction(baseSegment, 0x130, VgaFunc16CopySquareOfPixels_2538_130_254B0);
        DefineFunction(baseSegment, 0x133, "VgaFunc17CopyframebufferExplodeAndCenter");
        DefineFunction(baseSegment, 0x13C, VgaFunc20NoOp_2538_13C_254BC);
        DefineFunction(baseSegment, 0x13F, "VgaFunc21SetPixel");
        DefineFunction(baseSegment, 0x163, VgaFunc33UpdateVgaOffset01A3FromLineNumberAsAx_2538_163_254E3);
        DefineFunction(baseSegment, 0x16C, VgaFunc36GenerateTextureOutBP_2538_16C_254EC);
        DefineFunction(baseSegment, 0x17B, "VgaFunc41CopyPalette2toPalette1");
        DefineFunction(baseSegment, 0x9B8, WaitForRetrace_2538_9B8_25D38);
        DefineFunction(baseSegment, 0xA21, SetBxCxPaletteRelated_2538_A21_25DA1);
        DefineFunction(baseSegment, 0xA58, CopyCsRamB5FToB2F_2538_A58_25DD8);
        DefineFunction(baseSegment, 0xB68, LoadPaletteInVgaDac_2538_B68_25EE8);
        DefineFunction(baseSegment, 0xC10, SetDiFromXYCordsDxBx_2538_C10_25F90);
        DefineFunction(baseSegment, 0x1B7C, MemcpyDSToESFor64000_2538_1B7C_26EFC);
        DefineFunction(baseSegment, 0x1B8E, CopySquareOfPixels_2538_1B8E_26F0E);

        // called in globe, without it globe rotation works but stutters when clicking
        DefineFunction(baseSegment, 0x1D07, "UnknownGlobeRelated");
        DefineFunction(baseSegment, 0x1D5A, UnknownGlobeInitRelated_2538_1D5A_270DA);
        DefineFunction(baseSegment, 0x2025, "UnknownMapRelated");
        DefineFunction(baseSegment, 0x2343, CopyMapBlock_2538_2343_276C3);
        DefineFunction(baseSegment, 0x253D, RetraceRelatedCalledOnEnterGlobe_2538_253D_278BD);
        DefineFunction(baseSegment, 0x2572, WaitForRetraceInTransitions_2538_2572_278F2);
        DefineFunction(baseSegment, 0x261D, WaitForRetraceDuringIntroVideo_2538_261D_2799D);
        DefineFunction(baseSegment, 0x32C1, "GenerateMenuTransitionFrame");
    }

    public Action CopyCsRamB5FToB2F_2538_A58_25DD8(int gotoAddress) {
        _logger.Debug("CopyCsRamB5FToB2F");

        // No jump
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(State.CS, 0x5BF);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(State.CS, 0x2BF);

        // 768 times (3 blocks of 256)
        Memory.MemCopy(sourceAddress, destinationAddress, 768);
        return NearRet();
    }

    public Action CopyMapBlock_2538_2343_276C3(int gotoAddress) {
        // 37 lines in ghidra
        ushort blockSize = State.CX;
        uint baseSourceAddress = MemoryUtils.ToPhysicalAddress(State.DS, State.SI);
        uint baseDestinationAddress = MemoryUtils.ToPhysicalAddress(State.ES, State.DI);
        _logger.Debug("unknownMapCopyMapBlock blockSize={@BlockSize}, baseSourceAddress:{@BaseSourceAddress},baseDestinationAddress:{@BaseDestinationAddress}", blockSize, baseSourceAddress, baseDestinationAddress);
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < blockSize; j++) {
                byte value = Memory.GetUint8((uint)(baseSourceAddress + j + 400 * i));
                value = (byte)(((value >> 4) & 0xF) + 0x10);
                Memory.SetUint8((uint)(baseDestinationAddress + j + 320 * i), value);
            }
        }

        // point to next block
        State.SI = ((ushort)(State.SI + 4 * 400));
        State.DI = ((ushort)(State.DI + 4 * 320));
        return NearRet();
    }

    public Action VgaFunc16CopySquareOfPixels_2538_130_254B0(int gotoAddress) {
        // 26F0E
        return CopySquareOfPixels_2538_1B8E_26F0E(0);
    }

    public Action VgaFunc14CopySquareOfPixelsSiIsSourceSegment_2538_12A_254AA(int gotoAddress) {
        // 26F0C
        State.DS = (State.SI);
        return CopySquareOfPixels_2538_1B8E_26F0E(0);
    }

    public Action VgaFunc08FillWithZeroFor64000AtES_2538_118_25498(int gotoAddress) {
        // 26D77
        uint address = MemoryUtils.ToPhysicalAddress(State.ES, 0);
        _logger.Debug("fillWithZeroFor64000AtES address:{@Address}", address);
        Memory.Memset(address, 0, 64000);
        return FarRet();
    }

    // when disabled floors disappear in some rooms.
    public Action VgaFunc36GenerateTextureOutBP_2538_16C_254EC(int gotoAddress) {
        // 28D69, 30 lines in ghidra
        uint destinationBaseAddress = MemoryUtils.ToPhysicalAddress(State.ES, 0);
        ushort initialColor = State.AX;
        ushort colorIncrement = State.DI;
        ushort xorNoise = State.BP;
        ushort xorNoisePattern = State.SI;
        ushort length = State.CX;
        SetDiFromXYCordsDxBx_2538_C10_25F90(0);
        ushort destinationOffsetAddress = State.DI;
        int direction = State.DirectionFlag ? -1 : 1;
        if (_logger.IsEnabled(Serilog.Events.LogEventLevel.Debug)) {
            _logger.Debug("generateFloors xy:{@X},{@Y} destinationBaseAddress:{@DestinationBaseAddress},destinationOffsetAddress:{@DestinationOffsetAddress}," + "colorIncrement:{@ColorIncrement},initialColor:{@InitialColor},xorNoise:{@XorNoise},xorNoisePattern:{@XorNoisePattern},length:{@Length},direction:{@Direction}", State.DX, State.BX, destinationBaseAddress,
                destinationOffsetAddress, colorIncrement, initialColor, xorNoise, xorNoisePattern, length, direction);
        }

        uint destinationAddress = destinationBaseAddress + destinationOffsetAddress;
        for (int i = 0; i < length; i++) {
            bool shouldXor = (xorNoise & 1) == 1;
            xorNoise >>= 1;
            if (shouldXor) {
                xorNoise ^= xorNoisePattern;
            }

            byte valueToStore = (byte)(ConvertUtils.Uint8((byte)((xorNoise & 0x3) - 1)) + ConvertUtils.Uint8((byte)(initialColor >> 8)));
            Memory.SetUint8((uint)(destinationAddress + i * direction), valueToStore);
            initialColor += colorIncrement;
        }

        // Needed for next calls
        State.BP = (xorNoise);
        return FarRet();
    }

    public ushort GetBaseSegment() {
        return baseSegment;
    }

    public Action VgaFunc01GetInfoInAxCxBp_2538_103_25483(int gotoAddress) {
        // 25D59
        _logger.Debug("getInfoInAxCxBp");
        State.AX = (MemoryMap.GraphicVideoMemorySegment);
        State.CX = (IMAGE_UNDER_MOUSE_CURSOR_START);
        State.BP = (0);
        return FarRet();
    }

    public Action LoadPaletteInVgaDac_2538_B68_25EE8(int gotoAddress) {
        // No jump, 49 lines in ghidra
        try {
            VgaCard vgaCard = Machine.VgaCard;
            uint baseAddress = MemoryUtils.ToPhysicalAddress(State.ES, State.DX);
            byte writeIndex = State.BL;
            ushort numberOfColors = State.CX;
            byte loadMode = globals.Get2538_01BD_Byte8_PaletteLoadMode();
            _logger.Debug("loadPaletteInVgaDac, baseAddress:{@BaseAddress}, writeIndex:{@Writeindex}, loadMode:{@LoadMode}, numberOfColors:{@NumberOfColors}", baseAddress, writeIndex, loadMode, numberOfColors);
            vgaCard.SetVgaWriteIndex(writeIndex);
            if (loadMode == 0) {
                for (uint i = 0; i < numberOfColors * 3; i++) {
                    byte value = UInt8[baseAddress + i];
                    vgaCard.RgbDataWrite(value);
                }
            } else {
                // Untested ... 25f29 in ghidra, 2538:BA9 in dosbox, probably wrong
                throw FailAsUntested("This palette code path was converted to java but never executed...");
                for (ushort i = 0; i < numberOfColors * 3; i += 3) {
                    byte r = (byte)(UInt8[baseAddress + i] & 0x3F);
                    byte g = (byte)(UInt8[baseAddress + i + 1] & 0x3F);
                    byte b = (byte)(UInt8[baseAddress + i + 2] & 0x3F);
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

    public Action VgaFunc11MemcpyDSToESFor64000_2538_121_254A1(int gotoAddress) {
        return MemcpyDSToESFor64000_2538_1B7C_26EFC(0);
    }

    public Action VgaFunc15MemcpyDSToESFor64000_2538_12D_254AD(int gotoAddress) {
        // 26EFC, seems used when moving rooms
        return MemcpyDSToESFor64000_2538_1B7C_26EFC(0);
    }

    public Action MemcpyDSToESFor64000_2538_1B7C_26EFC(int gotoAddress) {
        // No jump, 22 lines in ghidra
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(State.DS, 0);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(State.ES, 0);
        _logger.Debug("memcpyDSToESFor64000 sourceAddress:{@SourceAddress},destinationAddress:{@DestinationAddress}", sourceAddress, destinationAddress);
        Memory.MemCopy(sourceAddress, destinationAddress, 64000);
        return FarRet();
    }

    public Action CopySquareOfPixels_2538_1B8E_26F0E(int gotoAddress) {
        // No jump, 30 instructions 67 lines in ghidra
        // warning: we dont set registers at the end but no idea if their values are used or not.
        SetDiFromXYCordsDxBx_2538_C10_25F90(0);
        ushort baseOffsetDi = State.DI;
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(State.DS, baseOffsetDi);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(State.ES, baseOffsetDi);
        ushort rowCount = State.BP;
        ushort columnCount = State.AX;
        _logger.Debug("moveSquareOfPixels sourceBuffer:{@SourceBuffer}, destinationBuffer:{@DestinationBuffer},startX:{@StartX},startY:{@StartY},columnCount:{@ColumnCount},rowCount:{@RowCount}", State.DS, State.ES, State.DX, State.BX, columnCount, rowCount);
        for (ushort y = 0; y < columnCount; y++) {
            for (ushort x = 0; x < rowCount; x++) {
                int disp = y * 320 + x;
                UInt8[(uint)(destinationAddress + disp)] = UInt8[(uint)(sourceAddress + disp)];
            }
        }

        return FarRet();
    }

    public Action VgaFunc20NoOp_2538_13C_254BC(int gotoAddress) {
        return FarRet();
    }

    /// <summary>
    /// Restores image under mouse cursor. No input apart from globals and no output.
    /// </summary>
    public Action VgaFunc04RestoreImageUnderMouseCursor_2538_10C_2548C(int gotoAddress) {
        // 26CC0
        ushort mouseCursorAddressInVram = this.globals.Get2538_018A_Word16_MouseCursorAddressInVram();
        ushort columns = this.globals.Get2538_018C_Word16_ColumnsOfMouseCursorCount();
        ushort lines = this.globals.Get2538_018E_Word16_LinesOfMouseCursorCount();
        _logger.Debug("restoreImageUnderMouseCursor mouseCursorAddressInVram:{@MouseCursorAddressInVram},columns:{@Columns},lines:{@Lines}", mouseCursorAddressInVram, columns, lines);
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(MemoryMap.GraphicVideoMemorySegment, IMAGE_UNDER_MOUSE_CURSOR_START);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(MemoryMap.GraphicVideoMemorySegment, mouseCursorAddressInVram);
        for (ushort i = 0; i < lines; i++) {
            Memory.MemCopy((uint)(sourceAddress + columns * i), (uint)(destinationAddress + 320 * i), columns);
        }

        return FarRet();
    }

    public Action RetraceRelatedCalledOnEnterGlobe_2538_253D_278BD(int gotoAddress) {
        return NearRet();
    }

    public Action SetBxCxPaletteRelated_2538_A21_25DA1(int gotoAddress) {
        // No jump
        State.BX = ((ushort)(State.BX / 3));
        ushort unknownValue = State.CX;
        if (unknownValue < 0x300) {
            State.CX = ((ushort)(unknownValue / 3));
            return NearRet();
        }

        // crashes when executed, but never reached...
        State.CX = (0x100);
        return NearRet();
    }

    public Action UnknownGlobeInitRelated_2538_1D5A_270DA(int gotoAddress) {
        // no jump
        globals.Set2538_1CA6_Word16_UnknownGlobeRelated(State.DI);
        globals.Set2538_1EA6_Word16_UnknownGlobeRelated(0xFEDD);
        globals.Set2538_1F29_Word16_UnknownGlobeRelated(0xFE5A);
        globals.Set2538_1CAE_Word16_UnknownGlobeRelated(0x6360 - 1);
        globals.Set2538_1CB0_Word16_UnknownGlobeRelated(0x6360);
        globals.Set2538_1CB2_Word16_UnknownGlobeRelated(0x6360);
        State.DS = (State.SS);
        State.CarryFlag = true;
        return FarRet();
    }

    // line number in AX, offset address in 01A3
    public Action VgaFunc33UpdateVgaOffset01A3FromLineNumberAsAx_2538_163_254E3(int gotoAddress) {
        // 25F86
        ushort lineNumber = State.AX;
        this.globals.Set2538_01A3_Word16_VgaOffset((ushort)(lineNumber * 320));
        _logger.Debug("updateVgaOffset01A3FromLineNumberAsAx lineNumber:{@LineNumber},vgaOffset01A3:{@VgaOffset01A3}", lineNumber, globals.Get2538_01A3_Word16_VgaOffset());
        return FarRet();
    }

    public Action WaitForRetrace_2538_9B8_25D38(int gotoAddress) {
        // no jump, 28 lines in ghidra, part of the function is not executed in the logs and DX is always 3DA.
        // Wait for retrace.
        VgaCard vgaCard = Machine.VgaCard;
        while (!vgaCard.TickRetrace())
            ;
        State.CarryFlag = true;
        return NearRet();
    }

    public Action WaitForRetraceDuringIntroVideo_2538_261D_2799D(int gotoAddress) {
        // Calls 0x2538_2572_278F2 when 01A1 is not 0 which we dont need
        return NearRet();
    }

    public Action WaitForRetraceInTransitions_2538_2572_278F2(int gotoAddress) {
        // Calls part of 0x2538_253D_278BD which we dont need
        return NearRet();
    }

    private Action SetDiFromXYCordsDxBx_2538_C10_25F90(int gotoAddress) {
        ushort x = State.DX;
        ushort y = State.BX;
        int offset = globals.Get2538_01A3_Word16_VgaOffset();
        if (y >= 200) {
            y = 199;
        }

        ushort res = (ushort)(320 * y + x + offset);
        State.DI = (res);
        _logger.Debug("setDiFromXYCordsDxBx x:{@X},y:{@Y},offset:{@Offset},res:{@Res}", x, y, offset, res);
        return NearRet();
    }
}