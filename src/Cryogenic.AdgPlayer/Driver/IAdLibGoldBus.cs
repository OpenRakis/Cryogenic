namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Abstraction for the AdLib Gold secondary command/control bus.
/// Maps to the secondary register port at <c>[ADG:0117]</c> on real hardware.
/// Production playback wires this to the Spice86 IO port dispatcher; tests
/// substitute a recording fake to assert exact init sequences.
/// </summary>
public interface IAdLibGoldBus {
	/// <summary>Sends a single command byte to the Gold command port.</summary>
	void SendCommand(byte command);

	/// <summary>
	/// Writes a Gold control register using the wait-ready protocol
	/// (corresponds to <c>AdgWriteSecondaryOplRegisterWithReady_1158</c>).
	/// </summary>
	void WriteControlRegister(byte register, byte value);

	/// <summary>
	/// Polls the Gold status port until bits 6/7 (mask 0xC0) are clear
	/// (corresponds to <c>AdgWaitSecondaryOplReady_1149</c>).
	/// </summary>
	void WaitReady();

	/// <summary>Reads the Gold status byte from the secondary status port.</summary>
	byte ReadStatus();
}