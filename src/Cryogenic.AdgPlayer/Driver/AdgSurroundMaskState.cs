namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Mutable holder for the global AdLib Gold surround-mask byte
/// (<c>AdgSurroundMaskOffset</c> in the original driver). Default
/// state has every surround group enabled (0xFF).
/// </summary>
public sealed class AdgSurroundMaskState {
	private const byte DefaultMask = 0xFF;
	private byte _mask = DefaultMask;

	/// <summary>Current surround mask byte.</summary>
	public byte Mask => _mask;

	/// <summary>Replaces the mask with <paramref name="value"/>.</summary>
	public void SetMask(byte value) {
		_mask = value;
	}

	/// <summary>Restores the mask to its default 0xFF value.</summary>
	public void Reset() {
		_mask = DefaultMask;
	}
}