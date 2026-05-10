namespace Cryogenic.AdgPlayer.Ui.Tests.ViewModels;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Song;
using Cryogenic.AdgPlayer.Ui.Logging;
using Cryogenic.AdgPlayer.Ui.Tests.Support;
using Cryogenic.AdgPlayer.Ui.ViewModels;

using System;
using System.IO;

using Xunit;

/// <summary>Unit tests for <see cref="MainWindowViewModel"/>.</summary>
public sealed class MainWindowViewModelTests {
	/// <summary>The default title constant matches the brand string.</summary>
	[Fact]
	public void DefaultTitleConst_IsBrandedString() {
		// Arrange
		// Act
		string title = MainWindowViewModel.DefaultTitleConst;

		// Assert
		Assert.Equal("Cryogenic ADG Player — AdLib Gold OPL3", title);
	}

	/// <summary>A fresh view model exposes the default title.</summary>
	[Fact]
	public void Constructor_ExposesDefaultTitle() {
		// Arrange
		MainWindowViewModel viewModel = new();

		// Act
		string title = viewModel.Title;

		// Assert
		Assert.Equal(MainWindowViewModel.DefaultTitleConst, title);
	}

	/// <summary>Setting <see cref="MainWindowViewModel.Title"/> raises a property change event.</summary>
	[Fact]
	public void Title_Set_RaisesPropertyChanged() {
		// Arrange
		MainWindowViewModel viewModel = new();
		string changed = string.Empty;
		viewModel.PropertyChanged += (_, e) => changed = e.PropertyName ?? string.Empty;

		// Act
		viewModel.Title = "Updated";

		// Assert
		Assert.Equal("Updated", viewModel.Title);
		Assert.Equal(nameof(MainWindowViewModel.Title), changed);
	}

	/// <summary>Selecting a browser item triggers <see cref="AdgPlayerSessionViewModel.LoadCommand"/>.</summary>
	[Fact]
	public void BrowserSelection_TriggersSessionLoad() {
		// Arrange — write a tiny ADG-shaped fixture and register it in the stub catalog.
		string path = Path.Combine(Path.GetTempPath(), $"adg_main_{Guid.NewGuid():N}.bin");
		byte[] bytes = new byte[0x100];
		bytes[0] = 0x00;
		bytes[1] = 0x01;
		int dataBase = AdgSongHeader.DataBase;
		bytes[dataBase + 0] = 0x10; // channel 0 offset = 0x0010 (relative)
		File.WriteAllBytes(path, bytes);
		StubAdgSongCatalog catalog = new();
		catalog.Add(new AdgBrowserItem(path, Path.GetFileName(path), bytes.Length));
		MainWindowViewModel viewModel = new(catalog, new AdgDriverState(), ObservableSerilogSink.Instance, static action => action());
		viewModel.Browser.Refresh();

		try {
			// Act
			viewModel.Browser.SelectedIndex = 0;

			// Assert
			Assert.True(viewModel.Session.Engine.HasSongLoaded);
		} finally {
			viewModel.Session.Dispose();
			File.Delete(path);
		}
	}
}