namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 24 — Read-only typed wrapper around the three per-channel
/// route byte tables consumed by <c>AdgWriteInstrumentPatch_0F95</c>:
/// channel route (<c>AdgChannelRoutingTableOffset</c>), primary
/// operator route (<c>AdgChannelPrimaryOperatorRouteOffset</c>) and
/// secondary operator route
/// (<c>AdgChannelSecondaryOperatorRouteOffset</c>) in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public sealed class AdgChannelRoutingTableTests {
	private static byte[] BuildSequence(byte start) {
		byte[] values = new byte[AdgChannelRoutingTable.ChannelCount];
		for (int i = 0; i < values.Length; i++) {
			values[i] = (byte)(start + i);
		}
		return values;
	}

	[Fact]
	public void ChannelCount_IsEighteen() {
		// Assert
		Assert.Equal(18, AdgChannelRoutingTable.ChannelCount);
	}

	[Fact]
	public void GetEntry_ReturnsTripletForGivenChannel() {
		// Arrange
		byte[] channel = BuildSequence(0x10);
		byte[] primary = BuildSequence(0x40);
		byte[] secondary = BuildSequence(0x80);
		AdgChannelRoutingTable table = new(channel, primary, secondary);

		// Act
		AdgChannelRoutingEntry entry = table.GetEntry(5);

		// Assert
		Assert.Equal((byte)0x15, entry.ChannelRoute);
		Assert.Equal((byte)0x45, entry.PrimaryRoute);
		Assert.Equal((byte)0x85, entry.SecondaryRoute);
	}

	[Fact]
	public void GetEntry_FirstAndLastChannelsAccessible() {
		// Arrange
		byte[] channel = BuildSequence(0x00);
		byte[] primary = BuildSequence(0x20);
		byte[] secondary = BuildSequence(0x40);
		AdgChannelRoutingTable table = new(channel, primary, secondary);

		// Act
		AdgChannelRoutingEntry first = table.GetEntry(0);
		AdgChannelRoutingEntry last = table.GetEntry(17);

		// Assert
		Assert.Equal(new AdgChannelRoutingEntry(0x00, 0x20, 0x40), first);
		Assert.Equal(new AdgChannelRoutingEntry(0x11, 0x31, 0x51), last);
	}

	[Theory]
	[InlineData(-1)]
	[InlineData(18)]
	[InlineData(100)]
	public void GetEntry_OutOfRange_Throws(int channelIndex) {
		// Arrange
		AdgChannelRoutingTable table = new(
			BuildSequence(0), BuildSequence(0), BuildSequence(0));

		// Act + Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => table.GetEntry(channelIndex));
	}

	[Fact]
	public void Constructor_NullArray_Throws() {
		// Arrange
		byte[] valid = BuildSequence(0);

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			new AdgChannelRoutingTable(null!, valid, valid));
		Assert.Throws<ArgumentNullException>(() =>
			new AdgChannelRoutingTable(valid, null!, valid));
		Assert.Throws<ArgumentNullException>(() =>
			new AdgChannelRoutingTable(valid, valid, null!));
	}

	[Fact]
	public void Constructor_WrongLengthArray_Throws() {
		// Arrange
		byte[] valid = BuildSequence(0);
		byte[] tooShort = new byte[17];

		// Act + Assert
		Assert.Throws<ArgumentException>(() =>
			new AdgChannelRoutingTable(tooShort, valid, valid));
	}

	[Fact]
	public void Constructor_DefensivelyCopiesArrays() {
		// Arrange
		byte[] channel = BuildSequence(0x10);
		byte[] primary = BuildSequence(0x40);
		byte[] secondary = BuildSequence(0x80);
		AdgChannelRoutingTable table = new(channel, primary, secondary);

		// Act — mutate the source arrays after construction.
		channel[0] = 0xFF;
		primary[0] = 0xFF;
		secondary[0] = 0xFF;

		// Assert — table values are unaffected.
		AdgChannelRoutingEntry entry = table.GetEntry(0);
		Assert.Equal(new AdgChannelRoutingEntry(0x10, 0x40, 0x80), entry);
	}
}