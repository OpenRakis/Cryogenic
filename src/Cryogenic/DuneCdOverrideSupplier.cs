namespace Cryogenic;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.Function;
using Spice86.Core.Emulator.ReverseEngineer;
using Spice86.Core.Emulator.VM;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

using System.Collections.Generic;

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
public class DuneCdOverrideSupplier : IOverrideSupplier {
    
    /// <summary>
    /// Generates function information mappings that tell Spice86 which addresses should be overridden
    /// with C# implementations.
    /// </summary>
    /// <param name="loggerService">Service for logging debug information during override execution.</param>
    /// <param name="configuration">Spice86 configuration containing runtime settings.</param>
    /// <param name="programStartSegment">The segment where the DOS program was loaded in memory.</param>
    /// <param name="machine">The emulated machine instance providing access to CPU, memory, and devices.</param>
    /// <returns>A dictionary mapping segmented addresses to their function information and override implementations.</returns>
    public IDictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(
        ILoggerService loggerService,
        Configuration configuration,
        ushort programStartSegment,
        Machine machine) {
        Dictionary<SegmentedAddress, FunctionInformation> res = new();
        CreateOverrides(loggerService, configuration, programStartSegment, machine, res);
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
    private void CreateOverrides(ILoggerService loggerService, Configuration configuration, ushort programStartSegment, 
        Machine machine, Dictionary<SegmentedAddress, FunctionInformation> res) {
        new Overrides.Overrides(res, programStartSegment, machine, loggerService, configuration);
    }
}