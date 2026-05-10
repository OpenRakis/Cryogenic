namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure decoder for the Feedback/Connection register byte (OPL3
/// register 0xC0 family) from a 27-byte ADG instrument patch. Faithful
/// port of the connection-byte block inside
/// <c>AdgWriteInstrumentPatch_0F95</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public static class AdgInstrumentConnectionComputer {
	/// <summary>Minimum patch length required (offsets 0x04, 0x0F,
	/// 0x1A are read).</summary>
	public const int RequiredPatchLength = 0x1B;

	private const int FeedbackByteOffset = 0x04;
	private const int ConnectionMidOffset = 0x0F;
	private const int ConnectionHighOffset = 0x1A;
	private const byte ConnectionRegisterMask = 0x0F;

	/// <summary>
	/// Decodes the Feedback/Connection register byte from
	/// <paramref name="patch"/>. The 8086 sequence is preserved verbatim
	/// to keep the link to the disasm trace obvious.
	/// </summary>
	public static byte Compute(byte[] patch) {
		ArgumentNullException.ThrowIfNull(patch);
		if (patch.Length < RequiredPatchLength) {
			throw new ArgumentException(
				$"Instrument patch must contain at least {RequiredPatchLength} bytes.",
				nameof(patch));
		}

		byte midByte = patch[ConnectionMidOffset];
		byte highByte = patch[ConnectionHighOffset];
		byte feedbackByte = patch[FeedbackByteOffset];

		// w = Make16(midByte, highByte)
		ushort word = (ushort)(midByte | (highByte << 8));

		// w >>= 1
		word = (ushort)(word >> 1);

		// w = Make16(~Lo8(w), feedbackByte)
		byte invertedLow = (byte)~(byte)(word & 0xFF);
		word = (ushort)(invertedLow | (feedbackByte << 8));

		// w <<= 1
		word = (ushort)(word << 1);

		// connection = Hi8(w) & 0x0F
		return (byte)((byte)(word >> 8) & ConnectionRegisterMask);
	}
}