namespace Cryogenic.OverrideLogic;

/// <summary>
/// Pure, stateless helper methods encoding the data-structure manipulation logic of specific
/// game assembly routines. These methods are independently testable without a live Spice86
/// Machine instance and are called from the corresponding override methods.
/// </summary>
public static class DataStructureLogic {

	/// <summary>
	/// Adds <paramref name="baseOffset"/> to every entry in a size-prefixed word table.
	/// </summary>
	/// <param name="words">
	/// The word table to adjust in place. <c>words[0]</c> encodes the total byte size of the
	/// adjustable region; <c>count = words[0] / 2</c> words are adjusted (including
	/// <c>words[0]</c> itself). Words beyond <c>count</c> are not modified.
	/// </param>
	/// <param name="baseOffset">Value added to each adjusted word.</param>
	/// <remarks>
	/// Implements the body of <c>adjust_sub_resource_pointers</c> (seg000:0098), which
	/// is called during resource loading to relocate sub-resource offset tables relative
	/// to their container base address. The original x86 STOSW loop at seg000:009F
	/// reads <c>count</c> from the first word before modifying it, so all <c>count</c>
	/// words (including the count word itself) receive the base offset addition.
	/// Confirmed executed in <c>dump/spice86dumpExecutionFlow.json</c>.
	/// </remarks>
	public static void AdjustOffsetTable(ushort[] words, ushort baseOffset) {
		if (words.Length == 0) {
			return;
		}
		int count = words[0] / 2;
		for (int i = 0; i < count && i < words.Length; i++) {
			words[i] = (ushort)(words[i] + baseOffset);
		}
	}
}