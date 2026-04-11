namespace Cryogenic.Mt32DriverDebug.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// Represents a single MIDI channel's base volume for the volume hierarchy view.
/// </summary>
public sealed partial class ChannelVolumeBarViewModel : ObservableObject {
	/// <summary>MIDI channel index (0..9).</summary>
	public int ChannelIndex { get; }

	/// <summary>Current base volume value (0..127).</summary>
	[ObservableProperty]
	private int _volume;

	/// <summary>
	/// Initializes a volume bar for the given MIDI channel.
	/// </summary>
	/// <param name="channelIndex">MIDI channel index.</param>
	public ChannelVolumeBarViewModel(int channelIndex) {
		ChannelIndex = channelIndex;
	}
}