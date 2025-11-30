namespace Cryogenic.GameEngineWindow;

using System;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Threading;

using Cryogenic.GameEngineWindow.ViewModels;
using Cryogenic.GameEngineWindow.Views;

using Spice86.Core.Emulator.CPU.Registers;
using Spice86.Core.Emulator.Memory.ReaderWriter;

/// <summary>
/// Helper class to create and show the Dune Game State Window.
/// </summary>
public static class GameEngineWindowManager {
    private static DuneGameStateWindow? _window;
    private static DuneGameStateViewModel? _viewModel;

    /// <summary>
    /// Creates and shows the Dune Game State Window.
    /// </summary>
    /// <param name="memory">The memory reader/writer interface for accessing emulated memory.</param>
    /// <param name="segmentRegisters">The CPU segment registers.</param>
    /// <remarks>
    /// This method must be called from the UI thread or will dispatch to the UI thread.
    /// The window is created as a non-modal window that stays open alongside the main window.
    /// </remarks>
    public static void ShowWindow(IByteReaderWriter memory, SegmentRegisters segmentRegisters) {
        // Ensure we're on the UI thread
        if (!Dispatcher.UIThread.CheckAccess()) {
            Dispatcher.UIThread.Post(() => ShowWindow(memory, segmentRegisters));
            return;
        }

        // If window already exists and is still valid, just show it
        if (_window != null) {
            try {
                _window.Show();
                _window.Activate();
                return;
            } catch {
                // Window was closed, create a new one
                _viewModel?.Dispose();
                _window = null;
                _viewModel = null;
            }
        }

        // Create the ViewModel
        _viewModel = new DuneGameStateViewModel(memory, segmentRegisters);

        // Create the Window
        _window = new DuneGameStateWindow {
            DataContext = _viewModel
        };

        // Handle window closing
        _window.Closing += (sender, args) => {
            _viewModel?.Dispose();
            _viewModel = null;
            _window = null;
        };

        // Show the window
        _window.Show();
    }

    /// <summary>
    /// Closes the Dune Game State Window if it is open.
    /// </summary>
    public static void CloseWindow() {
        if (!Dispatcher.UIThread.CheckAccess()) {
            Dispatcher.UIThread.Post(CloseWindow);
            return;
        }

        _window?.Close();
        _viewModel?.Dispose();
        _window = null;
        _viewModel = null;
    }

    /// <summary>
    /// Gets whether the window is currently open.
    /// </summary>
    public static bool IsWindowOpen => _window != null;
}
