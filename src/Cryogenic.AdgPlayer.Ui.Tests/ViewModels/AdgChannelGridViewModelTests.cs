namespace Cryogenic.AdgPlayer.Ui.Tests.ViewModels;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Ui.ViewModels;

using Xunit;

/// <summary>Unit tests for <see cref="AdgChannelGridViewModel"/>.</summary>
public sealed class AdgChannelGridViewModelTests {
	/// <summary>The grid contains exactly one row per logical channel.</summary>
	[Fact]
	public void Constructor_BuildsOneRowPerChannel() {
		// Arrange
		AdgDriverState state = new();
		AdgChannelGridViewModel viewModel = new(state);

		// Act
		// Assert
		Assert.Equal(AdgDriverState.ChannelCount, viewModel.Rows.Count);
		for (int i = 0; i < AdgDriverState.ChannelCount; i++) {
			Assert.Equal(i, viewModel.Rows[i].Index);
		}
	}

	/// <summary>Initial rows mirror the zero-state of the driver tables.</summary>
	[Fact]
	public void Constructor_RowsMirrorEmptyDriverState() {
		// Arrange
		AdgDriverState state = new();
		AdgChannelGridViewModel viewModel = new(state);

		// Act
		// Assert
		foreach (AdgChannelRowViewModel row in viewModel.Rows) {
			Assert.Equal(0, row.CurrentNote);
			Assert.Equal(0, row.Instrument);
			Assert.Equal(0, row.PitchBendCounter);
			Assert.Equal(0, row.PitchAccumulator);
			Assert.False(row.IsFourOperator);
		}
	}

	/// <summary><c>Refresh</c> picks up driver mutations on every channel.</summary>
	[Fact]
	public void Refresh_PicksUpDriverStateMutations() {
		// Arrange
		AdgDriverState state = new();
		AdgChannelGridViewModel viewModel = new(state);
		state.CurrentNotes.Set(0, 0x4A);
		state.InstrumentSlots.Set(0, 0x07);
		state.PitchBendCounters.Set(0, 0x10);
		state.PitchAccumulators.Set(0, 0x40);
		state.PatchTypeSlots.Set(5, AdgChannelPatchTypeSlots.FourOperatorMarker);

		// Act
		viewModel.Refresh();

		// Assert
		AdgChannelRowViewModel row0 = viewModel.Rows[0];
		Assert.Equal(0x4A, row0.CurrentNote);
		Assert.Equal(0x07, row0.Instrument);
		Assert.Equal(0x10, row0.PitchBendCounter);
		Assert.Equal(0x40, row0.PitchAccumulator);
		Assert.False(row0.IsFourOperator);
		Assert.True(viewModel.Rows[5].IsFourOperator);
	}
}