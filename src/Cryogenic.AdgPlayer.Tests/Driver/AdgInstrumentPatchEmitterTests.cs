namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Phase 23b — Full orchestrator for <c>AdgWriteInstrumentPatch_0F95</c>.
/// Composes <see cref="AdgInstrumentEmitter"/> +
/// <see cref="AdgSurroundMaskUpdater"/>, persists the new mask in
/// <see cref="AdgSurroundMaskState"/>, and emits the optional
/// <c>SecondaryControl</c> (chip 1, register 0x04) write through the
/// secondary chip with no router transform.
/// </summary>
public sealed class AdgInstrumentPatchEmitterTests {
	private static byte[] BuildPatch(byte patchType) {
		byte[] patch = new byte[AdgInstrumentEmitter.RequiredPatchLength];
		for (int i = 0; i < patch.Length; i++) {
			patch[i] = (byte)(0x10 + i);
		}
		patch[0] = patchType;
		return patch;
	}

	[Fact]
	public void Emit_NonSurround_WritesElevenInstrumentRegisters_AndOneSecondaryControl() {
		// Arrange — secondaryRoute=0x00 → bit 0 cleared in mask 0xFF → 0xFE.
		RecordingOplBus bus = new();
		AdgSurroundMaskState state = new();
		byte[] patch = BuildPatch(patchType: 0x00);

		// Act
		AdgInstrumentPatchEmitter.Emit(bus, state, patch,
			channelRoute: 0x00, primaryRoute: 0x00, secondaryRoute: 0x00);

		// Assert — 11 instrument writes + 1 SecondaryControl write.
		Assert.Equal(12, bus.Writes.Count);
		Assert.Equal((byte)0xFE, state.Mask);
		Assert.Equal(new OplWrite(1, 0x04, 0xFE), bus.Writes[11]);
	}

	[Fact]
	public void Emit_PatchTypeFour_SkipsSecondaryControlAndKeepsMaskUnchanged() {
		// Arrange
		RecordingOplBus bus = new();
		AdgSurroundMaskState state = new();
		byte[] patch = BuildPatch(patchType: 0x04);

		// Act
		AdgInstrumentPatchEmitter.Emit(bus, state, patch,
			channelRoute: 0x00, primaryRoute: 0x00, secondaryRoute: 0x00);

		// Assert — 11 instrument writes only; mask untouched.
		Assert.Equal(11, bus.Writes.Count);
		Assert.Equal((byte)0xFF, state.Mask);
	}

	[Fact]
	public void Emit_SecondaryRouteSkipBit_SkipsSecondaryControlAndKeepsMaskUnchanged() {
		// Arrange — secondaryRoute bit 0x10 set → no surround update.
		RecordingOplBus bus = new();
		AdgSurroundMaskState state = new();
		byte[] patch = BuildPatch(patchType: 0x00);

		// Act
		AdgInstrumentPatchEmitter.Emit(bus, state, patch,
			channelRoute: 0x00, primaryRoute: 0x00, secondaryRoute: 0x10);

		// Assert
		Assert.Equal(11, bus.Writes.Count);
		Assert.Equal((byte)0xFF, state.Mask);
	}

	[Fact]
	public void Emit_AccumulatesClearedBitsAcrossCalls() {
		// Arrange — two consecutive emits should clear bits 0 and 6
		// of the same mask, ending at 0xFF & ~0x01 & ~0x40 = 0xBE.
		RecordingOplBus bus = new();
		AdgSurroundMaskState state = new();
		byte[] patch = BuildPatch(patchType: 0x00);

		// Act
		AdgInstrumentPatchEmitter.Emit(bus, state, patch,
			channelRoute: 0x00, primaryRoute: 0x00, secondaryRoute: 0x00);
		AdgInstrumentPatchEmitter.Emit(bus, state, patch,
			channelRoute: 0x00, primaryRoute: 0x00, secondaryRoute: 0x83);

		// Assert
		Assert.Equal((byte)0xBE, state.Mask);
		Assert.Equal(new OplWrite(1, 0x04, 0xFE), bus.Writes[11]);
		Assert.Equal(new OplWrite(1, 0x04, 0xBE), bus.Writes[23]);
	}

	[Fact]
	public void Emit_NullBus_Throws() {
		// Arrange
		AdgSurroundMaskState state = new();
		byte[] patch = BuildPatch(0x00);

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgInstrumentPatchEmitter.Emit(null!, state, patch, 0, 0, 0));
	}

	[Fact]
	public void Emit_NullState_Throws() {
		// Arrange
		RecordingOplBus bus = new();
		byte[] patch = BuildPatch(0x00);

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgInstrumentPatchEmitter.Emit(bus, null!, patch, 0, 0, 0));
	}
}