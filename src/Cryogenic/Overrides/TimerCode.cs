namespace Cryogenic.Overrides;

using Spice86.Emulator.Devices.Timer;
using Spice86.Emulator.ReverseEngineer;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {
    public void DefineTimerCodeOverrides() {
        DefineFunction(cs1, 0xE8A8, SetPitTimerToAX_1ED_E8A8_10778);
    }

    public Action SetPitTimerToAX_1ED_E8A8_10778(int gotoAddress) {
        // Seems only called on quit
        ushort valueToSet = State.AX;
        _logger.Debug("Setting timer 0 value to {@ValueToSet}", valueToSet);
        Timer timer = Machine.Timer;
        Counter counter = timer.GetCounter(0);
        counter.ReadWritePolicy = 0;
        counter.Mode = 3;
        counter.Bcd = 0;
        counter.SetValue(valueToSet);
        return NearRet();
    }
}