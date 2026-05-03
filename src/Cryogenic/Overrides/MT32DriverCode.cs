namespace Cryogenic.Overrides;

using Cryogenic.Mt32DriverDebug;
using Cryogenic.Services;

using Serilog;

using Spice86.Shared.Utils;

using System;
using System.IO;
using System.Text;

/// <summary>
/// Partial class containing Roland MT-32 MIDI driver (DNMID) overrides.
/// </summary>
/// <remarks>
/// <para>
/// This file mirrors the DNMID.UNHSQ driver loaded by DNCDPRG.EXE after DriverLoadToolbox
/// remapping. Runtime traces in this workspace show the live segment at 5BAE for the active
/// driver image while the exported entry ABI remains the canonical F000:0100..0112 surface.
/// </para>
/// <para>
/// Export table in DNMID.UNHSQ (offset 0000):
/// </para>
/// <code>
/// 0000: E9 C8 00 -> jmp 01CB (entry 00: init)
/// 0003: E9 4A 01 -> jmp 0250 (entry 01: open song)
/// 0006: E9 D8 00 -> jmp 01E1 (entry 02: reset)
/// 0009: E9 2F 01 -> jmp 023B (entry 03: set tick flag)
/// 000C: E9 DF 00 -> jmp 01EE (entry 04: set dynamics/velocity mapping)
/// 000F: E9 FD 01 -> jmp 030F (entry 05: timer tick)
/// 0012: E9 16 01 -> jmp 022B (entry 06: set volume)
/// </code>
/// <para>
/// Internal function map reconstructed from DNMID.UNHSQ bytes:
/// </para>
/// <code>
/// 01A8 PatchFileExtensions      01CB InitInternal           01E1 ResetInternal
/// 01EE SetVelocityMapping       022B SetVolumeInternal      023B SetTimerTickFlag
/// 0250 OpenInternal             02AE BuildChannelTable      030F TickInternal
/// 0349 CheckSongPosition        036F ProcessTick            03C7 CheckSongEnd
/// 049B ReadVarLengthDelta       04D7 HandleFade             052F EnterUartMode
/// 0559 SendResetSequence        0564 SendByteWithWait       0592 Send2Bytes
/// 05A6 Send3Bytes               05BF PortIO
/// </code>
/// <para>
/// Driver CS-relative data used by this implementation:
/// </para>
/// <list type="bullet">
/// <item><description>0x0115/0x0117 song stream far pointer</description></item>
/// <item><description>0x0119/0x011B event stream far pointer</description></item>
/// <item><description>0x011D timer accumulator, 0x011F measure, 0x0121 subdivision</description></item>
/// <item><description>0x0123 repeat counter, 0x0125 MIDI base port, 0x0127 I/O delay</description></item>
/// <item><description>0x0139 status flags, 0x013A tick flag, 0x013B fade bit pattern</description></item>
/// <item><description>0x013D current volume, 0x013E target volume, 0x013F master volume</description></item>
/// <item><description>0x0140 active channels, 0x0142.. per-channel tick/event state</description></item>
/// <item><description>0x019C.. channel base volumes, 0x01A5.. extension bytes</description></item>
/// <item><description>0x0246.. song header cache for position validation</description></item>
/// </list>
/// </remarks>
public partial class Overrides {
	private static readonly ILogger Mt32Logger = Log.ForContext("Subsystem", "MT32Driver");
	private const ushort LiveMt32DriverSegment = 0x5BAE;
	private const ushort LiveMt32OutOffsetA = 0x0577;
	private const ushort LiveMt32OutOffsetB = 0x05D0;
	/// <summary>
	/// True when the MT-32 C# driver overrides are active.
	/// Enabled only when the game's <c>-a</c> argument starts with <c>MID</c>, which is the
	/// token the game uses when the MT-32 driver is requested (e.g. <c>"MID330 SBP2227"</c>).
	/// </summary>
	private bool EnableMt32CSharpFunctionReplacement;
	private int _firstDispatchCount = 0;

	/// <summary>
	/// Sets <see cref="EnableMt32CSharpFunctionReplacement"/> from the emulated-exe args.
	/// Must be called before <c>DefineOverrides()</c> so that <c>DefineMT32DriverCodeOverrides</c>
	/// sees the correct value when deciding whether to register function replacements.
	/// </summary>
	private void DetectMt32DriverEnabled() {
		MusicDriverType driverType = MusicDriverDetection.DetectFromExeArgs(Configuration.ExeArgs ?? string.Empty);
		EnableMt32CSharpFunctionReplacement = driverType == MusicDriverType.Dnmid;
	}

	/// <summary>
	/// When the MT-32 driver is active, validates the music folder path from
	/// <see cref="Program.MusicFolderPath"/> and instantiates <see cref="MusicFolderPlayer"/>.
	/// Called once from the <c>Overrides</c> constructor after <c>DefineOverrides()</c>.
	/// </summary>
	private void InitializeMusicFolderPlayer() {
		if (!EnableMt32CSharpFunctionReplacement) {
			Mt32Logger.Information("MT-32 driver not active (ExeArgs='{ExeArgs}'). MusicFolder replacement disabled.", Configuration.ExeArgs ?? string.Empty);
			return;
		}
		string musicFolderPath = Program.MusicFolderPath;
		if (string.IsNullOrEmpty(musicFolderPath)) {
			Mt32Logger.Information("MusicFolder not configured, replacement disabled.");
			return;
		}
		if (!Directory.Exists(musicFolderPath)) {
			Mt32Logger.Warning("MusicFolder path '{Path}' does not exist. Replacement disabled.", musicFolderPath);
			return;
		}
		_musicFolderPlayer = new MusicFolderPlayer(musicFolderPath);
	}

	/// <summary>
	/// Computes a 2-byte content fingerprint from the song data block at <paramref name="physicalAddress"/>.
	/// The fingerprint is a lowercase hexadecimal string of the first 2 bytes and is used as the
	/// stable key in <c>fingerprints.json</c>.
	/// </summary>
	/// <param name="physicalAddress">20-bit physical address of the song data block (ES:SI linearised).</param>
	/// <returns>Lowercase 4-character hex string, e.g. <c>"a3f2"</c>.</returns>
	private string ComputeSongFingerprint(uint physicalAddress) {
		StringBuilder sb = new StringBuilder(4);
		for (int i = 0; i < 2; i++) {
			sb.Append(Memory.UInt8[physicalAddress + (uint)i].ToString("x2", System.Globalization.CultureInfo.InvariantCulture));
		}
		return sb.ToString();
	}

	private const string MusicDriverInitAlias = "MusicDriver_Init";
	private const string MusicDriverOpenSongAlias = "MusicDriver_OpenSong";
	private const string MusicDriverResetStopAlias = "MusicDriver_ResetStop";
	private const string MusicDriverSetTickEnabledAlias = "MusicDriver_SetTickEnabled";
	private const string MusicDriverSetDynamicsCurveAlias = "MusicDriver_SetDynamicsCurve";
	private const string MusicDriverSetMasterVolumeAlias = "MusicDriver_SetMasterVolume";
	private static readonly Mt32EventHandlerKind[] Mt32EventHandlerTable = [
		Mt32EventHandlerKind.ThreeByteWithDelta,
		Mt32EventHandlerKind.ThreeByteWithDelta,
		Mt32EventHandlerKind.DeltaOnly,
		Mt32EventHandlerKind.ThreeByteControlWithDelta,
		Mt32EventHandlerKind.TwoByteWithDelta,
		Mt32EventHandlerKind.TwoByteWithDelta,
		Mt32EventHandlerKind.ThreeByteWithDelta,
		Mt32EventHandlerKind.SpecialControlFlow
	];

	private ushort _midiSegment = DriverLoadToolbox.DRIVER3_SEGMENT;

	private enum Mt32EventHandlerKind {
		ThreeByteWithDelta,
		DeltaOnly,
		ThreeByteControlWithDelta,
		TwoByteWithDelta,
		SpecialControlFlow
	}

	/// <summary>
	/// Emulates <c>PUSHF</c> by pushing the canonical FLAGS register value on the emulated CPU stack.
	/// </summary>
	private void PushFlagsToStack() {
		Stack.Push16(State.Flags.FlagRegister16);
	}

	/// <summary>
	/// Emulates <c>POPF</c> by restoring FLAGS from the emulated CPU stack.
	/// </summary>
	private void PopFlagsFromStack() {
		State.Flags.FlagRegister = Stack.Pop16();
	}

	/// <summary>
	/// Saves full general-purpose register set plus ES on the emulated stack.
	/// </summary>
	private void PushGeneralRegistersAndEs() {
		Stack.Push16(AX);
		Stack.Push16(BX);
		Stack.Push16(CX);
		Stack.Push16(DX);
		Stack.Push16(SI);
		Stack.Push16(DI);
		Stack.Push16(BP);
		Stack.Push16(ES);
	}

	/// <summary>
	/// Restores full general-purpose register set plus ES from the emulated stack.
	/// </summary>
	private void PopGeneralRegistersAndEs() {
		ES = Stack.Pop16();
		BP = Stack.Pop16();
		DI = Stack.Pop16();
		SI = Stack.Pop16();
		DX = Stack.Pop16();
		CX = Stack.Pop16();
		BX = Stack.Pop16();
		AX = Stack.Pop16();
	}

	/// <summary>
	/// Saves registers that must remain stable across scheduler tick calls (excluding AX/BX/CX outputs).
	/// </summary>
	private void PushTickVolatileRegisters() {
		Stack.Push16(ES);
		Stack.Push16(DX);
		Stack.Push16(SI);
		Stack.Push16(DI);
		Stack.Push16(BP);
	}

	/// <summary>
	/// Restores registers that must remain stable across scheduler tick calls (excluding AX/BX/CX outputs).
	/// </summary>
	private void PopTickVolatileRegisters() {
		BP = Stack.Pop16();
		DI = Stack.Pop16();
		SI = Stack.Pop16();
		DX = Stack.Pop16();
		ES = Stack.Pop16();
	}

	/// <summary>
	/// Registers MT-32 MIDI driver function overrides and trace hooks.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This binds the reconstructed DNMID surface to the runtime segment discovered in live
	/// execution (5BAE in current traces), while preserving the F000 export naming.
	/// </para>
	/// <code>
	/// F000:0100 init, 0103 open, 0106 reset, 0109 setTick, 010C setVelocity,
	/// 010F tick, 0112 setVolume
	/// </code>
	/// </remarks>
	public void DefineMT32DriverCodeOverrides() {
		if (EnableMt32CSharpFunctionReplacement) {
			RegisterMt32LiveFunctionReplacements();
		} else {
			Mt32Logger.Information("MT-32 C# replacement disabled. Using instruction hooks only.");
		}

		RegisterMt32EntryCounterHooks();
		DoOnTopOfInstruction(LiveMt32DriverSegment, LiveMt32OutOffsetA, TraceLiveMt32Out_5BAE_0577_05C057);
		DoOnTopOfInstruction(LiveMt32DriverSegment, LiveMt32OutOffsetB, TraceLiveMt32Out_5BAE_05D0_05C0B0);
	}

	/// <summary>
	/// Registers all reconstructed DNMID function replacements on the live remapped MT-32 segment.
	/// </summary>
	private void RegisterMt32LiveFunctionReplacements() {
		_midiSegment = LiveMt32DriverSegment;
		DefineFunction(LiveMt32DriverSegment, 0x0100, MidiInit_F000_0100_F0100, false, nameof(MidiInit_F000_0100_F0100));
		DefineFunction(LiveMt32DriverSegment, 0x0103, MidiOpen_F000_0103_F0103, false, nameof(MidiOpen_F000_0103_F0103));
		DefineFunction(LiveMt32DriverSegment, 0x0106, MidiReset_F000_0106_F0106, false, nameof(MidiReset_F000_0106_F0106));
		DefineFunction(LiveMt32DriverSegment, 0x0109, MidiSetTimerTickFlag_F000_0109_F0109, false, nameof(MidiSetTimerTickFlag_F000_0109_F0109));
		DefineFunction(LiveMt32DriverSegment, 0x010C, MidiSetVelocityMapping_F000_010C_F010C, false, nameof(MidiSetVelocityMapping_F000_010C_F010C));
		DefineFunction(LiveMt32DriverSegment, 0x010F, MidiTick_F000_010F_F010F, false, nameof(MidiTick_F000_010F_F010F));
		DefineFunction(LiveMt32DriverSegment, 0x0112, MidiSetVolume_F000_0112_F0112, false, nameof(MidiSetVolume_F000_0112_F0112));
		DefineFunction(LiveMt32DriverSegment, 0x01A8, MidiPatchFileExtensions_F000_01A8_F01A8, false, nameof(MidiPatchFileExtensions_F000_01A8_F01A8));
		DefineFunction(LiveMt32DriverSegment, 0x01CB, MidiInitInternal_F000_01CB_F01CB, false, nameof(MidiInitInternal_F000_01CB_F01CB));
		DefineFunction(LiveMt32DriverSegment, 0x01E1, MidiResetInternal_F000_01E1_F01E1, false, nameof(MidiResetInternal_F000_01E1_F01E1));
		DefineFunction(LiveMt32DriverSegment, 0x022B, MidiSetVolumeInternal_F000_022B_F022B, false, nameof(MidiSetVolumeInternal_F000_022B_F022B));
		DefineFunction(LiveMt32DriverSegment, 0x0250, MidiOpenInternal_F000_0250_F0250, false, nameof(MidiOpenInternal_F000_0250_F0250));
		DefineFunction(LiveMt32DriverSegment, 0x02AE, MidiBuildChannelTable_F000_02AE_F02AE, false, nameof(MidiBuildChannelTable_F000_02AE_F02AE));
		DefineFunction(LiveMt32DriverSegment, 0x030F, MidiTickInternal_F000_030F_F030F, false, nameof(MidiTickInternal_F000_030F_F030F));
		DefineFunction(LiveMt32DriverSegment, 0x0349, MidiCheckSongPosition_F000_0349_F0349, false, nameof(MidiCheckSongPosition_F000_0349_F0349));
		DefineFunction(LiveMt32DriverSegment, 0x036F, MidiProcessTick_F000_036F_F036F, false, nameof(MidiProcessTick_F000_036F_F036F));
		DefineFunction(LiveMt32DriverSegment, 0x03C7, MidiCheckSongEnd_F000_03C7_F03C7, false, nameof(MidiCheckSongEnd_F000_03C7_F03C7));
		DefineFunction(LiveMt32DriverSegment, 0x049B, MidiReadVariableLengthDelta_F000_049B_F049B, false, nameof(MidiReadVariableLengthDelta_F000_049B_F049B));
		DefineFunction(LiveMt32DriverSegment, 0x04D7, MidiHandleFade_F000_04D7_F04D7, false, nameof(MidiHandleFade_F000_04D7_F04D7));
		DefineFunction(LiveMt32DriverSegment, 0x052F, MidiEnterUartMode_F000_052F_F052F, false, nameof(MidiEnterUartMode_F000_052F_F052F));
		DefineFunction(LiveMt32DriverSegment, 0x0559, MidiSendResetSequence_F000_0559_F0559, false, nameof(MidiSendResetSequence_F000_0559_F0559));
		DefineFunction(LiveMt32DriverSegment, 0x0564, MidiSendByteWithWait_F000_0564_F0564, false, nameof(MidiSendByteWithWait_F000_0564_F0564));
		DefineFunction(LiveMt32DriverSegment, 0x0592, MidiSend2Bytes_F000_0592_F0592, false, nameof(MidiSend2Bytes_F000_0592_F0592));
		DefineFunction(LiveMt32DriverSegment, 0x05A6, MidiSend3Bytes_F000_05A6_F05A6, false, nameof(MidiSend3Bytes_F000_05A6_F05A6));
		DefineFunction(LiveMt32DriverSegment, 0x05BF, MidiPortIO_F000_05BF_F05BF, false, nameof(MidiPortIO_F000_05BF_F05BF));
	}

	/// <summary>
	/// Registers lightweight call-counter hooks for the exported MT-32 entry surface.
	/// </summary>
	private void RegisterMt32EntryCounterHooks() {
		DoOnTopOfInstruction(LiveMt32DriverSegment, 0x01A8, TraceLiveMt32SongCandidates_5BAE_01A8_05BBA8);
		DoOnTopOfInstruction(LiveMt32DriverSegment, 0x0100, TraceLiveMt32Entry_5BAE_0100_05BB00);
		DoOnTopOfInstruction(LiveMt32DriverSegment, 0x0103, TraceLiveMt32Entry_5BAE_0103_05BB03);
		DoOnTopOfInstruction(LiveMt32DriverSegment, 0x0106, TraceLiveMt32Entry_5BAE_0106_05BB06);
		DoOnTopOfInstruction(LiveMt32DriverSegment, 0x0109, TraceLiveMt32Entry_5BAE_0109_05BB09);
		DoOnTopOfInstruction(LiveMt32DriverSegment, 0x010C, TraceLiveMt32Entry_5BAE_010C_05BB0C);
		DoOnTopOfInstruction(LiveMt32DriverSegment, 0x010F, TraceLiveMt32Entry_5BAE_010F_05BB0F);
		DoOnTopOfInstruction(LiveMt32DriverSegment, 0x0112, TraceLiveMt32Entry_5BAE_0112_05BB12);
	}

	/// <summary>
	/// Logs raw OUT traffic at live MT-32 site 5BAE:0577 for runtime parity checks.
	/// </summary>
	private void TraceLiveMt32Out_5BAE_0577_05C057() {
		byte value = (byte)(AX & 0xFF);
		Mt32Logger.Information("[MIDI:5BAE:0577] OUT DX,AL port={PortHex} value={ValueHex} csip={CsIp} cycles={Cycles}", $"0x{DX:X4}", $"0x{value:X2}", $"{CS:X4}:{IP:X4}", State.Cycles);
		RecordLiveMt32OutputForGoldenCapture(value);
	}

	/// <summary>
	/// Logs raw OUT traffic at live MT-32 site 5BAE:05D0 for runtime parity checks.
	/// </summary>
	private void TraceLiveMt32Out_5BAE_05D0_05C0B0() {
		byte value = (byte)(AX & 0xFF);
		Mt32Logger.Information("[MIDI:5BAE:05D0] OUT DX,AL port={PortHex} value={ValueHex} csip={CsIp} cycles={Cycles}", $"0x{DX:X4}", $"0x{value:X2}", $"{CS:X4}:{IP:X4}", State.Cycles);
		RecordLiveMt32OutputForGoldenCapture(value);
	}

	/// <summary>
	/// Captures live MT-32 UART output bytes with DNMID timeline fields for golden trace comparison.
	/// </summary>
	private void RecordLiveMt32OutputForGoldenCapture(byte value) {
		ushort measure = ReadLiveMt32Word(0x011F);
		ushort subdivision = ReadLiveMt32Word(0x0121);
		ushort repeatCounter = ReadLiveMt32Word(0x0123);
		ushort timerAccumulator = ReadLiveMt32Word(0x011D);
		Cryogenic.CryogenicMcpTools.RecordMt32OutputByte(value, DX, CS, IP, State.Cycles, measure, subdivision, repeatCounter, timerAccumulator);
	}

	/// <summary>
	/// Safely reads one CS-relative word from the live MT-32 driver segment.
	/// </summary>
	private ushort ReadLiveMt32Word(ushort offset) {
		return Memory.UInt16[MemoryUtils.ToPhysicalAddress(LiveMt32DriverSegment, offset)];
	}

	/// <summary>
	/// Samples live filename table entries from the MT-32 extension-patch routine to discover song names.
	/// </summary>
	private void TraceLiveMt32SongCandidates_5BAE_01A8_05BBA8() {
		ushort stackTableOffset = BP;
		ushort stackTableSegment = ES;
		ushort nameCount = CX;
		if (nameCount == 0 || nameCount > 32) {
			return;
		}

		ushort currentEntryOffset = stackTableOffset;
		for (int i = 0; i < nameCount; i++) {
			ushort fileOffset = Memory.UInt16[MemoryUtils.ToPhysicalAddress(stackTableSegment, currentEntryOffset)];
			currentEntryOffset += 2;
			string rawName = ReadPatchedFilenameFromStack(stackTableSegment, fileOffset);
			string normalizedName = NormalizeLiveSongCandidate(rawName);
			if (!string.IsNullOrEmpty(normalizedName)) {
				Cryogenic.CryogenicMcpTools.RecordMt32SongNameCandidate(normalizedName, "dnmid:live-patch-table");
			}
		}
	}

	private static string NormalizeLiveSongCandidate(string rawName) {
		if (string.IsNullOrWhiteSpace(rawName)) {
			return string.Empty;
		}

		string trimmed = rawName.Trim();
		int dotIndex = trimmed.LastIndexOf('.');
		if (dotIndex >= 0) {
			string baseName = trimmed.Substring(0, dotIndex);
			if (string.IsNullOrWhiteSpace(baseName)) {
				return string.Empty;
			}
			return string.Concat(baseName, ".M32");
		}

		return string.Concat(trimmed, ".M32");
	}

	/// <summary>
	/// Records invocation of exported entry F000:0100.
	/// </summary>
	private void TraceLiveMt32Entry_5BAE_0100_05BB00() {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:0100", CS, IP);
	}

	/// <summary>
	/// Records invocation of exported entry F000:0103.
	/// </summary>
	private void TraceLiveMt32Entry_5BAE_0103_05BB03() {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:0103", CS, IP);
		Cryogenic.CryogenicMcpTools.RecordMt32SongOpen(ES, SI);
	}

	/// <summary>
	/// Records invocation of exported entry F000:0106.
	/// </summary>
	private void TraceLiveMt32Entry_5BAE_0106_05BB06() {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:0106", CS, IP);
	}

	/// <summary>
	/// Records invocation of exported entry F000:0109.
	/// </summary>
	private void TraceLiveMt32Entry_5BAE_0109_05BB09() {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:0109", CS, IP);
	}

	/// <summary>
	/// Records invocation of exported entry F000:010C.
	/// </summary>
	private void TraceLiveMt32Entry_5BAE_010C_05BB0C() {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:010C", CS, IP);
	}

	/// <summary>
	/// Records invocation of exported entry F000:010F.
	/// </summary>
	private void TraceLiveMt32Entry_5BAE_010F_05BB0F() {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:010F", CS, IP);
	}

	/// <summary>
	/// Records invocation of exported entry F000:0112.
	/// </summary>
	private void TraceLiveMt32Entry_5BAE_0112_05BB12() {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:0112", CS, IP);
	}

	/// <summary>
	/// Reads a 16-bit value at CS-relative driver storage using the active MIDI segment anchor.
	/// </summary>
	private ushort MidiCsWord(ushort offset) {
		return Memory.UInt16[MemoryUtils.ToPhysicalAddress(_midiSegment, offset)];
	}

	/// <summary>
	/// Writes a 16-bit value at CS-relative driver storage using the active MIDI segment anchor.
	/// </summary>
	private void MidiCsWordSet(ushort offset, ushort value) {
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(_midiSegment, offset)] = value;
	}

	/// <summary>
	/// Reads an 8-bit value at CS-relative driver storage using the active MIDI segment anchor.
	/// </summary>
	private byte MidiCsByte(ushort offset) {
		return Memory.UInt8[MemoryUtils.ToPhysicalAddress(_midiSegment, offset)];
	}

	/// <summary>
	/// Writes an 8-bit value at CS-relative driver storage using the active MIDI segment anchor.
	/// </summary>
	private void MidiCsByteSet(ushort offset, byte value) {
		Memory.UInt8[MemoryUtils.ToPhysicalAddress(_midiSegment, offset)] = value;
	}

	/// <summary>
	/// Entry 00 wrapper: initializes driver state and returns required driver memory size in BX.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 0100: E9 C8 00    jmp 01CB
	/// </code>
	/// <para>ABI: far entrypoint, returns with RETF.</para>
	/// </remarks>
	public Action MidiInit_F000_0100_F0100(int gotoAddress) {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:0100");
		Mt32Logger.Debug("[MIDI:F000:0100] Init entry called (Alias={Alias})", MusicDriverInitAlias);
		return MidiInitInternal_F000_01CB_F01CB(0);
	}

	/// <summary>
	/// Entry 01 wrapper: opens a song stream and initializes channel playback tables.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 0103: E9 4A 01    jmp 0250
	/// </code>
	/// </remarks>
	public Action MidiOpen_F000_0103_F0103(int gotoAddress) {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:0103");
		Mt32Logger.Debug("[MIDI:F000:0103] Open entry called (Alias={Alias})", MusicDriverOpenSongAlias);
		if (_musicFolderPlayer is not null) {
			uint physAddr = MemoryUtils.ToPhysicalAddress(ES, SI);
			string fingerprint = ComputeSongFingerprint(physAddr);
			string songName = _musicFolderPlayer.ResolveName(fingerprint);
			byte masterVol = MidiCsByte(0x013F);
			float normVol = Math.Clamp(masterVol / 127.0f, 0.0f, 1.0f);
			_musicFolderPlayer.TryPlay(fingerprint, normVol);
			if (_musicFolderPlayer.IsActive) {
				// Replacement is playing: skip MidiOpenInternal entirely so the native MT-32
				// driver never starts and cannot produce its initialisation notes.
				Mt32Logger.Debug("[MIDI:F000:0103] Replacement active for '{Name}' ({Fingerprint}), suppressing MidiOpenInternal.", songName, fingerprint);
				return FarRet();
			}
		}
		return MidiOpenInternal_F000_0250_F0250(0);
	}

	/// <summary>
	/// Entry 02 wrapper: resets runtime state and re-enters UART mode.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 0106: E9 D8 00    jmp 01E1
	/// </code>
	/// </remarks>
	public Action MidiReset_F000_0106_F0106(int gotoAddress) {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:0106");
		Mt32Logger.Debug("[MIDI:F000:0106] Reset entry called (Alias={Alias})", MusicDriverResetStopAlias);
		if (_musicFolderPlayer is not null && _musicFolderPlayer.IsActive) {
			// A replacement track is already playing. The game issues Reset before every Open
			// as part of its song-start sequence. Calling MidiResetInternal here would send a
			// MT-32 SysEx reset to the MIDI port, producing an audible click. Suppress it;
			// TryPlay in MidiOpen handles the actual track transition.
			Mt32Logger.Debug("[MIDI:F000:0106] Replacement active, suppressing MidiResetInternal to avoid MT-32 SysEx click.");
			return FarRet();
		}
		return MidiResetInternal_F000_01E1_F01E1(0);
	}

	/// <summary>
	/// Entry 03 wrapper: marks timer tick flag and returns current status byte in AL.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 0109: E9 2F 01    jmp 023B
	/// 023B: C6 06 3A 01 01   mov byte [013A], 1
	/// 0241: A0 39 01         mov al, [0139]
	/// 0245: CB               retf
	/// </code>
	/// </remarks>
	public Action MidiSetTimerTickFlag_F000_0109_F0109(int gotoAddress) {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:0109");
		Mt32Logger.Debug("[MIDI:F000:0109] Set tick flag (Alias={Alias})", MusicDriverSetTickEnabledAlias);
		MidiCsByteSet(0x013A, 1);
		AX = (ushort)((AX & 0xFF00) | MidiCsByte(0x0139));
		return FarRet();
	}

	/// <summary>
	/// Entry 04 wrapper: computes dynamics/fade bit pattern from AX, sets target volume from caller BL, and updates status flags.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 010C: E9 DF 00         jmp 01EE
	/// 01EE: push bx
	/// 01EF: mov bx, FFFF
	/// 01F2: cmp ax, 0060 / jc +1A
	/// 01F7: mov bx, AAAA
	/// 01FA: cmp ax, 00C0 / jc +12
	/// 01FF: mov bx, 8888
	/// 0202: cmp ax, 0180 / jc +0A
	/// 0207: mov bx, 8080
	/// 020A: cmp ax, 0300 / jc +02
	/// 020F: xor bl, bl
	/// 0211: mov [013B], bx
	/// 0217: mov [013E], bl
	/// 021C: mov al, [0139]
	/// 0222: jns +06
	/// 0224: or  al, 40
	/// 0226: mov [0139], al
	/// 022A: retf
	/// </code>
	/// </remarks>
	public Action MidiSetVelocityMapping_F000_010C_F010C(int gotoAddress) {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:010C");
		Mt32Logger.Debug("[MIDI:F000:010C] Set velocity mapping (Alias={Alias}, AX={AxHex})", MusicDriverSetDynamicsCurveAlias, $"0x{AX:X4}");
		byte originalBl = (byte)(BX & 0x00FF);
		ushort bx = 0xFFFF;
		if (AX >= 0x0060) {
			bx = 0xAAAA;
		}
		if (AX >= 0x00C0) {
			bx = 0x8888;
		}
		if (AX >= 0x0180) {
			bx = 0x8080;
		}
		if (AX >= 0x0300) {
			bx = (ushort)(bx & 0xFF00);
		}
		MidiCsWordSet(0x013B, bx);
		MidiCsByteSet(0x013E, originalBl);
		byte status = MidiCsByte(0x0139);
		if ((status & 0x80) != 0) {
			status = (byte)(status | 0x40);
			MidiCsByteSet(0x0139, status);
		}
		AX = (ushort)((AX & 0xFF00) | status);
		return FarRet();
	}

	/// <summary>
	/// Entry 05 wrapper: executes one scheduler tick and returns status/position snapshot.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 010F: E9 FD 01    jmp 030F
	/// </code>
	/// </remarks>
	public Action MidiTick_F000_010F_F010F(int gotoAddress) {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:010F");
		if (_musicFolderPlayer is not null && _musicFolderPlayer.IsActive) {
			return FarRet();
		}
		return MidiTickInternal_F000_030F_F030F(0);
	}

	/// <summary>
	/// Entry 06 wrapper: updates master/target volume and fade setup.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 0112: E9 16 01    jmp 022B
	/// </code>
	/// </remarks>
	public Action MidiSetVolume_F000_0112_F0112(int gotoAddress) {
		Cryogenic.CryogenicMcpTools.RecordMt32Call("F000:0112");
		Mt32Logger.Debug("[MIDI:F000:0112] Set volume entry (Alias={Alias})", MusicDriverSetMasterVolumeAlias);
		if (_musicFolderPlayer is not null && _musicFolderPlayer.IsActive) {
			byte al = (byte)(AX & 0xFF);
			_musicFolderPlayer.Volume = Math.Clamp(al / 127.0f, 0.0f, 1.0f);
			// Skip MidiSetVolumeInternal: the native driver was never opened for this song,
			// so operating on its uninitialised state is unsafe and unnecessary.
			return FarRet();
		}
		return MidiSetVolumeInternal_F000_022B_F022B(0);
	}

	/// <summary>
	/// Rewrites filename extensions in-place to the driver's expected suffix bytes.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 01A8: 8B F5          mov si, bp
	/// 01AA: 26 AD          lodsw es:[si]
	/// 01AC: 05 02 00       add ax, 2
	/// 01B2: B9 09 00       mov cx, 9
	/// 01B5: B0 2E          mov al, '.'
	/// 01B7: F2 AE          repne scasb
	/// 01BE: 2E A1 A5 01    mov ax, cs:[01A5]
	/// 01C2: AB             stosw
	/// 01C3: 2E A0 A7 01    mov al, cs:[01A7]
	/// 01C7: AA             stosb
	/// 01CA: C3             ret
	/// </code>
	/// </remarks>
	public Action MidiPatchFileExtensions_F000_01A8_F01A8(int gotoAddress) {
		ES = SS;
		ushort si = BP;
		ushort cx = CX;
		for (int i = 0; i < cx; i++) {
			ushort fileOffset = Memory.UInt16[MemoryUtils.ToPhysicalAddress(ES, si)];
			si += 2;
			ushort scanPtr = (ushort)(fileOffset + 2);
			bool foundDot = false;
			for (int j = 0; j < 9; j++) {
				byte value = Memory.UInt8[MemoryUtils.ToPhysicalAddress(ES, scanPtr)];
				scanPtr++;
				if (value == 0x2E) {
					foundDot = true;
					break;
				}
			}
			if (foundDot) {
				ushort extWord = MidiCsWord(0x01A5);
				byte extByte = MidiCsByte(0x01A7);
				Memory.UInt16[MemoryUtils.ToPhysicalAddress(ES, scanPtr)] = extWord;
				scanPtr += 2;
				Memory.UInt8[MemoryUtils.ToPhysicalAddress(ES, scanPtr)] = extByte;
				string patchedName = ReadPatchedFilenameFromStack(ES, fileOffset);
				if (patchedName.EndsWith(".M32", StringComparison.OrdinalIgnoreCase)) {
					Cryogenic.CryogenicMcpTools.RecordMt32SongNameCandidate(patchedName, "dnmid:patch-ext");
				}
			}
		}
		SI = si;
		return NearRet();
	}

	/// <summary>
	/// Reads one patched DOS filename from SS using the DNMID filename table layout.
	/// </summary>
	private string ReadPatchedFilenameFromStack(ushort segment, ushort fileOffset) {
		ushort pointer = (ushort)(fileOffset + 2);
		char[] chars = new char[16];
		int length = 0;
		for (int i = 0; i < chars.Length; i++) {
			byte value = Memory.UInt8[MemoryUtils.ToPhysicalAddress(segment, pointer)];
			pointer++;
			if (value == 0 || value == 0x20) {
				break;
			}
			if (value < 0x21 || value > 0x7E) {
				break;
			}
			chars[length] = (char)value;
			length++;
		}
		return length == 0 ? string.Empty : new string(chars, 0, length);
	}

	/// <summary>
	/// Internal init body: sets base port, patches extensions, resets device, and returns BX=0x0500.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 01CB: or ax, ax
	/// 01CD: jz +04
	/// 01CF: mov cs:[0125], ax
	/// 01D3: call 01A8
	/// 01D6: call 0559
	/// 01D9: push cs
	/// 01DA: call 01E1
	/// 01DD: mov bx, 0500
	/// 01E0: retf
	/// </code>
	/// </remarks>
	public Action MidiInitInternal_F000_01CB_F01CB(int gotoAddress) {
		if (AX != 0) {
			MidiCsWordSet(0x0125, AX);
		}
		MidiPatchFileExtensions_F000_01A8_F01A8(0);
		MidiSendResetSequence_F000_0559_F0559(0);
		MidiResetInternal_F000_01E1_F01E1(0);
		BX = 0x0500;
		return FarRet();
	}

	/// <summary>
	/// Internal reset body: enters UART mode and clears status byte.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 01E1: pushf
	/// 01E2: cli
	/// 01E3: call 052F
	/// 01E6: xor ax, ax
	/// 01E8: mov cs:[0139], al
	/// 01EC: popf
	/// 01ED: retf
	/// </code>
	/// </remarks>
	public Action MidiResetInternal_F000_01E1_F01E1(int gotoAddress) {
		PushFlagsToStack();
		InterruptFlag = false;
		MidiEnterUartMode_F000_052F_F052F(0);
		AX = 0;
		MidiCsByteSet(0x0139, 0);
		PopFlagsFromStack();
		return FarRet();
	}

	/// <summary>
	/// Internal set-volume body: stores AL to master/target volumes and resets fade pattern.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 022B: mov cs:[013F], al
	/// 022E: mov cs:[013E], al
	/// 0231: mov word cs:[013B], FFFF
	/// 0237: retf
	/// </code>
	/// </remarks>
	public Action MidiSetVolumeInternal_F000_022B_F022B(int gotoAddress) {
		byte al = (byte)(AX & 0xFF);
		MidiCsByteSet(0x013F, al);
		MidiCsByteSet(0x013E, al);
		MidiCsWordSet(0x013B, 0xFFFF);
		return FarRet();
	}

	/// <summary>
	/// Internal open-song body: captures pointers, builds channels, seeds state, and starts playback.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 0250..02AD core sequence:
	/// push ds; push cs; pop ds
	/// mov [013A], al
	/// read header words into 0246..024E cache
	/// set [0115:0117] stream pointer
	/// set [0119:011B] event pointer
	/// call 052F (UART init)
	/// call 02AE (build channel table)
	/// copy [013F] -> [013D],[013E]
	/// zero [011D],[0123]
	/// call 036F (initial process tick)
	/// mov [0139], 80
	/// pop ds; retf
	/// </code>
	/// </remarks>
	public Action MidiOpenInternal_F000_0250_F0250(int gotoAddress) {
		Cryogenic.CryogenicMcpTools.RecordMt32SongOpen(ES, SI);
		PushGeneralRegistersAndEs();
		Stack.Push16(DS);
		Stack.Push16(CS);
		DS = Stack.Pop16();
		Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x013A)] = (byte)(AX & 0xFF);
		ushort headerWord = Memory.UInt16[MemoryUtils.ToPhysicalAddress(ES, SI)];
		ushort di = 0x0246;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, di)] = SI;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, (ushort)(di + 2))] = ES;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, (ushort)(di + 4))] = headerWord;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, (ushort)(di + 6))] = Memory.UInt16[MemoryUtils.ToPhysicalAddress(ES, (ushort)(SI + 0x4000))];
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, (ushort)(di + 8))] = Memory.UInt16[MemoryUtils.ToPhysicalAddress(ES, (ushort)(SI - 0x8000))];
		ushort songDataOffset = (ushort)(SI + 2);
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0115)] = songDataOffset;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0117)] = ES;
		ushort eventOffset = (ushort)(SI + Memory.UInt16[MemoryUtils.ToPhysicalAddress(ES, SI)]);
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0119)] = eventOffset;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x011B)] = ES;
		MidiEnterUartMode_F000_052F_F052F(0);
		MidiBuildChannelTable_F000_02AE_F02AE(0);
		byte masterVol = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x013F)];
		Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x013D)] = masterVol;
		Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x013E)] = masterVol;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x011D)] = 0;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0123)] = 0;
		MidiProcessTick_F000_036F_F036F(0);
		Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x0139)] = 0x80;
		DS = Stack.Pop16();
		PopGeneralRegistersAndEs();
		return FarRet();
	}

	/// <summary>
	/// Builds the 9-channel runtime table and initial deltas from song header pointers.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 02AE..030E:
	/// clear [0140] active count
	/// load channel offsets from [0115:0117] into 0166..
	/// count non-zero channels
	/// fill 019C.. with default 0x60
	/// set measure/subdivision to 1/0x60
	/// for each channel: seed [DI], [DI+12] using 049B var-length reader
	/// ret
	/// </code>
	/// </remarks>
	public Action MidiBuildChannelTable_F000_02AE_F02AE(int gotoAddress) {
		ushort currentDs = DS;
		ES = currentDs;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, 0x0140)] = 0;
		ushort songSi = Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, 0x0115)];
		ushort songSeg = Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, 0x0117)];
		DS = songSeg;
		MidiBuildChannelOffsets(songSeg, songSi);
		DS = currentDs;
		ushort esSeg = Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, 0x0117)];
		ES = esSeg;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, 0x011F)] = 1;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, 0x0121)] = 0x0060;
		MidiInitChannelDeltas(currentDs, esSeg);
		return NearRet();
	}

	/// <summary>
	/// Builds channel event offsets from the song header and initializes active-channel count and base channel volumes.
	/// </summary>
	private void MidiBuildChannelOffsets(ushort songSeg, ushort songSi) {
		ushort bp = songSi;
		ushort di = 0x0166;
		for (int i = 0; i < 9; i++) {
			ushort channelOffset = Memory.UInt16[MemoryUtils.ToPhysicalAddress(songSeg, songSi)];
			songSi += 2;
			if (channelOffset != 0) {
				ushort activeCount = Memory.UInt16[MemoryUtils.ToPhysicalAddress(_midiSegment, 0x0140)];
				Memory.UInt16[MemoryUtils.ToPhysicalAddress(_midiSegment, 0x0140)] = (ushort)(activeCount + 1);
				channelOffset = (ushort)(channelOffset + bp);
			}
			Memory.UInt16[MemoryUtils.ToPhysicalAddress(ES, di)] = channelOffset;
			di += 2;
		}

		di = 0x019C;
		for (int i = 0; i < 9; i++) {
			Memory.UInt8[MemoryUtils.ToPhysicalAddress(ES, di)] = 0x60;
			di++;
		}
	}

	/// <summary>
	/// Initializes per-channel wait counters and event pointers, decoding the first var-length delta when a channel is present.
	/// </summary>
	private void MidiInitChannelDeltas(ushort currentDs, ushort esSeg) {
		ushort di = 0x0142;
		for (int i = 0; i < 9; i++) {
			ushort channelEventOffset = Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, (ushort)(di + 0x24))];
			Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, (ushort)(di + 0x12))] = channelEventOffset;
			Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, di)] = 0xFFFF;
			if (channelEventOffset != 0) {
				ushort savedAx = AX;
				ushort savedCx = CX;
				ushort savedSi = SI;
				AX = (ushort)(i + 1);
				DI = di;
				SI = channelEventOffset;
				ES = esSeg;
				MidiReadVariableLengthDeltaInternal();
				di = DI;
				SI = savedSi;
				CX = savedCx;
				AX = savedAx;
				ushort tickVal = Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, di)];
				Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, di)] = (ushort)(tickVal + 1);
			}
			di += 2;
		}
	}

	// 02E0 path: reset measure/subdivision and reseed channel deltas.
	/// <summary>
	/// Resets measure and subdivision counters, then reseeds all channel deltas from the event stream.
	/// </summary>
	private void MidiResetSchedulerStateInternal() {
		ushort currentDs = DS;
		ushort esSeg = Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, 0x0117)];
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, 0x011F)] = 1;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(currentDs, 0x0121)] = 0x0060;
		MidiInitChannelDeltas(currentDs, esSeg);
	}

	/// <summary>
	/// Main scheduler tick body; updates timer, invokes song processing, applies fade rotation.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 030F..0348:
	/// push ds; ds=cs
	/// if status bit7 set:
	///   dec byte [011E]
	///   if signed underflow: call 0349; if equal call 036F
	///   rol word [013B],1; if carry set call 04D7
	/// return AL=[0139], BX=[011F], CX=[0121], pop ds, retf
	/// </code>
	/// </remarks>
	public Action MidiTickInternal_F000_030F_F030F(int gotoAddress) {
		PushTickVolatileRegisters();
		Stack.Push16(DS);
		Stack.Push16(CS);
		DS = Stack.Pop16();
		byte status = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x0139)];
		if ((status & 0x80) != 0) {
			byte timerLow = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x011E)];
			timerLow--;
			Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x011E)] = timerLow;
			if ((timerLow & 0x80) != 0) {
				bool positionMatch = MidiCheckSongPositionInternal();
				if (positionMatch) {
					MidiProcessTick_F000_036F_F036F(0);
				}
			}
			ushort fadeBits = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x013B)];
			bool topBit = (fadeBits & 0x8000) != 0;
			fadeBits = (ushort)((fadeBits << 1) | (topBit ? 1 : 0));
			Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x013B)] = fadeBits;
			if (topBit) {
				MidiHandleFade_F000_04D7_F04D7(0);
			}
		}
		status = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x0139)];
		AX = (ushort)((AX & 0xFF00) | status);
		BX = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x011F)];
		CX = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0121)];
		DS = Stack.Pop16();
		PopTickVolatileRegisters();
		return FarRet();
	}

	/// <summary>
	/// Compares live song markers with the cached header copy.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 0349..036E:
	/// les si, [0246]
	/// cmp [es:si],      [024A]
	/// cmp [es:si+4000], [024C]
	/// cmp [es:si+8000], [024E]
	/// ret
	/// </code>
	/// </remarks>
	public Action MidiCheckSongPosition_F000_0349_F0349(int gotoAddress) {
		MidiCheckSongPositionInternal();
		return NearRet();
	}

	/// <summary>
	/// Validates three live song marker words against the cached header snapshot at 024A..024E.
	/// </summary>
	/// <returns>
	/// True when all compared markers match; otherwise false.
	/// </returns>
	private bool MidiCheckSongPositionInternal() {
		ushort headerSi = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0246)];
		ushort headerEs = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0248)];
		ushort marker0 = Memory.UInt16[MemoryUtils.ToPhysicalAddress(headerEs, headerSi)];
		ushort cached0 = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x024A)];
		if (marker0 != cached0) {
			return false;
		}
		ushort marker1 = Memory.UInt16[MemoryUtils.ToPhysicalAddress(headerEs, (ushort)(headerSi + 0x4000))];
		ushort cached1 = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x024C)];
		if (marker1 != cached1) {
			return false;
		}
		ushort marker2 = Memory.UInt16[MemoryUtils.ToPhysicalAddress(headerEs, (ushort)(headerSi - 0x8000))];
		ushort cached2 = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x024E)];
		return marker2 == cached2;
	}

	/// <summary>
	/// Processes one global tick across active channels, dispatching MIDI messages until each channel waits.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 036F..03C6:
	/// add song increment [ES:BX+30] to [011D]
	/// call 03C7 (end/loop check)
	/// for each active channel:
	///   dec channel wait
	///   if zero: consume events and dispatch via [0129 + type*2]
	///   read next var-length delta via 049B
	/// decrement subdivision [0121], wrap to 0x60 and increment measure [011F]
	/// ret
	/// </code>
	/// </remarks>
	public Action MidiProcessTick_F000_036F_F036F(int gotoAddress) {
		ushort songBx = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0115)];
		ushort songEs = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0117)];
		ushort tickIncrement = Memory.UInt16[MemoryUtils.ToPhysicalAddress(songEs, (ushort)(songBx + 0x30))];
		ushort pos = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x011D)];
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x011D)] = (ushort)(pos + tickIncrement);
		BX = songBx;
		ES = songEs;
		MidiCheckSongEndInternal(songBx, songEs);
		ushort activeChannels = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0140)];
		ushort di = 0x0142;
		for (int ch = 0; ch < activeChannels; ch++) {
			di = MidiProcessChannel(di, songEs);
		}
		MidiAdvanceSubdivision();
		return NearRet();
	}

	/// <summary>
	/// Advances one channel state machine until the channel reaches a non-zero wait counter.
	/// </summary>
	/// <returns>
	/// The next channel descriptor offset.
	/// </returns>
	private ushort MidiProcessChannel(ushort di, ushort songEs) {
		ushort tickCounter = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, di)];
		tickCounter--;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, di)] = tickCounter;
		if (tickCounter != 0) {
			return (ushort)(di + 2);
		}
		ushort channelSi = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, (ushort)(di + 0x12))];
		if (channelSi == 0) {
			return (ushort)(di + 2);
		}
		while (true) {
			ushort eventWord = Memory.UInt16[MemoryUtils.ToPhysicalAddress(songEs, channelSi)];
			channelSi += 2;
			ushort eventType = (ushort)((eventWord & 0x0070) >> 4);
			DX = (ushort)((di - 0x0142) >> 1);
			DI = di;
			SI = channelSi;
			ES = songEs;
			AX = eventWord;
			MidiDispatchEvent(eventWord, eventType);
			channelSi = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, (ushort)(di + 0x12))];
			ushort newTick = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, di)];
			if (newTick != 0) {
				break;
			}
		}
		return (ushort)(di + 2);
	}

	/// <summary>
	/// Decrements song subdivision and rolls measure when subdivision wraps from 1 to 0.
	/// </summary>
	private void MidiAdvanceSubdivision() {
		byte subdivision = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x0121)];
		subdivision--;
		Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x0121)] = subdivision;
		if (subdivision == 0) {
			Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x0121)] = 0x60;
			ushort measure = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x011F)];
			Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x011F)] = (ushort)(measure + 1);
		}
	}

	/// <summary>
	/// Routes one decoded event word to the corresponding MT-32 handler routine.
	/// </summary>
	private void MidiDispatchEvent(ushort eventWord, ushort eventType) {
		byte statusByte = (byte)(eventWord & 0xFF);
		byte dataByte = (byte)((eventWord >> 8) & 0xFF);
		if (_firstDispatchCount < 5) {
			Mt32Logger.Information("[MIDI:DISPATCH] type={Type} status={StatusHex}", eventType, $"0x{statusByte:X2}");
			_firstDispatchCount++;
		}
		Mt32EventHandlerKind handlerKind = Mt32EventHandlerTable[eventType & 0x7];
		switch (handlerKind) {
			case Mt32EventHandlerKind.ThreeByteWithDelta:
				MidiHandleThreeByteEventWithDelta(statusByte, dataByte);
				break;
			case Mt32EventHandlerKind.DeltaOnly:
				MidiReadVariableLengthDeltaInternal();
				break;
			case Mt32EventHandlerKind.ThreeByteControlWithDelta:
				MidiHandleControlChangeEventWithDelta(statusByte, dataByte);
				break;
			case Mt32EventHandlerKind.TwoByteWithDelta:
				MidiHandleTwoByteEventWithDelta(statusByte, dataByte);
				break;
			case Mt32EventHandlerKind.SpecialControlFlow:
				MidiHandleSpecialControlEvent();
				break;
		}
	}

	/// <summary>
	/// Handles a three-byte MIDI event by reading byte3 from stream, decoding next delta, then sending via 05A6 contract.
	/// </summary>
	private void MidiHandleThreeByteEventWithDelta(byte statusByte, byte dataByte) {
		byte thirdData = Memory.UInt8[MemoryUtils.ToPhysicalAddress(ES, SI)];
		SI++;
		MidiReadVariableLengthDeltaInternal();
		AX = (ushort)((dataByte << 8) | statusByte);
		CX = thirdData;
		MidiSend3Bytes_F000_05A6_F05A6(0);
	}

	/// <summary>
	/// Handles control-change events, applying channel volume scaling for controller 07 before dispatching.
	/// </summary>
	private void MidiHandleControlChangeEventWithDelta(byte statusByte, byte dataByte) {
		byte value = Memory.UInt8[MemoryUtils.ToPhysicalAddress(ES, SI)];
		SI++;
		MidiReadVariableLengthDeltaInternal();
		if (dataByte == 0x07) {
			byte channelNumber = (byte)(statusByte & 0x0F);
			Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, (ushort)(0x019C + channelNumber))] = value;
			byte currentVolume = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x013D)];
			value = (byte)(((ushort)(currentVolume * value)) >> 8);
		}
		AX = (ushort)((dataByte << 8) | statusByte);
		CX = value;
		MidiSend3Bytes_F000_05A6_F05A6(0);
	}

	/// <summary>
	/// Handles a two-byte MIDI event by decoding next delta and sending AX through 0592 contract.
	/// </summary>
	private void MidiHandleTwoByteEventWithDelta(byte statusByte, byte dataByte) {
		MidiReadVariableLengthDeltaInternal();
		AX = (ushort)((dataByte << 8) | statusByte);
		MidiSend2Bytes_F000_0592_F0592(0);
	}

	/// <summary>
	/// Handles special control flow events including end marker processing, loop/tick flag handling, scheduler reset, and optional global reset.
	/// </summary>
	private void MidiHandleSpecialControlEvent() {
		byte al = (byte)(AX & 0x00FF);
		if (al != 0xFF) {
			// 045F: nop (explicitly modeled as no-op path)
		}

		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, DI)] = 0xFFFF;
		byte nextEventOffsetLow = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, (ushort)(DI + 0x12))];
		nextEventOffsetLow = (byte)(nextEventOffsetLow - 2);
		Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, (ushort)(DI + 0x12))] = nextEventOffsetLow;
		if (DX != 0) {
			return;
		}

		byte tickFlag = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x013A)];
		tickFlag--;
		Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x013A)] = tickFlag;
		if (tickFlag == 0) {
			AX = 0xFFFF;
			for (int i = 0; i < 9; i++) {
				Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, DI)] = 0xFFFF;
				DI += 2;
			}
			MidiResetInternal_F000_01E1_F01E1(0);
			return;
		}
		if ((tickFlag & 0x80) != 0) {
			Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x013A)] = (byte)(tickFlag + 1);
		}
		MidiResetSchedulerStateInternal();
		BX = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0115)];
		ES = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0117)];
		DI = 0x0142;
		MidiCheckSongEndInternal(BX, ES);
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, DI)] = (ushort)(Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, DI)] - 1);
	}

	/// <summary>
	/// Checks song end and loop boundaries, copying or restoring channel snapshots as required.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 03C7..049A:
	/// if [0123] == 0:
	///   compare end measure [ES:BX+2A] and subdivision == 0x60
	///   copy 0x12 words from 0142 to 0178
	///   [0123] = [ES:BX+2E] - 1
	/// else:
	///   when measure reaches loop marker [ES:BX+2C]:
	///   dec [0123], restore 0x12 words from 0178 to 0142, restore measure
	/// ret
	/// </code>
	/// </remarks>
	public Action MidiCheckSongEnd_F000_03C7_F03C7(int gotoAddress) {
		ushort songBx = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0115)];
		ushort songEs = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0117)];
		MidiCheckSongEndInternal(songBx, songEs);
		return NearRet();
	}

	/// <summary>
	/// Applies song end and loop bookkeeping, including snapshot copy/restore of channel runtime state.
	/// </summary>
	private void MidiCheckSongEndInternal(ushort songBx, ushort songEs) {
		ushort repeatCount = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0123)];
		if (repeatCount == 0) {
			ushort endMeasure = Memory.UInt16[MemoryUtils.ToPhysicalAddress(songEs, (ushort)(songBx + 0x2A))];
			ushort currentMeasure = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x011F)];
			if (endMeasure != currentMeasure) {
				return;
			}
			ushort currentSubdivision = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0121)];
			if (currentSubdivision != 0x0060) {
				return;
			}
			ushort di = 0x0142;
			uint src = MemoryUtils.ToPhysicalAddress(DS, di);
			uint dst = MemoryUtils.ToPhysicalAddress(DS, (ushort)(di + 0x36));
			Memory.MemCopy(src, dst, 0x12 * 2);
			ushort loopRepeat = Memory.UInt16[MemoryUtils.ToPhysicalAddress(songEs, (ushort)(songBx + 0x2E))];
			loopRepeat--;
			Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0123)] = loopRepeat;
			return;
		}

		ushort loopMeasure = Memory.UInt16[MemoryUtils.ToPhysicalAddress(songEs, (ushort)(songBx + 0x2C))];
		ushort measure = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x011F)];
		if (loopMeasure != measure) {
			return;
		}
		repeatCount--;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0123)] = repeatCount;
		ushort restoreDi = 0x0142;
		uint restoreSrc = MemoryUtils.ToPhysicalAddress(DS, (ushort)(restoreDi + 0x36));
		uint restoreDst = MemoryUtils.ToPhysicalAddress(DS, restoreDi);
		Memory.MemCopy(restoreSrc, restoreDst, 0x12 * 2);
		ushort restoreMeasure = Memory.UInt16[MemoryUtils.ToPhysicalAddress(songEs, (ushort)(songBx + 0x2A))];
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x011F)] = restoreMeasure;
	}

	/// <summary>
	/// Reads variable-length delta-time from ES:SI and stores decoded value to DS:[DI].
	/// </summary>
	/// <remarks>
	/// <code>
	/// 049B..04D6 algorithm:
	/// read first byte
	/// if bit7 clear -> single-byte value
	/// else accumulate 7-bit chunks through AX/CX shifts/rotates
	/// on overflow set AX=FFFF
	/// store AX to [DI], store updated SI to [DI+12]
	/// ret
	/// </code>
	/// </remarks>
	public Action MidiReadVariableLengthDelta_F000_049B_F049B(int gotoAddress) {
		MidiReadVariableLengthDeltaInternal();
		return NearRet();
	}

	/// <summary>
	/// Decodes the driver-specific variable-length delta-time format and writes result/pointer back to channel state.
	/// </summary>
	/// <remarks>
	/// AX and CX are preserved for caller parity because this helper is invoked from multiple internal call sites.
	/// </remarks>
	private void MidiReadVariableLengthDeltaInternal() {
		ushort savedAx = AX;
		ushort savedCx = CX;

		ushort ax = 0;
		byte al = Memory.UInt8[MemoryUtils.ToPhysicalAddress(ES, SI)];
		SI++;
		ax = (ushort)((ax & 0xFF00) | al);

		if ((al & 0x80) != 0) {
			ushort cx = 0;
			while (true) {
				byte cl = (byte)(cx & 0x00FF);
				byte ah = (byte)((ax >> 8) & 0x00FF);
				byte newCh = cl;
				byte newCl = ah;
				byte newAh = (byte)(ax & 0x00FF);
				cx = (ushort)((newCh << 8) | newCl);
				ax = (ushort)((newAh << 8) | (ax & 0x00FF));

				al = Memory.UInt8[MemoryUtils.ToPhysicalAddress(ES, SI)];
				SI++;
				ax = (ushort)((ax & 0xFF00) | al);
				if ((al & 0x80) == 0) {
					break;
				}
			}

			ax &= 0x7F7F;
			cx &= 0x7F7F;

			byte shiftedCl = (byte)(((byte)(cx & 0x00FF)) << 1);
			cx = (ushort)((cx & 0xFF00) | shiftedCl);
			cx = (ushort)(cx >> 1);

			byte shiftedAl = (byte)(((byte)(ax & 0x00FF)) << 1);
			ax = (ushort)((ax & 0xFF00) | shiftedAl);
			ax = (ushort)(ax << 1);

			for (int i = 0; i < 2; i++) {
				bool carryFromCx = (cx & 0x0001) != 0;
				cx = (ushort)(cx >> 1);
				ax = (ushort)((ax >> 1) | (carryFromCx ? 0x8000 : 0));
			}

			if (cx != 0) {
				ax = 0xFFFF;
			}
		}

		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, DI)] = ax;
		Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, (ushort)(DI + 0x12))] = SI;
		AX = savedAx;
		CX = savedCx;
	}

	/// <summary>
	/// Fade handler: moves current volume toward target and re-sends per-channel CC7 volumes.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 04D7..052E:
	/// diff = [013D] - [013E]
	/// if zero: set [013B]=1 and clear status bit6
	/// else clamp step to +/-3 toward target
	/// for channels 0..9: scaled = current * channelBase / 256
	/// send B0+ch,07,scaled
	/// if all channels end at zero: clear status [0139]
	/// ret
	/// </code>
	/// </remarks>
	public Action MidiHandleFade_F000_04D7_F04D7(int gotoAddress) {
		byte current = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x013D)];
		byte target = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x013E)];
		if (current == target) {
			Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x013B)] = 1;
			byte status = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x0139)];
			Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x0139)] = (byte)(status & 0xBF);
			return NearRet();
		}

		Stack.Push16(DX);
		Stack.Push16(SI);
		Stack.Push16(DI);
		Stack.Push16(BP);
		Stack.Push16(ES);
		try {

			if (current > target) {
				byte deltaDown = (byte)(current - target);
				if (deltaDown > 3) {
					deltaDown = 3;
				}
				current = (byte)(current - deltaDown);
			} else {
				byte deltaUp = (byte)(target - current);
				if (deltaUp > 3) {
					deltaUp = 3;
				}
				current = (byte)(current + deltaUp);
			}
			Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x013D)] = current;

			for (int ch = 0; ch < 10; ch++) {
				byte channelBase = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, (ushort)(0x019C + ch))];
				byte scaled = (byte)((current * channelBase) >> 8);
				MidiSend3BytesDirect((byte)(0xB0 + ch), 0x07, scaled);
			}
			if (current == 0) {
				MidiCsByteSet(0x0139, 0);
			}
		} finally {
			ES = Stack.Pop16();
			BP = Stack.Pop16();
			DI = Stack.Pop16();
			SI = Stack.Pop16();
			DX = Stack.Pop16();
		}
		return NearRet();
	}

	/// <summary>
	/// Enters UART-related startup mode by broadcasting controller setup and then sending reset sequence.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 052F..0558:
	/// [0127] = 0x0050
	/// for channel 0..9:
	///   send (B0|ch, 7B, 00)
	///   send (E0|ch, 00, 40)
	/// [0127] = 1
	/// send reset sequence (calls 0559 path)
	/// </code>
	/// </remarks>
	public Action MidiEnterUartMode_F000_052F_F052F(int gotoAddress) {
		MidiCsWordSet(0x0127, 0x0050);
		for (int ch = 0; ch < 10; ch++) {
			MidiSend3BytesDirect((byte)(0xB0 + ch), 0x7B, 0x00);
			MidiSend3BytesDirect((byte)(0xE0 + ch), 0x00, 0x40);
		}
		MidiCsWordSet(0x0127, 1);
		return MidiSendResetSequence_F000_0559_F0559(0);
	}

	/// <summary>
	/// Sends the two-byte MT-32 reset handshaking sequence over the control path.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 0559: mov bl,FF; call 0564
	/// 055E: mov bl,3F; call 0564
	/// 0563: ret
	/// </code>
	/// </remarks>
	public Action MidiSendResetSequence_F000_0559_F0559(int gotoAddress) {
		BX = (ushort)((BX & 0xFF00) | 0x00FF);
		MidiSendByteWithAckUsingControlPort();
		BX = (ushort)((BX & 0xFF00) | 0x003F);
		MidiSendByteWithAckUsingControlPort();
		return NearRet();
	}

	/// <summary>
	/// Sends BL byte using control-port wait/ack protocol (status polling and timeout loops), preserving CX, DX, and FLAGS via stack.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 0564..0591:
	/// push CX; push DX; pushf; cli
	/// wait while status bit6 busy
	/// out (base+1), BL
	/// wait for status bit7 data-ready
	/// read data port; if != FE continue polling
	/// long settle delay loop
	/// popf; pop DX; pop CX
	/// ret
	/// </code>
	/// </remarks>
	public Action MidiSendByteWithWait_F000_0564_F0564(int gotoAddress) {
		Stack.Push16(CX);
		Stack.Push16(DX);
		PushFlagsToStack();
		InterruptFlag = false;
		MidiSendByteWithAckUsingControlPort();
		PopFlagsFromStack();
		DX = Stack.Pop16();
		CX = Stack.Pop16();
		return NearRet();
	}

	/// <summary>
	/// Core implementation used by reset-sequence and send-byte entrypoints: writes BL to control port with MPU-401 acknowledge polling.
	/// </summary>
	private void MidiSendByteWithAckUsingControlPort() {
		byte value = (byte)(BX & 0x00FF);
		ushort basePort = MidiCsWord(0x0125);
		ushort statusPort = (ushort)(basePort + 1);
		ushort dataPort = basePort;
		byte status;
		ushort readyCounter = 0;
		do {
			status = Machine.IoPortDispatcher.ReadByte(statusPort);
			readyCounter--;
		} while ((status & 0x40) != 0 && readyCounter != 0);
		Machine.IoPortDispatcher.WriteByte(statusPort, value);
		ushort ackCounter = 0x0064;
		do {
			status = Machine.IoPortDispatcher.ReadByte(statusPort);
			ackCounter--;
		} while ((status & 0x80) == 0 && ackCounter != 0);
		ackCounter++;
		byte data = Machine.IoPortDispatcher.ReadByte(dataPort);
		if (data != 0xFE && ackCounter != 0) {
			do {
				status = Machine.IoPortDispatcher.ReadByte(statusPort);
				ackCounter--;
			} while ((status & 0x80) == 0 && ackCounter != 0);
		}
		ushort settleCounter = 0x4E20;
		while (settleCounter != 0) {
			status = Machine.IoPortDispatcher.ReadByte(statusPort);
			settleCounter--;
		}
		AX = (ushort)((AX & 0xFF00) | status);
	}

	/// <summary>
	/// Sends a 2-byte MIDI message from AX (AL=status, AH=data1), preserving BX/CX/DX and FLAGS, but leaving AX post-state as produced by low-level I/O.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 0592..05A5:
	/// push BX; push CX; push DX; pushf; cli
	/// bx=ax; call 05BF
	/// bl=bh; call 05BF
	/// popf; pop DX; pop CX; pop BX; ret
	/// </code>
	/// </remarks>
	public Action MidiSend2Bytes_F000_0592_F0592(int gotoAddress) {
		Stack.Push16(BX);
		Stack.Push16(CX);
		Stack.Push16(DX);
		PushFlagsToStack();
		InterruptFlag = false;
		BX = AX;
		MidiPortIO_F000_05BF_F05BF(0);
		BX = (ushort)((BX & 0xFF00) | ((BX >> 8) & 0x00FF));
		MidiPortIO_F000_05BF_F05BF(0);
		PopFlagsFromStack();
		DX = Stack.Pop16();
		CX = Stack.Pop16();
		BX = Stack.Pop16();
		return NearRet();
	}

	/// <summary>
	/// Sends a 3-byte MIDI message from AX+CL (AL=status, AH=data1, CL=data2), preserving BX/CX/DX and FLAGS, but leaving AX post-state as produced by low-level I/O.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 05A6..05BE:
	/// push BX; push CX; push DX; pushf
	/// bx=ax; call 05BF
	/// push CX
	/// cli
	/// bl=bh; call 05BF
	/// pop bx (original cx low); call 05BF
	/// popf; pop DX; pop CX; pop BX; ret
	/// </code>
	/// </remarks>
	public Action MidiSend3Bytes_F000_05A6_F05A6(int gotoAddress) {
		Stack.Push16(BX);
		Stack.Push16(CX);
		Stack.Push16(DX);
		PushFlagsToStack();
		InterruptFlag = false;
		BX = AX;
		Stack.Push16(CX);
		MidiPortIO_F000_05BF_F05BF(0);
		BX = (ushort)((BX & 0xFF00) | ((AX >> 8) & 0x00FF));
		MidiPortIO_F000_05BF_F05BF(0);
		BX = Stack.Pop16();
		MidiPortIO_F000_05BF_F05BF(0);
		PopFlagsFromStack();
		DX = Stack.Pop16();
		CX = Stack.Pop16();
		BX = Stack.Pop16();
		return NearRet();
	}

	/// <summary>
	/// Convenience helper that loads AX/CX as required by the 05A6 contract and delegates to the 3-byte sender.
	/// </summary>
	private void MidiSend3BytesDirect(byte byte1, byte byte2, byte byte3) {
		AX = (ushort)((byte2 << 8) | byte1);
		CX = byte3;
		MidiSend3Bytes_F000_05A6_F05A6(0);
	}

	/// <summary>
	/// Low-level data-port sender with busy wait and programmable post-write delay.
	/// </summary>
	/// <remarks>
	/// <code>
	/// 05BF..05DA:
	/// dx=[0125]+1
	/// wait while status bit6 set
	/// out (dx-1), BL
	/// delay loop count from [0127], polling status
	/// ret
	/// </code>
	/// </remarks>
	public Action MidiPortIO_F000_05BF_F05BF(int gotoAddress) {
		ushort basePort = MidiCsWord(0x0125);
		ushort statusPort = (ushort)(basePort + 1);
		ushort dataPort = basePort;
		byte value = (byte)(BX & 0x00FF);
		byte status;
		ushort waitCounter = 0x00FF;
		do {
			status = Machine.IoPortDispatcher.ReadByte(statusPort);
			waitCounter--;
		} while ((status & 0x40) != 0 && waitCounter != 0);
		Machine.IoPortDispatcher.WriteByte(dataPort, value);
		ushort delayCounter = MidiCsWord(0x0127);
		while (delayCounter != 0) {
			status = Machine.IoPortDispatcher.ReadByte(statusPort);
			delayCounter--;
		}
		DX = statusPort;
		CX = 0;
		AX = (ushort)((AX & 0xFF00) | status);
		return NearRet();
	}
}