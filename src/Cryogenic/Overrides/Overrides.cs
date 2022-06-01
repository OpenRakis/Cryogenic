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
        if (!Machine.Configuration.UseCodeOverride) {
            // Detect code rewrites only in emulated mode
            DetectCodeRewrites();
            // Remap drivers so that their segments is a multiple of 0x1000. This is to workaround a bug in ghidra 
            // See https://github.com/NationalSecurityAgency/ghidra/issues/981
            RemapDrivers();
            // Dump memory at the proper time. Too soon and drivers wont be loaded, too late and init code will be erased
            DoDump();
        }

        SetupExecutableCodeModificationStrategy();

        // Generated code, crashes for various reasons
        //DefineGeneratedCodeOverrides();
    }

    private void DoDump() {
        OverrideInstruction(cs1, 0x000C, () => {
            new RecorderDataWriter(Machine.Configuration.RecordedDataDirectory, Machine).DumpAll();
            // STI  (1000_000C / 0x1000C)
            InterruptFlag = true;
            return NearJump(0x000D);
        });
    }

    private void RemapDrivers() {
        OverrideInstruction(cs1, 0xE57B, () => {
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

            // Last free segment
            UInt16[DS, 0xce68] = 0x9FFF;
            // VGA driver
            if (AX == 0) {
                UInt16[DS, 0x39B9] = 0x4010;
            }

            // PC speaker 2
            if (AX == 7) {
                // Override last free segment just this time so that allocator accepts to let us load over 0xA000
                UInt16[DS, 0xce68] = 0xEFFF;
                UInt16[DS, 0x39B9] = 0xC010;
            }

            // MIDI
            if (AX == 6) {
                UInt16[DS, 0x39B9] = 0x7010;
            }

            // PC speaker
            if (AX == 2) {
                //UInt16[DS, 0x39B9] = 0xD000;
            }
            // PUSH CX (1000_E57B / 0x1E57B)
            Stack.Push(CX);
            return NearJump(0xE57C);
        });
        // Could have modified checks at CS1:E794 and CS1:E7F3 to have ZF always false and get away with the last free segment check, but doing so did not work well
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
    }
}