namespace Cryogenic.UI.ViewModels;

using Spice86.ViewModels;

public partial class LiveSaveGameWindowViewModel : ViewModelBase {
    private readonly IMemory _memory;
    public LiveSaveGameWindowViewModel(IMemory memory) {
        _memory = memory;
    }
}