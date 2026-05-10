namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Two-byte master/current volume cell mirroring the
/// <c>AdgMasterVolumeOffset</c>/<c>AdgCurrentVolumeOffset</c> bytes
/// inside the song state. <see cref="SetMaster"/> writes both bytes
/// (matches dnadg:066C) so the next <c>RestoreCurrentFromMaster</c>
/// call (post fade) snaps current back to the program-set level.
/// </summary>
public sealed class AdgMasterVolume {
	/// <summary>Configured master volume.</summary>
	public byte Master { get; private set; }

	/// <summary>Live current volume (after fades / modulations).</summary>
	public byte Current { get; private set; }

	/// <summary>Sets master and synchronises current to the same byte.</summary>
	public void SetMaster(byte value) {
		Master = value;
		Current = value;
	}

	/// <summary>Updates the live current volume only.</summary>
	public void SetCurrent(byte value) {
		Current = value;
	}

	/// <summary>Copies the master volume back into the current cell.</summary>
	public void RestoreCurrentFromMaster() {
		Current = Master;
	}
}