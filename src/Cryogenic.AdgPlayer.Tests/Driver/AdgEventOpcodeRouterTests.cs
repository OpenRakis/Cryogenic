namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using Xunit;

/// <summary>
/// Unit tests for <see cref="AdgEventOpcodeRouter"/>.
/// </summary>
public sealed class AdgEventOpcodeRouterTests {
	/// <summary>
	/// The router maps the 8 jump-table slots to the event opcodes
	/// observed in <c>AdgDispatchObservedEvent_0756</c>.
	/// </summary>
	[Theory]
	[InlineData(0, AdgEventOpcode.NoteOff)]
	[InlineData(1, AdgEventOpcode.NoteOn)]
	[InlineData(2, AdgEventOpcode.ReadWaitValue)]
	[InlineData(3, AdgEventOpcode.ReadWaitValue)]
	[InlineData(4, AdgEventOpcode.ProgramChange)]
	[InlineData(5, AdgEventOpcode.VolumeModulation)]
	[InlineData(6, AdgEventOpcode.PitchBend)]
	[InlineData(7, AdgEventOpcode.EndOfTrack)]
	public void Route_MapsSlotToOpcode(int slot, AdgEventOpcode expected) {
		// Arrange
		// Act
		AdgEventOpcode opcode = AdgEventOpcodeRouter.Route(slot);

		// Assert
		Assert.Equal(expected, opcode);
	}

	/// <summary>Out-of-range slot raises.</summary>
	[Theory]
	[InlineData(-1)]
	[InlineData(8)]
	[InlineData(255)]
	public void Route_OutOfRange_Throws(int slot) {
		// Arrange
		// Act
		// Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => AdgEventOpcodeRouter.Route(slot));
	}
}