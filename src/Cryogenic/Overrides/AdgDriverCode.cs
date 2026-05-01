namespace Cryogenic.Overrides;

using Serilog;

using System;

/// <summary>
/// DNADG (AdLib Gold / OPL3) C# override scaffold.
/// This class is intentionally registration-only until runtime evidence is collected.
/// </summary>
public partial class Overrides {
	private static readonly ILogger AdgLogger = Log.ForContext("Subsystem", "ADGDriver");
	private static bool EnableAdgCSharpFunctionReplacement = false;
	private ushort _adgSegment = 0x564B;

	private const ushort AdgDefaultSegment = 0x564B;
	private const ushort AdgStatusOffset = 0x01DE;
	private const ushort AdgChannelRoutingTableOffset = 0x017F;
	private const ushort AdgFrequencyWordTableOffset = 0x015A;
	private const ushort AdgPrimaryRegisterPortOffset = 0x0115;
	private const ushort AdgSecondaryRegisterPortOffset = 0x0117;
	private const int AdgResetChannelCount = 0x12;

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

	private void ResolveAdgSegment() {
		if (DriverLoadToolbox.ActualAdpSegment != 0) {
			_adgSegment = DriverLoadToolbox.ActualAdpSegment;
		} else {
			_adgSegment = AdgDefaultSegment;
		}
	}

	private byte AdgByte(ushort offset) {
		return SegByte(_adgSegment, offset);
	}

	private void AdgByteSet(ushort offset, byte value) {
		SegByteSet(_adgSegment, offset, value);
	}

	private ushort AdgWord(ushort offset) {
		return SegWord(_adgSegment, offset);
	}

	private void AdgPushFlagsToStack() {
		Stack.Push16(State.Flags.FlagRegister16);
	}

	private void AdgPopFlagsFromStack() {
		State.Flags.FlagRegister = Stack.Pop16();
	}

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

	private void AdgOplNoteOff_ResetHelper(ushort channelIndex) {
		DX = channelIndex;
		SI = DX;
		SI = (ushort)(SI + SI);
		AX = AdgWord((ushort)(AdgFrequencyWordTableOffset + SI));
		CX = AX;

		AdgWriteRoutedOplRegister(0xA0, Lo8(CX), (byte)channelIndex);
		AdgWriteRoutedOplRegister(0xB0, Hi8(CX), (byte)channelIndex);
	}

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

	private void RegisterAdgObservedFunctionReplacements() {
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
	public Action AdgInit_564B_0100_0565B0(int gotoAddress) {
		AdgInit_564B_04FF_0569AF(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:0103. Jumps to 564B:0626.
	/// </summary>
	public Action AdgOpenSong_564B_0103_0565B3(int gotoAddress) {
		AdgOpenSong_564B_0626_056AD6(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:0106. Jumps to 564B:0561.
	/// </summary>
	public Action AdgReset_564B_0106_0565B6(int gotoAddress) {
		AdgReset_564B_0561_056A11(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:0109. Jumps to 564B:0610.
	/// </summary>
	public Action AdgSetTickEnabled_564B_0109_0565B9(int gotoAddress) {
		AdgSetTickEnabled_564B_0610_056AC0(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:010C. Jumps to 564B:05BE.
	/// </summary>
	public Action AdgSetDynamics_564B_010C_0565BC(int gotoAddress) {
		AdgSetDynamics_564B_05BE_056A6E(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:010F. Jumps to 564B:06F6.
	/// </summary>
	public Action AdgTick_564B_010F_0565BF(int gotoAddress) {
		AdgTick_564B_06F6_056BA6(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG export wrapper at 564B:0112. Jumps to 564B:05AB.
	/// </summary>
	public Action AdgSetVolume_564B_0112_0565C2(int gotoAddress) {
		AdgSetVolume_564B_05AB_056A5B(0);
		return FarRet();
	}

	/// <summary>
	/// DNADG internal init entry at 564B:04FF.
	/// </summary>
	public Action AdgInit_564B_04FF_0569AF(int gotoAddress) {
		throw FailAsUntested("DNADG init body at 564B:04FF is runtime-observed but not implemented yet.");
	}

	/// <summary>
	/// DNADG internal open-song entry at 564B:0626.
	/// </summary>
	public Action AdgOpenSong_564B_0626_056AD6(int gotoAddress) {
		throw FailAsUntested("DNADG open-song body at 564B:0626 is runtime-observed but not implemented yet.");
	}

	/// <summary>
	/// DNADG internal reset entry at 564B:0561.
	/// </summary>
	public Action AdgReset_564B_0561_056A11(int gotoAddress) {
		AdgPushFlagsToStack();
		InterruptFlag = false;
		AdgResetInternal_0EBA();
		AX = 0;
		AdgByteSet(AdgStatusOffset, 0);
		AdgPopFlagsFromStack();
		return FarRet();
	}

	/// <summary>
	/// DNADG internal set-tick-enabled entry at 564B:0610.
	/// </summary>
	public Action AdgSetTickEnabled_564B_0610_056AC0(int gotoAddress) {
		throw FailAsUntested("DNADG set-tick-enabled body at 564B:0610 is runtime-observed but not implemented yet.");
	}

	/// <summary>
	/// DNADG internal set-dynamics entry at 564B:05BE.
	/// </summary>
	public Action AdgSetDynamics_564B_05BE_056A6E(int gotoAddress) {
		throw FailAsUntested("DNADG set-dynamics body at 564B:05BE is runtime-observed but not implemented yet.");
	}

	/// <summary>
	/// DNADG internal tick entry at 564B:06F6.
	/// </summary>
	public Action AdgTick_564B_06F6_056BA6(int gotoAddress) {
		throw FailAsUntested("DNADG tick body at 564B:06F6 is runtime-observed but not implemented yet.");
	}

	/// <summary>
	/// DNADG internal set-volume entry at 564B:05AB.
	/// </summary>
	public Action AdgSetVolume_564B_05AB_056A5B(int gotoAddress) {
		throw FailAsUntested("DNADG set-volume body at 564B:05AB is runtime-observed but not implemented yet.");
	}
}