namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

using Xunit;

/// <summary>
/// Tests for <see cref="DefaultAdgPitchBendBody"/> — the
/// production <see cref="IAdgPitchBendBody"/> wiring math
/// (<see cref="AdgPitchBendComputer"/>) into the routed cache+emit
/// (<see cref="AdgChannelPitchBendEmitter"/>).
/// </summary>
public sealed class DefaultAdgPitchBendBodyTests {
	private static AdgFrequencyLookupTable BuildLookup() {
		ushort[] lookup = new ushort[12] {
			0x0157, 0x016C, 0x0181, 0x0198, 0x01B1, 0x01CB,
			0x01E6, 0x0203, 0x0222, 0x0243, 0x0266, 0x028A
		};
		return new AdgFrequencyLookupTable(lookup);
	}

	private static AdgPitchBendFractionsTable BuildBendFractions() {
		byte[] fractions = new byte[13] {
			0x10, 0x20, 0x30, 0x40, 0x50, 0x60,
			0x70, 0x80, 0x90, 0xA0, 0xB0, 0xC0, 0xD0
		};
		return new AdgPitchBendFractionsTable(fractions);
	}

	private static AdgPortamentoFractionsTable BuildPortamentoFractions() {
		byte[] fractions = new byte[10] {
			0x01, 0x02, 0x03, 0x04, 0x05,
			0x06, 0x07, 0x08, 0x09, 0x0A
		};
		return new AdgPortamentoFractionsTable(fractions);
	}

	private static AdgChannelRoutingTable BuildZeroRouting() {
		byte[] zero = new byte[AdgChannelRoutingTable.ChannelCount];
		return new AdgChannelRoutingTable(zero, zero, zero);
	}

	/// <summary>
	/// When the channel currently holds note 0, the body is a
	/// no-op — no cache write, no OPL emit.
	/// </summary>
	[Fact]
	public void Emit_CurrentNoteZero_NoSideEffects() {
		// Arrange
		RecordingOplBus bus = new();
		AdgFrequencyWordCache cache = new();
		AdgChannelCurrentNotes notes = new();
		AdgChannelPitchModeSlots modes = new();
		DefaultAdgPitchBendBody body = new(
			bus, cache, BuildZeroRouting(), BuildLookup(),
			BuildBendFractions(), BuildPortamentoFractions(),
			notes, modes);

		// Act
		body.Emit(channelIndex: 0, bendWord: 0x0040);

		// Assert
		Assert.Empty(bus.Writes);
		Assert.Equal<ushort>(0, cache.Get(0));
	}

	/// <summary>
	/// With a live current note and centred bend, the body emits
	/// the routed (A0, B0|0x20) pair and updates the cache.
	/// </summary>
	[Fact]
	public void Emit_LiveNoteCenteredBend_EmitsRoutedKeyOn() {
		// Arrange
		RecordingOplBus bus = new();
		AdgFrequencyWordCache cache = new();
		AdgChannelCurrentNotes notes = new();
		AdgChannelPitchModeSlots modes = new();
		notes.Set(0, 0x18);
		DefaultAdgPitchBendBody body = new(
			bus, cache, BuildZeroRouting(), BuildLookup(),
			BuildBendFractions(), BuildPortamentoFractions(),
			notes, modes);

		// Act — bendValue 0x40 (centre); pitchMode 0 (bend mode).
		body.Emit(channelIndex: 0, bendWord: 0x0040);

		// Assert — A0=0x58, B0=Hi8|0x20=0x21 (per computer test).
		Assert.Equal(2, bus.Writes.Count);
		Assert.Equal(0xA0, bus.Writes[0].Register);
		Assert.Equal(0x58, bus.Writes[0].Value);
		Assert.Equal(0xB0, bus.Writes[1].Register);
		Assert.Equal(0x21, bus.Writes[1].Value);
		Assert.Equal<ushort>(0x0158, cache.Get(0));
	}
}