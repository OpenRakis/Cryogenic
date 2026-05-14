namespace Cryogenic.AdgPlayer.Ui.Behaviors;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Threading;
using Avalonia.Xaml.Interactivity;

using System.Collections.Specialized;
using System.Threading;

/// <summary>
/// XAML behavior that auto-scrolls a ListBox to the last item when new items are added.
/// Reused by all ADG scrolling panels (events, OPL writes, logs).
/// </summary>
public sealed class ScrollToEndBehavior : Behavior<ListBox> {
	private INotifyCollectionChanged? _trackedCollection;
	private int _scrollScheduled;

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
		if (AssociatedObject?.ItemsSource is INotifyCollectionChanged notifyCollectionChanged) {
			_trackedCollection = notifyCollectionChanged;
			notifyCollectionChanged.CollectionChanged += OnCollectionChanged;
		}
	}

	private void UnhookCollection() {
		if (_trackedCollection is not null) {
			_trackedCollection.CollectionChanged -= OnCollectionChanged;
			_trackedCollection = null;
		}
	}

	private void OnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e) {
		if (e.Action != NotifyCollectionChangedAction.Add || AssociatedObject is null) {
			return;
		}

		if (Interlocked.Exchange(ref _scrollScheduled, 1) != 0) {
			return;
		}

		Dispatcher.UIThread.Post(() => {
			Interlocked.Exchange(ref _scrollScheduled, 0);
			if (AssociatedObject is null) {
				return;
			}

			int count = AssociatedObject.ItemCount;
			if (count > 0) {
				AssociatedObject.ScrollIntoView(count - 1);
			}
		}, DispatcherPriority.Background);
	}
}