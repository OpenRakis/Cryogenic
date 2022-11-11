namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.ReverseEngineer;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {

    public void DefineScriptedSceneCodeOverrides() {
        DefineFunction(cs1, 0x93F, LoadSceneSequenceDataIntoAXAndAdvanceSI_1ED_93F_280F);
        DefineFunction(cs1, 0x945, SetSceneSequenceOffsetToSi_1ED_945_2815);
    }

    public Action LoadSceneSequenceDataIntoAXAndAdvanceSI_1ED_93F_280F(int gotoAddress) {
        ushort offset = globalsOnDs.Get1138_4854_Word16_SceneSequenceOffset();
        ushort value = UInt16[State.CS, offset];
        State.AX = value;
        _logger.Debug("loadSceneSequenceDataIntoAXAndAdvanceSI: offset:{@Offset},value:{@Value}", offset, value);

        // point to next value
        State.SI = (ushort)(offset + 2);

        // in asm this is done by continuing to setUnknownOffset4854ToSi_1ED_945_2815
        globalsOnDs.Set1138_4854_Word16_SceneSequenceOffset(State.SI);
        return NearRet();
    }

    public Action SetSceneSequenceOffsetToSi_1ED_945_2815(int gotoAddress) {
        ushort offset = State.SI;
        _logger.Debug("setUnknownOffset4854ToSi: offset:{@Offset}", offset);
        globalsOnDs.Set1138_4854_Word16_SceneSequenceOffset(offset);
        return NearRet();
    }
}