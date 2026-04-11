namespace Cryogenic.Mt32Player;

using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using Cryogenic.Mt32Player.ViewModels;
using Cryogenic.Mt32Player.Views;

using System;

public sealed class App : Application {
	public override void Initialize() {
		AvaloniaXamlLoader.Load(this);
	}

	public override void OnFrameworkInitializationCompleted() {
		if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
			MainWindow mainWindow = new MainWindow();
			MainWindowViewModel viewModel = new MainWindowViewModel(mainWindow);
			string? startupSongPath = TryGetOptionValue(desktop.Args, "song");
			if (!string.IsNullOrWhiteSpace(startupSongPath)) {
				viewModel.M32Path = startupSongPath;
				viewModel.Status = "M32 path loaded from command line (--song).";
			}
			mainWindow.DataContext = viewModel;
			desktop.Exit += (_, _) => viewModel.Dispose();
			desktop.MainWindow = mainWindow;
		}

		base.OnFrameworkInitializationCompleted();
	}

	private static string? TryGetOptionValue(string[]? args, string optionName) {
		if (args is null || args.Length == 0) {
			return null;
		}

		for (int i = 0; i < args.Length; i++) {
			string arg = args[i];
			if (arg.Equals($"--{optionName}", StringComparison.OrdinalIgnoreCase)
				|| arg.Equals($"-{optionName}", StringComparison.OrdinalIgnoreCase)
				|| (optionName == "song" && arg.Equals("-s", StringComparison.OrdinalIgnoreCase))) {
				if (i + 1 < args.Length) {
					return args[i + 1];
				}
				return null;
			}

			if (arg.StartsWith($"--{optionName}=", StringComparison.OrdinalIgnoreCase)) {
				return arg.Substring(optionName.Length + 3);
			}
		}

		return null;
	}
}