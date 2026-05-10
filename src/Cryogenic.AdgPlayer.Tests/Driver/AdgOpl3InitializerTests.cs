namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

using System.Collections.Generic;

/// <summary>
/// Phase 6 — OPL3 chip initialization (the five fixed-register writes
/// emitted by <c>AdgInit_564B_04FF_0569AF</c> right before the Gold init).
/// Sequence (port maps to chip 0=primary, 1=secondary):
///   chip0 reg 0x01 = 0x20  (WaveformControl: enable wave-select)
///   chip0 reg 0xBD = 0x00  (PercussionControl: percussion off)
///   chip0 reg 0x08 = 0x40  (ChannelEnable: KeyScale/NTS bit)
///   chip1 reg 0x05 = 0x01  (Opl3Mode: enable OPL3)
///   chip1 reg 0x04 = 0x00  (SecondaryControl: 4-op disabled)
/// </summary>
public sealed class AdgOpl3InitializerTests {
	[Fact]
	public void Initialize_EmitsExactFiveWriteSequence() {
		// Arrange
		RecordingOplBus bus = new();
		AdgOpl3Initializer initializer = new();

		// Act
		initializer.Initialize(bus);

		// Assert
		IReadOnlyList<OplWrite> writes = bus.Writes;
		Assert.Equal(5, writes.Count);
		Assert.Equal(new OplWrite(0, 0x01, 0x20), writes[0]);
		Assert.Equal(new OplWrite(0, 0xBD, 0x00), writes[1]);
		Assert.Equal(new OplWrite(0, 0x08, 0x40), writes[2]);
		Assert.Equal(new OplWrite(1, 0x05, 0x01), writes[3]);
		Assert.Equal(new OplWrite(1, 0x04, 0x00), writes[4]);
	}

	[Fact]
	public void Initialize_NullBus_Throws() {
		// Arrange
		AdgOpl3Initializer initializer = new();

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() => initializer.Initialize(null!));
	}
}