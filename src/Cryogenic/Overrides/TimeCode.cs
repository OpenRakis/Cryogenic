namespace Cryogenic.Overrides;

using Serilog.Events;

using Spice86.Core.Emulator.ReverseEngineer;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {

    public void DefineTimeCodeOverrides() {
        DefineFunction(cs1, 0x1AD1, GetSunlightDay_1ED_1AD1_39A1);
        DefineFunction(cs1, 0x1AE0, SetHourOfTheDayToAX_1ED_1AE0_39B0);
    }

    public ushort GetHourOfTheDay() {
        return (ushort)(globalsOnDs.Get1138_0002_Word16_GameElapsedTime() & 0xF);
    }

    /// <summary>
    /// Puts into AX the day where the sunlight will be seen, either current day or next day.
    /// </summary>
    public Action GetSunlightDay_1ED_1AD1_39A1(int gotoAddress) {
        ushort elapsed = globalsOnDs.Get1138_0002_Word16_GameElapsedTime();
        ushort in3Hours = (ushort)(elapsed + 3);
        ushort day = (ushort)(in3Hours >> 4);
        State.AX = day;
        return NearRet();
    }

    public Action SetHourOfTheDayToAX_1ED_1AE0_39B0(int gotoAddress) {
        State.AX = GetHourOfTheDay();
        if (_logger.IsEnabled(LogEventLevel.Debug)) {
            _logger.Debug("setHourOfTheDayToAX:gameTime:{@GameTime}, gameHour:{@GameHour}", globalsOnDs.Get1138_0002_Word16_GameElapsedTime(), State.AX);
        }

        return NearRet();
    }
}