namespace Cryogenic.AdgPlayer.Tests.Opl;

using Cryogenic.AdgPlayer.Opl;

using Xunit;

/// <summary>Tests for <see cref="NullOplBus"/>.</summary>
public sealed class NullOplBusTests {
	/// <summary>Writes are silently discarded with no side effect.</summary>
	[Fact]
	public void WriteRegister_SilentlyDiscards() {
		// Arrange
		NullOplBus bus = new();

		// Act
		bus.WriteRegister(0, 0xB0, 0x20);
		bus.WriteRegister(1, 0xA0, 0x55);

		// Assert — completing without exception is the contract.
		Assert.IsType<NullOplBus>(bus);
	}
}
