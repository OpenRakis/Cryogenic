namespace Cryogenic.AdpPlayer.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

public sealed partial class ChannelTrackerRowViewModel : ObservableObject {
	public int ChannelIndex { get; }

	[ObservableProperty]
	private string _wait = "FFFF";

	[ObservableProperty]
	private string _pointer = "0000";

	[ObservableProperty]
	private string _lastEvent = "-";

	public ChannelTrackerRowViewModel(int channelIndex) {
		ChannelIndex = channelIndex;
	}
}