namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.OperatingSystem;
using Spice86.Core.Emulator.OperatingSystem.Structures;

using System;

/// <summary>
/// Partial class containing HNM video file format handling overrides.
/// </summary>
/// <remarks>
/// <para>
/// HNM is a proprietary video format used by Cryo Interactive for full-motion video sequences.
/// This file provides overrides for reading HNM file data from disk into memory buffers
/// for decoding and playback.
/// </para>
/// <para>
/// Method names contain underscores to separate segment, offset, and linear addresses
/// for traceability back to the original DOS disassembly.
/// </para>
/// </remarks>
public partial class Overrides {

    /// <summary>
    /// Registers HNM video file handling function overrides with Spice86.
    /// </summary>
    public void DefineHnmCodeOverrides() {
        DefineFunction(cs1, 0xCDBF, HnmReadFromFileHandle_1000_CDBF_01CDBF);
    }

    /// <summary>
    /// Override for CS1:CDBF - Reads data from an open HNM video file into a memory buffer.
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <exception cref="UnhandledOperationException">
    /// Thrown if the actual bytes read doesn't match the requested amount, indicating an untested code path
    /// where the original DOS code would loop to retry the read.
    /// </exception>
    /// <remarks>
    /// <para>
    /// Performs a sequential read from the HNM file using the DOS file manager. Updates global
    /// state tracking file position, remaining bytes, and buffer pointers.
    /// </para>
    /// <para>
    /// The function reads CX bytes from the file at the current offset into the target buffer,
    /// then advances all related pointers and counters.
    /// </para>
    /// </remarks>
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