namespace Cryogenic.AdgPlayer.Ui.Audio;

/// <summary>
/// Immutable snapshot of one ring-buffer bucket: instantaneous peak
/// amplitude per channel plus the slow-decay peak-hold value.
/// </summary>
public readonly record struct WaveformBucket(float Left, float Right, float LeftPeak, float RightPeak);