namespace Cryogenic.Globals;

using Cryogenic.Generated;

using Spice86.Core.Emulator.Memory.ReaderWriter;

/// <summary>
/// Extends the generated GlobalsOnCsSegment0x2538 class with additional manually-defined accessors
/// for game state values that could not be automatically detected during runtime analysis.
/// </summary>
/// <remarks>
/// This class provides access to global variables stored at the CS segment 0x2538.
/// Values here represent game state that was not captured by the automated code generation tools.
/// </remarks>
public class ExtraGlobalsOnCsSegment0x2538 : GlobalsOnCsSegment0x2538 {

    /// <summary>
    /// Initializes a new instance of the <see cref="ExtraGlobalsOnCsSegment0x2538"/> class.
    /// </summary>
    /// <param name="memory">The memory reader/writer interface for accessing emulated memory.</param>
    /// <param name="baseAddress">The base address of the CS segment 0x2538 in physical memory.</param>
    public ExtraGlobalsOnCsSegment0x2538(IByteReaderWriter memory, uint baseAddress) : base(memory, baseAddress) {
    }
}