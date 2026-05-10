namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Performs the OPL3 chip initialization writes emitted by
/// <c>AdgInit_564B_04FF_0569AF</c> immediately before the AdLib Gold
/// startup sequence. Five fixed-register writes map directly to
/// <see cref="IOplBus.WriteRegister"/> calls (chip 0 = primary,
/// chip 1 = secondary). Register and value semantics:
/// <list type="bullet">
///   <item>chip0 0x01 = 0x20 — WaveformControl: enable WaveformSelect.</item>
///   <item>chip0 0xBD = 0x00 — PercussionControl: rhythm/percussion off.</item>
///   <item>chip0 0x08 = 0x40 — ChannelEnable / KeyScale (NTS bit).</item>
///   <item>chip1 0x05 = 0x01 — Opl3Mode: enable OPL3 features.</item>
///   <item>chip1 0x04 = 0x00 — SecondaryControl: 4-op pairing disabled.</item>
/// </list>
/// </summary>
public sealed class AdgOpl3Initializer {
	private static readonly (int Chip, byte Register, byte Value)[] InitSequence = {
		(0, 0x01, 0x20),
		(0, 0xBD, 0x00),
		(0, 0x08, 0x40),
		(1, 0x05, 0x01),
		(1, 0x04, 0x00),
	};

	/// <summary>Emits the OPL3 init writes onto <paramref name="bus"/>.</summary>
	public void Initialize(IOplBus bus) {
		ArgumentNullException.ThrowIfNull(bus);

		foreach ((int chip, byte register, byte value) in InitSequence) {
			bus.WriteRegister(chip, register, value);
		}
	}
}