namespace Cryogenic.AdgPlayer.Mcp;

using System;

/// <summary>
/// Stereo (interleaved L/R float) ring buffer for captured mixer
/// output. Producer (mixer callback thread) writes via
/// <see cref="Append"/>; MCP tools read the most recent N frames
/// via <see cref="GetRecent"/>. Threadsafe via coarse locking.
/// </summary>
public sealed class AudioSampleRingBuffer {
    private readonly float[] _buffer;
    private readonly int _capacityFrames;
    private readonly object _gate = new();
    private long _totalFrames;
    private int _head;

    /// <summary>Builds a ring sized to hold <paramref name="capacityFrames"/> stereo frames.</summary>
    public AudioSampleRingBuffer(int capacityFrames) {
        if (capacityFrames <= 0) {
            throw new ArgumentOutOfRangeException(nameof(capacityFrames));
        }
        _capacityFrames = capacityFrames;
        _buffer = new float[capacityFrames * 2];
    }

    /// <summary>Total stereo frames appended since construction.</summary>
    public long TotalFrames {
        get {
            lock (_gate) {
                return _totalFrames;
            }
        }
    }

    /// <summary>
    /// Appends <paramref name="sampleCount"/> floats from
    /// <paramref name="source"/> (must be a multiple of 2 — stereo
    /// interleaved). When sample count exceeds ring capacity the
    /// oldest samples are overwritten.
    /// </summary>
    public void Append(float[] source, int sampleCount) {
        ArgumentNullException.ThrowIfNull(source);
        if (sampleCount <= 0) {
            return;
        }
        if ((sampleCount & 1) != 0) {
            throw new ArgumentException("sampleCount must be even (stereo interleaved).", nameof(sampleCount));
        }
        lock (_gate) {
            int frameCount = sampleCount / 2;
            for (int i = 0; i < sampleCount; i++) {
                _buffer[_head] = source[i];
                _head = (_head + 1) % _buffer.Length;
            }
            _totalFrames += frameCount;
        }
    }

    /// <summary>
    /// Copies the most recent <paramref name="frameCount"/> stereo
    /// frames (clamped to capacity and to actual frames produced)
    /// into a fresh array. Output length equals
    /// <c>min(frameCount, available) * 2</c>.
    /// </summary>
    public float[] GetRecent(int frameCount) {
        if (frameCount <= 0) {
            return Array.Empty<float>();
        }
        lock (_gate) {
            int available = (int)Math.Min(_totalFrames, _capacityFrames);
            int wanted = Math.Min(frameCount, available);
            if (wanted <= 0) {
                return Array.Empty<float>();
            }
            float[] result = new float[wanted * 2];
            int startSample = (_head - (wanted * 2) + _buffer.Length) % _buffer.Length;
            for (int i = 0; i < result.Length; i++) {
                result[i] = _buffer[(startSample + i) % _buffer.Length];
            }
            return result;
        }
    }

    /// <summary>
    /// Copies all frames produced since the supplied global frame
    /// index (consult <see cref="TotalFrames"/>) into a fresh array,
    /// clamped to ring capacity. Returns the array and the new
    /// total-frames cursor via <paramref name="newCursor"/> so the
    /// caller can chain calls without missing samples (as long as
    /// drains happen faster than the ring wraps).
    /// </summary>
    public float[] DrainSince(long sinceFrame, out long newCursor) {
        lock (_gate) {
            newCursor = _totalFrames;
            long produced = _totalFrames - sinceFrame;
            if (produced <= 0L) {
                return Array.Empty<float>();
            }
            int wanted = (int)Math.Min(produced, _capacityFrames);
            float[] result = new float[wanted * 2];
            int startSample = (_head - (wanted * 2) + _buffer.Length) % _buffer.Length;
            for (int i = 0; i < result.Length; i++) {
                result[i] = _buffer[(startSample + i) % _buffer.Length];
            }
            return result;
        }
    }
}
