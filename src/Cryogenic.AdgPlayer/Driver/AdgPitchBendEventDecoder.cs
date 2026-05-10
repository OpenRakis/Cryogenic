namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Decoded pitch-bend payload. Both bytes carry the same 8-bit bend
/// magnitude — the original <c>Make16(Hi8(eventWord), Hi8(eventWord))</c>
/// at dnadg:0D86 duplicates the high byte of the event word into
/// AH and AL before <c>AdgPitchBendBody_0D8B</c>.
/// </summary>
/// <param name="HighByte">Bend magnitude (high byte).</param>
/// <param name="LowByte">Bend magnitude (low byte, equal to <see cref="HighByte"/>).</param>
public readonly record struct AdgPitchBendEvent(byte HighByte, byte LowByte) {
	/// <summary>Combined 16-bit payload (<c>(HighByte&lt;&lt;8) | LowByte</c>).</summary>
	public ushort Payload => (ushort)((HighByte << 8) | LowByte);
}

/// <summary>
/// Pure decoder for the pitch-bend channel-event word. Extracts the
/// high byte of the event word and duplicates it into both bytes of
/// an <see cref="AdgPitchBendEvent"/>.
/// </summary>
public static class AdgPitchBendEventDecoder {
	/// <summary>
	/// Returns the bend payload encoded by the supplied event word.
	/// </summary>
	public static AdgPitchBendEvent Decode(ushort eventWord) {
		byte highByte = (byte)(eventWord >> 8);
		return new AdgPitchBendEvent(highByte, highByte);
	}
}