namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 7 — channel routing.
/// <see cref="AdgChannelRouter"/> is the pure transformation that maps
/// (OPL register base, channel route byte) → (chip, routed register).
/// Extracted from <c>AdgWriteRoutedOplRegister</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>:
///   if route &amp; 0x80 → secondary chip (1), register = base + (route XOR 0x80)
///   else                → primary chip (0),    register = base + route
/// </summary>
public sealed class AdgChannelRouterTests {
	[Fact]
	public void Route_PrimaryChip_AddsRouteToBase() {
		// Arrange — runtime route table entry 9 = 0x80 (chip1 ch0)
		// but here pick a primary value: route 0x06 routes A0+6 to chip 0.
		const byte registerBase = 0xA0;
		const byte route = 0x06;

		// Act
		AdgRoutedRegister routed = AdgChannelRouter.Route(registerBase, route);

		// Assert
		Assert.Equal(0, routed.Chip);
		Assert.Equal((byte)0xA6, routed.Register);
	}

	[Fact]
	public void Route_SecondaryChip_StripsSignBitFromRegister() {
		// Arrange — route 0x88 = secondary chip, channel 8.
		// Expected routed register = 0xB0 + 0x88 XOR 0x80 = 0xB0 + 0x08 = 0xB8.
		const byte registerBase = 0xB0;
		const byte route = 0x88;

		// Act
		AdgRoutedRegister routed = AdgChannelRouter.Route(registerBase, route);

		// Assert
		Assert.Equal(1, routed.Chip);
		Assert.Equal((byte)0xB8, routed.Register);
	}

	[Fact]
	public void Route_ZeroRoute_StaysOnPrimaryWithBaseRegister() {
		// Arrange
		const byte registerBase = 0x40;
		const byte route = 0x00;

		// Act
		AdgRoutedRegister routed = AdgChannelRouter.Route(registerBase, route);

		// Assert
		Assert.Equal(0, routed.Chip);
		Assert.Equal((byte)0x40, routed.Register);
	}

	[Fact]
	public void Route_HighestSecondaryRoute_WrapsRegisterCorrectly() {
		// Arrange — route 0xFF on register base 0xA0:
		//   routed = 0xA0 + 0xFF = 0x9F (after wrap), then XOR 0x80 = 0x1F.
		// Equivalent to base + (route - 0x80) modulo 256 = 0xA0 + 0x7F = 0x11F → 0x1F.
		const byte registerBase = 0xA0;
		const byte route = 0xFF;

		// Act
		AdgRoutedRegister routed = AdgChannelRouter.Route(registerBase, route);

		// Assert
		Assert.Equal(1, routed.Chip);
		Assert.Equal((byte)0x1F, routed.Register);
	}
}