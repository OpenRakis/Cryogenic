namespace Cryogenic.Overrides;

#pragma warning disable MA0051 // Method is too long
#pragma warning disable S4136  // Keep helper overload placement as-is in this low-level port
#pragma warning disable S1854  // Register-style assignments intentionally mirror assembly flow

using Serilog;

using Spice86.Shared.Utils;

using System;

/// <summary>
/// DNADP (AdLib Pro / OPL) music driver full C# override.
/// </summary>
public partial class Overrides {
	private static readonly ILogger AdpLogger = Log.ForContext("Subsystem", "ADPDriver");
	private static bool EnableAdpCSharpFunctionReplacement = true;
	private ushort _adpSegment = 0x5BAE;
	private int _adpTickIndex;

	private const ushort AdpDefaultSegment = 0x5BAE;
	private const ushort AdpChannelTableBase = 0x01A2;

	public void DefineAdpDriverCodeOverrides() {
		if (!EnableAdpCSharpFunctionReplacement) {
			AdpLogger.Information("DNADP full replacement disabled.");
			return;
		}
		ResolveAdpSegment();
		RegisterAdpLiveFunctionReplacements();
	}

	private void ResolveAdpSegment() {
		if (DriverLoadToolbox.ActualAdpSegment != 0) {
			_adpSegment = DriverLoadToolbox.ActualAdpSegment;
		} else {
			_adpSegment = AdpDefaultSegment;
		}
	}

	private void RegisterAdpLiveFunctionReplacements() {
		DefineFunction(_adpSegment, 0x0100, AdpInit_5BAE_0100_05BBE0, false, nameof(AdpInit_5BAE_0100_05BBE0));
		DefineFunction(_adpSegment, 0x0103, AdpOpen_5BAE_0103_05BBE3, false, nameof(AdpOpen_5BAE_0103_05BBE3));
		DefineFunction(_adpSegment, 0x0106, AdpReset_5BAE_0106_05BBE6, false, nameof(AdpReset_5BAE_0106_05BBE6));
		DefineFunction(_adpSegment, 0x0109, AdpSetTickEnabled_5BAE_0109_05BBE9, false, nameof(AdpSetTickEnabled_5BAE_0109_05BBE9));
		DefineFunction(_adpSegment, 0x010C, AdpSetDynamics_5BAE_010C_05BBEC, false, nameof(AdpSetDynamics_5BAE_010C_05BBEC));
		DefineFunction(_adpSegment, 0x010F, AdpTick_5BAE_010F_05BBEF, false, nameof(AdpTick_5BAE_010F_05BBEF));
		DefineFunction(_adpSegment, 0x0112, AdpSetVolume_5BAE_0112_05BBF2, false, nameof(AdpSetVolume_5BAE_0112_05BBF2));

		DefineFunction(_adpSegment, 0x02B5, AdpInitInternal_5BAE_02B5_05BDD5, false, nameof(AdpInitInternal_5BAE_02B5_05BDD5));
		DefineFunction(_adpSegment, 0x02D8, AdpInit_5BAE_02D8_05BDF8, false, nameof(AdpInit_5BAE_02D8_05BDF8));
		DefineFunction(_adpSegment, 0x02FE, AdpReset_5BAE_02FE_05BE1E, false, nameof(AdpReset_5BAE_02FE_05BE1E));
		DefineFunction(_adpSegment, 0x030B, AdpResetInternalBody_5BAE_030B_05BE2B, false, nameof(AdpResetInternalBody_5BAE_030B_05BE2B));
		DefineFunction(_adpSegment, 0x0348, AdpSetVolume_5BAE_0348_05BE68, false, nameof(AdpSetVolume_5BAE_0348_05BE68));
		DefineFunction(_adpSegment, 0x035B, AdpSetDynamicsCurve_5BAE_035B_05BE7B, false, nameof(AdpSetDynamicsCurve_5BAE_035B_05BE7B));
		DefineFunction(_adpSegment, 0x039C, AdpSetTimerTickFlag_5BAE_039C_05BEBC, false, nameof(AdpSetTimerTickFlag_5BAE_039C_05BEBC));
		DefineFunction(_adpSegment, 0x03B2, AdpOpen_5BAE_03B2_05BED2, false, nameof(AdpOpen_5BAE_03B2_05BED2));
		DefineFunction(_adpSegment, 0x0413, AdpBuildChannelTable_5BAE_0413_05BF33, false, nameof(AdpBuildChannelTable_5BAE_0413_05BF33));
		DefineFunction(_adpSegment, 0x0473, AdpTickHandler_5BAE_0473_05BF93, false, nameof(AdpTickHandler_5BAE_0473_05BF93));
		DefineFunction(_adpSegment, 0x04AD, AdpSongValidation_5BAE_04AD_05BFCD, false, nameof(AdpSongValidation_5BAE_04AD_05BFCD));
		DefineFunction(_adpSegment, 0x04D3, AdpProcessTick_5BAE_04D3_05BFF3, false, nameof(AdpProcessTick_5BAE_04D3_05BFF3));
		DefineFunction(_adpSegment, 0x0553, AdpLoopPointCheck_5BAE_0553_05C073, false, nameof(AdpLoopPointCheck_5BAE_0553_05C073));
		DefineFunction(_adpSegment, 0x05AA, AdpProgramChange_5BAE_05AA_05C0CA, false, nameof(AdpProgramChange_5BAE_05AA_05C0CA));
		DefineFunction(_adpSegment, 0x062C, AdpNoteOn_5BAE_062C_05C14C, false, nameof(AdpNoteOn_5BAE_062C_05C14C));
		DefineFunction(_adpSegment, 0x065B, AdpNoteOff_5BAE_065B_05C17B, false, nameof(AdpNoteOff_5BAE_065B_05C17B));
		DefineFunction(_adpSegment, 0x066F, AdpEndOfTrack_5BAE_066F_05C18F, false, nameof(AdpEndOfTrack_5BAE_066F_05C18F));
		DefineFunction(_adpSegment, 0x06A8, AdpVolumeModulation_5BAE_06A8_05C1C8, false, nameof(AdpVolumeModulation_5BAE_06A8_05C1C8));
		DefineFunction(_adpSegment, 0x0740, AdpEnvelopeSetup_5BAE_0740_05C260, false, nameof(AdpEnvelopeSetup_5BAE_0740_05C260));
		DefineFunction(_adpSegment, 0x07EA, AdpPitchBend_5BAE_07EA_05C30A, false, nameof(AdpPitchBend_5BAE_07EA_05C30A));
		DefineFunction(_adpSegment, 0x07EF, AdpPitchBendBody_5BAE_07EF_05C30F, false, nameof(AdpPitchBendBody_5BAE_07EF_05C30F));
		DefineFunction(_adpSegment, 0x08E1, AdpReadWaitValue_5BAE_08E1_05C401, false, nameof(AdpReadWaitValue_5BAE_08E1_05C401));
		DefineFunction(_adpSegment, 0x091B, AdpUnknown091B_5BAE_091B_05C43B, false, nameof(AdpUnknown091B_5BAE_091B_05C43B));
		DefineFunction(_adpSegment, 0x092D, AdpFadeStep_5BAE_092D_05C44D, false, nameof(AdpFadeStep_5BAE_092D_05C44D));
		DefineFunction(_adpSegment, 0x0982, AdpUnknown0982_5BAE_0982_05C4A2, false, nameof(AdpUnknown0982_5BAE_0982_05C4A2));
		DefineFunction(_adpSegment, 0x099A, AdpUnknown099A_5BAE_099A_05C4BA, false, nameof(AdpUnknown099A_5BAE_099A_05C4BA));
		DefineFunction(_adpSegment, 0x09AB, AdpInstrumentWrite_5BAE_09AB_05C4CB, false, nameof(AdpInstrumentWrite_5BAE_09AB_05C4CB));
		DefineFunction(_adpSegment, 0x09C3, AdpInstrumentWriteLoop_5BAE_09C3_05C4E3, false, nameof(AdpInstrumentWriteLoop_5BAE_09C3_05C4E3));
		DefineFunction(_adpSegment, 0x0A58, AdpOplNoteOn_5BAE_0A58_05C578, false, nameof(AdpOplNoteOn_5BAE_0A58_05C578));
		DefineFunction(_adpSegment, 0x0A87, AdpOplNoteOff_5BAE_0A87_05C5A7, false, nameof(AdpOplNoteOff_5BAE_0A87_05C5A7));
		DefineFunction(_adpSegment, 0x0A8F, AdpOplFrequencyWrite_5BAE_0A8F_05C5AF, false, nameof(AdpOplFrequencyWrite_5BAE_0A8F_05C5AF));
		DefineFunction(_adpSegment, 0x0AA2, AdpOplRegisterWrite_5BAE_0AA2_05C5C2, false, nameof(AdpOplRegisterWrite_5BAE_0AA2_05C5C2));
	}

	private static byte Lo8(ushort value) {
		return (byte)(value & 0xFF);
	}

	private static byte Hi8(ushort value) {
		return (byte)(value >> 8);
	}

	private static ushort Make16(byte lo, byte hi) {
		return (ushort)(lo | (hi << 8));
	}

	private uint AdpAddr(ushort offset) {
		return MemoryUtils.ToPhysicalAddress(_adpSegment, offset);
	}

	private byte AdpByte(ushort offset) {
		return Memory.UInt8[AdpAddr(offset)];
	}

	private void AdpByteSet(ushort offset, byte value) {
		Memory.UInt8[AdpAddr(offset)] = value;
	}

	private ushort AdpWord(ushort offset) {
		return Memory.UInt16[AdpAddr(offset)];
	}

	private void AdpWordSet(ushort offset, ushort value) {
		Memory.UInt16[AdpAddr(offset)] = value;
	}

	private byte SegByte(ushort segment, ushort offset) {
		return Memory.UInt8[MemoryUtils.ToPhysicalAddress(segment, offset)];
	}

	private void SegByteSet(ushort segment, ushort offset, byte value) {
		Memory.UInt8[MemoryUtils.ToPhysicalAddress(segment, offset)] = value;
	}

	private ushort SegWord(ushort segment, ushort offset) {
		return Memory.UInt16[MemoryUtils.ToPhysicalAddress(segment, offset)];
	}

	private void SegWordSet(ushort segment, ushort offset, ushort value) {
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(segment, offset)] = value;
	}

	private void AdpPushFlagsToStack() {
		Stack.Push16(State.Flags.FlagRegister16);
	}

	private void AdpPopFlagsFromStack() {
		State.Flags.FlagRegister = Stack.Pop16();
	}

	/// <summary>
	/// Gist: ADPInit_entry (0100). Entry‐point jump to ADPInit.
	/// <code>dnadp:0100 jmp ADPInit</code>
	/// </summary>
	public Action AdpInit_5BAE_0100_05BBE0(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0100_Init");
		return AdpInit_5BAE_02D8_05BDF8(0);
	}

	/// <summary>
	/// Gist: ADPOpen_entry (0103). Entry‐point jump to ADPOpen.
	/// <code>dnadp:0103 jmp ADPOpen</code>
	/// </summary>
	public Action AdpOpen_5BAE_0103_05BBE3(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0103_OpenSong");
		CryogenicMcpTools.RecordAdpSongOpen(ES, SI);
		return AdpOpen_5BAE_03B2_05BED2(0);
	}

	/// <summary>
	/// Gist: ADPReset_entry (0106). Entry‐point jump to ADPReset.
	/// <code>dnadp:0106 jmp ADPReset</code>
	/// </summary>
	public Action AdpReset_5BAE_0106_05BBE6(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0106_Reset");
		return AdpReset_5BAE_02FE_05BE1E(0);
	}

	/// <summary>
	/// Gist: ADPSetTickEnabled_entry (0109). Entry‐point jump to ADPSetTimerTickFlag.
	/// <code>dnadp:0109 jmp ADPSetTimerTickFlag</code>
	/// </summary>
	public Action AdpSetTickEnabled_5BAE_0109_05BBE9(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0109_SetTickEnabled");
		return AdpSetTimerTickFlag_5BAE_039C_05BEBC(0);
	}

	/// <summary>
	/// Gist: ADPSetDynamics_entry (010C). Entry‐point jump to ADPSetDynamicsCurve.
	/// <code>dnadp:010c jmp ADPSetDynamicsCurve</code>
	/// </summary>
	public Action AdpSetDynamics_5BAE_010C_05BBEC(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:010C_SetDynamics");
		return AdpSetDynamicsCurve_5BAE_035B_05BE7B(0);
	}

	/// <summary>
	/// Gist: ADPTick_entry (010F). Entry‐point jump to ADPTickHandler.
	/// <code>dnadp:010f jmp ADPTickHandler</code>
	/// </summary>
	public Action AdpTick_5BAE_010F_05BBEF(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:010F_Tick");
		return AdpTickHandler_5BAE_0473_05BF93(0);
	}

	/// <summary>
	/// Gist: ADPSetVolume_entry (0112). Entry‐point jump to ADPSetVolume.
	/// <code>dnadp:0112 jmp ADPSetVolume</code>
	/// </summary>
	public Action AdpSetVolume_5BAE_0112_05BBF2(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0112_SetVolume");
		return AdpSetVolume_5BAE_0348_05BE68(0);
	}

	/// <summary>
	/// Gist: ADPInitInternal (02B5). Patches file extensions to ".HSQ" in the filename table.
	/// Scans SS:BP pointer list for '.' and overwrites the 3-byte extension with CS:[02B0]="HSQ".
	/// Called from ADPInit at 02E1.
	/// <code>
	/// dnadp:02b5  push ss / pop es / mov si, bp
	/// dnadp:02b9  es:lodsw / add ax, 2 / mov di, ax
	/// dnadp:02c4  mov al, 2eh / repnz scasb   ; search for '.'
	/// dnadp:02cb  mov ax, cs:[2b0h] / stosw / mov al, cs:[2b2h] / stosb
	/// dnadp:02d5  loop loc_002b9 / ret
	/// </code>
	/// </summary>
	public Action AdpInitInternal_5BAE_02B5_05BDD5(int gotoAddress) {
		ushort es = SS;
		ushort si = BP;
		ushort di = (ushort)(SegWord(es, si) + 2);
		for (int i = 0; i < CX; i++) {
			ushort scan = di;
			bool found = false;
			for (int j = 0; j < 9; j++) {
				if (SegByte(es, scan) == 0x2E) {
					found = true;
					break;
				}
				scan++;
			}
			if (found) {
				SegWordSet(es, scan, AdpWord(0x02B0));
				SegByteSet(es, (ushort)(scan + 2), AdpByte(0x02B2));
			}
			di = (ushort)(di + 1);
		}
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPInit (02D8). Main driver initialization.
	/// Sets base I/O port from AX (if non-zero), calls ADPInitInternal to patch filenames,
	/// configures OPL registers (WaveformSelect=01, Percussion=off, TimerCtrl=40),
	/// then calls ADPReset. Returns BX=0x0F00 via RETF.
	/// <code>
	/// dnadp:02d8  and ax, 0fffh / jz loc_002e1 / mov cs:[2b3h], ax
	/// dnadp:02e1  call ADPInitInternal
	/// dnadp:02e4  mov ax, 2001h / call ADPOplRegisterWrite
	/// dnadp:02f0  mov ax, 4008h / call ADPOplRegisterWrite
	/// dnadp:02f6  push cs / call ADPReset / mov bx, 0f00h / retf
	/// </code>
	/// </summary>
	public Action AdpInit_5BAE_02D8_05BDF8(int gotoAddress) {
		AX = (ushort)(AX & 0x0FFF);
		if (AX != 0) {
			AdpWordSet(0x02B3, AX);
		}
		AdpInitInternal_5BAE_02B5_05BDD5(0);
		AX = 0x2001;
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		AX = 0x00BD;
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		AX = 0x4008;
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		AdpReset_5BAE_02FE_05BE1E(0);
		BX = 0x0F00;
		return FarRet();
	}

	/// <summary>
	/// Gist: ADPReset (02FE). Silences all channels and clears the playback status flag.
	/// Saves/restores FLAGS (PUSHF/POPF) and disables interrupts during the operation.
	/// <code>
	/// dnadp:02fe  pushf / cli
	/// dnadp:0300  call ADPUnknown091B   ; all-notes-off loop
	/// dnadp:0303  xor ax, ax / mov cs:[19ah], al
	/// dnadp:0309  popf / retf
	/// </code>
	/// </summary>
	public Action AdpReset_5BAE_02FE_05BE1E(int gotoAddress) {
		AdpPushFlagsToStack();
		InterruptFlag = false;
		AdpUnknown091B_5BAE_091B_05C43B(0);
		AX = 0;
		AdpByteSet(0x019A, 0);
		AdpPopFlagsFromStack();
		return FarRet();
	}

	/// <summary>
	/// Gist: ADPResetInternal_body (030B). Computes a scaled volume value from AX.
	/// Used by both ADPSetVolume (0348) and ADPSetDynamicsCurve (035B).
	/// Performs two rounds of div/mul scaling against BH=0xF0, BL=0x78 thresholds,
	/// merging high and low nibble results into a composite volume byte in AL.
	/// <code>
	/// dnadp:030b  push bx / push dx / shr al, 1 ×3 / mov dx, ax
	/// dnadp:0315  mov bx, 0f078h / ... / div bh / mul dl
	/// dnadp:0340  and ax, 0ff0h / or al, ah / pop dx / pop bx / ret
	/// </code>
	/// </summary>
	public Action AdpResetInternalBody_5BAE_030B_05BE2B(int gotoAddress) {
		byte al = Lo8(AX);
		byte ah = Hi8(AX);
		al = (byte)(al >> 1);
		al = (byte)(al >> 1);
		al = (byte)(al >> 1);
		byte dl = al;
		byte dh = ah;
		byte bl = 0x78;
		byte bh = 0xF0;
		if (ah > bl) {
			ah = bl;
		}

		// xor al,al; div bh  -> unsigned divide AX by BH, quotient in AL, remainder in AH
		al = 0;
		ushort axDiv = Make16(al, ah);
		al = (byte)(axDiv / bh);
		ah = (byte)(axDiv % bh);

		// mul dl -> AX = AL * DL
		ushort mul1 = (ushort)(al * dl);
		al = Lo8(mul1);
		ah = Hi8(mul1);

		// xchg ah,dh
		byte temp = ah;
		ah = dh;
		dh = temp;

		ah = (byte)(ah - bh);
		ah = (byte)(0 - ah);
		if (ah > bl) {
			ah = bl;
		}

		// xor al,al; div bh
		al = 0;
		axDiv = Make16(al, ah);
		al = (byte)(axDiv / bh);
		ah = (byte)(axDiv % bh);

		// mul dl; shr ax,1 x4
		ushort axOut = (ushort)(al * dl);
		axOut = (ushort)(axOut >> 1);
		axOut = (ushort)(axOut >> 1);
		axOut = (ushort)(axOut >> 1);
		axOut = (ushort)(axOut >> 1);

		// mov ah,dh; and ax,0x0FF0; or al,ah
		ah = dh;
		axOut = (ushort)(axOut & 0x0FF0);
		AX = (ushort)(axOut | ah);
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPSetVolume (0348). Sets the master volume and resets the fade pattern to 0xFFFF.
	/// Calls ADPResetInternal_body to scale AX, then stores the result at [019E] and [019D].
	/// <code>
	/// dnadp:0348  call ADPResetInternal_body
	/// dnadp:034b  mov cs:[19eh], al / mov cs:[19dh], al
	/// dnadp:0353  mov word ptr cs:[19fh], 0ffffh / retf
	/// </code>
	/// </summary>
	public Action AdpSetVolume_5BAE_0348_05BE68(int gotoAddress) {
		AdpResetInternalBody_5BAE_030B_05BE2B(0);
		byte al = Lo8(AX);
		AdpByteSet(0x019E, al);
		AdpByteSet(0x019D, al);
		AdpWordSet(0x019F, 0xFFFF);
		return FarRet();
	}

	/// <summary>
	/// Gist: ADPSetDynamicsCurve (035B). Sets the dynamics target volume and fade bit-pattern.
	/// Scales BX via ADPResetInternal_body, then selects a fade pattern based on AX thresholds:
	/// 0xFFFF (&lt;0x60), 0xAAAA (&lt;0xC0), 0x8888 (&lt;0x180), 0x8080 (&lt;0x300), 0x8000 (else).
	/// If playback is active (bit 7), sets bit 6 to enable fade.
	/// <code>
	/// dnadp:035b  push ax / mov ax, bx / call ADPResetInternal_body
	/// dnadp:0366  mov bx, 0ffffh / cmp ax, 60h / jb loc_00388 ...
	/// dnadp:0388  mov cs:[19fh], bx
	/// dnadp:0391  or al, al / jns loc_0039b / or al, 40h
	/// dnadp:039b  retf
	/// </code>
	/// </summary>
	public Action AdpSetDynamicsCurve_5BAE_035B_05BE7B(int gotoAddress) {
		ushort savedAx = AX;
		AX = BX;
		AdpResetInternalBody_5BAE_030B_05BE2B(0);
		AdpByteSet(0x019D, Lo8(AX));
		AX = savedAx;
		ushort fade = 0xFFFF;
		if (AX >= 0x0060) {
			fade = 0xAAAA;
		}
		if (AX >= 0x00C0) {
			fade = 0x8888;
		}
		if (AX >= 0x0180) {
			fade = 0x8080;
		}
		if (AX >= 0x0300) {
			fade = 0x8000;
		}
		AdpWordSet(0x019F, fade);
		byte status = AdpByte(0x019A);
		if ((status & 0x80) != 0) {
			status = (byte)(status | 0x40);
			AdpByteSet(0x019A, status);
		}
		return FarRet();
	}

	/// <summary>
	/// Gist: ADPSetTimerTickFlag (039C). Sets the timer tick flag to 1 and returns status in AL.
	/// <code>
	/// dnadp:039c  mov byte ptr cs:[19bh], 1
	/// dnadp:03a2  mov al, cs:[19ah] / retf
	/// </code>
	/// </summary>
	public Action AdpSetTimerTickFlag_5BAE_039C_05BEBC(int gotoAddress) {
		AdpByteSet(0x019B, 1);
		byte al = AdpByte(0x019A);
		AX = Make16(al, Hi8(AX));
		return FarRet();
	}

	/// <summary>
	/// Gist: ADPOpen (03B2). Opens a song for playback.
	/// Saves DS, sets DS=CS, stores the song header pointer and validation checksums,
	/// computes channel table and instrument table offsets, calls ADPUnknown099A to init
	/// OPL slots, ADPBuildChannelTable, ADPUnknown0982 for mixer, then ADPProcessTick
	/// to prime the first tick. Sets status byte to 0x80 (playing).
	/// <code>
	/// dnadp:03b2  push ds / push cs / pop ds / mov [19bh], al
	/// dnadp:03ef  call ADPUnknown099A / call ADPBuildChannelTable
	/// dnadp:03fb  call ADPUnknown0982 / ... / call ADPProcessTick
	/// dnadp:040e  mov [19ah], 80h / pop ds / retf
	/// </code>
	/// </summary>
	public Action AdpOpen_5BAE_03B2_05BED2(int gotoAddress) {
		ushort oldDs = DS;
		DS = CS;
		AdpByteSet(0x019B, Lo8(AX));
		ushort header = SegWord(ES, SI);
		AdpWordSet(0x03A8, SI);
		AdpWordSet(0x03AA, ES);
		AdpWordSet(0x03AC, header);
		AdpWordSet(0x03AE, SegWord(ES, (ushort)(SI + 0x4000)));
		AdpWordSet(0x03B0, SegWord(ES, (ushort)(SI - 0x8000)));
		ushort songDataOffset = (ushort)(SI + 2);
		AdpWordSet(0x0115, songDataOffset);
		AdpWordSet(0x0117, ES);
		ushort eventOffset = (ushort)(SI + SegWord(ES, SI));
		AdpWordSet(0x0119, eventOffset);
		AdpWordSet(0x011B, ES);
		AdpUnknown099A_5BAE_099A_05C4BA(0);
		AdpBuildChannelTable_5BAE_0413_05BF33(0);
		byte masterVolume = AdpByte(0x019E);
		AdpByteSet(0x019C, masterVolume);
		AdpUnknown0982_5BAE_0982_05C4A2(0);
		AdpByteSet(0x019D, Lo8(AX));
		AdpWordSet(0x011D, 0);
		AdpWordSet(0x0123, 0);
		AdpProcessTick_5BAE_04D3_05BFF3(0);
		AdpByteSet(0x019A, 0x80);
		DS = oldDs;
		return FarRet();
	}

	/// <summary>
	/// Gist: ADPBuildChannelTable (0413). Builds the 9-channel dispatch table from song header.
	/// Reads relative channel stream offsets from the song data, converts to absolute offsets,
	/// initializes per-channel instrument (0xFF), per-channel flags, beat/measure counters,
	/// and primes each channel's wait value via ADPReadWaitValue.
	/// <code>
	/// dnadp:0413  push ds / push ds / pop es / lds si, [115h]
	/// dnadp:0422  lodsw / or ax, ax / jz loc_00429 / add ax, bp
	/// dnadp:0444  mov word ptr [11fh], 1 / mov word ptr [121h], 60h
	/// dnadp:0453  mov cx, 9 / mov di, 1a2h
	/// dnadp:0466  call ADPReadWaitValue / inc word ptr [di]
	/// </code>
	/// </summary>
	public Action AdpBuildChannelTable_5BAE_0413_05BF33(int gotoAddress) {
		ushort songOffset = AdpWord(0x0115);
		ushort songSegment = AdpWord(0x0117);
		for (int i = 0; i < 9; i++) {
			ushort relative = SegWord(songSegment, (ushort)(songOffset + (i * 2)));
			ushort absolute = relative == 0 ? (ushort)0 : (ushort)(relative + songOffset);
			AdpWordSet((ushort)(0x01C6 + (i * 2)), absolute);
		}
		for (int i = 0; i < 9; i++) {
			AdpWordSet((ushort)(0x01D8 + (i * 2)), 0x00FF);
			AdpWordSet((ushort)(0x01FC + (i * 2)), 0x0000);
		}
		AdpWordSet(0x011F, 0x0001);
		AdpWordSet(0x0121, 0x0060);
		ushort di = AdpChannelTableBase;
		ushort cx = 9;
		while (cx != 0) {
			ushort si = AdpWord((ushort)(di + 0x24));
			AdpWordSet((ushort)(di + 0x12), si);
			AdpWordSet(di, 0xFFFF);
			if (si != 0) {
				ES = songSegment;
				SI = si;
				AX = cx;
				DI = di;
				AdpReadWaitValue_5BAE_08E1_05C401(0);
				AdpWordSet(di, (ushort)(AdpWord(di) + 1));
				cx = AX;
			}
			di = (ushort)(di + 2);
			cx--;
		}
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPTickHandler (0473). Main timer tick handler called from the host.
	/// Checks playback status, decrements the sub-tick counter, validates song integrity,
	/// calls ADPProcessTick when the sub-tick expires, rotates the fade bit-pattern and
	/// calls ADPFadeStep on carry. Returns status in AL, beat in BX, sub-beat in CX.
	/// <code>
	/// dnadp:0473  push ds / mov ax, cs / mov ds, ax
	/// dnadp:0478  cmp byte ptr [19ah], 0 / jns loc_004a0
	/// dnadp:047f  dec byte ptr [11eh] / jns loc_00497
	/// dnadp:0485  call ADPSongValidation / jnz loc_004a0
	/// dnadp:048f  call ADPProcessTick
	/// dnadp:0497  rol [19fh], 1 / jnb loc_004a0 / call ADPFadeStep
	/// dnadp:04a0  mov al, [19ah] / mov bx, [11fh] / mov cx, [121h] / pop ds / retf
	/// </code>
	/// </summary>
	public Action AdpTickHandler_5BAE_0473_05BF93(int gotoAddress) {
		_adpTickIndex++;
		CryogenicMcpTools.RecordAdpCall("5BAE:0473_TickInternal");
		ushort oldDs = DS;
		DS = CS;
		byte status = AdpByte(0x019A);
		if ((status & 0x80) != 0) {
			byte timerLo = AdpByte(0x011E);
			timerLo--;
			AdpByteSet(0x011E, timerLo);
			if ((timerLo & 0x80) != 0) {
				AdpSongValidation_5BAE_04AD_05BFCD(0);
				if (ZeroFlag) {
					ushort savedDx = DX;
					ushort savedSi = SI;
					ushort savedDi = DI;
					ushort savedBp = BP;
					ushort savedEs = ES;
					AdpProcessTick_5BAE_04D3_05BFF3(0);
					ES = savedEs;
					BP = savedBp;
					DI = savedDi;
					SI = savedSi;
					DX = savedDx;
				}
			}
			ushort fadePattern = AdpWord(0x019F);
			fadePattern = (ushort)((fadePattern << 1) | (fadePattern >> 15));
			AdpWordSet(0x019F, fadePattern);
			CarryFlag = (fadePattern & 0x0001) != 0;
			if (CarryFlag) {
				AdpFadeStep_5BAE_092D_05C44D(0);
			}
		}
		byte outStatus = AdpByte(0x019A);
		AX = Make16(outStatus, Hi8(AX));
		BX = AdpWord(0x011F);
		CX = AdpWord(0x0121);
		DS = oldDs;
		return FarRet();
	}

	/// <summary>
	/// Gist: ADPSongValidation (04AD). Validates the song data hasn't changed in memory.
	/// Compares three checksums stored at [03AC/03AE/03B0] against live values at
	/// ES:SI, ES:SI+0x4000, and ES:SI-0x8000. Sets ZF if all match.
	/// <code>
	/// dnadp:04ad  push si / push es / les si, [3a8h]
	/// dnadp:04b3  mov ax, es:[si] / cmp [3ach], ax / jnz loc_004d0
	/// dnadp:04bc  mov ax, es:[si+4000h] / cmp [3aeh], ax / jnz loc_004d0
	/// dnadp:04c7  mov ax, es:[si-8000h] / cmp [3b0h], ax
	/// dnadp:04d0  pop es / pop si / ret
	/// </code>
	/// </summary>
	public Action AdpSongValidation_5BAE_04AD_05BFCD(int gotoAddress) {
		ushort songOff = AdpWord(0x03A8);
		ushort songSeg = AdpWord(0x03AA);
		ushort a = SegWord(songSeg, songOff);
		ushort b = AdpWord(0x03AC);
		ushort c = SegWord(songSeg, (ushort)(songOff + 0x4000));
		ushort d = AdpWord(0x03AE);
		ushort e = SegWord(songSeg, (ushort)(songOff - 0x8000));
		ushort f = AdpWord(0x03B0);
		ZeroFlag = a == b && c == d && e == f;
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPProcessTick (04D3). Core per-tick event processing for all 9 channels.
	/// Adds tempo word to the tick accumulator, calls ADPLoopPointCheck, then iterates
	/// channels: decrement wait, dispatch opcodes (NoteOn/Off, ProgramChange, PitchBend,
	/// VolumeModulation, EndOfTrack) via handler table at [0125], or apply glide/vibrato
	/// for non-zero waits. Decrements the sub-beat counter and advances beat on rollover.
	/// <code>
	/// dnadp:04d3  les bx, [115h] / mov ax, es:[bx+30h] / add [11dh], ax
	/// dnadp:04e2  call ADPLoopPointCheck / mov cx, 9
	/// dnadp:04e8  dec word ptr [di] / jnz loc_0052a
	/// dnadp:04f5  es:lodsw / ... / call word ptr [bx+125h]
	/// dnadp:051a  dec byte ptr [121h] / ... / inc word ptr [11fh]
	/// </code>
	/// </summary>
	public Action AdpProcessTick_5BAE_04D3_05BFF3(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:04D3_ProcessTick");
		ushort songOff = AdpWord(0x0115);
		ushort songSeg = AdpWord(0x0117);
		ushort tempoWord = SegWord(songSeg, (ushort)(songOff + 0x30));
		AdpWordSet(0x011D, (ushort)(AdpWord(0x011D) + tempoWord));
		DI = AdpChannelTableBase;
		ES = songSeg;
		BX = songOff;
		AdpLoopPointCheck_5BAE_0553_05C073(0);
		ushort cx = 9;
		while (cx != 0) {
			ushort wait = (ushort)(AdpWord(DI) - 1);
			AdpWordSet(DI, wait);
			if (wait != 0) {
				if (AdpByte((ushort)(DI + 0x5A)) != 0 && AdpWord((ushort)(DI + 0x12)) != 0) {
					AdpByteSet((ushort)(DI + 0x5A), (byte)(AdpByte((ushort)(DI + 0x5A)) - 1));
					ushort phaseWord = AdpWord((ushort)(DI + 0x6C));
					byte phaseLo = Lo8(phaseWord);
					byte phaseHi = Hi8(phaseWord);
					phaseLo = (byte)(phaseLo + phaseHi);
					AdpByteSet((ushort)(DI + 0x6C), phaseLo);
					DX = (ushort)((DI - AdpChannelTableBase) >> 1);
					AdpPitchBendBody_5BAE_07EF_05C30F(0);
				}
			} else {
				while (AdpWord(DI) == 0) {
					SI = AdpWord((ushort)(DI + 0x12));
					if (SI == 0) {
						break;
					}
					AX = SegWord(ES, SI);
					SI = (ushort)(SI + 2);
					DX = (ushort)((DI - AdpChannelTableBase) >> 1);
					byte handler = (byte)((AX >> 4) & 0x07);
					switch (handler) {
						case 0:
							AdpNoteOff_5BAE_065B_05C17B(0);
							break;
						case 1:
							AdpNoteOn_5BAE_062C_05C14C(0);
							break;
						case 2:
						case 3:
							AdpReadWaitValue_5BAE_08E1_05C401(0);
							break;
						case 4:
							AdpProgramChange_5BAE_05AA_05C0CA(0);
							break;
						case 5:
							AdpVolumeModulation_5BAE_06A8_05C1C8(0);
							break;
						case 6:
							AdpPitchBend_5BAE_07EA_05C30A(0);
							break;
						case 7:
							AdpEndOfTrack_5BAE_066F_05C18F(0);
							break;
					}
					if (AdpWord(DI) != 0) {
						break;
					}
				}
			}
			DI = (ushort)(DI + 2);
			cx--;
		}
		byte sub = AdpByte(0x0121);
		sub--;
		AdpByteSet(0x0121, sub);
		if (sub == 0) {
			AdpByteSet(0x0121, 0x60);
			AdpWordSet(0x011F, (ushort)(AdpWord(0x011F) + 1));
		}
		CryogenicMcpTools.RecordAdpSchedulerState(AdpWord(0x011F), AdpWord(0x0121));
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPLoopPointCheck (0553). Manages song loop points.
	/// If loop counter is zero: snapshot channel state at the loop-start beat.
	/// If loop counter is non-zero: at the loop-end beat, restore the snapshot and
	/// decrement the loop counter, rewinding playback to the loop-start beat.
	/// <code>
	/// dnadp:0553  cmp word ptr [123h], 0 / jnz loc_00585
	/// dnadp:055a  mov ax, es:[bx+2ah] / cmp ax, [11fh]  ; check loop-start beat
	/// dnadp:056f  add di, 0eah / ... / rep movsw        ; snapshot state
	/// dnadp:0585  mov ax, es:[bx+2ch] / cmp ax, [11fh]  ; check loop-end beat
	/// dnadp:058f  dec word ptr [123h] / ... / rep movsw  ; restore state
	/// </code>
	/// </summary>
	public Action AdpLoopPointCheck_5BAE_0553_05C073(int gotoAddress) {
		if (AdpWord(0x0123) == 0) {
			if (SegWord(ES, (ushort)(BX + 0x2A)) == AdpWord(0x011F) && AdpWord(0x0121) == 0x0060) {
				for (int i = 0; i < 0x12; i++) {
					AdpWordSet((ushort)(DI + 0xEA + (i * 2)), AdpWord((ushort)(DI + (i * 2))));
				}
				AdpWordSet(0x0123, (ushort)(SegWord(ES, (ushort)(BX + 0x2E)) - 1));
			}
			return NearRet();
		}

		if (SegWord(ES, (ushort)(BX + 0x2C)) == AdpWord(0x011F)) {
			AdpWordSet(0x0123, (ushort)(AdpWord(0x0123) - 1));
			for (int i = 0; i < 0x12; i++) {
				AdpWordSet((ushort)(DI + (i * 2)), AdpWord((ushort)(DI + 0xEA + (i * 2))));
			}
			AdpWordSet(0x011F, SegWord(ES, (ushort)(BX + 0x2A)));
		}
		return NearRet();
	}

	/// <summary>
	/// Gist: ADP_OP_ProgramChange (05AA). Loads a new instrument for the current channel.
	/// Reads instrument index from AH, computes offset into instrument table (×0x28 stride),
	/// loads operator levels, sensitivity, envelope, feedback/connection, transpose, vibrato,
	/// then calls ADPInstrumentWrite to program both OPL operators.
	/// <code>
	/// dnadp:05aa  call ADPReadWaitValue / cmp [di+36h], ah / jz ret
	/// dnadp:05b5  mov al, 28h / mul ah / les si, [119h] / add si, ax
	/// dnadp:05c3  mov [di+48h], ax   ; transpose word
	/// dnadp:0627  call ADPInstrumentWrite / pop ds / ret
	/// </code>
	/// </summary>
	public Action AdpProgramChange_5BAE_05AA_05C0CA(int gotoAddress) {
		AdpReadWaitValue_5BAE_08E1_05C401(0);
		if (AdpByte((ushort)(DI + 0x36)) == Hi8(AX)) {
			return NearRet();
		}
		AdpByteSet((ushort)(DI + 0x36), Hi8(AX));
		byte instrument = Hi8(AX);
		ushort instrumentOffset = (ushort)(instrument * 0x28);
		ushort instTableOff = (ushort)(AdpWord(0x0119) + instrumentOffset);
		ushort instTableSeg = AdpWord(0x011B);

		AdpWordSet((ushort)(DI + 0x48), SegWord(instTableSeg, (ushort)(instTableOff + 0x21)));
		byte ah = SegByte(instTableSeg, (ushort)(instTableOff + 0x17));
		byte al = SegByte(instTableSeg, (ushort)(instTableOff + 0x0A));
		byte bh = SegByte(instTableSeg, (ushort)(instTableOff + 0x02));
		byte bl = SegByte(instTableSeg, (ushort)(instTableOff + 0x0F));
		ushort bx = Make16(bl, bh);
		bx = (ushort)(bx & 0x0303);
		bx = (ushort)((bx >> 2) | (bx << 14));
		ushort ax = Make16(al, ah);
		ax = (ushort)(ax | bx);
		AdpWordSet((ushort)(DI + 0x90), ax);
		AdpWordSet((ushort)(DI + 0x7E), SegWord(instTableSeg, (ushort)(instTableOff + 0x1E)));
		AdpWordSet((ushort)(DI + 0xC6), SegWord(instTableSeg, (ushort)(instTableOff + 0x26)));

		al = SegByte(instTableSeg, (ushort)(instTableOff + 0x0E));
		al = (byte)~al;
		al = (byte)((al >> 1) | (al << 7));
		ah = SegByte(instTableSeg, (ushort)(instTableOff + 0x04));
		ax = (ushort)(Make16(al, ah) << 1);
		al = SegByte(instTableSeg, (ushort)(instTableOff + 0x20));
		ax = Make16(al, Hi8(ax));
		AdpWordSet((ushort)(DI + 0xB4), ax);

		al = SegByte(instTableSeg, (ushort)(instTableOff + 0x1B));
		AdpWordSet((ushort)(DI + 0xD8), Make16(al, Hi8(ax)));
		ax = SegWord(instTableSeg, (ushort)(instTableOff + 0x23));
		AdpByteSet((ushort)(DI + 0x6D), Hi8(ax));
		AdpWordSet((ushort)(DI + 0x5A), Make16(0, Lo8(ax)));

		DX = (ushort)((DI - AdpChannelTableBase) >> 1);
		ushort oldDs = DS;
		SI = (ushort)(instTableOff + 2);
		DS = instTableSeg;
		AdpInstrumentWrite_5BAE_09AB_05C4CB(0);
		DS = oldDs;
		return NearRet();
	}

	/// <summary>
	/// Gist: ADP_OP_NoteOn (062C). Triggers a note on the current channel.
	/// Reads velocity byte from stream (lodsb), calls ADPReadWaitValue, sets envelope
	/// via ADP_OP_EnvelopeSetup. If a note is currently playing, silences it first.
	/// Extracts note from AH of dispatch word, adds transpose [DI+49h], converts to
	/// OPL pitch via ADPOplNoteOn.
	/// <code>
	/// dnadp:062c  es:lodsb / call ADPReadWaitValue / push ax
	/// dnadp:0632  call ADP_OP_EnvelopeSetup
	/// dnadp:0635  cmp byte ptr [di+37h], 0 / jz loc_00640
	/// dnadp:063b  xor ax, ax / call ADPOplFrequencyWrite  ; silence prev note
	/// dnadp:0640  pop ax / mov al, ah / add al, [di+49h]  ; note + transpose
	/// dnadp:0648  mov [di+37h], al / sub ax, 48h
	/// dnadp:0658  jmp ADPOplNoteOn
	/// </code>
	/// </summary>
	public Action AdpNoteOn_5BAE_062C_05C14C(int gotoAddress) {
		byte note = SegByte(ES, SI);
		SI = (ushort)(SI + 1);
		AX = Make16(note, Hi8(AX));
		AdpReadWaitValue_5BAE_08E1_05C401(0);
		ushort savedAx = AX;
		AdpEnvelopeSetup_5BAE_0740_05C260(0);
		if (AdpByte((ushort)(DI + 0x37)) != 0) {
			AX = 0;
			AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(0);
		}
		AX = savedAx;
		byte al = Hi8(AX);
		al = (byte)(al + AdpByte((ushort)(DI + 0x49)));
		AdpByteSet((ushort)(DI + 0x37), al);
		AX = (ushort)(al - 0x48);
		AdpByteSet((ushort)(DI + 0x5A), AdpByte((ushort)(DI + 0x5B)));
		AdpByteSet((ushort)(DI + 0x6C), 0x40);
		AdpOplNoteOn_5BAE_0A58_05C578(0);
		return NearRet();
	}

	/// <summary>
	/// Gist: ADP_OP_NoteOff (065B). Releases a note on the current channel.
	/// Skips one stream byte (inc si), reads wait value, then compares
	/// AH+transpose with current note. If they match, clears the note and
	/// calls ADPOplNoteOff; otherwise does nothing (note already replaced).
	/// <code>
	/// dnadp:065b  inc si / call ADPReadWaitValue
	/// dnadp:065f  add ah, [di+49h] / cmp [di+37h], ah / jnz ret
	/// dnadp:0667  mov byte ptr [di+37h], 0 / jmp ADPOplNoteOff
	/// </code>
	/// </summary>
	public Action AdpNoteOff_5BAE_065B_05C17B(int gotoAddress) {
		SI = (ushort)(SI + 1);
		AdpReadWaitValue_5BAE_08E1_05C401(0);
		byte ah = (byte)(Hi8(AX) + AdpByte((ushort)(DI + 0x49)));
		if (AdpByte((ushort)(DI + 0x37)) == ah) {
			AdpByteSet((ushort)(DI + 0x37), 0);
			AdpOplNoteOff_5BAE_0A87_05C5A7(0);
		}
		return NearRet();
	}

	/// <summary>
	/// Gist: ADP_OP_EndOfTrack (066F). Handles end-of-track for a channel.
	/// Sets channel wait to 0xFFFF and rewinds stream pointer by 2.
	/// For channel 0 (DX==0): decrements the tick flag; if zero, fills all
	/// channel waits with 0xFFFF and calls ADPReset. If the tick flag was
	/// positive, re-initializes the channel table for looped playback.
	/// <code>
	/// dnadp:066f  mov word ptr [di], 0ffffh / sub byte ptr [di+12h], 2
	/// dnadp:0677  or dx, dx / jnz ret
	/// dnadp:067b  dec byte ptr [19bh] / jz loc_00697
	/// dnadp:0687  call loc_00444  ; reinit channels
	/// dnadp:0697  ... / call ADPReset / ret
	/// </code>
	/// </summary>
	public Action AdpEndOfTrack_5BAE_066F_05C18F(int gotoAddress) {
		AdpWordSet(DI, 0xFFFF);
		AdpByteSet((ushort)(DI + 0x12), (byte)(AdpByte((ushort)(DI + 0x12)) - 2));
		if (DX != 0) {
			return NearRet();
		}
		byte tickFlag = (byte)(AdpByte(0x019B) - 1);
		AdpByteSet(0x019B, tickFlag);
		if (tickFlag == 0) {
			ushort fillDi = AdpChannelTableBase;
			for (int i = 0; i < 9; i++) {
				AdpWordSet(fillDi, 0xFFFF);
				fillDi = (ushort)(fillDi + 2);
			}
			AdpReset_5BAE_02FE_05BE1E(0);
			return NearRet();
		}
		if ((tickFlag & 0x80) != 0) {
			AdpByteSet(0x019B, (byte)(tickFlag + 1));
		}
		AdpWordSet(0x011F, 1);
		AdpWordSet(0x0121, 0x60);
		ushort loopDi = AdpChannelTableBase;
		for (ushort cx = 9; cx > 0; cx--) {
			ushort ptr = AdpWord((ushort)(loopDi + 0x24));
			AdpWordSet((ushort)(loopDi + 0x12), ptr);
			AdpWordSet(loopDi, 0xFFFF);
			if (ptr != 0) {
				ES = AdpWord(0x0117);
				SI = ptr;
				AX = cx;
				DI = loopDi;
				AdpReadWaitValue_5BAE_08E1_05C401(0);
				AdpWordSet(loopDi, (ushort)(AdpWord(loopDi) + 1));
			}
			loopDi = (ushort)(loopDi + 2);
		}
		ES = AdpWord(0x0117);
		BX = AdpWord(0x0115);
		DI = AdpChannelTableBase;
		AdpLoopPointCheck_5BAE_0553_05C073(0);
		AdpWordSet(DI, (ushort)(AdpWord(DI) - 1));
		return NearRet();
	}

	/// <summary>
	/// Gist: ADP_OP_VolumeModulation (06A8). Applies velocity-based volume modulation.
	/// Reads a volume byte from AH, computes inverse velocity (0x80-AH), then scales
	/// both operators' levels and the feedback register based on channel sensitivity
	/// values at [DI+C6h] and [DI+D8h]. Writes OPL registers 40h+ and C0h+.
	/// <code>
	/// dnadp:06a8  call ADPReadWaitValue / mov al, 80h / sub al, ah
	/// dnadp:06b1  mov bx, [di+0a2h] / mov cx, [di+0c6h]
	/// dnadp:06bd  ... / shr al, cl / sub ah, al  ; scale operator level
	/// dnadp:06e3  call ADPOplRegisterWrite
	/// dnadp:0714  mov cx, [di+0d8h]  ; feedback sensitivity
	/// </code>
	/// </summary>
	public Action AdpVolumeModulation_5BAE_06A8_05C1C8(int gotoAddress) {
		AdpReadWaitValue_5BAE_08E1_05C401(0);
		byte al = 0x80;
		byte ah = Hi8(AX);
		al = (byte)(al - ah);
		byte tmp = ah;
		ah = al;
		al = tmp;
		ushort bx = AdpWord((ushort)(DI + 0xA2));
		ushort cx = AdpWord((ushort)(DI + 0xC6));
		if (Lo8(cx) != 0) {
			byte cl = Lo8(cx);
			byte scaleAl = al;
			if ((cl & 0x80) != 0) {
				cl = (byte)(0 - cl);
				scaleAl = ah;
			}
			cl = (byte)(0 - (byte)(cl - 4));
			scaleAl = (byte)(scaleAl >> cl);
			byte reg = (byte)(Lo8(bx) & 0x3F);
			reg = reg >= scaleAl ? (byte)(reg - scaleAl) : (byte)0;
			byte flags = (byte)(Lo8(bx) & 0xC0);
			byte outAh = (byte)(reg | flags);
			byte oplReg = (byte)(AdpByte((ushort)(0x0171 + DX)) + 0x40);
			AX = Make16(oplReg, outAh);
			AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		}
		if (Hi8(cx) != 0) {
			byte ch = Hi8(cx);
			byte scaleAl = al;
			if ((ch & 0x80) != 0) {
				ch = (byte)(0 - ch);
				scaleAl = ah;
			}
			byte shr = (byte)(4 - ch);
			scaleAl = (byte)(scaleAl >> shr);
			byte reg = (byte)(Hi8(bx) & 0x3F);
			reg = reg >= scaleAl ? (byte)(reg - scaleAl) : (byte)0;
			byte flags = (byte)(Hi8(bx) & 0xC0);
			byte outAh = (byte)(reg | flags);
			byte oplReg = (byte)(AdpByte((ushort)(0x017A + DX)) + 0x40);
			AX = Make16(oplReg, outAh);
			AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		}
		cx = AdpWord((ushort)(DI + 0xD8));
		if (Lo8(cx) != 0) {
			byte cl = Lo8(cx);
			byte scaleAl = al;
			if ((cl & 0x80) != 0) {
				cl = (byte)(0 - cl);
				scaleAl = ah;
			}
			cl = (byte)(0 - (byte)(cl - 6));
			scaleAl = (byte)(scaleAl >> cl);
			scaleAl = (byte)(scaleAl & 0xFE);
			scaleAl = (byte)(scaleAl + Hi8(cx));
			if (scaleAl > 0x0F) {
				scaleAl = (byte)((scaleAl & 0x0F) | 0x0E);
			}
			AdpByteSet((ushort)(DI + 0xD9), scaleAl);
			AX = Make16((byte)(0xC0 + DX), scaleAl);
			AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		}
		return NearRet();
	}

	/// <summary>
	/// Gist: ADP_OP_EnvelopeSetup (0740). Sets operator levels from note velocity.
	/// Computes inverse velocity (0x80 - AL), scales both operators using sensitivity
	/// [DI+7Eh], adds the scaled value to each operator's base level [DI+90h], clamps
	/// to 0x3F, and writes OPL register 40h+slot. Also handles feedback at [DI+B4h].
	/// <code>
	/// dnadp:0740  mov ah, al / mov al, 80h / sub al, ah
	/// dnadp:0746  mov bx, [di+90h] / mov cx, [di+7eh]
	/// dnadp:0758  sub cl, 4 / neg cl / shr al, cl  ; sensitivity scaling
	/// dnadp:0764  add ah, al / cmp ah, 3fh / jbe loc_0076d / mov ah, 3fh
	/// dnadp:077c  call ADPOplRegisterWrite
	/// </code>
	/// </summary>
	public Action AdpEnvelopeSetup_5BAE_0740_05C260(int gotoAddress) {
		byte ah = Lo8(AX);
		byte al = (byte)(0x80 - ah);
		ushort bx = AdpWord((ushort)(DI + 0x90));
		ushort cx = AdpWord((ushort)(DI + 0x7E));

		if (Lo8(cx) != 0) {
			byte cl = Lo8(cx);
			byte scaleAl = al;
			if ((cl & 0x80) != 0) {
				cl = (byte)(0 - cl);
				scaleAl = ah;
			}
			cl = (byte)(0 - (byte)(cl - 4));
			scaleAl = (byte)(scaleAl >> cl);
			byte reg = (byte)(Lo8(bx) & 0x3F);
			reg = (byte)(reg + scaleAl);
			if (reg > 0x3F) {
				reg = 0x3F;
			}
			Lo8(ref bx, (byte)((Lo8(bx) & 0xC0) | reg));
			byte oplReg = (byte)(AdpByte((ushort)(0x0171 + DX)) + 0x40);
			AX = Make16(oplReg, Lo8(bx));
			AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		}

		if (Hi8(cx) != 0) {
			byte ch = Hi8(cx);
			byte scaleAl = al;
			if ((ch & 0x80) != 0) {
				ch = (byte)(0 - ch);
				scaleAl = ah;
			}
			byte shr = (byte)(4 - ch);
			scaleAl = (byte)(scaleAl >> shr);
			byte reg = (byte)(Hi8(bx) & 0x3F);
			reg = (byte)(reg + scaleAl);
			if (reg > 0x3F) {
				reg = 0x3F;
			}
			Hi8(ref bx, (byte)((Hi8(bx) & 0xC0) | reg));
			byte oplReg = (byte)(AdpByte((ushort)(0x017A + DX)) + 0x40);
			AX = Make16(oplReg, Hi8(bx));
			AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		}

		AdpWordSet((ushort)(DI + 0xA2), bx);
		cx = AdpWord((ushort)(DI + 0xB4));
		if (Lo8(cx) == 0) {
			AdpByteSet((ushort)(DI + 0xD9), Hi8(cx));
			return NearRet();
		}
		byte cl2 = Lo8(cx);
		byte scale = al;
		if ((cl2 & 0x80) != 0) {
			cl2 = (byte)(0 - cl2);
			scale = ah;
		}
		cl2 = (byte)(0 - (byte)(cl2 - 6));
		scale = (byte)(scale >> cl2);
		scale = (byte)(scale & 0xFE);
		scale = (byte)(scale + Hi8(cx));
		if (scale > 0x0F) {
			scale = (byte)((scale & 0x0F) | 0x0E);
		}
		AdpByteSet((ushort)(DI + 0xD9), scale);
		AX = Make16((byte)(0xC0 + DX), scale);
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		return NearRet();
	}

	private static void Lo8(ref ushort value, byte lo) {
		value = (ushort)((value & 0xFF00) | lo);
	}

	private static void Hi8(ref ushort value, byte hi) {
		value = (ushort)((value & 0x00FF) | (hi << 8));
	}

	/// <summary>
	/// Gist: ADP_OP_PitchBend (07EA). Opcode handler: extracts pitch from AH, reads wait,
	/// then falls through to ADPPitchBend.
	/// <code>
	/// dnadp:07ea  mov al, ah / call ADPReadWaitValue
	/// dnadp:07ef  ; fall through to ADPPitchBend
	/// </code>
	/// </summary>
	public Action AdpPitchBend_5BAE_07EA_05C30A(int gotoAddress) {
		byte al = Hi8(AX);
		AX = Make16(al, Hi8(AX));
		AdpReadWaitValue_5BAE_08E1_05C401(0);
		return AdpPitchBendBody_5BAE_07EF_05C30F(0);
	}

	/// <summary>
	/// Gist: ADPPitchBend (07EF). Computes pitch-bent frequency for the current channel.
	/// Uses the current note [DI+37h] and pitch byte in AL (center=0x40).
	/// Two modes based on [DI+48h]: mode 0 uses semitone interpolation tables at [0183/0184],
	/// mode 1 uses coarse 1/5-semitone tables at [0190]. Applies fractional sub-key bending
	/// to the base OPL frequency from the f-number table at [0147], then writes the key-on
	/// frequency via ADPOplFrequencyWrite.
	/// <code>
	/// dnadp:07ef  mov cl, [di+37h] / xor ch, ch / jcxz ret
	/// dnadp:07f9  sub al, 18h / div 0ch  ; compute octave/key
	/// dnadp:0800  cmp byte ptr [di+48h], 0 / jnz loc_00865
	/// dnadp:0806  sub ax, 40h / ...  ; center-relative bend
	/// dnadp:08de  jmp ADPOplFrequencyWrite
	/// </code>
	/// </summary>
	public Action AdpPitchBendBody_5BAE_07EF_05C30F(int gotoAddress) {
		byte note = AdpByte((ushort)(DI + 0x37));
		if (note == 0) {
			return NearRet();
		}
		byte pitch = Lo8(AX);
		byte semitone = (byte)(note - 0x18);
		byte octave = (byte)(semitone / 12);
		byte key = (byte)(semitone % 12);
		ushort freq;
		if (AdpByte((ushort)(DI + 0x48)) == 0) {
			int centered = pitch - 0x40;
			if (centered < 0) {
				centered = -centered;
				int fracMul = (centered & 0x1F) << 3;
				centered >>= 5;
				if (key < centered) {
					key = (byte)(key + 12 - centered);
					if (octave > 0) {
						octave--;
					}
				} else {
					key = (byte)(key - centered);
				}
				byte frac = AdpByte((ushort)(0x0183 + key));
				byte bend = (byte)((frac * fracMul) >> 8);
				freq = AdpWord((ushort)(0x0147 + key * 2));
				freq = (ushort)(freq - bend);
			} else {
				centered = centered + 1;
				int fracMul = (centered & 0x1F) << 3;
				centered >>= 5;
				key = (byte)(key + centered);
				if (key >= 12) {
					key -= 12;
					octave++;
				}
				byte frac = AdpByte((ushort)(0x0184 + key));
				byte bend = (byte)((frac * fracMul) >> 8);
				freq = AdpWord((ushort)(0x0147 + key * 2));
				freq = (ushort)(freq + bend);
			}
		} else {
			int centered = pitch - 0x40;
			if (centered < 0) {
				centered = -centered;
				int q = centered / 5;
				if (key < q) {
					key = (byte)(key + 12 - q);
					if (octave > 0) {
						octave--;
					}
				} else {
					key = (byte)(key - q);
				}
				ushort tbl = (ushort)(0x0190 + (key >= 6 ? 5 : 0));
				byte bend = AdpByte((ushort)(tbl + (centered % 5)));
				freq = AdpWord((ushort)(0x0147 + key * 2));
				freq = (ushort)(freq - bend);
			} else {
				int q = centered / 5;
				key = (byte)(key + q);
				if (key >= 12) {
					key -= 12;
					octave++;
				}
				ushort tbl = (ushort)(0x0190 + (key >= 6 ? 5 : 0));
				byte bend = AdpByte((ushort)(tbl + (centered % 5)));
				freq = AdpWord((ushort)(0x0147 + key * 2));
				freq = (ushort)(freq + bend);
			}
		}
		byte block = (byte)(octave << 2);
		byte freqHi = (byte)(Hi8(freq) | block);
		ushort outWord = Make16(Lo8(freq), freqHi);
		AdpWordSet((ushort)(0x015F + DX * 2), outWord);
		AX = (ushort)(outWord | 0x2000);
		AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(0);
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPReadWaitValue (08E1). Reads a variable-length wait value from the stream.
	/// Single byte if bit 7 is clear; multi-byte VLQ encoding if bit 7 is set.
	/// Stores the decoded wait at [DI], updated SI at [DI+12h], and preserves AX.
	/// <code>
	/// dnadp:08e1  push ax / xor ax, ax / es:lodsb
	/// dnadp:08e8  or al, al / jns loc_00914  ; single-byte fast path
	/// dnadp:08ec  mov ch, cl / mov cl, ah / mov ah, al / es:lodsb / js loop
	/// dnadp:08f8  and ax, 7f7fh / ... / shr cx, 1 / rcr ax, 1  ; bit packing
	/// dnadp:0914  mov [di], ax / mov [di+12h], si / pop ax / ret
	/// </code>
	/// </summary>
	public Action AdpReadWaitValue_5BAE_08E1_05C401(int gotoAddress) {
		ushort savedAx = AX;
		ushort ax = 0;
		byte al = SegByte(ES, SI);
		SI = (ushort)(SI + 1);
		if ((al & 0x80) != 0) {
			ushort cx = 0;
			while (true) {
				byte ch = Lo8(cx);
				byte cl = Hi8(ax);
				byte ah = al;
				al = SegByte(ES, SI);
				SI = (ushort)(SI + 1);
				cx = Make16(cl, ch);
				ax = Make16(al, ah);
				if ((al & 0x80) == 0) {
					ax = (ushort)(ax & 0x7F7F);
					cx = (ushort)(cx & 0x7F7F);
					byte cxLo = (byte)(Lo8(cx) << 1);
					cx = Make16(cxLo, Hi8(cx));
					cx = (ushort)(cx >> 1);
					al = (byte)(Lo8(ax) << 1);
					ax = Make16(al, Hi8(ax));
					ax = (ushort)(ax << 1);
					cx = (ushort)(cx >> 1);
					bool carry = (ax & 0x0001) != 0;
					ax = (ushort)((ax >> 1) | ((cx & 0x0001) << 15));
					_ = carry;
					cx = (ushort)(cx >> 1);
					ax = (ushort)((ax >> 1) | ((cx & 0x0001) << 15));
					if (cx != 0) {
						ax = 0xFFFF;
					}
					break;
				}
			}
		} else {
			ax = al;
		}
		AdpWordSet(DI, ax);
		AdpWordSet((ushort)(DI + 0x12), SI);
		AX = savedAx;
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPUnknown091B (091B). Loops through all 9 channels calling ADPOplNoteOff.
	/// Effectively an all-notes-off operation.
	/// <code>
	/// dnadp:091b  push ds / push cs / pop ds / mov cx, 9
	/// dnadp:0921  push cx / mov dx, cx / dec dx / call ADPOplNoteOff / pop cx
	/// dnadp:0929  loop loc_00921 / pop ds / ret
	/// </code>
	/// </summary>
	public Action AdpUnknown091B_5BAE_091B_05C43B(int gotoAddress) {
		for (ushort c = 9; c > 0; c--) {
			DX = (ushort)(c - 1);
			AdpOplNoteOff_5BAE_0A87_05C5A7(0);
		}
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPFadeStep (092D). Advances the volume fade by one step toward the target.
	/// Independently adjusts the low and high nibbles of the current volume [019C]
	/// toward the target [019D]. When target is reached, resets the fade pattern to 1
	/// and clears bit 6 of status. If volume reaches zero, calls ADPUnknown091B and
	/// clears the entire status byte.
	/// <code>
	/// dnadp:092d  mov al, [19ch] / cmp al, [19dh] / jnz loc_00942
	/// dnadp:0936  mov word ptr [19fh], 1 / and byte ptr [19ah], 0bfh / ret
	/// dnadp:0942  ... / inc ah / ... / add al, 10h / ...  ; nibble stepping
	/// dnadp:0978  call ADPUnknown091B / mov byte ptr [19ah], 0
	/// </code>
	/// </summary>
	public Action AdpFadeStep_5BAE_092D_05C44D(int gotoAddress) {
		byte current = AdpByte(0x019C);
		byte target = AdpByte(0x019D);
		if (current == target) {
			AdpWordSet(0x019F, 1);
			AdpByteSet(0x019A, (byte)(AdpByte(0x019A) & 0xBF));
			return NearRet();
		}
		byte ah = current;
		byte bl = target;
		byte bh = bl;
		byte lowCurrent = (byte)(current & 0x0F);
		byte lowTarget = (byte)(bl & 0x0F);
		if (lowCurrent != lowTarget) {
			ah++;
			if (lowCurrent > lowTarget) {
				ah -= 2;
			}
		}
		byte outValue = ah;
		byte highOut = (byte)(ah & 0xF0);
		byte highTarget = (byte)(bh & 0xF0);
		if (highOut != highTarget) {
			outValue = (byte)(outValue + 0x10);
			if (highOut > highTarget) {
				outValue = (byte)(outValue - 0x20);
			}
		}
		AdpByteSet(0x019C, outValue);
		if (outValue == 0) {
			AdpUnknown091B_5BAE_091B_05C43B(0);
			AdpByteSet(0x019A, 0);
		}
		AdpUnknown0982_5BAE_0982_05C4A2(0);
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPUnknown0982 (0982). Writes the current volume to the mixer register.
	/// Reads [019C] volume, writes register 0x26 to the OPL port+4. Also an entry point
	/// from ADPFadeStep after volume update.
	/// <code>
	/// dnadp:0982  mov al, cs:[19ch]
	/// dnadp:0986  mov ah, 26h / push dx
	/// dnadp:0989  mov dx, cs:[2b3h] / add dl, 4
	/// dnadp:0991  xchg al, ah / out dx, al / inc dx / xchg al, ah / out dx, al
	/// dnadp:0998  pop dx / ret
	/// </code>
	/// </summary>
	public Action AdpUnknown0982_5BAE_0982_05C4A2(int gotoAddress) {
		byte volume = AdpByte(0x019C);
		ushort port = AdpWord(0x02B3);
		if (port == 0) {
			port = 0x0388;
		}
		port = (ushort)(port + 4);
		Machine.OPL.WriteByte(port, 0x26);
		Machine.OPL.WriteByte((ushort)(port + 1), volume);
		AX = Make16(volume, Hi8(AX));
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPUnknown099A (099A). Initializes all 18 OPL operator slots to 0xFF level.
	/// Reads the slot-to-register mapping at [0171..0182], adds 0x80 to get the
	/// sustain/release register, and writes 0xFF (max attenuation / fastest release).
	/// <code>
	/// dnadp:099a  mov si, 171h / mov cx, 12h / mov ah, 0ffh
	/// dnadp:09a2  lodsb / add al, 80h / call ADPOplRegisterWrite / loop
	/// </code>
	/// </summary>
	public Action AdpUnknown099A_5BAE_099A_05C4BA(int gotoAddress) {
		for (int i = 0; i < 0x12; i++) {
			byte reg = (byte)(AdpByte((ushort)(0x0171 + i)) + 0x80);
			AX = Make16(reg, 0xFF);
			AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		}
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPInstrumentWrite (09AB). Programs both OPL operators for an instrument.
	/// Doubles DX to get the operator pair offset from [0135+BX], calls
	/// ADPInstrumentWriteLoop for the modulator, swaps DH/DL, adjusts SI by +0x0D,
	/// then falls through to ADPInstrumentWriteLoop for the carrier.
	/// <code>
	/// dnadp:09ab  add dx, dx / mov bx, dx / mov dx, cs:[bx+135h]
	/// dnadp:09b4  shr bx, 1 / call ADPInstrumentWriteLoop
	/// dnadp:09b9  xchg dh, dl / mov ah, [si+1bh] / add si, 0dh
	/// dnadp:09c1  jmp loc_009dc  ; into ADPInstrumentWriteLoop body
	/// </code>
	/// </summary>
	public Action AdpInstrumentWrite_5BAE_09AB_05C4CB(int gotoAddress) {
		DX = (ushort)(DX * 2);
		ushort bx = DX;
		DX = AdpWord((ushort)(0x0135 + bx));
		bx = (ushort)(bx >> 1);
		AdpInstrumentWriteLoop_5BAE_09C3_05C4E3(0);
		byte dl = Lo8(DX);
		byte dh = Hi8(DX);
		byte tmp = dl;
		dl = dh;
		dh = tmp;
		AX = Make16(Lo8(AX), SegByte(DS, (ushort)(SI + 0x1B)));
		SI = (ushort)(SI + 0x0D);
		return AdpInstrumentWriteLoop_5BAE_09C3_05C4E3(0);
	}

	/// <summary>
	/// Gist: ADPInstrumentWriteLoop (09C3). Programs one OPL operator from instrument data.
	/// Writes 6 OPL registers per operator: C0 (feedback/connection), E0 (waveform),
	/// 40 (key-scale/level), 60 (attack/decay), 80 (sustain/release), 20 (AM/VIB/EG/KSR/mult).
	/// Uses bit manipulation (ROR, SHL, NOT) to pack instrument fields into OPL register format.
	/// <code>
	/// dnadp:09c3  mov ah, [si+0ch] / shr ax, 1 / mov ah, [si+2] / not al / shl ax, 1
	/// dnadp:09d2  mov al, 0c0h / add al, bl / call ADPOplRegisterWrite
	/// dnadp:09e6  mov ah, [si+8] / mov al, [si] / ror ax, 1 ×2 / ... / call ADPOplRegisterWrite
	/// dnadp:0a34  mov al, [si+0bh] / ror ax, 1 / ... ×4 / and ax, 0f00fh / or ah, al
	/// dnadp:0a54  call ADPOplRegisterWrite / ret
	/// </code>
	/// </summary>
	public Action AdpInstrumentWriteLoop_5BAE_09C3_05C4E3(int gotoAddress) {
		byte dl = Lo8(DX);
		byte bl = Lo8(BX);
		byte al;
		byte ah;

		ah = SegByte(DS, (ushort)(SI + 0x0C));
		al = Lo8(AX);
		ushort ax = Make16(al, ah);
		ax = (ushort)(ax >> 1);
		ah = SegByte(DS, (ushort)(SI + 0x02));
		al = (byte)~Lo8(ax);
		ax = (ushort)(Make16(al, ah) << 1);
		ah = (byte)(Hi8(ax) & 0x0F);
		al = (byte)(0xC0 + bl);
		AX = Make16(al, ah);
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);

		ah = (byte)(SegByte(DS, (ushort)(SI + 0x1A)) & 0x03);
		al = (byte)(0xE0 + dl);
		AX = Make16(al, ah);
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);

		ah = SegByte(DS, (ushort)(SI + 0x08));
		al = SegByte(DS, SI);
		ah = (byte)(ah << 2);
		ushort rot = Make16(al, ah);
		rot = (ushort)((rot >> 2) | (rot << 14));
		al = (byte)(0x40 + dl);
		AX = Make16(al, Hi8(rot));
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);

		ah = SegByte(DS, (ushort)(SI + 0x03));
		al = SegByte(DS, (ushort)(SI + 0x06));
		al = (byte)(al << 4);
		ax = (ushort)(Make16(al, ah) << 4);
		al = (byte)(0x60 + dl);
		AX = Make16(al, Hi8(ax));
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);

		ah = SegByte(DS, (ushort)(SI + 0x04));
		al = SegByte(DS, (ushort)(SI + 0x07));
		al = (byte)(al << 4);
		ax = (ushort)(Make16(al, ah) << 4);
		al = (byte)(0x80 + dl);
		AX = Make16(al, Hi8(ax));
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);

		ah = SegByte(DS, (ushort)(SI + 0x0B));
		al = SegByte(DS, (ushort)(SI + 0x05));
		ushort r = Make16(al, ah);
		r = (ushort)((r >> 1) | (r << 15));
		ah = Hi8(r);
		al = SegByte(DS, (ushort)(SI + 0x0A));
		r = Make16(al, ah);
		r = (ushort)((r >> 1) | (r << 15));
		ah = Hi8(r);
		al = SegByte(DS, (ushort)(SI + 0x09));
		r = Make16(al, ah);
		r = (ushort)((r >> 1) | (r << 15));
		ah = Hi8(r);
		al = SegByte(DS, (ushort)(SI + 0x01));
		r = (ushort)(Make16(al, ah) & 0xF00F);
		r = (ushort)(r | Lo8(r));
		AX = Make16((byte)(0x20 + dl), Hi8(r));
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPOplNoteOn (0A58). Converts an adjusted note value to OPL frequency and triggers key-on.
	/// Adds 0x30 to AX, clamps to range [0, 0x60), divides by 12 for octave/key,
	/// looks up the f-number from the table at [0147], sets the block field,
	/// caches the frequency at [015F+ch*2], sets key-on bit, and calls ADPOplFrequencyWrite.
	/// <code>
	/// dnadp:0a58  add ax, 30h / cmp ax, 60h / jb loc_00a62 / xor ax, ax
	/// dnadp:0a62  mov bl, 0ch / div bl   ; AL=octave, AH=key
	/// dnadp:0a68  xchg ah, al / xor ah, ah / add ax, ax / mov si, ax
	/// dnadp:0a70  mov ax, [si+147h]       ; f-number lookup
	/// dnadp:0a74  shl cl, 1 / shl cl, 1 / or ah, cl  ; block bits
	/// dnadp:0a82  or ah, 20h / jmp ADPOplFrequencyWrite
	/// </code>
	/// </summary>
	public Action AdpOplNoteOn_5BAE_0A58_05C578(int gotoAddress) {
		AX = (ushort)(AX + 0x30);
		if (AX >= 0x60) {
			AX = 0;
		}
		byte octave = (byte)(Lo8(AX) / 12);
		byte note = (byte)(Lo8(AX) % 12);
		ushort freq = AdpWord((ushort)(0x0147 + note * 2));
		byte high = (byte)(Hi8(freq) | (octave << 2));
		ushort outWord = Make16(Lo8(freq), high);
		AdpWordSet((ushort)(0x015F + DX * 2), outWord);
		outWord = (ushort)(outWord | 0x2000);
		AX = outWord;
		return AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(0);
	}

	/// <summary>
	/// Gist: ADPOplNoteOff (0A87). Turns off a note by writing the cached frequency without key-on.
	/// Reads the stored frequency from [015F+ch*2] and falls through to ADPOplFrequencyWrite.
	/// <code>
	/// dnadp:0a87  mov si, dx / add si, si / mov ax, [si+15fh]
	/// dnadp:0a8f  ; fall through to ADPOplFrequencyWrite
	/// </code>
	/// </summary>
	public Action AdpOplNoteOff_5BAE_0A87_05C5A7(int gotoAddress) {
		AX = AdpWord((ushort)(0x015F + DX * 2));
		return AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(0);
	}

	/// <summary>
	/// Gist: ADPOplFrequencyWrite (0A8F). Writes a frequency word to OPL registers A0+ch and B0+ch.
	/// Low byte of AX → register A0+DX, high byte → register B0+DX.
	/// <code>
	/// dnadp:0a8f  mov cx, ax / mov al, dl / add al, 0a0h / mov ah, cl
	/// dnadp:0a97  mov si, ax / call ADPOplRegisterWrite
	/// dnadp:0a9c  mov ax, si / add al, 10h / mov ah, ch
	/// dnadp:0aa2  ; fall through to ADPOplRegisterWrite
	/// </code>
	/// </summary>
	public Action AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(int gotoAddress) {
		ushort cx = AX;
		AX = Make16((byte)(0xA0 + DX), Lo8(cx));
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		AX = Make16((byte)(0xB0 + DX), Hi8(cx));
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		return NearRet();
	}

	/// <summary>
	/// Gist: ADPOplRegisterWrite (0AA2). Writes one OPL register.
	/// AL = register number, AH = value. Writes to the base port [02B3] with
	/// appropriate timing delays (7 reads for index, 35 reads for data).
	/// <code>
	/// dnadp:0aa2  push dx / mov dx, 388h / out dx, al
	/// dnadp:0aa7  in al, dx ×7    ; index timing delay
	/// dnadp:0aae  inc dx / mov al, ah / out dx, al
	/// dnadp:0ab2  in al, dx ×35   ; data timing delay
	/// dnadp:0ad5  pop dx / ret
	/// </code>
	/// </summary>
	public Action AdpOplRegisterWrite_5BAE_0AA2_05C5C2(int gotoAddress) {
		byte register = Lo8(AX);
		byte value = Hi8(AX);
		CryogenicMcpTools.RecordAdpOplWrite(register, value, State.Cycles, _adpTickIndex);
		ushort basePort = AdpWord(0x02B3);
		if (basePort == 0) {
			basePort = 0x0388;
		}
		Machine.OPL.WriteByte(basePort, register);
		Machine.OPL.WriteByte((ushort)(basePort + 1), value);
		return NearRet();
	}
}

#pragma warning restore S1854
#pragma warning restore S4136
#pragma warning restore MA0051