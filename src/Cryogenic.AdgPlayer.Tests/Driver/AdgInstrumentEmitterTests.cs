namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Phase 21 — Composes <see cref="AdgInstrumentConnectionComputer"/>,
/// <see cref="AdgChannelRouter"/> and two
/// <see cref="AdgInstrumentOperatorEmitter"/> calls into the full
/// instrument-patch emit sequence (without the surround tail, which is
/// covered separately in a later phase). Faithful to
/// <c>AdgWriteInstrumentPatch_0F95</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public sealed class AdgInstrumentEmitterTests {
	private static byte[] BuildPatch() {
		// Distinct values per offset so an off-by-one in the slicing or
		// the waveform pickup is observable in the asserted writes.
		byte[] patch = new byte[AdgInstrumentEmitter.RequiredPatchLength];
		for (int i = 0; i < patch.Length; i++) {
			patch[i] = (byte)(0x10 + i);
		}
		return patch;
	}

	[Fact]
	public void Emit_WritesConnectionThenPrimaryThenSecondary() {
		// Arrange
		RecordingOplBus bus = new();
		byte[] patch = BuildPatch();

		// Act — channelRoute=0x00 (chip 0), primaryRoute=0x00, secondaryRoute=0x03.
		AdgInstrumentEmitter.Emit(bus, patch,
			channelRoute: 0x00, primaryRoute: 0x00, secondaryRoute: 0x03);

		// Assert — 1 connection write + 5 primary + 5 secondary = 11 writes.
		Assert.Equal(11, bus.Writes.Count);

		// Connection byte goes to 0xC0 (chip 0 because channelRoute=0).
		byte expectedConnection = AdgInstrumentConnectionComputer.Compute(patch);
		Assert.Equal(new OplWrite(0, 0xC0, expectedConnection), bus.Writes[0]);
	}

	[Fact]
	public void Emit_PrimaryOperatorReadsFromPatchHead_AndWaveform0x1C() {
		// Arrange
		RecordingOplBus bus = new();
		byte[] patch = BuildPatch();

		RecordingOplBus reference = new();
		byte[] primaryPatch = new byte[AdgInstrumentOperatorComputer.RequiredPatchLength];
		Array.Copy(patch, 0, primaryPatch, 0, primaryPatch.Length);
		AdgInstrumentOperatorEmitter.Emit(reference, primaryPatch,
			patch[0x1C], operatorRoute: 0x00);

		// Act
		AdgInstrumentEmitter.Emit(bus, patch,
			channelRoute: 0x00, primaryRoute: 0x00, secondaryRoute: 0x03);

		// Assert — bus.Writes[1..6] must equal the standalone primary emit.
		for (int i = 0; i < 5; i++) {
			Assert.Equal(reference.Writes[i], bus.Writes[1 + i]);
		}
	}

	[Fact]
	public void Emit_SecondaryOperatorReadsFromPatch0x0D_AndWaveform0x1D() {
		// Arrange
		RecordingOplBus bus = new();
		byte[] patch = BuildPatch();

		RecordingOplBus reference = new();
		byte[] secondaryPatch = new byte[AdgInstrumentOperatorComputer.RequiredPatchLength];
		Array.Copy(patch, 0x0D, secondaryPatch, 0, secondaryPatch.Length);
		AdgInstrumentOperatorEmitter.Emit(reference, secondaryPatch,
			patch[0x1D], operatorRoute: 0x03);

		// Act
		AdgInstrumentEmitter.Emit(bus, patch,
			channelRoute: 0x00, primaryRoute: 0x00, secondaryRoute: 0x03);

		// Assert — bus.Writes[6..11] must equal the standalone secondary emit.
		for (int i = 0; i < 5; i++) {
			Assert.Equal(reference.Writes[i], bus.Writes[6 + i]);
		}
	}

	[Fact]
	public void Emit_RoutesConnectionByteThroughChannelRoute() {
		// Arrange — channelRoute with bit 7 set sends to chip 1.
		RecordingOplBus bus = new();
		byte[] patch = BuildPatch();

		// Act — channelRoute=0x88 → register = ((0xC0+0x88)&0xFF) ^ 0x80
		// = 0x48 ^ 0x80 = 0xC8, on chip 1.
		AdgInstrumentEmitter.Emit(bus, patch,
			channelRoute: 0x88, primaryRoute: 0x00, secondaryRoute: 0x03);

		// Assert
		byte expectedConnection = AdgInstrumentConnectionComputer.Compute(patch);
		Assert.Equal(new OplWrite(1, 0xC8, expectedConnection), bus.Writes[0]);
	}

	[Fact]
	public void Emit_NullBus_Throws() {
		// Arrange
		byte[] patch = BuildPatch();

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgInstrumentEmitter.Emit(null!, patch, 0, 0, 0));
	}

	[Fact]
	public void Emit_NullPatch_Throws() {
		// Arrange
		RecordingOplBus bus = new();

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgInstrumentEmitter.Emit(bus, null!, 0, 0, 0));
	}

	[Fact]
	public void Emit_PatchTooShort_Throws() {
		// Arrange — must reach offsets 0x1C and 0x1D.
		RecordingOplBus bus = new();
		byte[] patch = new byte[AdgInstrumentEmitter.RequiredPatchLength - 1];

		// Act + Assert
		Assert.Throws<ArgumentException>(() =>
			AdgInstrumentEmitter.Emit(bus, patch, 0, 0, 0));
	}
}