namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure helper that mirrors the <c>add BX,inst*0x28</c> address math in
/// <c>AdgProgramChange_0831</c>: each instrument record in the song
/// patch table occupies <see cref="PatchStride"/> bytes.
/// </summary>
public static class AdgPatchOffsetCalculator {
	/// <summary>Size in bytes of an instrument patch record.</summary>
	public const ushort PatchStride = 0x28;

	/// <summary>
	/// Returns <c>(ushort)(tableBase + instrumentIndex * 0x28)</c> with
	/// native 16-bit wrap.
	/// </summary>
	public static ushort OffsetFor(ushort tableBase, byte instrumentIndex) {
		return (ushort)(tableBase + instrumentIndex * PatchStride);
	}
}