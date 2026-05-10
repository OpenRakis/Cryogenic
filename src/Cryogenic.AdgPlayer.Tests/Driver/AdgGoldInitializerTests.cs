namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using System.Collections.Generic;

/// <summary>
/// Phase 5 — AdLib Gold hardware initialization sequence.
/// Faithful port of <c>AdgInitializeGoldHardware_1185</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c> (564B:1185).
/// The original sequence is:
///   1. Send command byte 0xFF (reset/latch)
///   2. Write 6 Gold control registers via wait-ready protocol:
///      0x06=0xFB, 0x07=0xF7, 0x04=0xF7, 0x05=0xF7, 0x09=0xFF, 0x0A=0xFF
///   3. Wait ready, then read status byte
///   4. Send command byte 0xFE (release reset)
/// </summary>
public sealed class AdgGoldInitializerTests {
	[Fact]
	public void Initialize_EmitsCommand_RegisterWrites_AndReleaseInOrder() {
		// Arrange
		RecordingAdLibGoldBus bus = new();
		AdgGoldInitializer initializer = new();

		// Act
		initializer.Initialize(bus);

		// Assert — the exact operation sequence observed at 564B:1185.
		IReadOnlyList<AdLibGoldOp> ops = bus.Operations;
		Assert.Equal(10, ops.Count);

		Assert.Equal(AdLibGoldOp.Command(0xFF), ops[0]);
		Assert.Equal(AdLibGoldOp.WriteRegister(0x06, 0xFB), ops[1]);
		Assert.Equal(AdLibGoldOp.WriteRegister(0x07, 0xF7), ops[2]);
		Assert.Equal(AdLibGoldOp.WriteRegister(0x04, 0xF7), ops[3]);
		Assert.Equal(AdLibGoldOp.WriteRegister(0x05, 0xF7), ops[4]);
		Assert.Equal(AdLibGoldOp.WriteRegister(0x09, 0xFF), ops[5]);
		Assert.Equal(AdLibGoldOp.WriteRegister(0x0A, 0xFF), ops[6]);
		Assert.Equal(AdLibGoldOp.WaitReady(), ops[7]);
		Assert.Equal(AdLibGoldOp.ReadStatus(), ops[8]);
		Assert.Equal(AdLibGoldOp.Command(0xFE), ops[9]);
	}

	[Fact]
	public void Initialize_ReturnsGoldStatus_ComputedFromInvertedReadByte() {
		// Arrange — the original code does:
		//   status = ReadByte(DX+1);
		//   AdgGoldStatusOffset = (~status) & GoldPresentMask (0xC0)
		// Stub the bus so ReadStatus returns 0x3F → ~0x3F = 0xC0 → masked = 0xC0.
		RecordingAdLibGoldBus bus = new() { StatusToReturn = 0x3F };
		AdgGoldInitializer initializer = new();

		// Act
		byte goldStatus = initializer.Initialize(bus);

		// Assert
		Assert.Equal((byte)0xC0, goldStatus);
	}

	[Fact]
	public void Initialize_NullBus_Throws() {
		// Arrange
		AdgGoldInitializer initializer = new();

		// Act + Assert
		Assert.Throws<ArgumentNullException>(() => initializer.Initialize(null!));
	}
}

/// <summary>
/// Test double for <see cref="IAdLibGoldBus"/> that records the operation
/// sequence. <see cref="StatusToReturn"/> controls the byte returned by
/// <see cref="IAdLibGoldBus.ReadStatus"/>.
/// </summary>
internal sealed class RecordingAdLibGoldBus : IAdLibGoldBus {
	private readonly List<AdLibGoldOp> _ops = new();

	public IReadOnlyList<AdLibGoldOp> Operations => _ops;
	public byte StatusToReturn { get; set; }

	public void SendCommand(byte command) => _ops.Add(AdLibGoldOp.Command(command));

	public void WriteControlRegister(byte register, byte value)
		=> _ops.Add(AdLibGoldOp.WriteRegister(register, value));

	public void WaitReady() => _ops.Add(AdLibGoldOp.WaitReady());

	public byte ReadStatus() {
		_ops.Add(AdLibGoldOp.ReadStatus());
		return StatusToReturn;
	}
}

/// <summary>
/// Discriminated record of operations recorded by
/// <see cref="RecordingAdLibGoldBus"/>.
/// </summary>
internal readonly record struct AdLibGoldOp(AdLibGoldOpKind Kind, byte A, byte B) {
	public static AdLibGoldOp Command(byte b) => new(AdLibGoldOpKind.Command, b, 0);
	public static AdLibGoldOp WriteRegister(byte reg, byte val) => new(AdLibGoldOpKind.WriteRegister, reg, val);
	public static AdLibGoldOp WaitReady() => new(AdLibGoldOpKind.WaitReady, 0, 0);
	public static AdLibGoldOp ReadStatus() => new(AdLibGoldOpKind.ReadStatus, 0, 0);
}

internal enum AdLibGoldOpKind : byte { Command, WriteRegister, WaitReady, ReadStatus }