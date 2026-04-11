namespace Cryogenic.AdpPlayer.Views;

using Avalonia.Controls;

using Cryogenic.AdpPlayer.ViewModels;

public partial class MainWindow : Window {
	public MainWindow() {
		InitializeComponent();
	}

	protected override void OnDataContextChanged(EventArgs e) {
		base.OnDataContextChanged(e);
		if (DataContext is MainWindowViewModel vm) {
			WaveformControl? waveform = this.FindControl<WaveformControl>("Waveform");
			if (waveform is not null) {
				vm.RegisterWaveformControl(waveform);
			}
		}
	}
}