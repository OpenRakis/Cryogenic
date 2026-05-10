namespace Cryogenic.AdgPlayer.Services;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;

using System;

/// <summary>
/// Engine OPL helpers: holds the bound <see cref="IOplBus"/> and
/// exposes high-level OPL3 utility writes (key-off broadcast,
/// register write). Wires the engine to either a real OPL3
/// synth (production) or a recording bus (tests).
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
	private IOplBus _oplBus = new RecordingOplBus();
	private AdgChannelRoutingTable? _routingTable;

	/// <summary>
	/// Currently bound OPL bus. Defaults to a fresh
	/// <see cref="RecordingOplBus"/> so the engine is usable with
	/// no host wiring (and so tests can read writes back without
	/// extra setup).
	/// </summary>
	public IOplBus OplBus => _oplBus;

	/// <summary>
	/// Currently bound channel routing table extracted from the
	/// loaded DNADG driver image. Null until <see cref="SetRoutingTable"/>
	/// is called; in that case OPL emit handlers (NoteOff/NoteOn)
	/// only mutate driver state and skip register writes.
	/// </summary>
	public AdgChannelRoutingTable? RoutingTable => _routingTable;

	/// <summary>Replaces the bound bus. Throws on null.</summary>
	public void SetOplBus(IOplBus bus) {
		ArgumentNullException.ThrowIfNull(bus);
		_oplBus = bus;
	}

	/// <summary>
	/// Binds the per-channel routing table extracted from the DNADG
	/// driver image. Required for OPL register emit during NoteOff
	/// and NoteOn dispatch.
	/// </summary>
	public void SetRoutingTable(AdgChannelRoutingTable routingTable) {
		ArgumentNullException.ThrowIfNull(routingTable);
		_routingTable = routingTable;
	}

	/// <summary>
	/// Writes <paramref name="value"/> to <paramref name="register"/>
	/// on <paramref name="chip"/> (0 = primary, 1 = secondary OPL3
	/// bank used by AdLib Gold for the second 9 channels).
	/// </summary>
	public void WriteOplRegister(int chip, byte register, byte value) {
		if (chip is not (0 or 1)) {
			throw new ArgumentOutOfRangeException(nameof(chip), chip, "OPL3 chip selector must be 0 or 1.");
		}
		_oplBus.WriteRegister(chip, register, value);
	}

	/// <summary>
	/// Drops every key-on bit on both chips by writing 0 to
	/// registers 0xB0..0xB8. Mirrors the silence-all step of
	/// <c>AdgEndOfTrack_0AF5</c>.
	/// </summary>
	public void SilenceAll() {
		for (byte reg = 0xB0; reg <= 0xB8; reg++) {
			_oplBus.WriteRegister(0, reg, 0);
			_oplBus.WriteRegister(1, reg, 0);
		}
	}

	/// <summary>
	/// Initialises the OPL3 chip pair by enabling OPL3 mode (reg 0x05
	/// on the secondary chip = 1) and clearing connection-select / 4-op
	/// flags. Mirrors the front of
	/// <c>AdgInitOpl3_xxxx</c>: <c>(1,0x05,0x01)</c> +
	/// <c>(1,0x04,0x00)</c>.
	/// </summary>
	public void InitializeOpl3() {
		_oplBus.WriteRegister(1, 0x05, 0x01);
		_oplBus.WriteRegister(1, 0x04, 0x00);
		SilenceAll();
	}
}