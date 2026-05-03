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
		DefineFunction(cs1, 0x021C, PlayIntro2_1000_021C_01021C);
		DefineFunction(cs1, 0x0580, PlayIntro_1000_0580_010580);
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

	/// <summary>
	/// Override for CS1:021C — play_intro2 (seg000:021C).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action PlayIntro2_1000_021C_01021C(int gotoAddress) {
		throw FailAsUntested("PlayIntro2 (seg000:021C) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:0580 — play_intro (seg000:0580).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action PlayIntro_1000_0580_010580(int gotoAddress) {
		throw FailAsUntested("PlayIntro (seg000:0580) not yet implemented");
	}
}