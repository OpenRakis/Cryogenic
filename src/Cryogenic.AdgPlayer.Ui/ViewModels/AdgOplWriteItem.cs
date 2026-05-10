namespace Cryogenic.AdgPlayer.Ui.ViewModels;

/// <summary>
/// One row in the OPL register-write capture panel.
/// Immutable snapshot of one <see cref="Cryogenic.AdgPlayer.Opl.OplWrite"/>
/// observed by an <see cref="Cryogenic.AdgPlayer.Ui.Opl.OplCaptureBus"/>.
/// </summary>
public sealed class AdgOplWriteItem {
	/// <summary>Monotonic capture sequence number.</summary>
	public long Sequence { get; }

	/// <summary>OPL3 chip selector (0 = primary, 1 = secondary).</summary>
	public int Chip { get; }

	/// <summary>OPL3 register address (0..0xFF).</summary>
	public byte Register { get; }

	/// <summary>Value written to the register.</summary>
	public byte Value { get; }

	/// <summary>Builds an immutable display row.</summary>
	public AdgOplWriteItem(long sequence, int chip, byte register, byte value) {
		Sequence = sequence;
		Chip = chip;
		Register = register;
		Value = value;
	}
}