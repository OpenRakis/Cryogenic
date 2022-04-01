namespace Cryogenic.Overrides;

using Cryogenic.Globals;

using Serilog;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {
    public void DefineVideoCodeOverrides() {
        DefineFunction(cs1, 0xC921, GetHnmResourceFlagNamePtrByIndexAXToBx_1ED_C921_E7F1);
        DefineFunction(cs1, 0xCA59, VideoPlayRelated_1ED_CA59_E929);
        DefineFunction(cs1, 0xCC85, CheckIfHnmComplete_1ED_CC85_EB55);
    }

    public Action CheckIfHnmComplete_1ED_CC85_EB55(int gotoAddress) {
        int value = globalsOnDs.Get1138_DBE7_Byte8_hnmFinishedFlag();
        _logger.Debug("DBE7={@DBE7}", value);
        State.ZeroFlag = value is 0 or 1;
        return NearRet();
    }

    /// <summary>
    /// Reads value at DS:(AX*2)+0x33A3 and returns it in BX
    /// </summary>
    public Action GetHnmResourceFlagNamePtrByIndexAXToBx_1ED_C921_E7F1(int gotoAddress) {
        // Only executed when a video starts
        ushort offset = (ushort)(State.AX * 2 + 0x33A3);
        ushort value = UInt16[State.DS, offset];
        _logger.Debug("read33A3WithAxOffset {@Ax} {@Value}", State.AX, value);
        State.BX = value;
        return NearRet();
    }

    public Action VideoPlayRelated_1ED_CA59_E929(int gotoAddress) {
        // seems to have no impact what so ever is done here. Only executed during videos
        ushort value = globalsOnDs.Get1138_CE7A_Word16_VideoPlayRelatedIndex();
        globalsOnDs.Set1138_DC22_Word16_VideoPlayRelatedIndex(value);
        _logger.Debug("videoPlayRelated value:{@Value}", value);
        return NearRet();
    }
}