namespace Cryogenic.Globals;

using Cryogenic.Generated;

using Spice86.Emulator.VM;

// Non generated code for values that could not be detected by running the game
public class ExtraGlobalsOnDs : GlobalsOnDs
{
    public ExtraGlobalsOnDs(Machine machine): base(machine)
    {
    }

    public  ushort GetMenuType()
    {

        // menu displayed and associated actions depend on this value
        return this.GetUint16(Get1138_21DA_Word16_OffsetToMenuType());
    }

    public  uint Get1138_DC04_DWord32_hnmFileOffset()
    {
        return GetUint32(0xDC04);
    }

    public  void Set1138_DC04_DWord32_hnmFileOffset(uint value)
    {
        SetUint32(0xDC04, value);
    }

    public  uint Get1138_DC08_DWord32_hnmFileRemain()
    {
        return GetUint32(0xDC08);
    }

    public  void Set1138_DC08_DWord32_hnmFileRemain(uint value)
    {
        SetUint32(0xDC08, value);
    }
}
