namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Final orchestrator for <c>AdgWriteInstrumentPatch_0F95</c>. Emits
/// the eleven instrument register writes via
/// <see cref="AdgInstrumentEmitter"/>, then computes the surround-mask
/// update via <see cref="AdgSurroundMaskUpdater"/>, persists the new
/// mask in <see cref="AdgSurroundMaskState"/>, and conditionally emits
/// the <c>SecondaryControl</c> write (chip 1, register 0x04) via direct
/// secondary-chip access — no router transform, matching
/// <c>AdgWriteSecondaryRegisterDirect</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public static class AdgInstrumentPatchEmitter {
	private const int SecondaryControlChip = 1;
	private const byte SecondaryControlRegister = 0x04;

	/// <summary>
	/// Emits the full instrument-patch program and updates the global
	/// surround mask.
	/// </summary>
	public static void Emit(IOplBus bus, AdgSurroundMaskState surroundState,
		byte[] patch, byte channelRoute, byte primaryRoute, byte secondaryRoute) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(surroundState);
		// AdgInstrumentEmitter.Emit validates patch.

		AdgInstrumentEmitter.Emit(bus, patch, channelRoute, primaryRoute, secondaryRoute);

		AdgSurroundMaskUpdate update = AdgSurroundMaskUpdater.Compute(
			secondaryRoute, patchTypeByte: patch[0], currentMask: surroundState.Mask);

		if (!update.ShouldEmit) {
			return;
		}

		surroundState.SetMask(update.NewMask);
		bus.WriteRegister(SecondaryControlChip, SecondaryControlRegister, update.NewMask);
	}
}