namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Emits the five OPL register writes for one instrument operator.
/// Faithful port of <c>AdgWriteInstrumentOperator_102C</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>: composes
/// <see cref="AdgInstrumentOperatorComputer"/> +
/// <see cref="AdgChannelRouter"/> + <see cref="IOplBus"/>.
/// </summary>
public static class AdgInstrumentOperatorEmitter {
	private const byte WaveformRegisterBase = 0xE0;
	private const byte TotalLevelRegisterBase = 0x40;
	private const byte AttackDecayRegisterBase = 0x60;
	private const byte SustainReleaseRegisterBase = 0x80;
	private const byte OpFlagsRegisterBase = 0x20;

	/// <summary>
	/// Decodes <paramref name="patch"/> + <paramref name="waveform"/> via
	/// <see cref="AdgInstrumentOperatorComputer.Compute"/>, then writes
	/// the five resulting register values onto <paramref name="bus"/>
	/// routed through <paramref name="operatorRoute"/>, in the exact
	/// order used by the original driver.
	/// </summary>
	public static void Emit(IOplBus bus, byte[] patch, byte waveform, byte operatorRoute) {
		ArgumentNullException.ThrowIfNull(bus);
		// AdgInstrumentOperatorComputer.Compute validates patch.

		AdgInstrumentOperatorRegisters registers =
			AdgInstrumentOperatorComputer.Compute(patch, waveform);

		WriteRouted(bus, WaveformRegisterBase, registers.Waveform, operatorRoute);
		WriteRouted(bus, TotalLevelRegisterBase, registers.TotalLevel, operatorRoute);
		WriteRouted(bus, AttackDecayRegisterBase, registers.AttackDecay, operatorRoute);
		WriteRouted(bus, SustainReleaseRegisterBase, registers.SustainRelease, operatorRoute);
		WriteRouted(bus, OpFlagsRegisterBase, registers.OpFlags, operatorRoute);
	}

	private static void WriteRouted(IOplBus bus, byte registerBase, byte value, byte route) {
		AdgRoutedRegister routed = AdgChannelRouter.Route(registerBase, route);
		bus.WriteRegister(routed.Chip, routed.Register, value);
	}
}