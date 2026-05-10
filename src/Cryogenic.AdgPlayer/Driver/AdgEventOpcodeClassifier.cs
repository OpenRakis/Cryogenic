namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure helper that classifies a 16-bit channel-event word into one
/// of 8 jump-table slots. Mirrors the three instructions at
/// dnadg:0784:
/// <code>
/// and BX,0x0070
/// shr BX
/// shr BX
/// shr BX
/// </code>
/// The resulting BX is then used as a word index into the jump
/// table at <c>DS:[BX+0x012E]</c>. The original <c>shr 3</c>
/// folds in the word-multiplication of the table walk; this pure
/// helper instead returns the human-readable 0..7 slot index by
/// shifting one extra position. Callers that need the byte offset
/// into the jump table multiply by 2.
/// </summary>
public static class AdgEventOpcodeClassifier {
	/// <summary>Number of valid event-opcode slots (0..7).</summary>
	public const int SlotCount = 8;

	private const ushort OpcodeMask = 0x0070;
	private const int OpcodeShift = 4;

	/// <summary>
	/// Returns the 0..7 jump-table slot for the supplied event word.
	/// </summary>
	public static int Classify(ushort eventWord) {
		return (eventWord & OpcodeMask) >> OpcodeShift;
	}
}