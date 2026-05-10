namespace Cryogenic.AdgPlayer.Ui.Views;

using Avalonia.Controls;
using Avalonia.Markup.Xaml;

/// <summary>
/// Code-behind for the ADG player main window. Loads the XAML
/// resource at construction; exposes no extra surface area beyond
/// <see cref="Window"/>.
/// </summary>
public sealed partial class MainWindow : Window {
	/// <summary>Initializes the main window and loads its XAML.</summary>
	public MainWindow() {
		AvaloniaXamlLoader.Load(this);
	}
}