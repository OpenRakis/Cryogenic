using Cryogenic;

using Spice86.Core.CLI;

// Configure command-line arguments for Spice86 execution
List<string> newArgs = args.ToList();
//newArgs.AddRange("-m /mnt/c/mt32-rom-data -d true -e /mnt/c/Jeux/ABWFR/DUNE_CD/C/DNCDPRG.EXE -a \"MID330 SBP2227\" --UseCodeOverride true".Split(" "));

// Inject the custom interrupt handler segment address into the configuration
// This reserves segment 0x800 for BIOS/IRQ handlers, freeing 0xF000 for driver3
newArgs.Add($"--{nameof(Configuration.ProvidedAsmHandlersSegment)}={DriverLoadToolbox.INTERRUPT_HANDLER_SEGMENT}");

// Launch Spice86 with the DuneCdOverrideSupplier and verify the DNCDPRG.EXE checksum
// The SHA256 checksum ensures we're running against the expected version of the DOS executable
global::Spice86.Program.RunWithOverrides<DuneCdOverrideSupplier>(newArgs.ToArray(), "5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9");

/// <summary>
/// Entry point class for the Cryogenic application.
/// </summary>
/// <remarks>
/// This partial class serves as the main entry point for running the Dune CD game
/// through Spice86 with custom C# overrides. The top-level statements handle
/// argument configuration and program launch.
/// </remarks>
public partial class Program {
}