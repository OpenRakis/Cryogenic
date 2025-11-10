namespace Cryogenic.Overrides;
using System;

/// <summary>
/// Partial class containing Roland MT-32 MIDI driver overrides.
/// </summary>
/// <remarks>
/// Provides C# implementations for the DNMID MIDI driver functions.
/// The MT-32 was a popular MIDI synthesizer module used for music in DOS games.
/// </remarks>
public partial class Overrides {

    /// <summary>
    /// Registers MT-32 MIDI driver function overrides with Spice86.
    /// </summary>
    /// <remarks>
    /// Defines function entry points at segment 0xF000 where the MIDI driver is loaded.
    /// </remarks>
    public void DefineMT32DriverCodeOverrides() {
        DefineFunction(0xF000, 0x100, DNMID_entry_00, true, nameof(DNMID_entry_00));
        DefineFunction(0xF000, 0x100 + 0x17b, DNMID_entry_01, true, nameof(DNMID_entry_01));
        DefineFunction(0xF000, 0x1CB, DNMID_internal_function_00, true, nameof(DNMID_internal_function_00));
    }

    /// <summary>
    /// MIDI driver entry point 01 - Handles MIDI output operations.
    /// </summary>
    /// <param name="arg">Jump target argument (unused in this implementation).</param>
    /// <returns>A near jump action based on the XOR result.</returns>
    /// <remarks>
    /// Performs XOR on AX register with itself (clearing it) and conditionally outputs
    /// to MIDI port 0x330 based on the result. This likely handles MIDI reset or silence operations.
    /// </remarks>
    private Action DNMID_entry_01(int arg) {
        var result = Alu16.Xor(AX, AX);
        if (result == 0) {
            return NearJump(0x04);
        }
        Cpu.Out16(0x330, AX);
        return NearJump(0x0);
    }

    /// <summary>
    /// MIDI driver entry point 00 - Primary entry delegating to entry point 01.
    /// </summary>
    /// <param name="arg">Jump target argument (unused in this implementation).</param>
    /// <returns>Action returned by DNMID_entry_01.</returns>
    /// <remarks>
    /// Immediately delegates to DNMID_entry_01. The commented-out NearJump(0x17b)
    /// suggests this may have had alternative behavior in earlier implementations.
    /// </remarks>
    private Action DNMID_entry_00(int arg) {
        return DNMID_entry_01(0);
        //return NearJump(0x17b);
    }

    /// <summary>
    /// MIDI driver internal function 00 - Placeholder that does nothing.
    /// </summary>
    /// <param name="arg">Jump target argument (unused in this implementation).</param>
    /// <returns>A near return action to exit immediately.</returns>
    /// <remarks>
    /// This function appears to never be called during normal gameplay.
    /// It may be a stub for functionality that was planned but never implemented,
    /// or for error handling code that is rarely triggered.
    /// </remarks>
    private Action DNMID_internal_function_00(int arg) {
        return NearRet();
    }
}
