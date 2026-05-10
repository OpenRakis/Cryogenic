namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Phase 26d — Channel-indexed adapter that resolves the per-channel
/// route via <see cref="AdgChannelRoutingTable"/> and forwards the
/// note-off emit to <see cref="AdgNoteOffEmitter"/>, reading the
/// previous frequency word from <see cref="AdgFrequencyWordCache"/>.
/// </summary>
public sealed class AdgChannelNoteOffEmitterTests {
	private static AdgChannelRoutingTable BuildTable(int channelIndex, byte route) {
		byte[] channels = new byte[AdgChannelRoutingTable.ChannelCount];
		byte[] zero = new byte[AdgChannelRoutingTable.ChannelCount];
		channels[channelIndex] = route;
		return new AdgChannelRoutingTable(channels, zero, zero);
	}

	[Fact]
	public void Emit_WritesCachedLowAndHighRoutedThroughChannelRoute() {
		// Arrange
		RecordingOplBus bus = new();
		AdgFrequencyWordCache cache = new();
		cache.Set(2, 0x1A2B);
		AdgChannelRoutingTable table = BuildTable(channelIndex: 2, route: 0x00);

		// Act
		AdgChannelNoteOffEmitter.Emit(bus, cache, table, channelIndex: 2);

		// Assert — A0+0=0xA0, B0+0=0xB0; chip 0 because route=0.
		Assert.Equal(2, bus.Writes.Count);
		Assert.Equal(new OplWrite(0, 0xA0, 0x2B), bus.Writes[0]);
		Assert.Equal(new OplWrite(0, 0xB0, 0x1A), bus.Writes[1]);
	}

	[Fact]
	public void Emit_RoutesThroughChannelRoute() {
		// Arrange — channelRoute=0x88 → both writes go to chip 1.
		RecordingOplBus bus = new();
		AdgFrequencyWordCache cache = new();
		cache.Set(0, 0x0F00);
		AdgChannelRoutingTable table = BuildTable(channelIndex: 0, route: 0x88);

		// Act
		AdgChannelNoteOffEmitter.Emit(bus, cache, table, channelIndex: 0);

		// Assert
		Assert.Equal(1, bus.Writes[0].Chip);
		Assert.Equal(1, bus.Writes[1].Chip);
	}

	[Fact]
	public void Emit_NullBus_Throws() {
		// Arrange
		AdgFrequencyWordCache cache = new();
		AdgChannelRoutingTable table = BuildTable(0, 0);

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgChannelNoteOffEmitter.Emit(null!, cache, table, 0));
	}

	[Fact]
	public void Emit_NullCache_Throws() {
		// Arrange
		RecordingOplBus bus = new();
		AdgChannelRoutingTable table = BuildTable(0, 0);

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgChannelNoteOffEmitter.Emit(bus, null!, table, 0));
	}

	[Fact]
	public void Emit_NullTable_Throws() {
		// Arrange
		RecordingOplBus bus = new();
		AdgFrequencyWordCache cache = new();

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgChannelNoteOffEmitter.Emit(bus, cache, null!, 0));
	}
}