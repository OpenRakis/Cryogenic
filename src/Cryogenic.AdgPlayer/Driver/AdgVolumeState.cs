namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Mutable holder for the ADG driver's master volume, dynamics, and
/// fade-pattern state. Faithful port of the three-byte cluster at
/// <c>AdgMasterVolumeOffset</c> (0x04D8), <c>AdgDynamicsOffset</c> (0x04D7),
/// and <c>AdgFadePatternOffset</c> (0x01E0) updated by
/// <c>AdgSetVolume_564B_05AB_056A5B</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public sealed class AdgVolumeState {
	/// <summary>Current master volume (low byte of scaled AX).</summary>
	public byte MasterVolume { get; private set; }

	/// <summary>Current dynamics target (mirrors <see cref="MasterVolume"/>
	/// after <see cref="SetVolume"/>).</summary>
	public byte Dynamics { get; private set; }

	/// <summary>Current fade cadence pattern.</summary>
	public AdgFadePattern FadePattern { get; private set; } = AdgFadePattern.Immediate;

	/// <summary>
	/// Scales <paramref name="ax"/> through <see cref="AdgVolumeScaler.Scale"/>,
	/// writes the low byte of the result into both <see cref="MasterVolume"/>
	/// and <see cref="Dynamics"/>, and forces the fade pattern to
	/// <see cref="AdgFadePattern.Immediate"/>.
	/// </summary>
	public void SetVolume(ushort ax) {
		ushort scaled = AdgVolumeScaler.Scale(ax);
		byte scaledLow = (byte)(scaled & 0xFF);
		MasterVolume = scaledLow;
		Dynamics = scaledLow;
		FadePattern = AdgFadePattern.Immediate;
	}

	/// <summary>
	/// Replaces the current fade pattern. Used by other entry points
	/// (e.g. fade-out at 564B:0535) that update the cadence without
	/// altering the volume bytes.
	/// </summary>
	public void SetFadePattern(AdgFadePattern pattern) {
		FadePattern = pattern;
	}

	/// <summary>
	/// Replaces only the dynamics target byte. Used by the dynamics
	/// path (<c>AdgSetDynamics_564B_05BE</c>) which mutates dynamics
	/// without touching <see cref="MasterVolume"/>.
	/// </summary>
	public void SetDynamics(byte dynamics) {
		Dynamics = dynamics;
	}
}