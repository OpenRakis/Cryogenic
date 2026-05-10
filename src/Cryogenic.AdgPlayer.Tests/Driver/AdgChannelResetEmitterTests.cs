namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

using System.Collections.Generic;

/// <summary>
/// Phase 8 — global note-off reset across all 18 logical channels.
/// Faithful port of <c>AdgResetInternal_0EBA</c> +
/// <c>AdgOplNoteOff_ResetHelper</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// Original behavior:
///   for CX = 0x12; CX != 0; CX-- :
///       channelIndex = CX - 1                   ; iterates 17..0
///       freq = FrequencyWordTable[channelIndex] ; cached A0/B0 word
///       WriteRouted(0xA0, lo(freq), channelIndex)
///       WriteRouted(0xB0, hi(freq), channelIndex)
/// The hi byte is written *without* the key-on bit (0x20), so the channel
/// is silenced even though the frequency word is restored.
/// </summary>
public sealed class AdgChannelResetEmitterTests {
	[Fact]
	public void Emit_AllChannels_WritesA0AndB0PairForEachInDescendingOrder() {
		// Arrange — minimal: 18 routes (all primary, route = channel index)
		// and a unique cached frequency word per channel so we can identify
		// each pair in the recorded output.
		byte[] routingTable = new byte[18];
		ushort[] frequencyWords = new ushort[18];
		for (int i = 0; i < 18; i++) {
			routingTable[i] = (byte)i;
			frequencyWords[i] = (ushort)(0x1100 + i);
		}
		RecordingOplBus bus = new();

		// Act
		AdgChannelResetEmitter.EmitGlobalNoteOff(bus, routingTable, frequencyWords);

		// Assert — 18 channels × 2 writes (A0 + B0) = 36 writes,
		// processed in channel-index order 17..0.
		IReadOnlyList<OplWrite> writes = bus.Writes;
		Assert.Equal(36, writes.Count);

		for (int step = 0; step < 18; step++) {
			int ch = 17 - step;
			ushort freq = (ushort)(0x1100 + ch);
			OplWrite a0 = writes[step * 2];
			OplWrite b0 = writes[step * 2 + 1];
			Assert.Equal(0, a0.Chip);
			Assert.Equal((byte)(0xA0 + ch), a0.Register);
			Assert.Equal((byte)(freq & 0xFF), a0.Value);
			Assert.Equal(0, b0.Chip);
			Assert.Equal((byte)(0xB0 + ch), b0.Register);
			Assert.Equal((byte)(freq >> 8), b0.Value);
		}
	}

	[Fact]
	public void Emit_RespectsSecondaryChipRouting() {
		// Arrange — channel 0 routes to secondary chip via route 0x88.
		// Expected register: 0xA0 + 0x88 XOR 0x80 = 0xA8 on chip 1.
		byte[] routingTable = new byte[18];
		ushort[] frequencyWords = new ushort[18];
		routingTable[0] = 0x88;
		frequencyWords[0] = 0x2A57;
		RecordingOplBus bus = new();

		// Act
		AdgChannelResetEmitter.EmitGlobalNoteOff(bus, routingTable, frequencyWords);

		// Assert — channel 0 is processed last (step 17). Inspect that pair.
		IReadOnlyList<OplWrite> writes = bus.Writes;
		OplWrite a0 = writes[34];
		OplWrite b0 = writes[35];
		Assert.Equal(new OplWrite(1, 0xA8, 0x57), a0);
		Assert.Equal(new OplWrite(1, 0xB8, 0x2A), b0);
	}

	[Fact]
	public void Emit_RejectsRoutingTableOfWrongLength() {
		// Arrange
		byte[] routingTable = new byte[10];
		ushort[] frequencyWords = new ushort[18];
		RecordingOplBus bus = new();

		// Act + Assert
		Assert.Throws<ArgumentException>(() =>
			AdgChannelResetEmitter.EmitGlobalNoteOff(bus, routingTable, frequencyWords));
	}

	[Fact]
	public void Emit_RejectsFrequencyTableOfWrongLength() {
		// Arrange
		byte[] routingTable = new byte[18];
		ushort[] frequencyWords = new ushort[10];
		RecordingOplBus bus = new();

		// Act + Assert
		Assert.Throws<ArgumentException>(() =>
			AdgChannelResetEmitter.EmitGlobalNoteOff(bus, routingTable, frequencyWords));
	}

	[Fact]
	public void Emit_NullBus_Throws() {
		// Arrange
		byte[] routingTable = new byte[18];
		ushort[] frequencyWords = new ushort[18];

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() =>
			AdgChannelResetEmitter.EmitGlobalNoteOff(null!, routingTable, frequencyWords));
	}
}