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
		/// <summary>
		/// Forces Gold command latch mode and reset staging.
		/// </summary>
		ResetAndLatch = 0xFF,
		/// <summary>
		/// Leaves Gold command latch mode and resumes normal writes.
		/// </summary>
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
		/// <summary>Waveform control.</summary>
		WaveformControl = 0x01,
		/// <summary>Operator key-scale/output-level base register.</summary>
		KeyScaleAndOutput = 0x40,
		/// <summary>Operator attack/decay base register.</summary>
		AttackDecay = 0x60,
		/// <summary>Operator sustain/release base register.</summary>
		SustainRelease = 0x80,
		/// <summary>Operator feedback/connection base register.</summary>
		FeedbackConnection = 0xC0,
		/// <summary>Channel frequency low-byte base register.</summary>
		FrequencyLow = 0xA0,
		/// <summary>Channel frequency high-byte / key-on base register.</summary>
		FrequencyHigh = 0xB0,
		/// <summary>Channel control register used during init.</summary>
		ChannelEnable = 0x08,
		/// <summary>Global rhythm/percussion control register.</summary>
		PercussionControl = 0xBD,
		/// <summary>Secondary-chip OPL3 mode enable register.</summary>
		Opl3Mode = 0x05,
		/// <summary>Secondary-chip control register.</summary>
		SecondaryControl = 0x04,
		/// <summary>AdLib Gold global-volume high nibble register.</summary>
		GoldGlobalVolumeHi = 0x09,
		/// <summary>AdLib Gold global-volume low nibble register.</summary>
		GoldGlobalVolumeLo = 0x0A,
		/// <summary>AdLib Gold surround serial-control register.</summary>
		GoldSurroundControl = 0x18
	}

	/// <summary>
	/// Common immediate values extracted from live ADG instruction streams.
	/// </summary>
	private enum AdgImmediate : byte {
		/// <summary>Literal zero byte used for reset/clear writes.</summary>
		Zero = 0x00,
		/// <summary>Literal one byte used for enable and single-step flags.</summary>
		One = 0x01,
		/// <summary>Literal two byte used for bit toggles and increments.</summary>
		Two = 0x02,
		/// <summary>Literal three byte used in shift/divide helpers.</summary>
		Three = 0x03,
		/// <summary>Literal four byte used for Gold surround latch bit.</summary>
		Four = 0x04,
		/// <summary>Logical channel index 6 (percussion skip slot).</summary>
		Six = 0x06,
		/// <summary>Literal seven used in OPL address-port wait loops.</summary>
		Seven = 0x07,
		/// <summary>Literal eight used in surround serializer loop count.</summary>
		Eight = 0x08,
		/// <summary>Literal nine used in extension string scan window.</summary>
		Nine = 0x09,
		/// <summary>Literal ten.</summary>
		Ten = 0x0A,
		/// <summary>Literal twelve.</summary>
		Twelve = 0x0C,
		/// <summary>Logical channel index 14 (percussion skip slot).</summary>
		Fourteen = 0x0E,
		/// <summary>Logical channel index 15 (percussion skip slot).</summary>
		Fifteen = 0x0F,
		/// <summary>Total ADG logical channel count.</summary>
		Eighteen = 0x12,
		/// <summary>Upper bound (exclusive) for Gold surround channel traversal.</summary>
		ThirtyOne = 0x1F,
		/// <summary>Waveform-control value used during init.</summary>
		ThirtyTwo = 0x20,
		/// <summary>Data-port delay loop count for direct secondary/primary writes.</summary>
		ThirtyFive = 35,
		/// <summary>Data-port delay loop count for fixed write helper.</summary>
		ThirtySeven = 37,
		/// <summary>Default ADG subdivision tick seed.</summary>
		NinetySix = 0x60,
		/// <summary>Volume clamp threshold used by scaling routine.</summary>
		OneTwenty = 0x78,
		/// <summary>High-bit mask and sign bit constant.</summary>
		OneTwentyEight = 0x80,
		/// <summary>Gold volume command bit prefix.</summary>
		OneTwentyNine = 0x81,
		/// <summary>Status-ready mask for secondary OPL polling.</summary>
		OneNinetyTwoMask = 0xC0,
		/// <summary>Mask used to clear Gold surround latch bit 2.</summary>
		TwoFiftyOneMask = 0xFB,
		/// <summary>Mask used to clear Gold surround clock bit 1.</summary>
		TwoFiftyThreeMask = 0xFD,
		/// <summary>Mask used to keep serialized surround data as 7-bit lane.</summary>
		TwoFiftyFourMask = 0xFE,
		/// <summary>All-bits-set byte.</summary>
		TwoFiftyFive = 0xFF,
		/// <summary>ASCII '.' used in extension patch scanning.</summary>
		DotAscii = 0x2E,
		/// <summary>High-nibble extraction mask.</summary>
		F0Mask = 0xF0,
		/// <summary>Low 8-bit word seed for 0x00FF patterns.</summary>
		Ff16Lo = 0xFF,
		/// <summary>Variable-length decode payload mask.</summary>
		SevenBitMask = 0x7F,
		/// <summary>Mask used to clear fade-pending status bit.</summary>
		FadeClearMask = 0xBF,
		/// <summary>Mask used to derive Gold present bit from status register.</summary>
		GoldPresentMask = 0x20
	}

	/// <summary>
	/// Named fade-pattern words written to ADG fade state.
	/// </summary>
	/// <remarks>
	/// These 16-bit patterns are rotated by the original driver to control fade cadence.
	/// </remarks>
	private enum AdgFadePattern : ushort {
		/// <summary>Single terminal step when target volume is reached.</summary>
		SingleStep = 0x0001,
		/// <summary>Fastest repeating fade cadence.</summary>
		Fastest = 0x8000,
		/// <summary>Fast repeating fade cadence.</summary>
		Fast = 0x8080,
		/// <summary>Medium repeating fade cadence.</summary>
		Medium = 0x8888,
		/// <summary>Slow repeating fade cadence.</summary>
		Slow = 0xAAAA,
		/// <summary>Immediate transition (no staggered fade cadence).</summary>
		Immediate = 0xFFFF
	}

	/// <summary>
	/// Fixed Gold initialization command words observed at 564B:1185.
	/// </summary>
	/// <remarks>
	/// Each word encodes <c>AL=register</c> and <c>AH=value</c> for helper 1158.
	/// </remarks>
	private enum AdgGoldInitWord : ushort {
		/// <summary>Gold control register 0x06 set to 0xFB.</summary>
		Fb06 = 0xFB06,
		/// <summary>Gold control register 0x07 set to 0xF7.</summary>
		F707 = 0xF707,
		/// <summary>Gold control register 0x04 set to 0xF7.</summary>
		F704 = 0xF704,
		/// <summary>Gold control register 0x05 set to 0xF7.</summary>
		F705 = 0xF705,
		/// <summary>Gold global-volume high register 0x09 set to 0xFF.</summary>
		Ff09 = 0xFF09,
		/// <summary>Gold global-volume low register 0x0A set to 0xFF.</summary>
		Ff0A = 0xFF0A
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
	private static bool EnableAdgCSharpFunctionReplacement = true;
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
	private const ushort AdgOperationHandlerTableOffset = 0x012E;
	private const ushort AdgFadeScratchOffset = 0x013E;
	private const ushort AdgFadeScratch2Offset = 0x0140;
	private const ushort AdgSurroundMaskOffset = 0x017E;
	private const ushort AdgChannelTableBase = 0x01E2;
	private const ushort AdgLoopSnapshotBase = 0x03B6;
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
	private const ushort AdgSongLoopStartMeasureOffset = 0x002A;
	private const ushort AdgSongLoopEndMeasureOffset = 0x002C;
	private const ushort AdgSongLoopRepeatCountOffset = 0x002E;
	private const ushort AdgChannelPitchBendCounterOffset = 0x00B4;
	private const ushort AdgChannelPitchAccumulatorOffset = 0x00D8;
	private const ushort AdgAuxRegisterPortOffset1 = 0x0119;
	private const ushort AdgAuxRegisterPortOffset2 = 0x011B;
	private const ushort AdgVolumeHighNibbleWordMask = 0x0FF0;
	private const ushort AdgChannelWaitValueEventPointerOffset = 0x0024;
	private const ushort AdgChannelStateEventSourceOffset = 0x0048;
	private const ushort AdgChannelInstrumentOffset = 0x006C;
	private const ushort AdgChannelCurrentNoteOffset = 0x006D;
	private const ushort AdgChannelPitchModeOffset = 0x0090;
	private const ushort AdgChannelPitchTransposeOffset = 0x0091;
	private const ushort AdgChannelStateScratchOffset = 0x021C;
	private const ushort AdgChannelTlShapingOffset = 0x00FC;
	private const ushort AdgChannelEnvShapingOffset = 0x0120;
	private const ushort AdgChannelCurrentOperatorLevelOffset = 0x0144;
	private const ushort AdgChannelConnectionShapingOffset = 0x0168;
	private const ushort AdgChannelPrimaryOperatorRouteOffset = 0x01A3;
	private const ushort AdgChannelConnectionModulationOffset = 0x01B0;
	private const ushort AdgChannelConnectionCurrentOffset = 0x01B1;
	private const ushort AdgChannelRouteShadowOffset = 0x0191;
	private const ushort AdgChannelSecondaryOperatorRouteOffset = 0x01B5;
	private const ushort AdgChannelVolumeModulationOffset = 0x018C;
	private const ushort AdgChannelPatchTypeOffset = 0x02D0;
	private const ushort AdgIdentityWordSecondPlaneOffset = 0x4000;
	private const ushort AdgIdentityWordThirdPlaneOffset = 0x8000;
	private const ushort AdgFrequencyLookupTableOffset = 0x0142;
	private const ushort AdgPitchBendFractionsTableOffset = 0x01C7;
	private const ushort AdgPortamentoFractionsTableOffset = 0x01D4;
	private const ushort AdgDynamicsThresholdSlow = 0x0060;
	private const ushort AdgDynamicsThresholdMedium = 0x00C0;
	private const ushort AdgDynamicsThresholdFast = 0x0180;
	private const ushort AdgDynamicsThresholdFastest = 0x0300;
	private const ushort AdgDriverInitBxResult = 0x0F00;
	private const byte AdgLastLogicalChannelIndex = 0x15;
	private const byte AdgFadeHighNibbleIncrement = 0x10;
	private const byte AdgFadeHighNibbleDecrement = 0x20;
	private const ushort AdgLoopSnapshotWordCount = 0x0024;
	private const int AdgObservedOperationHandlerCount = 8;
	private const int AdgResetChannelCount = (byte)AdgImmediate.Eighteen;

	/// <summary>
	/// Registers ADG function overrides for the active remapped ADG segment.
	/// </summary>
	/// <remarks>
	/// Registration is intentionally disabled by default until runtime ABI parity is validated.
	/// This method is the single activation switch for all ADG replacement wiring.
	/// <code>
	/// call far ADG:0100
	/// call far ADG:0103
	/// ...
	/// </code>
	/// </remarks>
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

	private static ushort AdgChannelSlotOffset(ushort relativeOffset, ushort channelIndex) {
		return (ushort)(AdgChannelTableBase + relativeOffset + (channelIndex << 1));
	}

	private byte AdgChannelByte(ushort relativeOffset, ushort channelIndex) {
		return AdgByte(AdgChannelSlotOffset(relativeOffset, channelIndex));
	}

	private void AdgChannelByteSet(ushort relativeOffset, ushort channelIndex, byte value) {
		AdgByteSet(AdgChannelSlotOffset(relativeOffset, channelIndex), value);
	}

	private ushort AdgChannelWord(ushort relativeOffset, ushort channelIndex) {
		return AdgWord(AdgChannelSlotOffset(relativeOffset, channelIndex));
	}

	private void AdgChannelWordSet(ushort relativeOffset, ushort channelIndex, ushort value) {
		AdgWordSet(AdgChannelSlotOffset(relativeOffset, channelIndex), value);
	}

	private byte AdgIndexedByte(ushort baseOffset, ushort channelIndex) {
		return AdgByte((ushort)(baseOffset + channelIndex));
	}

	private void AdgIndexedByteSet(ushort baseOffset, ushort channelIndex, byte value) {
		AdgByteSet((ushort)(baseOffset + channelIndex), value);
	}

	private ushort AdgIndexedWord(ushort baseOffset, ushort channelIndex) {
		return AdgWord((ushort)(baseOffset + (channelIndex << 1)));
	}

	private void AdgIndexedWordSet(ushort baseOffset, ushort channelIndex, ushort value) {
		AdgWordSet((ushort)(baseOffset + (channelIndex << 1)), value);
	}

	private void AdgWriteRouteSelectedRegister_1101(byte registerBase, byte registerValue, byte routeByte) {
		sbyte route = unchecked((sbyte)routeByte);
		AdgWriteRelativeGoldRegister(registerBase, registerValue, route);
	}

	private void AdgWriteChannelRegister_10ED(byte registerBase, byte registerValue, ushort channelIndex) {
		byte routeByte = AdgIndexedByte(AdgChannelRoutingTableOffset, channelIndex);
		AdgWriteRouteSelectedRegister_1101(registerBase, registerValue, routeByte);
	}

	private void AdgWriteFrequencyWord_10E0(ushort channelIndex, ushort frequencyWord) {
		AdgWriteChannelRegister_10ED((byte)AdgOplRegister.FrequencyLow, Lo8(frequencyWord), channelIndex);
		AdgWriteChannelRegister_10ED((byte)AdgOplRegister.FrequencyHigh, Hi8(frequencyWord), channelIndex);
	}

	private void AdgNoteOn_10A9(ushort channelIndex, ushort rawPitch) {
		ushort noteWord = (ushort)(rawPitch + 0x0030);
		if (noteWord >= 0x0060) {
			noteWord = 0;
		}

		byte octave = (byte)(noteWord / (byte)AdgImmediate.Twelve);
		byte semitone = (byte)(noteWord % (byte)AdgImmediate.Twelve);
		ushort frequencyWord = AdgWord((ushort)(AdgFrequencyLookupTableOffset + (semitone << 1)));
		frequencyWord = Make16(Lo8(frequencyWord), (byte)(Hi8(frequencyWord) | (octave << 2)));
		AdgIndexedWordSet(AdgFrequencyWordTableOffset, channelIndex, frequencyWord);
		frequencyWord = Make16(Lo8(frequencyWord), (byte)(Hi8(frequencyWord) | (byte)AdgImmediate.ThirtyTwo));
		AdgWriteFrequencyWord_10E0(channelIndex, frequencyWord);
	}

	private void AdgNoteOff_10D8(ushort channelIndex) {
		ushort frequencyWord = AdgIndexedWord(AdgFrequencyWordTableOffset, channelIndex);
		AdgWriteFrequencyWord_10E0(channelIndex, frequencyWord);
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
		byte bl = (byte)AdgImmediate.OneTwenty;
		byte bh = (byte)AdgImmediate.F0Mask;
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
		axOut = (ushort)(axOut & AdgVolumeHighNibbleWordMask);
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

			ushort scanCount = (byte)AdgImmediate.Nine;
			bool foundDot = false;
			while (scanCount != 0) {
				byte value = SegByte(ES, DI);
				DI = (ushort)(DI + 1);
				scanCount--;
				if (value == (byte)AdgImmediate.DotAscii) {
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
		for (int i = 0; i < (byte)AdgImmediate.Seven; i++) {
			Machine.IoPortDispatcher.ReadByte(DX);
		}

		DX++;
		Machine.IoPortDispatcher.WriteByte(DX, registerValue);
		byte delayData = 0;
		for (int i = 0; i < (byte)AdgImmediate.ThirtySeven; i++) {
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
		while ((status & (byte)AdgImmediate.OneNinetyTwoMask) != 0) {
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
		while ((status & (byte)AdgImmediate.OneNinetyTwoMask) != 0) {
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
	private void AdgSendSecondaryCommandByte_FF_1176() {
		AdgSendSecondaryCommandByte((byte)AdgSecondaryCommand.ResetAndLatch);
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
	private void AdgSendSecondaryCommandByte_FE_116E() {
		AdgWaitSecondaryOplReady_1149();
		AdgSendSecondaryCommandByte((byte)AdgSecondaryCommand.ReleaseReset);
	}

	/// <summary>
	/// Performs AdLib Gold startup initialization sequence.
	/// Observed from live execution at 564B:1185.
	/// </summary>
	private void AdgInitializeGoldHardware_1185() {
		AdgPushFlagsToStack();
		InterruptFlag = false;
		AdgSendSecondaryCommandByte_FF_1176();

		AX = (ushort)AdgGoldInitWord.Fb06;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AX = (ushort)AdgGoldInitWord.F707;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AX = (ushort)AdgGoldInitWord.F704;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AX = (ushort)AdgGoldInitWord.F705;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AX = (ushort)AdgGoldInitWord.Ff09;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AX = (ushort)AdgGoldInitWord.Ff0A;
		AdgWriteSecondaryOplRegisterWithReady_1158();
		AdgWaitSecondaryOplReady_1149();

		DX = AdgWord(AdgSecondaryRegisterPortOffset);
		byte status = Machine.IoPortDispatcher.ReadByte((ushort)(DX + 1));
		status = (byte)(~status & (byte)AdgImmediate.GoldPresentMask);
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
		for (int i = 0; i < (byte)AdgImmediate.Seven; i++) {
			Machine.IoPortDispatcher.ReadByte(DX);
		}

		DX++;
		Machine.IoPortDispatcher.WriteByte(DX, registerValue);
		for (int i = 0; i < (byte)AdgImmediate.ThirtyFive; i++) {
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
		for (int i = 0; i < (byte)AdgImmediate.Seven; i++) {
			Machine.IoPortDispatcher.ReadByte(DX);
		}

		DX++;
		Machine.IoPortDispatcher.WriteByte(DX, registerValue);
		for (int i = 0; i < (byte)AdgImmediate.ThirtyFive; i++) {
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
			routedRegister = (byte)(routedRegister ^ (byte)AdgImmediate.OneTwentyEight);
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
		byte highNibble = (byte)(Lo8(AX) & (byte)AdgImmediate.F0Mask);
		byte highRegisterValue = (byte)((highNibble >> 3) | (byte)AdgImmediate.OneTwentyNine);
		AdgWriteSecondaryOplRegisterWithReady((byte)AdgOplRegister.GoldGlobalVolumeHi, highRegisterValue);

		AX = preservedVolume;
		byte lowNibble = (byte)(Lo8(AX) & (byte)AdgImmediate.Fifteen);
		byte lowRegisterValue = (byte)((lowNibble << 1) | (byte)AdgImmediate.OneTwentyNine);
		AdgWriteSecondaryOplRegisterWithReady((byte)AdgOplRegister.GoldGlobalVolumeLo, lowRegisterValue);

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
		for (int channel = AdgLastLogicalChannelIndex; channel >= (byte)AdgImmediate.Zero; channel--) {
			if (channel == (byte)AdgImmediate.Six
				|| channel == (byte)AdgImmediate.Seven
				|| channel == (byte)AdgImmediate.Fourteen
				|| channel == (byte)AdgImmediate.Fifteen) {
				continue;
			}

			byte registerIndex = (byte)(channel + (byte)AdgImmediate.OneTwentyEight);
			AdgWritePrimaryRegisterDirect(registerIndex, (byte)AdgImmediate.TwoFiftyFive);
			AdgWriteSecondaryRegisterDirect(registerIndex, (byte)AdgImmediate.TwoFiftyFive);
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
		for (int index = 0; index < (byte)AdgImmediate.Eight; index++) {
			registerValue = (byte)(registerValue & (byte)AdgImmediate.TwoFiftyThreeMask);
			AdgWriteSecondaryOplRegisterWithReady((byte)AdgOplRegister.GoldSurroundControl, registerValue);

			byte channelMask = (byte)((originalValue << 1) & (byte)AdgImmediate.TwoFiftyFourMask);
			registerValue = (byte)((registerValue & (byte)AdgImmediate.TwoFiftyFourMask) | channelMask);
			AdgWriteSecondaryOplRegisterWithReady((byte)AdgOplRegister.GoldSurroundControl, registerValue);

			registerValue = (byte)(registerValue | (byte)AdgImmediate.Two);
			AdgWriteSecondaryOplRegisterWithReady((byte)AdgOplRegister.GoldSurroundControl, registerValue);
		}
		AX = Make16(originalValue, registerValue);
	}

	/// <summary>
	/// Refreshes Gold surround state from the current song surround table.
	/// Observed from live execution at 564B:11C4.
	/// </summary>
	/// <remarks><code>for 0..0x1E: write mask-on, load table byte, write mask-off</code></remarks>
	private void AdgUpdateGoldSurround_11C4() {
		if (AdgByte(AdgGoldStatusOffset) == (byte)AdgImmediate.Zero) {
			return;
		}

		AdgPushFlagsToStack();
		InterruptFlag = false;
		DX = 0;
		while (Lo8(DX) < (byte)AdgImmediate.ThirtyOne) {
			AX = Make16(Lo8(DX), (byte)AdgImmediate.Zero);
			AdgWriteGoldSurroundMask_11F4();
			AdgWriteSecondaryOplRegisterWithReady((byte)AdgOplRegister.GoldSurroundControl, (byte)(Hi8(AX) | (byte)AdgImmediate.Four));

			byte mask = SegByte(ES, SI);
			SI = (ushort)(SI + 1);
			AX = Make16(mask, Hi8(AX));
			AdgWriteGoldSurroundMask_11F4();
			AdgWriteSecondaryOplRegisterWithReady((byte)AdgOplRegister.GoldSurroundControl, (byte)(Hi8(AX) & (byte)AdgImmediate.TwoFiftyOneMask));
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
			value = (value << (byte)AdgImmediate.Seven) | (uint)(current & (byte)AdgImmediate.SevenBitMask);
			if (value > ushort.MaxValue) {
				overflow = true;
			}
			if ((current & (byte)AdgImmediate.OneTwentyEight) == 0) {
				break;
			}
		}

		AdgWordSet(DI, overflow ? ushort.MaxValue : (ushort)value);
		AdgWordSet((ushort)(DI + AdgChannelWaitValueEventPointerOffset), SI);
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
		AX = (byte)AdgImmediate.TwoFiftyFive;
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
		AdgWordSet(AdgSubdivisionOffset, (byte)AdgImmediate.NinetySix);
		DI = AdgChannelTableBase;
		CX = AdgResetChannelCount;
		while (CX != 0) {
			ushort eventOffset = AdgWord((ushort)(DI + AdgChannelStateEventSourceOffset));
			AdgWordSet((ushort)(DI + AdgChannelWaitValueEventPointerOffset), eventOffset);
			AdgWordSet(DI, ushort.MaxValue);
			AdgWordSet((ushort)(DI + AdgChannelStateScratchOffset), 0);
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
	/// Resets only the runtime scheduler state while reusing the current channel source table.
	/// Observed from live execution at 564B:06B9.
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:06B9  mov [0128],1
	/// dnadg:06BF  mov [012A],0x60
	/// dnadg:06C5  mov CX,0x12
	/// dnadg:06C8  mov DI,0x01E2
	/// dnadg:06CB  mov SI,[DI+0x48]
	/// dnadg:06CE  mov [DI+0x24],SI
	/// dnadg:06D1  mov [DI],0xFFFF
	/// dnadg:06D5  mov [DI+0x021C],0
	/// dnadg:06DB  or SI,SI
	/// dnadg:06DF  mov AX,CX / call 0E7E / inc word ptr [DI]
	/// dnadg:06E8  add DI,2 / loop 06CB
	/// dnadg:06ED  xor AX,AX
	/// dnadg:06EF  mov [013E],AX
	/// dnadg:06F2  mov [0140],AX
	/// </code>
	/// </remarks>
	private void AdgResetSchedulerState_06B9() {
		AdgWordSet(AdgMeasureOffset, 1);
		AdgWordSet(AdgSubdivisionOffset, (byte)AdgImmediate.NinetySix);
		CX = (byte)AdgImmediate.Eighteen;
		DI = AdgChannelTableBase;
		while (CX != 0) {
			SI = AdgWord((ushort)(DI + AdgChannelStateEventSourceOffset));
			AdgWordSet((ushort)(DI + AdgChannelWaitValueEventPointerOffset), SI);
			AdgWordSet(DI, ushort.MaxValue);
			AdgWordSet((ushort)(DI + AdgChannelStateScratchOffset), 0);
			if (SI != 0) {
				AX = CX;
				AdgReadWaitValue_0E7E();
				AdgWordSet(DI, (ushort)(AdgWord(DI) + 1));
				CX = AX;
			}
			DI = (ushort)(DI + 2);
			CX--;
		}

		AX = 0;
		AdgWordSet(AdgFadeScratchOffset, AX);
		AdgWordSet(AdgFadeScratch2Offset, AX);
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
			AdgWordSet(AdgFadePatternOffset, (ushort)AdgFadePattern.SingleStep);
			AdgByteSet(AdgStatusOffset, (byte)(AdgByte(AdgStatusOffset) & (byte)AdgImmediate.FadeClearMask));
			return;
		}

		byte updatedVolume = currentVolume;
		byte currentLowNibble = (byte)(updatedVolume & (byte)AdgImmediate.Fifteen);
		byte targetLowNibble = (byte)(targetVolume & (byte)AdgImmediate.Fifteen);
		if (currentLowNibble != targetLowNibble) {
			updatedVolume = (byte)(updatedVolume + 1);
			if (currentLowNibble > targetLowNibble) {
				updatedVolume = (byte)(updatedVolume - 2);
			}
		}

		byte currentHighNibble = (byte)(updatedVolume & (byte)AdgImmediate.F0Mask);
		byte targetHighNibble = (byte)(targetVolume & (byte)AdgImmediate.F0Mask);
		if (currentHighNibble != targetHighNibble) {
			updatedVolume = (byte)(updatedVolume + AdgFadeHighNibbleIncrement);
			if (currentHighNibble > targetHighNibble) {
				updatedVolume = (byte)(updatedVolume - AdgFadeHighNibbleDecrement);
			}
		}

		AdgByteSet(AdgCurrentVolumeOffset, updatedVolume);
		if (updatedVolume == (byte)AdgImmediate.Zero) {
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
			routedRegister = (byte)(routedRegister ^ (byte)AdgImmediate.OneTwentyEight);
		}

		Machine.IoPortDispatcher.WriteByte(registerPort, routedRegister);
		for (int i = 0; i < (byte)AdgImmediate.Seven; i++) {
			Machine.IoPortDispatcher.ReadByte(registerPort);
		}

		ushort dataPort = (ushort)(registerPort + 1);
		Machine.IoPortDispatcher.WriteByte(dataPort, value);
		byte delayData = 0;
		for (int i = 0; i < (byte)AdgImmediate.ThirtySeven; i++) {
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

		AdgWriteRoutedOplRegister((byte)AdgOplRegister.FrequencyLow, Lo8(CX), (byte)channelIndex);
		AdgWriteRoutedOplRegister((byte)AdgOplRegister.FrequencyHigh, Hi8(CX), (byte)channelIndex);
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
		ushort word1 = SegWord(ES, (ushort)(SI + AdgIdentityWordSecondPlaneOffset));
		ushort word2 = SegWord(ES, (ushort)(SI + AdgIdentityWordThirdPlaneOffset));

		SI = savedSi;
		ES = savedEs;
		return word0 == AdgWord(AdgSongIdentityMagic1Offset)
			&& word1 == AdgWord(AdgSongIdentityMagic2Offset)
			&& word2 == AdgWord(AdgSongIdentityMagic3Offset);
	}

	/// <summary>
	/// Checks and applies ADG loop snapshot save/restore transitions.
	/// Observed from live execution at 564B:07DA.
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:07DA  cmp [012C],0
	/// dnadg:07DF  jne short 080C
	/// dnadg:07E1  mov AX,ES:[BX+2A]
	/// dnadg:07E5  cmp AX,[0128]
	/// dnadg:07E9  jne short 080B
	/// dnadg:07EB  cmp [012A],0x60
	/// dnadg:07F0  jne short 080B
	/// dnadg:07F2  push DI / push ES
	/// dnadg:07F4  mov SI,DI
	/// dnadg:07F6  add DI,0x01D4
	/// dnadg:07FA  push DS / pop ES
	/// dnadg:07FC  mov CX,0x24
	/// dnadg:07FF  rep movs word ptr ES:[DI],word ptr DS:[SI]
	/// dnadg:0803  mov AX,ES:[BX+2E]
	/// dnadg:0807  dec AX
	/// dnadg:0808  mov [012C],AX
	/// dnadg:080B  ret near
	/// dnadg:080C  mov AX,ES:[BX+2C]
	/// dnadg:0810  cmp AX,[0128]
	/// dnadg:0814  jne short 080B
	/// dnadg:0816  dec [012C]
	/// dnadg:081A  push DI / push ES
	/// dnadg:081C  lea SI,[DI+0x01D4]
	/// dnadg:0820  push DS / pop ES
	/// dnadg:0822  mov CX,0x24
	/// dnadg:0825  rep movs word ptr ES:[DI],word ptr DS:[SI]
	/// dnadg:0829  mov AX,ES:[BX+2A]
	/// dnadg:082D  mov [0128],AX
	/// dnadg:0830  ret near
	/// </code>
	/// </remarks>
	private void AdgCheckLoopPoint_07DA() {
		if (AdgWord(AdgLoopCounterOffset) == 0) {
			AX = SegWord(ES, (ushort)(BX + AdgSongLoopStartMeasureOffset));
			if (AX != AdgWord(AdgMeasureOffset)) {
				return;
			}

			if (AdgWord(AdgSubdivisionOffset) != (byte)AdgImmediate.NinetySix) {
				return;
			}

			ushort savedDi = DI;
			ushort savedEs = ES;
			SI = DI;
			DI = (ushort)(DI + AdgLoopSnapshotBase);
			ES = _adgSegment;
			CX = AdgLoopSnapshotWordCount;
			while (CX != 0) {
				ushort value = SegWord(_adgSegment, SI);
				SegWordSet(ES, DI, value);
				SI = (ushort)(SI + 2);
				DI = (ushort)(DI + 2);
				CX--;
			}
			ES = savedEs;
			DI = savedDi;

			AX = SegWord(ES, (ushort)(BX + AdgSongLoopRepeatCountOffset));
			AX--;
			AdgWordSet(AdgLoopCounterOffset, AX);
			return;
		}

		AX = SegWord(ES, (ushort)(BX + AdgSongLoopEndMeasureOffset));
		if (AX != AdgWord(AdgMeasureOffset)) {
			return;
		}

		AdgWordSet(AdgLoopCounterOffset, (ushort)(AdgWord(AdgLoopCounterOffset) - 1));
		ushort restoredDi = DI;
		ushort restoredEs = ES;
		SI = (ushort)(DI + AdgLoopSnapshotBase);
		ES = _adgSegment;
		CX = AdgLoopSnapshotWordCount;
		while (CX != 0) {
			ushort value = SegWord(_adgSegment, SI);
			SegWordSet(ES, DI, value);
			SI = (ushort)(SI + 2);
			DI = (ushort)(DI + 2);
			CX--;
		}
		ES = restoredEs;
		DI = restoredDi;
		AX = SegWord(ES, (ushort)(BX + AdgSongLoopStartMeasureOffset));
		AdgWordSet(AdgMeasureOffset, AX);
	}

	/// <summary>
	/// Observed scheduler-side vibrato path from 564B:07AD.
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:07AD  cmp byte ptr [DI+0x00B4],0
	/// dnadg:07B2  je short 0798
	/// dnadg:07B4  mov SI,[DI+0x24]
	/// dnadg:07B7  or SI,SI
	/// dnadg:07B9  je short 0798
	/// dnadg:07BD  dec byte ptr [DI+0x00B4]
	/// dnadg:07C1  mov AX,[DI+0x00D8]
	/// dnadg:07C5  add AL,AH
	/// dnadg:07C7  mov byte ptr [DI+0x00D8],AL
	/// dnadg:07CB  mov DX,DI
	/// dnadg:07CD  sub DX,0x01E2
	/// dnadg:07D1  shr DX,1
	/// dnadg:07D3  call 0D8B
	/// </code>
	/// </remarks>
	private void AdgAdvancePitchModulation_07AD() {
		if (AdgByte((ushort)(DI + AdgChannelPitchBendCounterOffset)) == 0) {
			return;
		}

		SI = AdgWord((ushort)(DI + AdgChannelWaitValueEventPointerOffset));
		if (SI == 0) {
			return;
		}

		AdgByteSet(
			(ushort)(DI + AdgChannelPitchBendCounterOffset),
			(byte)(AdgByte((ushort)(DI + AdgChannelPitchBendCounterOffset)) - 1));

		AX = AdgWord((ushort)(DI + AdgChannelPitchAccumulatorOffset));
		AX = Make16((byte)(Lo8(AX) + Hi8(AX)), Hi8(AX));
		AdgByteSet((ushort)(DI + AdgChannelPitchAccumulatorOffset), Lo8(AX));

		DX = (ushort)(DI - AdgChannelTableBase);
		DX = (ushort)(DX >> 1);
		AdgPitchBendBody_0D8B(AX);
	}

	private void AdgClearScratchMask_0ACD() {
		if (AdgWord(DI) < 0x0030) {
			return;
		}

		byte nextEventByte = SegByte(ES, SI);
		if (nextEventByte != (byte)AdgImmediate.TwoFiftyFive && (nextEventByte & (byte)AdgImmediate.F0Mask) != 0xC0) {
			return;
		}

		ushort previousScratch = AdgWord((ushort)(DI + AdgChannelStateScratchOffset));
		AdgWordSet((ushort)(DI + AdgChannelStateScratchOffset), 0);
		ushort scratchMask = (ushort)~previousScratch;
		if ((scratchMask & 0x8000) == 0) {
			AdgWordSet(AdgFadeScratch2Offset, (ushort)(AdgWord(AdgFadeScratch2Offset) & scratchMask));
			return;
		}

		AdgWordSet(AdgFadeScratchOffset, (ushort)(AdgWord(AdgFadeScratchOffset) & scratchMask));
	}

	private void AdgWriteInstrumentOperator_102C(byte routeByte, ushort patchOffset, byte waveform) {
		AdgWriteRouteSelectedRegister_1101((byte)AdgOplRegister.Opl3Mode + 0xDB, (byte)(waveform & 0x07), routeByte);

		byte tlValue = (byte)((Make16(SegByte(ES, (ushort)(patchOffset + 0x02)), (byte)(SegByte(ES, (ushort)(patchOffset + 0x0A)) << 2)) >> 2) & 0xFF);
		AdgWriteRouteSelectedRegister_1101((byte)AdgOplRegister.KeyScaleAndOutput, tlValue, routeByte);

		ushort attackDecay = (ushort)(Make16((byte)(SegByte(ES, (ushort)(patchOffset + 0x08)) << 4), SegByte(ES, (ushort)(patchOffset + 0x05))) << 4);
		AdgWriteRouteSelectedRegister_1101((byte)AdgOplRegister.AttackDecay, Hi8(attackDecay), routeByte);

		ushort sustainRelease = (ushort)(Make16((byte)(SegByte(ES, (ushort)(patchOffset + 0x09)) << 4), SegByte(ES, (ushort)(patchOffset + 0x06))) << 4);
		AdgWriteRouteSelectedRegister_1101((byte)AdgOplRegister.SustainRelease, Hi8(sustainRelease), routeByte);

		ushort opFlags = 0;
		opFlags = RotateRight16(Make16(SegByte(ES, (ushort)(patchOffset + 0x0B)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SegByte(ES, (ushort)(patchOffset + 0x05)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SegByte(ES, (ushort)(patchOffset + 0x0A)), Hi8(opFlags)), 1);
		opFlags = RotateRight16(Make16(SegByte(ES, (ushort)(patchOffset + 0x09)), Hi8(opFlags)), 1);
		opFlags = Make16(SegByte(ES, (ushort)(patchOffset + 0x01)), Hi8(opFlags));
		opFlags = (ushort)(opFlags & 0xF00F);
		AdgWriteRouteSelectedRegister_1101(0x20, (byte)(Hi8(opFlags) | Lo8(opFlags)), routeByte);
	}

	private void AdgWriteInstrumentPatch_0F95(ushort patchOffset, ushort channelIndex) {
		byte channelRoute = AdgIndexedByte(AdgChannelRoutingTableOffset, channelIndex);
		byte primaryRoute = AdgIndexedByte(AdgChannelPrimaryOperatorRouteOffset, channelIndex);
		byte secondaryRoute = AdgIndexedByte(AdgChannelSecondaryOperatorRouteOffset, channelIndex);

		ushort connectionValue = Make16(SegByte(ES, (ushort)(patchOffset + 0x0F)), SegByte(ES, (ushort)(patchOffset + 0x1A)));
		connectionValue = (ushort)(connectionValue >> 1);
		connectionValue = Make16((byte)~Lo8(connectionValue), SegByte(ES, (ushort)(patchOffset + 0x04)));
		connectionValue = (ushort)(connectionValue << 1);
		byte connectionByte = (byte)(Hi8(connectionValue) & 0x0F);
		AdgWriteRouteSelectedRegister_1101((byte)AdgOplRegister.FeedbackConnection, connectionByte, channelRoute);

		AdgWriteInstrumentOperator_102C(primaryRoute, patchOffset, SegByte(ES, (ushort)(patchOffset + 0x1C)));
		AdgWriteInstrumentOperator_102C(secondaryRoute, (ushort)(patchOffset + 0x0D), SegByte(ES, (ushort)(patchOffset + 0x1D)));

		if ((secondaryRoute & 0x10) != 0) {
			return;
		}

		byte surroundIndex = (byte)(secondaryRoute & 0x03);
		if (unchecked((sbyte)secondaryRoute) < 0) {
			surroundIndex = (byte)(surroundIndex + 3);
		}
		byte surroundMask = (byte)(1 << surroundIndex);
		if (SegByte(ES, patchOffset) == (byte)AdgImmediate.Four) {
			return;
		}

		surroundMask = (byte)~surroundMask;
		surroundMask = (byte)(surroundMask & AdgByte(AdgSurroundMaskOffset));
		AdgByteSet(AdgSurroundMaskOffset, surroundMask);
		AdgWriteSecondaryRegisterDirect((byte)AdgOplRegister.SecondaryControl, surroundMask);
	}

	private void AdgConfigureInstrumentRouting_090D() {
		BP = AdgWord(AdgFadeScratchOffset);
		CX = AdgWord(AdgFadeScratch2Offset);
		AX = (ushort)~AdgWord((ushort)(DI + AdgChannelStateScratchOffset));
		if ((AX & 0x8000) == 0) {
			CX = (ushort)(CX & AX);
		} else {
			BP = (ushort)(BP & AX);
		}

		byte patchType = SegByte(ES, SI);
		if (patchType == (byte)AdgImmediate.Four) {
			throw FailAsUntested("ADG patch-type 4 routing path 564B:092A is not yet observed.");
		}

		BX = (ushort)(~BP & 0x01C0);
		if (BX != 0) {
			BX = (ushort)(BX >> 4);
			AX = AdgWord((ushort)(0x08ED + BX));
			BX = AdgWord((ushort)(0x08EF + BX));
			BP = (ushort)(BP | BX);
		} else {
			BX = (ushort)~CX;
			if ((BX & 0x01C0) == 0) {
				byte bh = (byte)(((Lo8(BX) >> 3) ^ Lo8(BX)) & 0x07);
				if (bh != 0) {
					throw FailAsUntested("ADG complex routing resolver 564B:0A2E requires more live evidence.");
				}

				AX = BP;
				byte folded = (byte)((Lo8(AX) ^ (Lo8(AX) >> 3)) & 0x07);
				if (folded != 0) {
					throw FailAsUntested("ADG alternate routing resolver 564B:0A38 is not yet observed.");
				}

				BX = (ushort)(BX & 0x003F);
				if (BX == 0) {
					throw FailAsUntested("ADG zero-mask routing resolver 564B:09EC is not yet observed.");
				}

				throw FailAsUntested("ADG sparse routing resolver 564B:0A46 requires more live evidence.");
			}

			BX = (ushort)((BX & 0x01C0) >> 4);
			AX = AdgWord((ushort)(0x08ED + BX));
			BX = AdgWord((ushort)(0x08EF + BX));
			AX = (ushort)(AX | 0x8080);
			CX = (ushort)(CX | BX);
			BX = Make16(Lo8(BX), (byte)(Hi8(BX) | 0x80));
		}

		AdgWordSet((ushort)(DI + AdgChannelStateScratchOffset), BX);
		AdgWordSet(AdgFadeScratchOffset, BP);
		AdgWordSet(AdgFadeScratch2Offset, CX);
		AdgIndexedByteSet(AdgChannelRoutingTableOffset, DX, Hi8(AX));
		AdgIndexedByteSet(AdgChannelPrimaryOperatorRouteOffset, DX, Lo8(AX));
		AX = (ushort)(AX + 0x0303);
		AdgIndexedByteSet(AdgChannelRouteShadowOffset, DX, Hi8(AX));
		AdgIndexedByteSet(AdgChannelSecondaryOperatorRouteOffset, DX, Lo8(AX));
	}

	private void AdgProgramChange_0831(ushort eventWord) {
		AdgReadWaitValue_0E7E();
		byte instrumentIndex = Hi8(eventWord);
		AdgByteSet((ushort)(DI + AdgChannelInstrumentOffset), instrumentIndex);
		ushort patchOffset = (ushort)(AdgWord(AdgEventPointerOffset) + instrumentIndex * 0x28);
		SI = patchOffset;
		ES = AdgWord(AdgEventSegmentOffset);

		AdgConfigureInstrumentRouting_090D();
		AdgWordSet((ushort)(DI + AdgChannelPitchModeOffset), SegWord(ES, (ushort)(SI + 0x21)));

		AX = Make16(SegByte(ES, (ushort)(SI + 0x0A)), SegByte(ES, (ushort)(SI + 0x17)));
		BX = Make16(SegByte(ES, (ushort)(SI + 0x0F)), SegByte(ES, (ushort)(SI + 0x02)));
		BX = (ushort)(BX & 0x0303);
		BX = RotateRight16(BX, 2);
		AX = (ushort)(AX | BX);
		AdgWordSet((ushort)(DI + AdgChannelEnvShapingOffset), AX);
		AdgWordSet((ushort)(DI + AdgChannelTlShapingOffset), SegWord(ES, (ushort)(SI + 0x1E)));
		AdgWordSet((ushort)(DI + AdgChannelVolumeModulationOffset), SegWord(ES, (ushort)(SI + 0x26)));

		AX = Make16((byte)~SegByte(ES, (ushort)(SI + 0x0E)), SegByte(ES, (ushort)(SI + 0x04)));
		AX = RotateRight16(AX, 1);
		AX = (ushort)(AX << 1);
		AX = Make16(SegByte(ES, (ushort)(SI + 0x20)), Hi8(AX));
		AdgWordSet((ushort)(DI + AdgChannelConnectionShapingOffset), AX);

		AX = Make16(SegByte(ES, (ushort)(SI + 0x1B)), Hi8(AX));
		AdgWordSet((ushort)(DI + AdgChannelConnectionModulationOffset), AX);

		AX = SegWord(ES, (ushort)(SI + 0x23));
		AdgByteSet((ushort)(DI + AdgChannelPitchAccumulatorOffset + 1), Hi8(AX));
		AX = Make16(0, Lo8(AX));
		AdgWordSet((ushort)(DI + AdgChannelPitchBendCounterOffset), AX);

		byte patchType = SegByte(ES, SI);
		AdgByteSet((ushort)(DI + AdgChannelPatchTypeOffset), patchType);
		if (patchType == (byte)AdgImmediate.Four) {
			throw FailAsUntested("ADG patch-type 4 program change path 564B:08BD is not yet observed.");
		}

		AdgWriteInstrumentPatch_0F95(patchOffset, DX);
	}

	private void AdgEnvelopeSetup_0C47(byte velocity, ushort channelIndex) {
		byte directVelocity = velocity;
		byte inverseVelocity = (byte)(0x80 - velocity);
		ushort operatorLevel = AdgWord((ushort)(DI + AdgChannelCurrentOperatorLevelOffset));
		ushort tlShaping = AdgWord((ushort)(DI + AdgChannelTlShapingOffset));

		if (Lo8(tlShaping) != 0) {
			byte shaping = Lo8(tlShaping);
			byte scale = inverseVelocity;
			if ((shaping & (byte)AdgImmediate.OneTwentyEight) != 0) {
				shaping = (byte)(0 - shaping);
				scale = directVelocity;
			}
			shaping = (byte)(0 - (byte)(shaping - (byte)AdgImmediate.Four));
			scale = (byte)(scale >> shaping);
			byte value = (byte)((Lo8(operatorLevel) & 0x3F) + scale);
			if (value > 0x3F) {
				value = 0x3F;
			}
			value = (byte)((Lo8(operatorLevel) & 0xC0) | value);
			operatorLevel = Make16(value, Hi8(operatorLevel));
			AdgWriteRouteSelectedRegister_1101((byte)AdgOplRegister.KeyScaleAndOutput, value, AdgIndexedByte(AdgChannelPrimaryOperatorRouteOffset, channelIndex));
		}

		if (Hi8(tlShaping) != 0) {
			byte shaping = Hi8(tlShaping);
			byte scale = inverseVelocity;
			if ((shaping & (byte)AdgImmediate.OneTwentyEight) != 0) {
				shaping = (byte)(0 - shaping);
				scale = directVelocity;
			}
			byte shift = (byte)((byte)AdgImmediate.Four - shaping);
			scale = (byte)(scale >> shift);
			byte value = (byte)((Hi8(operatorLevel) & 0x3F) + scale);
			if (value > 0x3F) {
				value = 0x3F;
			}
			value = (byte)((Hi8(operatorLevel) & 0xC0) | value);
			operatorLevel = Make16(Lo8(operatorLevel), value);
			AdgWriteRouteSelectedRegister_1101((byte)AdgOplRegister.KeyScaleAndOutput, value, AdgIndexedByte(AdgChannelSecondaryOperatorRouteOffset, channelIndex));
		}

		AdgWordSet((ushort)(DI + AdgChannelCurrentOperatorLevelOffset), operatorLevel);
		if (AdgByte((ushort)(DI + AdgChannelPatchTypeOffset)) == (byte)AdgImmediate.Four) {
			throw FailAsUntested("ADG patch-type 4 envelope path 564B:0CCB is not yet observed.");
		}

		ushort connectionShape = AdgWord((ushort)(DI + AdgChannelConnectionShapingOffset));
		if (Lo8(connectionShape) == 0) {
			AdgByteSet((ushort)(DI + AdgChannelConnectionCurrentOffset), Hi8(connectionShape));
			return;
		}

		byte connectionScaleMode = Lo8(connectionShape);
		byte connectionScale = inverseVelocity;
		if ((connectionScaleMode & (byte)AdgImmediate.OneTwentyEight) != 0) {
			connectionScaleMode = (byte)(0 - connectionScaleMode);
			connectionScale = directVelocity;
		}
		connectionScaleMode = (byte)(0 - (byte)(connectionScaleMode - (byte)AdgImmediate.Six));
		connectionScale = (byte)(connectionScale >> connectionScaleMode);
		connectionScale = (byte)(connectionScale & 0xFE);
		connectionScale = (byte)(connectionScale + Hi8(connectionShape));
		if (connectionScale > 0x0F) {
			connectionScale = (byte)((connectionScale & 0x0F) | 0x0E);
		}
		connectionScale = (byte)((connectionScale & 0x0F) | (Hi8(connectionShape) & 0x30));
		AdgByteSet((ushort)(DI + AdgChannelConnectionCurrentOffset), connectionScale);
		AdgWriteChannelRegister_10ED((byte)AdgOplRegister.FeedbackConnection, connectionScale, channelIndex);
	}

	private void AdgVolumeModulation_0B2E(ushort eventWord) {
		AdgReadWaitValue_0E7E();
		byte directVelocity = Hi8(eventWord);
		byte inverseVelocity = (byte)(0x80 - directVelocity);
		ushort operatorLevel = AdgWord((ushort)(DI + AdgChannelCurrentOperatorLevelOffset));
		ushort volumeShape = AdgWord((ushort)(DI + AdgChannelVolumeModulationOffset));

		if (Lo8(volumeShape) != 0) {
			byte shaping = Lo8(volumeShape);
			byte scale = directVelocity;
			if ((shaping & (byte)AdgImmediate.OneTwentyEight) != 0) {
				shaping = (byte)(0 - shaping);
				scale = inverseVelocity;
			}
			shaping = (byte)(0 - (byte)(shaping - (byte)AdgImmediate.Four));
			scale = (byte)(scale >> shaping);
			byte value = (byte)(Lo8(operatorLevel) & 0x3F);
			value = value >= scale ? (byte)(value - scale) : (byte)0;
			value = (byte)((Lo8(operatorLevel) & 0xC0) | value);
			operatorLevel = Make16(value, Hi8(operatorLevel));
			AdgWriteRouteSelectedRegister_1101((byte)AdgOplRegister.KeyScaleAndOutput, value, AdgIndexedByte(AdgChannelPrimaryOperatorRouteOffset, DX));
		}

		if (Hi8(volumeShape) != 0) {
			byte shaping = Hi8(volumeShape);
			byte scale = directVelocity;
			if ((shaping & (byte)AdgImmediate.OneTwentyEight) != 0) {
				shaping = (byte)(0 - shaping);
				scale = inverseVelocity;
			}
			byte shift = (byte)((byte)AdgImmediate.Four - shaping);
			scale = (byte)(scale >> shift);
			byte value = (byte)(Hi8(operatorLevel) & 0x3F);
			value = value >= scale ? (byte)(value - scale) : (byte)0;
			value = (byte)((Hi8(operatorLevel) & 0xC0) | value);
			operatorLevel = Make16(Lo8(operatorLevel), value);
			AdgWriteRouteSelectedRegister_1101((byte)AdgOplRegister.KeyScaleAndOutput, value, AdgIndexedByte(AdgChannelSecondaryOperatorRouteOffset, DX));
		}

		AdgWordSet((ushort)(DI + AdgChannelCurrentOperatorLevelOffset), operatorLevel);
		if (AdgByte((ushort)(DI + AdgChannelPatchTypeOffset)) == (byte)AdgImmediate.Four) {
			throw FailAsUntested("ADG patch-type 4 volume modulation path 564B:0BA7 is not yet observed.");
		}

		ushort connectionModulation = AdgWord((ushort)(DI + AdgChannelConnectionModulationOffset));
		if (Lo8(connectionModulation) == 0) {
			return;
		}

		byte shapingMode = Lo8(connectionModulation);
		byte scaleConnection = directVelocity;
		if ((shapingMode & (byte)AdgImmediate.OneTwentyEight) != 0) {
			shapingMode = (byte)(0 - shapingMode);
			scaleConnection = inverseVelocity;
		}
		shapingMode = (byte)(0 - (byte)(shapingMode - (byte)AdgImmediate.Six));
		scaleConnection = (byte)(scaleConnection >> shapingMode);
		scaleConnection = (byte)(scaleConnection & 0xFE);
		scaleConnection = (byte)(scaleConnection + Hi8(connectionModulation));
		if (scaleConnection > 0x0F) {
			scaleConnection = (byte)((scaleConnection & 0x0F) | 0x0E);
		}
		scaleConnection = (byte)((scaleConnection & 0x0F) | (Hi8(connectionModulation) & 0x30));
		AdgByteSet((ushort)(DI + AdgChannelConnectionCurrentOffset), scaleConnection);
		AdgWriteChannelRegister_10ED((byte)AdgOplRegister.FeedbackConnection, scaleConnection, DX);
	}

	private void AdgPitchBendBody_0D8B(ushort input) {
		byte note = AdgByte((ushort)(DI + AdgChannelCurrentNoteOffset));
		if (note == 0) {
			return;
		}

		ushort ax = Make16(Lo8(input), 0);
		ushort cx = Make16(note, 0);
		ushort temp = cx;
		cx = ax;
		ax = temp;

		byte quotient = (byte)((Lo8(ax) - 0x18) / (byte)AdgImmediate.Twelve);
		byte remainder = (byte)((Lo8(ax) - 0x18) % (byte)AdgImmediate.Twelve);
		cx = Make16(quotient, remainder);
		temp = cx;
		cx = ax;
		ax = temp;

		byte octave = Lo8(cx);
		byte semitone = Hi8(cx);
		if (AdgByte((ushort)(DI + AdgChannelPitchModeOffset)) == 0) {
			bool negative = ax < 0x0040;
			ax = (ushort)(ax - 0x0040);
			if (negative) {
				ax = (ushort)(0 - ax);
				ax = RotateRight16(ax, 5);
				byte delta = Lo8(ax);
				if (semitone >= delta) {
					semitone = (byte)(semitone - delta);
				} else {
					semitone = (byte)(semitone + (byte)AdgImmediate.Twelve - delta);
					octave = (byte)(octave - 1);
					if ((octave & (byte)AdgImmediate.OneTwentyEight) != 0) {
						octave = 0;
						semitone = 0;
					}
				}

				byte fraction = AdgByte((ushort)(AdgPitchBendFractionsTableOffset + semitone));
				ushort mul = (ushort)(fraction * Hi8(ax));
				byte adjustment = Hi8(mul);
				ushort frequency = AdgWord((ushort)(AdgFrequencyLookupTableOffset + (semitone << 1)));
				int result = Lo8(frequency) - adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) - (result < 0 ? 1 : 0)));
			} else {
				ax = (ushort)(ax + 1);
				ax = RotateRight16(ax, 5);
				byte delta = Lo8(ax);
				semitone = (byte)(semitone + delta);
				if (semitone >= (byte)AdgImmediate.Twelve) {
					semitone = (byte)(semitone - (byte)AdgImmediate.Twelve);
					octave = (byte)(octave + 1);
				}

				byte fraction = AdgByte((ushort)(AdgPitchBendFractionsTableOffset + semitone + 1));
				ushort mul = (ushort)(fraction * Hi8(ax));
				byte adjustment = Hi8(mul);
				ushort frequency = AdgWord((ushort)(AdgFrequencyLookupTableOffset + (semitone << 1)));
				int result = Lo8(frequency) + adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) + (result > 0xFF ? 1 : 0)));
			}
		} else {
			bool negative = ax < 0x0040;
			ax = (ushort)(ax - 0x0040);
			if (negative) {
				ax = (ushort)(0 - ax);
				byte delta = (byte)(ax / 5);
				byte remainderPort = (byte)(ax % 5);
				if (semitone >= delta) {
					semitone = (byte)(semitone - delta);
				} else {
					semitone = (byte)(semitone + (byte)AdgImmediate.Twelve - delta);
					octave = (byte)(octave - 1);
					if ((octave & (byte)AdgImmediate.OneTwentyEight) != 0) {
						octave = 0;
						semitone = 0;
					}
				}

				ushort tableBase = (ushort)(AdgPortamentoFractionsTableOffset + (semitone >= 6 ? 5 : 0));
				byte adjustment = AdgByte((ushort)(tableBase + remainderPort));
				ushort frequency = AdgWord((ushort)(AdgFrequencyLookupTableOffset + (semitone << 1)));
				int result = Lo8(frequency) - adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) - (result < 0 ? 1 : 0)));
			} else {
				byte delta = (byte)(ax / 5);
				byte remainderPort = (byte)(ax % 5);
				semitone = (byte)(semitone + delta);
				if (semitone >= (byte)AdgImmediate.Twelve) {
					semitone = (byte)(semitone - (byte)AdgImmediate.Twelve);
					octave = (byte)(octave + 1);
				}

				ushort tableBase = (ushort)(AdgPortamentoFractionsTableOffset + (semitone >= 6 ? 5 : 0));
				byte adjustment = AdgByte((ushort)(tableBase + remainderPort));
				ushort frequency = AdgWord((ushort)(AdgFrequencyLookupTableOffset + (semitone << 1)));
				int result = Lo8(frequency) + adjustment;
				ax = Make16((byte)result, (byte)(Hi8(frequency) + (result > 0xFF ? 1 : 0)));
			}
		}

		byte blockBits = (byte)(octave << 2);
		ax = Make16(Lo8(ax), (byte)(Hi8(ax) | blockBits));
		AdgIndexedWordSet(AdgFrequencyWordTableOffset, DX, ax);
		ax = Make16(Lo8(ax), (byte)(Hi8(ax) | (byte)AdgImmediate.ThirtyTwo));
		AdgWriteFrequencyWord_10E0(DX, ax);
	}

	private void AdgPitchBend_0D86(ushort eventWord) {
		AX = Make16(Hi8(eventWord), Hi8(eventWord));
		AdgReadWaitValue_0E7E();
		AdgPitchBendBody_0D8B(AX);
	}

	private void AdgNoteOn_0A82(ushort eventWord) {
		byte velocity = SegByte(ES, SI);
		SI = (ushort)(SI + 1);
		AX = Make16(velocity, Hi8(eventWord));
		AdgReadWaitValue_0E7E();
		AdgEnvelopeSetup_0C47(velocity, DX);
		if (AdgByte((ushort)(DI + AdgChannelCurrentNoteOffset)) != 0) {
			AdgNoteOff_10D8(DX);
		}

		byte note = (byte)(Hi8(eventWord) + AdgByte((ushort)(DI + AdgChannelPitchTransposeOffset)));
		AdgByteSet((ushort)(DI + AdgChannelCurrentNoteOffset), note);
		AdgByteSet((ushort)(DI + AdgChannelPitchBendCounterOffset), AdgByte((ushort)(DI + AdgChannelPitchBendCounterOffset + 1)));
		AdgByteSet((ushort)(DI + AdgChannelPitchAccumulatorOffset), 0x40);
		AdgNoteOn_10A9(DX, (ushort)(note - 0x48));
	}

	private void AdgNoteOff_0AB6(ushort eventWord) {
		SI = (ushort)(SI + 1);
		AdgReadWaitValue_0E7E();
		byte note = (byte)(Hi8(eventWord) + AdgByte((ushort)(DI + AdgChannelPitchTransposeOffset)));
		if (AdgByte((ushort)(DI + AdgChannelCurrentNoteOffset)) != note) {
			return;
		}

		AdgByteSet((ushort)(DI + AdgChannelCurrentNoteOffset), 0);
		AdgClearScratchMask_0ACD();
		AdgNoteOff_10D8(DX);
	}

	private void AdgEndOfTrack_0AF5() {
		AdgWordSet(DI, ushort.MaxValue);
		byte pointerLo = AdgByte((ushort)(DI + AdgChannelWaitValueEventPointerOffset));
		AdgByteSet((ushort)(DI + AdgChannelWaitValueEventPointerOffset), (byte)(pointerLo - 2));
		if (DX != 0) {
			AdgClearScratchMask_0ACD();
			return;
		}

		byte tickFlag = (byte)(AdgByte(AdgTickEnabledOffset) - 1);
		AdgByteSet(AdgTickEnabledOffset, tickFlag);
		if (tickFlag == 0) {
			AX = ushort.MaxValue;
			DI = AdgChannelTableBase;
			CX = (byte)AdgImmediate.Eighteen;
			while (CX != 0) {
				AdgWordSet(DI, AX);
				DI = (ushort)(DI + 2);
				CX--;
			}
			AdgReset_564B_0561_056A11(0);
			return;
		}

		if ((tickFlag & (byte)AdgImmediate.OneTwentyEight) != 0) {
			AdgByteSet(AdgTickEnabledOffset, (byte)(tickFlag + 1));
		}

		AdgResetSchedulerState_06B9();
		BX = AdgWord(AdgSongPointerOffset);
		ES = AdgWord(AdgSongSegmentOffset);
		DI = AdgChannelTableBase;
		AdgCheckLoopPoint_07DA();
		AdgWordSet(DI, (ushort)(AdgWord(DI) - 1));
	}

	/// <summary>
	/// Maps the observed ADG scheduler handler slot to the eventual C# opcode body.
	/// </summary>
	/// <remarks>
	/// Original dispatch is <c>call near word ptr DS:[BX+0x012E]</c> after
	/// <c>(eventWord &amp; 0x70) &gt;&gt; 4</c>. The live hot path confirms eight slots.
	/// </remarks>
	private void AdgDispatchObservedEvent_0756(ushort eventWord) {
		ushort operationIndex = (ushort)((eventWord & 0x0070) >> 4);
		if (operationIndex >= AdgObservedOperationHandlerCount) {
			throw FailAsUntested($"ADG scheduler observed invalid handler index {operationIndex:X}.");
		}

		switch (operationIndex) {
			case 0:
				AdgNoteOff_0AB6(eventWord);
				return;
			case 1:
				AdgNoteOn_0A82(eventWord);
				return;
			case 2:
			case 3:
				AdgReadWaitValue_0E7E();
				return;
			case 4:
				AdgProgramChange_0831(eventWord);
				return;
			case 5:
				AdgVolumeModulation_0B2E(eventWord);
				return;
			case 6:
				AdgPitchBend_0D86(eventWord);
				return;
			case 7:
				AdgEndOfTrack_0AF5();
				return;
			default:
				throw FailAsUntested($"ADG scheduler unhandled operation index {operationIndex:X}.");
		}
	}

	/// <summary>
	/// Main ADG scheduler body observed at 564B:0756.
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:0756  les BX,[011E]
	/// dnadg:075A  mov AX,ES:[BX+0x30]
	/// dnadg:075E  add [0126],AX
	/// dnadg:0762  mov DI,0x01E2
	/// dnadg:0765  call 07DA
	/// dnadg:0768  mov CX,0x12
	/// dnadg:076B  dec word ptr [DI]
	/// dnadg:076D  jne short 07AD
	/// dnadg:076F  mov SI,[DI+0x24]
	/// dnadg:0772  or SI,SI
	/// dnadg:0774  je short 0798
	/// dnadg:0778  lods AX,ES:[SI]
	/// dnadg:077A  mov DX,DI / sub DX,0x01E2 / shr DX,1
	/// dnadg:0782  mov BX,AX
	/// dnadg:0784  and BX,0x0070
	/// dnadg:0787  shr BX / shr BX / shr BX
	/// dnadg:078D  call word ptr DS:[BX+0x012E]
	/// dnadg:0793  cmp word ptr [DI],0
	/// dnadg:0796  je short 076F
	/// dnadg:0798  add DI,2
	/// dnadg:079B  loop 076B
	/// dnadg:079D  dec byte ptr [012A]
	/// dnadg:07A3  mov byte ptr [012A],0x60 / inc word ptr [0128]
	/// </code>
	/// </remarks>
	private void AdgSchedulerTick_0756() {
		ushort savedBx = BX;
		ushort savedDi = DI;
		ushort savedSi = SI;
		ushort savedDx = DX;
		ushort savedEs = ES;

		BX = AdgWord(AdgSongPointerOffset);
		ES = AdgWord(AdgSongSegmentOffset);
		AX = SegWord(ES, (ushort)(BX + 0x30));
		AdgWordSet(AdgTempoAccumulatorOffset, (ushort)(AdgWord(AdgTempoAccumulatorOffset) + AX));

		DI = AdgChannelTableBase;
		AdgCheckLoopPoint_07DA();
		CX = (byte)AdgImmediate.Eighteen;
		while (CX != 0) {
			AdgWordSet(DI, (ushort)(AdgWord(DI) - 1));
			if (AdgWord(DI) != 0) {
				AdgAdvancePitchModulation_07AD();
				DI = (ushort)(DI + 2);
				CX--;
				continue;
			}

			while (AdgWord(DI) == 0) {
				SI = AdgWord((ushort)(DI + AdgChannelWaitValueEventPointerOffset));
				if (SI == 0) {
					break;
				}

				AX = SegWord(ES, SI);
				SI = (ushort)(SI + 2);
				AdgWordSet((ushort)(DI + AdgChannelWaitValueEventPointerOffset), SI);
				DX = (ushort)(DI - AdgChannelTableBase);
				DX = (ushort)(DX >> 1);
				AdgDispatchObservedEvent_0756(AX);
			}

			DI = (ushort)(DI + 2);
			CX--;
		}

		AdgByteSet(AdgSubdivisionOffset, (byte)(AdgByte(AdgSubdivisionOffset) - 1));
		if (AdgByte(AdgSubdivisionOffset) == 0) {
			AdgByteSet(AdgSubdivisionOffset, (byte)AdgImmediate.NinetySix);
			AdgWordSet(AdgMeasureOffset, (ushort)(AdgWord(AdgMeasureOffset) + 1));
		}

		ES = savedEs;
		DX = savedDx;
		SI = savedSi;
		DI = savedDi;
		BX = savedBx;
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
	/// FULL commented disasm from live capture (dnadg:0100 export wrapper).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:0100  E9FC03  jmp near 0x04FF
	/// ; wrapper ABI: far entry, far return expected by caller
	/// </code>
	/// </remarks>
	public Action AdgInit_564B_0100_0565B0(int gotoAddress) {
		AdgInit_564B_04FF_0569AF(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from live capture (dnadg:0103 export wrapper).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:0103  E92005  jmp near 0x0626
	/// ; wrapper ABI: far entry, far return expected by caller
	/// </code>
	/// </remarks>
	public Action AdgOpenSong_564B_0103_0565B3(int gotoAddress) {
		AdgOpenSong_564B_0626_056AD6(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from live capture (dnadg:0106 export wrapper).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:0106  E95804  jmp near 0x0561
	/// ; wrapper ABI: far entry, far return expected by caller
	/// </code>
	/// </remarks>
	public Action AdgReset_564B_0106_0565B6(int gotoAddress) {
		AdgReset_564B_0561_056A11(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from live capture (dnadg:0109 export wrapper).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:0109  E90405  jmp near 0x0610
	/// ; wrapper ABI: far entry, far return expected by caller
	/// </code>
	/// </remarks>
	public Action AdgSetTickEnabled_564B_0109_0565B9(int gotoAddress) {
		AdgSetTickEnabled_564B_0610_056AC0(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from live capture (dnadg:010C export wrapper).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:010C  E9AF04  jmp near 0x05BE
	/// ; wrapper ABI: far entry, far return expected by caller
	/// </code>
	/// </remarks>
	public Action AdgSetDynamics_564B_010C_0565BC(int gotoAddress) {
		AdgSetDynamics_564B_05BE_056A6E(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from live capture (dnadg:010F export wrapper).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:010F  E9E405  jmp near 0x06F6
	/// ; wrapper ABI: far entry, far return expected by caller
	/// </code>
	/// </remarks>
	public Action AdgTick_564B_010F_0565BF(int gotoAddress) {
		AdgTick_564B_06F6_056BA6(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from live capture (dnadg:0112 export wrapper).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:0112  E99604  jmp near 0x05AB
	/// ; wrapper ABI: far entry, far return expected by caller
	/// </code>
	/// </remarks>
	public Action AdgSetVolume_564B_0112_0565C2(int gotoAddress) {
		AdgSetVolume_564B_05AB_056A5B(0);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from live capture (dnadg:04FF).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:04FF  or AX,AX
	/// dnadg:0501  je short 051C
	/// dnadg:0503  mov [0115],AX
	/// dnadg:050A  mov [0117],AX+2
	/// dnadg:0511  mov [0119],AX+4
	/// dnadg:0518  mov [011B],AX+6
	/// dnadg:051C  mov AL,0xFE
	/// dnadg:051E  mov DX,[0117]
	/// dnadg:0523  out DX,AL
	/// dnadg:0524  call 04DC
	/// dnadg:0527  mov AX,0x2001 ; primary init write
	/// dnadg:052A  call 1112
	/// dnadg:052D  mov AX,0x00BD ; percussion off
	/// dnadg:0530  call 1112
	/// dnadg:0533  mov AX,0x4008 ; channel enable mask
	/// ...
	/// dnadg:????  call 1185 ; Gold startup
	/// dnadg:????  call 0561 ; reset voices
	/// dnadg:????  mov BX,0x0F00
	/// dnadg:????  retf
	/// </code>
	/// </remarks>
	public Action AdgInit_564B_04FF_0569AF(int gotoAddress) {
		if (AX != 0) {
			AdgWordSet(AdgPrimaryRegisterPortOffset, AX);
			AX = (ushort)(AX + 2);
			AdgWordSet(AdgSecondaryRegisterPortOffset, AX);
			AX = (ushort)(AX + 2);
			AdgWordSet(AdgAuxRegisterPortOffset1, AX);
			AX = (ushort)(AX + 2);
			AdgWordSet(AdgAuxRegisterPortOffset2, AX);
		}

		Machine.IoPortDispatcher.WriteByte(AdgWord(AdgSecondaryRegisterPortOffset), (byte)AdgSecondaryCommand.ReleaseReset);
		AdgPatchDriverFileExtensions_04DC();
		AdgWriteFixedOplRegister(AdgWord(AdgPrimaryRegisterPortOffset), (byte)AdgOplRegister.WaveformControl, (byte)AdgImmediate.ThirtyTwo);
		AdgWriteFixedOplRegister(AdgWord(AdgPrimaryRegisterPortOffset), (byte)AdgOplRegister.PercussionControl, (byte)AdgImmediate.Zero);
		AdgWriteFixedOplRegister(AdgWord(AdgPrimaryRegisterPortOffset), (byte)AdgOplRegister.ChannelEnable, (byte)AdgOplRegister.KeyScaleAndOutput);
		AdgWriteFixedOplRegister(AdgWord(AdgSecondaryRegisterPortOffset), (byte)AdgOplRegister.Opl3Mode, (byte)AdgImmediate.One);
		AdgWriteFixedOplRegister(AdgWord(AdgSecondaryRegisterPortOffset), (byte)AdgOplRegister.SecondaryControl, (byte)AdgImmediate.Zero);
		AdgInitializeGoldHardware_1185();
		AdgReset_564B_0561_056A11(0);
		BX = AdgDriverInitBxResult;
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from live capture (dnadg:0626).
	/// This entry is still delegated to original code to preserve proven behavior while the remaining dispatcher internals are being ported.
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:0626  push DS
	/// dnadg:0627  push CS
	/// dnadg:0628  pop DS
	/// dnadg:0629  mov [01DF],AL
	/// dnadg:062C  mov AX,ES:[SI]
	/// dnadg:062F  mov DI,061C
	/// dnadg:0632  mov [DI],SI
	/// dnadg:0634  mov [DI+2],ES
	/// dnadg:0637  mov [DI+4],AX
	/// dnadg:063A  mov AX,ES:[SI+4000]
	/// dnadg:063F  mov [DI+6],AX
	/// dnadg:0642  mov AX,ES:[SI-8000]
	/// dnadg:0647  mov [DI+8],AX
	/// dnadg:064A  add SI,2
	/// dnadg:064D  mov [011E],SI
	/// dnadg:0651  mov [0120],ES
	/// dnadg:0655  sub SI,2
	/// dnadg:0658  add SI,ES:[SI]
	/// dnadg:065B  mov [0122],SI
	/// dnadg:065F  mov [0124],ES
	/// dnadg:0663  call 0F53
	/// dnadg:0666  call 0F78
	/// dnadg:0669  call 068A
	/// dnadg:066C  mov AL,[04D8]
	/// dnadg:066F  mov [04D6],AL
	/// dnadg:0672  call 0F21
	/// dnadg:0675  mov [04D7],AL
	/// dnadg:0678  xor AX,AX
	/// dnadg:067A  mov [0126],AX
	/// dnadg:067D  mov [012C],AX
	/// dnadg:0680  call 0756
	/// dnadg:0683  mov AL,0x80
	/// dnadg:0685  mov [01DE],AL
	/// dnadg:0688  pop DS
	/// dnadg:0689  retf
	/// </code>
	/// </remarks>
	public Action AdgOpenSong_564B_0626_056AD6(int gotoAddress) {
		DS = CS;

		AdgByteSet(AdgTickEnabledOffset, AL);

		ushort songId0 = SegWord(ES, SI);
		DI = AdgSongIdentityCacheOffset;
		SegWordSet(CS, DI, SI);
		SegWordSet(CS, (ushort)(DI + 2), ES);
		SegWordSet(CS, (ushort)(DI + 4), songId0);

		ushort songId1 = SegWord(ES, (ushort)(SI + 0x4000));
		SegWordSet(CS, (ushort)(DI + 6), songId1);

		ushort songId2 = SegWord(ES, (ushort)(SI + 0x8000));
		SegWordSet(CS, (ushort)(DI + 8), songId2);

		SI = (ushort)(SI + 2);
		AdgWordSet(AdgSongPointerOffset, SI);
		AdgWordSet(AdgSongSegmentOffset, ES);

		SI = (ushort)(SI - 2);
		ushort loopPointOffset = SegWord(ES, SI);
		SI = (ushort)(SI + loopPointOffset);
		AdgWordSet(AdgEventPointerOffset, SI);
		AdgWordSet(AdgEventSegmentOffset, ES);

		AdgSilenceGoldChannels_0F53();
		AdgUpdateGoldSurround_11C4();
		AdgBuildChannelTable_068A();

		byte masterVolume = AdgByte(AdgMasterVolumeOffset);
		AdgByteSet(AdgCurrentVolumeOffset, masterVolume);
		AdgApplyMasterVolumeToGold_0F21();
		AdgByteSet(AdgDynamicsOffset, AL);

		AX = 0;
		AdgWordSet(AdgTempoAccumulatorOffset, AX);
		AdgWordSet(AdgLoopCounterOffset, AX);

		AdgSchedulerTick_0756();
		AdgByteSet(AdgStatusOffset, (byte)AdgImmediate.OneTwentyEight);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from live capture (dnadg:0561).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:0561  pushf
	/// dnadg:0562  cli
	/// dnadg:0563  call 0EBA
	/// dnadg:0566  xor AX,AX
	/// dnadg:0568  mov [01DE],AL
	/// dnadg:056C  popf
	/// dnadg:056D  retf
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
	/// FULL commented disasm from live capture (dnadg:0610).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:0610  mov byte ptr [01DF],1
	/// dnadg:0616  mov AL,[01DE]
	/// dnadg:061A  retf
	/// </code>
	/// </remarks>
	public Action AdgSetTickEnabled_564B_0610_056AC0(int gotoAddress) {
		AdgByteSet(AdgTickEnabledOffset, 1);
		AX = Make16(AdgByte(AdgStatusOffset), Hi8(AX));
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from live capture (dnadg:05BE).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:05BE  push AX
	/// dnadg:05BF  mov AX,BX
	/// dnadg:05C1  call 056E ; scale dynamics
	/// dnadg:05C4  mov [04D7],AL
	/// dnadg:05C8  pop AX
	/// dnadg:05C9  mov BX,0xFFFF
	/// dnadg:05CC  cmp AX,0x0060
	/// dnadg:05D1  mov BX,0xAAAA (if AX>=0x0060)
	/// dnadg:05D4  cmp AX,0x00C0
	/// dnadg:05D9  mov BX,0x8888 (if AX>=0x00C0)
	/// dnadg:05DC  cmp AX,0x0180
	/// dnadg:05E1  mov BX,0x8080 (if AX>=0x0180)
	/// dnadg:05E4  cmp AX,0x0300
	/// dnadg:05E9  mov BX,0x8000 (if AX>=0x0300)
	/// dnadg:05EB  mov [01E0],BX
	/// dnadg:05EF  test byte ptr [01DE],0x80
	/// dnadg:05F4  jz short done
	/// dnadg:05F6  or byte ptr [01DE],0x40
	/// dnadg:05FC  retf
	/// </code>
	/// </remarks>
	public Action AdgSetDynamics_564B_05BE_056A6E(int gotoAddress) {
		ushort savedAx = AX;
		AX = BX;
		AdgComputeScaledVolumeFromAx();
		AdgByteSet(AdgDynamicsOffset, Lo8(AX));
		AX = savedAx;

		ushort fadePattern = (ushort)AdgFadePattern.Immediate;
		if (AX >= AdgDynamicsThresholdSlow) {
			fadePattern = (ushort)AdgFadePattern.Slow;
		}
		if (AX >= AdgDynamicsThresholdMedium) {
			fadePattern = (ushort)AdgFadePattern.Medium;
		}
		if (AX >= AdgDynamicsThresholdFast) {
			fadePattern = (ushort)AdgFadePattern.Fast;
		}
		if (AX >= AdgDynamicsThresholdFastest) {
			fadePattern = (ushort)AdgFadePattern.Fastest;
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
	/// FULL commented disasm from live capture (dnadg:06F6).
	/// This entry is still delegated to original code to preserve verified event-dispatch behavior until 0756/07DA dispatcher body is fully ported.
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:06F6  push DS
	/// dnadg:06F7  mov AX,CS
	/// dnadg:06F9  mov DS,AX
	/// dnadg:06FB  mov AL,[01DE]
	/// dnadg:06FE  or AL,AL
	/// dnadg:0700  jns short 0723
	/// dnadg:0702  dec byte ptr [0127]
	/// dnadg:0706  jns short 071A
	/// dnadg:0708  call 0730 ; identity check
	/// dnadg:070B  jne short 0723
	/// dnadg:070D  push DX/SI/DI/BP/ES
	/// dnadg:0712  call 0756 ; scheduler/dispatch
	/// dnadg:0715  pop ES/BP/DI/SI/DX
	/// dnadg:071A  rol word ptr [01E0],1
	/// dnadg:071E  jae short 0723
	/// dnadg:0720  call 0ECC ; fade step
	/// dnadg:0723  mov AL,[01DE]
	/// dnadg:0726  mov BX,[0128]
	/// dnadg:072A  mov CX,[012A]
	/// dnadg:072E  pop DS
	/// dnadg:072F  retf
	/// </code>
	/// </remarks>
	public Action AdgTick_564B_06F6_056BA6(int gotoAddress) {
		DS = CS;

		byte status = AdgByte(AdgStatusOffset);
		if ((status & (byte)AdgImmediate.OneTwentyEight) == 0) {
			AX = Make16(status, Hi8(AX));
			BX = AdgWord(AdgMeasureOffset);
			CX = AdgWord(AdgSubdivisionOffset);
			return FarRet();
		}

		byte tickDivider = AdgByte(AdgTickDividerOffset);
		tickDivider--;
		AdgByteSet(AdgTickDividerOffset, tickDivider);
		if (tickDivider != 0) {
			AX = Make16(status, Hi8(AX));
			BX = AdgWord(AdgMeasureOffset);
			CX = AdgWord(AdgSubdivisionOffset);
			return FarRet();
		}

		if (!AdgIsSongIdentityStillValid_0730()) {
			AX = Make16(status, Hi8(AX));
			BX = AdgWord(AdgMeasureOffset);
			CX = AdgWord(AdgSubdivisionOffset);
			return FarRet();
		}

		ushort savedDx = DX;
		ushort savedSi = SI;
		ushort savedDi = DI;
		ushort savedBp = BP;
		ushort savedEs = ES;

		AdgSchedulerTick_0756();

		ES = savedEs;
		BP = savedBp;
		DI = savedDi;
		SI = savedSi;
		DX = savedDx;

		ushort fadePattern = AdgWord(AdgFadePatternOffset);
		bool shouldFade = (fadePattern & 0x8000) != 0;
		fadePattern = (ushort)((fadePattern << 1) | (shouldFade ? 1 : 0));
		AdgWordSet(AdgFadePatternOffset, fadePattern);
		if (shouldFade) {
			AdgFadeStep_0ECC();
		}

		AX = Make16(AdgByte(AdgStatusOffset), Hi8(AX));
		BX = AdgWord(AdgMeasureOffset);
		CX = AdgWord(AdgSubdivisionOffset);
		return FarRet();
	}

	/// <summary>
	/// FULL commented disasm from live capture (dnadg:05AB).
	/// </summary>
	/// <remarks>
	/// <code>
	/// dnadg:05AB  call 056E ; scale AX to ADG volume domain
	/// dnadg:05AE  mov [04D8],AL ; master volume
	/// dnadg:05B2  mov [04D7],AL ; dynamics target
	/// dnadg:05B6  mov [01E0],0xFFFF ; immediate fade pattern
	/// dnadg:05BD  retf
	/// </code>
	/// </remarks>
	public Action AdgSetVolume_564B_05AB_056A5B(int gotoAddress) {
		AdgComputeScaledVolumeFromAx();
		byte scaledVolume = Lo8(AX);
		AdgByteSet(AdgMasterVolumeOffset, scaledVolume);
		AdgByteSet(AdgDynamicsOffset, scaledVolume);
		AdgWordSet(AdgFadePatternOffset, (ushort)AdgFadePattern.Immediate);
		return FarRet();
	}
}