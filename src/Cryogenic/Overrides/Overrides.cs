namespace Cryogenic.Overrides;

using Globals;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.Function;
using Spice86.Core.Emulator.Function.Dump;
using Spice86.Core.Emulator.VM;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

using System.Collections.Generic;

public partial class Overrides : CSharpOverrideHelper {
    protected ushort cs1; // 0x1000
    protected ushort cs2; // 0x334B
    protected ushort cs3; // 0x5635
    protected ushort cs4; // 0x563E
    protected ushort cs5; // 0xF000
    private ExtraGlobalsOnDs globalsOnDs;
    private ExtraGlobalsOnCsSegment0x2538 globalsOnCsSegment0X2538;

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

    private int callsTo02DB = 0;
    private int callsTo03ED = 0;

    private void DumpMemoryWithSuffix(string suffix) {
        new MemoryDataExporter(Memory, Machine.CallbackHandler, Configuration, Configuration.RecordedDataDirectory, _loggerService).DumpMemory(suffix);
    }

    private void DefineDriversRemapping() {
        DoOnTopOfInstruction(cs1, 0xE57B, () => {
            DriverLoadToolbox.RemapDrivers(State, Memory);
        });
        DoOnTopOfInstruction(cs1, 0xE593, () => {
            DriverLoadToolbox.ResetAllocator(State, Memory);
        });
    }

    private void DetectDriversEntryPoints() {
        DoOnTopOfInstruction(cs1, 0xE589, () => {
            DriverLoadToolbox.ReadDriverFunctionTable(State, Memory, this);
        });
    }
}