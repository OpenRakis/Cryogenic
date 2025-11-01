namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.OperatingSystem;
using Spice86.Core.Emulator.OperatingSystem.Structures;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides {

    public void DefineHnmCodeOverrides() {
        DefineFunction(cs1, 0xCDBF, HnmReadFromFileHandle_1000_CDBF_01CDBF);
    }

    public Action HnmReadFromFileHandle_1000_CDBF_01CDBF(int gotoAddress) {
        DosFileManager dosFileManager = Machine.Dos.FileManager;
        ushort fileHandle = globalsOnDs.Get1138_35A6_Word16_IsAnimateMenuUnneeded();
        if (fileHandle == 0) {
            return NearRet();
        }

        ushort readLength = CX;
        uint offset = globalsOnDs.Get1138_DC04_DWord32_hnmFileOffset();
        uint targetMemory = globalsOnDs.GetPtr1138_DC0C_Dword32_hnmFileReadBufferSegment().Linear;
        _loggerService.Debug("Read {@ReadLength} bytes from hnm file handle {@FileHandle} at offset {@Offset}", readLength, fileHandle, offset);
        dosFileManager.MoveFilePointerUsingHandle(0, fileHandle, (int)offset);
        DosFileOperationResult result = dosFileManager.ReadFileOrDevice(fileHandle, readLength, targetMemory);
        uint? actualReadLength = result.Value;
        if (actualReadLength != readLength) {
            throw this.FailAsUntested("The original code loops here when read bytes from hnm are not as expected.");
        }
        globalsOnDs.Set1138_DC08_DWord32_hnmFileRemain(globalsOnDs.Get1138_DC08_DWord32_hnmFileRemain() - actualReadLength.Value);
        globalsOnDs.Set1138_DC04_DWord32_hnmFileOffset(offset + actualReadLength.Value);
        globalsOnDs.Set1138_DC0C_Word16_hnmFileReadBufferSegment((ushort)(globalsOnDs.Get1138_DC0C_Word16_hnmFileReadBufferSegment() + actualReadLength.Value));
        globalsOnDs.Set1138_DC1A_Word16((ushort)(globalsOnDs.Get1138_DC1A_Word16() + actualReadLength.Value));
        return NearRet();
    }
}