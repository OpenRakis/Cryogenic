namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>Unit tests for <see cref="AdgDriverState"/>.</summary>
public sealed class AdgDriverStateTests {
	/// <summary>The aggregate exposes every per-channel sub-table.</summary>
	[Fact]
	public void Constructor_ExposesAllChannelTables() {
		// Arrange
		AdgDriverState state = new();

		// Act
		// Assert
		Assert.NotNull(state.WaitCounters);
		Assert.NotNull(state.EventPointers);
		Assert.NotNull(state.InstrumentSlots);
		Assert.NotNull(state.CurrentNotes);
		Assert.NotNull(state.PitchModeSlots);
		Assert.NotNull(state.PitchTransposeSlots);
		Assert.NotNull(state.PitchBendCounters);
		Assert.NotNull(state.PitchAccumulators);
		Assert.NotNull(state.VolumeModulationSlots);
		Assert.NotNull(state.PatchTypeSlots);
	}

	/// <summary>The aggregate exposes every singleton state cell.</summary>
	[Fact]
	public void Constructor_ExposesAllSingletons() {
		// Arrange
		AdgDriverState state = new();

		// Act
		// Assert
		Assert.NotNull(state.LoopState);
		Assert.NotNull(state.SongPosition);
		Assert.NotNull(state.TempoAccumulator);
		Assert.NotNull(state.MeasureClock);
		Assert.NotNull(state.MasterVolume);
		Assert.NotNull(state.FadePatternState);
		Assert.NotNull(state.Dynamics);
		Assert.NotNull(state.TickDivider);
	}

	/// <summary>The 18-channel constant matches every sub-table.</summary>
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		// Act
		// Assert
		Assert.Equal(18, AdgDriverState.ChannelCount);
		Assert.Equal(18, AdgChannelWaitCounters.ChannelCount);
		Assert.Equal(18, AdgChannelEventPointers.ChannelCount);
	}

	/// <summary><c>Reset</c> clears every per-channel slot and singleton.</summary>
	[Fact]
	public void Reset_ClearsEveryComponent() {
		// Arrange
		AdgDriverState state = new();
		state.InstrumentSlots.Set(0, 0x42);
		state.CurrentNotes.Set(1, 0x60);
		state.PitchTransposeSlots.Set(2, 0x05);
		state.PitchBendCounters.Set(3, 0x10);
		state.PitchAccumulators.Set(4, 0x40);
		state.VolumeModulationSlots.Set(5, 0xCAFE);
		state.PatchTypeSlots.Set(6, 0x04);
		state.PitchModeSlots.Set(7, 0x01);
		state.MasterVolume.SetMaster(0x55);
		state.FadePatternState.Set(0xAA);
		state.Dynamics.Set(0x80);
		state.TempoAccumulator.Add(0x1234);
		state.SongPosition.SetSongPointer(0x10);
		state.LoopState.SetMeasure(7);

		// Act
		state.Reset();

		// Assert
		for (int i = 0; i < AdgDriverState.ChannelCount; i++) {
			Assert.Equal(0, state.InstrumentSlots.Get(i));
			Assert.Equal(0, state.CurrentNotes.Get(i));
			Assert.Equal(0, state.PitchTransposeSlots.Get(i));
			Assert.Equal(0, state.PitchBendCounters.Get(i));
			Assert.Equal(0, state.PitchAccumulators.Get(i));
			Assert.Equal(0, state.VolumeModulationSlots.Get(i));
			Assert.Equal(0, state.PatchTypeSlots.Get(i));
			Assert.Equal(0, state.PitchModeSlots.Get(i));
			Assert.Equal((ushort)0, state.WaitCounters.Get(i));
			Assert.Equal((ushort)0, state.EventPointers.Get(i));
		}
		Assert.Equal(0, state.MasterVolume.Master);
		Assert.Equal(0, state.MasterVolume.Current);
		Assert.Equal(0, state.FadePatternState.Value);
		Assert.Equal(0, state.Dynamics.Value);
		Assert.Equal(0, state.TempoAccumulator.Value);
		Assert.Equal(0, state.SongPosition.SongPointer);
		Assert.Equal(0, state.LoopState.Measure);
	}
}