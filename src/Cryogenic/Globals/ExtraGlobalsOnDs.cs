namespace Cryogenic.Globals;

using Cryogenic.Generated;

using Spice86.Core.Emulator.VM;

// Non generated code for values that could not be detected by running the game
public class ExtraGlobalsOnDs : GlobalsOnDs {

    public ExtraGlobalsOnDs(Machine machine) : base(machine) {
    }

    public uint Get1138_DC04_DWord32_hnmFileOffset() {
        return UInt32[0xDC04];
    }

    public uint Get1138_DC08_DWord32_hnmFileRemain() {
        return UInt32[0xDC08];
    }

    public ushort GetMenuType() {
        // menu displayed and associated actions depend on this value
        return this.UInt16[Get1138_21DA_Word16_OffsetToMenuType()];
    }

    public void Set1138_DC04_DWord32_hnmFileOffset(uint value) {
        UInt32[0xDC04] = value;
    }

    public void Set1138_DC08_DWord32_hnmFileRemain(uint value) {
        UInt32[0xDC08] = value;
    }
}