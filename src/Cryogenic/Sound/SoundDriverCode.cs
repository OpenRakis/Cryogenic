namespace Cryogenic.Sound;

using Serilog;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class SoundDriverCode : CSharpOverrideHelper {
    private static readonly ILogger _logger = Log.Logger.ForContext<SoundDriverCode>();
    private ushort baseSegment1;
    private ushort baseSegment2;

    public SoundDriverCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort programStartSegment, Machine machine) : base(functionInformations, "soundDriverPcSpeaker", machine) {
        baseSegment1 = (ushort)(0x4635 + programStartSegment);
        DefineFunction(baseSegment1, 0x100, PcSpeakerActivationWithBXAndALCleanup_4822_100_48320);
        DefineFunction(baseSegment1, 0x103, ClearAL_4822_103_48323);
        DefineFunction(baseSegment1, 0x109, ClearAL_4822_109_48329);
        DefineFunction(baseSegment1, 0x10C, ClearAL_4822_10C_4832C);
        DefineFunction(baseSegment1, 0x115, ClearAL_4822_115_48335);
        DefineFunction(baseSegment1, 0x182, PcSpeakerActivationWithALCleanup_4822_182_483A2);
        DefineFunction(baseSegment1, 0x188, PcSpeakerActivation_4822_188_483A8);
        baseSegment2 = (ushort)(0x463E + programStartSegment);
        DefineFunction(baseSegment2, 0x100, PcSpeakerActivationWithBXAndALCleanup_482B_100_483B0);
        DefineFunction(baseSegment2, 0x106, ClearAL_482B_106_483B6);
        DefineFunction(baseSegment2, 0x112, ClearAL_482B_112_483C2);
        DefineFunction(baseSegment2, 0x182, PcSpeakerActivationWithALCleanup_482B_182_48432);
        DefineFunction(baseSegment2, 0x188, PcSpeakerActivation_482B_188_48438);
    }

    public Action ClearAL_4822_103_48323() {
        return SoundUnsupportedFarRet();
    }

    public Action ClearAL_4822_109_48329() {
        return SoundUnsupportedFarRet();
    }

    public Action ClearAL_4822_10C_4832C() {
        return SoundUnsupportedFarRet();
    }

    public Action ClearAL_4822_115_48335() {
        return SoundUnsupportedFarRet();
    }

    public Action ClearAL_482B_106_483B6() {
        return SoundUnsupportedFarRet();
    }

    public Action ClearAL_482B_112_483C2() {
        return SoundUnsupportedFarRet();
    }

    public ushort GetBaseSegment1() {
        return baseSegment1;
    }

    public ushort GetBaseSegment2() {
        return baseSegment2;
    }

    public Action PcSpeakerActivation_4822_188_483A8() {
        _logger.Debug("Other PC Speaker activation");
        return this.NearRet();
    }

    public Action PcSpeakerActivation_482B_188_48438() {
        _logger.Debug("PC Speaker activation");
        return this.NearRet();
    }

    public Action PcSpeakerActivationWithALCleanup_4822_182_483A2() {
        PcSpeakerActivation_4822_188_483A8();
        return SoundUnsupportedFarRet();
    }

    public Action PcSpeakerActivationWithALCleanup_482B_182_48432() {
        _logger.Debug("PC Speaker activation with AL cleanup");
        PcSpeakerActivation_482B_188_48438();
        return SoundUnsupportedFarRet();
    }

    public Action PcSpeakerActivationWithBXAndALCleanup_4822_100_48320() {
        PcSpeakerActivationWithALCleanup_4822_182_483A2();
        State.BX = (0);
        return FarRet();
    }

    public Action PcSpeakerActivationWithBXAndALCleanup_482B_100_483B0() {
        _logger.Debug("PC Speaker activation with BX and AL cleanup");
        PcSpeakerActivationWithALCleanup_482B_182_48432();
        State.BX = (0);
        return this.FarRet();
    }

    private Action SoundUnsupportedFarRet() {
        // 483A5
        State.AL = (0);
        return FarRet();
    }
}