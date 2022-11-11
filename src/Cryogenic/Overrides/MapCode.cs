namespace Cryogenic.Overrides;


using Spice86.Core.Emulator.Memory;
using Spice86.Core.Emulator.ReverseEngineer;
using Spice86.Core.Utils;

using System;

// Method names contain _ to separate addresses.
public partial class Overrides : CSharpOverrideHelper {
    public const ushort CLICK_HANDLER_FLAT_MAP = 0x1A9E;
    public const ushort CLICK_HANDLER_GLOBE_MAP = 0x2562;
    public const ushort CLICK_HANDLER_INGAME = 0x2572;
    public const ushort CLICK_HANDLER_MOVE_TROOP_MAP = 0x1AAC;
    public const ushort CLICK_HANDLER_ORNI_MAP = 0x1AC8;

    public void DefineMapCodeOverrides() {
        DefineFunction(cs1, 0xD95B, SetMapClickHandlerAddressToInGame_1ED_D95B_F82B);
        DefineFunction(cs1, 0xD95E, SetMapClickHandlerAddressFromAx_1ED_D95E_F82E);
        DefineFunction(cs1, 0xDAA3, InitMapCursorTypeDC58To0_1ED_DAA3_F973);
        DefineFunction(cs1, 0xDAAA, SetSiToMapCursorTypeDC58_1ED_DAAA_F97A);
        DefineFunction(cs1, 0x5B96, UnknownMemcopy_1ED_5B96_7A66);
    }

    public Action InitMapCursorTypeDC58To0_1ED_DAA3_F973(int gotoAddress) {
        // when 0 or any other value, map cursor is disabled for globe / orni.
        this.globalsOnDs.Set1138_DC58_Word16_MapCursorType(0);
        return NearRet();
    }

    public Action SetMapClickHandlerAddressFromAx_1ED_D95E_F82E(int gotoAddress) {
        globalsOnDs.Set1138_2570_Word16_MapClickHandlerAddress(State.AX);
        if (_logger.IsEnabled(Serilog.Events.LogEventLevel.Debug)) {
            _logger.Debug("setMapClickHandlerAddressFromAx: DS:{@Ds}, AX:{@Ax}", ConvertUtils.ToHex16(State.DS), ConvertUtils.ToHex16(State.AX));
        }

        return NearRet();
    }

    public Action SetMapClickHandlerAddressToInGame_1ED_D95B_F82B(int gotoAddress) {
        // called when starting to fly the orni, exiting maps and when switching from intro to game
        // at load time
        // See setMapClickHandlerAddressFromAx_1ED_D95E_F82E
        State.AX = CLICK_HANDLER_INGAME;
        return SetMapClickHandlerAddressFromAx_1ED_D95E_F82E(0);
    }

    public Action SetSiToMapCursorTypeDC58_1ED_DAAA_F97A(int gotoAddress) {
        // when taking an orni: 0x149C, when loading globe or results: 0x2448
        ushort value = State.SI;
        if (_logger.IsEnabled(Serilog.Events.LogEventLevel.Debug)) {
            _logger.Debug("setSiToMapCursorTypeDC58: value:{@Value}", ConvertUtils.ToHex16(value));
        }

        this.globalsOnDs.Set1138_DC58_Word16_MapCursorType(value);
        return NearRet();
    }

    public Action UnknownMemcopy_1ED_5B96_7A66(int gotoAddress) {
        // Called on map display / move, data to be copied never seems to change.
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(State.DS, 0x46e3);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(State.DS, State.DI);
        Memory.MemCopy(sourceAddress, destinationAddress, 4 * 2);
        return NearRet();
    }
}