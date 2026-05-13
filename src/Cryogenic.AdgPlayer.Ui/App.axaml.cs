namespace Cryogenic.AdgPlayer.Ui;

using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using Cryogenic.AdgPlayer.Ui.ViewModels;
using Cryogenic.AdgPlayer.Ui.Views;

public sealed class App : Application {
	public override void Initialize() {
		AvaloniaXamlLoader.Load(this);
	}

	public override void OnFrameworkInitializationCompleted() {
		if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
			MainWindow mainWindow = new MainWindow();
			MainWindowViewModel viewModel = new MainWindowViewModel(mainWindow);
			mainWindow.DataContext = viewModel;
			desktop.Exit += (_, _) => viewModel.Dispose();
			desktop.MainWindow = mainWindow;
		}

		base.OnFrameworkInitializationCompleted();
	}
}