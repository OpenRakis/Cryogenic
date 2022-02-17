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

public class GlobalsOnCsSegment0x1ED : MemoryBasedDataStructureWithBaseAddress
{
    public GlobalsOnCsSegment0x1ED(Machine machine): base(machine.GetMemory(), 0x1ED * 0x10)
    {
    }

    // Getters and Setters for address 0x1ED:0xAA/0x1F7A.
    // Operation not registered by running code
    public  int Get01ED_00AA_Word16()
    {
        return GetUint16(0xAA);
    }

    // Was accessed via the following registers: CS
    public  void Set01ED_00AA_Word16(ushort value)
    {
        SetUint16(0xAA, value);
    }

    // Getters and Setters for address 0x1ED:0xAC/0x1F7C.
    // Operation not registered by running code
    public  int Get01ED_00AC_Word16()
    {
        return GetUint16(0xAC);
    }

    // Was accessed via the following registers: CS
    public  void Set01ED_00AC_Word16(ushort value)
    {
        SetUint16(0xAC, value);
    }

    // Getters and Setters for address 0x1ED:0xAE/0x1F7E.
    // Operation not registered by running code
    public  int Get01ED_00AE_Word16()
    {
        return GetUint16(0xAE);
    }

    // Was accessed via the following registers: CS
    public  void Set01ED_00AE_Word16(ushort value)
    {
        SetUint16(0xAE, value);
    }

    // Getters and Setters for address 0x1ED:0xB0/0x1F80.
    // Operation not registered by running code
    public  int Get01ED_00B0_Word16()
    {
        return GetUint16(0xB0);
    }

    // Was accessed via the following registers: CS
    public  void Set01ED_00B0_Word16(ushort value)
    {
        SetUint16(0xB0, value);
    }

    // Getters and Setters for address 0x1ED:0xA6D3/0xC5A3.
    // Operation not registered by running code
    public  int Get01ED_A6D3_Byte8()
    {
        return GetUint8(0xA6D3);
    }

    // Was accessed via the following registers: CS
    public  void Set01ED_A6D3_Byte8(byte value)
    {
        SetUint8(0xA6D3, value);
    }

    // Getters and Setters for address 0x1ED:0xC13C/0xE00C.
    // Operation not registered by running code
    public  int Get01ED_C13C_Byte8()
    {
        return GetUint8(0xC13C);
    }

    // Was accessed via the following registers: CS
    public  void Set01ED_C13C_Byte8(byte value)
    {
        SetUint8(0xC13C, value);
    }

    // Getters and Setters for address 0x1ED:0xC21A/0xE0EA.
    // Was accessed via the following registers: CS
    public  int Get01ED_C21A_Byte8_paletteOffset()
    {
        return GetUint8(0xC21A);
    }

    // Was accessed via the following registers: CS
    public  void Set01ED_C21A_Byte8_paletteOffset(byte value)
    {
        SetUint8(0xC21A, value);
    }

    // Getters and Setters for address 0x1ED:0xCC94/0xEB64.
    // Operation not registered by running code
    public  int Get01ED_CC94_Word16_blitFunction()
    {
        return GetUint16(0xCC94);
    }

    // Was accessed via the following registers: CS
    public  void Set01ED_CC94_Word16_blitFunction(byte value)
    {
        SetUint16(0xCC94, value);
    }

    // Getters and Setters for address 0x1ED:0xE8D2/0x107A2.
    // Was accessed via the following registers: CS
    public  int Get01ED_E8D2_Word16_pitTimerValue()
    {
        return GetUint16(0xE8D2);
    }

    // Was accessed via the following registers: CS
    public  void Set01ED_E8D2_Word16_pitTimerValue(ushort value)
    {
        SetUint16(0xE8D2, value);
    }

    // Getters and Setters for address 0x1ED:0xE8D4/0x107A4.
    // Was accessed via the following registers: CS
    public  int Get01ED_E8D4_Byte8_pitTimerCounter()
    {
        return GetUint8(0xE8D4);
    }

    // Was accessed via the following registers: CS
    public  void Set01ED_E8D4_Byte8_pitTimerCounter(byte value)
    {
        SetUint8(0xE8D4, value);
    }

    // Getters and Setters for address 0x1ED:0xED3A/0x10C0A.
    // Was accessed via the following registers: CS
    public  int Get01ED_ED3A_Word16_emsEmmHandle()
    {
        return GetUint16(0xED3A);
    }

    // Operation not registered by running code
    public  void Set01ED_ED3A_Word16_emsEmmHandle(ushort value)
    {
        SetUint16(0xED3A, value);
    }

    // Getters and Setters for address 0x1ED:0xED3E/0x10C0E.
    // Was accessed via the following registers: CS
    public  int Get01ED_ED3E_Word16()
    {
        return GetUint16(0xED3E);
    }

    // Operation not registered by running code
    public  void Set01ED_ED3E_Word16(ushort value)
    {
        SetUint16(0xED3E, value);
    }

    // Getters and Setters for address 0x1ED:0xEE8A/0x10D5A.
    // Was accessed via the following registers: CS
    public  int Get01ED_EE8A_Word16_xmsMemoryBlock()
    {
        return GetUint16(0xEE8A);
    }

    // Operation not registered by running code
    public  void Set01ED_EE8A_Word16_xmsMemoryBlock(ushort value)
    {
        SetUint16(0xEE8A, value);
    }
}
