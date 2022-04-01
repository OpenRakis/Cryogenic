namespace Cryogenic.Overrides;

using Spice86.Emulator.ReverseEngineer;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {
    public void DefineSoundDriverCodeOverrides() {
        DefineFunction(cs3, 0x100, PcSpeakerActivationWithBXAndALCleanup_4822_100_48320);
        DefineFunction(cs3, 0x103, ClearAL_4822_103_48323);
        DefineFunction(cs3, 0x109, ClearAL_4822_109_48329);
        DefineFunction(cs3, 0x10C, ClearAL_4822_10C_4832C);
        DefineFunction(cs3, 0x115, ClearAL_4822_115_48335);
        DefineFunction(cs3, 0x182, PcSpeakerActivationWithALCleanup_4822_182_483A2);
        DefineFunction(cs3, 0x188, PcSpeakerActivation_4822_188_483A8);
        DefineFunction(cs4, 0x100, PcSpeakerActivationWithBXAndALCleanup_482B_100_483B0);
        DefineFunction(cs4, 0x106, ClearAL_482B_106_483B6);
        DefineFunction(cs4, 0x112, ClearAL_482B_112_483C2);
        DefineFunction(cs4, 0x182, PcSpeakerActivationWithALCleanup_482B_182_48432);
        DefineFunction(cs4, 0x188, PcSpeakerActivation_482B_188_48438);
    }

    public Action ClearAL_4822_103_48323(int gotoAddress) {
        return SoundUnsupportedFarRet();
    }

    public Action ClearAL_4822_109_48329(int gotoAddress) {
        return SoundUnsupportedFarRet();
    }

    public Action ClearAL_4822_10C_4832C(int gotoAddress) {
        return SoundUnsupportedFarRet();
    }

    public Action ClearAL_4822_115_48335(int gotoAddress) {
        return SoundUnsupportedFarRet();
    }

    public Action ClearAL_482B_106_483B6(int gotoAddress) {
        return SoundUnsupportedFarRet();
    }

    public Action ClearAL_482B_112_483C2(int gotoAddress) {
        return SoundUnsupportedFarRet();
    }

    public ushort GetBaseSegment1() {
        return cs3;
    }

    public ushort GetBaseSegment2() {
        return cs4;
    }

    public Action PcSpeakerActivation_4822_188_483A8(int gotoAddress) {
        _logger.Debug("Other PC Speaker activation");
        return this.NearRet();
    }

    public Action PcSpeakerActivation_482B_188_48438(int gotoAddress) {
        _logger.Debug("PC Speaker activation");
        return this.NearRet();
    }

    public Action PcSpeakerActivationWithALCleanup_4822_182_483A2(int gotoAddress) {
        PcSpeakerActivation_4822_188_483A8(0);
        return SoundUnsupportedFarRet();
    }

    public Action PcSpeakerActivationWithALCleanup_482B_182_48432(int gotoAddress) {
        _logger.Debug("PC Speaker activation with AL cleanup");
        PcSpeakerActivation_482B_188_48438(0);
        return SoundUnsupportedFarRet();
    }

    public Action PcSpeakerActivationWithBXAndALCleanup_4822_100_48320(int gotoAddress) {
        PcSpeakerActivationWithALCleanup_4822_182_483A2(0);
        State.BX = 0;
        return FarRet();
    }

    public Action PcSpeakerActivationWithBXAndALCleanup_482B_100_483B0(int gotoAddress) {
        _logger.Debug("PC Speaker activation with BX and AL cleanup");
        PcSpeakerActivationWithALCleanup_482B_182_48432(0);
        State.BX = 0;
        return this.FarRet();
    }

    private Action SoundUnsupportedFarRet() {
        // 483A5
        State.AL = 0;
        return FarRet();
    }
}