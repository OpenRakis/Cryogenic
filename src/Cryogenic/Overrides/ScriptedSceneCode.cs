namespace Cryogenic.Overrides;

/// <summary>
/// Partial class containing scripted scene sequence handling overrides.
/// </summary>
/// <remarks>
/// Method names contain underscores to separate segment, offset, and linear addresses
/// for traceability back to the original DOS disassembly. This file handles the execution
/// of scripted cutscenes and scene transitions through sequence data.
/// </remarks>
public partial class Overrides {

    /// <summary>
    /// Registers scripted scene sequence function overrides with Spice86.
    /// </summary>
    public void DefineScriptedSceneCodeOverrides() {
        DefineFunction(cs1, 0x93F, LoadSceneSequenceDataIntoAXAndAdvanceSI_1000_093F_01093F);
        DefineFunction(cs1, 0x945, SetSceneSequenceOffsetToSi_1000_0945_010945);
    }

    /// <summary>
    /// Override for CS1:093F - Loads the next scene sequence command into AX and advances the sequence pointer.
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <remarks>
    /// Reads a 16-bit command value from the current scene sequence offset in CS segment,
    /// stores it in AX, and advances the SI pointer to the next command. The sequence offset
    /// is maintained in global variable DS:4854.
    /// </remarks>
    public Action LoadSceneSequenceDataIntoAXAndAdvanceSI_1000_093F_01093F(int gotoAddress) {
        ushort offset = globalsOnDs.Get1138_4854_Word16_SceneSequenceOffset();
        ushort value = UInt16[CS, offset];
        AX = value;
        _loggerService.Debug("loadSceneSequenceDataIntoAXAndAdvanceSI: offset:{@Offset},value:{@Value}", offset, value);

        // point to next value
        SI = (ushort)(offset + 2);

        // in asm this is done by continuing to setUnknownOffset4854ToSi_1ED_945_2815
        globalsOnDs.Set1138_4854_Word16_SceneSequenceOffset(SI);
        return NearRet();
    }

    public Action SetSceneSequenceOffsetToSi_1000_0945_010945(int gotoAddress) {
        ushort offset = SI;
        _loggerService.Debug("setUnknownOffset4854ToSi: offset:{@Offset}", offset);
        globalsOnDs.Set1138_4854_Word16_SceneSequenceOffset(offset);
        return NearRet();
    }
}