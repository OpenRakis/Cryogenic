namespace Cryogenic.Overrides;

// Method names contain _ to separate addresses.
public partial class Overrides {
    public void DefineDialoguesCodeOverrides() {
        DefineFunction(cs1, 0xA1E8, IncUnknown47A8_1000_A1E8_01A1E8);
        DefineFunction(cs1, 0xA8B1, Unknown_1000_A8B1_01A8B1);
        DefineFunction(cs1, 0xC85B, InitDialogue_1000_C85B_01C85B);
    }

    public Action IncUnknown47A8_1000_A1E8_01A1E8(int gotoAddress) {
        // Called in dialogues, sometimes before first text display, sometimes before last text
        globalsOnDs.Set1138_47A8_Byte8((byte)(globalsOnDs.Get1138_47A8_Byte8() + 1));
        return NearRet();
    }

    public Action InitDialogue_1000_C85B_01C85B(int gotoAddress) {
        ushort value = this.globalsOnDs.Get1138_CE7A_Word16_VideoPlayRelatedIndex();
        this.globalsOnDs.Set1138_476E_Word16(value);
        this.globalsOnDs.Set1138_4772_Word16_TimeBetweenFaceZooms(0x1770);
        return NearRet();
    }

    public Action Unknown_1000_A8B1_01A8B1(int gotoAddress) {
        // Called when a dialogue text changes (beginning and during dialogue), and when entering an orni
        // Value does not seem to have any effect
        byte value = AL;
        value &= 0xF;
        value += 0x30;
        if (value > 0x39) {
            value += 0x7;
        }

        AL = value;
        return NearRet();
    }
}