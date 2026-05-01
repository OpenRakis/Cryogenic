namespace Cryogenic.Overrides;

using Serilog;

/// <summary>
/// DNADG (AdLib Gold / OPL3) C# override scaffold.
/// This class is intentionally registration-only until runtime evidence is collected.
/// </summary>
public partial class Overrides {
    private static readonly ILogger AdgLogger = Log.ForContext("Subsystem", "ADGDriver");
    private static bool EnableAdgCSharpFunctionReplacement = false;
    private ushort _adgSegment = 0x5BAE;

    private const ushort AdgDefaultSegment = 0x5BAE;

    /// <summary>
    /// Registers DNADG overrides.
    /// Registration is intentionally disabled by default until the runtime ABI is validated from live MCP evidence.
    /// </summary>
    public void DefineAdgDriverCodeOverrides() {
        if (!EnableAdgCSharpFunctionReplacement) {
            AdgLogger.Information("DNADG full replacement disabled.");
            return;
        }

        ResolveAdgSegment();
        AdgLogger.Information("DNADG replacement enabled but no function replacements are registered yet. Segment={AdgSegmentHex}",
            $"0x{_adgSegment:X4}");
    }

    private void ResolveAdgSegment() {
        if (DriverLoadToolbox.ActualAdpSegment != 0) {
            _adgSegment = DriverLoadToolbox.ActualAdpSegment;
        } else {
            _adgSegment = AdgDefaultSegment;
        }
    }
}