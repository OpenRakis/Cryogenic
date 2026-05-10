namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>Unit tests for <see cref="AdgNoteEventTransposer"/>.</summary>
public sealed class AdgNoteEventTransposerTests {
	/// <summary>Transposition mirrors <c>add AL,[DI+0x91]</c> with 8-bit wrap.</summary>
	[Theory]
	[InlineData(0x48, 0x00, 0x48)]
	[InlineData(0x48, 0x0C, 0x54)]
	[InlineData(0xF0, 0x20, 0x10)] // wrap
	[InlineData(0x60, 0xFF, 0x5F)] // signed-down via wrap
	public void Transpose_AddsTransposeWithEightBitWrap(int note, int transpose, int expected) {
		// Arrange
		// Act
		byte result = AdgNoteEventTransposer.Transpose((byte)note, (byte)transpose);

		// Assert
		Assert.Equal((byte)expected, result);
	}
}