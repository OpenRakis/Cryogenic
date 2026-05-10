namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgPitchBendEventDecoder"/>.
/// </summary>
public sealed class AdgPitchBendEventDecoderTests {
	/// <summary>
	/// The decoder mirrors <c>mov AX,Make16(Hi8(eventWord),Hi8(eventWord))</c>
	/// at dnadg:0D86 — it duplicates the high byte of the event
	/// word into both bytes of the bend payload.
	/// </summary>
	[Theory]
	[InlineData(0x0000, 0x00)]
	[InlineData(0x4000, 0x40)]
	[InlineData(0x80FF, 0x80)]
	[InlineData(0xCAFE, 0xCA)]
	public void Decode_DuplicatesHighByte(int eventWord, int expectedByte) {
		// Arrange
		// Act
		AdgPitchBendEvent bend = AdgPitchBendEventDecoder.Decode((ushort)eventWord);

		// Assert
		Assert.Equal((byte)expectedByte, bend.HighByte);
		Assert.Equal((byte)expectedByte, bend.LowByte);
		Assert.Equal((ushort)((expectedByte << 8) | expectedByte), bend.Payload);
	}

	/// <summary>The default event yields a zeroed bend payload.</summary>
	[Fact]
	public void DefaultStruct_HasZeroBytes() {
		// Arrange
		AdgPitchBendEvent bend = default;

		// Act
		// Assert
		Assert.Equal(0, bend.HighByte);
		Assert.Equal(0, bend.LowByte);
		Assert.Equal(0, bend.Payload);
	}
}