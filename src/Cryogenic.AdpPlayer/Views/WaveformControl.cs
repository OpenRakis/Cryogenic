namespace Cryogenic.AdpPlayer.Views;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Threading;

using System;
using System.Globalization;

/// <summary>
/// High-fidelity stereo "neon oscilloscope" waveform control. Left channel
/// amplitude extends above the center line (cyan), right channel mirrors
/// below (warm orange). Each channel renders a gradient-filled area, a
/// glow pass (thick translucent), a sharp waveform line, and a slowly
/// decaying peak-hold envelope. Feed interleaved stereo float samples
/// via <see cref="PushSamples"/>.
/// </summary>
public sealed class WaveformControl : Control {
	private const int DisplaySamples = 800;
	private const float PeakDecay = 0.993f;
	private const double Amplitude = 0.92;

	private readonly float[] _leftBuffer = new float[DisplaySamples];
	private readonly float[] _rightBuffer = new float[DisplaySamples];
	private readonly float[] _leftPeak = new float[DisplaySamples];
	private readonly float[] _rightPeak = new float[DisplaySamples];
	private int _writeIndex;

	private static readonly IBrush BgBrush = new SolidColorBrush(Color.FromRgb(0x08, 0x0C, 0x10));
	private static readonly Pen GridPen = new(new SolidColorBrush(Color.FromArgb(18, 0x40, 0x60, 0x80)), 0.5);
	private static readonly Pen CenterPen = new(new SolidColorBrush(Color.FromArgb(30, 0xFF, 0xFF, 0xFF)), 0.5);

	private static readonly Pen LGlow = new(new SolidColorBrush(Color.FromArgb(40, 0x40, 0xC8, 0xFF)), 4.0);
	private static readonly Pen LLine = new(new SolidColorBrush(Color.FromRgb(0x40, 0xC8, 0xFF)), 1.2);
	private static readonly Pen LPeak = new(new SolidColorBrush(Color.FromArgb(90, 0x20, 0xA0, 0xE0)), 0.6);
	private static readonly IBrush LFill = new LinearGradientBrush {
		StartPoint = new RelativePoint(0, 1, RelativeUnit.Relative),
		EndPoint = new RelativePoint(0, 0, RelativeUnit.Relative),
		GradientStops = {
			new GradientStop(Color.FromArgb(0, 0x40, 0xC8, 0xFF), 0),
			new GradientStop(Color.FromArgb(50, 0x40, 0xC8, 0xFF), 0.3),
			new GradientStop(Color.FromArgb(90, 0x60, 0xE0, 0xFF), 1.0)
		}
	};
	private static readonly IBrush LLabel = new SolidColorBrush(Color.FromArgb(70, 0x40, 0xC8, 0xFF));

	private static readonly Pen RGlow = new(new SolidColorBrush(Color.FromArgb(40, 0xFF, 0x80, 0x40)), 4.0);
	private static readonly Pen RLine = new(new SolidColorBrush(Color.FromRgb(0xFF, 0x80, 0x40)), 1.2);
	private static readonly Pen RPeak = new(new SolidColorBrush(Color.FromArgb(90, 0xE0, 0x60, 0x20)), 0.6);
	private static readonly IBrush RFill = new LinearGradientBrush {
		StartPoint = new RelativePoint(0, 0, RelativeUnit.Relative),
		EndPoint = new RelativePoint(0, 1, RelativeUnit.Relative),
		GradientStops = {
			new GradientStop(Color.FromArgb(0, 0xFF, 0x80, 0x40), 0),
			new GradientStop(Color.FromArgb(50, 0xFF, 0x80, 0x40), 0.3),
			new GradientStop(Color.FromArgb(90, 0xFF, 0xA0, 0x60), 1.0)
		}
	};
	private static readonly IBrush RLabel = new SolidColorBrush(Color.FromArgb(70, 0xFF, 0x80, 0x40));

	/// <summary>
	/// Accepts interleaved stereo float samples (L, R, L, R, ...) and downsamples
	/// them into the peak ring buffer. Call from any thread; the control invalidates
	/// on the UI thread when enough data arrives.
	/// </summary>
	public void PushSamples(float[] interleaved, int sampleCount) {
		int frames = sampleCount / 2;
		if (frames == 0) {
			return;
		}

		int step = Math.Max(1, frames / 8);
		for (int i = 0; i < frames; i += step) {
			float peakL = 0;
			float peakR = 0;
			int end = Math.Min(i + step, frames);
			for (int j = i; j < end; j++) {
				int idx = j * 2;
				if (idx + 1 < sampleCount) {
					float aL = Math.Abs(interleaved[idx]);
					float aR = Math.Abs(interleaved[idx + 1]);
					if (aL > peakL) {
						peakL = aL;
					}
					if (aR > peakR) {
						peakR = aR;
					}
				}
			}

			int wi = _writeIndex % DisplaySamples;
			_leftBuffer[wi] = peakL;
			_rightBuffer[wi] = peakR;

			if (peakL > _leftPeak[wi]) {
				_leftPeak[wi] = peakL;
			} else {
				_leftPeak[wi] *= PeakDecay;
			}
			if (peakR > _rightPeak[wi]) {
				_rightPeak[wi] = peakR;
			} else {
				_rightPeak[wi] *= PeakDecay;
			}
			_writeIndex++;
		}

		Dispatcher.UIThread.Post(InvalidateVisual, DispatcherPriority.Render);
	}

	/// <inheritdoc />
	public override void Render(DrawingContext context) {
		base.Render(context);

		double w = Bounds.Width;
		double h = Bounds.Height;
		if (w < 4 || h < 4) {
			return;
		}

		double cy = h / 2;
		double xStep = w / DisplaySamples;
		int readStart = _writeIndex >= DisplaySamples ? _writeIndex - DisplaySamples : 0;

		context.DrawRectangle(BgBrush, null, new Rect(0, 0, w, h));

		double[] gridLevels = [0.25, 0.50, 0.75];
		foreach (double lv in gridLevels) {
			double yUp = cy - lv * cy;
			double yDn = cy + lv * cy;
			context.DrawLine(GridPen, new Point(0, yUp), new Point(w, yUp));
			context.DrawLine(GridPen, new Point(0, yDn), new Point(w, yDn));
		}

		StreamGeometry leftFillGeo = new();
		StreamGeometry rightFillGeo = new();
		StreamGeometry leftLineGeo = new();
		StreamGeometry rightLineGeo = new();
		StreamGeometry leftPeakGeo = new();
		StreamGeometry rightPeakGeo = new();
		bool anyLeft = false;
		bool anyRight = false;

		using (StreamGeometryContext lf = leftFillGeo.Open())
		using (StreamGeometryContext rf = rightFillGeo.Open())
		using (StreamGeometryContext ll = leftLineGeo.Open())
		using (StreamGeometryContext rl = rightLineGeo.Open())
		using (StreamGeometryContext lp = leftPeakGeo.Open())
		using (StreamGeometryContext rp = rightPeakGeo.Open()) {
			lf.BeginFigure(new Point(0, cy), true);
			rf.BeginFigure(new Point(0, cy), true);

			for (int i = 0; i < DisplaySamples; i++) {
				int ri = (readStart + i) % DisplaySamples;
				double x = i * xStep;

				double yL = cy - _leftBuffer[ri] * cy * Amplitude;
				double yR = cy + _rightBuffer[ri] * cy * Amplitude;
				yL = Math.Clamp(yL, 0, h);
				yR = Math.Clamp(yR, 0, h);

				lf.LineTo(new Point(x, yL));
				rf.LineTo(new Point(x, yR));

				if (i == 0) {
					ll.BeginFigure(new Point(x, yL), false);
					rl.BeginFigure(new Point(x, yR), false);
				} else {
					ll.LineTo(new Point(x, yL));
					rl.LineTo(new Point(x, yR));
				}

				double yLP = cy - _leftPeak[ri] * cy * Amplitude;
				double yRP = cy + _rightPeak[ri] * cy * Amplitude;
				if (i == 0) {
					lp.BeginFigure(new Point(x, yLP), false);
					rp.BeginFigure(new Point(x, yRP), false);
				} else {
					lp.LineTo(new Point(x, yLP));
					rp.LineTo(new Point(x, yRP));
				}

				if (_leftBuffer[ri] > 0.001f) {
					anyLeft = true;
				}
				if (_rightBuffer[ri] > 0.001f) {
					anyRight = true;
				}
			}

			lf.LineTo(new Point(w, cy));
			lf.EndFigure(true);
			rf.LineTo(new Point(w, cy));
			rf.EndFigure(true);
		}

		if (anyLeft) {
			context.DrawGeometry(LFill, null, leftFillGeo);
		}
		if (anyRight) {
			context.DrawGeometry(RFill, null, rightFillGeo);
		}

		if (anyLeft) {
			context.DrawGeometry(null, LGlow, leftLineGeo);
		}
		if (anyRight) {
			context.DrawGeometry(null, RGlow, rightLineGeo);
		}

		if (anyLeft) {
			context.DrawGeometry(null, LLine, leftLineGeo);
		}
		if (anyRight) {
			context.DrawGeometry(null, RLine, rightLineGeo);
		}

		if (anyLeft) {
			context.DrawGeometry(null, LPeak, leftPeakGeo);
		}
		if (anyRight) {
			context.DrawGeometry(null, RPeak, rightPeakGeo);
		}

		context.DrawLine(CenterPen, new Point(0, cy), new Point(w, cy));

		FormattedText lt = new("L", CultureInfo.InvariantCulture, FlowDirection.LeftToRight,
			new Typeface("Inter", FontStyle.Normal, FontWeight.Bold), 11, LLabel);
		FormattedText rt = new("R", CultureInfo.InvariantCulture, FlowDirection.LeftToRight,
			new Typeface("Inter", FontStyle.Normal, FontWeight.Bold), 11, RLabel);
		context.DrawText(lt, new Point(6, 4));
		context.DrawText(rt, new Point(6, h - 18));
	}
}