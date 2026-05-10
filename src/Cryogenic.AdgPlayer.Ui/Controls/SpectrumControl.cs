namespace Cryogenic.AdgPlayer.Ui.Controls;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

using Cryogenic.AdgPlayer.Ui.Audio;

/// <summary>
/// FFT spectrum control: renders the <see cref="SpectrumBuffer.Bands"/>
/// as vertical bars filling the bounds. Painting is purely derived
/// from the bound buffer; redraw is triggered externally via
/// <see cref="Refresh"/>.
/// </summary>
public sealed class SpectrumControl : Control {
    private static readonly IBrush BackgroundBrush = new SolidColorBrush(Color.FromRgb(0x10, 0x14, 0x1A));
    private static readonly IBrush BarBrush = new SolidColorBrush(Color.FromRgb(0xA8, 0xFF, 0x9E));

    /// <summary>Buffer rendered by this control. Setting it triggers a redraw.</summary>
    public static readonly StyledProperty<SpectrumBuffer?> BufferProperty =
        AvaloniaProperty.Register<SpectrumControl, SpectrumBuffer?>(nameof(Buffer));

    /// <summary>Optional spectrum buffer to render. <c>null</c> renders an empty pane.</summary>
    public SpectrumBuffer? Buffer {
        get => GetValue(BufferProperty);
        set => SetValue(BufferProperty, value);
    }

    /// <summary>Builds the control and wires up redraw on buffer changes.</summary>
    public SpectrumControl() {
        BufferProperty.Changed.AddClassHandler<SpectrumControl>((c, _) => c.InvalidateVisual());
    }

    /// <inheritdoc />
    public override void Render(DrawingContext context) {
        Rect bounds = new(Bounds.Size);
        context.FillRectangle(BackgroundBrush, bounds);

        SpectrumBuffer? buffer = Buffer;
        if (buffer is null || bounds.Width <= 0 || bounds.Height <= 0) {
            return;
        }

        int bandCount = buffer.BandCount;
        double pixelsPerBand = bounds.Width / bandCount;
        double barWidth = System.Math.Max(1.0, pixelsPerBand - 1.0);
        System.ReadOnlySpan<float> bands = buffer.Bands;
        for (int i = 0; i < bandCount; i++) {
            double x = i * pixelsPerBand;
            double height = bands[i] * bounds.Height;
            context.FillRectangle(BarBrush, new Rect(x, bounds.Height - height, barWidth, height));
        }
    }

    /// <summary>Notifies the control that the underlying buffer changed.</summary>
    public void Refresh() {
        InvalidateVisual();
    }
}
