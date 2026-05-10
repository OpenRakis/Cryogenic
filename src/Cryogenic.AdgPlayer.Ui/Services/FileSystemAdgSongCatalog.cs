namespace Cryogenic.AdgPlayer.Ui.Services;

using Cryogenic.AdgPlayer.Ui.ViewModels;

using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// File-system backed <see cref="IAdgSongCatalog"/>. Scans a folder
/// (typically the decompressed <c>DUNE.DAT_</c> tree) for files with
/// extension <c>.UNHSQ</c> and returns each as an
/// <see cref="AdgBrowserItem"/>.
/// </summary>
public sealed class FileSystemAdgSongCatalog : IAdgSongCatalog {
	/// <summary>Default song file extension.</summary>
	public const string SongExtension = ".UNHSQ";

	private readonly string _directory;

	/// <summary>Constructs the catalog around the supplied directory.</summary>
	public FileSystemAdgSongCatalog(string directory) {
		ArgumentNullException.ThrowIfNull(directory);
		_directory = directory;
	}

	/// <summary>Returns one entry per <c>.UNHSQ</c> file in the directory, sorted by filename.</summary>
	public IReadOnlyList<AdgBrowserItem> Enumerate() {
		List<AdgBrowserItem> items = new();
		if (!Directory.Exists(_directory)) {
			return items;
		}

		string[] files = Directory.GetFiles(_directory, "*" + SongExtension, SearchOption.TopDirectoryOnly);
		Array.Sort(files, StringComparer.OrdinalIgnoreCase);
		foreach (string file in files) {
			FileInfo info = new(file);
			items.Add(new AdgBrowserItem(file, info.Name, info.Length));
		}
		return items;
	}
}