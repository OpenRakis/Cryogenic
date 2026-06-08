namespace Cryogenic.AdgPlayer.Ui.Services;

using System.IO;

/// <summary>
/// AdLib Gold control-path behavior for DNADG: Gold init, surround-table programming, and global volume writes.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
    private const int GoldSwitchFunctionsHeaderOffset = 0x32;
    private const int GoldSurroundTableHeaderOffset = 0x33;
    private const int GoldSurroundEntryCount = 0x1F;
    private const byte GoldRegisterStereoLeft = 0x04;
    private const byte GoldRegisterStereoRight = 0x05;
    private const byte GoldRegisterBass = 0x06;
    private const byte GoldRegisterTreble = 0x07;
    private const byte GoldRegisterSwitchFunctions = 0x08;
    private const byte GoldRegisterLeftFmVolume = 0x09;
    private const byte GoldRegisterRightFmVolume = 0x0A;
    private const byte GoldRegisterSurroundControl = 0x18;
    private const byte GoldVolumePrefix = 0x81;

    /// <summary>
    /// Mirrors the fixed AdLib Gold startup programming from AdgInitializeGoldHardware_1185.
    /// </summary>
    private void InitializeGoldHardware() {
        GoldControlWrite(GoldRegisterBass, 0xFB);
        GoldControlWrite(GoldRegisterTreble, 0xF7);
        GoldControlWrite(GoldRegisterStereoLeft, 0xF7);
        GoldControlWrite(GoldRegisterStereoRight, 0xF7);
        GoldControlWrite(GoldRegisterLeftFmVolume, 0xFF);
        GoldControlWrite(GoldRegisterRightFmVolume, 0xFF);
    }

    /// <summary>
    /// Mirrors helper 0F78: loads switch-functions from the song header and replays the 31-byte surround table.
    /// </summary>
    private void InitializeGoldSongControls() {
        int surroundModeOffset = _dataBase + GoldSwitchFunctionsHeaderOffset;
        int surroundTableOffset = _dataBase + GoldSurroundTableHeaderOffset;
        if (_songData.Length < surroundTableOffset + GoldSurroundEntryCount) {
            throw new InvalidDataException($"Song is too short for AdLib Gold surround data: length={_songData.Length}, required={surroundTableOffset + GoldSurroundEntryCount}");
        }

        byte switchFunctions = SongByte(surroundModeOffset);
        GoldControlWrite(GoldRegisterSwitchFunctions, switchFunctions);
        UpdateGoldSurroundTable((ushort)surroundTableOffset);
    }

    /// <summary>
    /// Mirrors AdgApplyMasterVolumeToGold_0F21.
    /// </summary>
    private void ApplyMasterVolumeToGold() {
        byte highNibble = (byte)(_currentVolume & 0xF0);
        byte highRegisterValue = (byte)((highNibble >> 3) | GoldVolumePrefix);
        GoldControlWrite(GoldRegisterLeftFmVolume, highRegisterValue);

        byte lowNibble = (byte)(_currentVolume & 0x0F);
        byte lowRegisterValue = (byte)((lowNibble << 1) | GoldVolumePrefix);
        GoldControlWrite(GoldRegisterRightFmVolume, lowRegisterValue);
    }

    /// <summary>
    /// Mirrors AdgUpdateGoldSurround_11C4 using the live-captured 11F4 serializer behavior.
    /// </summary>
    private void UpdateGoldSurroundTable(ushort tableOffset) {
        byte registerValue = 0;
        for (int index = 0; index < GoldSurroundEntryCount; index++) {
            registerValue = ShiftGoldSurroundMask((byte)index, registerValue);
            GoldControlWrite(GoldRegisterSurroundControl, (byte)(registerValue | 0x04));

            byte surroundValue = SongByte16((ushort)(tableOffset + index));
            registerValue = ShiftGoldSurroundMask(surroundValue, registerValue);
            GoldControlWrite(GoldRegisterSurroundControl, (byte)(registerValue & 0xFB));
        }
    }

    /// <summary>
    /// Mirrors AdgWriteGoldSurroundMask_11F4 based on the live 11C4/11F4 trace.
    /// </summary>
    private byte ShiftGoldSurroundMask(byte dataValue, byte registerValue) {
        ushort shiftRegister = dataValue;
        for (int index = 0; index < 8; index++) {
            registerValue = (byte)(registerValue & 0xFD);
            GoldControlWrite(GoldRegisterSurroundControl, registerValue);

            shiftRegister = (ushort)(shiftRegister << 1);
            registerValue = (byte)((registerValue & 0xFE) | Hi8(shiftRegister));
            GoldControlWrite(GoldRegisterSurroundControl, registerValue);

            registerValue = (byte)(registerValue | 0x02);
            GoldControlWrite(GoldRegisterSurroundControl, registerValue);
        }
        return registerValue;
    }
}