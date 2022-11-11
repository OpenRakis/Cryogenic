namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Devices.Timer;
using Spice86.Core.Emulator.ReverseEngineer;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides {
    public void DefineTimerCodeOverrides() {
        DefineFunction(cs1, 0xE8A8, SetPitTimerToAX_1000_E8A8_01E8A8);
    }

    public Action SetPitTimerToAX_1000_E8A8_01E8A8(int gotoAddress) {
        // Seems only called on quit
        ushort valueToSet = AX;
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