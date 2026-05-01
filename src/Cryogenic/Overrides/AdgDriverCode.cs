namespace Cryogenic.Overrides;

#pragma warning disable S1854 // Register-style assignments intentionally mirror assembly flow
#pragma warning disable S1144 // Helpers are staged ahead of the remaining ADG entrypoints
#pragma warning disable MA0051 // Some assembly-mirroring helpers exceed the local line budget

using Serilog;

using System;

/// <summary>
/// DNADG (AdLib Gold / OPL3) C# override scaffold.
/// This class is intentionally registration-only until runtime evidence is collected.
/// </summary>
public partial class Overrides {
	/// <summary>
	/// Secondary command bytes sent to the AdLib Gold command port.
	/// </summary>
	/// <remarks>
	/// These values come from live ADG traces and are used as explicit command phases.
	/// <code>
	/// mov AL,0xFF
	/// out DX,AL
	/// ...
	/// mov AL,0xFE
	/// out DX,AL
	/// </code>
	/// </remarks>
	private enum AdgSecondaryCommand : byte {
		ResetAndLatch = 0xFF,
		ReleaseReset = 0xFE
	}

	/// <summary>
	/// OPL register indexes used by DNADG during init, channel programming, and Gold surround control.
	/// </summary>
	/// <remarks>
	/// This enum replaces raw register bytes so reverse-engineering intent stays visible.
	/// <code>
	/// mov AL,0xBD
	/// out DX,AL
	/// inc DX
	/// mov AL,0x00
	/// out DX,AL
	/// </code>
	/// </remarks>
	private enum AdgOplRegister : byte {
		WaveformControl = 0x01,
		KeyScaleAndOutput = 0x40,
		AttackDecay = 0x60,
		SustainRelease = 0x80,
		FeedbackConnection = 0xC0,
		FrequencyLow = 0xA0,
		FrequencyHigh = 0xB0,
		ChannelEnable = 0x08,
		PercussionControl = 0xBD,
		Opl3Mode = 0x05,
		SecondaryControl = 0x04,
		GoldGlobalVolumeHi = 0x09,
		GoldGlobalVolumeLo = 0x0A,
		GoldSurroundControl = 0x18
	}

	/// <summary>
	/// Playback state bits tracked in ADG status byte at 0x01DE.
	/// </summary>
	/// <remarks>
	/// Flags are mirrored from observed branch/tests in the live driver.
	/// <code>
	/// mov AL,[0x01DE]
	/// or AL,AL
	/// jns ...
	/// </code>
	/// </remarks>
	[Flags]
	private enum AdgPlaybackStatus : byte {
		None = 0x00,
		Active = 0x80,
		FadePending = 0x40
	}

	private static readonly ILogger AdgLogger = Log.ForContext("Subsystem", "ADGDriver");
	private static bool EnableAdgCSharpFunctionReplacement = false;
	private ushort _adgSegment = 0x564B;

	private const ushort AdgDefaultSegment = 0x564B;
	private const ushort AdgStatusOffset = 0x01DE;
	private const ushort AdgTickEnabledOffset = 0x01DF;
	private const ushort AdgFadePatternOffset = 0x01E0;
	private const ushort AdgGoldStatusOffset = 0x011D;
	private const ushort AdgDynamicsOffset = 0x04D7;
	private const ushort AdgMasterVolumeOffset = 0x04D8;
	private const ushort AdgExtensionWordOffset = 0x04D9;
	private const ushort AdgExtensionByteOffset = 0x04DB;
	private const ushort AdgCurrentVolumeOffset = 0x04D6;
	private const ushort AdgSongPointerOffset = 0x011E;
	private const ushort AdgSongSegmentOffset = 0x0120;
	private const ushort AdgEventPointerOffset = 0x0122;
	private const ushort AdgEventSegmentOffset = 0x0124;
	private const ushort AdgTempoAccumulatorOffset = 0x0126;
	private const ushort AdgMeasureOffset = 0x0128;
	private const ushort AdgSubdivisionOffset = 0x012A;
	private const ushort AdgLoopCounterOffset = 0x012C;
	private const ushort AdgFadeScratchOffset = 0x013E;
	private const ushort AdgFadeScratch2Offset = 0x0140;
	private const ushort AdgSurroundMaskOffset = 0x017E;
	private const ushort AdgChannelTableBase = 0x01E2;
	private const ushort AdgChannelSourceOffsetsBase = 0x022A;
	private const ushort AdgChannelInitWordsBase = 0x024E;
	private const ushort AdgChannelInitWords2Base = 0x0296;
	private const ushort AdgChannelRoutingTableOffset = 0x017F;
	private const ushort AdgFrequencyWordTableOffset = 0x015A;
	private const ushort AdgPrimaryRegisterPortOffset = 0x0115;
	private const ushort AdgSecondaryRegisterPortOffset = 0x0117;
	private const ushort AdgSongIdentityCacheOffset = 0x061C;
	private const ushort AdgSongIdentityMagic1Offset = 0x0620;
	private const ushort AdgSongIdentityMagic2Offset = 0x0622;
	private const ushort AdgSongIdentityMagic3Offset = 0x0624;
	private const ushort AdgTickDividerOffset = 0x0127;
	private const int AdgResetChannelCount = 0x12;

	/// <summary>
	/// Registers ADG function overrides for the active remapped ADG segment.
	/// </summary>
	/// <remarks>
	/// This method is the entry switch for all ADG replacement wiring.
	/// <code>
	/// call far ADG:0100
	/// call far ADG:0103
	/// ...
	/// </code>
	/// </remarks>
	/// <summary>
	/// Registers DNADG overrides.
	/// Registration is intentionally disabled by default until the runtime ABI is validated from live MCP evidence.
	/// </summary>
	public void DefineAdgDriverCodeOverrides() {
		if (!EnableAdgCSharpFunctionReplacement) {
			AdgLogger.Information("DNADG full replacement disabled.");
			return;
		}

		ResolveAdgSegment();
		RegisterAdgObservedFunctionReplacements();
		AdgLogger.Information("DNADG replacement registrations enabled. Segment={AdgSegmentHex}",
			$"0x{_adgSegment:X4}");
	}

	/// <summary>
	/// Resolves the live ADG segment from the loader remap table.
	/// </summary>
	/// <remarks>
	/// <code>if ActualAdpSegment != 0 then use remapped segment else default 0x564B</code>
	/// </remarks>
	private void ResolveAdgSegment() {
		if (DriverLoadToolbox.ActualAdpSegment != 0) {
			_adgSegment = DriverLoadToolbox.ActualAdpSegment;
		} else {
			_adgSegment = AdgDefaultSegment;
		}
	}

	/// <summary>
	/// Reads one byte from the active ADG code/data segment.
	/// </summary>
	/// <remarks><code>mov AL, byte ptr [CS:offset]</code></remarks>
	private byte AdgByte(ushort offset) {
		return SegByte(_adgSegment, offset);
	}

	/// <summary>
	/// Writes one byte to the active ADG code/data segment.
	/// </summary>
	/// <remarks><code>mov byte ptr [CS:offset], AL</code></remarks>
	private void AdgByteSet(ushort offset, byte value) {
		SegByteSet(_adgSegment, offset, value);
	}

	/// <summary>
	/// Reads one word from the active ADG code/data segment.
	/// </summary>
	/// <remarks><code>mov AX, word ptr [CS:offset]</code></remarks>
	private ushort AdgWord(ushort offset) {
		return SegWord(_adgSegment, offset);
	}

	/// <summary>
	/// Writes one word to the active ADG code/data segment.
	/// </summary>
	/// <remarks><code>mov word ptr [CS:offset], AX</code></remarks>
	private void AdgWordSet(ushort offset, ushort value) {
		SegWordSet(_adgSegment, offset, value);
	}

	/// <summary>
	/// Mirrors PUSHF using the CPU stack and full FLAGS register.
	/// </summary>
	/// <remarks><code>pushf</code></remarks>
	private void AdgPushFlagsToStack() {
		Stack.Push16(State.Flags.FlagRegister16);
	}

	/// <summary>
	/// Mirrors POPF using the CPU stack and full FLAGS register.
	/// </summary>
	/// <remarks><code>popf</code></remarks>
	private void AdgPopFlagsFromStack() {
		State.Flags.FlagRegister = Stack.Pop16();
	}

	/// <summary>
	/// Converts AX input volume to ADG internal packed attenuation format.
	/// Observed from live execution at 564B:056E.
	/// </summary>
	/// <remarks>
	/// <code>
	/// shr AL,1
	/// ...
	/// div BH
	/// mul DL
	/// </code>
	/// </remarks>
	private void AdgComputeScaledVolumeFromAx() {
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

		al = 0;
		ushort axDiv = Make16(al, ah);
		al = (byte)(axDiv / bh);
		ah = (byte)(axDiv % bh);

		ushort mul1 = (ushort)(al * dl);
		al = Lo8(mul1);
		ah = Hi8(mul1);

		byte temp = ah;
		ah = dh;
		dh = temp;

		ah = (byte)(ah - bh);
		ah = (byte)(0 - ah);
		if (ah > bl) {
			ah = bl;
		}

		al = 0;
		axDiv = Make16(al, ah);
		al = (byte)(axDiv / bh);
		ah = (byte)(axDiv % bh);

		ushort axOut = (ushort)(al * dl);
		axOut = (ushort)(axOut >> 1);
		axOut = (ushort)(axOut >> 1);
		axOut = (ushort)(axOut >> 1);
		axOut = (ushort)(axOut >> 1);

		ah = dh;
		axOut = (ushort)(axOut & 0x0FF0);
		AX = (ushort)(axOut | ah);
	}

	/// <summary>
	/// Patches driver file-extension strings in caller-provided filename table.
	/// Observed from live execution at 564B:04DC.
	/// </summary>
	/// <remarks><code>scan '.' then copy extension bytes from CS:04D9/04DB</code></remarks>
	private void AdgPatchDriverFileExtensions_04DC() {
		ES = SS;
		SI = BP;
		ushort count = CX;
		while (count != 0) {
			AX = SegWord(ES, SI);
			SI = (ushort)(SI + 2);
			AX = (ushort)(AX + 2);
			DI = AX;

			ushort scanCount = 9;
			bool foundDot = false;
			while (scanCount != 0) {
				byte value = SegByte(ES, DI);
				DI = (ushort)(DI + 1);
				scanCount--;
				if (value == 0x2E) {
					foundDot = true;
					break;
				}
			}

			if (foundDot) {
				SegWordSet(ES, DI, AdgWord(AdgExtensionWordOffset));
				SegByteSet(ES, (ushort)(DI + 2), AdgByte(AdgExtensionByteOffset));
				DI = (ushort)(DI + 3);
			}

			count--;
		}
		CX = 0;
	}

	/// <summary>
	/// Writes an OPL register with the exact ADG port-delay pattern.
	/// </summary>
	/// <remarks><code>out DX,reg ; in DX x7 ; out DX+1,val ; in DX+1 x37</code></remarks>
	private void AdgWriteFixedOplRegister(ushort registerPort, byte registerIndex, byte registerValue) {
		ushort savedDx = DX;
		DX = registerPort;
		Machine.IoPortDispatcher.WriteByte(DX, registerIndex);
		for (int i = 0; i < 7; i++) {
			Machine.IoPortDispatcher.ReadByte(DX);
		}

		DX++;
		Machine.IoPortDispatcher.WriteByte(DX, registerValue);
		byte delayData = 0;
		for (int i = 0; i < 37; i++) {
			delayData = Machine.IoPortDispatcher.ReadByte(DX);
		}

		AX = Make16(delayData, registerValue);
		DX = savedDx;
	}

	/// <summary>
	/// Waits until the Gold secondary status port reports ready (bits 6/7 clear).
	/// Observed from live execution at 564B:1149.
	/// </summary>
	/// <remarks><code>in AL,DX ; and AL,0xC0 ; jne loop</code></remarks>
	private void AdgWaitSecondaryOplReady_1149() {
		ushort savedAx = AX;
		ushort savedDx = DX;
		DX = AdgWord(AdgSecondaryRegisterPortOffset);
		byte status = Machine.IoPortDispatcher.ReadByte(DX);
		while ((status & 0xC0) != 0) {
			status = Machine.IoPortDispatcher.ReadByte(DX);
		}
		DX = savedDx;
		AX = savedAx;
	}

	/// <summary>
	/// Writes AX as secondary Gold register/value after ready-wait.
	/// Observed from live execution at 564B:1158.
	/// </summary>
	/// <remarks><code>wait-ready ; out DX,AL ; out DX+1,AH</code></remarks>
	private void AdgWriteSecondaryOplRegisterWithReady_1158() {
		ushort savedAx = AX;
		ushort savedDx = DX;
		DX = AdgWord(AdgSecondaryRegisterPortOffset);
		byte status = Machine.IoPortDispatcher.ReadByte(DX);
		while ((status & 0xC0) != 0) {
			status = Machine.IoPortDispatcher.ReadByte(DX);
		}
		Machine.IoPortDispatcher.WriteByte(DX, Lo8(savedAx));
		DX++;
		Machine.IoPortDispatcher.WriteByte(DX, Hi8(savedAx));
		DX = savedDx;
		AX = savedAx;
	}

	/// <summary>
	/// Sends one command byte to the secondary Gold command port while preserving caller registers.
	/// </summary>
	/// <remarks><code>mov DX,[0117] ; out DX,AL</code></remarks>
	private void AdgSendSecondaryCommandByte(byte value) {
		ushort savedAx = AX;
		ushort savedCx = CX;
		ushort savedDx = DX;
		DX = AdgWord(AdgSecondaryRegisterPortOffset);
		Machine.IoPortDispatcher.WriteByte(DX, value);
		DX = savedDx;
		CX = savedCx;
		AX = savedAx;
	}

	private void AdgSendSecondaryCommandByte_FF_1176() {
		AdgSendSecondaryCommandByte((byte)AdgSecondaryCommand.ResetAndLatch);
	}

	/// <summary>
	/// Issues the Gold latch/reset command sequence start byte.
	/// </summary>
	/// <remarks>
	/// Address provenance: 564B:1176.
	/// <code>
	/// mov AL,0xFF
	/// out DX,AL
	/// ret
	/// </code>
	/// </remarks>

	private void AdgSendSecondaryCommandByte_FE_116E() {
		AdgWaitSecondaryOplReady_1149();
		AdgSendSecondaryCommandByte((byte)AdgSecondaryCommand.ReleaseReset);
	}

	/// <summary>
	/// Issues the Gold release command after waiting for ready state.
	/// </summary>
	/// <remarks>
	/// Address provenance: 564B:116E.
	/// <code>
	/// call 1149
	/// mov AL,0xFE
	/// out DX,AL
	/// ret
	/// </code>
	/// </remarks>

	/// <summary>
	/// Performs AdLib Gold startup initialization sequence.
	/// Observed from live execution at 564B:1185.
	/// </summary>
	private void AdgInitializeGoldHardware_1185() {
		AdgPushFlagsToStack();
		InterruptFlag = false;
		AdgSendSecondaryCommandByte_FF_1176();

		AX = 0xFB06;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AX = 0xF707;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AX = 0xF704;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AX++;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AX = 0xFF09;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AX++;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AdgWaitSecondaryOplReady_1149();

		DX = AdgWord(AdgSecondaryRegisterPortOffset);
		byte status = Machine.IoPortDispatcher.ReadByte((ushort)(DX + 1));
		status = (byte)(~status & 0x20);
		AdgByteSet(AdgGoldStatusOffset, status);
		AdgSendSecondaryCommandByte_FE_116E();
		AdgPopFlagsFromStack();
	}

	/// <summary>
	/// Direct write to secondary OPL address/data ports with ADG delay loops.
	/// </summary>
	/// <remarks><code>out secRegPort,index ; out secDataPort,value</code></remarks>
	private void AdgWriteSecondaryRegisterDirect(byte registerIndex, byte registerValue) {
		ushort savedDx = DX;
		DX = AdgWord(AdgSecondaryRegisterPortOffset);
		Machine.IoPortDispatcher.WriteByte(DX, registerIndex);
		for (int i = 0; i < 7; i++) {
			Machine.IoPortDispatcher.ReadByte(DX);
		}

		DX++;
		Machine.IoPortDispatcher.WriteByte(DX, registerValue);
		for (int i = 0; i < 35; i++) {
			Machine.IoPortDispatcher.ReadByte(DX);
		}

		DX = savedDx;
	}

	/// <summary>
	/// Direct write to primary OPL address/data ports with ADG delay loops.
	/// </summary>
	/// <remarks><code>out priRegPort,index ; out priDataPort,value</code></remarks>
	private void AdgWritePrimaryRegisterDirect(byte registerIndex, byte registerValue) {
		ushort savedDx = DX;
		DX = AdgWord(AdgPrimaryRegisterPortOffset);
		Machine.IoPortDispatcher.WriteByte(DX, registerIndex);
		for (int i = 0; i < 7; i++) {
			Machine.IoPortDispatcher.ReadByte(DX);
		}

		DX++;
		Machine.IoPortDispatcher.WriteByte(DX, registerValue);
		for (int i = 0; i < 35; i++) {
			Machine.IoPortDispatcher.ReadByte(DX);
		}

		DX = savedDx;
	}

	/// <summary>
	/// Applies a routed register write to primary/secondary chip by route sign.
	/// </summary>
	/// <remarks><code>if route&lt;0 then xor reg,0x80 and write secondary else write primary</code></remarks>
	private void AdgWriteRelativeGoldRegister(byte registerIndex, byte registerValue, sbyte route) {
		byte routedRegister = (byte)(registerIndex + (byte)route);
		if (route < 0) {
			routedRegister = (byte)(routedRegister ^ 0x80);
			AdgWriteSecondaryRegisterDirect(routedRegister, registerValue);
			return;
		}

		AdgWritePrimaryRegisterDirect(routedRegister, registerValue);
	}

	/// <summary>
	/// Applies current ADG master volume to Gold global volume registers.
	/// Observed from live execution at 564B:0F21.
	/// </summary>
	/// <remarks><code>write register 0x09 and 0x0A with packed high/low nibble attenuation</code></remarks>
	private void AdgApplyMasterVolumeToGold_0F21() {
		ushort savedAx = AX;
		AX = Make16(AdgByte(AdgCurrentVolumeOffset), Hi8(AX));
		AdgPushFlagsToStack();
		InterruptFlag = false;
		AdgSendSecondaryCommandByte_FF_1176();

		ushort preservedVolume = AX;
		byte highNibble = (byte)(Lo8(AX) & 0xF0);
		byte highRegisterValue = (byte)((highNibble >> 3) | 0x81);
		AdgWriteSecondaryOplRegisterWithReady(0x09, highRegisterValue);

		AX = preservedVolume;
		byte lowNibble = (byte)(Lo8(AX) & 0x0F);
		byte lowRegisterValue = (byte)((lowNibble << 1) | 0x81);
		AdgWriteSecondaryOplRegisterWithReady(0x0A, lowRegisterValue);

		AdgSendSecondaryCommandByte_FE_116E();
		AdgPopFlagsFromStack();
		AX = savedAx;
	}

	/// <summary>
	/// Clears operator state across playable channels on both OPL chips.
	/// Observed from live execution at 564B:0F53.
	/// </summary>
	/// <remarks><code>for channel in 0x15..0 : write 0xFF to both chips, skip percussion slots</code></remarks>
	private void AdgSilenceGoldChannels_0F53() {
		for (int channel = 0x15; channel >= 0; channel--) {
			if (channel == 6 || channel == 7 || channel == 0x0E || channel == 0x0F) {
				continue;
			}

			byte registerIndex = (byte)(channel + 0x80);
			AdgWritePrimaryRegisterDirect(registerIndex, 0xFF);
			AdgWriteSecondaryRegisterDirect(registerIndex, 0xFF);
		}
	}

	/// <summary>
	/// Writes one secondary Gold register/value pair using 1158 semantics.
	/// </summary>
	/// <remarks><code>mov AX,(reg,val) ; call 1158</code></remarks>
	private void AdgWriteSecondaryOplRegisterWithReady(byte registerIndex, byte registerValue) {
		ushort savedAx = AX;
		AX = Make16(registerIndex, registerValue);
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AX = savedAx;
	}

	/// <summary>
	/// Programs the Gold surround mask shift-register sequence.
	/// Observed from live execution at 564B:11F4.
	/// </summary>
	/// <remarks><code>loop 8: write register 0x18 with clock/data transitions</code></remarks>
	private void AdgWriteGoldSurroundMask_11F4() {
		byte originalValue = Lo8(AX);
		byte registerValue = Hi8(AX);
		for (int index = 0; index < 8; index++) {
			registerValue = (byte)(registerValue & 0xFD);
			AdgWriteSecondaryOplRegisterWithReady(0x18, registerValue);

			byte channelMask = (byte)((originalValue << 1) & 0xFE);
			registerValue = (byte)((registerValue & 0xFE) | channelMask);
			AdgWriteSecondaryOplRegisterWithReady(0x18, registerValue);

			registerValue = (byte)(registerValue | 0x02);
			AdgWriteSecondaryOplRegisterWithReady(0x18, registerValue);
		}
		AX = Make16(originalValue, registerValue);
	}

	/// <summary>
	/// Refreshes Gold surround state from the current song surround table.
	/// Observed from live execution at 564B:11C4.
	/// </summary>
	/// <remarks><code>for 0..0x1E: write mask-on, load table byte, write mask-off</code></remarks>
	private void AdgUpdateGoldSurround_11C4() {
		if (AdgByte(AdgGoldStatusOffset) == 0) {
			return;
		}

		AdgPushFlagsToStack();
		InterruptFlag = false;
		DX = 0;
		while (Lo8(DX) < 0x1F) {
			AX = Make16(Lo8(DX), 0);
			AdgWriteGoldSurroundMask_11F4();
			AdgWriteSecondaryOplRegisterWithReady(0x18, (byte)(Hi8(AX) | 0x04));

			byte mask = SegByte(ES, SI);
			SI = (ushort)(SI + 1);
			AX = Make16(mask, Hi8(AX));
			AdgWriteGoldSurroundMask_11F4();
			AdgWriteSecondaryOplRegisterWithReady(0x18, (byte)(Hi8(AX) & 0xFB));
			DX++;
		}
		AdgPopFlagsFromStack();
	}

	/// <summary>
	/// Decodes one ADG variable-length wait value from ES:SI into channel state.
	/// Observed from live execution at 564B:0E7E.
	/// </summary>
	/// <remarks><code>value = (value&lt;&lt;7) | (byte&amp;0x7F) until sign bit clears</code></remarks>
	private void AdgReadWaitValue_0E7E() {
		ushort savedAx = AX;
		uint value = 0;
		bool overflow = false;

		while (true) {
			byte current = SegByte(ES, SI);
			SI = (ushort)(SI + 1);
			value = (value << 7) | (uint)(current & 0x7F);
			if (value > 0xFFFF) {
				overflow = true;
			}
			if ((current & 0x80) == 0) {
				break;
			}
		}

		AdgWordSet(DI, overflow ? (ushort)0xFFFF : (ushort)value);
		AdgWordSet((ushort)(DI + 0x24), SI);
		AX = savedAx;
	}

	/// <summary>
	/// Builds the 18-channel runtime state table from current song pointers.
	/// Observed from live execution at 564B:068A.
	/// </summary>
	/// <remarks><code>initialize [022A..] pointers, [024E..]/[0296..] defaults, and first wait values</code></remarks>
	private void AdgBuildChannelTable_068A() {
		ushort currentDs = DS;
		ES = currentDs;

		ushort songOffset = AdgWord(AdgSongPointerOffset);
		ushort songSegment = AdgWord(AdgSongSegmentOffset);
		DS = songSegment;
		SI = songOffset;
		BP = SI;
		DI = AdgChannelSourceOffsetsBase;
		CX = AdgResetChannelCount;
		while (CX != 0) {
			ushort relativeOffset = SegWord(DS, SI);
			SI = (ushort)(SI + 2);
			ushort absoluteOffset = relativeOffset == 0 ? (ushort)0 : (ushort)(relativeOffset + BP);
			SegWordSet(ES, DI, absoluteOffset);
			DI = (ushort)(DI + 2);
			CX--;
		}

		DS = currentDs;
		DI = AdgChannelInitWordsBase;
		CX = AdgResetChannelCount;
		AX = 0x00FF;
		while (CX != 0) {
			AdgWordSet(DI, AX);
			DI = (ushort)(DI + 2);
			CX--;
		}

		DI = AdgChannelInitWords2Base;
		CX = AdgResetChannelCount;
		while (CX != 0) {
			AdgWordSet(DI, AX);
			DI = (ushort)(DI + 2);
			CX--;
		}

		ES = songSegment;
		SI = songOffset;
		AdgWordSet(AdgMeasureOffset, 1);
		AdgWordSet(AdgSubdivisionOffset, 0x0060);
		DI = AdgChannelTableBase;
		CX = AdgResetChannelCount;
		while (CX != 0) {
			ushort eventOffset = AdgWord((ushort)(DI + 0x48));
			AdgWordSet((ushort)(DI + 0x24), eventOffset);
			AdgWordSet(DI, 0xFFFF);
			AdgWordSet((ushort)(DI + 0x021C), 0);
			if (eventOffset != 0) {
				ushort currentCx = CX;
				SI = eventOffset;
				AX = currentCx;
				AdgReadWaitValue_0E7E();
				AdgWordSet(DI, (ushort)(AdgWord(DI) + 1));
				CX = AX;
			}
			DI = (ushort)(DI + 2);
			CX--;
		}

		AdgWordSet(AdgFadeScratchOffset, 0);
		AdgWordSet(AdgFadeScratch2Offset, 0);
		DS = currentDs;
	}

	/// <summary>
	/// Executes one fade-step iteration for dynamics transitions.
	/// Observed from live execution at 564B:0ECC.
	/// </summary>
	/// <remarks><code>nibble-wise step toward target volume; stop/reset when reaching zero</code></remarks>
	private void AdgFadeStep_0ECC() {
		byte currentVolume = AdgByte(AdgCurrentVolumeOffset);
		byte targetVolume = AdgByte(AdgDynamicsOffset);
		if (currentVolume == targetVolume) {
			AdgWordSet(AdgFadePatternOffset, 1);
			AdgByteSet(AdgStatusOffset, (byte)(AdgByte(AdgStatusOffset) & 0xBF));
			return;
		}

		byte updatedVolume = currentVolume;
		byte currentLowNibble = (byte)(updatedVolume & 0x0F);
		byte targetLowNibble = (byte)(targetVolume & 0x0F);
		if (currentLowNibble != targetLowNibble) {
			updatedVolume = (byte)(updatedVolume + 1);
			if (currentLowNibble > targetLowNibble) {
				updatedVolume = (byte)(updatedVolume - 2);
			}
		}

		byte currentHighNibble = (byte)(updatedVolume & 0xF0);
		byte targetHighNibble = (byte)(targetVolume & 0xF0);
		if (currentHighNibble != targetHighNibble) {
			updatedVolume = (byte)(updatedVolume + 0x10);
			if (currentHighNibble > targetHighNibble) {
				updatedVolume = (byte)(updatedVolume - 0x20);
			}
		}

		AdgByteSet(AdgCurrentVolumeOffset, updatedVolume);
		if (updatedVolume == 0) {
			ushort savedDx = DX;
			ushort savedSi = SI;
			AdgResetInternal_0EBA();
			SI = savedSi;
			DX = savedDx;
			AdgByteSet(AdgStatusOffset, 0);
		}
	}

	/// <summary>
	/// Writes one routed frequency/control register to the proper OPL chip.
	/// </summary>
	/// <remarks><code>route byte picks primary/secondary and register XOR 0x80 policy</code></remarks>
	private void AdgWriteRoutedOplRegister(byte registerBase, byte value, byte channelIndex) {
		ushort savedDx = DX;
		byte routeRaw = AdgByte((ushort)(AdgChannelRoutingTableOffset + channelIndex));
		sbyte signedRoute = unchecked((sbyte)routeRaw);
		byte routedRegister = (byte)(registerBase + routeRaw);
		ushort registerPort = signedRoute < 0 ? AdgWord(AdgSecondaryRegisterPortOffset) : AdgWord(AdgPrimaryRegisterPortOffset);

		if (signedRoute < 0) {
			routedRegister = (byte)(routedRegister ^ 0x80);
		}

		Machine.IoPortDispatcher.WriteByte(registerPort, routedRegister);
		for (int i = 0; i < 7; i++) {
			Machine.IoPortDispatcher.ReadByte(registerPort);
		}

		ushort dataPort = (ushort)(registerPort + 1);
		Machine.IoPortDispatcher.WriteByte(dataPort, value);
		byte delayData = 0;
		for (int i = 0; i < 37; i++) {
			delayData = Machine.IoPortDispatcher.ReadByte(dataPort);
		}

		AX = Make16(delayData, value);
		DX = savedDx;
	}

	/// <summary>
	/// Issues note-off writes for one logical ADG channel during reset.
	/// </summary>
	/// <remarks><code>write A0/B0 pair from cached frequency word table</code></remarks>
	private void AdgOplNoteOff_ResetHelper(ushort channelIndex) {
		DX = channelIndex;
		SI = DX;
		SI = (ushort)(SI + SI);
		AX = AdgWord((ushort)(AdgFrequencyWordTableOffset + SI));
		CX = AX;

		AdgWriteRoutedOplRegister(0xA0, Lo8(CX), (byte)channelIndex);
		AdgWriteRoutedOplRegister(0xB0, Hi8(CX), (byte)channelIndex);
	}

	/// <summary>
	/// Verifies that current song identity still matches the cached open-song snapshot.
	/// Observed from live execution at 564B:0730.
	/// </summary>
	/// <remarks><code>compare 3 identity words at +0,+0x4000,+0x8000 against 061C cache</code></remarks>
	private bool AdgIsSongIdentityStillValid_0730() {
		ushort savedSi = SI;
		ushort savedEs = ES;

		ES = AdgWord((ushort)(AdgSongIdentityCacheOffset + 2));
		SI = AdgWord(AdgSongIdentityCacheOffset);
		ushort word0 = SegWord(ES, SI);
		ushort word1 = SegWord(ES, (ushort)(SI + 0x4000));
		ushort word2 = SegWord(ES, (ushort)(SI + 0x8000));

		SI = savedSi;
		ES = savedEs;
		return word0 == AdgWord(AdgSongIdentityMagic1Offset)
			&& word1 == AdgWord(AdgSongIdentityMagic2Offset)
			&& word2 == AdgWord(AdgSongIdentityMagic3Offset);
	}

	/// <summary>
	/// Performs global note-off reset across all ADG channels.
	/// Observed from live execution at 564B:0EBA.
	/// </summary>
	/// <remarks><code>for CX=0x12..1: call note-off helper</code></remarks>
	private void AdgResetInternal_0EBA() {
		ushort originalDs = DS;
		DS = _adgSegment;

		CX = AdgResetChannelCount;
		while (CX != 0) {
			ushort currentCx = CX;
			ushort channelIndex = (ushort)(currentCx - 1);
			AdgOplNoteOff_ResetHelper(channelIndex);
			CX = (ushort)(currentCx - 1);
		}

		DS = originalDs;
	}

	/// <summary>
	/// Registers all currently observed ADG export and internal function entrypoints.
	/// </summary>
	/// <remarks><code>DefineFunction(segment, offset, override)</code></remarks>
	private void RegisterAdgObservedFunctionReplacements() {
		// <code>mov si,0100h ; export table start</code>
		// Export table validated live via MCP at 564B:0100 (ADG388).
		DefineFunction(_adgSegment, 0x0100, AdgInit_564B_0100_0565B0, false, nameof(AdgInit_564B_0100_0565B0));
		DefineFunction(_adgSegment, 0x0103, AdgOpenSong_564B_0103_0565B3, false, nameof(AdgOpenSong_564B_0103_0565B3));
		DefineFunction(_adgSegment, 0x0106, AdgReset_564B_0106_0565B6, false, nameof(AdgReset_564B_0106_0565B6));
		DefineFunction(_adgSegment, 0x0109, AdgSetTickEnabled_564B_0109_0565B9, false, nameof(AdgSetTickEnabled_564B_0109_0565B9));
		DefineFunction(_adgSegment, 0x010C, AdgSetDynamics_564B_010C_0565BC, false, nameof(AdgSetDynamics_564B_010C_0565BC));
		DefineFunction(_adgSegment, 0x010F, AdgTick_564B_010F_0565BF, false, nameof(AdgTick_564B_010F_0565BF));
		DefineFunction(_adgSegment, 0x0112, AdgSetVolume_564B_0112_0565C2, false, nameof(AdgSetVolume_564B_0112_0565C2));

		// Internal jump targets validated live from the same export table.
		DefineFunction(_adgSegment, 0x04FF, AdgInit_564B_04FF_0569AF, false, nameof(AdgInit_564B_04FF_0569AF));
		DefineFunction(_adgSegment, 0x0626, AdgOpenSong_564B_0626_056AD6, false, nameof(AdgOpenSong_564B_0626_056AD6));
		DefineFunction(_adgSegment, 0x0561, AdgReset_564B_0561_056A11, false, nameof(AdgReset_564B_0561_056A11));
		DefineFunction(_adgSegment, 0x0610, AdgSetTickEnabled_564B_0610_056AC0, false, nameof(AdgSetTickEnabled_564B_0610_056AC0));
		DefineFunction(_adgSegment, 0x05BE, AdgSetDynamics_564B_05BE_056A6E, false, nameof(AdgSetDynamics_564B_05BE_056A6E));
		DefineFunction(_adgSegment, 0x06F6, AdgTick_564B_06F6_056BA6, false, nameof(AdgTick_564B_06F6_056BA6));
		DefineFunction(_adgSegment, 0x05AB, AdgSetVolume_564B_05AB_056A5B, false, nameof(AdgSetVolume_564B_05AB_056A5B));
	}

	/// <summary>
	/// DNADG export wrapper at 564B:0100. Jumps to 564B:04FF.
	/// </summary>
	/// <remarks>
	/// <code>jmp 04FFh</code>
	/// </remarks>
	public Action AdgInit_564B_0100_0565B0(int gotoAddress) {
		AdgInit_564B_04FF_0569AF(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:0103. Jumps to 564B:0626.
	/// </summary>
	/// <remarks>
	/// <code>jmp 0626h</code>
	/// </remarks>
	public Action AdgOpenSong_564B_0103_0565B3(int gotoAddress) {
		AdgOpenSong_564B_0626_056AD6(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:0106. Jumps to 564B:0561.
	/// </summary>
	/// <remarks>
	/// <code>jmp 0561h</code>
	/// </remarks>
	public Action AdgReset_564B_0106_0565B6(int gotoAddress) {
		AdgReset_564B_0561_056A11(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:0109. Jumps to 564B:0610.
	/// </summary>
	/// <remarks>
	/// <code>jmp 0610h</code>
	/// </remarks>
	public Action AdgSetTickEnabled_564B_0109_0565B9(int gotoAddress) {
		AdgSetTickEnabled_564B_0610_056AC0(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:010C. Jumps to 564B:05BE.
	/// </summary>
	/// <remarks>
	/// <code>jmp 05BEh</code>
	/// </remarks>
	public Action AdgSetDynamics_564B_010C_0565BC(int gotoAddress) {
		AdgSetDynamics_564B_05BE_056A6E(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:010F. Jumps to 564B:06F6.
	/// </summary>
	/// <remarks>
	/// <code>jmp 06F6h</code>
	/// </remarks>
	public Action AdgTick_564B_010F_0565BF(int gotoAddress) {
		AdgTick_564B_06F6_056BA6(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:0112. Jumps to 564B:05AB.
	/// </summary>
	/// <remarks>
	/// <code>jmp 05ABh</code>
	/// </remarks>
	public Action AdgSetVolume_564B_0112_0565C2(int gotoAddress) {
		AdgSetVolume_564B_05AB_056A5B(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG internal init entry at 564B:04FF.
	/// </summary>
	/// <remarks>
	/// High-level init flow reconstructed from live evidence and DNADG.UNHSQ bytes.
	/// <code>
	/// out [SecondaryPort],0xFE
	/// call 04DC ; patch extension names
	/// call 1185 ; gold startup
	/// call 0561 ; reset voices
	/// mov BX,0x0F00
	/// retf
	/// </code>
	/// </remarks>
	public Action AdgInit_564B_04FF_0569AF(int gotoAddress) {
		if (AX != 0) {
			AdgWordSet(AdgPrimaryRegisterPortOffset, AX);
			AX = (ushort)(AX + 2);
			AdgWordSet(AdgSecondaryRegisterPortOffset, AX);
			AX = (ushort)(AX + 2);
			AdgWordSet(0x0119, AX);
			AX = (ushort)(AX + 2);
			AdgWordSet(0x011B, AX);
		}

		Machine.IoPortDispatcher.WriteByte(AdgWord(AdgSecondaryRegisterPortOffset), (byte)AdgSecondaryCommand.ReleaseReset);
		AdgPatchDriverFileExtensions_04DC();
		AdgWriteFixedOplRegister(AdgWord(AdgPrimaryRegisterPortOffset), (byte)AdgOplRegister.WaveformControl, 0x20);
		AdgWriteFixedOplRegister(AdgWord(AdgPrimaryRegisterPortOffset), (byte)AdgOplRegister.PercussionControl, 0x00);
		AdgWriteFixedOplRegister(AdgWord(AdgPrimaryRegisterPortOffset), (byte)AdgOplRegister.ChannelEnable, 0x40);
		AdgWriteFixedOplRegister(AdgWord(AdgSecondaryRegisterPortOffset), (byte)AdgOplRegister.Opl3Mode, 0x01);
		AdgWriteFixedOplRegister(AdgWord(AdgSecondaryRegisterPortOffset), (byte)AdgOplRegister.SecondaryControl, 0x00);
		AdgInitializeGoldHardware_1185();
		AdgReset_564B_0561_056A11(0);
		BX = 0x0F00;
		return FarRet();
	}

	/// <summary>
	/// DNADG internal open-song entry at 564B:0626.
	/// Currently routed to original machine code while helper-side behavior continues to be ported from live evidence.
	/// Live MCP and on-disk DNADG.UNHSQ byte slices both confirm this entrypoint contract.
	/// </summary>
	/// <remarks>
	/// <code>
	/// push DS
	/// push CS
	/// pop DS
	/// ...
	/// retf
	/// </code>
	/// </remarks>
	public Action AdgOpenSong_564B_0626_056AD6(int gotoAddress) {
		return NearJump(0x0626);
	}

	/// <summary>
	/// DNADG internal reset entry at 564B:0561.
	/// </summary>
	/// <remarks>
	/// <code>
	/// pushf
	/// cli
	/// call 0EBA
	/// mov AX,0
	/// mov [01DE],AL
	/// popf
	/// retf
	/// </code>
	/// </remarks>
	public Action AdgReset_564B_0561_056A11(int gotoAddress) {
		AdgPushFlagsToStack();
		InterruptFlag = false;
		AdgResetInternal_0EBA();
		AX = 0;
		AdgByteSet(AdgStatusOffset, (byte)AdgPlaybackStatus.None);
		AdgPopFlagsFromStack();
		return FarRet();
	}

	/// <summary>
	/// DNADG internal set-tick-enabled entry at 564B:0610.
	/// </summary>
	/// <remarks>
	/// <code>
	/// mov [01DF],1
	/// mov AL,[01DE]
	/// retf
	/// </code>
	/// </remarks>
	public Action AdgSetTickEnabled_564B_0610_056AC0(int gotoAddress) {
		AdgByteSet(AdgTickEnabledOffset, 1);
		AX = Make16(AdgByte(AdgStatusOffset), Hi8(AX));
		return FarRet();
	}

	/// <summary>
	/// DNADG internal set-dynamics entry at 564B:05BE.
	/// </summary>
	/// <remarks>
	/// <code>
	/// volume = Scale(BX)
	/// [04D7] = volume
	/// update [01E0] fade pattern
	/// if active: set fade-pending bit
	/// retf
	/// </code>
	/// </remarks>
	public Action AdgSetDynamics_564B_05BE_056A6E(int gotoAddress) {
		ushort savedAx = AX;
		AX = BX;
		AdgComputeScaledVolumeFromAx();
		AdgByteSet(AdgDynamicsOffset, Lo8(AX));
		AX = savedAx;

		ushort fadePattern = 0xFFFF;
		if (AX >= 0x0060) {
			fadePattern = 0xAAAA;
		}
		if (AX >= 0x00C0) {
			fadePattern = 0x8888;
		}
		if (AX >= 0x0180) {
			fadePattern = 0x8080;
		}
		if (AX >= 0x0300) {
			fadePattern = 0x8000;
		}
		AdgWordSet(AdgFadePatternOffset, fadePattern);

		byte status = AdgByte(AdgStatusOffset);
		if ((status & (byte)AdgPlaybackStatus.Active) != 0) {
			status = (byte)(status | (byte)AdgPlaybackStatus.FadePending);
			AdgByteSet(AdgStatusOffset, status);
		}
		return FarRet();
	}

	/// <summary>
	/// DNADG internal tick entry at 564B:06F6.
	/// Currently routed to original machine code while helper-side behavior continues to be ported from live evidence.
	/// Live MCP and on-disk DNADG.UNHSQ byte slices both confirm this entrypoint contract.
	/// </summary>
	/// <remarks>
	/// <code>
	/// call 0730 ; song identity check
	/// call 0756 ; scheduler
	/// rol [01E0],1
	/// call 0ECC ; fade step (conditional)
	/// retf
	/// </code>
	/// </remarks>
	public Action AdgTick_564B_06F6_056BA6(int gotoAddress) {
		return NearJump(0x06F6);
	}

	/// <summary>
	/// DNADG internal set-volume entry at 564B:05AB.
	/// </summary>
	/// <remarks>
	/// <code>
	/// volume = Scale(AX)
	/// [04D8] = volume
	/// [04D7] = volume
	/// [01E0] = 0xFFFF
	/// retf
	/// </code>
	/// </remarks>
	public Action AdgSetVolume_564B_05AB_056A5B(int gotoAddress) {
		AdgComputeScaledVolumeFromAx();
		byte scaledVolume = Lo8(AX);
		AdgByteSet(AdgMasterVolumeOffset, scaledVolume);
		AdgByteSet(AdgDynamicsOffset, scaledVolume);
		AdgWordSet(AdgFadePatternOffset, 0xFFFF);
		return FarRet();
	}
}