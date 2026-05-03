namespace Cryogenic.AdgPlayer.Mcp;

using Cryogenic.AdgPlayer.Services;

using ModelContextProtocol.Server;

using Serilog;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json;

/// <summary>
/// MCP tool definitions for inspecting and controlling the DNADG (AdLib Gold) standalone player.
/// All tools operate on the shared <see cref="AdgMcpState"/> singleton.
/// Use these tools to validate the reimplemented <see cref="DuneAdgPlayerEngine"/> against
/// the original driver behavior by loading the bundled HSQ music files and observing
/// OPL register writes, channel events, and playback state.
/// </summary>
[McpServerToolType]
public sealed class AdgPlayerTools {
	private static readonly ILogger Logger = Log.ForContext<AdgPlayerTools>();

	private static readonly string[] DefaultSearchDirs = [
		Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "doc", "DUNECDVF", "C", "DUNECD", "DUNE.DAT_"),
		@"C:\Users\noalm\source\repos\Cryogenic\doc\DUNECDVF\C\DUNECD\DUNE.DAT_",
		@"C:\Jeux\DUNE"
	];

	private readonly AdgMcpState _state;

	/// <summary>Creates the tool set bound to the given session state.</summary>
	public AdgPlayerTools(AdgMcpState state) {
		_state = state;
	}

	/// <summary>
	/// Lists the ADG and HSQ music files available in the default search directories or a
	/// caller-specified directory. Use the returned paths with <c>adg_load</c>.
	/// </summary>
	[McpServerTool, Description("List ADG and HSQ music files available for playback. Searches the bundled doc/DUNECDVF directory and common install locations.")]
	public string AdgListSongs(
		[Description("Optional directory path to search. If omitted the built-in search paths are used.")]
		string? directory = null) {
		List<string> searchDirs = directory is not null
			? [directory]
			: [..DefaultSearchDirs];

		List<string> found = new List<string>();
		foreach (string dir in searchDirs) {
			string expanded = dir;
			if (!Directory.Exists(expanded)) {
				continue;
			}
			foreach (string file in Directory.GetFiles(expanded, "*", SearchOption.TopDirectoryOnly)) {
				string ext = Path.GetExtension(file).ToUpperInvariant();
				if (ext is ".HSQ" or ".ADG" or ".AGD") {
					found.Add(file);
				}
			}
		}

		if (found.Count == 0) {
			return "No ADG/HSQ files found. Ensure the repo submodule contains doc/DUNECDVF/C/DUNECD/DUNE.DAT_/ with ARRAKIS_AGD.HSQ and MORNING.HSQ.";
		}

		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"Found {found.Count} music file(s):");
		foreach (string path in found) {
			FileInfo fi = new FileInfo(path);
			sb.AppendLine($"  {path}  ({fi.Length} bytes)");
		}
		return sb.ToString();
	}

	/// <summary>
	/// Loads an ADG or HSQ file into the engine. HSQ files are decompressed automatically
	/// using the same algorithm as the original DNADG driver. Call this before
	/// <c>adg_play</c> or <c>adg_tick</c>.
	/// </summary>
	[McpServerTool, Description("Load an ADG or HSQ music file into the engine. HSQ decompression is automatic. Must be called before adg_play or adg_tick.")]
	public string AdgLoad(
		[Description("Absolute path to the .HSQ or .ADG file to load.")]
		string filePath) {
		if (string.IsNullOrWhiteSpace(filePath)) {
			return "Error: filePath is required.";
		}
		if (!File.Exists(filePath)) {
			return $"Error: file not found: {filePath}";
		}

		try {
			byte[] raw = File.ReadAllBytes(filePath);
			_state.LoadSong(filePath, raw);
			SongHeaderInfo? header = _state.Engine.HeaderInfo;
			if (header is null) {
				return $"Loaded {Path.GetFileName(filePath)} but no valid ADG header was detected.";
			}
			return FormatHeaderInfo(filePath, header);
		} catch (IOException ex) {
			Logger.Error(ex, "Failed to load {Path}", filePath);
			return $"IO error loading file: {ex.Message}";
		}
	}

	/// <summary>
	/// Starts audio playback. The engine drives OPL register writes through the AdLib Gold
	/// pipeline at the native PIT rate. Subscribe to events or call <c>adg_opl_log</c>
	/// after a short delay to capture the initialisation writes.
	/// </summary>
	[McpServerTool, Description("Start playback of the currently loaded song. OPL writes flow through the AdLib Gold pipeline.")]
	public string AdgPlay() {
		if (string.IsNullOrEmpty(_state.LoadedPath)) {
			return "Error: no song loaded. Call adg_load first.";
		}
		try {
			_state.Engine.Play();
			return $"Playback started: {Path.GetFileName(_state.LoadedPath)}";
		} catch (InvalidOperationException ex) {
			return $"Cannot play: {ex.Message}";
		}
	}

	/// <summary>Pauses audio playback while preserving song position.</summary>
	[McpServerTool, Description("Pause playback. Song position is preserved so adg_play will resume from the same point.")]
	public string AdgPause() {
		_state.Engine.Pause();
		return "Paused.";
	}

	/// <summary>Stops playback and resets the song position to the beginning.</summary>
	[McpServerTool, Description("Stop playback and reset position to the beginning.")]
	public string AdgStop() {
		_state.Engine.Stop();
		return "Stopped.";
	}

	/// <summary>
	/// Advances the engine by a specified number of raw PIT ticks without audio output.
	/// Each tick corresponds to one PIT interrupt at the configured reload rate (~181 Hz).
	/// Use this to drive the engine step-by-step for precise inspection.
	/// Requires a loaded song and the engine in the playing state (call <c>adg_play</c> first).
	/// </summary>
	[McpServerTool, Description("Advance the engine by N raw PIT ticks without waiting for audio callbacks. Use after adg_play for step-by-step inspection. Each tick ≈ 5.5 ms at default PIT rate.")]
	public string AdgTick(
		[Description("Number of PIT ticks to advance. 181 ticks ≈ 1 second of driver time.")]
		int ticks = 181) {
		if (ticks <= 0 || ticks > 100_000) {
			return "Error: ticks must be between 1 and 100000.";
		}
		if (!_state.Engine.IsPlaying && !_state.Engine.IsPaused) {
			return "Error: engine is not playing. Call adg_play first.";
		}
		_state.Engine.AdvanceTicks(ticks);
		return FormatEngineState();
	}

	/// <summary>
	/// Returns a snapshot of the current engine state: play/pause status, current measure,
	/// tick count, subdivision, driver volume, and PIT timing.
	/// </summary>
	[McpServerTool, Description("Return a snapshot of the current engine state including playback position, tick count, measure, subdivision, and volume.")]
	public string AdgState() {
		return FormatEngineState();
	}

	/// <summary>
	/// Returns a per-channel state snapshot: active flag, instrument, note name, frequency
	/// word, pitch bend, and wait counter for all 18 OPL3 Gold channels.
	/// </summary>
	[McpServerTool, Description("Return per-channel state for all 18 OPL3 Gold channels: active flag, instrument, note, frequency word, and wait counter.")]
	public string AdgChannelStates() {
		ChannelSnapshot[] snapshots = _state.Engine.GetChannelSnapshots();
		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"Channel states at tick {_state.Engine.TotalTickCount} / measure {_state.Engine.CurrentMeasure}:");
		foreach (ChannelSnapshot s in snapshots) {
			string activeGlyph = s.IsActive ? "●" : "○";
			string inst = s.Instrument == 0xFF ? "--" : $"{s.Instrument:X2}h";
			string note = s.IsActive ? s.NoteName : "  ";
			sb.AppendLine($"  {activeGlyph} Ch{s.Channel:D2}  note={note,-4}  inst={inst}  freq=0x{s.Frequency:X4}  wait=0x{s.Wait:X4}  bend={s.PitchBendFlag:X4}h");
		}
		return sb.ToString();
	}

	/// <summary>
	/// Returns up to <paramref name="maxEntries"/> recent OPL register writes as a table.
	/// Each row shows the tick number, the register address (with secondary-bank indicator for
	/// registers ≥ 0x100), and the value written. Use this to validate that the reimplemented
	/// engine produces the same OPL sequence as the original DNADG driver.
	/// </summary>
	[McpServerTool, Description("Return recent OPL register writes captured since the last adg_load. Each row shows tick, register address (>=0x100 = secondary OPL3 bank), and value.")]
	public string AdgOplLog(
		[Description("Maximum number of entries to return (default 64, max 512).")]
		int maxEntries = 64) {
		maxEntries = Math.Clamp(maxEntries, 1, 512);
		List<OplWriteRecord> log = _state.GetOplLog(maxEntries);
		if (log.Count == 0) {
			return "OPL log is empty. Load a song and advance some ticks first.";
		}
		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"OPL writes (last {log.Count} entries, oldest first):");
		sb.AppendLine("  Tick        Reg    Bank  Value");
		sb.AppendLine("  ----------  -----  ----  -----");
		foreach (OplWriteRecord r in log) {
			string bank = r.Register >= 0x100 ? "2nd " : "1st ";
			sb.AppendLine($"  {r.Tick,-10}  0x{r.Register:X3}  {bank}  0x{r.Value:X2}");
		}
		return sb.ToString();
	}

	/// <summary>
	/// Returns up to <paramref name="maxEntries"/> recent channel events (NoteOn, NoteOff,
	/// PitchBend, SetInstrument, etc.) dispatched by the tick scheduler.
	/// </summary>
	[McpServerTool, Description("Return recent channel events (NoteOn, NoteOff, SetInstrument, PitchBend, …) dispatched by the tick scheduler.")]
	public string AdgChannelLog(
		[Description("Maximum number of entries to return (default 32, max 256).")]
		int maxEntries = 32) {
		maxEntries = Math.Clamp(maxEntries, 1, 256);
		List<ChannelEventRecord> log = _state.GetChannelLog(maxEntries);
		if (log.Count == 0) {
			return "Channel event log is empty. Load a song and advance some ticks first.";
		}
		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"Channel events (last {log.Count} entries, oldest first):");
		sb.AppendLine("  Tick        Ch   Event              Detail");
		sb.AppendLine("  ----------  ---  -----------------  ------");
		foreach (ChannelEventRecord r in log) {
			sb.AppendLine($"  {r.Tick,-10}  {r.Channel,2}   {r.EventType,-17}  {r.Detail}");
		}
		return sb.ToString();
	}

	/// <summary>
	/// Parses and returns the song header of any ADG/HSQ file without loading it into
	/// the engine. Useful for inspecting multiple files before choosing which to load.
	/// </summary>
	[McpServerTool, Description("Inspect the header of an ADG/HSQ file (tempo, channel count, instrument count, loop info) without loading it for playback.")]
	public string AdgInspectHeader(
		[Description("Absolute path to the .HSQ or .ADG file to inspect.")]
		string filePath) {
		if (!File.Exists(filePath)) {
			return $"Error: file not found: {filePath}";
		}
		try {
			byte[] raw = File.ReadAllBytes(filePath);
			if (!DuneAdgPlayerEngine.TryExtractHeaderInfo(raw, out SongHeaderInfo? header) || header is null) {
				return $"{Path.GetFileName(filePath)}: not a valid ADG file (bad header or unsupported format).";
			}
			return FormatHeaderInfo(filePath, header);
		} catch (IOException ex) {
			return $"IO error: {ex.Message}";
		}
	}

	/// <summary>
	/// Returns a JSON dump of the current engine state suitable for machine consumption.
	/// Includes all channel snapshots, counters, volume bytes, and timing parameters.
	/// </summary>
	[McpServerTool, Description("Return a structured JSON dump of the engine state for programmatic consumption. Includes all 18 channel snapshots plus timing and volume fields.")]
	public string AdgDumpJson() {
		ChannelSnapshot[] channels = _state.Engine.GetChannelSnapshots();
		object state = new {
			isPlaying = _state.Engine.IsPlaying,
			isPaused = _state.Engine.IsPaused,
			loadedFile = Path.GetFileName(_state.LoadedPath),
			totalTicks = _state.Engine.TotalTickCount,
			measure = _state.Engine.CurrentMeasure,
			subdivision = _state.Engine.CurrentSubdivision,
			pitReloadValue = _state.Engine.PitReloadValue,
			tickRateHz = Math.Round(_state.Engine.TickRateHz, 2),
			currentVolume = _state.Engine.CurrentDriverVolume,
			targetVolume = _state.Engine.TargetDriverVolume,
			masterVolume = _state.Engine.MasterDriverVolume,
			oplLogSize = _state.GetOplLog(512).Count,
			channels = System.Linq.Enumerable.Select(channels, ch => new {
				ch.Channel,
				active = ch.IsActive,
				note = ch.NoteName,
				instrument = ch.Instrument == 0xFF ? null : (int?)ch.Instrument,
				frequencyWord = ch.Frequency,
				wait = ch.Wait,
				pitchBendFlag = ch.PitchBendFlag
			})
		};
		return JsonSerializer.Serialize(state, new JsonSerializerOptions { WriteIndented = true });
	}

	// --- Helpers ---

	private string FormatEngineState() {
		StringBuilder sb = new StringBuilder();
		string playState = _state.Engine.IsPlaying ? "Playing" : _state.Engine.IsPaused ? "Paused" : "Stopped";
		sb.AppendLine($"State        : {playState}");
		if (!string.IsNullOrEmpty(_state.LoadedPath)) {
			sb.AppendLine($"Loaded file  : {Path.GetFileName(_state.LoadedPath)}");
		}
		sb.AppendLine($"Total ticks  : {_state.Engine.TotalTickCount}");
		sb.AppendLine($"Measure      : {_state.Engine.CurrentMeasure}");
		sb.AppendLine($"Subdivision  : 0x{_state.Engine.CurrentSubdivision:X2}");
		sb.AppendLine($"Tick rate    : {_state.Engine.TickRateHz:F2} Hz  (PIT reload 0x{_state.Engine.PitReloadValue:X4})");
		sb.AppendLine($"Driver vol   : cur=0x{_state.Engine.CurrentDriverVolume:X2}  tgt=0x{_state.Engine.TargetDriverVolume:X2}  master=0x{_state.Engine.MasterDriverVolume:X2}");
		sb.AppendLine($"OPL log      : {_state.GetOplLog(512).Count} entries captured");
		return sb.ToString();
	}

	private static string FormatHeaderInfo(string filePath, SongHeaderInfo header) {
		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"File         : {Path.GetFileName(filePath)}  ({header.RawFileSize} bytes{(header.WasHsqCompressed ? ", HSQ-compressed" : ", raw")})");
		sb.AppendLine($"Data base    : 0x{header.DataBase:X4}    Event base: 0x{header.EventBase:X4}");
		sb.AppendLine($"Tempo        : 0x{header.Tempo:X4}    Instruments: {header.InstrumentCount}");
		sb.AppendLine($"Channels     : {header.ActiveChannelCount}/{header.ChannelOffsets.Length} active");
		sb.AppendLine($"Loop         : measure {header.LoopStartMeasure} → {header.LoopEndMeasure}  ×{header.LoopCount}");
		sb.Append("Ch offsets   :");
		for (int i = 0; i < header.ChannelOffsets.Length; i++) {
			sb.Append(header.ChannelActive[i] ? $" Ch{i}=0x{header.ChannelOffsets[i]:X4}" : $" Ch{i}=--");
		}
		sb.AppendLine();
		return sb.ToString();
	}
}
