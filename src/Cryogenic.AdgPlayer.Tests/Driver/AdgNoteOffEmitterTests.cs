namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

using System.Collections.Generic;

/// <summary>
/// Phase 11 — note-off emission for one logical ADG channel.
/// Faithful port of <c>AdgNoteOff_10D8</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>:
///   freq = FrequencyWordCache[channelIndex]
///   WriteRouted(0xA0, lo(freq), channel)
///   WriteRouted(0xB0, hi(freq), channel)
/// The cached word has the key-on bit (0x20) cleared, so re-writing it
/// silences the channel while preserving its frequency.
/// </summary>
public sealed class AdgNoteOffEmitterTests {
	private static byte[] BuildPrimaryRoutingTable() {
		byte[] table = new byte[18];
		for (int i = 0; i < 18; i++) {
			table[i] = (byte)i;
		}
		return table;
	}

	[Fact]
	public void Emit_PrimaryChannel_RewritesCachedFrequencyWithoutKeyOn() {
		// Arrange — channel 6 has cached 0x15E5 (key-on cleared).
		byte[] routing = BuildPrimaryRoutingTable();
		ushort[] freqCache = new ushort[18];
		freqCache[6] = 0x15E5;
		RecordingOplBus bus = new();

		// Act
		AdgNoteOffEmitter.Emit(bus, routing, freqCache, channelIndex: 6);

		// Assert
		IReadOnlyList<OplWrite> writes = bus.Writes;
		Assert.Equal(2, writes.Count);
		Assert.Equal(new OplWrite(0, 0xA6, 0xE5), writes[0]);
		Assert.Equal(new OplWrite(0, 0xB6, 0x15), writes[1]);
	}

	[Fact]
	public void Emit_SecondaryChannel_RoutesToSecondChip() {
		// Arrange — channel 0 routes to secondary via 0x88. Cached 0x15E5.
		byte[] routing = BuildPrimaryRoutingTable();
		routing[0] = 0x88;
		ushort[] freqCache = new ushort[18];
		freqCache[0] = 0x15E5;
		RecordingOplBus bus = new();

		// Act
		AdgNoteOffEmitter.Emit(bus, routing, freqCache, channelIndex: 0);

		// Assert
		IReadOnlyList<OplWrite> writes = bus.Writes;
		Assert.Equal(new OplWrite(1, 0xA8, 0xE5), writes[0]);
		Assert.Equal(new OplWrite(1, 0xB8, 0x15), writes[1]);
	}

	[Fact]
	public void Emit_DoesNotMutateCacheEntries() {
		// Arrange
		byte[] routing = BuildPrimaryRoutingTable();
		ushort[] freqCache = new ushort[18];
		for (int i = 0; i < 18; i++) {
			freqCache[i] = (ushort)(0x9000 + i);
		}
		RecordingOplBus bus = new();

		// Act
		AdgNoteOffEmitter.Emit(bus, routing, freqCache, channelIndex: 5);

		// Assert
		for (int i = 0; i < 18; i++) {
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
			AdgNoteOffEmitter.Emit(bus, routing, freqCache, channelIndex: 18));
	}

	[Fact]
	public void Emit_NullBus_Throws() {
		// Arrange
		byte[] routing = BuildPrimaryRoutingTable();
		ushort[] freqCache = new ushort[18];

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgNoteOffEmitter.Emit(null!, routing, freqCache, 0));
	}
}