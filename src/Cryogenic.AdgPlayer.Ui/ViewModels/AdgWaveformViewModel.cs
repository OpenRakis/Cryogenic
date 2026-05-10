namespace Cryogenic.AdgPlayer.Ui.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

using Cryogenic.AdgPlayer.Ui.Audio;

/// <summary>
/// View-model exposing the <see cref="WaveformPeakBuffer"/> shared
/// with the renderer. Owns the buffer instance so that the
/// playback host can push samples and the waveform control can
/// pull buckets from a single shared reference.
/// </summary>
public sealed class AdgWaveformViewModel : ObservableObject {
	/// <summary>Peak buffer fed by the playback host and read by the control.</summary>
	public WaveformPeakBuffer Buffer { get; }

	/// <summary>Builds a view-model with a default-sized peak buffer.</summary>
	public AdgWaveformViewModel() : this(new WaveformPeakBuffer()) {
	}

	/// <summary>Builds a view-model with the supplied peak buffer.</summary>
	public AdgWaveformViewModel(WaveformPeakBuffer buffer) {
		System.ArgumentNullException.ThrowIfNull(buffer);
		Buffer = buffer;
	}

	/// <summary>True when at least one channel currently shows audible signal.</summary>
	public bool HasSignal => Buffer.HasLeftSignal() || Buffer.HasRightSignal();

	/// <summary>
	/// Pushes interleaved float samples into the buffer and raises
	/// <see cref="HasSignal"/>'s <see cref="ObservableObject.PropertyChanged"/>.
	/// </summary>
	public void PushSamples(float[] interleaved, int sampleCount) {
		Buffer.PushSamples(interleaved, sampleCount);
		OnPropertyChanged(nameof(HasSignal));
	}

	/// <summary>Clears the buffer and notifies bindings.</summary>
	public void Reset() {
		Buffer.Reset();
		OnPropertyChanged(nameof(HasSignal));
	}
}