namespace Cryogenic.Generated;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using Serilog;

// Accessors for values accessed via register ES
public class GlobalsOnEs : MemoryBasedDataStructureWithEsBaseAddress
{
    public GlobalsOnEs(Machine machine): base(machine)
    {
    }

    // Getters and Setters for address 0x40:0x63/0x463.
    // Was accessed via the following registers: ES
    public  int Get0040_0063_Word16()
    {
        return GetUint16(0x63);
    }

    // Operation not registered by running code
    public  void Set0040_0063_Word16(ushort value)
    {
        SetUint16(0x63, value);
    }

    // Getters and Setters for address 0x0:0x46C/0x46C.
    // Was accessed via the following registers: ES
    public  int Get0000_046C_Word16()
    {
        return GetUint16(0x46C);
    }

    // Operation not registered by running code
    public  void Set0000_046C_Word16(ushort value)
    {
        SetUint16(0x46C, value);
    }
}
