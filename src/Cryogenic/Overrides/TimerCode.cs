namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Devices.Timer;

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
        Timer timer = Machine.Timer;
        Pit8254Counter counter = timer.GetCounter(0);
        counter.ReadWritePolicy = 0;
        counter.Mode = 3;
        counter.Bcd = false;
        counter.Configure(valueToSet);
        return NearRet();
    }
}