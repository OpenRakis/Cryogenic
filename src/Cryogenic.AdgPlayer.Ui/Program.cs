namespace Cryogenic.AdgPlayer.Ui;

using Avalonia;

using Cryogenic.AdgPlayer.Ui.Logging;

using Serilog;

using System;

internal static class Program {
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
			Log.Information("Cryogenic ADG Player starting (branding: AdLib Gold / OPL3Gold)");
			if (HeadlessRegisterTraceCommand.TryRun(args, out int exitCode)) {
				Environment.ExitCode = exitCode;
				return;
			}
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