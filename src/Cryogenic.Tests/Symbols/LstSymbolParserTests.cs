namespace Cryogenic.Tests.Symbols;

using AwesomeAssertions;

using Cryogenic.Symbols;

using System.Collections.Generic;

/// <summary>
/// Unit tests for <see cref="LstSymbolParser"/>.
/// </summary>
public sealed class LstSymbolParserTests {
	/// <summary>Parsing an empty sequence returns an empty list.</summary>
	[Fact]
	public void Parse_EmptyInput_ReturnsEmpty() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse([]);

		// Assert
		result.Should().BeEmpty();
	}

	/// <summary>Semicolon-only comment lines are skipped.</summary>
	[Fact]
	public void Parse_CommentLinesOnly_ReturnsEmpty() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = [
			"; DNCDPRG.EXE",
			"; Project: cryo-dune-3.7-cd",
			"; Segment: seg000 (code)  00000..0f4b0",
			""
		];

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse(lines);

		// Assert
		result.Should().BeEmpty();
	}

	/// <summary>A plain instruction line without a label is skipped.</summary>
	[Fact]
	public void Parse_InstructionLineWithoutLabel_IsSkipped() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = [
			"seg000:0000                 mov     ax, 0dd1dh",
			"seg000:0003                 call    parse_command_line"
		];

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse(lines);

		// Assert
		result.Should().BeEmpty();
	}

	/// <summary>A labeled line without a comment produces a symbol with the correct fields.</summary>
	[Fact]
	public void Parse_LabeledLineNoComment_ProducesSymbolWithCorrectFields() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = ["seg000:021c  play_intro2:"];

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse(lines);

		// Assert
		result.Should().ContainSingle();
		LstSymbol sym = result[0];
		sym.Segment.Should().Be("seg000");
		sym.Offset.Should().Be(0x021C);
		sym.Name.Should().Be("play_intro2");
		sym.IsAutoLabel.Should().BeFalse();
	}

	/// <summary>A labeled line with a CODE XREF comment is parsed correctly.</summary>
	[Fact]
	public void Parse_LabeledLineWithCodeXref_ProducesSymbolIgnoringComment() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = ["seg000:003a  exit_with_error:                             ; CODE XREF: seg000:16f9, seg000:f08a"];

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse(lines);

		// Assert
		result.Should().ContainSingle();
		LstSymbol sym = result[0];
		sym.Name.Should().Be("exit_with_error");
		sym.Offset.Should().Be(0x003A);
		sym.IsAutoLabel.Should().BeFalse();
	}

	/// <summary>A loc_-prefixed label is marked as an auto-label.</summary>
	[Fact]
	public void Parse_LocPrefixedLabel_IsMarkedAsAutoLabel() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = ["seg000:0056  loc_00056:                                   ; CODE XREF: seg000:004c"];

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse(lines);

		// Assert
		result.Should().ContainSingle();
		result[0].IsAutoLabel.Should().BeTrue();
		result[0].Name.Should().Be("loc_00056");
	}

	/// <summary>A sub_-prefixed label is marked as an auto-label.</summary>
	[Fact]
	public void Parse_SubPrefixedLabel_IsMarkedAsAutoLabel() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = ["seg000:1234  sub_01234:"];

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse(lines);

		// Assert
		result.Should().ContainSingle();
		result[0].IsAutoLabel.Should().BeTrue();
	}

	/// <summary>A named symbol (not loc_ or sub_) is not marked as an auto-label.</summary>
	[Fact]
	public void Parse_MeaningfulName_IsNotAutoLabel() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = ["seg000:0580  play_intro:                                  ; CODE XREF: seg000:000d"];

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse(lines);

		// Assert
		result.Should().ContainSingle();
		result[0].IsAutoLabel.Should().BeFalse();
	}

	/// <summary>Mixed lines produce only the labeled entries, in order.</summary>
	[Fact]
	public void Parse_MixedLines_ProducesOnlyLabeledEntriesInOrder() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = [
			"; comment",
			"seg000:0000  start:",
			"seg000:0000                 mov     ax, 0dd1dh",
			"seg000:0003                 call    parse_command_line",
			"seg000:003a  exit_with_error:                             ; CODE XREF: seg000:16f9",
			"seg000:0056  loc_00056:                                   ; CODE XREF: seg000:004c"
		];

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse(lines);

		// Assert
		result.Should().HaveCount(3);
		result.Select(s => s.Name).Should().Equal("start", "exit_with_error", "loc_00056");
	}

	/// <summary>The start symbol at offset 0x0000 is parsed correctly.</summary>
	[Fact]
	public void Parse_StartSymbolAtOffsetZero_ParsesCorrectly() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = ["seg000:0000  start:"];

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse(lines);

		// Assert
		result.Should().ContainSingle();
		result[0].Offset.Should().Be(0);
		result[0].Name.Should().Be("start");
	}

	/// <summary>Trailing whitespace on a line does not prevent parsing.</summary>
	[Fact]
	public void Parse_LineWithTrailingWhitespace_IsHandled() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = ["seg000:021c  play_intro2:   "];

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse(lines);

		// Assert
		result.Should().ContainSingle();
		result[0].Name.Should().Be("play_intro2");
	}

	/// <summary>A label with uppercase hex offset is parsed with the correct numeric value.</summary>
	[Fact]
	public void Parse_UppercaseHexOffset_ParsesCorrectValue() {
		// Arrange
		ILstSymbolParser parser = new LstSymbolParser();
		string[] lines = ["seg000:00B0  initialize_resources:                        ; CODE XREF: seg000:0009"];

		// Act
		IReadOnlyList<LstSymbol> result = parser.Parse(lines);

		// Assert
		result.Should().ContainSingle();
		result[0].Offset.Should().Be(0x00B0);
	}
}
