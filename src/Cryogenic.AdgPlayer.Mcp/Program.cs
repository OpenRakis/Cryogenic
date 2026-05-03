using Cryogenic.AdgPlayer.Mcp;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using ModelContextProtocol.Server;

using Serilog;

// Configure Serilog to stderr so MCP stdio transport on stdout isn't polluted.
Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Information()
	.WriteTo.Console(
		outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}",
		standardErrorFromLevel: Serilog.Events.LogEventLevel.Verbose)
	.CreateLogger();

try {
	Log.Information("Cryogenic ADG Player MCP Server starting");
	Log.Information("Engine uses full Spice86 AdLib Gold + OPL3 pipeline");

	IHost host = Host.CreateDefaultBuilder(args)
		.UseSerilog()
		.ConfigureLogging(logging => {
			logging.SetMinimumLevel(LogLevel.Warning);
		})
		.ConfigureServices(services => {
			services.AddSingleton<AdgMcpState>();
			services
				.AddMcpServer()
				.WithStdioServerTransport()
				.WithTools<AdgPlayerTools>();
		})
		.Build();

	await host.RunAsync();
} catch (Exception ex) {
	Log.Fatal(ex, "ADG MCP server terminated unexpectedly");
} finally {
	Log.CloseAndFlush();
}
