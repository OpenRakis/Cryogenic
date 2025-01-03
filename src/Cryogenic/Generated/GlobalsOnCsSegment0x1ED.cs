namespace Cryogenic.Generated;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.ReverseEngineer.DataStructure;
using Spice86.Core.Emulator.VM;

public class GlobalsOnCsSegment0x1ED : MemoryBasedDataStructure {

    public GlobalsOnCsSegment0x1ED(IByteReaderWriter byteReaderWriter, uint baseAddress) : base(byteReaderWriter, baseAddress) {

    }

    // Getters and Setters for address 0x1ED:0xAA/0x1F7A.
    // Operation not registered by running code
    public int Get01ED_00AA_Word16() {
        return UInt16[0xAA];
    }

    // Getters and Setters for address 0x1ED:0xAC/0x1F7C.
    // Operation not registered by running code
    public int Get01ED_00AC_Word16() {
        return UInt16[0xAC];
    }

    // Getters and Setters for address 0x1ED:0xAE/0x1F7E.
    // Operation not registered by running code
    public int Get01ED_00AE_Word16() {
        return UInt16[0xAE];
    }

    // Getters and Setters for address 0x1ED:0xB0/0x1F80.
    // Operation not registered by running code
    public int Get01ED_00B0_Word16() {
        return UInt16[0xB0];
    }

    // Getters and Setters for address 0x1ED:0xA6D3/0xC5A3.
    // Operation not registered by running code
    public int Get01ED_A6D3_Byte8() {
        return UInt8[0xA6D3];
    }

    // Getters and Setters for address 0x1ED:0xC13C/0xE00C.
    // Operation not registered by running code
    public int Get01ED_C13C_Byte8() {
        return UInt8[0xC13C];
    }

    // Getters and Setters for address 0x1ED:0xC21A/0xE0EA.
    // Was accessed via the following registers: CS
    public int Get01ED_C21A_Byte8_paletteOffset() {
        return UInt8[0xC21A];
    }

    // Getters and Setters for address 0x1ED:0xCC94/0xEB64.
    // Operation not registered by running code
    public int Get01ED_CC94_Word16_blitFunction() {
        return UInt16[0xCC94];
    }

    // Getters and Setters for address 0x1ED:0xE8D2/0x107A2.
    // Was accessed via the following registers: CS
    public int Get01ED_E8D2_Word16_pitTimerValue() {
        return UInt16[0xE8D2];
    }

    // Getters and Setters for address 0x1ED:0xE8D4/0x107A4.
    // Was accessed via the following registers: CS
    public int Get01ED_E8D4_Byte8_pitTimerCounter() {
        return UInt8[0xE8D4];
    }

    // Getters and Setters for address 0x1ED:0xED3A/0x10C0A.
    // Was accessed via the following registers: CS
    public int Get01ED_ED3A_Word16_emsEmmHandle() {
        return UInt16[0xED3A];
    }

    // Getters and Setters for address 0x1ED:0xED3E/0x10C0E.
    // Was accessed via the following registers: CS
    public int Get01ED_ED3E_Word16() {
        return UInt16[0xED3E];
    }

    // Getters and Setters for address 0x1ED:0xEE8A/0x10D5A.
    // Was accessed via the following registers: CS
    public int Get01ED_EE8A_Word16_xmsMemoryBlock() {
        return UInt16[0xEE8A];
    }

    // Was accessed via the following registers: CS
    public void Set01ED_00AA_Word16(ushort value) {
        UInt16[0xAA] = value;
    }

    // Was accessed via the following registers: CS
    public void Set01ED_00AC_Word16(ushort value) {
        UInt16[0xAC] = value;
    }

    // Was accessed via the following registers: CS
    public void Set01ED_00AE_Word16(ushort value) {
        UInt16[0xAE] = value;
    }

    // Was accessed via the following registers: CS
    public void Set01ED_00B0_Word16(ushort value) {
        UInt16[0xB0] = value;
    }

    // Was accessed via the following registers: CS
    public void Set01ED_A6D3_Byte8(byte value) {
        UInt8[0xA6D3] = value;
    }

    // Was accessed via the following registers: CS
    public void Set01ED_C13C_Byte8(byte value) {
        UInt8[0xC13C] = value;
    }

    // Was accessed via the following registers: CS
    public void Set01ED_C21A_Byte8_paletteOffset(byte value) {
        UInt8[0xC21A] = value;
    }

    // Was accessed via the following registers: CS
    public void Set01ED_CC94_Word16_blitFunction(byte value) {
        UInt16[0xCC94] = value;
    }

    // Was accessed via the following registers: CS
    public void Set01ED_E8D2_Word16_pitTimerValue(ushort value) {
        UInt16[0xE8D2] = value;
    }

    // Was accessed via the following registers: CS
    public void Set01ED_E8D4_Byte8_pitTimerCounter(byte value) {
        UInt8[0xE8D4] = value;
    }

    // Operation not registered by running code
    public void Set01ED_ED3A_Word16_emsEmmHandle(ushort value) {
        UInt16[0xED3A] = value;
    }

    // Operation not registered by running code
    public void Set01ED_ED3E_Word16(ushort value) {
        UInt16[0xED3E] = value;
    }

    // Operation not registered by running code
    public void Set01ED_EE8A_Word16_xmsMemoryBlock(ushort value) {
        UInt16[0xEE8A] = value;
    }
}