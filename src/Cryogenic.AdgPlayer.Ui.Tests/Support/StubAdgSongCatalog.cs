namespace Cryogenic.AdgPlayer.Ui.Tests.Support;

using Cryogenic.AdgPlayer.Ui.Services;
using Cryogenic.AdgPlayer.Ui.ViewModels;

using System.Collections.Generic;

/// <summary>
/// Test double for <see cref="IAdgSongCatalog"/> backed by an
/// in-memory list. Allows tests to drive
/// <see cref="AdgBrowserViewModel.Refresh"/> deterministically.
/// </summary>
public sealed class StubAdgSongCatalog : IAdgSongCatalog {
	private readonly List<AdgBrowserItem> _items = new();

	/// <summary>Adds an item to the next snapshot returned by <see cref="Enumerate"/>.</summary>
	public void Add(AdgBrowserItem item) {
		_items.Add(item);
	}

	/// <summary>Empties the current snapshot.</summary>
	public void Clear() {
		_items.Clear();
	}

	/// <inheritdoc />
	public IReadOnlyList<AdgBrowserItem> Enumerate() {
		return _items.ToArray();
	}
}