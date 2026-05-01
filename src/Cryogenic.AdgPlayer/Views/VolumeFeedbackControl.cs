namespace Cryogenic.AdgPlayer.Views;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Threading;

using System;
using System.Globalization;

/// <summary>
/// Winamp-style animated volume feedback panel.
/// Renders stereo VU bars with peak hold and rolling loudness history.
/// Feed interleaved stereo float samples via <see cref="PushSamples"/>.
/// </summary>
public sealed class VolumeFeedbackControl : Control {
    private const int HistorySamples = 360;
    private const float PeakHoldDecay = 0.985f;
    private const float PeakRiseBias = 0.80f;

    private readonly float[] _leftHistory = new float[HistorySamples];
    private readonly float[] _rightHistory = new float[HistorySamples];
    private int _historyWriteIndex;

    private float _leftLevel;
    private float _rightLevel;
    private float _leftPeak;
    private float _rightPeak;

    private static readonly IBrush Bg = new LinearGradientBrush {
        StartPoint = new RelativePoint(0, 0, RelativeUnit.Relative),
        EndPoint = new RelativePoint(0, 1, RelativeUnit.Relative),
        GradientStops = {
            new GradientStop(Color.FromRgb(0x07, 0x11, 0x17), 0),
            new GradientStop(Color.FromRgb(0x0D, 0x1A, 0x24), 1)
        }
    };

    private static readonly IBrush MeterBg = new SolidColorBrush(Color.FromArgb(120, 0x0E, 0x15, 0x1D));
    private static readonly IBrush LabelBrush = new SolidColorBrush(Color.FromRgb(0xC9, 0xD1, 0xD9));
    private static readonly IBrush SecondaryBrush = new SolidColorBrush(Color.FromRgb(0x8B, 0x94, 0x9E));
    private static readonly Pen GuidePen = new(new SolidColorBrush(Color.FromArgb(40, 0x8B, 0x94, 0x9E)), 1);
    private static readonly Pen PeakPen = new(new SolidColorBrush(Color.FromRgb(0xFF, 0xF2, 0x8A)), 1.2);
    private static readonly Pen LeftHistoryPen = new(new SolidColorBrush(Color.FromArgb(180, 0x35, 0xBE, 0xFF)), 1.2);
    private static readonly Pen RightHistoryPen = new(new SolidColorBrush(Color.FromArgb(180, 0xFF, 0xA0, 0x55)), 1.2);

    /// <summary>
    /// Pushes interleaved stereo samples and updates meter state.
    /// </summary>
    public void PushSamples(float[] interleaved, int sampleCount) {
        int frames = sampleCount / 2;
        if (frames <= 0) {
            return;
        }

        double sumSqL = 0;
        double sumSqR = 0;
        float peakL = 0;
        float peakR = 0;

        for (int i = 0; i < sampleCount - 1; i += 2) {
            float l = Math.Abs(interleaved[i]);
            float r = Math.Abs(interleaved[i + 1]);
            if (l > peakL) {
                peakL = l;
            }
            if (r > peakR) {
                peakR = r;
            }
            sumSqL += l * l;
            sumSqR += r * r;
        }

        float rmsL = (float)Math.Sqrt(sumSqL / frames);
        float rmsR = (float)Math.Sqrt(sumSqR / frames);

        _leftLevel = MathF.Max(peakL * PeakRiseBias, rmsL);
        _rightLevel = MathF.Max(peakR * PeakRiseBias, rmsR);

        if (_leftLevel > _leftPeak) {
            _leftPeak = _leftLevel;
        } else {
            _leftPeak *= PeakHoldDecay;
        }
        if (_rightLevel > _rightPeak) {
            _rightPeak = _rightLevel;
        } else {
            _rightPeak *= PeakHoldDecay;
        }

        _leftPeak = Math.Clamp(_leftPeak, 0f, 1.2f);
        _rightPeak = Math.Clamp(_rightPeak, 0f, 1.2f);

        _leftHistory[_historyWriteIndex] = _leftLevel;
        _rightHistory[_historyWriteIndex] = _rightLevel;
        _historyWriteIndex = (_historyWriteIndex + 1) % HistorySamples;

        Dispatcher.UIThread.Post(InvalidateVisual, DispatcherPriority.Render);
    }

    public override void Render(DrawingContext context) {
        base.Render(context);

        double width = Bounds.Width;
        double height = Bounds.Height;
        if (width < 20 || height < 20) {
            return;
        }

        context.DrawRectangle(Bg, null, new Rect(0, 0, width, height));

        FormattedText title = new(
            "Volume Feedback",
            CultureInfo.InvariantCulture,
            FlowDirection.LeftToRight,
            new Typeface("Cascadia Mono", FontStyle.Normal, FontWeight.SemiBold),
            11,
            LabelBrush);
        context.DrawText(title, new Point(8, 6));

        double leftMargin = 46;
        double rightMargin = 8;
        double meterTop = 24;
        double meterHeight = 14;
        double meterGap = 8;
        double meterWidth = width - leftMargin - rightMargin;

        DrawMeter(context, leftMargin, meterTop, meterWidth, meterHeight, _leftLevel, _leftPeak, true);
        DrawMeter(context, leftMargin, meterTop + meterHeight + meterGap, meterWidth, meterHeight, _rightLevel, _rightPeak, false);

        FormattedText lLabel = new("L", CultureInfo.InvariantCulture, FlowDirection.LeftToRight, new Typeface("Cascadia Mono", FontStyle.Normal, FontWeight.Bold), 11, new SolidColorBrush(Color.FromRgb(0x58, 0xC8, 0xFF)));
        FormattedText rLabel = new("R", CultureInfo.InvariantCulture, FlowDirection.LeftToRight, new Typeface("Cascadia Mono", FontStyle.Normal, FontWeight.Bold), 11, new SolidColorBrush(Color.FromRgb(0xFF, 0x9A, 0x57)));
        context.DrawText(lLabel, new Point(18, meterTop + 1));
        context.DrawText(rLabel, new Point(18, meterTop + meterHeight + meterGap + 1));

        DrawDbScale(context, leftMargin, meterTop + meterHeight * 2 + meterGap + 2, meterWidth);
        DrawHistory(context, leftMargin, meterTop + meterHeight * 2 + meterGap + 18, meterWidth, height - (meterTop + meterHeight * 2 + meterGap + 24));
    }

    private static double LevelToDb(float level) {
        if (level <= 0.00001f) {
            return -60;
        }
        double db = 20.0 * Math.Log10(level);
        return Math.Clamp(db, -60, 3);
    }

    private static double DbToX(double db, double x, double width) {
        double normalized = (db + 60.0) / 63.0;
        return x + normalized * width;
    }

    private void DrawMeter(DrawingContext context, double x, double y, double width, double height, float level, float peak, bool isLeft) {
        context.DrawRectangle(MeterBg, null, new Rect(x, y, width, height));

        double db = LevelToDb(level);
        double fillX = DbToX(db, x, width);
        double fillWidth = Math.Max(0, fillX - x);

        LinearGradientBrush meterFill = new() {
            StartPoint = new RelativePoint(0, 0.5, RelativeUnit.Relative),
            EndPoint = new RelativePoint(1, 0.5, RelativeUnit.Relative),
            GradientStops = {
                new GradientStop(Color.FromRgb(0x2B, 0xD3, 0x7A), 0.0),
                new GradientStop(Color.FromRgb(0xC9, 0xD7, 0x4B), 0.72),
                new GradientStop(Color.FromRgb(0xFF, 0x5A, 0x5A), 1.0)
            }
        };
        if (!isLeft) {
            meterFill.Opacity = 0.92;
        }

        if (fillWidth > 0) {
            context.DrawRectangle(meterFill, null, new Rect(x, y, fillWidth, height));
        }

        double peakDb = LevelToDb(peak);
        double px = DbToX(peakDb, x, width);
        context.DrawLine(PeakPen, new Point(px, y - 1), new Point(px, y + height + 1));
    }

    private static void DrawDbScale(DrawingContext context, double x, double y, double width) {
        double[] ticks = [-60, -48, -36, -24, -12, -6, -3, 0, 3];
        for (int i = 0; i < ticks.Length; i++) {
            double db = ticks[i];
            double gx = DbToX(db, x, width);
            context.DrawLine(GuidePen, new Point(gx, y), new Point(gx, y + 10));

            FormattedText label = new(
                db > 0 ? $"+{db:0}" : $"{db:0}",
                CultureInfo.InvariantCulture,
                FlowDirection.LeftToRight,
                new Typeface("Cascadia Mono", FontStyle.Normal, FontWeight.Normal),
                10,
                SecondaryBrush);
            context.DrawText(label, new Point(gx - 10, y + 11));
        }
    }

    private void DrawHistory(DrawingContext context, double x, double y, double width, double height) {
        if (height < 10) {
            return;
        }

        context.DrawRectangle(new SolidColorBrush(Color.FromArgb(65, 0x08, 0x10, 0x16)), null, new Rect(x, y, width, height));

        StreamGeometry leftGeo = new();
        StreamGeometry rightGeo = new();
        double stepX = width / (HistorySamples - 1);

        using (StreamGeometryContext lctx = leftGeo.Open())
        using (StreamGeometryContext rctx = rightGeo.Open()) {
            for (int i = 0; i < HistorySamples; i++) {
                int idx = (_historyWriteIndex + i) % HistorySamples;
                double xx = x + i * stepX;
                double ly = y + height - (Math.Clamp(LevelToDb(_leftHistory[idx]), -60, 3) + 60) / 63 * height;
                double ry = y + height - (Math.Clamp(LevelToDb(_rightHistory[idx]), -60, 3) + 60) / 63 * height;

                if (i == 0) {
                    lctx.BeginFigure(new Point(xx, ly), false);
                    rctx.BeginFigure(new Point(xx, ry), false);
                } else {
                    lctx.LineTo(new Point(xx, ly));
                    rctx.LineTo(new Point(xx, ry));
                }
            }
        }

        context.DrawGeometry(null, LeftHistoryPen, leftGeo);
        context.DrawGeometry(null, RightHistoryPen, rightGeo);
    }
}
