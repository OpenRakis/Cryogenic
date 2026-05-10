namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Triplet of identity words read from a song's three addressing
/// planes (offset +0, +0x4000, +0x8000) and used to detect song
/// re-loads. Mirrors the cached identity at
/// <c>AdgSongIdentityCacheOffset</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
/// <param name="Word0">Word at the song base offset (+0).</param>
/// <param name="Word1">Word at the second plane offset (+0x4000).</param>
/// <param name="Word2">Word at the third plane offset (+0x8000).</param>
public readonly record struct AdgSongIdentity(ushort Word0, ushort Word1, ushort Word2) {
	/// <summary>Identity with all three words equal to zero.</summary>
	public static AdgSongIdentity Empty { get; } = new(0, 0, 0);

	/// <summary>
	/// Returns <c>true</c> when every word of <paramref name="other"/>
	/// matches the corresponding word in this identity.
	/// </summary>
	public bool Matches(AdgSongIdentity other) {
		return Word0 == other.Word0
			&& Word1 == other.Word1
			&& Word2 == other.Word2;
	}
}