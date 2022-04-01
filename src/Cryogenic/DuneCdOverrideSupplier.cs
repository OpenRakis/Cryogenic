namespace Cryogenic;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System.Collections.Generic;

/// <summary>
/// Example command line debug arguments: "commandLineArgs": "--Exe C:\\Jeux\\ABWFR\\DUNE_CD\\C\\DNCDPRG.EXE --CDrive=C:\\Jeux\\ABWFR\\DUNE_CD\\C --UseCodeOverride"
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
        new Overrides.Overrides(res, programStartSegment, machine).DefineOverrides();
        new CSharpOverrideHelper(res, machine).SetProvidedInterruptHandlersAsOverridden();
    }
}