namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Emits the full instrument-patch program for one logical channel:
/// the Feedback/Connection register byte (0xC0 family) followed by the
/// primary and secondary operator programs. Faithful port of the
/// non-surround portion of <c>AdgWriteInstrumentPatch_0F95</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>. The optional
/// surround-mask side effect at the end of the original routine is
/// handled by a separate component.
/// </summary>
public static class AdgInstrumentEmitter {
	private const byte FeedbackConnectionRegisterBase = 0xC0;
	private const int SecondaryOperatorPatchOffset = 0x0D;
	private const int PrimaryWaveformOffset = 0x1C;
	private const int SecondaryWaveformOffset = 0x1D;

	/// <summary>
	/// Minimum patch length required (offsets 0x1C and 0x1D are read).
	/// </summary>
	public const int RequiredPatchLength = 0x1E;

	/// <summary>
	/// Programs <paramref name="bus"/> with the eleven register writes
	/// that constitute one full instrument patch on the routed channel.
	/// </summary>
	public static void Emit(IOplBus bus, byte[] patch,
		byte channelRoute, byte primaryRoute, byte secondaryRoute) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(patch);
		if (patch.Length < RequiredPatchLength) {
			throw new ArgumentException(
				$"Instrument patch must contain at least {RequiredPatchLength} bytes.",
				nameof(patch));
		}

		byte connectionByte = AdgInstrumentConnectionComputer.Compute(patch);
		AdgRoutedRegister routed = AdgChannelRouter.Route(
			FeedbackConnectionRegisterBase, channelRoute);
		bus.WriteRegister(routed.Chip, routed.Register, connectionByte);

		byte[] primaryPatch = new byte[AdgInstrumentOperatorComputer.RequiredPatchLength];
		Array.Copy(patch, 0, primaryPatch, 0, primaryPatch.Length);
		AdgInstrumentOperatorEmitter.Emit(bus, primaryPatch,
			patch[PrimaryWaveformOffset], primaryRoute);

		byte[] secondaryPatch = new byte[AdgInstrumentOperatorComputer.RequiredPatchLength];
		Array.Copy(patch, SecondaryOperatorPatchOffset, secondaryPatch, 0,
			secondaryPatch.Length);
		AdgInstrumentOperatorEmitter.Emit(bus, secondaryPatch,
			patch[SecondaryWaveformOffset], secondaryRoute);
	}
}