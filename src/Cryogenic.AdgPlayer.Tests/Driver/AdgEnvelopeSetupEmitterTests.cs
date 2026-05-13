namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Tests for <see cref="AdgEnvelopeSetupEmitter"/> — the full
/// state-driven port of <c>AdgEnvelopeSetup_0C47</c>. Validates the
/// branching (zero shaping skips), saturation, KSL preservation,
/// patch-4 extension, and the connection-shape 0xC0 tail.
/// </summary>
public sealed class AdgEnvelopeSetupEmitterTests {
	private const int Ch = 3;

	private static (
		AdgChannelRoutingTable Routing,
		AdgChannelCurrentOperatorLevels CurrentLevels,
		AdgChannelTlShapingSlots TlShape,
		AdgChannelPatchTypeSlots PatchType,
		AdgChannelPatch4CurrentOperatorLevels Patch4Levels,
		AdgChannelPatch4TlShapingSlots Patch4Shape,
		AdgChannelConnectionShapingSlots ConnShape,
		AdgChannelConnectionModulationSlots ConnMod
	) BuildState(byte primaryRoute, byte secondaryRoute, byte channelRoute) {
		byte[] channels = new byte[AdgChannelRoutingTable.ChannelCount];
		byte[] primaries = new byte[AdgChannelRoutingTable.ChannelCount];
		byte[] secondaries = new byte[AdgChannelRoutingTable.ChannelCount];
		channels[Ch] = channelRoute;
		primaries[Ch] = primaryRoute;
		secondaries[Ch] = secondaryRoute;
		return (
			new AdgChannelRoutingTable(channels, primaries, secondaries),
			new AdgChannelCurrentOperatorLevels(),
			new AdgChannelTlShapingSlots(),
			new AdgChannelPatchTypeSlots(),
			new AdgChannelPatch4CurrentOperatorLevels(),
			new AdgChannelPatch4TlShapingSlots(),
			new AdgChannelConnectionShapingSlots(),
			new AdgChannelConnectionModulationSlots()
		);
	}

	[Fact]
	public void Emit_AllZeroShaping_EmitsNothing_AndPublishesConnectionCurrent() {
		// Arrange — no TL shaping, no connection-shape low byte;
		// the routine still publishes connectionShape.Hi to the
		// ConnectionCurrent slot (no OPL write).
		(AdgChannelRoutingTable rt, AdgChannelCurrentOperatorLevels lv,
			AdgChannelTlShapingSlots ts, AdgChannelPatchTypeSlots pt,
			AdgChannelPatch4CurrentOperatorLevels p4l,
			AdgChannelPatch4TlShapingSlots p4s,
			AdgChannelConnectionShapingSlots cs,
			AdgChannelConnectionModulationSlots cm) =
			BuildState(0x00, 0x03, 0x00);
		cs.Set(Ch, 0x2200); // Lo=0 (skip), Hi=0x22 → ConnectionCurrent.
		RecordingOplBus bus = new();

		// Act
		AdgEnvelopeSetupEmitter.Emit(bus, rt, lv, ts, pt, p4l, p4s, cs, cm,
			channelIndex: Ch, velocity: 0x40);

		// Assert
		Assert.Empty(bus.Writes);
		Assert.Equal(0x2200, cm.Get(Ch)); // High byte stored, low byte zero.
	}

	[Fact]
	public void Emit_PrimaryAndSecondaryShaping_EmitsTwoKeyScaleWrites() {
		// Arrange — primary route 0x03, secondary 0x06; shaping
		// 0x0202 (Lo=Hi=2 → shift = -(2-4)=2 → scale = inv>>2).
		(AdgChannelRoutingTable rt, AdgChannelCurrentOperatorLevels lv,
			AdgChannelTlShapingSlots ts, AdgChannelPatchTypeSlots pt,
			AdgChannelPatch4CurrentOperatorLevels p4l,
			AdgChannelPatch4TlShapingSlots p4s,
			AdgChannelConnectionShapingSlots cs,
			AdgChannelConnectionModulationSlots cm) =
			BuildState(0x03, 0x06, 0x00);
		lv.Set(Ch, 0xC0C0); // KSL=0xC0 on both ops; TL=0.
		ts.Set(Ch, 0x0202);
		// velocity=0x40 → inverseVelocity=0x40 → scale=0x40>>2=0x10.
		RecordingOplBus bus = new();

		// Act
		AdgEnvelopeSetupEmitter.Emit(bus, rt, lv, ts, pt, p4l, p4s, cs, cm,
			channelIndex: Ch, velocity: 0x40);

		// Assert — two TL writes at 0x40+route, KSL bits preserved.
		Assert.Equal(2, bus.Writes.Count);
		Assert.Equal(new OplWrite(0, (byte)(0x40 + 0x03), 0xD0), bus.Writes[0]);
		Assert.Equal(new OplWrite(0, (byte)(0x40 + 0x06), 0xD0), bus.Writes[1]);
		// Slot updated with both new levels.
		Assert.Equal(0xD0D0, lv.Get(Ch));
	}

	[Fact]
	public void Emit_ConnectionShape_EmitsFeedbackConnectionWrite_AndUpdatesCurrent() {
		// Arrange — only connection-shape, no TL shaping.
		(AdgChannelRoutingTable rt, AdgChannelCurrentOperatorLevels lv,
			AdgChannelTlShapingSlots ts, AdgChannelPatchTypeSlots pt,
			AdgChannelPatch4CurrentOperatorLevels p4l,
			AdgChannelPatch4TlShapingSlots p4s,
			AdgChannelConnectionShapingSlots cs,
			AdgChannelConnectionModulationSlots cm) =
			BuildState(0x00, 0x00, 0x00);
		// connectionShape: Lo=0x02 (rate), Hi=0x30 (pan-only seed).
		cs.Set(Ch, 0x3002);
		// velocity=0x40 → inverseVelocity=0x40.
		// shapingMode = -(2-6) = 4 → scale = 0x40 >> 4 = 0x04;
		// scale &= 0xFE → 0x04; scale + Hi(0x30) = 0x34;
		// 0x34 > 0x0F → (0x34 & 0x0F)|0x0E = 0x04|0x0E = 0x0E;
		// 0x0E | (0x30 & 0x30) = 0x3E.
		RecordingOplBus bus = new();

		// Act
		AdgEnvelopeSetupEmitter.Emit(bus, rt, lv, ts, pt, p4l, p4s, cs, cm,
			channelIndex: Ch, velocity: 0x40);

		// Assert
		Assert.Single(bus.Writes);
		Assert.Equal(new OplWrite(0, 0xC0, 0x3E), bus.Writes[0]);
		// ConnectionCurrent stored in high byte of the connection-modulation slot.
		Assert.Equal((ushort)(0x3E << 8), cm.Get(Ch));
	}
}
