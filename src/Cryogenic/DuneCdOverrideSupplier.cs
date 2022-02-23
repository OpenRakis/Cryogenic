namespace Cryogenic;

using Cryogenic.Mainexe;
using Cryogenic.Mainexe.Datastructures;
using Cryogenic.Mainexe.Dialogues;
using Cryogenic.Mainexe.Dictionary;
using Cryogenic.Mainexe.Display;
using Cryogenic.Mainexe.Init;
using Cryogenic.Mainexe.Menu;
using Cryogenic.Mainexe.Scriptedscene;
using Cryogenic.Mainexe.Sound;
using Cryogenic.Mainexe.Time;
using Cryogenic.Mainexe.Timer;
using Cryogenic.Mainexe.Video;
using Cryogenic.Sound;
using Cryogenic.Vgadriver;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System.Collections.Generic;

/// <summary>
/// Example command line debug arguments: "commandLineArgs": "--Exe C:\\Jeux\\ABWFR\\DUNE_CD\\C\\DNCDPRG.EXE --CDrive=C:\\Jeux\\ABWFR\\DUNE_CD\\C --UseCodeOverride"
/// </summary>
public class DuneCdOverrideSupplier : IOverrideSupplier {

    public Dictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(int programStartSegment, Machine machine) {
        Dictionary<SegmentedAddress, FunctionInformation> res = new();
        CreateOverrides((ushort)programStartSegment, machine, res);
        return res;
    }

    private void CreateOverrides(ushort programStartSegment, Machine machine, Dictionary<SegmentedAddress, FunctionInformation> res) {
        new CSharpOverrideHelper(res, "providedInterrupts", machine).SetProvidedInterruptHandlersAsOverridden();
        SoundDriverCode soundDriver = new SoundDriverCode(res, programStartSegment, machine);
        VgaDriverCode vgaDriver = new VgaDriverCode(res, programStartSegment, machine);
        new UnknownCode(res, programStartSegment, machine);
        new MenuCode(res, programStartSegment, machine);
        new ScriptedSceneCode(res, programStartSegment, machine);
        new MapCode(res, programStartSegment, machine);
        //TODO: Fix dialogues zoom on crack
        new DialoguesCode(res, programStartSegment, machine);
        //TODO: Fix crash
        //new DisplayCode(res, programStartSegment, machine, vgaDriver);
        new HnmCode(res, programStartSegment, machine);
        new VideoCode(res, programStartSegment, machine);
        new InitCode(res, programStartSegment, machine);
        new DatastructuresCode(res, programStartSegment, machine);
        new TimeCode(res, programStartSegment, machine);
        new SoundCode(res, programStartSegment, machine, soundDriver);
        new TimerCode(res, programStartSegment, machine);
        new StaticDefinitions(res, programStartSegment, machine);
    }
}