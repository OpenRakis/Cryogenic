namespace Cryogenic.AdgPlayer.Ui.Tests.ViewModels;

using Cryogenic.AdgPlayer.Opl;
using Cryogenic.AdgPlayer.Ui.Opl;
using Cryogenic.AdgPlayer.Ui.ViewModels;

using System;

using Xunit;

/// <summary>Unit tests for <see cref="AdgOplCaptureViewModel"/>.</summary>
public sealed class AdgOplCaptureViewModelTests {
	/// <summary>The list starts empty.</summary>
	[Fact]
	public void Constructor_StartsEmpty() {
		// Arrange
		OplCaptureBus bus = new(new RecordingOplBus());
		AdgOplCaptureViewModel viewModel = new(bus, RunInline);

		// Act
		// Assert
		Assert.Empty(viewModel.Writes);
	}

	/// <summary>Each forwarded write produces a row carrying chip / register / value.</summary>
	[Fact]
	public void WriteRegister_AppendsRow() {
		// Arrange
		OplCaptureBus bus = new(new RecordingOplBus());
		AdgOplCaptureViewModel viewModel = new(bus, RunInline);

		// Act
		bus.WriteRegister(0, 0x40, 0x55);
		bus.WriteRegister(1, 0x05, 0x01);

		// Assert
		Assert.Equal(2, viewModel.Writes.Count);
		Assert.Equal(1, viewModel.Writes[0].Sequence);
		Assert.Equal(0, viewModel.Writes[0].Chip);
		Assert.Equal(0x40, viewModel.Writes[0].Register);
		Assert.Equal(0x55, viewModel.Writes[0].Value);
		Assert.Equal(2, viewModel.Writes[1].Sequence);
		Assert.Equal(1, viewModel.Writes[1].Chip);
	}

	/// <summary>Past <see cref="AdgOplCaptureViewModel.MaxDisplayedEntries"/>, the oldest rows drop.</summary>
	[Fact]
	public void WriteRegister_BeyondCap_EvictsOldest() {
		// Arrange
		OplCaptureBus bus = new(new RecordingOplBus());
		AdgOplCaptureViewModel viewModel = new(bus, RunInline);

		// Act
		for (int i = 0; i < AdgOplCaptureViewModel.MaxDisplayedEntries + 5; i++) {
			bus.WriteRegister(0, (byte)(i & 0xFF), (byte)i);
		}

		// Assert
		Assert.Equal(AdgOplCaptureViewModel.MaxDisplayedEntries, viewModel.Writes.Count);
		Assert.Equal(6, viewModel.Writes[0].Sequence);
	}

	/// <summary>Disposing detaches from the bus.</summary>
	[Fact]
	public void Dispose_StopsRecording() {
		// Arrange
		OplCaptureBus bus = new(new RecordingOplBus());
		AdgOplCaptureViewModel viewModel = new(bus, RunInline);

		// Act
		viewModel.Dispose();
		bus.WriteRegister(0, 0x40, 0x99);

		// Assert
		Assert.Empty(viewModel.Writes);
	}

	private static void RunInline(Action action) {
		action();
	}
}