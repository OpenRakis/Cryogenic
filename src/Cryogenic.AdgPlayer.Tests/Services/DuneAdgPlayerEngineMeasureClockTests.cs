namespace Cryogenic.AdgPlayer.Tests.Services;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Services;
using Cryogenic.AdgPlayer.Song;

using Xunit;

/// <summary>
/// Tests for the measure/subdivision clock wired into the engine
/// tick. Mirrors the tail of <c>AdgSchedulerTick_0756</c>
/// (dnadg:079D-07A8): subdivision is decremented every tick; on
/// reaching zero, it reloads to 0x60 and the measure word advances.
/// </summary>
public sealed class DuneAdgPlayerEngineMeasureClockTests {
    private static byte[] BuildSong(ushort[] channelOffsets) {
        byte[] bytes = new byte[0x200];
        bytes[0] = 0x00;
        bytes[1] = 0x01;
        int dataBase = AdgSongHeader.DataBase;
        for (int i = 0; i < AdgSongHeader.ChannelCount; i++) {
            bytes[dataBase + i * 2] = (byte)(channelOffsets[i] & 0xFF);
            bytes[dataBase + i * 2 + 1] = (byte)(channelOffsets[i] >> 8);
        }
        return bytes;
    }

    /// <summary>
    /// <see cref="DuneAdgPlayerEngine.Load"/> seeds measure=1 and
    /// subdivision=0x60 so the song starts at the canonical
    /// AdgResetSchedulerState_06B9 state.
    /// </summary>
    [Fact]
    public void Load_SeedsMeasureClock() {
        // Arrange
        byte[] bytes = BuildSong(new ushort[9]);
        DuneAdgPlayerEngine engine = new();

        // Act
        engine.Load(bytes);

        // Assert
        Assert.Equal(1, engine.State.LoopState.Measure);
        Assert.Equal(AdgMeasureClock.SubdivisionsPerMeasure, engine.State.LoopState.Subdivision);
    }

    /// <summary>
    /// One tick decrements the subdivision word by one without
    /// advancing the measure.
    /// </summary>
    [Fact]
    public void Tick_DecrementsSubdivision() {
        // Arrange
        byte[] bytes = BuildSong(new ushort[9]);
        DuneAdgPlayerEngine engine = new();
        engine.Load(bytes);
        ushort startSubdivision = engine.State.LoopState.Subdivision;

        // Act
        engine.Tick();

        // Assert
        Assert.Equal((ushort)(startSubdivision - 1), engine.State.LoopState.Subdivision);
        Assert.Equal(1, engine.State.LoopState.Measure);
    }

    /// <summary>
    /// After 0x60 ticks, the subdivision counter rolls over: it
    /// reloads to 0x60 and the measure increments to 2.
    /// </summary>
    [Fact]
    public void Tick_RollsOverSubdivision_AdvancesMeasure() {
        // Arrange
        byte[] bytes = BuildSong(new ushort[9]);
        DuneAdgPlayerEngine engine = new();
        engine.Load(bytes);

        // Act — exactly one full measure of ticks.
        for (int i = 0; i < AdgMeasureClock.SubdivisionsPerMeasure; i++) {
            engine.Tick();
        }

        // Assert
        Assert.Equal(AdgMeasureClock.SubdivisionsPerMeasure, engine.State.LoopState.Subdivision);
        Assert.Equal(2, engine.State.LoopState.Measure);
    }
}
