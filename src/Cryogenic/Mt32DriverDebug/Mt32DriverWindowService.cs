namespace Cryogenic.Mt32DriverDebug;

using Avalonia.Threading;

using Cryogenic.Mt32DriverDebug.ViewModels;
using Cryogenic.Mt32DriverDebug.Views;

using Serilog;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Shared.UI;

/// <summary>
/// Service that manages the MT-32 driver debug window lifecycle.
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
/// This service is always active regardless of whether the C# MT-32 driver overrides
/// are enabled. It reads directly from emulator memory at the live DNMID segment.
/// </para>
/// </remarks>
public sealed class Mt32DriverWindowService {
	private static readonly ILogger Logger = Log.ForContext<Mt32DriverWindowService>();

	private readonly IByteReaderWriter _memory;
	private readonly ushort _driverSegment;
	private Mt32DriverWindow? _window;
	private Mt32DriverWindowViewModel? _viewModel;

	/// <summary>
	/// Creates the service backed by emulator memory.
	/// </summary>
	/// <param name="memory">The emulated memory from Machine.Memory.</param>
	/// <param name="driverSegment">The segment where the DNMID driver is loaded (e.g. 0x5BAE).</param>
	public Mt32DriverWindowService(IByteReaderWriter memory, ushort driverSegment) {
		_memory = memory;
		_driverSegment = driverSegment;
	}

	/// <summary>
	/// Creates and shows the MT-32 driver debug window via Spice86's AdditionalWindow API.
	/// Thread-safe: dispatches window creation to the Avalonia UI thread.
	/// </summary>
	public void ShowWindow() {
		Logger.Information("Requesting MT-32 driver debug window. DriverSegment=0x{DriverSegment:X4}", _driverSegment);
		Dispatcher.UIThread.Post(() => {
			try {
				if (_window is not null) {
					AdditionalWindow.Show(_window);
					return;
				}
				_viewModel = new Mt32DriverWindowViewModel(_memory, _driverSegment);
				_window = new Mt32DriverWindow {
					DataContext = _viewModel
				};
				_window.Closed += OnWindowClosed;
				AdditionalWindow.Show(_window);
				Logger.Information("MT-32 driver debug window shown successfully.");
			} catch (System.Exception ex) {
				Logger.Error(ex, "Failed to show MT-32 driver debug window.");
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
		Logger.Debug("MT-32 driver debug window closed and references cleared.");
	}
}