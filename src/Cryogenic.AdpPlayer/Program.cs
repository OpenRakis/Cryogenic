namespace Cryogenic.AdpPlayer;

using Avalonia;

using Cryogenic.AdpPlayer.Logging;

using Serilog;

using System;

internal static class Program {
	[STAThread]
	public static void Main(string[] args) {
		Log.Logger = new LoggerConfiguration()
			.MinimumLevel.Debug()
			.WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
			.WriteTo.File("logs/adpplayer-.log",
				rollingInterval: RollingInterval.Day,
				outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
			.WriteTo.Sink(ObservableSerilogSink.Instance)
			.CreateLogger();

		try {
			Log.Information("Cryogenic ADP Player starting");
			BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
		} catch (Exception ex) {
			Log.Fatal(ex, "Unhandled exception");
		} finally {
			Log.CloseAndFlush();
		}
	}

	public static AppBuilder BuildAvaloniaApp() {
		return AppBuilder.Configure<App>()
			.UsePlatformDetect()
			.LogToTrace()
			.WithInterFont();
	}
}