namespace Cryogenic.AdgPlayer.Ui;

using Avalonia;

using Cryogenic.AdgPlayer.Ui.Logging;

using Serilog;

using System;

/// <summary>
/// Process entry point for the Cryogenic ADG player. Configures
/// Serilog (console + rolling file) and starts the Avalonia
/// classic-desktop lifetime.
/// </summary>
internal static class Program {
	/// <summary>STA-thread entry point.</summary>
	[STAThread]
	public static void Main(string[] args) {
		Log.Logger = new LoggerConfiguration()
			.MinimumLevel.Debug()
			.WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
			.WriteTo.File("logs/adgplayer-.log",
				rollingInterval: RollingInterval.Day,
				outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
			.WriteTo.Sink(ObservableSerilogSink.Instance)
			.CreateLogger();

		try {
			Log.Information("Cryogenic ADG Player starting");
			BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
		} catch (Exception ex) {
			Log.Fatal(ex, "Unhandled exception");
		} finally {
			Log.CloseAndFlush();
		}
	}

	/// <summary>Builds the Avalonia <see cref="AppBuilder"/> for the app.</summary>
	public static AppBuilder BuildAvaloniaApp() {
		return AppBuilder.Configure<App>()
			.UsePlatformDetect()
			.LogToTrace()
			.WithInterFont();
	}
}