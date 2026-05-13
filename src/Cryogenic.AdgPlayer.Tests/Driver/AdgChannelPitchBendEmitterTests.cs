namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

using Xunit;

/// <summary>
/// Tests for <see cref="AdgChannelPitchBendEmitter"/> — verifies
/// the cache-then-routed-key-on-emit tail of
/// <c>AdgPitchBendBody_0D8B</c>.
/// </summary>
public sealed class AdgChannelPitchBendEmitterTests {
	private static AdgChannelRoutingTable BuildRouting(byte channelRoute0) {
		byte[] channels = new byte[AdgChannelRoutingTable.ChannelCount];
		channels[0] = channelRoute0;
		byte[] zero = new byte[AdgChannelRoutingTable.ChannelCount];
		return new AdgChannelRoutingTable(channels, zero, zero);
	}

	/// <summary>
	/// The precomputed frequency word is cached unmodified, then
	/// the A0/B0 register pair is emitted with the key-on bit
	/// (0x20) ORed into the high byte.
	/// </summary>
	[Fact]
	public void Emit_CachesPreKeyOnWord_AndEmitsKeyOnPair() {
		// Arrange
		RecordingOplBus bus = new();
		AdgFrequencyWordCache cache = new();
		AdgChannelRoutingTable routing = BuildRouting(0x00);

		// Act
		AdgChannelPitchBendEmitter.Emit(bus, cache, routing,
			channelIndex: 0, preKeyOnFrequencyWord: 0x0158);

		// Assert — cache holds pre-key-on word.
		Assert.Equal<ushort>(0x0158, cache.Get(0));
		// A0 receives Lo8 (0x58) and B0 receives Hi8|0x20 (0x21).
		Assert.Equal(2, bus.Writes.Count);
		Assert.Equal(0xA0, bus.Writes[0].Register);
		Assert.Equal(0x58, bus.Writes[0].Value);
		Assert.Equal(0xB0, bus.Writes[1].Register);
		Assert.Equal(0x21, bus.Writes[1].Value);
	}
}