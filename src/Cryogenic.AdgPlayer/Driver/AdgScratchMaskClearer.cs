namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure port of <c>AdgClearScratchMask_0ACD</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>. Called by NoteOff
/// (and the full <c>AdgEndOfTrack_0AF5</c> body) after a key-off has
/// been emitted — it conditionally peels per-channel state-scratch
/// bits out of the global fade-scratch cells when the channel is
/// "long-waiting" (wait counter ≥ 0x0030) and the next event byte is
/// the 0xFF terminator or a value with high nibble 0xC0.
/// </summary>
/// <remarks>
/// Verbatim oracle:
/// <code>
/// if (AdgWord(DI) &lt; 0x0030) return;
/// byte nextEventByte = SegByte(ES, SI);
/// if (nextEventByte != 0xFF &amp;&amp; (nextEventByte &amp; 0xF0) != 0xC0) return;
/// ushort previousScratch = AdgWord(DI + AdgChannelStateScratchOffset);
/// AdgWordSet(DI + AdgChannelStateScratchOffset, 0);
/// ushort scratchMask = (ushort)~previousScratch;
/// if ((scratchMask &amp; 0x8000) == 0) {
///     AdgWordSet(AdgFadeScratch2Offset, AdgWord(AdgFadeScratch2Offset) &amp; scratchMask);
///     return;
/// }
/// AdgWordSet(AdgFadeScratchOffset, AdgWord(AdgFadeScratchOffset) &amp; scratchMask);
/// </code>
/// </remarks>
public static class AdgScratchMaskClearer {
	/// <summary>
	/// Threshold below which the helper exits early. Mirrors the
	/// <c>cmp word ptr [DI],0x0030</c> at dnadg:0ACD.
	/// </summary>
	public const ushort LongWaitThreshold = 0x0030;

	/// <summary>0xFF terminator byte (<c>AdgImmediate.TwoFiftyFive</c>).</summary>
	public const byte TerminatorByte = 0xFF;

	/// <summary>High-nibble mask used to qualify the "next event byte" gate.</summary>
	public const byte HighNibbleMask = 0xF0;

	/// <summary>Required value of the high nibble for the gate to pass.</summary>
	public const byte HighNibbleMatch = 0xC0;

	/// <summary>
	/// Performs the conditional scratch-mask clear for the supplied
	/// channel. Mutates <paramref name="channelScratch"/> and
	/// <paramref name="fadeScratch"/> in place; no-op when the
	/// preconditions are not met.
	/// </summary>
	public static void Clear(AdgChannelStateScratch channelScratch,
		AdgFadeScratchState fadeScratch, int channelIndex,
		ushort waitCounter, byte nextEventByte) {
		ArgumentNullException.ThrowIfNull(channelScratch);
		ArgumentNullException.ThrowIfNull(fadeScratch);

		if (waitCounter < LongWaitThreshold) {
			return;
		}
		if (nextEventByte != TerminatorByte
			&& (nextEventByte & HighNibbleMask) != HighNibbleMatch) {
			return;
		}

		ushort previousScratch = channelScratch.Get(channelIndex);
		channelScratch.Set(channelIndex, 0);
		ushort scratchMask = (ushort)~previousScratch;
		if ((scratchMask & 0x8000) == 0) {
			fadeScratch.SetSecondary((ushort)(fadeScratch.Secondary & scratchMask));
			return;
		}
		fadeScratch.SetPrimary((ushort)(fadeScratch.Primary & scratchMask));
	}
}