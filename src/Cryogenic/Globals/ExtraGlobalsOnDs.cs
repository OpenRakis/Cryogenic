namespace Cryogenic.Globals;

using Cryogenic.Generated;

using Spice86.Core.Emulator.CPU.Registers;
using Spice86.Core.Emulator.Memory.ReaderWriter;

/// <summary>
/// Extends the generated GlobalsOnDs class with additional manually-defined accessors
/// for game state values that could not be automatically detected during runtime analysis.
/// </summary>
/// <remarks>
/// This class provides access to global variables stored in the DS (Data Segment).
/// Values here represent game state that was not captured by the automated code generation tools,
/// including HNM video playback state and menu system information.
/// </remarks>
public class ExtraGlobalsOnDs : GlobalsOnDs {

	/// <summary>
	/// Initializes a new instance of the <see cref="ExtraGlobalsOnDs"/> class.
	/// </summary>
	/// <param name="memory">The memory reader/writer interface for accessing emulated memory.</param>
	/// <param name="segmentRegisters">The CPU segment registers used to calculate absolute addresses.</param>
	public ExtraGlobalsOnDs(IByteReaderWriter memory, SegmentRegisters segmentRegisters) : base(memory, segmentRegisters) {
	}

	/// <summary>
	/// Gets the current file offset for HNM video file reading.
	/// </summary>
	/// <returns>The 32-bit file offset into the currently open HNM video file.</returns>
	/// <remarks>
	/// HNM files are video format used by the game. This offset tracks the current read position.
	/// Located at DS:DC04.
	/// </remarks>
	public uint Get1138_DC04_DWord32_hnmFileOffset() {
		return UInt32[0xDC04];
	}

	/// <summary>
	/// Gets the number of bytes remaining to read in the current HNM video file.
	/// </summary>
	/// <returns>The 32-bit count of remaining bytes in the HNM file.</returns>
	/// <remarks>
	/// Used to track progress during HNM video playback.
	/// Located at DS:DC08.
	/// </remarks>
	public uint Get1138_DC08_DWord32_hnmFileRemain() {
		return UInt32[0xDC08];
	}

	/// <summary>
	/// Gets the current menu type identifier that determines which menu is displayed and what actions are available.
	/// </summary>
	/// <returns>The 16-bit menu type identifier.</returns>
	/// <remarks>
	/// The menu displayed and associated user actions depend on this value.
	/// Different menu types include dialogue menus, map views, equipment screens, etc.
	/// The value is retrieved indirectly through an offset pointer.
	/// </remarks>
	public ushort GetMenuType() {
		// menu displayed and associated actions depend on this value
		return this.UInt16[Get1138_21DA_Word16_OffsetToMenuType()];
	}

	/// <summary>
	/// Sets the current file offset for HNM video file reading.
	/// </summary>
	/// <param name="value">The new 32-bit file offset to set.</param>
	/// <remarks>
	/// Updates the read position in the currently open HNM video file.
	/// Located at DS:DC04.
	/// </remarks>
	public void Set1138_DC04_DWord32_hnmFileOffset(uint value) {
		UInt32[0xDC04] = value;
	}

	/// <summary>
	/// Sets the number of bytes remaining to read in the current HNM video file.
	/// </summary>
	/// <param name="value">The new 32-bit count of remaining bytes.</param>
	/// <remarks>
	/// Used to update progress tracking during HNM video playback.
	/// Located at DS:DC08.
	/// </remarks>
	public void Set1138_DC08_DWord32_hnmFileRemain(uint value) {
		UInt32[0xDC08] = value;
	}

	/// <summary>
	/// Sets the character draw X coordinate (full 16-bit) at DS:D82C.
	/// </summary>
	/// <param name="value">The new 16-bit X coordinate.</param>
	/// <remarks>
	/// The auto-generated <see cref="Cryogenic.Generated.GlobalsOnDs.Set1138_D82C_Word16_CharacterXCoord(byte)"/>
	/// has a byte-typed parameter that truncates writes to the low byte. This helper writes the full 16-bit
	/// value as the disassembly does (<c>MOV [D82C], DX</c>).
	/// </remarks>
	public void Set1138_D82C_Word16_CharacterXCoord_Full(ushort value) {
		UInt16[0xD82C] = value;
	}

	/// <summary>
	/// Sets the character draw Y coordinate (full 16-bit) at DS:D82E.
	/// </summary>
	/// <param name="value">The new 16-bit Y coordinate.</param>
	/// <remarks>
	/// The auto-generated setter accepts only a byte. This helper writes the full 16-bit value to mirror
	/// <c>MOV [D82E], BX</c> from the disassembly at <c>seg000:D052</c>.
	/// </remarks>
	public void Set1138_D82E_Word16_CharacterYCoord_Full(ushort value) {
		UInt16[0xD82E] = value;
	}

	/// <summary>
	/// Sets the secondary draw X coordinate (full 16-bit) at DS:D830.
	/// </summary>
	/// <param name="value">The new 16-bit X coordinate.</param>
	/// <remarks>
	/// Mirrors the disassembly write <c>MOV [D830], DX</c> at <c>seg000:D056</c>. The auto-generated
	/// setter narrows to a byte and is therefore unsuitable for full-word writes.
	/// </remarks>
	public void Set1138_D830_Word16_Full(ushort value) {
		UInt16[0xD830] = value;
	}

	/// <summary>
	/// Sets the secondary draw Y coordinate (full 16-bit) at DS:D832.
	/// </summary>
	/// <param name="value">The new 16-bit Y coordinate.</param>
	/// <remarks>
	/// Mirrors the disassembly write <c>MOV [D832], BX</c> at <c>seg000:D05A</c>. The auto-generated
	/// setter narrows to a byte and is therefore unsuitable for full-word writes.
	/// </remarks>
	public void Set1138_D832_Word16_Full(ushort value) {
		UInt16[0xD832] = value;
	}
}