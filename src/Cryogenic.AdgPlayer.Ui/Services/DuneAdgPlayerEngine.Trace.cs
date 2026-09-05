namespace Cryogenic.AdgPlayer.Ui.Services;

using System;

using System.Collections.Generic;

/// <summary>
/// Headless register-trace capture for validating the standalone DNADG player against override traces.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
    /// <summary>
    /// Captures a headless trace of logical register writes and channel events for the loaded song.
    /// </summary>
    /// <param name="maxTicks">Maximum number of scheduler ticks to execute after the open-song phase.</param>
    /// <returns>The captured register and event trace.</returns>
    public RegisterTraceCapture CaptureRegisterTrace(int maxTicks) {
        if (maxTicks <= 0) {
            throw new ArgumentOutOfRangeException(nameof(maxTicks), maxTicks, "maxTicks must be positive.");
        }
        if (_songData.Length == 0) {
            throw new InvalidOperationException("Cannot capture a DNADG trace without a loaded song.");
        }

        List<RegisterTraceEntry> registerWrites = new List<RegisterTraceEntry>();
        List<ChannelTraceEntry> channelEvents = new List<ChannelTraceEntry>();

        void OnRegister(ushort register, byte value, long tick) {
            registerWrites.Add(new RegisterTraceEntry {
                Tick = tick,
                Register = register,
                Value = value
            });
        }

        void OnChannel(int channel, string eventName, string detail, long tick) {
            channelEvents.Add(new ChannelTraceEntry {
                Tick = tick,
                Channel = channel,
                EventName = eventName,
                Detail = detail
            });
        }

        lock (_lock) {
            if (_playing || _paused) {
                StopInternal();
            }

            OplRegisterWritten += OnRegister;
            ChannelEventDispatched += OnChannel;
            try {
                PreparePlaybackState();

                int ticksExecuted = 0;
                while (ticksExecuted < maxTicks && (_statusFlags & 0x80) != 0) {
                    _totalTickCount++;
                    TickInternal();
                    ticksExecuted++;
                }

                return new RegisterTraceCapture {
                    FormatVersion = "1.0",
                    TicksRequested = maxTicks,
                    TicksExecuted = ticksExecuted,
                    PlaybackStillActive = (_statusFlags & 0x80) != 0,
                    FinalMeasure = _measure,
                    FinalSubdivision = _subdivision,
                    RegisterWrites = registerWrites,
                    ChannelEvents = channelEvents
                };
            } finally {
                OplRegisterWritten -= OnRegister;
                ChannelEventDispatched -= OnChannel;
                AllNotesOff();
                _statusFlags = 0;
                _playing = false;
                _paused = false;
                _opl.Pause();
            }
        }
    }
}

/// <summary>
/// Serialized output of one headless DNADG register-trace capture.
/// </summary>
public sealed class RegisterTraceCapture {
    /// <summary>Trace format version.</summary>
    public string FormatVersion { get; set; } = "1.0";

    /// <summary>Maximum ticks requested for the capture.</summary>
    public int TicksRequested { get; set; }

    /// <summary>Ticks actually executed before stopping or reaching the cap.</summary>
    public int TicksExecuted { get; set; }

    /// <summary>True when playback was still active when the capture stopped.</summary>
    public bool PlaybackStillActive { get; set; }

    /// <summary>Measure reached at the end of capture.</summary>
    public ushort FinalMeasure { get; set; }

    /// <summary>Subdivision reached at the end of capture.</summary>
    public byte FinalSubdivision { get; set; }

    /// <summary>Logical register writes observed during capture.</summary>
    public List<RegisterTraceEntry> RegisterWrites { get; set; } = new List<RegisterTraceEntry>();

    /// <summary>High-level channel events observed during capture.</summary>
    public List<ChannelTraceEntry> ChannelEvents { get; set; } = new List<ChannelTraceEntry>();
}

/// <summary>
/// One logical register write captured from the standalone DNADG engine.
/// </summary>
public sealed class RegisterTraceEntry {
    /// <summary>Tick on which the write occurred.</summary>
    public long Tick { get; set; }

    /// <summary>Logical register identifier.</summary>
    public ushort Register { get; set; }

    /// <summary>Value written to the logical register.</summary>
    public byte Value { get; set; }
}

/// <summary>
/// One high-level channel event captured during a headless run.
/// </summary>
public sealed class ChannelTraceEntry {
    /// <summary>Tick on which the event occurred.</summary>
    public long Tick { get; set; }

    /// <summary>Logical DNADG channel index.</summary>
    public int Channel { get; set; }

    /// <summary>Event name emitted by the engine.</summary>
    public string EventName { get; set; } = string.Empty;

    /// <summary>Event detail payload emitted by the engine.</summary>
    public string Detail { get; set; } = string.Empty;
}