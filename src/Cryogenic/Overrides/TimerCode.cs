namespace Cryogenic.Overrides;

using System;

/// <summary>
/// Partial class containing hardware timer (PIT 8254) related overrides.
/// </summary>
/// <remarks>
/// Method names contain underscores to separate segment, offset, and linear addresses
/// for traceability back to the original DOS disassembly.
/// </remarks>
public partial class Overrides {
	/// <summary>
	/// Registers hardware timer function overrides with Spice86.
	/// </summary>
	public void DefineTimerCodeOverrides() {
		DefineFunction(cs1, 0xE8A8, SetPitTimerToAX_1000_E8A8_01E8A8);
	}

	/// <summary>
	/// Override for CS1:E8A8 - Configures the PIT (Programmable Interval Timer) 8254 counter 0.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
	/// <returns>A near return action to exit the function.</returns>
	/// <remarks>
	/// <para>
	/// Sets up the system timer counter 0 with the value from AX register.
	/// The counter is configured in mode 3 (square wave generator) without BCD encoding.
	/// Uses direct PIT port I/O: control byte 0x36 to port 0x43 (channel 0, both bytes, mode 3,
	/// binary), then the reload value low and high bytes to port 0x40.
	/// </para>
	/// <para>
	/// This function appears to be called primarily during game shutdown to restore
	/// the system timer to its default state. The PIT controls the system clock
	/// interrupt frequency (IRQ 0).
	/// </para>
	/// </remarks>
	public Action SetPitTimerToAX_1000_E8A8_01E8A8(int gotoAddress) {
		// Seems only called on quit
		ushort valueToSet = AX;
		_loggerService.Debug("Setting timer 0 value to {@ValueToSet}", valueToSet);
		// Control byte 0x36: channel 0 (bits 7-6 = 00), both bytes LSB then MSB (bits 5-4 = 11),
		// mode 3 square wave (bits 3-1 = 011), binary (bit 0 = 0)
		Machine.Timer.WriteByte(0x43, 0x36);
		Machine.Timer.WriteByte(0x40, (byte)(valueToSet & 0xFF));
		Machine.Timer.WriteByte(0x40, (byte)(valueToSet >> 8));
		return NearRet();
	}
}