namespace Cryogenic.AdgPlayer.Ui;

using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Ui.Logging;
using Cryogenic.AdgPlayer.Ui.Services;
using Cryogenic.AdgPlayer.Ui.ViewModels;
using Cryogenic.AdgPlayer.Ui.Views;

using System;

/// <summary>
/// Avalonia application entry point for the Cryogenic ADG (AdLib Gold)
/// player UI. Builds the main window and wires its view model on
/// classic-desktop startup. Mirrors the layout of
/// <c>Cryogenic.AdpPlayer.App</c> but is otherwise independent.
/// </summary>
public sealed class App : Application {
	/// <summary>Loads the XAML resources for the application.</summary>
	public override void Initialize() {
		AvaloniaXamlLoader.Load(this);
	}

	/// <summary>
	/// Creates the main window, attaches its view model, and registers
	/// the disposal of the view model on application exit.
	/// </summary>
	public override void OnFrameworkInitializationCompleted() {
		if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
			MainWindow mainWindow = new MainWindow();
			IAdgSongCatalog catalog = ResolveCatalog();
			AdgDriverState driverState = new();
			Action<Action> dispatch = action => Dispatcher.UIThread.Post(action);
			MainWindowViewModel viewModel = new MainWindowViewModel(catalog, driverState, ObservableSerilogSink.Instance, dispatch);
			mainWindow.DataContext = viewModel;
			desktop.MainWindow = mainWindow;
		}

		base.OnFrameworkInitializationCompleted();
	}

	private static IAdgSongCatalog ResolveCatalog() {
		string defaultDir = @"C:\Users\noalm\source\repos\Cryogenic\doc\DUNECDVF\C\DUNECD\DUNE.DAT_";
		return new FileSystemAdgSongCatalog(defaultDir);
	}
}