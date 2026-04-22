namespace Cryogenic.AdpPlayer.ViewModels;

/// <summary>
/// Display item for OPL register writes in the UI.
/// </summary>
public sealed class OplWriteItem {
	/// <summary>OPL register address.</summary>
	public ushort Register { get; set; }

	/// <summary>Value written.</summary>
	public byte Value { get; set; }

	/// <summary>Tick count when write occurred.</summary>
	public long Tick { get; set; }

	/// <summary>Human-readable register description.</summary>
	public string RegisterName => Register switch {
		>= 0x20 and <= 0x35 => $"AM/VIB  op={Register - 0x20:X2}",
		>= 0x40 and <= 0x55 => $"KSL/TL  op={Register - 0x40:X2}",
		>= 0x60 and <= 0x75 => $"AR/DR   op={Register - 0x60:X2}",
		>= 0x80 and <= 0x95 => $"SL/RR   op={Register - 0x80:X2}",
		>= 0xA0 and <= 0xA8 => $"FreqLo  ch={Register - 0xA0}",
		>= 0xB0 and <= 0xB8 => $"FreqHi  ch={Register - 0xB0}",
		0xBD => "Rhythm",
		>= 0xC0 and <= 0xC8 => $"FeedCon ch={Register - 0xC0}",
		>= 0xE0 and <= 0xF5 => $"Wave    op={Register - 0xE0:X2}",
		0x01 or 0x20 => "Test/WSEnable",
		0x08 => "CSM/KBSplit",
		_ => $"Reg 0x{Register:X3}"
	};

	/// <summary>Formatted display string.</summary>
	public string Display => $"[{Tick,8}] {RegisterName,-18} = 0x{Value:X2}";
}