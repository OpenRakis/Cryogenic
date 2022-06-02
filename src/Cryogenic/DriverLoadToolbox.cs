namespace Cryogenic;

using Spice86.Emulator.CPU;

/**
 * Purpose is to load the drivers at a multiple of 0x1000 so that it's easier to see in the listing where we are
 * and also to workaround ghidra issue https://github.com/NationalSecurityAgency/ghidra/issues/981
 * RemapDrivers should be called at the beginning of method CS1:E57B:
 *  - It removes the allocator max segment limit
 *  - It sets next free pointer to either C000, D000, E000 depending on the driver being loaded
 * ResetAllocator needs to be called at the end of methode CS1:E57B, that is at address CS1:E593:
 *  - It resets the allocator max segment limit to what it was before
 *  - It resets the next free pointer to what it was before.
 * Consequently, after the sequence is over the driver is loaded but not allocated, but this doesn't matter because memory above VRAM is not used by the game
 */
public class DriverLoadToolbox {
    private static ushort InitialFreeLimit = 0;
    private static ushort InitialFreeSegment = 0;
    private static ushort InitialFreeOffset = 0;
    private static int CurrentDriver = -1;

    private static Dictionary<int, string> _driverNames = new() {
        {0, "DNVGA"},
        {1, "DN386"},
        {2, "DNPCS"},
        {3, "DNADL"},
        {4, "DNADP"},
        {5, "DNADG"},
        {6, "DNMID"},
        {7, "DNPCS2"},
        {8, "DNSDB"},
        {9, "DNSBP"}
    };

    static public void RemapDrivers(State state, Memory memory) {
        /*
        AX values:
          0: DNVGA
          1: DN386
          2: DNPCS
          3: DNADL
          4: DNADP
          5: DNADG
          6: DNMID
          7: DNPCS2
          8: DNSDB
          9: DNSBP
        */

        DisableAllocatorLimit(state, memory);
        CurrentDriver = state.AX;
        // VGA driver
        if (CurrentDriver == 0) {
            memory.UInt16[state.DS, 0x39B9] = 0xC010;
        }

        // PC speaker 2
        if (CurrentDriver == 7) {
            // Load the smallest driver here
            memory.UInt16[state.DS, 0x39B9] = 0xD010;
        }

        // MIDI
        if (CurrentDriver == 6) {
            memory.UInt16[state.DS, 0x39B9] = 0xE010;
        }
    }

    static public void DisableAllocatorLimit(State state, Memory memory) {
        InitialFreeLimit = memory.UInt16[state.DS, 0xce68];
        // Override last free segment so that allocator accepts to let us load over 0xA000
        memory.UInt16[state.DS, 0xce68] = 0xEFFF;
        // Backup the allocator last free segment and offset
        InitialFreeOffset = memory.UInt16[state.DS, 0x39B7];
        InitialFreeSegment = memory.UInt16[state.DS, 0x39B9];
    }

    static public void ResetAllocator(State state, Memory memory) {
        // Restore allocator state to what it was so that allocation can continue in memory below 0xA000
        memory.UInt16[state.DS, 0xce68] = InitialFreeLimit;
        memory.UInt16[state.DS, 0x39B7] = InitialFreeOffset;
        memory.UInt16[state.DS, 0x39B9] = InitialFreeSegment;
    }

    static public void ReadDriverFunctionTable(State state, Memory memory, CSharpOverrideHelper cSharpOverrideHelper) {
        // Should be injected at E589
        _driverNames.TryGetValue(CurrentDriver, out string? driverName);
        if (driverName == null) {
            return;
        }
        ushort segment = (ushort)(state.AX - 0x10);
        // -2 because SI points to the first segment but we want the offset.
        ushort functionTableEntryOffset = (ushort)(state.SI - 2);
        int numberOfFunctions = state.CX;
        for (int i = 0; i < numberOfFunctions; i++) {
            ushort pointerTableOffset = memory.UInt16[state.DS, (ushort)(functionTableEntryOffset + i * 4)];
            SegmentedAddress entryAddress = new SegmentedAddress(segment, pointerTableOffset);
            DefineFunctionIfNotPresent(entryAddress, $"{driverName}_entry_{i.ToString("D2")}", cSharpOverrideHelper);
            // Parse the jump to create the target function address in the driver
            SegmentedAddress? jumpTargetAddress = null;
            if (memory.UInt8[entryAddress.ToPhysical()] == 0xE9) {
                // 16bit offset
                short jumpDisp = (short)memory.UInt16[entryAddress.ToPhysical() + 1];
                ushort jumpOffset = (ushort)(entryAddress.Offset + 3 + jumpDisp);
                jumpTargetAddress = new SegmentedAddress(segment, jumpOffset);
            }

            if (memory.UInt8[entryAddress.ToPhysical()] == 0xEB) {
                // 8 bit offset
                sbyte jumpDisp = (sbyte)memory.UInt8[entryAddress.ToPhysical() + 1];
                ushort jumpOffset = (ushort)(entryAddress.Offset + 2 + jumpDisp);
                jumpTargetAddress = new SegmentedAddress(segment, jumpOffset);
            }
            DefineFunctionIfNotPresent(jumpTargetAddress, $"{driverName}_internal_function_{i.ToString("D2")}", cSharpOverrideHelper);
        }
    }

    static private void DefineFunctionIfNotPresent(SegmentedAddress? address, string name,
        CSharpOverrideHelper cSharpOverrideHelper) {
        if (address == null) {
            return;
        }
        cSharpOverrideHelper.Machine.Cpu.FunctionHandler.GetOrCreateFunctionInformation(address, name);
    }
}