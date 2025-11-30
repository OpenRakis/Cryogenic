namespace Cryogenic.GameEngineWindow;

using System;

using Avalonia.Threading;

using Cryogenic.GameEngineWindow.ViewModels;
using Cryogenic.GameEngineWindow.Views;

using Spice86.Core.Emulator.CPU.Registers;
using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.VM;

public static class GameEngineWindowManager {
    private static DuneGameStateWindow? _window;
    private static DuneGameStateViewModel? _viewModel;
    private static bool _isWindowOpen;

    public static void ShowWindow(IByteReaderWriter memory, SegmentRegisters segmentRegisters, IPauseHandler? pauseHandler = null) {
        if (!Dispatcher.UIThread.CheckAccess()) {
            Dispatcher.UIThread.Post(() => ShowWindow(memory, segmentRegisters, pauseHandler));
            return;
        }

        if (_window != null && _isWindowOpen) {
            _window.Show();
            _window.Activate();
            return;
        }

        _viewModel?.Dispose();
        _viewModel = new DuneGameStateViewModel(memory, segmentRegisters, pauseHandler);
        _window = new DuneGameStateWindow {
            DataContext = _viewModel
        };

        _window.Closed += (sender, args) => {
            _isWindowOpen = false;
            _viewModel?.Dispose();
            _viewModel = null;
            _window = null;
        };

        _isWindowOpen = true;
        _window.Show();
    }

    public static void CloseWindow() {
        if (!Dispatcher.UIThread.CheckAccess()) {
            Dispatcher.UIThread.Post(CloseWindow);
            return;
        }

        _window?.Close();
        _viewModel?.Dispose();
        _window = null;
        _viewModel = null;
        _isWindowOpen = false;
    }

    public static bool IsWindowOpen => _isWindowOpen;
}
