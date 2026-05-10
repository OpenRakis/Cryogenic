namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

using System.Collections.Generic;

/// <summary>
/// Phase 19 — emit the five OPL register writes for an instrument
/// operator. Faithful port of <c>AdgWriteInstrumentOperator_102C</c>
/// from <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>:
/// the original calls <c>AdgWriteRouteSelectedRegister_1101</c> in this
/// exact order with these register bases (waveform 0xE0 = 0x05+0xDB):
///   1. 0xE0 + route ← waveform &amp; 7
///   2. 0x40 + route ← TotalLevel
///   3. 0x60 + route ← AttackDecay
///   4. 0x80 + route ← SustainRelease
///   5. 0x20 + route ← OpFlags
/// </summary>
public sealed class AdgInstrumentOperatorEmitterTests {
	private static byte[] BuildPatchA() {
		// Reuses the deterministic "DistinctPatchBytes" patch from
		// AdgInstrumentOperatorComputerTests so the expected register
		// values are: waveform=0x07, TL=0x32, AD=0x19, SR=0x35,
		// opFlags=0xB5.
		return new byte[] {
			0x00, 0x05, 0xC8, 0x00, 0x00, 0x71, 0x83, 0x00,
			0xA9, 0x05, 0x02, 0x01
		};
	}

	[Fact]
	public void Emit_PrimaryRoute_WritesFiveRegistersInOrder() {
		// Arrange
		byte[] patch = BuildPatchA();
		RecordingOplBus bus = new();

		// Act — operator route 0x03 (primary chip, operator slot 3).
		AdgInstrumentOperatorEmitter.Emit(bus, patch, waveform: 0x0F, operatorRoute: 0x03);

		// Assert
		IReadOnlyList<OplWrite> writes = bus.Writes;
		Assert.Equal(5, writes.Count);
		Assert.Equal(new OplWrite(0, 0xE3, 0x07), writes[0]);
		Assert.Equal(new OplWrite(0, 0x43, 0x32), writes[1]);
		Assert.Equal(new OplWrite(0, 0x63, 0x19), writes[2]);
		Assert.Equal(new OplWrite(0, 0x83, 0x35), writes[3]);
		Assert.Equal(new OplWrite(0, 0x23, 0xB5), writes[4]);
	}

	[Fact]
	public void Emit_SecondaryRoute_TargetsSecondChipWithStrippedHighBit() {
		// Arrange
		byte[] patch = BuildPatchA();
		RecordingOplBus bus = new();

		// Act — route 0x88: secondary, operator slot 8.
		AdgInstrumentOperatorEmitter.Emit(bus, patch, waveform: 0x0F, operatorRoute: 0x88);

		// Assert
		IReadOnlyList<OplWrite> writes = bus.Writes;
		// AdgChannelRouter.Route: register = ((byte)(base+route)) ^ 0x80.
		//   0xE0+0x88 = 0x68 → ^0x80 = 0xE8
		//   0x40+0x88 = 0xC8 → ^0x80 = 0x48
		//   0x60+0x88 = 0xE8 → ^0x80 = 0x68
		//   0x80+0x88 = 0x08 → ^0x80 = 0x88
		//   0x20+0x88 = 0xA8 → ^0x80 = 0x28
		Assert.Equal(new OplWrite(1, 0xE8, 0x07), writes[0]);
		Assert.Equal(new OplWrite(1, 0x48, 0x32), writes[1]);
		Assert.Equal(new OplWrite(1, 0x68, 0x19), writes[2]);
		Assert.Equal(new OplWrite(1, 0x88, 0x35), writes[3]);
		Assert.Equal(new OplWrite(1, 0x28, 0xB5), writes[4]);
	}

	[Fact]
	public void Emit_NullBus_Throws() {
		// Arrange
		byte[] patch = BuildPatchA();

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgInstrumentOperatorEmitter.Emit(null!, patch, 0, 0));
	}

	[Fact]
	public void Emit_NullPatch_Throws() {
		// Arrange
		RecordingOplBus bus = new();

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgInstrumentOperatorEmitter.Emit(bus, null!, 0, 0));
	}

	[Fact]
	public void Emit_PatchTooShort_Throws() {
		// Arrange
		byte[] patch = new byte[11];
		RecordingOplBus bus = new();

		// Act + Assert
		Assert.Throws<ArgumentException>(() =>
			AdgInstrumentOperatorEmitter.Emit(bus, patch, 0, 0));
	}
}