namespace Cryogenic.Services;

using LibVLCSharp.Shared;

using Serilog;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Plays audio files from a configured local folder as replacements for the game's native MT-32 music.
/// </summary>
/// <remarks>
/// <para>
/// The registry file <c>fingerprints.json</c> maps 2-byte song-block content fingerprints to
/// human-readable names. It must be placed in the same folder passed via <c>--MusicFolder</c>.
/// A default copy ships in <c>assets_override/music/fingerprints.json</c> and can be freely edited.
/// </para>
/// <para>
/// Audio playback is provided by LibVLCSharp, which handles MP3, OGG, WAV, FLAC, and AAC
/// natively on both Linux and Windows without additional per-format packages.
/// </para>
/// <para>
/// Replacement files are resolved by priority: mp3 → ogg → wav → flac → aac.
/// If no file is found for a given name, native MT-32 playback is used for that song.
/// </para>
/// </remarks>
public sealed class MusicFolderPlayer : IDisposable {
	private static readonly ILogger PlayerLogger = Log.ForContext("Subsystem", "MusicFolderPlayer");
	private static readonly string[] AudioExtensions = ["mp3", "ogg", "wav", "flac", "aac"];
	private const string AnalysisCacheFileName = "track-analysis-cache.json";
	private const int CurrentAnalysisVersion = 1;

	private readonly string _folderPath;
	private readonly string _analysisCachePath;
	private readonly LibVLC _libVlc;
	private readonly MediaPlayer _mediaPlayer;
	private readonly StartupTrackSilenceAnalyzer _silenceAnalyzer;
	private readonly Dictionary<string, FingerprintEntry> _registry;
	private readonly Dictionary<string, ResolvedTrack> _resolvedTracks;
	private readonly Dictionary<string, TrackAnalysisCacheEntry> _analysisByFingerprint;
	private float _volume = 1.0f;
	private long _currentTrackSkipMs;
	/// <summary>
	/// Fingerprint of the song currently loaded in the media player, or empty when none.
	/// Used to avoid stopping and restarting LibVLC when the game re-opens the same song
	/// (which happens whenever the driver goes through a Reset → Open cycle on scene load).
	/// </summary>
	private string _currentFingerprint = string.Empty;

	/// <summary>
	/// Gets or sets whether the replacement track loops continuously when it reaches the end.
	/// Defaults to <c>true</c> to mirror the driver's internal loop behaviour.
	/// </summary>
	public bool IsLooping { get; set; } = true;

	/// <summary>
	/// Gets whether a replacement track is currently active.
	/// Set to <c>false</c> by <see cref="Stop"/> or by natural track end when <see cref="IsLooping"/> is <c>false</c>.
	/// </summary>
	public bool IsActive { get; private set; }

	/// <summary>
	/// Gets or sets the current playback volume in the range 0.0–1.0.
	/// Setting this property applies the change immediately via LibVLC (scaled to 0–100).
	/// </summary>
	public float Volume {
		get => _volume;
		set {
			_volume = Math.Clamp(value, 0.0f, 1.0f);
			_mediaPlayer.Volume = (int)(_volume * 100f);
		}
	}

	/// <summary>
	/// Initialises the player for <paramref name="folderPath"/> and loads <c>fingerprints.json</c> from that folder.
	/// </summary>
	/// <param name="folderPath">
	/// Absolute path to the folder containing replacement audio files and <c>fingerprints.json</c>.
	/// Passed from the <c>--MusicFolder</c> command-line argument.
	/// </param>
	public MusicFolderPlayer(string folderPath) {
		_folderPath = folderPath;
		_analysisCachePath = Path.Combine(_folderPath, AnalysisCacheFileName);
		_registry = new Dictionary<string, FingerprintEntry>(StringComparer.Ordinal);
		_resolvedTracks = new Dictionary<string, ResolvedTrack>(StringComparer.Ordinal);
		_analysisByFingerprint = new Dictionary<string, TrackAnalysisCacheEntry>(StringComparer.Ordinal);
		Core.Initialize();
		_libVlc = new LibVLC();
		_mediaPlayer = new MediaPlayer(_libVlc);
		_silenceAnalyzer = new StartupTrackSilenceAnalyzer(_libVlc);
		_mediaPlayer.EndReached += OnEndReached;
		LoadRegistry();
		InitializeTrackCatalogAndAnalysis();
	}

	/// <summary>
	/// Returns the primary (first) human-readable name for the given fingerprint.
	/// If <paramref name="fingerprint"/> is not in registry or has no names, returns <c>"Unknown"</c>.
	/// </summary>
	/// <param name="fingerprint">Lowercase hex string of the first 2 bytes of the song data block at ES:SI.</param>
	/// <returns>The first name associated with this fingerprint, or <c>"Unknown"</c>.</returns>
	public string ResolveName(string fingerprint) {
		if (_registry.TryGetValue(fingerprint, out FingerprintEntry? existing) && existing.Names.Count > 0) {
			return existing.Names[0];
		}
		return "Unknown";
	}

	/// <summary>
	/// Attempts to start replacement playback for the song identified by <paramref name="fingerprint"/>.
	/// The name associated with the fingerprint is looked up in the registry and used to find an audio
	/// file in the music folder. If no file is found, the method returns without playing so the native
	/// MT-32 driver can handle the song. Any currently active track is stopped before a new one starts.
	/// </summary>
	/// <param name="fingerprint">Lowercase hex fingerprint string identifying the song.</param>
	public void TryPlay(string fingerprint) {
		if (IsActive && string.Equals(fingerprint, _currentFingerprint, StringComparison.Ordinal)) {
			// Same song already playing (e.g. game did Reset → Open on same song).
			return;
		}
		if (IsActive) {
			PlayerLogger.Debug("Stopping previous track before opening {Fingerprint}.", fingerprint);
			Stop();
		}

		if (!_resolvedTracks.TryGetValue(fingerprint, out ResolvedTrack resolvedTrack)) {
			IReadOnlyList<string> songNames = _registry.TryGetValue(fingerprint, out FingerprintEntry? entry) ? entry.Names : [];
			PlayerLogger.Debug("No replacement file for fingerprint {Fingerprint} (names='{Names}'). Falling through to MT-32.", fingerprint, string.Join(", ", songNames));
			return;
		}
		if (!_analysisByFingerprint.TryGetValue(fingerprint, out TrackAnalysisCacheEntry analysisEntry)) {
			analysisEntry = TrackAnalysisCacheEntry.Create(fingerprint, 0, 0.0, CurrentAnalysisVersion, resolvedTrack.FilePath, resolvedTrack.FileSize, resolvedTrack.LastWriteUtcTicks);
		}

		using Media media = new Media(_libVlc, resolvedTrack.FilePath, FromType.FromPath);
		_mediaPlayer.Media = media;
		bool started = _mediaPlayer.Play();
		if (!started) {
			throw new InvalidOperationException($"LibVLC could not open '{resolvedTrack.FilePath}'.");
		}

		ApplyTrackSkip(analysisEntry.SkipMs, resolvedTrack.FilePath, fingerprint);
		IsActive = true;
		_currentFingerprint = fingerprint;
		_currentTrackSkipMs = analysisEntry.SkipMs;
	}

	/// <summary>
	/// Stops the currently playing replacement track and sets <see cref="IsActive"/> to <c>false</c>.
	/// Safe to call when no track is playing.
	/// </summary>
	private void Stop() {
		_mediaPlayer.Stop();
		IsActive = false;
		_currentFingerprint = string.Empty;
		_currentTrackSkipMs = 0;
	}

	/// <inheritdoc />
	public void Dispose() {
		_mediaPlayer.EndReached -= OnEndReached;
		_mediaPlayer.Stop();
		_mediaPlayer.Dispose();
		_libVlc.Dispose();
	}

	private void OnEndReached(object? sender, EventArgs e) {
		if (!IsLooping) {
			IsActive = false;
			return;
		}
		ThreadPool.QueueUserWorkItem(_ => {
			if (!IsLooping || !IsActive) {
				return;
			}
			_mediaPlayer.Stop();
			bool restarted = _mediaPlayer.Play();
			if (!restarted) {
				throw new InvalidOperationException("Loop restart failed in MediaPlayer.");
			}
			if (_currentTrackSkipMs > 0) {
				Media? media = _mediaPlayer.Media;
				if (media is null) {
					throw new InvalidOperationException("Loop restart media context is missing.");
				}
				ApplyTrackSkip(_currentTrackSkipMs, media.Mrl, _currentFingerprint);
			}
		});
	}

	private static string ResolveFilePath(IReadOnlyList<string> songNames, IReadOnlyDictionary<string, string> filesByName) {
		if (songNames.Count == 0) {
			return string.Empty;
		}
		foreach (string songName in songNames) {
			if (string.IsNullOrWhiteSpace(songName)) {
				continue;
			}
			foreach (string extension in AudioExtensions) {
				string key = $"{songName}.{extension}".ToLowerInvariant();
				if (filesByName.TryGetValue(key, out string? path) && !string.IsNullOrEmpty(path)) {
					return path;
				}
			}
		}
		return string.Empty;
	}

	private void InitializeTrackCatalogAndAnalysis() {
		if (!Directory.Exists(_folderPath)) {
			throw new DirectoryNotFoundException($"Music folder '{_folderPath}' does not exist.");
		}

		Dictionary<string, string> filesByName = BuildFileNameLookup(_folderPath);
		foreach (KeyValuePair<string, FingerprintEntry> pair in _registry) {
			string fingerprint = pair.Key;
			string resolvedPath = ResolveFilePath(pair.Value.Names, filesByName);
			if (string.IsNullOrEmpty(resolvedPath)) {
				continue;
			}

			FileInfo fileInfo = new FileInfo(resolvedPath);
			if (!fileInfo.Exists) {
				throw new FileNotFoundException($"Resolved replacement file does not exist for '{fingerprint}'.", resolvedPath);
			}

			ResolvedTrack resolvedTrack = new ResolvedTrack(resolvedPath, fileInfo.Length, fileInfo.LastWriteTimeUtc.Ticks);
			_resolvedTracks[fingerprint] = resolvedTrack;
		}

		LoadAnalysisCache();
		AnalyzeTracksAtStartup();
		SaveAnalysisCache();
	}

	private void AnalyzeTracksAtStartup() {
		Stopwatch stopwatch = Stopwatch.StartNew();
		int cacheHits = 0;
		int analyzedCount = 0;
		Lock sync = new Lock();
		ParallelOptions options = new ParallelOptions { MaxDegreeOfParallelism = Math.Min(Environment.ProcessorCount, 4) };

		Parallel.ForEach(_resolvedTracks, options, pair => {
			string fingerprint = pair.Key;
			ResolvedTrack resolvedTrack = pair.Value;

			if (TryGetFreshCachedEntry(fingerprint, resolvedTrack, out TrackAnalysisCacheEntry cachedEntry)) {
				lock (sync) {
					_analysisByFingerprint[fingerprint] = cachedEntry;
				}
				Interlocked.Increment(ref cacheHits);
				return;
			}

			TrackAnalysisCacheEntry newEntry;
			try {
				TrackSilenceAnalysisResult result = _silenceAnalyzer.Analyze(resolvedTrack.FilePath);
				newEntry = TrackAnalysisCacheEntry.Create(
					fingerprint,
					result.SkipMs,
					result.Confidence,
					CurrentAnalysisVersion,
					resolvedTrack.FilePath,
					resolvedTrack.FileSize,
					resolvedTrack.LastWriteUtcTicks);
			} catch (Exception ex) {
				PlayerLogger.Warning(ex, "Track analysis failed for fingerprint {Fingerprint}. Using zero skip.", fingerprint);
				newEntry = TrackAnalysisCacheEntry.Create(
					fingerprint,
					0,
					0.0,
					CurrentAnalysisVersion,
					resolvedTrack.FilePath,
					resolvedTrack.FileSize,
					resolvedTrack.LastWriteUtcTicks);
			}

			lock (sync) {
				_analysisByFingerprint[fingerprint] = newEntry;
			}
			Interlocked.Increment(ref analyzedCount);
		});

		stopwatch.Stop();
		PlayerLogger.Information(
			"Track startup analysis complete. TotalTracks={TotalTracks} CacheHits={CacheHits} Analyzed={Analyzed} ElapsedMs={ElapsedMs}",
			_resolvedTracks.Count,
			cacheHits,
			analyzedCount,
			stopwatch.ElapsedMilliseconds);
	}

	private bool TryGetFreshCachedEntry(string fingerprint, in ResolvedTrack resolvedTrack, out TrackAnalysisCacheEntry entry) {
		if (
			_analysisByFingerprint.TryGetValue(fingerprint, out TrackAnalysisCacheEntry existing) &&
			existing.AnalysisVersion == CurrentAnalysisVersion &&
			string.Equals(existing.FilePath, resolvedTrack.FilePath, StringComparison.OrdinalIgnoreCase) &&
			existing.FileSize == resolvedTrack.FileSize &&
			existing.LastWriteUtcTicks == resolvedTrack.LastWriteUtcTicks
		) {
			entry = existing;
			return true;
		}

		entry = TrackAnalysisCacheEntry.Empty;
		return false;
	}

	private void LoadAnalysisCache() {
		if (!File.Exists(_analysisCachePath)) {
			return;
		}

		TrackAnalysisCacheContainer? container;
		try {
			string json = File.ReadAllText(_analysisCachePath);
			container = JsonSerializer.Deserialize<TrackAnalysisCacheContainer>(json);
		} catch (Exception ex) {
			PlayerLogger.Warning(ex, "Could not read analysis cache '{Path}'. Rebuilding cache.", _analysisCachePath);
			_analysisByFingerprint.Clear();
			return;
		}
		if (container is null) {
			PlayerLogger.Warning("Could not deserialize analysis cache '{Path}'. Rebuilding cache.", _analysisCachePath);
			_analysisByFingerprint.Clear();
			return;
		}

		_analysisByFingerprint.Clear();
		foreach (TrackAnalysisCacheEntry entry in container.Entries.Where(e => !string.IsNullOrEmpty(e.Fingerprint))) {
			_analysisByFingerprint[entry.Fingerprint] = entry;
		}
	}

	private void SaveAnalysisCache() {
		TrackAnalysisCacheContainer container = new TrackAnalysisCacheContainer {
			AnalysisVersion = CurrentAnalysisVersion,
			Entries = _analysisByFingerprint.Values.OrderBy(e => e.Fingerprint, StringComparer.Ordinal).ToList()
		};
		string json = JsonSerializer.Serialize(container, new JsonSerializerOptions { WriteIndented = true });
		File.WriteAllText(_analysisCachePath, json);
	}

	private static Dictionary<string, string> BuildFileNameLookup(string folderPath) {
		return Directory
			.GetFiles(folderPath)
			.Where(path => !string.IsNullOrEmpty(Path.GetFileName(path)))
			.ToDictionary(path => Path.GetFileName(path).ToLowerInvariant(), path => path, StringComparer.OrdinalIgnoreCase);
	}

	private void ApplyTrackSkip(long skipMs, string filePath, string fingerprint) {
		if (skipMs <= 0) {
			return;
		}

		DateTime deadline = DateTime.UtcNow.AddSeconds(2);
		while (DateTime.UtcNow < deadline) {
			if (_mediaPlayer.IsSeekable && _mediaPlayer.Length > 0) {
				break;
			}
			Thread.Sleep(10);
		}

		if (!_mediaPlayer.IsSeekable || _mediaPlayer.Length <= 0) {
			throw new InvalidOperationException($"Track '{filePath}' is not seekable for fingerprint '{fingerprint}'.");
		}

		long clampedSkipMs = Math.Min(skipMs, Math.Max(0, _mediaPlayer.Length - 1));
		_mediaPlayer.SeekTo(TimeSpan.FromMilliseconds(clampedSkipMs));
		PlayerLogger.Debug("Applied startup skip. Fingerprint={Fingerprint} SkipMs={SkipMs} File='{FilePath}'", fingerprint, clampedSkipMs, filePath);
	}

	private void LoadRegistry() {
		string registryPath = Path.Combine(_folderPath, "fingerprints.json");
		if (!File.Exists(registryPath)) {
			throw new FileNotFoundException($"fingerprints.json not found at '{registryPath}'.", registryPath);
		}
		string json = File.ReadAllText(registryPath);
		MergeRegistryFromJson(json, registryPath);
	}

	private void MergeRegistryFromJson(string json, string source) {
		Dictionary<string, FingerprintEntry>? entries = JsonSerializer.Deserialize<Dictionary<string, FingerprintEntry>>(json);
		if (entries is null) {
			throw new InvalidOperationException($"fingerprints.json from '{source}' could not be parsed.");
		}
		foreach (KeyValuePair<string, FingerprintEntry> pair in entries) {
			_registry[pair.Key] = pair.Value;
		}

		if (_registry.Count == 0) {
			throw new InvalidOperationException($"fingerprints.json from '{source}' is empty.");
		}
	}
}

internal sealed class TrackAnalysisCacheContainer {
	[JsonPropertyName("analysisVersion")]
	public int AnalysisVersion { get; set; }

	[JsonPropertyName("entries")]
	public List<TrackAnalysisCacheEntry> Entries { get; set; } = [];
}

[StructLayout(LayoutKind.Auto)]
internal readonly struct ResolvedTrack {
	public ResolvedTrack(string filePath, long fileSize, long lastWriteUtcTicks) {
		FilePath = filePath;
		FileSize = fileSize;
		LastWriteUtcTicks = lastWriteUtcTicks;
	}

	public string FilePath { get; }
	public long FileSize { get; }
	public long LastWriteUtcTicks { get; }
}

[StructLayout(LayoutKind.Auto)]
internal readonly struct TrackAnalysisCacheEntry {
	public static readonly TrackAnalysisCacheEntry Empty = new TrackAnalysisCacheEntry(string.Empty, 0, 0.0, 0, string.Empty, 0, 0);

	public TrackAnalysisCacheEntry(
		string fingerprint,
		long skipMs,
		double confidence,
		int analysisVersion,
		string filePath,
		long fileSize,
		long lastWriteUtcTicks) {
		Fingerprint = fingerprint;
		SkipMs = skipMs;
		Confidence = confidence;
		AnalysisVersion = analysisVersion;
		FilePath = filePath;
		FileSize = fileSize;
		LastWriteUtcTicks = lastWriteUtcTicks;
	}

	[JsonPropertyName("fingerprint")]
	public string Fingerprint { get; init; }

	[JsonPropertyName("skipMs")]
	public long SkipMs { get; init; }

	[JsonPropertyName("confidence")]
	public double Confidence { get; init; }

	[JsonPropertyName("analysisVersion")]
	public int AnalysisVersion { get; init; }

	[JsonPropertyName("filePath")]
	public string FilePath { get; init; }

	[JsonPropertyName("fileSize")]
	public long FileSize { get; init; }

	[JsonPropertyName("lastWriteUtcTicks")]
	public long LastWriteUtcTicks { get; init; }

	public static TrackAnalysisCacheEntry Create(
		string fingerprint,
		long skipMs,
		double confidence,
		int analysisVersion,
		string filePath,
		long fileSize,
		long lastWriteUtcTicks
	) {
		return new TrackAnalysisCacheEntry(fingerprint, skipMs, confidence, analysisVersion, filePath, fileSize, lastWriteUtcTicks);
	}
}

/// <summary>
/// Persisted registry entry mapping a song content fingerprint to a human-readable name.
/// Stored in <c>fingerprints.json</c> inside the <c>--MusicFolder</c> directory.
/// </summary>
public sealed class FingerprintEntry {
	/// <summary>
	/// Lowercase hex fingerprint that keys this entry (first 8 bytes of the song block at ES:SI).
	/// Stored redundantly inside the value so the JSON is self-describing even when sorted or hand-edited.
	/// </summary>
	[JsonPropertyName("fingerprint")]
	public string Fingerprint { get; set; } = string.Empty;

	/// <summary>
	/// Ordered list of candidate file names for this song (without extension).
	/// The player resolves the first name for which a matching audio file exists in the music folder.
	/// Edit <c>fingerprints.json</c> in the music folder to add or reorder names.
	/// </summary>
	[JsonPropertyName("names")]
	public IReadOnlyList<string> Names { get; set; } = [];
}