namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgChannelIndexResolver"/>.
/// </summary>
public sealed class AdgChannelIndexResolverTests {
	/// <summary>
	/// The resolver mirrors <c>mov DX,DI / sub DX,0x01E2 / shr DX,1</c>
	/// at dnadg:077A which converts a wait-counter table walking
	/// pointer back into a 0..17 channel index.
	/// </summary>
	[Theory]
	[InlineData(0x01E2, 0)]
	[InlineData(0x01E4, 1)]
	[InlineData(0x01E6, 2)]
	[InlineData(0x0204, 17)]
	public void FromWaitCounterPointer_ReturnsExpectedIndex(int pointer, int expected) {
		// Arrange
		// Act
		int channelIndex = AdgChannelIndexResolver.FromWaitCounterPointer((ushort)pointer);

		// Assert
		Assert.Equal(expected, channelIndex);
	}

	/// <summary>
	/// Pointers below the table base raise (sanity guard for porting
	/// callers).
	/// </summary>
	[Fact]
	public void FromWaitCounterPointer_BelowBase_Throws() {
		// Arrange
		// Act
		// Assert
		Assert.Throws<ArgumentOutOfRangeException>(
			() => AdgChannelIndexResolver.FromWaitCounterPointer(0x01E1));
	}

	/// <summary>Pointers past the last channel raise.</summary>
	[Fact]
	public void FromWaitCounterPointer_PastEnd_Throws() {
		// Arrange
		// Act
		// Assert
		Assert.Throws<ArgumentOutOfRangeException>(
			() => AdgChannelIndexResolver.FromWaitCounterPointer(0x0206));
	}

	/// <summary>Odd pointers are not aligned to the word table.</summary>
	[Fact]
	public void FromWaitCounterPointer_OddPointer_Throws() {
		// Arrange
		// Act
		// Assert
		Assert.Throws<ArgumentException>(
			() => AdgChannelIndexResolver.FromWaitCounterPointer(0x01E3));
	}
}