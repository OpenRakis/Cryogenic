namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Channel-event opcodes dispatched by the DNADG scheduler.
/// Mirrors the seven distinct branches of
/// <c>AdgDispatchObservedEvent_0756</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>. Slots 2 and 3
/// both route to <see cref="ReadWaitValue"/>; the other slots map
/// one-to-one.
/// </summary>
public enum AdgEventOpcode {
	/// <summary>Slot 0 — note off (<c>AdgNoteOff_0AB6</c>).</summary>
	NoteOff = 0,

	/// <summary>Slot 1 — note on (<c>AdgNoteOn_0A82</c>).</summary>
	NoteOn = 1,

	/// <summary>Slots 2 and 3 — read variable-length wait value (<c>AdgReadWaitValue_0E7E</c>).</summary>
	ReadWaitValue = 2,

	/// <summary>Slot 4 — program (instrument) change (<c>AdgProgramChange_0831</c>).</summary>
	ProgramChange = 4,

	/// <summary>Slot 5 — volume modulation (<c>AdgVolumeModulation_0B2E</c>).</summary>
	VolumeModulation = 5,

	/// <summary>Slot 6 — pitch bend (<c>AdgPitchBend_0D86</c>).</summary>
	PitchBend = 6,

	/// <summary>Slot 7 — end of track (<c>AdgEndOfTrack_0AF5</c>).</summary>
	EndOfTrack = 7,
}