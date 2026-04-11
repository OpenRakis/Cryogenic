namespace Cryogenic;

using Serilog;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.Function;
using Spice86.Core.Emulator.Mcp;
using Spice86.Core.Emulator.ReverseEngineer;
using Spice86.Core.Emulator.VM;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Supplies C# override functions for the Dune CD (DNCDPRG.EXE) DOS program running in Spice86.
/// </summary>
/// <remarks>
/// This class implements <see cref="IOverrideSupplier"/> to provide custom C# implementations
/// that replace specific routines in the original DOS executable for improved performance,
/// debugging capabilities, and modern platform compatibility.
/// 
/// Example command line debug arguments: -e "C:\\Jeux\\ABWFR\\DUNE_CD\\C\\DNCDPRG.EXE" --UseCodeOverride true
/// </remarks>
public class DuneCdOverrideSupplier : IOverrideSupplier, IMcpToolSupplier {
	private static readonly ILogger Logger = Log.ForContext<DuneCdOverrideSupplier>();

	/// <summary>
	/// Generates function information mappings that tell Spice86 which addresses should be overridden
	/// with C# implementations.
	/// </summary>
	/// <param name="loggerService">Service for logging debug information during override execution.</param>
	/// <param name="configuration">Spice86 configuration containing runtime settings.</param>
	/// <param name="programStartAddress">The segment where the DOS program was loaded in memory.</param>
	/// <param name="machine">The emulated machine instance providing access to CPU, memory, and devices.</param>
	/// <returns>A dictionary mapping segmented addresses to their function information and override implementations.</returns>
	public IDictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(
		ILoggerService loggerService,
		Configuration configuration,
		ushort programStartAddress,
		Machine machine) {
		Logger.Information(
			"Generating override function information. ProgramStartAddress={ProgramStartAddressHex}, UseCodeOverride={UseCodeOverride}",
			$"0x{programStartAddress:X4}",
			configuration.UseCodeOverride);
		Dictionary<SegmentedAddress, FunctionInformation> res = new();
		CreateOverrides(loggerService, configuration, programStartAddress, machine, res);
		Logger.Information("Generated {FunctionCount} override function entries.", res.Count);
		return res;
	}

	/// <summary>
	/// Creates and registers all override functions by instantiating the Overrides class.
	/// </summary>
	/// <param name="loggerService">Service for logging debug information during override execution.</param>
	/// <param name="configuration">Spice86 configuration containing runtime settings.</param>
	/// <param name="programStartSegment">The segment where the DOS program was loaded in memory.</param>
	/// <param name="machine">The emulated machine instance providing access to CPU, memory, and devices.</param>
	/// <param name="res">The dictionary to populate with override function mappings.</param>
	private static void CreateOverrides(ILoggerService loggerService, Configuration configuration, ushort programStartSegment,
		Machine machine, Dictionary<SegmentedAddress, FunctionInformation> res) {
		Logger.Debug(
			"Creating Overrides instance. ProgramStartSegment={ProgramStartSegmentHex}, ExistingFunctionCount={ExistingFunctionCount}",
			$"0x{programStartSegment:X4}",
			res.Count);
#pragma warning disable S1848
		new Overrides.Overrides(res, programStartSegment, machine, loggerService, configuration);
#pragma warning restore S1848
		Logger.Debug("Overrides instance created. RegisteredFunctionCount={RegisteredFunctionCount}", res.Count);
	}

	/// <summary>
	/// Provides the assembly containing Cryogenic-specific MCP tools.
	/// Spice86 discovers tools from these assemblies and exposes them on the MCP endpoint.
	/// </summary>
	/// <returns>Assemblies that declare MCP tool methods.</returns>
	public IEnumerable<Assembly> GetMcpToolAssemblies() {
		Assembly toolsAssembly = typeof(CryogenicMcpTools).Assembly;
		Logger.Information("Supplying MCP tool assembly {AssemblyName}", toolsAssembly.GetName().Name ?? "unknown");
		return new[] { toolsAssembly };
	}

	/// <summary>
	/// Provides service instances available for MCP tool method injection.
	/// No service instances are currently required for Cryogenic tools.
	/// </summary>
	/// <returns>Service instances for MCP tool execution.</returns>
	public IEnumerable<object> GetMcpServices() {
		Logger.Debug("Supplying MCP services collection (empty).");
		return Array.Empty<object>();
	}
}