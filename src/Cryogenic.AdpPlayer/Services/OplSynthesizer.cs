namespace Cryogenic.AdpPlayer.Services;

using NukedOPL3Sharp;

using Serilog;

using System;

/// <summary>
/// Wraps the NukedOPL3Sharp Opl3Chip to provide OPL2-compatible register
/// writes and stereo float sample generation at a fixed sample rate.
/// The chip runs in OPL2 mode (only registers 0x00–0xFF are used).
/// </summary>
public sealed class OplSynthesizer : IDisposable {
	private static readonly ILogger Logger = Log.ForContext<OplSynthesizer>();

	private readonly Opl3Chip _chip;
	private readonly uint _sampleRate;
	private short[] _tempBuffer = new short[4096];
	private bool _disposed;

	/// <summary>
	/// Called after each render batch with the interleaved stereo float buffer
	/// and the total sample count (frames × 2).
	/// </summary>
	public event Action<float[], int>? AudioSamplesRendered;

	/// <summary>
	/// Called before each render with the number of frames to generate.
	/// The engine hooks this to advance PIT timing.
	/// </summary>
	public Action<int>? OnBeforeRender;

	public OplSynthesizer(int sampleRate) {
		_sampleRate = (uint)sampleRate;
		_chip = new Opl3Chip();
		_chip.Reset(_sampleRate);
		Logger.Information("OPL3 chip initialized at {SampleRate} Hz", _sampleRate);
	}

	/// <summary>
	/// Writes a value to an OPL register (port 0x388/0x389 equivalent).
	/// Register address is 0x000–0x0FF for OPL2 bank 0.
	/// </summary>
	public void WriteRegister(ushort register, byte value) {
		_chip.WriteRegister(register, value);
	}

	/// <summary>
	/// Renders the specified number of stereo frames into the provided buffer.
	/// Buffer must be at least frames × 2 in length (interleaved L, R).
	/// Invokes OnBeforeRender before generating samples, then converts the
	/// OPL3 short output to float for Spice86.Audio compatibility.
	/// </summary>
	public void RenderFrames(float[] buffer, int frames) {
		OnBeforeRender?.Invoke(frames);

		int sampleCount = frames * 2;
		if (_tempBuffer.Length < sampleCount) {
			_tempBuffer = new short[sampleCount];
		}

		_chip.GenerateStream(_tempBuffer.AsSpan(0, sampleCount));

		for (int i = 0; i < sampleCount; i++) {
			buffer[i] = _tempBuffer[i] / 32768f;
		}

		AudioSamplesRendered?.Invoke(buffer, sampleCount);
	}

	/// <summary>
	/// Resets the OPL chip to silence.
	/// </summary>
	public void Reset() {
		_chip.Reset(_sampleRate);
	}

	public void Dispose() {
		if (_disposed) {
			return;
		}
		_disposed = true;
	}
}