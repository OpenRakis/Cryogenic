namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Emits a precomputed frequency word to the OPL3 bus for one
/// logical ADG channel, and updates the per-channel frequency-word
/// cache. Faithful port of the tail of <c>AdgPitchBendBody_0D8B</c>:
/// <code>
/// AdgIndexedWordSet(AdgFrequencyWordTableOffset, DX, ax);  // cache pre-key-on
/// ax |= 0x2000;                                            // set key-on bit
/// AdgWriteFrequencyWord_10E0(DX, ax);
/// </code>
/// (oracle dnadg:0E20).
/// </summary>
public static class AdgChannelPitchBendEmitter {
	private const int ChannelCount = AdgChannelResetEmitter.ChannelCount;
	private const byte FrequencyLowRegisterBase = 0xA0;
	private const byte FrequencyHighRegisterBase = 0xB0;
	private const byte KeyOnBit = 0x20;

	/// <summary>
	/// Caches <paramref name="preKeyOnFrequencyWord"/> for
	/// <paramref name="channelIndex"/> and routes the
	/// (A0, B0|0x20) pair to <paramref name="bus"/>.
	/// </summary>
	public static void Emit(
		IOplBus bus,
		AdgFrequencyWordCache frequencyWordCache,
		AdgChannelRoutingTable routingTable,
		int channelIndex,
		ushort preKeyOnFrequencyWord) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(frequencyWordCache);
		ArgumentNullException.ThrowIfNull(routingTable);
		if ((uint)channelIndex >= ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(channelIndex));
		}

		frequencyWordCache.Set(channelIndex, preKeyOnFrequencyWord);

		byte route = routingTable.ChannelRoutesAsArray()[channelIndex];
		AdgRoutedRegister low = AdgChannelRouter.Route(FrequencyLowRegisterBase, route);
		bus.WriteRegister(low.Chip, low.Register, (byte)(preKeyOnFrequencyWord & 0xFF));

		byte high = (byte)(((preKeyOnFrequencyWord >> 8) & 0xFF) | KeyOnBit);
		AdgRoutedRegister highRouted = AdgChannelRouter.Route(FrequencyHighRegisterBase, route);
		bus.WriteRegister(highRouted.Chip, highRouted.Register, high);
	}
}
