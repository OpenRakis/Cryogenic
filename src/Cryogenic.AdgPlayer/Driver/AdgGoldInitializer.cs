namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Performs the AdLib Gold hardware startup sequence — a faithful port of
/// <c>AdgInitializeGoldHardware_1185</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c> (564B:1185).
/// </summary>
/// <remarks>
/// Sequence (from AdgGoldInitWord enum + 1185 routine):
///   1. SendCommand 0xFF (reset/latch)
///   2. WriteControlRegister 0x06=0xFB, 0x07=0xF7, 0x04=0xF7,
///                           0x05=0xF7, 0x09=0xFF, 0x0A=0xFF
///   3. WaitReady; status = ReadStatus
///   4. SendCommand 0xFE (release reset)
/// Returns the Gold-presence status byte computed as
///   <c>(~status) &amp; 0xC0</c>.
/// </remarks>
public sealed class AdgGoldInitializer {
	private const byte ResetAndLatchCommand = 0xFF;
	private const byte ReleaseResetCommand = 0xFE;
	private const byte GoldPresentMask = 0xC0;

	private static readonly (byte Register, byte Value)[] InitWords = {
		(0x06, 0xFB),
		(0x07, 0xF7),
		(0x04, 0xF7),
		(0x05, 0xF7),
		(0x09, 0xFF),
		(0x0A, 0xFF),
	};

	/// <summary>Executes the Gold startup sequence on <paramref name="bus"/>.</summary>
	/// <returns>
	/// The Gold-present status byte: <c>(~ReadStatus()) &amp; 0xC0</c>.
	/// Stored at <c>AdgGoldStatusOffset</c> (0x011D) by the original code.
	/// </returns>
	public byte Initialize(IAdLibGoldBus bus) {
		ArgumentNullException.ThrowIfNull(bus);

		bus.SendCommand(ResetAndLatchCommand);

		foreach ((byte register, byte value) in InitWords) {
			bus.WriteControlRegister(register, value);
		}

		bus.WaitReady();
		byte rawStatus = bus.ReadStatus();
		byte goldStatus = (byte)(~rawStatus & GoldPresentMask);

		bus.SendCommand(ReleaseResetCommand);

		return goldStatus;
	}
}