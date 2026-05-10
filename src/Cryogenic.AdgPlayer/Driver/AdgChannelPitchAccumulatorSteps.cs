namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// 18-slot byte table holding the per-channel pitch-accumulator
/// step value. Mirrors the byte at
/// <c>AdgChannelPitchAccumulatorOffset + 1</c> (DI+0xD9) in the
/// original DNADG driver. The pair (step:value) is read as a single
/// little-endian word in <c>AdgAdvancePitchModulation_07AD</c>:
/// <code>
/// mov AX,[DI+0xD8]   ; AL = accumulator value, AH = step
/// add AL,AH          ; advance accumulator by step (8-bit wrap)
/// mov [DI+0xD8],AL   ; store new value (step preserved)
/// </code>
/// This component owns the AH byte; <see cref="AdgChannelPitchAccumulators"/>
/// owns the AL byte.
/// </summary>
public sealed class AdgChannelPitchAccumulatorSteps {
	/// <summary>Number of channel slots in the table.</summary>
	public const int ChannelCount = 18;

	private readonly byte[] _slots = new byte[ChannelCount];

	/// <summary>Reads the step byte for <paramref name="channelIndex"/>.</summary>
	public byte Get(int channelIndex) {
		Validate(channelIndex);
		return _slots[channelIndex];
	}

	/// <summary>Writes the step byte for <paramref name="channelIndex"/>.</summary>
	public void Set(int channelIndex, byte value) {
		Validate(channelIndex);
		_slots[channelIndex] = value;
	}

	/// <summary>Resets every channel slot to zero.</summary>
	public void Reset() {
		Array.Clear(_slots);
	}

	private static void Validate(int channelIndex) {
		if (channelIndex < 0 || channelIndex >= ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(channelIndex),
				channelIndex, "Channel index must be within [0,18).");
		}
	}
}
