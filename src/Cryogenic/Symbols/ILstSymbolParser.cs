namespace Cryogenic.Symbols;

using System.Collections.Generic;

/// <summary>
/// Parses DNCDPRG.lst disassembly listing lines into <see cref="LstSymbol"/> entries.
/// </summary>
/// <remarks>
/// Implementations must handle the IDA-style listing format used by the Dune CD project.
/// Lines that do not define a label (instructions, comments, blank lines) are silently skipped.
/// </remarks>
public interface ILstSymbolParser {
	/// <summary>
	/// Parses the supplied lines from a .lst file and returns all symbol entries found.
	/// </summary>
	/// <param name="lines">Lines of the .lst file to parse.</param>
	/// <returns>
	/// All symbols discovered in the listing, in the order they appear.
	/// Never <c>null</c>; returns an empty list when no symbols are found.
	/// </returns>
	IReadOnlyList<LstSymbol> Parse(IEnumerable<string> lines);
}