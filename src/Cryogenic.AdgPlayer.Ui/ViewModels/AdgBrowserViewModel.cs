namespace Cryogenic.AdgPlayer.Ui.ViewModels;

using Cryogenic.AdgPlayer.Ui.Services;

using System;
using System.Collections.ObjectModel;

/// <summary>
/// View model for the DUNE.DAT browser panel. Holds an
/// <see cref="ObservableCollection{T}"/> of <see cref="AdgBrowserItem"/>
/// pulled from an <see cref="IAdgSongCatalog"/>, plus the integer
/// selection index used by the <c>ListBox.SelectedIndex</c> binding
/// (we deliberately avoid nullable selected-item state).
/// </summary>
public sealed class AdgBrowserViewModel : ViewModelBase {
	/// <summary>Sentinel returned by <see cref="SelectedIndex"/> when the list has no selection.</summary>
	public const int NoSelection = -1;

	private readonly IAdgSongCatalog _catalog;
	private int _selectedIndex = NoSelection;

	/// <summary>Items currently displayed in the browser.</summary>
	public ObservableCollection<AdgBrowserItem> Items { get; } = new();

	/// <summary>Index of the highlighted item or <see cref="NoSelection"/>.</summary>
	public int SelectedIndex {
		get => _selectedIndex;
		set {
			int clamped = value < 0 || value >= Items.Count ? NoSelection : value;
			if (SetProperty(ref _selectedIndex, clamped)) {
				OnPropertyChanged(nameof(HasSelection));
			}
		}
	}

	/// <summary>True when <see cref="SelectedIndex"/> points at a real item.</summary>
	public bool HasSelection => _selectedIndex != NoSelection;

	/// <summary>Builds the view model around the supplied catalog.</summary>
	public AdgBrowserViewModel(IAdgSongCatalog catalog) {
		ArgumentNullException.ThrowIfNull(catalog);
		_catalog = catalog;
	}

	/// <summary>
	/// Re-reads the catalog and replaces the current item list. The
	/// previously selected item is dropped (selection is reset to
	/// <see cref="NoSelection"/>).
	/// </summary>
	public void Refresh() {
		Items.Clear();
		foreach (AdgBrowserItem item in _catalog.Enumerate()) {
			Items.Add(item);
		}
		SelectedIndex = NoSelection;
	}

	/// <summary>
	/// Returns the highlighted item. Throws when
	/// <see cref="HasSelection"/> is <c>false</c>; callers must guard
	/// the call. This avoids exposing a nullable property.
	/// </summary>
	public AdgBrowserItem GetSelectedItem() {
		if (!HasSelection) {
			throw new InvalidOperationException("No item is selected.");
		}
		return Items[_selectedIndex];
	}
}