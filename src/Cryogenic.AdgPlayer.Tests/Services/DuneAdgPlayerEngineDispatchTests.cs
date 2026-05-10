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
    /// Unhandled musical opcode (ProgramChange slot 4, not yet ported)
    /// raises the structured event AND zeroes the channel pointer
    /// to prevent runaway dispatch.
    /// </summary>
    [Fact]
    public void Dispatch_UnhandledOpcode_RaisesEventAndZeroesPointer() {
        // Arrange — slot 4 = ProgramChange (not yet ported); event word at absolute 0x12.
        //   Low byte 0x40 → bits 4..6 = 0b100 = slot 4.
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x40;
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
        Assert.Equal(AdgEventOpcode.ProgramChange, captured.Value.Opcode);
        Assert.Equal(0, engine.State.EventPointers.Get(0));
    }

    /// <summary>
    /// NoteOff with matching current note clears the channel's
    /// current-note slot and advances the cursor past the velocity
    /// byte and the wait value.
    /// </summary>
    [Fact]
    public void Dispatch_NoteOff_MatchingNote_ClearsCurrentNoteAndAdvances() {
        // Arrange — slot 0 = NoteOff. Event word = (note=0x40 << 8) | 0x00.
        //   Channel 0 relative 0x10 → absolute 0x12.
        //   Layout: [0x12]=0x00 [0x13]=0x40 (event word, note 0x40),
        //   [0x14]=0x55 (velocity, skipped),
        //   [0x15]=0x03 (wait value, single-byte),
        //   [0x16]=0xFF (next-event byte for ScratchMaskClearer gate).
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x00;
        bytes[0x13] = 0x40;
        bytes[0x14] = 0x55;
        bytes[0x15] = 0x03;
        bytes[0x16] = 0xFF;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);
        // Channel 0 currently holds note 0x40 (transpose=0).
        engine.State.CurrentNotes.Set(0, 0x40);

        // Act
        engine.DispatchEvents(0);

        // Assert
        Assert.Equal(0, engine.State.CurrentNotes.Get(0));
        Assert.Equal(3, engine.State.WaitCounters.Get(0));
        Assert.Equal(0x16, engine.State.EventPointers.Get(0));
    }

    /// <summary>
    /// NoteOff for a different note than the channel currently holds
    /// is ignored: current-note remains, but velocity + wait are
    /// still consumed.
    /// </summary>
    [Fact]
    public void Dispatch_NoteOff_NonMatchingNote_LeavesCurrentNote() {
        // Arrange — channel currently holds 0x42, NoteOff fires for 0x40.
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x00;
        bytes[0x13] = 0x40;
        bytes[0x14] = 0x55;
        bytes[0x15] = 0x07;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);
        engine.State.CurrentNotes.Set(0, 0x42);

        // Act
        engine.DispatchEvents(0);

        // Assert — current note unchanged, but cursor advanced past wait.
        Assert.Equal(0x42, engine.State.CurrentNotes.Get(0));
        Assert.Equal(7, engine.State.WaitCounters.Get(0));
        Assert.Equal(0x16, engine.State.EventPointers.Get(0));
    }

    /// <summary>
    /// NoteOff applies the per-channel pitch transpose before
    /// matching against the channel's current note (mirrors the
    /// <c>add AL,[DI+0x91]</c> at dnadg:0ABE).
    /// </summary>
    [Fact]
    public void Dispatch_NoteOff_RespectsPitchTranspose() {
        // Arrange — raw note 0x40, transpose +2 → effective note 0x42.
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x00;
        bytes[0x13] = 0x40;
        bytes[0x14] = 0x00;
        bytes[0x15] = 0x01;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);
        engine.State.PitchTransposeSlots.Set(0, 0x02);
        engine.State.CurrentNotes.Set(0, 0x42);

        // Act
        engine.DispatchEvents(0);

        // Assert
        Assert.Equal(0, engine.State.CurrentNotes.Get(0));
    }

    /// <summary>
    /// When a routing table is bound, NoteOff also emits an OPL3
    /// key-off via <see cref="AdgChannelNoteOffEmitter"/>: the cached
    /// frequency word (key-on bit cleared) is rewritten to the
    /// channel's A0/B0 pair.
    /// </summary>
    [Fact]
    public void Dispatch_NoteOff_WithRoutingTable_EmitsKeyOffToOpl() {
        // Arrange — channel 0 routed to physical 0x00 (A0=0xA0, B0=0xB0)
        //   via channel-route byte 0x00 (high nibble selects bank, low
        //   nibble selects A0/B0 register pair).
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x00;
        bytes[0x13] = 0x40;
        bytes[0x14] = 0x00;
        bytes[0x15] = 0x01;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);
        engine.State.CurrentNotes.Set(0, 0x40);
        // Cache a frequency word so the emitter has something to write.
        engine.State.FrequencyWordCache.Set(0, 0x1234);
        // Build a minimal routing table (channel 0 routed to slot 0).
        byte[] channelRoutes = new byte[AdgChannelRoutingTable.ChannelCount];
        byte[] primaryRoutes = new byte[AdgChannelRoutingTable.ChannelCount];
        byte[] secondaryRoutes = new byte[AdgChannelRoutingTable.ChannelCount];
        engine.SetRoutingTable(new AdgChannelRoutingTable(channelRoutes, primaryRoutes, secondaryRoutes));
        Cryogenic.AdgPlayer.Opl.RecordingOplBus bus = new();
        engine.SetOplBus(bus);

        // Act
        engine.DispatchEvents(0);

        // Assert — at least one A0/B0 pair was written for channel 0.
        Assert.NotEmpty(bus.Writes);
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

    /// <summary>
    /// NoteOn (slot 1) stores the transposed note in the channel's
    /// current-note slot, recenters the pitch accumulator, and
    /// advances the cursor past velocity + wait value.
    /// </summary>
    [Fact]
    public void Dispatch_NoteOn_StoresCurrentNoteAndCentersPitch() {
        // Arrange — slot 1 NoteOn, note=0x40, velocity=0x55, wait=0x02.
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x10;
        bytes[0x13] = 0x40;
        bytes[0x14] = 0x55;
        bytes[0x15] = 0x02;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);
        engine.State.PitchAccumulators.Set(0, 0x00);

        // Act
        engine.DispatchEvents(0);

        // Assert
        Assert.Equal(0x40, engine.State.CurrentNotes.Get(0));
        Assert.Equal(AdgChannelPitchAccumulators.CenterValue, engine.State.PitchAccumulators.Get(0));
        Assert.Equal(2, engine.State.WaitCounters.Get(0));
        Assert.Equal(0x16, engine.State.EventPointers.Get(0));
    }

    /// <summary>
    /// NoteOn applies the per-channel pitch transpose to the raw
    /// note before storing it (mirrors <c>add AL,[DI+0x91]</c>
    /// at dnadg:0A99).
    /// </summary>
    [Fact]
    public void Dispatch_NoteOn_AppliesPitchTranspose() {
        // Arrange — raw note 0x40, transpose -1 → effective 0x3F.
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x10;
        bytes[0x13] = 0x40;
        bytes[0x14] = 0x00;
        bytes[0x15] = 0x01;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);
        engine.State.PitchTransposeSlots.Set(0, 0xFF);

        // Act
        engine.DispatchEvents(0);

        // Assert
        Assert.Equal(0x3F, engine.State.CurrentNotes.Get(0));
    }

    /// <summary>
    /// NoteOn fired while the channel still holds a previous note
    /// emits a key-off for the previous note before storing the new
    /// one — but only when a routing table is bound.
    /// </summary>
    [Fact]
    public void Dispatch_NoteOn_PreviousNoteHeld_EmitsKeyOffWhenRouted() {
        // Arrange — channel already holds note 0x42; new NoteOn for 0x40.
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x10;
        bytes[0x13] = 0x40;
        bytes[0x14] = 0x00;
        bytes[0x15] = 0x01;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);
        engine.State.CurrentNotes.Set(0, 0x42);
        engine.State.FrequencyWordCache.Set(0, 0x1234);
        byte[] zeroes = new byte[AdgChannelRoutingTable.ChannelCount];
        engine.SetRoutingTable(new AdgChannelRoutingTable(zeroes, zeroes, zeroes));
        Cryogenic.AdgPlayer.Opl.RecordingOplBus bus = new();
        engine.SetOplBus(bus);

        // Act
        engine.DispatchEvents(0);

        // Assert — previous note key-off emitted, new note stored.
        Assert.NotEmpty(bus.Writes);
        Assert.Equal(0x40, engine.State.CurrentNotes.Get(0));
    }

    /// <summary>
    /// NoteOn with no previous note held and no routing table is
    /// purely state-mutating — no OPL writes at all.
    /// </summary>
    [Fact]
    public void Dispatch_NoteOn_FreshChannel_NoRouting_StateOnly() {
        // Arrange — channel currently silent (currentNote = 0).
        byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
        bytes[0x12] = 0x10;
        bytes[0x13] = 0x44;
        bytes[0x14] = 0x70;
        bytes[0x15] = 0x01;
        DuneAdgPlayerEngine engine = LoadEngine(bytes);
        engine.State.WaitCounters.Set(0, 0);
        Cryogenic.AdgPlayer.Opl.RecordingOplBus bus = new();
        engine.SetOplBus(bus);

        // Act
        engine.DispatchEvents(0);

        // Assert
        Assert.Equal(0x44, engine.State.CurrentNotes.Get(0));
        Assert.Empty(bus.Writes);
    }
}
