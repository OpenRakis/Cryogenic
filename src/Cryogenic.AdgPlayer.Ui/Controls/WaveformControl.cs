namespace Cryogenic.AdgPlayer.Ui.Controls;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

using Cryogenic.AdgPlayer.Ui.Audio;

/// <summary>
/// Lightweight stereo waveform <see cref="Control"/> that renders a
/// <see cref="WaveformPeakBuffer"/> as two horizontal bands (left
/// channel on top, right on the bottom) with a slow-decay peak hold
/// envelope drawn behind the instantaneous peak. Painting is purely
/// derived from the buffer; refresh is driven by an external caller
/// that invalidates the visual when new samples are pushed.
/// </summary>
public sealed class WaveformControl : Control {
    private static readonly IBrush LeftBrush = new SolidColorBrush(Color.FromRgb(0x6B, 0xD4, 0xFF));
    private static readonly IBrush RightBrush = new SolidColorBrush(Color.FromRgb(0xFF, 0xC2, 0x6B));
    private static readonly IBrush PeakBrush = new SolidColorBrush(Color.FromArgb(0x60, 0xFF, 0xFF, 0xFF));
    private static readonly IBrush BackgroundBrush = new SolidColorBrush(Color.FromRgb(0x10, 0x14, 0x1A));

    /// <summary>Peak buffer rendered by this control. Setting it triggers a redraw.</summary>
    public static readonly StyledProperty<WaveformPeakBuffer?> BufferProperty =
        AvaloniaProperty.Register<WaveformControl, WaveformPeakBuffer?>(nameof(Buffer));

    /// <summary>Optional buffer to render. <c>null</c> renders an empty pane.</summary>
    public WaveformPeakBuffer? Buffer {
        get => GetValue(BufferProperty);
        set => SetValue(BufferProperty, value);
    }

    /// <summary>Builds the control and wires up redraw on buffer changes.</summary>
    public WaveformControl() {
        BufferProperty.Changed.AddClassHandler<WaveformControl>((c, _) => c.InvalidateVisual());
    }

    /// <inheritdoc />
    public override void Render(DrawingContext context) {
        Rect bounds = new(Bounds.Size);
        context.FillRectangle(BackgroundBrush, bounds);

        WaveformPeakBuffer? buffer = Buffer;
        if (buffer is null || bounds.Width <= 0 || bounds.Height <= 0) {
            return;
        }

        double midY = bounds.Height / 2.0;
        double leftHeight = midY;
        double rightHeight = bounds.Height - midY;
        int displaySamples = buffer.DisplaySamples;
        double pixelsPerBucket = bounds.Width / displaySamples;
        int start = buffer.ReadStart();

        for (int i = 0; i < displaySamples; i++) {
            int bucketIndex = (start + i) % displaySamples;
            WaveformBucket bucket = buffer.GetBucket(bucketIndex);
            double x = i * pixelsPerBucket;
            double width = System.Math.Max(1.0, pixelsPerBucket);

            double leftPeak = bucket.LeftPeak * leftHeight;
            double leftAmp = bucket.Left * leftHeight;
            context.FillRectangle(PeakBrush, new Rect(x, midY - leftPeak, width, leftPeak));
            context.FillRectangle(LeftBrush, new Rect(x, midY - leftAmp, width, leftAmp));

            double rightPeak = bucket.RightPeak * rightHeight;
            double rightAmp = bucket.Right * rightHeight;
            context.FillRectangle(PeakBrush, new Rect(x, midY, width, rightPeak));
            context.FillRectangle(RightBrush, new Rect(x, midY, width, rightAmp));
        }
    }

    /// <summary>
    /// Notifies the control that the underlying buffer changed.
    /// Used by the playback host on the UI thread to trigger a
    /// redraw without re-assigning the buffer reference.
    /// </summary>
    public void Refresh() {
        InvalidateVisual();
    }
}
