namespace Cryogenic.Generated;

using Spice86.Core.Emulator.Memory;
using Spice86.Core.Emulator.ReverseEngineer;
using Spice86.Core.Emulator.VM;
using Spice86.Shared.Emulator.Memory;

// Accessors for values accessed via register SS
public class GlobalsOnSs : MemoryBasedDataStructureWithSsBaseAddress {
    public GlobalsOnSs(Machine machine) : base(machine) {
    }

    // Getters and Setters for address 0x1138:0xCC/0x1144C.
    // Was accessed via the following registers: SS
    public int Get1138_00CC_Word16() {
        return GetUint16(0xCC);
    }

    // Was accessed via the following registers: DS
    public void Set1138_00CC_Word16(ushort value) {
        SetUint16(0xCC, value);
    }

    // Getters and Setters for address 0x1138:0xCE/0x1144E.
    // Operation not registered by running code
    public int Get1138_00CE_Byte8() {
        return GetUint8(0xCE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_00CE_Byte8(byte value) {
        SetUint8(0xCE, value);
    }

    // Getters and Setters for address 0x1138:0xD0/0x11450.
    // Was accessed via the following registers: SS
    public int Get1138_00D0_Word16() {
        return GetUint16(0xD0);
    }

    // Was accessed via the following registers: DS, SS
    public void Set1138_00D0_Word16(ushort value) {
        SetUint16(0xD0, value);
    }

    // Getters and Setters for address 0x1138:0xD2/0x11452.
    // Was accessed via the following registers: SS
    public int Get1138_00D2_Word16() {
        return GetUint16(0xD2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_00D2_Word16(ushort value) {
        SetUint16(0xD2, value);
    }

    // Getters and Setters for address 0x1138:0xD4/0x11454.
    // Operation not registered by running code
    public int Get1138_00D4_Byte8() {
        return GetUint8(0xD4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_00D4_Byte8(byte value) {
        SetUint8(0xD4, value);
    }

    // Getters and Setters for address 0x1138:0xD6/0x11456.
    // Was accessed via the following registers: SS
    public int Get1138_00D6_Word16() {
        return GetUint16(0xD6);
    }

    // Was accessed via the following registers: DS, SS
    public void Set1138_00D6_Word16(ushort value) {
        SetUint16(0xD6, value);
    }

    // Getters and Setters for address 0x1138:0xD8/0x11458.
    // Was accessed via the following registers: SS
    public int Get1138_00D8_Word16() {
        return GetUint16(0xD8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_00D8_Word16(ushort value) {
        SetUint16(0xD8, value);
    }

    // Getters and Setters for address 0x1138:0xDA/0x1145A.
    // Operation not registered by running code
    public int Get1138_00DA_Byte8() {
        return GetUint8(0xDA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_00DA_Byte8(byte value) {
        SetUint8(0xDA, value);
    }

    // Getters and Setters for address 0x1138:0xDC/0x1145C.
    // Was accessed via the following registers: SS
    public int Get1138_00DC_Word16() {
        return GetUint16(0xDC);
    }

    // Was accessed via the following registers: DS, SS
    public void Set1138_00DC_Word16(ushort value) {
        SetUint16(0xDC, value);
    }

    // Getters and Setters for address 0x1138:0xDE/0x1145E.
    // Was accessed via the following registers: SS
    public int Get1138_00DE_Word16() {
        return GetUint16(0xDE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_00DE_Word16(ushort value) {
        SetUint16(0xDE, value);
    }

    // Getters and Setters for address 0x1138:0xE0/0x11460.
    // Operation not registered by running code
    public int Get1138_00E0_Byte8() {
        return GetUint8(0xE0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_00E0_Byte8(byte value) {
        SetUint8(0xE0, value);
    }

    // Getters and Setters for address 0x1138:0xE2/0x11462.
    // Was accessed via the following registers: SS
    public int Get1138_00E2_Word16() {
        return GetUint16(0xE2);
    }

    // Was accessed via the following registers: DS, SS
    public void Set1138_00E2_Word16(ushort value) {
        SetUint16(0xE2, value);
    }

    // Getters and Setters for address 0x1138:0xE4/0x11464.
    // Was accessed via the following registers: SS
    public int Get1138_00E4_Word16() {
        return GetUint16(0xE4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_00E4_Word16(ushort value) {
        SetUint16(0xE4, value);
    }

    // Getters and Setters for address 0x1138:0xE6/0x11466.
    // Operation not registered by running code
    public int Get1138_00E6_Byte8() {
        return GetUint8(0xE6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_00E6_Byte8(byte value) {
        SetUint8(0xE6, value);
    }

    // Getters and Setters for address 0x1138:0x23E/0x115BE.
    // Was accessed via the following registers: SS
    public int Get1138_023E_Byte8() {
        return GetUint8(0x23E);
    }

    // Operation not registered by running code
    public void Set1138_023E_Byte8(byte value) {
        SetUint8(0x23E, value);
    }

    // Getters and Setters for address 0x1138:0x25A/0x115DA.
    // Was accessed via the following registers: SS
    public int Get1138_025A_Byte8() {
        return GetUint8(0x25A);
    }

    // Operation not registered by running code
    public void Set1138_025A_Byte8(byte value) {
        SetUint8(0x25A, value);
    }

    // Getters and Setters for address 0x1138:0x276/0x115F6.
    // Was accessed via the following registers: SS
    public int Get1138_0276_Byte8() {
        return GetUint8(0x276);
    }

    // Operation not registered by running code
    public void Set1138_0276_Byte8(byte value) {
        SetUint8(0x276, value);
    }

    // Getters and Setters for address 0x1138:0x10C8/0x12448.
    // Operation not registered by running code
    public int Get1138_10C8_Word16() {
        return GetUint16(0x10C8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_10C8_Word16(ushort value) {
        SetUint16(0x10C8, value);
    }

    // Getters and Setters for address 0x1138:0x10CA/0x1244A.
    // Operation not registered by running code
    public int Get1138_10CA_Word16() {
        return GetUint16(0x10CA);
    }

    // Was accessed via the following registers: DS, SS
    public void Set1138_10CA_Word16(ushort value) {
        SetUint16(0x10CA, value);
    }

    // Getters and Setters for address 0x1138:0x116A/0x124EA.
    // Was accessed via the following registers: SS
    public int Get1138_116A_Byte8() {
        return GetUint8(0x116A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_116A_Byte8(byte value) {
        SetUint8(0x116A, value);
    }

    // Getters and Setters for address 0x1138:0x116B/0x124EB.
    // Was accessed via the following registers: SS
    public int Get1138_116B_Byte8() {
        return GetUint8(0x116B);
    }

    // Operation not registered by running code
    public void Set1138_116B_Byte8(byte value) {
        SetUint8(0x116B, value);
    }

    // Getters and Setters for address 0x1138:0x116C/0x124EC.
    // Was accessed via the following registers: SS
    public int Get1138_116C_Byte8() {
        return GetUint8(0x116C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_116C_Byte8(byte value) {
        SetUint8(0x116C, value);
    }

    // Getters and Setters for address 0x1138:0x116D/0x124ED.
    // Was accessed via the following registers: SS
    public int Get1138_116D_Byte8() {
        return GetUint8(0x116D);
    }

    // Operation not registered by running code
    public void Set1138_116D_Byte8(byte value) {
        SetUint8(0x116D, value);
    }

    // Getters and Setters for address 0x1138:0x116E/0x124EE.
    // Was accessed via the following registers: SS
    public int Get1138_116E_Byte8() {
        return GetUint8(0x116E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_116E_Byte8(byte value) {
        SetUint8(0x116E, value);
    }

    // Getters and Setters for address 0x1138:0x116F/0x124EF.
    // Was accessed via the following registers: SS
    public int Get1138_116F_Byte8() {
        return GetUint8(0x116F);
    }

    // Operation not registered by running code
    public void Set1138_116F_Byte8(byte value) {
        SetUint8(0x116F, value);
    }

    // Getters and Setters for address 0x1138:0x143C/0x127BC.
    // Was accessed via the following registers: SS
    public int Get1138_143C_Word16() {
        return GetUint16(0x143C);
    }

    // Operation not registered by running code
    public void Set1138_143C_Word16(ushort value) {
        SetUint16(0x143C, value);
    }

    // Getters and Setters for address 0x1138:0x143E/0x127BE.
    // Was accessed via the following registers: SS
    public int Get1138_143E_Word16() {
        return GetUint16(0x143E);
    }

    // Operation not registered by running code
    public void Set1138_143E_Word16(ushort value) {
        SetUint16(0x143E, value);
    }

    // Getters and Setters for address 0x1138:0x1440/0x127C0.
    // Was accessed via the following registers: SS
    public int Get1138_1440_Word16() {
        return GetUint16(0x1440);
    }

    // Operation not registered by running code
    public void Set1138_1440_Word16(ushort value) {
        SetUint16(0x1440, value);
    }

    // Getters and Setters for address 0x1138:0x1442/0x127C2.
    // Was accessed via the following registers: SS
    public int Get1138_1442_Word16() {
        return GetUint16(0x1442);
    }

    // Operation not registered by running code
    public void Set1138_1442_Word16(ushort value) {
        SetUint16(0x1442, value);
    }

    // Getters and Setters for address 0x1138:0x16E3/0x12A63.
    // Was accessed via the following registers: SS
    public int Get1138_16E3_Byte8() {
        return GetUint8(0x16E3);
    }

    // Operation not registered by running code
    public void Set1138_16E3_Byte8(byte value) {
        SetUint8(0x16E3, value);
    }

    // Getters and Setters for address 0x1138:0x16E6/0x12A66.
    // Was accessed via the following registers: SS
    public int Get1138_16E6_Byte8() {
        return GetUint8(0x16E6);
    }

    // Operation not registered by running code
    public void Set1138_16E6_Byte8(byte value) {
        SetUint8(0x16E6, value);
    }

    // Getters and Setters for address 0x1138:0x179E/0x12B1E.
    // Was accessed via the following registers: SS
    public int Get1138_179E_Word16() {
        return GetUint16(0x179E);
    }

    // Operation not registered by running code
    public void Set1138_179E_Word16(ushort value) {
        SetUint16(0x179E, value);
    }

    // Getters and Setters for address 0x1138:0x1898/0x12C18.
    // Was accessed via the following registers: SS
    public int Get1138_1898_Byte8() {
        return GetUint8(0x1898);
    }

    // Operation not registered by running code
    public void Set1138_1898_Byte8(byte value) {
        SetUint8(0x1898, value);
    }

    // Getters and Setters for address 0x1138:0x189B/0x12C1B.
    // Was accessed via the following registers: SS
    public int Get1138_189B_Byte8() {
        return GetUint8(0x189B);
    }

    // Operation not registered by running code
    public void Set1138_189B_Byte8(byte value) {
        SetUint8(0x189B, value);
    }

    // Getters and Setters for address 0x1138:0x18C5/0x12C45.
    // Was accessed via the following registers: SS
    public int Get1138_18C5_Word16() {
        return GetUint16(0x18C5);
    }

    // Operation not registered by running code
    public void Set1138_18C5_Word16(ushort value) {
        SetUint16(0x18C5, value);
    }

    // Getters and Setters for address 0x1138:0x18F3/0x12C73.
    // Was accessed via the following registers: SS
    public int Get1138_18F3_Word16() {
        return GetUint16(0x18F3);
    }

    // Operation not registered by running code
    public void Set1138_18F3_Word16(ushort value) {
        SetUint16(0x18F3, value);
    }

    // Getters and Setters for address 0x1138:0x18F5/0x12C75.
    // Was accessed via the following registers: SS
    public int Get1138_18F5_Word16() {
        return GetUint16(0x18F5);
    }

    // Operation not registered by running code
    public void Set1138_18F5_Word16(ushort value) {
        SetUint16(0x18F5, value);
    }

    // Getters and Setters for address 0x1138:0x18FD/0x12C7D.
    // Was accessed via the following registers: SS
    public int Get1138_18FD_Byte8() {
        return GetUint8(0x18FD);
    }

    // Operation not registered by running code
    public void Set1138_18FD_Byte8(byte value) {
        SetUint8(0x18FD, value);
    }

    // Getters and Setters for address 0x1138:0x1900/0x12C80.
    // Was accessed via the following registers: SS
    public int Get1138_1900_Byte8() {
        return GetUint8(0x1900);
    }

    // Operation not registered by running code
    public void Set1138_1900_Byte8(byte value) {
        SetUint8(0x1900, value);
    }

    // Getters and Setters for address 0x1138:0x1BF0/0x12F70.
    // Was accessed via the following registers: DS, SS
    public int Get1138_1BF0_Word16() {
        return GetUint16(0x1BF0);
    }

    // Operation not registered by running code
    public void Set1138_1BF0_Word16(ushort value) {
        SetUint16(0x1BF0, value);
    }

    // Getters and Setters for address 0x1138:0x1BF2/0x12F72.
    // Was accessed via the following registers: DS, SS
    public int Get1138_1BF2_Word16() {
        return GetUint16(0x1BF2);
    }

    // Operation not registered by running code
    public void Set1138_1BF2_Word16(ushort value) {
        SetUint16(0x1BF2, value);
    }

    // Getters and Setters for address 0x1138:0x1E76/0x131F6.
    // Was accessed via the following registers: SS
    public int Get1138_1E76_Word16() {
        return GetUint16(0x1E76);
    }

    // Operation not registered by running code
    public void Set1138_1E76_Word16(ushort value) {
        SetUint16(0x1E76, value);
    }

    // Getters and Setters for address 0x1138:0x1E78/0x131F8.
    // Was accessed via the following registers: SS
    public int Get1138_1E78_Word16() {
        return GetUint16(0x1E78);
    }

    // Operation not registered by running code
    public void Set1138_1E78_Word16(ushort value) {
        SetUint16(0x1E78, value);
    }

    // Getters and Setters for address 0x1138:0x1E7A/0x131FA.
    // Was accessed via the following registers: SS
    public int Get1138_1E7A_Word16() {
        return GetUint16(0x1E7A);
    }

    // Operation not registered by running code
    public void Set1138_1E7A_Word16(ushort value) {
        SetUint16(0x1E7A, value);
    }

    // Getters and Setters for address 0x1138:0x1E7C/0x131FC.
    // Was accessed via the following registers: SS
    public int Get1138_1E7C_Word16() {
        return GetUint16(0x1E7C);
    }

    // Operation not registered by running code
    public void Set1138_1E7C_Word16(ushort value) {
        SetUint16(0x1E7C, value);
    }

    // Getters and Setters for address 0x1138:0x1EFE/0x1327E.
    // Was accessed via the following registers: SS
    public int Get1138_1EFE_Word16() {
        return GetUint16(0x1EFE);
    }

    // Operation not registered by running code
    public void Set1138_1EFE_Word16(ushort value) {
        SetUint16(0x1EFE, value);
    }

    // Getters and Setters for address 0x1138:0x1F00/0x13280.
    // Was accessed via the following registers: SS
    public int Get1138_1F00_Word16() {
        return GetUint16(0x1F00);
    }

    // Operation not registered by running code
    public void Set1138_1F00_Word16(ushort value) {
        SetUint16(0x1F00, value);
    }

    // Getters and Setters for address 0x1138:0x1F02/0x13282.
    // Was accessed via the following registers: SS
    public int Get1138_1F02_Word16() {
        return GetUint16(0x1F02);
    }

    // Operation not registered by running code
    public void Set1138_1F02_Word16(ushort value) {
        SetUint16(0x1F02, value);
    }

    // Getters and Setters for address 0x1138:0x1F04/0x13284.
    // Was accessed via the following registers: SS
    public int Get1138_1F04_Word16() {
        return GetUint16(0x1F04);
    }

    // Operation not registered by running code
    public void Set1138_1F04_Word16(ushort value) {
        SetUint16(0x1F04, value);
    }

    // Getters and Setters for address 0x1138:0x1F0E/0x1328E.
    // Was accessed via the following registers: SS
    public int Get1138_1F0E_Byte8() {
        return GetUint8(0x1F0E);
    }

    // Operation not registered by running code
    public void Set1138_1F0E_Byte8(byte value) {
        SetUint8(0x1F0E, value);
    }

    // Getters and Setters for address 0x1138:0x1F10/0x13290.
    // Was accessed via the following registers: SS
    public int Get1138_1F10_Word16() {
        return GetUint16(0x1F10);
    }

    // Was accessed via the following registers: SS
    public void Set1138_1F10_Word16(ushort value) {
        SetUint16(0x1F10, value);
    }

    // Getters and Setters for address 0x1138:0x1F14/0x13294.
    // Was accessed via the following registers: SS
    public int Get1138_1F14_Word16() {
        return GetUint16(0x1F14);
    }

    // Was accessed via the following registers: SS
    public void Set1138_1F14_Word16(ushort value) {
        SetUint16(0x1F14, value);
    }

    // Getters and Setters for address 0x1138:0x1F18/0x13298.
    // Was accessed via the following registers: SS
    public int Get1138_1F18_Word16() {
        return GetUint16(0x1F18);
    }

    // Was accessed via the following registers: SS
    public void Set1138_1F18_Word16(ushort value) {
        SetUint16(0x1F18, value);
    }

    // Getters and Setters for address 0x1138:0x1F1C/0x1329C.
    // Was accessed via the following registers: SS
    public int Get1138_1F1C_Word16() {
        return GetUint16(0x1F1C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_1F1C_Word16(ushort value) {
        SetUint16(0x1F1C, value);
    }

    // Getters and Setters for address 0x1138:0x1F20/0x132A0.
    // Was accessed via the following registers: SS
    public int Get1138_1F20_Word16() {
        return GetUint16(0x1F20);
    }

    // Was accessed via the following registers: SS
    public void Set1138_1F20_Word16(ushort value) {
        SetUint16(0x1F20, value);
    }

    // Getters and Setters for address 0x1138:0x1F24/0x132A4.
    // Was accessed via the following registers: SS
    public int Get1138_1F24_Word16() {
        return GetUint16(0x1F24);
    }

    // Operation not registered by running code
    public void Set1138_1F24_Word16(ushort value) {
        SetUint16(0x1F24, value);
    }

    // Getters and Setters for address 0x1138:0x1F7E/0x132FE.
    // Was accessed via the following registers: SS
    public int Get1138_1F7E_Byte8() {
        return GetUint8(0x1F7E);
    }

    // Operation not registered by running code
    public void Set1138_1F7E_Byte8(byte value) {
        SetUint8(0x1F7E, value);
    }

    // Getters and Setters for address 0x1138:0x1F80/0x13300.
    // Was accessed via the following registers: SS
    public int Get1138_1F80_Word16() {
        return GetUint16(0x1F80);
    }

    // Was accessed via the following registers: SS
    public void Set1138_1F80_Word16(ushort value) {
        SetUint16(0x1F80, value);
    }

    // Getters and Setters for address 0x1138:0x1F84/0x13304.
    // Was accessed via the following registers: SS
    public int Get1138_1F84_Word16() {
        return GetUint16(0x1F84);
    }

    // Was accessed via the following registers: SS
    public void Set1138_1F84_Word16(ushort value) {
        SetUint16(0x1F84, value);
    }

    // Getters and Setters for address 0x1138:0x1F86/0x13306.
    // Operation not registered by running code
    public int Get1138_1F86_Word16() {
        return GetUint16(0x1F86);
    }

    // Was accessed via the following registers: SS
    public void Set1138_1F86_Word16(ushort value) {
        SetUint16(0x1F86, value);
    }

    // Getters and Setters for address 0x1138:0x1F88/0x13308.
    // Was accessed via the following registers: SS
    public int Get1138_1F88_Word16() {
        return GetUint16(0x1F88);
    }

    // Was accessed via the following registers: SS
    public void Set1138_1F88_Word16(ushort value) {
        SetUint16(0x1F88, value);
    }

    // Getters and Setters for address 0x1138:0x1F8C/0x1330C.
    // Was accessed via the following registers: SS
    public int Get1138_1F8C_Word16() {
        return GetUint16(0x1F8C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_1F8C_Word16(ushort value) {
        SetUint16(0x1F8C, value);
    }

    // Getters and Setters for address 0x1138:0x1F90/0x13310.
    // Was accessed via the following registers: SS
    public int Get1138_1F90_Word16() {
        return GetUint16(0x1F90);
    }

    // Operation not registered by running code
    public void Set1138_1F90_Word16(ushort value) {
        SetUint16(0x1F90, value);
    }

    // Getters and Setters for address 0x1138:0x1FFE/0x1337E.
    // Was accessed via the following registers: SS
    public int Get1138_1FFE_Byte8() {
        return GetUint8(0x1FFE);
    }

    // Operation not registered by running code
    public void Set1138_1FFE_Byte8(byte value) {
        SetUint8(0x1FFE, value);
    }

    // Getters and Setters for address 0x1138:0x2000/0x13380.
    // Was accessed via the following registers: SS
    public int Get1138_2000_Word16() {
        return GetUint16(0x2000);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2000_Word16(ushort value) {
        SetUint16(0x2000, value);
    }

    // Getters and Setters for address 0x1138:0x2004/0x13384.
    // Was accessed via the following registers: SS
    public int Get1138_2004_Word16() {
        return GetUint16(0x2004);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2004_Word16(ushort value) {
        SetUint16(0x2004, value);
    }

    // Getters and Setters for address 0x1138:0x2008/0x13388.
    // Was accessed via the following registers: SS
    public int Get1138_2008_Word16() {
        return GetUint16(0x2008);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2008_Word16(ushort value) {
        SetUint16(0x2008, value);
    }

    // Getters and Setters for address 0x1138:0x200C/0x1338C.
    // Was accessed via the following registers: SS
    public int Get1138_200C_Word16() {
        return GetUint16(0x200C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_200C_Word16(ushort value) {
        SetUint16(0x200C, value);
    }

    // Getters and Setters for address 0x1138:0x2010/0x13390.
    // Was accessed via the following registers: SS
    public int Get1138_2010_Word16() {
        return GetUint16(0x2010);
    }

    // Operation not registered by running code
    public void Set1138_2010_Word16(ushort value) {
        SetUint16(0x2010, value);
    }

    // Getters and Setters for address 0x1138:0x2012/0x13392.
    // Was accessed via the following registers: SS
    public int Get1138_2012_Byte8() {
        return GetUint8(0x2012);
    }

    // Operation not registered by running code
    public void Set1138_2012_Byte8(byte value) {
        SetUint8(0x2012, value);
    }

    // Getters and Setters for address 0x1138:0x2014/0x13394.
    // Was accessed via the following registers: SS
    public int Get1138_2014_Word16() {
        return GetUint16(0x2014);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2014_Word16(ushort value) {
        SetUint16(0x2014, value);
    }

    // Getters and Setters for address 0x1138:0x2018/0x13398.
    // Was accessed via the following registers: SS
    public int Get1138_2018_Word16() {
        return GetUint16(0x2018);
    }

    // Operation not registered by running code
    public void Set1138_2018_Word16(ushort value) {
        SetUint16(0x2018, value);
    }

    // Getters and Setters for address 0x1138:0x201A/0x1339A.
    // Was accessed via the following registers: SS
    public int Get1138_201A_Byte8() {
        return GetUint8(0x201A);
    }

    // Operation not registered by running code
    public void Set1138_201A_Byte8(byte value) {
        SetUint8(0x201A, value);
    }

    // Getters and Setters for address 0x1138:0x201C/0x1339C.
    // Was accessed via the following registers: SS
    public int Get1138_201C_Word16() {
        return GetUint16(0x201C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_201C_Word16(ushort value) {
        SetUint16(0x201C, value);
    }

    // Getters and Setters for address 0x1138:0x201D/0x1339D.
    // Operation not registered by running code
    public int Get1138_201D_Byte8() {
        return GetUint8(0x201D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_201D_Byte8(byte value) {
        SetUint8(0x201D, value);
    }

    // Getters and Setters for address 0x1138:0x2020/0x133A0.
    // Was accessed via the following registers: SS
    public int Get1138_2020_Word16() {
        return GetUint16(0x2020);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2020_Word16(ushort value) {
        SetUint16(0x2020, value);
    }

    // Getters and Setters for address 0x1138:0x2021/0x133A1.
    // Operation not registered by running code
    public int Get1138_2021_Byte8() {
        return GetUint8(0x2021);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2021_Byte8(byte value) {
        SetUint8(0x2021, value);
    }

    // Getters and Setters for address 0x1138:0x2024/0x133A4.
    // Was accessed via the following registers: SS
    public int Get1138_2024_Word16() {
        return GetUint16(0x2024);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2024_Word16(ushort value) {
        SetUint16(0x2024, value);
    }

    // Getters and Setters for address 0x1138:0x2025/0x133A5.
    // Operation not registered by running code
    public int Get1138_2025_Byte8() {
        return GetUint8(0x2025);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2025_Byte8(byte value) {
        SetUint8(0x2025, value);
    }

    // Getters and Setters for address 0x1138:0x2028/0x133A8.
    // Was accessed via the following registers: SS
    public int Get1138_2028_Word16() {
        return GetUint16(0x2028);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2028_Word16(ushort value) {
        SetUint16(0x2028, value);
    }

    // Getters and Setters for address 0x1138:0x202C/0x133AC.
    // Was accessed via the following registers: SS
    public int Get1138_202C_Word16() {
        return GetUint16(0x202C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_202C_Word16(ushort value) {
        SetUint16(0x202C, value);
    }

    // Getters and Setters for address 0x1138:0x2030/0x133B0.
    // Was accessed via the following registers: SS
    public int Get1138_2030_Word16() {
        return GetUint16(0x2030);
    }

    // Operation not registered by running code
    public void Set1138_2030_Word16(ushort value) {
        SetUint16(0x2030, value);
    }

    // Getters and Setters for address 0x1138:0x2032/0x133B2.
    // Was accessed via the following registers: SS
    public int Get1138_2032_Byte8() {
        return GetUint8(0x2032);
    }

    // Operation not registered by running code
    public void Set1138_2032_Byte8(byte value) {
        SetUint8(0x2032, value);
    }

    // Getters and Setters for address 0x1138:0x2034/0x133B4.
    // Was accessed via the following registers: SS
    public int Get1138_2034_Word16() {
        return GetUint16(0x2034);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2034_Word16(ushort value) {
        SetUint16(0x2034, value);
    }

    // Getters and Setters for address 0x1138:0x2038/0x133B8.
    // Was accessed via the following registers: SS
    public int Get1138_2038_Word16() {
        return GetUint16(0x2038);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2038_Word16(ushort value) {
        SetUint16(0x2038, value);
    }

    // Getters and Setters for address 0x1138:0x203C/0x133BC.
    // Was accessed via the following registers: SS
    public int Get1138_203C_Word16() {
        return GetUint16(0x203C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_203C_Word16(ushort value) {
        SetUint16(0x203C, value);
    }

    // Getters and Setters for address 0x1138:0x2040/0x133C0.
    // Was accessed via the following registers: SS
    public int Get1138_2040_Word16() {
        return GetUint16(0x2040);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2040_Word16(ushort value) {
        SetUint16(0x2040, value);
    }

    // Getters and Setters for address 0x1138:0x2044/0x133C4.
    // Was accessed via the following registers: SS
    public int Get1138_2044_Word16() {
        return GetUint16(0x2044);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2044_Word16(ushort value) {
        SetUint16(0x2044, value);
    }

    // Getters and Setters for address 0x1138:0x2048/0x133C8.
    // Was accessed via the following registers: SS
    public int Get1138_2048_Word16() {
        return GetUint16(0x2048);
    }

    // Operation not registered by running code
    public void Set1138_2048_Word16(ushort value) {
        SetUint16(0x2048, value);
    }

    // Getters and Setters for address 0x1138:0x204A/0x133CA.
    // Was accessed via the following registers: SS
    public int Get1138_204A_Byte8() {
        return GetUint8(0x204A);
    }

    // Operation not registered by running code
    public void Set1138_204A_Byte8(byte value) {
        SetUint8(0x204A, value);
    }

    // Getters and Setters for address 0x1138:0x204C/0x133CC.
    // Was accessed via the following registers: SS
    public int Get1138_204C_Word16() {
        return GetUint16(0x204C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_204C_Word16(ushort value) {
        SetUint16(0x204C, value);
    }

    // Getters and Setters for address 0x1138:0x2050/0x133D0.
    // Was accessed via the following registers: SS
    public int Get1138_2050_Word16() {
        return GetUint16(0x2050);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2050_Word16(ushort value) {
        SetUint16(0x2050, value);
    }

    // Getters and Setters for address 0x1138:0x2052/0x133D2.
    // Operation not registered by running code
    public int Get1138_2052_Word16() {
        return GetUint16(0x2052);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2052_Word16(ushort value) {
        SetUint16(0x2052, value);
    }

    // Getters and Setters for address 0x1138:0x2054/0x133D4.
    // Was accessed via the following registers: SS
    public int Get1138_2054_Word16() {
        return GetUint16(0x2054);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2054_Word16(ushort value) {
        SetUint16(0x2054, value);
    }

    // Getters and Setters for address 0x1138:0x2058/0x133D8.
    // Was accessed via the following registers: SS
    public int Get1138_2058_Word16() {
        return GetUint16(0x2058);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2058_Word16(ushort value) {
        SetUint16(0x2058, value);
    }

    // Getters and Setters for address 0x1138:0x205C/0x133DC.
    // Was accessed via the following registers: SS
    public int Get1138_205C_Word16() {
        return GetUint16(0x205C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_205C_Word16(ushort value) {
        SetUint16(0x205C, value);
    }

    // Getters and Setters for address 0x1138:0x2060/0x133E0.
    // Was accessed via the following registers: SS
    public int Get1138_2060_Word16() {
        return GetUint16(0x2060);
    }

    // Operation not registered by running code
    public void Set1138_2060_Word16(ushort value) {
        SetUint16(0x2060, value);
    }

    // Getters and Setters for address 0x1138:0x208A/0x1340A.
    // Was accessed via the following registers: SS
    public int Get1138_208A_Byte8() {
        return GetUint8(0x208A);
    }

    // Operation not registered by running code
    public void Set1138_208A_Byte8(byte value) {
        SetUint8(0x208A, value);
    }

    // Getters and Setters for address 0x1138:0x208C/0x1340C.
    // Was accessed via the following registers: SS
    public int Get1138_208C_Word16() {
        return GetUint16(0x208C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_208C_Word16(ushort value) {
        SetUint16(0x208C, value);
    }

    // Getters and Setters for address 0x1138:0x2090/0x13410.
    // Was accessed via the following registers: SS
    public int Get1138_2090_Word16() {
        return GetUint16(0x2090);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2090_Word16(ushort value) {
        SetUint16(0x2090, value);
    }

    // Getters and Setters for address 0x1138:0x2094/0x13414.
    // Was accessed via the following registers: SS
    public int Get1138_2094_Word16() {
        return GetUint16(0x2094);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2094_Word16(ushort value) {
        SetUint16(0x2094, value);
    }

    // Getters and Setters for address 0x1138:0x2098/0x13418.
    // Was accessed via the following registers: SS
    public int Get1138_2098_Word16() {
        return GetUint16(0x2098);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2098_Word16(ushort value) {
        SetUint16(0x2098, value);
    }

    // Getters and Setters for address 0x1138:0x209C/0x1341C.
    // Was accessed via the following registers: SS
    public int Get1138_209C_Word16() {
        return GetUint16(0x209C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_209C_Word16(ushort value) {
        SetUint16(0x209C, value);
    }

    // Getters and Setters for address 0x1138:0x20A0/0x13420.
    // Was accessed via the following registers: SS
    public int Get1138_20A0_Word16() {
        return GetUint16(0x20A0);
    }

    // Operation not registered by running code
    public void Set1138_20A0_Word16(ushort value) {
        SetUint16(0x20A0, value);
    }

    // Getters and Setters for address 0x1138:0x20A2/0x13422.
    // Was accessed via the following registers: SS
    public int Get1138_20A2_Byte8() {
        return GetUint8(0x20A2);
    }

    // Operation not registered by running code
    public void Set1138_20A2_Byte8(byte value) {
        SetUint8(0x20A2, value);
    }

    // Getters and Setters for address 0x1138:0x20A4/0x13424.
    // Was accessed via the following registers: SS
    public int Get1138_20A4_Word16() {
        return GetUint16(0x20A4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_20A4_Word16(ushort value) {
        SetUint16(0x20A4, value);
    }

    // Getters and Setters for address 0x1138:0x20A8/0x13428.
    // Was accessed via the following registers: SS
    public int Get1138_20A8_Word16() {
        return GetUint16(0x20A8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_20A8_Word16(ushort value) {
        SetUint16(0x20A8, value);
    }

    // Getters and Setters for address 0x1138:0x20AC/0x1342C.
    // Was accessed via the following registers: SS
    public int Get1138_20AC_Word16() {
        return GetUint16(0x20AC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_20AC_Word16(ushort value) {
        SetUint16(0x20AC, value);
    }

    // Getters and Setters for address 0x1138:0x20B0/0x13430.
    // Was accessed via the following registers: SS
    public int Get1138_20B0_Word16() {
        return GetUint16(0x20B0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_20B0_Word16(ushort value) {
        SetUint16(0x20B0, value);
    }

    // Getters and Setters for address 0x1138:0x20B4/0x13434.
    // Was accessed via the following registers: SS
    public int Get1138_20B4_Word16() {
        return GetUint16(0x20B4);
    }

    // Operation not registered by running code
    public void Set1138_20B4_Word16(ushort value) {
        SetUint16(0x20B4, value);
    }

    // Getters and Setters for address 0x1138:0x20B6/0x13436.
    // Was accessed via the following registers: SS
    public int Get1138_20B6_Byte8() {
        return GetUint8(0x20B6);
    }

    // Operation not registered by running code
    public void Set1138_20B6_Byte8(byte value) {
        SetUint8(0x20B6, value);
    }

    // Getters and Setters for address 0x1138:0x20B8/0x13438.
    // Was accessed via the following registers: SS
    public int Get1138_20B8_Word16() {
        return GetUint16(0x20B8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_20B8_Word16(ushort value) {
        SetUint16(0x20B8, value);
    }

    // Getters and Setters for address 0x1138:0x20BC/0x1343C.
    // Was accessed via the following registers: SS
    public int Get1138_20BC_Word16() {
        return GetUint16(0x20BC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_20BC_Word16(ushort value) {
        SetUint16(0x20BC, value);
    }

    // Getters and Setters for address 0x1138:0x20C0/0x13440.
    // Was accessed via the following registers: SS
    public int Get1138_20C0_Word16() {
        return GetUint16(0x20C0);
    }

    // Operation not registered by running code
    public void Set1138_20C0_Word16(ushort value) {
        SetUint16(0x20C0, value);
    }

    // Getters and Setters for address 0x1138:0x20F2/0x13472.
    // Was accessed via the following registers: SS
    public int Get1138_20F2_Byte8() {
        return GetUint8(0x20F2);
    }

    // Operation not registered by running code
    public void Set1138_20F2_Byte8(byte value) {
        SetUint8(0x20F2, value);
    }

    // Getters and Setters for address 0x1138:0x20F4/0x13474.
    // Was accessed via the following registers: SS
    public int Get1138_20F4_Word16() {
        return GetUint16(0x20F4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_20F4_Word16(ushort value) {
        SetUint16(0x20F4, value);
    }

    // Getters and Setters for address 0x1138:0x20F8/0x13478.
    // Was accessed via the following registers: SS
    public int Get1138_20F8_Word16() {
        return GetUint16(0x20F8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_20F8_Word16(ushort value) {
        SetUint16(0x20F8, value);
    }

    // Getters and Setters for address 0x1138:0x20FC/0x1347C.
    // Was accessed via the following registers: SS
    public int Get1138_20FC_Word16() {
        return GetUint16(0x20FC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_20FC_Word16(ushort value) {
        SetUint16(0x20FC, value);
    }

    // Getters and Setters for address 0x1138:0x20FD/0x1347D.
    // Operation not registered by running code
    public int Get1138_20FD_Byte8() {
        return GetUint8(0x20FD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_20FD_Byte8(byte value) {
        SetUint8(0x20FD, value);
    }

    // Getters and Setters for address 0x1138:0x2100/0x13480.
    // Was accessed via the following registers: SS
    public int Get1138_2100_Word16() {
        return GetUint16(0x2100);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2100_Word16(ushort value) {
        SetUint16(0x2100, value);
    }

    // Getters and Setters for address 0x1138:0x2104/0x13484.
    // Was accessed via the following registers: SS
    public int Get1138_2104_Word16() {
        return GetUint16(0x2104);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2104_Word16(ushort value) {
        SetUint16(0x2104, value);
    }

    // Getters and Setters for address 0x1138:0x2108/0x13488.
    // Was accessed via the following registers: SS
    public int Get1138_2108_Word16() {
        return GetUint16(0x2108);
    }

    // Operation not registered by running code
    public void Set1138_2108_Word16(ushort value) {
        SetUint16(0x2108, value);
    }

    // Getters and Setters for address 0x1138:0x210A/0x1348A.
    // Was accessed via the following registers: SS
    public int Get1138_210A_Byte8() {
        return GetUint8(0x210A);
    }

    // Operation not registered by running code
    public void Set1138_210A_Byte8(byte value) {
        SetUint8(0x210A, value);
    }

    // Getters and Setters for address 0x1138:0x210C/0x1348C.
    // Was accessed via the following registers: SS
    public int Get1138_210C_Word16() {
        return GetUint16(0x210C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_210C_Word16(ushort value) {
        SetUint16(0x210C, value);
    }

    // Getters and Setters for address 0x1138:0x2110/0x13490.
    // Was accessed via the following registers: SS
    public int Get1138_2110_Word16() {
        return GetUint16(0x2110);
    }

    // Was accessed via the following registers: DS, SS
    public void Set1138_2110_Word16(ushort value) {
        SetUint16(0x2110, value);
    }

    // Getters and Setters for address 0x1138:0x2114/0x13494.
    // Was accessed via the following registers: SS
    public int Get1138_2114_Word16() {
        return GetUint16(0x2114);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2114_Word16(ushort value) {
        SetUint16(0x2114, value);
    }

    // Getters and Setters for address 0x1138:0x2118/0x13498.
    // Was accessed via the following registers: SS
    public int Get1138_2118_Word16() {
        return GetUint16(0x2118);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2118_Word16(ushort value) {
        SetUint16(0x2118, value);
    }

    // Getters and Setters for address 0x1138:0x211C/0x1349C.
    // Was accessed via the following registers: SS
    public int Get1138_211C_Word16() {
        return GetUint16(0x211C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_211C_Word16(ushort value) {
        SetUint16(0x211C, value);
    }

    // Getters and Setters for address 0x1138:0x2120/0x134A0.
    // Was accessed via the following registers: SS
    public int Get1138_2120_Word16() {
        return GetUint16(0x2120);
    }

    // Operation not registered by running code
    public void Set1138_2120_Word16(ushort value) {
        SetUint16(0x2120, value);
    }

    // Getters and Setters for address 0x1138:0x212E/0x134AE.
    // Was accessed via the following registers: SS
    public int Get1138_212E_Byte8() {
        return GetUint8(0x212E);
    }

    // Operation not registered by running code
    public void Set1138_212E_Byte8(byte value) {
        SetUint8(0x212E, value);
    }

    // Getters and Setters for address 0x1138:0x2130/0x134B0.
    // Was accessed via the following registers: SS
    public int Get1138_2130_Word16() {
        return GetUint16(0x2130);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2130_Word16(ushort value) {
        SetUint16(0x2130, value);
    }

    // Getters and Setters for address 0x1138:0x2134/0x134B4.
    // Was accessed via the following registers: SS
    public int Get1138_2134_Word16() {
        return GetUint16(0x2134);
    }

    // Operation not registered by running code
    public void Set1138_2134_Word16(ushort value) {
        SetUint16(0x2134, value);
    }

    // Getters and Setters for address 0x1138:0x2136/0x134B6.
    // Was accessed via the following registers: SS
    public int Get1138_2136_Byte8() {
        return GetUint8(0x2136);
    }

    // Operation not registered by running code
    public void Set1138_2136_Byte8(byte value) {
        SetUint8(0x2136, value);
    }

    // Getters and Setters for address 0x1138:0x2138/0x134B8.
    // Was accessed via the following registers: SS
    public int Get1138_2138_Word16() {
        return GetUint16(0x2138);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2138_Word16(ushort value) {
        SetUint16(0x2138, value);
    }

    // Getters and Setters for address 0x1138:0x2139/0x134B9.
    // Operation not registered by running code
    public int Get1138_2139_Byte8() {
        return GetUint8(0x2139);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2139_Byte8(byte value) {
        SetUint8(0x2139, value);
    }

    // Getters and Setters for address 0x1138:0x213C/0x134BC.
    // Was accessed via the following registers: SS
    public int Get1138_213C_Word16() {
        return GetUint16(0x213C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_213C_Word16(ushort value) {
        SetUint16(0x213C, value);
    }

    // Getters and Setters for address 0x1138:0x2140/0x134C0.
    // Was accessed via the following registers: SS
    public int Get1138_2140_Word16() {
        return GetUint16(0x2140);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2140_Word16(ushort value) {
        SetUint16(0x2140, value);
    }

    // Getters and Setters for address 0x1138:0x2144/0x134C4.
    // Was accessed via the following registers: SS
    public int Get1138_2144_Word16() {
        return GetUint16(0x2144);
    }

    // Was accessed via the following registers: SS
    public void Set1138_2144_Word16(ushort value) {
        SetUint16(0x2144, value);
    }

    // Getters and Setters for address 0x1138:0x2148/0x134C8.
    // Was accessed via the following registers: SS
    public int Get1138_2148_Word16() {
        return GetUint16(0x2148);
    }

    // Operation not registered by running code
    public void Set1138_2148_Word16(ushort value) {
        SetUint16(0x2148, value);
    }

    // Getters and Setters for address 0x1138:0x21BE/0x1353E.
    // Was accessed via the following registers: SS
    public int Get1138_21BE_Word16() {
        return GetUint16(0x21BE);
    }

    // Operation not registered by running code
    public void Set1138_21BE_Word16(ushort value) {
        SetUint16(0x21BE, value);
    }

    // Getters and Setters for address 0x1138:0x21C2/0x13542.
    // Was accessed via the following registers: SS
    public int Get1138_21C2_Word16() {
        return GetUint16(0x21C2);
    }

    // Operation not registered by running code
    public void Set1138_21C2_Word16(ushort value) {
        SetUint16(0x21C2, value);
    }

    // Getters and Setters for address 0x1138:0x21C6/0x13546.
    // Was accessed via the following registers: SS
    public int Get1138_21C6_Word16() {
        return GetUint16(0x21C6);
    }

    // Operation not registered by running code
    public void Set1138_21C6_Word16(ushort value) {
        SetUint16(0x21C6, value);
    }

    // Getters and Setters for address 0x1138:0x223C/0x135BC.
    // Was accessed via the following registers: SS
    public int Get1138_223C_Word16() {
        return GetUint16(0x223C);
    }

    // Operation not registered by running code
    public void Set1138_223C_Word16(ushort value) {
        SetUint16(0x223C, value);
    }

    // Getters and Setters for address 0x1138:0x223E/0x135BE.
    // Was accessed via the following registers: SS
    public int Get1138_223E_Word16() {
        return GetUint16(0x223E);
    }

    // Operation not registered by running code
    public void Set1138_223E_Word16(ushort value) {
        SetUint16(0x223E, value);
    }

    // Getters and Setters for address 0x1138:0x2240/0x135C0.
    // Was accessed via the following registers: DS, SS
    public int Get1138_2240_Word16() {
        return GetUint16(0x2240);
    }

    // Operation not registered by running code
    public void Set1138_2240_Word16(ushort value) {
        SetUint16(0x2240, value);
    }

    // Getters and Setters for address 0x1138:0x2242/0x135C2.
    // Was accessed via the following registers: SS
    public int Get1138_2242_Word16() {
        return GetUint16(0x2242);
    }

    // Operation not registered by running code
    public void Set1138_2242_Word16(ushort value) {
        SetUint16(0x2242, value);
    }

    // Getters and Setters for address 0x1138:0x2244/0x135C4.
    // Was accessed via the following registers: SS
    public int Get1138_2244_Word16() {
        return GetUint16(0x2244);
    }

    // Was accessed via the following registers: DS
    public void Set1138_2244_Word16(ushort value) {
        SetUint16(0x2244, value);
    }

    // Getters and Setters for address 0x1138:0x2246/0x135C6.
    // Was accessed via the following registers: SS
    public int Get1138_2246_Word16() {
        return GetUint16(0x2246);
    }

    // Was accessed via the following registers: DS
    public void Set1138_2246_Word16(ushort value) {
        SetUint16(0x2246, value);
    }

    // Getters and Setters for address 0x1138:0x2248/0x135C8.
    // Was accessed via the following registers: SS
    public int Get1138_2248_Word16() {
        return GetUint16(0x2248);
    }

    // Operation not registered by running code
    public void Set1138_2248_Word16(ushort value) {
        SetUint16(0x2248, value);
    }

    // Getters and Setters for address 0x1138:0x224A/0x135CA.
    // Was accessed via the following registers: SS
    public int Get1138_224A_Word16() {
        return GetUint16(0x224A);
    }

    // Was accessed via the following registers: DS
    public void Set1138_224A_Word16(ushort value) {
        SetUint16(0x224A, value);
    }

    // Getters and Setters for address 0x1138:0x224C/0x135CC.
    // Was accessed via the following registers: SS
    public int Get1138_224C_Word16() {
        return GetUint16(0x224C);
    }

    // Operation not registered by running code
    public void Set1138_224C_Word16(ushort value) {
        SetUint16(0x224C, value);
    }

    // Getters and Setters for address 0x1138:0x224E/0x135CE.
    // Was accessed via the following registers: SS
    public int Get1138_224E_Word16() {
        return GetUint16(0x224E);
    }

    // Operation not registered by running code
    public void Set1138_224E_Word16(ushort value) {
        SetUint16(0x224E, value);
    }

    // Getters and Setters for address 0x1138:0x2250/0x135D0.
    // Was accessed via the following registers: SS
    public int Get1138_2250_Word16() {
        return GetUint16(0x2250);
    }

    // Operation not registered by running code
    public void Set1138_2250_Word16(ushort value) {
        SetUint16(0x2250, value);
    }

    // Getters and Setters for address 0x1138:0x2252/0x135D2.
    // Was accessed via the following registers: SS
    public int Get1138_2252_Word16() {
        return GetUint16(0x2252);
    }

    // Operation not registered by running code
    public void Set1138_2252_Word16(ushort value) {
        SetUint16(0x2252, value);
    }

    // Getters and Setters for address 0x1138:0x2265/0x135E5.
    // Was accessed via the following registers: SS
    public int Get1138_2265_Word16() {
        return GetUint16(0x2265);
    }

    // Operation not registered by running code
    public void Set1138_2265_Word16(ushort value) {
        SetUint16(0x2265, value);
    }

    // Getters and Setters for address 0x1138:0x2267/0x135E7.
    // Was accessed via the following registers: SS
    public int Get1138_2267_Word16() {
        return GetUint16(0x2267);
    }

    // Operation not registered by running code
    public void Set1138_2267_Word16(ushort value) {
        SetUint16(0x2267, value);
    }

    // Getters and Setters for address 0x1138:0x2269/0x135E9.
    // Was accessed via the following registers: SS
    public int Get1138_2269_Word16() {
        return GetUint16(0x2269);
    }

    // Operation not registered by running code
    public void Set1138_2269_Word16(ushort value) {
        SetUint16(0x2269, value);
    }

    // Getters and Setters for address 0x1138:0x226B/0x135EB.
    // Was accessed via the following registers: SS
    public int Get1138_226B_Word16() {
        return GetUint16(0x226B);
    }

    // Operation not registered by running code
    public void Set1138_226B_Word16(ushort value) {
        SetUint16(0x226B, value);
    }

    // Getters and Setters for address 0x1138:0x2776/0x13AF6.
    // Was accessed via the following registers: SS
    public int Get1138_2776_Word16() {
        return GetUint16(0x2776);
    }

    // Operation not registered by running code
    public void Set1138_2776_Word16(ushort value) {
        SetUint16(0x2776, value);
    }

    // Getters and Setters for address 0x1138:0x2778/0x13AF8.
    // Was accessed via the following registers: SS
    public int Get1138_2778_Word16() {
        return GetUint16(0x2778);
    }

    // Operation not registered by running code
    public void Set1138_2778_Word16(ushort value) {
        SetUint16(0x2778, value);
    }

    // Getters and Setters for address 0x1138:0x277A/0x13AFA.
    // Was accessed via the following registers: SS
    public int Get1138_277A_Word16() {
        return GetUint16(0x277A);
    }

    // Operation not registered by running code
    public void Set1138_277A_Word16(ushort value) {
        SetUint16(0x277A, value);
    }

    // Getters and Setters for address 0x1138:0x277C/0x13AFC.
    // Was accessed via the following registers: SS
    public int Get1138_277C_Word16() {
        return GetUint16(0x277C);
    }

    // Operation not registered by running code
    public void Set1138_277C_Word16(ushort value) {
        SetUint16(0x277C, value);
    }

    // Getters and Setters for address 0x1138:0x277E/0x13AFE.
    // Was accessed via the following registers: SS
    public int Get1138_277E_Word16() {
        return GetUint16(0x277E);
    }

    // Operation not registered by running code
    public void Set1138_277E_Word16(ushort value) {
        SetUint16(0x277E, value);
    }

    // Getters and Setters for address 0x1138:0x2780/0x13B00.
    // Was accessed via the following registers: SS
    public int Get1138_2780_Word16() {
        return GetUint16(0x2780);
    }

    // Operation not registered by running code
    public void Set1138_2780_Word16(ushort value) {
        SetUint16(0x2780, value);
    }

    // Getters and Setters for address 0x1138:0x2782/0x13B02.
    // Was accessed via the following registers: SS
    public int Get1138_2782_Word16() {
        return GetUint16(0x2782);
    }

    // Operation not registered by running code
    public void Set1138_2782_Word16(ushort value) {
        SetUint16(0x2782, value);
    }

    // Getters and Setters for address 0x1138:0x38C9/0x14C49.
    // Was accessed via the following registers: DS, SS
    public uint Get1138_38C9_Dword32_gfxVtable05blit() {
        return GetUint32(0x38C9);
    }

    // Was accessed via the following registers: DS, SS
    public SegmentedAddress GetPtr1138_38C9_Dword32_gfxVtable05blit() {
        return new SegmentedAddress(GetUint16(0x38C9 + 2), GetUint16(0x38C9));
    }

    // Operation not registered by running code
    public void Set1138_38C9_Dword32_gfxVtable05blit(ushort value) {
        SetUint32(0x38C9, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_38C9_Dword32_gfxVtable05blit(SegmentedAddress value) {
        SetUint16(0x38C9 + 2, value.Segment);
        SetUint16(0x38C9, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x38CD/0x14C4D.
    // Was accessed via the following registers: DS, SS
    public uint Get1138_38CD_Dword32_gfxVtable06() {
        return GetUint32(0x38CD);
    }

    // Was accessed via the following registers: DS, SS
    public SegmentedAddress GetPtr1138_38CD_Dword32_gfxVtable06() {
        return new SegmentedAddress(GetUint16(0x38CD + 2), GetUint16(0x38CD));
    }

    // Operation not registered by running code
    public void Set1138_38CD_Dword32_gfxVtable06(ushort value) {
        SetUint32(0x38CD, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_38CD_Dword32_gfxVtable06(SegmentedAddress value) {
        SetUint16(0x38CD + 2, value.Segment);
        SetUint16(0x38CD, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x38E1/0x14C61.
    // Was accessed via the following registers: SS
    public uint Get1138_38E1_Dword32_gfxVtable11memcpyDSToESFor64000() {
        return GetUint32(0x38E1);
    }

    // Was accessed via the following registers: SS
    public SegmentedAddress GetPtr1138_38E1_Dword32_gfxVtable11memcpyDSToESFor64000() {
        return new SegmentedAddress(GetUint16(0x38E1 + 2), GetUint16(0x38E1));
    }

    // Operation not registered by running code
    public void Set1138_38E1_Dword32_gfxVtable11memcpyDSToESFor64000(ushort value) {
        SetUint32(0x38E1, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_38E1_Dword32_gfxVtable11memcpyDSToESFor64000(SegmentedAddress value) {
        SetUint16(0x38E1 + 2, value.Segment);
        SetUint16(0x38E1, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x38E5/0x14C65.
    // Was accessed via the following registers: SS
    public uint Get1138_38E5_Dword32_gfxVtable12copyRectangle() {
        return GetUint32(0x38E5);
    }

    // Was accessed via the following registers: SS
    public SegmentedAddress GetPtr1138_38E5_Dword32_gfxVtable12copyRectangle() {
        return new SegmentedAddress(GetUint16(0x38E5 + 2), GetUint16(0x38E5));
    }

    // Operation not registered by running code
    public void Set1138_38E5_Dword32_gfxVtable12copyRectangle(ushort value) {
        SetUint32(0x38E5, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_38E5_Dword32_gfxVtable12copyRectangle(SegmentedAddress value) {
        SetUint16(0x38E5 + 2, value.Segment);
        SetUint16(0x38E5, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x38F1/0x14C71.
    // Was accessed via the following registers: SS
    public uint Get1138_38F1_Dword32_gfxVtable15memcpyDSToESFor64000() {
        return GetUint32(0x38F1);
    }

    // Was accessed via the following registers: SS
    public SegmentedAddress GetPtr1138_38F1_Dword32_gfxVtable15memcpyDSToESFor64000() {
        return new SegmentedAddress(GetUint16(0x38F1 + 2), GetUint16(0x38F1));
    }

    // Operation not registered by running code
    public void Set1138_38F1_Dword32_gfxVtable15memcpyDSToESFor64000(ushort value) {
        SetUint32(0x38F1, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_38F1_Dword32_gfxVtable15memcpyDSToESFor64000(SegmentedAddress value) {
        SetUint16(0x38F1 + 2, value.Segment);
        SetUint16(0x38F1, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x38F5/0x14C75.
    // Was accessed via the following registers: SS
    public uint Get1138_38F5_Dword32_gfxVtable16copySquareOfPixels() {
        return GetUint32(0x38F5);
    }

    // Was accessed via the following registers: SS
    public SegmentedAddress GetPtr1138_38F5_Dword32_gfxVtable16copySquareOfPixels() {
        return new SegmentedAddress(GetUint16(0x38F5 + 2), GetUint16(0x38F5));
    }

    // Operation not registered by running code
    public void Set1138_38F5_Dword32_gfxVtable16copySquareOfPixels(ushort value) {
        SetUint32(0x38F5, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_38F5_Dword32_gfxVtable16copySquareOfPixels(SegmentedAddress value) {
        SetUint16(0x38F5 + 2, value.Segment);
        SetUint16(0x38F5, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x3911/0x14C91.
    // Was accessed via the following registers: SS
    public uint Get1138_3911_Dword32_gfxVtable23() {
        return GetUint32(0x3911);
    }

    // Was accessed via the following registers: SS
    public SegmentedAddress GetPtr1138_3911_Dword32_gfxVtable23() {
        return new SegmentedAddress(GetUint16(0x3911 + 2), GetUint16(0x3911));
    }

    // Operation not registered by running code
    public void Set1138_3911_Dword32_gfxVtable23(ushort value) {
        SetUint32(0x3911, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_3911_Dword32_gfxVtable23(SegmentedAddress value) {
        SetUint16(0x3911 + 2, value.Segment);
        SetUint16(0x3911, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x3921/0x14CA1.
    // Was accessed via the following registers: SS
    public uint Get1138_3921_Dword32_gfxVtable27() {
        return GetUint32(0x3921);
    }

    // Was accessed via the following registers: SS
    public SegmentedAddress GetPtr1138_3921_Dword32_gfxVtable27() {
        return new SegmentedAddress(GetUint16(0x3921 + 2), GetUint16(0x3921));
    }

    // Operation not registered by running code
    public void Set1138_3921_Dword32_gfxVtable27(ushort value) {
        SetUint32(0x3921, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_3921_Dword32_gfxVtable27(SegmentedAddress value) {
        SetUint16(0x3921 + 2, value.Segment);
        SetUint16(0x3921, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x392D/0x14CAD.
    // Was accessed via the following registers: DS, SS
    public uint Get1138_392D_Dword32_gfxVtable30() {
        return GetUint32(0x392D);
    }

    // Was accessed via the following registers: DS, SS
    public SegmentedAddress GetPtr1138_392D_Dword32_gfxVtable30() {
        return new SegmentedAddress(GetUint16(0x392D + 2), GetUint16(0x392D));
    }

    // Operation not registered by running code
    public void Set1138_392D_Dword32_gfxVtable30(ushort value) {
        SetUint32(0x392D, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_392D_Dword32_gfxVtable30(SegmentedAddress value) {
        SetUint16(0x392D + 2, value.Segment);
        SetUint16(0x392D, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x3931/0x14CB1.
    // Was accessed via the following registers: SS
    public uint Get1138_3931_Dword32_gfxVtable31() {
        return GetUint32(0x3931);
    }

    // Was accessed via the following registers: SS
    public SegmentedAddress GetPtr1138_3931_Dword32_gfxVtable31() {
        return new SegmentedAddress(GetUint16(0x3931 + 2), GetUint16(0x3931));
    }

    // Operation not registered by running code
    public void Set1138_3931_Dword32_gfxVtable31(ushort value) {
        SetUint32(0x3931, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_3931_Dword32_gfxVtable31(SegmentedAddress value) {
        SetUint16(0x3931 + 2, value.Segment);
        SetUint16(0x3931, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x3941/0x14CC1.
    // Was accessed via the following registers: SS
    public uint Get1138_3941_Dword32_gfxVtable35() {
        return GetUint32(0x3941);
    }

    // Was accessed via the following registers: SS
    public SegmentedAddress GetPtr1138_3941_Dword32_gfxVtable35() {
        return new SegmentedAddress(GetUint16(0x3941 + 2), GetUint16(0x3941));
    }

    // Operation not registered by running code
    public void Set1138_3941_Dword32_gfxVtable35(ushort value) {
        SetUint32(0x3941, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_3941_Dword32_gfxVtable35(SegmentedAddress value) {
        SetUint16(0x3941 + 2, value.Segment);
        SetUint16(0x3941, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x3949/0x14CC9.
    // Was accessed via the following registers: SS
    public uint Get1138_3949_Dword32_gfxVtable37() {
        return GetUint32(0x3949);
    }

    // Was accessed via the following registers: SS
    public SegmentedAddress GetPtr1138_3949_Dword32_gfxVtable37() {
        return new SegmentedAddress(GetUint16(0x3949 + 2), GetUint16(0x3949));
    }

    // Operation not registered by running code
    public void Set1138_3949_Dword32_gfxVtable37(ushort value) {
        SetUint32(0x3949, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_3949_Dword32_gfxVtable37(SegmentedAddress value) {
        SetUint16(0x3949 + 2, value.Segment);
        SetUint16(0x3949, value.Offset);
    }

    // Getters and Setters for address 0x1138:0x39B9/0x14D39.
    // Was accessed via the following registers: DS, SS
    public int Get1138_39B9_Word16_allocatorNextFreeSegment() {
        return GetUint16(0x39B9);
    }

    // Was accessed via the following registers: DS
    public void Set1138_39B9_Word16_allocatorNextFreeSegment(ushort value) {
        SetUint16(0x39B9, value);
    }

    // Getters and Setters for address 0x1138:0x3BA2/0x14F22.
    // Was accessed via the following registers: SS
    public int Get1138_3BA2_Word16() {
        return GetUint16(0x3BA2);
    }

    // Operation not registered by running code
    public void Set1138_3BA2_Word16(ushort value) {
        SetUint16(0x3BA2, value);
    }

    // Getters and Setters for address 0x1138:0x3BAE/0x14F2E.
    // Was accessed via the following registers: SS
    public int Get1138_3BAE_Word16() {
        return GetUint16(0x3BAE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3BAE_Word16(ushort value) {
        SetUint16(0x3BAE, value);
    }

    // Getters and Setters for address 0x1138:0x3C54/0x14FD4.
    // Operation not registered by running code
    public int Get1138_3C54_Word16() {
        return GetUint16(0x3C54);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C54_Word16(ushort value) {
        SetUint16(0x3C54, value);
    }

    // Getters and Setters for address 0x1138:0x3C56/0x14FD6.
    // Operation not registered by running code
    public int Get1138_3C56_Word16() {
        return GetUint16(0x3C56);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C56_Word16(ushort value) {
        SetUint16(0x3C56, value);
    }

    // Getters and Setters for address 0x1138:0x3C58/0x14FD8.
    // Was accessed via the following registers: SS
    public int Get1138_3C58_Word16() {
        return GetUint16(0x3C58);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C58_Word16(ushort value) {
        SetUint16(0x3C58, value);
    }

    // Getters and Setters for address 0x1138:0x3C5A/0x14FDA.
    // Was accessed via the following registers: SS
    public int Get1138_3C5A_Word16() {
        return GetUint16(0x3C5A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C5A_Word16(ushort value) {
        SetUint16(0x3C5A, value);
    }

    // Getters and Setters for address 0x1138:0x3C5C/0x14FDC.
    // Was accessed via the following registers: SS
    public int Get1138_3C5C_Word16() {
        return GetUint16(0x3C5C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C5C_Word16(ushort value) {
        SetUint16(0x3C5C, value);
    }

    // Getters and Setters for address 0x1138:0x3C5E/0x14FDE.
    // Was accessed via the following registers: SS
    public int Get1138_3C5E_Word16() {
        return GetUint16(0x3C5E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C5E_Word16(ushort value) {
        SetUint16(0x3C5E, value);
    }

    // Getters and Setters for address 0x1138:0x3C60/0x14FE0.
    // Was accessed via the following registers: SS
    public int Get1138_3C60_Word16() {
        return GetUint16(0x3C60);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C60_Word16(ushort value) {
        SetUint16(0x3C60, value);
    }

    // Getters and Setters for address 0x1138:0x3C62/0x14FE2.
    // Was accessed via the following registers: SS
    public int Get1138_3C62_Word16() {
        return GetUint16(0x3C62);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C62_Word16(ushort value) {
        SetUint16(0x3C62, value);
    }

    // Getters and Setters for address 0x1138:0x3C64/0x14FE4.
    // Was accessed via the following registers: SS
    public int Get1138_3C64_Word16() {
        return GetUint16(0x3C64);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C64_Word16(ushort value) {
        SetUint16(0x3C64, value);
    }

    // Getters and Setters for address 0x1138:0x3C66/0x14FE6.
    // Was accessed via the following registers: SS
    public int Get1138_3C66_Word16() {
        return GetUint16(0x3C66);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C66_Word16(ushort value) {
        SetUint16(0x3C66, value);
    }

    // Getters and Setters for address 0x1138:0x3C68/0x14FE8.
    // Was accessed via the following registers: SS
    public int Get1138_3C68_Word16() {
        return GetUint16(0x3C68);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C68_Word16(ushort value) {
        SetUint16(0x3C68, value);
    }

    // Getters and Setters for address 0x1138:0x3C6A/0x14FEA.
    // Was accessed via the following registers: SS
    public int Get1138_3C6A_Word16() {
        return GetUint16(0x3C6A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C6A_Word16(ushort value) {
        SetUint16(0x3C6A, value);
    }

    // Getters and Setters for address 0x1138:0x3C6C/0x14FEC.
    // Was accessed via the following registers: SS
    public int Get1138_3C6C_Word16() {
        return GetUint16(0x3C6C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C6C_Word16(ushort value) {
        SetUint16(0x3C6C, value);
    }

    // Getters and Setters for address 0x1138:0x3C6E/0x14FEE.
    // Was accessed via the following registers: SS
    public int Get1138_3C6E_Word16() {
        return GetUint16(0x3C6E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C6E_Word16(ushort value) {
        SetUint16(0x3C6E, value);
    }

    // Getters and Setters for address 0x1138:0x3C70/0x14FF0.
    // Was accessed via the following registers: SS
    public int Get1138_3C70_Word16() {
        return GetUint16(0x3C70);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C70_Word16(ushort value) {
        SetUint16(0x3C70, value);
    }

    // Getters and Setters for address 0x1138:0x3C72/0x14FF2.
    // Was accessed via the following registers: SS
    public int Get1138_3C72_Word16() {
        return GetUint16(0x3C72);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C72_Word16(ushort value) {
        SetUint16(0x3C72, value);
    }

    // Getters and Setters for address 0x1138:0x3C74/0x14FF4.
    // Was accessed via the following registers: SS
    public int Get1138_3C74_Word16() {
        return GetUint16(0x3C74);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C74_Word16(ushort value) {
        SetUint16(0x3C74, value);
    }

    // Getters and Setters for address 0x1138:0x3C76/0x14FF6.
    // Was accessed via the following registers: SS
    public int Get1138_3C76_Word16() {
        return GetUint16(0x3C76);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C76_Word16(ushort value) {
        SetUint16(0x3C76, value);
    }

    // Getters and Setters for address 0x1138:0x3C78/0x14FF8.
    // Was accessed via the following registers: SS
    public int Get1138_3C78_Word16() {
        return GetUint16(0x3C78);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C78_Word16(ushort value) {
        SetUint16(0x3C78, value);
    }

    // Getters and Setters for address 0x1138:0x3C7A/0x14FFA.
    // Was accessed via the following registers: SS
    public int Get1138_3C7A_Word16() {
        return GetUint16(0x3C7A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C7A_Word16(ushort value) {
        SetUint16(0x3C7A, value);
    }

    // Getters and Setters for address 0x1138:0x3C7C/0x14FFC.
    // Operation not registered by running code
    public int Get1138_3C7C_Word16() {
        return GetUint16(0x3C7C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C7C_Word16(ushort value) {
        SetUint16(0x3C7C, value);
    }

    // Getters and Setters for address 0x1138:0x3C7E/0x14FFE.
    // Was accessed via the following registers: SS
    public int Get1138_3C7E_Word16() {
        return GetUint16(0x3C7E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C7E_Word16(ushort value) {
        SetUint16(0x3C7E, value);
    }

    // Getters and Setters for address 0x1138:0x3C80/0x15000.
    // Was accessed via the following registers: SS
    public int Get1138_3C80_Word16() {
        return GetUint16(0x3C80);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C80_Word16(ushort value) {
        SetUint16(0x3C80, value);
    }

    // Getters and Setters for address 0x1138:0x3C82/0x15002.
    // Was accessed via the following registers: SS
    public int Get1138_3C82_Word16() {
        return GetUint16(0x3C82);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C82_Word16(ushort value) {
        SetUint16(0x3C82, value);
    }

    // Getters and Setters for address 0x1138:0x3C84/0x15004.
    // Was accessed via the following registers: SS
    public int Get1138_3C84_Word16() {
        return GetUint16(0x3C84);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C84_Word16(ushort value) {
        SetUint16(0x3C84, value);
    }

    // Getters and Setters for address 0x1138:0x3C86/0x15006.
    // Was accessed via the following registers: SS
    public int Get1138_3C86_Word16() {
        return GetUint16(0x3C86);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C86_Word16(ushort value) {
        SetUint16(0x3C86, value);
    }

    // Getters and Setters for address 0x1138:0x3C88/0x15008.
    // Was accessed via the following registers: SS
    public int Get1138_3C88_Word16() {
        return GetUint16(0x3C88);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C88_Word16(ushort value) {
        SetUint16(0x3C88, value);
    }

    // Getters and Setters for address 0x1138:0x3C8A/0x1500A.
    // Was accessed via the following registers: SS
    public int Get1138_3C8A_Word16() {
        return GetUint16(0x3C8A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C8A_Word16(ushort value) {
        SetUint16(0x3C8A, value);
    }

    // Getters and Setters for address 0x1138:0x3C8C/0x1500C.
    // Was accessed via the following registers: SS
    public int Get1138_3C8C_Word16() {
        return GetUint16(0x3C8C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C8C_Word16(ushort value) {
        SetUint16(0x3C8C, value);
    }

    // Getters and Setters for address 0x1138:0x3C8E/0x1500E.
    // Was accessed via the following registers: SS
    public int Get1138_3C8E_Word16() {
        return GetUint16(0x3C8E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C8E_Word16(ushort value) {
        SetUint16(0x3C8E, value);
    }

    // Getters and Setters for address 0x1138:0x3C90/0x15010.
    // Was accessed via the following registers: SS
    public int Get1138_3C90_Word16() {
        return GetUint16(0x3C90);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C90_Word16(ushort value) {
        SetUint16(0x3C90, value);
    }

    // Getters and Setters for address 0x1138:0x3C92/0x15012.
    // Was accessed via the following registers: SS
    public int Get1138_3C92_Word16() {
        return GetUint16(0x3C92);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C92_Word16(ushort value) {
        SetUint16(0x3C92, value);
    }

    // Getters and Setters for address 0x1138:0x3C94/0x15014.
    // Was accessed via the following registers: SS
    public int Get1138_3C94_Word16() {
        return GetUint16(0x3C94);
    }

    // Operation not registered by running code
    public void Set1138_3C94_Word16(ushort value) {
        SetUint16(0x3C94, value);
    }

    // Getters and Setters for address 0x1138:0x3C96/0x15016.
    // Was accessed via the following registers: SS
    public int Get1138_3C96_Word16() {
        return GetUint16(0x3C96);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C96_Word16(ushort value) {
        SetUint16(0x3C96, value);
    }

    // Getters and Setters for address 0x1138:0x3C98/0x15018.
    // Was accessed via the following registers: SS
    public int Get1138_3C98_Word16() {
        return GetUint16(0x3C98);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C98_Word16(ushort value) {
        SetUint16(0x3C98, value);
    }

    // Getters and Setters for address 0x1138:0x3C9A/0x1501A.
    // Was accessed via the following registers: SS
    public int Get1138_3C9A_Word16() {
        return GetUint16(0x3C9A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C9A_Word16(ushort value) {
        SetUint16(0x3C9A, value);
    }

    // Getters and Setters for address 0x1138:0x3C9C/0x1501C.
    // Was accessed via the following registers: SS
    public int Get1138_3C9C_Word16() {
        return GetUint16(0x3C9C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3C9C_Word16(ushort value) {
        SetUint16(0x3C9C, value);
    }

    // Getters and Setters for address 0x1138:0x3C9E/0x1501E.
    // Was accessed via the following registers: SS
    public int Get1138_3C9E_Word16() {
        return GetUint16(0x3C9E);
    }

    // Operation not registered by running code
    public void Set1138_3C9E_Word16(ushort value) {
        SetUint16(0x3C9E, value);
    }

    // Getters and Setters for address 0x1138:0x3CA0/0x15020.
    // Was accessed via the following registers: SS
    public int Get1138_3CA0_Word16() {
        return GetUint16(0x3CA0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CA0_Word16(ushort value) {
        SetUint16(0x3CA0, value);
    }

    // Getters and Setters for address 0x1138:0x3CA2/0x15022.
    // Was accessed via the following registers: SS
    public int Get1138_3CA2_Word16() {
        return GetUint16(0x3CA2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CA2_Word16(ushort value) {
        SetUint16(0x3CA2, value);
    }

    // Getters and Setters for address 0x1138:0x3CA4/0x15024.
    // Was accessed via the following registers: SS
    public int Get1138_3CA4_Word16() {
        return GetUint16(0x3CA4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CA4_Word16(ushort value) {
        SetUint16(0x3CA4, value);
    }

    // Getters and Setters for address 0x1138:0x3CA5/0x15025.
    // Operation not registered by running code
    public int Get1138_3CA5_Byte8() {
        return GetUint8(0x3CA5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CA5_Byte8(byte value) {
        SetUint8(0x3CA5, value);
    }

    // Getters and Setters for address 0x1138:0x3CA6/0x15026.
    // Was accessed via the following registers: SS
    public int Get1138_3CA6_Word16() {
        return GetUint16(0x3CA6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CA6_Word16(ushort value) {
        SetUint16(0x3CA6, value);
    }

    // Getters and Setters for address 0x1138:0x3CA8/0x15028.
    // Operation not registered by running code
    public int Get1138_3CA8_Byte8() {
        return GetUint8(0x3CA8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CA8_Byte8(byte value) {
        SetUint8(0x3CA8, value);
    }

    // Was accessed via the following registers: SS
    public int Get1138_3CA8_Word16() {
        return GetUint16(0x3CA8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CA8_Word16(ushort value) {
        SetUint16(0x3CA8, value);
    }

    // Getters and Setters for address 0x1138:0x3CA9/0x15029.
    // Operation not registered by running code
    public int Get1138_3CA9_Byte8() {
        return GetUint8(0x3CA9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CA9_Byte8(byte value) {
        SetUint8(0x3CA9, value);
    }

    // Getters and Setters for address 0x1138:0x3CAA/0x1502A.
    // Operation not registered by running code
    public int Get1138_3CAA_Byte8() {
        return GetUint8(0x3CAA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CAA_Byte8(byte value) {
        SetUint8(0x3CAA, value);
    }

    // Was accessed via the following registers: SS
    public int Get1138_3CAA_Word16() {
        return GetUint16(0x3CAA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CAA_Word16(ushort value) {
        SetUint16(0x3CAA, value);
    }

    // Getters and Setters for address 0x1138:0x3CAB/0x1502B.
    // Operation not registered by running code
    public int Get1138_3CAB_Byte8() {
        return GetUint8(0x3CAB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CAB_Byte8(byte value) {
        SetUint8(0x3CAB, value);
    }

    // Getters and Setters for address 0x1138:0x3CAC/0x1502C.
    // Operation not registered by running code
    public int Get1138_3CAC_Byte8() {
        return GetUint8(0x3CAC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CAC_Byte8(byte value) {
        SetUint8(0x3CAC, value);
    }

    // Was accessed via the following registers: SS
    public int Get1138_3CAC_Word16() {
        return GetUint16(0x3CAC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CAC_Word16(ushort value) {
        SetUint16(0x3CAC, value);
    }

    // Getters and Setters for address 0x1138:0x3CAD/0x1502D.
    // Operation not registered by running code
    public int Get1138_3CAD_Byte8() {
        return GetUint8(0x3CAD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CAD_Byte8(byte value) {
        SetUint8(0x3CAD, value);
    }

    // Getters and Setters for address 0x1138:0x3CAE/0x1502E.
    // Operation not registered by running code
    public int Get1138_3CAE_Byte8() {
        return GetUint8(0x3CAE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CAE_Byte8(byte value) {
        SetUint8(0x3CAE, value);
    }

    // Was accessed via the following registers: SS
    public int Get1138_3CAE_Word16() {
        return GetUint16(0x3CAE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CAE_Word16(ushort value) {
        SetUint16(0x3CAE, value);
    }

    // Getters and Setters for address 0x1138:0x3CAF/0x1502F.
    // Operation not registered by running code
    public int Get1138_3CAF_Byte8() {
        return GetUint8(0x3CAF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CAF_Byte8(byte value) {
        SetUint8(0x3CAF, value);
    }

    // Getters and Setters for address 0x1138:0x3CB0/0x15030.
    // Was accessed via the following registers: SS
    public int Get1138_3CB0_Word16() {
        return GetUint16(0x3CB0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CB0_Word16(ushort value) {
        SetUint16(0x3CB0, value);
    }

    // Getters and Setters for address 0x1138:0x3CB2/0x15032.
    // Was accessed via the following registers: SS
    public int Get1138_3CB2_Word16() {
        return GetUint16(0x3CB2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CB2_Word16(ushort value) {
        SetUint16(0x3CB2, value);
    }

    // Getters and Setters for address 0x1138:0x3CB4/0x15034.
    // Was accessed via the following registers: SS
    public int Get1138_3CB4_Word16() {
        return GetUint16(0x3CB4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CB4_Word16(ushort value) {
        SetUint16(0x3CB4, value);
    }

    // Getters and Setters for address 0x1138:0x3CB6/0x15036.
    // Was accessed via the following registers: SS
    public int Get1138_3CB6_Word16() {
        return GetUint16(0x3CB6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_3CB6_Word16(ushort value) {
        SetUint16(0x3CB6, value);
    }

    // Getters and Setters for address 0x1138:0x4608/0x15988.
    // Operation not registered by running code
    public int Get1138_4608_Word16() {
        return GetUint16(0x4608);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4608_Word16(ushort value) {
        SetUint16(0x4608, value);
    }

    // Getters and Setters for address 0x1138:0x46D2/0x15A52.
    // Was accessed via the following registers: SS
    public int Get1138_46D2_Word16() {
        return GetUint16(0x46D2);
    }

    // Was accessed via the following registers: DS
    public void Set1138_46D2_Word16(ushort value) {
        SetUint16(0x46D2, value);
    }

    // Getters and Setters for address 0x1138:0x46D4/0x15A54.
    // Was accessed via the following registers: SS
    public int Get1138_46D4_Word16() {
        return GetUint16(0x46D4);
    }

    // Was accessed via the following registers: DS
    public void Set1138_46D4_Word16(ushort value) {
        SetUint16(0x46D4, value);
    }

    // Getters and Setters for address 0x1138:0x47CA/0x15B4A.
    // Was accessed via the following registers: DS, SS
    public int Get1138_47CA_Word16() {
        return GetUint16(0x47CA);
    }

    // Was accessed via the following registers: DS
    public void Set1138_47CA_Word16(ushort value) {
        SetUint16(0x47CA, value);
    }

    // Getters and Setters for address 0x1138:0x47CC/0x15B4C.
    // Was accessed via the following registers: SS
    public int Get1138_47CC_Word16() {
        return GetUint16(0x47CC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_47CC_Word16(ushort value) {
        SetUint16(0x47CC, value);
    }

    // Getters and Setters for address 0x1138:0x47D4/0x15B54.
    // Was accessed via the following registers: SS
    public int Get1138_47D4_Word16() {
        return GetUint16(0x47D4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_47D4_Word16(ushort value) {
        SetUint16(0x47D4, value);
    }

    // Getters and Setters for address 0x1138:0x47D6/0x15B56.
    // Was accessed via the following registers: SS
    public int Get1138_47D6_Word16() {
        return GetUint16(0x47D6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_47D6_Word16(ushort value) {
        SetUint16(0x47D6, value);
    }

    // Getters and Setters for address 0x1138:0x47D8/0x15B58.
    // Was accessed via the following registers: SS
    public int Get1138_47D8_Word16() {
        return GetUint16(0x47D8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_47D8_Word16(ushort value) {
        SetUint16(0x47D8, value);
    }

    // Getters and Setters for address 0x1138:0x47DA/0x15B5A.
    // Was accessed via the following registers: SS
    public int Get1138_47DA_Word16() {
        return GetUint16(0x47DA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_47DA_Word16(ushort value) {
        SetUint16(0x47DA, value);
    }

    // Getters and Setters for address 0x1138:0x4888/0x15C08.
    // Was accessed via the following registers: SS
    public int Get1138_4888_Word16() {
        return GetUint16(0x4888);
    }

    // Operation not registered by running code
    public void Set1138_4888_Word16(ushort value) {
        SetUint16(0x4888, value);
    }

    // Getters and Setters for address 0x1138:0x48B2/0x15C32.
    // Was accessed via the following registers: SS
    public int Get1138_48B2_Word16() {
        return GetUint16(0x48B2);
    }

    // Operation not registered by running code
    public void Set1138_48B2_Word16(ushort value) {
        SetUint16(0x48B2, value);
    }

    // Getters and Setters for address 0x1138:0x48B4/0x15C34.
    // Was accessed via the following registers: SS
    public int Get1138_48B4_Word16() {
        return GetUint16(0x48B4);
    }

    // Operation not registered by running code
    public void Set1138_48B4_Word16(ushort value) {
        SetUint16(0x48B4, value);
    }

    // Getters and Setters for address 0x1138:0x48B6/0x15C36.
    // Was accessed via the following registers: SS
    public int Get1138_48B6_Word16() {
        return GetUint16(0x48B6);
    }

    // Operation not registered by running code
    public void Set1138_48B6_Word16(ushort value) {
        SetUint16(0x48B6, value);
    }

    // Getters and Setters for address 0x1138:0x48B8/0x15C38.
    // Was accessed via the following registers: SS
    public int Get1138_48B8_Word16() {
        return GetUint16(0x48B8);
    }

    // Operation not registered by running code
    public void Set1138_48B8_Word16(ushort value) {
        SetUint16(0x48B8, value);
    }

    // Getters and Setters for address 0x1138:0x48BA/0x15C3A.
    // Was accessed via the following registers: SS
    public int Get1138_48BA_Word16() {
        return GetUint16(0x48BA);
    }

    // Operation not registered by running code
    public void Set1138_48BA_Word16(ushort value) {
        SetUint16(0x48BA, value);
    }

    // Getters and Setters for address 0x1138:0x48BC/0x15C3C.
    // Was accessed via the following registers: SS
    public int Get1138_48BC_Word16() {
        return GetUint16(0x48BC);
    }

    // Operation not registered by running code
    public void Set1138_48BC_Word16(ushort value) {
        SetUint16(0x48BC, value);
    }

    // Getters and Setters for address 0x1138:0x48BE/0x15C3E.
    // Was accessed via the following registers: SS
    public int Get1138_48BE_Word16() {
        return GetUint16(0x48BE);
    }

    // Operation not registered by running code
    public void Set1138_48BE_Word16(ushort value) {
        SetUint16(0x48BE, value);
    }

    // Getters and Setters for address 0x1138:0x48D2/0x15C52.
    // Was accessed via the following registers: SS
    public int Get1138_48D2_Word16() {
        return GetUint16(0x48D2);
    }

    // Operation not registered by running code
    public void Set1138_48D2_Word16(ushort value) {
        SetUint16(0x48D2, value);
    }

    // Getters and Setters for address 0x1138:0x48D4/0x15C54.
    // Was accessed via the following registers: SS
    public int Get1138_48D4_Word16() {
        return GetUint16(0x48D4);
    }

    // Operation not registered by running code
    public void Set1138_48D4_Word16(ushort value) {
        SetUint16(0x48D4, value);
    }

    // Getters and Setters for address 0x1138:0x48D6/0x15C56.
    // Was accessed via the following registers: SS
    public int Get1138_48D6_Word16() {
        return GetUint16(0x48D6);
    }

    // Operation not registered by running code
    public void Set1138_48D6_Word16(ushort value) {
        SetUint16(0x48D6, value);
    }

    // Getters and Setters for address 0x1138:0x48D8/0x15C58.
    // Was accessed via the following registers: SS
    public int Get1138_48D8_Word16() {
        return GetUint16(0x48D8);
    }

    // Operation not registered by running code
    public void Set1138_48D8_Word16(ushort value) {
        SetUint16(0x48D8, value);
    }

    // Getters and Setters for address 0x1138:0x48DA/0x15C5A.
    // Was accessed via the following registers: SS
    public int Get1138_48DA_Word16() {
        return GetUint16(0x48DA);
    }

    // Operation not registered by running code
    public void Set1138_48DA_Word16(ushort value) {
        SetUint16(0x48DA, value);
    }

    // Getters and Setters for address 0x1138:0x48DC/0x15C5C.
    // Was accessed via the following registers: SS
    public int Get1138_48DC_Word16() {
        return GetUint16(0x48DC);
    }

    // Operation not registered by running code
    public void Set1138_48DC_Word16(ushort value) {
        SetUint16(0x48DC, value);
    }

    // Getters and Setters for address 0x1138:0x48DE/0x15C5E.
    // Was accessed via the following registers: SS
    public int Get1138_48DE_Word16() {
        return GetUint16(0x48DE);
    }

    // Operation not registered by running code
    public void Set1138_48DE_Word16(ushort value) {
        SetUint16(0x48DE, value);
    }

    // Getters and Setters for address 0x1138:0x48E0/0x15C60.
    // Was accessed via the following registers: SS
    public int Get1138_48E0_Word16() {
        return GetUint16(0x48E0);
    }

    // Operation not registered by running code
    public void Set1138_48E0_Word16(ushort value) {
        SetUint16(0x48E0, value);
    }

    // Getters and Setters for address 0x1138:0x490C/0x15C8C.
    // Was accessed via the following registers: SS
    public int Get1138_490C_Word16() {
        return GetUint16(0x490C);
    }

    // Operation not registered by running code
    public void Set1138_490C_Word16(ushort value) {
        SetUint16(0x490C, value);
    }

    // Getters and Setters for address 0x1138:0x490E/0x15C8E.
    // Was accessed via the following registers: SS
    public int Get1138_490E_Word16() {
        return GetUint16(0x490E);
    }

    // Operation not registered by running code
    public void Set1138_490E_Word16(ushort value) {
        SetUint16(0x490E, value);
    }

    // Getters and Setters for address 0x1138:0x4948/0x15CC8.
    // Was accessed via the following registers: SS
    public int Get1138_4948_Word16() {
        return GetUint16(0x4948);
    }

    // Operation not registered by running code
    public void Set1138_4948_Word16(ushort value) {
        SetUint16(0x4948, value);
    }

    // Getters and Setters for address 0x1138:0x494A/0x15CCA.
    // Was accessed via the following registers: DS, SS
    public int Get1138_494A_Word16() {
        return GetUint16(0x494A);
    }

    // Operation not registered by running code
    public void Set1138_494A_Word16(ushort value) {
        SetUint16(0x494A, value);
    }

    // Getters and Setters for address 0x1138:0x494C/0x15CCC.
    // Was accessed via the following registers: DS, SS
    public int Get1138_494C_Word16() {
        return GetUint16(0x494C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_494C_Word16(ushort value) {
        SetUint16(0x494C, value);
    }

    // Getters and Setters for address 0x1138:0x494E/0x15CCE.
    // Operation not registered by running code
    public int Get1138_494E_Word16() {
        return GetUint16(0x494E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_494E_Word16(ushort value) {
        SetUint16(0x494E, value);
    }

    // Getters and Setters for address 0x1138:0x4950/0x15CD0.
    // Was accessed via the following registers: SS
    public int Get1138_4950_Word16() {
        return GetUint16(0x4950);
    }

    // Operation not registered by running code
    public void Set1138_4950_Word16(ushort value) {
        SetUint16(0x4950, value);
    }

    // Getters and Setters for address 0x1138:0x4952/0x15CD2.
    // Was accessed via the following registers: SS
    public int Get1138_4952_Word16() {
        return GetUint16(0x4952);
    }

    // Operation not registered by running code
    public void Set1138_4952_Word16(ushort value) {
        SetUint16(0x4952, value);
    }

    // Getters and Setters for address 0x1138:0x4954/0x15CD4.
    // Was accessed via the following registers: SS
    public int Get1138_4954_Word16() {
        return GetUint16(0x4954);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4954_Word16(ushort value) {
        SetUint16(0x4954, value);
    }

    // Getters and Setters for address 0x1138:0x4956/0x15CD6.
    // Operation not registered by running code
    public int Get1138_4956_Word16() {
        return GetUint16(0x4956);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4956_Word16(ushort value) {
        SetUint16(0x4956, value);
    }

    // Getters and Setters for address 0x1138:0x4958/0x15CD8.
    // Was accessed via the following registers: SS
    public int Get1138_4958_Word16() {
        return GetUint16(0x4958);
    }

    // Operation not registered by running code
    public void Set1138_4958_Word16(ushort value) {
        SetUint16(0x4958, value);
    }

    // Getters and Setters for address 0x1138:0x495A/0x15CDA.
    // Was accessed via the following registers: SS
    public int Get1138_495A_Word16() {
        return GetUint16(0x495A);
    }

    // Operation not registered by running code
    public void Set1138_495A_Word16(ushort value) {
        SetUint16(0x495A, value);
    }

    // Getters and Setters for address 0x1138:0x495C/0x15CDC.
    // Was accessed via the following registers: SS
    public int Get1138_495C_Word16() {
        return GetUint16(0x495C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_495C_Word16(ushort value) {
        SetUint16(0x495C, value);
    }

    // Getters and Setters for address 0x1138:0x495E/0x15CDE.
    // Operation not registered by running code
    public int Get1138_495E_Word16() {
        return GetUint16(0x495E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_495E_Word16(ushort value) {
        SetUint16(0x495E, value);
    }

    // Getters and Setters for address 0x1138:0x4960/0x15CE0.
    // Was accessed via the following registers: SS
    public int Get1138_4960_Word16() {
        return GetUint16(0x4960);
    }

    // Operation not registered by running code
    public void Set1138_4960_Word16(ushort value) {
        SetUint16(0x4960, value);
    }

    // Getters and Setters for address 0x1138:0x4962/0x15CE2.
    // Was accessed via the following registers: SS
    public int Get1138_4962_Word16() {
        return GetUint16(0x4962);
    }

    // Operation not registered by running code
    public void Set1138_4962_Word16(ushort value) {
        SetUint16(0x4962, value);
    }

    // Getters and Setters for address 0x1138:0x4964/0x15CE4.
    // Was accessed via the following registers: SS
    public int Get1138_4964_Word16() {
        return GetUint16(0x4964);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4964_Word16(ushort value) {
        SetUint16(0x4964, value);
    }

    // Getters and Setters for address 0x1138:0x4966/0x15CE6.
    // Operation not registered by running code
    public int Get1138_4966_Word16() {
        return GetUint16(0x4966);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4966_Word16(ushort value) {
        SetUint16(0x4966, value);
    }

    // Getters and Setters for address 0x1138:0x4968/0x15CE8.
    // Was accessed via the following registers: SS
    public int Get1138_4968_Word16() {
        return GetUint16(0x4968);
    }

    // Operation not registered by running code
    public void Set1138_4968_Word16(ushort value) {
        SetUint16(0x4968, value);
    }

    // Getters and Setters for address 0x1138:0x496A/0x15CEA.
    // Was accessed via the following registers: SS
    public int Get1138_496A_Word16() {
        return GetUint16(0x496A);
    }

    // Operation not registered by running code
    public void Set1138_496A_Word16(ushort value) {
        SetUint16(0x496A, value);
    }

    // Getters and Setters for address 0x1138:0x496C/0x15CEC.
    // Was accessed via the following registers: SS
    public int Get1138_496C_Word16() {
        return GetUint16(0x496C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_496C_Word16(ushort value) {
        SetUint16(0x496C, value);
    }

    // Getters and Setters for address 0x1138:0x496E/0x15CEE.
    // Operation not registered by running code
    public int Get1138_496E_Word16() {
        return GetUint16(0x496E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_496E_Word16(ushort value) {
        SetUint16(0x496E, value);
    }

    // Getters and Setters for address 0x1138:0x4970/0x15CF0.
    // Was accessed via the following registers: SS
    public int Get1138_4970_Word16() {
        return GetUint16(0x4970);
    }

    // Operation not registered by running code
    public void Set1138_4970_Word16(ushort value) {
        SetUint16(0x4970, value);
    }

    // Getters and Setters for address 0x1138:0x4972/0x15CF2.
    // Was accessed via the following registers: SS
    public int Get1138_4972_Word16() {
        return GetUint16(0x4972);
    }

    // Operation not registered by running code
    public void Set1138_4972_Word16(ushort value) {
        SetUint16(0x4972, value);
    }

    // Getters and Setters for address 0x1138:0x4974/0x15CF4.
    // Was accessed via the following registers: SS
    public int Get1138_4974_Word16() {
        return GetUint16(0x4974);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4974_Word16(ushort value) {
        SetUint16(0x4974, value);
    }

    // Getters and Setters for address 0x1138:0x4976/0x15CF6.
    // Operation not registered by running code
    public int Get1138_4976_Word16() {
        return GetUint16(0x4976);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4976_Word16(ushort value) {
        SetUint16(0x4976, value);
    }

    // Getters and Setters for address 0x1138:0x4978/0x15CF8.
    // Was accessed via the following registers: SS
    public int Get1138_4978_Word16() {
        return GetUint16(0x4978);
    }

    // Operation not registered by running code
    public void Set1138_4978_Word16(ushort value) {
        SetUint16(0x4978, value);
    }

    // Getters and Setters for address 0x1138:0x497A/0x15CFA.
    // Was accessed via the following registers: SS
    public int Get1138_497A_Word16() {
        return GetUint16(0x497A);
    }

    // Operation not registered by running code
    public void Set1138_497A_Word16(ushort value) {
        SetUint16(0x497A, value);
    }

    // Getters and Setters for address 0x1138:0x497C/0x15CFC.
    // Was accessed via the following registers: SS
    public int Get1138_497C_Word16() {
        return GetUint16(0x497C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_497C_Word16(ushort value) {
        SetUint16(0x497C, value);
    }

    // Getters and Setters for address 0x1138:0x497E/0x15CFE.
    // Operation not registered by running code
    public int Get1138_497E_Word16() {
        return GetUint16(0x497E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_497E_Word16(ushort value) {
        SetUint16(0x497E, value);
    }

    // Getters and Setters for address 0x1138:0x4980/0x15D00.
    // Was accessed via the following registers: SS
    public int Get1138_4980_Word16() {
        return GetUint16(0x4980);
    }

    // Operation not registered by running code
    public void Set1138_4980_Word16(ushort value) {
        SetUint16(0x4980, value);
    }

    // Getters and Setters for address 0x1138:0x4982/0x15D02.
    // Was accessed via the following registers: SS
    public int Get1138_4982_Word16() {
        return GetUint16(0x4982);
    }

    // Operation not registered by running code
    public void Set1138_4982_Word16(ushort value) {
        SetUint16(0x4982, value);
    }

    // Getters and Setters for address 0x1138:0x4984/0x15D04.
    // Was accessed via the following registers: SS
    public int Get1138_4984_Word16() {
        return GetUint16(0x4984);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4984_Word16(ushort value) {
        SetUint16(0x4984, value);
    }

    // Getters and Setters for address 0x1138:0x4986/0x15D06.
    // Operation not registered by running code
    public int Get1138_4986_Word16() {
        return GetUint16(0x4986);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4986_Word16(ushort value) {
        SetUint16(0x4986, value);
    }

    // Getters and Setters for address 0x1138:0x4988/0x15D08.
    // Was accessed via the following registers: SS
    public int Get1138_4988_Word16() {
        return GetUint16(0x4988);
    }

    // Operation not registered by running code
    public void Set1138_4988_Word16(ushort value) {
        SetUint16(0x4988, value);
    }

    // Getters and Setters for address 0x1138:0x498A/0x15D0A.
    // Was accessed via the following registers: SS
    public int Get1138_498A_Word16() {
        return GetUint16(0x498A);
    }

    // Operation not registered by running code
    public void Set1138_498A_Word16(ushort value) {
        SetUint16(0x498A, value);
    }

    // Getters and Setters for address 0x1138:0x498C/0x15D0C.
    // Was accessed via the following registers: SS
    public int Get1138_498C_Word16() {
        return GetUint16(0x498C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_498C_Word16(ushort value) {
        SetUint16(0x498C, value);
    }

    // Getters and Setters for address 0x1138:0x498E/0x15D0E.
    // Operation not registered by running code
    public int Get1138_498E_Word16() {
        return GetUint16(0x498E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_498E_Word16(ushort value) {
        SetUint16(0x498E, value);
    }

    // Getters and Setters for address 0x1138:0x4990/0x15D10.
    // Was accessed via the following registers: SS
    public int Get1138_4990_Word16() {
        return GetUint16(0x4990);
    }

    // Operation not registered by running code
    public void Set1138_4990_Word16(ushort value) {
        SetUint16(0x4990, value);
    }

    // Getters and Setters for address 0x1138:0x4992/0x15D12.
    // Was accessed via the following registers: SS
    public int Get1138_4992_Word16() {
        return GetUint16(0x4992);
    }

    // Operation not registered by running code
    public void Set1138_4992_Word16(ushort value) {
        SetUint16(0x4992, value);
    }

    // Getters and Setters for address 0x1138:0x4994/0x15D14.
    // Was accessed via the following registers: SS
    public int Get1138_4994_Word16() {
        return GetUint16(0x4994);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4994_Word16(ushort value) {
        SetUint16(0x4994, value);
    }

    // Getters and Setters for address 0x1138:0x4996/0x15D16.
    // Operation not registered by running code
    public int Get1138_4996_Word16() {
        return GetUint16(0x4996);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4996_Word16(ushort value) {
        SetUint16(0x4996, value);
    }

    // Getters and Setters for address 0x1138:0x4998/0x15D18.
    // Was accessed via the following registers: SS
    public int Get1138_4998_Word16() {
        return GetUint16(0x4998);
    }

    // Operation not registered by running code
    public void Set1138_4998_Word16(ushort value) {
        SetUint16(0x4998, value);
    }

    // Getters and Setters for address 0x1138:0x499A/0x15D1A.
    // Was accessed via the following registers: SS
    public int Get1138_499A_Word16() {
        return GetUint16(0x499A);
    }

    // Operation not registered by running code
    public void Set1138_499A_Word16(ushort value) {
        SetUint16(0x499A, value);
    }

    // Getters and Setters for address 0x1138:0x499C/0x15D1C.
    // Was accessed via the following registers: SS
    public int Get1138_499C_Word16() {
        return GetUint16(0x499C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_499C_Word16(ushort value) {
        SetUint16(0x499C, value);
    }

    // Getters and Setters for address 0x1138:0x499E/0x15D1E.
    // Operation not registered by running code
    public int Get1138_499E_Word16() {
        return GetUint16(0x499E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_499E_Word16(ushort value) {
        SetUint16(0x499E, value);
    }

    // Getters and Setters for address 0x1138:0x49A0/0x15D20.
    // Was accessed via the following registers: SS
    public int Get1138_49A0_Word16() {
        return GetUint16(0x49A0);
    }

    // Operation not registered by running code
    public void Set1138_49A0_Word16(ushort value) {
        SetUint16(0x49A0, value);
    }

    // Getters and Setters for address 0x1138:0x49A2/0x15D22.
    // Was accessed via the following registers: SS
    public int Get1138_49A2_Word16() {
        return GetUint16(0x49A2);
    }

    // Operation not registered by running code
    public void Set1138_49A2_Word16(ushort value) {
        SetUint16(0x49A2, value);
    }

    // Getters and Setters for address 0x1138:0x49A4/0x15D24.
    // Was accessed via the following registers: SS
    public int Get1138_49A4_Word16() {
        return GetUint16(0x49A4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49A4_Word16(ushort value) {
        SetUint16(0x49A4, value);
    }

    // Getters and Setters for address 0x1138:0x49A6/0x15D26.
    // Operation not registered by running code
    public int Get1138_49A6_Word16() {
        return GetUint16(0x49A6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49A6_Word16(ushort value) {
        SetUint16(0x49A6, value);
    }

    // Getters and Setters for address 0x1138:0x49A8/0x15D28.
    // Was accessed via the following registers: SS
    public int Get1138_49A8_Word16() {
        return GetUint16(0x49A8);
    }

    // Operation not registered by running code
    public void Set1138_49A8_Word16(ushort value) {
        SetUint16(0x49A8, value);
    }

    // Getters and Setters for address 0x1138:0x49AA/0x15D2A.
    // Was accessed via the following registers: SS
    public int Get1138_49AA_Word16() {
        return GetUint16(0x49AA);
    }

    // Operation not registered by running code
    public void Set1138_49AA_Word16(ushort value) {
        SetUint16(0x49AA, value);
    }

    // Getters and Setters for address 0x1138:0x49AC/0x15D2C.
    // Was accessed via the following registers: SS
    public int Get1138_49AC_Word16() {
        return GetUint16(0x49AC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49AC_Word16(ushort value) {
        SetUint16(0x49AC, value);
    }

    // Getters and Setters for address 0x1138:0x49AE/0x15D2E.
    // Operation not registered by running code
    public int Get1138_49AE_Word16() {
        return GetUint16(0x49AE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49AE_Word16(ushort value) {
        SetUint16(0x49AE, value);
    }

    // Getters and Setters for address 0x1138:0x49B0/0x15D30.
    // Was accessed via the following registers: SS
    public int Get1138_49B0_Word16() {
        return GetUint16(0x49B0);
    }

    // Operation not registered by running code
    public void Set1138_49B0_Word16(ushort value) {
        SetUint16(0x49B0, value);
    }

    // Getters and Setters for address 0x1138:0x49B2/0x15D32.
    // Was accessed via the following registers: SS
    public int Get1138_49B2_Word16() {
        return GetUint16(0x49B2);
    }

    // Operation not registered by running code
    public void Set1138_49B2_Word16(ushort value) {
        SetUint16(0x49B2, value);
    }

    // Getters and Setters for address 0x1138:0x49B4/0x15D34.
    // Was accessed via the following registers: SS
    public int Get1138_49B4_Word16() {
        return GetUint16(0x49B4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49B4_Word16(ushort value) {
        SetUint16(0x49B4, value);
    }

    // Getters and Setters for address 0x1138:0x49B6/0x15D36.
    // Operation not registered by running code
    public int Get1138_49B6_Word16() {
        return GetUint16(0x49B6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49B6_Word16(ushort value) {
        SetUint16(0x49B6, value);
    }

    // Getters and Setters for address 0x1138:0x49B8/0x15D38.
    // Was accessed via the following registers: SS
    public int Get1138_49B8_Word16() {
        return GetUint16(0x49B8);
    }

    // Operation not registered by running code
    public void Set1138_49B8_Word16(ushort value) {
        SetUint16(0x49B8, value);
    }

    // Getters and Setters for address 0x1138:0x49BA/0x15D3A.
    // Was accessed via the following registers: SS
    public int Get1138_49BA_Word16() {
        return GetUint16(0x49BA);
    }

    // Operation not registered by running code
    public void Set1138_49BA_Word16(ushort value) {
        SetUint16(0x49BA, value);
    }

    // Getters and Setters for address 0x1138:0x49BC/0x15D3C.
    // Was accessed via the following registers: SS
    public int Get1138_49BC_Word16() {
        return GetUint16(0x49BC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49BC_Word16(ushort value) {
        SetUint16(0x49BC, value);
    }

    // Getters and Setters for address 0x1138:0x49BE/0x15D3E.
    // Operation not registered by running code
    public int Get1138_49BE_Word16() {
        return GetUint16(0x49BE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49BE_Word16(ushort value) {
        SetUint16(0x49BE, value);
    }

    // Getters and Setters for address 0x1138:0x49C0/0x15D40.
    // Was accessed via the following registers: SS
    public int Get1138_49C0_Word16() {
        return GetUint16(0x49C0);
    }

    // Operation not registered by running code
    public void Set1138_49C0_Word16(ushort value) {
        SetUint16(0x49C0, value);
    }

    // Getters and Setters for address 0x1138:0x49C2/0x15D42.
    // Was accessed via the following registers: SS
    public int Get1138_49C2_Word16() {
        return GetUint16(0x49C2);
    }

    // Operation not registered by running code
    public void Set1138_49C2_Word16(ushort value) {
        SetUint16(0x49C2, value);
    }

    // Getters and Setters for address 0x1138:0x49C4/0x15D44.
    // Was accessed via the following registers: SS
    public int Get1138_49C4_Word16() {
        return GetUint16(0x49C4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49C4_Word16(ushort value) {
        SetUint16(0x49C4, value);
    }

    // Getters and Setters for address 0x1138:0x49C6/0x15D46.
    // Operation not registered by running code
    public int Get1138_49C6_Word16() {
        return GetUint16(0x49C6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49C6_Word16(ushort value) {
        SetUint16(0x49C6, value);
    }

    // Getters and Setters for address 0x1138:0x49C8/0x15D48.
    // Was accessed via the following registers: SS
    public int Get1138_49C8_Word16() {
        return GetUint16(0x49C8);
    }

    // Operation not registered by running code
    public void Set1138_49C8_Word16(ushort value) {
        SetUint16(0x49C8, value);
    }

    // Getters and Setters for address 0x1138:0x49CA/0x15D4A.
    // Was accessed via the following registers: SS
    public int Get1138_49CA_Word16() {
        return GetUint16(0x49CA);
    }

    // Operation not registered by running code
    public void Set1138_49CA_Word16(ushort value) {
        SetUint16(0x49CA, value);
    }

    // Getters and Setters for address 0x1138:0x49CC/0x15D4C.
    // Was accessed via the following registers: SS
    public int Get1138_49CC_Word16() {
        return GetUint16(0x49CC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49CC_Word16(ushort value) {
        SetUint16(0x49CC, value);
    }

    // Getters and Setters for address 0x1138:0x49CE/0x15D4E.
    // Operation not registered by running code
    public int Get1138_49CE_Word16() {
        return GetUint16(0x49CE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49CE_Word16(ushort value) {
        SetUint16(0x49CE, value);
    }

    // Getters and Setters for address 0x1138:0x49D0/0x15D50.
    // Was accessed via the following registers: SS
    public int Get1138_49D0_Word16() {
        return GetUint16(0x49D0);
    }

    // Operation not registered by running code
    public void Set1138_49D0_Word16(ushort value) {
        SetUint16(0x49D0, value);
    }

    // Getters and Setters for address 0x1138:0x49D2/0x15D52.
    // Was accessed via the following registers: SS
    public int Get1138_49D2_Word16() {
        return GetUint16(0x49D2);
    }

    // Operation not registered by running code
    public void Set1138_49D2_Word16(ushort value) {
        SetUint16(0x49D2, value);
    }

    // Getters and Setters for address 0x1138:0x49D4/0x15D54.
    // Was accessed via the following registers: SS
    public int Get1138_49D4_Word16() {
        return GetUint16(0x49D4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49D4_Word16(ushort value) {
        SetUint16(0x49D4, value);
    }

    // Getters and Setters for address 0x1138:0x49D6/0x15D56.
    // Operation not registered by running code
    public int Get1138_49D6_Word16() {
        return GetUint16(0x49D6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49D6_Word16(ushort value) {
        SetUint16(0x49D6, value);
    }

    // Getters and Setters for address 0x1138:0x49D8/0x15D58.
    // Was accessed via the following registers: SS
    public int Get1138_49D8_Word16() {
        return GetUint16(0x49D8);
    }

    // Operation not registered by running code
    public void Set1138_49D8_Word16(ushort value) {
        SetUint16(0x49D8, value);
    }

    // Getters and Setters for address 0x1138:0x49DA/0x15D5A.
    // Was accessed via the following registers: SS
    public int Get1138_49DA_Word16() {
        return GetUint16(0x49DA);
    }

    // Operation not registered by running code
    public void Set1138_49DA_Word16(ushort value) {
        SetUint16(0x49DA, value);
    }

    // Getters and Setters for address 0x1138:0x49DC/0x15D5C.
    // Was accessed via the following registers: SS
    public int Get1138_49DC_Word16() {
        return GetUint16(0x49DC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49DC_Word16(ushort value) {
        SetUint16(0x49DC, value);
    }

    // Getters and Setters for address 0x1138:0x49DE/0x15D5E.
    // Operation not registered by running code
    public int Get1138_49DE_Word16() {
        return GetUint16(0x49DE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49DE_Word16(ushort value) {
        SetUint16(0x49DE, value);
    }

    // Getters and Setters for address 0x1138:0x49E0/0x15D60.
    // Was accessed via the following registers: SS
    public int Get1138_49E0_Word16() {
        return GetUint16(0x49E0);
    }

    // Operation not registered by running code
    public void Set1138_49E0_Word16(ushort value) {
        SetUint16(0x49E0, value);
    }

    // Getters and Setters for address 0x1138:0x49E2/0x15D62.
    // Was accessed via the following registers: SS
    public int Get1138_49E2_Word16() {
        return GetUint16(0x49E2);
    }

    // Operation not registered by running code
    public void Set1138_49E2_Word16(ushort value) {
        SetUint16(0x49E2, value);
    }

    // Getters and Setters for address 0x1138:0x49E4/0x15D64.
    // Was accessed via the following registers: SS
    public int Get1138_49E4_Word16() {
        return GetUint16(0x49E4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49E4_Word16(ushort value) {
        SetUint16(0x49E4, value);
    }

    // Getters and Setters for address 0x1138:0x49E6/0x15D66.
    // Operation not registered by running code
    public int Get1138_49E6_Word16() {
        return GetUint16(0x49E6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49E6_Word16(ushort value) {
        SetUint16(0x49E6, value);
    }

    // Getters and Setters for address 0x1138:0x49E8/0x15D68.
    // Was accessed via the following registers: SS
    public int Get1138_49E8_Word16() {
        return GetUint16(0x49E8);
    }

    // Operation not registered by running code
    public void Set1138_49E8_Word16(ushort value) {
        SetUint16(0x49E8, value);
    }

    // Getters and Setters for address 0x1138:0x49EA/0x15D6A.
    // Was accessed via the following registers: SS
    public int Get1138_49EA_Word16() {
        return GetUint16(0x49EA);
    }

    // Operation not registered by running code
    public void Set1138_49EA_Word16(ushort value) {
        SetUint16(0x49EA, value);
    }

    // Getters and Setters for address 0x1138:0x49EC/0x15D6C.
    // Was accessed via the following registers: SS
    public int Get1138_49EC_Word16() {
        return GetUint16(0x49EC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49EC_Word16(ushort value) {
        SetUint16(0x49EC, value);
    }

    // Getters and Setters for address 0x1138:0x49EE/0x15D6E.
    // Operation not registered by running code
    public int Get1138_49EE_Word16() {
        return GetUint16(0x49EE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49EE_Word16(ushort value) {
        SetUint16(0x49EE, value);
    }

    // Getters and Setters for address 0x1138:0x49F0/0x15D70.
    // Was accessed via the following registers: SS
    public int Get1138_49F0_Word16() {
        return GetUint16(0x49F0);
    }

    // Operation not registered by running code
    public void Set1138_49F0_Word16(ushort value) {
        SetUint16(0x49F0, value);
    }

    // Getters and Setters for address 0x1138:0x49F2/0x15D72.
    // Was accessed via the following registers: SS
    public int Get1138_49F2_Word16() {
        return GetUint16(0x49F2);
    }

    // Operation not registered by running code
    public void Set1138_49F2_Word16(ushort value) {
        SetUint16(0x49F2, value);
    }

    // Getters and Setters for address 0x1138:0x49F4/0x15D74.
    // Was accessed via the following registers: SS
    public int Get1138_49F4_Word16() {
        return GetUint16(0x49F4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49F4_Word16(ushort value) {
        SetUint16(0x49F4, value);
    }

    // Getters and Setters for address 0x1138:0x49F6/0x15D76.
    // Operation not registered by running code
    public int Get1138_49F6_Word16() {
        return GetUint16(0x49F6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49F6_Word16(ushort value) {
        SetUint16(0x49F6, value);
    }

    // Getters and Setters for address 0x1138:0x49F8/0x15D78.
    // Was accessed via the following registers: SS
    public int Get1138_49F8_Word16() {
        return GetUint16(0x49F8);
    }

    // Operation not registered by running code
    public void Set1138_49F8_Word16(ushort value) {
        SetUint16(0x49F8, value);
    }

    // Getters and Setters for address 0x1138:0x49FA/0x15D7A.
    // Was accessed via the following registers: SS
    public int Get1138_49FA_Word16() {
        return GetUint16(0x49FA);
    }

    // Operation not registered by running code
    public void Set1138_49FA_Word16(ushort value) {
        SetUint16(0x49FA, value);
    }

    // Getters and Setters for address 0x1138:0x49FC/0x15D7C.
    // Was accessed via the following registers: SS
    public int Get1138_49FC_Word16() {
        return GetUint16(0x49FC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49FC_Word16(ushort value) {
        SetUint16(0x49FC, value);
    }

    // Getters and Setters for address 0x1138:0x49FE/0x15D7E.
    // Operation not registered by running code
    public int Get1138_49FE_Word16() {
        return GetUint16(0x49FE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_49FE_Word16(ushort value) {
        SetUint16(0x49FE, value);
    }

    // Getters and Setters for address 0x1138:0x4A00/0x15D80.
    // Was accessed via the following registers: SS
    public int Get1138_4A00_Word16() {
        return GetUint16(0x4A00);
    }

    // Operation not registered by running code
    public void Set1138_4A00_Word16(ushort value) {
        SetUint16(0x4A00, value);
    }

    // Getters and Setters for address 0x1138:0x4A02/0x15D82.
    // Was accessed via the following registers: SS
    public int Get1138_4A02_Word16() {
        return GetUint16(0x4A02);
    }

    // Operation not registered by running code
    public void Set1138_4A02_Word16(ushort value) {
        SetUint16(0x4A02, value);
    }

    // Getters and Setters for address 0x1138:0x4A04/0x15D84.
    // Was accessed via the following registers: SS
    public int Get1138_4A04_Word16() {
        return GetUint16(0x4A04);
    }

    // Operation not registered by running code
    public void Set1138_4A04_Word16(ushort value) {
        SetUint16(0x4A04, value);
    }

    // Getters and Setters for address 0x1138:0x4A06/0x15D86.
    // Operation not registered by running code
    public int Get1138_4A06_Word16() {
        return GetUint16(0x4A06);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A06_Word16(ushort value) {
        SetUint16(0x4A06, value);
    }

    // Getters and Setters for address 0x1138:0x4A08/0x15D88.
    // Was accessed via the following registers: SS
    public int Get1138_4A08_Word16() {
        return GetUint16(0x4A08);
    }

    // Operation not registered by running code
    public void Set1138_4A08_Word16(ushort value) {
        SetUint16(0x4A08, value);
    }

    // Getters and Setters for address 0x1138:0x4A0A/0x15D8A.
    // Was accessed via the following registers: SS
    public int Get1138_4A0A_Word16() {
        return GetUint16(0x4A0A);
    }

    // Operation not registered by running code
    public void Set1138_4A0A_Word16(ushort value) {
        SetUint16(0x4A0A, value);
    }

    // Getters and Setters for address 0x1138:0x4A0C/0x15D8C.
    // Was accessed via the following registers: SS
    public int Get1138_4A0C_Word16() {
        return GetUint16(0x4A0C);
    }

    // Operation not registered by running code
    public void Set1138_4A0C_Word16(ushort value) {
        SetUint16(0x4A0C, value);
    }

    // Getters and Setters for address 0x1138:0x4A0E/0x15D8E.
    // Operation not registered by running code
    public int Get1138_4A0E_Word16() {
        return GetUint16(0x4A0E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A0E_Word16(ushort value) {
        SetUint16(0x4A0E, value);
    }

    // Getters and Setters for address 0x1138:0x4A10/0x15D90.
    // Was accessed via the following registers: SS
    public int Get1138_4A10_Word16() {
        return GetUint16(0x4A10);
    }

    // Operation not registered by running code
    public void Set1138_4A10_Word16(ushort value) {
        SetUint16(0x4A10, value);
    }

    // Getters and Setters for address 0x1138:0x4A12/0x15D92.
    // Was accessed via the following registers: SS
    public int Get1138_4A12_Word16() {
        return GetUint16(0x4A12);
    }

    // Operation not registered by running code
    public void Set1138_4A12_Word16(ushort value) {
        SetUint16(0x4A12, value);
    }

    // Getters and Setters for address 0x1138:0x4A14/0x15D94.
    // Was accessed via the following registers: SS
    public int Get1138_4A14_Word16() {
        return GetUint16(0x4A14);
    }

    // Operation not registered by running code
    public void Set1138_4A14_Word16(ushort value) {
        SetUint16(0x4A14, value);
    }

    // Getters and Setters for address 0x1138:0x4A16/0x15D96.
    // Operation not registered by running code
    public int Get1138_4A16_Word16() {
        return GetUint16(0x4A16);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A16_Word16(ushort value) {
        SetUint16(0x4A16, value);
    }

    // Getters and Setters for address 0x1138:0x4A18/0x15D98.
    // Was accessed via the following registers: SS
    public int Get1138_4A18_Word16() {
        return GetUint16(0x4A18);
    }

    // Operation not registered by running code
    public void Set1138_4A18_Word16(ushort value) {
        SetUint16(0x4A18, value);
    }

    // Getters and Setters for address 0x1138:0x4A1A/0x15D9A.
    // Was accessed via the following registers: SS
    public int Get1138_4A1A_Word16() {
        return GetUint16(0x4A1A);
    }

    // Operation not registered by running code
    public void Set1138_4A1A_Word16(ushort value) {
        SetUint16(0x4A1A, value);
    }

    // Getters and Setters for address 0x1138:0x4A1C/0x15D9C.
    // Was accessed via the following registers: SS
    public int Get1138_4A1C_Word16() {
        return GetUint16(0x4A1C);
    }

    // Operation not registered by running code
    public void Set1138_4A1C_Word16(ushort value) {
        SetUint16(0x4A1C, value);
    }

    // Getters and Setters for address 0x1138:0x4A1E/0x15D9E.
    // Operation not registered by running code
    public int Get1138_4A1E_Word16() {
        return GetUint16(0x4A1E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A1E_Word16(ushort value) {
        SetUint16(0x4A1E, value);
    }

    // Getters and Setters for address 0x1138:0x4A20/0x15DA0.
    // Was accessed via the following registers: SS
    public int Get1138_4A20_Word16() {
        return GetUint16(0x4A20);
    }

    // Operation not registered by running code
    public void Set1138_4A20_Word16(ushort value) {
        SetUint16(0x4A20, value);
    }

    // Getters and Setters for address 0x1138:0x4A22/0x15DA2.
    // Was accessed via the following registers: SS
    public int Get1138_4A22_Word16() {
        return GetUint16(0x4A22);
    }

    // Operation not registered by running code
    public void Set1138_4A22_Word16(ushort value) {
        SetUint16(0x4A22, value);
    }

    // Getters and Setters for address 0x1138:0x4A24/0x15DA4.
    // Was accessed via the following registers: SS
    public int Get1138_4A24_Word16() {
        return GetUint16(0x4A24);
    }

    // Operation not registered by running code
    public void Set1138_4A24_Word16(ushort value) {
        SetUint16(0x4A24, value);
    }

    // Getters and Setters for address 0x1138:0x4A26/0x15DA6.
    // Operation not registered by running code
    public int Get1138_4A26_Word16() {
        return GetUint16(0x4A26);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A26_Word16(ushort value) {
        SetUint16(0x4A26, value);
    }

    // Getters and Setters for address 0x1138:0x4A28/0x15DA8.
    // Was accessed via the following registers: SS
    public int Get1138_4A28_Word16() {
        return GetUint16(0x4A28);
    }

    // Operation not registered by running code
    public void Set1138_4A28_Word16(ushort value) {
        SetUint16(0x4A28, value);
    }

    // Getters and Setters for address 0x1138:0x4A2A/0x15DAA.
    // Was accessed via the following registers: SS
    public int Get1138_4A2A_Word16() {
        return GetUint16(0x4A2A);
    }

    // Operation not registered by running code
    public void Set1138_4A2A_Word16(ushort value) {
        SetUint16(0x4A2A, value);
    }

    // Getters and Setters for address 0x1138:0x4A2C/0x15DAC.
    // Was accessed via the following registers: SS
    public int Get1138_4A2C_Word16() {
        return GetUint16(0x4A2C);
    }

    // Operation not registered by running code
    public void Set1138_4A2C_Word16(ushort value) {
        SetUint16(0x4A2C, value);
    }

    // Getters and Setters for address 0x1138:0x4A2E/0x15DAE.
    // Operation not registered by running code
    public int Get1138_4A2E_Word16() {
        return GetUint16(0x4A2E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A2E_Word16(ushort value) {
        SetUint16(0x4A2E, value);
    }

    // Getters and Setters for address 0x1138:0x4A30/0x15DB0.
    // Was accessed via the following registers: SS
    public int Get1138_4A30_Word16() {
        return GetUint16(0x4A30);
    }

    // Operation not registered by running code
    public void Set1138_4A30_Word16(ushort value) {
        SetUint16(0x4A30, value);
    }

    // Getters and Setters for address 0x1138:0x4A32/0x15DB2.
    // Was accessed via the following registers: SS
    public int Get1138_4A32_Word16() {
        return GetUint16(0x4A32);
    }

    // Operation not registered by running code
    public void Set1138_4A32_Word16(ushort value) {
        SetUint16(0x4A32, value);
    }

    // Getters and Setters for address 0x1138:0x4A34/0x15DB4.
    // Was accessed via the following registers: SS
    public int Get1138_4A34_Word16() {
        return GetUint16(0x4A34);
    }

    // Operation not registered by running code
    public void Set1138_4A34_Word16(ushort value) {
        SetUint16(0x4A34, value);
    }

    // Getters and Setters for address 0x1138:0x4A36/0x15DB6.
    // Operation not registered by running code
    public int Get1138_4A36_Word16() {
        return GetUint16(0x4A36);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A36_Word16(ushort value) {
        SetUint16(0x4A36, value);
    }

    // Getters and Setters for address 0x1138:0x4A38/0x15DB8.
    // Was accessed via the following registers: SS
    public int Get1138_4A38_Word16() {
        return GetUint16(0x4A38);
    }

    // Operation not registered by running code
    public void Set1138_4A38_Word16(ushort value) {
        SetUint16(0x4A38, value);
    }

    // Getters and Setters for address 0x1138:0x4A3A/0x15DBA.
    // Was accessed via the following registers: SS
    public int Get1138_4A3A_Word16() {
        return GetUint16(0x4A3A);
    }

    // Operation not registered by running code
    public void Set1138_4A3A_Word16(ushort value) {
        SetUint16(0x4A3A, value);
    }

    // Getters and Setters for address 0x1138:0x4A3C/0x15DBC.
    // Was accessed via the following registers: SS
    public int Get1138_4A3C_Word16() {
        return GetUint16(0x4A3C);
    }

    // Operation not registered by running code
    public void Set1138_4A3C_Word16(ushort value) {
        SetUint16(0x4A3C, value);
    }

    // Getters and Setters for address 0x1138:0x4A3E/0x15DBE.
    // Operation not registered by running code
    public int Get1138_4A3E_Word16() {
        return GetUint16(0x4A3E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A3E_Word16(ushort value) {
        SetUint16(0x4A3E, value);
    }

    // Getters and Setters for address 0x1138:0x4A40/0x15DC0.
    // Was accessed via the following registers: SS
    public int Get1138_4A40_Word16() {
        return GetUint16(0x4A40);
    }

    // Operation not registered by running code
    public void Set1138_4A40_Word16(ushort value) {
        SetUint16(0x4A40, value);
    }

    // Getters and Setters for address 0x1138:0x4A42/0x15DC2.
    // Was accessed via the following registers: SS
    public int Get1138_4A42_Word16() {
        return GetUint16(0x4A42);
    }

    // Operation not registered by running code
    public void Set1138_4A42_Word16(ushort value) {
        SetUint16(0x4A42, value);
    }

    // Getters and Setters for address 0x1138:0x4A44/0x15DC4.
    // Was accessed via the following registers: SS
    public int Get1138_4A44_Word16() {
        return GetUint16(0x4A44);
    }

    // Operation not registered by running code
    public void Set1138_4A44_Word16(ushort value) {
        SetUint16(0x4A44, value);
    }

    // Getters and Setters for address 0x1138:0x4A46/0x15DC6.
    // Operation not registered by running code
    public int Get1138_4A46_Word16() {
        return GetUint16(0x4A46);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A46_Word16(ushort value) {
        SetUint16(0x4A46, value);
    }

    // Getters and Setters for address 0x1138:0x4A48/0x15DC8.
    // Was accessed via the following registers: SS
    public int Get1138_4A48_Word16() {
        return GetUint16(0x4A48);
    }

    // Operation not registered by running code
    public void Set1138_4A48_Word16(ushort value) {
        SetUint16(0x4A48, value);
    }

    // Getters and Setters for address 0x1138:0x4A4A/0x15DCA.
    // Was accessed via the following registers: SS
    public int Get1138_4A4A_Word16() {
        return GetUint16(0x4A4A);
    }

    // Operation not registered by running code
    public void Set1138_4A4A_Word16(ushort value) {
        SetUint16(0x4A4A, value);
    }

    // Getters and Setters for address 0x1138:0x4A4C/0x15DCC.
    // Was accessed via the following registers: SS
    public int Get1138_4A4C_Word16() {
        return GetUint16(0x4A4C);
    }

    // Operation not registered by running code
    public void Set1138_4A4C_Word16(ushort value) {
        SetUint16(0x4A4C, value);
    }

    // Getters and Setters for address 0x1138:0x4A4E/0x15DCE.
    // Operation not registered by running code
    public int Get1138_4A4E_Word16() {
        return GetUint16(0x4A4E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A4E_Word16(ushort value) {
        SetUint16(0x4A4E, value);
    }

    // Getters and Setters for address 0x1138:0x4A50/0x15DD0.
    // Was accessed via the following registers: SS
    public int Get1138_4A50_Word16() {
        return GetUint16(0x4A50);
    }

    // Operation not registered by running code
    public void Set1138_4A50_Word16(ushort value) {
        SetUint16(0x4A50, value);
    }

    // Getters and Setters for address 0x1138:0x4A52/0x15DD2.
    // Was accessed via the following registers: SS
    public int Get1138_4A52_Word16() {
        return GetUint16(0x4A52);
    }

    // Operation not registered by running code
    public void Set1138_4A52_Word16(ushort value) {
        SetUint16(0x4A52, value);
    }

    // Getters and Setters for address 0x1138:0x4A54/0x15DD4.
    // Was accessed via the following registers: SS
    public int Get1138_4A54_Word16() {
        return GetUint16(0x4A54);
    }

    // Operation not registered by running code
    public void Set1138_4A54_Word16(ushort value) {
        SetUint16(0x4A54, value);
    }

    // Getters and Setters for address 0x1138:0x4A56/0x15DD6.
    // Operation not registered by running code
    public int Get1138_4A56_Word16() {
        return GetUint16(0x4A56);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A56_Word16(ushort value) {
        SetUint16(0x4A56, value);
    }

    // Getters and Setters for address 0x1138:0x4A58/0x15DD8.
    // Was accessed via the following registers: SS
    public int Get1138_4A58_Word16() {
        return GetUint16(0x4A58);
    }

    // Operation not registered by running code
    public void Set1138_4A58_Word16(ushort value) {
        SetUint16(0x4A58, value);
    }

    // Getters and Setters for address 0x1138:0x4A5A/0x15DDA.
    // Was accessed via the following registers: SS
    public int Get1138_4A5A_Word16() {
        return GetUint16(0x4A5A);
    }

    // Operation not registered by running code
    public void Set1138_4A5A_Word16(ushort value) {
        SetUint16(0x4A5A, value);
    }

    // Getters and Setters for address 0x1138:0x4A5C/0x15DDC.
    // Was accessed via the following registers: SS
    public int Get1138_4A5C_Word16() {
        return GetUint16(0x4A5C);
    }

    // Operation not registered by running code
    public void Set1138_4A5C_Word16(ushort value) {
        SetUint16(0x4A5C, value);
    }

    // Getters and Setters for address 0x1138:0x4A5E/0x15DDE.
    // Operation not registered by running code
    public int Get1138_4A5E_Word16() {
        return GetUint16(0x4A5E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A5E_Word16(ushort value) {
        SetUint16(0x4A5E, value);
    }

    // Getters and Setters for address 0x1138:0x4A60/0x15DE0.
    // Was accessed via the following registers: SS
    public int Get1138_4A60_Word16() {
        return GetUint16(0x4A60);
    }

    // Operation not registered by running code
    public void Set1138_4A60_Word16(ushort value) {
        SetUint16(0x4A60, value);
    }

    // Getters and Setters for address 0x1138:0x4A62/0x15DE2.
    // Was accessed via the following registers: SS
    public int Get1138_4A62_Word16() {
        return GetUint16(0x4A62);
    }

    // Operation not registered by running code
    public void Set1138_4A62_Word16(ushort value) {
        SetUint16(0x4A62, value);
    }

    // Getters and Setters for address 0x1138:0x4A64/0x15DE4.
    // Was accessed via the following registers: SS
    public int Get1138_4A64_Word16() {
        return GetUint16(0x4A64);
    }

    // Operation not registered by running code
    public void Set1138_4A64_Word16(ushort value) {
        SetUint16(0x4A64, value);
    }

    // Getters and Setters for address 0x1138:0x4A66/0x15DE6.
    // Operation not registered by running code
    public int Get1138_4A66_Word16() {
        return GetUint16(0x4A66);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A66_Word16(ushort value) {
        SetUint16(0x4A66, value);
    }

    // Getters and Setters for address 0x1138:0x4A68/0x15DE8.
    // Was accessed via the following registers: SS
    public int Get1138_4A68_Word16() {
        return GetUint16(0x4A68);
    }

    // Operation not registered by running code
    public void Set1138_4A68_Word16(ushort value) {
        SetUint16(0x4A68, value);
    }

    // Getters and Setters for address 0x1138:0x4A6A/0x15DEA.
    // Was accessed via the following registers: SS
    public int Get1138_4A6A_Word16() {
        return GetUint16(0x4A6A);
    }

    // Operation not registered by running code
    public void Set1138_4A6A_Word16(ushort value) {
        SetUint16(0x4A6A, value);
    }

    // Getters and Setters for address 0x1138:0x4A6C/0x15DEC.
    // Was accessed via the following registers: SS
    public int Get1138_4A6C_Word16() {
        return GetUint16(0x4A6C);
    }

    // Operation not registered by running code
    public void Set1138_4A6C_Word16(ushort value) {
        SetUint16(0x4A6C, value);
    }

    // Getters and Setters for address 0x1138:0x4A6E/0x15DEE.
    // Operation not registered by running code
    public int Get1138_4A6E_Word16() {
        return GetUint16(0x4A6E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A6E_Word16(ushort value) {
        SetUint16(0x4A6E, value);
    }

    // Getters and Setters for address 0x1138:0x4A70/0x15DF0.
    // Was accessed via the following registers: SS
    public int Get1138_4A70_Word16() {
        return GetUint16(0x4A70);
    }

    // Operation not registered by running code
    public void Set1138_4A70_Word16(ushort value) {
        SetUint16(0x4A70, value);
    }

    // Getters and Setters for address 0x1138:0x4A72/0x15DF2.
    // Was accessed via the following registers: SS
    public int Get1138_4A72_Word16() {
        return GetUint16(0x4A72);
    }

    // Operation not registered by running code
    public void Set1138_4A72_Word16(ushort value) {
        SetUint16(0x4A72, value);
    }

    // Getters and Setters for address 0x1138:0x4A74/0x15DF4.
    // Was accessed via the following registers: SS
    public int Get1138_4A74_Word16() {
        return GetUint16(0x4A74);
    }

    // Operation not registered by running code
    public void Set1138_4A74_Word16(ushort value) {
        SetUint16(0x4A74, value);
    }

    // Getters and Setters for address 0x1138:0x4A76/0x15DF6.
    // Operation not registered by running code
    public int Get1138_4A76_Word16() {
        return GetUint16(0x4A76);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A76_Word16(ushort value) {
        SetUint16(0x4A76, value);
    }

    // Getters and Setters for address 0x1138:0x4A78/0x15DF8.
    // Was accessed via the following registers: SS
    public int Get1138_4A78_Word16() {
        return GetUint16(0x4A78);
    }

    // Operation not registered by running code
    public void Set1138_4A78_Word16(ushort value) {
        SetUint16(0x4A78, value);
    }

    // Getters and Setters for address 0x1138:0x4A7A/0x15DFA.
    // Was accessed via the following registers: SS
    public int Get1138_4A7A_Word16() {
        return GetUint16(0x4A7A);
    }

    // Operation not registered by running code
    public void Set1138_4A7A_Word16(ushort value) {
        SetUint16(0x4A7A, value);
    }

    // Getters and Setters for address 0x1138:0x4A7C/0x15DFC.
    // Was accessed via the following registers: SS
    public int Get1138_4A7C_Word16() {
        return GetUint16(0x4A7C);
    }

    // Operation not registered by running code
    public void Set1138_4A7C_Word16(ushort value) {
        SetUint16(0x4A7C, value);
    }

    // Getters and Setters for address 0x1138:0x4A7E/0x15DFE.
    // Operation not registered by running code
    public int Get1138_4A7E_Word16() {
        return GetUint16(0x4A7E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A7E_Word16(ushort value) {
        SetUint16(0x4A7E, value);
    }

    // Getters and Setters for address 0x1138:0x4A80/0x15E00.
    // Was accessed via the following registers: SS
    public int Get1138_4A80_Word16() {
        return GetUint16(0x4A80);
    }

    // Operation not registered by running code
    public void Set1138_4A80_Word16(ushort value) {
        SetUint16(0x4A80, value);
    }

    // Getters and Setters for address 0x1138:0x4A82/0x15E02.
    // Was accessed via the following registers: SS
    public int Get1138_4A82_Word16() {
        return GetUint16(0x4A82);
    }

    // Operation not registered by running code
    public void Set1138_4A82_Word16(ushort value) {
        SetUint16(0x4A82, value);
    }

    // Getters and Setters for address 0x1138:0x4A84/0x15E04.
    // Was accessed via the following registers: SS
    public int Get1138_4A84_Word16() {
        return GetUint16(0x4A84);
    }

    // Operation not registered by running code
    public void Set1138_4A84_Word16(ushort value) {
        SetUint16(0x4A84, value);
    }

    // Getters and Setters for address 0x1138:0x4A86/0x15E06.
    // Operation not registered by running code
    public int Get1138_4A86_Word16() {
        return GetUint16(0x4A86);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A86_Word16(ushort value) {
        SetUint16(0x4A86, value);
    }

    // Getters and Setters for address 0x1138:0x4A88/0x15E08.
    // Was accessed via the following registers: SS
    public int Get1138_4A88_Word16() {
        return GetUint16(0x4A88);
    }

    // Operation not registered by running code
    public void Set1138_4A88_Word16(ushort value) {
        SetUint16(0x4A88, value);
    }

    // Getters and Setters for address 0x1138:0x4A8A/0x15E0A.
    // Was accessed via the following registers: SS
    public int Get1138_4A8A_Word16() {
        return GetUint16(0x4A8A);
    }

    // Operation not registered by running code
    public void Set1138_4A8A_Word16(ushort value) {
        SetUint16(0x4A8A, value);
    }

    // Getters and Setters for address 0x1138:0x4A8C/0x15E0C.
    // Was accessed via the following registers: SS
    public int Get1138_4A8C_Word16() {
        return GetUint16(0x4A8C);
    }

    // Operation not registered by running code
    public void Set1138_4A8C_Word16(ushort value) {
        SetUint16(0x4A8C, value);
    }

    // Getters and Setters for address 0x1138:0x4A8E/0x15E0E.
    // Operation not registered by running code
    public int Get1138_4A8E_Word16() {
        return GetUint16(0x4A8E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A8E_Word16(ushort value) {
        SetUint16(0x4A8E, value);
    }

    // Getters and Setters for address 0x1138:0x4A90/0x15E10.
    // Was accessed via the following registers: SS
    public int Get1138_4A90_Word16() {
        return GetUint16(0x4A90);
    }

    // Operation not registered by running code
    public void Set1138_4A90_Word16(ushort value) {
        SetUint16(0x4A90, value);
    }

    // Getters and Setters for address 0x1138:0x4A92/0x15E12.
    // Was accessed via the following registers: SS
    public int Get1138_4A92_Word16() {
        return GetUint16(0x4A92);
    }

    // Operation not registered by running code
    public void Set1138_4A92_Word16(ushort value) {
        SetUint16(0x4A92, value);
    }

    // Getters and Setters for address 0x1138:0x4A94/0x15E14.
    // Was accessed via the following registers: SS
    public int Get1138_4A94_Word16() {
        return GetUint16(0x4A94);
    }

    // Operation not registered by running code
    public void Set1138_4A94_Word16(ushort value) {
        SetUint16(0x4A94, value);
    }

    // Getters and Setters for address 0x1138:0x4A96/0x15E16.
    // Operation not registered by running code
    public int Get1138_4A96_Word16() {
        return GetUint16(0x4A96);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A96_Word16(ushort value) {
        SetUint16(0x4A96, value);
    }

    // Getters and Setters for address 0x1138:0x4A98/0x15E18.
    // Was accessed via the following registers: SS
    public int Get1138_4A98_Word16() {
        return GetUint16(0x4A98);
    }

    // Operation not registered by running code
    public void Set1138_4A98_Word16(ushort value) {
        SetUint16(0x4A98, value);
    }

    // Getters and Setters for address 0x1138:0x4A9A/0x15E1A.
    // Was accessed via the following registers: SS
    public int Get1138_4A9A_Word16() {
        return GetUint16(0x4A9A);
    }

    // Operation not registered by running code
    public void Set1138_4A9A_Word16(ushort value) {
        SetUint16(0x4A9A, value);
    }

    // Getters and Setters for address 0x1138:0x4A9C/0x15E1C.
    // Was accessed via the following registers: SS
    public int Get1138_4A9C_Word16() {
        return GetUint16(0x4A9C);
    }

    // Operation not registered by running code
    public void Set1138_4A9C_Word16(ushort value) {
        SetUint16(0x4A9C, value);
    }

    // Getters and Setters for address 0x1138:0x4A9E/0x15E1E.
    // Operation not registered by running code
    public int Get1138_4A9E_Word16() {
        return GetUint16(0x4A9E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4A9E_Word16(ushort value) {
        SetUint16(0x4A9E, value);
    }

    // Getters and Setters for address 0x1138:0x4AA0/0x15E20.
    // Was accessed via the following registers: SS
    public int Get1138_4AA0_Word16() {
        return GetUint16(0x4AA0);
    }

    // Operation not registered by running code
    public void Set1138_4AA0_Word16(ushort value) {
        SetUint16(0x4AA0, value);
    }

    // Getters and Setters for address 0x1138:0x4AA2/0x15E22.
    // Was accessed via the following registers: SS
    public int Get1138_4AA2_Word16() {
        return GetUint16(0x4AA2);
    }

    // Operation not registered by running code
    public void Set1138_4AA2_Word16(ushort value) {
        SetUint16(0x4AA2, value);
    }

    // Getters and Setters for address 0x1138:0x4AA4/0x15E24.
    // Was accessed via the following registers: SS
    public int Get1138_4AA4_Word16() {
        return GetUint16(0x4AA4);
    }

    // Operation not registered by running code
    public void Set1138_4AA4_Word16(ushort value) {
        SetUint16(0x4AA4, value);
    }

    // Getters and Setters for address 0x1138:0x4AA6/0x15E26.
    // Operation not registered by running code
    public int Get1138_4AA6_Word16() {
        return GetUint16(0x4AA6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AA6_Word16(ushort value) {
        SetUint16(0x4AA6, value);
    }

    // Getters and Setters for address 0x1138:0x4AA8/0x15E28.
    // Was accessed via the following registers: SS
    public int Get1138_4AA8_Word16() {
        return GetUint16(0x4AA8);
    }

    // Operation not registered by running code
    public void Set1138_4AA8_Word16(ushort value) {
        SetUint16(0x4AA8, value);
    }

    // Getters and Setters for address 0x1138:0x4AAA/0x15E2A.
    // Was accessed via the following registers: SS
    public int Get1138_4AAA_Word16() {
        return GetUint16(0x4AAA);
    }

    // Operation not registered by running code
    public void Set1138_4AAA_Word16(ushort value) {
        SetUint16(0x4AAA, value);
    }

    // Getters and Setters for address 0x1138:0x4AAC/0x15E2C.
    // Was accessed via the following registers: SS
    public int Get1138_4AAC_Word16() {
        return GetUint16(0x4AAC);
    }

    // Operation not registered by running code
    public void Set1138_4AAC_Word16(ushort value) {
        SetUint16(0x4AAC, value);
    }

    // Getters and Setters for address 0x1138:0x4AAE/0x15E2E.
    // Operation not registered by running code
    public int Get1138_4AAE_Word16() {
        return GetUint16(0x4AAE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AAE_Word16(ushort value) {
        SetUint16(0x4AAE, value);
    }

    // Getters and Setters for address 0x1138:0x4AB0/0x15E30.
    // Was accessed via the following registers: SS
    public int Get1138_4AB0_Word16() {
        return GetUint16(0x4AB0);
    }

    // Operation not registered by running code
    public void Set1138_4AB0_Word16(ushort value) {
        SetUint16(0x4AB0, value);
    }

    // Getters and Setters for address 0x1138:0x4AB2/0x15E32.
    // Was accessed via the following registers: SS
    public int Get1138_4AB2_Word16() {
        return GetUint16(0x4AB2);
    }

    // Operation not registered by running code
    public void Set1138_4AB2_Word16(ushort value) {
        SetUint16(0x4AB2, value);
    }

    // Getters and Setters for address 0x1138:0x4AB4/0x15E34.
    // Was accessed via the following registers: SS
    public int Get1138_4AB4_Word16() {
        return GetUint16(0x4AB4);
    }

    // Operation not registered by running code
    public void Set1138_4AB4_Word16(ushort value) {
        SetUint16(0x4AB4, value);
    }

    // Getters and Setters for address 0x1138:0x4AB6/0x15E36.
    // Operation not registered by running code
    public int Get1138_4AB6_Word16() {
        return GetUint16(0x4AB6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AB6_Word16(ushort value) {
        SetUint16(0x4AB6, value);
    }

    // Getters and Setters for address 0x1138:0x4AB8/0x15E38.
    // Was accessed via the following registers: SS
    public int Get1138_4AB8_Word16() {
        return GetUint16(0x4AB8);
    }

    // Operation not registered by running code
    public void Set1138_4AB8_Word16(ushort value) {
        SetUint16(0x4AB8, value);
    }

    // Getters and Setters for address 0x1138:0x4ABA/0x15E3A.
    // Was accessed via the following registers: SS
    public int Get1138_4ABA_Word16() {
        return GetUint16(0x4ABA);
    }

    // Operation not registered by running code
    public void Set1138_4ABA_Word16(ushort value) {
        SetUint16(0x4ABA, value);
    }

    // Getters and Setters for address 0x1138:0x4ABC/0x15E3C.
    // Was accessed via the following registers: SS
    public int Get1138_4ABC_Word16() {
        return GetUint16(0x4ABC);
    }

    // Operation not registered by running code
    public void Set1138_4ABC_Word16(ushort value) {
        SetUint16(0x4ABC, value);
    }

    // Getters and Setters for address 0x1138:0x4ABE/0x15E3E.
    // Operation not registered by running code
    public int Get1138_4ABE_Word16() {
        return GetUint16(0x4ABE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ABE_Word16(ushort value) {
        SetUint16(0x4ABE, value);
    }

    // Getters and Setters for address 0x1138:0x4AC0/0x15E40.
    // Was accessed via the following registers: SS
    public int Get1138_4AC0_Word16() {
        return GetUint16(0x4AC0);
    }

    // Operation not registered by running code
    public void Set1138_4AC0_Word16(ushort value) {
        SetUint16(0x4AC0, value);
    }

    // Getters and Setters for address 0x1138:0x4AC2/0x15E42.
    // Was accessed via the following registers: SS
    public int Get1138_4AC2_Word16() {
        return GetUint16(0x4AC2);
    }

    // Operation not registered by running code
    public void Set1138_4AC2_Word16(ushort value) {
        SetUint16(0x4AC2, value);
    }

    // Getters and Setters for address 0x1138:0x4AC4/0x15E44.
    // Was accessed via the following registers: SS
    public int Get1138_4AC4_Word16() {
        return GetUint16(0x4AC4);
    }

    // Operation not registered by running code
    public void Set1138_4AC4_Word16(ushort value) {
        SetUint16(0x4AC4, value);
    }

    // Getters and Setters for address 0x1138:0x4AC6/0x15E46.
    // Operation not registered by running code
    public int Get1138_4AC6_Word16() {
        return GetUint16(0x4AC6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AC6_Word16(ushort value) {
        SetUint16(0x4AC6, value);
    }

    // Getters and Setters for address 0x1138:0x4AC8/0x15E48.
    // Was accessed via the following registers: SS
    public int Get1138_4AC8_Word16() {
        return GetUint16(0x4AC8);
    }

    // Operation not registered by running code
    public void Set1138_4AC8_Word16(ushort value) {
        SetUint16(0x4AC8, value);
    }

    // Getters and Setters for address 0x1138:0x4ACA/0x15E4A.
    // Was accessed via the following registers: SS
    public int Get1138_4ACA_Word16() {
        return GetUint16(0x4ACA);
    }

    // Operation not registered by running code
    public void Set1138_4ACA_Word16(ushort value) {
        SetUint16(0x4ACA, value);
    }

    // Getters and Setters for address 0x1138:0x4ACC/0x15E4C.
    // Was accessed via the following registers: SS
    public int Get1138_4ACC_Word16() {
        return GetUint16(0x4ACC);
    }

    // Operation not registered by running code
    public void Set1138_4ACC_Word16(ushort value) {
        SetUint16(0x4ACC, value);
    }

    // Getters and Setters for address 0x1138:0x4ACE/0x15E4E.
    // Operation not registered by running code
    public int Get1138_4ACE_Word16() {
        return GetUint16(0x4ACE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ACE_Word16(ushort value) {
        SetUint16(0x4ACE, value);
    }

    // Getters and Setters for address 0x1138:0x4AD0/0x15E50.
    // Was accessed via the following registers: SS
    public int Get1138_4AD0_Word16() {
        return GetUint16(0x4AD0);
    }

    // Operation not registered by running code
    public void Set1138_4AD0_Word16(ushort value) {
        SetUint16(0x4AD0, value);
    }

    // Getters and Setters for address 0x1138:0x4AD2/0x15E52.
    // Was accessed via the following registers: SS
    public int Get1138_4AD2_Word16() {
        return GetUint16(0x4AD2);
    }

    // Operation not registered by running code
    public void Set1138_4AD2_Word16(ushort value) {
        SetUint16(0x4AD2, value);
    }

    // Getters and Setters for address 0x1138:0x4AD4/0x15E54.
    // Was accessed via the following registers: SS
    public int Get1138_4AD4_Word16() {
        return GetUint16(0x4AD4);
    }

    // Operation not registered by running code
    public void Set1138_4AD4_Word16(ushort value) {
        SetUint16(0x4AD4, value);
    }

    // Getters and Setters for address 0x1138:0x4AD6/0x15E56.
    // Operation not registered by running code
    public int Get1138_4AD6_Word16() {
        return GetUint16(0x4AD6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AD6_Word16(ushort value) {
        SetUint16(0x4AD6, value);
    }

    // Getters and Setters for address 0x1138:0x4AD8/0x15E58.
    // Was accessed via the following registers: SS
    public int Get1138_4AD8_Word16() {
        return GetUint16(0x4AD8);
    }

    // Operation not registered by running code
    public void Set1138_4AD8_Word16(ushort value) {
        SetUint16(0x4AD8, value);
    }

    // Getters and Setters for address 0x1138:0x4ADA/0x15E5A.
    // Was accessed via the following registers: SS
    public int Get1138_4ADA_Word16() {
        return GetUint16(0x4ADA);
    }

    // Operation not registered by running code
    public void Set1138_4ADA_Word16(ushort value) {
        SetUint16(0x4ADA, value);
    }

    // Getters and Setters for address 0x1138:0x4ADC/0x15E5C.
    // Was accessed via the following registers: SS
    public int Get1138_4ADC_Word16() {
        return GetUint16(0x4ADC);
    }

    // Operation not registered by running code
    public void Set1138_4ADC_Word16(ushort value) {
        SetUint16(0x4ADC, value);
    }

    // Getters and Setters for address 0x1138:0x4ADE/0x15E5E.
    // Operation not registered by running code
    public int Get1138_4ADE_Word16() {
        return GetUint16(0x4ADE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ADE_Word16(ushort value) {
        SetUint16(0x4ADE, value);
    }

    // Getters and Setters for address 0x1138:0x4AE0/0x15E60.
    // Was accessed via the following registers: SS
    public int Get1138_4AE0_Word16() {
        return GetUint16(0x4AE0);
    }

    // Operation not registered by running code
    public void Set1138_4AE0_Word16(ushort value) {
        SetUint16(0x4AE0, value);
    }

    // Getters and Setters for address 0x1138:0x4AE2/0x15E62.
    // Was accessed via the following registers: SS
    public int Get1138_4AE2_Word16() {
        return GetUint16(0x4AE2);
    }

    // Operation not registered by running code
    public void Set1138_4AE2_Word16(ushort value) {
        SetUint16(0x4AE2, value);
    }

    // Getters and Setters for address 0x1138:0x4AE4/0x15E64.
    // Was accessed via the following registers: SS
    public int Get1138_4AE4_Word16() {
        return GetUint16(0x4AE4);
    }

    // Operation not registered by running code
    public void Set1138_4AE4_Word16(ushort value) {
        SetUint16(0x4AE4, value);
    }

    // Getters and Setters for address 0x1138:0x4AE6/0x15E66.
    // Operation not registered by running code
    public int Get1138_4AE6_Word16() {
        return GetUint16(0x4AE6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AE6_Word16(ushort value) {
        SetUint16(0x4AE6, value);
    }

    // Getters and Setters for address 0x1138:0x4AE8/0x15E68.
    // Was accessed via the following registers: SS
    public int Get1138_4AE8_Word16() {
        return GetUint16(0x4AE8);
    }

    // Operation not registered by running code
    public void Set1138_4AE8_Word16(ushort value) {
        SetUint16(0x4AE8, value);
    }

    // Getters and Setters for address 0x1138:0x4AEA/0x15E6A.
    // Was accessed via the following registers: SS
    public int Get1138_4AEA_Word16() {
        return GetUint16(0x4AEA);
    }

    // Operation not registered by running code
    public void Set1138_4AEA_Word16(ushort value) {
        SetUint16(0x4AEA, value);
    }

    // Getters and Setters for address 0x1138:0x4AEC/0x15E6C.
    // Was accessed via the following registers: SS
    public int Get1138_4AEC_Word16() {
        return GetUint16(0x4AEC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AEC_Word16(ushort value) {
        SetUint16(0x4AEC, value);
    }

    // Getters and Setters for address 0x1138:0x4AEE/0x15E6E.
    // Operation not registered by running code
    public int Get1138_4AEE_Word16() {
        return GetUint16(0x4AEE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AEE_Word16(ushort value) {
        SetUint16(0x4AEE, value);
    }

    // Getters and Setters for address 0x1138:0x4AF0/0x15E70.
    // Was accessed via the following registers: SS
    public int Get1138_4AF0_Word16() {
        return GetUint16(0x4AF0);
    }

    // Operation not registered by running code
    public void Set1138_4AF0_Word16(ushort value) {
        SetUint16(0x4AF0, value);
    }

    // Getters and Setters for address 0x1138:0x4AF2/0x15E72.
    // Was accessed via the following registers: SS
    public int Get1138_4AF2_Word16() {
        return GetUint16(0x4AF2);
    }

    // Operation not registered by running code
    public void Set1138_4AF2_Word16(ushort value) {
        SetUint16(0x4AF2, value);
    }

    // Getters and Setters for address 0x1138:0x4AF4/0x15E74.
    // Was accessed via the following registers: SS
    public int Get1138_4AF4_Word16() {
        return GetUint16(0x4AF4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AF4_Word16(ushort value) {
        SetUint16(0x4AF4, value);
    }

    // Getters and Setters for address 0x1138:0x4AF6/0x15E76.
    // Operation not registered by running code
    public int Get1138_4AF6_Word16() {
        return GetUint16(0x4AF6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AF6_Word16(ushort value) {
        SetUint16(0x4AF6, value);
    }

    // Getters and Setters for address 0x1138:0x4AF8/0x15E78.
    // Was accessed via the following registers: SS
    public int Get1138_4AF8_Word16() {
        return GetUint16(0x4AF8);
    }

    // Operation not registered by running code
    public void Set1138_4AF8_Word16(ushort value) {
        SetUint16(0x4AF8, value);
    }

    // Getters and Setters for address 0x1138:0x4AFA/0x15E7A.
    // Was accessed via the following registers: SS
    public int Get1138_4AFA_Word16() {
        return GetUint16(0x4AFA);
    }

    // Operation not registered by running code
    public void Set1138_4AFA_Word16(ushort value) {
        SetUint16(0x4AFA, value);
    }

    // Getters and Setters for address 0x1138:0x4AFC/0x15E7C.
    // Was accessed via the following registers: SS
    public int Get1138_4AFC_Word16() {
        return GetUint16(0x4AFC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AFC_Word16(ushort value) {
        SetUint16(0x4AFC, value);
    }

    // Getters and Setters for address 0x1138:0x4AFE/0x15E7E.
    // Operation not registered by running code
    public int Get1138_4AFE_Word16() {
        return GetUint16(0x4AFE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4AFE_Word16(ushort value) {
        SetUint16(0x4AFE, value);
    }

    // Getters and Setters for address 0x1138:0x4B00/0x15E80.
    // Was accessed via the following registers: SS
    public int Get1138_4B00_Word16() {
        return GetUint16(0x4B00);
    }

    // Operation not registered by running code
    public void Set1138_4B00_Word16(ushort value) {
        SetUint16(0x4B00, value);
    }

    // Getters and Setters for address 0x1138:0x4B02/0x15E82.
    // Was accessed via the following registers: SS
    public int Get1138_4B02_Word16() {
        return GetUint16(0x4B02);
    }

    // Operation not registered by running code
    public void Set1138_4B02_Word16(ushort value) {
        SetUint16(0x4B02, value);
    }

    // Getters and Setters for address 0x1138:0x4B04/0x15E84.
    // Was accessed via the following registers: SS
    public int Get1138_4B04_Word16() {
        return GetUint16(0x4B04);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B04_Word16(ushort value) {
        SetUint16(0x4B04, value);
    }

    // Getters and Setters for address 0x1138:0x4B06/0x15E86.
    // Operation not registered by running code
    public int Get1138_4B06_Word16() {
        return GetUint16(0x4B06);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B06_Word16(ushort value) {
        SetUint16(0x4B06, value);
    }

    // Getters and Setters for address 0x1138:0x4B08/0x15E88.
    // Was accessed via the following registers: SS
    public int Get1138_4B08_Word16() {
        return GetUint16(0x4B08);
    }

    // Operation not registered by running code
    public void Set1138_4B08_Word16(ushort value) {
        SetUint16(0x4B08, value);
    }

    // Getters and Setters for address 0x1138:0x4B0A/0x15E8A.
    // Was accessed via the following registers: SS
    public int Get1138_4B0A_Word16() {
        return GetUint16(0x4B0A);
    }

    // Operation not registered by running code
    public void Set1138_4B0A_Word16(ushort value) {
        SetUint16(0x4B0A, value);
    }

    // Getters and Setters for address 0x1138:0x4B0C/0x15E8C.
    // Was accessed via the following registers: SS
    public int Get1138_4B0C_Word16() {
        return GetUint16(0x4B0C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B0C_Word16(ushort value) {
        SetUint16(0x4B0C, value);
    }

    // Getters and Setters for address 0x1138:0x4B0E/0x15E8E.
    // Operation not registered by running code
    public int Get1138_4B0E_Word16() {
        return GetUint16(0x4B0E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B0E_Word16(ushort value) {
        SetUint16(0x4B0E, value);
    }

    // Getters and Setters for address 0x1138:0x4B10/0x15E90.
    // Was accessed via the following registers: SS
    public int Get1138_4B10_Word16() {
        return GetUint16(0x4B10);
    }

    // Operation not registered by running code
    public void Set1138_4B10_Word16(ushort value) {
        SetUint16(0x4B10, value);
    }

    // Getters and Setters for address 0x1138:0x4B12/0x15E92.
    // Was accessed via the following registers: SS
    public int Get1138_4B12_Word16() {
        return GetUint16(0x4B12);
    }

    // Operation not registered by running code
    public void Set1138_4B12_Word16(ushort value) {
        SetUint16(0x4B12, value);
    }

    // Getters and Setters for address 0x1138:0x4B14/0x15E94.
    // Was accessed via the following registers: SS
    public int Get1138_4B14_Word16() {
        return GetUint16(0x4B14);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B14_Word16(ushort value) {
        SetUint16(0x4B14, value);
    }

    // Getters and Setters for address 0x1138:0x4B16/0x15E96.
    // Operation not registered by running code
    public int Get1138_4B16_Word16() {
        return GetUint16(0x4B16);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B16_Word16(ushort value) {
        SetUint16(0x4B16, value);
    }

    // Getters and Setters for address 0x1138:0x4B18/0x15E98.
    // Was accessed via the following registers: SS
    public int Get1138_4B18_Word16() {
        return GetUint16(0x4B18);
    }

    // Operation not registered by running code
    public void Set1138_4B18_Word16(ushort value) {
        SetUint16(0x4B18, value);
    }

    // Getters and Setters for address 0x1138:0x4B1A/0x15E9A.
    // Was accessed via the following registers: SS
    public int Get1138_4B1A_Word16() {
        return GetUint16(0x4B1A);
    }

    // Operation not registered by running code
    public void Set1138_4B1A_Word16(ushort value) {
        SetUint16(0x4B1A, value);
    }

    // Getters and Setters for address 0x1138:0x4B1C/0x15E9C.
    // Was accessed via the following registers: SS
    public int Get1138_4B1C_Word16() {
        return GetUint16(0x4B1C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B1C_Word16(ushort value) {
        SetUint16(0x4B1C, value);
    }

    // Getters and Setters for address 0x1138:0x4B1E/0x15E9E.
    // Operation not registered by running code
    public int Get1138_4B1E_Word16() {
        return GetUint16(0x4B1E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B1E_Word16(ushort value) {
        SetUint16(0x4B1E, value);
    }

    // Getters and Setters for address 0x1138:0x4B20/0x15EA0.
    // Was accessed via the following registers: SS
    public int Get1138_4B20_Word16() {
        return GetUint16(0x4B20);
    }

    // Operation not registered by running code
    public void Set1138_4B20_Word16(ushort value) {
        SetUint16(0x4B20, value);
    }

    // Getters and Setters for address 0x1138:0x4B22/0x15EA2.
    // Was accessed via the following registers: SS
    public int Get1138_4B22_Word16() {
        return GetUint16(0x4B22);
    }

    // Operation not registered by running code
    public void Set1138_4B22_Word16(ushort value) {
        SetUint16(0x4B22, value);
    }

    // Getters and Setters for address 0x1138:0x4B24/0x15EA4.
    // Was accessed via the following registers: SS
    public int Get1138_4B24_Word16() {
        return GetUint16(0x4B24);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B24_Word16(ushort value) {
        SetUint16(0x4B24, value);
    }

    // Getters and Setters for address 0x1138:0x4B26/0x15EA6.
    // Operation not registered by running code
    public int Get1138_4B26_Word16() {
        return GetUint16(0x4B26);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B26_Word16(ushort value) {
        SetUint16(0x4B26, value);
    }

    // Getters and Setters for address 0x1138:0x4B28/0x15EA8.
    // Was accessed via the following registers: SS
    public int Get1138_4B28_Word16() {
        return GetUint16(0x4B28);
    }

    // Operation not registered by running code
    public void Set1138_4B28_Word16(ushort value) {
        SetUint16(0x4B28, value);
    }

    // Getters and Setters for address 0x1138:0x4B2A/0x15EAA.
    // Was accessed via the following registers: SS
    public int Get1138_4B2A_Word16() {
        return GetUint16(0x4B2A);
    }

    // Operation not registered by running code
    public void Set1138_4B2A_Word16(ushort value) {
        SetUint16(0x4B2A, value);
    }

    // Getters and Setters for address 0x1138:0x4B2C/0x15EAC.
    // Was accessed via the following registers: SS
    public int Get1138_4B2C_Word16() {
        return GetUint16(0x4B2C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B2C_Word16(ushort value) {
        SetUint16(0x4B2C, value);
    }

    // Getters and Setters for address 0x1138:0x4B2E/0x15EAE.
    // Operation not registered by running code
    public int Get1138_4B2E_Word16() {
        return GetUint16(0x4B2E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B2E_Word16(ushort value) {
        SetUint16(0x4B2E, value);
    }

    // Getters and Setters for address 0x1138:0x4B30/0x15EB0.
    // Was accessed via the following registers: SS
    public int Get1138_4B30_Word16() {
        return GetUint16(0x4B30);
    }

    // Operation not registered by running code
    public void Set1138_4B30_Word16(ushort value) {
        SetUint16(0x4B30, value);
    }

    // Getters and Setters for address 0x1138:0x4B32/0x15EB2.
    // Was accessed via the following registers: SS
    public int Get1138_4B32_Word16() {
        return GetUint16(0x4B32);
    }

    // Operation not registered by running code
    public void Set1138_4B32_Word16(ushort value) {
        SetUint16(0x4B32, value);
    }

    // Getters and Setters for address 0x1138:0x4B34/0x15EB4.
    // Was accessed via the following registers: SS
    public int Get1138_4B34_Word16() {
        return GetUint16(0x4B34);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B34_Word16(ushort value) {
        SetUint16(0x4B34, value);
    }

    // Getters and Setters for address 0x1138:0x4B36/0x15EB6.
    // Operation not registered by running code
    public int Get1138_4B36_Word16() {
        return GetUint16(0x4B36);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B36_Word16(ushort value) {
        SetUint16(0x4B36, value);
    }

    // Getters and Setters for address 0x1138:0x4B38/0x15EB8.
    // Was accessed via the following registers: SS
    public int Get1138_4B38_Word16() {
        return GetUint16(0x4B38);
    }

    // Operation not registered by running code
    public void Set1138_4B38_Word16(ushort value) {
        SetUint16(0x4B38, value);
    }

    // Getters and Setters for address 0x1138:0x4B3A/0x15EBA.
    // Was accessed via the following registers: SS
    public int Get1138_4B3A_Word16() {
        return GetUint16(0x4B3A);
    }

    // Operation not registered by running code
    public void Set1138_4B3A_Word16(ushort value) {
        SetUint16(0x4B3A, value);
    }

    // Getters and Setters for address 0x1138:0x4B3C/0x15EBC.
    // Was accessed via the following registers: SS
    public int Get1138_4B3C_Word16() {
        return GetUint16(0x4B3C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B3C_Word16(ushort value) {
        SetUint16(0x4B3C, value);
    }

    // Getters and Setters for address 0x1138:0x4B3E/0x15EBE.
    // Operation not registered by running code
    public int Get1138_4B3E_Word16() {
        return GetUint16(0x4B3E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B3E_Word16(ushort value) {
        SetUint16(0x4B3E, value);
    }

    // Getters and Setters for address 0x1138:0x4B40/0x15EC0.
    // Was accessed via the following registers: SS
    public int Get1138_4B40_Word16() {
        return GetUint16(0x4B40);
    }

    // Operation not registered by running code
    public void Set1138_4B40_Word16(ushort value) {
        SetUint16(0x4B40, value);
    }

    // Getters and Setters for address 0x1138:0x4B42/0x15EC2.
    // Was accessed via the following registers: SS
    public int Get1138_4B42_Word16() {
        return GetUint16(0x4B42);
    }

    // Operation not registered by running code
    public void Set1138_4B42_Word16(ushort value) {
        SetUint16(0x4B42, value);
    }

    // Getters and Setters for address 0x1138:0x4B44/0x15EC4.
    // Was accessed via the following registers: SS
    public int Get1138_4B44_Word16() {
        return GetUint16(0x4B44);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B44_Word16(ushort value) {
        SetUint16(0x4B44, value);
    }

    // Getters and Setters for address 0x1138:0x4B46/0x15EC6.
    // Operation not registered by running code
    public int Get1138_4B46_Word16() {
        return GetUint16(0x4B46);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B46_Word16(ushort value) {
        SetUint16(0x4B46, value);
    }

    // Getters and Setters for address 0x1138:0x4B48/0x15EC8.
    // Was accessed via the following registers: SS
    public int Get1138_4B48_Word16() {
        return GetUint16(0x4B48);
    }

    // Operation not registered by running code
    public void Set1138_4B48_Word16(ushort value) {
        SetUint16(0x4B48, value);
    }

    // Getters and Setters for address 0x1138:0x4B4A/0x15ECA.
    // Was accessed via the following registers: SS
    public int Get1138_4B4A_Word16() {
        return GetUint16(0x4B4A);
    }

    // Operation not registered by running code
    public void Set1138_4B4A_Word16(ushort value) {
        SetUint16(0x4B4A, value);
    }

    // Getters and Setters for address 0x1138:0x4B4C/0x15ECC.
    // Was accessed via the following registers: SS
    public int Get1138_4B4C_Word16() {
        return GetUint16(0x4B4C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B4C_Word16(ushort value) {
        SetUint16(0x4B4C, value);
    }

    // Getters and Setters for address 0x1138:0x4B4E/0x15ECE.
    // Operation not registered by running code
    public int Get1138_4B4E_Word16() {
        return GetUint16(0x4B4E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B4E_Word16(ushort value) {
        SetUint16(0x4B4E, value);
    }

    // Getters and Setters for address 0x1138:0x4B50/0x15ED0.
    // Was accessed via the following registers: SS
    public int Get1138_4B50_Word16() {
        return GetUint16(0x4B50);
    }

    // Operation not registered by running code
    public void Set1138_4B50_Word16(ushort value) {
        SetUint16(0x4B50, value);
    }

    // Getters and Setters for address 0x1138:0x4B52/0x15ED2.
    // Was accessed via the following registers: SS
    public int Get1138_4B52_Word16() {
        return GetUint16(0x4B52);
    }

    // Operation not registered by running code
    public void Set1138_4B52_Word16(ushort value) {
        SetUint16(0x4B52, value);
    }

    // Getters and Setters for address 0x1138:0x4B54/0x15ED4.
    // Was accessed via the following registers: SS
    public int Get1138_4B54_Word16() {
        return GetUint16(0x4B54);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B54_Word16(ushort value) {
        SetUint16(0x4B54, value);
    }

    // Getters and Setters for address 0x1138:0x4B56/0x15ED6.
    // Operation not registered by running code
    public int Get1138_4B56_Word16() {
        return GetUint16(0x4B56);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B56_Word16(ushort value) {
        SetUint16(0x4B56, value);
    }

    // Getters and Setters for address 0x1138:0x4B58/0x15ED8.
    // Was accessed via the following registers: SS
    public int Get1138_4B58_Word16() {
        return GetUint16(0x4B58);
    }

    // Operation not registered by running code
    public void Set1138_4B58_Word16(ushort value) {
        SetUint16(0x4B58, value);
    }

    // Getters and Setters for address 0x1138:0x4B5A/0x15EDA.
    // Was accessed via the following registers: SS
    public int Get1138_4B5A_Word16() {
        return GetUint16(0x4B5A);
    }

    // Operation not registered by running code
    public void Set1138_4B5A_Word16(ushort value) {
        SetUint16(0x4B5A, value);
    }

    // Getters and Setters for address 0x1138:0x4B5C/0x15EDC.
    // Was accessed via the following registers: SS
    public int Get1138_4B5C_Word16() {
        return GetUint16(0x4B5C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B5C_Word16(ushort value) {
        SetUint16(0x4B5C, value);
    }

    // Getters and Setters for address 0x1138:0x4B5E/0x15EDE.
    // Operation not registered by running code
    public int Get1138_4B5E_Word16() {
        return GetUint16(0x4B5E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B5E_Word16(ushort value) {
        SetUint16(0x4B5E, value);
    }

    // Getters and Setters for address 0x1138:0x4B60/0x15EE0.
    // Was accessed via the following registers: SS
    public int Get1138_4B60_Word16() {
        return GetUint16(0x4B60);
    }

    // Operation not registered by running code
    public void Set1138_4B60_Word16(ushort value) {
        SetUint16(0x4B60, value);
    }

    // Getters and Setters for address 0x1138:0x4B62/0x15EE2.
    // Was accessed via the following registers: SS
    public int Get1138_4B62_Word16() {
        return GetUint16(0x4B62);
    }

    // Operation not registered by running code
    public void Set1138_4B62_Word16(ushort value) {
        SetUint16(0x4B62, value);
    }

    // Getters and Setters for address 0x1138:0x4B64/0x15EE4.
    // Was accessed via the following registers: SS
    public int Get1138_4B64_Word16() {
        return GetUint16(0x4B64);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B64_Word16(ushort value) {
        SetUint16(0x4B64, value);
    }

    // Getters and Setters for address 0x1138:0x4B66/0x15EE6.
    // Operation not registered by running code
    public int Get1138_4B66_Word16() {
        return GetUint16(0x4B66);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B66_Word16(ushort value) {
        SetUint16(0x4B66, value);
    }

    // Getters and Setters for address 0x1138:0x4B68/0x15EE8.
    // Was accessed via the following registers: SS
    public int Get1138_4B68_Word16() {
        return GetUint16(0x4B68);
    }

    // Operation not registered by running code
    public void Set1138_4B68_Word16(ushort value) {
        SetUint16(0x4B68, value);
    }

    // Getters and Setters for address 0x1138:0x4B6A/0x15EEA.
    // Was accessed via the following registers: SS
    public int Get1138_4B6A_Word16() {
        return GetUint16(0x4B6A);
    }

    // Operation not registered by running code
    public void Set1138_4B6A_Word16(ushort value) {
        SetUint16(0x4B6A, value);
    }

    // Getters and Setters for address 0x1138:0x4B6C/0x15EEC.
    // Was accessed via the following registers: SS
    public int Get1138_4B6C_Word16() {
        return GetUint16(0x4B6C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B6C_Word16(ushort value) {
        SetUint16(0x4B6C, value);
    }

    // Getters and Setters for address 0x1138:0x4B6E/0x15EEE.
    // Operation not registered by running code
    public int Get1138_4B6E_Word16() {
        return GetUint16(0x4B6E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B6E_Word16(ushort value) {
        SetUint16(0x4B6E, value);
    }

    // Getters and Setters for address 0x1138:0x4B70/0x15EF0.
    // Was accessed via the following registers: SS
    public int Get1138_4B70_Word16() {
        return GetUint16(0x4B70);
    }

    // Operation not registered by running code
    public void Set1138_4B70_Word16(ushort value) {
        SetUint16(0x4B70, value);
    }

    // Getters and Setters for address 0x1138:0x4B72/0x15EF2.
    // Was accessed via the following registers: SS
    public int Get1138_4B72_Word16() {
        return GetUint16(0x4B72);
    }

    // Operation not registered by running code
    public void Set1138_4B72_Word16(ushort value) {
        SetUint16(0x4B72, value);
    }

    // Getters and Setters for address 0x1138:0x4B74/0x15EF4.
    // Was accessed via the following registers: SS
    public int Get1138_4B74_Word16() {
        return GetUint16(0x4B74);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B74_Word16(ushort value) {
        SetUint16(0x4B74, value);
    }

    // Getters and Setters for address 0x1138:0x4B76/0x15EF6.
    // Operation not registered by running code
    public int Get1138_4B76_Word16() {
        return GetUint16(0x4B76);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B76_Word16(ushort value) {
        SetUint16(0x4B76, value);
    }

    // Getters and Setters for address 0x1138:0x4B78/0x15EF8.
    // Was accessed via the following registers: SS
    public int Get1138_4B78_Word16() {
        return GetUint16(0x4B78);
    }

    // Operation not registered by running code
    public void Set1138_4B78_Word16(ushort value) {
        SetUint16(0x4B78, value);
    }

    // Getters and Setters for address 0x1138:0x4B7A/0x15EFA.
    // Was accessed via the following registers: SS
    public int Get1138_4B7A_Word16() {
        return GetUint16(0x4B7A);
    }

    // Operation not registered by running code
    public void Set1138_4B7A_Word16(ushort value) {
        SetUint16(0x4B7A, value);
    }

    // Getters and Setters for address 0x1138:0x4B7C/0x15EFC.
    // Was accessed via the following registers: SS
    public int Get1138_4B7C_Word16() {
        return GetUint16(0x4B7C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B7C_Word16(ushort value) {
        SetUint16(0x4B7C, value);
    }

    // Getters and Setters for address 0x1138:0x4B7E/0x15EFE.
    // Operation not registered by running code
    public int Get1138_4B7E_Word16() {
        return GetUint16(0x4B7E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B7E_Word16(ushort value) {
        SetUint16(0x4B7E, value);
    }

    // Getters and Setters for address 0x1138:0x4B80/0x15F00.
    // Was accessed via the following registers: SS
    public int Get1138_4B80_Word16() {
        return GetUint16(0x4B80);
    }

    // Operation not registered by running code
    public void Set1138_4B80_Word16(ushort value) {
        SetUint16(0x4B80, value);
    }

    // Getters and Setters for address 0x1138:0x4B82/0x15F02.
    // Was accessed via the following registers: SS
    public int Get1138_4B82_Word16() {
        return GetUint16(0x4B82);
    }

    // Operation not registered by running code
    public void Set1138_4B82_Word16(ushort value) {
        SetUint16(0x4B82, value);
    }

    // Getters and Setters for address 0x1138:0x4B84/0x15F04.
    // Was accessed via the following registers: SS
    public int Get1138_4B84_Word16() {
        return GetUint16(0x4B84);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B84_Word16(ushort value) {
        SetUint16(0x4B84, value);
    }

    // Getters and Setters for address 0x1138:0x4B86/0x15F06.
    // Operation not registered by running code
    public int Get1138_4B86_Word16() {
        return GetUint16(0x4B86);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B86_Word16(ushort value) {
        SetUint16(0x4B86, value);
    }

    // Getters and Setters for address 0x1138:0x4B88/0x15F08.
    // Was accessed via the following registers: SS
    public int Get1138_4B88_Word16() {
        return GetUint16(0x4B88);
    }

    // Operation not registered by running code
    public void Set1138_4B88_Word16(ushort value) {
        SetUint16(0x4B88, value);
    }

    // Getters and Setters for address 0x1138:0x4B8A/0x15F0A.
    // Was accessed via the following registers: SS
    public int Get1138_4B8A_Word16() {
        return GetUint16(0x4B8A);
    }

    // Operation not registered by running code
    public void Set1138_4B8A_Word16(ushort value) {
        SetUint16(0x4B8A, value);
    }

    // Getters and Setters for address 0x1138:0x4B8C/0x15F0C.
    // Was accessed via the following registers: SS
    public int Get1138_4B8C_Word16() {
        return GetUint16(0x4B8C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B8C_Word16(ushort value) {
        SetUint16(0x4B8C, value);
    }

    // Getters and Setters for address 0x1138:0x4B8E/0x15F0E.
    // Operation not registered by running code
    public int Get1138_4B8E_Word16() {
        return GetUint16(0x4B8E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B8E_Word16(ushort value) {
        SetUint16(0x4B8E, value);
    }

    // Getters and Setters for address 0x1138:0x4B90/0x15F10.
    // Was accessed via the following registers: SS
    public int Get1138_4B90_Word16() {
        return GetUint16(0x4B90);
    }

    // Operation not registered by running code
    public void Set1138_4B90_Word16(ushort value) {
        SetUint16(0x4B90, value);
    }

    // Getters and Setters for address 0x1138:0x4B92/0x15F12.
    // Was accessed via the following registers: SS
    public int Get1138_4B92_Word16() {
        return GetUint16(0x4B92);
    }

    // Operation not registered by running code
    public void Set1138_4B92_Word16(ushort value) {
        SetUint16(0x4B92, value);
    }

    // Getters and Setters for address 0x1138:0x4B94/0x15F14.
    // Was accessed via the following registers: SS
    public int Get1138_4B94_Word16() {
        return GetUint16(0x4B94);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B94_Word16(ushort value) {
        SetUint16(0x4B94, value);
    }

    // Getters and Setters for address 0x1138:0x4B96/0x15F16.
    // Operation not registered by running code
    public int Get1138_4B96_Word16() {
        return GetUint16(0x4B96);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B96_Word16(ushort value) {
        SetUint16(0x4B96, value);
    }

    // Getters and Setters for address 0x1138:0x4B98/0x15F18.
    // Was accessed via the following registers: SS
    public int Get1138_4B98_Word16() {
        return GetUint16(0x4B98);
    }

    // Operation not registered by running code
    public void Set1138_4B98_Word16(ushort value) {
        SetUint16(0x4B98, value);
    }

    // Getters and Setters for address 0x1138:0x4B9A/0x15F1A.
    // Was accessed via the following registers: SS
    public int Get1138_4B9A_Word16() {
        return GetUint16(0x4B9A);
    }

    // Operation not registered by running code
    public void Set1138_4B9A_Word16(ushort value) {
        SetUint16(0x4B9A, value);
    }

    // Getters and Setters for address 0x1138:0x4B9C/0x15F1C.
    // Was accessed via the following registers: SS
    public int Get1138_4B9C_Word16() {
        return GetUint16(0x4B9C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B9C_Word16(ushort value) {
        SetUint16(0x4B9C, value);
    }

    // Getters and Setters for address 0x1138:0x4B9E/0x15F1E.
    // Operation not registered by running code
    public int Get1138_4B9E_Word16() {
        return GetUint16(0x4B9E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4B9E_Word16(ushort value) {
        SetUint16(0x4B9E, value);
    }

    // Getters and Setters for address 0x1138:0x4BA0/0x15F20.
    // Was accessed via the following registers: SS
    public int Get1138_4BA0_Word16() {
        return GetUint16(0x4BA0);
    }

    // Operation not registered by running code
    public void Set1138_4BA0_Word16(ushort value) {
        SetUint16(0x4BA0, value);
    }

    // Getters and Setters for address 0x1138:0x4BA2/0x15F22.
    // Was accessed via the following registers: SS
    public int Get1138_4BA2_Word16() {
        return GetUint16(0x4BA2);
    }

    // Operation not registered by running code
    public void Set1138_4BA2_Word16(ushort value) {
        SetUint16(0x4BA2, value);
    }

    // Getters and Setters for address 0x1138:0x4BA4/0x15F24.
    // Was accessed via the following registers: SS
    public int Get1138_4BA4_Word16() {
        return GetUint16(0x4BA4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BA4_Word16(ushort value) {
        SetUint16(0x4BA4, value);
    }

    // Getters and Setters for address 0x1138:0x4BA6/0x15F26.
    // Operation not registered by running code
    public int Get1138_4BA6_Word16() {
        return GetUint16(0x4BA6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BA6_Word16(ushort value) {
        SetUint16(0x4BA6, value);
    }

    // Getters and Setters for address 0x1138:0x4BA8/0x15F28.
    // Was accessed via the following registers: SS
    public int Get1138_4BA8_Word16() {
        return GetUint16(0x4BA8);
    }

    // Operation not registered by running code
    public void Set1138_4BA8_Word16(ushort value) {
        SetUint16(0x4BA8, value);
    }

    // Getters and Setters for address 0x1138:0x4BAA/0x15F2A.
    // Was accessed via the following registers: SS
    public int Get1138_4BAA_Word16() {
        return GetUint16(0x4BAA);
    }

    // Operation not registered by running code
    public void Set1138_4BAA_Word16(ushort value) {
        SetUint16(0x4BAA, value);
    }

    // Getters and Setters for address 0x1138:0x4BAC/0x15F2C.
    // Was accessed via the following registers: SS
    public int Get1138_4BAC_Word16() {
        return GetUint16(0x4BAC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BAC_Word16(ushort value) {
        SetUint16(0x4BAC, value);
    }

    // Getters and Setters for address 0x1138:0x4BAE/0x15F2E.
    // Operation not registered by running code
    public int Get1138_4BAE_Word16() {
        return GetUint16(0x4BAE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BAE_Word16(ushort value) {
        SetUint16(0x4BAE, value);
    }

    // Getters and Setters for address 0x1138:0x4BB0/0x15F30.
    // Was accessed via the following registers: SS
    public int Get1138_4BB0_Word16() {
        return GetUint16(0x4BB0);
    }

    // Operation not registered by running code
    public void Set1138_4BB0_Word16(ushort value) {
        SetUint16(0x4BB0, value);
    }

    // Getters and Setters for address 0x1138:0x4BB2/0x15F32.
    // Was accessed via the following registers: SS
    public int Get1138_4BB2_Word16() {
        return GetUint16(0x4BB2);
    }

    // Operation not registered by running code
    public void Set1138_4BB2_Word16(ushort value) {
        SetUint16(0x4BB2, value);
    }

    // Getters and Setters for address 0x1138:0x4BB4/0x15F34.
    // Was accessed via the following registers: SS
    public int Get1138_4BB4_Word16() {
        return GetUint16(0x4BB4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BB4_Word16(ushort value) {
        SetUint16(0x4BB4, value);
    }

    // Getters and Setters for address 0x1138:0x4BB6/0x15F36.
    // Operation not registered by running code
    public int Get1138_4BB6_Word16() {
        return GetUint16(0x4BB6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BB6_Word16(ushort value) {
        SetUint16(0x4BB6, value);
    }

    // Getters and Setters for address 0x1138:0x4BB8/0x15F38.
    // Was accessed via the following registers: SS
    public int Get1138_4BB8_Word16() {
        return GetUint16(0x4BB8);
    }

    // Operation not registered by running code
    public void Set1138_4BB8_Word16(ushort value) {
        SetUint16(0x4BB8, value);
    }

    // Getters and Setters for address 0x1138:0x4BBA/0x15F3A.
    // Was accessed via the following registers: SS
    public int Get1138_4BBA_Word16() {
        return GetUint16(0x4BBA);
    }

    // Operation not registered by running code
    public void Set1138_4BBA_Word16(ushort value) {
        SetUint16(0x4BBA, value);
    }

    // Getters and Setters for address 0x1138:0x4BBC/0x15F3C.
    // Was accessed via the following registers: SS
    public int Get1138_4BBC_Word16() {
        return GetUint16(0x4BBC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BBC_Word16(ushort value) {
        SetUint16(0x4BBC, value);
    }

    // Getters and Setters for address 0x1138:0x4BBE/0x15F3E.
    // Operation not registered by running code
    public int Get1138_4BBE_Word16() {
        return GetUint16(0x4BBE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BBE_Word16(ushort value) {
        SetUint16(0x4BBE, value);
    }

    // Getters and Setters for address 0x1138:0x4BC0/0x15F40.
    // Was accessed via the following registers: SS
    public int Get1138_4BC0_Word16() {
        return GetUint16(0x4BC0);
    }

    // Operation not registered by running code
    public void Set1138_4BC0_Word16(ushort value) {
        SetUint16(0x4BC0, value);
    }

    // Getters and Setters for address 0x1138:0x4BC2/0x15F42.
    // Was accessed via the following registers: SS
    public int Get1138_4BC2_Word16() {
        return GetUint16(0x4BC2);
    }

    // Operation not registered by running code
    public void Set1138_4BC2_Word16(ushort value) {
        SetUint16(0x4BC2, value);
    }

    // Getters and Setters for address 0x1138:0x4BC4/0x15F44.
    // Was accessed via the following registers: SS
    public int Get1138_4BC4_Word16() {
        return GetUint16(0x4BC4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BC4_Word16(ushort value) {
        SetUint16(0x4BC4, value);
    }

    // Getters and Setters for address 0x1138:0x4BC6/0x15F46.
    // Operation not registered by running code
    public int Get1138_4BC6_Word16() {
        return GetUint16(0x4BC6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BC6_Word16(ushort value) {
        SetUint16(0x4BC6, value);
    }

    // Getters and Setters for address 0x1138:0x4BC8/0x15F48.
    // Was accessed via the following registers: SS
    public int Get1138_4BC8_Word16() {
        return GetUint16(0x4BC8);
    }

    // Operation not registered by running code
    public void Set1138_4BC8_Word16(ushort value) {
        SetUint16(0x4BC8, value);
    }

    // Getters and Setters for address 0x1138:0x4BCA/0x15F4A.
    // Was accessed via the following registers: SS
    public int Get1138_4BCA_Word16() {
        return GetUint16(0x4BCA);
    }

    // Operation not registered by running code
    public void Set1138_4BCA_Word16(ushort value) {
        SetUint16(0x4BCA, value);
    }

    // Getters and Setters for address 0x1138:0x4BCC/0x15F4C.
    // Was accessed via the following registers: SS
    public int Get1138_4BCC_Word16() {
        return GetUint16(0x4BCC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BCC_Word16(ushort value) {
        SetUint16(0x4BCC, value);
    }

    // Getters and Setters for address 0x1138:0x4BCE/0x15F4E.
    // Operation not registered by running code
    public int Get1138_4BCE_Word16() {
        return GetUint16(0x4BCE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BCE_Word16(ushort value) {
        SetUint16(0x4BCE, value);
    }

    // Getters and Setters for address 0x1138:0x4BD0/0x15F50.
    // Was accessed via the following registers: SS
    public int Get1138_4BD0_Word16() {
        return GetUint16(0x4BD0);
    }

    // Operation not registered by running code
    public void Set1138_4BD0_Word16(ushort value) {
        SetUint16(0x4BD0, value);
    }

    // Getters and Setters for address 0x1138:0x4BD2/0x15F52.
    // Was accessed via the following registers: SS
    public int Get1138_4BD2_Word16() {
        return GetUint16(0x4BD2);
    }

    // Operation not registered by running code
    public void Set1138_4BD2_Word16(ushort value) {
        SetUint16(0x4BD2, value);
    }

    // Getters and Setters for address 0x1138:0x4BD4/0x15F54.
    // Was accessed via the following registers: SS
    public int Get1138_4BD4_Word16() {
        return GetUint16(0x4BD4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BD4_Word16(ushort value) {
        SetUint16(0x4BD4, value);
    }

    // Getters and Setters for address 0x1138:0x4BD6/0x15F56.
    // Operation not registered by running code
    public int Get1138_4BD6_Word16() {
        return GetUint16(0x4BD6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BD6_Word16(ushort value) {
        SetUint16(0x4BD6, value);
    }

    // Getters and Setters for address 0x1138:0x4BD8/0x15F58.
    // Was accessed via the following registers: SS
    public int Get1138_4BD8_Word16() {
        return GetUint16(0x4BD8);
    }

    // Operation not registered by running code
    public void Set1138_4BD8_Word16(ushort value) {
        SetUint16(0x4BD8, value);
    }

    // Getters and Setters for address 0x1138:0x4BDA/0x15F5A.
    // Was accessed via the following registers: SS
    public int Get1138_4BDA_Word16() {
        return GetUint16(0x4BDA);
    }

    // Operation not registered by running code
    public void Set1138_4BDA_Word16(ushort value) {
        SetUint16(0x4BDA, value);
    }

    // Getters and Setters for address 0x1138:0x4BDC/0x15F5C.
    // Was accessed via the following registers: SS
    public int Get1138_4BDC_Word16() {
        return GetUint16(0x4BDC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BDC_Word16(ushort value) {
        SetUint16(0x4BDC, value);
    }

    // Getters and Setters for address 0x1138:0x4BDE/0x15F5E.
    // Operation not registered by running code
    public int Get1138_4BDE_Word16() {
        return GetUint16(0x4BDE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BDE_Word16(ushort value) {
        SetUint16(0x4BDE, value);
    }

    // Getters and Setters for address 0x1138:0x4BE0/0x15F60.
    // Was accessed via the following registers: SS
    public int Get1138_4BE0_Word16() {
        return GetUint16(0x4BE0);
    }

    // Operation not registered by running code
    public void Set1138_4BE0_Word16(ushort value) {
        SetUint16(0x4BE0, value);
    }

    // Getters and Setters for address 0x1138:0x4BE2/0x15F62.
    // Was accessed via the following registers: SS
    public int Get1138_4BE2_Word16() {
        return GetUint16(0x4BE2);
    }

    // Operation not registered by running code
    public void Set1138_4BE2_Word16(ushort value) {
        SetUint16(0x4BE2, value);
    }

    // Getters and Setters for address 0x1138:0x4BE4/0x15F64.
    // Was accessed via the following registers: SS
    public int Get1138_4BE4_Word16() {
        return GetUint16(0x4BE4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BE4_Word16(ushort value) {
        SetUint16(0x4BE4, value);
    }

    // Getters and Setters for address 0x1138:0x4BE6/0x15F66.
    // Operation not registered by running code
    public int Get1138_4BE6_Word16() {
        return GetUint16(0x4BE6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BE6_Word16(ushort value) {
        SetUint16(0x4BE6, value);
    }

    // Getters and Setters for address 0x1138:0x4BE8/0x15F68.
    // Was accessed via the following registers: SS
    public int Get1138_4BE8_Word16() {
        return GetUint16(0x4BE8);
    }

    // Operation not registered by running code
    public void Set1138_4BE8_Word16(ushort value) {
        SetUint16(0x4BE8, value);
    }

    // Getters and Setters for address 0x1138:0x4BEA/0x15F6A.
    // Was accessed via the following registers: SS
    public int Get1138_4BEA_Word16() {
        return GetUint16(0x4BEA);
    }

    // Operation not registered by running code
    public void Set1138_4BEA_Word16(ushort value) {
        SetUint16(0x4BEA, value);
    }

    // Getters and Setters for address 0x1138:0x4BEC/0x15F6C.
    // Was accessed via the following registers: SS
    public int Get1138_4BEC_Word16() {
        return GetUint16(0x4BEC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BEC_Word16(ushort value) {
        SetUint16(0x4BEC, value);
    }

    // Getters and Setters for address 0x1138:0x4BEE/0x15F6E.
    // Operation not registered by running code
    public int Get1138_4BEE_Word16() {
        return GetUint16(0x4BEE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BEE_Word16(ushort value) {
        SetUint16(0x4BEE, value);
    }

    // Getters and Setters for address 0x1138:0x4BF0/0x15F70.
    // Was accessed via the following registers: SS
    public int Get1138_4BF0_Word16() {
        return GetUint16(0x4BF0);
    }

    // Operation not registered by running code
    public void Set1138_4BF0_Word16(ushort value) {
        SetUint16(0x4BF0, value);
    }

    // Getters and Setters for address 0x1138:0x4BF2/0x15F72.
    // Was accessed via the following registers: SS
    public int Get1138_4BF2_Word16() {
        return GetUint16(0x4BF2);
    }

    // Operation not registered by running code
    public void Set1138_4BF2_Word16(ushort value) {
        SetUint16(0x4BF2, value);
    }

    // Getters and Setters for address 0x1138:0x4BF4/0x15F74.
    // Was accessed via the following registers: SS
    public int Get1138_4BF4_Word16() {
        return GetUint16(0x4BF4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BF4_Word16(ushort value) {
        SetUint16(0x4BF4, value);
    }

    // Getters and Setters for address 0x1138:0x4BF6/0x15F76.
    // Operation not registered by running code
    public int Get1138_4BF6_Word16() {
        return GetUint16(0x4BF6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BF6_Word16(ushort value) {
        SetUint16(0x4BF6, value);
    }

    // Getters and Setters for address 0x1138:0x4BF8/0x15F78.
    // Was accessed via the following registers: SS
    public int Get1138_4BF8_Word16() {
        return GetUint16(0x4BF8);
    }

    // Operation not registered by running code
    public void Set1138_4BF8_Word16(ushort value) {
        SetUint16(0x4BF8, value);
    }

    // Getters and Setters for address 0x1138:0x4BFA/0x15F7A.
    // Was accessed via the following registers: SS
    public int Get1138_4BFA_Word16() {
        return GetUint16(0x4BFA);
    }

    // Operation not registered by running code
    public void Set1138_4BFA_Word16(ushort value) {
        SetUint16(0x4BFA, value);
    }

    // Getters and Setters for address 0x1138:0x4BFC/0x15F7C.
    // Was accessed via the following registers: SS
    public int Get1138_4BFC_Word16() {
        return GetUint16(0x4BFC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BFC_Word16(ushort value) {
        SetUint16(0x4BFC, value);
    }

    // Getters and Setters for address 0x1138:0x4BFE/0x15F7E.
    // Operation not registered by running code
    public int Get1138_4BFE_Word16() {
        return GetUint16(0x4BFE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4BFE_Word16(ushort value) {
        SetUint16(0x4BFE, value);
    }

    // Getters and Setters for address 0x1138:0x4C00/0x15F80.
    // Was accessed via the following registers: SS
    public int Get1138_4C00_Word16() {
        return GetUint16(0x4C00);
    }

    // Operation not registered by running code
    public void Set1138_4C00_Word16(ushort value) {
        SetUint16(0x4C00, value);
    }

    // Getters and Setters for address 0x1138:0x4C02/0x15F82.
    // Was accessed via the following registers: SS
    public int Get1138_4C02_Word16() {
        return GetUint16(0x4C02);
    }

    // Operation not registered by running code
    public void Set1138_4C02_Word16(ushort value) {
        SetUint16(0x4C02, value);
    }

    // Getters and Setters for address 0x1138:0x4C04/0x15F84.
    // Was accessed via the following registers: SS
    public int Get1138_4C04_Word16() {
        return GetUint16(0x4C04);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4C04_Word16(ushort value) {
        SetUint16(0x4C04, value);
    }

    // Getters and Setters for address 0x1138:0x4C08/0x15F88.
    // Was accessed via the following registers: SS
    public int Get1138_4C08_Word16() {
        return GetUint16(0x4C08);
    }

    // Operation not registered by running code
    public void Set1138_4C08_Word16(ushort value) {
        SetUint16(0x4C08, value);
    }

    // Getters and Setters for address 0x1138:0x4C0A/0x15F8A.
    // Was accessed via the following registers: SS
    public int Get1138_4C0A_Word16() {
        return GetUint16(0x4C0A);
    }

    // Operation not registered by running code
    public void Set1138_4C0A_Word16(ushort value) {
        SetUint16(0x4C0A, value);
    }

    // Getters and Setters for address 0x1138:0x4C0C/0x15F8C.
    // Was accessed via the following registers: SS
    public int Get1138_4C0C_Word16() {
        return GetUint16(0x4C0C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4C0C_Word16(ushort value) {
        SetUint16(0x4C0C, value);
    }

    // Getters and Setters for address 0x1138:0x4C10/0x15F90.
    // Was accessed via the following registers: SS
    public int Get1138_4C10_Word16() {
        return GetUint16(0x4C10);
    }

    // Operation not registered by running code
    public void Set1138_4C10_Word16(ushort value) {
        SetUint16(0x4C10, value);
    }

    // Getters and Setters for address 0x1138:0x4C12/0x15F92.
    // Was accessed via the following registers: SS
    public int Get1138_4C12_Word16() {
        return GetUint16(0x4C12);
    }

    // Operation not registered by running code
    public void Set1138_4C12_Word16(ushort value) {
        SetUint16(0x4C12, value);
    }

    // Getters and Setters for address 0x1138:0x4C14/0x15F94.
    // Was accessed via the following registers: SS
    public int Get1138_4C14_Word16() {
        return GetUint16(0x4C14);
    }

    // Operation not registered by running code
    public void Set1138_4C14_Word16(ushort value) {
        SetUint16(0x4C14, value);
    }

    // Getters and Setters for address 0x1138:0x4C18/0x15F98.
    // Was accessed via the following registers: SS
    public int Get1138_4C18_Word16() {
        return GetUint16(0x4C18);
    }

    // Operation not registered by running code
    public void Set1138_4C18_Word16(ushort value) {
        SetUint16(0x4C18, value);
    }

    // Getters and Setters for address 0x1138:0x4C1A/0x15F9A.
    // Was accessed via the following registers: SS
    public int Get1138_4C1A_Word16() {
        return GetUint16(0x4C1A);
    }

    // Operation not registered by running code
    public void Set1138_4C1A_Word16(ushort value) {
        SetUint16(0x4C1A, value);
    }

    // Getters and Setters for address 0x1138:0x4C1C/0x15F9C.
    // Was accessed via the following registers: SS
    public int Get1138_4C1C_Word16() {
        return GetUint16(0x4C1C);
    }

    // Operation not registered by running code
    public void Set1138_4C1C_Word16(ushort value) {
        SetUint16(0x4C1C, value);
    }

    // Getters and Setters for address 0x1138:0x4C20/0x15FA0.
    // Was accessed via the following registers: SS
    public int Get1138_4C20_Word16() {
        return GetUint16(0x4C20);
    }

    // Operation not registered by running code
    public void Set1138_4C20_Word16(ushort value) {
        SetUint16(0x4C20, value);
    }

    // Getters and Setters for address 0x1138:0x4C22/0x15FA2.
    // Was accessed via the following registers: SS
    public int Get1138_4C22_Word16() {
        return GetUint16(0x4C22);
    }

    // Operation not registered by running code
    public void Set1138_4C22_Word16(ushort value) {
        SetUint16(0x4C22, value);
    }

    // Getters and Setters for address 0x1138:0x4C24/0x15FA4.
    // Was accessed via the following registers: SS
    public int Get1138_4C24_Word16() {
        return GetUint16(0x4C24);
    }

    // Operation not registered by running code
    public void Set1138_4C24_Word16(ushort value) {
        SetUint16(0x4C24, value);
    }

    // Getters and Setters for address 0x1138:0x4C28/0x15FA8.
    // Was accessed via the following registers: SS
    public int Get1138_4C28_Word16() {
        return GetUint16(0x4C28);
    }

    // Operation not registered by running code
    public void Set1138_4C28_Word16(ushort value) {
        SetUint16(0x4C28, value);
    }

    // Getters and Setters for address 0x1138:0x4C2A/0x15FAA.
    // Was accessed via the following registers: SS
    public int Get1138_4C2A_Word16() {
        return GetUint16(0x4C2A);
    }

    // Operation not registered by running code
    public void Set1138_4C2A_Word16(ushort value) {
        SetUint16(0x4C2A, value);
    }

    // Getters and Setters for address 0x1138:0x4C2C/0x15FAC.
    // Was accessed via the following registers: SS
    public int Get1138_4C2C_Word16() {
        return GetUint16(0x4C2C);
    }

    // Operation not registered by running code
    public void Set1138_4C2C_Word16(ushort value) {
        SetUint16(0x4C2C, value);
    }

    // Getters and Setters for address 0x1138:0x4C30/0x15FB0.
    // Was accessed via the following registers: SS
    public int Get1138_4C30_Word16() {
        return GetUint16(0x4C30);
    }

    // Operation not registered by running code
    public void Set1138_4C30_Word16(ushort value) {
        SetUint16(0x4C30, value);
    }

    // Getters and Setters for address 0x1138:0x4C32/0x15FB2.
    // Was accessed via the following registers: SS
    public int Get1138_4C32_Word16() {
        return GetUint16(0x4C32);
    }

    // Operation not registered by running code
    public void Set1138_4C32_Word16(ushort value) {
        SetUint16(0x4C32, value);
    }

    // Getters and Setters for address 0x1138:0x4C34/0x15FB4.
    // Was accessed via the following registers: SS
    public int Get1138_4C34_Word16() {
        return GetUint16(0x4C34);
    }

    // Operation not registered by running code
    public void Set1138_4C34_Word16(ushort value) {
        SetUint16(0x4C34, value);
    }

    // Getters and Setters for address 0x1138:0x4C38/0x15FB8.
    // Was accessed via the following registers: SS
    public int Get1138_4C38_Word16() {
        return GetUint16(0x4C38);
    }

    // Operation not registered by running code
    public void Set1138_4C38_Word16(ushort value) {
        SetUint16(0x4C38, value);
    }

    // Getters and Setters for address 0x1138:0x4C3A/0x15FBA.
    // Was accessed via the following registers: SS
    public int Get1138_4C3A_Word16() {
        return GetUint16(0x4C3A);
    }

    // Operation not registered by running code
    public void Set1138_4C3A_Word16(ushort value) {
        SetUint16(0x4C3A, value);
    }

    // Getters and Setters for address 0x1138:0x4C3C/0x15FBC.
    // Was accessed via the following registers: SS
    public int Get1138_4C3C_Word16() {
        return GetUint16(0x4C3C);
    }

    // Operation not registered by running code
    public void Set1138_4C3C_Word16(ushort value) {
        SetUint16(0x4C3C, value);
    }

    // Getters and Setters for address 0x1138:0x4C40/0x15FC0.
    // Was accessed via the following registers: SS
    public int Get1138_4C40_Word16() {
        return GetUint16(0x4C40);
    }

    // Operation not registered by running code
    public void Set1138_4C40_Word16(ushort value) {
        SetUint16(0x4C40, value);
    }

    // Getters and Setters for address 0x1138:0x4C42/0x15FC2.
    // Was accessed via the following registers: SS
    public int Get1138_4C42_Word16() {
        return GetUint16(0x4C42);
    }

    // Operation not registered by running code
    public void Set1138_4C42_Word16(ushort value) {
        SetUint16(0x4C42, value);
    }

    // Getters and Setters for address 0x1138:0x4C44/0x15FC4.
    // Was accessed via the following registers: SS
    public int Get1138_4C44_Word16() {
        return GetUint16(0x4C44);
    }

    // Operation not registered by running code
    public void Set1138_4C44_Word16(ushort value) {
        SetUint16(0x4C44, value);
    }

    // Getters and Setters for address 0x1138:0x4C48/0x15FC8.
    // Was accessed via the following registers: SS
    public int Get1138_4C48_Word16() {
        return GetUint16(0x4C48);
    }

    // Operation not registered by running code
    public void Set1138_4C48_Word16(ushort value) {
        SetUint16(0x4C48, value);
    }

    // Getters and Setters for address 0x1138:0x4C4A/0x15FCA.
    // Was accessed via the following registers: SS
    public int Get1138_4C4A_Word16() {
        return GetUint16(0x4C4A);
    }

    // Operation not registered by running code
    public void Set1138_4C4A_Word16(ushort value) {
        SetUint16(0x4C4A, value);
    }

    // Getters and Setters for address 0x1138:0x4C4C/0x15FCC.
    // Was accessed via the following registers: SS
    public int Get1138_4C4C_Word16() {
        return GetUint16(0x4C4C);
    }

    // Operation not registered by running code
    public void Set1138_4C4C_Word16(ushort value) {
        SetUint16(0x4C4C, value);
    }

    // Getters and Setters for address 0x1138:0x4C50/0x15FD0.
    // Was accessed via the following registers: SS
    public int Get1138_4C50_Word16() {
        return GetUint16(0x4C50);
    }

    // Operation not registered by running code
    public void Set1138_4C50_Word16(ushort value) {
        SetUint16(0x4C50, value);
    }

    // Getters and Setters for address 0x1138:0x4C52/0x15FD2.
    // Was accessed via the following registers: SS
    public int Get1138_4C52_Word16() {
        return GetUint16(0x4C52);
    }

    // Operation not registered by running code
    public void Set1138_4C52_Word16(ushort value) {
        SetUint16(0x4C52, value);
    }

    // Getters and Setters for address 0x1138:0x4C54/0x15FD4.
    // Was accessed via the following registers: SS
    public int Get1138_4C54_Word16() {
        return GetUint16(0x4C54);
    }

    // Operation not registered by running code
    public void Set1138_4C54_Word16(ushort value) {
        SetUint16(0x4C54, value);
    }

    // Getters and Setters for address 0x1138:0x4C58/0x15FD8.
    // Was accessed via the following registers: SS
    public int Get1138_4C58_Word16() {
        return GetUint16(0x4C58);
    }

    // Operation not registered by running code
    public void Set1138_4C58_Word16(ushort value) {
        SetUint16(0x4C58, value);
    }

    // Getters and Setters for address 0x1138:0x4C5A/0x15FDA.
    // Was accessed via the following registers: SS
    public int Get1138_4C5A_Word16() {
        return GetUint16(0x4C5A);
    }

    // Operation not registered by running code
    public void Set1138_4C5A_Word16(ushort value) {
        SetUint16(0x4C5A, value);
    }

    // Getters and Setters for address 0x1138:0x4C5C/0x15FDC.
    // Was accessed via the following registers: SS
    public int Get1138_4C5C_Word16() {
        return GetUint16(0x4C5C);
    }

    // Operation not registered by running code
    public void Set1138_4C5C_Word16(ushort value) {
        SetUint16(0x4C5C, value);
    }

    // Getters and Setters for address 0x1138:0x4E7C/0x161FC.
    // Operation not registered by running code
    public byte Get1138_4E7C_Byte8() {
        return GetUint8(0x4E7C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E7C_Byte8(byte value) {
        SetUint8(0x4E7C, value);
    }

    // Getters and Setters for address 0x1138:0x4E7D/0x161FD.
    // Operation not registered by running code
    public int Get1138_4E7D_Byte8() {
        return GetUint8(0x4E7D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E7D_Byte8(byte value) {
        SetUint8(0x4E7D, value);
    }

    // Getters and Setters for address 0x1138:0x4E7E/0x161FE.
    // Operation not registered by running code
    public int Get1138_4E7E_Byte8() {
        return GetUint8(0x4E7E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E7E_Byte8(byte value) {
        SetUint8(0x4E7E, value);
    }

    // Getters and Setters for address 0x1138:0x4E7F/0x161FF.
    // Operation not registered by running code
    public int Get1138_4E7F_Byte8() {
        return GetUint8(0x4E7F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E7F_Byte8(byte value) {
        SetUint8(0x4E7F, value);
    }

    // Getters and Setters for address 0x1138:0x4E80/0x16200.
    // Operation not registered by running code
    public int Get1138_4E80_Byte8() {
        return GetUint8(0x4E80);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E80_Byte8(byte value) {
        SetUint8(0x4E80, value);
    }

    // Getters and Setters for address 0x1138:0x4E81/0x16201.
    // Operation not registered by running code
    public int Get1138_4E81_Byte8() {
        return GetUint8(0x4E81);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E81_Byte8(byte value) {
        SetUint8(0x4E81, value);
    }

    // Getters and Setters for address 0x1138:0x4E82/0x16202.
    // Operation not registered by running code
    public int Get1138_4E82_Byte8() {
        return GetUint8(0x4E82);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E82_Byte8(byte value) {
        SetUint8(0x4E82, value);
    }

    // Getters and Setters for address 0x1138:0x4E83/0x16203.
    // Operation not registered by running code
    public int Get1138_4E83_Byte8() {
        return GetUint8(0x4E83);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E83_Byte8(byte value) {
        SetUint8(0x4E83, value);
    }

    // Getters and Setters for address 0x1138:0x4E84/0x16204.
    // Operation not registered by running code
    public int Get1138_4E84_Byte8() {
        return GetUint8(0x4E84);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E84_Byte8(byte value) {
        SetUint8(0x4E84, value);
    }

    // Getters and Setters for address 0x1138:0x4E85/0x16205.
    // Operation not registered by running code
    public int Get1138_4E85_Byte8() {
        return GetUint8(0x4E85);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E85_Byte8(byte value) {
        SetUint8(0x4E85, value);
    }

    // Getters and Setters for address 0x1138:0x4E86/0x16206.
    // Operation not registered by running code
    public int Get1138_4E86_Byte8() {
        return GetUint8(0x4E86);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E86_Byte8(byte value) {
        SetUint8(0x4E86, value);
    }

    // Getters and Setters for address 0x1138:0x4E87/0x16207.
    // Operation not registered by running code
    public int Get1138_4E87_Byte8() {
        return GetUint8(0x4E87);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E87_Byte8(byte value) {
        SetUint8(0x4E87, value);
    }

    // Getters and Setters for address 0x1138:0x4E88/0x16208.
    // Operation not registered by running code
    public int Get1138_4E88_Byte8() {
        return GetUint8(0x4E88);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E88_Byte8(byte value) {
        SetUint8(0x4E88, value);
    }

    // Getters and Setters for address 0x1138:0x4E89/0x16209.
    // Operation not registered by running code
    public int Get1138_4E89_Byte8() {
        return GetUint8(0x4E89);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E89_Byte8(byte value) {
        SetUint8(0x4E89, value);
    }

    // Getters and Setters for address 0x1138:0x4E8A/0x1620A.
    // Operation not registered by running code
    public int Get1138_4E8A_Byte8() {
        return GetUint8(0x4E8A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E8A_Byte8(byte value) {
        SetUint8(0x4E8A, value);
    }

    // Getters and Setters for address 0x1138:0x4E8B/0x1620B.
    // Operation not registered by running code
    public int Get1138_4E8B_Byte8() {
        return GetUint8(0x4E8B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E8B_Byte8(byte value) {
        SetUint8(0x4E8B, value);
    }

    // Getters and Setters for address 0x1138:0x4E8C/0x1620C.
    // Operation not registered by running code
    public int Get1138_4E8C_Byte8() {
        return GetUint8(0x4E8C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E8C_Byte8(byte value) {
        SetUint8(0x4E8C, value);
    }

    // Getters and Setters for address 0x1138:0x4E8D/0x1620D.
    // Operation not registered by running code
    public int Get1138_4E8D_Byte8() {
        return GetUint8(0x4E8D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E8D_Byte8(byte value) {
        SetUint8(0x4E8D, value);
    }

    // Getters and Setters for address 0x1138:0x4E8E/0x1620E.
    // Operation not registered by running code
    public int Get1138_4E8E_Byte8() {
        return GetUint8(0x4E8E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E8E_Byte8(byte value) {
        SetUint8(0x4E8E, value);
    }

    // Getters and Setters for address 0x1138:0x4E8F/0x1620F.
    // Operation not registered by running code
    public int Get1138_4E8F_Byte8() {
        return GetUint8(0x4E8F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E8F_Byte8(byte value) {
        SetUint8(0x4E8F, value);
    }

    // Getters and Setters for address 0x1138:0x4E90/0x16210.
    // Operation not registered by running code
    public int Get1138_4E90_Byte8() {
        return GetUint8(0x4E90);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E90_Byte8(byte value) {
        SetUint8(0x4E90, value);
    }

    // Getters and Setters for address 0x1138:0x4E91/0x16211.
    // Operation not registered by running code
    public int Get1138_4E91_Byte8() {
        return GetUint8(0x4E91);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E91_Byte8(byte value) {
        SetUint8(0x4E91, value);
    }

    // Getters and Setters for address 0x1138:0x4E92/0x16212.
    // Operation not registered by running code
    public int Get1138_4E92_Byte8() {
        return GetUint8(0x4E92);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E92_Byte8(byte value) {
        SetUint8(0x4E92, value);
    }

    // Getters and Setters for address 0x1138:0x4E93/0x16213.
    // Operation not registered by running code
    public int Get1138_4E93_Byte8() {
        return GetUint8(0x4E93);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E93_Byte8(byte value) {
        SetUint8(0x4E93, value);
    }

    // Getters and Setters for address 0x1138:0x4E94/0x16214.
    // Operation not registered by running code
    public int Get1138_4E94_Byte8() {
        return GetUint8(0x4E94);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E94_Byte8(byte value) {
        SetUint8(0x4E94, value);
    }

    // Getters and Setters for address 0x1138:0x4E95/0x16215.
    // Operation not registered by running code
    public int Get1138_4E95_Byte8() {
        return GetUint8(0x4E95);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E95_Byte8(byte value) {
        SetUint8(0x4E95, value);
    }

    // Getters and Setters for address 0x1138:0x4E96/0x16216.
    // Operation not registered by running code
    public int Get1138_4E96_Byte8() {
        return GetUint8(0x4E96);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E96_Byte8(byte value) {
        SetUint8(0x4E96, value);
    }

    // Getters and Setters for address 0x1138:0x4E97/0x16217.
    // Operation not registered by running code
    public int Get1138_4E97_Byte8() {
        return GetUint8(0x4E97);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E97_Byte8(byte value) {
        SetUint8(0x4E97, value);
    }

    // Getters and Setters for address 0x1138:0x4E98/0x16218.
    // Operation not registered by running code
    public int Get1138_4E98_Byte8() {
        return GetUint8(0x4E98);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E98_Byte8(byte value) {
        SetUint8(0x4E98, value);
    }

    // Getters and Setters for address 0x1138:0x4E99/0x16219.
    // Operation not registered by running code
    public int Get1138_4E99_Byte8() {
        return GetUint8(0x4E99);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E99_Byte8(byte value) {
        SetUint8(0x4E99, value);
    }

    // Getters and Setters for address 0x1138:0x4E9A/0x1621A.
    // Operation not registered by running code
    public int Get1138_4E9A_Byte8() {
        return GetUint8(0x4E9A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E9A_Byte8(byte value) {
        SetUint8(0x4E9A, value);
    }

    // Getters and Setters for address 0x1138:0x4E9B/0x1621B.
    // Operation not registered by running code
    public int Get1138_4E9B_Byte8() {
        return GetUint8(0x4E9B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E9B_Byte8(byte value) {
        SetUint8(0x4E9B, value);
    }

    // Getters and Setters for address 0x1138:0x4E9C/0x1621C.
    // Operation not registered by running code
    public int Get1138_4E9C_Byte8() {
        return GetUint8(0x4E9C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E9C_Byte8(byte value) {
        SetUint8(0x4E9C, value);
    }

    // Getters and Setters for address 0x1138:0x4E9D/0x1621D.
    // Operation not registered by running code
    public int Get1138_4E9D_Byte8() {
        return GetUint8(0x4E9D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E9D_Byte8(byte value) {
        SetUint8(0x4E9D, value);
    }

    // Getters and Setters for address 0x1138:0x4E9E/0x1621E.
    // Operation not registered by running code
    public int Get1138_4E9E_Byte8() {
        return GetUint8(0x4E9E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E9E_Byte8(byte value) {
        SetUint8(0x4E9E, value);
    }

    // Getters and Setters for address 0x1138:0x4E9F/0x1621F.
    // Operation not registered by running code
    public int Get1138_4E9F_Byte8() {
        return GetUint8(0x4E9F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4E9F_Byte8(byte value) {
        SetUint8(0x4E9F, value);
    }

    // Getters and Setters for address 0x1138:0x4EA0/0x16220.
    // Operation not registered by running code
    public int Get1138_4EA0_Byte8() {
        return GetUint8(0x4EA0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EA0_Byte8(byte value) {
        SetUint8(0x4EA0, value);
    }

    // Getters and Setters for address 0x1138:0x4EA1/0x16221.
    // Operation not registered by running code
    public int Get1138_4EA1_Byte8() {
        return GetUint8(0x4EA1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EA1_Byte8(byte value) {
        SetUint8(0x4EA1, value);
    }

    // Getters and Setters for address 0x1138:0x4EA2/0x16222.
    // Operation not registered by running code
    public int Get1138_4EA2_Byte8() {
        return GetUint8(0x4EA2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EA2_Byte8(byte value) {
        SetUint8(0x4EA2, value);
    }

    // Getters and Setters for address 0x1138:0x4EA3/0x16223.
    // Operation not registered by running code
    public int Get1138_4EA3_Byte8() {
        return GetUint8(0x4EA3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EA3_Byte8(byte value) {
        SetUint8(0x4EA3, value);
    }

    // Getters and Setters for address 0x1138:0x4EA4/0x16224.
    // Operation not registered by running code
    public int Get1138_4EA4_Byte8() {
        return GetUint8(0x4EA4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EA4_Byte8(byte value) {
        SetUint8(0x4EA4, value);
    }

    // Getters and Setters for address 0x1138:0x4EA5/0x16225.
    // Operation not registered by running code
    public int Get1138_4EA5_Byte8() {
        return GetUint8(0x4EA5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EA5_Byte8(byte value) {
        SetUint8(0x4EA5, value);
    }

    // Getters and Setters for address 0x1138:0x4EA6/0x16226.
    // Operation not registered by running code
    public int Get1138_4EA6_Byte8() {
        return GetUint8(0x4EA6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EA6_Byte8(byte value) {
        SetUint8(0x4EA6, value);
    }

    // Getters and Setters for address 0x1138:0x4EA7/0x16227.
    // Operation not registered by running code
    public int Get1138_4EA7_Byte8() {
        return GetUint8(0x4EA7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EA7_Byte8(byte value) {
        SetUint8(0x4EA7, value);
    }

    // Getters and Setters for address 0x1138:0x4EA8/0x16228.
    // Operation not registered by running code
    public int Get1138_4EA8_Byte8() {
        return GetUint8(0x4EA8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EA8_Byte8(byte value) {
        SetUint8(0x4EA8, value);
    }

    // Getters and Setters for address 0x1138:0x4EA9/0x16229.
    // Operation not registered by running code
    public int Get1138_4EA9_Byte8() {
        return GetUint8(0x4EA9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EA9_Byte8(byte value) {
        SetUint8(0x4EA9, value);
    }

    // Getters and Setters for address 0x1138:0x4EAA/0x1622A.
    // Operation not registered by running code
    public int Get1138_4EAA_Byte8() {
        return GetUint8(0x4EAA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EAA_Byte8(byte value) {
        SetUint8(0x4EAA, value);
    }

    // Getters and Setters for address 0x1138:0x4EAB/0x1622B.
    // Operation not registered by running code
    public int Get1138_4EAB_Byte8() {
        return GetUint8(0x4EAB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EAB_Byte8(byte value) {
        SetUint8(0x4EAB, value);
    }

    // Getters and Setters for address 0x1138:0x4EAC/0x1622C.
    // Operation not registered by running code
    public int Get1138_4EAC_Byte8() {
        return GetUint8(0x4EAC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EAC_Byte8(byte value) {
        SetUint8(0x4EAC, value);
    }

    // Getters and Setters for address 0x1138:0x4EAD/0x1622D.
    // Operation not registered by running code
    public int Get1138_4EAD_Byte8() {
        return GetUint8(0x4EAD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EAD_Byte8(byte value) {
        SetUint8(0x4EAD, value);
    }

    // Getters and Setters for address 0x1138:0x4EAE/0x1622E.
    // Operation not registered by running code
    public int Get1138_4EAE_Byte8() {
        return GetUint8(0x4EAE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EAE_Byte8(byte value) {
        SetUint8(0x4EAE, value);
    }

    // Getters and Setters for address 0x1138:0x4EAF/0x1622F.
    // Operation not registered by running code
    public int Get1138_4EAF_Byte8() {
        return GetUint8(0x4EAF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EAF_Byte8(byte value) {
        SetUint8(0x4EAF, value);
    }

    // Getters and Setters for address 0x1138:0x4EB0/0x16230.
    // Operation not registered by running code
    public int Get1138_4EB0_Byte8() {
        return GetUint8(0x4EB0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EB0_Byte8(byte value) {
        SetUint8(0x4EB0, value);
    }

    // Getters and Setters for address 0x1138:0x4EB1/0x16231.
    // Operation not registered by running code
    public int Get1138_4EB1_Byte8() {
        return GetUint8(0x4EB1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EB1_Byte8(byte value) {
        SetUint8(0x4EB1, value);
    }

    // Getters and Setters for address 0x1138:0x4EB2/0x16232.
    // Operation not registered by running code
    public int Get1138_4EB2_Byte8() {
        return GetUint8(0x4EB2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EB2_Byte8(byte value) {
        SetUint8(0x4EB2, value);
    }

    // Getters and Setters for address 0x1138:0x4EB3/0x16233.
    // Operation not registered by running code
    public int Get1138_4EB3_Byte8() {
        return GetUint8(0x4EB3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EB3_Byte8(byte value) {
        SetUint8(0x4EB3, value);
    }

    // Getters and Setters for address 0x1138:0x4EB4/0x16234.
    // Operation not registered by running code
    public int Get1138_4EB4_Byte8() {
        return GetUint8(0x4EB4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EB4_Byte8(byte value) {
        SetUint8(0x4EB4, value);
    }

    // Getters and Setters for address 0x1138:0x4EB5/0x16235.
    // Operation not registered by running code
    public int Get1138_4EB5_Byte8() {
        return GetUint8(0x4EB5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EB5_Byte8(byte value) {
        SetUint8(0x4EB5, value);
    }

    // Getters and Setters for address 0x1138:0x4EB6/0x16236.
    // Operation not registered by running code
    public int Get1138_4EB6_Byte8() {
        return GetUint8(0x4EB6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EB6_Byte8(byte value) {
        SetUint8(0x4EB6, value);
    }

    // Getters and Setters for address 0x1138:0x4EB7/0x16237.
    // Operation not registered by running code
    public int Get1138_4EB7_Byte8() {
        return GetUint8(0x4EB7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EB7_Byte8(byte value) {
        SetUint8(0x4EB7, value);
    }

    // Getters and Setters for address 0x1138:0x4EB8/0x16238.
    // Operation not registered by running code
    public int Get1138_4EB8_Byte8() {
        return GetUint8(0x4EB8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EB8_Byte8(byte value) {
        SetUint8(0x4EB8, value);
    }

    // Getters and Setters for address 0x1138:0x4EB9/0x16239.
    // Operation not registered by running code
    public int Get1138_4EB9_Byte8() {
        return GetUint8(0x4EB9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EB9_Byte8(byte value) {
        SetUint8(0x4EB9, value);
    }

    // Getters and Setters for address 0x1138:0x4EBA/0x1623A.
    // Operation not registered by running code
    public int Get1138_4EBA_Byte8() {
        return GetUint8(0x4EBA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EBA_Byte8(byte value) {
        SetUint8(0x4EBA, value);
    }

    // Getters and Setters for address 0x1138:0x4EBB/0x1623B.
    // Operation not registered by running code
    public int Get1138_4EBB_Byte8() {
        return GetUint8(0x4EBB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EBB_Byte8(byte value) {
        SetUint8(0x4EBB, value);
    }

    // Getters and Setters for address 0x1138:0x4EBC/0x1623C.
    // Operation not registered by running code
    public int Get1138_4EBC_Byte8() {
        return GetUint8(0x4EBC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EBC_Byte8(byte value) {
        SetUint8(0x4EBC, value);
    }

    // Getters and Setters for address 0x1138:0x4EBD/0x1623D.
    // Operation not registered by running code
    public int Get1138_4EBD_Byte8() {
        return GetUint8(0x4EBD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EBD_Byte8(byte value) {
        SetUint8(0x4EBD, value);
    }

    // Getters and Setters for address 0x1138:0x4EBE/0x1623E.
    // Operation not registered by running code
    public int Get1138_4EBE_Byte8() {
        return GetUint8(0x4EBE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EBE_Byte8(byte value) {
        SetUint8(0x4EBE, value);
    }

    // Getters and Setters for address 0x1138:0x4EBF/0x1623F.
    // Operation not registered by running code
    public int Get1138_4EBF_Byte8() {
        return GetUint8(0x4EBF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EBF_Byte8(byte value) {
        SetUint8(0x4EBF, value);
    }

    // Getters and Setters for address 0x1138:0x4EC0/0x16240.
    // Operation not registered by running code
    public int Get1138_4EC0_Byte8() {
        return GetUint8(0x4EC0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EC0_Byte8(byte value) {
        SetUint8(0x4EC0, value);
    }

    // Getters and Setters for address 0x1138:0x4EC1/0x16241.
    // Operation not registered by running code
    public int Get1138_4EC1_Byte8() {
        return GetUint8(0x4EC1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EC1_Byte8(byte value) {
        SetUint8(0x4EC1, value);
    }

    // Getters and Setters for address 0x1138:0x4EC2/0x16242.
    // Operation not registered by running code
    public int Get1138_4EC2_Byte8() {
        return GetUint8(0x4EC2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EC2_Byte8(byte value) {
        SetUint8(0x4EC2, value);
    }

    // Getters and Setters for address 0x1138:0x4EC3/0x16243.
    // Operation not registered by running code
    public int Get1138_4EC3_Byte8() {
        return GetUint8(0x4EC3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EC3_Byte8(byte value) {
        SetUint8(0x4EC3, value);
    }

    // Getters and Setters for address 0x1138:0x4EC4/0x16244.
    // Operation not registered by running code
    public int Get1138_4EC4_Byte8() {
        return GetUint8(0x4EC4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EC4_Byte8(byte value) {
        SetUint8(0x4EC4, value);
    }

    // Getters and Setters for address 0x1138:0x4EC5/0x16245.
    // Operation not registered by running code
    public int Get1138_4EC5_Byte8() {
        return GetUint8(0x4EC5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EC5_Byte8(byte value) {
        SetUint8(0x4EC5, value);
    }

    // Getters and Setters for address 0x1138:0x4EC6/0x16246.
    // Operation not registered by running code
    public int Get1138_4EC6_Byte8() {
        return GetUint8(0x4EC6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EC6_Byte8(byte value) {
        SetUint8(0x4EC6, value);
    }

    // Getters and Setters for address 0x1138:0x4EC7/0x16247.
    // Operation not registered by running code
    public int Get1138_4EC7_Byte8() {
        return GetUint8(0x4EC7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EC7_Byte8(byte value) {
        SetUint8(0x4EC7, value);
    }

    // Getters and Setters for address 0x1138:0x4EC8/0x16248.
    // Operation not registered by running code
    public int Get1138_4EC8_Byte8() {
        return GetUint8(0x4EC8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EC8_Byte8(byte value) {
        SetUint8(0x4EC8, value);
    }

    // Getters and Setters for address 0x1138:0x4EC9/0x16249.
    // Operation not registered by running code
    public int Get1138_4EC9_Byte8() {
        return GetUint8(0x4EC9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EC9_Byte8(byte value) {
        SetUint8(0x4EC9, value);
    }

    // Getters and Setters for address 0x1138:0x4ECA/0x1624A.
    // Operation not registered by running code
    public int Get1138_4ECA_Byte8() {
        return GetUint8(0x4ECA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ECA_Byte8(byte value) {
        SetUint8(0x4ECA, value);
    }

    // Getters and Setters for address 0x1138:0x4ECB/0x1624B.
    // Operation not registered by running code
    public int Get1138_4ECB_Byte8() {
        return GetUint8(0x4ECB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ECB_Byte8(byte value) {
        SetUint8(0x4ECB, value);
    }

    // Getters and Setters for address 0x1138:0x4ECC/0x1624C.
    // Operation not registered by running code
    public int Get1138_4ECC_Byte8() {
        return GetUint8(0x4ECC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ECC_Byte8(byte value) {
        SetUint8(0x4ECC, value);
    }

    // Getters and Setters for address 0x1138:0x4ECD/0x1624D.
    // Operation not registered by running code
    public int Get1138_4ECD_Byte8() {
        return GetUint8(0x4ECD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ECD_Byte8(byte value) {
        SetUint8(0x4ECD, value);
    }

    // Getters and Setters for address 0x1138:0x4ECE/0x1624E.
    // Operation not registered by running code
    public int Get1138_4ECE_Byte8() {
        return GetUint8(0x4ECE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ECE_Byte8(byte value) {
        SetUint8(0x4ECE, value);
    }

    // Getters and Setters for address 0x1138:0x4ECF/0x1624F.
    // Operation not registered by running code
    public int Get1138_4ECF_Byte8() {
        return GetUint8(0x4ECF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ECF_Byte8(byte value) {
        SetUint8(0x4ECF, value);
    }

    // Getters and Setters for address 0x1138:0x4ED0/0x16250.
    // Operation not registered by running code
    public int Get1138_4ED0_Byte8() {
        return GetUint8(0x4ED0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ED0_Byte8(byte value) {
        SetUint8(0x4ED0, value);
    }

    // Getters and Setters for address 0x1138:0x4ED1/0x16251.
    // Operation not registered by running code
    public int Get1138_4ED1_Byte8() {
        return GetUint8(0x4ED1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ED1_Byte8(byte value) {
        SetUint8(0x4ED1, value);
    }

    // Getters and Setters for address 0x1138:0x4ED2/0x16252.
    // Operation not registered by running code
    public int Get1138_4ED2_Byte8() {
        return GetUint8(0x4ED2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ED2_Byte8(byte value) {
        SetUint8(0x4ED2, value);
    }

    // Getters and Setters for address 0x1138:0x4ED3/0x16253.
    // Operation not registered by running code
    public int Get1138_4ED3_Byte8() {
        return GetUint8(0x4ED3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ED3_Byte8(byte value) {
        SetUint8(0x4ED3, value);
    }

    // Getters and Setters for address 0x1138:0x4ED4/0x16254.
    // Operation not registered by running code
    public int Get1138_4ED4_Byte8() {
        return GetUint8(0x4ED4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ED4_Byte8(byte value) {
        SetUint8(0x4ED4, value);
    }

    // Getters and Setters for address 0x1138:0x4ED5/0x16255.
    // Operation not registered by running code
    public int Get1138_4ED5_Byte8() {
        return GetUint8(0x4ED5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ED5_Byte8(byte value) {
        SetUint8(0x4ED5, value);
    }

    // Getters and Setters for address 0x1138:0x4ED6/0x16256.
    // Operation not registered by running code
    public int Get1138_4ED6_Byte8() {
        return GetUint8(0x4ED6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ED6_Byte8(byte value) {
        SetUint8(0x4ED6, value);
    }

    // Getters and Setters for address 0x1138:0x4ED7/0x16257.
    // Operation not registered by running code
    public int Get1138_4ED7_Byte8() {
        return GetUint8(0x4ED7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ED7_Byte8(byte value) {
        SetUint8(0x4ED7, value);
    }

    // Getters and Setters for address 0x1138:0x4ED8/0x16258.
    // Operation not registered by running code
    public int Get1138_4ED8_Byte8() {
        return GetUint8(0x4ED8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ED8_Byte8(byte value) {
        SetUint8(0x4ED8, value);
    }

    // Getters and Setters for address 0x1138:0x4ED9/0x16259.
    // Operation not registered by running code
    public int Get1138_4ED9_Byte8() {
        return GetUint8(0x4ED9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4ED9_Byte8(byte value) {
        SetUint8(0x4ED9, value);
    }

    // Getters and Setters for address 0x1138:0x4EDA/0x1625A.
    // Operation not registered by running code
    public int Get1138_4EDA_Byte8() {
        return GetUint8(0x4EDA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EDA_Byte8(byte value) {
        SetUint8(0x4EDA, value);
    }

    // Getters and Setters for address 0x1138:0x4EDB/0x1625B.
    // Operation not registered by running code
    public int Get1138_4EDB_Byte8() {
        return GetUint8(0x4EDB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EDB_Byte8(byte value) {
        SetUint8(0x4EDB, value);
    }

    // Getters and Setters for address 0x1138:0x4EDC/0x1625C.
    // Operation not registered by running code
    public int Get1138_4EDC_Byte8() {
        return GetUint8(0x4EDC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EDC_Byte8(byte value) {
        SetUint8(0x4EDC, value);
    }

    // Getters and Setters for address 0x1138:0x4EDD/0x1625D.
    // Operation not registered by running code
    public int Get1138_4EDD_Byte8() {
        return GetUint8(0x4EDD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EDD_Byte8(byte value) {
        SetUint8(0x4EDD, value);
    }

    // Getters and Setters for address 0x1138:0x4EDE/0x1625E.
    // Operation not registered by running code
    public int Get1138_4EDE_Byte8() {
        return GetUint8(0x4EDE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EDE_Byte8(byte value) {
        SetUint8(0x4EDE, value);
    }

    // Getters and Setters for address 0x1138:0x4EDF/0x1625F.
    // Operation not registered by running code
    public int Get1138_4EDF_Byte8() {
        return GetUint8(0x4EDF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EDF_Byte8(byte value) {
        SetUint8(0x4EDF, value);
    }

    // Getters and Setters for address 0x1138:0x4EE0/0x16260.
    // Operation not registered by running code
    public int Get1138_4EE0_Byte8() {
        return GetUint8(0x4EE0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EE0_Byte8(byte value) {
        SetUint8(0x4EE0, value);
    }

    // Getters and Setters for address 0x1138:0x4EE1/0x16261.
    // Operation not registered by running code
    public int Get1138_4EE1_Byte8() {
        return GetUint8(0x4EE1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EE1_Byte8(byte value) {
        SetUint8(0x4EE1, value);
    }

    // Getters and Setters for address 0x1138:0x4EE2/0x16262.
    // Operation not registered by running code
    public int Get1138_4EE2_Byte8() {
        return GetUint8(0x4EE2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EE2_Byte8(byte value) {
        SetUint8(0x4EE2, value);
    }

    // Getters and Setters for address 0x1138:0x4EE3/0x16263.
    // Operation not registered by running code
    public int Get1138_4EE3_Byte8() {
        return GetUint8(0x4EE3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EE3_Byte8(byte value) {
        SetUint8(0x4EE3, value);
    }

    // Getters and Setters for address 0x1138:0x4EE4/0x16264.
    // Operation not registered by running code
    public int Get1138_4EE4_Byte8() {
        return GetUint8(0x4EE4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EE4_Byte8(byte value) {
        SetUint8(0x4EE4, value);
    }

    // Getters and Setters for address 0x1138:0x4EE5/0x16265.
    // Operation not registered by running code
    public int Get1138_4EE5_Byte8() {
        return GetUint8(0x4EE5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EE5_Byte8(byte value) {
        SetUint8(0x4EE5, value);
    }

    // Getters and Setters for address 0x1138:0x4EE6/0x16266.
    // Operation not registered by running code
    public int Get1138_4EE6_Byte8() {
        return GetUint8(0x4EE6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EE6_Byte8(byte value) {
        SetUint8(0x4EE6, value);
    }

    // Getters and Setters for address 0x1138:0x4EE7/0x16267.
    // Operation not registered by running code
    public int Get1138_4EE7_Byte8() {
        return GetUint8(0x4EE7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EE7_Byte8(byte value) {
        SetUint8(0x4EE7, value);
    }

    // Getters and Setters for address 0x1138:0x4EE8/0x16268.
    // Operation not registered by running code
    public int Get1138_4EE8_Byte8() {
        return GetUint8(0x4EE8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EE8_Byte8(byte value) {
        SetUint8(0x4EE8, value);
    }

    // Getters and Setters for address 0x1138:0x4EE9/0x16269.
    // Operation not registered by running code
    public int Get1138_4EE9_Byte8() {
        return GetUint8(0x4EE9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EE9_Byte8(byte value) {
        SetUint8(0x4EE9, value);
    }

    // Getters and Setters for address 0x1138:0x4EEA/0x1626A.
    // Operation not registered by running code
    public int Get1138_4EEA_Byte8() {
        return GetUint8(0x4EEA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EEA_Byte8(byte value) {
        SetUint8(0x4EEA, value);
    }

    // Getters and Setters for address 0x1138:0x4EEB/0x1626B.
    // Operation not registered by running code
    public int Get1138_4EEB_Byte8() {
        return GetUint8(0x4EEB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EEB_Byte8(byte value) {
        SetUint8(0x4EEB, value);
    }

    // Getters and Setters for address 0x1138:0x4EEC/0x1626C.
    // Operation not registered by running code
    public int Get1138_4EEC_Byte8() {
        return GetUint8(0x4EEC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EEC_Byte8(byte value) {
        SetUint8(0x4EEC, value);
    }

    // Getters and Setters for address 0x1138:0x4EED/0x1626D.
    // Operation not registered by running code
    public int Get1138_4EED_Byte8() {
        return GetUint8(0x4EED);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EED_Byte8(byte value) {
        SetUint8(0x4EED, value);
    }

    // Getters and Setters for address 0x1138:0x4EEE/0x1626E.
    // Operation not registered by running code
    public int Get1138_4EEE_Byte8() {
        return GetUint8(0x4EEE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EEE_Byte8(byte value) {
        SetUint8(0x4EEE, value);
    }

    // Getters and Setters for address 0x1138:0x4EEF/0x1626F.
    // Operation not registered by running code
    public int Get1138_4EEF_Byte8() {
        return GetUint8(0x4EEF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EEF_Byte8(byte value) {
        SetUint8(0x4EEF, value);
    }

    // Getters and Setters for address 0x1138:0x4EF0/0x16270.
    // Operation not registered by running code
    public int Get1138_4EF0_Byte8() {
        return GetUint8(0x4EF0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EF0_Byte8(byte value) {
        SetUint8(0x4EF0, value);
    }

    // Getters and Setters for address 0x1138:0x4EF1/0x16271.
    // Operation not registered by running code
    public int Get1138_4EF1_Byte8() {
        return GetUint8(0x4EF1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EF1_Byte8(byte value) {
        SetUint8(0x4EF1, value);
    }

    // Getters and Setters for address 0x1138:0x4EF2/0x16272.
    // Operation not registered by running code
    public int Get1138_4EF2_Byte8() {
        return GetUint8(0x4EF2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EF2_Byte8(byte value) {
        SetUint8(0x4EF2, value);
    }

    // Getters and Setters for address 0x1138:0x4EF3/0x16273.
    // Operation not registered by running code
    public int Get1138_4EF3_Byte8() {
        return GetUint8(0x4EF3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EF3_Byte8(byte value) {
        SetUint8(0x4EF3, value);
    }

    // Getters and Setters for address 0x1138:0x4EF4/0x16274.
    // Operation not registered by running code
    public int Get1138_4EF4_Byte8() {
        return GetUint8(0x4EF4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EF4_Byte8(byte value) {
        SetUint8(0x4EF4, value);
    }

    // Getters and Setters for address 0x1138:0x4EF5/0x16275.
    // Operation not registered by running code
    public int Get1138_4EF5_Byte8() {
        return GetUint8(0x4EF5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EF5_Byte8(byte value) {
        SetUint8(0x4EF5, value);
    }

    // Getters and Setters for address 0x1138:0x4EF6/0x16276.
    // Operation not registered by running code
    public int Get1138_4EF6_Byte8() {
        return GetUint8(0x4EF6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EF6_Byte8(byte value) {
        SetUint8(0x4EF6, value);
    }

    // Getters and Setters for address 0x1138:0x4EF7/0x16277.
    // Operation not registered by running code
    public int Get1138_4EF7_Byte8() {
        return GetUint8(0x4EF7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EF7_Byte8(byte value) {
        SetUint8(0x4EF7, value);
    }

    // Getters and Setters for address 0x1138:0x4EF8/0x16278.
    // Operation not registered by running code
    public int Get1138_4EF8_Byte8() {
        return GetUint8(0x4EF8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EF8_Byte8(byte value) {
        SetUint8(0x4EF8, value);
    }

    // Getters and Setters for address 0x1138:0x4EF9/0x16279.
    // Operation not registered by running code
    public int Get1138_4EF9_Byte8() {
        return GetUint8(0x4EF9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EF9_Byte8(byte value) {
        SetUint8(0x4EF9, value);
    }

    // Getters and Setters for address 0x1138:0x4EFA/0x1627A.
    // Operation not registered by running code
    public int Get1138_4EFA_Byte8() {
        return GetUint8(0x4EFA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EFA_Byte8(byte value) {
        SetUint8(0x4EFA, value);
    }

    // Getters and Setters for address 0x1138:0x4EFB/0x1627B.
    // Operation not registered by running code
    public int Get1138_4EFB_Byte8() {
        return GetUint8(0x4EFB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EFB_Byte8(byte value) {
        SetUint8(0x4EFB, value);
    }

    // Getters and Setters for address 0x1138:0x4EFC/0x1627C.
    // Operation not registered by running code
    public int Get1138_4EFC_Byte8() {
        return GetUint8(0x4EFC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EFC_Byte8(byte value) {
        SetUint8(0x4EFC, value);
    }

    // Getters and Setters for address 0x1138:0x4EFD/0x1627D.
    // Operation not registered by running code
    public int Get1138_4EFD_Byte8() {
        return GetUint8(0x4EFD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EFD_Byte8(byte value) {
        SetUint8(0x4EFD, value);
    }

    // Getters and Setters for address 0x1138:0x4EFE/0x1627E.
    // Operation not registered by running code
    public int Get1138_4EFE_Byte8() {
        return GetUint8(0x4EFE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EFE_Byte8(byte value) {
        SetUint8(0x4EFE, value);
    }

    // Getters and Setters for address 0x1138:0x4EFF/0x1627F.
    // Operation not registered by running code
    public int Get1138_4EFF_Byte8() {
        return GetUint8(0x4EFF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4EFF_Byte8(byte value) {
        SetUint8(0x4EFF, value);
    }

    // Getters and Setters for address 0x1138:0x4F00/0x16280.
    // Operation not registered by running code
    public int Get1138_4F00_Byte8() {
        return GetUint8(0x4F00);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F00_Byte8(byte value) {
        SetUint8(0x4F00, value);
    }

    // Getters and Setters for address 0x1138:0x4F01/0x16281.
    // Operation not registered by running code
    public int Get1138_4F01_Byte8() {
        return GetUint8(0x4F01);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F01_Byte8(byte value) {
        SetUint8(0x4F01, value);
    }

    // Getters and Setters for address 0x1138:0x4F02/0x16282.
    // Operation not registered by running code
    public int Get1138_4F02_Byte8() {
        return GetUint8(0x4F02);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F02_Byte8(byte value) {
        SetUint8(0x4F02, value);
    }

    // Getters and Setters for address 0x1138:0x4F03/0x16283.
    // Operation not registered by running code
    public int Get1138_4F03_Byte8() {
        return GetUint8(0x4F03);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F03_Byte8(byte value) {
        SetUint8(0x4F03, value);
    }

    // Getters and Setters for address 0x1138:0x4F04/0x16284.
    // Operation not registered by running code
    public int Get1138_4F04_Byte8() {
        return GetUint8(0x4F04);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F04_Byte8(byte value) {
        SetUint8(0x4F04, value);
    }

    // Getters and Setters for address 0x1138:0x4F05/0x16285.
    // Operation not registered by running code
    public int Get1138_4F05_Byte8() {
        return GetUint8(0x4F05);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F05_Byte8(byte value) {
        SetUint8(0x4F05, value);
    }

    // Getters and Setters for address 0x1138:0x4F06/0x16286.
    // Operation not registered by running code
    public int Get1138_4F06_Byte8() {
        return GetUint8(0x4F06);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F06_Byte8(byte value) {
        SetUint8(0x4F06, value);
    }

    // Getters and Setters for address 0x1138:0x4F07/0x16287.
    // Operation not registered by running code
    public int Get1138_4F07_Byte8() {
        return GetUint8(0x4F07);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F07_Byte8(byte value) {
        SetUint8(0x4F07, value);
    }

    // Getters and Setters for address 0x1138:0x4F08/0x16288.
    // Operation not registered by running code
    public int Get1138_4F08_Byte8() {
        return GetUint8(0x4F08);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F08_Byte8(byte value) {
        SetUint8(0x4F08, value);
    }

    // Getters and Setters for address 0x1138:0x4F09/0x16289.
    // Operation not registered by running code
    public int Get1138_4F09_Byte8() {
        return GetUint8(0x4F09);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F09_Byte8(byte value) {
        SetUint8(0x4F09, value);
    }

    // Getters and Setters for address 0x1138:0x4F0A/0x1628A.
    // Operation not registered by running code
    public int Get1138_4F0A_Byte8() {
        return GetUint8(0x4F0A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F0A_Byte8(byte value) {
        SetUint8(0x4F0A, value);
    }

    // Getters and Setters for address 0x1138:0x4F0B/0x1628B.
    // Operation not registered by running code
    public int Get1138_4F0B_Byte8() {
        return GetUint8(0x4F0B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F0B_Byte8(byte value) {
        SetUint8(0x4F0B, value);
    }

    // Getters and Setters for address 0x1138:0x4F0C/0x1628C.
    // Operation not registered by running code
    public int Get1138_4F0C_Byte8() {
        return GetUint8(0x4F0C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F0C_Byte8(byte value) {
        SetUint8(0x4F0C, value);
    }

    // Getters and Setters for address 0x1138:0x4F0D/0x1628D.
    // Operation not registered by running code
    public int Get1138_4F0D_Byte8() {
        return GetUint8(0x4F0D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F0D_Byte8(byte value) {
        SetUint8(0x4F0D, value);
    }

    // Getters and Setters for address 0x1138:0x4F0E/0x1628E.
    // Operation not registered by running code
    public int Get1138_4F0E_Byte8() {
        return GetUint8(0x4F0E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F0E_Byte8(byte value) {
        SetUint8(0x4F0E, value);
    }

    // Getters and Setters for address 0x1138:0x4F0F/0x1628F.
    // Operation not registered by running code
    public int Get1138_4F0F_Byte8() {
        return GetUint8(0x4F0F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F0F_Byte8(byte value) {
        SetUint8(0x4F0F, value);
    }

    // Getters and Setters for address 0x1138:0x4F10/0x16290.
    // Operation not registered by running code
    public int Get1138_4F10_Byte8() {
        return GetUint8(0x4F10);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F10_Byte8(byte value) {
        SetUint8(0x4F10, value);
    }

    // Getters and Setters for address 0x1138:0x4F11/0x16291.
    // Operation not registered by running code
    public int Get1138_4F11_Byte8() {
        return GetUint8(0x4F11);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F11_Byte8(byte value) {
        SetUint8(0x4F11, value);
    }

    // Getters and Setters for address 0x1138:0x4F12/0x16292.
    // Operation not registered by running code
    public int Get1138_4F12_Byte8() {
        return GetUint8(0x4F12);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F12_Byte8(byte value) {
        SetUint8(0x4F12, value);
    }

    // Getters and Setters for address 0x1138:0x4F13/0x16293.
    // Operation not registered by running code
    public int Get1138_4F13_Byte8() {
        return GetUint8(0x4F13);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F13_Byte8(byte value) {
        SetUint8(0x4F13, value);
    }

    // Getters and Setters for address 0x1138:0x4F14/0x16294.
    // Operation not registered by running code
    public int Get1138_4F14_Byte8() {
        return GetUint8(0x4F14);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F14_Byte8(byte value) {
        SetUint8(0x4F14, value);
    }

    // Getters and Setters for address 0x1138:0x4F15/0x16295.
    // Operation not registered by running code
    public int Get1138_4F15_Byte8() {
        return GetUint8(0x4F15);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F15_Byte8(byte value) {
        SetUint8(0x4F15, value);
    }

    // Getters and Setters for address 0x1138:0x4F16/0x16296.
    // Operation not registered by running code
    public int Get1138_4F16_Byte8() {
        return GetUint8(0x4F16);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F16_Byte8(byte value) {
        SetUint8(0x4F16, value);
    }

    // Getters and Setters for address 0x1138:0x4F17/0x16297.
    // Operation not registered by running code
    public int Get1138_4F17_Byte8() {
        return GetUint8(0x4F17);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F17_Byte8(byte value) {
        SetUint8(0x4F17, value);
    }

    // Getters and Setters for address 0x1138:0x4F18/0x16298.
    // Operation not registered by running code
    public int Get1138_4F18_Byte8() {
        return GetUint8(0x4F18);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F18_Byte8(byte value) {
        SetUint8(0x4F18, value);
    }

    // Getters and Setters for address 0x1138:0x4F19/0x16299.
    // Operation not registered by running code
    public int Get1138_4F19_Byte8() {
        return GetUint8(0x4F19);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F19_Byte8(byte value) {
        SetUint8(0x4F19, value);
    }

    // Getters and Setters for address 0x1138:0x4F1A/0x1629A.
    // Operation not registered by running code
    public int Get1138_4F1A_Byte8() {
        return GetUint8(0x4F1A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F1A_Byte8(byte value) {
        SetUint8(0x4F1A, value);
    }

    // Getters and Setters for address 0x1138:0x4F1B/0x1629B.
    // Operation not registered by running code
    public int Get1138_4F1B_Byte8() {
        return GetUint8(0x4F1B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F1B_Byte8(byte value) {
        SetUint8(0x4F1B, value);
    }

    // Getters and Setters for address 0x1138:0x4F1C/0x1629C.
    // Operation not registered by running code
    public int Get1138_4F1C_Byte8() {
        return GetUint8(0x4F1C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F1C_Byte8(byte value) {
        SetUint8(0x4F1C, value);
    }

    // Getters and Setters for address 0x1138:0x4F1D/0x1629D.
    // Operation not registered by running code
    public int Get1138_4F1D_Byte8() {
        return GetUint8(0x4F1D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F1D_Byte8(byte value) {
        SetUint8(0x4F1D, value);
    }

    // Getters and Setters for address 0x1138:0x4F1E/0x1629E.
    // Operation not registered by running code
    public int Get1138_4F1E_Byte8() {
        return GetUint8(0x4F1E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F1E_Byte8(byte value) {
        SetUint8(0x4F1E, value);
    }

    // Getters and Setters for address 0x1138:0x4F1F/0x1629F.
    // Operation not registered by running code
    public int Get1138_4F1F_Byte8() {
        return GetUint8(0x4F1F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F1F_Byte8(byte value) {
        SetUint8(0x4F1F, value);
    }

    // Getters and Setters for address 0x1138:0x4F20/0x162A0.
    // Operation not registered by running code
    public int Get1138_4F20_Byte8() {
        return GetUint8(0x4F20);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F20_Byte8(byte value) {
        SetUint8(0x4F20, value);
    }

    // Getters and Setters for address 0x1138:0x4F21/0x162A1.
    // Operation not registered by running code
    public int Get1138_4F21_Byte8() {
        return GetUint8(0x4F21);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F21_Byte8(byte value) {
        SetUint8(0x4F21, value);
    }

    // Getters and Setters for address 0x1138:0x4F22/0x162A2.
    // Operation not registered by running code
    public int Get1138_4F22_Byte8() {
        return GetUint8(0x4F22);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F22_Byte8(byte value) {
        SetUint8(0x4F22, value);
    }

    // Getters and Setters for address 0x1138:0x4F23/0x162A3.
    // Operation not registered by running code
    public int Get1138_4F23_Byte8() {
        return GetUint8(0x4F23);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F23_Byte8(byte value) {
        SetUint8(0x4F23, value);
    }

    // Getters and Setters for address 0x1138:0x4F24/0x162A4.
    // Operation not registered by running code
    public int Get1138_4F24_Byte8() {
        return GetUint8(0x4F24);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F24_Byte8(byte value) {
        SetUint8(0x4F24, value);
    }

    // Getters and Setters for address 0x1138:0x4F25/0x162A5.
    // Operation not registered by running code
    public int Get1138_4F25_Byte8() {
        return GetUint8(0x4F25);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F25_Byte8(byte value) {
        SetUint8(0x4F25, value);
    }

    // Getters and Setters for address 0x1138:0x4F26/0x162A6.
    // Operation not registered by running code
    public int Get1138_4F26_Byte8() {
        return GetUint8(0x4F26);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F26_Byte8(byte value) {
        SetUint8(0x4F26, value);
    }

    // Getters and Setters for address 0x1138:0x4F27/0x162A7.
    // Operation not registered by running code
    public int Get1138_4F27_Byte8() {
        return GetUint8(0x4F27);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F27_Byte8(byte value) {
        SetUint8(0x4F27, value);
    }

    // Getters and Setters for address 0x1138:0x4F28/0x162A8.
    // Operation not registered by running code
    public int Get1138_4F28_Byte8() {
        return GetUint8(0x4F28);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F28_Byte8(byte value) {
        SetUint8(0x4F28, value);
    }

    // Getters and Setters for address 0x1138:0x4F29/0x162A9.
    // Operation not registered by running code
    public int Get1138_4F29_Byte8() {
        return GetUint8(0x4F29);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F29_Byte8(byte value) {
        SetUint8(0x4F29, value);
    }

    // Getters and Setters for address 0x1138:0x4F2A/0x162AA.
    // Operation not registered by running code
    public int Get1138_4F2A_Byte8() {
        return GetUint8(0x4F2A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F2A_Byte8(byte value) {
        SetUint8(0x4F2A, value);
    }

    // Getters and Setters for address 0x1138:0x4F2B/0x162AB.
    // Operation not registered by running code
    public int Get1138_4F2B_Byte8() {
        return GetUint8(0x4F2B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F2B_Byte8(byte value) {
        SetUint8(0x4F2B, value);
    }

    // Getters and Setters for address 0x1138:0x4F2C/0x162AC.
    // Operation not registered by running code
    public int Get1138_4F2C_Byte8() {
        return GetUint8(0x4F2C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F2C_Byte8(byte value) {
        SetUint8(0x4F2C, value);
    }

    // Getters and Setters for address 0x1138:0x4F2D/0x162AD.
    // Operation not registered by running code
    public int Get1138_4F2D_Byte8() {
        return GetUint8(0x4F2D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F2D_Byte8(byte value) {
        SetUint8(0x4F2D, value);
    }

    // Getters and Setters for address 0x1138:0x4F2E/0x162AE.
    // Operation not registered by running code
    public int Get1138_4F2E_Byte8() {
        return GetUint8(0x4F2E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F2E_Byte8(byte value) {
        SetUint8(0x4F2E, value);
    }

    // Getters and Setters for address 0x1138:0x4F2F/0x162AF.
    // Operation not registered by running code
    public int Get1138_4F2F_Byte8() {
        return GetUint8(0x4F2F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F2F_Byte8(byte value) {
        SetUint8(0x4F2F, value);
    }

    // Getters and Setters for address 0x1138:0x4F30/0x162B0.
    // Operation not registered by running code
    public int Get1138_4F30_Byte8() {
        return GetUint8(0x4F30);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F30_Byte8(byte value) {
        SetUint8(0x4F30, value);
    }

    // Getters and Setters for address 0x1138:0x4F31/0x162B1.
    // Operation not registered by running code
    public int Get1138_4F31_Byte8() {
        return GetUint8(0x4F31);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F31_Byte8(byte value) {
        SetUint8(0x4F31, value);
    }

    // Getters and Setters for address 0x1138:0x4F32/0x162B2.
    // Operation not registered by running code
    public int Get1138_4F32_Byte8() {
        return GetUint8(0x4F32);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F32_Byte8(byte value) {
        SetUint8(0x4F32, value);
    }

    // Getters and Setters for address 0x1138:0x4F33/0x162B3.
    // Operation not registered by running code
    public int Get1138_4F33_Byte8() {
        return GetUint8(0x4F33);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F33_Byte8(byte value) {
        SetUint8(0x4F33, value);
    }

    // Getters and Setters for address 0x1138:0x4F34/0x162B4.
    // Operation not registered by running code
    public int Get1138_4F34_Byte8() {
        return GetUint8(0x4F34);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F34_Byte8(byte value) {
        SetUint8(0x4F34, value);
    }

    // Getters and Setters for address 0x1138:0x4F35/0x162B5.
    // Operation not registered by running code
    public int Get1138_4F35_Byte8() {
        return GetUint8(0x4F35);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F35_Byte8(byte value) {
        SetUint8(0x4F35, value);
    }

    // Getters and Setters for address 0x1138:0x4F36/0x162B6.
    // Operation not registered by running code
    public int Get1138_4F36_Byte8() {
        return GetUint8(0x4F36);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F36_Byte8(byte value) {
        SetUint8(0x4F36, value);
    }

    // Getters and Setters for address 0x1138:0x4F37/0x162B7.
    // Operation not registered by running code
    public int Get1138_4F37_Byte8() {
        return GetUint8(0x4F37);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F37_Byte8(byte value) {
        SetUint8(0x4F37, value);
    }

    // Getters and Setters for address 0x1138:0x4F38/0x162B8.
    // Operation not registered by running code
    public int Get1138_4F38_Byte8() {
        return GetUint8(0x4F38);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F38_Byte8(byte value) {
        SetUint8(0x4F38, value);
    }

    // Getters and Setters for address 0x1138:0x4F39/0x162B9.
    // Operation not registered by running code
    public int Get1138_4F39_Byte8() {
        return GetUint8(0x4F39);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F39_Byte8(byte value) {
        SetUint8(0x4F39, value);
    }

    // Getters and Setters for address 0x1138:0x4F3A/0x162BA.
    // Operation not registered by running code
    public int Get1138_4F3A_Byte8() {
        return GetUint8(0x4F3A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F3A_Byte8(byte value) {
        SetUint8(0x4F3A, value);
    }

    // Getters and Setters for address 0x1138:0x4F3B/0x162BB.
    // Operation not registered by running code
    public int Get1138_4F3B_Byte8() {
        return GetUint8(0x4F3B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F3B_Byte8(byte value) {
        SetUint8(0x4F3B, value);
    }

    // Getters and Setters for address 0x1138:0x4F3C/0x162BC.
    // Operation not registered by running code
    public int Get1138_4F3C_Byte8() {
        return GetUint8(0x4F3C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F3C_Byte8(byte value) {
        SetUint8(0x4F3C, value);
    }

    // Getters and Setters for address 0x1138:0x4F3D/0x162BD.
    // Operation not registered by running code
    public int Get1138_4F3D_Byte8() {
        return GetUint8(0x4F3D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F3D_Byte8(byte value) {
        SetUint8(0x4F3D, value);
    }

    // Getters and Setters for address 0x1138:0x4F3E/0x162BE.
    // Operation not registered by running code
    public int Get1138_4F3E_Byte8() {
        return GetUint8(0x4F3E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F3E_Byte8(byte value) {
        SetUint8(0x4F3E, value);
    }

    // Getters and Setters for address 0x1138:0x4F3F/0x162BF.
    // Operation not registered by running code
    public int Get1138_4F3F_Byte8() {
        return GetUint8(0x4F3F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F3F_Byte8(byte value) {
        SetUint8(0x4F3F, value);
    }

    // Getters and Setters for address 0x1138:0x4F40/0x162C0.
    // Operation not registered by running code
    public int Get1138_4F40_Byte8() {
        return GetUint8(0x4F40);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F40_Byte8(byte value) {
        SetUint8(0x4F40, value);
    }

    // Getters and Setters for address 0x1138:0x4F41/0x162C1.
    // Operation not registered by running code
    public int Get1138_4F41_Byte8() {
        return GetUint8(0x4F41);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F41_Byte8(byte value) {
        SetUint8(0x4F41, value);
    }

    // Getters and Setters for address 0x1138:0x4F42/0x162C2.
    // Operation not registered by running code
    public int Get1138_4F42_Byte8() {
        return GetUint8(0x4F42);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F42_Byte8(byte value) {
        SetUint8(0x4F42, value);
    }

    // Getters and Setters for address 0x1138:0x4F43/0x162C3.
    // Operation not registered by running code
    public int Get1138_4F43_Byte8() {
        return GetUint8(0x4F43);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F43_Byte8(byte value) {
        SetUint8(0x4F43, value);
    }

    // Getters and Setters for address 0x1138:0x4F44/0x162C4.
    // Operation not registered by running code
    public int Get1138_4F44_Byte8() {
        return GetUint8(0x4F44);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F44_Byte8(byte value) {
        SetUint8(0x4F44, value);
    }

    // Getters and Setters for address 0x1138:0x4F45/0x162C5.
    // Operation not registered by running code
    public int Get1138_4F45_Byte8() {
        return GetUint8(0x4F45);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F45_Byte8(byte value) {
        SetUint8(0x4F45, value);
    }

    // Getters and Setters for address 0x1138:0x4F46/0x162C6.
    // Operation not registered by running code
    public int Get1138_4F46_Byte8() {
        return GetUint8(0x4F46);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F46_Byte8(byte value) {
        SetUint8(0x4F46, value);
    }

    // Getters and Setters for address 0x1138:0x4F47/0x162C7.
    // Operation not registered by running code
    public int Get1138_4F47_Byte8() {
        return GetUint8(0x4F47);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F47_Byte8(byte value) {
        SetUint8(0x4F47, value);
    }

    // Getters and Setters for address 0x1138:0x4F48/0x162C8.
    // Operation not registered by running code
    public int Get1138_4F48_Byte8() {
        return GetUint8(0x4F48);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F48_Byte8(byte value) {
        SetUint8(0x4F48, value);
    }

    // Getters and Setters for address 0x1138:0x4F49/0x162C9.
    // Operation not registered by running code
    public int Get1138_4F49_Byte8() {
        return GetUint8(0x4F49);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F49_Byte8(byte value) {
        SetUint8(0x4F49, value);
    }

    // Getters and Setters for address 0x1138:0x4F4A/0x162CA.
    // Operation not registered by running code
    public int Get1138_4F4A_Byte8() {
        return GetUint8(0x4F4A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F4A_Byte8(byte value) {
        SetUint8(0x4F4A, value);
    }

    // Getters and Setters for address 0x1138:0x4F4B/0x162CB.
    // Operation not registered by running code
    public int Get1138_4F4B_Byte8() {
        return GetUint8(0x4F4B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F4B_Byte8(byte value) {
        SetUint8(0x4F4B, value);
    }

    // Getters and Setters for address 0x1138:0x4F4C/0x162CC.
    // Operation not registered by running code
    public int Get1138_4F4C_Byte8() {
        return GetUint8(0x4F4C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F4C_Byte8(byte value) {
        SetUint8(0x4F4C, value);
    }

    // Getters and Setters for address 0x1138:0x4F4D/0x162CD.
    // Operation not registered by running code
    public int Get1138_4F4D_Byte8() {
        return GetUint8(0x4F4D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F4D_Byte8(byte value) {
        SetUint8(0x4F4D, value);
    }

    // Getters and Setters for address 0x1138:0x4F4E/0x162CE.
    // Operation not registered by running code
    public int Get1138_4F4E_Byte8() {
        return GetUint8(0x4F4E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F4E_Byte8(byte value) {
        SetUint8(0x4F4E, value);
    }

    // Getters and Setters for address 0x1138:0x4F4F/0x162CF.
    // Operation not registered by running code
    public int Get1138_4F4F_Byte8() {
        return GetUint8(0x4F4F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F4F_Byte8(byte value) {
        SetUint8(0x4F4F, value);
    }

    // Getters and Setters for address 0x1138:0x4F50/0x162D0.
    // Operation not registered by running code
    public int Get1138_4F50_Byte8() {
        return GetUint8(0x4F50);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F50_Byte8(byte value) {
        SetUint8(0x4F50, value);
    }

    // Getters and Setters for address 0x1138:0x4F51/0x162D1.
    // Operation not registered by running code
    public int Get1138_4F51_Byte8() {
        return GetUint8(0x4F51);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F51_Byte8(byte value) {
        SetUint8(0x4F51, value);
    }

    // Getters and Setters for address 0x1138:0x4F52/0x162D2.
    // Operation not registered by running code
    public int Get1138_4F52_Byte8() {
        return GetUint8(0x4F52);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F52_Byte8(byte value) {
        SetUint8(0x4F52, value);
    }

    // Getters and Setters for address 0x1138:0x4F53/0x162D3.
    // Operation not registered by running code
    public int Get1138_4F53_Byte8() {
        return GetUint8(0x4F53);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F53_Byte8(byte value) {
        SetUint8(0x4F53, value);
    }

    // Getters and Setters for address 0x1138:0x4F54/0x162D4.
    // Operation not registered by running code
    public int Get1138_4F54_Byte8() {
        return GetUint8(0x4F54);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F54_Byte8(byte value) {
        SetUint8(0x4F54, value);
    }

    // Getters and Setters for address 0x1138:0x4F55/0x162D5.
    // Operation not registered by running code
    public int Get1138_4F55_Byte8() {
        return GetUint8(0x4F55);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F55_Byte8(byte value) {
        SetUint8(0x4F55, value);
    }

    // Getters and Setters for address 0x1138:0x4F56/0x162D6.
    // Operation not registered by running code
    public int Get1138_4F56_Byte8() {
        return GetUint8(0x4F56);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F56_Byte8(byte value) {
        SetUint8(0x4F56, value);
    }

    // Getters and Setters for address 0x1138:0x4F57/0x162D7.
    // Operation not registered by running code
    public int Get1138_4F57_Byte8() {
        return GetUint8(0x4F57);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F57_Byte8(byte value) {
        SetUint8(0x4F57, value);
    }

    // Getters and Setters for address 0x1138:0x4F58/0x162D8.
    // Operation not registered by running code
    public int Get1138_4F58_Byte8() {
        return GetUint8(0x4F58);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F58_Byte8(byte value) {
        SetUint8(0x4F58, value);
    }

    // Getters and Setters for address 0x1138:0x4F59/0x162D9.
    // Operation not registered by running code
    public int Get1138_4F59_Byte8() {
        return GetUint8(0x4F59);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F59_Byte8(byte value) {
        SetUint8(0x4F59, value);
    }

    // Getters and Setters for address 0x1138:0x4F5A/0x162DA.
    // Operation not registered by running code
    public int Get1138_4F5A_Byte8() {
        return GetUint8(0x4F5A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F5A_Byte8(byte value) {
        SetUint8(0x4F5A, value);
    }

    // Getters and Setters for address 0x1138:0x4F5B/0x162DB.
    // Operation not registered by running code
    public int Get1138_4F5B_Byte8() {
        return GetUint8(0x4F5B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F5B_Byte8(byte value) {
        SetUint8(0x4F5B, value);
    }

    // Getters and Setters for address 0x1138:0x4F5C/0x162DC.
    // Operation not registered by running code
    public int Get1138_4F5C_Byte8() {
        return GetUint8(0x4F5C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F5C_Byte8(byte value) {
        SetUint8(0x4F5C, value);
    }

    // Getters and Setters for address 0x1138:0x4F5D/0x162DD.
    // Operation not registered by running code
    public int Get1138_4F5D_Byte8() {
        return GetUint8(0x4F5D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F5D_Byte8(byte value) {
        SetUint8(0x4F5D, value);
    }

    // Getters and Setters for address 0x1138:0x4F5E/0x162DE.
    // Operation not registered by running code
    public int Get1138_4F5E_Byte8() {
        return GetUint8(0x4F5E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F5E_Byte8(byte value) {
        SetUint8(0x4F5E, value);
    }

    // Getters and Setters for address 0x1138:0x4F5F/0x162DF.
    // Operation not registered by running code
    public int Get1138_4F5F_Byte8() {
        return GetUint8(0x4F5F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F5F_Byte8(byte value) {
        SetUint8(0x4F5F, value);
    }

    // Getters and Setters for address 0x1138:0x4F60/0x162E0.
    // Operation not registered by running code
    public int Get1138_4F60_Byte8() {
        return GetUint8(0x4F60);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F60_Byte8(byte value) {
        SetUint8(0x4F60, value);
    }

    // Getters and Setters for address 0x1138:0x4F61/0x162E1.
    // Operation not registered by running code
    public int Get1138_4F61_Byte8() {
        return GetUint8(0x4F61);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F61_Byte8(byte value) {
        SetUint8(0x4F61, value);
    }

    // Getters and Setters for address 0x1138:0x4F62/0x162E2.
    // Operation not registered by running code
    public int Get1138_4F62_Byte8() {
        return GetUint8(0x4F62);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F62_Byte8(byte value) {
        SetUint8(0x4F62, value);
    }

    // Getters and Setters for address 0x1138:0x4F63/0x162E3.
    // Operation not registered by running code
    public int Get1138_4F63_Byte8() {
        return GetUint8(0x4F63);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F63_Byte8(byte value) {
        SetUint8(0x4F63, value);
    }

    // Getters and Setters for address 0x1138:0x4F64/0x162E4.
    // Operation not registered by running code
    public int Get1138_4F64_Byte8() {
        return GetUint8(0x4F64);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F64_Byte8(byte value) {
        SetUint8(0x4F64, value);
    }

    // Getters and Setters for address 0x1138:0x4F65/0x162E5.
    // Operation not registered by running code
    public int Get1138_4F65_Byte8() {
        return GetUint8(0x4F65);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F65_Byte8(byte value) {
        SetUint8(0x4F65, value);
    }

    // Getters and Setters for address 0x1138:0x4F66/0x162E6.
    // Operation not registered by running code
    public int Get1138_4F66_Byte8() {
        return GetUint8(0x4F66);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F66_Byte8(byte value) {
        SetUint8(0x4F66, value);
    }

    // Getters and Setters for address 0x1138:0x4F67/0x162E7.
    // Operation not registered by running code
    public int Get1138_4F67_Byte8() {
        return GetUint8(0x4F67);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F67_Byte8(byte value) {
        SetUint8(0x4F67, value);
    }

    // Getters and Setters for address 0x1138:0x4F68/0x162E8.
    // Operation not registered by running code
    public int Get1138_4F68_Byte8() {
        return GetUint8(0x4F68);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F68_Byte8(byte value) {
        SetUint8(0x4F68, value);
    }

    // Getters and Setters for address 0x1138:0x4F69/0x162E9.
    // Operation not registered by running code
    public int Get1138_4F69_Byte8() {
        return GetUint8(0x4F69);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F69_Byte8(byte value) {
        SetUint8(0x4F69, value);
    }

    // Getters and Setters for address 0x1138:0x4F6A/0x162EA.
    // Operation not registered by running code
    public int Get1138_4F6A_Byte8() {
        return GetUint8(0x4F6A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F6A_Byte8(byte value) {
        SetUint8(0x4F6A, value);
    }

    // Getters and Setters for address 0x1138:0x4F6B/0x162EB.
    // Operation not registered by running code
    public int Get1138_4F6B_Byte8() {
        return GetUint8(0x4F6B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F6B_Byte8(byte value) {
        SetUint8(0x4F6B, value);
    }

    // Getters and Setters for address 0x1138:0x4F6C/0x162EC.
    // Operation not registered by running code
    public int Get1138_4F6C_Byte8() {
        return GetUint8(0x4F6C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F6C_Byte8(byte value) {
        SetUint8(0x4F6C, value);
    }

    // Getters and Setters for address 0x1138:0x4F6D/0x162ED.
    // Operation not registered by running code
    public int Get1138_4F6D_Byte8() {
        return GetUint8(0x4F6D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F6D_Byte8(byte value) {
        SetUint8(0x4F6D, value);
    }

    // Getters and Setters for address 0x1138:0x4F6E/0x162EE.
    // Operation not registered by running code
    public int Get1138_4F6E_Byte8() {
        return GetUint8(0x4F6E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F6E_Byte8(byte value) {
        SetUint8(0x4F6E, value);
    }

    // Getters and Setters for address 0x1138:0x4F6F/0x162EF.
    // Operation not registered by running code
    public int Get1138_4F6F_Byte8() {
        return GetUint8(0x4F6F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F6F_Byte8(byte value) {
        SetUint8(0x4F6F, value);
    }

    // Getters and Setters for address 0x1138:0x4F70/0x162F0.
    // Operation not registered by running code
    public int Get1138_4F70_Byte8() {
        return GetUint8(0x4F70);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F70_Byte8(byte value) {
        SetUint8(0x4F70, value);
    }

    // Getters and Setters for address 0x1138:0x4F71/0x162F1.
    // Operation not registered by running code
    public int Get1138_4F71_Byte8() {
        return GetUint8(0x4F71);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F71_Byte8(byte value) {
        SetUint8(0x4F71, value);
    }

    // Getters and Setters for address 0x1138:0x4F72/0x162F2.
    // Operation not registered by running code
    public int Get1138_4F72_Byte8() {
        return GetUint8(0x4F72);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F72_Byte8(byte value) {
        SetUint8(0x4F72, value);
    }

    // Getters and Setters for address 0x1138:0x4F73/0x162F3.
    // Operation not registered by running code
    public int Get1138_4F73_Byte8() {
        return GetUint8(0x4F73);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F73_Byte8(byte value) {
        SetUint8(0x4F73, value);
    }

    // Getters and Setters for address 0x1138:0x4F74/0x162F4.
    // Operation not registered by running code
    public int Get1138_4F74_Byte8() {
        return GetUint8(0x4F74);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F74_Byte8(byte value) {
        SetUint8(0x4F74, value);
    }

    // Getters and Setters for address 0x1138:0x4F75/0x162F5.
    // Operation not registered by running code
    public int Get1138_4F75_Byte8() {
        return GetUint8(0x4F75);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F75_Byte8(byte value) {
        SetUint8(0x4F75, value);
    }

    // Getters and Setters for address 0x1138:0x4F76/0x162F6.
    // Operation not registered by running code
    public int Get1138_4F76_Byte8() {
        return GetUint8(0x4F76);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F76_Byte8(byte value) {
        SetUint8(0x4F76, value);
    }

    // Getters and Setters for address 0x1138:0x4F77/0x162F7.
    // Operation not registered by running code
    public int Get1138_4F77_Byte8() {
        return GetUint8(0x4F77);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F77_Byte8(byte value) {
        SetUint8(0x4F77, value);
    }

    // Getters and Setters for address 0x1138:0x4F78/0x162F8.
    // Operation not registered by running code
    public int Get1138_4F78_Byte8() {
        return GetUint8(0x4F78);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F78_Byte8(byte value) {
        SetUint8(0x4F78, value);
    }

    // Getters and Setters for address 0x1138:0x4F79/0x162F9.
    // Operation not registered by running code
    public int Get1138_4F79_Byte8() {
        return GetUint8(0x4F79);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F79_Byte8(byte value) {
        SetUint8(0x4F79, value);
    }

    // Getters and Setters for address 0x1138:0x4F7A/0x162FA.
    // Operation not registered by running code
    public int Get1138_4F7A_Byte8() {
        return GetUint8(0x4F7A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F7A_Byte8(byte value) {
        SetUint8(0x4F7A, value);
    }

    // Getters and Setters for address 0x1138:0x4F7B/0x162FB.
    // Operation not registered by running code
    public int Get1138_4F7B_Byte8() {
        return GetUint8(0x4F7B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F7B_Byte8(byte value) {
        SetUint8(0x4F7B, value);
    }

    // Getters and Setters for address 0x1138:0x4F7C/0x162FC.
    // Operation not registered by running code
    public int Get1138_4F7C_Byte8() {
        return GetUint8(0x4F7C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F7C_Byte8(byte value) {
        SetUint8(0x4F7C, value);
    }

    // Getters and Setters for address 0x1138:0x4F7D/0x162FD.
    // Operation not registered by running code
    public int Get1138_4F7D_Byte8() {
        return GetUint8(0x4F7D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F7D_Byte8(byte value) {
        SetUint8(0x4F7D, value);
    }

    // Getters and Setters for address 0x1138:0x4F7E/0x162FE.
    // Operation not registered by running code
    public int Get1138_4F7E_Byte8() {
        return GetUint8(0x4F7E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F7E_Byte8(byte value) {
        SetUint8(0x4F7E, value);
    }

    // Getters and Setters for address 0x1138:0x4F7F/0x162FF.
    // Operation not registered by running code
    public int Get1138_4F7F_Byte8() {
        return GetUint8(0x4F7F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F7F_Byte8(byte value) {
        SetUint8(0x4F7F, value);
    }

    // Getters and Setters for address 0x1138:0x4F80/0x16300.
    // Operation not registered by running code
    public int Get1138_4F80_Byte8() {
        return GetUint8(0x4F80);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F80_Byte8(byte value) {
        SetUint8(0x4F80, value);
    }

    // Getters and Setters for address 0x1138:0x4F81/0x16301.
    // Operation not registered by running code
    public int Get1138_4F81_Byte8() {
        return GetUint8(0x4F81);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F81_Byte8(byte value) {
        SetUint8(0x4F81, value);
    }

    // Getters and Setters for address 0x1138:0x4F82/0x16302.
    // Operation not registered by running code
    public int Get1138_4F82_Byte8() {
        return GetUint8(0x4F82);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F82_Byte8(byte value) {
        SetUint8(0x4F82, value);
    }

    // Getters and Setters for address 0x1138:0x4F83/0x16303.
    // Operation not registered by running code
    public int Get1138_4F83_Byte8() {
        return GetUint8(0x4F83);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F83_Byte8(byte value) {
        SetUint8(0x4F83, value);
    }

    // Getters and Setters for address 0x1138:0x4F84/0x16304.
    // Operation not registered by running code
    public int Get1138_4F84_Byte8() {
        return GetUint8(0x4F84);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F84_Byte8(byte value) {
        SetUint8(0x4F84, value);
    }

    // Getters and Setters for address 0x1138:0x4F85/0x16305.
    // Operation not registered by running code
    public int Get1138_4F85_Byte8() {
        return GetUint8(0x4F85);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F85_Byte8(byte value) {
        SetUint8(0x4F85, value);
    }

    // Getters and Setters for address 0x1138:0x4F86/0x16306.
    // Operation not registered by running code
    public int Get1138_4F86_Byte8() {
        return GetUint8(0x4F86);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F86_Byte8(byte value) {
        SetUint8(0x4F86, value);
    }

    // Getters and Setters for address 0x1138:0x4F87/0x16307.
    // Operation not registered by running code
    public int Get1138_4F87_Byte8() {
        return GetUint8(0x4F87);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F87_Byte8(byte value) {
        SetUint8(0x4F87, value);
    }

    // Getters and Setters for address 0x1138:0x4F88/0x16308.
    // Operation not registered by running code
    public int Get1138_4F88_Byte8() {
        return GetUint8(0x4F88);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F88_Byte8(byte value) {
        SetUint8(0x4F88, value);
    }

    // Getters and Setters for address 0x1138:0x4F89/0x16309.
    // Operation not registered by running code
    public int Get1138_4F89_Byte8() {
        return GetUint8(0x4F89);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F89_Byte8(byte value) {
        SetUint8(0x4F89, value);
    }

    // Getters and Setters for address 0x1138:0x4F8A/0x1630A.
    // Operation not registered by running code
    public int Get1138_4F8A_Byte8() {
        return GetUint8(0x4F8A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F8A_Byte8(byte value) {
        SetUint8(0x4F8A, value);
    }

    // Getters and Setters for address 0x1138:0x4F8B/0x1630B.
    // Operation not registered by running code
    public int Get1138_4F8B_Byte8() {
        return GetUint8(0x4F8B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F8B_Byte8(byte value) {
        SetUint8(0x4F8B, value);
    }

    // Getters and Setters for address 0x1138:0x4F8C/0x1630C.
    // Operation not registered by running code
    public int Get1138_4F8C_Byte8() {
        return GetUint8(0x4F8C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F8C_Byte8(byte value) {
        SetUint8(0x4F8C, value);
    }

    // Getters and Setters for address 0x1138:0x4F8D/0x1630D.
    // Operation not registered by running code
    public int Get1138_4F8D_Byte8() {
        return GetUint8(0x4F8D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F8D_Byte8(byte value) {
        SetUint8(0x4F8D, value);
    }

    // Getters and Setters for address 0x1138:0x4F8E/0x1630E.
    // Operation not registered by running code
    public int Get1138_4F8E_Byte8() {
        return GetUint8(0x4F8E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F8E_Byte8(byte value) {
        SetUint8(0x4F8E, value);
    }

    // Getters and Setters for address 0x1138:0x4F8F/0x1630F.
    // Operation not registered by running code
    public int Get1138_4F8F_Byte8() {
        return GetUint8(0x4F8F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F8F_Byte8(byte value) {
        SetUint8(0x4F8F, value);
    }

    // Getters and Setters for address 0x1138:0x4F90/0x16310.
    // Operation not registered by running code
    public int Get1138_4F90_Byte8() {
        return GetUint8(0x4F90);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F90_Byte8(byte value) {
        SetUint8(0x4F90, value);
    }

    // Getters and Setters for address 0x1138:0x4F91/0x16311.
    // Operation not registered by running code
    public int Get1138_4F91_Byte8() {
        return GetUint8(0x4F91);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F91_Byte8(byte value) {
        SetUint8(0x4F91, value);
    }

    // Getters and Setters for address 0x1138:0x4F92/0x16312.
    // Operation not registered by running code
    public int Get1138_4F92_Byte8() {
        return GetUint8(0x4F92);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F92_Byte8(byte value) {
        SetUint8(0x4F92, value);
    }

    // Getters and Setters for address 0x1138:0x4F93/0x16313.
    // Operation not registered by running code
    public int Get1138_4F93_Byte8() {
        return GetUint8(0x4F93);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F93_Byte8(byte value) {
        SetUint8(0x4F93, value);
    }

    // Getters and Setters for address 0x1138:0x4F94/0x16314.
    // Operation not registered by running code
    public int Get1138_4F94_Byte8() {
        return GetUint8(0x4F94);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F94_Byte8(byte value) {
        SetUint8(0x4F94, value);
    }

    // Getters and Setters for address 0x1138:0x4F95/0x16315.
    // Operation not registered by running code
    public int Get1138_4F95_Byte8() {
        return GetUint8(0x4F95);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F95_Byte8(byte value) {
        SetUint8(0x4F95, value);
    }

    // Getters and Setters for address 0x1138:0x4F96/0x16316.
    // Operation not registered by running code
    public int Get1138_4F96_Byte8() {
        return GetUint8(0x4F96);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F96_Byte8(byte value) {
        SetUint8(0x4F96, value);
    }

    // Getters and Setters for address 0x1138:0x4F97/0x16317.
    // Operation not registered by running code
    public int Get1138_4F97_Byte8() {
        return GetUint8(0x4F97);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F97_Byte8(byte value) {
        SetUint8(0x4F97, value);
    }

    // Getters and Setters for address 0x1138:0x4F98/0x16318.
    // Operation not registered by running code
    public int Get1138_4F98_Byte8() {
        return GetUint8(0x4F98);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F98_Byte8(byte value) {
        SetUint8(0x4F98, value);
    }

    // Getters and Setters for address 0x1138:0x4F99/0x16319.
    // Operation not registered by running code
    public int Get1138_4F99_Byte8() {
        return GetUint8(0x4F99);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F99_Byte8(byte value) {
        SetUint8(0x4F99, value);
    }

    // Getters and Setters for address 0x1138:0x4F9A/0x1631A.
    // Operation not registered by running code
    public int Get1138_4F9A_Byte8() {
        return GetUint8(0x4F9A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F9A_Byte8(byte value) {
        SetUint8(0x4F9A, value);
    }

    // Getters and Setters for address 0x1138:0x4F9B/0x1631B.
    // Operation not registered by running code
    public int Get1138_4F9B_Byte8() {
        return GetUint8(0x4F9B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F9B_Byte8(byte value) {
        SetUint8(0x4F9B, value);
    }

    // Getters and Setters for address 0x1138:0x4F9C/0x1631C.
    // Operation not registered by running code
    public int Get1138_4F9C_Byte8() {
        return GetUint8(0x4F9C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F9C_Byte8(byte value) {
        SetUint8(0x4F9C, value);
    }

    // Getters and Setters for address 0x1138:0x4F9D/0x1631D.
    // Operation not registered by running code
    public int Get1138_4F9D_Byte8() {
        return GetUint8(0x4F9D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F9D_Byte8(byte value) {
        SetUint8(0x4F9D, value);
    }

    // Getters and Setters for address 0x1138:0x4F9E/0x1631E.
    // Operation not registered by running code
    public int Get1138_4F9E_Byte8() {
        return GetUint8(0x4F9E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F9E_Byte8(byte value) {
        SetUint8(0x4F9E, value);
    }

    // Getters and Setters for address 0x1138:0x4F9F/0x1631F.
    // Operation not registered by running code
    public int Get1138_4F9F_Byte8() {
        return GetUint8(0x4F9F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4F9F_Byte8(byte value) {
        SetUint8(0x4F9F, value);
    }

    // Getters and Setters for address 0x1138:0x4FA0/0x16320.
    // Operation not registered by running code
    public int Get1138_4FA0_Byte8() {
        return GetUint8(0x4FA0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FA0_Byte8(byte value) {
        SetUint8(0x4FA0, value);
    }

    // Getters and Setters for address 0x1138:0x4FA1/0x16321.
    // Operation not registered by running code
    public int Get1138_4FA1_Byte8() {
        return GetUint8(0x4FA1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FA1_Byte8(byte value) {
        SetUint8(0x4FA1, value);
    }

    // Getters and Setters for address 0x1138:0x4FA2/0x16322.
    // Operation not registered by running code
    public int Get1138_4FA2_Byte8() {
        return GetUint8(0x4FA2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FA2_Byte8(byte value) {
        SetUint8(0x4FA2, value);
    }

    // Getters and Setters for address 0x1138:0x4FA3/0x16323.
    // Operation not registered by running code
    public int Get1138_4FA3_Byte8() {
        return GetUint8(0x4FA3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FA3_Byte8(byte value) {
        SetUint8(0x4FA3, value);
    }

    // Getters and Setters for address 0x1138:0x4FA4/0x16324.
    // Operation not registered by running code
    public int Get1138_4FA4_Byte8() {
        return GetUint8(0x4FA4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FA4_Byte8(byte value) {
        SetUint8(0x4FA4, value);
    }

    // Getters and Setters for address 0x1138:0x4FA5/0x16325.
    // Operation not registered by running code
    public int Get1138_4FA5_Byte8() {
        return GetUint8(0x4FA5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FA5_Byte8(byte value) {
        SetUint8(0x4FA5, value);
    }

    // Getters and Setters for address 0x1138:0x4FA6/0x16326.
    // Operation not registered by running code
    public int Get1138_4FA6_Byte8() {
        return GetUint8(0x4FA6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FA6_Byte8(byte value) {
        SetUint8(0x4FA6, value);
    }

    // Getters and Setters for address 0x1138:0x4FA7/0x16327.
    // Operation not registered by running code
    public int Get1138_4FA7_Byte8() {
        return GetUint8(0x4FA7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FA7_Byte8(byte value) {
        SetUint8(0x4FA7, value);
    }

    // Getters and Setters for address 0x1138:0x4FA8/0x16328.
    // Operation not registered by running code
    public int Get1138_4FA8_Byte8() {
        return GetUint8(0x4FA8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FA8_Byte8(byte value) {
        SetUint8(0x4FA8, value);
    }

    // Getters and Setters for address 0x1138:0x4FA9/0x16329.
    // Operation not registered by running code
    public int Get1138_4FA9_Byte8() {
        return GetUint8(0x4FA9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FA9_Byte8(byte value) {
        SetUint8(0x4FA9, value);
    }

    // Getters and Setters for address 0x1138:0x4FAA/0x1632A.
    // Operation not registered by running code
    public int Get1138_4FAA_Byte8() {
        return GetUint8(0x4FAA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FAA_Byte8(byte value) {
        SetUint8(0x4FAA, value);
    }

    // Getters and Setters for address 0x1138:0x4FAB/0x1632B.
    // Operation not registered by running code
    public int Get1138_4FAB_Byte8() {
        return GetUint8(0x4FAB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FAB_Byte8(byte value) {
        SetUint8(0x4FAB, value);
    }

    // Getters and Setters for address 0x1138:0x4FAC/0x1632C.
    // Operation not registered by running code
    public int Get1138_4FAC_Byte8() {
        return GetUint8(0x4FAC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FAC_Byte8(byte value) {
        SetUint8(0x4FAC, value);
    }

    // Getters and Setters for address 0x1138:0x4FAD/0x1632D.
    // Operation not registered by running code
    public int Get1138_4FAD_Byte8() {
        return GetUint8(0x4FAD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FAD_Byte8(byte value) {
        SetUint8(0x4FAD, value);
    }

    // Getters and Setters for address 0x1138:0x4FAE/0x1632E.
    // Operation not registered by running code
    public int Get1138_4FAE_Byte8() {
        return GetUint8(0x4FAE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FAE_Byte8(byte value) {
        SetUint8(0x4FAE, value);
    }

    // Getters and Setters for address 0x1138:0x4FAF/0x1632F.
    // Operation not registered by running code
    public int Get1138_4FAF_Byte8() {
        return GetUint8(0x4FAF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FAF_Byte8(byte value) {
        SetUint8(0x4FAF, value);
    }

    // Getters and Setters for address 0x1138:0x4FB0/0x16330.
    // Operation not registered by running code
    public int Get1138_4FB0_Byte8() {
        return GetUint8(0x4FB0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FB0_Byte8(byte value) {
        SetUint8(0x4FB0, value);
    }

    // Getters and Setters for address 0x1138:0x4FB1/0x16331.
    // Operation not registered by running code
    public int Get1138_4FB1_Byte8() {
        return GetUint8(0x4FB1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FB1_Byte8(byte value) {
        SetUint8(0x4FB1, value);
    }

    // Getters and Setters for address 0x1138:0x4FB2/0x16332.
    // Operation not registered by running code
    public int Get1138_4FB2_Byte8() {
        return GetUint8(0x4FB2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FB2_Byte8(byte value) {
        SetUint8(0x4FB2, value);
    }

    // Getters and Setters for address 0x1138:0x4FB3/0x16333.
    // Operation not registered by running code
    public int Get1138_4FB3_Byte8() {
        return GetUint8(0x4FB3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FB3_Byte8(byte value) {
        SetUint8(0x4FB3, value);
    }

    // Getters and Setters for address 0x1138:0x4FB4/0x16334.
    // Operation not registered by running code
    public int Get1138_4FB4_Byte8() {
        return GetUint8(0x4FB4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FB4_Byte8(byte value) {
        SetUint8(0x4FB4, value);
    }

    // Getters and Setters for address 0x1138:0x4FB5/0x16335.
    // Operation not registered by running code
    public int Get1138_4FB5_Byte8() {
        return GetUint8(0x4FB5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FB5_Byte8(byte value) {
        SetUint8(0x4FB5, value);
    }

    // Getters and Setters for address 0x1138:0x4FB6/0x16336.
    // Operation not registered by running code
    public int Get1138_4FB6_Byte8() {
        return GetUint8(0x4FB6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FB6_Byte8(byte value) {
        SetUint8(0x4FB6, value);
    }

    // Getters and Setters for address 0x1138:0x4FB7/0x16337.
    // Operation not registered by running code
    public int Get1138_4FB7_Byte8() {
        return GetUint8(0x4FB7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FB7_Byte8(byte value) {
        SetUint8(0x4FB7, value);
    }

    // Getters and Setters for address 0x1138:0x4FB8/0x16338.
    // Operation not registered by running code
    public int Get1138_4FB8_Byte8() {
        return GetUint8(0x4FB8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FB8_Byte8(byte value) {
        SetUint8(0x4FB8, value);
    }

    // Getters and Setters for address 0x1138:0x4FB9/0x16339.
    // Operation not registered by running code
    public int Get1138_4FB9_Byte8() {
        return GetUint8(0x4FB9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FB9_Byte8(byte value) {
        SetUint8(0x4FB9, value);
    }

    // Getters and Setters for address 0x1138:0x4FBA/0x1633A.
    // Operation not registered by running code
    public int Get1138_4FBA_Byte8() {
        return GetUint8(0x4FBA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FBA_Byte8(byte value) {
        SetUint8(0x4FBA, value);
    }

    // Getters and Setters for address 0x1138:0x4FBB/0x1633B.
    // Operation not registered by running code
    public int Get1138_4FBB_Byte8() {
        return GetUint8(0x4FBB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FBB_Byte8(byte value) {
        SetUint8(0x4FBB, value);
    }

    // Getters and Setters for address 0x1138:0x4FBC/0x1633C.
    // Operation not registered by running code
    public int Get1138_4FBC_Byte8() {
        return GetUint8(0x4FBC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FBC_Byte8(byte value) {
        SetUint8(0x4FBC, value);
    }

    // Getters and Setters for address 0x1138:0x4FBD/0x1633D.
    // Operation not registered by running code
    public int Get1138_4FBD_Byte8() {
        return GetUint8(0x4FBD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FBD_Byte8(byte value) {
        SetUint8(0x4FBD, value);
    }

    // Getters and Setters for address 0x1138:0x4FBE/0x1633E.
    // Operation not registered by running code
    public int Get1138_4FBE_Byte8() {
        return GetUint8(0x4FBE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FBE_Byte8(byte value) {
        SetUint8(0x4FBE, value);
    }

    // Getters and Setters for address 0x1138:0x4FBF/0x1633F.
    // Operation not registered by running code
    public int Get1138_4FBF_Byte8() {
        return GetUint8(0x4FBF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FBF_Byte8(byte value) {
        SetUint8(0x4FBF, value);
    }

    // Getters and Setters for address 0x1138:0x4FC0/0x16340.
    // Operation not registered by running code
    public int Get1138_4FC0_Byte8() {
        return GetUint8(0x4FC0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FC0_Byte8(byte value) {
        SetUint8(0x4FC0, value);
    }

    // Getters and Setters for address 0x1138:0x4FC1/0x16341.
    // Operation not registered by running code
    public int Get1138_4FC1_Byte8() {
        return GetUint8(0x4FC1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FC1_Byte8(byte value) {
        SetUint8(0x4FC1, value);
    }

    // Getters and Setters for address 0x1138:0x4FC2/0x16342.
    // Operation not registered by running code
    public int Get1138_4FC2_Byte8() {
        return GetUint8(0x4FC2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FC2_Byte8(byte value) {
        SetUint8(0x4FC2, value);
    }

    // Getters and Setters for address 0x1138:0x4FC3/0x16343.
    // Operation not registered by running code
    public int Get1138_4FC3_Byte8() {
        return GetUint8(0x4FC3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FC3_Byte8(byte value) {
        SetUint8(0x4FC3, value);
    }

    // Getters and Setters for address 0x1138:0x4FC4/0x16344.
    // Operation not registered by running code
    public int Get1138_4FC4_Byte8() {
        return GetUint8(0x4FC4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FC4_Byte8(byte value) {
        SetUint8(0x4FC4, value);
    }

    // Getters and Setters for address 0x1138:0x4FC5/0x16345.
    // Operation not registered by running code
    public int Get1138_4FC5_Byte8() {
        return GetUint8(0x4FC5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FC5_Byte8(byte value) {
        SetUint8(0x4FC5, value);
    }

    // Getters and Setters for address 0x1138:0x4FC6/0x16346.
    // Operation not registered by running code
    public int Get1138_4FC6_Byte8() {
        return GetUint8(0x4FC6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FC6_Byte8(byte value) {
        SetUint8(0x4FC6, value);
    }

    // Getters and Setters for address 0x1138:0x4FC7/0x16347.
    // Operation not registered by running code
    public int Get1138_4FC7_Byte8() {
        return GetUint8(0x4FC7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FC7_Byte8(byte value) {
        SetUint8(0x4FC7, value);
    }

    // Getters and Setters for address 0x1138:0x4FC8/0x16348.
    // Operation not registered by running code
    public int Get1138_4FC8_Byte8() {
        return GetUint8(0x4FC8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FC8_Byte8(byte value) {
        SetUint8(0x4FC8, value);
    }

    // Getters and Setters for address 0x1138:0x4FC9/0x16349.
    // Operation not registered by running code
    public int Get1138_4FC9_Byte8() {
        return GetUint8(0x4FC9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FC9_Byte8(byte value) {
        SetUint8(0x4FC9, value);
    }

    // Getters and Setters for address 0x1138:0x4FCA/0x1634A.
    // Operation not registered by running code
    public int Get1138_4FCA_Byte8() {
        return GetUint8(0x4FCA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FCA_Byte8(byte value) {
        SetUint8(0x4FCA, value);
    }

    // Getters and Setters for address 0x1138:0x4FCB/0x1634B.
    // Operation not registered by running code
    public int Get1138_4FCB_Byte8() {
        return GetUint8(0x4FCB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FCB_Byte8(byte value) {
        SetUint8(0x4FCB, value);
    }

    // Getters and Setters for address 0x1138:0x4FCC/0x1634C.
    // Operation not registered by running code
    public int Get1138_4FCC_Byte8() {
        return GetUint8(0x4FCC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FCC_Byte8(byte value) {
        SetUint8(0x4FCC, value);
    }

    // Getters and Setters for address 0x1138:0x4FCD/0x1634D.
    // Operation not registered by running code
    public int Get1138_4FCD_Byte8() {
        return GetUint8(0x4FCD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FCD_Byte8(byte value) {
        SetUint8(0x4FCD, value);
    }

    // Getters and Setters for address 0x1138:0x4FCE/0x1634E.
    // Operation not registered by running code
    public int Get1138_4FCE_Byte8() {
        return GetUint8(0x4FCE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FCE_Byte8(byte value) {
        SetUint8(0x4FCE, value);
    }

    // Getters and Setters for address 0x1138:0x4FCF/0x1634F.
    // Operation not registered by running code
    public int Get1138_4FCF_Byte8() {
        return GetUint8(0x4FCF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FCF_Byte8(byte value) {
        SetUint8(0x4FCF, value);
    }

    // Getters and Setters for address 0x1138:0x4FD0/0x16350.
    // Operation not registered by running code
    public int Get1138_4FD0_Byte8() {
        return GetUint8(0x4FD0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FD0_Byte8(byte value) {
        SetUint8(0x4FD0, value);
    }

    // Getters and Setters for address 0x1138:0x4FD1/0x16351.
    // Operation not registered by running code
    public int Get1138_4FD1_Byte8() {
        return GetUint8(0x4FD1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FD1_Byte8(byte value) {
        SetUint8(0x4FD1, value);
    }

    // Getters and Setters for address 0x1138:0x4FD2/0x16352.
    // Operation not registered by running code
    public int Get1138_4FD2_Byte8() {
        return GetUint8(0x4FD2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FD2_Byte8(byte value) {
        SetUint8(0x4FD2, value);
    }

    // Getters and Setters for address 0x1138:0x4FD3/0x16353.
    // Operation not registered by running code
    public int Get1138_4FD3_Byte8() {
        return GetUint8(0x4FD3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FD3_Byte8(byte value) {
        SetUint8(0x4FD3, value);
    }

    // Getters and Setters for address 0x1138:0x4FD4/0x16354.
    // Operation not registered by running code
    public int Get1138_4FD4_Byte8() {
        return GetUint8(0x4FD4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FD4_Byte8(byte value) {
        SetUint8(0x4FD4, value);
    }

    // Getters and Setters for address 0x1138:0x4FD5/0x16355.
    // Operation not registered by running code
    public int Get1138_4FD5_Byte8() {
        return GetUint8(0x4FD5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FD5_Byte8(byte value) {
        SetUint8(0x4FD5, value);
    }

    // Getters and Setters for address 0x1138:0x4FD6/0x16356.
    // Operation not registered by running code
    public int Get1138_4FD6_Byte8() {
        return GetUint8(0x4FD6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FD6_Byte8(byte value) {
        SetUint8(0x4FD6, value);
    }

    // Getters and Setters for address 0x1138:0x4FD7/0x16357.
    // Operation not registered by running code
    public int Get1138_4FD7_Byte8() {
        return GetUint8(0x4FD7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FD7_Byte8(byte value) {
        SetUint8(0x4FD7, value);
    }

    // Getters and Setters for address 0x1138:0x4FD8/0x16358.
    // Operation not registered by running code
    public int Get1138_4FD8_Byte8() {
        return GetUint8(0x4FD8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FD8_Byte8(byte value) {
        SetUint8(0x4FD8, value);
    }

    // Getters and Setters for address 0x1138:0x4FD9/0x16359.
    // Operation not registered by running code
    public int Get1138_4FD9_Byte8() {
        return GetUint8(0x4FD9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FD9_Byte8(byte value) {
        SetUint8(0x4FD9, value);
    }

    // Getters and Setters for address 0x1138:0x4FDA/0x1635A.
    // Operation not registered by running code
    public int Get1138_4FDA_Byte8() {
        return GetUint8(0x4FDA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FDA_Byte8(byte value) {
        SetUint8(0x4FDA, value);
    }

    // Getters and Setters for address 0x1138:0x4FDB/0x1635B.
    // Operation not registered by running code
    public int Get1138_4FDB_Byte8() {
        return GetUint8(0x4FDB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_4FDB_Byte8(byte value) {
        SetUint8(0x4FDB, value);
    }

    // Getters and Setters for address 0x1138:0x5199/0x16519.
    // Operation not registered by running code
    public int Get1138_5199_Byte8() {
        return GetUint8(0x5199);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5199_Byte8(byte value) {
        SetUint8(0x5199, value);
    }

    // Getters and Setters for address 0x1138:0x519A/0x1651A.
    // Operation not registered by running code
    public int Get1138_519A_Byte8() {
        return GetUint8(0x519A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_519A_Byte8(byte value) {
        SetUint8(0x519A, value);
    }

    // Getters and Setters for address 0x1138:0x519B/0x1651B.
    // Operation not registered by running code
    public int Get1138_519B_Byte8() {
        return GetUint8(0x519B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_519B_Byte8(byte value) {
        SetUint8(0x519B, value);
    }

    // Getters and Setters for address 0x1138:0x519C/0x1651C.
    // Operation not registered by running code
    public int Get1138_519C_Byte8() {
        return GetUint8(0x519C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_519C_Byte8(byte value) {
        SetUint8(0x519C, value);
    }

    // Getters and Setters for address 0x1138:0x519D/0x1651D.
    // Operation not registered by running code
    public int Get1138_519D_Byte8() {
        return GetUint8(0x519D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_519D_Byte8(byte value) {
        SetUint8(0x519D, value);
    }

    // Getters and Setters for address 0x1138:0x519E/0x1651E.
    // Operation not registered by running code
    public int Get1138_519E_Byte8() {
        return GetUint8(0x519E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_519E_Byte8(byte value) {
        SetUint8(0x519E, value);
    }

    // Getters and Setters for address 0x1138:0x519F/0x1651F.
    // Operation not registered by running code
    public int Get1138_519F_Byte8() {
        return GetUint8(0x519F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_519F_Byte8(byte value) {
        SetUint8(0x519F, value);
    }

    // Getters and Setters for address 0x1138:0x51A0/0x16520.
    // Operation not registered by running code
    public int Get1138_51A0_Byte8() {
        return GetUint8(0x51A0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51A0_Byte8(byte value) {
        SetUint8(0x51A0, value);
    }

    // Getters and Setters for address 0x1138:0x51A1/0x16521.
    // Operation not registered by running code
    public int Get1138_51A1_Byte8() {
        return GetUint8(0x51A1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51A1_Byte8(byte value) {
        SetUint8(0x51A1, value);
    }

    // Getters and Setters for address 0x1138:0x51A2/0x16522.
    // Operation not registered by running code
    public int Get1138_51A2_Byte8() {
        return GetUint8(0x51A2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51A2_Byte8(byte value) {
        SetUint8(0x51A2, value);
    }

    // Getters and Setters for address 0x1138:0x51A3/0x16523.
    // Operation not registered by running code
    public int Get1138_51A3_Byte8() {
        return GetUint8(0x51A3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51A3_Byte8(byte value) {
        SetUint8(0x51A3, value);
    }

    // Getters and Setters for address 0x1138:0x51A4/0x16524.
    // Operation not registered by running code
    public int Get1138_51A4_Byte8() {
        return GetUint8(0x51A4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51A4_Byte8(byte value) {
        SetUint8(0x51A4, value);
    }

    // Getters and Setters for address 0x1138:0x51A5/0x16525.
    // Operation not registered by running code
    public int Get1138_51A5_Byte8() {
        return GetUint8(0x51A5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51A5_Byte8(byte value) {
        SetUint8(0x51A5, value);
    }

    // Getters and Setters for address 0x1138:0x51A6/0x16526.
    // Operation not registered by running code
    public int Get1138_51A6_Byte8() {
        return GetUint8(0x51A6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51A6_Byte8(byte value) {
        SetUint8(0x51A6, value);
    }

    // Getters and Setters for address 0x1138:0x51A7/0x16527.
    // Operation not registered by running code
    public int Get1138_51A7_Byte8() {
        return GetUint8(0x51A7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51A7_Byte8(byte value) {
        SetUint8(0x51A7, value);
    }

    // Getters and Setters for address 0x1138:0x51A8/0x16528.
    // Operation not registered by running code
    public int Get1138_51A8_Byte8() {
        return GetUint8(0x51A8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51A8_Byte8(byte value) {
        SetUint8(0x51A8, value);
    }

    // Getters and Setters for address 0x1138:0x51A9/0x16529.
    // Operation not registered by running code
    public int Get1138_51A9_Byte8() {
        return GetUint8(0x51A9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51A9_Byte8(byte value) {
        SetUint8(0x51A9, value);
    }

    // Getters and Setters for address 0x1138:0x51AA/0x1652A.
    // Operation not registered by running code
    public int Get1138_51AA_Byte8() {
        return GetUint8(0x51AA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51AA_Byte8(byte value) {
        SetUint8(0x51AA, value);
    }

    // Getters and Setters for address 0x1138:0x51AB/0x1652B.
    // Operation not registered by running code
    public int Get1138_51AB_Byte8() {
        return GetUint8(0x51AB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51AB_Byte8(byte value) {
        SetUint8(0x51AB, value);
    }

    // Getters and Setters for address 0x1138:0x51AC/0x1652C.
    // Operation not registered by running code
    public int Get1138_51AC_Byte8() {
        return GetUint8(0x51AC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51AC_Byte8(byte value) {
        SetUint8(0x51AC, value);
    }

    // Getters and Setters for address 0x1138:0x51AD/0x1652D.
    // Operation not registered by running code
    public int Get1138_51AD_Byte8() {
        return GetUint8(0x51AD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51AD_Byte8(byte value) {
        SetUint8(0x51AD, value);
    }

    // Getters and Setters for address 0x1138:0x51AE/0x1652E.
    // Operation not registered by running code
    public int Get1138_51AE_Byte8() {
        return GetUint8(0x51AE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51AE_Byte8(byte value) {
        SetUint8(0x51AE, value);
    }

    // Getters and Setters for address 0x1138:0x51AF/0x1652F.
    // Operation not registered by running code
    public int Get1138_51AF_Byte8() {
        return GetUint8(0x51AF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51AF_Byte8(byte value) {
        SetUint8(0x51AF, value);
    }

    // Getters and Setters for address 0x1138:0x51B0/0x16530.
    // Operation not registered by running code
    public int Get1138_51B0_Byte8() {
        return GetUint8(0x51B0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51B0_Byte8(byte value) {
        SetUint8(0x51B0, value);
    }

    // Getters and Setters for address 0x1138:0x51B1/0x16531.
    // Operation not registered by running code
    public int Get1138_51B1_Byte8() {
        return GetUint8(0x51B1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51B1_Byte8(byte value) {
        SetUint8(0x51B1, value);
    }

    // Getters and Setters for address 0x1138:0x51B2/0x16532.
    // Operation not registered by running code
    public int Get1138_51B2_Byte8() {
        return GetUint8(0x51B2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51B2_Byte8(byte value) {
        SetUint8(0x51B2, value);
    }

    // Getters and Setters for address 0x1138:0x51B3/0x16533.
    // Operation not registered by running code
    public int Get1138_51B3_Byte8() {
        return GetUint8(0x51B3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51B3_Byte8(byte value) {
        SetUint8(0x51B3, value);
    }

    // Getters and Setters for address 0x1138:0x51B4/0x16534.
    // Operation not registered by running code
    public int Get1138_51B4_Byte8() {
        return GetUint8(0x51B4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51B4_Byte8(byte value) {
        SetUint8(0x51B4, value);
    }

    // Getters and Setters for address 0x1138:0x51B5/0x16535.
    // Operation not registered by running code
    public int Get1138_51B5_Byte8() {
        return GetUint8(0x51B5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51B5_Byte8(byte value) {
        SetUint8(0x51B5, value);
    }

    // Getters and Setters for address 0x1138:0x51B6/0x16536.
    // Operation not registered by running code
    public int Get1138_51B6_Byte8() {
        return GetUint8(0x51B6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51B6_Byte8(byte value) {
        SetUint8(0x51B6, value);
    }

    // Getters and Setters for address 0x1138:0x51B7/0x16537.
    // Operation not registered by running code
    public int Get1138_51B7_Byte8() {
        return GetUint8(0x51B7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51B7_Byte8(byte value) {
        SetUint8(0x51B7, value);
    }

    // Getters and Setters for address 0x1138:0x51B8/0x16538.
    // Operation not registered by running code
    public int Get1138_51B8_Byte8() {
        return GetUint8(0x51B8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51B8_Byte8(byte value) {
        SetUint8(0x51B8, value);
    }

    // Getters and Setters for address 0x1138:0x51B9/0x16539.
    // Operation not registered by running code
    public int Get1138_51B9_Byte8() {
        return GetUint8(0x51B9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51B9_Byte8(byte value) {
        SetUint8(0x51B9, value);
    }

    // Getters and Setters for address 0x1138:0x51BA/0x1653A.
    // Operation not registered by running code
    public int Get1138_51BA_Byte8() {
        return GetUint8(0x51BA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51BA_Byte8(byte value) {
        SetUint8(0x51BA, value);
    }

    // Getters and Setters for address 0x1138:0x51BB/0x1653B.
    // Operation not registered by running code
    public int Get1138_51BB_Byte8() {
        return GetUint8(0x51BB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51BB_Byte8(byte value) {
        SetUint8(0x51BB, value);
    }

    // Getters and Setters for address 0x1138:0x51BC/0x1653C.
    // Operation not registered by running code
    public int Get1138_51BC_Byte8() {
        return GetUint8(0x51BC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51BC_Byte8(byte value) {
        SetUint8(0x51BC, value);
    }

    // Getters and Setters for address 0x1138:0x51BD/0x1653D.
    // Operation not registered by running code
    public int Get1138_51BD_Byte8() {
        return GetUint8(0x51BD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51BD_Byte8(byte value) {
        SetUint8(0x51BD, value);
    }

    // Getters and Setters for address 0x1138:0x51BE/0x1653E.
    // Operation not registered by running code
    public int Get1138_51BE_Byte8() {
        return GetUint8(0x51BE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51BE_Byte8(byte value) {
        SetUint8(0x51BE, value);
    }

    // Getters and Setters for address 0x1138:0x51BF/0x1653F.
    // Operation not registered by running code
    public int Get1138_51BF_Byte8() {
        return GetUint8(0x51BF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51BF_Byte8(byte value) {
        SetUint8(0x51BF, value);
    }

    // Getters and Setters for address 0x1138:0x51C0/0x16540.
    // Operation not registered by running code
    public int Get1138_51C0_Byte8() {
        return GetUint8(0x51C0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51C0_Byte8(byte value) {
        SetUint8(0x51C0, value);
    }

    // Getters and Setters for address 0x1138:0x51C1/0x16541.
    // Operation not registered by running code
    public int Get1138_51C1_Byte8() {
        return GetUint8(0x51C1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51C1_Byte8(byte value) {
        SetUint8(0x51C1, value);
    }

    // Getters and Setters for address 0x1138:0x51C2/0x16542.
    // Operation not registered by running code
    public int Get1138_51C2_Byte8() {
        return GetUint8(0x51C2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51C2_Byte8(byte value) {
        SetUint8(0x51C2, value);
    }

    // Getters and Setters for address 0x1138:0x51C3/0x16543.
    // Operation not registered by running code
    public int Get1138_51C3_Byte8() {
        return GetUint8(0x51C3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51C3_Byte8(byte value) {
        SetUint8(0x51C3, value);
    }

    // Getters and Setters for address 0x1138:0x51C4/0x16544.
    // Operation not registered by running code
    public int Get1138_51C4_Byte8() {
        return GetUint8(0x51C4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51C4_Byte8(byte value) {
        SetUint8(0x51C4, value);
    }

    // Getters and Setters for address 0x1138:0x51C5/0x16545.
    // Operation not registered by running code
    public int Get1138_51C5_Byte8() {
        return GetUint8(0x51C5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51C5_Byte8(byte value) {
        SetUint8(0x51C5, value);
    }

    // Getters and Setters for address 0x1138:0x51C6/0x16546.
    // Operation not registered by running code
    public int Get1138_51C6_Byte8() {
        return GetUint8(0x51C6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51C6_Byte8(byte value) {
        SetUint8(0x51C6, value);
    }

    // Getters and Setters for address 0x1138:0x51C7/0x16547.
    // Operation not registered by running code
    public int Get1138_51C7_Byte8() {
        return GetUint8(0x51C7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51C7_Byte8(byte value) {
        SetUint8(0x51C7, value);
    }

    // Getters and Setters for address 0x1138:0x51C8/0x16548.
    // Operation not registered by running code
    public int Get1138_51C8_Byte8() {
        return GetUint8(0x51C8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51C8_Byte8(byte value) {
        SetUint8(0x51C8, value);
    }

    // Getters and Setters for address 0x1138:0x51C9/0x16549.
    // Operation not registered by running code
    public int Get1138_51C9_Byte8() {
        return GetUint8(0x51C9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51C9_Byte8(byte value) {
        SetUint8(0x51C9, value);
    }

    // Getters and Setters for address 0x1138:0x51CA/0x1654A.
    // Operation not registered by running code
    public int Get1138_51CA_Byte8() {
        return GetUint8(0x51CA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51CA_Byte8(byte value) {
        SetUint8(0x51CA, value);
    }

    // Getters and Setters for address 0x1138:0x51CB/0x1654B.
    // Operation not registered by running code
    public int Get1138_51CB_Byte8() {
        return GetUint8(0x51CB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51CB_Byte8(byte value) {
        SetUint8(0x51CB, value);
    }

    // Getters and Setters for address 0x1138:0x51CC/0x1654C.
    // Operation not registered by running code
    public int Get1138_51CC_Byte8() {
        return GetUint8(0x51CC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51CC_Byte8(byte value) {
        SetUint8(0x51CC, value);
    }

    // Getters and Setters for address 0x1138:0x51CD/0x1654D.
    // Operation not registered by running code
    public int Get1138_51CD_Byte8() {
        return GetUint8(0x51CD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51CD_Byte8(byte value) {
        SetUint8(0x51CD, value);
    }

    // Getters and Setters for address 0x1138:0x51CE/0x1654E.
    // Operation not registered by running code
    public int Get1138_51CE_Byte8() {
        return GetUint8(0x51CE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51CE_Byte8(byte value) {
        SetUint8(0x51CE, value);
    }

    // Getters and Setters for address 0x1138:0x51CF/0x1654F.
    // Operation not registered by running code
    public int Get1138_51CF_Byte8() {
        return GetUint8(0x51CF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51CF_Byte8(byte value) {
        SetUint8(0x51CF, value);
    }

    // Getters and Setters for address 0x1138:0x51D0/0x16550.
    // Operation not registered by running code
    public int Get1138_51D0_Byte8() {
        return GetUint8(0x51D0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51D0_Byte8(byte value) {
        SetUint8(0x51D0, value);
    }

    // Getters and Setters for address 0x1138:0x51D1/0x16551.
    // Operation not registered by running code
    public int Get1138_51D1_Byte8() {
        return GetUint8(0x51D1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51D1_Byte8(byte value) {
        SetUint8(0x51D1, value);
    }

    // Getters and Setters for address 0x1138:0x51D2/0x16552.
    // Operation not registered by running code
    public int Get1138_51D2_Byte8() {
        return GetUint8(0x51D2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51D2_Byte8(byte value) {
        SetUint8(0x51D2, value);
    }

    // Getters and Setters for address 0x1138:0x51D3/0x16553.
    // Operation not registered by running code
    public int Get1138_51D3_Byte8() {
        return GetUint8(0x51D3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51D3_Byte8(byte value) {
        SetUint8(0x51D3, value);
    }

    // Getters and Setters for address 0x1138:0x51D4/0x16554.
    // Operation not registered by running code
    public int Get1138_51D4_Byte8() {
        return GetUint8(0x51D4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51D4_Byte8(byte value) {
        SetUint8(0x51D4, value);
    }

    // Getters and Setters for address 0x1138:0x51D5/0x16555.
    // Operation not registered by running code
    public int Get1138_51D5_Byte8() {
        return GetUint8(0x51D5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51D5_Byte8(byte value) {
        SetUint8(0x51D5, value);
    }

    // Getters and Setters for address 0x1138:0x51D6/0x16556.
    // Operation not registered by running code
    public int Get1138_51D6_Byte8() {
        return GetUint8(0x51D6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51D6_Byte8(byte value) {
        SetUint8(0x51D6, value);
    }

    // Getters and Setters for address 0x1138:0x51D7/0x16557.
    // Operation not registered by running code
    public int Get1138_51D7_Byte8() {
        return GetUint8(0x51D7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51D7_Byte8(byte value) {
        SetUint8(0x51D7, value);
    }

    // Getters and Setters for address 0x1138:0x51D8/0x16558.
    // Operation not registered by running code
    public int Get1138_51D8_Byte8() {
        return GetUint8(0x51D8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51D8_Byte8(byte value) {
        SetUint8(0x51D8, value);
    }

    // Getters and Setters for address 0x1138:0x51D9/0x16559.
    // Operation not registered by running code
    public int Get1138_51D9_Byte8() {
        return GetUint8(0x51D9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51D9_Byte8(byte value) {
        SetUint8(0x51D9, value);
    }

    // Getters and Setters for address 0x1138:0x51DA/0x1655A.
    // Operation not registered by running code
    public int Get1138_51DA_Byte8() {
        return GetUint8(0x51DA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51DA_Byte8(byte value) {
        SetUint8(0x51DA, value);
    }

    // Getters and Setters for address 0x1138:0x51DB/0x1655B.
    // Operation not registered by running code
    public int Get1138_51DB_Byte8() {
        return GetUint8(0x51DB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51DB_Byte8(byte value) {
        SetUint8(0x51DB, value);
    }

    // Getters and Setters for address 0x1138:0x51DC/0x1655C.
    // Operation not registered by running code
    public int Get1138_51DC_Byte8() {
        return GetUint8(0x51DC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51DC_Byte8(byte value) {
        SetUint8(0x51DC, value);
    }

    // Getters and Setters for address 0x1138:0x51DD/0x1655D.
    // Operation not registered by running code
    public int Get1138_51DD_Byte8() {
        return GetUint8(0x51DD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51DD_Byte8(byte value) {
        SetUint8(0x51DD, value);
    }

    // Getters and Setters for address 0x1138:0x51DE/0x1655E.
    // Operation not registered by running code
    public int Get1138_51DE_Byte8() {
        return GetUint8(0x51DE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51DE_Byte8(byte value) {
        SetUint8(0x51DE, value);
    }

    // Getters and Setters for address 0x1138:0x51DF/0x1655F.
    // Operation not registered by running code
    public int Get1138_51DF_Byte8() {
        return GetUint8(0x51DF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51DF_Byte8(byte value) {
        SetUint8(0x51DF, value);
    }

    // Getters and Setters for address 0x1138:0x51E0/0x16560.
    // Operation not registered by running code
    public int Get1138_51E0_Byte8() {
        return GetUint8(0x51E0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51E0_Byte8(byte value) {
        SetUint8(0x51E0, value);
    }

    // Getters and Setters for address 0x1138:0x51E1/0x16561.
    // Operation not registered by running code
    public int Get1138_51E1_Byte8() {
        return GetUint8(0x51E1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51E1_Byte8(byte value) {
        SetUint8(0x51E1, value);
    }

    // Getters and Setters for address 0x1138:0x51E2/0x16562.
    // Operation not registered by running code
    public int Get1138_51E2_Byte8() {
        return GetUint8(0x51E2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51E2_Byte8(byte value) {
        SetUint8(0x51E2, value);
    }

    // Getters and Setters for address 0x1138:0x51E3/0x16563.
    // Operation not registered by running code
    public int Get1138_51E3_Byte8() {
        return GetUint8(0x51E3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51E3_Byte8(byte value) {
        SetUint8(0x51E3, value);
    }

    // Getters and Setters for address 0x1138:0x51E4/0x16564.
    // Operation not registered by running code
    public int Get1138_51E4_Byte8() {
        return GetUint8(0x51E4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51E4_Byte8(byte value) {
        SetUint8(0x51E4, value);
    }

    // Getters and Setters for address 0x1138:0x51E5/0x16565.
    // Operation not registered by running code
    public int Get1138_51E5_Byte8() {
        return GetUint8(0x51E5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51E5_Byte8(byte value) {
        SetUint8(0x51E5, value);
    }

    // Getters and Setters for address 0x1138:0x51E6/0x16566.
    // Operation not registered by running code
    public int Get1138_51E6_Byte8() {
        return GetUint8(0x51E6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51E6_Byte8(byte value) {
        SetUint8(0x51E6, value);
    }

    // Getters and Setters for address 0x1138:0x51E7/0x16567.
    // Operation not registered by running code
    public int Get1138_51E7_Byte8() {
        return GetUint8(0x51E7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51E7_Byte8(byte value) {
        SetUint8(0x51E7, value);
    }

    // Getters and Setters for address 0x1138:0x51E8/0x16568.
    // Operation not registered by running code
    public int Get1138_51E8_Byte8() {
        return GetUint8(0x51E8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51E8_Byte8(byte value) {
        SetUint8(0x51E8, value);
    }

    // Getters and Setters for address 0x1138:0x51E9/0x16569.
    // Operation not registered by running code
    public int Get1138_51E9_Byte8() {
        return GetUint8(0x51E9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51E9_Byte8(byte value) {
        SetUint8(0x51E9, value);
    }

    // Getters and Setters for address 0x1138:0x51EA/0x1656A.
    // Operation not registered by running code
    public int Get1138_51EA_Byte8() {
        return GetUint8(0x51EA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51EA_Byte8(byte value) {
        SetUint8(0x51EA, value);
    }

    // Getters and Setters for address 0x1138:0x51EB/0x1656B.
    // Operation not registered by running code
    public int Get1138_51EB_Byte8() {
        return GetUint8(0x51EB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51EB_Byte8(byte value) {
        SetUint8(0x51EB, value);
    }

    // Getters and Setters for address 0x1138:0x51EC/0x1656C.
    // Operation not registered by running code
    public int Get1138_51EC_Byte8() {
        return GetUint8(0x51EC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51EC_Byte8(byte value) {
        SetUint8(0x51EC, value);
    }

    // Getters and Setters for address 0x1138:0x51ED/0x1656D.
    // Operation not registered by running code
    public int Get1138_51ED_Byte8() {
        return GetUint8(0x51ED);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51ED_Byte8(byte value) {
        SetUint8(0x51ED, value);
    }

    // Getters and Setters for address 0x1138:0x51EE/0x1656E.
    // Operation not registered by running code
    public int Get1138_51EE_Byte8() {
        return GetUint8(0x51EE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51EE_Byte8(byte value) {
        SetUint8(0x51EE, value);
    }

    // Getters and Setters for address 0x1138:0x51EF/0x1656F.
    // Operation not registered by running code
    public int Get1138_51EF_Byte8() {
        return GetUint8(0x51EF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51EF_Byte8(byte value) {
        SetUint8(0x51EF, value);
    }

    // Getters and Setters for address 0x1138:0x51F0/0x16570.
    // Operation not registered by running code
    public int Get1138_51F0_Byte8() {
        return GetUint8(0x51F0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51F0_Byte8(byte value) {
        SetUint8(0x51F0, value);
    }

    // Getters and Setters for address 0x1138:0x51F1/0x16571.
    // Operation not registered by running code
    public int Get1138_51F1_Byte8() {
        return GetUint8(0x51F1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51F1_Byte8(byte value) {
        SetUint8(0x51F1, value);
    }

    // Getters and Setters for address 0x1138:0x51F2/0x16572.
    // Operation not registered by running code
    public int Get1138_51F2_Byte8() {
        return GetUint8(0x51F2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51F2_Byte8(byte value) {
        SetUint8(0x51F2, value);
    }

    // Getters and Setters for address 0x1138:0x51F3/0x16573.
    // Operation not registered by running code
    public int Get1138_51F3_Byte8() {
        return GetUint8(0x51F3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51F3_Byte8(byte value) {
        SetUint8(0x51F3, value);
    }

    // Getters and Setters for address 0x1138:0x51F4/0x16574.
    // Operation not registered by running code
    public int Get1138_51F4_Byte8() {
        return GetUint8(0x51F4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51F4_Byte8(byte value) {
        SetUint8(0x51F4, value);
    }

    // Getters and Setters for address 0x1138:0x51F5/0x16575.
    // Operation not registered by running code
    public int Get1138_51F5_Byte8() {
        return GetUint8(0x51F5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51F5_Byte8(byte value) {
        SetUint8(0x51F5, value);
    }

    // Getters and Setters for address 0x1138:0x51F6/0x16576.
    // Operation not registered by running code
    public int Get1138_51F6_Byte8() {
        return GetUint8(0x51F6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51F6_Byte8(byte value) {
        SetUint8(0x51F6, value);
    }

    // Getters and Setters for address 0x1138:0x51F7/0x16577.
    // Operation not registered by running code
    public int Get1138_51F7_Byte8() {
        return GetUint8(0x51F7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51F7_Byte8(byte value) {
        SetUint8(0x51F7, value);
    }

    // Getters and Setters for address 0x1138:0x51F8/0x16578.
    // Operation not registered by running code
    public int Get1138_51F8_Byte8() {
        return GetUint8(0x51F8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51F8_Byte8(byte value) {
        SetUint8(0x51F8, value);
    }

    // Getters and Setters for address 0x1138:0x51F9/0x16579.
    // Operation not registered by running code
    public int Get1138_51F9_Byte8() {
        return GetUint8(0x51F9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51F9_Byte8(byte value) {
        SetUint8(0x51F9, value);
    }

    // Getters and Setters for address 0x1138:0x51FA/0x1657A.
    // Operation not registered by running code
    public int Get1138_51FA_Byte8() {
        return GetUint8(0x51FA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51FA_Byte8(byte value) {
        SetUint8(0x51FA, value);
    }

    // Getters and Setters for address 0x1138:0x51FB/0x1657B.
    // Operation not registered by running code
    public int Get1138_51FB_Byte8() {
        return GetUint8(0x51FB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51FB_Byte8(byte value) {
        SetUint8(0x51FB, value);
    }

    // Getters and Setters for address 0x1138:0x51FC/0x1657C.
    // Operation not registered by running code
    public int Get1138_51FC_Byte8() {
        return GetUint8(0x51FC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51FC_Byte8(byte value) {
        SetUint8(0x51FC, value);
    }

    // Getters and Setters for address 0x1138:0x51FD/0x1657D.
    // Operation not registered by running code
    public int Get1138_51FD_Byte8() {
        return GetUint8(0x51FD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51FD_Byte8(byte value) {
        SetUint8(0x51FD, value);
    }

    // Getters and Setters for address 0x1138:0x51FE/0x1657E.
    // Operation not registered by running code
    public int Get1138_51FE_Byte8() {
        return GetUint8(0x51FE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51FE_Byte8(byte value) {
        SetUint8(0x51FE, value);
    }

    // Getters and Setters for address 0x1138:0x51FF/0x1657F.
    // Operation not registered by running code
    public int Get1138_51FF_Byte8() {
        return GetUint8(0x51FF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_51FF_Byte8(byte value) {
        SetUint8(0x51FF, value);
    }

    // Getters and Setters for address 0x1138:0x5200/0x16580.
    // Operation not registered by running code
    public int Get1138_5200_Byte8() {
        return GetUint8(0x5200);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5200_Byte8(byte value) {
        SetUint8(0x5200, value);
    }

    // Getters and Setters for address 0x1138:0x5201/0x16581.
    // Operation not registered by running code
    public int Get1138_5201_Byte8() {
        return GetUint8(0x5201);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5201_Byte8(byte value) {
        SetUint8(0x5201, value);
    }

    // Getters and Setters for address 0x1138:0x5202/0x16582.
    // Operation not registered by running code
    public int Get1138_5202_Byte8() {
        return GetUint8(0x5202);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5202_Byte8(byte value) {
        SetUint8(0x5202, value);
    }

    // Getters and Setters for address 0x1138:0x5203/0x16583.
    // Operation not registered by running code
    public int Get1138_5203_Byte8() {
        return GetUint8(0x5203);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5203_Byte8(byte value) {
        SetUint8(0x5203, value);
    }

    // Getters and Setters for address 0x1138:0x5204/0x16584.
    // Operation not registered by running code
    public int Get1138_5204_Byte8() {
        return GetUint8(0x5204);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5204_Byte8(byte value) {
        SetUint8(0x5204, value);
    }

    // Getters and Setters for address 0x1138:0x5205/0x16585.
    // Operation not registered by running code
    public int Get1138_5205_Byte8() {
        return GetUint8(0x5205);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5205_Byte8(byte value) {
        SetUint8(0x5205, value);
    }

    // Getters and Setters for address 0x1138:0x5206/0x16586.
    // Operation not registered by running code
    public int Get1138_5206_Byte8() {
        return GetUint8(0x5206);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5206_Byte8(byte value) {
        SetUint8(0x5206, value);
    }

    // Getters and Setters for address 0x1138:0x5207/0x16587.
    // Operation not registered by running code
    public int Get1138_5207_Byte8() {
        return GetUint8(0x5207);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5207_Byte8(byte value) {
        SetUint8(0x5207, value);
    }

    // Getters and Setters for address 0x1138:0x5208/0x16588.
    // Operation not registered by running code
    public int Get1138_5208_Byte8() {
        return GetUint8(0x5208);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5208_Byte8(byte value) {
        SetUint8(0x5208, value);
    }

    // Getters and Setters for address 0x1138:0x5209/0x16589.
    // Operation not registered by running code
    public int Get1138_5209_Byte8() {
        return GetUint8(0x5209);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5209_Byte8(byte value) {
        SetUint8(0x5209, value);
    }

    // Getters and Setters for address 0x1138:0x520A/0x1658A.
    // Operation not registered by running code
    public int Get1138_520A_Byte8() {
        return GetUint8(0x520A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_520A_Byte8(byte value) {
        SetUint8(0x520A, value);
    }

    // Getters and Setters for address 0x1138:0x520B/0x1658B.
    // Operation not registered by running code
    public int Get1138_520B_Byte8() {
        return GetUint8(0x520B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_520B_Byte8(byte value) {
        SetUint8(0x520B, value);
    }

    // Getters and Setters for address 0x1138:0x520C/0x1658C.
    // Operation not registered by running code
    public int Get1138_520C_Byte8() {
        return GetUint8(0x520C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_520C_Byte8(byte value) {
        SetUint8(0x520C, value);
    }

    // Getters and Setters for address 0x1138:0x520D/0x1658D.
    // Operation not registered by running code
    public int Get1138_520D_Byte8() {
        return GetUint8(0x520D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_520D_Byte8(byte value) {
        SetUint8(0x520D, value);
    }

    // Getters and Setters for address 0x1138:0x520E/0x1658E.
    // Operation not registered by running code
    public int Get1138_520E_Byte8() {
        return GetUint8(0x520E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_520E_Byte8(byte value) {
        SetUint8(0x520E, value);
    }

    // Getters and Setters for address 0x1138:0x520F/0x1658F.
    // Operation not registered by running code
    public int Get1138_520F_Byte8() {
        return GetUint8(0x520F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_520F_Byte8(byte value) {
        SetUint8(0x520F, value);
    }

    // Getters and Setters for address 0x1138:0x5210/0x16590.
    // Operation not registered by running code
    public int Get1138_5210_Byte8() {
        return GetUint8(0x5210);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5210_Byte8(byte value) {
        SetUint8(0x5210, value);
    }

    // Getters and Setters for address 0x1138:0x5211/0x16591.
    // Operation not registered by running code
    public int Get1138_5211_Byte8() {
        return GetUint8(0x5211);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5211_Byte8(byte value) {
        SetUint8(0x5211, value);
    }

    // Getters and Setters for address 0x1138:0x5212/0x16592.
    // Operation not registered by running code
    public int Get1138_5212_Byte8() {
        return GetUint8(0x5212);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5212_Byte8(byte value) {
        SetUint8(0x5212, value);
    }

    // Getters and Setters for address 0x1138:0x5213/0x16593.
    // Operation not registered by running code
    public int Get1138_5213_Byte8() {
        return GetUint8(0x5213);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5213_Byte8(byte value) {
        SetUint8(0x5213, value);
    }

    // Getters and Setters for address 0x1138:0x5214/0x16594.
    // Operation not registered by running code
    public int Get1138_5214_Byte8() {
        return GetUint8(0x5214);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5214_Byte8(byte value) {
        SetUint8(0x5214, value);
    }

    // Getters and Setters for address 0x1138:0x5215/0x16595.
    // Operation not registered by running code
    public int Get1138_5215_Byte8() {
        return GetUint8(0x5215);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5215_Byte8(byte value) {
        SetUint8(0x5215, value);
    }

    // Getters and Setters for address 0x1138:0x5216/0x16596.
    // Operation not registered by running code
    public int Get1138_5216_Byte8() {
        return GetUint8(0x5216);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5216_Byte8(byte value) {
        SetUint8(0x5216, value);
    }

    // Getters and Setters for address 0x1138:0x5217/0x16597.
    // Operation not registered by running code
    public int Get1138_5217_Byte8() {
        return GetUint8(0x5217);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5217_Byte8(byte value) {
        SetUint8(0x5217, value);
    }

    // Getters and Setters for address 0x1138:0x5218/0x16598.
    // Operation not registered by running code
    public int Get1138_5218_Byte8() {
        return GetUint8(0x5218);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5218_Byte8(byte value) {
        SetUint8(0x5218, value);
    }

    // Getters and Setters for address 0x1138:0x5219/0x16599.
    // Operation not registered by running code
    public int Get1138_5219_Byte8() {
        return GetUint8(0x5219);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5219_Byte8(byte value) {
        SetUint8(0x5219, value);
    }

    // Getters and Setters for address 0x1138:0x521A/0x1659A.
    // Operation not registered by running code
    public int Get1138_521A_Byte8() {
        return GetUint8(0x521A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_521A_Byte8(byte value) {
        SetUint8(0x521A, value);
    }

    // Getters and Setters for address 0x1138:0x521B/0x1659B.
    // Operation not registered by running code
    public int Get1138_521B_Byte8() {
        return GetUint8(0x521B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_521B_Byte8(byte value) {
        SetUint8(0x521B, value);
    }

    // Getters and Setters for address 0x1138:0x521C/0x1659C.
    // Operation not registered by running code
    public int Get1138_521C_Byte8() {
        return GetUint8(0x521C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_521C_Byte8(byte value) {
        SetUint8(0x521C, value);
    }

    // Getters and Setters for address 0x1138:0x521D/0x1659D.
    // Operation not registered by running code
    public int Get1138_521D_Byte8() {
        return GetUint8(0x521D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_521D_Byte8(byte value) {
        SetUint8(0x521D, value);
    }

    // Getters and Setters for address 0x1138:0x521E/0x1659E.
    // Operation not registered by running code
    public int Get1138_521E_Byte8() {
        return GetUint8(0x521E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_521E_Byte8(byte value) {
        SetUint8(0x521E, value);
    }

    // Getters and Setters for address 0x1138:0x521F/0x1659F.
    // Operation not registered by running code
    public int Get1138_521F_Byte8() {
        return GetUint8(0x521F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_521F_Byte8(byte value) {
        SetUint8(0x521F, value);
    }

    // Getters and Setters for address 0x1138:0x5220/0x165A0.
    // Operation not registered by running code
    public int Get1138_5220_Byte8() {
        return GetUint8(0x5220);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5220_Byte8(byte value) {
        SetUint8(0x5220, value);
    }

    // Getters and Setters for address 0x1138:0x5221/0x165A1.
    // Operation not registered by running code
    public int Get1138_5221_Byte8() {
        return GetUint8(0x5221);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5221_Byte8(byte value) {
        SetUint8(0x5221, value);
    }

    // Getters and Setters for address 0x1138:0x5222/0x165A2.
    // Operation not registered by running code
    public int Get1138_5222_Byte8() {
        return GetUint8(0x5222);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5222_Byte8(byte value) {
        SetUint8(0x5222, value);
    }

    // Getters and Setters for address 0x1138:0x5223/0x165A3.
    // Operation not registered by running code
    public int Get1138_5223_Byte8() {
        return GetUint8(0x5223);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5223_Byte8(byte value) {
        SetUint8(0x5223, value);
    }

    // Getters and Setters for address 0x1138:0x5224/0x165A4.
    // Operation not registered by running code
    public int Get1138_5224_Byte8() {
        return GetUint8(0x5224);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5224_Byte8(byte value) {
        SetUint8(0x5224, value);
    }

    // Getters and Setters for address 0x1138:0x5225/0x165A5.
    // Operation not registered by running code
    public int Get1138_5225_Byte8() {
        return GetUint8(0x5225);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5225_Byte8(byte value) {
        SetUint8(0x5225, value);
    }

    // Getters and Setters for address 0x1138:0x5226/0x165A6.
    // Operation not registered by running code
    public int Get1138_5226_Byte8() {
        return GetUint8(0x5226);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5226_Byte8(byte value) {
        SetUint8(0x5226, value);
    }

    // Getters and Setters for address 0x1138:0x5227/0x165A7.
    // Operation not registered by running code
    public int Get1138_5227_Byte8() {
        return GetUint8(0x5227);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5227_Byte8(byte value) {
        SetUint8(0x5227, value);
    }

    // Getters and Setters for address 0x1138:0x5228/0x165A8.
    // Operation not registered by running code
    public int Get1138_5228_Byte8() {
        return GetUint8(0x5228);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5228_Byte8(byte value) {
        SetUint8(0x5228, value);
    }

    // Getters and Setters for address 0x1138:0x5229/0x165A9.
    // Operation not registered by running code
    public int Get1138_5229_Byte8() {
        return GetUint8(0x5229);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5229_Byte8(byte value) {
        SetUint8(0x5229, value);
    }

    // Getters and Setters for address 0x1138:0x522A/0x165AA.
    // Operation not registered by running code
    public int Get1138_522A_Byte8() {
        return GetUint8(0x522A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_522A_Byte8(byte value) {
        SetUint8(0x522A, value);
    }

    // Getters and Setters for address 0x1138:0x522B/0x165AB.
    // Operation not registered by running code
    public int Get1138_522B_Byte8() {
        return GetUint8(0x522B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_522B_Byte8(byte value) {
        SetUint8(0x522B, value);
    }

    // Getters and Setters for address 0x1138:0x522C/0x165AC.
    // Operation not registered by running code
    public int Get1138_522C_Byte8() {
        return GetUint8(0x522C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_522C_Byte8(byte value) {
        SetUint8(0x522C, value);
    }

    // Getters and Setters for address 0x1138:0x522D/0x165AD.
    // Operation not registered by running code
    public int Get1138_522D_Byte8() {
        return GetUint8(0x522D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_522D_Byte8(byte value) {
        SetUint8(0x522D, value);
    }

    // Getters and Setters for address 0x1138:0x522E/0x165AE.
    // Operation not registered by running code
    public int Get1138_522E_Byte8() {
        return GetUint8(0x522E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_522E_Byte8(byte value) {
        SetUint8(0x522E, value);
    }

    // Getters and Setters for address 0x1138:0x522F/0x165AF.
    // Operation not registered by running code
    public int Get1138_522F_Byte8() {
        return GetUint8(0x522F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_522F_Byte8(byte value) {
        SetUint8(0x522F, value);
    }

    // Getters and Setters for address 0x1138:0x5230/0x165B0.
    // Operation not registered by running code
    public int Get1138_5230_Byte8() {
        return GetUint8(0x5230);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5230_Byte8(byte value) {
        SetUint8(0x5230, value);
    }

    // Getters and Setters for address 0x1138:0x5231/0x165B1.
    // Operation not registered by running code
    public int Get1138_5231_Byte8() {
        return GetUint8(0x5231);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5231_Byte8(byte value) {
        SetUint8(0x5231, value);
    }

    // Getters and Setters for address 0x1138:0x5232/0x165B2.
    // Operation not registered by running code
    public int Get1138_5232_Byte8() {
        return GetUint8(0x5232);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5232_Byte8(byte value) {
        SetUint8(0x5232, value);
    }

    // Getters and Setters for address 0x1138:0x5233/0x165B3.
    // Operation not registered by running code
    public int Get1138_5233_Byte8() {
        return GetUint8(0x5233);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5233_Byte8(byte value) {
        SetUint8(0x5233, value);
    }

    // Getters and Setters for address 0x1138:0x5234/0x165B4.
    // Operation not registered by running code
    public int Get1138_5234_Byte8() {
        return GetUint8(0x5234);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5234_Byte8(byte value) {
        SetUint8(0x5234, value);
    }

    // Getters and Setters for address 0x1138:0x5235/0x165B5.
    // Operation not registered by running code
    public int Get1138_5235_Byte8() {
        return GetUint8(0x5235);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5235_Byte8(byte value) {
        SetUint8(0x5235, value);
    }

    // Getters and Setters for address 0x1138:0x5236/0x165B6.
    // Operation not registered by running code
    public int Get1138_5236_Byte8() {
        return GetUint8(0x5236);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5236_Byte8(byte value) {
        SetUint8(0x5236, value);
    }

    // Getters and Setters for address 0x1138:0x5237/0x165B7.
    // Operation not registered by running code
    public int Get1138_5237_Byte8() {
        return GetUint8(0x5237);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5237_Byte8(byte value) {
        SetUint8(0x5237, value);
    }

    // Getters and Setters for address 0x1138:0x5238/0x165B8.
    // Operation not registered by running code
    public int Get1138_5238_Byte8() {
        return GetUint8(0x5238);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5238_Byte8(byte value) {
        SetUint8(0x5238, value);
    }

    // Getters and Setters for address 0x1138:0x5239/0x165B9.
    // Operation not registered by running code
    public int Get1138_5239_Byte8() {
        return GetUint8(0x5239);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5239_Byte8(byte value) {
        SetUint8(0x5239, value);
    }

    // Getters and Setters for address 0x1138:0x523A/0x165BA.
    // Operation not registered by running code
    public int Get1138_523A_Byte8() {
        return GetUint8(0x523A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_523A_Byte8(byte value) {
        SetUint8(0x523A, value);
    }

    // Getters and Setters for address 0x1138:0x523B/0x165BB.
    // Operation not registered by running code
    public int Get1138_523B_Byte8() {
        return GetUint8(0x523B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_523B_Byte8(byte value) {
        SetUint8(0x523B, value);
    }

    // Getters and Setters for address 0x1138:0x523C/0x165BC.
    // Operation not registered by running code
    public int Get1138_523C_Byte8() {
        return GetUint8(0x523C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_523C_Byte8(byte value) {
        SetUint8(0x523C, value);
    }

    // Getters and Setters for address 0x1138:0x523D/0x165BD.
    // Operation not registered by running code
    public int Get1138_523D_Byte8() {
        return GetUint8(0x523D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_523D_Byte8(byte value) {
        SetUint8(0x523D, value);
    }

    // Getters and Setters for address 0x1138:0x523E/0x165BE.
    // Operation not registered by running code
    public int Get1138_523E_Byte8() {
        return GetUint8(0x523E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_523E_Byte8(byte value) {
        SetUint8(0x523E, value);
    }

    // Getters and Setters for address 0x1138:0x523F/0x165BF.
    // Operation not registered by running code
    public int Get1138_523F_Byte8() {
        return GetUint8(0x523F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_523F_Byte8(byte value) {
        SetUint8(0x523F, value);
    }

    // Getters and Setters for address 0x1138:0x5240/0x165C0.
    // Operation not registered by running code
    public int Get1138_5240_Byte8() {
        return GetUint8(0x5240);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5240_Byte8(byte value) {
        SetUint8(0x5240, value);
    }

    // Getters and Setters for address 0x1138:0x5241/0x165C1.
    // Operation not registered by running code
    public int Get1138_5241_Byte8() {
        return GetUint8(0x5241);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5241_Byte8(byte value) {
        SetUint8(0x5241, value);
    }

    // Getters and Setters for address 0x1138:0x5242/0x165C2.
    // Operation not registered by running code
    public int Get1138_5242_Byte8() {
        return GetUint8(0x5242);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5242_Byte8(byte value) {
        SetUint8(0x5242, value);
    }

    // Getters and Setters for address 0x1138:0x5243/0x165C3.
    // Operation not registered by running code
    public int Get1138_5243_Byte8() {
        return GetUint8(0x5243);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5243_Byte8(byte value) {
        SetUint8(0x5243, value);
    }

    // Getters and Setters for address 0x1138:0x5244/0x165C4.
    // Operation not registered by running code
    public int Get1138_5244_Byte8() {
        return GetUint8(0x5244);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5244_Byte8(byte value) {
        SetUint8(0x5244, value);
    }

    // Getters and Setters for address 0x1138:0x5245/0x165C5.
    // Operation not registered by running code
    public int Get1138_5245_Byte8() {
        return GetUint8(0x5245);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5245_Byte8(byte value) {
        SetUint8(0x5245, value);
    }

    // Getters and Setters for address 0x1138:0x5246/0x165C6.
    // Operation not registered by running code
    public int Get1138_5246_Byte8() {
        return GetUint8(0x5246);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5246_Byte8(byte value) {
        SetUint8(0x5246, value);
    }

    // Getters and Setters for address 0x1138:0x5247/0x165C7.
    // Operation not registered by running code
    public int Get1138_5247_Byte8() {
        return GetUint8(0x5247);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5247_Byte8(byte value) {
        SetUint8(0x5247, value);
    }

    // Getters and Setters for address 0x1138:0x5248/0x165C8.
    // Operation not registered by running code
    public int Get1138_5248_Byte8() {
        return GetUint8(0x5248);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5248_Byte8(byte value) {
        SetUint8(0x5248, value);
    }

    // Getters and Setters for address 0x1138:0x5249/0x165C9.
    // Operation not registered by running code
    public int Get1138_5249_Byte8() {
        return GetUint8(0x5249);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5249_Byte8(byte value) {
        SetUint8(0x5249, value);
    }

    // Getters and Setters for address 0x1138:0x524A/0x165CA.
    // Operation not registered by running code
    public int Get1138_524A_Byte8() {
        return GetUint8(0x524A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_524A_Byte8(byte value) {
        SetUint8(0x524A, value);
    }

    // Getters and Setters for address 0x1138:0x524B/0x165CB.
    // Operation not registered by running code
    public int Get1138_524B_Byte8() {
        return GetUint8(0x524B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_524B_Byte8(byte value) {
        SetUint8(0x524B, value);
    }

    // Getters and Setters for address 0x1138:0x524C/0x165CC.
    // Operation not registered by running code
    public int Get1138_524C_Byte8() {
        return GetUint8(0x524C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_524C_Byte8(byte value) {
        SetUint8(0x524C, value);
    }

    // Getters and Setters for address 0x1138:0x524D/0x165CD.
    // Operation not registered by running code
    public int Get1138_524D_Byte8() {
        return GetUint8(0x524D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_524D_Byte8(byte value) {
        SetUint8(0x524D, value);
    }

    // Getters and Setters for address 0x1138:0x524E/0x165CE.
    // Operation not registered by running code
    public int Get1138_524E_Byte8() {
        return GetUint8(0x524E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_524E_Byte8(byte value) {
        SetUint8(0x524E, value);
    }

    // Getters and Setters for address 0x1138:0x524F/0x165CF.
    // Operation not registered by running code
    public int Get1138_524F_Byte8() {
        return GetUint8(0x524F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_524F_Byte8(byte value) {
        SetUint8(0x524F, value);
    }

    // Getters and Setters for address 0x1138:0x5250/0x165D0.
    // Operation not registered by running code
    public int Get1138_5250_Byte8() {
        return GetUint8(0x5250);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5250_Byte8(byte value) {
        SetUint8(0x5250, value);
    }

    // Getters and Setters for address 0x1138:0x5251/0x165D1.
    // Operation not registered by running code
    public int Get1138_5251_Byte8() {
        return GetUint8(0x5251);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5251_Byte8(byte value) {
        SetUint8(0x5251, value);
    }

    // Getters and Setters for address 0x1138:0x5252/0x165D2.
    // Operation not registered by running code
    public int Get1138_5252_Byte8() {
        return GetUint8(0x5252);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5252_Byte8(byte value) {
        SetUint8(0x5252, value);
    }

    // Getters and Setters for address 0x1138:0x5253/0x165D3.
    // Operation not registered by running code
    public int Get1138_5253_Byte8() {
        return GetUint8(0x5253);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5253_Byte8(byte value) {
        SetUint8(0x5253, value);
    }

    // Getters and Setters for address 0x1138:0x5254/0x165D4.
    // Operation not registered by running code
    public int Get1138_5254_Byte8() {
        return GetUint8(0x5254);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5254_Byte8(byte value) {
        SetUint8(0x5254, value);
    }

    // Getters and Setters for address 0x1138:0x5255/0x165D5.
    // Operation not registered by running code
    public int Get1138_5255_Byte8() {
        return GetUint8(0x5255);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5255_Byte8(byte value) {
        SetUint8(0x5255, value);
    }

    // Getters and Setters for address 0x1138:0x5256/0x165D6.
    // Operation not registered by running code
    public int Get1138_5256_Byte8() {
        return GetUint8(0x5256);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5256_Byte8(byte value) {
        SetUint8(0x5256, value);
    }

    // Getters and Setters for address 0x1138:0x5257/0x165D7.
    // Operation not registered by running code
    public int Get1138_5257_Byte8() {
        return GetUint8(0x5257);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5257_Byte8(byte value) {
        SetUint8(0x5257, value);
    }

    // Getters and Setters for address 0x1138:0x5258/0x165D8.
    // Operation not registered by running code
    public int Get1138_5258_Byte8() {
        return GetUint8(0x5258);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5258_Byte8(byte value) {
        SetUint8(0x5258, value);
    }

    // Getters and Setters for address 0x1138:0x5259/0x165D9.
    // Operation not registered by running code
    public int Get1138_5259_Byte8() {
        return GetUint8(0x5259);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5259_Byte8(byte value) {
        SetUint8(0x5259, value);
    }

    // Getters and Setters for address 0x1138:0x525A/0x165DA.
    // Operation not registered by running code
    public int Get1138_525A_Byte8() {
        return GetUint8(0x525A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_525A_Byte8(byte value) {
        SetUint8(0x525A, value);
    }

    // Getters and Setters for address 0x1138:0x525B/0x165DB.
    // Operation not registered by running code
    public int Get1138_525B_Byte8() {
        return GetUint8(0x525B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_525B_Byte8(byte value) {
        SetUint8(0x525B, value);
    }

    // Getters and Setters for address 0x1138:0x525C/0x165DC.
    // Operation not registered by running code
    public int Get1138_525C_Byte8() {
        return GetUint8(0x525C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_525C_Byte8(byte value) {
        SetUint8(0x525C, value);
    }

    // Getters and Setters for address 0x1138:0x525D/0x165DD.
    // Operation not registered by running code
    public int Get1138_525D_Byte8() {
        return GetUint8(0x525D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_525D_Byte8(byte value) {
        SetUint8(0x525D, value);
    }

    // Getters and Setters for address 0x1138:0x525E/0x165DE.
    // Operation not registered by running code
    public int Get1138_525E_Byte8() {
        return GetUint8(0x525E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_525E_Byte8(byte value) {
        SetUint8(0x525E, value);
    }

    // Getters and Setters for address 0x1138:0x525F/0x165DF.
    // Operation not registered by running code
    public int Get1138_525F_Byte8() {
        return GetUint8(0x525F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_525F_Byte8(byte value) {
        SetUint8(0x525F, value);
    }

    // Getters and Setters for address 0x1138:0x5260/0x165E0.
    // Operation not registered by running code
    public int Get1138_5260_Byte8() {
        return GetUint8(0x5260);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5260_Byte8(byte value) {
        SetUint8(0x5260, value);
    }

    // Getters and Setters for address 0x1138:0x5261/0x165E1.
    // Operation not registered by running code
    public int Get1138_5261_Byte8() {
        return GetUint8(0x5261);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5261_Byte8(byte value) {
        SetUint8(0x5261, value);
    }

    // Getters and Setters for address 0x1138:0x5262/0x165E2.
    // Operation not registered by running code
    public int Get1138_5262_Byte8() {
        return GetUint8(0x5262);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5262_Byte8(byte value) {
        SetUint8(0x5262, value);
    }

    // Getters and Setters for address 0x1138:0x5263/0x165E3.
    // Operation not registered by running code
    public int Get1138_5263_Byte8() {
        return GetUint8(0x5263);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5263_Byte8(byte value) {
        SetUint8(0x5263, value);
    }

    // Getters and Setters for address 0x1138:0x5264/0x165E4.
    // Operation not registered by running code
    public int Get1138_5264_Byte8() {
        return GetUint8(0x5264);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5264_Byte8(byte value) {
        SetUint8(0x5264, value);
    }

    // Getters and Setters for address 0x1138:0x5265/0x165E5.
    // Operation not registered by running code
    public int Get1138_5265_Byte8() {
        return GetUint8(0x5265);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5265_Byte8(byte value) {
        SetUint8(0x5265, value);
    }

    // Getters and Setters for address 0x1138:0x5266/0x165E6.
    // Operation not registered by running code
    public int Get1138_5266_Byte8() {
        return GetUint8(0x5266);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5266_Byte8(byte value) {
        SetUint8(0x5266, value);
    }

    // Getters and Setters for address 0x1138:0x5267/0x165E7.
    // Operation not registered by running code
    public int Get1138_5267_Byte8() {
        return GetUint8(0x5267);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5267_Byte8(byte value) {
        SetUint8(0x5267, value);
    }

    // Getters and Setters for address 0x1138:0x5268/0x165E8.
    // Operation not registered by running code
    public int Get1138_5268_Byte8() {
        return GetUint8(0x5268);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5268_Byte8(byte value) {
        SetUint8(0x5268, value);
    }

    // Getters and Setters for address 0x1138:0x5269/0x165E9.
    // Operation not registered by running code
    public int Get1138_5269_Byte8() {
        return GetUint8(0x5269);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5269_Byte8(byte value) {
        SetUint8(0x5269, value);
    }

    // Getters and Setters for address 0x1138:0x526A/0x165EA.
    // Operation not registered by running code
    public int Get1138_526A_Byte8() {
        return GetUint8(0x526A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_526A_Byte8(byte value) {
        SetUint8(0x526A, value);
    }

    // Getters and Setters for address 0x1138:0x526B/0x165EB.
    // Operation not registered by running code
    public int Get1138_526B_Byte8() {
        return GetUint8(0x526B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_526B_Byte8(byte value) {
        SetUint8(0x526B, value);
    }

    // Getters and Setters for address 0x1138:0x526C/0x165EC.
    // Operation not registered by running code
    public int Get1138_526C_Byte8() {
        return GetUint8(0x526C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_526C_Byte8(byte value) {
        SetUint8(0x526C, value);
    }

    // Getters and Setters for address 0x1138:0x526D/0x165ED.
    // Operation not registered by running code
    public int Get1138_526D_Byte8() {
        return GetUint8(0x526D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_526D_Byte8(byte value) {
        SetUint8(0x526D, value);
    }

    // Getters and Setters for address 0x1138:0x526E/0x165EE.
    // Operation not registered by running code
    public int Get1138_526E_Byte8() {
        return GetUint8(0x526E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_526E_Byte8(byte value) {
        SetUint8(0x526E, value);
    }

    // Getters and Setters for address 0x1138:0x526F/0x165EF.
    // Operation not registered by running code
    public int Get1138_526F_Byte8() {
        return GetUint8(0x526F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_526F_Byte8(byte value) {
        SetUint8(0x526F, value);
    }

    // Getters and Setters for address 0x1138:0x5270/0x165F0.
    // Operation not registered by running code
    public int Get1138_5270_Byte8() {
        return GetUint8(0x5270);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5270_Byte8(byte value) {
        SetUint8(0x5270, value);
    }

    // Getters and Setters for address 0x1138:0x5271/0x165F1.
    // Operation not registered by running code
    public int Get1138_5271_Byte8() {
        return GetUint8(0x5271);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5271_Byte8(byte value) {
        SetUint8(0x5271, value);
    }

    // Getters and Setters for address 0x1138:0x5272/0x165F2.
    // Operation not registered by running code
    public int Get1138_5272_Byte8() {
        return GetUint8(0x5272);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5272_Byte8(byte value) {
        SetUint8(0x5272, value);
    }

    // Getters and Setters for address 0x1138:0x5273/0x165F3.
    // Operation not registered by running code
    public int Get1138_5273_Byte8() {
        return GetUint8(0x5273);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5273_Byte8(byte value) {
        SetUint8(0x5273, value);
    }

    // Getters and Setters for address 0x1138:0x5274/0x165F4.
    // Operation not registered by running code
    public int Get1138_5274_Byte8() {
        return GetUint8(0x5274);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5274_Byte8(byte value) {
        SetUint8(0x5274, value);
    }

    // Getters and Setters for address 0x1138:0x5275/0x165F5.
    // Operation not registered by running code
    public int Get1138_5275_Byte8() {
        return GetUint8(0x5275);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5275_Byte8(byte value) {
        SetUint8(0x5275, value);
    }

    // Getters and Setters for address 0x1138:0x5276/0x165F6.
    // Operation not registered by running code
    public int Get1138_5276_Byte8() {
        return GetUint8(0x5276);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5276_Byte8(byte value) {
        SetUint8(0x5276, value);
    }

    // Getters and Setters for address 0x1138:0x5277/0x165F7.
    // Operation not registered by running code
    public int Get1138_5277_Byte8() {
        return GetUint8(0x5277);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5277_Byte8(byte value) {
        SetUint8(0x5277, value);
    }

    // Getters and Setters for address 0x1138:0x5278/0x165F8.
    // Operation not registered by running code
    public int Get1138_5278_Byte8() {
        return GetUint8(0x5278);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5278_Byte8(byte value) {
        SetUint8(0x5278, value);
    }

    // Getters and Setters for address 0x1138:0x5279/0x165F9.
    // Operation not registered by running code
    public int Get1138_5279_Byte8() {
        return GetUint8(0x5279);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5279_Byte8(byte value) {
        SetUint8(0x5279, value);
    }

    // Getters and Setters for address 0x1138:0x527A/0x165FA.
    // Operation not registered by running code
    public int Get1138_527A_Byte8() {
        return GetUint8(0x527A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_527A_Byte8(byte value) {
        SetUint8(0x527A, value);
    }

    // Getters and Setters for address 0x1138:0x527B/0x165FB.
    // Operation not registered by running code
    public int Get1138_527B_Byte8() {
        return GetUint8(0x527B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_527B_Byte8(byte value) {
        SetUint8(0x527B, value);
    }

    // Getters and Setters for address 0x1138:0x527C/0x165FC.
    // Operation not registered by running code
    public int Get1138_527C_Byte8() {
        return GetUint8(0x527C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_527C_Byte8(byte value) {
        SetUint8(0x527C, value);
    }

    // Getters and Setters for address 0x1138:0x527D/0x165FD.
    // Operation not registered by running code
    public int Get1138_527D_Byte8() {
        return GetUint8(0x527D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_527D_Byte8(byte value) {
        SetUint8(0x527D, value);
    }

    // Getters and Setters for address 0x1138:0x527E/0x165FE.
    // Operation not registered by running code
    public int Get1138_527E_Byte8() {
        return GetUint8(0x527E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_527E_Byte8(byte value) {
        SetUint8(0x527E, value);
    }

    // Getters and Setters for address 0x1138:0x527F/0x165FF.
    // Operation not registered by running code
    public int Get1138_527F_Byte8() {
        return GetUint8(0x527F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_527F_Byte8(byte value) {
        SetUint8(0x527F, value);
    }

    // Getters and Setters for address 0x1138:0x5280/0x16600.
    // Operation not registered by running code
    public int Get1138_5280_Byte8() {
        return GetUint8(0x5280);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5280_Byte8(byte value) {
        SetUint8(0x5280, value);
    }

    // Getters and Setters for address 0x1138:0x5281/0x16601.
    // Operation not registered by running code
    public int Get1138_5281_Byte8() {
        return GetUint8(0x5281);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5281_Byte8(byte value) {
        SetUint8(0x5281, value);
    }

    // Getters and Setters for address 0x1138:0x5282/0x16602.
    // Operation not registered by running code
    public int Get1138_5282_Byte8() {
        return GetUint8(0x5282);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5282_Byte8(byte value) {
        SetUint8(0x5282, value);
    }

    // Getters and Setters for address 0x1138:0x5283/0x16603.
    // Operation not registered by running code
    public int Get1138_5283_Byte8() {
        return GetUint8(0x5283);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5283_Byte8(byte value) {
        SetUint8(0x5283, value);
    }

    // Getters and Setters for address 0x1138:0x5284/0x16604.
    // Operation not registered by running code
    public int Get1138_5284_Byte8() {
        return GetUint8(0x5284);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5284_Byte8(byte value) {
        SetUint8(0x5284, value);
    }

    // Getters and Setters for address 0x1138:0x5285/0x16605.
    // Operation not registered by running code
    public int Get1138_5285_Byte8() {
        return GetUint8(0x5285);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5285_Byte8(byte value) {
        SetUint8(0x5285, value);
    }

    // Getters and Setters for address 0x1138:0x5286/0x16606.
    // Operation not registered by running code
    public int Get1138_5286_Byte8() {
        return GetUint8(0x5286);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5286_Byte8(byte value) {
        SetUint8(0x5286, value);
    }

    // Getters and Setters for address 0x1138:0x5287/0x16607.
    // Operation not registered by running code
    public int Get1138_5287_Byte8() {
        return GetUint8(0x5287);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5287_Byte8(byte value) {
        SetUint8(0x5287, value);
    }

    // Getters and Setters for address 0x1138:0x5288/0x16608.
    // Operation not registered by running code
    public int Get1138_5288_Byte8() {
        return GetUint8(0x5288);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5288_Byte8(byte value) {
        SetUint8(0x5288, value);
    }

    // Getters and Setters for address 0x1138:0x5289/0x16609.
    // Operation not registered by running code
    public int Get1138_5289_Byte8() {
        return GetUint8(0x5289);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5289_Byte8(byte value) {
        SetUint8(0x5289, value);
    }

    // Getters and Setters for address 0x1138:0x528A/0x1660A.
    // Operation not registered by running code
    public int Get1138_528A_Byte8() {
        return GetUint8(0x528A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_528A_Byte8(byte value) {
        SetUint8(0x528A, value);
    }

    // Getters and Setters for address 0x1138:0x528B/0x1660B.
    // Operation not registered by running code
    public int Get1138_528B_Byte8() {
        return GetUint8(0x528B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_528B_Byte8(byte value) {
        SetUint8(0x528B, value);
    }

    // Getters and Setters for address 0x1138:0x528C/0x1660C.
    // Operation not registered by running code
    public int Get1138_528C_Byte8() {
        return GetUint8(0x528C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_528C_Byte8(byte value) {
        SetUint8(0x528C, value);
    }

    // Getters and Setters for address 0x1138:0x528D/0x1660D.
    // Operation not registered by running code
    public int Get1138_528D_Byte8() {
        return GetUint8(0x528D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_528D_Byte8(byte value) {
        SetUint8(0x528D, value);
    }

    // Getters and Setters for address 0x1138:0x528E/0x1660E.
    // Operation not registered by running code
    public int Get1138_528E_Byte8() {
        return GetUint8(0x528E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_528E_Byte8(byte value) {
        SetUint8(0x528E, value);
    }

    // Getters and Setters for address 0x1138:0x528F/0x1660F.
    // Operation not registered by running code
    public int Get1138_528F_Byte8() {
        return GetUint8(0x528F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_528F_Byte8(byte value) {
        SetUint8(0x528F, value);
    }

    // Getters and Setters for address 0x1138:0x5290/0x16610.
    // Operation not registered by running code
    public int Get1138_5290_Byte8() {
        return GetUint8(0x5290);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5290_Byte8(byte value) {
        SetUint8(0x5290, value);
    }

    // Getters and Setters for address 0x1138:0x5291/0x16611.
    // Operation not registered by running code
    public int Get1138_5291_Byte8() {
        return GetUint8(0x5291);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5291_Byte8(byte value) {
        SetUint8(0x5291, value);
    }

    // Getters and Setters for address 0x1138:0x5292/0x16612.
    // Operation not registered by running code
    public int Get1138_5292_Byte8() {
        return GetUint8(0x5292);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5292_Byte8(byte value) {
        SetUint8(0x5292, value);
    }

    // Getters and Setters for address 0x1138:0x5293/0x16613.
    // Operation not registered by running code
    public int Get1138_5293_Byte8() {
        return GetUint8(0x5293);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5293_Byte8(byte value) {
        SetUint8(0x5293, value);
    }

    // Getters and Setters for address 0x1138:0x5294/0x16614.
    // Operation not registered by running code
    public int Get1138_5294_Byte8() {
        return GetUint8(0x5294);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5294_Byte8(byte value) {
        SetUint8(0x5294, value);
    }

    // Getters and Setters for address 0x1138:0x5295/0x16615.
    // Operation not registered by running code
    public int Get1138_5295_Byte8() {
        return GetUint8(0x5295);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5295_Byte8(byte value) {
        SetUint8(0x5295, value);
    }

    // Getters and Setters for address 0x1138:0x5296/0x16616.
    // Operation not registered by running code
    public int Get1138_5296_Byte8() {
        return GetUint8(0x5296);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5296_Byte8(byte value) {
        SetUint8(0x5296, value);
    }

    // Getters and Setters for address 0x1138:0x5297/0x16617.
    // Operation not registered by running code
    public int Get1138_5297_Byte8() {
        return GetUint8(0x5297);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5297_Byte8(byte value) {
        SetUint8(0x5297, value);
    }

    // Getters and Setters for address 0x1138:0x5298/0x16618.
    // Operation not registered by running code
    public int Get1138_5298_Byte8() {
        return GetUint8(0x5298);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5298_Byte8(byte value) {
        SetUint8(0x5298, value);
    }

    // Getters and Setters for address 0x1138:0x5299/0x16619.
    // Operation not registered by running code
    public int Get1138_5299_Byte8() {
        return GetUint8(0x5299);
    }

    // Was accessed via the following registers: SS
    public void Set1138_5299_Byte8(byte value) {
        SetUint8(0x5299, value);
    }

    // Getters and Setters for address 0x1138:0x529A/0x1661A.
    // Operation not registered by running code
    public int Get1138_529A_Byte8() {
        return GetUint8(0x529A);
    }

    // Was accessed via the following registers: SS
    public void Set1138_529A_Byte8(byte value) {
        SetUint8(0x529A, value);
    }

    // Getters and Setters for address 0x1138:0x529B/0x1661B.
    // Operation not registered by running code
    public int Get1138_529B_Byte8() {
        return GetUint8(0x529B);
    }

    // Was accessed via the following registers: SS
    public void Set1138_529B_Byte8(byte value) {
        SetUint8(0x529B, value);
    }

    // Getters and Setters for address 0x1138:0x529C/0x1661C.
    // Operation not registered by running code
    public int Get1138_529C_Byte8() {
        return GetUint8(0x529C);
    }

    // Was accessed via the following registers: SS
    public void Set1138_529C_Byte8(byte value) {
        SetUint8(0x529C, value);
    }

    // Getters and Setters for address 0x1138:0x529D/0x1661D.
    // Operation not registered by running code
    public int Get1138_529D_Byte8() {
        return GetUint8(0x529D);
    }

    // Was accessed via the following registers: SS
    public void Set1138_529D_Byte8(byte value) {
        SetUint8(0x529D, value);
    }

    // Getters and Setters for address 0x1138:0x529E/0x1661E.
    // Operation not registered by running code
    public int Get1138_529E_Byte8() {
        return GetUint8(0x529E);
    }

    // Was accessed via the following registers: SS
    public void Set1138_529E_Byte8(byte value) {
        SetUint8(0x529E, value);
    }

    // Getters and Setters for address 0x1138:0x529F/0x1661F.
    // Operation not registered by running code
    public int Get1138_529F_Byte8() {
        return GetUint8(0x529F);
    }

    // Was accessed via the following registers: SS
    public void Set1138_529F_Byte8(byte value) {
        SetUint8(0x529F, value);
    }

    // Getters and Setters for address 0x1138:0x52A0/0x16620.
    // Operation not registered by running code
    public int Get1138_52A0_Byte8() {
        return GetUint8(0x52A0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52A0_Byte8(byte value) {
        SetUint8(0x52A0, value);
    }

    // Getters and Setters for address 0x1138:0x52A1/0x16621.
    // Operation not registered by running code
    public int Get1138_52A1_Byte8() {
        return GetUint8(0x52A1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52A1_Byte8(byte value) {
        SetUint8(0x52A1, value);
    }

    // Getters and Setters for address 0x1138:0x52A2/0x16622.
    // Operation not registered by running code
    public int Get1138_52A2_Byte8() {
        return GetUint8(0x52A2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52A2_Byte8(byte value) {
        SetUint8(0x52A2, value);
    }

    // Getters and Setters for address 0x1138:0x52A3/0x16623.
    // Operation not registered by running code
    public int Get1138_52A3_Byte8() {
        return GetUint8(0x52A3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52A3_Byte8(byte value) {
        SetUint8(0x52A3, value);
    }

    // Getters and Setters for address 0x1138:0x52A4/0x16624.
    // Operation not registered by running code
    public int Get1138_52A4_Byte8() {
        return GetUint8(0x52A4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52A4_Byte8(byte value) {
        SetUint8(0x52A4, value);
    }

    // Getters and Setters for address 0x1138:0x52A5/0x16625.
    // Operation not registered by running code
    public int Get1138_52A5_Byte8() {
        return GetUint8(0x52A5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52A5_Byte8(byte value) {
        SetUint8(0x52A5, value);
    }

    // Getters and Setters for address 0x1138:0x52A6/0x16626.
    // Operation not registered by running code
    public int Get1138_52A6_Byte8() {
        return GetUint8(0x52A6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52A6_Byte8(byte value) {
        SetUint8(0x52A6, value);
    }

    // Getters and Setters for address 0x1138:0x52A7/0x16627.
    // Operation not registered by running code
    public int Get1138_52A7_Byte8() {
        return GetUint8(0x52A7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52A7_Byte8(byte value) {
        SetUint8(0x52A7, value);
    }

    // Getters and Setters for address 0x1138:0x52A8/0x16628.
    // Operation not registered by running code
    public int Get1138_52A8_Byte8() {
        return GetUint8(0x52A8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52A8_Byte8(byte value) {
        SetUint8(0x52A8, value);
    }

    // Getters and Setters for address 0x1138:0x52A9/0x16629.
    // Operation not registered by running code
    public int Get1138_52A9_Byte8() {
        return GetUint8(0x52A9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52A9_Byte8(byte value) {
        SetUint8(0x52A9, value);
    }

    // Getters and Setters for address 0x1138:0x52AA/0x1662A.
    // Operation not registered by running code
    public int Get1138_52AA_Byte8() {
        return GetUint8(0x52AA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52AA_Byte8(byte value) {
        SetUint8(0x52AA, value);
    }

    // Getters and Setters for address 0x1138:0x52AB/0x1662B.
    // Operation not registered by running code
    public int Get1138_52AB_Byte8() {
        return GetUint8(0x52AB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52AB_Byte8(byte value) {
        SetUint8(0x52AB, value);
    }

    // Getters and Setters for address 0x1138:0x52AC/0x1662C.
    // Operation not registered by running code
    public int Get1138_52AC_Byte8() {
        return GetUint8(0x52AC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52AC_Byte8(byte value) {
        SetUint8(0x52AC, value);
    }

    // Getters and Setters for address 0x1138:0x52AD/0x1662D.
    // Operation not registered by running code
    public int Get1138_52AD_Byte8() {
        return GetUint8(0x52AD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52AD_Byte8(byte value) {
        SetUint8(0x52AD, value);
    }

    // Getters and Setters for address 0x1138:0x52AE/0x1662E.
    // Operation not registered by running code
    public int Get1138_52AE_Byte8() {
        return GetUint8(0x52AE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52AE_Byte8(byte value) {
        SetUint8(0x52AE, value);
    }

    // Getters and Setters for address 0x1138:0x52AF/0x1662F.
    // Operation not registered by running code
    public int Get1138_52AF_Byte8() {
        return GetUint8(0x52AF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52AF_Byte8(byte value) {
        SetUint8(0x52AF, value);
    }

    // Getters and Setters for address 0x1138:0x52B0/0x16630.
    // Operation not registered by running code
    public int Get1138_52B0_Byte8() {
        return GetUint8(0x52B0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52B0_Byte8(byte value) {
        SetUint8(0x52B0, value);
    }

    // Getters and Setters for address 0x1138:0x52B1/0x16631.
    // Operation not registered by running code
    public int Get1138_52B1_Byte8() {
        return GetUint8(0x52B1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52B1_Byte8(byte value) {
        SetUint8(0x52B1, value);
    }

    // Getters and Setters for address 0x1138:0x52B2/0x16632.
    // Operation not registered by running code
    public int Get1138_52B2_Byte8() {
        return GetUint8(0x52B2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52B2_Byte8(byte value) {
        SetUint8(0x52B2, value);
    }

    // Getters and Setters for address 0x1138:0x52B3/0x16633.
    // Operation not registered by running code
    public int Get1138_52B3_Byte8() {
        return GetUint8(0x52B3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52B3_Byte8(byte value) {
        SetUint8(0x52B3, value);
    }

    // Getters and Setters for address 0x1138:0x52B4/0x16634.
    // Operation not registered by running code
    public int Get1138_52B4_Byte8() {
        return GetUint8(0x52B4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52B4_Byte8(byte value) {
        SetUint8(0x52B4, value);
    }

    // Getters and Setters for address 0x1138:0x52B5/0x16635.
    // Operation not registered by running code
    public int Get1138_52B5_Byte8() {
        return GetUint8(0x52B5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52B5_Byte8(byte value) {
        SetUint8(0x52B5, value);
    }

    // Getters and Setters for address 0x1138:0x52B6/0x16636.
    // Operation not registered by running code
    public int Get1138_52B6_Byte8() {
        return GetUint8(0x52B6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52B6_Byte8(byte value) {
        SetUint8(0x52B6, value);
    }

    // Getters and Setters for address 0x1138:0x52B7/0x16637.
    // Operation not registered by running code
    public int Get1138_52B7_Byte8() {
        return GetUint8(0x52B7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52B7_Byte8(byte value) {
        SetUint8(0x52B7, value);
    }

    // Getters and Setters for address 0x1138:0x52B8/0x16638.
    // Operation not registered by running code
    public int Get1138_52B8_Byte8() {
        return GetUint8(0x52B8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52B8_Byte8(byte value) {
        SetUint8(0x52B8, value);
    }

    // Getters and Setters for address 0x1138:0x52B9/0x16639.
    // Operation not registered by running code
    public int Get1138_52B9_Byte8() {
        return GetUint8(0x52B9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52B9_Byte8(byte value) {
        SetUint8(0x52B9, value);
    }

    // Getters and Setters for address 0x1138:0x52BA/0x1663A.
    // Operation not registered by running code
    public int Get1138_52BA_Byte8() {
        return GetUint8(0x52BA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52BA_Byte8(byte value) {
        SetUint8(0x52BA, value);
    }

    // Getters and Setters for address 0x1138:0x52BB/0x1663B.
    // Operation not registered by running code
    public int Get1138_52BB_Byte8() {
        return GetUint8(0x52BB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52BB_Byte8(byte value) {
        SetUint8(0x52BB, value);
    }

    // Getters and Setters for address 0x1138:0x52BC/0x1663C.
    // Operation not registered by running code
    public int Get1138_52BC_Byte8() {
        return GetUint8(0x52BC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52BC_Byte8(byte value) {
        SetUint8(0x52BC, value);
    }

    // Getters and Setters for address 0x1138:0x52BD/0x1663D.
    // Operation not registered by running code
    public int Get1138_52BD_Byte8() {
        return GetUint8(0x52BD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52BD_Byte8(byte value) {
        SetUint8(0x52BD, value);
    }

    // Getters and Setters for address 0x1138:0x52BE/0x1663E.
    // Operation not registered by running code
    public int Get1138_52BE_Byte8() {
        return GetUint8(0x52BE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52BE_Byte8(byte value) {
        SetUint8(0x52BE, value);
    }

    // Getters and Setters for address 0x1138:0x52BF/0x1663F.
    // Operation not registered by running code
    public int Get1138_52BF_Byte8() {
        return GetUint8(0x52BF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52BF_Byte8(byte value) {
        SetUint8(0x52BF, value);
    }

    // Getters and Setters for address 0x1138:0x52C0/0x16640.
    // Operation not registered by running code
    public int Get1138_52C0_Byte8() {
        return GetUint8(0x52C0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52C0_Byte8(byte value) {
        SetUint8(0x52C0, value);
    }

    // Getters and Setters for address 0x1138:0x52C1/0x16641.
    // Operation not registered by running code
    public int Get1138_52C1_Byte8() {
        return GetUint8(0x52C1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52C1_Byte8(byte value) {
        SetUint8(0x52C1, value);
    }

    // Getters and Setters for address 0x1138:0x52C2/0x16642.
    // Operation not registered by running code
    public int Get1138_52C2_Byte8() {
        return GetUint8(0x52C2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52C2_Byte8(byte value) {
        SetUint8(0x52C2, value);
    }

    // Getters and Setters for address 0x1138:0x52C3/0x16643.
    // Operation not registered by running code
    public int Get1138_52C3_Byte8() {
        return GetUint8(0x52C3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52C3_Byte8(byte value) {
        SetUint8(0x52C3, value);
    }

    // Getters and Setters for address 0x1138:0x52C4/0x16644.
    // Operation not registered by running code
    public int Get1138_52C4_Byte8() {
        return GetUint8(0x52C4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52C4_Byte8(byte value) {
        SetUint8(0x52C4, value);
    }

    // Getters and Setters for address 0x1138:0x52C5/0x16645.
    // Operation not registered by running code
    public int Get1138_52C5_Byte8() {
        return GetUint8(0x52C5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52C5_Byte8(byte value) {
        SetUint8(0x52C5, value);
    }

    // Getters and Setters for address 0x1138:0x52C6/0x16646.
    // Operation not registered by running code
    public int Get1138_52C6_Byte8() {
        return GetUint8(0x52C6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52C6_Byte8(byte value) {
        SetUint8(0x52C6, value);
    }

    // Getters and Setters for address 0x1138:0x52C7/0x16647.
    // Operation not registered by running code
    public int Get1138_52C7_Byte8() {
        return GetUint8(0x52C7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52C7_Byte8(byte value) {
        SetUint8(0x52C7, value);
    }

    // Getters and Setters for address 0x1138:0x52C8/0x16648.
    // Operation not registered by running code
    public int Get1138_52C8_Byte8() {
        return GetUint8(0x52C8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52C8_Byte8(byte value) {
        SetUint8(0x52C8, value);
    }

    // Getters and Setters for address 0x1138:0x52C9/0x16649.
    // Operation not registered by running code
    public int Get1138_52C9_Byte8() {
        return GetUint8(0x52C9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52C9_Byte8(byte value) {
        SetUint8(0x52C9, value);
    }

    // Getters and Setters for address 0x1138:0x52CA/0x1664A.
    // Operation not registered by running code
    public int Get1138_52CA_Byte8() {
        return GetUint8(0x52CA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52CA_Byte8(byte value) {
        SetUint8(0x52CA, value);
    }

    // Getters and Setters for address 0x1138:0x52CB/0x1664B.
    // Operation not registered by running code
    public int Get1138_52CB_Byte8() {
        return GetUint8(0x52CB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52CB_Byte8(byte value) {
        SetUint8(0x52CB, value);
    }

    // Getters and Setters for address 0x1138:0x52CC/0x1664C.
    // Operation not registered by running code
    public int Get1138_52CC_Byte8() {
        return GetUint8(0x52CC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52CC_Byte8(byte value) {
        SetUint8(0x52CC, value);
    }

    // Getters and Setters for address 0x1138:0x52CD/0x1664D.
    // Operation not registered by running code
    public int Get1138_52CD_Byte8() {
        return GetUint8(0x52CD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52CD_Byte8(byte value) {
        SetUint8(0x52CD, value);
    }

    // Getters and Setters for address 0x1138:0x52CE/0x1664E.
    // Operation not registered by running code
    public int Get1138_52CE_Byte8() {
        return GetUint8(0x52CE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52CE_Byte8(byte value) {
        SetUint8(0x52CE, value);
    }

    // Getters and Setters for address 0x1138:0x52CF/0x1664F.
    // Operation not registered by running code
    public int Get1138_52CF_Byte8() {
        return GetUint8(0x52CF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52CF_Byte8(byte value) {
        SetUint8(0x52CF, value);
    }

    // Getters and Setters for address 0x1138:0x52D0/0x16650.
    // Operation not registered by running code
    public int Get1138_52D0_Byte8() {
        return GetUint8(0x52D0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52D0_Byte8(byte value) {
        SetUint8(0x52D0, value);
    }

    // Getters and Setters for address 0x1138:0x52D1/0x16651.
    // Operation not registered by running code
    public int Get1138_52D1_Byte8() {
        return GetUint8(0x52D1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52D1_Byte8(byte value) {
        SetUint8(0x52D1, value);
    }

    // Getters and Setters for address 0x1138:0x52D2/0x16652.
    // Operation not registered by running code
    public int Get1138_52D2_Byte8() {
        return GetUint8(0x52D2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52D2_Byte8(byte value) {
        SetUint8(0x52D2, value);
    }

    // Getters and Setters for address 0x1138:0x52D3/0x16653.
    // Operation not registered by running code
    public int Get1138_52D3_Byte8() {
        return GetUint8(0x52D3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52D3_Byte8(byte value) {
        SetUint8(0x52D3, value);
    }

    // Getters and Setters for address 0x1138:0x52D4/0x16654.
    // Operation not registered by running code
    public int Get1138_52D4_Byte8() {
        return GetUint8(0x52D4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52D4_Byte8(byte value) {
        SetUint8(0x52D4, value);
    }

    // Getters and Setters for address 0x1138:0x52D5/0x16655.
    // Operation not registered by running code
    public int Get1138_52D5_Byte8() {
        return GetUint8(0x52D5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52D5_Byte8(byte value) {
        SetUint8(0x52D5, value);
    }

    // Getters and Setters for address 0x1138:0x52D6/0x16656.
    // Operation not registered by running code
    public int Get1138_52D6_Byte8() {
        return GetUint8(0x52D6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52D6_Byte8(byte value) {
        SetUint8(0x52D6, value);
    }

    // Getters and Setters for address 0x1138:0x52D7/0x16657.
    // Operation not registered by running code
    public int Get1138_52D7_Byte8() {
        return GetUint8(0x52D7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52D7_Byte8(byte value) {
        SetUint8(0x52D7, value);
    }

    // Getters and Setters for address 0x1138:0x52D8/0x16658.
    // Operation not registered by running code
    public int Get1138_52D8_Byte8() {
        return GetUint8(0x52D8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52D8_Byte8(byte value) {
        SetUint8(0x52D8, value);
    }

    // Getters and Setters for address 0x1138:0x52D9/0x16659.
    // Operation not registered by running code
    public int Get1138_52D9_Byte8() {
        return GetUint8(0x52D9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52D9_Byte8(byte value) {
        SetUint8(0x52D9, value);
    }

    // Getters and Setters for address 0x1138:0x52DA/0x1665A.
    // Operation not registered by running code
    public int Get1138_52DA_Byte8() {
        return GetUint8(0x52DA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52DA_Byte8(byte value) {
        SetUint8(0x52DA, value);
    }

    // Getters and Setters for address 0x1138:0x52DB/0x1665B.
    // Operation not registered by running code
    public int Get1138_52DB_Byte8() {
        return GetUint8(0x52DB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52DB_Byte8(byte value) {
        SetUint8(0x52DB, value);
    }

    // Getters and Setters for address 0x1138:0x52DC/0x1665C.
    // Operation not registered by running code
    public int Get1138_52DC_Byte8() {
        return GetUint8(0x52DC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52DC_Byte8(byte value) {
        SetUint8(0x52DC, value);
    }

    // Getters and Setters for address 0x1138:0x52DD/0x1665D.
    // Operation not registered by running code
    public int Get1138_52DD_Byte8() {
        return GetUint8(0x52DD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52DD_Byte8(byte value) {
        SetUint8(0x52DD, value);
    }

    // Getters and Setters for address 0x1138:0x52DE/0x1665E.
    // Operation not registered by running code
    public int Get1138_52DE_Byte8() {
        return GetUint8(0x52DE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52DE_Byte8(byte value) {
        SetUint8(0x52DE, value);
    }

    // Getters and Setters for address 0x1138:0x52DF/0x1665F.
    // Operation not registered by running code
    public int Get1138_52DF_Byte8() {
        return GetUint8(0x52DF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52DF_Byte8(byte value) {
        SetUint8(0x52DF, value);
    }

    // Getters and Setters for address 0x1138:0x52E0/0x16660.
    // Operation not registered by running code
    public int Get1138_52E0_Byte8() {
        return GetUint8(0x52E0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52E0_Byte8(byte value) {
        SetUint8(0x52E0, value);
    }

    // Getters and Setters for address 0x1138:0x52E1/0x16661.
    // Operation not registered by running code
    public int Get1138_52E1_Byte8() {
        return GetUint8(0x52E1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52E1_Byte8(byte value) {
        SetUint8(0x52E1, value);
    }

    // Getters and Setters for address 0x1138:0x52E2/0x16662.
    // Operation not registered by running code
    public int Get1138_52E2_Byte8() {
        return GetUint8(0x52E2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52E2_Byte8(byte value) {
        SetUint8(0x52E2, value);
    }

    // Getters and Setters for address 0x1138:0x52E3/0x16663.
    // Operation not registered by running code
    public int Get1138_52E3_Byte8() {
        return GetUint8(0x52E3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52E3_Byte8(byte value) {
        SetUint8(0x52E3, value);
    }

    // Getters and Setters for address 0x1138:0x52E4/0x16664.
    // Operation not registered by running code
    public int Get1138_52E4_Byte8() {
        return GetUint8(0x52E4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52E4_Byte8(byte value) {
        SetUint8(0x52E4, value);
    }

    // Getters and Setters for address 0x1138:0x52E5/0x16665.
    // Operation not registered by running code
    public int Get1138_52E5_Byte8() {
        return GetUint8(0x52E5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52E5_Byte8(byte value) {
        SetUint8(0x52E5, value);
    }

    // Getters and Setters for address 0x1138:0x52E6/0x16666.
    // Operation not registered by running code
    public int Get1138_52E6_Byte8() {
        return GetUint8(0x52E6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52E6_Byte8(byte value) {
        SetUint8(0x52E6, value);
    }

    // Getters and Setters for address 0x1138:0x52E7/0x16667.
    // Operation not registered by running code
    public int Get1138_52E7_Byte8() {
        return GetUint8(0x52E7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52E7_Byte8(byte value) {
        SetUint8(0x52E7, value);
    }

    // Getters and Setters for address 0x1138:0x52E8/0x16668.
    // Operation not registered by running code
    public int Get1138_52E8_Byte8() {
        return GetUint8(0x52E8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52E8_Byte8(byte value) {
        SetUint8(0x52E8, value);
    }

    // Getters and Setters for address 0x1138:0x52E9/0x16669.
    // Operation not registered by running code
    public int Get1138_52E9_Byte8() {
        return GetUint8(0x52E9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52E9_Byte8(byte value) {
        SetUint8(0x52E9, value);
    }

    // Getters and Setters for address 0x1138:0x52EA/0x1666A.
    // Operation not registered by running code
    public int Get1138_52EA_Byte8() {
        return GetUint8(0x52EA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52EA_Byte8(byte value) {
        SetUint8(0x52EA, value);
    }

    // Getters and Setters for address 0x1138:0x52EB/0x1666B.
    // Operation not registered by running code
    public int Get1138_52EB_Byte8() {
        return GetUint8(0x52EB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52EB_Byte8(byte value) {
        SetUint8(0x52EB, value);
    }

    // Getters and Setters for address 0x1138:0x52EC/0x1666C.
    // Operation not registered by running code
    public int Get1138_52EC_Byte8() {
        return GetUint8(0x52EC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52EC_Byte8(byte value) {
        SetUint8(0x52EC, value);
    }

    // Getters and Setters for address 0x1138:0x52ED/0x1666D.
    // Operation not registered by running code
    public int Get1138_52ED_Byte8() {
        return GetUint8(0x52ED);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52ED_Byte8(byte value) {
        SetUint8(0x52ED, value);
    }

    // Getters and Setters for address 0x1138:0x52EE/0x1666E.
    // Operation not registered by running code
    public int Get1138_52EE_Byte8() {
        return GetUint8(0x52EE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52EE_Byte8(byte value) {
        SetUint8(0x52EE, value);
    }

    // Getters and Setters for address 0x1138:0x52EF/0x1666F.
    // Operation not registered by running code
    public int Get1138_52EF_Byte8() {
        return GetUint8(0x52EF);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52EF_Byte8(byte value) {
        SetUint8(0x52EF, value);
    }

    // Getters and Setters for address 0x1138:0x52F0/0x16670.
    // Operation not registered by running code
    public int Get1138_52F0_Byte8() {
        return GetUint8(0x52F0);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52F0_Byte8(byte value) {
        SetUint8(0x52F0, value);
    }

    // Getters and Setters for address 0x1138:0x52F1/0x16671.
    // Operation not registered by running code
    public int Get1138_52F1_Byte8() {
        return GetUint8(0x52F1);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52F1_Byte8(byte value) {
        SetUint8(0x52F1, value);
    }

    // Getters and Setters for address 0x1138:0x52F2/0x16672.
    // Operation not registered by running code
    public int Get1138_52F2_Byte8() {
        return GetUint8(0x52F2);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52F2_Byte8(byte value) {
        SetUint8(0x52F2, value);
    }

    // Getters and Setters for address 0x1138:0x52F3/0x16673.
    // Operation not registered by running code
    public int Get1138_52F3_Byte8() {
        return GetUint8(0x52F3);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52F3_Byte8(byte value) {
        SetUint8(0x52F3, value);
    }

    // Getters and Setters for address 0x1138:0x52F4/0x16674.
    // Operation not registered by running code
    public int Get1138_52F4_Byte8() {
        return GetUint8(0x52F4);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52F4_Byte8(byte value) {
        SetUint8(0x52F4, value);
    }

    // Getters and Setters for address 0x1138:0x52F5/0x16675.
    // Operation not registered by running code
    public int Get1138_52F5_Byte8() {
        return GetUint8(0x52F5);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52F5_Byte8(byte value) {
        SetUint8(0x52F5, value);
    }

    // Getters and Setters for address 0x1138:0x52F6/0x16676.
    // Operation not registered by running code
    public int Get1138_52F6_Byte8() {
        return GetUint8(0x52F6);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52F6_Byte8(byte value) {
        SetUint8(0x52F6, value);
    }

    // Getters and Setters for address 0x1138:0x52F7/0x16677.
    // Operation not registered by running code
    public int Get1138_52F7_Byte8() {
        return GetUint8(0x52F7);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52F7_Byte8(byte value) {
        SetUint8(0x52F7, value);
    }

    // Getters and Setters for address 0x1138:0x52F8/0x16678.
    // Operation not registered by running code
    public int Get1138_52F8_Byte8() {
        return GetUint8(0x52F8);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52F8_Byte8(byte value) {
        SetUint8(0x52F8, value);
    }

    // Getters and Setters for address 0x1138:0x52F9/0x16679.
    // Operation not registered by running code
    public int Get1138_52F9_Byte8() {
        return GetUint8(0x52F9);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52F9_Byte8(byte value) {
        SetUint8(0x52F9, value);
    }

    // Getters and Setters for address 0x1138:0x52FA/0x1667A.
    // Operation not registered by running code
    public int Get1138_52FA_Byte8() {
        return GetUint8(0x52FA);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52FA_Byte8(byte value) {
        SetUint8(0x52FA, value);
    }

    // Getters and Setters for address 0x1138:0x52FB/0x1667B.
    // Operation not registered by running code
    public int Get1138_52FB_Byte8() {
        return GetUint8(0x52FB);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52FB_Byte8(byte value) {
        SetUint8(0x52FB, value);
    }

    // Getters and Setters for address 0x1138:0x52FC/0x1667C.
    // Operation not registered by running code
    public int Get1138_52FC_Byte8() {
        return GetUint8(0x52FC);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52FC_Byte8(byte value) {
        SetUint8(0x52FC, value);
    }

    // Getters and Setters for address 0x1138:0x52FD/0x1667D.
    // Operation not registered by running code
    public int Get1138_52FD_Byte8() {
        return GetUint8(0x52FD);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52FD_Byte8(byte value) {
        SetUint8(0x52FD, value);
    }

    // Getters and Setters for address 0x1138:0x52FE/0x1667E.
    // Operation not registered by running code
    public int Get1138_52FE_Byte8() {
        return GetUint8(0x52FE);
    }

    // Was accessed via the following registers: SS
    public void Set1138_52FE_Byte8(byte value) {
        SetUint8(0x52FE, value);
    }

    // Getters and Setters for address 0x1138:0x8B79/0x19EF9.
    // Was accessed via the following registers: SS
    public int Get1138_8B79_Word16() {
        return GetUint16(0x8B79);
    }

    // Operation not registered by running code
    public void Set1138_8B79_Word16(byte value) {
        SetUint16(0x8B79, value);
    }

    // Getters and Setters for address 0x1138:0x8B7B/0x19EFB.
    // Was accessed via the following registers: SS
    public int Get1138_8B7B_Word16() {
        return GetUint16(0x8B7B);
    }

    // Operation not registered by running code
    public void Set1138_8B7B_Word16(ushort value) {
        SetUint16(0x8B7B, value);
    }

    // Getters and Setters for address 0x1138:0x8B7D/0x19EFD.
    // Was accessed via the following registers: SS
    public int Get1138_8B7D_Word16() {
        return GetUint16(0x8B7D);
    }

    // Operation not registered by running code
    public void Set1138_8B7D_Word16(ushort value) {
        SetUint16(0x8B7D, value);
    }

    // Getters and Setters for address 0x1138:0x8B7F/0x19EFF.
    // Was accessed via the following registers: SS
    public int Get1138_8B7F_Word16() {
        return GetUint16(0x8B7F);
    }

    // Operation not registered by running code
    public void Set1138_8B7F_Word16(ushort value) {
        SetUint16(0x8B7F, value);
    }

    // Getters and Setters for address 0x1138:0x8B81/0x19F01.
    // Was accessed via the following registers: SS
    public int Get1138_8B81_Word16() {
        return GetUint16(0x8B81);
    }

    // Operation not registered by running code
    public void Set1138_8B81_Word16(ushort value) {
        SetUint16(0x8B81, value);
    }

    // Getters and Setters for address 0x1138:0x8B83/0x19F03.
    // Was accessed via the following registers: SS
    public int Get1138_8B83_Word16() {
        return GetUint16(0x8B83);
    }

    // Operation not registered by running code
    public void Set1138_8B83_Word16(ushort value) {
        SetUint16(0x8B83, value);
    }

    // Getters and Setters for address 0x1138:0x8B85/0x19F05.
    // Was accessed via the following registers: SS
    public int Get1138_8B85_Word16() {
        return GetUint16(0x8B85);
    }

    // Operation not registered by running code
    public void Set1138_8B85_Word16(ushort value) {
        SetUint16(0x8B85, value);
    }

    // Getters and Setters for address 0x1138:0x8B87/0x19F07.
    // Was accessed via the following registers: SS
    public int Get1138_8B87_Word16() {
        return GetUint16(0x8B87);
    }

    // Operation not registered by running code
    public void Set1138_8B87_Word16(ushort value) {
        SetUint16(0x8B87, value);
    }

    // Getters and Setters for address 0x1138:0x8B89/0x19F09.
    // Was accessed via the following registers: SS
    public int Get1138_8B89_Word16() {
        return GetUint16(0x8B89);
    }

    // Operation not registered by running code
    public void Set1138_8B89_Word16(ushort value) {
        SetUint16(0x8B89, value);
    }

    // Getters and Setters for address 0x1138:0x8B8B/0x19F0B.
    // Was accessed via the following registers: SS
    public int Get1138_8B8B_Word16() {
        return GetUint16(0x8B8B);
    }

    // Operation not registered by running code
    public void Set1138_8B8B_Word16(ushort value) {
        SetUint16(0x8B8B, value);
    }

    // Getters and Setters for address 0x1138:0x8B8D/0x19F0D.
    // Was accessed via the following registers: SS
    public int Get1138_8B8D_Word16() {
        return GetUint16(0x8B8D);
    }

    // Operation not registered by running code
    public void Set1138_8B8D_Word16(ushort value) {
        SetUint16(0x8B8D, value);
    }

    // Getters and Setters for address 0x1138:0x8B8F/0x19F0F.
    // Was accessed via the following registers: SS
    public int Get1138_8B8F_Word16() {
        return GetUint16(0x8B8F);
    }

    // Operation not registered by running code
    public void Set1138_8B8F_Word16(ushort value) {
        SetUint16(0x8B8F, value);
    }

    // Getters and Setters for address 0x1138:0x8B91/0x19F11.
    // Was accessed via the following registers: SS
    public int Get1138_8B91_Word16() {
        return GetUint16(0x8B91);
    }

    // Operation not registered by running code
    public void Set1138_8B91_Word16(ushort value) {
        SetUint16(0x8B91, value);
    }

    // Getters and Setters for address 0x1138:0x8B93/0x19F13.
    // Was accessed via the following registers: SS
    public int Get1138_8B93_Word16() {
        return GetUint16(0x8B93);
    }

    // Operation not registered by running code
    public void Set1138_8B93_Word16(ushort value) {
        SetUint16(0x8B93, value);
    }

    // Getters and Setters for address 0x1138:0x8B95/0x19F15.
    // Was accessed via the following registers: SS
    public int Get1138_8B95_Word16() {
        return GetUint16(0x8B95);
    }

    // Operation not registered by running code
    public void Set1138_8B95_Word16(ushort value) {
        SetUint16(0x8B95, value);
    }

    // Getters and Setters for address 0x1138:0x8B97/0x19F17.
    // Was accessed via the following registers: SS
    public int Get1138_8B97_Word16() {
        return GetUint16(0x8B97);
    }

    // Operation not registered by running code
    public void Set1138_8B97_Word16(ushort value) {
        SetUint16(0x8B97, value);
    }

    // Getters and Setters for address 0x1138:0x8B99/0x19F19.
    // Was accessed via the following registers: SS
    public int Get1138_8B99_Word16() {
        return GetUint16(0x8B99);
    }

    // Operation not registered by running code
    public void Set1138_8B99_Word16(ushort value) {
        SetUint16(0x8B99, value);
    }

    // Getters and Setters for address 0x1138:0x8B9B/0x19F1B.
    // Was accessed via the following registers: SS
    public int Get1138_8B9B_Word16() {
        return GetUint16(0x8B9B);
    }

    // Operation not registered by running code
    public void Set1138_8B9B_Word16(ushort value) {
        SetUint16(0x8B9B, value);
    }

    // Getters and Setters for address 0x1138:0x8B9D/0x19F1D.
    // Was accessed via the following registers: SS
    public int Get1138_8B9D_Word16() {
        return GetUint16(0x8B9D);
    }

    // Operation not registered by running code
    public void Set1138_8B9D_Word16(ushort value) {
        SetUint16(0x8B9D, value);
    }

    // Getters and Setters for address 0x1138:0x8B9F/0x19F1F.
    // Was accessed via the following registers: SS
    public int Get1138_8B9F_Word16() {
        return GetUint16(0x8B9F);
    }

    // Operation not registered by running code
    public void Set1138_8B9F_Word16(ushort value) {
        SetUint16(0x8B9F, value);
    }

    // Getters and Setters for address 0x1138:0x8BA1/0x19F21.
    // Was accessed via the following registers: SS
    public int Get1138_8BA1_Word16() {
        return GetUint16(0x8BA1);
    }

    // Operation not registered by running code
    public void Set1138_8BA1_Word16(ushort value) {
        SetUint16(0x8BA1, value);
    }

    // Getters and Setters for address 0x1138:0x8BA3/0x19F23.
    // Was accessed via the following registers: SS
    public int Get1138_8BA3_Word16() {
        return GetUint16(0x8BA3);
    }

    // Operation not registered by running code
    public void Set1138_8BA3_Word16(ushort value) {
        SetUint16(0x8BA3, value);
    }

    // Getters and Setters for address 0x1138:0x8BA5/0x19F25.
    // Was accessed via the following registers: SS
    public int Get1138_8BA5_Word16() {
        return GetUint16(0x8BA5);
    }

    // Operation not registered by running code
    public void Set1138_8BA5_Word16(ushort value) {
        SetUint16(0x8BA5, value);
    }

    // Getters and Setters for address 0x1138:0x8BA7/0x19F27.
    // Was accessed via the following registers: SS
    public int Get1138_8BA7_Word16() {
        return GetUint16(0x8BA7);
    }

    // Operation not registered by running code
    public void Set1138_8BA7_Word16(ushort value) {
        SetUint16(0x8BA7, value);
    }

    // Getters and Setters for address 0x1138:0x8BA9/0x19F29.
    // Was accessed via the following registers: SS
    public int Get1138_8BA9_Word16() {
        return GetUint16(0x8BA9);
    }

    // Operation not registered by running code
    public void Set1138_8BA9_Word16(ushort value) {
        SetUint16(0x8BA9, value);
    }

    // Getters and Setters for address 0x1138:0x8BAB/0x19F2B.
    // Was accessed via the following registers: SS
    public int Get1138_8BAB_Word16() {
        return GetUint16(0x8BAB);
    }

    // Operation not registered by running code
    public void Set1138_8BAB_Word16(ushort value) {
        SetUint16(0x8BAB, value);
    }

    // Getters and Setters for address 0x1138:0x8BAD/0x19F2D.
    // Was accessed via the following registers: SS
    public int Get1138_8BAD_Word16() {
        return GetUint16(0x8BAD);
    }

    // Operation not registered by running code
    public void Set1138_8BAD_Word16(ushort value) {
        SetUint16(0x8BAD, value);
    }

    // Getters and Setters for address 0x1138:0x8BAF/0x19F2F.
    // Was accessed via the following registers: SS
    public int Get1138_8BAF_Word16() {
        return GetUint16(0x8BAF);
    }

    // Operation not registered by running code
    public void Set1138_8BAF_Word16(ushort value) {
        SetUint16(0x8BAF, value);
    }

    // Getters and Setters for address 0x1138:0x8BB1/0x19F31.
    // Was accessed via the following registers: SS
    public int Get1138_8BB1_Word16() {
        return GetUint16(0x8BB1);
    }

    // Operation not registered by running code
    public void Set1138_8BB1_Word16(ushort value) {
        SetUint16(0x8BB1, value);
    }

    // Getters and Setters for address 0x1138:0x8BB3/0x19F33.
    // Was accessed via the following registers: SS
    public int Get1138_8BB3_Word16() {
        return GetUint16(0x8BB3);
    }

    // Operation not registered by running code
    public void Set1138_8BB3_Word16(ushort value) {
        SetUint16(0x8BB3, value);
    }

    // Getters and Setters for address 0x1138:0x8BB5/0x19F35.
    // Was accessed via the following registers: SS
    public int Get1138_8BB5_Word16() {
        return GetUint16(0x8BB5);
    }

    // Operation not registered by running code
    public void Set1138_8BB5_Word16(ushort value) {
        SetUint16(0x8BB5, value);
    }

    // Getters and Setters for address 0x1138:0x8BB7/0x19F37.
    // Was accessed via the following registers: SS
    public int Get1138_8BB7_Word16() {
        return GetUint16(0x8BB7);
    }

    // Operation not registered by running code
    public void Set1138_8BB7_Word16(ushort value) {
        SetUint16(0x8BB7, value);
    }

    // Getters and Setters for address 0x1138:0x8BB9/0x19F39.
    // Was accessed via the following registers: SS
    public int Get1138_8BB9_Word16() {
        return GetUint16(0x8BB9);
    }

    // Operation not registered by running code
    public void Set1138_8BB9_Word16(ushort value) {
        SetUint16(0x8BB9, value);
    }

    // Getters and Setters for address 0x1138:0x8BBB/0x19F3B.
    // Was accessed via the following registers: SS
    public int Get1138_8BBB_Word16() {
        return GetUint16(0x8BBB);
    }

    // Operation not registered by running code
    public void Set1138_8BBB_Word16(ushort value) {
        SetUint16(0x8BBB, value);
    }

    // Getters and Setters for address 0x1138:0x8BBD/0x19F3D.
    // Was accessed via the following registers: SS
    public int Get1138_8BBD_Word16() {
        return GetUint16(0x8BBD);
    }

    // Operation not registered by running code
    public void Set1138_8BBD_Word16(ushort value) {
        SetUint16(0x8BBD, value);
    }

    // Getters and Setters for address 0x1138:0x8BBF/0x19F3F.
    // Was accessed via the following registers: SS
    public int Get1138_8BBF_Word16() {
        return GetUint16(0x8BBF);
    }

    // Operation not registered by running code
    public void Set1138_8BBF_Word16(ushort value) {
        SetUint16(0x8BBF, value);
    }

    // Getters and Setters for address 0x1138:0x8BC1/0x19F41.
    // Was accessed via the following registers: SS
    public int Get1138_8BC1_Word16() {
        return GetUint16(0x8BC1);
    }

    // Operation not registered by running code
    public void Set1138_8BC1_Word16(ushort value) {
        SetUint16(0x8BC1, value);
    }

    // Getters and Setters for address 0x1138:0x8BC3/0x19F43.
    // Was accessed via the following registers: SS
    public int Get1138_8BC3_Word16() {
        return GetUint16(0x8BC3);
    }

    // Operation not registered by running code
    public void Set1138_8BC3_Word16(ushort value) {
        SetUint16(0x8BC3, value);
    }

    // Getters and Setters for address 0x1138:0x8BC5/0x19F45.
    // Was accessed via the following registers: SS
    public int Get1138_8BC5_Word16() {
        return GetUint16(0x8BC5);
    }

    // Operation not registered by running code
    public void Set1138_8BC5_Word16(ushort value) {
        SetUint16(0x8BC5, value);
    }

    // Getters and Setters for address 0x1138:0x8BC7/0x19F47.
    // Was accessed via the following registers: SS
    public int Get1138_8BC7_Word16() {
        return GetUint16(0x8BC7);
    }

    // Operation not registered by running code
    public void Set1138_8BC7_Word16(ushort value) {
        SetUint16(0x8BC7, value);
    }

    // Getters and Setters for address 0x1138:0x8BC9/0x19F49.
    // Was accessed via the following registers: SS
    public int Get1138_8BC9_Word16() {
        return GetUint16(0x8BC9);
    }

    // Operation not registered by running code
    public void Set1138_8BC9_Word16(ushort value) {
        SetUint16(0x8BC9, value);
    }

    // Getters and Setters for address 0x1138:0x8BCB/0x19F4B.
    // Was accessed via the following registers: SS
    public int Get1138_8BCB_Word16() {
        return GetUint16(0x8BCB);
    }

    // Operation not registered by running code
    public void Set1138_8BCB_Word16(ushort value) {
        SetUint16(0x8BCB, value);
    }

    // Getters and Setters for address 0x1138:0x8BCD/0x19F4D.
    // Was accessed via the following registers: SS
    public int Get1138_8BCD_Word16() {
        return GetUint16(0x8BCD);
    }

    // Operation not registered by running code
    public void Set1138_8BCD_Word16(ushort value) {
        SetUint16(0x8BCD, value);
    }

    // Getters and Setters for address 0x1138:0x8BCF/0x19F4F.
    // Was accessed via the following registers: SS
    public int Get1138_8BCF_Word16() {
        return GetUint16(0x8BCF);
    }

    // Operation not registered by running code
    public void Set1138_8BCF_Word16(ushort value) {
        SetUint16(0x8BCF, value);
    }

    // Getters and Setters for address 0x1138:0x8BD1/0x19F51.
    // Was accessed via the following registers: SS
    public int Get1138_8BD1_Word16() {
        return GetUint16(0x8BD1);
    }

    // Operation not registered by running code
    public void Set1138_8BD1_Word16(ushort value) {
        SetUint16(0x8BD1, value);
    }

    // Getters and Setters for address 0x1138:0x8BD3/0x19F53.
    // Was accessed via the following registers: SS
    public int Get1138_8BD3_Word16() {
        return GetUint16(0x8BD3);
    }

    // Operation not registered by running code
    public void Set1138_8BD3_Word16(ushort value) {
        SetUint16(0x8BD3, value);
    }

    // Getters and Setters for address 0x1138:0x8BD5/0x19F55.
    // Was accessed via the following registers: SS
    public int Get1138_8BD5_Word16() {
        return GetUint16(0x8BD5);
    }

    // Operation not registered by running code
    public void Set1138_8BD5_Word16(ushort value) {
        SetUint16(0x8BD5, value);
    }

    // Getters and Setters for address 0x1138:0x8BD7/0x19F57.
    // Was accessed via the following registers: SS
    public int Get1138_8BD7_Word16() {
        return GetUint16(0x8BD7);
    }

    // Operation not registered by running code
    public void Set1138_8BD7_Word16(ushort value) {
        SetUint16(0x8BD7, value);
    }

    // Getters and Setters for address 0x1138:0x8BD9/0x19F59.
    // Was accessed via the following registers: SS
    public int Get1138_8BD9_Word16() {
        return GetUint16(0x8BD9);
    }

    // Operation not registered by running code
    public void Set1138_8BD9_Word16(ushort value) {
        SetUint16(0x8BD9, value);
    }

    // Getters and Setters for address 0x1138:0x8BDB/0x19F5B.
    // Was accessed via the following registers: SS
    public int Get1138_8BDB_Word16() {
        return GetUint16(0x8BDB);
    }

    // Operation not registered by running code
    public void Set1138_8BDB_Word16(ushort value) {
        SetUint16(0x8BDB, value);
    }

    // Getters and Setters for address 0x1138:0x8BDD/0x19F5D.
    // Was accessed via the following registers: SS
    public int Get1138_8BDD_Word16() {
        return GetUint16(0x8BDD);
    }

    // Operation not registered by running code
    public void Set1138_8BDD_Word16(ushort value) {
        SetUint16(0x8BDD, value);
    }

    // Getters and Setters for address 0x1138:0x8BDF/0x19F5F.
    // Was accessed via the following registers: SS
    public int Get1138_8BDF_Word16() {
        return GetUint16(0x8BDF);
    }

    // Operation not registered by running code
    public void Set1138_8BDF_Word16(ushort value) {
        SetUint16(0x8BDF, value);
    }

    // Getters and Setters for address 0x1138:0x8BE1/0x19F61.
    // Was accessed via the following registers: SS
    public int Get1138_8BE1_Word16() {
        return GetUint16(0x8BE1);
    }

    // Operation not registered by running code
    public void Set1138_8BE1_Word16(ushort value) {
        SetUint16(0x8BE1, value);
    }

    // Getters and Setters for address 0x1138:0x8BE3/0x19F63.
    // Was accessed via the following registers: SS
    public int Get1138_8BE3_Word16() {
        return GetUint16(0x8BE3);
    }

    // Operation not registered by running code
    public void Set1138_8BE3_Word16(ushort value) {
        SetUint16(0x8BE3, value);
    }

    // Getters and Setters for address 0x1138:0x8BE5/0x19F65.
    // Was accessed via the following registers: SS
    public int Get1138_8BE5_Word16() {
        return GetUint16(0x8BE5);
    }

    // Operation not registered by running code
    public void Set1138_8BE5_Word16(ushort value) {
        SetUint16(0x8BE5, value);
    }

    // Getters and Setters for address 0x1138:0x8BE7/0x19F67.
    // Was accessed via the following registers: SS
    public int Get1138_8BE7_Word16() {
        return GetUint16(0x8BE7);
    }

    // Operation not registered by running code
    public void Set1138_8BE7_Word16(ushort value) {
        SetUint16(0x8BE7, value);
    }

    // Getters and Setters for address 0x1138:0x8BE9/0x19F69.
    // Was accessed via the following registers: SS
    public int Get1138_8BE9_Word16() {
        return GetUint16(0x8BE9);
    }

    // Operation not registered by running code
    public void Set1138_8BE9_Word16(ushort value) {
        SetUint16(0x8BE9, value);
    }

    // Getters and Setters for address 0x1138:0x8BEB/0x19F6B.
    // Was accessed via the following registers: SS
    public int Get1138_8BEB_Word16() {
        return GetUint16(0x8BEB);
    }

    // Operation not registered by running code
    public void Set1138_8BEB_Word16(ushort value) {
        SetUint16(0x8BEB, value);
    }

    // Getters and Setters for address 0x1138:0x8BED/0x19F6D.
    // Was accessed via the following registers: SS
    public int Get1138_8BED_Word16() {
        return GetUint16(0x8BED);
    }

    // Operation not registered by running code
    public void Set1138_8BED_Word16(ushort value) {
        SetUint16(0x8BED, value);
    }

    // Getters and Setters for address 0x1138:0x8BEF/0x19F6F.
    // Was accessed via the following registers: SS
    public int Get1138_8BEF_Word16() {
        return GetUint16(0x8BEF);
    }

    // Operation not registered by running code
    public void Set1138_8BEF_Word16(ushort value) {
        SetUint16(0x8BEF, value);
    }

    // Getters and Setters for address 0x1138:0x8BF1/0x19F71.
    // Was accessed via the following registers: SS
    public int Get1138_8BF1_Word16() {
        return GetUint16(0x8BF1);
    }

    // Operation not registered by running code
    public void Set1138_8BF1_Word16(ushort value) {
        SetUint16(0x8BF1, value);
    }

    // Getters and Setters for address 0x1138:0x8BF3/0x19F73.
    // Was accessed via the following registers: SS
    public int Get1138_8BF3_Word16() {
        return GetUint16(0x8BF3);
    }

    // Operation not registered by running code
    public void Set1138_8BF3_Word16(ushort value) {
        SetUint16(0x8BF3, value);
    }

    // Getters and Setters for address 0x1138:0x8BF5/0x19F75.
    // Was accessed via the following registers: SS
    public int Get1138_8BF5_Word16() {
        return GetUint16(0x8BF5);
    }

    // Operation not registered by running code
    public void Set1138_8BF5_Word16(ushort value) {
        SetUint16(0x8BF5, value);
    }

    // Getters and Setters for address 0x1138:0x8BF7/0x19F77.
    // Was accessed via the following registers: SS
    public int Get1138_8BF7_Word16() {
        return GetUint16(0x8BF7);
    }

    // Operation not registered by running code
    public void Set1138_8BF7_Word16(ushort value) {
        SetUint16(0x8BF7, value);
    }

    // Getters and Setters for address 0x1138:0x8BF9/0x19F79.
    // Was accessed via the following registers: SS
    public int Get1138_8BF9_Word16() {
        return GetUint16(0x8BF9);
    }

    // Operation not registered by running code
    public void Set1138_8BF9_Word16(ushort value) {
        SetUint16(0x8BF9, value);
    }

    // Getters and Setters for address 0x1138:0x8BFB/0x19F7B.
    // Was accessed via the following registers: SS
    public int Get1138_8BFB_Word16() {
        return GetUint16(0x8BFB);
    }

    // Operation not registered by running code
    public void Set1138_8BFB_Word16(ushort value) {
        SetUint16(0x8BFB, value);
    }

    // Getters and Setters for address 0x1138:0x8BFD/0x19F7D.
    // Was accessed via the following registers: SS
    public int Get1138_8BFD_Word16() {
        return GetUint16(0x8BFD);
    }

    // Operation not registered by running code
    public void Set1138_8BFD_Word16(ushort value) {
        SetUint16(0x8BFD, value);
    }

    // Getters and Setters for address 0x1138:0x8BFF/0x19F7F.
    // Was accessed via the following registers: SS
    public int Get1138_8BFF_Word16() {
        return GetUint16(0x8BFF);
    }

    // Operation not registered by running code
    public void Set1138_8BFF_Word16(ushort value) {
        SetUint16(0x8BFF, value);
    }

    // Getters and Setters for address 0x1138:0x8C01/0x19F81.
    // Was accessed via the following registers: SS
    public int Get1138_8C01_Word16() {
        return GetUint16(0x8C01);
    }

    // Operation not registered by running code
    public void Set1138_8C01_Word16(ushort value) {
        SetUint16(0x8C01, value);
    }

    // Getters and Setters for address 0x1138:0x8C03/0x19F83.
    // Was accessed via the following registers: SS
    public int Get1138_8C03_Word16() {
        return GetUint16(0x8C03);
    }

    // Operation not registered by running code
    public void Set1138_8C03_Word16(ushort value) {
        SetUint16(0x8C03, value);
    }

    // Getters and Setters for address 0x1138:0x8C05/0x19F85.
    // Was accessed via the following registers: SS
    public int Get1138_8C05_Word16() {
        return GetUint16(0x8C05);
    }

    // Operation not registered by running code
    public void Set1138_8C05_Word16(ushort value) {
        SetUint16(0x8C05, value);
    }

    // Getters and Setters for address 0x1138:0x8C07/0x19F87.
    // Was accessed via the following registers: SS
    public int Get1138_8C07_Word16() {
        return GetUint16(0x8C07);
    }

    // Operation not registered by running code
    public void Set1138_8C07_Word16(ushort value) {
        SetUint16(0x8C07, value);
    }

    // Getters and Setters for address 0x1138:0x8C09/0x19F89.
    // Was accessed via the following registers: SS
    public int Get1138_8C09_Word16() {
        return GetUint16(0x8C09);
    }

    // Operation not registered by running code
    public void Set1138_8C09_Word16(ushort value) {
        SetUint16(0x8C09, value);
    }

    // Getters and Setters for address 0x1138:0x8C0B/0x19F8B.
    // Was accessed via the following registers: SS
    public int Get1138_8C0B_Word16() {
        return GetUint16(0x8C0B);
    }

    // Operation not registered by running code
    public void Set1138_8C0B_Word16(ushort value) {
        SetUint16(0x8C0B, value);
    }

    // Getters and Setters for address 0x1138:0x8C0D/0x19F8D.
    // Was accessed via the following registers: SS
    public int Get1138_8C0D_Word16() {
        return GetUint16(0x8C0D);
    }

    // Operation not registered by running code
    public void Set1138_8C0D_Word16(ushort value) {
        SetUint16(0x8C0D, value);
    }

    // Getters and Setters for address 0x1138:0x8C0F/0x19F8F.
    // Was accessed via the following registers: SS
    public int Get1138_8C0F_Word16() {
        return GetUint16(0x8C0F);
    }

    // Operation not registered by running code
    public void Set1138_8C0F_Word16(ushort value) {
        SetUint16(0x8C0F, value);
    }

    // Getters and Setters for address 0x1138:0x8C11/0x19F91.
    // Was accessed via the following registers: SS
    public int Get1138_8C11_Word16() {
        return GetUint16(0x8C11);
    }

    // Operation not registered by running code
    public void Set1138_8C11_Word16(ushort value) {
        SetUint16(0x8C11, value);
    }

    // Getters and Setters for address 0x1138:0x8C13/0x19F93.
    // Was accessed via the following registers: SS
    public int Get1138_8C13_Word16() {
        return GetUint16(0x8C13);
    }

    // Operation not registered by running code
    public void Set1138_8C13_Word16(ushort value) {
        SetUint16(0x8C13, value);
    }

    // Getters and Setters for address 0x1138:0x8C15/0x19F95.
    // Was accessed via the following registers: SS
    public int Get1138_8C15_Word16() {
        return GetUint16(0x8C15);
    }

    // Operation not registered by running code
    public void Set1138_8C15_Word16(ushort value) {
        SetUint16(0x8C15, value);
    }

    // Getters and Setters for address 0x1138:0x8C17/0x19F97.
    // Was accessed via the following registers: SS
    public int Get1138_8C17_Word16() {
        return GetUint16(0x8C17);
    }

    // Operation not registered by running code
    public void Set1138_8C17_Word16(ushort value) {
        SetUint16(0x8C17, value);
    }

    // Getters and Setters for address 0x1138:0x8C19/0x19F99.
    // Was accessed via the following registers: SS
    public int Get1138_8C19_Word16() {
        return GetUint16(0x8C19);
    }

    // Operation not registered by running code
    public void Set1138_8C19_Word16(ushort value) {
        SetUint16(0x8C19, value);
    }

    // Getters and Setters for address 0x1138:0x8C1B/0x19F9B.
    // Was accessed via the following registers: SS
    public int Get1138_8C1B_Word16() {
        return GetUint16(0x8C1B);
    }

    // Operation not registered by running code
    public void Set1138_8C1B_Word16(ushort value) {
        SetUint16(0x8C1B, value);
    }

    // Getters and Setters for address 0x1138:0x8C1D/0x19F9D.
    // Was accessed via the following registers: SS
    public int Get1138_8C1D_Word16() {
        return GetUint16(0x8C1D);
    }

    // Operation not registered by running code
    public void Set1138_8C1D_Word16(ushort value) {
        SetUint16(0x8C1D, value);
    }

    // Getters and Setters for address 0x1138:0x8C1F/0x19F9F.
    // Was accessed via the following registers: SS
    public int Get1138_8C1F_Word16() {
        return GetUint16(0x8C1F);
    }

    // Operation not registered by running code
    public void Set1138_8C1F_Word16(ushort value) {
        SetUint16(0x8C1F, value);
    }

    // Getters and Setters for address 0x1138:0x8C21/0x19FA1.
    // Was accessed via the following registers: SS
    public int Get1138_8C21_Word16() {
        return GetUint16(0x8C21);
    }

    // Operation not registered by running code
    public void Set1138_8C21_Word16(ushort value) {
        SetUint16(0x8C21, value);
    }

    // Getters and Setters for address 0x1138:0x8C23/0x19FA3.
    // Was accessed via the following registers: SS
    public int Get1138_8C23_Word16() {
        return GetUint16(0x8C23);
    }

    // Operation not registered by running code
    public void Set1138_8C23_Word16(ushort value) {
        SetUint16(0x8C23, value);
    }

    // Getters and Setters for address 0x1138:0x8C25/0x19FA5.
    // Was accessed via the following registers: SS
    public int Get1138_8C25_Word16() {
        return GetUint16(0x8C25);
    }

    // Operation not registered by running code
    public void Set1138_8C25_Word16(ushort value) {
        SetUint16(0x8C25, value);
    }

    // Getters and Setters for address 0x1138:0x8C27/0x19FA7.
    // Was accessed via the following registers: SS
    public int Get1138_8C27_Word16() {
        return GetUint16(0x8C27);
    }

    // Operation not registered by running code
    public void Set1138_8C27_Word16(ushort value) {
        SetUint16(0x8C27, value);
    }

    // Getters and Setters for address 0x1138:0x8C29/0x19FA9.
    // Was accessed via the following registers: SS
    public int Get1138_8C29_Word16() {
        return GetUint16(0x8C29);
    }

    // Operation not registered by running code
    public void Set1138_8C29_Word16(ushort value) {
        SetUint16(0x8C29, value);
    }

    // Getters and Setters for address 0x1138:0x8C2B/0x19FAB.
    // Was accessed via the following registers: SS
    public int Get1138_8C2B_Word16() {
        return GetUint16(0x8C2B);
    }

    // Operation not registered by running code
    public void Set1138_8C2B_Word16(ushort value) {
        SetUint16(0x8C2B, value);
    }

    // Getters and Setters for address 0x1138:0x8C2D/0x19FAD.
    // Was accessed via the following registers: SS
    public int Get1138_8C2D_Word16() {
        return GetUint16(0x8C2D);
    }

    // Operation not registered by running code
    public void Set1138_8C2D_Word16(ushort value) {
        SetUint16(0x8C2D, value);
    }

    // Getters and Setters for address 0x1138:0x8C2F/0x19FAF.
    // Was accessed via the following registers: SS
    public int Get1138_8C2F_Word16() {
        return GetUint16(0x8C2F);
    }

    // Operation not registered by running code
    public void Set1138_8C2F_Word16(ushort value) {
        SetUint16(0x8C2F, value);
    }

    // Getters and Setters for address 0x1138:0x8C31/0x19FB1.
    // Was accessed via the following registers: SS
    public int Get1138_8C31_Word16() {
        return GetUint16(0x8C31);
    }

    // Operation not registered by running code
    public void Set1138_8C31_Word16(ushort value) {
        SetUint16(0x8C31, value);
    }

    // Getters and Setters for address 0x1138:0x8C33/0x19FB3.
    // Was accessed via the following registers: SS
    public int Get1138_8C33_Word16() {
        return GetUint16(0x8C33);
    }

    // Operation not registered by running code
    public void Set1138_8C33_Word16(ushort value) {
        SetUint16(0x8C33, value);
    }

    // Getters and Setters for address 0x1138:0x8C35/0x19FB5.
    // Was accessed via the following registers: SS
    public int Get1138_8C35_Word16() {
        return GetUint16(0x8C35);
    }

    // Operation not registered by running code
    public void Set1138_8C35_Word16(ushort value) {
        SetUint16(0x8C35, value);
    }

    // Getters and Setters for address 0x1138:0x8C37/0x19FB7.
    // Was accessed via the following registers: SS
    public int Get1138_8C37_Word16() {
        return GetUint16(0x8C37);
    }

    // Operation not registered by running code
    public void Set1138_8C37_Word16(ushort value) {
        SetUint16(0x8C37, value);
    }

    // Getters and Setters for address 0x1138:0x8C39/0x19FB9.
    // Was accessed via the following registers: SS
    public int Get1138_8C39_Word16() {
        return GetUint16(0x8C39);
    }

    // Operation not registered by running code
    public void Set1138_8C39_Word16(ushort value) {
        SetUint16(0x8C39, value);
    }

    // Getters and Setters for address 0x1138:0x8C3B/0x19FBB.
    // Was accessed via the following registers: SS
    public int Get1138_8C3B_Word16() {
        return GetUint16(0x8C3B);
    }

    // Operation not registered by running code
    public void Set1138_8C3B_Word16(ushort value) {
        SetUint16(0x8C3B, value);
    }

    // Getters and Setters for address 0x1138:0x8C3D/0x19FBD.
    // Was accessed via the following registers: SS
    public int Get1138_8C3D_Word16() {
        return GetUint16(0x8C3D);
    }

    // Operation not registered by running code
    public void Set1138_8C3D_Word16(ushort value) {
        SetUint16(0x8C3D, value);
    }

    // Getters and Setters for address 0x1138:0x8C3F/0x19FBF.
    // Was accessed via the following registers: SS
    public int Get1138_8C3F_Word16() {
        return GetUint16(0x8C3F);
    }

    // Operation not registered by running code
    public void Set1138_8C3F_Word16(ushort value) {
        SetUint16(0x8C3F, value);
    }

    // Getters and Setters for address 0x1138:0x8C41/0x19FC1.
    // Was accessed via the following registers: SS
    public int Get1138_8C41_Word16() {
        return GetUint16(0x8C41);
    }

    // Operation not registered by running code
    public void Set1138_8C41_Word16(ushort value) {
        SetUint16(0x8C41, value);
    }

    // Getters and Setters for address 0x1138:0x8C43/0x19FC3.
    // Was accessed via the following registers: SS
    public int Get1138_8C43_Word16() {
        return GetUint16(0x8C43);
    }

    // Operation not registered by running code
    public void Set1138_8C43_Word16(ushort value) {
        SetUint16(0x8C43, value);
    }

    // Getters and Setters for address 0x1138:0x8C45/0x19FC5.
    // Was accessed via the following registers: SS
    public int Get1138_8C45_Word16() {
        return GetUint16(0x8C45);
    }

    // Operation not registered by running code
    public void Set1138_8C45_Word16(ushort value) {
        SetUint16(0x8C45, value);
    }

    // Getters and Setters for address 0x1138:0x8C47/0x19FC7.
    // Was accessed via the following registers: SS
    public int Get1138_8C47_Word16() {
        return GetUint16(0x8C47);
    }

    // Operation not registered by running code
    public void Set1138_8C47_Word16(ushort value) {
        SetUint16(0x8C47, value);
    }

    // Getters and Setters for address 0x1138:0x8C49/0x19FC9.
    // Was accessed via the following registers: SS
    public int Get1138_8C49_Word16() {
        return GetUint16(0x8C49);
    }

    // Operation not registered by running code
    public void Set1138_8C49_Word16(ushort value) {
        SetUint16(0x8C49, value);
    }

    // Getters and Setters for address 0x1138:0x8C4B/0x19FCB.
    // Was accessed via the following registers: SS
    public int Get1138_8C4B_Word16() {
        return GetUint16(0x8C4B);
    }

    // Operation not registered by running code
    public void Set1138_8C4B_Word16(ushort value) {
        SetUint16(0x8C4B, value);
    }

    // Getters and Setters for address 0x1138:0x8C4D/0x19FCD.
    // Was accessed via the following registers: SS
    public int Get1138_8C4D_Word16() {
        return GetUint16(0x8C4D);
    }

    // Operation not registered by running code
    public void Set1138_8C4D_Word16(ushort value) {
        SetUint16(0x8C4D, value);
    }

    // Getters and Setters for address 0x1138:0x8C4F/0x19FCF.
    // Was accessed via the following registers: SS
    public int Get1138_8C4F_Word16() {
        return GetUint16(0x8C4F);
    }

    // Operation not registered by running code
    public void Set1138_8C4F_Word16(ushort value) {
        SetUint16(0x8C4F, value);
    }

    // Getters and Setters for address 0x1138:0x8C51/0x19FD1.
    // Was accessed via the following registers: SS
    public int Get1138_8C51_Word16() {
        return GetUint16(0x8C51);
    }

    // Operation not registered by running code
    public void Set1138_8C51_Word16(ushort value) {
        SetUint16(0x8C51, value);
    }

    // Getters and Setters for address 0x1138:0x8C53/0x19FD3.
    // Was accessed via the following registers: SS
    public int Get1138_8C53_Word16() {
        return GetUint16(0x8C53);
    }

    // Operation not registered by running code
    public void Set1138_8C53_Word16(ushort value) {
        SetUint16(0x8C53, value);
    }

    // Getters and Setters for address 0x1138:0x8C55/0x19FD5.
    // Was accessed via the following registers: SS
    public int Get1138_8C55_Word16() {
        return GetUint16(0x8C55);
    }

    // Operation not registered by running code
    public void Set1138_8C55_Word16(ushort value) {
        SetUint16(0x8C55, value);
    }

    // Getters and Setters for address 0x1138:0x8C57/0x19FD7.
    // Was accessed via the following registers: SS
    public int Get1138_8C57_Word16() {
        return GetUint16(0x8C57);
    }

    // Operation not registered by running code
    public void Set1138_8C57_Word16(ushort value) {
        SetUint16(0x8C57, value);
    }

    // Getters and Setters for address 0x1138:0x8C59/0x19FD9.
    // Was accessed via the following registers: SS
    public int Get1138_8C59_Word16() {
        return GetUint16(0x8C59);
    }

    // Operation not registered by running code
    public void Set1138_8C59_Word16(ushort value) {
        SetUint16(0x8C59, value);
    }

    // Getters and Setters for address 0x1138:0x8C5B/0x19FDB.
    // Was accessed via the following registers: SS
    public int Get1138_8C5B_Word16() {
        return GetUint16(0x8C5B);
    }

    // Operation not registered by running code
    public void Set1138_8C5B_Word16(ushort value) {
        SetUint16(0x8C5B, value);
    }

    // Getters and Setters for address 0x1138:0x8C5D/0x19FDD.
    // Was accessed via the following registers: SS
    public int Get1138_8C5D_Word16() {
        return GetUint16(0x8C5D);
    }

    // Operation not registered by running code
    public void Set1138_8C5D_Word16(ushort value) {
        SetUint16(0x8C5D, value);
    }

    // Getters and Setters for address 0x1138:0x8C5F/0x19FDF.
    // Was accessed via the following registers: SS
    public int Get1138_8C5F_Word16() {
        return GetUint16(0x8C5F);
    }

    // Operation not registered by running code
    public void Set1138_8C5F_Word16(ushort value) {
        SetUint16(0x8C5F, value);
    }

    // Getters and Setters for address 0x1138:0x8C61/0x19FE1.
    // Was accessed via the following registers: SS
    public int Get1138_8C61_Word16() {
        return GetUint16(0x8C61);
    }

    // Operation not registered by running code
    public void Set1138_8C61_Word16(ushort value) {
        SetUint16(0x8C61, value);
    }

    // Getters and Setters for address 0x1138:0x8C63/0x19FE3.
    // Was accessed via the following registers: SS
    public int Get1138_8C63_Word16() {
        return GetUint16(0x8C63);
    }

    // Operation not registered by running code
    public void Set1138_8C63_Word16(ushort value) {
        SetUint16(0x8C63, value);
    }

    // Getters and Setters for address 0x1138:0x8C65/0x19FE5.
    // Was accessed via the following registers: SS
    public int Get1138_8C65_Word16() {
        return GetUint16(0x8C65);
    }

    // Operation not registered by running code
    public void Set1138_8C65_Word16(ushort value) {
        SetUint16(0x8C65, value);
    }

    // Getters and Setters for address 0x1138:0x8C67/0x19FE7.
    // Was accessed via the following registers: SS
    public int Get1138_8C67_Word16() {
        return GetUint16(0x8C67);
    }

    // Operation not registered by running code
    public void Set1138_8C67_Word16(ushort value) {
        SetUint16(0x8C67, value);
    }

    // Getters and Setters for address 0x1138:0x8C69/0x19FE9.
    // Was accessed via the following registers: SS
    public int Get1138_8C69_Word16() {
        return GetUint16(0x8C69);
    }

    // Operation not registered by running code
    public void Set1138_8C69_Word16(ushort value) {
        SetUint16(0x8C69, value);
    }

    // Getters and Setters for address 0x1138:0x8C6B/0x19FEB.
    // Was accessed via the following registers: SS
    public int Get1138_8C6B_Word16() {
        return GetUint16(0x8C6B);
    }

    // Operation not registered by running code
    public void Set1138_8C6B_Word16(ushort value) {
        SetUint16(0x8C6B, value);
    }

    // Getters and Setters for address 0x1138:0x8C6D/0x19FED.
    // Was accessed via the following registers: SS
    public int Get1138_8C6D_Word16() {
        return GetUint16(0x8C6D);
    }

    // Operation not registered by running code
    public void Set1138_8C6D_Word16(ushort value) {
        SetUint16(0x8C6D, value);
    }

    // Getters and Setters for address 0x1138:0x8C6F/0x19FEF.
    // Was accessed via the following registers: SS
    public int Get1138_8C6F_Word16() {
        return GetUint16(0x8C6F);
    }

    // Operation not registered by running code
    public void Set1138_8C6F_Word16(ushort value) {
        SetUint16(0x8C6F, value);
    }

    // Getters and Setters for address 0x1138:0x8C71/0x19FF1.
    // Was accessed via the following registers: SS
    public int Get1138_8C71_Word16() {
        return GetUint16(0x8C71);
    }

    // Operation not registered by running code
    public void Set1138_8C71_Word16(ushort value) {
        SetUint16(0x8C71, value);
    }

    // Getters and Setters for address 0x1138:0x8C73/0x19FF3.
    // Was accessed via the following registers: SS
    public int Get1138_8C73_Word16() {
        return GetUint16(0x8C73);
    }

    // Operation not registered by running code
    public void Set1138_8C73_Word16(ushort value) {
        SetUint16(0x8C73, value);
    }

    // Getters and Setters for address 0x1138:0x8C75/0x19FF5.
    // Was accessed via the following registers: SS
    public int Get1138_8C75_Word16() {
        return GetUint16(0x8C75);
    }

    // Operation not registered by running code
    public void Set1138_8C75_Word16(ushort value) {
        SetUint16(0x8C75, value);
    }

    // Getters and Setters for address 0x1138:0x8C77/0x19FF7.
    // Was accessed via the following registers: SS
    public int Get1138_8C77_Word16() {
        return GetUint16(0x8C77);
    }

    // Operation not registered by running code
    public void Set1138_8C77_Word16(ushort value) {
        SetUint16(0x8C77, value);
    }

    // Getters and Setters for address 0x1138:0x8C79/0x19FF9.
    // Was accessed via the following registers: SS
    public int Get1138_8C79_Word16() {
        return GetUint16(0x8C79);
    }

    // Operation not registered by running code
    public void Set1138_8C79_Word16(ushort value) {
        SetUint16(0x8C79, value);
    }

    // Getters and Setters for address 0x1138:0x8C7B/0x19FFB.
    // Was accessed via the following registers: SS
    public int Get1138_8C7B_Word16() {
        return GetUint16(0x8C7B);
    }

    // Operation not registered by running code
    public void Set1138_8C7B_Word16(ushort value) {
        SetUint16(0x8C7B, value);
    }

    // Getters and Setters for address 0x1138:0x8C7D/0x19FFD.
    // Was accessed via the following registers: SS
    public int Get1138_8C7D_Word16() {
        return GetUint16(0x8C7D);
    }

    // Operation not registered by running code
    public void Set1138_8C7D_Word16(ushort value) {
        SetUint16(0x8C7D, value);
    }

    // Getters and Setters for address 0x1138:0x8C7F/0x19FFF.
    // Was accessed via the following registers: SS
    public int Get1138_8C7F_Word16() {
        return GetUint16(0x8C7F);
    }

    // Operation not registered by running code
    public void Set1138_8C7F_Word16(ushort value) {
        SetUint16(0x8C7F, value);
    }

    // Getters and Setters for address 0x1138:0x8C81/0x1A001.
    // Was accessed via the following registers: SS
    public int Get1138_8C81_Word16() {
        return GetUint16(0x8C81);
    }

    // Operation not registered by running code
    public void Set1138_8C81_Word16(ushort value) {
        SetUint16(0x8C81, value);
    }

    // Getters and Setters for address 0x1138:0x8C83/0x1A003.
    // Was accessed via the following registers: SS
    public int Get1138_8C83_Word16() {
        return GetUint16(0x8C83);
    }

    // Operation not registered by running code
    public void Set1138_8C83_Word16(ushort value) {
        SetUint16(0x8C83, value);
    }

    // Getters and Setters for address 0x1138:0x8C85/0x1A005.
    // Was accessed via the following registers: SS
    public int Get1138_8C85_Word16() {
        return GetUint16(0x8C85);
    }

    // Operation not registered by running code
    public void Set1138_8C85_Word16(ushort value) {
        SetUint16(0x8C85, value);
    }

    // Getters and Setters for address 0x1138:0x8C87/0x1A007.
    // Was accessed via the following registers: SS
    public int Get1138_8C87_Word16() {
        return GetUint16(0x8C87);
    }

    // Operation not registered by running code
    public void Set1138_8C87_Word16(ushort value) {
        SetUint16(0x8C87, value);
    }

    // Getters and Setters for address 0x1138:0x8C89/0x1A009.
    // Was accessed via the following registers: SS
    public int Get1138_8C89_Word16() {
        return GetUint16(0x8C89);
    }

    // Operation not registered by running code
    public void Set1138_8C89_Word16(ushort value) {
        SetUint16(0x8C89, value);
    }

    // Getters and Setters for address 0x1138:0x8C8B/0x1A00B.
    // Was accessed via the following registers: SS
    public int Get1138_8C8B_Word16() {
        return GetUint16(0x8C8B);
    }

    // Operation not registered by running code
    public void Set1138_8C8B_Word16(ushort value) {
        SetUint16(0x8C8B, value);
    }

    // Getters and Setters for address 0x1138:0x8C8D/0x1A00D.
    // Was accessed via the following registers: SS
    public int Get1138_8C8D_Word16() {
        return GetUint16(0x8C8D);
    }

    // Operation not registered by running code
    public void Set1138_8C8D_Word16(ushort value) {
        SetUint16(0x8C8D, value);
    }

    // Getters and Setters for address 0x1138:0x8C8F/0x1A00F.
    // Was accessed via the following registers: SS
    public int Get1138_8C8F_Word16() {
        return GetUint16(0x8C8F);
    }

    // Operation not registered by running code
    public void Set1138_8C8F_Word16(ushort value) {
        SetUint16(0x8C8F, value);
    }

    // Getters and Setters for address 0x1138:0x8C91/0x1A011.
    // Was accessed via the following registers: SS
    public int Get1138_8C91_Word16() {
        return GetUint16(0x8C91);
    }

    // Operation not registered by running code
    public void Set1138_8C91_Word16(ushort value) {
        SetUint16(0x8C91, value);
    }

    // Getters and Setters for address 0x1138:0x8C93/0x1A013.
    // Was accessed via the following registers: SS
    public int Get1138_8C93_Word16() {
        return GetUint16(0x8C93);
    }

    // Operation not registered by running code
    public void Set1138_8C93_Word16(ushort value) {
        SetUint16(0x8C93, value);
    }

    // Getters and Setters for address 0x1138:0x8C95/0x1A015.
    // Was accessed via the following registers: SS
    public int Get1138_8C95_Word16() {
        return GetUint16(0x8C95);
    }

    // Operation not registered by running code
    public void Set1138_8C95_Word16(ushort value) {
        SetUint16(0x8C95, value);
    }

    // Getters and Setters for address 0x1138:0x8C97/0x1A017.
    // Was accessed via the following registers: SS
    public int Get1138_8C97_Word16() {
        return GetUint16(0x8C97);
    }

    // Operation not registered by running code
    public void Set1138_8C97_Word16(ushort value) {
        SetUint16(0x8C97, value);
    }

    // Getters and Setters for address 0x1138:0x8C99/0x1A019.
    // Was accessed via the following registers: SS
    public int Get1138_8C99_Word16() {
        return GetUint16(0x8C99);
    }

    // Operation not registered by running code
    public void Set1138_8C99_Word16(ushort value) {
        SetUint16(0x8C99, value);
    }

    // Getters and Setters for address 0x1138:0x8C9B/0x1A01B.
    // Was accessed via the following registers: SS
    public int Get1138_8C9B_Word16() {
        return GetUint16(0x8C9B);
    }

    // Operation not registered by running code
    public void Set1138_8C9B_Word16(ushort value) {
        SetUint16(0x8C9B, value);
    }

    // Getters and Setters for address 0x1138:0x8C9D/0x1A01D.
    // Was accessed via the following registers: SS
    public int Get1138_8C9D_Word16() {
        return GetUint16(0x8C9D);
    }

    // Operation not registered by running code
    public void Set1138_8C9D_Word16(ushort value) {
        SetUint16(0x8C9D, value);
    }

    // Getters and Setters for address 0x1138:0x8C9F/0x1A01F.
    // Was accessed via the following registers: SS
    public int Get1138_8C9F_Word16() {
        return GetUint16(0x8C9F);
    }

    // Operation not registered by running code
    public void Set1138_8C9F_Word16(ushort value) {
        SetUint16(0x8C9F, value);
    }

    // Getters and Setters for address 0x1138:0x8CA1/0x1A021.
    // Was accessed via the following registers: SS
    public int Get1138_8CA1_Word16() {
        return GetUint16(0x8CA1);
    }

    // Operation not registered by running code
    public void Set1138_8CA1_Word16(ushort value) {
        SetUint16(0x8CA1, value);
    }

    // Getters and Setters for address 0x1138:0x8CA3/0x1A023.
    // Was accessed via the following registers: SS
    public int Get1138_8CA3_Word16() {
        return GetUint16(0x8CA3);
    }

    // Operation not registered by running code
    public void Set1138_8CA3_Word16(ushort value) {
        SetUint16(0x8CA3, value);
    }

    // Getters and Setters for address 0x1138:0x8CA5/0x1A025.
    // Was accessed via the following registers: SS
    public int Get1138_8CA5_Word16() {
        return GetUint16(0x8CA5);
    }

    // Operation not registered by running code
    public void Set1138_8CA5_Word16(ushort value) {
        SetUint16(0x8CA5, value);
    }

    // Getters and Setters for address 0x1138:0x8CA7/0x1A027.
    // Was accessed via the following registers: SS
    public int Get1138_8CA7_Word16() {
        return GetUint16(0x8CA7);
    }

    // Operation not registered by running code
    public void Set1138_8CA7_Word16(ushort value) {
        SetUint16(0x8CA7, value);
    }

    // Getters and Setters for address 0x1138:0x8CA9/0x1A029.
    // Was accessed via the following registers: SS
    public int Get1138_8CA9_Word16() {
        return GetUint16(0x8CA9);
    }

    // Operation not registered by running code
    public void Set1138_8CA9_Word16(ushort value) {
        SetUint16(0x8CA9, value);
    }

    // Getters and Setters for address 0x1138:0x8CAB/0x1A02B.
    // Was accessed via the following registers: SS
    public int Get1138_8CAB_Word16() {
        return GetUint16(0x8CAB);
    }

    // Operation not registered by running code
    public void Set1138_8CAB_Word16(ushort value) {
        SetUint16(0x8CAB, value);
    }

    // Getters and Setters for address 0x1138:0x8CAD/0x1A02D.
    // Was accessed via the following registers: SS
    public int Get1138_8CAD_Word16() {
        return GetUint16(0x8CAD);
    }

    // Operation not registered by running code
    public void Set1138_8CAD_Word16(ushort value) {
        SetUint16(0x8CAD, value);
    }

    // Getters and Setters for address 0x1138:0x8CAF/0x1A02F.
    // Was accessed via the following registers: SS
    public int Get1138_8CAF_Word16() {
        return GetUint16(0x8CAF);
    }

    // Operation not registered by running code
    public void Set1138_8CAF_Word16(ushort value) {
        SetUint16(0x8CAF, value);
    }

    // Getters and Setters for address 0x1138:0x8CB1/0x1A031.
    // Was accessed via the following registers: SS
    public int Get1138_8CB1_Word16() {
        return GetUint16(0x8CB1);
    }

    // Operation not registered by running code
    public void Set1138_8CB1_Word16(ushort value) {
        SetUint16(0x8CB1, value);
    }

    // Getters and Setters for address 0x1138:0x8CB3/0x1A033.
    // Was accessed via the following registers: SS
    public int Get1138_8CB3_Word16() {
        return GetUint16(0x8CB3);
    }

    // Operation not registered by running code
    public void Set1138_8CB3_Word16(ushort value) {
        SetUint16(0x8CB3, value);
    }

    // Getters and Setters for address 0x1138:0x8CB5/0x1A035.
    // Was accessed via the following registers: SS
    public int Get1138_8CB5_Word16() {
        return GetUint16(0x8CB5);
    }

    // Operation not registered by running code
    public void Set1138_8CB5_Word16(ushort value) {
        SetUint16(0x8CB5, value);
    }

    // Getters and Setters for address 0x1138:0x8CB7/0x1A037.
    // Was accessed via the following registers: SS
    public int Get1138_8CB7_Word16() {
        return GetUint16(0x8CB7);
    }

    // Operation not registered by running code
    public void Set1138_8CB7_Word16(ushort value) {
        SetUint16(0x8CB7, value);
    }

    // Getters and Setters for address 0x1138:0x8CB9/0x1A039.
    // Was accessed via the following registers: SS
    public int Get1138_8CB9_Word16() {
        return GetUint16(0x8CB9);
    }

    // Operation not registered by running code
    public void Set1138_8CB9_Word16(ushort value) {
        SetUint16(0x8CB9, value);
    }

    // Getters and Setters for address 0x1138:0x8CBB/0x1A03B.
    // Was accessed via the following registers: SS
    public int Get1138_8CBB_Word16() {
        return GetUint16(0x8CBB);
    }

    // Operation not registered by running code
    public void Set1138_8CBB_Word16(ushort value) {
        SetUint16(0x8CBB, value);
    }

    // Getters and Setters for address 0x1138:0x8CBD/0x1A03D.
    // Was accessed via the following registers: SS
    public int Get1138_8CBD_Word16() {
        return GetUint16(0x8CBD);
    }

    // Operation not registered by running code
    public void Set1138_8CBD_Word16(ushort value) {
        SetUint16(0x8CBD, value);
    }

    // Getters and Setters for address 0x1138:0x8CBF/0x1A03F.
    // Was accessed via the following registers: SS
    public int Get1138_8CBF_Word16() {
        return GetUint16(0x8CBF);
    }

    // Operation not registered by running code
    public void Set1138_8CBF_Word16(ushort value) {
        SetUint16(0x8CBF, value);
    }

    // Getters and Setters for address 0x1138:0x8CC1/0x1A041.
    // Was accessed via the following registers: SS
    public int Get1138_8CC1_Word16() {
        return GetUint16(0x8CC1);
    }

    // Operation not registered by running code
    public void Set1138_8CC1_Word16(ushort value) {
        SetUint16(0x8CC1, value);
    }

    // Getters and Setters for address 0x1138:0x8CC3/0x1A043.
    // Was accessed via the following registers: SS
    public int Get1138_8CC3_Word16() {
        return GetUint16(0x8CC3);
    }

    // Operation not registered by running code
    public void Set1138_8CC3_Word16(ushort value) {
        SetUint16(0x8CC3, value);
    }

    // Getters and Setters for address 0x1138:0x8CC5/0x1A045.
    // Was accessed via the following registers: SS
    public int Get1138_8CC5_Word16() {
        return GetUint16(0x8CC5);
    }

    // Operation not registered by running code
    public void Set1138_8CC5_Word16(ushort value) {
        SetUint16(0x8CC5, value);
    }

    // Getters and Setters for address 0x1138:0x8CC7/0x1A047.
    // Was accessed via the following registers: SS
    public int Get1138_8CC7_Word16() {
        return GetUint16(0x8CC7);
    }

    // Operation not registered by running code
    public void Set1138_8CC7_Word16(ushort value) {
        SetUint16(0x8CC7, value);
    }

    // Getters and Setters for address 0x1138:0x8CC9/0x1A049.
    // Was accessed via the following registers: SS
    public int Get1138_8CC9_Word16() {
        return GetUint16(0x8CC9);
    }

    // Operation not registered by running code
    public void Set1138_8CC9_Word16(ushort value) {
        SetUint16(0x8CC9, value);
    }

    // Getters and Setters for address 0x1138:0x8CCB/0x1A04B.
    // Was accessed via the following registers: SS
    public int Get1138_8CCB_Word16() {
        return GetUint16(0x8CCB);
    }

    // Operation not registered by running code
    public void Set1138_8CCB_Word16(ushort value) {
        SetUint16(0x8CCB, value);
    }

    // Getters and Setters for address 0x1138:0x8CCD/0x1A04D.
    // Was accessed via the following registers: SS
    public int Get1138_8CCD_Word16() {
        return GetUint16(0x8CCD);
    }

    // Operation not registered by running code
    public void Set1138_8CCD_Word16(ushort value) {
        SetUint16(0x8CCD, value);
    }

    // Getters and Setters for address 0x1138:0x8CCF/0x1A04F.
    // Was accessed via the following registers: SS
    public int Get1138_8CCF_Word16() {
        return GetUint16(0x8CCF);
    }

    // Operation not registered by running code
    public void Set1138_8CCF_Word16(ushort value) {
        SetUint16(0x8CCF, value);
    }

    // Getters and Setters for address 0x1138:0x8CD1/0x1A051.
    // Was accessed via the following registers: SS
    public int Get1138_8CD1_Word16() {
        return GetUint16(0x8CD1);
    }

    // Operation not registered by running code
    public void Set1138_8CD1_Word16(ushort value) {
        SetUint16(0x8CD1, value);
    }

    // Getters and Setters for address 0x1138:0x8CD3/0x1A053.
    // Was accessed via the following registers: SS
    public int Get1138_8CD3_Word16() {
        return GetUint16(0x8CD3);
    }

    // Operation not registered by running code
    public void Set1138_8CD3_Word16(ushort value) {
        SetUint16(0x8CD3, value);
    }

    // Getters and Setters for address 0x1138:0x8CD5/0x1A055.
    // Was accessed via the following registers: SS
    public int Get1138_8CD5_Word16() {
        return GetUint16(0x8CD5);
    }

    // Operation not registered by running code
    public void Set1138_8CD5_Word16(ushort value) {
        SetUint16(0x8CD5, value);
    }

    // Getters and Setters for address 0x1138:0x8CD7/0x1A057.
    // Was accessed via the following registers: SS
    public int Get1138_8CD7_Word16() {
        return GetUint16(0x8CD7);
    }

    // Operation not registered by running code
    public void Set1138_8CD7_Word16(ushort value) {
        SetUint16(0x8CD7, value);
    }

    // Getters and Setters for address 0x1138:0x8CD9/0x1A059.
    // Was accessed via the following registers: SS
    public int Get1138_8CD9_Word16() {
        return GetUint16(0x8CD9);
    }

    // Operation not registered by running code
    public void Set1138_8CD9_Word16(ushort value) {
        SetUint16(0x8CD9, value);
    }

    // Getters and Setters for address 0x1138:0x8CDB/0x1A05B.
    // Was accessed via the following registers: SS
    public int Get1138_8CDB_Word16() {
        return GetUint16(0x8CDB);
    }

    // Operation not registered by running code
    public void Set1138_8CDB_Word16(ushort value) {
        SetUint16(0x8CDB, value);
    }

    // Getters and Setters for address 0x1138:0x8CDD/0x1A05D.
    // Was accessed via the following registers: SS
    public int Get1138_8CDD_Word16() {
        return GetUint16(0x8CDD);
    }

    // Operation not registered by running code
    public void Set1138_8CDD_Word16(ushort value) {
        SetUint16(0x8CDD, value);
    }

    // Getters and Setters for address 0x1138:0x8CDF/0x1A05F.
    // Was accessed via the following registers: SS
    public int Get1138_8CDF_Word16() {
        return GetUint16(0x8CDF);
    }

    // Operation not registered by running code
    public void Set1138_8CDF_Word16(ushort value) {
        SetUint16(0x8CDF, value);
    }

    // Getters and Setters for address 0x1138:0x8CE1/0x1A061.
    // Was accessed via the following registers: SS
    public int Get1138_8CE1_Word16() {
        return GetUint16(0x8CE1);
    }

    // Operation not registered by running code
    public void Set1138_8CE1_Word16(ushort value) {
        SetUint16(0x8CE1, value);
    }

    // Getters and Setters for address 0x1138:0x8CE3/0x1A063.
    // Was accessed via the following registers: SS
    public int Get1138_8CE3_Word16() {
        return GetUint16(0x8CE3);
    }

    // Operation not registered by running code
    public void Set1138_8CE3_Word16(ushort value) {
        SetUint16(0x8CE3, value);
    }

    // Getters and Setters for address 0x1138:0x8CE5/0x1A065.
    // Was accessed via the following registers: SS
    public int Get1138_8CE5_Word16() {
        return GetUint16(0x8CE5);
    }

    // Operation not registered by running code
    public void Set1138_8CE5_Word16(ushort value) {
        SetUint16(0x8CE5, value);
    }

    // Getters and Setters for address 0x1138:0x8CE7/0x1A067.
    // Was accessed via the following registers: SS
    public int Get1138_8CE7_Word16() {
        return GetUint16(0x8CE7);
    }

    // Operation not registered by running code
    public void Set1138_8CE7_Word16(ushort value) {
        SetUint16(0x8CE7, value);
    }

    // Getters and Setters for address 0x1138:0x8CE9/0x1A069.
    // Was accessed via the following registers: SS
    public int Get1138_8CE9_Word16() {
        return GetUint16(0x8CE9);
    }

    // Operation not registered by running code
    public void Set1138_8CE9_Word16(ushort value) {
        SetUint16(0x8CE9, value);
    }

    // Getters and Setters for address 0x1138:0x8CEB/0x1A06B.
    // Was accessed via the following registers: SS
    public int Get1138_8CEB_Word16() {
        return GetUint16(0x8CEB);
    }

    // Operation not registered by running code
    public void Set1138_8CEB_Word16(ushort value) {
        SetUint16(0x8CEB, value);
    }

    // Getters and Setters for address 0x1138:0x8CED/0x1A06D.
    // Was accessed via the following registers: SS
    public int Get1138_8CED_Word16() {
        return GetUint16(0x8CED);
    }

    // Operation not registered by running code
    public void Set1138_8CED_Word16(ushort value) {
        SetUint16(0x8CED, value);
    }

    // Getters and Setters for address 0x1138:0x8CEF/0x1A06F.
    // Was accessed via the following registers: SS
    public int Get1138_8CEF_Word16() {
        return GetUint16(0x8CEF);
    }

    // Operation not registered by running code
    public void Set1138_8CEF_Word16(ushort value) {
        SetUint16(0x8CEF, value);
    }

    // Getters and Setters for address 0x1138:0x8CF1/0x1A071.
    // Was accessed via the following registers: SS
    public int Get1138_8CF1_Word16() {
        return GetUint16(0x8CF1);
    }

    // Operation not registered by running code
    public void Set1138_8CF1_Word16(ushort value) {
        SetUint16(0x8CF1, value);
    }

    // Getters and Setters for address 0x1138:0x8CF3/0x1A073.
    // Was accessed via the following registers: SS
    public int Get1138_8CF3_Word16() {
        return GetUint16(0x8CF3);
    }

    // Operation not registered by running code
    public void Set1138_8CF3_Word16(ushort value) {
        SetUint16(0x8CF3, value);
    }

    // Getters and Setters for address 0x1138:0x8CF5/0x1A075.
    // Was accessed via the following registers: SS
    public int Get1138_8CF5_Word16() {
        return GetUint16(0x8CF5);
    }

    // Operation not registered by running code
    public void Set1138_8CF5_Word16(ushort value) {
        SetUint16(0x8CF5, value);
    }

    // Getters and Setters for address 0x1138:0x8CF7/0x1A077.
    // Was accessed via the following registers: SS
    public int Get1138_8CF7_Word16() {
        return GetUint16(0x8CF7);
    }

    // Operation not registered by running code
    public void Set1138_8CF7_Word16(ushort value) {
        SetUint16(0x8CF7, value);
    }

    // Getters and Setters for address 0x1138:0x8CF9/0x1A079.
    // Was accessed via the following registers: SS
    public int Get1138_8CF9_Word16() {
        return GetUint16(0x8CF9);
    }

    // Operation not registered by running code
    public void Set1138_8CF9_Word16(ushort value) {
        SetUint16(0x8CF9, value);
    }

    // Getters and Setters for address 0x1138:0x8CFB/0x1A07B.
    // Was accessed via the following registers: SS
    public int Get1138_8CFB_Word16() {
        return GetUint16(0x8CFB);
    }

    // Operation not registered by running code
    public void Set1138_8CFB_Word16(ushort value) {
        SetUint16(0x8CFB, value);
    }

    // Getters and Setters for address 0x1138:0x8CFD/0x1A07D.
    // Was accessed via the following registers: SS
    public int Get1138_8CFD_Word16() {
        return GetUint16(0x8CFD);
    }

    // Operation not registered by running code
    public void Set1138_8CFD_Word16(ushort value) {
        SetUint16(0x8CFD, value);
    }

    // Getters and Setters for address 0x1138:0xA5C0/0x1B940.
    // Was accessed via the following registers: SS
    public int Get1138_A5C0_Word16() {
        return GetUint16(0xA5C0);
    }

    // Was accessed via the following registers: DS
    public void Set1138_A5C0_Word16(ushort value) {
        SetUint16(0xA5C0, value);
    }

    // Getters and Setters for address 0x1138:0xA5C2/0x1B942.
    // Was accessed via the following registers: SS
    public int Get1138_A5C2_Word16() {
        return GetUint16(0xA5C2);
    }

    // Operation not registered by running code
    public void Set1138_A5C2_Word16(ushort value) {
        SetUint16(0xA5C2, value);
    }

    // Getters and Setters for address 0x1138:0xA5C4/0x1B944.
    // Was accessed via the following registers: SS
    public int Get1138_A5C4_Word16() {
        return GetUint16(0xA5C4);
    }

    // Operation not registered by running code
    public void Set1138_A5C4_Word16(ushort value) {
        SetUint16(0xA5C4, value);
    }

    // Getters and Setters for address 0x1138:0xA5C6/0x1B946.
    // Was accessed via the following registers: SS
    public int Get1138_A5C6_Word16() {
        return GetUint16(0xA5C6);
    }

    // Operation not registered by running code
    public void Set1138_A5C6_Word16(ushort value) {
        SetUint16(0xA5C6, value);
    }

    // Getters and Setters for address 0x1138:0xA5C8/0x1B948.
    // Was accessed via the following registers: SS
    public int Get1138_A5C8_Word16() {
        return GetUint16(0xA5C8);
    }

    // Operation not registered by running code
    public void Set1138_A5C8_Word16(ushort value) {
        SetUint16(0xA5C8, value);
    }

    // Getters and Setters for address 0x1138:0xA5CA/0x1B94A.
    // Was accessed via the following registers: SS
    public int Get1138_A5CA_Word16() {
        return GetUint16(0xA5CA);
    }

    // Operation not registered by running code
    public void Set1138_A5CA_Word16(ushort value) {
        SetUint16(0xA5CA, value);
    }

    // Getters and Setters for address 0x1138:0xA5CC/0x1B94C.
    // Was accessed via the following registers: SS
    public int Get1138_A5CC_Word16() {
        return GetUint16(0xA5CC);
    }

    // Operation not registered by running code
    public void Set1138_A5CC_Word16(ushort value) {
        SetUint16(0xA5CC, value);
    }

    // Getters and Setters for address 0x1138:0xA5CE/0x1B94E.
    // Was accessed via the following registers: SS
    public int Get1138_A5CE_Word16() {
        return GetUint16(0xA5CE);
    }

    // Operation not registered by running code
    public void Set1138_A5CE_Word16(ushort value) {
        SetUint16(0xA5CE, value);
    }

    // Getters and Setters for address 0x1138:0xA5D0/0x1B950.
    // Was accessed via the following registers: SS
    public int Get1138_A5D0_Word16() {
        return GetUint16(0xA5D0);
    }

    // Operation not registered by running code
    public void Set1138_A5D0_Word16(ushort value) {
        SetUint16(0xA5D0, value);
    }

    // Getters and Setters for address 0x1138:0xA5D2/0x1B952.
    // Was accessed via the following registers: SS
    public int Get1138_A5D2_Word16() {
        return GetUint16(0xA5D2);
    }

    // Operation not registered by running code
    public void Set1138_A5D2_Word16(ushort value) {
        SetUint16(0xA5D2, value);
    }

    // Getters and Setters for address 0x1138:0xA5D4/0x1B954.
    // Was accessed via the following registers: SS
    public int Get1138_A5D4_Word16() {
        return GetUint16(0xA5D4);
    }

    // Operation not registered by running code
    public void Set1138_A5D4_Word16(ushort value) {
        SetUint16(0xA5D4, value);
    }

    // Getters and Setters for address 0x1138:0xA5D6/0x1B956.
    // Was accessed via the following registers: SS
    public int Get1138_A5D6_Word16() {
        return GetUint16(0xA5D6);
    }

    // Operation not registered by running code
    public void Set1138_A5D6_Word16(ushort value) {
        SetUint16(0xA5D6, value);
    }

    // Getters and Setters for address 0x1138:0xA5D8/0x1B958.
    // Was accessed via the following registers: SS
    public int Get1138_A5D8_Word16() {
        return GetUint16(0xA5D8);
    }

    // Operation not registered by running code
    public void Set1138_A5D8_Word16(ushort value) {
        SetUint16(0xA5D8, value);
    }

    // Getters and Setters for address 0x1138:0xA9D0/0x1BD50.
    // Was accessed via the following registers: SS
    public int Get1138_A9D0_Word16() {
        return GetUint16(0xA9D0);
    }

    // Was accessed via the following registers: DS
    public void Set1138_A9D0_Word16(ushort value) {
        SetUint16(0xA9D0, value);
    }

    // Getters and Setters for address 0x1138:0xA9D2/0x1BD52.
    // Was accessed via the following registers: SS
    public int Get1138_A9D2_Word16() {
        return GetUint16(0xA9D2);
    }

    // Operation not registered by running code
    public void Set1138_A9D2_Word16(ushort value) {
        SetUint16(0xA9D2, value);
    }

    // Getters and Setters for address 0x1138:0xA9D4/0x1BD54.
    // Was accessed via the following registers: SS
    public int Get1138_A9D4_Word16() {
        return GetUint16(0xA9D4);
    }

    // Operation not registered by running code
    public void Set1138_A9D4_Word16(ushort value) {
        SetUint16(0xA9D4, value);
    }

    // Getters and Setters for address 0x1138:0xA9D6/0x1BD56.
    // Was accessed via the following registers: SS
    public int Get1138_A9D6_Word16() {
        return GetUint16(0xA9D6);
    }

    // Operation not registered by running code
    public void Set1138_A9D6_Word16(ushort value) {
        SetUint16(0xA9D6, value);
    }

    // Getters and Setters for address 0x1138:0xA9D8/0x1BD58.
    // Was accessed via the following registers: SS
    public int Get1138_A9D8_Word16() {
        return GetUint16(0xA9D8);
    }

    // Operation not registered by running code
    public void Set1138_A9D8_Word16(ushort value) {
        SetUint16(0xA9D8, value);
    }

    // Getters and Setters for address 0x1138:0xA9DA/0x1BD5A.
    // Was accessed via the following registers: SS
    public int Get1138_A9DA_Word16() {
        return GetUint16(0xA9DA);
    }

    // Operation not registered by running code
    public void Set1138_A9DA_Word16(ushort value) {
        SetUint16(0xA9DA, value);
    }

    // Getters and Setters for address 0x1138:0xA9DC/0x1BD5C.
    // Was accessed via the following registers: SS
    public int Get1138_A9DC_Word16() {
        return GetUint16(0xA9DC);
    }

    // Operation not registered by running code
    public void Set1138_A9DC_Word16(ushort value) {
        SetUint16(0xA9DC, value);
    }

    // Getters and Setters for address 0x1138:0xA9DE/0x1BD5E.
    // Was accessed via the following registers: SS
    public int Get1138_A9DE_Word16() {
        return GetUint16(0xA9DE);
    }

    // Operation not registered by running code
    public void Set1138_A9DE_Word16(ushort value) {
        SetUint16(0xA9DE, value);
    }

    // Getters and Setters for address 0x1138:0xA9E0/0x1BD60.
    // Was accessed via the following registers: SS
    public int Get1138_A9E0_Word16() {
        return GetUint16(0xA9E0);
    }

    // Operation not registered by running code
    public void Set1138_A9E0_Word16(ushort value) {
        SetUint16(0xA9E0, value);
    }

    // Getters and Setters for address 0x1138:0xA9E2/0x1BD62.
    // Was accessed via the following registers: SS
    public int Get1138_A9E2_Word16() {
        return GetUint16(0xA9E2);
    }

    // Operation not registered by running code
    public void Set1138_A9E2_Word16(ushort value) {
        SetUint16(0xA9E2, value);
    }

    // Getters and Setters for address 0x1138:0xA9E4/0x1BD64.
    // Was accessed via the following registers: SS
    public int Get1138_A9E4_Word16() {
        return GetUint16(0xA9E4);
    }

    // Operation not registered by running code
    public void Set1138_A9E4_Word16(ushort value) {
        SetUint16(0xA9E4, value);
    }

    // Getters and Setters for address 0x1138:0xA9E6/0x1BD66.
    // Was accessed via the following registers: SS
    public int Get1138_A9E6_Word16() {
        return GetUint16(0xA9E6);
    }

    // Operation not registered by running code
    public void Set1138_A9E6_Word16(ushort value) {
        SetUint16(0xA9E6, value);
    }

    // Getters and Setters for address 0x1138:0xA9E8/0x1BD68.
    // Was accessed via the following registers: SS
    public int Get1138_A9E8_Word16() {
        return GetUint16(0xA9E8);
    }

    // Operation not registered by running code
    public void Set1138_A9E8_Word16(ushort value) {
        SetUint16(0xA9E8, value);
    }

    // Getters and Setters for address 0x1138:0xA9EA/0x1BD6A.
    // Was accessed via the following registers: SS
    public int Get1138_A9EA_Word16() {
        return GetUint16(0xA9EA);
    }

    // Operation not registered by running code
    public void Set1138_A9EA_Word16(ushort value) {
        SetUint16(0xA9EA, value);
    }

    // Getters and Setters for address 0x1138:0xA9EC/0x1BD6C.
    // Was accessed via the following registers: SS
    public int Get1138_A9EC_Word16() {
        return GetUint16(0xA9EC);
    }

    // Operation not registered by running code
    public void Set1138_A9EC_Word16(ushort value) {
        SetUint16(0xA9EC, value);
    }

    // Getters and Setters for address 0x1138:0xA9EE/0x1BD6E.
    // Was accessed via the following registers: SS
    public int Get1138_A9EE_Word16() {
        return GetUint16(0xA9EE);
    }

    // Operation not registered by running code
    public void Set1138_A9EE_Word16(ushort value) {
        SetUint16(0xA9EE, value);
    }

    // Getters and Setters for address 0x1138:0xAB9A/0x1BF1A.
    // Was accessed via the following registers: SS
    public int Get1138_AB9A_Byte8() {
        return GetUint8(0xAB9A);
    }

    // Operation not registered by running code
    public void Set1138_AB9A_Byte8(byte value) {
        SetUint8(0xAB9A, value);
    }

    // Getters and Setters for address 0x1138:0xBBD2/0x1CF52.
    // Was accessed via the following registers: SS
    public int Get1138_BBD2_Byte8() {
        return GetUint8(0xBBD2);
    }

    // Operation not registered by running code
    public void Set1138_BBD2_Byte8(byte value) {
        SetUint8(0xBBD2, value);
    }

    // Getters and Setters for address 0x1138:0xBBD6/0x1CF56.
    // Was accessed via the following registers: SS
    public int Get1138_BBD6_Byte8() {
        return GetUint8(0xBBD6);
    }

    // Operation not registered by running code
    public void Set1138_BBD6_Byte8(byte value) {
        SetUint8(0xBBD6, value);
    }

    // Getters and Setters for address 0x1138:0xCE7A/0x1E1FA.
    // Was accessed via the following registers: DS, SS
    public int Get1138_CE7A_Word16_VideoPlayRelatedIndex() {
        return GetUint16(0xCE7A);
    }

    // Was accessed via the following registers: DS
    public void Set1138_CE7A_Word16_VideoPlayRelatedIndex(ushort value) {
        SetUint16(0xCE7A, value);
    }

    // Getters and Setters for address 0x1138:0xD820/0x1EBA0.
    // Was accessed via the following registers: DS, SS
    public int Get1138_D820_Word16() {
        return GetUint16(0xD820);
    }

    // Was accessed via the following registers: DS, SS
    public void Set1138_D820_Word16(ushort value) {
        SetUint16(0xD820, value);
    }

    // Getters and Setters for address 0x1138:0xD834/0x1EBB4.
    // Was accessed via the following registers: DS, SS
    public int Get1138_D834_Word16() {
        return GetUint16(0xD834);
    }

    // Was accessed via the following registers: DS, SS
    public void Set1138_D834_Word16(ushort value) {
        SetUint16(0xD834, value);
    }

    // Getters and Setters for address 0x1138:0xD836/0x1EBB6.
    // Was accessed via the following registers: SS
    public int Get1138_D836_Word16() {
        return GetUint16(0xD836);
    }

    // Was accessed via the following registers: DS, SS
    public void Set1138_D836_Word16(ushort value) {
        SetUint16(0xD836, value);
    }

    // Getters and Setters for address 0x1138:0xD838/0x1EBB8.
    // Was accessed via the following registers: DS, SS
    public int Get1138_D838_Word16() {
        return GetUint16(0xD838);
    }

    // Was accessed via the following registers: DS, SS
    public void Set1138_D838_Word16(ushort value) {
        SetUint16(0xD838, value);
    }

    // Getters and Setters for address 0x1138:0xD83A/0x1EBBA.
    // Was accessed via the following registers: DS, SS
    public int Get1138_D83A_Word16() {
        return GetUint16(0xD83A);
    }

    // Was accessed via the following registers: DS, SS
    public void Set1138_D83A_Word16(ushort value) {
        SetUint16(0xD83A, value);
    }

    // Getters and Setters for address 0x1138:0xDBB0/0x1EF30.
    // Operation not registered by running code
    public int Get1138_DBB0_Word16_StructureSegmentedAddress_sprite_sheet_resource_ptr() {
        return GetUint16(0xDBB0);
    }

    // Was accessed via the following registers: DS
    public void Set1138_DBB0_Word16_StructureSegmentedAddress_sprite_sheet_resource_ptr(ushort value) {
        SetUint16(0xDBB0, value);
    }

    // Was accessed via the following registers: DS, SS
    public uint Get1138_DBB0_Dword32_StructureSegmentedAddress_sprite_sheet_resource_ptr() {
        return GetUint32(0xDBB0);
    }

    // Was accessed via the following registers: DS, SS
    public SegmentedAddress GetPtr1138_DBB0_Dword32_StructureSegmentedAddress_sprite_sheet_resource_ptr() {
        return new SegmentedAddress(GetUint16(0xDBB0 + 2), GetUint16(0xDBB0));
    }

    // Operation not registered by running code
    public void Set1138_DBB0_Dword32_StructureSegmentedAddress_sprite_sheet_resource_ptr(ushort value) {
        SetUint32(0xDBB0, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_DBB0_Dword32_StructureSegmentedAddress_sprite_sheet_resource_ptr(SegmentedAddress value) {
        SetUint16(0xDBB0 + 2, value.Segment);
        SetUint16(0xDBB0, value.Offset);
    }

    // Getters and Setters for address 0x1138:0xDBB2/0x1EF32.
    // Was accessed via the following registers: DS, SS
    public int Get1138_DBB2_Word16() {
        return GetUint16(0xDBB2);
    }

    // Was accessed via the following registers: DS
    public void Set1138_DBB2_Word16(ushort value) {
        SetUint16(0xDBB2, value);
    }

    // Getters and Setters for address 0x1138:0xDBBA/0x1EF3A.
    // Was accessed via the following registers: DS, SS
    public int Get1138_DBBA_Word16() {
        return GetUint16(0xDBBA);
    }

    // Was accessed via the following registers: DS
    public void Set1138_DBBA_Word16(ushort value) {
        SetUint16(0xDBBA, value);
    }

    // Getters and Setters for address 0x1138:0xDBBC/0x1EF3C.
    // Operation not registered by running code
    public int Get1138_DBBC_Word16_dnmajFunc2() {
        return GetUint16(0xDBBC);
    }

    // Was accessed via the following registers: DS
    public void Set1138_DBBC_Word16_dnmajFunc2(ushort value) {
        SetUint16(0xDBBC, value);
    }

    // Was accessed via the following registers: SS
    public uint Get1138_DBBC_Dword32_dnmajFunc2() {
        return GetUint32(0xDBBC);
    }

    // Was accessed via the following registers: SS
    public SegmentedAddress GetPtr1138_DBBC_Dword32_dnmajFunc2() {
        return new SegmentedAddress(GetUint16(0xDBBC + 2), GetUint16(0xDBBC));
    }

    // Operation not registered by running code
    public void Set1138_DBBC_Dword32_dnmajFunc2(ushort value) {
        SetUint32(0xDBBC, value);
    }

    // Operation not registered by running code
    public void SetPtr1138_DBBC_Dword32_dnmajFunc2(SegmentedAddress value) {
        SetUint16(0xDBBC + 2, value.Segment);
        SetUint16(0xDBBC, value.Offset);
    }

    // Getters and Setters for address 0x1138:0xDBD8/0x1EF58.
    // Was accessed via the following registers: DS, SS
    public int Get1138_DBD8_Word16_screenBuffer() {
        return GetUint16(0xDBD8);
    }

    // Was accessed via the following registers: DS
    public void Set1138_DBD8_Word16_screenBuffer(ushort value) {
        SetUint16(0xDBD8, value);
    }

    // Getters and Setters for address 0x1138:0xDCF2/0x1F072.
    // Was accessed via the following registers: DS, SS
    public int Get1138_DCF2_Word16() {
        return GetUint16(0xDCF2);
    }

    // Was accessed via the following registers: DS
    public void Set1138_DCF2_Word16(ushort value) {
        SetUint16(0xDCF2, value);
    }

    // Getters and Setters for address 0x1138:0xDD00/0x1F080.
    // Was accessed via the following registers: DS, SS
    public int Get1138_DD00_Word16() {
        return GetUint16(0xDD00);
    }

    // Was accessed via the following registers: DS
    public void Set1138_DD00_Word16(ushort value) {
        SetUint16(0xDD00, value);
    }
}
