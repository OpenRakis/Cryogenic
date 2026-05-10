namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Subdivision/measure clock orchestrator. Mirrors the tail of
/// <c>AdgSchedulerTick_0756</c> at dnadg:079D :
/// <code>
/// dec byte ptr [012A]      ; subdivision--
/// jnz exit
/// mov byte ptr [012A],0x60 ; reload subdivision counter
/// inc word ptr [0128]      ; measure++
/// </code>
/// and the reload pair at dnadg:0573 / dnadg:067A which seeds
/// measure=1 and subdivision=0x60 when a song is opened or reset.
/// </summary>
public sealed class AdgMeasureClock {
	/// <summary>Reload value for the subdivision counter (0x60 ticks per measure).</summary>
	public const ushort SubdivisionsPerMeasure = 0x60;

	private readonly AdgLoopState _loopState;

	/// <summary>
	/// Builds a clock bound to the supplied <paramref name="loopState"/>.
	/// All updates flow through that shared state object so consumers
	/// can observe the same Measure/Subdivision words.
	/// </summary>
	public AdgMeasureClock(AdgLoopState loopState) {
		ArgumentNullException.ThrowIfNull(loopState);
		_loopState = loopState;
	}

	/// <summary>
	/// Resets the clock to the song-start state: measure=1,
	/// subdivision=0x60.
	/// </summary>
	public void Initialize() {
		_loopState.SetMeasure(1);
		_loopState.SetSubdivision(SubdivisionsPerMeasure);
	}

	/// <summary>
	/// Consumes one scheduler tick: decrements the subdivision
	/// counter and, if it rolled to zero, reloads it to 0x60 and
	/// increments the measure word. Returns <c>true</c> exactly when
	/// the rollover occurred.
	/// </summary>
	public bool AdvanceSubdivision() {
		ushort next = (ushort)(_loopState.Subdivision - 1);
		if (next == 0) {
			_loopState.SetSubdivision(SubdivisionsPerMeasure);
			_loopState.SetMeasure((ushort)(_loopState.Measure + 1));
			return true;
		}
		_loopState.SetSubdivision(next);
		return false;
	}
}