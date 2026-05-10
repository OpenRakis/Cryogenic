namespace Cryogenic.AdgPlayer.Ui.Tests.Views;

using Avalonia.Headless.XUnit;

using Cryogenic.AdgPlayer.Ui.ViewModels;
using Cryogenic.AdgPlayer.Ui.Views;

using Xunit;

/// <summary>
/// Headless Avalonia tests for <see cref="MainWindow"/>. Runs against
/// the headless platform configured by
/// <see cref="TestAppBuilder"/>.
/// </summary>
public sealed class MainWindowTests {
	/// <summary>The window can be instantiated under the headless platform.</summary>
	[AvaloniaFact]
	public void Constructor_ProducesWindow() {
		// Arrange
		// Act
		MainWindow window = new();

		// Assert
		Assert.NotNull(window);
	}

	/// <summary>The window picks up the view model's title via binding.</summary>
	[AvaloniaFact]
	public void Title_BindsToViewModel() {
		// Arrange
		MainWindow window = new();
		MainWindowViewModel viewModel = new();
		window.DataContext = viewModel;
		window.Show();

		// Act
		viewModel.Title = "Bound";

		// Assert
		Assert.Equal("Bound", window.Title);
		window.Close();
	}
}