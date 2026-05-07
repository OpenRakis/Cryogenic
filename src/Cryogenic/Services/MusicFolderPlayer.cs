namespace Cryogenic.Services;

using LibVLCSharp.Shared;

using Serilog;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;

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

	private readonly string _folderPath;
	private readonly LibVLC _libVlc;
	private readonly MediaPlayer _mediaPlayer;
	private readonly Dictionary<string, FingerprintEntry> _registry;
	private float _volume = 1.0f;
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
		_registry = new Dictionary<string, FingerprintEntry>(StringComparer.Ordinal);
		Core.Initialize();
		_libVlc = new LibVLC();
		_mediaPlayer = new MediaPlayer(_libVlc);
		_mediaPlayer.EndReached += OnEndReached;
		LoadRegistry();
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

		IReadOnlyList<string> songNames = _registry.TryGetValue(fingerprint, out FingerprintEntry? entry) ? entry.Names : [];
		string resolvedPath = ResolveFilePath(songNames);
		if (string.IsNullOrEmpty(resolvedPath)) {
			PlayerLogger.Warning("No replacement file for song {Fingerprint} (names='{Names}'). Falling through to MT-32.", fingerprint, string.Join(", ", songNames));
			return;
		}

		try {
			Media media = new Media(_libVlc, resolvedPath, FromType.FromPath);
			_mediaPlayer.Media = media;
			media.Dispose();
			bool started = _mediaPlayer.Play();
			if (!started) {
				PlayerLogger.Warning("LibVLC could not open '{FilePath}'. Falling through to MT-32.", resolvedPath);
				IsActive = false;
				return;
			}
			IsActive = true;
			_currentFingerprint = fingerprint;
		} catch (Exception ex) {
			PlayerLogger.Warning(ex, "LibVLC could not open '{FilePath}'. Falling through to MT-32.", resolvedPath);
			IsActive = false;
		}
	}

	/// <summary>
	/// Stops the currently playing replacement track and sets <see cref="IsActive"/> to <c>false</c>.
	/// Safe to call when no track is playing.
	/// </summary>
	private void Stop() {
		_mediaPlayer.Stop();
		IsActive = false;
		_currentFingerprint = string.Empty;
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
			_mediaPlayer.Play();
		});
	}

	private string ResolveFilePath(IReadOnlyList<string> songNames) {
		if (songNames.Count == 0) {
			return string.Empty;
		}
		string[] filesInFolder = Directory.Exists(_folderPath)
			? Directory.GetFiles(_folderPath)
			: [];
		foreach (string songName in songNames) {
			if (string.IsNullOrWhiteSpace(songName)) {
				continue;
			}
			string? match = AudioExtensions
				.Select(ext => filesInFolder.FirstOrDefault(
					f => string.Equals(Path.GetFileName(f), $"{songName}.{ext}", StringComparison.OrdinalIgnoreCase)))
				.FirstOrDefault(m => m is not null);
			if (match is not null) {
				return match;
			}
		}
		return string.Empty;
	}

	private void LoadRegistry() {
		string registryPath = Path.Combine(_folderPath, "fingerprints.json");
		if (!File.Exists(registryPath)) {
			PlayerLogger.Warning("fingerprints.json not found at '{Path}'. Song names will be unknown.", registryPath);
			return;
		}
		string json = File.ReadAllText(registryPath);
		MergeRegistryFromJson(json, registryPath);
	}

	private void MergeRegistryFromJson(string json, string source) {
		Dictionary<string, FingerprintEntry>? entries = JsonSerializer.Deserialize<Dictionary<string, FingerprintEntry>>(json);
		if (entries is null) {
			PlayerLogger.Warning("fingerprints.json from {Source} could not be parsed (null result).", source);
			return;
		}
		foreach (KeyValuePair<string, FingerprintEntry> pair in entries) {
			_registry[pair.Key] = pair.Value;
		}
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