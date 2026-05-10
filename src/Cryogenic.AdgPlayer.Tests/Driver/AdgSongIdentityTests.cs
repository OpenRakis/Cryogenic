namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Phase 27b — Triplet of identity words read from a song's three
/// addressing planes (offset +0, +0x4000, +0x8000) and compared
/// against the cached identity to detect song re-loads. Mirrors
/// <c>AdgIsSongIdentityStillValid_0730</c> +
/// <c>AdgSongIdentityMagic1/2/3Offset</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public sealed class AdgSongIdentityTests {
	[Fact]
	public void Equality_WhenAllThreeWordsMatch() {
		// Arrange
		AdgSongIdentity a = new(0x1111, 0x2222, 0x3333);
		AdgSongIdentity b = new(0x1111, 0x2222, 0x3333);

		// Act + Assert
		Assert.Equal(a, b);
		Assert.True(a.Matches(b));
	}

	[Fact]
	public void Inequality_WhenAnyWordDiffers() {
		// Arrange
		AdgSongIdentity baseline = new(0x1111, 0x2222, 0x3333);

		// Assert
		Assert.False(baseline.Matches(new AdgSongIdentity(0xFFFF, 0x2222, 0x3333)));
		Assert.False(baseline.Matches(new AdgSongIdentity(0x1111, 0xFFFF, 0x3333)));
		Assert.False(baseline.Matches(new AdgSongIdentity(0x1111, 0x2222, 0xFFFF)));
	}

	[Fact]
	public void Empty_IsAllZero() {
		// Act
		AdgSongIdentity empty = AdgSongIdentity.Empty;

		// Assert
		Assert.Equal(new AdgSongIdentity(0, 0, 0), empty);
	}
}