namespace Cryogenic.AdgPlayer.Ui.Tests.ViewModels;

using Cryogenic.AdgPlayer.Ui.ViewModels;

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
}