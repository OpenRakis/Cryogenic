namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Fade cadence patterns rotated by the ADG driver to control fade speed.
/// Mirrors <c>AdgFadePattern</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public enum AdgFadePattern : ushort {
	/// <summary>Single terminal step when target volume is reached.</summary>
	SingleStep = 0x0001,
	/// <summary>Fastest repeating fade cadence.</summary>
	Fastest = 0x8000,
	/// <summary>Fast repeating fade cadence.</summary>
	Fast = 0x8080,
	/// <summary>Medium repeating fade cadence.</summary>
	Medium = 0x8888,
	/// <summary>Slow repeating fade cadence.</summary>
	Slow = 0xAAAA,
	/// <summary>Immediate transition (no staggered fade cadence).</summary>
	Immediate = 0xFFFF
}