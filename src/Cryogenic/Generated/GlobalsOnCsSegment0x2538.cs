namespace Cryogenic.Generated;

using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

public class GlobalsOnCsSegment0x2538 : MemoryBasedDataStructureWithBaseAddress {
    public GlobalsOnCsSegment0x2538(Machine machine) : base(machine.GetMemory(), 0x2538 * 0x10) {
    }

    // Getters and Setters for address 0x2538:0x18A/0x2550A.
    // Was accessed via the following registers: CS
    public ushort Get2538_018A_Word16_MouseCursorAddressInVram() {
        return GetUint16(0x18A);
    }

    // Was accessed via the following registers: CS
    public void Set2538_018A_Word16_MouseCursorAddressInVram(ushort value) {
        SetUint16(0x18A, value);
    }

    // Getters and Setters for address 0x2538:0x18C/0x2550C.
    // Was accessed via the following registers: CS
    public byte Get2538_018C_Byte8_ColumnsOfMouseCursorCount() {
        return GetUint8(0x18C);
    }

    // Operation not registered by running code
    public void Set2538_018C_Byte8_ColumnsOfMouseCursorCount(byte value) {
        SetUint8(0x18C, value);
    }

    // Was accessed via the following registers: CS
    public ushort Get2538_018C_Word16_ColumnsOfMouseCursorCount() {
        return GetUint16(0x18C);
    }

    // Was accessed via the following registers: CS
    public void Set2538_018C_Word16_ColumnsOfMouseCursorCount(ushort value) {
        SetUint16(0x18C, value);
    }

    // Getters and Setters for address 0x2538:0x18E/0x2550E.
    // Was accessed via the following registers: CS
    public ushort Get2538_018E_Word16_LinesOfMouseCursorCount() {
        return GetUint16(0x18E);
    }

    // Was accessed via the following registers: CS
    public void Set2538_018E_Word16_LinesOfMouseCursorCount(ushort value) {
        SetUint16(0x18E, value);
    }

    // Getters and Setters for address 0x2538:0x190/0x25510.
    // Was accessed via the following registers: CS
    public int Get2538_0190_Word16() {
        return GetUint16(0x190);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0190_Word16(ushort value) {
        SetUint16(0x190, value);
    }

    // Getters and Setters for address 0x2538:0x192/0x25512.
    // Operation not registered by running code
    public int Get2538_0192_Word16() {
        return GetUint16(0x192);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0192_Word16(ushort value) {
        SetUint16(0x192, value);
    }

    // Getters and Setters for address 0x2538:0x194/0x25514.
    // Was accessed via the following registers: CS
    public int Get2538_0194_Word16() {
        return GetUint16(0x194);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0194_Word16(ushort value) {
        SetUint16(0x194, value);
    }

    // Getters and Setters for address 0x2538:0x196/0x25516.
    // Was accessed via the following registers: CS
    public int Get2538_0196_Word16() {
        return GetUint16(0x196);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0196_Word16(ushort value) {
        SetUint16(0x196, value);
    }

    // Getters and Setters for address 0x2538:0x198/0x25518.
    // Was accessed via the following registers: CS
    public int Get2538_0198_Word16() {
        return GetUint16(0x198);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0198_Word16(ushort value) {
        SetUint16(0x198, value);
    }

    // Getters and Setters for address 0x2538:0x19A/0x2551A.
    // Was accessed via the following registers: CS
    public int Get2538_019A_Word16() {
        return GetUint16(0x19A);
    }

    // Was accessed via the following registers: CS
    public void Set2538_019A_Word16(ushort value) {
        SetUint16(0x19A, value);
    }

    // Getters and Setters for address 0x2538:0x19C/0x2551C.
    // Was accessed via the following registers: CS
    public int Get2538_019C_Byte8() {
        return GetUint8(0x19C);
    }

    // Was accessed via the following registers: CS
    public void Set2538_019C_Byte8(byte value) {
        SetUint8(0x19C, value);
    }

    // Getters and Setters for address 0x2538:0x19D/0x2551D.
    // Was accessed via the following registers: CS
    public int Get2538_019D_Word16() {
        return GetUint16(0x19D);
    }

    // Operation not registered by running code
    public void Set2538_019D_Word16(ushort value) {
        SetUint16(0x19D, value);
    }

    // Getters and Setters for address 0x2538:0x19E/0x2551E.
    // Was accessed via the following registers: CS
    public int Get2538_019E_Byte8() {
        return GetUint8(0x19E);
    }

    // Was accessed via the following registers: CS
    public void Set2538_019E_Byte8(byte value) {
        SetUint8(0x19E, value);
    }

    // Getters and Setters for address 0x2538:0x19F/0x2551F.
    // Was accessed via the following registers: CS, DS
    public int Get2538_019F_Word16_VgaStatusRegisterPort() {
        return GetUint16(0x19F);
    }

    // Was accessed via the following registers: CS
    public void Set2538_019F_Word16_VgaStatusRegisterPort(ushort value) {
        SetUint16(0x19F, value);
    }

    // Getters and Setters for address 0x2538:0x1A1/0x25521.
    // Was accessed via the following registers: CS, DS
    public int Get2538_01A1_Byte8_NeedWaitForRetrace() {
        return GetUint8(0x1A1);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01A1_Byte8_NeedWaitForRetrace(byte value) {
        SetUint8(0x1A1, value);
    }

    // Getters and Setters for address 0x2538:0x1A2/0x25522.
    // Was accessed via the following registers: CS, DS
    public byte Get2538_01A2_Byte8_VgaStatusRegisterPortExpectedRetraceValue() {
        return GetUint8(0x1A2);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01A2_Byte8_VgaStatusRegisterPortExpectedRetraceValue(byte value) {
        SetUint8(0x1A2, value);
    }

    // Getters and Setters for address 0x2538:0x1A3/0x25523.
    // Was accessed via the following registers: CS
    public ushort Get2538_01A3_Word16_VgaOffset() {
        return GetUint16(0x1A3);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01A3_Word16_VgaOffset(ushort value) {
        SetUint16(0x1A3, value);
    }

    // Getters and Setters for address 0x2538:0x1A5/0x25525.
    // Was accessed via the following registers: CS
    public ushort Get2538_01A5_Word16() {
        return GetUint16(0x1A5);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01A5_Word16(ushort value) {
        SetUint16(0x1A5, value);
    }

    // Getters and Setters for address 0x2538:0x1A7/0x25527.
    // Operation not registered by running code
    public ushort Get2538_01A7_Word16() {
        return GetUint16(0x1A7);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01A7_Word16(ushort value) {
        SetUint16(0x1A7, value);
    }

    // Was accessed via the following registers: CS
    public uint Get2538_01A7_Dword32() {
        return GetUint32(0x1A7);
    }

    // Was accessed via the following registers: CS
    public SegmentedAddress GetPtr2538_01A7_Dword32() {
        return new SegmentedAddress(GetUint16(0x1A7 + 2), GetUint16(0x1A7));
    }

    // Operation not registered by running code
    public void Set2538_01A7_Dword32(ushort value) {
        SetUint32(0x1A7, value);
    }

    // Operation not registered by running code
    public void SetPtr2538_01A7_Dword32(SegmentedAddress value) {
        SetUint16(0x1A7 + 2, value.GetSegment());
        SetUint16(0x1A7, value.GetOffset());
    }

    // Getters and Setters for address 0x2538:0x1A9/0x25529.
    // Operation not registered by running code
    public int Get2538_01A9_Word16() {
        return GetUint16(0x1A9);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01A9_Word16(ushort value) {
        SetUint16(0x1A9, value);
    }

    // Getters and Setters for address 0x2538:0x1AB/0x2552B.
    // Was accessed via the following registers: CS
    public int Get2538_01AB_Word16() {
        return GetUint16(0x1AB);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01AB_Word16(ushort value) {
        SetUint16(0x1AB, value);
    }

    // Getters and Setters for address 0x2538:0x1AD/0x2552D.
    // Was accessed via the following registers: CS
    public int Get2538_01AD_Word16() {
        return GetUint16(0x1AD);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01AD_Word16(ushort value) {
        SetUint16(0x1AD, value);
    }

    // Getters and Setters for address 0x2538:0x1AF/0x2552F.
    // Operation not registered by running code
    public int Get2538_01AF_Word16() {
        return GetUint16(0x1AF);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01AF_Word16(ushort value) {
        SetUint16(0x1AF, value);
    }

    // Getters and Setters for address 0x2538:0x1B1/0x25531.
    // Was accessed via the following registers: CS
    public int Get2538_01B1_Byte8() {
        return GetUint8(0x1B1);
    }

    // Operation not registered by running code
    public void Set2538_01B1_Byte8(byte value) {
        SetUint8(0x1B1, value);
    }

    // Was accessed via the following registers: CS
    public int Get2538_01B1_Word16() {
        return GetUint16(0x1B1);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01B1_Word16(ushort value) {
        SetUint16(0x1B1, value);
    }

    // Getters and Setters for address 0x2538:0x1B2/0x25532.
    // Was accessed via the following registers: CS
    public int Get2538_01B2_Byte8() {
        return GetUint8(0x1B2);
    }

    // Operation not registered by running code
    public void Set2538_01B2_Byte8(byte value) {
        SetUint8(0x1B2, value);
    }

    // Getters and Setters for address 0x2538:0x1B3/0x25533.
    // Was accessed via the following registers: CS
    public int Get2538_01B3_Word16() {
        return GetUint16(0x1B3);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01B3_Word16(ushort value) {
        SetUint16(0x1B3, value);
    }

    // Getters and Setters for address 0x2538:0x1B5/0x25535.
    // Was accessed via the following registers: CS
    public int Get2538_01B5_Word16() {
        return GetUint16(0x1B5);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01B5_Word16(ushort value) {
        SetUint16(0x1B5, value);
    }

    // Getters and Setters for address 0x2538:0x1B7/0x25537.
    // Operation not registered by running code
    public int Get2538_01B7_Word16() {
        return GetUint16(0x1B7);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01B7_Word16(ushort value) {
        SetUint16(0x1B7, value);
    }

    // Getters and Setters for address 0x2538:0x1B9/0x25539.
    // Was accessed via the following registers: CS
    public int Get2538_01B9_Word16() {
        return GetUint16(0x1B9);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01B9_Word16(ushort value) {
        SetUint16(0x1B9, value);
    }

    // Getters and Setters for address 0x2538:0x1BB/0x2553B.
    // Was accessed via the following registers: CS
    public ushort Get2538_01BB_Word16() {
        return GetUint16(0x1BB);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01BB_Word16(ushort value) {
        SetUint16(0x1BB, value);
    }

    // Getters and Setters for address 0x2538:0x1BD/0x2553D.
    // Was accessed via the following registers: CS
    public byte Get2538_01BD_Byte8_PaletteLoadMode() {
        return GetUint8(0x1BD);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01BD_Byte8_PaletteLoadMode(byte value) {
        SetUint8(0x1BD, value);
    }

    // Getters and Setters for address 0x2538:0x1BE/0x2553E.
    // Was accessed via the following registers: CS
    public byte Get2538_01BE_Byte8() {
        return GetUint8(0x1BE);
    }

    // Was accessed via the following registers: CS
    public void Set2538_01BE_Byte8(byte value) {
        SetUint8(0x1BE, value);
    }

    // Getters and Setters for address 0x2538:0x92F/0x25CAF.
    // Was accessed via the following registers: CS
    public byte Get2538_092F_Byte8() {
        return GetUint8(0x92F);
    }

    // Operation not registered by running code
    public void Set2538_092F_Byte8(byte value) {
        SetUint8(0x92F, value);
    }

    // Getters and Setters for address 0x2538:0x930/0x25CB0.
    // Was accessed via the following registers: CS
    public int Get2538_0930_Byte8() {
        return GetUint8(0x930);
    }

    // Operation not registered by running code
    public void Set2538_0930_Byte8(byte value) {
        SetUint8(0x930, value);
    }

    // Getters and Setters for address 0x2538:0x931/0x25CB1.
    // Was accessed via the following registers: CS
    public int Get2538_0931_Byte8() {
        return GetUint8(0x931);
    }

    // Operation not registered by running code
    public void Set2538_0931_Byte8(byte value) {
        SetUint8(0x931, value);
    }

    // Getters and Setters for address 0x2538:0x932/0x25CB2.
    // Was accessed via the following registers: CS
    public int Get2538_0932_Byte8() {
        return GetUint8(0x932);
    }

    // Operation not registered by running code
    public void Set2538_0932_Byte8(byte value) {
        SetUint8(0x932, value);
    }

    // Getters and Setters for address 0x2538:0x933/0x25CB3.
    // Was accessed via the following registers: CS
    public int Get2538_0933_Byte8() {
        return GetUint8(0x933);
    }

    // Operation not registered by running code
    public void Set2538_0933_Byte8(byte value) {
        SetUint8(0x933, value);
    }

    // Getters and Setters for address 0x2538:0x934/0x25CB4.
    // Was accessed via the following registers: CS
    public int Get2538_0934_Byte8() {
        return GetUint8(0x934);
    }

    // Operation not registered by running code
    public void Set2538_0934_Byte8(byte value) {
        SetUint8(0x934, value);
    }

    // Getters and Setters for address 0x2538:0x935/0x25CB5.
    // Was accessed via the following registers: CS
    public int Get2538_0935_Byte8() {
        return GetUint8(0x935);
    }

    // Operation not registered by running code
    public void Set2538_0935_Byte8(byte value) {
        SetUint8(0x935, value);
    }

    // Getters and Setters for address 0x2538:0x936/0x25CB6.
    // Was accessed via the following registers: CS
    public int Get2538_0936_Byte8() {
        return GetUint8(0x936);
    }

    // Operation not registered by running code
    public void Set2538_0936_Byte8(byte value) {
        SetUint8(0x936, value);
    }

    // Getters and Setters for address 0x2538:0x937/0x25CB7.
    // Was accessed via the following registers: CS
    public int Get2538_0937_Byte8() {
        return GetUint8(0x937);
    }

    // Operation not registered by running code
    public void Set2538_0937_Byte8(byte value) {
        SetUint8(0x937, value);
    }

    // Getters and Setters for address 0x2538:0x938/0x25CB8.
    // Was accessed via the following registers: CS
    public int Get2538_0938_Byte8() {
        return GetUint8(0x938);
    }

    // Operation not registered by running code
    public void Set2538_0938_Byte8(byte value) {
        SetUint8(0x938, value);
    }

    // Getters and Setters for address 0x2538:0x939/0x25CB9.
    // Was accessed via the following registers: CS
    public int Get2538_0939_Byte8() {
        return GetUint8(0x939);
    }

    // Operation not registered by running code
    public void Set2538_0939_Byte8(byte value) {
        SetUint8(0x939, value);
    }

    // Getters and Setters for address 0x2538:0x93A/0x25CBA.
    // Was accessed via the following registers: CS
    public int Get2538_093A_Byte8() {
        return GetUint8(0x93A);
    }

    // Operation not registered by running code
    public void Set2538_093A_Byte8(byte value) {
        SetUint8(0x93A, value);
    }

    // Getters and Setters for address 0x2538:0x93B/0x25CBB.
    // Was accessed via the following registers: CS
    public int Get2538_093B_Byte8() {
        return GetUint8(0x93B);
    }

    // Operation not registered by running code
    public void Set2538_093B_Byte8(byte value) {
        SetUint8(0x93B, value);
    }

    // Getters and Setters for address 0x2538:0x93C/0x25CBC.
    // Was accessed via the following registers: CS
    public int Get2538_093C_Byte8() {
        return GetUint8(0x93C);
    }

    // Operation not registered by running code
    public void Set2538_093C_Byte8(byte value) {
        SetUint8(0x93C, value);
    }

    // Getters and Setters for address 0x2538:0x93D/0x25CBD.
    // Was accessed via the following registers: CS
    public int Get2538_093D_Byte8() {
        return GetUint8(0x93D);
    }

    // Operation not registered by running code
    public void Set2538_093D_Byte8(byte value) {
        SetUint8(0x93D, value);
    }

    // Getters and Setters for address 0x2538:0x93E/0x25CBE.
    // Was accessed via the following registers: CS
    public int Get2538_093E_Byte8() {
        return GetUint8(0x93E);
    }

    // Operation not registered by running code
    public void Set2538_093E_Byte8(byte value) {
        SetUint8(0x93E, value);
    }

    // Getters and Setters for address 0x2538:0xC3C/0x25FBC.
    // Operation not registered by running code
    public int Get2538_0C3C_Word16() {
        return GetUint16(0xC3C);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0C3C_Word16(ushort value) {
        SetUint16(0xC3C, value);
    }

    // Getters and Setters for address 0x2538:0xC43/0x25FC3.
    // Operation not registered by running code
    public int Get2538_0C43_Byte8() {
        return GetUint8(0xC43);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0C43_Byte8(byte value) {
        SetUint8(0xC43, value);
    }

    // Getters and Setters for address 0x2538:0xCD6/0x26056.
    // Operation not registered by running code
    public int Get2538_0CD6_Word16() {
        return GetUint16(0xCD6);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0CD6_Word16(ushort value) {
        SetUint16(0xCD6, value);
    }

    // Getters and Setters for address 0x2538:0xCDD/0x2605D.
    // Operation not registered by running code
    public int Get2538_0CDD_Byte8() {
        return GetUint8(0xCDD);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0CDD_Byte8(byte value) {
        SetUint8(0xCDD, value);
    }

    // Getters and Setters for address 0x2538:0xD81/0x26101.
    // Was accessed via the following registers: CS
    public int Get2538_0D81_Word16() {
        return GetUint16(0xD81);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0D81_Word16(ushort value) {
        SetUint16(0xD81, value);
    }

    // Getters and Setters for address 0x2538:0xD83/0x26103.
    // Was accessed via the following registers: CS
    public int Get2538_0D83_Word16() {
        return GetUint16(0xD83);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0D83_Word16(ushort value) {
        SetUint16(0xD83, value);
    }

    // Getters and Setters for address 0x2538:0xDDE/0x2615E.
    // Operation not registered by running code
    public int Get2538_0DDE_Word16() {
        return GetUint16(0xDDE);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0DDE_Word16(ushort value) {
        SetUint16(0xDDE, value);
    }

    // Getters and Setters for address 0x2538:0xE13/0x26193.
    // Operation not registered by running code
    public int Get2538_0E13_Byte8() {
        return GetUint8(0xE13);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0E13_Byte8(byte value) {
        SetUint8(0xE13, value);
    }

    // Getters and Setters for address 0x2538:0xE26/0x261A6.
    // Operation not registered by running code
    public int Get2538_0E26_Byte8() {
        return GetUint8(0xE26);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0E26_Byte8(byte value) {
        SetUint8(0xE26, value);
    }

    // Getters and Setters for address 0x2538:0xE32/0x261B2.
    // Operation not registered by running code
    public int Get2538_0E32_Byte8() {
        return GetUint8(0xE32);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0E32_Byte8(byte value) {
        SetUint8(0xE32, value);
    }

    // Getters and Setters for address 0x2538:0xEF0/0x26270.
    // Operation not registered by running code
    public int Get2538_0EF0_Byte8() {
        return GetUint8(0xEF0);
    }

    // Was accessed via the following registers: CS
    public void Set2538_0EF0_Byte8(byte value) {
        SetUint8(0xEF0, value);
    }

    // Getters and Setters for address 0x2538:0x10DC/0x2645C.
    // Was accessed via the following registers: CS
    public int Get2538_10DC_Word16() {
        return GetUint16(0x10DC);
    }

    // Was accessed via the following registers: CS
    public void Set2538_10DC_Word16(ushort value) {
        SetUint16(0x10DC, value);
    }

    // Getters and Setters for address 0x2538:0x10DE/0x2645E.
    // Was accessed via the following registers: CS
    public int Get2538_10DE_Word16() {
        return GetUint16(0x10DE);
    }

    // Was accessed via the following registers: CS
    public void Set2538_10DE_Word16(ushort value) {
        SetUint16(0x10DE, value);
    }

    // Getters and Setters for address 0x2538:0x10E0/0x26460.
    // Was accessed via the following registers: CS
    public int Get2538_10E0_Word16() {
        return GetUint16(0x10E0);
    }

    // Was accessed via the following registers: CS
    public void Set2538_10E0_Word16(ushort value) {
        SetUint16(0x10E0, value);
    }

    // Getters and Setters for address 0x2538:0x158B/0x2690B.
    // Was accessed via the following registers: CS
    public int Get2538_158B_Word16() {
        return GetUint16(0x158B);
    }

    // Was accessed via the following registers: CS
    public void Set2538_158B_Word16(ushort value) {
        SetUint16(0x158B, value);
    }

    // Getters and Setters for address 0x2538:0x1CA0/0x27020.
    // Was accessed via the following registers: CS
    public int Get2538_1CA0_Word16() {
        return GetUint16(0x1CA0);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1CA0_Word16(ushort value) {
        SetUint16(0x1CA0, value);
    }

    // Getters and Setters for address 0x2538:0x1CA2/0x27022.
    // Was accessed via the following registers: CS
    public int Get2538_1CA2_Word16() {
        return GetUint16(0x1CA2);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1CA2_Word16(ushort value) {
        SetUint16(0x1CA2, value);
    }

    // Getters and Setters for address 0x2538:0x1CA4/0x27024.
    // Was accessed via the following registers: CS
    public int Get2538_1CA4_Word16() {
        return GetUint16(0x1CA4);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1CA4_Word16(ushort value) {
        SetUint16(0x1CA4, value);
    }

    // Getters and Setters for address 0x2538:0x1CA6/0x27026.
    // Was accessed via the following registers: CS
    public int Get2538_1CA6_Word16_UnknownGlobeRelated() {
        return GetUint16(0x1CA6);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1CA6_Word16_UnknownGlobeRelated(ushort value) {
        SetUint16(0x1CA6, value);
    }

    // Getters and Setters for address 0x2538:0x1CA8/0x27028.
    // Was accessed via the following registers: CS
    public int Get2538_1CA8_Word16() {
        return GetUint16(0x1CA8);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1CA8_Word16(ushort value) {
        SetUint16(0x1CA8, value);
    }

    // Getters and Setters for address 0x2538:0x1CAA/0x2702A.
    // Was accessed via the following registers: CS
    public int Get2538_1CAA_Word16() {
        return GetUint16(0x1CAA);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1CAA_Word16(ushort value) {
        SetUint16(0x1CAA, value);
    }

    // Getters and Setters for address 0x2538:0x1CAC/0x2702C.
    // Was accessed via the following registers: CS
    public int Get2538_1CAC_Word16() {
        return GetUint16(0x1CAC);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1CAC_Word16(ushort value) {
        SetUint16(0x1CAC, value);
    }

    // Getters and Setters for address 0x2538:0x1CAE/0x2702E.
    // Was accessed via the following registers: CS
    public int Get2538_1CAE_Word16_UnknownGlobeRelated() {
        return GetUint16(0x1CAE);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1CAE_Word16_UnknownGlobeRelated(ushort value) {
        SetUint16(0x1CAE, value);
    }

    // Getters and Setters for address 0x2538:0x1CB0/0x27030.
    // Was accessed via the following registers: CS
    public int Get2538_1CB0_Word16_UnknownGlobeRelated() {
        return GetUint16(0x1CB0);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1CB0_Word16_UnknownGlobeRelated(ushort value) {
        SetUint16(0x1CB0, value);
    }

    // Getters and Setters for address 0x2538:0x1CB2/0x27032.
    // Was accessed via the following registers: CS
    public int Get2538_1CB2_Word16_UnknownGlobeRelated() {
        return GetUint16(0x1CB2);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1CB2_Word16_UnknownGlobeRelated(ushort value) {
        SetUint16(0x1CB2, value);
    }

    // Getters and Setters for address 0x2538:0x1CB4/0x27034.
    // Was accessed via the following registers: CS
    public int Get2538_1CB4_Word16() {
        return GetUint16(0x1CB4);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1CB4_Word16(ushort value) {
        SetUint16(0x1CB4, value);
    }

    // Getters and Setters for address 0x2538:0x1E4A/0x271CA.
    // Operation not registered by running code
    public int Get2538_1E4A_Word16() {
        return GetUint16(0x1E4A);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1E4A_Word16(ushort value) {
        SetUint16(0x1E4A, value);
    }

    // Getters and Setters for address 0x2538:0x1EA6/0x27226.
    // Operation not registered by running code
    public int Get2538_1EA6_Word16_UnknownGlobeRelated() {
        return GetUint16(0x1EA6);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1EA6_Word16_UnknownGlobeRelated(ushort value) {
        SetUint16(0x1EA6, value);
    }

    // Getters and Setters for address 0x2538:0x1F29/0x272A9.
    // Operation not registered by running code
    public int Get2538_1F29_Word16_UnknownGlobeRelated() {
        return GetUint16(0x1F29);
    }

    // Was accessed via the following registers: CS
    public void Set2538_1F29_Word16_UnknownGlobeRelated(ushort value) {
        SetUint16(0x1F29, value);
    }

    // Getters and Setters for address 0x2538:0x2535/0x278B5.
    // Was accessed via the following registers: CS
    public int Get2538_2535_Word16() {
        return GetUint16(0x2535);
    }

    // Was accessed via the following registers: CS
    public void Set2538_2535_Word16(ushort value) {
        SetUint16(0x2535, value);
    }

    // Getters and Setters for address 0x2538:0x2537/0x278B7.
    // Was accessed via the following registers: CS
    public int Get2538_2537_Word16() {
        return GetUint16(0x2537);
    }

    // Was accessed via the following registers: CS
    public void Set2538_2537_Word16(ushort value) {
        SetUint16(0x2537, value);
    }

    // Getters and Setters for address 0x2538:0x2539/0x278B9.
    // Was accessed via the following registers: CS
    public int Get2538_2539_Word16() {
        return GetUint16(0x2539);
    }

    // Was accessed via the following registers: CS
    public void Set2538_2539_Word16(ushort value) {
        SetUint16(0x2539, value);
    }

    // Getters and Setters for address 0x2538:0x261B/0x2799B.
    // Was accessed via the following registers: CS
    public int Get2538_261B_Word16() {
        return GetUint16(0x261B);
    }

    // Was accessed via the following registers: CS
    public void Set2538_261B_Word16(ushort value) {
        SetUint16(0x261B, value);
    }

    // Getters and Setters for address 0x2538:0x2768/0x27AE8.
    // Was accessed via the following registers: CS
    public int Get2538_2768_Word16() {
        return GetUint16(0x2768);
    }

    // Was accessed via the following registers: CS
    public void Set2538_2768_Word16(ushort value) {
        SetUint16(0x2768, value);
    }

    // Getters and Setters for address 0x2538:0x276A/0x27AEA.
    // Was accessed via the following registers: CS
    public int Get2538_276A_Word16() {
        return GetUint16(0x276A);
    }

    // Was accessed via the following registers: CS
    public void Set2538_276A_Word16(ushort value) {
        SetUint16(0x276A, value);
    }

    // Getters and Setters for address 0x2538:0x27E4/0x27B64.
    // Was accessed via the following registers: CS
    public int Get2538_27E4_Word16() {
        return GetUint16(0x27E4);
    }

    // Was accessed via the following registers: CS
    public void Set2538_27E4_Word16(ushort value) {
        SetUint16(0x27E4, value);
    }

    // Getters and Setters for address 0x2538:0x29D3/0x27D53.
    // Was accessed via the following registers: CS
    public int Get2538_29D3_Byte8() {
        return GetUint8(0x29D3);
    }

    // Was accessed via the following registers: CS
    public void Set2538_29D3_Byte8(byte value) {
        SetUint8(0x29D3, value);
    }

    // Getters and Setters for address 0x2538:0x3114/0x28494.
    // Was accessed via the following registers: CS
    public int Get2538_3114_Word16() {
        return GetUint16(0x3114);
    }

    // Was accessed via the following registers: CS
    public void Set2538_3114_Word16(ushort value) {
        SetUint16(0x3114, value);
    }

    // Getters and Setters for address 0x2538:0x3116/0x28496.
    // Was accessed via the following registers: CS
    public int Get2538_3116_Word16() {
        return GetUint16(0x3116);
    }

    // Was accessed via the following registers: CS
    public void Set2538_3116_Word16(ushort value) {
        SetUint16(0x3116, value);
    }

    // Getters and Setters for address 0x2538:0x35EA/0x2896A.
    // Was accessed via the following registers: CS
    public int Get2538_35EA_Word16() {
        return GetUint16(0x35EA);
    }

    // Was accessed via the following registers: CS
    public void Set2538_35EA_Word16(ushort value) {
        SetUint16(0x35EA, value);
    }

    // Getters and Setters for address 0x2538:0x35EC/0x2896C.
    // Was accessed via the following registers: CS
    public int Get2538_35EC_Word16() {
        return GetUint16(0x35EC);
    }

    // Was accessed via the following registers: CS
    public void Set2538_35EC_Word16(ushort value) {
        SetUint16(0x35EC, value);
    }

    // Getters and Setters for address 0x2538:0x35EE/0x2896E.
    // Was accessed via the following registers: CS
    public int Get2538_35EE_Word16() {
        return GetUint16(0x35EE);
    }

    // Was accessed via the following registers: CS
    public void Set2538_35EE_Word16(ushort value) {
        SetUint16(0x35EE, value);
    }

    // Getters and Setters for address 0x2538:0x35F0/0x28970.
    // Was accessed via the following registers: CS
    public int Get2538_35F0_Word16() {
        return GetUint16(0x35F0);
    }

    // Was accessed via the following registers: CS
    public void Set2538_35F0_Word16(ushort value) {
        SetUint16(0x35F0, value);
    }

    // Getters and Setters for address 0x2538:0x35F2/0x28972.
    // Was accessed via the following registers: CS
    public int Get2538_35F2_Word16() {
        return GetUint16(0x35F2);
    }

    // Was accessed via the following registers: CS
    public void Set2538_35F2_Word16(ushort value) {
        SetUint16(0x35F2, value);
    }

    // Getters and Setters for address 0x2538:0x35F4/0x28974.
    // Was accessed via the following registers: CS
    public int Get2538_35F4_Word16() {
        return GetUint16(0x35F4);
    }

    // Was accessed via the following registers: CS
    public void Set2538_35F4_Word16(ushort value) {
        SetUint16(0x35F4, value);
    }

    // Getters and Setters for address 0x2538:0x35F6/0x28976.
    // Was accessed via the following registers: CS
    public int Get2538_35F6_Word16() {
        return GetUint16(0x35F6);
    }

    // Was accessed via the following registers: CS
    public void Set2538_35F6_Word16(ushort value) {
        SetUint16(0x35F6, value);
    }

    // Getters and Setters for address 0x2538:0x35F8/0x28978.
    // Was accessed via the following registers: CS
    public int Get2538_35F8_Word16() {
        return GetUint16(0x35F8);
    }

    // Was accessed via the following registers: CS
    public void Set2538_35F8_Word16(ushort value) {
        SetUint16(0x35F8, value);
    }

    // Getters and Setters for address 0x2538:0x35FA/0x2897A.
    // Was accessed via the following registers: CS
    public int Get2538_35FA_Word16() {
        return GetUint16(0x35FA);
    }

    // Was accessed via the following registers: CS
    public void Set2538_35FA_Word16(ushort value) {
        SetUint16(0x35FA, value);
    }

    // Getters and Setters for address 0x2538:0x35FC/0x2897C.
    // Was accessed via the following registers: CS
    public int Get2538_35FC_Word16() {
        return GetUint16(0x35FC);
    }

    // Was accessed via the following registers: CS
    public void Set2538_35FC_Word16(ushort value) {
        SetUint16(0x35FC, value);
    }

    // Getters and Setters for address 0x2538:0x35FE/0x2897E.
    // Was accessed via the following registers: CS
    public int Get2538_35FE_Word16() {
        return GetUint16(0x35FE);
    }

    // Was accessed via the following registers: CS
    public void Set2538_35FE_Word16(ushort value) {
        SetUint16(0x35FE, value);
    }

    // Getters and Setters for address 0x2538:0x3600/0x28980.
    // Was accessed via the following registers: CS
    public int Get2538_3600_Word16() {
        return GetUint16(0x3600);
    }

    // Was accessed via the following registers: CS
    public void Set2538_3600_Word16(ushort value) {
        SetUint16(0x3600, value);
    }

    // Getters and Setters for address 0x2538:0x38C0/0x28C40.
    // Was accessed via the following registers: CS
    public int Get2538_38C0_Word16() {
        return GetUint16(0x38C0);
    }

    // Was accessed via the following registers: CS
    public void Set2538_38C0_Word16(ushort value) {
        SetUint16(0x38C0, value);
    }

    // Getters and Setters for address 0x2538:0x38C2/0x28C42.
    // Was accessed via the following registers: CS
    public int Get2538_38C2_Word16() {
        return GetUint16(0x38C2);
    }

    // Was accessed via the following registers: CS
    public void Set2538_38C2_Word16(ushort value) {
        SetUint16(0x38C2, value);
    }

    // Getters and Setters for address 0x2538:0x38C4/0x28C44.
    // Was accessed via the following registers: CS
    public int Get2538_38C4_Word16() {
        return GetUint16(0x38C4);
    }

    // Was accessed via the following registers: CS
    public void Set2538_38C4_Word16(ushort value) {
        SetUint16(0x38C4, value);
    }

    // Getters and Setters for address 0x2538:0x38C6/0x28C46.
    // Was accessed via the following registers: CS
    public int Get2538_38C6_Word16() {
        return GetUint16(0x38C6);
    }

    // Was accessed via the following registers: CS
    public void Set2538_38C6_Word16(ushort value) {
        SetUint16(0x38C6, value);
    }

    // Getters and Setters for address 0x2538:0x38C8/0x28C48.
    // Was accessed via the following registers: CS
    public int Get2538_38C8_Word16() {
        return GetUint16(0x38C8);
    }

    // Was accessed via the following registers: CS
    public void Set2538_38C8_Word16(ushort value) {
        SetUint16(0x38C8, value);
    }

    // Getters and Setters for address 0x2538:0x38CA/0x28C4A.
    // Was accessed via the following registers: CS
    public int Get2538_38CA_Word16() {
        return GetUint16(0x38CA);
    }

    // Was accessed via the following registers: CS
    public void Set2538_38CA_Word16(ushort value) {
        SetUint16(0x38CA, value);
    }

    // Getters and Setters for address 0x2538:0x38CC/0x28C4C.
    // Operation not registered by running code
    public int Get2538_38CC_Word16() {
        return GetUint16(0x38CC);
    }

    // Was accessed via the following registers: CS
    public void Set2538_38CC_Word16(ushort value) {
        SetUint16(0x38CC, value);
    }

    // Getters and Setters for address 0x2538:0x38CE/0x28C4E.
    // Operation not registered by running code
    public int Get2538_38CE_Word16() {
        return GetUint16(0x38CE);
    }

    // Was accessed via the following registers: CS
    public void Set2538_38CE_Word16(ushort value) {
        SetUint16(0x38CE, value);
    }

    // Getters and Setters for address 0x2538:0x38D0/0x28C50.
    // Operation not registered by running code
    public int Get2538_38D0_Word16() {
        return GetUint16(0x38D0);
    }

    // Was accessed via the following registers: CS
    public void Set2538_38D0_Word16(ushort value) {
        SetUint16(0x38D0, value);
    }

    // Getters and Setters for address 0x2538:0x38D2/0x28C52.
    // Operation not registered by running code
    public int Get2538_38D2_Word16() {
        return GetUint16(0x38D2);
    }

    // Was accessed via the following registers: CS
    public void Set2538_38D2_Word16(ushort value) {
        SetUint16(0x38D2, value);
    }

    // Getters and Setters for address 0x2538:0x38D4/0x28C54.
    // Was accessed via the following registers: CS
    public int Get2538_38D4_Word16() {
        return GetUint16(0x38D4);
    }

    // Was accessed via the following registers: CS
    public void Set2538_38D4_Word16(ushort value) {
        SetUint16(0x38D4, value);
    }

    // Getters and Setters for address 0x2538:0x3A10/0x28D90.
    // Was accessed via the following registers: CS
    public int Get2538_3A10_Word16() {
        return GetUint16(0x3A10);
    }

    // Operation not registered by running code
    public void Set2538_3A10_Word16(ushort value) {
        SetUint16(0x3A10, value);
    }
}
