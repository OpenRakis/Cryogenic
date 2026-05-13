namespace Cryogenic.AdgPlayer.Mcp;

using Cryogenic.AdgPlayer.Opl;

using System;
using System.Collections.Generic;

/// <summary>A single recorded OPL register write with its session-relative index.</summary>
public readonly record struct OplWriteRecord(int Index, int Chip, byte Register, byte Value);

/// <summary>
/// Ring-buffered recorder for OPL register writes. Stores up to
/// <c>capacity</c> writes and exposes a monotonically-increasing
/// <see cref="TotalCount"/> so MCP clients can poll for new writes
/// without losing track when the ring wraps.
/// </summary>
public sealed class OplWriteRecorder : IOplBus {
	private readonly OplWriteRecord[] _buffer;
	private readonly int _capacity;
	private int _total;

	/// <summary>Builds a recorder with the supplied ring capacity.</summary>
	public OplWriteRecorder(int capacity) {
		if (capacity <= 0) {
			throw new ArgumentOutOfRangeException(nameof(capacity));
		}
		_capacity = capacity;
		_buffer = new OplWriteRecord[capacity];
	}

	/// <summary>Total number of writes accepted since construction.</summary>
	public int TotalCount => _total;

	/// <inheritdoc />
	public void WriteRegister(int chip, byte register, byte value) {
		int slot = _total % _capacity;
		_buffer[slot] = new OplWriteRecord(_total, chip, register, value);
		_total++;
	}

	/// <summary>
	/// Returns all writes with <c>Index &gt;= sinceIndex</c>, clamped
	/// to the ring capacity. When <paramref name="sinceIndex"/> is
	/// older than the oldest entry still in the ring, only the
	/// retained tail is returned.
	/// </summary>
	public IReadOnlyList<OplWriteRecord> GetSince(int sinceIndex) {
		if (sinceIndex < 0) {
			sinceIndex = 0;
		}
		int oldest = Math.Max(0, _total - _capacity);
		int from = Math.Max(sinceIndex, oldest);
		int count = _total - from;
		if (count <= 0) {
			return Array.Empty<OplWriteRecord>();
		}
		OplWriteRecord[] result = new OplWriteRecord[count];
		for (int i = 0; i < count; i++) {
			int idx = (from + i) % _capacity;
			result[i] = _buffer[idx];
		}
		return result;
	}
}
