namespace Cryogenic.AdgPlayer.Ui.Tests.ViewModels;

using Cryogenic.AdgPlayer.Ui.Tests.Support;
using Cryogenic.AdgPlayer.Ui.ViewModels;

using System;

using Xunit;

/// <summary>Unit tests for <see cref="AdgBrowserViewModel"/>.</summary>
public sealed class AdgBrowserViewModelTests {
	/// <summary>A fresh view model has an empty list and no selection.</summary>
	[Fact]
	public void Constructor_StartsEmptyAndUnselected() {
		// Arrange
		StubAdgSongCatalog catalog = new();
		AdgBrowserViewModel viewModel = new(catalog);

		// Act
		// Assert
		Assert.Empty(viewModel.Items);
		Assert.Equal(AdgBrowserViewModel.NoSelection, viewModel.SelectedIndex);
		Assert.False(viewModel.HasSelection);
	}

	/// <summary><c>Refresh</c> pulls every item from the catalog.</summary>
	[Fact]
	public void Refresh_PopulatesItemsFromCatalog() {
		// Arrange
		StubAdgSongCatalog catalog = new();
		catalog.Add(new AdgBrowserItem(@"C:\a\ARRAKIS_AGD.UNHSQ", "ARRAKIS_AGD.UNHSQ", 4096));
		catalog.Add(new AdgBrowserItem(@"C:\a\MORNING_AGD.UNHSQ", "MORNING_AGD.UNHSQ", 8192));
		AdgBrowserViewModel viewModel = new(catalog);

		// Act
		viewModel.Refresh();

		// Assert
		Assert.Equal(2, viewModel.Items.Count);
		Assert.Equal("ARRAKIS_AGD.UNHSQ", viewModel.Items[0].FileName);
		Assert.Equal(8192, viewModel.Items[1].SizeBytes);
	}

	/// <summary><c>Refresh</c> resets the selection.</summary>
	[Fact]
	public void Refresh_ResetsSelection() {
		// Arrange
		StubAdgSongCatalog catalog = new();
		catalog.Add(new AdgBrowserItem(@"C:\a\X.UNHSQ", "X.UNHSQ", 1));
		catalog.Add(new AdgBrowserItem(@"C:\a\Y.UNHSQ", "Y.UNHSQ", 2));
		AdgBrowserViewModel viewModel = new(catalog);
		viewModel.Refresh();
		viewModel.SelectedIndex = 1;

		// Act
		viewModel.Refresh();

		// Assert
		Assert.Equal(AdgBrowserViewModel.NoSelection, viewModel.SelectedIndex);
		Assert.False(viewModel.HasSelection);
	}

	/// <summary>Out-of-range selection clamps to <see cref="AdgBrowserViewModel.NoSelection"/>.</summary>
	[Theory]
	[InlineData(-5)]
	[InlineData(99)]
	public void SelectedIndex_OutOfRange_ClampsToNoSelection(int candidate) {
		// Arrange
		StubAdgSongCatalog catalog = new();
		catalog.Add(new AdgBrowserItem(@"C:\a\X.UNHSQ", "X.UNHSQ", 1));
		AdgBrowserViewModel viewModel = new(catalog);
		viewModel.Refresh();

		// Act
		viewModel.SelectedIndex = candidate;

		// Assert
		Assert.Equal(AdgBrowserViewModel.NoSelection, viewModel.SelectedIndex);
		Assert.False(viewModel.HasSelection);
	}

	/// <summary>A valid selection makes <see cref="AdgBrowserViewModel.HasSelection"/> true.</summary>
	[Fact]
	public void SelectedIndex_Valid_TogglesHasSelection() {
		// Arrange
		StubAdgSongCatalog catalog = new();
		catalog.Add(new AdgBrowserItem(@"C:\a\X.UNHSQ", "X.UNHSQ", 1));
		AdgBrowserViewModel viewModel = new(catalog);
		viewModel.Refresh();

		// Act
		viewModel.SelectedIndex = 0;

		// Assert
		Assert.Equal(0, viewModel.SelectedIndex);
		Assert.True(viewModel.HasSelection);
		Assert.Equal("X.UNHSQ", viewModel.GetSelectedItem().FileName);
	}

	/// <summary><c>GetSelectedItem</c> throws when nothing is selected.</summary>
	[Fact]
	public void GetSelectedItem_NoSelection_Throws() {
		// Arrange
		StubAdgSongCatalog catalog = new();
		AdgBrowserViewModel viewModel = new(catalog);

		// Act
		// Assert
		Assert.Throws<InvalidOperationException>(() => viewModel.GetSelectedItem());
	}

	/// <summary>Setting <see cref="AdgBrowserViewModel.SelectedIndex"/> raises change events.</summary>
	[Fact]
	public void SelectedIndex_Set_RaisesPropertyChanged() {
		// Arrange
		StubAdgSongCatalog catalog = new();
		catalog.Add(new AdgBrowserItem(@"C:\a\X.UNHSQ", "X.UNHSQ", 1));
		AdgBrowserViewModel viewModel = new(catalog);
		viewModel.Refresh();
		bool sawIndex = false;
		bool sawHas = false;
		viewModel.PropertyChanged += (_, e) => {
			if (e.PropertyName == nameof(AdgBrowserViewModel.SelectedIndex)) {
				sawIndex = true;
			}
			if (e.PropertyName == nameof(AdgBrowserViewModel.HasSelection)) {
				sawHas = true;
			}
		};

		// Act
		viewModel.SelectedIndex = 0;

		// Assert
		Assert.True(sawIndex);
		Assert.True(sawHas);
	}
}