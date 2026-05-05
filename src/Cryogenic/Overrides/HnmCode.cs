namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.OperatingSystem;
using Spice86.Core.Emulator.OperatingSystem.Structures;

using System;

/// <summary>
/// Partial class containing HNM video file format handling overrides.
/// </summary>
/// <remarks>
/// <para>
/// HNM is a proprietary video format used by Cryo Interactive for full-motion video sequences.
/// This file provides overrides for reading HNM file data from disk into memory buffers
/// for decoding and playback.
/// </para>
/// <para>
/// Method names contain underscores to separate segment, offset, and linear addresses
/// for traceability back to the original DOS disassembly.
/// </para>
/// </remarks>
public partial class Overrides {

	/// <summary>
	/// Registers HNM video file handling function overrides with Spice86.
	/// </summary>
	public void DefineHnmCodeOverrides() {
		DefineFunction(cs1, 0xCDBF, HnmReadFromFileHandle_1000_CDBF_01CDBF);
		DefineFunction(cs1, 0x0309, PlayCreditsHnm_1000_0309_010309);
		DefineFunction(cs1, 0x061C, LoadVirginHnm_1000_061C_01061C);
		DefineFunction(cs1, 0x0625, PlayVirginHnm_1000_0625_010625);
		DefineFunction(cs1, 0x064D, LoadCryoHnm_1000_064D_01064D);
		DefineFunction(cs1, 0x0658, LoadCryo2Hnm_1000_0658_010658);
		DefineFunction(cs1, 0x0661, PlayCryoOrCryo2Hnm_1000_0661_010661);
		DefineFunction(cs1, 0x0678, LoadPresentHnm_1000_0678_010678);
		DefineFunction(cs1, 0x0684, PlayPresentHnm_1000_0684_010684);
		DefineFunction(cs1, 0x069E, LoadIntroHnm_1000_069E_01069E);
		DefineFunction(cs1, 0x06AA, PlayHnm86Frames_1000_06AA_0106AA);
		DefineFunction(cs1, 0x06BD, PlayHnmSkippable_1000_06BD_0106BD);
		DefineFunction(cs1, 0x09EF, PlayCreditsHnmAlt_1000_09EF_0109EF);
	}

	/// <summary>
	/// Override for CS1:CDBF - Reads data from an open HNM video file into a memory buffer.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in this override).</param>
	/// <returns>A near return action to exit the function.</returns>
	/// <exception cref="UnhandledOperationException">
	/// Thrown if the actual bytes read doesn't match the requested amount, indicating an untested code path
	/// where the original DOS code would loop to retry the read.
	/// </exception>
	/// <remarks>
	/// <para>
	/// Performs a sequential read from the HNM file using the DOS file manager. Updates global
	/// state tracking file position, remaining bytes, and buffer pointers.
	/// </para>
	/// <para>
	/// The function reads CX bytes from the file at the current offset into the target buffer,
	/// then advances all related pointers and counters.
	/// </para>
	/// </remarks>
	public Action HnmReadFromFileHandle_1000_CDBF_01CDBF(int gotoAddress) {
		DosFileManager dosFileManager = Machine.Dos.FileManager;
		ushort fileHandle = globalsOnDs.Get1138_35A6_Word16_IsAnimateMenuUnneeded();
		if (fileHandle == 0) {
			return NearRet();
		}

		ushort readLength = CX;
		uint offset = globalsOnDs.Get1138_DC04_DWord32_hnmFileOffset();
		uint targetMemory = globalsOnDs.GetPtr1138_DC0C_Dword32_hnmFileReadBufferSegment().Linear;
		_loggerService.Debug("Read {@ReadLength} bytes from hnm file handle {@FileHandle} at offset {@Offset}", readLength, fileHandle, offset);
		dosFileManager.MoveFilePointerUsingHandle(SeekOrigin.Begin, fileHandle, (int)offset);
		DosFileOperationResult result = dosFileManager.ReadFileOrDevice(fileHandle, readLength, targetMemory);
		uint? actualReadLength = result.Value;
		if (actualReadLength != readLength) {
			throw this.FailAsUntested("The original code loops here when read bytes from hnm are not as expected.");
		}
		globalsOnDs.Set1138_DC08_DWord32_hnmFileRemain(globalsOnDs.Get1138_DC08_DWord32_hnmFileRemain() - actualReadLength.Value);
		globalsOnDs.Set1138_DC04_DWord32_hnmFileOffset(offset + actualReadLength.Value);
		globalsOnDs.Set1138_DC0C_Word16_hnmFileReadBufferSegment((ushort)(globalsOnDs.Get1138_DC0C_Word16_hnmFileReadBufferSegment() + actualReadLength.Value));
		globalsOnDs.Set1138_DC1A_Word16((ushort)(globalsOnDs.Get1138_DC1A_Word16() + actualReadLength.Value));
		return NearRet();
	}

	/// <summary>
	/// Override for CS1:0309 — play_CREDITS_HNM (seg000:0309).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action PlayCreditsHnm_1000_0309_010309(int gotoAddress) {
		throw FailAsUntested("PlayCreditsHnm (seg000:0309) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:061C — load_VIRGIN_HNM (seg000:061C).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action LoadVirginHnm_1000_061C_01061C(int gotoAddress) {
		throw FailAsUntested("LoadVirginHnm (seg000:061C) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:0625 — play_VIRGIN_HNM (seg000:0625).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action PlayVirginHnm_1000_0625_010625(int gotoAddress) {
		throw FailAsUntested("PlayVirginHnm (seg000:0625) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:064D — load_CRYO_HNM (seg000:064D).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action LoadCryoHnm_1000_064D_01064D(int gotoAddress) {
		throw FailAsUntested("LoadCryoHnm (seg000:064D) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:0658 — load_CRYO2_HNM (seg000:0658).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action LoadCryo2Hnm_1000_0658_010658(int gotoAddress) {
		throw FailAsUntested("LoadCryo2Hnm (seg000:0658) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:0661 — play_CRYO_OR_CRYO2_HNM (seg000:0661).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action PlayCryoOrCryo2Hnm_1000_0661_010661(int gotoAddress) {
		throw FailAsUntested("PlayCryoOrCryo2Hnm (seg000:0661) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:0678 — load_PRESENT_HNM (seg000:0678).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action LoadPresentHnm_1000_0678_010678(int gotoAddress) {
		throw FailAsUntested("LoadPresentHnm (seg000:0678) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:0684 — play_PRESENT_HNM (seg000:0684).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action PlayPresentHnm_1000_0684_010684(int gotoAddress) {
		throw FailAsUntested("PlayPresentHnm (seg000:0684) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:069E — load_INTRO_HNM (seg000:069E).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action LoadIntroHnm_1000_069E_01069E(int gotoAddress) {
		throw FailAsUntested("LoadIntroHnm (seg000:069E) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:06AA — play_hnm_86_frames (seg000:06AA).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action PlayHnm86Frames_1000_06AA_0106AA(int gotoAddress) {
		throw FailAsUntested("PlayHnm86Frames (seg000:06AA) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:06BD — play_hnm_skippable (seg000:06BD).
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action PlayHnmSkippable_1000_06BD_0106BD(int gotoAddress) {
		throw FailAsUntested("PlayHnmSkippable (seg000:06BD) not yet implemented");
	}

	/// <summary>
	/// Override for CS1:09EF — play_CREDITS_HNM alternate entry point (seg000:09EF).
	/// This is a distinct entry point from <see cref="PlayCreditsHnm_1000_0309_010309"/>.
	/// Confirmed executed in dump/spice86dumpExecutionFlow.json.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps.</param>
	/// <returns>Never returns; throws until implemented.</returns>
	public Action PlayCreditsHnmAlt_1000_09EF_0109EF(int gotoAddress) {
		throw FailAsUntested("PlayCreditsHnmAlt (seg000:09EF) not yet implemented");
	}
}