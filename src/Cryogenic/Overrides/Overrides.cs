namespace Cryogenic.Overrides;

using Globals;

using Serilog;

using Spice86.Emulator.Function;
using Spice86.Emulator.Function.Dump;
using Spice86.Emulator.Memory;
using Spice86.Emulator.VM;

using System.Collections.Generic;

public partial class Overrides : GeneratedOverrides {
    private static readonly ILogger _logger = Log.Logger.ForContext<Overrides>();
    private ExtraGlobalsOnDs globalsOnDs;
    private ExtraGlobalsOnCsSegment0x2538 globalsOnCsSegment0X2538;

    public Overrides(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort entrySegment,
        Machine machine) : base(functionInformations, machine) {
        // This does not depend on the entry segment. 
        this.cs5 = 0xF000;
        globalsOnDs = new ExtraGlobalsOnDs(machine);
        globalsOnCsSegment0X2538 = new ExtraGlobalsOnCsSegment0x2538(machine, cs2);

        DefineStaticDefinitionsGlobals();
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
        if (!Machine.Configuration.UseCodeOverrideOption) {
            // Detect code rewrites only in emulated mode
            DetectCodeRewrites();
        }

        DefineDriversRemapping();
        DetectDriversEntryPoints();
        // Dump memory at the proper time. Too soon and drivers wont be loaded, too late and init code will be erased
        DefineMemoryDumpsMapping();

        SetupExecutableCodeModificationStrategy();

        // Generated code, crashes for various reasons
        DefineGeneratedCodeOverrides();
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
        new RecorderDataWriter(Machine.Configuration.RecordedDataDirectory, Machine).DumpMemory(suffix);
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

    private void SetupExecutableCodeModificationStrategy() {
        // Don't detect code modification in cases where the result will already be in the dump and won't change. This is so that the generated code does not become overloaded.
        OverrideInstruction(cs1, 0xF2F6, () => {
            // Driver load from file to executable area, disable code modification detection
            IsRegisterExecutableCodeModificationEnabled = false;
            Interrupt(0x21);
            IsRegisterExecutableCodeModificationEnabled = true;
            return NearJump(0xF2F8);
        });
        OverrideInstruction(cs1, 0xF43B, () => {
            // Part of HSQ decompression, disable code modification detection
            IsRegisterExecutableCodeModificationEnabled = false;
            // MOVSB ES:DI,SI (1000_F43B / 0x1F43B)
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = (ushort)(SI + Direction8);
            DI = (ushort)(DI + Direction8);
            IsRegisterExecutableCodeModificationEnabled = true;
            return NearJump(0xF43C);
        });
        OverrideInstruction(cs1, 0xF429, () => {
            // Part of HSQ decompression, disable code modification detection
            IsRegisterExecutableCodeModificationEnabled = false;
            // REP
            while (CX != 0) {
                CX--;
                // MOVSW ES:DI,SI (1000_F429 / 0x1F429)
                UInt16[ES, DI] = UInt16[DS, SI];
                SI = (ushort)(SI + Direction16);
                DI = (ushort)(DI + Direction16);
            }

            IsRegisterExecutableCodeModificationEnabled = true;
            return NearJump(0xF42B);
        });
        OverrideInstruction(cs1, 0xF47A, () => {
            // Part of HSQ decompression, disable code modification detection
            IsRegisterExecutableCodeModificationEnabled = false;
            // REP
            while (CX != 0) {
                CX--;
                // MOVSB ES:DI,SI (1000_F47A / 0x1F47A)
                UInt8[ES, DI] = UInt8[DS, SI];
                SI = (ushort)(SI + Direction8);
                DI = (ushort)(DI + Direction8);
            }

            IsRegisterExecutableCodeModificationEnabled = true;
            return NearJump(0xF47C);
        });
        OverrideInstruction(cs1, 0xE933, () => {
            // Installation of interrupt handlers and update of jumps, only done once and already in the dump -> we dont care
            IsRegisterExecutableCodeModificationEnabled = false;
            // MOV word ptr CS:[DI],AX (1000_E933 / 0x1E933)
            UInt16[cs1, DI] = AX;
            // MOV AX,word ptr CS:[DI + 0x2] (1000_E936 / 0x1E936)
            AX = UInt16[cs1, (ushort)(DI + 0x2)];
            // XCHG word ptr ES:[SI + 0x2],AX (1000_E93A / 0x1E93A)
            ushort tmp_1000_E93A = UInt16[ES, (ushort)(SI + 0x2)];
            UInt16[ES, (ushort)(SI + 0x2)] = AX;
            AX = tmp_1000_E93A;
            // MOV word ptr CS:[DI + 0x2],AX (1000_E93E / 0x1E93E)
            UInt16[cs1, (ushort)(DI + 0x2)] = AX;
            IsRegisterExecutableCodeModificationEnabled = true;
            return NearJump(0xE942);
        });
        OverrideInstruction(cs4, 0x02D9, () => {
            // Driver modifying itself only once (setting opcodes from 0x00 to 0x60)
            IsRegisterExecutableCodeModificationEnabled = false;
            // REP
            while (CX != 0) {
                CX--;
                // STOSB ES:DI (563E_02D9 / 0x566B9)
                UInt8[ES, DI] = AL;
                DI = (ushort)(DI + Direction8);
            }

            IsRegisterExecutableCodeModificationEnabled = true;
            return NearJump(0x02DB);
        });
        OverrideInstruction(cs4, 0x03EB, () => {
            // Driver modifying itself only once (Copying to memory containing 0s)
            IsRegisterExecutableCodeModificationEnabled = false;
            // REP
            while (CX != 0) {
                CX--;
                // MOVSW ES:DI,SI (563E_03EB / 0x567CB)
                UInt16[ES, DI] = UInt16[DS, SI];
                SI = (ushort)(SI + Direction16);
                DI = (ushort)(DI + Direction16);
            }

            IsRegisterExecutableCodeModificationEnabled = true;
            return NearJump(0x03ED);
        });
        OverrideInstruction(cs1, 0x49F7, () => {
            // Seems like obfuscation, it is erasing CS:E40C -> CS:E85C with 0x0800
            IsRegisterExecutableCodeModificationEnabled = false;
            // STOSW ES:DI (1000_49F7 / 0x149F7)
            UInt16[ES, DI] = AX;
            DI = (ushort)(DI + Direction16);
            // STOSW ES:DI (1000_49F8 / 0x149F8)
            UInt16[ES, DI] = AX;
            DI = (ushort)(DI + Direction16);
            IsRegisterExecutableCodeModificationEnabled = true;
            return NearJump(0x49F9);
        });
        
        OverrideInstruction(cs1, 0xB4A6, () => {
            // Overwrites init code but after it has been executed ...
            IsRegisterExecutableCodeModificationEnabled = false;
            // REP
            while (CX != 0) {
                CX--;
                // MOVSB ES:DI,SI (1000_B4A6 / 0x1B4A6)
                UInt8[ES, DI] = UInt8[DS, SI];
                SI = (ushort)(SI + Direction8);
                DI = (ushort)(DI + Direction8);
            }
            IsRegisterExecutableCodeModificationEnabled = true;
            return NearJump(0xB4A8);
        });
        OverrideInstruction(cs1, 0xA083, () => {
            // Overwrites init code but after it has been executed ...
            IsRegisterExecutableCodeModificationEnabled = false;
            // MOV word ptr CS:[BP + 0x0],AX (1000_A083 / 0x1A083)
            UInt16[cs1, BP] = AX;
            // MOV word ptr CS:[BP + 0x2],0x0 (1000_A087 / 0x1A087)
            UInt16[cs1, (ushort)(BP + 0x2)] = 0x0;
            IsRegisterExecutableCodeModificationEnabled = true;
            return NearJump(0xA08D);
        });
    }
}