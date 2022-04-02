namespace Cryogenic.Overrides;

using Globals;

using JetBrains.Annotations;

using Serilog;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.VM;

using System.Collections.Generic;

public partial class Overrides {
    private static readonly ILogger _logger = Log.Logger.ForContext<Overrides>();
    private ushort cs1; // 0x1000
    private ushort cs2; // 0x334B
    private ushort cs3; // 0x5635
    private ushort cs4; // 0x563E
    private ExtraGlobalsOnDs globalsOnDs;
    private ExtraGlobalsOnCsSegment0x2538 globalsOnCsSegment0X2538;

    public Overrides(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort entrySegment, Machine machine) : base(functionInformations, machine) {
        this.cs1 = entrySegment;
        this.cs2 = (ushort)(entrySegment + 0x234B);
        this.cs3 = (ushort)(entrySegment + 0x4635);
        this.cs4 = (ushort)(entrySegment + 0x463E);
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
        DefineSoundCodeOverrides();
        DefineSoundDriverCodeOverrides();
        DefineTimeCodeOverrides();
        DefineTimerCodeOverrides();
        DefineUnknownCodeOverrides();
        DefineVideoCodeOverrides();
        // Do code rewrite detection after dune initialization, so override instruction
        OverrideInstruction(cs1, 0xc, () => {
            // cs1:000C is STI
            InterruptFlag = true;
            DetectCodeRewrites();
            return NearJump(0xd);
        });
        // Generated code, crashes for various reasons
        //DefineGeneratedCodeOverrides();
    }
}