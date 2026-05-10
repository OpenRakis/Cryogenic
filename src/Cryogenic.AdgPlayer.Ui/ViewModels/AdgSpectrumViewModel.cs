namespace Cryogenic.AdgPlayer.Ui.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

using Cryogenic.AdgPlayer.Ui.Audio;

/// <summary>
/// View-model exposing the <see cref="SpectrumBuffer"/> shared with
/// the <c>SpectrumControl</c>. Owns the buffer instance so that the
/// playback host can push samples while the control reads bands.
/// </summary>
public sealed class AdgSpectrumViewModel : ObservableObject {
	/// <summary>Spectrum buffer fed by the playback host and read by the control.</summary>
	public SpectrumBuffer Buffer { get; }

	/// <summary>Builds a view-model with a default-sized spectrum buffer.</summary>
	public AdgSpectrumViewModel() : this(new SpectrumBuffer()) {
	}

	/// <summary>Builds a view-model with the supplied spectrum buffer.</summary>
	public AdgSpectrumViewModel(SpectrumBuffer buffer) {
		System.ArgumentNullException.ThrowIfNull(buffer);
		Buffer = buffer;
	}

	/// <summary>True when at least one band shows audible energy.</summary>
	public bool HasSignal {
		get {
			System.ReadOnlySpan<float> bands = Buffer.Bands;
			for (int i = 0; i < bands.Length; i++) {
				if (bands[i] > 0.001f) {
					return true;
				}
			}
			return false;
		}
	}

	/// <summary>
	/// Pushes interleaved samples and recomputes the spectrum, then
	/// raises <see cref="HasSignal"/>'s change notification.
	/// </summary>
	public void PushAndRecompute(float[] interleaved, int sampleCount) {
		Buffer.PushSamples(interleaved, sampleCount);
		Buffer.Recompute();
		OnPropertyChanged(nameof(HasSignal));
	}

	/// <summary>Clears the buffer.</summary>
	public void Reset() {
		Buffer.Reset();
		OnPropertyChanged(nameof(HasSignal));
	}
}