namespace Cryogenic.AdgPlayer.Mcp;

using Cryogenic.AdgPlayer.Audio;
using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;
using Cryogenic.AdgPlayer.Services;

using System;
using System.Collections.Generic;

/// <summary>
/// Headless MCP-driven playback session. Wires the exact same
/// audio pipeline as <c>Cryogenic.AdgPlayer.Ui</c>:
/// <see cref="DuneAdgPlayerEngine"/> driving the full
/// <see cref="AdgOplSynthesizer"/> (NukedOPL3Sharp + Spice86
/// <c>SoftwareMixer</c> + master volume / filters) so MCP clients
/// see exactly what speakers hear. Samples emitted by the mixer's
/// <see cref="AdgOplSynthesizer.AudioSamplesRendered"/> event are
/// captured into a ring buffer and exposed over the wire alongside
/// the recorded OPL register stream.
/// </summary>
public sealed class AdgMcpSession : IDisposable {
    private readonly DuneAdgPlayerEngine _engine = new();
    private readonly AdgOplSynthesizer _synth = new();
    private readonly OplWriteRecorder _recorder;
    private readonly FanOutOplBus _bus;
    private readonly AdgChannelRoutingTable _routingTable;
    private readonly AdgFrequencyLookupTable _frequencyLookup;
    private readonly AudioSampleRingBuffer _audioRing = new(capacityFrames: 49716);
    private readonly object _gate = new();
    private string? _loadedSongPath;
    private bool _disposed;

    /// <summary>
    /// Per-session mutex. MCP servers may dispatch tool calls on
    /// parallel threads; tools serialize through this gate so a
    /// <c>play</c> request can never beat a still-running
    /// <c>load_song</c> to the engine.
    /// </summary>
    public object Gate => _gate;

    /// <summary>Builds the session and binds the engine to the fan-out bus.</summary>
    public AdgMcpSession() {
        _recorder = new OplWriteRecorder(capacity: 65536);
        _bus = new FanOutOplBus(new IOplBus[] { _synth, _recorder });
        _engine.SetOplBus(_bus);

        _routingTable = new AdgChannelRoutingTable();
        _frequencyLookup = AdgFrequencyLookupTable.CreateDefault();
        AdgPitchBendFractionsTable bendFractions = AdgPitchBendFractionsTable.CreateDefault();
        AdgPortamentoFractionsTable portamentoFractions = AdgPortamentoFractionsTable.CreateDefault();
        _engine.SetRoutingTable(_routingTable);
        _engine.SetFrequencyLookupTable(_frequencyLookup);
        _engine.SetPitchBendBody(new DefaultAdgPitchBendBody(
            _bus,
            _engine.State.FrequencyWordCache,
            _routingTable,
            _frequencyLookup,
            bendFractions,
            portamentoFractions,
            _engine.State.CurrentNotes,
            _engine.State.PitchModeSlots));

        _synth.AudioSamplesRendered += OnAudioSamplesRendered;
        _synth.Start();
    }

    /// <summary>The wrapped engine. Exposed for read-only inspection by tools.</summary>
    public DuneAdgPlayerEngine Engine => _engine;

    /// <summary>The wrapped OPL3 synthesizer (full SoftwareMixer pipeline).</summary>
    public AdgOplSynthesizer Synth => _synth;

    /// <summary>Loaded song path (null when no song is loaded).</summary>
    public string? LoadedSongPath => _loadedSongPath;

    /// <summary>Native OPL3 sample rate (49716 Hz, stereo interleaved).</summary>
    public int NativeSampleRate => _synth.NativeSampleRate;

    /// <summary>Total OPL writes recorded since session start.</summary>
    public int TotalOplWrites => _recorder.TotalCount;

    /// <summary>Total stereo audio frames produced by the mixer since session start.</summary>
    public long TotalAudioFrames => _audioRing.TotalFrames;

    /// <summary>Loads <paramref name="bytes"/> into the engine.</summary>
    public void Load(string path, byte[] bytes) {
        lock (_gate) {
            _engine.Load(bytes);
            _loadedSongPath = path;
        }
    }

    /// <summary>Starts playback.</summary>
    public void Play() {
        lock (_gate) {
            _engine.Play();
        }
    }

    /// <summary>Stops playback.</summary>
    public void Stop() {
        lock (_gate) {
            _engine.StopPlayback();
        }
    }

    /// <summary>Advances the engine up to <paramref name="tickCount"/> ticks; returns actual ticks executed.</summary>
    public int Tick(int tickCount) {
        if (tickCount < 0) {
            throw new ArgumentOutOfRangeException(nameof(tickCount));
        }
        lock (_gate) {
            int executed = 0;
            for (int i = 0; i < tickCount; i++) {
                if (!_engine.Tick()) {
                    break;
                }
                executed++;
            }
            return executed;
        }
    }

    /// <summary>
    /// Returns the most recent <paramref name="frameCount"/> stereo
    /// frames captured by the mixer (interleaved L/R floats in
    /// [-1, +1]). When fewer frames are available the result is the
    /// actual captured length; consult <see cref="TotalAudioFrames"/>
    /// to track production over time.
    /// </summary>
    public float[] GetRecentAudio(int frameCount) {
        return _audioRing.GetRecent(frameCount);
    }

    /// <summary>Returns recorded OPL writes since <paramref name="sinceIndex"/>; clamped to recorder capacity.</summary>
    public IReadOnlyList<OplWriteRecord> GetOplWrites(int sinceIndex) {
        return _recorder.GetSince(sinceIndex);
    }

    /// <inheritdoc />
    public void Dispose() {
        if (_disposed) {
            return;
        }
        _disposed = true;
        _synth.AudioSamplesRendered -= OnAudioSamplesRendered;
        _synth.Dispose();
    }

    private void OnAudioSamplesRendered(float[] buffer, int sampleCount) {
        _audioRing.Append(buffer, sampleCount);
    }
}
