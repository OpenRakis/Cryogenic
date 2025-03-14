﻿using Cryogenic;

using Spice86.Core.CLI;

List<string> newArgs = args.ToList();
//newArgs.AddRange("-m /mnt/c/mt32-rom-data -d true -e /mnt/c/Jeux/ABWFR/DUNE_CD/C/DNCDPRG.EXE -a \"MID330 SBP2227\" --UseCodeOverride true".Split(" "));
newArgs.Add($"--{nameof(Configuration.ProvidedAsmHandlersSegment)}={DriverLoadToolbox.INTERRUPT_HANDLER_SEGMENT}");

// Put the SHA256 checksum of your target DOS program here.
global::Spice86.Program.RunWithOverrides<DuneCdOverrideSupplier>(newArgs.ToArray(), "5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9");

public partial class Program {
}