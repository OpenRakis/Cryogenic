namespace Cryogenic.AdgPlayer.Ui;

using Cryogenic.AdgPlayer.Ui.Services;

using Serilog;

using Spice86.Audio.Filters;
using Spice86.Core.Emulator.Devices.Sound;

using System;
using System.IO;
using System.Text.Json;

/// <summary>
/// Console-only DNADG register-trace runner for validating the standalone player without launching the UI.
/// </summary>
internal static class HeadlessRegisterTraceCommand {
    private static readonly string[] DefaultDuneDatCandidates = [
        @"C:\Users\noalm\source\repos\Cryogenic\doc\DUNECDVF\C\DUNE.DAT",
        @"C:\Users\noalm\source\repos\Cryogenic\doc\DUNECDVF\C\DUNECD\DUNE.DAT",
    ];

    /// <summary>
    /// Runs the command if the argument list requests a headless trace capture.
    /// </summary>
    public static bool TryRun(string[] args, out int exitCode) {
        exitCode = 0;
        string traceEntry = GetOptionValue(args, "--trace-entry");
        string traceFile = GetOptionValue(args, "--trace-file");
        if (string.IsNullOrWhiteSpace(traceEntry) && string.IsNullOrWhiteSpace(traceFile)) {
            return false;
        }

        string duneDatPath = GetOptionValue(args, "--dune-dat");
        string extractedFolder = GetOptionValue(args, "--extracted-dat-folder");
        string outputPath = GetOptionValue(args, "--out");
        string comparePath = GetOptionValue(args, "--compare");
        int maxTicks = ParseIntOption(args, "--ticks", 512);

        try {
            string songPath = ResolveSongPath(traceEntry, traceFile, duneDatPath, extractedFolder);
            byte[] songBytes = File.ReadAllBytes(songPath);

            using OplSynthesizer opl = new OplSynthesizer(AudioEngine.Dummy);
            using DuneAdgPlayerEngine engine = new DuneAdgPlayerEngine(opl);
            engine.LoadSong(songBytes);

            RegisterTraceCapture capture = engine.CaptureRegisterTrace(maxTicks);

            if (!string.IsNullOrWhiteSpace(outputPath)) {
                WriteCapture(outputPath, capture);
            }

            if (!string.IsNullOrWhiteSpace(comparePath)) {
                RegisterTraceCapture expected = ReadCapture(comparePath);
                exitCode = CompareCaptures(capture, expected);
            } else {
                Log.Information("Headless trace captured: song={Song}, ticks={Ticks}, writes={Writes}, events={Events}",
                    Path.GetFileName(songPath), capture.TicksExecuted, capture.RegisterWrites.Count, capture.ChannelEvents.Count);
            }
        } catch (Exception ex) {
            Log.Error(ex, "Headless trace capture failed");
            exitCode = 1;
        }

        return true;
    }

    private static string ResolveSongPath(string traceEntry, string traceFile, string duneDatPath, string extractedFolder) {
        if (!string.IsNullOrWhiteSpace(traceFile)) {
            return Path.GetFullPath(traceFile);
        }

        string resolvedExtractedFolder = extractedFolder;
        if (string.IsNullOrWhiteSpace(resolvedExtractedFolder)) {
            string resolvedDuneDat = string.IsNullOrWhiteSpace(duneDatPath) ? ResolveDefaultDuneDatPath() : duneDatPath;
            resolvedExtractedFolder = ResolveExtractedDuneDatFolder(resolvedDuneDat);
        }

        if (!Directory.Exists(resolvedExtractedFolder)) {
            throw new DirectoryNotFoundException($"DUNE.DAT_ extracted folder not found: {resolvedExtractedFolder}");
        }

        string songPath = Path.Combine(resolvedExtractedFolder, traceEntry);
        if (!File.Exists(songPath)) {
            throw new FileNotFoundException($"Could not locate DUNE.DAT_ entry '{traceEntry}' in '{resolvedExtractedFolder}'.", songPath);
        }

        return Path.GetFullPath(songPath);
    }

    private static string ResolveDefaultDuneDatPath() {
        for (int index = 0; index < DefaultDuneDatCandidates.Length; index++) {
            string candidate = DefaultDuneDatCandidates[index];
            if (File.Exists(candidate)) {
                return candidate;
            }
        }
        return DefaultDuneDatCandidates[0];
    }

    private static string ResolveExtractedDuneDatFolder(string duneDatPath) {
        string extractedNearDat = duneDatPath + "_";
        if (Directory.Exists(extractedNearDat)) {
            return extractedNearDat;
        }

        string workspaceExtracted = Path.Combine(Directory.GetCurrentDirectory(), "DUNE.DAT_");
        if (Directory.Exists(workspaceExtracted)) {
            return workspaceExtracted;
        }

        return extractedNearDat;
    }

    private static string GetOptionValue(string[] args, string optionName) {
        for (int index = 0; index < args.Length - 1; index++) {
            if (string.Equals(args[index], optionName, StringComparison.OrdinalIgnoreCase)) {
                return args[index + 1];
            }
        }
        return string.Empty;
    }

    private static int ParseIntOption(string[] args, string optionName, int defaultValue) {
        string value = GetOptionValue(args, optionName);
        if (string.IsNullOrWhiteSpace(value)) {
            return defaultValue;
        }
        return int.TryParse(value, out int parsed) ? parsed : defaultValue;
    }

    private static void WriteCapture(string outputPath, RegisterTraceCapture capture) {
        string fullOutputPath = Path.GetFullPath(outputPath);
        string directory = Path.GetDirectoryName(fullOutputPath) ?? string.Empty;
        if (!string.IsNullOrWhiteSpace(directory)) {
            Directory.CreateDirectory(directory);
        }

        JsonSerializerOptions options = new JsonSerializerOptions {
            WriteIndented = true
        };
        File.WriteAllText(fullOutputPath, JsonSerializer.Serialize(capture, options));
        Log.Information("Headless trace written to {OutputPath}", fullOutputPath);
    }

    private static RegisterTraceCapture ReadCapture(string path) {
        string json = File.ReadAllText(path);
        RegisterTraceCapture? capture = JsonSerializer.Deserialize<RegisterTraceCapture>(json);
        if (capture is null) {
            throw new InvalidDataException($"Unable to parse register trace file '{path}'.");
        }
        return capture;
    }

    private static int CompareCaptures(RegisterTraceCapture actual, RegisterTraceCapture expected) {
        int writeCount = Math.Min(actual.RegisterWrites.Count, expected.RegisterWrites.Count);
        for (int index = 0; index < writeCount; index++) {
            RegisterTraceEntry actualWrite = actual.RegisterWrites[index];
            RegisterTraceEntry expectedWrite = expected.RegisterWrites[index];
            if (actualWrite.Tick != expectedWrite.Tick
                || actualWrite.Register != expectedWrite.Register
                || actualWrite.Value != expectedWrite.Value) {
                Log.Error("Trace mismatch at write #{Index}: actual=(tick={ActualTick}, reg=0x{ActualReg:X3}, value=0x{ActualValue:X2}) expected=(tick={ExpectedTick}, reg=0x{ExpectedReg:X3}, value=0x{ExpectedValue:X2})",
                    index,
                    actualWrite.Tick, actualWrite.Register, actualWrite.Value,
                    expectedWrite.Tick, expectedWrite.Register, expectedWrite.Value);
                return 2;
            }
        }

        if (actual.RegisterWrites.Count != expected.RegisterWrites.Count) {
            Log.Error("Trace write count mismatch: actual={ActualCount}, expected={ExpectedCount}", actual.RegisterWrites.Count, expected.RegisterWrites.Count);
            return 2;
        }

        int eventCount = Math.Min(actual.ChannelEvents.Count, expected.ChannelEvents.Count);
        for (int index = 0; index < eventCount; index++) {
            ChannelTraceEntry actualEvent = actual.ChannelEvents[index];
            ChannelTraceEntry expectedEvent = expected.ChannelEvents[index];
            if (actualEvent.Tick != expectedEvent.Tick
                || actualEvent.Channel != expectedEvent.Channel
                || !string.Equals(actualEvent.EventName, expectedEvent.EventName, StringComparison.Ordinal)
                || !string.Equals(actualEvent.Detail, expectedEvent.Detail, StringComparison.Ordinal)) {
                Log.Error("Trace event mismatch at event #{Index}: actual=(tick={ActualTick}, ch={ActualChannel}, name={ActualName}, detail={ActualDetail}) expected=(tick={ExpectedTick}, ch={ExpectedChannel}, name={ExpectedName}, detail={ExpectedDetail})",
                    index,
                    actualEvent.Tick, actualEvent.Channel, actualEvent.EventName, actualEvent.Detail,
                    expectedEvent.Tick, expectedEvent.Channel, expectedEvent.EventName, expectedEvent.Detail);
                return 2;
            }
        }

        if (actual.ChannelEvents.Count != expected.ChannelEvents.Count) {
            Log.Error("Trace event count mismatch: actual={ActualCount}, expected={ExpectedCount}", actual.ChannelEvents.Count, expected.ChannelEvents.Count);
            return 2;
        }

        Log.Information("Headless trace comparison passed: writes={WriteCount}, events={EventCount}", actual.RegisterWrites.Count, actual.ChannelEvents.Count);
        return 0;
    }
}