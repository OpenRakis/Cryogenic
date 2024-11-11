namespace Cryogenic.Generated;

using Spice86.Core.Emulator.CPU.Registers;
using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;
// Accessors for values accessed via register ES
public class GlobalsOnEs : MemoryBasedDataStructureWithEsBaseAddress {

    public GlobalsOnEs(IByteReaderWriter memory, SegmentRegisters segmentRegisters) : base(memory, segmentRegisters) {
    }

    // Getters and Setters for address 0x0:0x46C/0x46C.
    // Was accessed via the following registers: ES
    public int Get0000_046C_Word16() {
        return UInt16[0x46C];
    }

    // Getters and Setters for address 0x40:0x63/0x463.
    // Was accessed via the following registers: ES
    public int Get0040_0063_Word16() {
        return UInt16[0x63];
    }

    // Operation not registered by running code
    public void Set0000_046C_Word16(ushort value) {
        UInt16[0x46C] = value;
    }

    // Operation not registered by running code
    public void Set0040_0063_Word16(ushort value) {
        UInt16[0x63] = value;
    }
}