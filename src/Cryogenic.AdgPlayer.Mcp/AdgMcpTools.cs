namespace Cryogenic.AdgPlayer.Mcp;

using ModelContextProtocol.Server;

using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;

/// <summary>
/// MCP tool surface for driving a <see cref="AdgMcpSession"/> over
/// stdio. Tools cover song discovery, load/play/stop/tick, OPL
/// register inspection, and audio-sample retrieval (the same mixer
/// output a UI speaker would receive).
/// </summary>
[McpServerToolType]
public sealed class AdgMcpTools {
    private static readonly JsonSerializerOptions JsonOpts = new() {
        WriteIndented = false,
    };

    /// <summary>
    /// Enumerates HSQ/UNHSQ song files under
    /// <c>doc/DUNECDVF/C/DUNECD/DUNE.DAT_/</c> in the workspace root
    /// (auto-resolved by walking parents until the folder appears).
    /// </summary>
    [McpServerTool(Name = "list_songs")]
    [Description("Lists HSQ / UNHSQ song files bundled in doc/DUNECDVF/C/DUNECD/DUNE.DAT_/")]
    public static string ListSongs() {
        string? root = TryFindDatFolder();
        if (root is null) {
            return JsonSerializer.Serialize(new {
                root = (string?)null,
                files = Array.Empty<string>(),
                error = "DUNE.DAT_ folder not found",
            }, JsonOpts);
        }
        string[] files = Directory.EnumerateFiles(root)
            .Where(f => f.EndsWith(".HSQ", StringComparison.OrdinalIgnoreCase)
                || f.EndsWith(".UNHSQ", StringComparison.OrdinalIgnoreCase))
            .OrderBy(f => f, StringComparer.OrdinalIgnoreCase)
            .ToArray();
        return JsonSerializer.Serialize(new { root, files }, JsonOpts);
    }

    /// <summary>Loads a song file by absolute or workspace-relative path.</summary>
    [McpServerTool(Name = "load_song")]
    [Description("Loads a song from disk into the engine. Accepts absolute or workspace-relative path.")]
    public static string LoadSong(
        AdgMcpSession session,
        [Description("Path to .HSQ or .UNHSQ song file (absolute or relative).")] string path) {
        string resolved = ResolvePath(path);
        byte[] bytes = File.ReadAllBytes(resolved);
        session.Load(resolved, bytes);
        return JsonSerializer.Serialize(new {
            loaded = true,
            path = resolved,
            byteCount = bytes.Length,
        }, JsonOpts);
    }

    /// <summary>Starts playback.</summary>
    [McpServerTool(Name = "play")]
    [Description("Starts playback on the currently loaded song.")]
    public static string Play(AdgMcpSession session) {
        session.Play();
        return GetState(session);
    }

    /// <summary>Stops playback.</summary>
    [McpServerTool(Name = "stop")]
    [Description("Stops playback (engine remains loaded; can resume with play).")]
    public static string Stop(AdgMcpSession session) {
        session.Stop();
        return GetState(session);
    }

    /// <summary>Advances the engine by N ticks.</summary>
    [McpServerTool(Name = "tick")]
    [Description("Advances the engine by N driver ticks; returns ticks actually executed.")]
    public static string Tick(
        AdgMcpSession session,
        [Description("Number of ticks to advance.")] int count) {
        int executed = session.Tick(count);
        return JsonSerializer.Serialize(new {
            requested = count,
            executed,
            isPlaying = session.Engine.IsPlaying,
        }, JsonOpts);
    }

    /// <summary>Returns engine + session state.</summary>
    [McpServerTool(Name = "get_state")]
    [Description("Returns engine + session state (loaded, playing, song path, OPL write count, audio frames produced).")]
    public static string GetState(AdgMcpSession session) {
        lock (session.Gate) {
            return JsonSerializer.Serialize(new {
                hasSongLoaded = session.Engine.HasSongLoaded,
                isPlaying = session.Engine.IsPlaying,
                loadedSongPath = session.LoadedSongPath,
                totalOplWrites = session.TotalOplWrites,
                totalAudioFrames = session.TotalAudioFrames,
                nativeSampleRate = session.NativeSampleRate,
            }, JsonOpts);
        }
    }

    /// <summary>Returns recorded OPL writes since the supplied index.</summary>
    [McpServerTool(Name = "get_opl_writes")]
    [Description("Returns recorded OPL register writes with Index >= sinceIndex. Each entry: {index, chip, register, value}.")]
    public static string GetOplWrites(
        AdgMcpSession session,
        [Description("Return writes with index >= this value. 0 = from oldest in ring.")] int sinceIndex,
        [Description("Optional max entries to return (default 256, cap 4096).")] int maxEntries) {
        int cap = maxEntries <= 0 ? 256 : Math.Min(maxEntries, 4096);
        IReadOnlyList<OplWriteRecord> all = session.GetOplWrites(sinceIndex);
        int take = Math.Min(cap, all.Count);
        object[] payload = new object[take];
        for (int i = 0; i < take; i++) {
            OplWriteRecord w = all[i];
            payload[i] = new {
                index = w.Index,
                chip = w.Chip,
                register = w.Register,
                value = w.Value,
            };
        }
        return JsonSerializer.Serialize(new {
            total = session.TotalOplWrites,
            returned = take,
            truncated = take < all.Count,
            writes = payload,
        }, JsonOpts);
    }

    /// <summary>
    /// Returns the most recent N stereo frames of mixer output as a
    /// base64-encoded little-endian float32 buffer (interleaved
    /// L/R). N is clamped to ring capacity (~1 second @ 49716 Hz).
    /// </summary>
    [McpServerTool(Name = "get_audio_samples")]
    [Description("Returns the most recent N stereo frames from the mixer as base64-encoded float32 L/R interleaved samples in [-1,+1].")]
    public static string GetAudioSamples(
        AdgMcpSession session,
        [Description("Number of stereo frames to return. Clamped to ring capacity (~1 second).")] int frameCount) {
        float[] samples = session.GetRecentAudio(frameCount);
        byte[] bytes = new byte[samples.Length * sizeof(float)];
        Buffer.BlockCopy(samples, 0, bytes, 0, bytes.Length);
        string b64 = Convert.ToBase64String(bytes);
        return JsonSerializer.Serialize(new {
            sampleRate = session.NativeSampleRate,
            channels = 2,
            frames = samples.Length / 2,
            totalFramesProduced = session.TotalAudioFrames,
            format = "float32-le-interleaved",
            samplesBase64 = b64,
        }, JsonOpts);
    }

    /// <summary>
    /// Returns lightweight peak / RMS statistics of the most recent
    /// N frames without transferring raw audio. Use this to poll for
    /// activity cheaply before fetching samples.
    /// </summary>
    [McpServerTool(Name = "get_audio_levels")]
    [Description("Returns peak/RMS amplitude of the most recent N stereo frames without transferring raw audio.")]
    public static string GetAudioLevels(
        AdgMcpSession session,
        [Description("Number of recent stereo frames to summarize.")] int frameCount) {
        float[] samples = session.GetRecentAudio(frameCount);
        float peakL = 0f;
        float peakR = 0f;
        double sumL = 0d;
        double sumR = 0d;
        int frames = samples.Length / 2;
        for (int i = 0; i < frames; i++) {
            float l = samples[i * 2];
            float r = samples[(i * 2) + 1];
            float al = MathF.Abs(l);
            float ar = MathF.Abs(r);
            if (al > peakL) {
                peakL = al;
            }
            if (ar > peakR) {
                peakR = ar;
            }
            sumL += l * l;
            sumR += r * r;
        }
        double rmsL = frames > 0 ? Math.Sqrt(sumL / frames) : 0d;
        double rmsR = frames > 0 ? Math.Sqrt(sumR / frames) : 0d;
        return JsonSerializer.Serialize(new {
            frames,
            peakLeft = peakL,
            peakRight = peakR,
            rmsLeft = rmsL,
            rmsRight = rmsR,
            totalFramesProduced = session.TotalAudioFrames,
        }, JsonOpts);
    }

    /// <summary>
    /// Renders <paramref name="seconds"/> of audio to a 16-bit PCM
    /// WAV file under <c>artifacts/adg-compile/</c> (or
    /// <paramref name="outputPath"/> when supplied). Drives the
    /// engine forward by ticking it until the requested duration
    /// has been produced by the mixer.
    /// </summary>
    [McpServerTool(Name = "dump_wav")]
    [Description("Renders N seconds of player audio to a 16-bit PCM stereo WAV file. Ticks the engine while the mixer drains.")]
    public static string DumpWav(
        AdgMcpSession session,
        [Description("Duration in seconds to capture.")] double seconds,
        [Description("Output file path (absolute or workspace-relative). Empty = auto under artifacts/adg-compile/.")] string outputPath) {
        if (seconds <= 0d) {
            throw new ArgumentOutOfRangeException(nameof(seconds));
        }
        string resolved = ResolveOutputWavPath(outputPath, session);
        string? dir = Path.GetDirectoryName(resolved);
        if (!string.IsNullOrEmpty(dir)) {
            Directory.CreateDirectory(dir);
        }

        long targetFrames = (long)(seconds * session.NativeSampleRate);
        long startFrames = session.TotalAudioFrames;
        long cursor = startFrames;
        long framesWritten = 0L;
        long deadline = Environment.TickCount64 + (long)(seconds * 4000d) + 5000L;
        using (FileStream fs = new(resolved, FileMode.Create, FileAccess.Write))
        using (BinaryWriter bw = new(fs)) {
            WriteWavHeader(bw, sampleRate: session.NativeSampleRate, dataByteCount: (int)(targetFrames * 4));
            while (framesWritten < targetFrames) {
                lock (session.Gate) {
                    session.Tick(64);
                }
                System.Threading.Thread.Sleep(20);
                float[] chunk = session.DrainAudio(cursor, out cursor);
                long room = (targetFrames - framesWritten) * 2;
                int take = (int)Math.Min(chunk.Length, room);
                for (int i = 0; i < take; i++) {
                    float clamped = Math.Clamp(chunk[i], -1f, 1f);
                    short pcm = (short)Math.Round(clamped * 32767f);
                    bw.Write(pcm);
                }
                framesWritten += take / 2;
                if (Environment.TickCount64 > deadline) {
                    break;
                }
            }
            long actualDataBytes = framesWritten * 4;
            fs.Seek(4, SeekOrigin.Begin);
            bw.Write((int)(36 + actualDataBytes));
            fs.Seek(40, SeekOrigin.Begin);
            bw.Write((int)actualDataBytes);
        }
        return JsonSerializer.Serialize(new {
            path = resolved,
            sampleRate = session.NativeSampleRate,
            channels = 2,
            framesRequested = targetFrames,
            framesWritten,
        }, JsonOpts);
    }

    private static string ResolveOutputWavPath(string outputPath, AdgMcpSession session) {
        if (!string.IsNullOrWhiteSpace(outputPath)) {
            return Path.IsPathRooted(outputPath)
                ? outputPath
                : Path.GetFullPath(Path.Combine(TryFindWorkspaceRoot() ?? AppContext.BaseDirectory, outputPath));
        }
        string root = TryFindWorkspaceRoot() ?? AppContext.BaseDirectory;
        string songName = session.LoadedSongPath is null
            ? "no-song"
            : Path.GetFileNameWithoutExtension(session.LoadedSongPath);
        string stamp = DateTime.UtcNow.ToString("yyyyMMdd-HHmmss");
        return Path.Combine(root, "artifacts", "adg-compile", $"{songName}-{stamp}.wav");
    }

    private static void WriteWavPcm16(string path, float[] samples, int sampleRate) {
        using FileStream fs = new(path, FileMode.Create, FileAccess.Write);
        using BinaryWriter bw = new(fs);
        int byteCount = samples.Length * 2;
        WriteWavHeader(bw, sampleRate, byteCount);
        for (int i = 0; i < samples.Length; i++) {
            float clamped = Math.Clamp(samples[i], -1f, 1f);
            short pcm = (short)Math.Round(clamped * 32767f);
            bw.Write(pcm);
        }
    }

    private static void WriteWavHeader(BinaryWriter bw, int sampleRate, int dataByteCount) {
        bw.Write(System.Text.Encoding.ASCII.GetBytes("RIFF"));
        bw.Write(36 + dataByteCount);
        bw.Write(System.Text.Encoding.ASCII.GetBytes("WAVE"));
        bw.Write(System.Text.Encoding.ASCII.GetBytes("fmt "));
        bw.Write(16);
        bw.Write((short)1);
        bw.Write((short)2);
        bw.Write(sampleRate);
        bw.Write(sampleRate * 2 * 2);
        bw.Write((short)4);
        bw.Write((short)16);
        bw.Write(System.Text.Encoding.ASCII.GetBytes("data"));
        bw.Write(dataByteCount);
    }

    private static string ResolvePath(string path) {
        string? root = TryFindWorkspaceRoot();
        if (root is not null) {
            string candidate = Path.GetFullPath(Path.Combine(root, path));
            if (File.Exists(candidate)) {
                return candidate;
            }
        }
        return path;
    }

    private static string? TryFindWorkspaceRoot() {
    DirectoryInfo? dir = new(AppContext.BaseDirectory);
    while (dir is not null) {
        if (File.Exists(Path.Combine(dir.FullName, "src", "Cryogenic.sln"))) {
            return dir.FullName;
        }
        dir = dir.Parent;
    }
    return null;
}

private static string? TryFindDatFolder() {
    string? root = TryFindWorkspaceRoot();
    if (root is null) {
        return null;
    }
    string candidate = Path.Combine(root, "doc", "DUNECDVF", "C", "DUNECD", "DUNE.DAT_");
    return Directory.Exists(candidate) ? candidate : null;
}
}
