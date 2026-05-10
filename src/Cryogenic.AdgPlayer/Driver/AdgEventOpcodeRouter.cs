namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure router that maps a 0..7 opcode slot (returned by
/// <see cref="AdgEventOpcodeClassifier"/>) to the corresponding
/// <see cref="AdgEventOpcode"/>. Verbatim translation of the
/// switch in <c>AdgDispatchObservedEvent_0756</c> with slots 2/3
/// folded onto <see cref="AdgEventOpcode.ReadWaitValue"/>.
/// </summary>
public static class AdgEventOpcodeRouter {
	/// <summary>
	/// Returns the opcode for <paramref name="slot"/>, or throws
	/// when the slot is outside [0,8).
	/// </summary>
	public static AdgEventOpcode Route(int slot) {
		switch (slot) {
			case 0: return AdgEventOpcode.NoteOff;
			case 1: return AdgEventOpcode.NoteOn;
			case 2: return AdgEventOpcode.ReadWaitValue;
			case 3: return AdgEventOpcode.ReadWaitValue;
			case 4: return AdgEventOpcode.ProgramChange;
			case 5: return AdgEventOpcode.VolumeModulation;
			case 6: return AdgEventOpcode.PitchBend;
			case 7: return AdgEventOpcode.EndOfTrack;
			default:
				throw new ArgumentOutOfRangeException(nameof(slot), slot,
					"Opcode slot must be within [0,8).");
		}
	}
}