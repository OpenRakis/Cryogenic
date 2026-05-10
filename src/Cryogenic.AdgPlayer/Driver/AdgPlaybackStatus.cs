namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Bitfield for the byte at <c>AdgStatusOffset</c> (0x01DE) in the ADG
/// driver. Mirrors the original <c>AdgPlaybackStatus</c> enum from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
[Flags]
public enum AdgPlaybackStatus : byte {
	/// <summary>Idle: no song loaded, no pending state.</summary>
	None = 0x00,

	/// <summary>Pending fade transition; raised when a dynamics change
	/// is requested while a song is active.</summary>
	FadePending = 0x40,

	/// <summary>A song is currently loaded and being scheduled.</summary>
	Active = 0x80
}