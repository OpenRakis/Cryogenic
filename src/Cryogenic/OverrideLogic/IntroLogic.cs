namespace Cryogenic.OverrideLogic;

/// <summary>
/// Pure, stateless helper methods encoding the intro-scene animation logic of specific
/// game assembly routines. These methods are independently testable without a live Spice86
/// Machine instance and are called from the corresponding override methods.
/// </summary>
public static class IntroLogic {

	/// <summary>
	/// Stores node pointers and computes the combined animation direction byte for an
	/// intro scene node, implementing the logic of <c>loc_001e0</c> (seg000:01E0).
	/// </summary>
	/// <param name="tileType">
	/// Tile type byte read from <c>DS:[DI]</c>; only the lower nibble (bits 0–3) is used.
	/// </param>
	/// <param name="directionByte">
	/// Current direction byte read from <c>DS:[SI+0x12]</c>; only the lower 3 bits (bits 0–2)
	/// are preserved before XOR operations.
	/// </param>
	/// <returns>
	/// The combined direction byte: <c>(tileType &amp; 0x0F) | finalDirectionBits</c>.
	/// Bit 7 of the result is set when the masked tile type is in the ranges 4–5 or above 9,
	/// following the three consecutive XOR-with-0x80 tests at seg000:01F5, 01FC, 0203.
	/// </returns>
	/// <remarks>
	/// Implements the body of <c>loc_001e0</c> which writes the target node pointers
	/// to <c>DS:[SI+4]</c>, <c>DS:[SI+6]</c>, <c>DS:[SI+8]</c> and then computes the
	/// direction byte via:
	/// <code>
	/// AL = tileType &amp; 0x0F
	/// AH = directionByte &amp; 0x07
	/// if (AL &gt; 3)  AH ^= 0x80
	/// if (AL &gt; 5)  AH ^= 0x80
	/// if (AL &gt; 9)  AH ^= 0x80
	/// result = AL | AH
	/// </code>
	/// The pointer writes (<c>mov [SI+4], DI</c> etc.) are handled by the calling
	/// override method, which has access to the emulated registers.
	/// Source: IDA disassembly at seg000:01E0–020B in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public static byte ComputeNodeDirectionByte(byte tileType, byte directionByte) {
		byte al = (byte)(tileType & 0x0F);
		byte ah = (byte)(directionByte & 0x07);
		if (al > 3) {
			ah ^= 0x80;
		}
		if (al > 5) {
			ah ^= 0x80;
		}
		if (al > 9) {
			ah ^= 0x80;
		}
		return (byte)(al | ah);
	}
}