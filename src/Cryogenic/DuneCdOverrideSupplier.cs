namespace Cryogenic;

using Avalonia.Threading;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.Function;
using Spice86.Core.Emulator.VM;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;
using Spice86.Shared.UI;

using System.Collections.Generic;

using UI.ViewModels;
using UI.Views;

/// <summary>
/// Example command line debug arguments: -e "C:\\Jeux\\ABWFR\\DUNE_CD\\C\\DNCDPRG.EXE" --UseCodeOverride true
/// </summary>
public class DuneCdOverrideSupplier : IOverrideSupplier {
    
    public IDictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(
        ILoggerService loggerService,
        Configuration configuration,
        ushort programStartSegment,
        Machine machine) {
        Dictionary<SegmentedAddress, FunctionInformation> res = new();
        CreateOverrides(loggerService, configuration, programStartSegment, machine, res);
        Dispatcher.UIThread.Post(() => {
            AdditionalWindow.Show(new LiveSaveGameWindow() { DataContext = new LiveSaveGameWindowViewModel(machine.Memory) });
        });
        return res;
    }

    private void CreateOverrides(ILoggerService loggerService, Configuration configuration, ushort programStartSegment, 
        Machine machine, Dictionary<SegmentedAddress, FunctionInformation> res) {
        new Overrides.Overrides(res, programStartSegment, machine, loggerService, configuration);
    }
}