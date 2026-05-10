namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Composes the dynamics-update entry point of the ADG driver. Faithful
/// port of <c>AdgSetDynamics_564B_05BE_056A6E</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>: scales the dynamics
/// input, picks a fade cadence from the current track-position word, and
/// raises <see cref="AdgPlaybackStatus.FadePending"/> if a song is
/// currently active.
/// </summary>
public sealed class AdgDynamicsService {
	private readonly AdgVolumeState _volume;
	private readonly AdgPlaybackState _playback;

	/// <summary>
	/// Creates a service bound to the supplied volume and playback state
	/// holders. Both must be non-null.
	/// </summary>
	public AdgDynamicsService(AdgVolumeState volume, AdgPlaybackState playback) {
		ArgumentNullException.ThrowIfNull(volume);
		ArgumentNullException.ThrowIfNull(playback);
		_volume = volume;
		_playback = playback;
	}

	/// <summary>
	/// Applies a dynamics change.
	/// </summary>
	/// <param name="dynamicsBx">
	/// 16-bit dynamics input (BX in the original disasm); scaled through
	/// <see cref="AdgVolumeScaler.Scale"/> and stored as the low byte of
	/// the result into <see cref="AdgVolumeState.Dynamics"/>.
	/// </param>
	/// <param name="trackPositionAx">
	/// 16-bit caller-saved AX value used for fade-pattern selection via
	/// <see cref="AdgFadePatternSelector.Select"/>.
	/// </param>
	public void Apply(ushort dynamicsBx, ushort trackPositionAx) {
		ushort scaled = AdgVolumeScaler.Scale(dynamicsBx);
		_volume.SetDynamics((byte)(scaled & 0xFF));

		AdgFadePattern pattern = AdgFadePatternSelector.Select(trackPositionAx);
		_volume.SetFadePattern(pattern);

		_playback.RequestFadeIfActive();
	}
}