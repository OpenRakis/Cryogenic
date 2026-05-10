namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Phase 26c — Channel-indexed adapter that resolves the per-channel
/// route via <see cref="AdgChannelRoutingTable"/> and forwards the
/// note-on emit to <see cref="AdgNoteOnEmitter"/>, persisting the new
/// cached frequency word in <see cref="AdgFrequencyWordCache"/>.
/// </summary>
public sealed class AdgChannelNoteOnEmitterTests {
	private static AdgChannelRoutingTable BuildTable(int channelIndex, byte route) {
		byte[] channels = new byte[AdgChannelRoutingTable.ChannelCount];
		byte[] zero = new byte[AdgChannelRoutingTable.ChannelCount];
		channels[channelIndex] = route;
		return new AdgChannelRoutingTable(channels, zero, zero);
	}

	private static AdgFrequencyLookupTable BuildLookup() {
		ushort[] lookup = new ushort[AdgFrequencyLookupTable.SemitoneCount];
		for (int i = 0; i < lookup.Length; i++) {
			lookup[i] = (ushort)(0x0200 + i);
		}
		return new AdgFrequencyLookupTable(lookup);
	}

	[Fact]
	public void Emit_DelegatesToNoteOnEmitterWithChannelRoute() {
		// Arrange
		RecordingOplBus actualBus = new();
		AdgFrequencyWordCache actualCache = new();
		AdgChannelRoutingTable table = BuildTable(channelIndex: 4, route: 0x00);
		AdgFrequencyLookupTable lookup = BuildLookup();

		RecordingOplBus expectedBus = new();
		ushort[] expectedCacheArray = new ushort[AdgChannelRoutingTable.ChannelCount];
		byte[] routingArray = new byte[AdgChannelRoutingTable.ChannelCount];
		ushort[] lookupArray = new ushort[AdgFrequencyLookupTable.SemitoneCount];
		lookup.AsSpan().CopyTo(lookupArray);
		AdgNoteOnEmitter.Emit(expectedBus, routingArray, expectedCacheArray, lookupArray,
			channelIndex: 4, rawPitch: 0x12);

		// Act
		AdgChannelNoteOnEmitter.Emit(actualBus, actualCache, table, lookup,
			channelIndex: 4, rawPitch: 0x12);

		// Assert
		Assert.Equal(expectedBus.Writes.Count, actualBus.Writes.Count);
		for (int i = 0; i < expectedBus.Writes.Count; i++) {
			Assert.Equal(expectedBus.Writes[i], actualBus.Writes[i]);
		}
		Assert.Equal(expectedCacheArray[4], actualCache.Get(4));
	}

	[Fact]
	public void Emit_RoutesThroughChannelEntry() {
		// Arrange — channelRoute=0x88 → low/high writes go to chip 1.
		RecordingOplBus bus = new();
		AdgFrequencyWordCache cache = new();
		AdgChannelRoutingTable table = BuildTable(channelIndex: 0, route: 0x88);
		AdgFrequencyLookupTable lookup = BuildLookup();

		// Act
		AdgChannelNoteOnEmitter.Emit(bus, cache, table, lookup,
			channelIndex: 0, rawPitch: 0x10);

		// Assert
		Assert.Equal(2, bus.Writes.Count);
		Assert.Equal(1, bus.Writes[0].Chip);
		Assert.Equal(1, bus.Writes[1].Chip);
	}

	[Fact]
	public void Emit_NullBus_Throws() {
		// Arrange
		AdgFrequencyWordCache cache = new();
		AdgChannelRoutingTable table = BuildTable(0, 0);
		AdgFrequencyLookupTable lookup = BuildLookup();

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgChannelNoteOnEmitter.Emit(null!, cache, table, lookup, 0, 0));
	}

	[Fact]
	public void Emit_NullCache_Throws() {
		// Arrange
		RecordingOplBus bus = new();
		AdgChannelRoutingTable table = BuildTable(0, 0);
		AdgFrequencyLookupTable lookup = BuildLookup();

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgChannelNoteOnEmitter.Emit(bus, null!, table, lookup, 0, 0));
	}

	[Fact]
	public void Emit_NullTable_Throws() {
		// Arrange
		RecordingOplBus bus = new();
		AdgFrequencyWordCache cache = new();
		AdgFrequencyLookupTable lookup = BuildLookup();

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgChannelNoteOnEmitter.Emit(bus, cache, null!, lookup, 0, 0));
	}

	[Fact]
	public void Emit_NullLookup_Throws() {
		// Arrange
		RecordingOplBus bus = new();
		AdgFrequencyWordCache cache = new();
		AdgChannelRoutingTable table = BuildTable(0, 0);

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgChannelNoteOnEmitter.Emit(bus, cache, table, null!, 0, 0));
	}
}