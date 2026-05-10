namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Phase 25 — Channel-indexed adapter that resolves the
/// <see cref="AdgChannelRoutingEntry"/> from
/// <see cref="AdgChannelRoutingTable"/> and forwards to
/// <see cref="AdgInstrumentPatchEmitter.Emit"/>. Equivalent to the
/// caller side of <c>AdgWriteInstrumentPatch_0F95</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>: take a logical
/// channel index, lookup the three route bytes, then emit.
/// </summary>
public sealed class AdgChannelInstrumentEmitterTests {
	private static byte[] BuildPatch(byte patchType) {
		byte[] patch = new byte[AdgInstrumentEmitter.RequiredPatchLength];
		for (int i = 0; i < patch.Length; i++) {
			patch[i] = (byte)(0x10 + i);
		}
		patch[0] = patchType;
		return patch;
	}

	private static AdgChannelRoutingTable BuildTable(byte channel, byte primary, byte secondary) {
		byte[] channelRoutes = new byte[AdgChannelRoutingTable.ChannelCount];
		byte[] primaryRoutes = new byte[AdgChannelRoutingTable.ChannelCount];
		byte[] secondaryRoutes = new byte[AdgChannelRoutingTable.ChannelCount];
		channelRoutes[3] = channel;
		primaryRoutes[3] = primary;
		secondaryRoutes[3] = secondary;
		return new AdgChannelRoutingTable(channelRoutes, primaryRoutes, secondaryRoutes);
	}

	[Fact]
	public void Emit_DelegatesToPatchEmitterWithResolvedRoutes() {
		// Arrange
		RecordingOplBus actualBus = new();
		AdgSurroundMaskState actualState = new();
		byte[] patch = BuildPatch(0x00);
		AdgChannelRoutingTable table = BuildTable(channel: 0x00, primary: 0x00, secondary: 0x02);

		RecordingOplBus expectedBus = new();
		AdgSurroundMaskState expectedState = new();
		AdgInstrumentPatchEmitter.Emit(expectedBus, expectedState, patch,
			channelRoute: 0x00, primaryRoute: 0x00, secondaryRoute: 0x02);

		// Act
		AdgChannelInstrumentEmitter.Emit(actualBus, actualState, patch, table, channelIndex: 3);

		// Assert
		Assert.Equal(expectedBus.Writes.Count, actualBus.Writes.Count);
		for (int i = 0; i < expectedBus.Writes.Count; i++) {
			Assert.Equal(expectedBus.Writes[i], actualBus.Writes[i]);
		}
		Assert.Equal(expectedState.Mask, actualState.Mask);
	}

	[Fact]
	public void Emit_UsesTripletForGivenChannelIndex() {
		// Arrange — channelRoute=0x88 routes connection write to chip 1.
		RecordingOplBus bus = new();
		AdgSurroundMaskState state = new();
		byte[] patch = BuildPatch(0x00);
		AdgChannelRoutingTable table = BuildTable(channel: 0x88, primary: 0x00, secondary: 0x10);

		// Act
		AdgChannelInstrumentEmitter.Emit(bus, state, patch, table, channelIndex: 3);

		// Assert — connection routed via 0x88; secondary skip bit set so
		// no SecondaryControl write and mask untouched.
		Assert.Equal(11, bus.Writes.Count);
		Assert.Equal(1, bus.Writes[0].Chip);
		Assert.Equal((byte)0xFF, state.Mask);
	}

	[Fact]
	public void Emit_NullBus_Throws() {
		// Arrange
		AdgSurroundMaskState state = new();
		byte[] patch = BuildPatch(0x00);
		AdgChannelRoutingTable table = BuildTable(0, 0, 0);

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgChannelInstrumentEmitter.Emit(null!, state, patch, table, 0));
	}

	[Fact]
	public void Emit_NullTable_Throws() {
		// Arrange
		RecordingOplBus bus = new();
		AdgSurroundMaskState state = new();
		byte[] patch = BuildPatch(0x00);

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgChannelInstrumentEmitter.Emit(bus, state, patch, null!, 0));
	}

	[Fact]
	public void Emit_OutOfRangeChannelIndex_Throws() {
		// Arrange
		RecordingOplBus bus = new();
		AdgSurroundMaskState state = new();
		byte[] patch = BuildPatch(0x00);
		AdgChannelRoutingTable table = BuildTable(0, 0, 0);

		// Act + Assert
		Assert.Throws<ArgumentOutOfRangeException>(() =>
			AdgChannelInstrumentEmitter.Emit(bus, state, patch, table, 18));
	}
}