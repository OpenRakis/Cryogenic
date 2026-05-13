namespace Cryogenic.AdgPlayer.Mcp;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

/// <summary>
/// Stdio MCP server entry point. Registers a single shared
/// <see cref="AdgMcpSession"/> as a singleton so all tool
/// invocations from a connected MCP client target the same engine
/// + synthesizer + recorders.
/// </summary>
public static class Program {
	/// <summary>Builds and runs the MCP host.</summary>
	public static async Task Main(string[] args) {
		HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

		builder.Logging.AddConsole(options => {
			options.LogToStandardErrorThreshold = LogLevel.Trace;
		});

		builder.Services.AddSingleton<AdgMcpSession>();

		builder.Services
			.AddMcpServer()
			.WithStdioServerTransport()
			.WithTools<AdgMcpTools>();

		await builder.Build().RunAsync();
	}
}
