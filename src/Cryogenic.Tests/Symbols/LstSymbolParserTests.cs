namespace Cryogenic.Tests.Symbols;

using Cryogenic.Symbols;

using System.Collections.Generic;

/// <summary>
/// Unit tests for <see cref="LstSymbolParser"/>.
/// </summary>
public sealed class LstSymbolParserTests {
	private readonly ILstSymbolParser _parser = new LstSymbolParser();

	/// <summary>Parsing an empty sequence returns an empty list.</summary>
	[Fact]
	public void Parse_EmptyInput_ReturnsEmpty() {
		IReadOnlyList<LstSymbol> result = _parser.Parse([]);
		Assert.Empty(result);
	}

	/// <summary>Semicolon-only comment lines are skipped.</summary>
	[Fact]
	public void Parse_CommentLinesOnly_ReturnsEmpty() {
		string[] lines = [
			"; DNCDPRG.EXE",
			"; Project: cryo-dune-3.7-cd",
			"; Segment: seg000 (code)  00000..0f4b0",
			""
		];
		IReadOnlyList<LstSymbol> result = _parser.Parse(lines);
		Assert.Empty(result);
	}

	/// <summary>A plain instruction line without a label is skipped.</summary>
	[Fact]
	public void Parse_InstructionLineWithoutLabel_IsSkipped() {
		string[] lines = [
			"seg000:0000                 mov     ax, 0dd1dh",
			"seg000:0003                 call    parse_command_line"
		];
		IReadOnlyList<LstSymbol> result = _parser.Parse(lines);
		Assert.Empty(result);
	}

	/// <summary>A labeled line without a comment produces a symbol with the correct fields.</summary>
	[Fact]
	public void Parse_LabeledLineNoComment_ProducesSymbolWithCorrectFields() {
		string[] lines = ["seg000:021c  play_intro2:"];
		IReadOnlyList<LstSymbol> result = _parser.Parse(lines);
		Assert.Single(result);
		LstSymbol sym = result[0];
		Assert.Equal("seg000", sym.Segment);
		Assert.Equal(0x021C, sym.Offset);
		Assert.Equal("play_intro2", sym.Name);
		Assert.False(sym.IsAutoLabel);
	}

	/// <summary>A labeled line with a CODE XREF comment is parsed correctly.</summary>
	[Fact]
	public void Parse_LabeledLineWithCodeXref_ProducesSymbolIgnoringComment() {
		string[] lines = ["seg000:003a  exit_with_error:                             ; CODE XREF: seg000:16f9, seg000:f08a"];
		IReadOnlyList<LstSymbol> result = _parser.Parse(lines);
		Assert.Single(result);
		LstSymbol sym = result[0];
		Assert.Equal("exit_with_error", sym.Name);
		Assert.Equal(0x003A, sym.Offset);
		Assert.False(sym.IsAutoLabel);
	}

	/// <summary>A loc_-prefixed label is marked as an auto-label.</summary>
	[Fact]
	public void Parse_LocPrefixedLabel_IsMarkedAsAutoLabel() {
		string[] lines = ["seg000:0056  loc_00056:                                   ; CODE XREF: seg000:004c"];
		IReadOnlyList<LstSymbol> result = _parser.Parse(lines);
		Assert.Single(result);
		Assert.True(result[0].IsAutoLabel);
		Assert.Equal("loc_00056", result[0].Name);
	}

	/// <summary>A sub_-prefixed label is marked as an auto-label.</summary>
	[Fact]
	public void Parse_SubPrefixedLabel_IsMarkedAsAutoLabel() {
		string[] lines = ["seg000:1234  sub_01234:"];
		IReadOnlyList<LstSymbol> result = _parser.Parse(lines);
		Assert.Single(result);
		Assert.True(result[0].IsAutoLabel);
	}

	/// <summary>A named symbol (not loc_ or sub_) is not marked as an auto-label.</summary>
	[Fact]
	public void Parse_MeaningfulName_IsNotAutoLabel() {
		string[] lines = ["seg000:0580  play_intro:                                  ; CODE XREF: seg000:000d"];
		IReadOnlyList<LstSymbol> result = _parser.Parse(lines);
		Assert.Single(result);
		Assert.False(result[0].IsAutoLabel);
	}

	/// <summary>Mixed lines produce only the labeled entries, in order.</summary>
	[Fact]
	public void Parse_MixedLines_ProducesOnlyLabeledEntriesInOrder() {
		string[] lines = [
			"; comment",
			"seg000:0000  start:",
			"seg000:0000                 mov     ax, 0dd1dh",
			"seg000:0003                 call    parse_command_line",
			"seg000:003a  exit_with_error:                             ; CODE XREF: seg000:16f9",
			"seg000:0056  loc_00056:                                   ; CODE XREF: seg000:004c"
		];
		IReadOnlyList<LstSymbol> result = _parser.Parse(lines);
		Assert.Equal(3, result.Count);
		Assert.Equal("start", result[0].Name);
		Assert.Equal("exit_with_error", result[1].Name);
		Assert.Equal("loc_00056", result[2].Name);
	}

	/// <summary>The start symbol at offset 0x0000 is parsed correctly.</summary>
	[Fact]
	public void Parse_StartSymbolAtOffsetZero_ParsesCorrectly() {
		string[] lines = ["seg000:0000  start:"];
		IReadOnlyList<LstSymbol> result = _parser.Parse(lines);
		Assert.Single(result);
		Assert.Equal(0, result[0].Offset);
		Assert.Equal("start", result[0].Name);
	}

	/// <summary>Trailing whitespace on a line does not prevent parsing.</summary>
	[Fact]
	public void Parse_LineWithTrailingWhitespace_IsHandled() {
		string[] lines = ["seg000:021c  play_intro2:   "];
		IReadOnlyList<LstSymbol> result = _parser.Parse(lines);
		Assert.Single(result);
		Assert.Equal("play_intro2", result[0].Name);
	}

	/// <summary>A label with uppercase hex offset is parsed with the correct numeric value.</summary>
	[Fact]
	public void Parse_UppercaseHexOffset_ParsesCorrectValue() {
		string[] lines = ["seg000:00B0  initialize_resources:                        ; CODE XREF: seg000:0009"];
		IReadOnlyList<LstSymbol> result = _parser.Parse(lines);
		Assert.Single(result);
		Assert.Equal(0x00B0, result[0].Offset);
	}
}
