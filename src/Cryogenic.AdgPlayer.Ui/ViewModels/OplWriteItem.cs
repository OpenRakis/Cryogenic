namespace Cryogenic.AdgPlayer.Ui.ViewModels;

/// <summary>
/// Display item for OPL register writes in the UI.
/// Decodes the AdLib Gold dual-bank OPL3 address space: high byte of <see cref="Register"/>
/// selects the logical register bank:
/// 0 = primary FM, 1 = secondary FM / OPL3 extension bank, 2 = AdLib Gold control path.
/// </summary>
public sealed class OplWriteItem {
	/// <summary>16-bit OPL address: (chip &lt;&lt; 8) | reg.</summary>
	public ushort Register { get; set; }

	/// <summary>Value written.</summary>
	public byte Value { get; set; }

	/// <summary>Tick count when write occurred.</summary>
	public long Tick { get; set; }

	/// <summary>Chip bank selector decoded from the high byte of <see cref="Register"/>.</summary>
	public int Chip => Register >> 8;

	/// <summary>Per-bank register index decoded from the low byte of <see cref="Register"/>.</summary>
	public byte Reg => (byte)(Register & 0xFF);

	/// <summary>Human-readable register description (AdLib Gold / OPL3-aware).</summary>
	public string RegisterName {
		get {
			byte r = Reg;
			if (Chip == 2) {
				return r switch {
					0x04 => "GoldStereoLeft",
					0x05 => "GoldStereoRight",
					0x06 => "GoldBass",
					0x07 => "GoldTreble",
					0x08 => "GoldSwitchFn",
					0x09 => "GoldFmVolL",
					0x0A => "GoldFmVolR",
					0x18 => "GoldSurround",
					_ => $"GoldReg 0x{r:X2}"
				};
			}

			if (Chip == 1) {
				switch (r) {
					case 0x04: return "4OpMask";        // OPL3 4-operator enable bitmap
					case 0x05: return "OPL3Enable";     // OPL3 mode flag (NEW bit)
				}
			}
			return r switch {
				>= 0x20 and <= 0x35 => $"AM/VIB  op={r - 0x20:X2}",
				>= 0x40 and <= 0x55 => $"KSL/TL  op={r - 0x40:X2}",
				>= 0x60 and <= 0x75 => $"AR/DR   op={r - 0x60:X2}",
				>= 0x80 and <= 0x95 => $"SL/RR   op={r - 0x80:X2}",
				>= 0xA0 and <= 0xA8 => $"FreqLo  ch={r - 0xA0}",
				>= 0xB0 and <= 0xB8 => $"FreqHi  ch={r - 0xB0}",
				0xBD => "Rhythm",
				>= 0xC0 and <= 0xC8 => $"FeedCon ch={r - 0xC0}",
				>= 0xE0 and <= 0xF5 => $"Wave    op={r - 0xE0:X2}",
				0x01 => "Test/WSEnable",
				0x08 => "CSM/KBSplit",
				_ => $"Reg 0x{r:X2}"
			};
		}
	}

	/// <summary>Formatted display string with AdLib Gold chip prefix.</summary>
	public string Display => $"[{Tick,8}] c{Chip} {RegisterName,-22} = 0x{Value:X2}";
}