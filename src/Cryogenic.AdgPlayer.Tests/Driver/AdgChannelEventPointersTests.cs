namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgChannelEventPointers"/>.
/// </summary>
public sealed class AdgChannelEventPointersTests {
	/// <summary>The pointer table holds 18 channel slots.</summary>
	[Fact]
	public void ChannelCount_IsEighteen() {
		// Arrange
		// Act
		int count = AdgChannelEventPointers.ChannelCount;

		// Assert
		Assert.Equal(18, count);
	}

	/// <summary>All event pointers are zero by default.</summary>
	[Fact]
	public void Default_AllPointersAreZero() {
		// Arrange
		AdgChannelEventPointers pointers = new();

		// Act
		// Assert
		for (int i = 0; i < AdgChannelEventPointers.ChannelCount; i++) {
			Assert.Equal(0, pointers.Get(i));
		}
	}

	/// <summary><c>Set</c> writes the pointer slot.</summary>
	[Fact]
	public void Set_StoresPointerAtIndex() {
		// Arrange
		AdgChannelEventPointers pointers = new();

		// Act
		pointers.Set(7, 0xCAFE);

		// Assert
		Assert.Equal(0xCAFE, pointers.Get(7));
	}

	/// <summary>
	/// <c>Advance</c> adds 2 to the pointer (matches <c>add SI,2</c>
	/// after consuming a 16-bit event word at dnadg:0772).
	/// </summary>
	[Fact]
	public void Advance_IncreasesPointerByTwo() {
		// Arrange
		AdgChannelEventPointers pointers = new();
		pointers.Set(2, 0x1000);

		// Act
		ushort newValue = pointers.Advance(2);

		// Assert
		Assert.Equal(0x1002, newValue);
		Assert.Equal(0x1002, pointers.Get(2));
	}

	/// <summary><c>Advance</c> wraps modulo 2^16 like the 8086 <c>add</c>.</summary>
	[Fact]
	public void Advance_WrapsOnUshortOverflow() {
		// Arrange
		AdgChannelEventPointers pointers = new();
		pointers.Set(0, 0xFFFF);

		// Act
		ushort newValue = pointers.Advance(0);

		// Assert
		Assert.Equal(0x0001, newValue);
	}

	/// <summary><c>Reset</c> clears every pointer slot.</summary>
	[Fact]
	public void Reset_ClearsAllPointers() {
		// Arrange
		AdgChannelEventPointers pointers = new();
		for (int i = 0; i < AdgChannelEventPointers.ChannelCount; i++) {
			pointers.Set(i, (ushort)(0x1000 + i));
		}

		// Act
		pointers.Reset();

		// Assert
		for (int i = 0; i < AdgChannelEventPointers.ChannelCount; i++) {
			Assert.Equal(0, pointers.Get(i));
		}
	}
}