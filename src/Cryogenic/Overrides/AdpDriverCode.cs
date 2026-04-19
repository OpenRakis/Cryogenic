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
		// Keep 5BAE:010F as original ASM (jmp 0473) to preserve call/return traceability.
		// The real tick logic remains overridden at 5BAE:0473.
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

	private static ushort RotateRight16(ushort value, int count) {
		int normalizedCount = count & 0x0F;
		if (normalizedCount == 0) {
			return value;
		}
		return (ushort)((value >> normalizedCount) | (value << (16 - normalizedCount)));
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
	/// FULL commented disasm from gist (dnadp:0100).
	/// <code>
	/// dnadp:0100  ADPInit_entry:
	/// dnadp:0100                  jmp     ADPInit
	/// </code>
	/// </summary>
	public Action AdpInit_5BAE_0100_05BBE0(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0100_Init");
		AdpInit_5BAE_02D8_05BDF8(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:0103).
	/// <code>
	/// dnadp:0103
	/// dnadp:0103  ADPOpen_entry:
	/// dnadp:0103                  jmp     ADPOpen
	/// </code>
	/// </summary>
	public Action AdpOpen_5BAE_0103_05BBE3(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0103_OpenSong");
		CryogenicMcpTools.RecordAdpSongOpen(ES, SI);
		AdpOpen_5BAE_03B2_05BED2(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:0106).
	/// <code>
	/// dnadp:0106
	/// dnadp:0106  ADPReset_entry:
	/// dnadp:0106                  jmp     ADPReset
	/// </code>
	/// </summary>
	public Action AdpReset_5BAE_0106_05BBE6(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0106_Reset");
		AdpReset_5BAE_02FE_05BE1E(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:0109).
	/// <code>
	/// dnadp:0109
	/// dnadp:0109  ADPSetTickEnabled_entry:
	/// dnadp:0109                  jmp     ADPSetTimerTickFlag
	/// </code>
	/// </summary>
	public Action AdpSetTickEnabled_5BAE_0109_05BBE9(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0109_SetTickEnabled");
		AdpSetTimerTickFlag_5BAE_039C_05BEBC(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:010c).
	/// <code>
	/// dnadp:010c
	/// dnadp:010c  ADPSetDynamics_entry:
	/// dnadp:010c                  jmp     ADPSetDynamicsCurve
	/// </code>
	/// </summary>
	public Action AdpSetDynamics_5BAE_010C_05BBEC(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:010C_SetDynamics");
		AdpSetDynamicsCurve_5BAE_035B_05BE7B(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:010f).
	/// <code>
	/// dnadp:010f
	/// dnadp:010f  ADPTick_entry:
	/// dnadp:010f                  jmp     ADPTickHandler
	/// </code>
	/// </summary>
	public Action AdpTick_5BAE_010F_05BBEF(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:010F_Tick");
		AdpTickHandler_5BAE_0473_05BF93(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:0112).
	/// <code>
	/// dnadp:0112
	/// dnadp:0112  ADPSetVolume_entry:
	/// dnadp:0112                  jmp     ADPSetVolume
	/// dnadp:0115
	/// dnadp:0125  data_00125      dw ADP_OP_NoteOff
	/// dnadp:0127                  dw ADP_OP_NoteOn
	/// dnadp:0129                  dw ADPReadWaitValue
	/// dnadp:012b                  dw ADPReadWaitValue
	/// dnadp:012d                  dw ADP_OP_ProgramChange
	/// dnadp:012f                  dw ADP_OP_VolumeModulation
	/// dnadp:0131                  dw ADP_OP_PitchBend
	/// dnadp:0133                  dw ADP_OP_EndOfTrack
	/// </code>
	/// </summary>
	public Action AdpSetVolume_5BAE_0112_05BBF2(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0112_SetVolume");
		AdpSetVolume_5BAE_0348_05BE68(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:02b5).
	/// <code>
	/// dnadp:02b5
	/// dnadp:02b5  ADPInitInternal:                              ; CODE XREF: dnadp:02e1
	/// dnadp:02b5                  push    ss
	/// dnadp:02b6                  pop     es
	/// dnadp:02b7                  mov     si, bp
	/// dnadp:02b9
	/// dnadp:02b9  loc_002b9:                                    ; CODE XREF: dnadp:02d5
	/// dnadp:02b9                  es:lodsw
	/// dnadp:02bb                  add     ax, 2
	/// dnadp:02be                  mov     di, ax
	/// dnadp:02c0                  push    cx
	/// dnadp:02c1                  mov     cx, 9
	/// dnadp:02c4                  mov     al, 2eh
	/// dnadp:02c6                  repnz scasb
	/// dnadp:02c8                  pop     cx
	/// dnadp:02c9                  jnz     loc_002d5
	/// dnadp:02cb                  mov     ax, cs:[2b0h]
	/// dnadp:02cf                  stosw
	/// dnadp:02d0                  mov     al, cs:[2b2h]
	/// dnadp:02d4                  stosb
	/// dnadp:02d5
	/// dnadp:02d5  loc_002d5:                                    ; CODE XREF: dnadp:02c9
	/// dnadp:02d5                  loop    loc_002b9
	/// dnadp:02d7                  ret
	/// </code>
	/// </summary>
	public Action AdpInitInternal_5BAE_02B5_05BDD5(int gotoAddress) {
		ES = SS;
		SI = BP;
		ushort count = CX;
		while (count != 0) {
			AX = SegWord(ES, SI);
			SI = (ushort)(SI + 2);
			AX = (ushort)(AX + 2);
			DI = AX;

			ushort scanCount = 9;
			bool found = false;
			while (scanCount != 0) {
				byte value = SegByte(ES, DI);
				DI = (ushort)(DI + 1);
				scanCount--;
				if (value == 0x2E) {
					found = true;
					break;
				}
			}

			if (found) {
				SegWordSet(ES, DI, AdpWord(0x02B0));
				SegByteSet(ES, (ushort)(DI + 2), AdpByte(0x02B2));
				DI = (ushort)(DI + 3);
			}

			count--;
		}
		CX = 0;
		return NearRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:02d8).
	/// <code>
	/// dnadp:02d8
	/// dnadp:02d8  ADPInit:                                      ; CODE XREF: dnadp:0100
	/// dnadp:02d8                  and     ax, 0fffh
	/// dnadp:02db                  jz      loc_002e1
	/// dnadp:02dd                  mov     cs:[2b3h], ax
	/// dnadp:02e1
	/// dnadp:02e1  loc_002e1:                                    ; CODE XREF: dnadp:02db
	/// dnadp:02e1                  call    ADPInitInternal
	/// dnadp:02e4                  mov     ax, 2001h
	/// dnadp:02e7                  call    ADPOplRegisterWrite
	/// dnadp:02ea                  mov     ax, 0bdh
	/// dnadp:02ed                  call    ADPOplRegisterWrite
	/// dnadp:02f0                  mov     ax, 4008h
	/// dnadp:02f3                  call    ADPOplRegisterWrite
	/// dnadp:02f6                  push    cs
	/// dnadp:02f7                  call    ADPReset
	/// dnadp:02fa                  mov     bx, 0f00h
	/// dnadp:02fd                  retf
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
	/// FULL commented disasm from gist (dnadp:02fe).
	/// <code>
	/// dnadp:02fe
	/// dnadp:02fe  ADPReset:                                     ; CODE XREF: dnadp:0106, dnadp:02f7, dnadp:06a4
	/// dnadp:02fe                  pushf
	/// dnadp:02ff                  cli
	/// dnadp:0300                  call    ADPUnknown091B
	/// dnadp:0303                  xor     ax, ax
	/// dnadp:0305                  mov     cs:[19ah], al
	/// dnadp:0309                  popf
	/// dnadp:030a                  retf
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
	/// FULL commented disasm from gist (dnadp:030b).
	/// <code>
	/// dnadp:030b
	/// dnadp:030b  ADPResetInternal_body:                        ; CODE XREF: dnadp:0348, dnadp:035e
	/// dnadp:030b                  push    bx
	/// dnadp:030c                  push    dx
	/// dnadp:030d                  shr     al, 1
	/// dnadp:030f                  shr     al, 1
	/// dnadp:0311                  shr     al, 1
	/// dnadp:0313                  mov     dx, ax
	/// dnadp:0315                  mov     bx, 0f078h
	/// dnadp:0318                  cmp     ah, bl
	/// dnadp:031a                  jbe     loc_0031e
	/// dnadp:031c                  mov     ah, bl
	/// dnadp:031e
	/// dnadp:031e  loc_0031e:                                    ; CODE XREF: dnadp:031a
	/// dnadp:031e                  xor     al, al
	/// dnadp:0320                  div     bh
	/// dnadp:0322                  mul     dl
	/// dnadp:0324                  xchg    ah, dh
	/// dnadp:0326                  sub     ah, bh
	/// dnadp:0328                  neg     ah
	/// dnadp:032a                  cmp     ah, bl
	/// dnadp:032c                  jbe     loc_00330
	/// dnadp:032e                  mov     ah, bl
	/// dnadp:0330
	/// dnadp:0330  loc_00330:                                    ; CODE XREF: dnadp:032c
	/// dnadp:0330                  xor     al, al
	/// dnadp:0332                  div     bh
	/// dnadp:0334                  mul     dl
	/// dnadp:0336                  shr     ax, 1
	/// dnadp:0338                  shr     ax, 1
	/// dnadp:033a                  shr     ax, 1
	/// dnadp:033c                  shr     ax, 1
	/// dnadp:033e                  mov     ah, dh
	/// dnadp:0340                  and     ax, 0ff0h
	/// dnadp:0343                  or      al, ah
	/// dnadp:0345                  pop     dx
	/// dnadp:0346                  pop     bx
	/// dnadp:0347                  ret
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
	/// FULL commented disasm from gist (dnadp:0348).
	/// <code>
	/// dnadp:0348
	/// dnadp:0348  ADPSetVolume:                                 ; CODE XREF: dnadp:0112
	/// dnadp:0348                  call    ADPResetInternal_body
	/// dnadp:034b                  mov     cs:[19eh], al
	/// dnadp:034f                  mov     cs:[19dh], al
	/// dnadp:0353                  mov     word ptr cs:[19fh], 0ffffh
	/// dnadp:035a                  retf
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
	/// FULL commented disasm from gist (dnadp:035b).
	/// <code>
	/// dnadp:035b
	/// dnadp:035b  ADPSetDynamicsCurve:                          ; CODE XREF: dnadp:010c
	/// dnadp:035b                  push    ax
	/// dnadp:035c                  mov     ax, bx
	/// dnadp:035e                  call    ADPResetInternal_body
	/// dnadp:0361                  mov     cs:[19dh], al
	/// dnadp:0365                  pop     ax
	/// dnadp:0366                  mov     bx, 0ffffh
	/// dnadp:0369                  cmp     ax, 60h
	/// dnadp:036c                  jb      loc_00388
	/// dnadp:036e                  mov     bx, 0aaaah
	/// dnadp:0371                  cmp     ax, 0c0h
	/// dnadp:0374                  jb      loc_00388
	/// dnadp:0376                  mov     bx, 8888h
	/// dnadp:0379                  cmp     ax, 180h
	/// dnadp:037c                  jb      loc_00388
	/// dnadp:037e                  mov     bx, 8080h
	/// dnadp:0381                  cmp     ax, 300h
	/// dnadp:0384                  jb      loc_00388
	/// dnadp:0386                  xor     bl, bl
	/// dnadp:0388
	/// dnadp:0388  loc_00388:                                    ; CODE XREF: dnadp:036c, dnadp:0374, dnadp:037c, dnadp:0384
	/// dnadp:0388                  mov     cs:[19fh], bx
	/// dnadp:038d                  mov     al, cs:[19ah]
	/// dnadp:0391                  or      al, al
	/// dnadp:0393                  jns     loc_0039b
	/// dnadp:0395                  or      al, 40h
	/// dnadp:0397                  mov     cs:[19ah], al
	/// dnadp:039b
	/// dnadp:039b  loc_0039b:                                    ; CODE XREF: dnadp:0393
	/// dnadp:039b                  retf
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
	/// FULL commented disasm from gist (dnadp:039c).
	/// <code>
	/// dnadp:039c
	/// dnadp:039c  ADPSetTimerTickFlag:                          ; CODE XREF: dnadp:0109
	/// dnadp:039c                  mov     byte ptr cs:[19bh], 1
	/// dnadp:03a2                  mov     al, cs:[19ah]
	/// dnadp:03a6                  retf
	/// dnadp:03a7
	/// </code>
	/// </summary>
	public Action AdpSetTimerTickFlag_5BAE_039C_05BEBC(int gotoAddress) {
		AdpByteSet(0x019B, 1);
		byte al = AdpByte(0x019A);
		AX = Make16(al, Hi8(AX));
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:03b2).
	/// <code>
	/// dnadp:03b2
	/// dnadp:03b2  ADPOpen:                                      ; CODE XREF: dnadp:0103
	/// dnadp:03b2                  push    ds
	/// dnadp:03b3                  push    cs
	/// dnadp:03b4                  pop     ds
	/// dnadp:03b5                  mov     [19bh], al
	/// dnadp:03b8                  mov     ax, es:[si]
	/// dnadp:03bb                  mov     di, 3a8h
	/// dnadp:03be                  mov     [di], si
	/// dnadp:03c0                  mov     [di+2], es
	/// dnadp:03c3                  mov     [di+4], ax
	/// dnadp:03c6                  mov     ax, es:[si+4000h]
	/// dnadp:03cb                  mov     [di+6], ax
	/// dnadp:03ce                  mov     ax, es:[si-8000h]
	/// dnadp:03d3                  mov     [di+8], ax
	/// dnadp:03d6                  add     si, 2
	/// dnadp:03d9                  mov     [115h], si
	/// dnadp:03dd                  mov     [117h], es
	/// dnadp:03e1                  sub     si, 2
	/// dnadp:03e4                  add     si, es:[si]
	/// dnadp:03e7                  mov     [119h], si
	/// dnadp:03eb                  mov     [11bh], es
	/// dnadp:03ef                  call    ADPUnknown099A
	/// dnadp:03f2                  call    ADPBuildChannelTable
	/// dnadp:03f5                  mov     al, [19eh]
	/// dnadp:03f8                  mov     [19ch], al
	/// dnadp:03fb                  call    ADPUnknown0982
	/// dnadp:03fe                  mov     [19dh], al
	/// dnadp:0401                  xor     ax, ax
	/// dnadp:0403                  mov     [11dh], ax
	/// dnadp:0406                  mov     [123h], ax
	/// dnadp:0409                  call    ADPProcessTick
	/// dnadp:040c                  mov     al, 80h
	/// dnadp:040e                  mov     [19ah], al
	/// dnadp:0411                  pop     ds
	/// dnadp:0412                  retf
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
	/// FULL commented disasm from gist (dnadp:0413).
	/// <code>
	/// dnadp:0413
	/// dnadp:0413  ADPBuildChannelTable:                         ; CODE XREF: dnadp:03f2
	/// dnadp:0413                  push    ds
	/// dnadp:0414                  push    ds
	/// dnadp:0415                  pop     es
	/// dnadp:0416                  lds     si, [115h]
	/// dnadp:041a                  mov     bp, si
	/// dnadp:041c                  mov     di, 1c6h
	/// dnadp:041f                  mov     cx, 9
	/// dnadp:0422
	/// dnadp:0422  loc_00422:                                    ; CODE XREF: dnadp:042a
	/// dnadp:0422                  lodsw
	/// dnadp:0423                  or      ax, ax
	/// dnadp:0425                  jz      loc_00429
	/// dnadp:0427                  add     ax, bp
	/// dnadp:0429
	/// dnadp:0429  loc_00429:                                    ; CODE XREF: dnadp:0425
	/// dnadp:0429                  stosw
	/// dnadp:042a                  loop    loc_00422
	/// dnadp:042c                  mov     di, 1d8h
	/// dnadp:042f                  mov     cl, 9
	/// dnadp:0431                  mov     ax, 0ffh
	/// dnadp:0434                  rep stosw
	/// dnadp:0436                  mov     di, 1fch
	/// dnadp:0439                  mov     cl, 9
	/// dnadp:043b                  xor     ax, ax
	/// dnadp:043d                  rep stosw
	/// dnadp:043f                  pop     ds
	/// dnadp:0440                  les     si, [115h]
	/// dnadp:0444
	/// dnadp:0444  loc_00444:                                    ; CODE XREF: dnadp:0687
	/// dnadp:0444                  mov     word ptr [11fh], 1
	/// dnadp:044a                  mov     word ptr [121h], 60h
	/// dnadp:0450                  mov     cx, 9
	/// dnadp:0453                  mov     di, 1a2h
	/// dnadp:0456
	/// dnadp:0456  loc_00456:                                    ; CODE XREF: dnadp:0470
	/// dnadp:0456                  mov     si, [di+24h]
	/// dnadp:0459                  mov     [di+12h], si
	/// dnadp:045c                  mov     word ptr [di], 0ffffh
	/// dnadp:0460                  or      si, si
	/// dnadp:0462                  jz      loc_0046d
	/// dnadp:0464                  mov     ax, cx
	/// dnadp:0466                  call    ADPReadWaitValue
	/// dnadp:0469                  inc     word ptr [di]
	/// dnadp:046b                  mov     cx, ax
	/// dnadp:046d
	/// dnadp:046d  loc_0046d:                                    ; CODE XREF: dnadp:0462
	/// dnadp:046d                  add     di, 2
	/// dnadp:0470                  loop    loc_00456
	/// dnadp:0472                  ret
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
		ES = songSegment;
		SI = songOffset;
		return NearRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:0473).
	/// <code>
	/// dnadp:0473
	/// dnadp:0473  ADPTickHandler:                               ; CODE XREF: dnadp:010f
	/// dnadp:0473                  push    ds
	/// dnadp:0474                  mov     ax, cs
	/// dnadp:0476                  mov     ds, ax
	/// dnadp:0478                  cmp     byte ptr [19ah], 0
	/// dnadp:047d                  jns     loc_004a0
	/// dnadp:047f                  dec     byte ptr [11eh]
	/// dnadp:0483                  jns     loc_00497
	/// dnadp:0485                  call    ADPSongValidation
	/// dnadp:0488                  jnz     loc_004a0
	/// dnadp:048a                  push    dx
	/// dnadp:048b                  push    si
	/// dnadp:048c                  push    di
	/// dnadp:048d                  push    bp
	/// dnadp:048e                  push    es
	/// dnadp:048f                  call    ADPProcessTick
	/// dnadp:0492                  pop     es
	/// dnadp:0493                  pop     bp
	/// dnadp:0494                  pop     di
	/// dnadp:0495                  pop     si
	/// dnadp:0496                  pop     dx
	/// dnadp:0497
	/// dnadp:0497  loc_00497:                                    ; CODE XREF: dnadp:0483
	/// dnadp:0497                  rol     [19fh], 1
	/// dnadp:049b                  jnb     loc_004a0
	/// dnadp:049d                  call    ADPFadeStep
	/// dnadp:04a0
	/// dnadp:04a0  loc_004a0:                                    ; CODE XREF: dnadp:047d, dnadp:0488, dnadp:049b
	/// dnadp:04a0                  mov     al, [19ah]
	/// dnadp:04a3                  mov     bx, [11fh]
	/// dnadp:04a7                  mov     cx, [121h]
	/// dnadp:04ab                  pop     ds
	/// dnadp:04ac                  retf
	/// </code>
	/// </summary>
	public Action AdpTickHandler_5BAE_0473_05BF93(int gotoAddress) {
		_adpTickIndex++;
		CryogenicMcpTools.RecordAdpCall("5BAE:0473_TickInternal");
		ushort oldDs = DS;
		DS = CS;
		bool skipTickAndFade = false;
		byte status = AdpByte(0x019A);
		if ((status & 0x80) != 0) {
			byte timerLo = AdpByte(0x011E);
			timerLo--;
			AdpByteSet(0x011E, timerLo);
			if ((timerLo & 0x80) != 0) {
				AdpSongValidation_5BAE_04AD_05BFCD(0);
				if (!ZeroFlag) {
					skipTickAndFade = true;
				} else {
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
			if (!skipTickAndFade) {
				ushort fadePattern = AdpWord(0x019F);
				fadePattern = (ushort)((fadePattern << 1) | (fadePattern >> 15));
				AdpWordSet(0x019F, fadePattern);
				CarryFlag = (fadePattern & 0x0001) != 0;
				if (CarryFlag) {
					AdpFadeStep_5BAE_092D_05C44D(0);
				}
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
	/// FULL commented disasm from gist (dnadp:04ad).
	/// <code>
	/// dnadp:04ad
	/// dnadp:04ad  ADPSongValidation:                            ; CODE XREF: dnadp:0485
	/// dnadp:04ad                  push    si
	/// dnadp:04ae                  push    es
	/// dnadp:04af                  les     si, [3a8h]
	/// dnadp:04b3                  mov     ax, es:[si]
	/// dnadp:04b6                  cmp     [3ach], ax
	/// dnadp:04ba                  jnz     loc_004d0
	/// dnadp:04bc                  mov     ax, es:[si+4000h]
	/// dnadp:04c1                  cmp     [3aeh], ax
	/// dnadp:04c5                  jnz     loc_004d0
	/// dnadp:04c7                  mov     ax, es:[si-8000h]
	/// dnadp:04cc                  cmp     [3b0h], ax
	/// dnadp:04d0
	/// dnadp:04d0  loc_004d0:                                    ; CODE XREF: dnadp:04ba, dnadp:04c5
	/// dnadp:04d0                  pop     es
	/// dnadp:04d1                  pop     si
	/// dnadp:04d2                  ret
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
	/// FULL commented disasm from gist (dnadp:04d3).
	/// <code>
	/// dnadp:04d3
	/// dnadp:04d3  ADPProcessTick:                               ; CODE XREF: dnadp:0409, dnadp:048f
	/// dnadp:04d3                  les     bx, [115h]
	/// dnadp:04d7                  mov     ax, es:[bx+30h]
	/// dnadp:04db                  add     [11dh], ax
	/// dnadp:04df                  mov     di, 1a2h
	/// dnadp:04e2                  call    ADPLoopPointCheck
	/// dnadp:04e5                  mov     cx, 9
	/// dnadp:04e8
	/// dnadp:04e8  loc_004e8:                                    ; CODE XREF: dnadp:0518
	/// dnadp:04e8                  dec     word ptr [di]
	/// dnadp:04ea                  jnz     loc_0052a
	/// dnadp:04ec
	/// dnadp:04ec  loc_004ec:                                    ; CODE XREF: dnadp:0513
	/// dnadp:04ec                  mov     si, [di+12h]
	/// dnadp:04ef                  or      si, si
	/// dnadp:04f1                  jz      loc_00515
	/// dnadp:04f3                  push    cx
	/// dnadp:04f4                  push    di
	/// dnadp:04f5                  es:lodsw
	/// dnadp:04f7                  mov     dx, di
	/// dnadp:04f9                  sub     dx, 1a2h
	/// dnadp:04fd                  shr     dx, 1
	/// dnadp:04ff                  mov     bx, ax
	/// dnadp:0501                  and     bx, 70h
	/// dnadp:0504                  shr     bx, 1
	/// dnadp:0506                  shr     bx, 1
	/// dnadp:0508                  shr     bx, 1
	/// dnadp:050a                  call    word ptr [bx+125h]
	/// dnadp:050e                  pop     di
	/// dnadp:050f                  pop     cx
	/// dnadp:0510                  cmp     word ptr [di], 0
	/// dnadp:0513                  jz      loc_004ec
	/// dnadp:0515
	/// dnadp:0515  loc_00515:                                    ; CODE XREF: dnadp:04f1, dnadp:052e, dnadp:0535, dnadp:0551
	/// dnadp:0515                  add     di, 2
	/// dnadp:0518                  loop    loc_004e8
	/// dnadp:051a                  dec     byte ptr [121h]
	/// dnadp:051e                  jnz     loc_00529
	/// dnadp:0520                  mov     byte ptr [121h], 60h
	/// dnadp:0525                  inc     word ptr [11fh]
	/// dnadp:0529
	/// dnadp:0529  loc_00529:                                    ; CODE XREF: dnadp:051e
	/// dnadp:0529                  ret
	/// dnadp:052a
	/// dnadp:052a  loc_0052a:                                    ; CODE XREF: dnadp:04ea
	/// dnadp:052a                  cmp     byte ptr [di+5ah], 0
	/// dnadp:052e                  jz      loc_00515
	/// dnadp:0530                  mov     si, [di+12h]
	/// dnadp:0533                  or      si, si
	/// dnadp:0535                  jz      loc_00515
	/// dnadp:0537                  push    cx
	/// dnadp:0538                  push    di
	/// dnadp:0539                  dec     byte ptr [di+5ah]
	/// dnadp:053c                  mov     ax, [di+6ch]
	/// dnadp:053f                  add     al, ah
	/// dnadp:0541                  mov     [di+6ch], al
	/// dnadp:0544                  mov     dx, di
	/// dnadp:0546                  sub     dx, 1a2h
	/// dnadp:054a                  shr     dx, 1
	/// dnadp:054c                  call    ADPPitchBend
	/// dnadp:054f                  pop     di
	/// dnadp:0550                  pop     cx
	/// dnadp:0551                  jmp     loc_00515
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
					ushort savedDi = DI;
					ushort savedCxRegister = CX;
					CX = cx;
					SI = AdpWord((ushort)(DI + 0x12));
					AdpByteSet((ushort)(DI + 0x5A), (byte)(AdpByte((ushort)(DI + 0x5A)) - 1));
					ushort phaseWord = AdpWord((ushort)(DI + 0x6C));
					byte phaseLo = Lo8(phaseWord);
					byte phaseHi = Hi8(phaseWord);
					phaseLo = (byte)(phaseLo + phaseHi);
					AdpByteSet((ushort)(DI + 0x6C), phaseLo);
					AX = Make16(phaseLo, phaseHi);
					DX = (ushort)((DI - AdpChannelTableBase) >> 1);
					AdpPitchBendBody_5BAE_07EF_05C30F(0);
					CX = savedCxRegister;
					DI = savedDi;
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
					ushort savedDi = DI;
					ushort savedCxRegister = CX;
					CX = cx;
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
							CryogenicMcpTools.RecordAdpCall("5BAE:04D3_DispatchReadWait");
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
					CX = savedCxRegister;
					DI = savedDi;
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
	/// FULL commented disasm from gist (dnadp:0553).
	/// <code>
	/// dnadp:0553
	/// dnadp:0553  ADPLoopPointCheck:                            ; CODE XREF: dnadp:04e2, dnadp:0691
	/// dnadp:0553                  cmp     word ptr [123h], 0
	/// dnadp:0558                  jnz     loc_00585
	/// dnadp:055a                  mov     ax, es:[bx+2ah]
	/// dnadp:055e                  cmp     ax, [11fh]
	/// dnadp:0562                  jnz     loc_00584
	/// dnadp:0564                  cmp     word ptr [121h], 60h
	/// dnadp:0569                  jnz     loc_00584
	/// dnadp:056b                  push    di
	/// dnadp:056c                  push    es
	/// dnadp:056d                  mov     si, di
	/// dnadp:056f                  add     di, 0eah
	/// dnadp:0573                  push    ds
	/// dnadp:0574                  pop     es
	/// dnadp:0575                  mov     cx, 12h
	/// dnadp:0578                  rep movsw
	/// dnadp:057a                  pop     es
	/// dnadp:057b                  pop     di
	/// dnadp:057c                  mov     ax, es:[bx+2eh]
	/// dnadp:0580                  dec     ax
	/// dnadp:0581                  mov     [123h], ax
	/// dnadp:0584
	/// dnadp:0584  loc_00584:                                    ; CODE XREF: dnadp:0562, dnadp:0569, dnadp:058d
	/// dnadp:0584                  ret
	/// dnadp:0585
	/// dnadp:0585  loc_00585:                                    ; CODE XREF: dnadp:0558
	/// dnadp:0585                  mov     ax, es:[bx+2ch]
	/// dnadp:0589                  cmp     ax, [11fh]
	/// dnadp:058d                  jnz     loc_00584
	/// dnadp:058f                  dec     word ptr [123h]
	/// dnadp:0593                  push    di
	/// dnadp:0594                  push    es
	/// dnadp:0595                  lea     si, [di+0eah]
	/// dnadp:0599                  push    ds
	/// dnadp:059a                  pop     es
	/// dnadp:059b                  mov     cx, 12h
	/// dnadp:059e                  rep movsw
	/// dnadp:05a0                  pop     es
	/// dnadp:05a1                  pop     di
	/// dnadp:05a2                  mov     ax, es:[bx+2ah]
	/// dnadp:05a6                  mov     [11fh], ax
	/// dnadp:05a9
	/// dnadp:05a9  loc_005a9:                                    ; CODE XREF: dnadp:05b0
	/// dnadp:05a9                  ret
	/// </code>
	/// </summary>
	public Action AdpLoopPointCheck_5BAE_0553_05C073(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0553_LoopPointCheck");
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
	/// FULL commented disasm from gist (dnadp:05aa).
	/// <code>
	/// dnadp:05aa
	/// dnadp:05aa  ADP_OP_ProgramChange:
	/// dnadp:05aa                  call    ADPReadWaitValue
	/// dnadp:05ad                  cmp     [di+36h], ah
	/// dnadp:05b0                  jz      loc_005a9
	/// dnadp:05b2                  mov     [di+36h], ah
	/// dnadp:05b5                  mov     al, 28h
	/// dnadp:05b7                  mul     ah
	/// dnadp:05b9                  les     si, [119h]
	/// dnadp:05bd                  add     si, ax
	/// dnadp:05bf                  mov     ax, es:[si+21h]
	/// dnadp:05c3                  mov     [di+48h], ax
	/// dnadp:05c6                  mov     ah, es:[si+17h]
	/// dnadp:05ca                  mov     al, es:[si+0ah]
	/// dnadp:05ce                  mov     bh, es:[si+2]
	/// dnadp:05d2                  mov     bl, es:[si+0fh]
	/// dnadp:05d6                  and     bx, 303h
	/// dnadp:05da                  ror     bx, 1
	/// dnadp:05dc                  ror     bx, 1
	/// dnadp:05de                  or      ax, bx
	/// dnadp:05e0                  mov     [di+90h], ax
	/// dnadp:05e4                  mov     ax, es:[si+1eh]
	/// dnadp:05e8                  mov     [di+7eh], ax
	/// dnadp:05eb                  mov     ax, es:[si+26h]
	/// dnadp:05ef                  mov     [di+0c6h], ax
	/// dnadp:05f3                  mov     al, es:[si+0eh]
	/// dnadp:05f7                  not     al
	/// dnadp:05f9                  ror     al, 1
	/// dnadp:05fb                  mov     ah, es:[si+4]
	/// dnadp:05ff                  shl     ax, 1
	/// dnadp:0601                  mov     al, es:[si+20h]
	/// dnadp:0605                  mov     [di+0b4h], ax
	/// dnadp:0609                  mov     al, es:[si+1bh]
	/// dnadp:060d                  mov     [di+0d8h], ax
	/// dnadp:0611                  mov     ax, es:[si+23h]
	/// dnadp:0615                  mov     [di+6dh], ah
	/// dnadp:0618                  mov     ah, al
	/// dnadp:061a                  xor     al, al
	/// dnadp:061c                  mov     [di+5ah], ax
	/// dnadp:061f                  push    ds
	/// dnadp:0620                  mov     ax, es
	/// dnadp:0622                  mov     ds, ax
	/// dnadp:0624                  add     si, 2
	/// dnadp:0627                  call    ADPInstrumentWrite
	/// dnadp:062a                  pop     ds
	/// dnadp:062b                  ret
	/// </code>
	/// </summary>
	public Action AdpProgramChange_5BAE_05AA_05C0CA(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:05AA_ProgramChange");
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
	/// FULL commented disasm from gist (dnadp:062c).
	/// <code>
	/// dnadp:062c
	/// dnadp:062c  ADP_OP_NoteOn:
	/// dnadp:062c                  es:lodsb
	/// dnadp:062e                  call    ADPReadWaitValue
	/// dnadp:0631                  push    ax
	/// dnadp:0632                  call    ADP_OP_EnvelopeSetup
	/// dnadp:0635                  cmp     byte ptr [di+37h], 0
	/// dnadp:0639                  jz      loc_00640
	/// dnadp:063b                  xor     ax, ax
	/// dnadp:063d                  call    ADPOplFrequencyWrite
	/// dnadp:0640
	/// dnadp:0640  loc_00640:                                    ; CODE XREF: dnadp:0639
	/// dnadp:0640                  pop     ax
	/// dnadp:0641                  mov     al, ah
	/// dnadp:0643                  add     al, [di+49h]
	/// dnadp:0646                  xor     ah, ah
	/// dnadp:0648                  mov     [di+37h], al
	/// dnadp:064b                  sub     ax, 48h
	/// dnadp:064e                  mov     cl, [di+5bh]
	/// dnadp:0651                  mov     [di+5ah], cl
	/// dnadp:0654                  mov     byte ptr [di+6ch], 40h
	/// dnadp:0658                  jmp     ADPOplNoteOn
	/// </code>
	/// </summary>
	public Action AdpNoteOn_5BAE_062C_05C14C(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:062C_NoteOn");
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
		AL = AH;
		AL = (byte)(AL + AdpByte((ushort)(DI + 0x49)));
		AH = 0;
		AdpByteSet((ushort)(DI + 0x37), AL);
		AX = (ushort)(AX - 0x48);
		CL = AdpByte((ushort)(DI + 0x5B));
		AdpByteSet((ushort)(DI + 0x5A), CL);
		AdpByteSet((ushort)(DI + 0x6C), 0x40);
		AdpOplNoteOn_5BAE_0A58_05C578(0);
		return NearRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:065b).
	/// <code>
	/// dnadp:065b
	/// dnadp:065b  ADP_OP_NoteOff:
	/// dnadp:065b                  inc     si
	/// dnadp:065c                  call    ADPReadWaitValue
	/// dnadp:065f                  add     ah, [di+49h]
	/// dnadp:0662                  cmp     [di+37h], ah
	/// dnadp:0665                  jnz     loc_0066e
	/// dnadp:0667                  mov     byte ptr [di+37h], 0
	/// dnadp:066b                  jmp     ADPOplNoteOff
	/// dnadp:066e
	/// dnadp:066e  loc_0066e:                                    ; CODE XREF: dnadp:0665
	/// dnadp:066e                  ret
	/// </code>
	/// </summary>
	public Action AdpNoteOff_5BAE_065B_05C17B(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:065B_NoteOff");
		SI = (ushort)(SI + 1);
		AdpReadWaitValue_5BAE_08E1_05C401(0);
		AH = (byte)(AH + AdpByte((ushort)(DI + 0x49)));
		if (AdpByte((ushort)(DI + 0x37)) == AH) {
			AdpByteSet((ushort)(DI + 0x37), 0);
			AdpOplNoteOff_5BAE_0A87_05C5A7(0);
		}
		return NearRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:066f).
	/// <code>
	/// dnadp:066f
	/// dnadp:066f  ADP_OP_EndOfTrack:
	/// dnadp:066f                  mov     word ptr [di], 0ffffh
	/// dnadp:0673                  sub     byte ptr [di+12h], 2
	/// dnadp:0677                  or      dx, dx
	/// dnadp:0679                  jnz     loc_00696
	/// dnadp:067b                  dec     byte ptr [19bh]
	/// dnadp:067f                  jz      loc_00697
	/// dnadp:0681                  jns     loc_00687
	/// dnadp:0683                  inc     byte ptr [19bh]
	/// dnadp:0687
	/// dnadp:0687  loc_00687:                                    ; CODE XREF: dnadp:0681
	/// dnadp:0687                  call    loc_00444
	/// dnadp:068a                  les     bx, [115h]
	/// dnadp:068e                  mov     di, 1a2h
	/// dnadp:0691                  call    ADPLoopPointCheck
	/// dnadp:0694                  dec     word ptr [di]
	/// dnadp:0696
	/// dnadp:0696  loc_00696:                                    ; CODE XREF: dnadp:0679
	/// dnadp:0696                  ret
	/// dnadp:0697
	/// dnadp:0697  loc_00697:                                    ; CODE XREF: dnadp:067f
	/// dnadp:0697                  mov     ax, 0ffffh
	/// dnadp:069a                  push    es
	/// dnadp:069b                  push    ds
	/// dnadp:069c                  pop     es
	/// dnadp:069d                  mov     cx, 9
	/// dnadp:06a0                  rep stosw
	/// dnadp:06a2                  pop     es
	/// dnadp:06a3                  push    cs
	/// dnadp:06a4                  call    ADPReset
	/// dnadp:06a7                  ret
	/// </code>
	/// </summary>
	public Action AdpEndOfTrack_5BAE_066F_05C18F(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:066F_EndOfTrack");
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
		ushort cx = 9;
		while (cx > 0) {
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
				cx = AX;
			}
			loopDi = (ushort)(loopDi + 2);
			cx = (ushort)(cx - 1);
		}
		ES = AdpWord(0x0117);
		BX = AdpWord(0x0115);
		DI = AdpChannelTableBase;
		AdpLoopPointCheck_5BAE_0553_05C073(0);
		AdpWordSet(DI, (ushort)(AdpWord(DI) - 1));
		return NearRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:06a8).
	/// <code>
	/// dnadp:06a8
	/// dnadp:06a8  ADP_OP_VolumeModulation:
	/// dnadp:06a8                  call    ADPReadWaitValue
	/// dnadp:06ab                  mov     al, 80h
	/// dnadp:06ad                  sub     al, ah
	/// dnadp:06af                  xchg    al, ah
	/// dnadp:06b1                  mov     bx, [di+0a2h]
	/// dnadp:06b5                  mov     cx, [di+0c6h]
	/// dnadp:06b9                  or      cl, cl
	/// dnadp:06bb                  jz      loc_006e7
	/// dnadp:06bd                  push    ax
	/// dnadp:06be                  jns     loc_006c4
	/// dnadp:06c0                  neg     cl
	/// dnadp:06c2                  mov     al, ah
	/// dnadp:06c4
	/// dnadp:06c4  loc_006c4:                                    ; CODE XREF: dnadp:06be
	/// dnadp:06c4                  sub     cl, 4
	/// dnadp:06c7                  neg     cl
	/// dnadp:06c9                  shr     al, cl
	/// dnadp:06cb                  mov     ah, bl
	/// dnadp:06cd                  and     ah, 3fh
	/// dnadp:06d0                  sub     ah, al
	/// dnadp:06d2                  jnb     loc_006d6
	/// dnadp:06d4                  xor     ah, ah
	/// dnadp:06d6
	/// dnadp:06d6  loc_006d6:                                    ; CODE XREF: dnadp:06d2
	/// dnadp:06d6                  and     bl, 0c0h
	/// dnadp:06d9                  or      ah, bl
	/// dnadp:06db                  mov     si, 171h
	/// dnadp:06de                  add     si, dx
	/// dnadp:06e0                  lodsb
	/// dnadp:06e1                  add     al, 40h
	/// dnadp:06e3                  call    ADPOplRegisterWrite
	/// dnadp:06e6                  pop     ax
	/// dnadp:06e7
	/// dnadp:06e7  loc_006e7:                                    ; CODE XREF: dnadp:06bb
	/// dnadp:06e7                  or      ch, ch
	/// dnadp:06e9                  jz      loc_00714
	/// dnadp:06eb                  push    ax
	/// dnadp:06ec                  jns     loc_006f2
	/// dnadp:06ee                  neg     ch
	/// dnadp:06f0                  mov     al, ah
	/// dnadp:06f2
	/// dnadp:06f2  loc_006f2:                                    ; CODE XREF: dnadp:06ec
	/// dnadp:06f2                  mov     cl, 4
	/// dnadp:06f4                  sub     cl, ch
	/// dnadp:06f6                  shr     al, cl
	/// dnadp:06f8                  mov     ah, bh
	/// dnadp:06fa                  and     ah, 3fh
	/// dnadp:06fd                  sub     ah, al
	/// dnadp:06ff                  jnb     loc_00703
	/// dnadp:0701                  xor     ah, ah
	/// dnadp:0703
	/// dnadp:0703  loc_00703:                                    ; CODE XREF: dnadp:06ff
	/// dnadp:0703                  and     bh, 0c0h
	/// dnadp:0706                  or      ah, bh
	/// dnadp:0708                  mov     si, 17ah
	/// dnadp:070b                  add     si, dx
	/// dnadp:070d                  lodsb
	/// dnadp:070e                  add     al, 40h
	/// dnadp:0710                  call    ADPOplRegisterWrite
	/// dnadp:0713                  pop     ax
	/// dnadp:0714
	/// dnadp:0714  loc_00714:                                    ; CODE XREF: dnadp:06e9
	/// dnadp:0714                  mov     cx, [di+0d8h]
	/// dnadp:0718                  or      cl, cl
	/// dnadp:071a                  jnz     loc_0071d
	/// dnadp:071c                  ret
	/// dnadp:071d
	/// dnadp:071d  loc_0071d:                                    ; CODE XREF: dnadp:071a
	/// dnadp:071d                  jns     loc_00723
	/// dnadp:071f                  neg     cl
	/// dnadp:0721                  mov     al, ah
	/// dnadp:0723
	/// dnadp:0723  loc_00723:                                    ; CODE XREF: dnadp:071d
	/// dnadp:0723                  sub     cl, 6
	/// dnadp:0726                  neg     cl
	/// dnadp:0728                  shr     al, cl
	/// dnadp:072a                  and     al, 0feh
	/// dnadp:072c                  add     al, ch
	/// dnadp:072e                  cmp     al, 0fh
	/// dnadp:0730                  jbe     loc_00736
	/// dnadp:0732                  and     al, 0fh
	/// dnadp:0734                  or      al, 0eh
	/// dnadp:0736
	/// dnadp:0736  loc_00736:                                    ; CODE XREF: dnadp:0730
	/// dnadp:0736                  mov     ah, al
	/// dnadp:0738                  mov     al, dl
	/// dnadp:073a                  add     al, 0c0h
	/// dnadp:073c                  call    ADPOplRegisterWrite
	/// dnadp:073f                  ret
	/// </code>
	/// </summary>
	public Action AdpVolumeModulation_5BAE_06A8_05C1C8(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:06A8_VolumeModulation");
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
			AX = Make16((byte)(0xC0 + DX), scaleAl);
			AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		}
		return NearRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:0740).
	/// <code>
	/// dnadp:0740
	/// dnadp:0740  ADP_OP_EnvelopeSetup:                         ; CODE XREF: dnadp:0632
	/// dnadp:0740                  mov     ah, al
	/// dnadp:0742                  mov     al, 80h
	/// dnadp:0744                  sub     al, ah
	/// dnadp:0746                  mov     bx, [di+90h]
	/// dnadp:074a                  mov     cx, [di+7eh]
	/// dnadp:074d                  or      cl, cl
	/// dnadp:074f                  jz      loc_00780
	/// dnadp:0751                  push    ax
	/// dnadp:0752                  jns     loc_00758
	/// dnadp:0754                  neg     cl
	/// dnadp:0756                  mov     al, ah
	/// dnadp:0758
	/// dnadp:0758  loc_00758:                                    ; CODE XREF: dnadp:0752
	/// dnadp:0758                  sub     cl, 4
	/// dnadp:075b                  neg     cl
	/// dnadp:075d                  shr     al, cl
	/// dnadp:075f                  mov     ah, bl
	/// dnadp:0761                  and     ah, 3fh
	/// dnadp:0764                  add     ah, al
	/// dnadp:0766                  cmp     ah, 3fh
	/// dnadp:0769                  jbe     loc_0076d
	/// dnadp:076b                  mov     ah, 3fh
	/// dnadp:076d
	/// dnadp:076d  loc_0076d:                                    ; CODE XREF: dnadp:0769
	/// dnadp:076d                  and     bl, 0c0h
	/// dnadp:0770                  or      bl, ah
	/// dnadp:0772                  mov     ah, bl
	/// dnadp:0774                  mov     si, 171h
	/// dnadp:0777                  add     si, dx
	/// dnadp:0779                  lodsb
	/// dnadp:077a                  add     al, 40h
	/// dnadp:077c                  call    ADPOplRegisterWrite
	/// dnadp:077f                  pop     ax
	/// dnadp:0780
	/// dnadp:0780  loc_00780:                                    ; CODE XREF: dnadp:074f
	/// dnadp:0780                  or      ch, ch
	/// dnadp:0782                  jz      loc_007b2
	/// dnadp:0784                  push    ax
	/// dnadp:0785                  jns     loc_0078b
	/// dnadp:0787                  neg     ch
	/// dnadp:0789                  mov     al, ah
	/// dnadp:078b
	/// dnadp:078b  loc_0078b:                                    ; CODE XREF: dnadp:0785
	/// dnadp:078b                  mov     cl, 4
	/// dnadp:078d                  sub     cl, ch
	/// dnadp:078f                  shr     al, cl
	/// dnadp:0791                  mov     ah, bh
	/// dnadp:0793                  and     ah, 3fh
	/// dnadp:0796                  add     ah, al
	/// dnadp:0798                  cmp     ah, 3fh
	/// dnadp:079b                  jbe     loc_0079f
	/// dnadp:079d                  mov     ah, 3fh
	/// dnadp:079f
	/// dnadp:079f  loc_0079f:                                    ; CODE XREF: dnadp:079b
	/// dnadp:079f                  and     bh, 0c0h
	/// dnadp:07a2                  or      bh, ah
	/// dnadp:07a4                  mov     ah, bh
	/// dnadp:07a6                  mov     si, 17ah
	/// dnadp:07a9                  add     si, dx
	/// dnadp:07ab                  lodsb
	/// dnadp:07ac                  add     al, 40h
	/// dnadp:07ae                  call    ADPOplRegisterWrite
	/// dnadp:07b1                  pop     ax
	/// dnadp:07b2
	/// dnadp:07b2  loc_007b2:                                    ; CODE XREF: dnadp:0782
	/// dnadp:07b2                  mov     [di+0a2h], bx
	/// dnadp:07b6                  mov     cx, [di+0b4h]
	/// dnadp:07ba                  or      cl, cl
	/// dnadp:07bc                  jnz     loc_007c3
	/// dnadp:07be                  mov     [di+0d9h], ch
	/// dnadp:07c2                  ret
	/// dnadp:07c3
	/// dnadp:07c3  loc_007c3:                                    ; CODE XREF: dnadp:07bc
	/// dnadp:07c3                  jns     loc_007c9
	/// dnadp:07c5                  neg     cl
	/// dnadp:07c7                  mov     al, ah
	/// dnadp:07c9
	/// dnadp:07c9  loc_007c9:                                    ; CODE XREF: dnadp:07c3
	/// dnadp:07c9                  sub     cl, 6
	/// dnadp:07cc                  neg     cl
	/// dnadp:07ce                  shr     al, cl
	/// dnadp:07d0                  and     al, 0feh
	/// dnadp:07d2                  add     al, ch
	/// dnadp:07d4                  cmp     al, 0fh
	/// dnadp:07d6                  jbe     loc_007dc
	/// dnadp:07d8                  and     al, 0fh
	/// dnadp:07da                  or      al, 0eh
	/// dnadp:07dc
	/// dnadp:07dc  loc_007dc:                                    ; CODE XREF: dnadp:07d6
	/// dnadp:07dc                  mov     ah, al
	/// dnadp:07de                  mov     [di+0d9h], al
	/// dnadp:07e2                  mov     al, dl
	/// dnadp:07e4                  add     al, 0c0h
	/// dnadp:07e6                  call    ADPOplRegisterWrite
	/// dnadp:07e9
	/// dnadp:07e9  loc_007e9:                                    ; CODE XREF: dnadp:07f4
	/// dnadp:07e9                  ret
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
	/// FULL commented disasm from gist (dnadp:07ea).
	/// <code>
	/// dnadp:07ea
	/// dnadp:07ea  ADP_OP_PitchBend:
	/// dnadp:07ea                  mov     al, ah
	/// dnadp:07ec                  call    ADPReadWaitValue
	/// </code>
	/// </summary>
	public Action AdpPitchBend_5BAE_07EA_05C30A(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:07EA_PitchBendOp");
		byte al = Hi8(AX);
		AX = Make16(al, Hi8(AX));
		AdpReadWaitValue_5BAE_08E1_05C401(0);
		return AdpPitchBendBody_5BAE_07EF_05C30F(0);
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:07ef).
	/// <code>
	/// dnadp:07ef
	/// dnadp:07ef  ADPPitchBend:                                 ; CODE XREF: dnadp:054c
	/// dnadp:07ef                  mov     cl, [di+37h]
	/// dnadp:07f2                  xor     ch, ch
	/// dnadp:07f4                  jcxz    loc_007e9
	/// dnadp:07f6                  mov     ah, ch
	/// dnadp:07f8                  xchg    cx, ax
	/// dnadp:07f9                  sub     al, 18h
	/// dnadp:07fb                  mov     bh, 0ch
	/// dnadp:07fd                  div     bh
	/// dnadp:07ff                  xchg    cx, ax
	/// dnadp:0800                  cmp     byte ptr [di+48h], 0
	/// dnadp:0804                  jnz     loc_00865
	/// dnadp:0806                  sub     ax, 40h
	/// dnadp:0809                  jnb     loc_00842
	/// dnadp:080b                  neg     ax
	/// dnadp:080d                  ror     ax, 1
	/// dnadp:080f                  ror     ax, 1
	/// dnadp:0811                  ror     ax, 1
	/// dnadp:0813                  ror     ax, 1
	/// dnadp:0815                  ror     ax, 1
	/// dnadp:0817                  sub     ch, al
	/// dnadp:0819                  jnb     loc_00824
	/// dnadp:081b                  add     ch, 0ch
	/// dnadp:081e                  dec     cl
	/// dnadp:0820                  jns     loc_00824
	/// dnadp:0822                  xor     cx, cx
	/// dnadp:0824
	/// dnadp:0824  loc_00824:                                    ; CODE XREF: dnadp:0819, dnadp:0820
	/// dnadp:0824                  mov     al, ch
	/// dnadp:0826                  mov     bx, 183h
	/// dnadp:0829                  xlat
	/// dnadp:082a                  mul     ah
	/// dnadp:082c                  mov     al, ah
	/// dnadp:082e                  xchg    al, ch
	/// dnadp:0830                  xor     ah, ah
	/// dnadp:0832                  add     ax, ax
	/// dnadp:0834                  mov     si, ax
	/// dnadp:0836                  mov     ax, [si+147h]
	/// dnadp:083a                  sub     al, ch
	/// dnadp:083c                  sbb     ah, 0
	/// dnadp:083f                  jmp     loc_008cd
	/// dnadp:0842
	/// dnadp:0842  loc_00842:                                    ; CODE XREF: dnadp:0809
	/// dnadp:0842                  inc     ax
	/// dnadp:0843                  ror     ax, 1
	/// dnadp:0845                  ror     ax, 1
	/// dnadp:0847                  ror     ax, 1
	/// dnadp:0849                  ror     ax, 1
	/// dnadp:084b                  ror     ax, 1
	/// dnadp:084d                  add     ch, al
	/// dnadp:084f                  cmp     ch, 0ch
	/// dnadp:0852                  jb      loc_00859
	/// dnadp:0854                  sub     ch, 0ch
	/// dnadp:0857                  inc     cl
	/// dnadp:0859
	/// dnadp:0859  loc_00859:                                    ; CODE XREF: dnadp:0852
	/// dnadp:0859                  mov     al, ch
	/// dnadp:085b                  mov     bx, 184h
	/// dnadp:085e                  xlat
	/// dnadp:085f                  mul     ah
	/// dnadp:0861                  mov     al, ah
	/// dnadp:0863                  jmp     loc_008bc
	/// dnadp:0865
	/// dnadp:0865  loc_00865:                                    ; CODE XREF: dnadp:0804
	/// dnadp:0865                  sub     ax, 40h
	/// dnadp:0868                  jnb     loc_0089e
	/// dnadp:086a                  neg     ax
	/// dnadp:086c                  mov     bh, 5
	/// dnadp:086e                  div     bh
	/// dnadp:0870                  sub     ch, al
	/// dnadp:0872                  jnb     loc_0087d
	/// dnadp:0874                  add     ch, 0ch
	/// dnadp:0877                  dec     cl
	/// dnadp:0879                  jns     loc_0087d
	/// dnadp:087b                  xor     cx, cx
	/// dnadp:087d
	/// dnadp:087d  loc_0087d:                                    ; CODE XREF: dnadp:0872, dnadp:0879
	/// dnadp:087d                  mov     al, ah
	/// dnadp:087f                  mov     bx, 190h
	/// dnadp:0882                  cmp     ch, 6
	/// dnadp:0885                  jb      loc_0088a
	/// dnadp:0887                  add     bx, 5
	/// dnadp:088a
	/// dnadp:088a  loc_0088a:                                    ; CODE XREF: dnadp:0885
	/// dnadp:088a                  xlat
	/// dnadp:088b                  xchg    al, ch
	/// dnadp:088d                  xor     ah, ah
	/// dnadp:088f                  add     ax, ax
	/// dnadp:0891                  mov     si, ax
	/// dnadp:0893                  mov     ax, [si+147h]
	/// dnadp:0897                  sub     al, ch
	/// dnadp:0899                  sbb     ah, 0
	/// dnadp:089c                  jmp     loc_008cd
	/// dnadp:089e
	/// dnadp:089e  loc_0089e:                                    ; CODE XREF: dnadp:0868
	/// dnadp:089e                  mov     bh, 5
	/// dnadp:08a0                  div     bh
	/// dnadp:08a2                  add     ch, al
	/// dnadp:08a4                  cmp     ch, 0ch
	/// dnadp:08a7                  jb      loc_008ae
	/// dnadp:08a9                  sub     ch, 0ch
	/// dnadp:08ac                  inc     cl
	/// dnadp:08ae
	/// dnadp:08ae  loc_008ae:                                    ; CODE XREF: dnadp:08a7
	/// dnadp:08ae                  mov     al, ah
	/// dnadp:08b0                  mov     bx, 190h
	/// dnadp:08b3                  cmp     ch, 6
	/// dnadp:08b6                  jb      loc_008bb
	/// dnadp:08b8                  add     bx, 5
	/// dnadp:08bb
	/// dnadp:08bb  loc_008bb:                                    ; CODE XREF: dnadp:08b6
	/// dnadp:08bb                  xlat
	/// dnadp:08bc
	/// dnadp:08bc  loc_008bc:                                    ; CODE XREF: dnadp:0863
	/// dnadp:08bc                  xchg    al, ch
	/// dnadp:08be                  xor     ah, ah
	/// dnadp:08c0                  add     ax, ax
	/// dnadp:08c2                  mov     si, ax
	/// dnadp:08c4                  mov     ax, [si+147h]
	/// dnadp:08c8                  add     al, ch
	/// dnadp:08ca                  adc     ah, 0
	/// dnadp:08cd
	/// dnadp:08cd  loc_008cd:                                    ; CODE XREF: dnadp:083f, dnadp:089c
	/// dnadp:08cd                  shl     cl, 1
	/// dnadp:08cf                  shl     cl, 1
	/// dnadp:08d1                  or      ah, cl
	/// dnadp:08d3                  mov     si, dx
	/// dnadp:08d5                  add     si, si
	/// dnadp:08d7                  mov     [si+15fh], ax
	/// dnadp:08db                  or      ah, 20h
	/// dnadp:08de                  jmp     ADPOplFrequencyWrite
	/// </code>
	/// </summary>
	public Action AdpPitchBendBody_5BAE_07EF_05C30F(int gotoAddress) {
		byte cl = AdpByte((ushort)(DI + 0x37));
		byte ch = 0;
		if (cl == 0) {
			return NearRet();
		}

		byte alInput = Lo8(AX);
		ushort cx = Make16(cl, ch);
		ushort ax = Make16(alInput, 0);
		ushort tempSwap = cx;
		cx = ax;
		ax = tempSwap;

		byte al = (byte)(Lo8(ax) - 0x18);
		byte ah = 0;
		byte bh = 0x0C;
		ushort divAx = Make16(al, ah);
		byte divQ = (byte)(divAx / bh);
		byte divR = (byte)(divAx % bh);
		ax = Make16(divQ, divR);

		tempSwap = cx;
		cx = ax;
		ax = tempSwap;
		cl = Lo8(cx);
		ch = Hi8(cx);

		if (AdpByte((ushort)(DI + 0x48)) == 0) {
			bool carryFromSub40 = ax < 0x0040;
			ax = (ushort)(ax - 0x0040);
			if (carryFromSub40) {
				ax = (ushort)(0 - ax);
				ax = RotateRight16(ax, 5);
				al = Lo8(ax);
				if (ch >= al) {
					ch = (byte)(ch - al);
				} else {
					ch = (byte)(ch + 0x0C - al);
					cl = (byte)(cl - 1);
					if ((cl & 0x80) != 0) {
						cx = 0;
						cl = 0;
						ch = 0;
					}
				}

				al = ch;
				byte frac = AdpByte((ushort)(0x0183 + al));
				ah = Hi8(ax);
				ushort mul = (ushort)(frac * ah);
				al = Hi8(mul);
				byte oldCh = ch;
				ch = al;
				al = oldCh;
				ah = 0;
				ushort keyIndex = (ushort)(Make16(al, ah) << 1);
				ax = AdpWord((ushort)(0x0147 + keyIndex));
				int subRes = Lo8(ax) - ch;
				al = (byte)subRes;
				ah = (byte)(Hi8(ax) - (subRes < 0 ? 1 : 0));
				ax = Make16(al, ah);
			} else {
				ax = (ushort)(ax + 1);
				ax = RotateRight16(ax, 5);
				al = Lo8(ax);
				ch = (byte)(ch + al);
				if (ch >= 0x0C) {
					ch = (byte)(ch - 0x0C);
					cl = (byte)(cl + 1);
				}

				al = ch;
				byte frac = AdpByte((ushort)(0x0184 + al));
				ah = Hi8(ax);
				ushort mul = (ushort)(frac * ah);
				al = Hi8(mul);

				byte oldCh = ch;
				ch = al;
				al = oldCh;
				ah = 0;
				ushort keyIndex = (ushort)(Make16(al, ah) << 1);
				ax = AdpWord((ushort)(0x0147 + keyIndex));
				int addRes = Lo8(ax) + ch;
				al = (byte)addRes;
				ah = (byte)(Hi8(ax) + (addRes > 0xFF ? 1 : 0));
				ax = Make16(al, ah);
			}
		} else {
			bool carryFromSub40 = ax < 0x0040;
			ax = (ushort)(ax - 0x0040);
			if (carryFromSub40) {
				ax = (ushort)(0 - ax);
				bh = 5;
				ushort divWord = ax;
				divQ = (byte)(divWord / bh);
				divR = (byte)(divWord % bh);
				if (ch >= divQ) {
					ch = (byte)(ch - divQ);
				} else {
					ch = (byte)(ch + 0x0C - divQ);
					cl = (byte)(cl - 1);
					if ((cl & 0x80) != 0) {
						cx = 0;
						cl = 0;
						ch = 0;
					}
				}

				al = divR;
				ushort bx = 0x0190;
				if (ch >= 6) {
					bx = (ushort)(bx + 5);
				}
				byte frac = AdpByte((ushort)(bx + al));
				byte oldCh = ch;
				ch = frac;
				al = oldCh;
				ah = 0;
				ushort keyIndex = (ushort)(Make16(al, ah) << 1);
				ax = AdpWord((ushort)(0x0147 + keyIndex));
				int subRes = Lo8(ax) - ch;
				al = (byte)subRes;
				ah = (byte)(Hi8(ax) - (subRes < 0 ? 1 : 0));
				ax = Make16(al, ah);
			} else {
				bh = 5;
				ushort divWord = ax;
				divQ = (byte)(divWord / bh);
				divR = (byte)(divWord % bh);
				ch = (byte)(ch + divQ);
				if (ch >= 0x0C) {
					ch = (byte)(ch - 0x0C);
					cl = (byte)(cl + 1);
				}

				al = divR;
				ushort bx = 0x0190;
				if (ch >= 6) {
					bx = (ushort)(bx + 5);
				}
				byte frac = AdpByte((ushort)(bx + al));
				byte oldCh = ch;
				ch = frac;
				al = oldCh;
				ah = 0;
				ushort keyIndex = (ushort)(Make16(al, ah) << 1);
				ax = AdpWord((ushort)(0x0147 + keyIndex));
				int addRes = Lo8(ax) + ch;
				al = (byte)addRes;
				ah = (byte)(Hi8(ax) + (addRes > 0xFF ? 1 : 0));
				ax = Make16(al, ah);
			}
		}

		cl = (byte)(cl << 1);
		cl = (byte)(cl << 1);
		ah = (byte)(Hi8(ax) | cl);
		ax = Make16(Lo8(ax), ah);

		SI = DX;
		SI = (ushort)(SI + SI);
		AdpWordSet((ushort)(0x015F + SI), ax);
		ah = (byte)(Hi8(ax) | 0x20);
		AX = Make16(Lo8(ax), ah);
		AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(0);
		return NearRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:08e1).
	/// <code>
	/// dnadp:08e1
	/// dnadp:08e1  ADPReadWaitValue:                             ; CODE XREF: dnadp:0466, dnadp:05aa, dnadp:062e, dnadp:065c, dnadp:06a8, dnadp:07ec
	/// dnadp:08e1                  push    ax
	/// dnadp:08e2                  xor     ax, ax
	/// dnadp:08e4                  es:lodsb
	/// dnadp:08e6                  or      al, al
	/// dnadp:08e8                  jns     loc_00914
	/// dnadp:08ea                  xor     cx, cx
	/// dnadp:08ec
	/// dnadp:08ec  loc_008ec:                                    ; CODE XREF: dnadp:08f6
	/// dnadp:08ec                  mov     ch, cl
	/// dnadp:08ee                  mov     cl, ah
	/// dnadp:08f0                  mov     ah, al
	/// dnadp:08f2                  es:lodsb
	/// dnadp:08f4                  or      al, al
	/// dnadp:08f6                  js      loc_008ec
	/// dnadp:08f8                  and     ax, 7f7fh
	/// dnadp:08fb                  and     cx, 7f7fh
	/// dnadp:08ff                  shl     cl, 1
	/// dnadp:0901                  shr     cx, 1
	/// dnadp:0903                  shl     al, 1
	/// dnadp:0905                  shl     ax, 1
	/// dnadp:0907                  shr     cx, 1
	/// dnadp:0909                  rcr     ax, 1
	/// dnadp:090b                  shr     cx, 1
	/// dnadp:090d                  rcr     ax, 1
	/// dnadp:090f                  jcxz    loc_00914
	/// dnadp:0911                  mov     ax, 0ffffh
	/// dnadp:0914
	/// dnadp:0914  loc_00914:                                    ; CODE XREF: dnadp:08e8, dnadp:090f
	/// dnadp:0914                  mov     [di], ax
	/// dnadp:0916                  mov     [di+12h], si
	/// dnadp:0919                  pop     ax
	/// dnadp:091a                  ret
	/// </code>
	/// </summary>
	public Action AdpReadWaitValue_5BAE_08E1_05C401(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:08E1_ReadWaitValue");
		ushort savedAx = AX;
		ushort ax = 0;
		byte al = SegByte(ES, SI);
		SI = (ushort)(SI + 1);
		ax = Make16(al, 0);

		if ((al & 0x80) != 0) {
			ushort cx = 0;
			do {
				byte previousCl = Lo8(cx);
				byte previousAh = Hi8(ax);
				cx = Make16(previousAh, previousCl);
				Hi8(ref ax, al);
				al = SegByte(ES, SI);
				SI = (ushort)(SI + 1);
				Lo8(ref ax, al);
			} while ((al & 0x80) != 0);

			ax = (ushort)(ax & 0x7F7F);
			cx = (ushort)(cx & 0x7F7F);

			byte cl = Lo8(cx);
			cl = (byte)(cl << 1);
			Lo8(ref cx, cl);
			cx = (ushort)(cx >> 1);

			byte lowAl = Lo8(ax);
			lowAl = (byte)(lowAl << 1);
			Lo8(ref ax, lowAl);
			ax = (ushort)(ax << 1);

			bool carry = (cx & 0x0001) != 0;
			cx = (ushort)(cx >> 1);
			ax = (ushort)((ax >> 1) | (carry ? 0x8000 : 0));

			carry = (cx & 0x0001) != 0;
			cx = (ushort)(cx >> 1);
			ax = (ushort)((ax >> 1) | (carry ? 0x8000 : 0));

			if (cx != 0) {
				ax = 0xFFFF;
			}

			CX = cx;
		}

		AdpWordSet(DI, ax);
		AdpWordSet((ushort)(DI + 0x12), SI);
		AX = savedAx;
		return NearRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:091b).
	/// <code>
	/// dnadp:091b
	/// dnadp:091b  ADPUnknown091B:                               ; CODE XREF: dnadp:0300, dnadp:0978
	/// dnadp:091b                  push    ds
	/// dnadp:091c                  push    cs
	/// dnadp:091d                  pop     ds
	/// dnadp:091e                  mov     cx, 9
	/// dnadp:0921
	/// dnadp:0921  loc_00921:                                    ; CODE XREF: dnadp:0929
	/// dnadp:0921                  push    cx
	/// dnadp:0922                  mov     dx, cx
	/// dnadp:0924                  dec     dx
	/// dnadp:0925                  call    ADPOplNoteOff
	/// dnadp:0928                  pop     cx
	/// dnadp:0929                  loop    loc_00921
	/// dnadp:092b                  pop     ds
	/// dnadp:092c                  ret
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
	/// FULL commented disasm from gist (dnadp:092d).
	/// <code>
	/// dnadp:092d
	/// dnadp:092d  ADPFadeStep:                                  ; CODE XREF: dnadp:049d
	/// dnadp:092d                  mov     al, [19ch]
	/// dnadp:0930                  cmp     al, [19dh]
	/// dnadp:0934                  jnz     loc_00942
	/// dnadp:0936                  mov     word ptr [19fh], 1
	/// dnadp:093c                  and     byte ptr [19ah], 0bfh
	/// dnadp:0941                  ret
	/// dnadp:0942
	/// dnadp:0942  loc_00942:                                    ; CODE XREF: dnadp:0934
	/// dnadp:0942                  mov     ah, al
	/// dnadp:0944                  mov     bl, [19dh]
	/// dnadp:0948                  mov     bh, bl
	/// dnadp:094a                  and     al, 0fh
	/// dnadp:094c                  and     bl, 0fh
	/// dnadp:094f                  cmp     al, bl
	/// dnadp:0951                  jz      loc_0095b
	/// dnadp:0953                  inc     ah
	/// dnadp:0955                  jb      loc_0095b
	/// dnadp:0957                  dec     ah
	/// dnadp:0959                  dec     ah
	/// dnadp:095b
	/// dnadp:095b  loc_0095b:                                    ; CODE XREF: dnadp:0951, dnadp:0955
	/// dnadp:095b                  mov     al, ah
	/// dnadp:095d                  and     ah, 0f0h
	/// dnadp:0960                  and     bh, 0f0h
	/// dnadp:0963                  cmp     ah, bh
	/// dnadp:0965                  jz      loc_0096f
	/// dnadp:0967                  add     al, 10h
	/// dnadp:0969                  cmp     ah, bh
	/// dnadp:096b                  jb      loc_0096f
	/// dnadp:096d                  sub     al, 20h
	/// dnadp:096f
	/// dnadp:096f  loc_0096f:                                    ; CODE XREF: dnadp:0965, dnadp:096b
	/// dnadp:096f                  mov     [19ch], al
	/// dnadp:0972                  or      al, al
	/// dnadp:0974                  jnz     loc_00986
	/// dnadp:0976                  push    dx
	/// dnadp:0977                  push    si
	/// dnadp:0978                  call    ADPUnknown091B
	/// dnadp:097b                  pop     si
	/// dnadp:097c                  pop     dx
	/// dnadp:097d                  mov     byte ptr [19ah], 0
	/// </code>
	/// </summary>
	public Action AdpFadeStep_5BAE_092D_05C44D(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:092D_FadeStep");
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
	/// FULL commented disasm from gist (dnadp:0982).
	/// <code>
	/// dnadp:0982
	/// dnadp:0982  ADPUnknown0982:                               ; CODE XREF: dnadp:03fb
	/// dnadp:0982                  mov     al, cs:[19ch]
	/// dnadp:0986
	/// dnadp:0986  loc_00986:                                    ; CODE XREF: dnadp:0974
	/// dnadp:0986                  mov     ah, 26h
	/// dnadp:0988                  push    dx
	/// dnadp:0989                  mov     dx, cs:[2b3h]
	/// dnadp:098e                  add     dl, 4
	/// dnadp:0991                  xchg    al, ah
	/// dnadp:0993                  out     dx, al
	/// dnadp:0994                  inc     dx
	/// dnadp:0995                  xchg    al, ah
	/// dnadp:0997                  out     dx, al
	/// dnadp:0998                  pop     dx
	/// dnadp:0999                  ret
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
		AX = Make16(volume, 0x26);
		return NearRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:099a).
	/// <code>
	/// dnadp:099a
	/// dnadp:099a  ADPUnknown099A:                               ; CODE XREF: dnadp:03ef
	/// dnadp:099a                  mov     si, 171h
	/// dnadp:099d                  mov     cx, 12h
	/// dnadp:09a0                  mov     ah, 0ffh
	/// dnadp:09a2
	/// dnadp:09a2  loc_009a2:                                    ; CODE XREF: dnadp:09a8
	/// dnadp:09a2                  lodsb
	/// dnadp:09a3                  add     al, 80h
	/// dnadp:09a5                  call    ADPOplRegisterWrite
	/// dnadp:09a8                  loop    loc_009a2
	/// dnadp:09aa                  ret
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
	/// FULL commented disasm from gist (dnadp:09ab).
	/// <code>
	/// dnadp:09ab
	/// dnadp:09ab  ADPInstrumentWrite:                           ; CODE XREF: dnadp:0627
	/// dnadp:09ab                  add     dx, dx
	/// dnadp:09ad                  mov     bx, dx
	/// dnadp:09af                  mov     dx, cs:[bx+135h]
	/// dnadp:09b4                  shr     bx, 1
	/// dnadp:09b6                  call    ADPInstrumentWriteLoop
	/// dnadp:09b9                  xchg    dh, dl
	/// dnadp:09bb                  mov     ah, [si+1bh]
	/// dnadp:09be                  add     si, 0dh
	/// dnadp:09c1                  jmp     loc_009dc
	/// </code>
	/// </summary>
	public Action AdpInstrumentWrite_5BAE_09AB_05C4CB(int gotoAddress) {
		DX = (ushort)(DX * 2);
		ushort bx = DX;
		DX = AdpWord((ushort)(0x0135 + bx));
		bx = (ushort)(bx >> 1);
		AdpInstrumentWriteLoop_5BAE_09C3_05C4E3(0);
		DX = Make16(Hi8(DX), Lo8(DX));
		byte waveformAh = SegByte(DS, (ushort)(SI + 0x1B));
		SI = (ushort)(SI + 0x0D);
		AX = Make16(Lo8(AX), waveformAh);
		return AdpInstrumentWriteLoopFrom09DC_5BAE_09DC(0);
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:09c3).
	/// <code>
	/// dnadp:09c3
	/// dnadp:09c3  ADPInstrumentWriteLoop:                       ; CODE XREF: dnadp:09b6
	/// dnadp:09c3                  mov     ah, [si+0ch]
	/// dnadp:09c6                  shr     ax, 1
	/// dnadp:09c8                  mov     ah, [si+2]
	/// dnadp:09cb                  not     al
	/// dnadp:09cd                  shl     ax, 1
	/// dnadp:09cf                  and     ah, 0fh
	/// dnadp:09d2                  mov     al, 0c0h
	/// dnadp:09d4                  add     al, bl
	/// dnadp:09d6                  call    ADPOplRegisterWrite
	/// dnadp:09d9                  mov     ah, [si+1ah]
	/// </code>
	/// </summary>
	public Action AdpInstrumentWriteLoop_5BAE_09C3_05C4E3(int gotoAddress) {
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

		AX = Make16(Lo8(AX), (byte)(SegByte(DS, (ushort)(SI + 0x1A)) & 0x03));
		return AdpInstrumentWriteLoopFrom09DC_5BAE_09DC(0);
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:09dc).
	/// <code>
	/// dnadp:09dc
	/// dnadp:09dc  loc_009dc:                                    ; CODE XREF: dnadp:09c1
	/// dnadp:09dc                  and     ah, 3
	/// dnadp:09df                  mov     al, 0e0h
	/// dnadp:09e1                  add     al, dl
	/// dnadp:09e3                  call    ADPOplRegisterWrite
	/// dnadp:09e6                  mov     ah, [si+8]
	/// dnadp:09e9                  mov     al, [si]
	/// dnadp:09eb                  shl     ah, 1
	/// dnadp:09ed                  shl     ah, 1
	/// dnadp:09ef                  ror     ax, 1
	/// dnadp:09f1                  ror     ax, 1
	/// dnadp:09f3                  mov     al, 40h
	/// dnadp:09f5                  add     al, dl
	/// dnadp:09f7                  call    ADPOplRegisterWrite
	/// dnadp:09fa                  mov     ah, [si+3]
	/// dnadp:09fd                  mov     al, [si+6]
	/// dnadp:0a00                  shl     al, 1
	/// dnadp:0a02                  shl     al, 1
	/// dnadp:0a04                  shl     al, 1
	/// dnadp:0a06                  shl     al, 1
	/// dnadp:0a08                  shl     ax, 1
	/// dnadp:0a0a                  shl     ax, 1
	/// dnadp:0a0c                  shl     ax, 1
	/// dnadp:0a0e                  shl     ax, 1
	/// dnadp:0a10                  mov     al, 60h
	/// dnadp:0a12                  add     al, dl
	/// dnadp:0a14                  call    ADPOplRegisterWrite
	/// dnadp:0a17                  mov     ah, [si+4]
	/// dnadp:0a1a                  mov     al, [si+7]
	/// dnadp:0a1d                  shl     al, 1
	/// dnadp:0a1f                  shl     al, 1
	/// dnadp:0a21                  shl     al, 1
	/// dnadp:0a23                  shl     al, 1
	/// dnadp:0a25                  shl     ax, 1
	/// dnadp:0a27                  shl     ax, 1
	/// dnadp:0a29                  shl     ax, 1
	/// dnadp:0a2b                  shl     ax, 1
	/// dnadp:0a2d                  mov     al, 80h
	/// dnadp:0a2f                  add     al, dl
	/// dnadp:0a31                  call    ADPOplRegisterWrite
	/// dnadp:0a34                  mov     al, [si+0bh]
	/// dnadp:0a37                  ror     ax, 1
	/// dnadp:0a39                  mov     al, [si+5]
	/// dnadp:0a3c                  ror     ax, 1
	/// dnadp:0a3e                  mov     al, [si+0ah]
	/// dnadp:0a41                  ror     ax, 1
	/// dnadp:0a43                  mov     al, [si+9]
	/// dnadp:0a46                  ror     ax, 1
	/// dnadp:0a48                  mov     al, [si+1]
	/// dnadp:0a4b                  and     ax, 0f00fh
	/// dnadp:0a4e                  or      ah, al
	/// dnadp:0a50                  mov     al, 20h
	/// dnadp:0a52                  add     al, dl
	/// dnadp:0a54                  call    ADPOplRegisterWrite
	/// dnadp:0a57                  ret
	/// </code>
	/// </summary>
	public Action AdpInstrumentWriteLoopFrom09DC_5BAE_09DC(int gotoAddress) {
		byte dl = Lo8(DX);
		byte al;
		byte ah;

		ah = (byte)(Hi8(AX) & 0x03);
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
		ushort ax = (ushort)(Make16(al, ah) << 4);
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

		ushort axState = AX;
		al = SegByte(DS, (ushort)(SI + 0x0B));
		axState = Make16(al, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		al = SegByte(DS, (ushort)(SI + 0x05));
		axState = Make16(al, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		al = SegByte(DS, (ushort)(SI + 0x0A));
		axState = Make16(al, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		al = SegByte(DS, (ushort)(SI + 0x09));
		axState = Make16(al, Hi8(axState));
		axState = (ushort)((axState >> 1) | (axState << 15));
		al = SegByte(DS, (ushort)(SI + 0x01));
		axState = Make16(al, Hi8(axState));
		axState = (ushort)(axState & 0xF00F);
		AX = Make16((byte)(0x20 + dl), (byte)(Hi8(axState) | Lo8(axState)));
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		return NearRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:0a58).
	/// <code>
	/// dnadp:0a58
	/// dnadp:0a58  ADPOplNoteOn:                                 ; CODE XREF: dnadp:0658
	/// dnadp:0a58                  add     ax, 30h
	/// dnadp:0a5b                  cmp     ax, 60h
	/// dnadp:0a5e                  jb      loc_00a62
	/// dnadp:0a60                  xor     ax, ax
	/// dnadp:0a62
	/// dnadp:0a62  loc_00a62:                                    ; CODE XREF: dnadp:0a5e
	/// dnadp:0a62                  mov     bl, 0ch
	/// dnadp:0a64                  div     bl
	/// dnadp:0a66                  mov     cl, al
	/// dnadp:0a68                  xchg    ah, al
	/// dnadp:0a6a                  xor     ah, ah
	/// dnadp:0a6c                  add     ax, ax
	/// dnadp:0a6e                  mov     si, ax
	/// dnadp:0a70                  mov     ax, [si+147h]
	/// dnadp:0a74                  shl     cl, 1
	/// dnadp:0a76                  shl     cl, 1
	/// dnadp:0a78                  or      ah, cl
	/// dnadp:0a7a                  mov     si, dx
	/// dnadp:0a7c                  add     si, si
	/// dnadp:0a7e                  mov     [si+15fh], ax
	/// dnadp:0a82                  or      ah, 20h
	/// dnadp:0a85                  jmp     ADPOplFrequencyWrite
	/// </code>
	/// </summary>
	public Action AdpOplNoteOn_5BAE_0A58_05C578(int gotoAddress) {
		AX = (ushort)(AX + 0x30);
		if (AX >= 0x60) {
			AX = 0;
		}

		BL = 0x0C;
		ushort divWord = AX;
		AL = (byte)(divWord / BL);
		AH = (byte)(divWord % BL);

		CL = AL;
		byte tmp = AH;
		AH = AL;
		AL = tmp;
		AH = 0;
		AX = (ushort)(AX + AX);

		SI = AX;
		AX = AdpWord((ushort)(0x0147 + SI));

		CL = (byte)(CL << 1);
		CL = (byte)(CL << 1);
		AH = (byte)(AH | CL);

		SI = DX;
		SI = (ushort)(SI + SI);
		AdpWordSet((ushort)(0x015F + SI), AX);

		AH = (byte)(AH | 0x20);
		return AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(0);
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:0a87).
	/// <code>
	/// dnadp:0a87
	/// dnadp:0a87  ADPOplNoteOff:                                ; CODE XREF: dnadp:066b, dnadp:0925
	/// dnadp:0a87                  mov     si, dx
	/// dnadp:0a89                  add     si, si
	/// dnadp:0a8b                  mov     ax, [si+15fh]
	/// </code>
	/// </summary>
	public Action AdpOplNoteOff_5BAE_0A87_05C5A7(int gotoAddress) {
		SI = DX;
		SI = (ushort)(SI + SI);
		AX = AdpWord((ushort)(0x015F + SI));
		return AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(0);
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:0a8f).
	/// <code>
	/// dnadp:0a8f
	/// dnadp:0a8f  ADPOplFrequencyWrite:                         ; CODE XREF: dnadp:063d, dnadp:08de, dnadp:0a85
	/// dnadp:0a8f                  mov     cx, ax
	/// dnadp:0a91                  mov     al, dl
	/// dnadp:0a93                  add     al, 0a0h
	/// dnadp:0a95                  mov     ah, cl
	/// dnadp:0a97                  mov     si, ax
	/// dnadp:0a99                  call    ADPOplRegisterWrite
	/// dnadp:0a9c                  mov     ax, si
	/// dnadp:0a9e                  add     al, 10h
	/// dnadp:0aa0                  mov     ah, ch
	/// </code>
	/// </summary>
	public Action AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(int gotoAddress) {
		CX = AX;
		AX = Make16((byte)(0xA0 + DX), Lo8(CX));
		SI = AX;
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		AX = SI;
		AX = Make16((byte)(Lo8(AX) + 0x10), Hi8(CX));
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		return NearRet();
	}

	/// <summary>
	/// FULL commented disasm from gist (dnadp:0aa2).
	/// <code>
	/// dnadp:0aa2
	/// dnadp:0aa2  ADPOplRegisterWrite:                          ; CODE XREF: dnadp:02e7, dnadp:02ed, dnadp:02f3, dnadp:06e3, dnadp:0710, dnadp:073c, dnadp:077c, dnadp:07ae, dnadp:07e6, dnadp:09a5, dnadp:09d6, dnadp:09e3, dnadp:09f7, dnadp:0a14, dnadp:0a31, dnadp:0a54, dnadp:0a99
	/// dnadp:0aa2                  push    dx
	/// dnadp:0aa3                  mov     dx, 388h
	/// dnadp:0aa6                  out     dx, al
	/// dnadp:0aa7                  in      al, dx
	/// dnadp:0aa8                  in      al, dx
	/// dnadp:0aa9                  in      al, dx
	/// dnadp:0aaa                  in      al, dx
	/// dnadp:0aab                  in      al, dx
	/// dnadp:0aac                  in      al, dx
	/// dnadp:0aad                  in      al, dx
	/// dnadp:0aae                  inc     dx
	/// dnadp:0aaf                  mov     al, ah
	/// dnadp:0ab1                  out     dx, al
	/// dnadp:0ab2                  in      al, dx
	/// dnadp:0ab3                  in      al, dx
	/// dnadp:0ab4                  in      al, dx
	/// dnadp:0ab5                  in      al, dx
	/// dnadp:0ab6                  in      al, dx
	/// dnadp:0ab7                  in      al, dx
	/// dnadp:0ab8                  in      al, dx
	/// dnadp:0ab9                  in      al, dx
	/// dnadp:0aba                  in      al, dx
	/// dnadp:0abb                  in      al, dx
	/// dnadp:0abc                  in      al, dx
	/// dnadp:0abd                  in      al, dx
	/// dnadp:0abe                  in      al, dx
	/// dnadp:0abf                  in      al, dx
	/// dnadp:0ac0                  in      al, dx
	/// dnadp:0ac1                  in      al, dx
	/// dnadp:0ac2                  in      al, dx
	/// dnadp:0ac3                  in      al, dx
	/// dnadp:0ac4                  in      al, dx
	/// dnadp:0ac5                  in      al, dx
	/// dnadp:0ac6                  in      al, dx
	/// dnadp:0ac7                  in      al, dx
	/// dnadp:0ac8                  in      al, dx
	/// dnadp:0ac9                  in      al, dx
	/// dnadp:0aca                  in      al, dx
	/// dnadp:0acb                  in      al, dx
	/// dnadp:0acc                  in      al, dx
	/// dnadp:0acd                  in      al, dx
	/// dnadp:0ace                  in      al, dx
	/// dnadp:0acf                  in      al, dx
	/// dnadp:0ad0                  in      al, dx
	/// dnadp:0ad1                  in      al, dx
	/// dnadp:0ad2                  in      al, dx
	/// dnadp:0ad3                  in      al, dx
	/// dnadp:0ad4                  in      al, dx
	/// dnadp:0ad5                  pop     dx
	/// dnadp:0ad6                  ret
	/// </code>
	/// </summary>
	public Action AdpOplRegisterWrite_5BAE_0AA2_05C5C2(int gotoAddress) {
		byte register = Lo8(AX);
		byte value = Hi8(AX);
		CryogenicMcpTools.RecordAdpOplWrite(register, value, State.Cycles, _adpTickIndex);
		ushort savedDx = DX;
		ushort basePort = 0x0388;
		byte delayData = 0;

		Machine.IoPortDispatcher.WriteByte(basePort, register);
		for (int i = 0; i < 7; i++) {
			Machine.IoPortDispatcher.ReadByte(basePort);
		}

		ushort dataPort = (ushort)(basePort + 1);
		Machine.IoPortDispatcher.WriteByte(dataPort, value);
		for (int i = 0; i < 35; i++) {
			delayData = Machine.IoPortDispatcher.ReadByte(dataPort);
		}

		// ASM leaves AH as the written value (mov al,ah before data write); only AL is clobbered by IN delay reads.
		AX = Make16(delayData, value);
		DX = savedDx;
		return NearRet();
	}
}

#pragma warning restore S1854
#pragma warning restore S4136
#pragma warning restore MA0051