namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Mutable per-channel cache of the last A0/B0 frequency word emitted
/// by <see cref="AdgNoteOnEmitter"/>. The cached value retains the
/// channel's current octave and frequency low byte but with the key-on
/// bit cleared, so that <see cref="AdgNoteOffEmitter"/> can re-issue
/// the same A0/B0 pair to release the note. Mirrors the cache stored
/// at <c>AdgFrequencyWordTableOffset</c> in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// </summary>
public sealed class AdgFrequencyWordCache {
	/// <summary>Number of logical channels (matches
	/// <see cref="AdgChannelResetEmitter.ChannelCount"/>).</summary>
	public const int ChannelCount = 18;

	private readonly ushort[] _frequencyWords = new ushort[ChannelCount];

	/// <summary>Returns the cached frequency word for
	/// <paramref name="channelIndex"/>.</summary>
	public ushort Get(int channelIndex) {
		EnsureChannelIndex(channelIndex);
		return _frequencyWords[channelIndex];
	}

	/// <summary>Stores <paramref name="value"/> as the cached frequency
	/// word for <paramref name="channelIndex"/>.</summary>
	public void Set(int channelIndex, ushort value) {
		EnsureChannelIndex(channelIndex);
		_frequencyWords[channelIndex] = value;
	}

	/// <summary>Clears every cached entry to zero.</summary>
	public void Reset() {
		Array.Clear(_frequencyWords);
	}

	/// <summary>
	/// Returns the underlying 18-entry array for legacy consumers that
	/// still take a raw <see cref="ushort"/> array (for example
	/// <see cref="AdgNoteOnEmitter.Emit"/>). Mutations through the
	/// returned reference are visible via <see cref="Get"/>.
	/// </summary>
	internal ushort[] AsArray() {
		return _frequencyWords;
	}

	private static void EnsureChannelIndex(int channelIndex) {
		if (channelIndex < 0 || channelIndex >= ChannelCount) {
			throw new ArgumentOutOfRangeException(nameof(channelIndex));
		}
	}
}