namespace Cryogenic.Overrides;

using Globals;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.Function;
using Spice86.Core.Emulator.Function.Dump;
using Spice86.Core.Emulator.VM;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

using System.Collections.Generic;

/// <summary>
/// Central class for defining C# overrides that replace routines in the DNCDPRG.EXE DOS executable.
/// </summary>
/// <remarks>
/// <para>
/// This partial class serves as the main coordinator for all game overrides. It extends
/// <see cref="CSharpOverrideHelper"/> from Spice86 and provides the infrastructure for
/// replacing DOS assembly routines with modern C# implementations.
/// </para>
/// <para>
/// The class maintains segment fields (cs1-cs5) that serve as anchors for all injected addresses.
/// These segments are carefully mapped to avoid conflicts and enable easier disassembly analysis:
/// </para>
/// <list type="bullet">
/// <item><description>cs1 (0x1000): Main game code segment</description></item>
/// <item><description>cs2 (0xD000): VGA driver segment (remapped)</description></item>
/// <item><description>cs3 (0xE000): PCM audio driver segment (remapped)</description></item>
/// <item><description>cs4 (0xE000): MIDI music driver segment (remapped, shares with cs3)</description></item>
/// <item><description>cs5 (0x0800): BIOS/IRQ interrupt handlers segment</description></item>
/// </list>
/// <para>
/// Override registration uses helper methods like <c>DefineFunction</c> (replaces CALL targets)
/// and <c>DoOnTopOfInstruction</c> (injects inline hooks). These ensure Spice86 correctly
/// patches the emulated program at the specified addresses.
/// </para>
/// </remarks>
public partial class Overrides : CSharpOverrideHelper {
    /// <summary>Main game code segment (0x1000).</summary>
    protected ushort cs1;

    /// <summary>VGA driver segment (remapped to 0xD000).</summary>
    protected ushort cs2;

    /// <summary>PCM audio driver segment (remapped to 0xE000).</summary>
    protected ushort cs3;

    /// <summary>MIDI music driver segment (remapped to 0xE000, shares with cs3).</summary>
    protected ushort cs4;

    /// <summary>BIOS/IRQ interrupt handler segment (0x0800).</summary>
    protected ushort cs5;

    /// <summary>Accessor for game global variables stored in the DS segment.</summary>
    private ExtraGlobalsOnDs globalsOnDs;

    /// <summary>Accessor for game global variables stored in CS segment 0x2538.</summary>
    private ExtraGlobalsOnCsSegment0x2538 globalsOnCsSegment0X2538;

    /// <summary>
    /// Initializes the override system and registers all function replacements and hooks.
    /// </summary>
    /// <param name="functionInformations">Dictionary to populate with function override mappings.</param>
    /// <param name="entrySegment">The segment where DNCDPRG.EXE was loaded (unused but required by interface).</param>
    /// <param name="machine">The emulated machine providing access to CPU, memory, and devices.</param>
    /// <param name="loggerService">Service for logging debug information during override execution.</param>
    /// <param name="configuration">Spice86 configuration containing runtime settings.</param>
    public Overrides(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort entrySegment,
        Machine machine, ILoggerService loggerService, Configuration configuration) : 
        base(functionInformations, machine,  loggerService, configuration) {
        // Main code
        this.cs1 = 0x1000;
        // Vga driver is remapped here
        this.cs2 = DriverLoadToolbox.DRIVER1_SEGMENT;
        // PCM driver
        this.cs3 = DriverLoadToolbox.DRIVER2_SEGMENT;
        // Midi driver
        this.cs4 = DriverLoadToolbox.DRIVER2_SEGMENT;
        // Bios, This does not depend on the entry segment. 
        this.cs5 = DriverLoadToolbox.INTERRUPT_HANDLER_SEGMENT;
        globalsOnDs = new ExtraGlobalsOnDs(machine.Memory, machine.Cpu.State.SegmentRegisters);
        globalsOnCsSegment0X2538 = new ExtraGlobalsOnCsSegment0x2538(machine.Memory, cs2);

        DefineOverrides();
        DefineStaticDefinitionsFunctions();
    }

    /// <summary>
    /// Registers all override functions and inline hooks across different game subsystems.
    /// </summary>
    /// <remarks>
    /// This method orchestrates the registration of overrides for:
    /// <list type="bullet">
    /// <item><description>Data structures and memory management</description></item>
    /// <item><description>VGA graphics operations</description></item>
    /// <item><description>Dialogue system</description></item>
    /// <item><description>Display and rendering</description></item>
    /// <item><description>HNM video playback</description></item>
    /// <item><description>Initialization sequences</description></item>
    /// <item><description>Map rendering and navigation</description></item>
    /// <item><description>Menu system</description></item>
    /// <item><description>Scripted scenes and cutscenes</description></item>
    /// <item><description>Time and timer management</description></item>
    /// <item><description>MT-32 MIDI driver</description></item>
    /// <item><description>Driver remapping infrastructure</description></item>
    /// <item><description>Memory dump triggers for debugging</description></item>
    /// </list>
    /// Generated code overrides are commented out as they crash for various reasons.
    /// </remarks>
    public void DefineOverrides() {
        DefineDataStructureOverrides();
        DefineVgaDriverCodeOverrides();
        DefineDialoguesCodeOverrides();
        DefineDisplayCodeOverrides();
        DefineHnmCodeOverrides();
        DefineInitCodeOverrides();
        DefineMapCodeOverrides();
        DefineMenuCodeOverrides();
        DefineScriptedSceneCodeOverrides();
        DefineTimeCodeOverrides();
        DefineTimerCodeOverrides();
        DefineUnknownCodeOverrides();
        DefineVideoCodeOverrides();

        DefineDriversRemapping();
        DetectDriversEntryPoints();
        // Dump memory at the proper time. Too soon and drivers wont be loaded, too late and init code will be erased
        DefineMemoryDumpsMapping();
        DefineMT32DriverCodeOverrides();
        
        // Generated code, crashes for various reasons
        //DefineGeneratedCodeOverrides();
    }
    
    /// <summary>
    /// Registers memory dump triggers at strategic points during game initialization.
    /// </summary>
    /// <remarks>
    /// Memory dumps are triggered at specific addresses to capture game state:
    /// <list type="bullet">
    /// <item><description>After driver loading (CS1:000C)</description></item>
    /// <item><description>After self-modifying code updates (CS4:02DC and CS4:03EE)</description></item>
    /// </list>
    /// Dumps must be timed carefully - too early and drivers won't be loaded,
    /// too late and initialization code will be erased by self-modifying code.
    /// </remarks>
    private void DefineMemoryDumpsMapping() {
        DoOnTopOfInstruction(cs1, 0x000C, () => {
            DumpMemoryWithSuffix("_" + ConvertUtils.ToHex16WithoutX(cs1) + "_000C_After_driver_load");
        });
        DoOnTopOfInstruction(cs4, 0x02DC, () => {
            callsTo02DB++;
            DumpMemoryWithSuffix("_" + ConvertUtils.ToHex16WithoutX(cs4) + "_02DC_After_code_modification_" +
                                 callsTo02DB);
        });
        DoOnTopOfInstruction(cs4, 0x03EE, () => {
            callsTo03ED++;
            DumpMemoryWithSuffix("_" + ConvertUtils.ToHex16WithoutX(cs4) + "_03EE_After_code_modification_" +
                                 callsTo03ED);
        });
    }

    /// <summary>Counter for memory dumps at CS4:02DC to create unique filenames.</summary>
    private int callsTo02DB = 0;

    /// <summary>Counter for memory dumps at CS4:03EE to create unique filenames.</summary>
    private int callsTo03ED = 0;

    /// <summary>
    /// Exports a memory dump with the specified filename suffix.
    /// </summary>
    /// <param name="suffix">Suffix to append to the dump filename for identification.</param>
    private void DumpMemoryWithSuffix(string suffix) {
        new MemoryDataExporter(Memory, Machine.CallbackHandler, Configuration, Configuration.RecordedDataDirectory, _loggerService).DumpMemory(suffix);
    }

    /// <summary>
    /// Registers hooks for driver remapping at the beginning and end of the driver load routine.
    /// </summary>
    /// <remarks>
    /// Injects calls to <see cref="DriverLoadToolbox.RemapDrivers"/> at CS1:E57B
    /// and <see cref="DriverLoadToolbox.ResetAllocator"/> at CS1:E593 to control
    /// driver segment allocation.
    /// </remarks>
    private void DefineDriversRemapping() {
        DoOnTopOfInstruction(cs1, 0xE57B, () => {
            DriverLoadToolbox.RemapDrivers(State, Memory);
        });
        DoOnTopOfInstruction(cs1, 0xE593, () => {
            DriverLoadToolbox.ResetAllocator(State, Memory);
        });
    }

    /// <summary>
    /// Registers a hook to automatically detect and define driver entry point functions.
    /// </summary>
    /// <remarks>
    /// Injects a call to <see cref="DriverLoadToolbox.ReadDriverFunctionTable"/> at CS1:E589
    /// to parse driver export tables and register their functions for tracing.
    /// </remarks>
    private void DetectDriversEntryPoints() {
        DoOnTopOfInstruction(cs1, 0xE589, () => {
            DriverLoadToolbox.ReadDriverFunctionTable(State, Memory, this);
        });
    }
}