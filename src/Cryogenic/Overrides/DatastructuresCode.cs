namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Memory;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure.Array;
using Spice86.Shared.Emulator.Memory;

using System;

/// <summary>
/// Partial class containing data structure manipulation overrides.
/// </summary>
/// <remarks>
/// Method names contain underscores to separate segment, offset, and linear addresses
/// for traceability back to the original DOS disassembly.
/// </remarks>
public partial class Overrides {
    /// <summary>
    /// Registers data structure manipulation function overrides with Spice86.
    /// </summary>
    public void DefineDataStructureOverrides() {
        DefineFunction(cs1, 0x98, ConvertIndexTableToPointerTable_1000_0098_010098);
        DefineFunction(cs1, 0xC1F4, GetEsSiPointerToUnknown_1000_C1F4_01C1F4);
    }

    /// <summary>
    /// Override for CS1:0098 - Converts an index table to a pointer table by adding an offset to each entry.
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <remarks>
    /// Takes a table of indices at ES:DI and converts them to absolute pointers by adding
    /// the DI offset value to each entry. The first word in the table contains the total
    /// size in bytes (count = size / 2). This is used for relocating resource tables.
    /// </remarks>
    public Action ConvertIndexTableToPointerTable_1000_0098_010098(int gotoAddress) {
        uint initialAddress = MemoryUtils.ToPhysicalAddress(ES, DI);

        // wtf
        int increment = DI;
        int count = UInt16[initialAddress] / 2;
        UInt16Array array = new UInt16Array(Memory, initialAddress, count);
        for (int i = 0; i < array.Count; i++) {
            array[i] = (ushort)(array[i] + increment);
        }

        return NearRet();
    }

    /// <summary>
    /// Override for CS1:C1F4 - Retrieves a pointer from the sprite sheet resource table by index.
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <remarks>
    /// Looks up an entry in the sprite sheet resource pointer table using the AX register as index.
    /// Returns the resulting pointer in ES:SI. This is used extensively for accessing sprite
    /// graphics data. TODO: Create a proper data structure with more organized accessors
    /// when the exact format is better understood.
    /// </remarks>
    public Action GetEsSiPointerToUnknown_1000_C1F4_01C1F4(int gotoAddress) {
        // TODO: create a proper data structure with more organized accessors when what this is is known better.
        int index = AX;
        SegmentedAddress baseAddress = globalsOnDs.GetPtr1138_DBB0_Dword32_spriteSheetResourcePointer();
        int resOffset = baseAddress.Offset + UInt16[(uint)(baseAddress.Linear + index * 2)];
        ES = baseAddress.Segment;
        SI = (ushort)resOffset;
        return NearRet();
    }
}