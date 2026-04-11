namespace Cryogenic.Mt32DriverDebug.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// View model for a single DNMID driver channel row in the tracker panel.
/// Updated periodically from <see cref="DnmidDriverState"/> memory reads.
/// </summary>
public sealed partial class DriverChannelRowViewModel : ObservableObject {
	/// <summary>Zero-based channel index within the DNMID driver.</summary>
	public int ChannelIndex { get; }

	/// <summary>Tick wait counter in hex (FFFF = end-of-stream / parked).</summary>
	[ObservableProperty]
	private string _tickCounter = "----";

	/// <summary>Event stream pointer in hex.</summary>
	[ObservableProperty]
	private string _eventPointer = "----";

	/// <summary>Original start offset from song header (hex).</summary>
	[ObservableProperty]
	private string _startOffset = "----";

	/// <summary>Channel base volume (0..127) for CC7 scaling.</summary>
	[ObservableProperty]
	private string _baseVolume = "---";

	/// <summary>Saved wait counter for loop restore (hex).</summary>
	[ObservableProperty]
	private string _snapshotWait = "----";

	/// <summary>Saved event pointer for loop restore (hex).</summary>
	[ObservableProperty]
	private string _snapshotPointer = "----";

	/// <summary>Whether the channel is parked (tick = 0xFFFF).</summary>
	[ObservableProperty]
	private bool _isParked = true;

	/// <summary>Channel status label for display ("Active", "Parked", "Idle").</summary>
	[ObservableProperty]
	private string _status = "Idle";

	/// <summary>
	/// Initializes a channel row for the given index.
	/// </summary>
	/// <param name="channelIndex">Zero-based channel index.</param>
	public DriverChannelRowViewModel(int channelIndex) {
		ChannelIndex = channelIndex;
	}
}