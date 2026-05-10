namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Abstraction over a 16-bit segment+offset memory read. Decouples
/// the per-channel event-stream walker from the concrete real-mode
/// memory backend (<c>ES:[SI]</c>) so it can be unit-tested with a
/// pure in-memory double.
/// </summary>
public interface IAdgEventStream {
	/// <summary>
	/// Reads the 16-bit little-endian word stored at
	/// <paramref name="segment"/>:<paramref name="offset"/>.
	/// </summary>
	ushort ReadWord(ushort segment, ushort offset);
}