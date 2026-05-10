namespace Cryogenic.AdgPlayer.Ui.ViewModels;

/// <summary>
/// Snapshot of one ADG logical channel for the channel-grid panel.
/// Built from <see cref="Cryogenic.AdgPlayer.Driver.AdgDriverState"/>
/// each time the host engine asks for a refresh — instances are
/// immutable so the UI never observes a half-updated row.
/// </summary>
public sealed class AdgChannelRowViewModel {
	/// <summary>Logical channel index in the 0..17 range.</summary>
	public int Index { get; }

	/// <summary>Latest current-note byte (DI+0x6D).</summary>
	public byte CurrentNote { get; }

	/// <summary>Latest instrument byte (DI+0x6C).</summary>
	public byte Instrument { get; }

	/// <summary>Latest pitch-bend counter byte (DI+0xB4).</summary>
	public byte PitchBendCounter { get; }

	/// <summary>Latest pitch accumulator byte (DI+0xD8).</summary>
	public byte PitchAccumulator { get; }

	/// <summary>True when the channel currently uses a 4-op patch (DI+0x2D0).</summary>
	public bool IsFourOperator { get; }

	/// <summary>Builds a row snapshot.</summary>
	public AdgChannelRowViewModel(
		int index,
		byte currentNote,
		byte instrument,
		byte pitchBendCounter,
		byte pitchAccumulator,
		bool isFourOperator) {
		Index = index;
		CurrentNote = currentNote;
		Instrument = instrument;
		PitchBendCounter = pitchBendCounter;
		PitchAccumulator = pitchAccumulator;
		IsFourOperator = isFourOperator;
	}
}