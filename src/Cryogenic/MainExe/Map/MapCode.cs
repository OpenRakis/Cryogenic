namespace Cryogenic.Mainexe.Dictionary;

using Cryogenic.Globals;

using Serilog;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;
using Spice86.Utils;

using System;
using System.Collections.Generic;

// Method names contain _ to separate addresses.
public class MapCode : CSharpOverrideHelper {
    public const ushort CLICK_HANDLER_FLAT_MAP = 0x1A9E;
    public const ushort CLICK_HANDLER_GLOBE_MAP = 0x2562;
    public const ushort CLICK_HANDLER_INGAME = 0x2572;
    public const ushort CLICK_HANDLER_MOVE_TROOP_MAP = 0x1AAC;
    public const ushort CLICK_HANDLER_ORNI_MAP = 0x1AC8;
    private static readonly ILogger _logger = Log.Logger.ForContext<MapCode>();
    private ExtraGlobalsOnDs globals;

    public MapCode(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, ushort segment, Machine machine) : base(functionInformations, "map", machine) {
        this.globals = new ExtraGlobalsOnDs(machine);
        DefineFunction(segment, 0xD95B, "setMapClickHandlerAddressToInGame", SetMapClickHandlerAddressToInGame_1ED_D95B_F82B);
        DefineFunction(segment, 0xD95E, "setMapClickHandlerAddressFromAx", SetMapClickHandlerAddressFromAx_1ED_D95E_F82E);
        DefineFunction(segment, 0xDAA3, "initMapCursorTypeDC58To0", InitMapCursorTypeDC58To0_1ED_DAA3_F973);
        DefineFunction(segment, 0xDAAA, "setSiToMapCursorTypeDC58", SetSiToMapCursorTypeDC58_1ED_DAAA_F97A);
        DefineFunction(segment, 0x5B96, "unknownMemcopy", UnknownMemcopy_1ED_5B96_7A66);
    }

    public Action InitMapCursorTypeDC58To0_1ED_DAA3_F973() {
        // when 0 or any other value, map cursor is disabled for globe / orni.
        this.globals.Set1138_DC58_Word16_MapCursorType(0);
        return NearRet();
    }

    public Action SetMapClickHandlerAddressFromAx_1ED_D95E_F82E() {
        globals.Set1138_2570_Word16_MapClickHandlerAddress(State.AX);
        if (_logger.IsEnabled(Serilog.Events.LogEventLevel.Debug)) {
            _logger.Debug("setMapClickHandlerAddressFromAx: DS:{@Ds}, AX:{@Ax}", ConvertUtils.ToHex16(State.DS), ConvertUtils.ToHex16(State.AX));
        }

        return NearRet();
    }

    public Action SetMapClickHandlerAddressToInGame_1ED_D95B_F82B() {
        // called when starting to fly the orni, exiting maps and when switching from intro to game
        // at load time
        // See setMapClickHandlerAddressFromAx_1ED_D95E_F82E
        State.AX = (CLICK_HANDLER_INGAME);
        return SetMapClickHandlerAddressFromAx_1ED_D95E_F82E();
    }

    public Action SetSiToMapCursorTypeDC58_1ED_DAAA_F97A() {
        // when taking an orni: 0x149C, when loading globe or results: 0x2448
        ushort value = State.SI;
        if (_logger.IsEnabled(Serilog.Events.LogEventLevel.Debug)) {
            _logger.Debug("setSiToMapCursorTypeDC58: value:{@Value}", ConvertUtils.ToHex16(value));
        }

        this.globals.Set1138_DC58_Word16_MapCursorType(value);
        return NearRet();
    }

    public Action UnknownMemcopy_1ED_5B96_7A66() {
        // Called on map display / move, data to be copied never seems to change.
        uint sourceAddress = MemoryUtils.ToPhysicalAddress(State.DS, 0x46e3);
        uint destinationAddress = MemoryUtils.ToPhysicalAddress(State.DS, State.DI);
        Memory.MemCopy(sourceAddress, destinationAddress, 4 * 2);
        return NearRet();
    }
}