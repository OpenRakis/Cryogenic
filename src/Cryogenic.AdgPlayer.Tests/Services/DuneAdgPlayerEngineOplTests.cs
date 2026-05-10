namespace Cryogenic.AdgPlayer.Tests.Services;

using Cryogenic.AdgPlayer.Opl;
using Cryogenic.AdgPlayer.Services;

using System;

using Xunit;

/// <summary>Tests for <see cref="DuneAdgPlayerEngine"/> OPL helpers.</summary>
public sealed class DuneAdgPlayerEngineOplTests {
	/// <summary>Default bus is a recording bus that captures writes.</summary>
	[Fact]
	public void Default_OplBus_IsRecording() {
		// Arrange / Act
		DuneAdgPlayerEngine engine = new();

		// Assert
		Assert.IsType<RecordingOplBus>(engine.OplBus);
	}

	/// <summary>SetOplBus rejects null.</summary>
	[Fact]
	public void SetOplBus_Null_Throws() {
		// Arrange
		DuneAdgPlayerEngine engine = new();

		// Act / Assert
		Assert.Throws<ArgumentNullException>(() => engine.SetOplBus(null!));
	}

	/// <summary>WriteOplRegister forwards to the bound bus.</summary>
	[Fact]
	public void WriteOplRegister_ForwardsToBus() {
		// Arrange
		DuneAdgPlayerEngine engine = new();
		RecordingOplBus bus = new();
		engine.SetOplBus(bus);

		// Act
		engine.WriteOplRegister(0, 0x20, 0x42);
		engine.WriteOplRegister(1, 0xB0, 0x31);

		// Assert
		Assert.Equal(2, bus.Writes.Count);
		Assert.Equal(new OplWrite(0, 0x20, 0x42), bus.Writes[0]);
		Assert.Equal(new OplWrite(1, 0xB0, 0x31), bus.Writes[1]);
	}

	/// <summary>WriteOplRegister rejects out-of-range chip selectors.</summary>
	[Fact]
	public void WriteOplRegister_BadChip_Throws() {
		// Arrange
		DuneAdgPlayerEngine engine = new();

		// Act / Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => engine.WriteOplRegister(2, 0x00, 0x00));
	}

	/// <summary>SilenceAll writes zero to 0xB0..0xB8 on both chips.</summary>
	[Fact]
	public void SilenceAll_WritesKeyOffOnBothBanks() {
		// Arrange
		DuneAdgPlayerEngine engine = new();
		RecordingOplBus bus = new();
		engine.SetOplBus(bus);

		// Act
		engine.SilenceAll();

		// Assert — 9 channels * 2 chips = 18 writes
		Assert.Equal(18, bus.Writes.Count);
		for (int i = 0; i < 9; i++) {
			Assert.Equal(new OplWrite(0, (byte)(0xB0 + i), 0), bus.Writes[i * 2]);
			Assert.Equal(new OplWrite(1, (byte)(0xB0 + i), 0), bus.Writes[i * 2 + 1]);
		}
	}

	/// <summary>InitializeOpl3 enables OPL3 mode then silences all channels.</summary>
	[Fact]
	public void InitializeOpl3_EnablesModeThenSilences() {
		// Arrange
		DuneAdgPlayerEngine engine = new();
		RecordingOplBus bus = new();
		engine.SetOplBus(bus);

		// Act
		engine.InitializeOpl3();

		// Assert
		Assert.Equal(new OplWrite(1, 0x05, 0x01), bus.Writes[0]);
		Assert.Equal(new OplWrite(1, 0x04, 0x00), bus.Writes[1]);
		// Then 18 silence writes.
		Assert.Equal(2 + 18, bus.Writes.Count);
	}
}