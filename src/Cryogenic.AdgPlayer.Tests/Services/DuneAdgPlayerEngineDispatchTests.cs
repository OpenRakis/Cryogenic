namespace Cryogenic.AdgPlayer.Tests.Services;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Services;
using Cryogenic.AdgPlayer.Song;

using Xunit;

/// <summary>
/// Tests for the B4 event dispatcher in <see cref="DuneAdgPlayerEngine"/>.
/// Covers the two opcodes implemented in this cycle (ReadWaitValue,
/// EndOfTrack) and the structured fall-through for unhandled musical
/// opcodes (NoteOff/NoteOn/ProgramChange/VolumeModulation/PitchBend),
/// each of which raises <see cref="DuneAdgPlayerEngine.UnhandledOpcodeEncountered"/>
/// and zeroes the channel pointer.
/// </summary>
public sealed class DuneAdgPlayerEngineDispatchTests {
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

    private static DuneAdgPlayerEngine LoadEngine(byte[] bytes) {
        DuneAdgPlayerEngine engine = new();
        engine.Load(bytes);
        return engine;
    }

    /// <summary>
    /// ReadWaitValue (slot 2) consumes a single-byte wait value and
    /// seeds the channel wait counter.
    /// </summary>
    [Fact]
    public void Dispatch_ReadWaitValue_SingleByte_SeedsWaitCounter() {
        // Arrange — channel 0 relative offset 0x10 → absolute pointer 0x12.
        //   word at 0x12 = 0x0020 (slot 2 = ReadWaitValue), then byte 0x05.
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x20;
        bytes[0x13] = 0x00;
        bytes[0x14] = 0x05;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        // Force wait to 0 so dispatch fires immediately.
        engine.State.WaitCounters.Set(0, 0);

        // Act
        int dispatched = engine.DispatchEvents(0);

        // Assert
        Assert.Equal(1, dispatched);
        Assert.Equal(5, engine.State.WaitCounters.Get(0));
        Assert.Equal(0x15, engine.State.EventPointers.Get(0));
    }

    /// <summary>
    /// ReadWaitValue with a multi-byte continuation accumulates 7-bit
    /// chunks high-to-low (mirrors AdgReadWaitValue_0E7E).
    /// </summary>
    [Fact]
    public void Dispatch_ReadWaitValue_MultiByte_Accumulates() {
        // Arrange — value 0x81 0x05 → ((0x01) << 7) | 0x05 = 0x85.
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x20;
        bytes[0x13] = 0x00;
        bytes[0x14] = 0x81; // continuation
        bytes[0x15] = 0x05; // terminator
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);

        // Act
        engine.DispatchEvents(0);

        // Assert
        Assert.Equal(0x85, engine.State.WaitCounters.Get(0));
        Assert.Equal(0x16, engine.State.EventPointers.Get(0));
    }

    /// <summary>
    /// EndOfTrack (slot 7) zeroes the channel event pointer so the
    /// channel is excluded from subsequent ticks.
    /// </summary>
    [Fact]
    public void Dispatch_EndOfTrack_ZeroesPointer() {
        // Arrange — channel 0 relative 0x10 → absolute 0x12; slot 7 word = 0x0070.
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x70;
        bytes[0x13] = 0x00;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);

        // Act
        engine.DispatchEvents(0);

        // Assert
        Assert.Equal(0, engine.State.EventPointers.Get(0));
    }

    /// <summary>
    /// Slot 3 also routes to ReadWaitValue (per AdgEventOpcodeRouter).
    /// </summary>
    [Fact]
    public void Dispatch_ReadWaitValue_Slot3_AlsoRoutes() {
        // Arrange — slot 3 event word = 0x0030, at absolute pointer 0x12.
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x30;
        bytes[0x13] = 0x00;
        bytes[0x14] = 0x07;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);

        // Act
        engine.DispatchEvents(0);

        // Assert
        Assert.Equal(7, engine.State.WaitCounters.Get(0));
    }

    /// <summary>
    /// Unhandled musical opcode (NoteOff in this case) raises the
    /// structured event AND zeroes the channel pointer to prevent
    /// runaway dispatch.
    /// </summary>
    [Fact]
    public void Dispatch_UnhandledOpcode_RaisesEventAndZeroesPointer() {
        // Arrange — slot 0 = NoteOff (not yet ported); event word at absolute 0x12.
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0xAB; // event word lo (only bits 4..6 select slot)
        bytes[0x13] = 0xCD;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);
        AdgUnhandledOpcodeArgs? captured = null;
        engine.UnhandledOpcodeEncountered += args => captured = args;

        // Act
        engine.DispatchEvents(0);

        // Assert
        Assert.NotNull(captured);
        Assert.Equal(0, captured!.Value.ChannelIndex);
        Assert.Equal(AdgEventOpcode.NoteOff, captured.Value.Opcode);
        Assert.Equal(0, engine.State.EventPointers.Get(0));
    }

    /// <summary>
    /// Calling DispatchEvents with no song loaded throws.
    /// </summary>
    [Fact]
    public void Dispatch_NoSong_Throws() {
        // Arrange
        DuneAdgPlayerEngine engine = new();

        // Act / Assert
        Assert.Throws<System.InvalidOperationException>(() => engine.DispatchEvents(0));
    }

    /// <summary>
    /// Tick auto-dispatches when a channel's wait counter reaches zero,
    /// chaining ReadWaitValue → EndOfTrack so the channel exits cleanly.
    /// </summary>
    [Fact]
    public void Tick_ChainsReadWaitThenEndOfTrack() {
        // Arrange — channel 0 relative 0x10 → absolute pointer 0x12.
        //   ReadWaitValue (0x0020) + 0x02
        //   ReadWaitValue (0x0020) + 0x01
        //   EndOfTrack (0x0070)
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x20;
        bytes[0x13] = 0x00;
        bytes[0x14] = 0x02;
        bytes[0x15] = 0x20;
        bytes[0x16] = 0x00;
        bytes[0x17] = 0x01;
        bytes[0x18] = 0x70;
        bytes[0x19] = 0x00;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.Play();

        // Act — first tick dispatches first ReadWaitValue (wait=2).
        bool t1 = engine.Tick();
        // Tick 2 decrements wait 2→1.
        bool t2 = engine.Tick();
        // Tick 3 decrements wait 1→0 and dispatches second ReadWaitValue (wait=1).
        bool t3 = engine.Tick();
        // Tick 4 decrements wait 1→0 and dispatches EndOfTrack → channel cleared.
        bool t4 = engine.Tick();

        // Assert
        Assert.True(t1);
        Assert.True(t2);
        Assert.True(t3);
        Assert.False(t4);
        Assert.Equal(0, engine.State.EventPointers.Get(0));
        Assert.False(engine.IsPlaying);
    }
}
