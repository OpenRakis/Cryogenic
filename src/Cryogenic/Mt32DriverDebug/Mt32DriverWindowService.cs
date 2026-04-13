namespace Cryogenic.Mt32DriverDebug;

using Avalonia.Threading;

using Cryogenic.Mt32DriverDebug.ViewModels;
using Cryogenic.Mt32DriverDebug.Views;

using Serilog;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Shared.UI;

/// <summary>
/// Service that manages the music driver debug window lifecycle.
/// Creates the window on the Avalonia UI thread using <see cref="AdditionalWindow.Show"/>
/// from Spice86.Shared so the window is tracked by the Spice86 desktop application lifetime.
/// </summary>
/// <remarks>
/// <para>
/// Call <see cref="ShowWindow"/> after the emulator Machine is available.
/// The window can be shown and re-shown at any time; <see cref="AdditionalWindow.Show"/>
/// activates an existing instance or creates a new one.
/// </para>
/// <para>
/// This service is always active regardless of whether the C# driver overrides
/// are enabled. It reads directly from emulator memory at the live driver segment.
/// </para>
/// </remarks>
public sealed class Mt32DriverWindowService {
	private static readonly ILogger Logger = Log.ForContext<Mt32DriverWindowService>();

	private readonly IMusicDriverState _driverState;
	private readonly GameAudioState _gameAudio;
	private Mt32DriverWindow? _window;
	private Mt32DriverWindowViewModel? _viewModel;

	/// <summary>
	/// Creates the service backed by emulator memory with automatic driver type detection.
	/// </summary>
	/// <param name="driverState">The driver state reader (DNMID or DNADP).</param>
	/// <param name="gameAudio">Game-level audio globals reader.</param>
	public Mt32DriverWindowService(IMusicDriverState driverState, GameAudioState gameAudio) {
		_driverState = driverState;
		_gameAudio = gameAudio;
	}

	/// <summary>
	/// Creates and shows the music driver debug window via Spice86's AdditionalWindow API.
	/// Thread-safe: dispatches window creation to the Avalonia UI thread.
	/// </summary>
	public void ShowWindow() {
		Logger.Information("Requesting {DriverName} driver debug window.", _driverState.DriverName);
		Dispatcher.UIThread.Post(() => {
			try {
				if (_window is not null) {
					AdditionalWindow.Show(_window);
					return;
				}
				_viewModel = new Mt32DriverWindowViewModel(_driverState, _gameAudio);
				_window = new Mt32DriverWindow {
					DataContext = _viewModel
				};
				_window.Closed += OnWindowClosed;
				AdditionalWindow.Show(_window);
				Logger.Information("{DriverName} driver debug window shown successfully.", _driverState.DriverName);
			} catch (System.Exception ex) {
				Logger.Error(ex, "Failed to show music driver debug window.");
			}
		});
	}

	/// <summary>
	/// Handles window closure so a new instance can be created on next <see cref="ShowWindow"/> call.
	/// </summary>
	private void OnWindowClosed(object? sender, System.EventArgs e) {
		if (_window is not null) {
			_window.Closed -= OnWindowClosed;
		}
		_window = null;
		_viewModel?.Dispose();
		_viewModel = null;
		Logger.Debug("Music driver debug window closed and references cleared.");
	}
}