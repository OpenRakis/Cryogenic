namespace Cryogenic.Overrides;

// Method names contain _ to separate addresses.
public partial class Overrides {

    public void DefineScriptedSceneCodeOverrides() {
        DefineFunction(cs1, 0x93F, LoadSceneSequenceDataIntoAXAndAdvanceSI_1000_093F_01093F);
        DefineFunction(cs1, 0x945, SetSceneSequenceOffsetToSi_1000_0945_010945);
    }

    public Action LoadSceneSequenceDataIntoAXAndAdvanceSI_1000_093F_01093F(int gotoAddress) {
        ushort offset = globalsOnDs.Get1138_4854_Word16_SceneSequenceOffset();
        ushort value = UInt16[CS, offset];
        AX = value;
        _logger.Debug("loadSceneSequenceDataIntoAXAndAdvanceSI: offset:{@Offset},value:{@Value}", offset, value);

        // point to next value
        SI = (ushort)(offset + 2);

        // in asm this is done by continuing to setUnknownOffset4854ToSi_1ED_945_2815
        globalsOnDs.Set1138_4854_Word16_SceneSequenceOffset(SI);
        return NearRet();
    }

    public Action SetSceneSequenceOffsetToSi_1000_0945_010945(int gotoAddress) {
        ushort offset = SI;
        _logger.Debug("setUnknownOffset4854ToSi: offset:{@Offset}", offset);
        globalsOnDs.Set1138_4854_Word16_SceneSequenceOffset(offset);
        return NearRet();
    }
}