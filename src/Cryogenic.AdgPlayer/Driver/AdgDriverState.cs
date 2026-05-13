namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Composite ADG driver state aggregate. Bundles the per-channel
/// tables and singleton cells reverse-engineered from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c> into a single
/// object suitable for being shared between the scheduler, the
/// dispatch handlers, and a UI binding layer. Each component is
/// owned exclusively by this aggregate; there is no observable
/// fan-out yet.
/// </summary>
public sealed class AdgDriverState {
	/// <summary>Number of logical channels managed by the driver.</summary>
	public const int ChannelCount = 18;

	/// <summary>Per-channel ushort wait counters (DI+0).</summary>
	public AdgChannelWaitCounters WaitCounters { get; }

	/// <summary>Per-channel event-stream offsets (DI+0x24).</summary>
	public AdgChannelEventPointers EventPointers { get; }

	/// <summary>Per-channel instrument byte (DI+0x6C).</summary>
	public AdgChannelInstrumentSlots InstrumentSlots { get; }

	/// <summary>Per-channel current note (DI+0x6D).</summary>
	public AdgChannelCurrentNotes CurrentNotes { get; }

	/// <summary>Per-channel pitch mode flag (DI+0x90).</summary>
	public AdgChannelPitchModeSlots PitchModeSlots { get; }

	/// <summary>Per-channel pitch transpose offset (DI+0x91).</summary>
	public AdgChannelPitchTransposeSlots PitchTransposeSlots { get; }

	/// <summary>Per-channel pitch-bend tick counter (DI+0xB4).</summary>
	public AdgChannelPitchBendCounters PitchBendCounters { get; }

	/// <summary>Per-channel pitch accumulator (DI+0xD8).</summary>
	public AdgChannelPitchAccumulators PitchAccumulators { get; }

	/// <summary>Per-channel volume modulation shape word (DI+0x18C).</summary>
	public AdgChannelVolumeModulationSlots VolumeModulationSlots { get; }

	/// <summary>Per-channel patch type byte (DI+0x2D0).</summary>
	public AdgChannelPatchTypeSlots PatchTypeSlots { get; }

	/// <summary>Loop measure / subdivision / loop-counter triplet.</summary>
	public AdgLoopState LoopState { get; }

	/// <summary>Song / event pointer pair (0x011E…0x0124).</summary>
	public AdgSongPosition SongPosition { get; }

	/// <summary>Tempo accumulator word (0x0126).</summary>
	public AdgTempoAccumulator TempoAccumulator { get; }

	/// <summary>Subdivision-to-measure clock built on top of <see cref="LoopState"/>.</summary>
	public AdgMeasureClock MeasureClock { get; }

	/// <summary>Master / current volume cell (0x04D8 / 0x04D6).</summary>
	public AdgMasterVolume MasterVolume { get; }

	/// <summary>Fade pattern state byte (0x01E0).</summary>
	public AdgFadePatternState FadePatternState { get; }

	/// <summary>Tempo-dynamics byte (0x04D7).</summary>
	public AdgDynamics Dynamics { get; }

	/// <summary>Tick divider counter (0x0127).</summary>
	public AdgTickDivider TickDivider { get; }

	/// <summary>Per-channel state-scratch words (DI+0x021C).</summary>
	public AdgChannelStateScratch ChannelStateScratch { get; }

	/// <summary>Global fade-scratch ushort pair (0x013E / 0x0140).</summary>
	public AdgFadeScratchState FadeScratchState { get; }

	/// <summary>Per-channel cached A0/B0 frequency word (DI+0x1B0).</summary>
	public AdgFrequencyWordCache FrequencyWordCache { get; }

	/// <summary>Loop-point rep-movs snapshot mirror (channel base + 0x03B6).</summary>
	public AdgLoopSnapshotStore LoopSnapshotStore { get; }

	/// <summary>Per-channel pitch-accumulator step byte (DI+0xD9).</summary>
	public AdgChannelPitchAccumulatorSteps PitchAccumulatorSteps { get; }

	/// <summary>Per-channel pitch-bend counter reload byte (DI+0xB5).</summary>
	public AdgChannelPitchBendCounterReloads PitchBendCounterReloads { get; }

	/// <summary>Per-channel current-operator-level word (DI+0xF0).</summary>
	public AdgChannelCurrentOperatorLevels CurrentOperatorLevels { get; }

	/// <summary>Master-track event counter (0x01DF, <c>AdgTickEnabledOffset</c>).</summary>
	public AdgTickEnabledCounter TickEnabledCounter { get; }

	/// <summary>Global surround-mask byte (<c>AdgSurroundMaskOffset</c>).</summary>
	public AdgSurroundMaskState SurroundMaskState { get; }

	/// <summary>Per-channel TL-shaping word (DI+0xFC).</summary>
	public AdgChannelTlShapingSlots TlShapingSlots { get; }

	/// <summary>Per-channel envelope-shaping word (DI+0x120).</summary>
	public AdgChannelEnvShapingSlots EnvShapingSlots { get; }

	/// <summary>Per-channel connection-shaping word (DI+0x168).</summary>
	public AdgChannelConnectionShapingSlots ConnectionShapingSlots { get; }

	/// <summary>Per-channel connection-modulation pair (DI+0x1B0).</summary>
	public AdgChannelConnectionModulationSlots ConnectionModulationSlots { get; }

	/// <summary>Per-channel Patch4 TL-shaping word (DI+0x240).</summary>
	public AdgChannelPatch4TlShapingSlots Patch4TlShapingSlots { get; }

	/// <summary>Per-channel Patch4 envelope-shaping word (DI+0x264).</summary>
	public AdgChannelPatch4EnvShapingSlots Patch4EnvShapingSlots { get; }

	/// <summary>Per-channel Patch4 volume-modulation word (DI+0x2AC).</summary>
	public AdgChannelPatch4VolumeModulationSlots Patch4VolumeModulationSlots { get; }

	/// <summary>Per-channel Patch4 current-operator-level word (DI+0x288).</summary>
	public AdgChannelPatch4CurrentOperatorLevels Patch4CurrentOperatorLevels { get; }

	/// <summary>Constructs every component in its zero state.</summary>
	public AdgDriverState() {
		WaitCounters = new AdgChannelWaitCounters();
		EventPointers = new AdgChannelEventPointers();
		InstrumentSlots = new AdgChannelInstrumentSlots();
		CurrentNotes = new AdgChannelCurrentNotes();
		PitchModeSlots = new AdgChannelPitchModeSlots();
		PitchTransposeSlots = new AdgChannelPitchTransposeSlots();
		PitchBendCounters = new AdgChannelPitchBendCounters();
		PitchAccumulators = new AdgChannelPitchAccumulators();
		VolumeModulationSlots = new AdgChannelVolumeModulationSlots();
		PatchTypeSlots = new AdgChannelPatchTypeSlots();
		LoopState = new AdgLoopState();
		SongPosition = new AdgSongPosition();
		TempoAccumulator = new AdgTempoAccumulator();
		MeasureClock = new AdgMeasureClock(LoopState);
		MasterVolume = new AdgMasterVolume();
		FadePatternState = new AdgFadePatternState();
		Dynamics = new AdgDynamics();
		TickDivider = new AdgTickDivider();
		ChannelStateScratch = new AdgChannelStateScratch();
		FadeScratchState = new AdgFadeScratchState();
		FrequencyWordCache = new AdgFrequencyWordCache();
		LoopSnapshotStore = new AdgLoopSnapshotStore();
		PitchAccumulatorSteps = new AdgChannelPitchAccumulatorSteps();
		PitchBendCounterReloads = new AdgChannelPitchBendCounterReloads();
		CurrentOperatorLevels = new AdgChannelCurrentOperatorLevels();
		TickEnabledCounter = new AdgTickEnabledCounter();
		SurroundMaskState = new AdgSurroundMaskState();
		TlShapingSlots = new AdgChannelTlShapingSlots();
		EnvShapingSlots = new AdgChannelEnvShapingSlots();
		ConnectionShapingSlots = new AdgChannelConnectionShapingSlots();
		ConnectionModulationSlots = new AdgChannelConnectionModulationSlots();
		Patch4TlShapingSlots = new AdgChannelPatch4TlShapingSlots();
		Patch4EnvShapingSlots = new AdgChannelPatch4EnvShapingSlots();
		Patch4VolumeModulationSlots = new AdgChannelPatch4VolumeModulationSlots();
		Patch4CurrentOperatorLevels = new AdgChannelPatch4CurrentOperatorLevels();
	}

	/// <summary>
	/// Resets every owned component to its zero state. Mirrors the
	/// driver-wide reinitialisation performed at <c>AdgEndOfTrack_0AF5</c>
	/// when the last active channel finishes (table clear + scheduler
	/// reset).
	/// </summary>
	public void Reset() {
		WaitCounters.Reset();
		EventPointers.Reset();
		InstrumentSlots.Reset();
		CurrentNotes.Reset();
		PitchModeSlots.Reset();
		PitchTransposeSlots.Reset();
		PitchBendCounters.Reset();
		PitchAccumulators.Reset();
		VolumeModulationSlots.Reset();
		PatchTypeSlots.Reset();
		LoopState.Reset();
		SongPosition.Reset();
		TempoAccumulator.Reset();
		MasterVolume.SetMaster(0);
		FadePatternState.Reset();
		Dynamics.Reset();
		TickDivider.Reset();
		ChannelStateScratch.Reset();
		FadeScratchState.Reset();
		FrequencyWordCache.Reset();
		LoopSnapshotStore.Reset();
		PitchAccumulatorSteps.Reset();
		PitchBendCounterReloads.Reset();
		CurrentOperatorLevels.Reset();
		TickEnabledCounter.Reset();
		SurroundMaskState.Reset();
		TlShapingSlots.Reset();
		EnvShapingSlots.Reset();
		ConnectionShapingSlots.Reset();
		ConnectionModulationSlots.Reset();
		Patch4TlShapingSlots.Reset();
		Patch4EnvShapingSlots.Reset();
		Patch4VolumeModulationSlots.Reset();
		Patch4CurrentOperatorLevels.Reset();
	}
}