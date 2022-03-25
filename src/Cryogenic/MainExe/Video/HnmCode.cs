namespace Cryogenic.Mainexe.Video;

using Cryogenic.Globals;

using Serilog;

using Spice86.Emulator.Function;
using Spice86.Emulator.InterruptHandlers.Dos;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class HnmCode : CSharpOverrideHelper {
    private static readonly ILogger _logger = Log.Logger.ForContext<HnmCode>();
    private ExtraGlobalsOnDs globals;

    public HnmCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine) : base(functionInformations, "hnm", machine) {
        this.globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0xCDBF, HnmReadFromFileHandle_1ED_CDBF_EC8F);
    }

    public Action HnmReadFromFileHandle_1ED_CDBF_EC8F() {
        DosFileManager dosFileManager = Machine.DosInt21Handler.DosFileManager;
        ushort fileHandle = globals.Get1138_35A6_Word16_IsAnimateMenuUnneeded();
        if (fileHandle == 0) {
            return NearRet();
        }

        ushort readLength = State.CX;
        uint offset = globals.Get1138_DC04_DWord32_hnmFileOffset();
        uint targetMemory = globals.GetPtr1138_DC0C_Dword32_hnmFileReadBufferSegment().ToPhysical();
        _logger.Debug("Read {@ReadLength} bytes from hnm file handle {@FileHandle} at offset {@Offset}", readLength, fileHandle, offset);
        dosFileManager.MoveFilePointerUsingHandle(0, fileHandle, offset);
        DosFileOperationResult result = dosFileManager.ReadFile(fileHandle, readLength, targetMemory);
        uint? actualReadLength = result.Value;
        if (actualReadLength != readLength) {
            throw this.FailAsUntested("The original code loops here when read bytes from hnm are not as expected.");
        }
        if (actualReadLength is not null) {
            globals.Set1138_DC08_DWord32_hnmFileRemain(globals.Get1138_DC08_DWord32_hnmFileRemain() - actualReadLength.Value);
            globals.Set1138_DC04_DWord32_hnmFileOffset(offset + actualReadLength.Value);
            globals.Set1138_DC0C_Word16_hnmFileReadBufferSegment((ushort)(globals.Get1138_DC0C_Word16_hnmFileReadBufferSegment() + actualReadLength.Value));
            globals.Set1138_DC1A_Word16((ushort)(globals.Get1138_DC1A_Word16() + actualReadLength.Value));
        }
        return NearRet();
    }
}