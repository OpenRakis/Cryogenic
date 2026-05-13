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
	/// EndOfTrack writes the 0xFFFF done-sentinel to the channel's
	/// wait counter (mirrors <c>AdgWordSet(DI, ushort.MaxValue)</c>
	/// at dnadg:0AF5).
	/// </summary>
	[Fact]
	public void Dispatch_EndOfTrack_SetsDoneSentinelOnWaitCounter() {
		// Arrange
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x70;
		bytes[0x13] = 0x00;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(0, 0);

		// Act
		engine.DispatchEvents(0);

		// Assert
		Assert.Equal(0xFFFF, engine.State.WaitCounters.Get(0));
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
	/// ProgramChange (slot 4) consumes the wait value and writes the
	/// new instrument index into the channel's instrument slot
	/// (DI+0x6C).
	/// </summary>
	[Fact]
	public void Dispatch_ProgramChange_StoresInstrumentAndAdvances() {
		// Arrange — slot 4 ProgramChange, instrument index 0x12, wait=0x05.
		//   Layout: [0x12]=0x40 [0x13]=0x12 [0x14]=0x05.
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x40;
		bytes[0x13] = 0x12;
		bytes[0x14] = 0x05;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(0, 0);

		// Act
		engine.DispatchEvents(0);

		// Assert
		Assert.Equal(0x12, engine.State.InstrumentSlots.Get(0));
		Assert.Equal(5, engine.State.WaitCounters.Get(0));
		Assert.Equal(0x15, engine.State.EventPointers.Get(0));
	}

	/// <summary>
	/// VolumeModulation (slot 5) consumes the wait value but
	/// otherwise leaves driver state unchanged in this cycle (deep
	/// OPL register-emit chain deferred to B4.4b).
	/// </summary>
	[Fact]
	public void Dispatch_VolumeModulation_ConsumesWaitAndAdvances() {
		// Arrange — slot 5 VolumeModulation, wait=0x04.
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x50;
		bytes[0x13] = 0x33;
		bytes[0x14] = 0x04;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(0, 0);

		// Act
		engine.DispatchEvents(0);

		// Assert
		Assert.Equal(4, engine.State.WaitCounters.Get(0));
		Assert.Equal(0x15, engine.State.EventPointers.Get(0));
	}

	/// <summary>
	/// PitchBend (slot 6) consumes the wait value but otherwise
	/// leaves driver state unchanged in this cycle (deep OPL
	/// register-emit chain deferred to B4.5b).
	/// </summary>
	[Fact]
	public void Dispatch_PitchBend_ConsumesWaitAndAdvances() {
		// Arrange — slot 6 PitchBend, wait=0x06.
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x60;
		bytes[0x13] = 0x42;
		bytes[0x14] = 0x06;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(0, 0);

		// Act
		engine.DispatchEvents(0);

		// Assert
		Assert.Equal(6, engine.State.WaitCounters.Get(0));
		Assert.Equal(0x15, engine.State.EventPointers.Get(0));
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

	/// <summary>
	/// NoteOn reloads the live pitch-bend counter from its
	/// per-channel reload byte (mirrors
	/// <c>mov AL,[DI+pitchBendCounter+1]; mov [DI+pitchBendCounter],AL</c>
	/// at dnadg:0AA0).
	/// </summary>
	[Fact]
	public void Dispatch_NoteOn_ReloadsPitchBendCounter() {
		// Arrange — reload byte preset to 0x07 on channel 0; live
		//   counter starts at 0 and must be reloaded post-NoteOn.
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x10;
		bytes[0x13] = 0x40;
		bytes[0x14] = 0x00;
		bytes[0x15] = 0x01;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(0, 0);
		engine.State.PitchBendCounters.Set(0, 0x00);
		engine.State.PitchBendCounterReloads.Set(0, 0x07);

		// Act
		engine.DispatchEvents(0);

		// Assert
		Assert.Equal(0x07, engine.State.PitchBendCounters.Get(0));
	}

	/// <summary>
	/// When both a routing table and a frequency-lookup table are
	/// bound, NoteOn dispatch performs the full OPL3 note-on emit:
	/// the routed A0/B0 pair (with key-on bit 0x20 set) is written
	/// to the bus and the frequency-word cache is updated. Mirrors
	/// <c>AdgNoteOn_10A9</c> at dnadg:10A9.
	/// </summary>
	[Fact]
	public void Dispatch_NoteOn_WithLookupAndRouting_EmitsOplKeyOn() {
		// Arrange — fresh channel (no previous note), channel 0 routed
		//   to physical 0x00 (A0=0xA0, B0=0xB0). Use a 12-entry lookup
		//   table whose values are easy to identify in writes.
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x10;
		bytes[0x13] = 0x48;   // raw note 0x48 → semitone index 0
		bytes[0x14] = 0x60;
		bytes[0x15] = 0x01;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(0, 0);
		byte[] zeroes = new byte[AdgChannelRoutingTable.ChannelCount];
		engine.SetRoutingTable(new AdgChannelRoutingTable(zeroes, zeroes, zeroes));
		ushort[] lookup = new ushort[12] {
			0x0157, 0x016C, 0x0181, 0x0198, 0x01B1, 0x01CB,
			0x01E6, 0x0203, 0x0222, 0x0243, 0x0266, 0x028A
		};
		engine.SetFrequencyLookupTable(new AdgFrequencyLookupTable(lookup));
		Cryogenic.AdgPlayer.Opl.RecordingOplBus bus = new();
		engine.SetOplBus(bus);

		// Act
		engine.DispatchEvents(0);

		// Assert — note stored, cache populated, A0/B0 pair emitted.
		Assert.Equal(0x48, engine.State.CurrentNotes.Get(0));
		Assert.NotEqual<ushort>(0, engine.State.FrequencyWordCache.Get(0));
		Assert.Contains(bus.Writes, w => w.Register == 0xA0);
		Assert.Contains(bus.Writes, w => w.Register == 0xB0);
	}

	/// <summary>
	/// NoteOn with a routing table bound but no frequency-lookup
	/// table bound performs no OPL key-on emit (state-only path).
	/// Defensive guard: emit chain requires both tables.
	/// </summary>
	[Fact]
	public void Dispatch_NoteOn_RoutingOnly_NoLookup_NoKeyOnEmitted() {
		// Arrange
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x10;
		bytes[0x13] = 0x48;
		bytes[0x14] = 0x00;
		bytes[0x15] = 0x01;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(0, 0);
		byte[] zeroes = new byte[AdgChannelRoutingTable.ChannelCount];
		engine.SetRoutingTable(new AdgChannelRoutingTable(zeroes, zeroes, zeroes));
		Cryogenic.AdgPlayer.Opl.RecordingOplBus bus = new();
		engine.SetOplBus(bus);

		// Act
		engine.DispatchEvents(0);

		// Assert — no A0/B0 writes (only the key-off short re-emit
		//   path can write, and that's gated on previous note != 0).
		Assert.Empty(bus.Writes);
	}

	private sealed class RecordingPitchBendBody : IAdgPitchBendBody {
		public System.Collections.Generic.List<(int Channel, ushort Bend)> Calls { get; } = new();
		public void Emit(int channelIndex, ushort bendWord) {
			Calls.Add((channelIndex, bendWord));
		}
	}

	/// <summary>
	/// PitchBend dispatch consumes the wait value and forwards
	/// the duplicated Hi8 byte (mirroring oracle dnadg:0D86's
	/// <c>AX = Make16(Hi8(eventWord), Hi8(eventWord))</c>) to the
	/// configured <see cref="IAdgPitchBendBody"/>.
	/// </summary>
	[Fact]
	public void Dispatch_PitchBend_ForwardsDuplicatedByteToBody() {
		// Arrange — slot 6 PitchBend, bend byte 0x55, wait byte 0x01.
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x60;
		bytes[0x13] = 0x55;
		bytes[0x14] = 0x01;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(0, 0);
		RecordingPitchBendBody body = new();
		engine.SetPitchBendBody(body);

		// Act
		engine.DispatchEvents(0);

		// Assert — body invoked once with channel 0 and bendWord 0x5555.
		Assert.Single(body.Calls);
		Assert.Equal(0, body.Calls[0].Channel);
		Assert.Equal<ushort>(0x5555, body.Calls[0].Bend);
	}

	/// <summary>
	/// VolumeModulation dispatch consumes the wait value, computes
	/// per-operator new levels, updates the cached operator-level
	/// word, and (when the routing table is bound) emits the routed
	/// KSL/TL register pair via
	/// <see cref="AdgOperatorLevelEmitter"/>.
	/// </summary>
	[Fact]
	public void Dispatch_VolumeModulation_EmitsBothOperatorLevels() {
		// Arrange — slot 5 VolumeModulation, velocity 0x40, wait 0x01.
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x50;
		bytes[0x13] = 0x40;
		bytes[0x14] = 0x01;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(0, 0);
		engine.State.VolumeModulationSlots.Set(0, 0x0404);   // shape: both ops active.
		engine.State.CurrentOperatorLevels.Set(0, 0x3F3F);   // both ops full TL.
		byte[] zero = new byte[AdgChannelRoutingTable.ChannelCount];
		engine.SetRoutingTable(new AdgChannelRoutingTable(zero, zero, zero));
		Cryogenic.AdgPlayer.Opl.RecordingOplBus bus = new();
		engine.SetOplBus(bus);

		// Act
		engine.DispatchEvents(0);

		// Assert — KSL/TL register (0x40) emitted twice (primary + secondary).
		Assert.Equal(2, bus.Writes.Count);
		Assert.All(bus.Writes, w => Assert.Equal(0x40, w.Register));
		// Both operators received the same scaled level (0x3F - 0x40 → clamp 0).
		Assert.All(bus.Writes, w => Assert.Equal(0x00, w.Value));
		// Cached level updated.
		Assert.Equal<ushort>(0x0000, engine.State.CurrentOperatorLevels.Get(0));
	}

	/// <summary>
	/// VolumeModulation with no routing table bound performs only
	/// the cached state update — no OPL emit.
	/// </summary>
	[Fact]
	public void Dispatch_VolumeModulation_NoRouting_StateOnly() {
		// Arrange
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x50;
		bytes[0x13] = 0x40;
		bytes[0x14] = 0x01;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(0, 0);
		engine.State.VolumeModulationSlots.Set(0, 0x0404);
		engine.State.CurrentOperatorLevels.Set(0, 0x3F3F);
		Cryogenic.AdgPlayer.Opl.RecordingOplBus bus = new();
		engine.SetOplBus(bus);

		// Act
		engine.DispatchEvents(0);

		// Assert
		Assert.Empty(bus.Writes);
		Assert.Equal<ushort>(0x0000, engine.State.CurrentOperatorLevels.Get(0));
	}

	/// <summary>
	/// B4.6b — master-track EndOfTrack (channel 0) with a one-shot
	/// tick-enabled seed bulk-marks every channel's wait counter as
	/// done (<c>0xFFFF</c>), mirroring the <c>rep stos</c> loop at
	/// dnadg:0AF5 that wipes the channel table after the final
	/// master event.
	/// </summary>
	[Fact]
	public void Dispatch_EndOfTrack_Channel0_TickReachesZero_BulkResetsAllWaitCounters() {
		// Arrange — channel 0 EndOfTrack opcode at absolute 0x12.
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x70;
		bytes[0x13] = 0x00;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		// Pre-seed slave channels with arbitrary non-done values so we
		// can observe the bulk reset writes.
		for (int i = 1; i < AdgDriverState.ChannelCount; i++) {
			engine.State.WaitCounters.Set(i, (ushort)(0x1000 + i));
		}
		engine.State.WaitCounters.Set(0, 0);
		// Force the counter to 1 so the post-decrement value is 0
		// and the bulk-reset branch fires.
		engine.State.TickEnabledCounter.Set(1);

		// Act
		engine.DispatchEvents(0);

		// Assert
		Assert.Equal(0, engine.State.TickEnabledCounter.Value);
		for (int i = 0; i < AdgDriverState.ChannelCount; i++) {
			Assert.Equal<ushort>(0xFFFF, engine.State.WaitCounters.Get(i));
		}
	}

	/// <summary>
	/// B4.6b — master-track EndOfTrack with the tick-enabled counter
	/// pre-seeded above 1 follows the loop path: counter decrements
	/// (no underflow), scheduler state is re-initialised, channel 0's
	/// wait counter is left at <c>0xFFFE</c> (0xFFFF then -1 tail),
	/// and the slave channels' wait counters remain untouched.
	/// </summary>
	[Fact]
	public void Dispatch_EndOfTrack_Channel0_TickStillPositive_RunsLoopPath() {
		// Arrange
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x70;
		bytes[0x13] = 0x00;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		// Pre-seed slave channels.
		engine.State.WaitCounters.Set(1, 0x1234);
		engine.State.WaitCounters.Set(0, 0);
		engine.State.TickEnabledCounter.Set(3);

		// Act
		engine.DispatchEvents(0);

		// Assert
		Assert.Equal(2, engine.State.TickEnabledCounter.Value);
		// Channel 0 wait = 0xFFFF after the common prelude, then -1
		// (the original AdgWordSet(DI, AdgWord(DI) - 1) tail).
		Assert.Equal<ushort>(0xFFFE, engine.State.WaitCounters.Get(0));
		// Slave channels untouched.
		Assert.Equal<ushort>(0x1234, engine.State.WaitCounters.Get(1));
		// Scheduler state re-initialised (measure 1 / subdivision 0x60).
		Assert.Equal<ushort>(1, engine.State.LoopState.Measure);
		Assert.Equal<ushort>(0x60, engine.State.LoopState.Subdivision);
	}

	/// <summary>
	/// B4.6b — master-track EndOfTrack with the tick-enabled counter
	/// pre-seeded to 0 first underflows to 0xFF, then the
	/// sign-bit-test path restores it back to 0 via the
	/// <c>add byte ptr [01DF],1</c> branch at dnadg:0AF5. Because the
	/// post-decrement value is non-zero, the loop path still runs.
	/// </summary>
	[Fact]
	public void Dispatch_EndOfTrack_Channel0_TickUnderflow_RestoresCounterToZero() {
		// Arrange
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x70;
		bytes[0x13] = 0x00;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(0, 0);
		engine.State.TickEnabledCounter.Set(0);

		// Act
		engine.DispatchEvents(0);

		// Assert — counter underflowed to 0xFF then restored to 0.
		Assert.Equal(0, engine.State.TickEnabledCounter.Value);
		// Channel 0 still went through the loop tail (wait = 0xFFFE).
		Assert.Equal<ushort>(0xFFFE, engine.State.WaitCounters.Get(0));
	}

	/// <summary>
	/// B4.6b — slave-track EndOfTrack (channel != 0) takes the
	/// <c>DX != 0</c> branch at dnadg:0AF5: only the per-channel
	/// state mutations + scratch-mask clear; the master-track
	/// counter must NOT be decremented.
	/// </summary>
	[Fact]
	public void Dispatch_EndOfTrack_NonZeroChannel_LeavesTickCounterIntact() {
		// Arrange — channel 1 relative 0x10 → absolute 0x12.
		byte[] bytes = BuildSong(new ushort[] { 0, 0x10, 0, 0, 0, 0, 0, 0, 0 });
		bytes[0x12] = 0x70;
		bytes[0x13] = 0x00;
		DuneAdgPlayerEngine engine = LoadEngine(bytes);
		engine.State.WaitCounters.Set(1, 0);
		// Force a non-default counter value so we can detect any
		// accidental write.
		engine.State.TickEnabledCounter.Set(7);

		// Act
		engine.DispatchEvents(1);

		// Assert
		Assert.Equal(7, engine.State.TickEnabledCounter.Value);
		Assert.Equal<ushort>(0xFFFF, engine.State.WaitCounters.Get(1));
		Assert.Equal<ushort>(0, engine.State.EventPointers.Get(1));
	}

	/// <summary>
	/// B4.6b — <c>DuneAdgPlayerEngine.Load</c> seeds the master-track
	/// tick-enabled counter to <see cref="AdgTickEnabledCounter.DefaultSeed"/>.
	/// </summary>
	[Fact]
	public void Load_SeedsTickEnabledCounterToDefault() {
		// Arrange
		byte[] bytes = BuildSong(new ushort[] { 0x10, 0, 0, 0, 0, 0, 0, 0, 0 });
		DuneAdgPlayerEngine engine = new();

		// Act
		engine.Load(bytes);

		// Assert
		Assert.Equal(AdgTickEnabledCounter.DefaultSeed,
			engine.State.TickEnabledCounter.Value);
	}

	/// <summary>
	/// B4.3b.1 — ProgramChange with both an OPL routing table and an
	/// instrument patch bank present in the song image now emits the
	/// 11 instrument-patch register writes via
	/// <see cref="AdgInstrumentPatchEmitter"/>. Mirrors the
	/// <c>AdgWriteInstrumentPatch_0F95</c> tail of
	/// <c>AdgProgramChange_0831</c>.
	/// </summary>
	[Fact]
	public void Dispatch_ProgramChange_WithRoutingAndPatch_EmitsInstrumentRegisters() {
		// Arrange — song with the instrument bank starting at 0x40
		// (header word at file[0..1] = 0x40). Patch index 0 is
		// therefore at absolute offset 0x40; we fill it with a known
		// 40-byte pattern.
		byte[] bytes = new byte[0x100];
		bytes[0] = 0x40; // EventBase low
		bytes[1] = 0x00; // EventBase high
		int dataBase = AdgSongHeader.DataBase;
		bytes[dataBase + 0] = 0x10; // channel 0 relative offset
		// Fill the instrument record at 0x40..0x67 with a deterministic pattern.
		for (int i = 0; i < AdgPatchOffsetCalculator.PatchStride; i++) {
			bytes[0x40 + i] = (byte)(0x10 + i);
		}
		// Event word at absolute 0x12 (channel 0 pointer 0x10 + DataBase 2):
		//   slot 4 ProgramChange, instrument index 0, wait=0.
		bytes[0x12] = 0x40;
		bytes[0x13] = 0x00;
		bytes[0x14] = 0x00;

		DuneAdgPlayerEngine engine = new();
		engine.Load(bytes);
		engine.State.WaitCounters.Set(0, 0);

		byte[] zeroes = new byte[AdgChannelRoutingTable.ChannelCount];
		engine.SetRoutingTable(new AdgChannelRoutingTable(zeroes, zeroes, zeroes));
		Cryogenic.AdgPlayer.Opl.RecordingOplBus bus = new();
		engine.SetOplBus(bus);

		// Act
		engine.DispatchEvents(0);

		// Assert — instrument register writes happened. The connection
		// register (0xC0 family) plus five primary operator regs plus
		// five secondary operator regs = 11 writes total.
		Assert.True(bus.Writes.Count >= 11,
			$"expected >= 11 writes, got {bus.Writes.Count}");
		// Connection register 0xC0 was written.
		Assert.Contains(bus.Writes, w => w.Register == 0xC0);
		// Instrument byte stored on the channel.
		Assert.Equal((byte)0, engine.State.InstrumentSlots.Get(0));
	}

	/// <summary>
	/// B4.3b.1 — ProgramChange with no routing table bound emits no
	/// OPL writes and only updates the per-channel instrument slot
	/// (state-only fallback).
	/// </summary>
	[Fact]
	public void Dispatch_ProgramChange_WithoutRouting_NoEmit() {
		// Arrange
		byte[] bytes = new byte[0x100];
		bytes[0] = 0x40;
		int dataBase = AdgSongHeader.DataBase;
		bytes[dataBase + 0] = 0x10;
		for (int i = 0; i < AdgPatchOffsetCalculator.PatchStride; i++) {
			bytes[0x40 + i] = (byte)(0x10 + i);
		}
		bytes[0x12] = 0x40;
		bytes[0x13] = 0x00;
		bytes[0x14] = 0x00;

		DuneAdgPlayerEngine engine = new();
		engine.Load(bytes);
		engine.State.WaitCounters.Set(0, 0);

		Cryogenic.AdgPlayer.Opl.RecordingOplBus bus = new();
		engine.SetOplBus(bus);

		// Act
		engine.DispatchEvents(0);

		// Assert
		Assert.Empty(bus.Writes);
		Assert.Equal((byte)0, engine.State.InstrumentSlots.Get(0));
	}

	/// <summary>
	/// B4.3b.1 — when the computed patch offset overruns the song
	/// image (e.g. an instrument index that points past EOF), the
	/// handler defensively skips the patch emit and leaves the
	/// instrument-connection register (0xC0) unwritten. Other
	/// downstream NoteOff cascades are not asserted here — the only
	/// invariant is that no instrument program was emitted.
	/// </summary>
	[Fact]
	public void Dispatch_ProgramChange_PatchOffsetOutOfRange_NoEmit() {
		// Arrange — bank base 0x40 + index 0xF0 * 0x28 = far past EOF.
		byte[] bytes = new byte[0x100];
		bytes[0] = 0x40;
		int dataBase = AdgSongHeader.DataBase;
		bytes[dataBase + 0] = 0x10;
		bytes[0x12] = 0x40;
		bytes[0x13] = 0xF0; // instrument index
		bytes[0x14] = 0x70; // wait = 0x70 (large) so downstream dispatch stops

		DuneAdgPlayerEngine engine = new();
		engine.Load(bytes);
		engine.State.WaitCounters.Set(0, 0);
		byte[] zeroes = new byte[AdgChannelRoutingTable.ChannelCount];
		engine.SetRoutingTable(new AdgChannelRoutingTable(zeroes, zeroes, zeroes));
		Cryogenic.AdgPlayer.Opl.RecordingOplBus bus = new();
		engine.SetOplBus(bus);

		// Act
		engine.DispatchEvents(0);

		// Assert — defensive skip on the patch emit: no 0xC0 family
		// connection-register write happened. Instrument byte still
		// recorded.
		Assert.DoesNotContain(bus.Writes, w => w.Register == 0xC0);
		Assert.Equal((byte)0xF0, engine.State.InstrumentSlots.Get(0));
	}
}