namespace Cryogenic.AdgPlayer.Ui.Tests.Controls;

using Avalonia;
using Avalonia.Headless.XUnit;

using Cryogenic.AdgPlayer.Ui.Audio;
using Cryogenic.AdgPlayer.Ui.Controls;

using Xunit;

/// <summary>Headless Avalonia tests for <see cref="WaveformControl"/>.</summary>
public sealed class WaveformControlTests {
    /// <summary>The control can be instantiated under the headless platform.</summary>
    [AvaloniaFact]
    public void Constructor_ProducesControl() {
        // Arrange / Act
        WaveformControl control = new();

        // Assert
        Assert.NotNull(control);
        Assert.Null(control.Buffer);
    }

    /// <summary>Setting the <see cref="WaveformControl.Buffer"/> property is observable on the control.</summary>
    [AvaloniaFact]
    public void Buffer_RoundTripsThroughStyledProperty() {
        // Arrange
        WaveformControl control = new() { Width = 200, Height = 80 };
        WaveformPeakBuffer buffer = new(64);

        // Act
        control.Buffer = buffer;

        // Assert
        Assert.Same(buffer, control.Buffer);
    }

    /// <summary>Render does not throw when a buffer with samples is bound (no platform render here, just exercising the path).</summary>
    [AvaloniaFact]
    public void Refresh_DoesNotThrowWithBuffer() {
        // Arrange
        WaveformControl control = new() { Width = 100, Height = 50 };
        WaveformPeakBuffer buffer = new(32);
        buffer.PushSamples(new float[4] { 0.5f, -0.4f, 0.6f, -0.7f }, 4);
        control.Buffer = buffer;

        // Act / Assert (does not throw)
        control.Refresh();
    }
}
