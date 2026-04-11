namespace Cryogenic.Mt32DriverDebug.Behaviors;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Xaml.Interactivity;

using System.Collections.Specialized;

/// <summary>
/// XAML behavior that auto-scrolls a ListBox to the last item when new items are added.
/// Watches for ItemsSource changes to re-hook when the binding resolves after attach.
/// </summary>
public sealed class ScrollToEndBehavior : Behavior<ListBox> {
	private INotifyCollectionChanged? _trackedCollection;

	/// <inheritdoc />
	protected override void OnAttached() {
		base.OnAttached();
		if (AssociatedObject is not null) {
			AssociatedObject.PropertyChanged += OnPropertyChanged;
		}
		HookCollection();
	}

	/// <inheritdoc />
	protected override void OnDetaching() {
		if (AssociatedObject is not null) {
			AssociatedObject.PropertyChanged -= OnPropertyChanged;
		}
		UnhookCollection();
		base.OnDetaching();
	}

	private void OnPropertyChanged(object? sender, AvaloniaPropertyChangedEventArgs e) {
		if (e.Property == ItemsControl.ItemsSourceProperty) {
			HookCollection();
		}
	}

	private void HookCollection() {
		UnhookCollection();
		if (AssociatedObject?.ItemsSource is INotifyCollectionChanged ncc) {
			_trackedCollection = ncc;
			ncc.CollectionChanged += OnCollectionChanged;
		}
	}

	private void UnhookCollection() {
		if (_trackedCollection is not null) {
			_trackedCollection.CollectionChanged -= OnCollectionChanged;
			_trackedCollection = null;
		}
	}

	private void OnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e) {
		if (e.Action == NotifyCollectionChangedAction.Add && AssociatedObject is not null) {
			int count = AssociatedObject.ItemCount;
			if (count > 0) {
				AssociatedObject.ScrollIntoView(count - 1);
			}
		}
	}
}