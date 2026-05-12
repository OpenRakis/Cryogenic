namespace Cryogenic.AdgPlayer.Tests.Opl;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Phase 4 — OPL bus abstraction.
/// <see cref="IOplBus"/> models writes to OPL3 registers as
/// (chip, register, value) triples. The recording fake captures the full
/// sequence so driver-level tests can assert exact register-write streams
/// against runtime evidence.
/// OPL3 chip selector: 0 = primary (ports 388h/389h), 1 = secondary
/// (ports 38Ah/38Bh). AdLib Gold uses both for surround.
/// </summary>
public sealed class RecordingOplBusTests {
	[Fact]
	public void WriteRegister_RecordsSingleEntryInOrder() {
		// Arrange
		RecordingOplBus bus = new();

		// Act
		bus.WriteRegister(chip: 0, register: 0x20, value: 0x01);

		// Assert
		Assert.Single(bus.Writes);
		OplWrite write = bus.Writes[0];
		Assert.Equal(0, write.Chip);
		Assert.Equal((byte)0x20, write.Register);
		Assert.Equal((byte)0x01, write.Value);
	}

	[Fact]
	public void WriteRegister_PreservesInsertionOrderAcrossChips() {
		// Arrange
		RecordingOplBus bus = new();

		// Act
		bus.WriteRegister(0, 0xB0, 0x2E);
		bus.WriteRegister(1, 0xB0, 0x2E);
		bus.WriteRegister(0, 0xA0, 0x57);

		// Assert
		Assert.Equal(3, bus.Writes.Count);
		Assert.Equal((0, (byte)0xB0, (byte)0x2E),
			(bus.Writes[0].Chip, bus.Writes[0].Register, bus.Writes[0].Value));
		Assert.Equal((1, (byte)0xB0, (byte)0x2E),
			(bus.Writes[1].Chip, bus.Writes[1].Register, bus.Writes[1].Value));
		Assert.Equal((0, (byte)0xA0, (byte)0x57),
			(bus.Writes[2].Chip, bus.Writes[2].Register, bus.Writes[2].Value));
	}

	[Fact]
	public void Reset_ClearsRecordedWrites() {
		// Arrange
		RecordingOplBus bus = new();
		bus.WriteRegister(0, 0x01, 0x20);

		// Act
		bus.Reset();

		// Assert
		Assert.Empty(bus.Writes);
	}

	[Fact]
	public void WriteRegister_RejectsInvalidChipIndex() {
		// Arrange — OPL3 has exactly two chips (0 and 1).
		RecordingOplBus bus = new();

		// Act + Assert
		Assert.Throws<ArgumentOutOfRangeException>(
			() => bus.WriteRegister(chip: 2, register: 0x00, value: 0x00));
	}

	[Fact]
	public void Bus_IsExposedAsIOplBusInterface() {
		// Arrange — drivers must depend on the abstraction, not the fake.
		IOplBus bus = new RecordingOplBus();

		// Act
		bus.WriteRegister(0, 0x05, 0x01);

		// Assert
		Assert.Single(((RecordingOplBus)bus).Writes);
	}

	[Fact]
	public void DefaultCtor_IsUnbounded() {
		// Arrange
		RecordingOplBus bus = new();

		// Assert
		Assert.Equal(0, bus.Capacity);
		Assert.Equal(0, bus.DroppedCount);
	}

	[Fact]
	public void BoundedCtor_EvictsOldestEntryWhenFull() {
		// Arrange — capacity 2 so the third write evicts the first.
		RecordingOplBus bus = new(capacity: 2);

		// Act
		bus.WriteRegister(0, 0xA0, 0x10);
		bus.WriteRegister(0, 0xA0, 0x20);
		bus.WriteRegister(0, 0xA0, 0x30);

		// Assert
		Assert.Equal(2, bus.Writes.Count);
		Assert.Equal((byte)0x20, bus.Writes[0].Value);
		Assert.Equal((byte)0x30, bus.Writes[1].Value);
		Assert.Equal(1, bus.DroppedCount);
	}

	[Fact]
	public void BoundedCtor_NegativeCapacityThrows() {
		// Act + Assert
		Assert.Throws<ArgumentOutOfRangeException>(
			() => new RecordingOplBus(capacity: -1));
	}

	[Fact]
	public void Reset_ResetsDroppedCounter() {
		// Arrange
		RecordingOplBus bus = new(capacity: 1);
		bus.WriteRegister(0, 0xA0, 0x10);
		bus.WriteRegister(0, 0xA0, 0x20);
		Assert.Equal(1, bus.DroppedCount);

		// Act
		bus.Reset();

		// Assert
		Assert.Empty(bus.Writes);
		Assert.Equal(0, bus.DroppedCount);
	}
}