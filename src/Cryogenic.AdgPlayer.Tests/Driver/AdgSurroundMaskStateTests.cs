namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 23a — Mutable holder for the global AdLib Gold surround mask
/// (<c>AdgSurroundMaskOffset</c>). Single-byte state with explicit
/// reset, read and assign accessors so the orchestrator never touches
/// the byte directly.
/// </summary>
public sealed class AdgSurroundMaskStateTests {
	[Fact]
	public void DefaultMask_IsAllOnes() {
		// Arrange + Act
		AdgSurroundMaskState state = new();

		// Assert — the original driver initializes the surround mask to
		// 0xFF (all surround groups enabled).
		Assert.Equal((byte)0xFF, state.Mask);
	}

	[Fact]
	public void SetMask_StoresExactValue() {
		// Arrange
		AdgSurroundMaskState state = new();

		// Act
		state.SetMask(0x3F);

		// Assert
		Assert.Equal((byte)0x3F, state.Mask);
	}

	[Fact]
	public void Reset_RestoresDefault() {
		// Arrange
		AdgSurroundMaskState state = new();
		state.SetMask(0x00);

		// Act
		state.Reset();

		// Assert
		Assert.Equal((byte)0xFF, state.Mask);
	}
}