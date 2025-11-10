namespace Cryogenic.Overrides;

using Serilog.Events;

using Spice86.Core.Emulator.ReverseEngineer;

/// <summary>
/// Partial class containing game time and day/night cycle related overrides.
/// </summary>
/// <remarks>
/// Method names contain underscores to separate segment, offset, and linear addresses
/// for traceability back to the original DOS disassembly.
/// </remarks>
public partial class Overrides {

    /// <summary>
    /// Registers time and day/night cycle function overrides with Spice86.
    /// </summary>
    public void DefineTimeCodeOverrides() {
        DefineFunction(cs1, 0x1AD1, GetSunlightDay_1000_1AD1_011AD1);
        DefineFunction(cs1, 0x1AE0, SetHourOfTheDayToAX_1000_1AE0_011AE0);
    }

    /// <summary>
    /// Gets the current hour of the day (0-15) from the game elapsed time.
    /// </summary>
    /// <returns>The hour of the day as a 4-bit value (0x0 to 0xF).</returns>
    /// <remarks>
    /// Extracts the lower 4 bits of the game elapsed time counter,
    /// representing the hour within the current day.
    /// </remarks>
    public ushort GetHourOfTheDay() {
        return (ushort)(globalsOnDs.Get1138_0002_Word16_GameElapsedTime() & 0xF);
    }

    /// <summary>
    /// Override for CS1:1AD1 - Calculates which day sunlight will be visible (current or next day).
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <remarks>
    /// Puts into AX the day where the sunlight will be seen, either current day or next day.
    /// The calculation adds 3 hours to the current time and extracts the day component
    /// by right-shifting 4 bits (dividing by 16 hours per day).
    /// </remarks>
    public Action GetSunlightDay_1000_1AD1_011AD1(int gotoAddress) {
        ushort elapsed = globalsOnDs.Get1138_0002_Word16_GameElapsedTime();
        ushort in3Hours = (ushort)(elapsed + 3);
        ushort day = (ushort)(in3Hours >> 4);
        AX = day;
        return NearRet();
    }

    /// <summary>
    /// Override for CS1:1AE0 - Sets the AX register to the current hour of the day.
    /// </summary>
    /// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
    /// <returns>A near return action to exit the function.</returns>
    /// <remarks>
    /// Retrieves the hour component from game elapsed time and stores it in AX.
    /// Logs the full game time and extracted hour value when debug logging is enabled.
    /// </remarks>
    public Action SetHourOfTheDayToAX_1000_1AE0_011AE0(int gotoAddress) {
        AX = GetHourOfTheDay();
        if (_loggerService.IsEnabled(LogEventLevel.Debug)) {
            _loggerService.Debug("setHourOfTheDayToAX:gameTime:{@GameTime}, gameHour:{@GameHour}", globalsOnDs.Get1138_0002_Word16_GameElapsedTime(), AX);
        }

        return NearRet();
    }
}