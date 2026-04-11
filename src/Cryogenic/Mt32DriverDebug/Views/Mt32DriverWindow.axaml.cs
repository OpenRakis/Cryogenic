namespace Cryogenic.Mt32DriverDebug.Views;

using Avalonia.Controls;
using Avalonia.Interactivity;

using Cryogenic.Mt32DriverDebug.ViewModels;

/// <summary>
/// Code-behind for the MT-32 driver debug window.
/// Manages DispatcherTimer lifecycle by hooking into visual tree attachment events.
/// </summary>
public partial class Mt32DriverWindow : Window {
	/// <summary>
	/// Initializes the window and registers lifecycle events.
	/// </summary>
	public Mt32DriverWindow() {
		InitializeComponent();
		Loaded += OnLoaded;
		Closing += OnClosing;
	}

	/// <summary>
	/// Starts polling when the window is attached to the visual tree and rendered.
	/// </summary>
	private void OnLoaded(object? sender, RoutedEventArgs e) {
		if (DataContext is Mt32DriverWindowViewModel vm) {
			vm.AddLog("Window attached to visual tree.");
			vm.StartPolling();
		}
	}

	/// <summary>
	/// Stops polling and disposes the ViewModel when the window is closing.
	/// </summary>
	private void OnClosing(object? sender, WindowClosingEventArgs e) {
		if (DataContext is Mt32DriverWindowViewModel vm) {
			vm.StopPolling();
			vm.Dispose();
		}
	}
}