// C# Script to disassemble DNMID.UNHSQ using Iced x86 disassembler
// Run with: dotnet script disasm_dnmid.csx
// Or: dotnet run in a small console project

using System;
using System.IO;

// Manual 16-bit x86 disassembly of DNMID.UNHSQ
// Since we don't have Iced available as a script, decode the JMP table and key functions manually

var bytes = File.ReadAllBytes(@"C:\Users\noalm\source\repos\Cryogenic\doc\DUNECDVF\C\DUNECD\DUNE.DAT_\DNMID.UNHSQ");
Console.WriteLine($"DNMID.UNHSQ size: {bytes.Length} bytes (0x{bytes.Length:X3})");

// Entry JMP table (7 far JMPs at E9 xx xx)
Console.WriteLine("\n=== ENTRY JUMP TABLE ===");
int pos = 0;
string[] entryNames = { "Init", "Open", "Reset", "SetTimerTickFlag", "SetVelocityMapping", "Tick", "SetVolume" };
for (int i = 0; i < 7; i++)
{
    if (bytes[pos] == 0xE9)
    {
        short rel = (short)(bytes[pos + 1] | (bytes[pos + 2] << 8));
        int target = pos + 3 + rel;
        Console.WriteLine($"  {pos:X4}: JMP {target:X4}  ; Entry {i}: {entryNames[i]}");
        pos += 3;
    }
}

Console.WriteLine($"\n=== DATA AREA 0x{pos:X4} - 0x00A4 ===");
// Known data offsets
Console.WriteLine($"  0x0015: Song data ptr   = {bytes[0x15]:X2}{bytes[0x16]:X2}:{bytes[0x17]:X2}{bytes[0x18]:X2}");
Console.WriteLine($"  0x0019: Event data ptr  = {bytes[0x19]:X2}{bytes[0x1A]:X2}:{bytes[0x1B]:X2}{bytes[0x1C]:X2}");
Console.WriteLine($"  0x001D: Tick counter    = {bytes[0x1D]:X2}{bytes[0x1E]:X2}");
Console.WriteLine($"  0x001F: Measure number  = {bytes[0x1F]:X2}{bytes[0x20]:X2}");
Console.WriteLine($"  0x0021: Subdivision     = {bytes[0x21]:X2}{bytes[0x22]:X2}");
Console.WriteLine($"  0x0023: Loop counter    = {bytes[0x23]:X2}{bytes[0x24]:X2}");
Console.WriteLine($"  0x0025: MIDI port base  = {(bytes[0x26] << 8 | bytes[0x25]):X4}");
Console.WriteLine($"  0x0027: Delay count     = {(bytes[0x28] << 8 | bytes[0x27]):X4}");
Console.WriteLine($"  0x0029: Dispatch table  (8 words):");
for (int i = 0; i < 8; i++)
{
    int off = 0x29 + i * 2;
    ushort val = (ushort)(bytes[off] | (bytes[off + 1] << 8));
    Console.WriteLine($"           [{i}] = 0x{val:X4}");
}
Console.WriteLine($"  0x0039: Status flags    = 0x{bytes[0x39]:X2}");
Console.WriteLine($"  0x003A: Timer tick flag = 0x{bytes[0x3A]:X2}");
Console.WriteLine($"  0x003B: Fade pattern    = {(bytes[0x3C] << 8 | bytes[0x3B]):X4}");
Console.WriteLine($"  0x003D: Current volume  = 0x{bytes[0x3D]:X2}");
Console.WriteLine($"  0x003E: Target volume   = 0x{bytes[0x3E]:X2}");
Console.WriteLine($"  0x003F: Master volume   = 0x{bytes[0x3F]:X2}");
Console.WriteLine($"  0x00A5: Extension bytes = {(char)bytes[0xA5]}{(char)bytes[0xA6]}{(char)bytes[0xA7]}");
