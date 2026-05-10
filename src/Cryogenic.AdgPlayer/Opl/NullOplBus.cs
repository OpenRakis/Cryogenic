namespace Cryogenic.AdgPlayer.Opl;

/// <summary>
/// <see cref="IOplBus"/> sink that discards every register write.
/// Used as the production inner bus when no synth is connected yet,
/// to avoid unbounded growth that would occur with
/// <see cref="RecordingOplBus"/>.
/// </summary>
public sealed class NullOplBus : IOplBus {
	/// <inheritdoc />
	public void WriteRegister(int chip, byte register, byte value) {
		// Intentionally empty — sink discards every write.
	}
}