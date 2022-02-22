namespace Cryogenic.Mainexe.Time;

using Cryogenic.Globals;

using Serilog;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class TimeCode : CSharpOverrideHelper {
    private static readonly ILogger _logger = Log.Logger.ForContext<TimeCode>();
    private ExtraGlobalsOnDs globals;

    public TimeCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine) : base(functionInformations, "time", machine) {
        globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0x1AD1, "getSunlightDay", GetSunlightDay_1ED_1AD1_39A1);
        DefineFunction(segment, 0x1AE0, "setHourOfTheDayToAX", SetHourOfTheDayToAX_1ED_1AE0_39B0);
    }

    public ushort GetHourOfTheDay() {
        return (ushort)(globals.Get1138_0002_Word16_GameElapsedTime() & 0xF);
    }

    /// <summary>
    /// Puts into AX the day where the sunlight will be seen, either current day or next day.
    /// </summary>
    public Action GetSunlightDay_1ED_1AD1_39A1() {
        ushort elapsed = globals.Get1138_0002_Word16_GameElapsedTime();
        ushort in3Hours = (ushort)(elapsed + 3);
        ushort day = (ushort)(in3Hours >> 4);
        _state.AX = (day);
        return NearRet();
    }

    public Action SetHourOfTheDayToAX_1ED_1AE0_39B0() {
        _state.AX = (GetHourOfTheDay());
        if (_logger.IsEnabled(Serilog.Events.LogEventLevel.Debug)) {
            _logger.Debug("setHourOfTheDayToAX:gameTime:{@GameTime}, gameHour:{@GameHour}", globals.Get1138_0002_Word16_GameElapsedTime(), _state.AX);
        }

        return NearRet();
    }
}