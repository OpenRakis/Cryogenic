namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Mutable holder for the ADG driver's playback status byte (offset
/// 0x01DE in the runtime driver image). Implements the bit transitions
/// observed in <c>AdgSetDynamics_564B_05BE_056A6E</c> and surrounding
/// code in <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public sealed class AdgPlaybackState {
	/// <summary>Current raw status byte (combination of
	/// <see cref="AdgPlaybackStatus"/> flags).</summary>
	public AdgPlaybackStatus Status { get; private set; } = AdgPlaybackStatus.None;

	/// <summary>True when <see cref="AdgPlaybackStatus.Active"/> is set.</summary>
	public bool IsActive => (Status & AdgPlaybackStatus.Active) != 0;

	/// <summary>
	/// Marks playback as active (used after a successful song open).
	/// </summary>
	public void SetActive() {
		Status |= AdgPlaybackStatus.Active;
	}

	/// <summary>
	/// If a song is active, raises <see cref="AdgPlaybackStatus.FadePending"/>.
	/// Faithful port of:
	/// <code>
	/// test byte ptr [01DE],0x80
	/// jz   short done
	/// or   byte ptr [01DE],0x40
	/// </code>
	/// </summary>
	public void RequestFadeIfActive() {
		if (IsActive) {
			Status |= AdgPlaybackStatus.FadePending;
		}
	}

	/// <summary>Clears all status flags (driver reset / song close).</summary>
	public void Clear() {
		Status = AdgPlaybackStatus.None;
	}
}