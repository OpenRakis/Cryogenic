namespace Cryogenic.Mainexe.Timer;

using Serilog;

using Spice86.Emulator.Devices.Timer;
using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class TimerCode : CSharpOverrideHelper
{
    private static readonly ILogger _logger = Log.Logger.ForContext<TimerCode>();
    public TimerCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine): base(functionInformations, "timer", machine)
    {
        DefineFunction(segment, 0xE8A8, "setPitTimerToAX", SetPitTimerToAX_ida_1ED_E8A8_10778);
    }

    public  Action SetPitTimerToAX_ida_1ED_E8A8_10778()
    {

        // Seems only called on quit
        ushort valueToSet = _state.GetAX();
        _logger.Debug("Setting timer 0 value to {@ValueToSet}", valueToSet);
        Timer timer = _machine.GetTimer();
        Counter counter = timer.GetCounter(0);
        counter.SetReadWritePolicy(0);
        counter.SetMode(3);
        counter.SetBcd(0);
        counter.SetValue(valueToSet);
        return NearRet();
    }
}