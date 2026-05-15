namespace Cryogenic.Mt32Player;

using Avalonia;

using System;

internal static class Program {
	public static AppBuilder BuildAvaloniaApp() {
		return AppBuilder.Configure<App>()
			.UsePlatformDetect()
			.LogToTrace()
			.WithInterFont();
	}

	[STAThread]
	public static void Main(string[] args) {
		BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
	}
}