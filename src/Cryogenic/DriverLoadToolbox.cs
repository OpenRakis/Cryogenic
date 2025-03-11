namespace Cryogenic;

using Spice86.Core.Emulator.CPU;
using Spice86.Shared.Emulator.Memory;

/**
 * Purpose is to load the drivers at a multiple of 0x1000 so that it's easier to see in the listing where we are
 * and also to workaround ghidra issue https://github.com/NationalSecurityAgency/ghidra/issues/981
 * RemapDrivers should be called at the beginning of method CS1:E57B:
 *  - It removes the allocator max segment limit
 *  - It sets next free pointer to either D000, E000, F000 depending on the driver being loaded
 * ResetAllocator needs to be called at the end of methode CS1:E57B, that is at address CS1:E593:
 *  - It resets the allocator max segment limit to what it was before
 *  - It resets the next free pointer to what it was before.
 * Consequently, after the sequence is over the driver is loaded but not allocated, but this doesn't matter because memory above VRAM is not used by the game
 */
public class DriverLoadToolbox {
    // Free 0xF000 for driver3
    public const ushort INTERRUPT_HANDLER_SEGMENT = 0x800;

    public const ushort DRIVER1_SEGMENT = 0xD000;
    public const ushort DRIVER2_SEGMENT = 0xE000;
    public const ushort DRIVER3_SEGMENT = 0xF000;

    private static ushort InitialFreeLimit = 0;
    private static ushort InitialFreeSegment = 0;
    private static ushort InitialFreeOffset = 0;
    private static int CurrentDriver = -1;
    private static bool DriverOverrideHappened = false;

    private enum DriverIndex { DNVGA, DN386, DNPCS, DNADL, DNADP, DNADG, DNMID, DNPCS2, DNSDB, DNSBP }

    private static Dictionary<int, string> _driverNames = new() {
        { (int)DriverIndex.DNVGA, "DNVGA" },
        { (int)DriverIndex.DN386, "DN386" },
        { (int)DriverIndex.DNPCS, "DNPCS" },
        { (int)DriverIndex.DNADL, "DNADL" },
        { (int)DriverIndex.DNADP, "DNADP" },
        { (int)DriverIndex.DNADG, "DNADG" },
        { (int)DriverIndex.DNMID, "DNMID" },
        { (int)DriverIndex.DNPCS2, "DNPCS2" },
        { (int)DriverIndex.DNSDB, "DNSDB" },
        { (int)DriverIndex.DNSBP, "DNSBP" }
    };

    static public void RemapDrivers(State state, IMemory memory) {
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
        CurrentDriver = state.AX;
        ushort? newSegment = ComputeNewSegment(CurrentDriver);
        if (newSegment != null) {
            DisableAllocatorLimit(state, memory);
            DriverOverrideHappened = true;
            memory.UInt16[state.DS, 0x39B9] = (ushort)(newSegment.Value + 0x10);
        } else {
            DriverOverrideHappened = false;
        }
    }

    private static ushort? ComputeNewSegment(int driverId) {
        switch (driverId) {
            // VGA Driver Segment
            case (int)DriverIndex.DNVGA: return DRIVER1_SEGMENT;
            // PCM Driver segment
            case (int)DriverIndex.DNPCS2: return DRIVER2_SEGMENT;
            case (int)DriverIndex.DNSBP: return DRIVER2_SEGMENT;
            // Music driver segment
            case (int)DriverIndex.DNPCS: return DRIVER3_SEGMENT;
            case (int)DriverIndex.DNMID: return DRIVER3_SEGMENT;
        }
        
        return null;
    }

    public static void DisableAllocatorLimit(State state, IMemory memory) {
        InitialFreeLimit = memory.UInt16[state.DS, 0xce68];
        // Override free limit so that allocator accepts to let us load above 0xA000
        memory.UInt16[state.DS, 0xce68] = 0xFFFF;
        // Backup the allocator last free segment and offset
        InitialFreeOffset = memory.UInt16[state.DS, 0x39B7];
        InitialFreeSegment = memory.UInt16[state.DS, 0x39B9];
    }

    public static void ResetAllocator(State state, IMemory memory) {
        if (!DriverOverrideHappened) {
            return;
        }

        // Restore allocator state to what it was so that allocation can continue in memory below 0xA000
        memory.UInt16[state.DS, 0xce68] = InitialFreeLimit;
        memory.UInt16[state.DS, 0x39B7] = InitialFreeOffset;
        memory.UInt16[state.DS, 0x39B9] = InitialFreeSegment;
    }

    public static void ReadDriverFunctionTable(State state, IMemory memory, CSharpOverrideHelper cSharpOverrideHelper) {
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
            if (memory.UInt8[entryAddress.Linear] == 0xE9) {
                // 16bit offset
                short jumpDisp = (short)memory.UInt16[entryAddress.Linear + 1];
                ushort jumpOffset = (ushort)(entryAddress.Offset + 3 + jumpDisp);
                jumpTargetAddress = new SegmentedAddress(segment, jumpOffset);
            }

            if (memory.UInt8[entryAddress.Linear] == 0xEB) {
                // 8 bit offset
                sbyte jumpDisp = (sbyte)memory.UInt8[entryAddress.Linear + 1];
                ushort jumpOffset = (ushort)(entryAddress.Offset + 2 + jumpDisp);
                jumpTargetAddress = new SegmentedAddress(segment, jumpOffset);
            }

            DefineFunctionIfNotPresent(jumpTargetAddress, $"{driverName}_internal_function_{i.ToString("D2")}",
                cSharpOverrideHelper);
        }
    }

    private static void DefineFunctionIfNotPresent(SegmentedAddress? address, string name,
        CSharpOverrideHelper cSharpOverrideHelper) {
        if (address == null) {
            return;
        }

        cSharpOverrideHelper.Machine.Cpu.FunctionHandler.GetOrCreateFunctionInformation(address.Value, name);
    }
}