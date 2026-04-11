namespace Cryogenic.Mt32Player.Behaviors;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Xaml.Interactivity;

using System.Collections.Specialized;

/// <summary>
/// XAML behavior that auto-scrolls a ListBox to the last item when new items are added.
/// Attach via Interaction.Behaviors in AXAML. Requires Xaml.Behaviors.Avalonia package.
/// Watches for ItemsSource property changes so it re-hooks when the binding resolves
/// after the behavior is attached.
/// </summary>
public sealed class ScrollToEndBehavior : Behavior<ListBox> {
    private INotifyCollectionChanged? _trackedCollection;

    protected override void OnAttached() {
        base.OnAttached();
        if (AssociatedObject is not null) {
            AssociatedObject.PropertyChanged += OnPropertyChanged;
        }
        HookCollection();
    }

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