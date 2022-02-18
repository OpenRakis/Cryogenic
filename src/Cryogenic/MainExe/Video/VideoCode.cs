namespace Cryogenic.Mainexe.Video;

using Cryogenic.Globals;

using Serilog;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class VideoCode : CSharpOverrideHelper
{
    private static readonly ILogger _logger = Log.Logger.ForContext<VideoCode>();
    private ExtraGlobalsOnDs globals;
    public VideoCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine): base(functionInformations, "video", machine)
    {
        this.globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0xC921, "read33A3WithAxOffset/get_hnm_resource_flag_name_ptr_by_index_ax_to_bx_ida", Read33A3WithAxOffset_1ED_C921_E7F1);
        DefineFunction(segment, 0xCA59, "videoPlayRelated", VideoPlayRelated_1ED_CA59_E929);
        DefineFunction(segment, 0xCC85, "isLastFrame/check_if_hnm_complete_ida", IsLastFrame_1ED_CC85_EB55);
    }

    public  Action IsLastFrame_1ED_CC85_EB55()
    {
        int value = globals.Get1138_DBE7_Byte8_hnmFinishedFlag();
        _logger.Debug("DBE7={@DBE7}", value);
        _state.SetZeroFlag(value == 0 || value == 1);
        return NearRet();
    }

    /// <summary>
    /// Reads value at DS:(AX*2)+0x33A3 and returns it in BX
    /// </summary>
    public  Action Read33A3WithAxOffset_1ED_C921_E7F1()
    {

        // Only executed when a video starts
        int offset = _state.GetAX() * 2 + 0x33A3;
        uint address = MemoryUtils.ToPhysicalAddress(_state.GetDS(), (ushort)offset);
        ushort value = _memory.GetUint16(address);
        _logger.Debug("read33A3WithAxOffset {@Ax} {@Address} {@Value}", _state.GetAX(), address, value);
        _state.SetBX(value);
        return NearRet();
    }

    public  Action VideoPlayRelated_1ED_CA59_E929()
    {

        // seems to have no impact what so ever is done here. Only executed during videos
        ushort value = globals.Get1138_CE7A_Word16_VideoPlayRelatedIndex();
        globals.Set1138_DC22_Word16_VideoPlayRelatedIndex(value);
        _logger.Debug("videoPlayRelated value:{@Value}", value);
        return NearRet();
    }
}