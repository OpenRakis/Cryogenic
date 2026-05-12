namespace Cryogenic.AdgPlayer.Opl;

using System.Collections.Generic;

/// <summary>
/// Test double for <see cref="IOplBus"/> that records every register write
/// in insertion order so tests can assert exact OPL3 byte streams against
/// runtime evidence. By default the history is unbounded (matching the
/// pre-existing behaviour relied on by the dispatch and emit tests). For
/// long-running scenarios (Phase E1) callers can construct the bus with a
/// positive capacity, in which case the oldest entries are evicted once
/// the buffer is full so the recorder stays in O(capacity) memory.
/// </summary>
public sealed class RecordingOplBus : IOplBus {
	private readonly List<OplWrite> _writes;
	private readonly int _capacity;
	private long _droppedCount;

	/// <summary>
	/// Builds an unbounded recorder. Equivalent to <c>new RecordingOplBus(0)</c>.
	/// </summary>
	public RecordingOplBus() : this(0) {
	}

	/// <summary>
	/// Builds a recorder that evicts the oldest entry once it has buffered
	/// <paramref name="capacity"/> writes. A value of <c>0</c> keeps the
	/// recorder unbounded (the historical default).
	/// </summary>
	public RecordingOplBus(int capacity) {
		if (capacity < 0) {
			throw new ArgumentOutOfRangeException(nameof(capacity),
				"Capacity must be non-negative; pass 0 for unbounded.");
		}
		_capacity = capacity;
		_writes = capacity > 0 ? new List<OplWrite>(capacity) : new List<OplWrite>();
	}

	/// <summary>Read-only view of every recorded write, in insertion order.</summary>
	public IReadOnlyList<OplWrite> Writes => _writes;

	/// <summary>
	/// Cap on retained writes (<c>0</c> = unbounded). Older entries are
	/// dropped once <see cref="Writes"/>.Count reaches this value.
	/// </summary>
	public int Capacity => _capacity;

	/// <summary>
	/// Number of writes that were evicted because the bounded buffer was
	/// full. Always <c>0</c> for unbounded recorders.
	/// </summary>
	public long DroppedCount => _droppedCount;

	/// <inheritdoc />
	public void WriteRegister(int chip, byte register, byte value) {
		if (chip is not (0 or 1)) {
			throw new ArgumentOutOfRangeException(nameof(chip),
				"OPL3 chip selector must be 0 (primary) or 1 (secondary).");
		}
		if (_capacity > 0 && _writes.Count == _capacity) {
			_writes.RemoveAt(0);
			_droppedCount++;
		}
		_writes.Add(new OplWrite(chip, register, value));
	}

	/// <summary>Clears the recorded write history and the dropped counter.</summary>
	public void Reset() {
		_writes.Clear();
		_droppedCount = 0;
	}
}