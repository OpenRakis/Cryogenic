namespace Cryogenic.AdgPlayer.Ui.ViewModels;

/// <summary>
/// One row in the ADG song browser. Built from a decompressed
/// DUNE.DAT entry (typically a <c>.UNHSQ</c> file) so the UI can
/// list every available ADG song without keeping the raw bytes
/// alive. Immutable record-style class to avoid binding refresh
/// surprises.
/// </summary>
public sealed class AdgBrowserItem {
	/// <summary>Absolute path on disk to the decompressed song file.</summary>
	public string Path { get; }

	/// <summary>Filename component shown in the list cell.</summary>
	public string FileName { get; }

	/// <summary>Size in bytes of the song file (display purpose only).</summary>
	public long SizeBytes { get; }

	/// <summary>Builds a browser item with explicit fields.</summary>
	public AdgBrowserItem(string path, string fileName, long sizeBytes) {
		Path = path;
		FileName = fileName;
		SizeBytes = sizeBytes;
	}
}