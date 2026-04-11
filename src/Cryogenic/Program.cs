using Cryogenic;

using Serilog;
using Serilog.Events;

using Spice86.Core.CLI;

// Configure command-line arguments for Spice86 execution
List<string> newArgs = args.ToList();
//newArgs.AddRange("-m /mnt/c/mt32-rom-data -d true -e /mnt/c/Jeux/ABWFR/DUNE_CD/C/DNCDPRG.EXE -a \"MID330 SBP2227\" --UseCodeOverride true".Split(" "));

string logsDirectory = Path.Combine(AppContext.BaseDirectory, "logs");
Directory.CreateDirectory(logsDirectory);
string logPath = Path.Combine(logsDirectory, "cryogenic-node-.log");

Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Debug()
	.MinimumLevel.Override("Microsoft", LogEventLevel.Information)
	.Enrich.FromLogContext()
	.WriteTo.Console()
	.WriteTo.File(logPath, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 14, shared: true)
	.CreateLogger();

// Inject the custom interrupt handler segment address into the configuration
// This reserves segment 0x800 for BIOS/IRQ handlers, freeing 0xF000 for driver3
newArgs.Add($"--{nameof(Configuration.ProvidedAsmHandlersSegment)}={DriverLoadToolbox.INTERRUPT_HANDLER_SEGMENT}");

// Launch Spice86 with the DuneCdOverrideSupplier and verify the DNCDPRG.EXE checksum
// The SHA256 checksum ensures we're running against the expected version of the DOS executable
try {
	Log.Information("Starting Cryogenic node with {ArgCount} arguments. ProvidedAsmHandlersSegment={InterruptSegmentHex}",
		newArgs.Count,
		$"0x{DriverLoadToolbox.INTERRUPT_HANDLER_SEGMENT:X4}");
	Log.Debug("Effective arguments: {Args}", string.Join(" ", newArgs));

	global::Spice86.Program.RunWithOverrides<DuneCdOverrideSupplier>(
		newArgs.ToArray(),
		"5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9");

	Log.Information("Cryogenic node exited normally.");
} catch (Exception exception) {
	Log.Fatal(exception, "Cryogenic node terminated unexpectedly.");
	throw new InvalidOperationException("Cryogenic node terminated unexpectedly.", exception);
} finally {
	await Log.CloseAndFlushAsync().ConfigureAwait(false);
}

/// <summary>
/// Entry point class for the Cryogenic application.
/// </summary>
/// <remarks>
/// This partial class serves as the main entry point for running the Dune CD game
/// through Spice86 with custom C# overrides. The top-level statements handle
/// argument configuration and program launch.
/// </remarks>
public partial class Program {
}