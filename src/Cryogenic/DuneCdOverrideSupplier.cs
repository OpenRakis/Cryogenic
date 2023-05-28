namespace Cryogenic;

using Spice86.Core.Emulator.Function;
using Spice86.Core.Emulator.ReverseEngineer;
using Spice86.Core.Emulator.VM;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

using System.Collections.Generic;

/// <summary>
/// Example command line debug arguments: -e "C:\\Jeux\\ABWFR\\DUNE_CD\\C\\DNCDPRG.EXE" --UseCodeOverride true
/// </summary>
public class DuneCdOverrideSupplier : IOverrideSupplier {
    
    public Dictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(int programStartSegment,
        Machine machine) {
        Dictionary<SegmentedAddress, FunctionInformation> res = new();
        CreateOverrides((ushort)programStartSegment, machine, res);
        return res;
    }

    private void CreateOverrides(ushort programStartSegment, Machine machine,
        Dictionary<SegmentedAddress, FunctionInformation> res) {
        new Overrides.Overrides(res, programStartSegment, machine, (ILoggerService)Program.ServiceProvider!.GetService(typeof(ILoggerService))).DefineOverrides();
        new CSharpOverrideHelper(res, machine, (ILoggerService)Program.ServiceProvider!.GetService(typeof(ILoggerService))).SetProvidedInterruptHandlersAsOverridden();
    }
}