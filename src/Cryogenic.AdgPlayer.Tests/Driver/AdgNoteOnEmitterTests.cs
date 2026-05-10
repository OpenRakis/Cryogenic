namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

using System.Collections.Generic;

/// <summary>
/// Phase 10 — note-on emission.
/// <see cref="AdgNoteOnEmitter"/> composes <see cref="AdgNoteOnComputer"/>
/// with <see cref="AdgChannelRouter"/> to:
///   1. compute the cached + key-on frequency words
///   2. update <c>frequencyWordCache[channelIndex]</c> to the cached value
///      (matches <c>AdgIndexedWordSet(AdgFrequencyWordTableOffset, ...)</c>)
///   3. write A0 (lo of key-on word) then B0 (hi of key-on word) to the
///      OPL3 chip selected by routingTable[channelIndex]
/// Faithful port of the post-arithmetic tail of <c>AdgNoteOn_10A9</c> +
/// <c>AdgWriteFrequencyWord_10E0</c>.
/// </summary>
public sealed class AdgNoteOnEmitterTests {
	private static readonly ushort[] FrequencyLookup = {
		0x0157, 0x016B, 0x0181, 0x0198, 0x01B0, 0x01CA,
		0x01E5, 0x0202, 0x0220, 0x0241, 0x0263, 0x0287
	};

	private static byte[] BuildPrimaryRoutingTable() {
		byte[] table = new byte[18];
		for (int i = 0; i < 18; i++) {
			table[i] = (byte)i;
		}
		return table;
	}

	[Fact]
	public void Emit_OnPrimaryChannel_WritesA0LoThenB0HiWithKeyOn() {
		// Arrange — channel 6 (primary), rawPitch 0x12 → noteOn = 0x35E5,
		// cached = 0x15E5 (see AdgNoteOnComputerTests.Compute_NormalPitch...).
		byte[] routing = BuildPrimaryRoutingTable();
		ushort[] freqCache = new ushort[18];
		RecordingOplBus bus = new();

		// Act
		AdgNoteOnEmitter.Emit(bus, routing, freqCache, FrequencyLookup,
			channelIndex: 6, rawPitch: 0x12);

		// Assert
		IReadOnlyList<OplWrite> writes = bus.Writes;
		Assert.Equal(2, writes.Count);
		Assert.Equal(new OplWrite(0, 0xA6, 0xE5), writes[0]);
		Assert.Equal(new OplWrite(0, 0xB6, 0x35), writes[1]);
		// Cached word has key-on bit cleared (0x15E5, NOT 0x35E5).
		Assert.Equal((ushort)0x15E5, freqCache[6]);
	}

	[Fact]
	public void Emit_OnSecondaryChannel_RoutesWritesToSecondChip() {
		// Arrange — channel 0 routed to secondary via 0x88. rawPitch 0x12
		// produces noteOn 0x35E5; routed register: 0xA0 + 0x88 XOR 0x80 = 0xA8.
		byte[] routing = BuildPrimaryRoutingTable();
		routing[0] = 0x88;
		ushort[] freqCache = new ushort[18];
		RecordingOplBus bus = new();

		// Act
		AdgNoteOnEmitter.Emit(bus, routing, freqCache, FrequencyLookup,
			channelIndex: 0, rawPitch: 0x12);

		// Assert
		IReadOnlyList<OplWrite> writes = bus.Writes;
		Assert.Equal(new OplWrite(1, 0xA8, 0xE5), writes[0]);
		Assert.Equal(new OplWrite(1, 0xB8, 0x35), writes[1]);
		Assert.Equal((ushort)0x15E5, freqCache[0]);
	}

	[Fact]
	public void Emit_OutOfRangePitch_StoresSilencedNoteOnSentinel() {
		// Arrange — rawPitch 0x40 → noteWord 0x70 ≥ 0x60 forces noteWord=0.
		// freq[0]=0x0157, octave 0 → cached 0x0157, noteOn 0x2157.
		byte[] routing = BuildPrimaryRoutingTable();
		ushort[] freqCache = new ushort[18];
		RecordingOplBus bus = new();

		// Act
		AdgNoteOnEmitter.Emit(bus, routing, freqCache, FrequencyLookup,
			channelIndex: 3, rawPitch: 0x40);

		// Assert
		IReadOnlyList<OplWrite> writes = bus.Writes;
		Assert.Equal(new OplWrite(0, 0xA3, 0x57), writes[0]);
		Assert.Equal(new OplWrite(0, 0xB3, 0x21), writes[1]);
		Assert.Equal((ushort)0x0157, freqCache[3]);
	}

	[Fact]
	public void Emit_DoesNotMutateOtherCacheEntries() {
		// Arrange
		byte[] routing = BuildPrimaryRoutingTable();
		ushort[] freqCache = new ushort[18];
		for (int i = 0; i < 18; i++) {
			freqCache[i] = (ushort)(0x9000 + i);
		}
		RecordingOplBus bus = new();

		// Act
		AdgNoteOnEmitter.Emit(bus, routing, freqCache, FrequencyLookup,
			channelIndex: 6, rawPitch: 0x12);

		// Assert
		for (int i = 0; i < 18; i++) {
			if (i == 6) {
				continue;
			}
			Assert.Equal((ushort)(0x9000 + i), freqCache[i]);
		}
	}

	[Fact]
	public void Emit_RejectsOutOfRangeChannelIndex() {
		// Arrange
		byte[] routing = BuildPrimaryRoutingTable();
		ushort[] freqCache = new ushort[18];
		RecordingOplBus bus = new();

		// Act + Assert
		Assert.Throws<ArgumentOutOfRangeException>(() =>
			AdgNoteOnEmitter.Emit(bus, routing, freqCache, FrequencyLookup,
				channelIndex: 18, rawPitch: 0x12));
	}

	[Fact]
	public void Emit_NullBus_Throws() {
		// Arrange
		byte[] routing = BuildPrimaryRoutingTable();
		ushort[] freqCache = new ushort[18];

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgNoteOnEmitter.Emit(null!, routing, freqCache, FrequencyLookup, 0, 0));
	}
}