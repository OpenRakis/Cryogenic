namespace Cryogenic.Mainexe.Sound;

using Cryogenic.Globals;
using Cryogenic.Sound;

using Spice86.Emulator.CPU;
using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class SoundCode : CSharpOverrideHelper
{
    private SoundDriverCode soundDriver;
    private ExtraGlobalsOnDs globals;
    public SoundCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine, SoundDriverCode soundDriver): base(functionInformations, "sound", machine)
    {
        this.soundDriver = soundDriver;
        this.globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0xAC30, "soundDriverUnknownClearAL/call_pcm_audio_vtable_func_5_ida", SoundDriverUnknownClearAL_1ED_AC30_CB00);
        DefineFunction(segment, 0xAEB7, "checkSoundPresent/midi_func_2_0_ida", CheckSoundPresent_1ED_AEB7_CD87);
    }

    public  Action SoundDriverUnknownClearAL_1ED_AC30_CB00()
    {

        // Called at scene change
        CheckVtableContainsExpected(SegmentRegisters.DsIndex, 0x3999, soundDriver.GetBaseSegment1(), 0x10C);
        soundDriver.ClearAL_4822_10C_4832C();
        return NearRet();
    }

    public  Action CheckSoundPresent_1ED_AEB7_CD87()
    {

        // Called before videos
        CheckVtableContainsExpected(SegmentRegisters.DsIndex, 0x3975, soundDriver.GetBaseSegment2(), 0x106);
        globals.Set1138_DBCB_Byte8(0);
        soundDriver.ClearAL_482B_106_483B6();
        globals.Set1138_DBCD_Byte8_IsSoundPresent(_state.GetAL());
        return NearRet();
    }
}
