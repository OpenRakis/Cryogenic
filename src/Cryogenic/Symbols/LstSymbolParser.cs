namespace Cryogenic.Symbols;

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/// <summary>
/// Parses DNCDPRG.lst IDA-style listing lines to extract labeled symbol definitions.
/// </summary>
/// <remarks>
/// <para>
/// The expected line format is:
/// <c>seg000:XXXX  symbolName:  ; optional comment</c>
/// </para>
/// <para>
/// Lines that do not match this pattern (instructions, blank lines, semicolon comments,
/// and data-byte declarations) are silently skipped.
/// </para>
/// <para>
/// A symbol is classified as an auto-label when its name begins with "loc_" or "sub_",
/// which are IDA-generated prefixes for unlabeled jump targets and subroutines.
/// </para>
/// </remarks>
public sealed class LstSymbolParser : ILstSymbolParser {
	/// <summary>
	/// Matches lines of the form: <c>seg000:00B0  initialize_resources:  ; CODE XREF: ...</c>
	/// Named groups: segment, offset, name.
	/// The two-space gap between offset and name is mandatory in the IDA listing format.
	/// </summary>
	private static readonly Regex SymbolLinePattern = new(
		@"^(?<segment>seg\d+):(?<offset>[0-9a-fA-F]+)  (?<name>[a-zA-Z_][a-zA-Z0-9_]*):\s*(?:;.*)?$",
		RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture,
		TimeSpan.FromMilliseconds(100)
	);

	/// <inheritdoc />
	public IReadOnlyList<LstSymbol> Parse(IEnumerable<string> lines) {
		List<LstSymbol> symbols = new();
		foreach (string line in lines) {
			Match match = SymbolLinePattern.Match(line.TrimEnd('\r', '\n', ' '));
			if (!match.Success) {
				continue;
			}

			string segment = match.Groups["segment"].Value;
			ushort offset = Convert.ToUInt16(match.Groups["offset"].Value, 16);
			string name = match.Groups["name"].Value;
			bool isAutoLabel = name.StartsWith("loc_", StringComparison.Ordinal)
							|| name.StartsWith("sub_", StringComparison.Ordinal);

			symbols.Add(new LstSymbol {
				Segment = segment,
				Offset = offset,
				Name = name,
				IsAutoLabel = isAutoLabel
			});
		}

		return symbols;
	}
}