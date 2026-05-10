namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgChannelEventReader"/>.
/// </summary>
public sealed class AdgChannelEventReaderTests {
	/// <summary>
	/// When the channel pointer is zero the reader reports
	/// end-of-stream (matches <c>or SI,SI / je</c> at dnadg:0772).
	/// </summary>
	[Fact]
	public void TryReadNext_ZeroPointer_ReturnsFalse() {
		// Arrange
		AdgChannelEventPointers pointers = new();
		InMemoryAdgEventStream stream = new();
		AdgChannelEventReader reader = new(pointers, stream, eventSegment: 0x1234);

		// Act
		bool ok = reader.TryReadNext(channelIndex: 0, out ushort eventWord);

		// Assert
		Assert.False(ok);
		Assert.Equal(0, eventWord);
	}

	/// <summary>
	/// Reading a non-zero pointer returns the word at <c>ES:[SI]</c>
	/// and advances the pointer by 2 (mirrors dnadg:0778-0772).
	/// </summary>
	[Fact]
	public void TryReadNext_NonZero_ReturnsWordAndAdvancesPointer() {
		// Arrange
		AdgChannelEventPointers pointers = new();
		InMemoryAdgEventStream stream = new();
		ushort eventSegment = 0x1234;
		pointers.Set(2, 0x0040);
		stream.Write(eventSegment, 0x0040, 0xCAFE);
		AdgChannelEventReader reader = new(pointers, stream, eventSegment);

		// Act
		bool ok = reader.TryReadNext(channelIndex: 2, out ushort eventWord);

		// Assert
		Assert.True(ok);
		Assert.Equal(0xCAFE, eventWord);
		Assert.Equal(0x0042, pointers.Get(2));
	}

	/// <summary>
	/// Sequential reads walk the stream, advancing the pointer by 2
	/// each time, and return the words in order.
	/// </summary>
	[Fact]
	public void TryReadNext_SequentialReads_WalkStreamForward() {
		// Arrange
		AdgChannelEventPointers pointers = new();
		InMemoryAdgEventStream stream = new();
		ushort segment = 0x4000;
		pointers.Set(7, 0x0010);
		stream.Write(segment, 0x0010, 0x1111);
		stream.Write(segment, 0x0012, 0x2222);
		stream.Write(segment, 0x0014, 0x3333);
		AdgChannelEventReader reader = new(pointers, stream, segment);

		// Act
		reader.TryReadNext(7, out ushort first);
		reader.TryReadNext(7, out ushort second);
		reader.TryReadNext(7, out ushort third);

		// Assert
		Assert.Equal(0x1111, first);
		Assert.Equal(0x2222, second);
		Assert.Equal(0x3333, third);
		Assert.Equal(0x0016, pointers.Get(7));
	}
}