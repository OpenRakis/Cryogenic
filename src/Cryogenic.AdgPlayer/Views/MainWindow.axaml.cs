namespace Cryogenic.AdgPlayer.Views;

using Avalonia.Controls;

using Cryogenic.AdgPlayer.ViewModels;

/// <summary>
/// Main window code-behind. Links the waveform control to the view model.
/// </summary>
public sealed partial class MainWindow : Window {
    /// <summary>
    /// Initializes the main window and registers the waveform control.
    /// </summary>
    public MainWindow() {
        InitializeComponent();
    }

    /// <inheritdoc />
    protected override void OnDataContextChanged(System.EventArgs e) {
        base.OnDataContextChanged(e);
        if (DataContext is MainWindowViewModel vm) {
            vm.RegisterWaveformControl(Waveform);
            vm.RegisterVolumeFeedbackControl(VolumeFeedback);
        }
    }
}