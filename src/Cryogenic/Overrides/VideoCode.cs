namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.ReverseEngineer;

// Method names contain _ to separate addresses.
public partial class Overrides {
    public void DefineVideoCodeOverrides() {
        DefineFunction(cs1, 0xC921, GetHnmResourceFlagNamePtrByIndexAXToBx_1000_C921_01C921);
        DefineFunction(cs1, 0xCA59, VideoPlayRelated_1000_CA59_01CA59);
        DefineFunction(cs1, 0xCC85, CheckIfHnmComplete_1000_CC85_01CC85);
    }

    public Action CheckIfHnmComplete_1000_CC85_01CC85(int gotoAddress) {
        int value = globalsOnDs.Get1138_DBE7_Byte8_hnmFinishedFlag();
        _logger.Debug("DBE7={@DBE7}", value);
        ZeroFlag = value is 0 or 1;
        return NearRet();
    }

    /// <summary>
    /// Reads value at DS:(AX*2)+0x33A3 and returns it in BX
    /// </summary>
    public Action GetHnmResourceFlagNamePtrByIndexAXToBx_1000_C921_01C921(int gotoAddress) {
        // Only executed when a video starts
        ushort offset = (ushort)(AX * 2 + 0x33A3);
        ushort value = UInt16[DS, offset];
        _logger.Debug("read33A3WithAxOffset {@Ax} {@Value}", AX, value);
        BX = value;
        return NearRet();
    }

    public Action VideoPlayRelated_1000_CA59_01CA59(int gotoAddress) {
        // seems to have no impact what so ever is done here. Only executed during videos
        ushort value = globalsOnDs.Get1138_CE7A_Word16_VideoPlayRelatedIndex();
        globalsOnDs.Set1138_DC22_Word16_VideoPlayRelatedIndex(value);
        _logger.Debug("videoPlayRelated value:{@Value}", value);
        return NearRet();
    }
}