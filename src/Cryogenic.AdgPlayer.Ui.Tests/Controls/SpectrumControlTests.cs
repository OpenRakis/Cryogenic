namespace Cryogenic.AdgPlayer.Ui.Tests.Controls;

using Avalonia.Headless.XUnit;

using Cryogenic.AdgPlayer.Ui.Audio;
using Cryogenic.AdgPlayer.Ui.Controls;

using Xunit;

/// <summary>Headless Avalonia tests for <see cref="SpectrumControl"/>.</summary>
public sealed class SpectrumControlTests {
	/// <summary>The control can be instantiated under the headless platform.</summary>
	[AvaloniaFact]
	public void Constructor_ProducesControl() {
		// Arrange / Act
		SpectrumControl control = new();

		// Assert
		Assert.NotNull(control);
		Assert.Null(control.Buffer);
	}

	/// <summary>Buffer round-trips through the styled property.</summary>
	[AvaloniaFact]
	public void Buffer_RoundTripsThroughStyledProperty() {
		// Arrange
		SpectrumControl control = new() { Width = 200, Height = 80 };
		SpectrumBuffer buffer = new(64, 8);

		// Act
		control.Buffer = buffer;

		// Assert
		Assert.Same(buffer, control.Buffer);
	}

	/// <summary>Refresh does not throw with a populated buffer.</summary>
	[AvaloniaFact]
	public void Refresh_DoesNotThrowWithBuffer() {
		// Arrange
		SpectrumControl control = new() { Width = 100, Height = 50 };
		SpectrumBuffer buffer = new(32, 4);
		float[] data = new float[64];
		for (int i = 0; i < data.Length; i++) {
			data[i] = 0.25f;
		}
		buffer.PushSamples(data, data.Length);
		buffer.Recompute();
		control.Buffer = buffer;

		// Act / Assert (does not throw)
		control.Refresh();
	}
}