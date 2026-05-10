namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Production implementation of <see cref="IAdgPitchBendBody"/>.
/// Composes <see cref="AdgPitchBendComputer"/> (math) and
/// <see cref="AdgChannelPitchBendEmitter"/> (cache + routed
/// key-on emit) using the engine-supplied tables and per-channel
/// state, mirroring the dispatch tail of
/// <c>AdgPitchBendBody_0D8B</c> in the original DNADG driver.
/// </summary>
public sealed class DefaultAdgPitchBendBody : IAdgPitchBendBody {
	private readonly IOplBus _bus;
	private readonly AdgFrequencyWordCache _frequencyWordCache;
	private readonly AdgChannelRoutingTable _routingTable;
	private readonly AdgFrequencyLookupTable _frequencyLookup;
	private readonly AdgPitchBendFractionsTable _bendFractions;
	private readonly AdgPortamentoFractionsTable _portamentoFractions;
	private readonly AdgChannelCurrentNotes _currentNotes;
	private readonly AdgChannelPitchModeSlots _pitchModeSlots;

	/// <summary>Constructs a body bound to the supplied dependencies.</summary>
	public DefaultAdgPitchBendBody(
		IOplBus bus,
		AdgFrequencyWordCache frequencyWordCache,
		AdgChannelRoutingTable routingTable,
		AdgFrequencyLookupTable frequencyLookup,
		AdgPitchBendFractionsTable bendFractions,
		AdgPortamentoFractionsTable portamentoFractions,
		AdgChannelCurrentNotes currentNotes,
		AdgChannelPitchModeSlots pitchModeSlots) {
		ArgumentNullException.ThrowIfNull(bus);
		ArgumentNullException.ThrowIfNull(frequencyWordCache);
		ArgumentNullException.ThrowIfNull(routingTable);
		ArgumentNullException.ThrowIfNull(frequencyLookup);
		ArgumentNullException.ThrowIfNull(bendFractions);
		ArgumentNullException.ThrowIfNull(portamentoFractions);
		ArgumentNullException.ThrowIfNull(currentNotes);
		ArgumentNullException.ThrowIfNull(pitchModeSlots);
		_bus = bus;
		_frequencyWordCache = frequencyWordCache;
		_routingTable = routingTable;
		_frequencyLookup = frequencyLookup;
		_bendFractions = bendFractions;
		_portamentoFractions = portamentoFractions;
		_currentNotes = currentNotes;
		_pitchModeSlots = pitchModeSlots;
	}

	/// <inheritdoc />
	public void Emit(int channelIndex, ushort bendWord) {
		byte currentNote = _currentNotes.Get(channelIndex);
		byte pitchMode = _pitchModeSlots.Get(channelIndex);
		byte bendValue = (byte)(bendWord & 0xFF);

		AdgPitchBendComputer.Result result = AdgPitchBendComputer.Compute(
			currentNote, pitchMode, bendValue,
			_frequencyLookup, _bendFractions, _portamentoFractions);

		if (!result.Active) {
			return;
		}

		AdgChannelPitchBendEmitter.Emit(
			_bus, _frequencyWordCache, _routingTable,
			channelIndex, result.PreKeyOnFrequencyWord);
	}
}
