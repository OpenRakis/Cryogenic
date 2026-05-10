namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using System.Collections.Generic;

/// <summary>
/// In-memory <see cref="IAdgEventStream"/> double used by tests to
/// stand in for the real-mode segment lookup the driver performs at
/// <c>ES:[SI]</c>. Stores word values keyed by <c>(segment, offset)</c>.
/// </summary>
public sealed class InMemoryAdgEventStream : IAdgEventStream {
	private readonly Dictionary<(ushort, ushort), ushort> _words = new();

	/// <summary>Stores a word at the supplied segment-offset pair.</summary>
	public void Write(ushort segment, ushort offset, ushort value) {
		_words[(segment, offset)] = value;
	}

	/// <inheritdoc />
	public ushort ReadWord(ushort segment, ushort offset) {
		if (_words.TryGetValue((segment, offset), out ushort value)) {
			return value;
		}
		return 0;
	}
}