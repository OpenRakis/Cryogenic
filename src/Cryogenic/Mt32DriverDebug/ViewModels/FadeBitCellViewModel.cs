namespace Cryogenic.Mt32DriverDebug.ViewModels;

using Avalonia.Media;

using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// Represents a single bit in the 16-bit fade pattern rotation.
/// Used to render a visual grid of set/clear bits.
/// </summary>
public sealed partial class FadeBitCellViewModel : ObservableObject {
	private static readonly IBrush SetBrush = new SolidColorBrush(Color.FromRgb(0xE3, 0xB3, 0x41));
	private static readonly IBrush ClearBrush = new SolidColorBrush(Color.FromRgb(0x21, 0x26, 0x2D));

	/// <summary>Bit index (0 = MSB, 15 = LSB).</summary>
	public int BitIndex { get; }

	/// <summary>Whether this bit is set in the current fade pattern.</summary>
	[ObservableProperty]
	private bool _isSet;

	/// <summary>Display brush based on bit state.</summary>
	public IBrush CellBrush => IsSet ? SetBrush : ClearBrush;

	/// <summary>
	/// Initializes a bit cell at the given index.
	/// </summary>
	/// <param name="bitIndex">Bit position (0 = MSB).</param>
	public FadeBitCellViewModel(int bitIndex) {
		BitIndex = bitIndex;
	}

	/// <summary>
	/// Notify that CellBrush changed when IsSet changes.
	/// </summary>
	partial void OnIsSetChanged(bool value) {
		OnPropertyChanged(nameof(CellBrush));
	}
}