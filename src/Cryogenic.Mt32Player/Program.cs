namespace Cryogenic.Mt32Player;

using Avalonia;
using Avalonia.ReactiveUI;

using System;

internal static class Program {
	public static AppBuilder BuildAvaloniaApp() {
		return AppBuilder.Configure<App>()
			.UsePlatformDetect()
			.LogToTrace()
			.WithInterFont()
			.UseReactiveUI();
	}

	[STAThread]
	public static void Main(string[] args) {
		BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
	}
}