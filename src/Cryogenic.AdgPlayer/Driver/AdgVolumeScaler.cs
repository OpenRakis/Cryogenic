namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure volume scaler used by ADG's master volume / dynamics path.
/// Faithful byte-wise port of <c>AdgComputeScaledVolumeFromAx</c>
/// (live disasm at 564B:056E) from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
///
/// Algorithm (transcribed from the original 8086 instructions):
/// <code>
///   al = AL >> 3
///   dl = al, dh = AH
///   bl = 0x78, bh = 0xF0
///   ah = clamp(AH, 0x78)
///   axDiv = ah &lt;&lt; 8
///   al = axDiv / bh; ah = axDiv % bh
///   mul1 = al * dl
///   savedHi = mul1 &gt;&gt; 8
///   ah = -(AH - 0xF0)         ; uses raw AH, not clamped
///   ah = clamp(ah, 0x78)
///   axDiv = ah &lt;&lt; 8
///   al = axDiv / bh; ah = axDiv % bh
///   axOut = (al * dl) &gt;&gt; 4
///   AX = (axOut &amp; 0x0FF0) | savedHi
/// </code>
/// </summary>
public static class AdgVolumeScaler {
	private const byte ClampLimit = 0x78;
	private const byte Divisor = 0xF0;
	private const ushort HighNibbleWordMask = 0x0FF0;

	/// <summary>
	/// Scales <paramref name="ax"/> using the same byte-wise routine as the
	/// original DNADG driver. No side effects; pure function.
	/// </summary>
	public static ushort Scale(ushort ax) {
		byte rawAl = (byte)(ax & 0xFF);
		byte rawAh = (byte)(ax >> 8);

		byte al = (byte)(rawAl >> 3);
		byte dl = al;
		byte dh = rawAh;

		byte ah = rawAh;
		if (ah > ClampLimit) {
			ah = ClampLimit;
		}

		ushort axDiv = (ushort)(ah << 8);
		al = (byte)(axDiv / Divisor);
		ah = (byte)(axDiv % Divisor);

		ushort mul1 = (ushort)(al * dl);
		byte savedHi = (byte)(mul1 >> 8);

		ah = (byte)(rawAh - Divisor);
		ah = (byte)(0 - ah);
		if (ah > ClampLimit) {
			ah = ClampLimit;
		}

		axDiv = (ushort)(ah << 8);
		al = (byte)(axDiv / Divisor);
		ah = (byte)(axDiv % Divisor);

		ushort axOut = (ushort)(al * dl);
		axOut = (ushort)(axOut >> 4);
		axOut = (ushort)(axOut & HighNibbleWordMask);
		return (ushort)(axOut | savedHi);
	}
}