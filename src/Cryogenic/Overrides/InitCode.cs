namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.ReverseEngineer;

using System;

/// <summary>
/// Partial class containing game initialization related overrides.
/// </summary>
/// <remarks>
/// Method names contain underscores to separate segment, offset, and linear addresses
/// for traceability back to the original DOS disassembly.
/// </remarks>
public partial class Overrides {
    /// <summary>
    /// Registers game initialization function overrides with Spice86.
    /// </summary>
    public void DefineInitCodeOverrides() {
        DefineFunction(cs1, 0xDA53, VgaInitRelated_1000_DA53_01DA53);
    }

    /// <summary>
    /// Override for CS1:DA53 - Initializes VGA-related global variables to zero.
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <remarks>
    /// Called during game initialization to clear VGA-related state variables.
    /// Sets DS:DC6A (16-bit) and DS:46D7 (8-bit) to zero.
    /// </remarks>
    public Action VgaInitRelated_1000_DA53_01DA53(int gotoAddress) {
        this.globalsOnDs.Set1138_DC6A_Word16(0);
        this.globalsOnDs.Set1138_46D7_Byte8(0);
        return NearRet();
    }
}