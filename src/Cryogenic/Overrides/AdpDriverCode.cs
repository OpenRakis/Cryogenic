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

		DefineFunction(_adpSegment, 0x02B5, AdpPatchFileExtensions_5BAE_02B5_05BDD5, false, nameof(AdpPatchFileExtensions_5BAE_02B5_05BDD5));
		DefineFunction(_adpSegment, 0x02D8, AdpInitInternal_5BAE_02D8_05BDF8, false, nameof(AdpInitInternal_5BAE_02D8_05BDF8));
		DefineFunction(_adpSegment, 0x02FE, AdpResetInternal_5BAE_02FE_05BE1E, false, nameof(AdpResetInternal_5BAE_02FE_05BE1E));
		DefineFunction(_adpSegment, 0x030B, AdpVolumeScale_5BAE_030B_05BE2B, false, nameof(AdpVolumeScale_5BAE_030B_05BE2B));
		DefineFunction(_adpSegment, 0x0348, AdpSetVolumeInternal_5BAE_0348_05BE68, false, nameof(AdpSetVolumeInternal_5BAE_0348_05BE68));
		DefineFunction(_adpSegment, 0x035B, AdpSetDynamicsInternal_5BAE_035B_05BE7B, false, nameof(AdpSetDynamicsInternal_5BAE_035B_05BE7B));
		DefineFunction(_adpSegment, 0x039C, AdpSetTimerTickFlag_5BAE_039C_05BEBC, false, nameof(AdpSetTimerTickFlag_5BAE_039C_05BEBC));
		DefineFunction(_adpSegment, 0x03B2, AdpOpenInternal_5BAE_03B2_05BED2, false, nameof(AdpOpenInternal_5BAE_03B2_05BED2));
		DefineFunction(_adpSegment, 0x0413, AdpBuildChannelTable_5BAE_0413_05BF33, false, nameof(AdpBuildChannelTable_5BAE_0413_05BF33));
		DefineFunction(_adpSegment, 0x0473, AdpTickInternal_5BAE_0473_05BF93, false, nameof(AdpTickInternal_5BAE_0473_05BF93));
		DefineFunction(_adpSegment, 0x04AD, AdpValidateSong_5BAE_04AD_05BFCD, false, nameof(AdpValidateSong_5BAE_04AD_05BFCD));
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
		DefineFunction(_adpSegment, 0x091B, AdpAllNotesOff_5BAE_091B_05C43B, false, nameof(AdpAllNotesOff_5BAE_091B_05C43B));
		DefineFunction(_adpSegment, 0x092D, AdpFadeStep_5BAE_092D_05C44D, false, nameof(AdpFadeStep_5BAE_092D_05C44D));
		DefineFunction(_adpSegment, 0x0982, AdpMixerWrite_5BAE_0982_05C4A2, false, nameof(AdpMixerWrite_5BAE_0982_05C4A2));
		DefineFunction(_adpSegment, 0x099A, AdpInitOplSlots_5BAE_099A_05C4BA, false, nameof(AdpInitOplSlots_5BAE_099A_05C4BA));
		DefineFunction(_adpSegment, 0x09AB, AdpInstrumentWrite_5BAE_09AB_05C4CB, false, nameof(AdpInstrumentWrite_5BAE_09AB_05C4CB));
		DefineFunction(_adpSegment, 0x09C3, AdpInstrumentWriteOperator_5BAE_09C3_05C4E3, false, nameof(AdpInstrumentWriteOperator_5BAE_09C3_05C4E3));
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

	public Action AdpInit_5BAE_0100_05BBE0(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0100_Init");
		return AdpInitInternal_5BAE_02D8_05BDF8(0);
	}

	public Action AdpOpen_5BAE_0103_05BBE3(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0103_OpenSong");
		CryogenicMcpTools.RecordAdpSongOpen(ES, SI);
		return AdpOpenInternal_5BAE_03B2_05BED2(0);
	}

	public Action AdpReset_5BAE_0106_05BBE6(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0106_Reset");
		return AdpResetInternal_5BAE_02FE_05BE1E(0);
	}

	public Action AdpSetTickEnabled_5BAE_0109_05BBE9(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0109_SetTickEnabled");
		return AdpSetTimerTickFlag_5BAE_039C_05BEBC(0);
	}

	public Action AdpSetDynamics_5BAE_010C_05BBEC(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:010C_SetDynamics");
		return AdpSetDynamicsInternal_5BAE_035B_05BE7B(0);
	}

	public Action AdpTick_5BAE_010F_05BBEF(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:010F_Tick");
		return AdpTickInternal_5BAE_0473_05BF93(0);
	}

	public Action AdpSetVolume_5BAE_0112_05BBF2(int gotoAddress) {
		CryogenicMcpTools.RecordAdpCall("5BAE:0112_SetVolume");
		return AdpSetVolumeInternal_5BAE_0348_05BE68(0);
	}

	public Action AdpPatchFileExtensions_5BAE_02B5_05BDD5(int gotoAddress) {
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

	public Action AdpInitInternal_5BAE_02D8_05BDF8(int gotoAddress) {
		AX = (ushort)(AX & 0x0FFF);
		if (AX != 0) {
			AdpWordSet(0x02B3, AX);
		}
		AdpPatchFileExtensions_5BAE_02B5_05BDD5(0);
		AX = 0x2001;
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		AX = 0x00BD;
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		AX = 0x4008;
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		AdpResetInternal_5BAE_02FE_05BE1E(0);
		BX = 0x0F00;
		return FarRet();
	}

	public Action AdpResetInternal_5BAE_02FE_05BE1E(int gotoAddress) {
		AdpPushFlagsToStack();
		InterruptFlag = false;
		AdpAllNotesOff_5BAE_091B_05C43B(0);
		AX = 0;
		AdpByteSet(0x019A, 0);
		AdpPopFlagsFromStack();
		return FarRet();
	}

	public Action AdpVolumeScale_5BAE_030B_05BE2B(int gotoAddress) {
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

	public Action AdpSetVolumeInternal_5BAE_0348_05BE68(int gotoAddress) {
		AdpVolumeScale_5BAE_030B_05BE2B(0);
		byte al = Lo8(AX);
		AdpByteSet(0x019E, al);
		AdpByteSet(0x019D, al);
		AdpWordSet(0x019F, 0xFFFF);
		return FarRet();
	}

	public Action AdpSetDynamicsInternal_5BAE_035B_05BE7B(int gotoAddress) {
		ushort savedAx = AX;
		AX = BX;
		AdpVolumeScale_5BAE_030B_05BE2B(0);
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

	public Action AdpSetTimerTickFlag_5BAE_039C_05BEBC(int gotoAddress) {
		AdpByteSet(0x019B, 1);
		byte al = AdpByte(0x019A);
		AX = Make16(al, Hi8(AX));
		return FarRet();
	}

	public Action AdpOpenInternal_5BAE_03B2_05BED2(int gotoAddress) {
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
		AdpInitOplSlots_5BAE_099A_05C4BA(0);
		AdpBuildChannelTable_5BAE_0413_05BF33(0);
		byte masterVolume = AdpByte(0x019E);
		AdpByteSet(0x019C, masterVolume);
		AdpMixerWrite_5BAE_0982_05C4A2(0);
		AdpByteSet(0x019D, Lo8(AX));
		AdpWordSet(0x011D, 0);
		AdpWordSet(0x0123, 0);
		AdpProcessTick_5BAE_04D3_05BFF3(0);
		AdpByteSet(0x019A, 0x80);
		DS = oldDs;
		return FarRet();
	}

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

	public Action AdpTickInternal_5BAE_0473_05BF93(int gotoAddress) {
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
				AdpValidateSong_5BAE_04AD_05BFCD(0);
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

	public Action AdpValidateSong_5BAE_04AD_05BFCD(int gotoAddress) {
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
			AdpResetInternal_5BAE_02FE_05BE1E(0);
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
			reg = (byte)(reg - scaleAl);
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
			reg = (byte)(reg - scaleAl);
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

	public Action AdpPitchBend_5BAE_07EA_05C30A(int gotoAddress) {
		byte al = Hi8(AX);
		AX = Make16(al, Hi8(AX));
		AdpReadWaitValue_5BAE_08E1_05C401(0);
		return AdpPitchBendBody_5BAE_07EF_05C30F(0);
	}

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
		byte freqHi = (byte)(Hi8(freq) | block | 0x20);
		ushort outWord = Make16(Lo8(freq), freqHi);
		AdpWordSet((ushort)(0x015F + DX * 2), outWord);
		AX = outWord;
		AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(0);
		return NearRet();
	}

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

	public Action AdpAllNotesOff_5BAE_091B_05C43B(int gotoAddress) {
		for (ushort c = 9; c > 0; c--) {
			DX = (ushort)(c - 1);
			AdpOplNoteOff_5BAE_0A87_05C5A7(0);
		}
		return NearRet();
	}

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
			AdpAllNotesOff_5BAE_091B_05C43B(0);
			AdpByteSet(0x019A, 0);
		}
		AdpMixerWrite_5BAE_0982_05C4A2(0);
		return NearRet();
	}

	public Action AdpMixerWrite_5BAE_0982_05C4A2(int gotoAddress) {
		byte volume = AdpByte(0x019C);
		ushort port = AdpWord(0x02B3);
		if (port == 0) {
			port = 0x0388;
		}
		port = (ushort)(port + 4);
		Machine.IoPortDispatcher.WriteByte(port, 0x26);
		Machine.IoPortDispatcher.WriteByte((ushort)(port + 1), volume);
		AX = Make16(volume, Hi8(AX));
		return NearRet();
	}

	public Action AdpInitOplSlots_5BAE_099A_05C4BA(int gotoAddress) {
		for (int i = 0; i < 0x12; i++) {
			byte reg = (byte)(AdpByte((ushort)(0x0171 + i)) + 0x80);
			AX = Make16(reg, 0xFF);
			AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		}
		return NearRet();
	}

	public Action AdpInstrumentWrite_5BAE_09AB_05C4CB(int gotoAddress) {
		DX = (ushort)(DX * 2);
		ushort bx = DX;
		DX = AdpWord((ushort)(0x0135 + bx));
		bx = (ushort)(bx >> 1);
		AdpInstrumentWriteOperator_5BAE_09C3_05C4E3(0);
		byte dl = Lo8(DX);
		byte dh = Hi8(DX);
		byte tmp = dl;
		dl = dh;
		dh = tmp;
		AX = Make16(Lo8(AX), SegByte(DS, (ushort)(SI + 0x1B)));
		SI = (ushort)(SI + 0x0D);
		return AdpInstrumentWriteOperator_5BAE_09C3_05C4E3(0);
	}

	public Action AdpInstrumentWriteOperator_5BAE_09C3_05C4E3(int gotoAddress) {
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

	public Action AdpOplNoteOff_5BAE_0A87_05C5A7(int gotoAddress) {
		AX = AdpWord((ushort)(0x015F + DX * 2));
		return AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(0);
	}

	public Action AdpOplFrequencyWrite_5BAE_0A8F_05C5AF(int gotoAddress) {
		ushort cx = AX;
		AX = Make16((byte)(0xA0 + DX), Lo8(cx));
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		AX = Make16((byte)(0xB0 + DX), Hi8(cx));
		AdpOplRegisterWrite_5BAE_0AA2_05C5C2(0);
		return NearRet();
	}

	public Action AdpOplRegisterWrite_5BAE_0AA2_05C5C2(int gotoAddress) {
		byte register = Lo8(AX);
		byte value = Hi8(AX);
		CryogenicMcpTools.RecordAdpOplWrite(register, value, State.Cycles, _adpTickIndex);
		ushort basePort = AdpWord(0x02B3);
		if (basePort == 0) {
			basePort = 0x0388;
		}
		Machine.IoPortDispatcher.WriteByte(basePort, register);
		for (int i = 0; i < 7; i++) {
			_ = Machine.IoPortDispatcher.ReadByte(basePort);
		}
		ushort dataPort = (ushort)(basePort + 1);
		Machine.IoPortDispatcher.WriteByte(dataPort, value);
		for (int i = 0; i < 35; i++) {
			_ = Machine.IoPortDispatcher.ReadByte(dataPort);
		}
		return NearRet();
	}
}

#pragma warning restore S1854
#pragma warning restore S4136
#pragma warning restore MA0051