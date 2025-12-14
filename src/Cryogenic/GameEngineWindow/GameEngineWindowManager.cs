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
        Dispatcher.UIThread.Post(() => {
            // Check window state first using the flag which is the source of truth
            if (_isWindowOpen) {
                _window?.Show();
                _window?.Activate();
                return;
            }

            // Clean up any existing viewmodel
            _viewModel?.Dispose();
            _viewModel = new DuneGameStateViewModel(memory, segmentRegisters, pauseHandler);
            _window = new DuneGameStateWindow {
                DataContext = _viewModel
            };

            // Use a proper handler method that can be unsubscribed
            _window.Closed += OnWindowClosed;

            _isWindowOpen = true;
            _window.Show();
        });
    }

    private static void OnWindowClosed(object? sender, EventArgs args) {
        _isWindowOpen = false;
        _viewModel?.Dispose();
        _viewModel = null;
        
        // Unsubscribe to prevent memory leaks
        if (_window != null) {
            _window.Closed -= OnWindowClosed;
        }
        _window = null;
    }

    public static void CloseWindow() {
        if (!Dispatcher.UIThread.CheckAccess()) {
            Dispatcher.UIThread.Post(CloseWindow);
            return;
        }

        _window?.Close();
    }

    public static bool IsWindowOpen => _isWindowOpen;
}
