namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Result of a surround-mask update computation.
/// </summary>
/// <param name="ShouldEmit">
/// True when the caller must persist <paramref name="NewMask"/> and
/// write it to the secondary chip's SecondaryControl register; false
/// when one of the original bypass conditions short-circuited the
/// update.
/// </param>
/// <param name="NewMask">
/// The updated surround-mask byte. Equal to the supplied current mask
/// when <paramref name="ShouldEmit"/> is false.
/// </param>
public readonly record struct AdgSurroundMaskUpdate(bool ShouldEmit, byte NewMask);

/// <summary>
/// Pure decoder for the surround-mask update at the tail of
/// <c>AdgWriteInstrumentPatch_0F95</c>. Computes which surround bit a
/// patch's secondary route maps to, clears that bit in the current
/// mask, and reports whether the secondary-control register write must
/// be emitted. No side effects, no I/O.
/// </summary>
public static class AdgSurroundMaskUpdater {
	private const byte SkipUpdateBit = 0x10;
	private const byte LowIndexMask = 0x03;
	private const byte HighGroupBit = 0x80;
	private const int HighGroupOffset = 3;
	private const byte PatchTypeFour = 0x04;

	/// <summary>
	/// Computes the new surround mask after applying one channel's
	/// secondary-route descriptor.
	/// </summary>
	public static AdgSurroundMaskUpdate Compute(byte secondaryRoute,
		byte patchTypeByte, byte currentMask) {
		if ((secondaryRoute & SkipUpdateBit) != 0) {
			return new AdgSurroundMaskUpdate(false, currentMask);
		}

		int bitIndex = secondaryRoute & LowIndexMask;
		if ((secondaryRoute & HighGroupBit) != 0) {
			bitIndex += HighGroupOffset;
		}

		byte surroundBit = (byte)(1 << bitIndex);

		if (patchTypeByte == PatchTypeFour) {
			return new AdgSurroundMaskUpdate(false, currentMask);
		}

		byte newMask = (byte)(currentMask & (byte)~surroundBit);
		return new AdgSurroundMaskUpdate(true, newMask);
	}
}