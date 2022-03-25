namespace Cryogenic.Mainexe.Scriptedscene;

using Cryogenic.Globals;

using Serilog;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class ScriptedSceneCode : CSharpOverrideHelper {
    private static readonly ILogger _logger = Log.Logger.ForContext<ScriptedSceneCode>();
    private ExtraGlobalsOnDs globals;

    public ScriptedSceneCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine) : base(functionInformations, "scriptedScene", machine) {
        globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0x93F, "LoadSceneSequenceDataIntoAXAndAdvanceSI", LoadSceneSequenceDataIntoAXAndAdvanceSI_1ED_93F_280F);
        DefineFunction(segment, 0x945, "SetSceneSequenceOffsetToSi", SetSceneSequenceOffsetToSi_1ED_945_2815);
    }

    public Action LoadSceneSequenceDataIntoAXAndAdvanceSI_1ED_93F_280F() {
        ushort offset = globals.Get1138_4854_Word16_SceneSequenceOffset();
        ushort value = UInt16[State.CS, offset];
        State.AX = (value);
        _logger.Debug("loadSceneSequenceDataIntoAXAndAdvanceSI: offset:{@Offset},value:{@Value}", offset, value);

        // point to next value
        State.SI = ((ushort)(offset + 2));

        // in asm this is done by continuing to setUnknownOffset4854ToSi_1ED_945_2815
        globals.Set1138_4854_Word16_SceneSequenceOffset(State.SI);
        return NearRet();
    }

    public Action SetSceneSequenceOffsetToSi_1ED_945_2815() {
        ushort offset = State.SI;
        _logger.Debug("setUnknownOffset4854ToSi: offset:{@Offset}", offset);
        globals.Set1138_4854_Word16_SceneSequenceOffset(offset);
        return NearRet();
    }
}