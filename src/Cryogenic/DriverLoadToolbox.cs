namespace Cryogenic;

using Spice86.Core.Emulator.CPU;
using Spice86.Shared.Emulator.Memory;

/// <summary>
/// Provides utilities for remapping game drivers to clean segment boundaries for easier analysis.
/// </summary>
/// <remarks>
/// <para>
/// The purpose is to load the VGA, PCM, and MIDI drivers at multiples of 0x1000 (D000, E000, F000)
/// which makes it easier to identify code locations in disassembly listings and works around
/// Ghidra issue https://github.com/NationalSecurityAgency/ghidra/issues/981.
/// </para>
/// <para>
/// The remapping process works in two phases:
/// </para>
/// <list type="number">
/// <item><description>
/// <see cref="RemapDrivers"/> is called at the beginning of CS1:E57B to:
/// - Remove the allocator max segment limit
/// - Set next free pointer to D000, E000, or F000 depending on the driver being loaded
/// </description></item>
/// <item><description>
/// <see cref="ResetAllocator"/> is called at the end of CS1:E57B (address CS1:E593) to:
/// - Reset the allocator max segment limit to its original value
/// - Reset the next free pointer to its original value
/// </description></item>
/// </list>
/// <para>
/// After the sequence completes, the driver is loaded but not allocated. This is acceptable
/// because memory above VRAM (0xA000) is not used by the game.
/// </para>
/// </remarks>
public class DriverLoadToolbox {
    /// <summary>
    /// Segment address for interrupt handlers (0x800), freeing 0xF000 for driver3.
    /// </summary>
    public const ushort INTERRUPT_HANDLER_SEGMENT = 0x800;

    /// <summary>
    /// Target segment address for VGA driver (DNVGA) remapping.
    /// </summary>
    public const ushort DRIVER1_SEGMENT = 0xD000;

    /// <summary>
    /// Target segment address for PCM audio driver (DNPCS2, DNSBP) remapping.
    /// </summary>
    public const ushort DRIVER2_SEGMENT = 0xE000;

    /// <summary>
    /// Target segment address for MIDI music driver (DNPCS, DNMID) remapping.
    /// </summary>
    public const ushort DRIVER3_SEGMENT = 0xF000;

    /// <summary>
    /// Stores the original allocator limit before modification.
    /// </summary>
    private static ushort InitialFreeLimit = 0;

    /// <summary>
    /// Stores the original free segment pointer before modification.
    /// </summary>
    private static ushort InitialFreeSegment = 0;

    /// <summary>
    /// Stores the original free offset pointer before modification.
    /// </summary>
    private static ushort InitialFreeOffset = 0;

    /// <summary>
    /// Tracks the currently loading driver by its index.
    /// </summary>
    private static int CurrentDriver = -1;

    /// <summary>
    /// Indicates whether a driver override has occurred in the current load sequence.
    /// </summary>
    private static bool DriverOverrideHappened = false;

    /// <summary>
    /// Enumeration of driver identifiers corresponding to AX register values during driver loading.
    /// </summary>
    private enum DriverIndex { DNVGA, DN386, DNPCS, DNADL, DNADP, DNADG, DNMID, DNPCS2, DNSDB, DNSBP }

    /// <summary>
    /// Maps driver index values to their string names for identification and logging purposes.
    /// </summary>
    private static Dictionary<int, string> _driverNames = new() {
        { (int)DriverIndex.DNVGA, "DNVGA" },   // VGA graphics driver
        { (int)DriverIndex.DN386, "DN386" },   // 386 driver
        { (int)DriverIndex.DNPCS, "DNPCS" },   // PC Speaker sound driver
        { (int)DriverIndex.DNADL, "DNADL" },   // AdLib sound driver
        { (int)DriverIndex.DNADP, "DNADP" },   // AdLib Pro driver
        { (int)DriverIndex.DNADG, "DNADG" },   // AdLib Gold driver
        { (int)DriverIndex.DNMID, "DNMID" },   // MIDI music driver
        { (int)DriverIndex.DNPCS2, "DNPCS2" }, // PC Speaker variant 2
        { (int)DriverIndex.DNSDB, "DNSDB" },   // Sound Blaster driver
        { (int)DriverIndex.DNSBP, "DNSBP" }    // Sound Blaster Pro driver
    };

    /// <summary>
    /// Remaps specific game drivers to predetermined segment addresses for easier analysis.
    /// Should be called at the beginning of CS1:E57B during driver loading.
    /// </summary>
    /// <param name="state">CPU state containing the AX register with the driver index.</param>
    /// <param name="memory">Memory interface for reading and writing game memory.</param>
    /// <remarks>
    /// The AX register indicates which driver is being loaded:
    /// <list type="bullet">
    /// <item><description>0: DNVGA - VGA graphics driver</description></item>
    /// <item><description>1: DN386 - 386 driver</description></item>
    /// <item><description>2: DNPCS - PC Speaker sound driver</description></item>
    /// <item><description>3: DNADL - AdLib sound driver</description></item>
    /// <item><description>4: DNADP - AdLib Pro driver</description></item>
    /// <item><description>5: DNADG - AdLib Gold driver</description></item>
    /// <item><description>6: DNMID - MIDI music driver</description></item>
    /// <item><description>7: DNPCS2 - PC Speaker variant 2</description></item>
    /// <item><description>8: DNSDB - Sound Blaster driver</description></item>
    /// <item><description>9: DNSBP - Sound Blaster Pro driver</description></item>
    /// </list>
    /// Only VGA, PCM (DNPCS2/DNSBP), and MIDI (DNPCS/DNMID) drivers are remapped.
    /// </remarks>
    static public void RemapDrivers(State state, IMemory memory) {
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

    /// <summary>
    /// Computes the target segment address for a driver based on its identifier.
    /// </summary>
    /// <param name="driverId">The driver index from the AX register.</param>
    /// <returns>
    /// The target segment address for remapping, or null if the driver should not be remapped.
    /// </returns>
    /// <remarks>
    /// Only VGA, PCM audio, and MIDI music drivers are remapped to clean boundaries:
    /// <list type="bullet">
    /// <item><description>DNVGA → 0xD000 (DRIVER1_SEGMENT)</description></item>
    /// <item><description>DNPCS2, DNSBP → 0xE000 (DRIVER2_SEGMENT)</description></item>
    /// <item><description>DNPCS, DNMID → 0xF000 (DRIVER3_SEGMENT)</description></item>
    /// </list>
    /// Other drivers are left at their original allocations.
    /// </remarks>
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

    /// <summary>
    /// Disables the memory allocator's segment limit to allow driver loading above 0xA000 (VRAM boundary).
    /// </summary>
    /// <param name="state">CPU state providing the DS register value.</param>
    /// <param name="memory">Memory interface for reading and writing allocator state.</param>
    /// <remarks>
    /// Backs up the original allocator state and sets the limit to 0xFFFF, allowing allocation
    /// in the high memory region. This is necessary because drivers need to be loaded above the
    /// video RAM at 0xA000, which is normally restricted by the allocator.
    /// </remarks>
    public static void DisableAllocatorLimit(State state, IMemory memory) {
        InitialFreeLimit = memory.UInt16[state.DS, 0xce68];
        // Override free limit so that allocator accepts to let us load above 0xA000
        memory.UInt16[state.DS, 0xce68] = 0xFFFF;
        // Backup the allocator last free segment and offset
        InitialFreeOffset = memory.UInt16[state.DS, 0x39B7];
        InitialFreeSegment = memory.UInt16[state.DS, 0x39B9];
    }

    /// <summary>
    /// Restores the memory allocator to its original state after driver remapping is complete.
    /// Should be called at the end of CS1:E57B (address CS1:E593).
    /// </summary>
    /// <param name="state">CPU state providing the DS register value.</param>
    /// <param name="memory">Memory interface for writing allocator state.</param>
    /// <remarks>
    /// Restores the allocator limit and free pointers to their original values, allowing
    /// normal memory allocation to continue in the region below 0xA000. Only performs
    /// restoration if a driver override actually occurred.
    /// </remarks>
    public static void ResetAllocator(State state, IMemory memory) {
        if (!DriverOverrideHappened) {
            return;
        }

        // Restore allocator state to what it was so that allocation can continue in memory below 0xA000
        memory.UInt16[state.DS, 0xce68] = InitialFreeLimit;
        memory.UInt16[state.DS, 0x39B7] = InitialFreeOffset;
        memory.UInt16[state.DS, 0x39B9] = InitialFreeSegment;
    }

    /// <summary>
    /// Reads and auto-registers driver function table entries for Spice86 function tracing.
    /// Should be injected at address CS1:E589.
    /// </summary>
    /// <param name="state">CPU state containing AX (segment), SI (table offset), and CX (function count) registers.</param>
    /// <param name="memory">Memory interface for reading the driver's function table.</param>
    /// <param name="cSharpOverrideHelper">Helper for registering function definitions with Spice86.</param>
    /// <remarks>
    /// <para>
    /// Parses the driver's exported function table and automatically defines entry points and
    /// their internal implementations in Spice86's function information database. This enables
    /// better tracing, debugging, and potential overriding of driver functions.
    /// </para>
    /// <para>
    /// The function table is an array of near pointers, often pointing to JMP instructions
    /// that redirect to the actual implementation. This method decodes both the entry point
    /// and the jump target to create complete function definitions.
    /// </para>
    /// <para>
    /// Supports both near (0xE9) and short (0xEB) jump instructions.
    /// </para>
    /// </remarks>
    public static void ReadDriverFunctionTable(State state, IMemory memory, CSharpOverrideHelper cSharpOverrideHelper) {
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

    /// <summary>
    /// Defines a function in Spice86's function information database if it doesn't already exist.
    /// </summary>
    /// <param name="address">The segmented address of the function, or null to skip registration.</param>
    /// <param name="name">The symbolic name to assign to the function for debugging and tracing.</param>
    /// <param name="cSharpOverrideHelper">Helper for registering the function definition.</param>
    /// <remarks>
    /// Prevents duplicate function definitions by checking if the address is already registered.
    /// Does nothing if the address is null.
    /// </remarks>
    private static void DefineFunctionIfNotPresent(SegmentedAddress? address, string name,
        CSharpOverrideHelper cSharpOverrideHelper) {
        if (address == null) {
            return;
        }

        if (cSharpOverrideHelper.FunctionInformations.ContainsKey(address.Value)) {
            return;
        }
        cSharpOverrideHelper.DefineFunction(address.Value.Segment, address.Value.Offset, name);
    }
}