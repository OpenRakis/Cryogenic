namespace Cryogenic.Mt32Player.Views;

using Avalonia.Controls;

using Cryogenic.Mt32Player.ViewModels;

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