namespace Cryogenic.AdgPlayer.Ui.Services;

using Cryogenic.AdgPlayer.Ui.ViewModels;

using System.Collections.Generic;

/// <summary>
/// Service that produces the list of available ADG songs displayed
/// in the browser panel. Implementations are free to scan a
/// directory, walk a packed DUNE.DAT, or return a fixed in-memory
/// catalogue (for tests).
/// </summary>
public interface IAdgSongCatalog {
	/// <summary>Returns the catalogue in the order it should be displayed.</summary>
	IReadOnlyList<AdgBrowserItem> Enumerate();
}