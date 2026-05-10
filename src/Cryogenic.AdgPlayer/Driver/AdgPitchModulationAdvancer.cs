namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure port of <c>AdgAdvancePitchModulation_07AD</c>
/// (oracle <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>,
/// dnadg:07AD). Called once per active-but-still-waiting channel
/// during the scheduler tick to advance the per-channel pitch
/// accumulator and request a pitch-bend register emit.
/// </summary>
/// <remarks>
/// Original behaviour:
/// <code>
/// dnadg:07AD  cmp byte ptr [DI+0xB4],0   ; pitch bend counter
/// dnadg:07B2  je return
/// dnadg:07B4  mov SI,[DI+0x24]           ; event pointer
/// dnadg:07B7  or SI,SI / je return
/// dnadg:07BD  dec byte ptr [DI+0xB4]     ; counter--
/// dnadg:07C1  mov AX,[DI+0xD8]           ; AL=accumulator, AH=step
/// dnadg:07C5  add AL,AH
/// dnadg:07C7  mov [DI+0xD8],AL
/// dnadg:07CB  mov DX,DI / sub DX,0x01E2 / shr DX,1
/// dnadg:07D3  call 0D8B                  ; AdgPitchBendBody_0D8B(AX)
/// </code>
/// </remarks>
public static class AdgPitchModulationAdvancer {
	/// <summary>
	/// Advances the per-channel pitch accumulator and dispatches to
	/// <paramref name="pitchBendBody"/>. Returns <c>true</c> when
	/// the body was invoked (channel was eligible); <c>false</c>
	/// when one of the early-return guards fired (counter==0 or
	/// event pointer==0).
	/// </summary>
	public static bool Advance(
		int channelIndex,
		AdgChannelPitchBendCounters pitchBendCounters,
		AdgChannelEventPointers eventPointers,
		AdgChannelPitchAccumulators pitchAccumulators,
		AdgChannelPitchAccumulatorSteps pitchAccumulatorSteps,
		IAdgPitchBendBody pitchBendBody) {
		ArgumentNullException.ThrowIfNull(pitchBendCounters);
		ArgumentNullException.ThrowIfNull(eventPointers);
		ArgumentNullException.ThrowIfNull(pitchAccumulators);
		ArgumentNullException.ThrowIfNull(pitchAccumulatorSteps);
		ArgumentNullException.ThrowIfNull(pitchBendBody);

		byte counter = pitchBendCounters.Get(channelIndex);
		if (counter == 0) {
			return false;
		}
		if (eventPointers.Get(channelIndex) == 0) {
			return false;
		}

		pitchBendCounters.Set(channelIndex, (byte)(counter - 1));

		byte value = pitchAccumulators.Get(channelIndex);
		byte step = pitchAccumulatorSteps.Get(channelIndex);
		byte newValue = (byte)(value + step);
		pitchAccumulators.Set(channelIndex, newValue);

		ushort bendWord = (ushort)(newValue | (step << 8));
		pitchBendBody.Emit(channelIndex, bendWord);
		return true;
	}
}
