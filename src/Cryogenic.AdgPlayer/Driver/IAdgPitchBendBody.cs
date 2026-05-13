namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Receiver for "advance pitch bend" requests emitted by the
/// scheduler-side vibrato path
/// (<c>AdgAdvancePitchModulation_07AD</c> at dnadg:07AD). The body
/// itself — <c>AdgPitchBendBody_0D8B</c> — is a substantial OPL
/// emit chain that requires the frequency / fractions tables and
/// is ported in a separate cycle (B4.5b). Wiring the framing
/// against an interface keeps the dispatch faithful to the oracle
/// while letting the body be added without churning callers.
/// </summary>
public interface IAdgPitchBendBody {
	/// <summary>
	/// Emits the OPL register sequence for the supplied bend word.
	/// </summary>
	/// <param name="channelIndex">
	/// 0-based channel index (DX in the oracle, computed as
	/// <c>(DI - 0x01E2) &gt;&gt; 1</c>).
	/// </param>
	/// <param name="bendWord">
	/// The advanced accumulator word (low byte = updated value,
	/// high byte = step) passed to <c>AdgPitchBendBody_0D8B</c>.
	/// </param>
	void Emit(int channelIndex, ushort bendWord);
}

/// <summary>
/// No-op pitch-bend body. Used as the default until the real port
/// of <c>AdgPitchBendBody_0D8B</c> lands in cycle B4.5b. Keeps the
/// scheduler framing observable and testable without claiming any
/// OPL emission.
/// </summary>
public sealed class NullAdgPitchBendBody : IAdgPitchBendBody {
	/// <summary>Singleton instance.</summary>
	public static readonly NullAdgPitchBendBody Instance = new();

	private NullAdgPitchBendBody() { }

	/// <summary>No-op.</summary>
	public void Emit(int channelIndex, ushort bendWord) {
	}
}