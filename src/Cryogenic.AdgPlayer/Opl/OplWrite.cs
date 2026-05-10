namespace Cryogenic.AdgPlayer.Opl;

/// <summary>
/// A single OPL3 register write captured by an <see cref="IOplBus"/>
/// implementation. <see cref="Chip"/> selects the primary (0) or secondary
/// (1) OPL3 chip; AdLib Gold uses both for surround panning.
/// </summary>
public readonly record struct OplWrite(int Chip, byte Register, byte Value);