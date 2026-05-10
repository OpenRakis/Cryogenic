namespace Cryogenic.AdgPlayer.Opl;

using System.Collections.Generic;

/// <summary>
/// Test double for <see cref="IOplBus"/> that records every register write
/// in insertion order so tests can assert exact OPL3 byte streams against
/// runtime evidence.
/// </summary>
public sealed class RecordingOplBus : IOplBus {
	private readonly List<OplWrite> _writes = new();

	/// <summary>Read-only view of every recorded write, in insertion order.</summary>
	public IReadOnlyList<OplWrite> Writes => _writes;

	/// <inheritdoc />
	public void WriteRegister(int chip, byte register, byte value) {
		if (chip is not (0 or 1)) {
			throw new ArgumentOutOfRangeException(nameof(chip),
				"OPL3 chip selector must be 0 (primary) or 1 (secondary).");
		}
		_writes.Add(new OplWrite(chip, register, value));
	}

	/// <summary>Clears the recorded write history.</summary>
	public void Reset() => _writes.Clear();
}