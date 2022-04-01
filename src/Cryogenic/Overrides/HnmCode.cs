namespace Cryogenic.Overrides;

using Spice86.Emulator.InterruptHandlers.Dos;
using Spice86.Emulator.ReverseEngineer;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {

    public void DefineHnmCodeOverrides() {
        DefineFunction(cs1, 0xCDBF, HnmReadFromFileHandle_1ED_CDBF_EC8F);
    }

    public Action HnmReadFromFileHandle_1ED_CDBF_EC8F(int gotoAddress) {
        DosFileManager dosFileManager = Machine.DosInt21Handler.DosFileManager;
        ushort fileHandle = globalsOnDs.Get1138_35A6_Word16_IsAnimateMenuUnneeded();
        if (fileHandle == 0) {
            return NearRet();
        }

        ushort readLength = State.CX;
        uint offset = globalsOnDs.Get1138_DC04_DWord32_hnmFileOffset();
        uint targetMemory = globalsOnDs.GetPtr1138_DC0C_Dword32_hnmFileReadBufferSegment().ToPhysical();
        _logger.Debug("Read {@ReadLength} bytes from hnm file handle {@FileHandle} at offset {@Offset}", readLength, fileHandle, offset);
        dosFileManager.MoveFilePointerUsingHandle(0, fileHandle, offset);
        DosFileOperationResult result = dosFileManager.ReadFile(fileHandle, readLength, targetMemory);
        uint? actualReadLength = result.Value;
        if (actualReadLength != readLength) {
            throw this.FailAsUntested("The original code loops here when read bytes from hnm are not as expected.");
        }
        if (actualReadLength is not null) {
            globalsOnDs.Set1138_DC08_DWord32_hnmFileRemain(globalsOnDs.Get1138_DC08_DWord32_hnmFileRemain() - actualReadLength.Value);
            globalsOnDs.Set1138_DC04_DWord32_hnmFileOffset(offset + actualReadLength.Value);
            globalsOnDs.Set1138_DC0C_Word16_hnmFileReadBufferSegment((ushort)(globalsOnDs.Get1138_DC0C_Word16_hnmFileReadBufferSegment() + actualReadLength.Value));
            globalsOnDs.Set1138_DC1A_Word16((ushort)(globalsOnDs.Get1138_DC1A_Word16() + actualReadLength.Value));
        }
        return NearRet();
    }
}