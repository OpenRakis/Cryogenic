namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Devices.Video;
using Spice86.Core.Emulator.Memory;
using Spice86.Shared.Emulator.Errors;
using Spice86.Shared.Utils;
using Spice86.Shared.Interfaces;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides {
    private const ushort IMAGE_UNDER_MOUSE_CURSOR_START = 0xFA00;
    
    public void DefineVgaDriverCodeOverrides() {
        DefineFunction(cs2, 0x100, "VgaFunc00SetMode");
        DefineFunction(cs2, 0x103, VgaFunc01GetInfoInAxCxBp_334B_0103_0335B3);
        DefineFunction(cs2, 0x109, "VgaFunc03DrawMouseCursor");
        DefineFunction(cs2, 0x10C, VgaFunc04RestoreImageUnderMouseCursor_334B_010C_0335BC);
        DefineFunction(cs2, 0x10F, "VgaFunc05Blit");
        DefineFunction(cs2, 0x118, VgaFunc08FillWithZeroFor64000AtES_334B_0118_0335C8);
        DefineFunction(cs2, 0x121, VgaFunc11MemcpyDSToESFor64000_334B_0121_0335D1);
        DefineFunction(cs2, 0x124, "VgaFunc12CopyRectangle");
        DefineFunction(cs2, 0x12A, VgaFunc14CopySquareOfPixelsSiIsSourceSegment_334B_012A_0335DA);
        DefineFunction(cs2, 0x12D, VgaFunc15MemcpyDSToESFor64000_334B_012D_0335DD);
        DefineFunction(cs2, 0x130, VgaFunc16CopySquareOfPixels_334B_0130_0335E0);
        DefineFunction(cs2, 0x133, "VgaFunc17CopyframebufferExplodeAndCenter");
        DefineFunction(cs2, 0x13C, VgaFunc20NoOp_334B_013C_0335EC);
        DefineFunction(cs2, 0x13F, "VgaFunc21SetPixel");
        DefineFunction(cs2, 0x163, VgaFunc33UpdateVgaOffset01A3FromLineNumberAsAx_334B_0163_033613);
        DefineFunction(cs2, 0x16C, VgaFunc36GenerateTextureOutBP_334B_016C_03361C);
        DefineFunction(cs2, 0x17B, "VgaFunc41CopyPalette2toPalette1");
        DefineFunction(cs2, 0x9B8, WaitForRetrace_334B_09B8_033E68);
        DefineFunction(cs2, 0xA21, SetBxCxPaletteRelated_334B_0A21_033ED1);
        DefineFunction(cs2, 0xA58, CopyCsRamB5FToB2F_334B_0A58_033F08);
        DefineFunction(cs2, 0xB68, LoadPaletteInVgaDac_334B_0B68_034018);
        DefineFunction(cs2, 0xC10, SetDiFromXYCordsDxBx_334B_0C10_0340C0);
        DefineFunction(cs2, 0x1B7C, MemcpyDSToESFor64000_334B_1B7C_03502C);
        DefineFunction(cs2, 0x1B8E, CopySquareOfPixels_334B_1B8E_03503E);

        // called in globe, without it globe rotation works but stutters when clicking
        DefineFunction(cs2, 0x1D07, "UnknownGlobeRelated");
        DefineFunction(cs2, 0x1D5A, UnknownGlobeInitRelated_334B_1D5A_03520A);
        DefineFunction(cs2, 0x2025, "UnknownMapRelated");
        DefineFunction(cs2, 0x2343, CopyMapBlock_334B_2343_0357F3);
        DefineFunction(cs2, 0x253D, RetraceRelatedCalledOnEnterGlobe_334B_253D_0359ED);
        DefineFunction(cs2, 0x2572, WaitForRetraceInTransitions_334B_2572_035A22);
        DefineFunction(cs2, 0x261D, WaitForRetraceDuringIntroVideo_334B_261D_035ACD);
        DefineFunction(cs2, 0x32C1, "GenerateMenuTransitionFrame");
    }

    public Action CopyCsRamB5FToB2F_334B_0A58_033F08(int gotoAddress) {
        _loggerService.Debug("CopyCsRamB5FToB2F");

        // No jump
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(CS, 0x5BF);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(CS, 0x2BF);

        // 768 times (3 blocks of 256)
        Memory.MemCopy(sourceAddress, destinationAddress, 768);
        return NearRet();
    }

    public Action CopyMapBlock_334B_2343_0357F3(int gotoAddress) {
        // 37 lines in ghidra
        ushort blockSize = CX;
        uint baseSourceAddress = MemoryUtils.ToPhysicalAddress(DS, SI);
        uint baseDestinationAddress = MemoryUtils.ToPhysicalAddress(ES, DI);
        _loggerService.Debug("unknownMapCopyMapBlock blockSize={@BlockSize}, baseSourceAddress:{@BaseSourceAddress},baseDestinationAddress:{@BaseDestinationAddress}", blockSize, baseSourceAddress, baseDestinationAddress);
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < blockSize; j++) {
                byte value = Memory.UInt8[baseSourceAddress + j + 400 * i];
                value = (byte)(((value >> 4) & 0xF) + 0x10);
                Memory.UInt8[baseDestinationAddress + j + 320 * i] = value;
            }
        }

        // point to next block
        SI = (ushort)(SI + 4 * 400);
        DI = (ushort)(DI + 4 * 320);
        return NearRet();
    }

    public Action VgaFunc16CopySquareOfPixels_334B_0130_0335E0(int gotoAddress) {
        // 26F0E
        return CopySquareOfPixels_334B_1B8E_03503E(0);
    }

    public Action VgaFunc14CopySquareOfPixelsSiIsSourceSegment_334B_012A_0335DA(int gotoAddress) {
        // 26F0C
        DS = SI;
        return CopySquareOfPixels_334B_1B8E_03503E(0);
    }

    public Action VgaFunc08FillWithZeroFor64000AtES_334B_0118_0335C8(int gotoAddress) {
        // 26D77
        uint address = MemoryUtils.ToPhysicalAddress(ES, 0);
        _loggerService.Debug("fillWithZeroFor64000AtES address:{@Address}", address);
        Memory.Memset8(address, 0, 64000);
        return FarRet();
    }

    // when disabled floors disappear in some rooms.
    public Action VgaFunc36GenerateTextureOutBP_334B_016C_03361C(int gotoAddress) {
        // 28D69, 30 lines in ghidra
        uint destinationBaseAddress = MemoryUtils.ToPhysicalAddress(ES, 0);
        ushort initialColor = AX;
        ushort colorIncrement = DI;
        ushort xorNoise = BP;
        ushort xorNoisePattern = SI;
        ushort length = CX;
        SetDiFromXYCordsDxBx_334B_0C10_0340C0(0);
        ushort destinationOffsetAddress = DI;
        int direction = DirectionFlag ? -1 : 1;
        if (_loggerService.IsEnabled(Serilog.Events.LogEventLevel.Debug)) {
            _loggerService.Debug("generateFloors xy:{@X},{@Y} destinationBaseAddress:{@DestinationBaseAddress},destinationOffsetAddress:{@DestinationOffsetAddress}," + "colorIncrement:{@ColorIncrement},initialColor:{@InitialColor},xorNoise:{@XorNoise},xorNoisePattern:{@XorNoisePattern},length:{@Length},direction:{@Direction}", DX, BX, destinationBaseAddress,
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
            Memory.UInt8[destinationAddress + i * direction] = valueToStore;
            initialColor += colorIncrement;
        }

        // Needed for next calls
        BP = xorNoise;
        return FarRet();
    }

    public ushort GetBaseSegment() {
        return cs2;
    }

    public Action VgaFunc01GetInfoInAxCxBp_334B_0103_0335B3(int gotoAddress) {
        // 25D59
        _loggerService.Debug("getInfoInAxCxBp");
        AX = MemoryMap.GraphicVideoMemorySegment;
        CX = IMAGE_UNDER_MOUSE_CURSOR_START;
        BP = 0;
        return FarRet();
    }

    public Action LoadPaletteInVgaDac_334B_0B68_034018(int gotoAddress) {
        // No jump, 49 lines in ghidra
        try {
            IVideoCard vgaCard = Machine.VgaCard;
            uint baseAddress = MemoryUtils.ToPhysicalAddress(ES, DX);
            byte writeIndex = BL;
            ushort numberOfColors = CX;
            byte loadMode = globalsOnCsSegment0X2538.Get2538_01BD_Byte8_PaletteLoadMode();
            _loggerService.Debug("loadPaletteInVgaDac, baseAddress:{@BaseAddress}, writeIndex:{@Writeindex}, loadMode:{@LoadMode}, numberOfColors:{@NumberOfColors}", baseAddress, writeIndex, loadMode, numberOfColors);
            IVideoState videoState = Machine.VgaRegisters;
            videoState.DacRegisters.IndexRegisterWriteMode = writeIndex;
            
            if (loadMode == 0) {
                for (uint i = 0; i < numberOfColors * 3; i++) {
                    byte value = UInt8[baseAddress + i];
                    videoState.DacRegisters.DataRegister = value;
                }
            } else {
                // Untested ... 25f29 in ghidra, 2538:BA9 in dosbox, probably wrong
                throw FailAsUntested("This palette code path was converted to C# but never executed...");
                for (ushort i = 0; i < numberOfColors * 3; i += 3) {
                    byte r = (byte)(UInt8[baseAddress + i] & 0x3F);
                    byte g = (byte)(UInt8[baseAddress + i + 1] & 0x3F);
                    byte b = (byte)(UInt8[baseAddress + i + 2] & 0x3F);
                    byte value = (byte)((r * 5 + g * 9 + b * 2) >> 4);
                    videoState.DacRegisters.DataRegister = value;
                    videoState.DacRegisters.DataRegister = value;
                    videoState.DacRegisters.DataRegister = value;
                }
            }

            return NearRet();
        } catch (ArgumentOutOfRangeException e) {
            throw new UnrecoverableException(e.Message);
        }
    }

    public Action VgaFunc11MemcpyDSToESFor64000_334B_0121_0335D1(int gotoAddress) {
        return MemcpyDSToESFor64000_334B_1B7C_03502C(0);
    }

    public Action VgaFunc15MemcpyDSToESFor64000_334B_012D_0335DD(int gotoAddress) {
        // 26EFC, seems used when moving rooms
        return MemcpyDSToESFor64000_334B_1B7C_03502C(0);
    }

    public Action MemcpyDSToESFor64000_334B_1B7C_03502C(int gotoAddress) {
        // No jump, 22 lines in ghidra
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(DS, 0);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(ES, 0);
        _loggerService.Debug("memcpyDSToESFor64000 sourceAddress:{@SourceAddress},destinationAddress:{@DestinationAddress}", sourceAddress, destinationAddress);
        Memory.MemCopy(sourceAddress, destinationAddress, 64000);
        return FarRet();
    }

    public Action CopySquareOfPixels_334B_1B8E_03503E(int gotoAddress) {
        // No jump, 30 instructions 67 lines in ghidra
        // warning: we dont set registers at the end but no idea if their values are used or not.
        SetDiFromXYCordsDxBx_334B_0C10_0340C0(0);
        ushort baseOffsetDi = DI;
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(DS, baseOffsetDi);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(ES, baseOffsetDi);
        ushort rowCount = BP;
        ushort columnCount = AX;
        _loggerService.Debug("moveSquareOfPixels sourceBuffer:{@SourceBuffer}, destinationBuffer:{@DestinationBuffer},startX:{@StartX},startY:{@StartY},columnCount:{@ColumnCount},rowCount:{@RowCount}", DS, ES, DX, BX, columnCount, rowCount);
        for (ushort y = 0; y < columnCount; y++) {
            for (ushort x = 0; x < rowCount; x++) {
                int disp = y * 320 + x;
                UInt8[destinationAddress + disp] = UInt8[sourceAddress + disp];
            }
        }

        return FarRet();
    }

    public Action VgaFunc20NoOp_334B_013C_0335EC(int gotoAddress) {
        return FarRet();
    }

    /// <summary>
    /// Restores image under mouse cursor. No input apart from globals and no output.
    /// </summary>
    public Action VgaFunc04RestoreImageUnderMouseCursor_334B_010C_0335BC(int gotoAddress) {
        // 26CC0
        ushort mouseCursorAddressInVram = this.globalsOnCsSegment0X2538.Get2538_018A_Word16_MouseCursorAddressInVram();
        ushort columns = this.globalsOnCsSegment0X2538.Get2538_018C_Word16_ColumnsOfMouseCursorCount();
        ushort lines = this.globalsOnCsSegment0X2538.Get2538_018E_Word16_LinesOfMouseCursorCount();
        _loggerService.Debug("restoreImageUnderMouseCursor mouseCursorAddressInVram:{@MouseCursorAddressInVram},columns:{@Columns},lines:{@Lines}", mouseCursorAddressInVram, columns, lines);
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(MemoryMap.GraphicVideoMemorySegment, IMAGE_UNDER_MOUSE_CURSOR_START);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(MemoryMap.GraphicVideoMemorySegment, mouseCursorAddressInVram);
        for (ushort i = 0; i < lines; i++) {
            Memory.MemCopy((uint)(sourceAddress + columns * i), (uint)(destinationAddress + 320 * i), columns);
        }

        return FarRet();
    }

    public Action RetraceRelatedCalledOnEnterGlobe_334B_253D_0359ED(int gotoAddress) {
        return NearRet();
    }

    public Action SetBxCxPaletteRelated_334B_0A21_033ED1(int gotoAddress) {
        // No jump
        BX = (ushort)(BX / 3);
        ushort unknownValue = CX;
        if (unknownValue < 0x300) {
            CX = (ushort)(unknownValue / 3);
            return NearRet();
        }

        // crashes when executed, but never reached...
        CX = 0x100;
        return NearRet();
    }

    public Action UnknownGlobeInitRelated_334B_1D5A_03520A(int gotoAddress) {
        // no jump
        globalsOnCsSegment0X2538.Set2538_1CA6_Word16_UnknownGlobeRelated(DI);
        globalsOnCsSegment0X2538.Set2538_1EA6_Word16_UnknownGlobeRelated(0xFEDD);
        globalsOnCsSegment0X2538.Set2538_1F29_Word16_UnknownGlobeRelated(0xFE5A);
        globalsOnCsSegment0X2538.Set2538_1CAE_Word16_UnknownGlobeRelated(0x6360 - 1);
        globalsOnCsSegment0X2538.Set2538_1CB0_Word16_UnknownGlobeRelated(0x6360);
        globalsOnCsSegment0X2538.Set2538_1CB2_Word16_UnknownGlobeRelated(0x6360);
        DS = SS;
        CarryFlag = true;
        return FarRet();
    }

    // line number in AX, offset address in 01A3
    public Action VgaFunc33UpdateVgaOffset01A3FromLineNumberAsAx_334B_0163_033613(int gotoAddress) {
        // 25F86
        ushort lineNumber = AX;
        this.globalsOnCsSegment0X2538.Set2538_01A3_Word16_VgaOffset((ushort)(lineNumber * 320));
        _loggerService.Debug("updateVgaOffset01A3FromLineNumberAsAx lineNumber:{@LineNumber},vgaOffset01A3:{@VgaOffset01A3}", lineNumber, globalsOnCsSegment0X2538.Get2538_01A3_Word16_VgaOffset());
        return FarRet();
    }

    public Action WaitForRetrace_334B_09B8_033E68(int gotoAddress) {
        // no jump, 28 lines in ghidra, part of the function is not executed in the logs and DX is always 3DA.
        // Wait for retrace.
        IVideoCard vgaCard = Machine.VgaCard;
        vgaCard.UpdateScreen();
        Thread.Sleep(15);
        State.CarryFlag = true;
        return NearRet();
    }

    public Action WaitForRetraceDuringIntroVideo_334B_261D_035ACD(int gotoAddress) {
        // Calls 0x2538_2572_278F2 when 01A1 is not 0 which we dont need
        return NearRet();
    }

    public Action WaitForRetraceInTransitions_334B_2572_035A22(int gotoAddress) {
        // Calls part of 0x2538_253D_278BD which we dont need
        return NearRet();
    }

    private Action SetDiFromXYCordsDxBx_334B_0C10_0340C0(int gotoAddress) {
        ushort x = DX;
        ushort y = BX;
        int offset = globalsOnCsSegment0X2538.Get2538_01A3_Word16_VgaOffset();
        if (y >= 200) {
            y = 199;
        }

        ushort res = (ushort)(320 * y + x + offset);
        DI = res;
        _loggerService.Debug("setDiFromXYCordsDxBx x:{@X},y:{@Y},offset:{@Offset},res:{@Res}", x, y, offset, res);
        return NearRet();
    }
}