namespace Cryogenic.AdgPlayer.Ui.Services;

using System;

/// <summary>
/// Observability surfaces for the DNADG engine: snapshots, trace events, and UI-facing diagnostics.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
    /// <summary>
    /// Fired on every OPL register write: (register, value, totalTickCount).
    /// Safe to subscribe from any thread; handler must marshal to UI thread as needed.
    /// </summary>
    public event Action<ushort, byte, long>? OplRegisterWritten;

    /// <summary>
    /// Fired on NoteOn, NoteOff, ProgramChange, EndOfTrack events:
    /// (channel, eventName, detail, totalTickCount).
    /// Safe to subscribe from any thread; handler must marshal to UI thread as needed.
    /// </summary>
    public event Action<int, string, string, long>? ChannelEventDispatched;

    /// <summary>
    /// Fired after each audio render batch with normalized float samples and frame count.
    /// Forwarded from OplSynthesizer.AudioSamplesRendered.
    /// Safe to subscribe from any thread; handler must marshal to UI thread as needed.
    /// </summary>
    public event Action<float[], int>? AudioSamplesRendered;

    /// <summary>
    /// Gets a snapshot of per-channel state for UI display.
    /// </summary>
    public ChannelSnapshot[] GetChannelSnapshots() {
        ChannelSnapshot[] snapshots = new ChannelSnapshot[ChannelCount];
        lock (_lock) {
            for (int i = 0; i < ChannelCount; i++) {
                snapshots[i] = new ChannelSnapshot {
                    Channel = i,
                    Wait = _channelWait[i],
                    Instrument = _channelInstrument[i],
                    Note = _channelCurrentNote[i],
                    Transpose = _channelPitchTranspose[i],
                    Frequency = _adgFrequencyWordTable[i],
                    PitchBendFlag = _channelPitchBendFlag[i],
                    IsActive = _channelEventPointer[i] != 0 && _channelWait[i] != 0xFFFF
                };
            }
        }
        return snapshots;
    }
}

/// <summary>
/// Snapshot of a single OPL channel's state for UI display.
/// </summary>
public sealed class ChannelSnapshot {
    public int Channel { get; set; }
    public ushort Wait { get; set; }
    public byte Instrument { get; set; }
    public byte Note { get; set; }
    public byte Transpose { get; set; }
    public ushort Frequency { get; set; }
    public ushort PitchBendFlag { get; set; }
    public bool IsActive { get; set; }

    /// <summary>
    /// Human-readable note name from MIDI-style note number.
    /// </summary>
    public string NoteName {
        get {
            if (Note == 0) {
                return "---";
            }
            string[] names = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            int octave = (Note / 12) - 1;
            int semitone = Note % 12;
            return $"{names[semitone]}{octave}";
        }
    }
}