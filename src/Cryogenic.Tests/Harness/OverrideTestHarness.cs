namespace Cryogenic.Tests.Harness;

/// <summary>
/// Lightweight in-memory CPU state and flat-memory simulation for testing override
/// pure-logic helpers without requiring a live Spice86 Machine instance.
/// </summary>
/// <remarks>
/// Override methods read CPU registers and access Machine memory through Spice86 primitives;
/// integration-level verification of complete override behaviour requires running the game
/// under Spice86. This harness enables fast, isolated unit tests for logic extracted from
/// override methods into standalone helpers such as
/// <see cref="Cryogenic.OverrideLogic.DataStructureLogic"/>.
/// One fresh instance is created per Reqnroll scenario by the built-in Reqnroll IoC container
/// and shared across all step-definition classes that participate in that scenario.
/// </remarks>
public sealed class OverrideTestHarness {

	private readonly byte[] _memory = new byte[0x100000];

	/// <summary>Accumulator register (AX, 16-bit).</summary>
	public ushort AX { get; set; }

	/// <summary>Base register (BX, 16-bit).</summary>
	public ushort BX { get; set; }

	/// <summary>Count register (CX, 16-bit).</summary>
	public ushort CX { get; set; }

	/// <summary>Data register (DX, 16-bit).</summary>
	public ushort DX { get; set; }

	/// <summary>Source index register (SI, 16-bit).</summary>
	public ushort SI { get; set; }

	/// <summary>Destination index register (DI, 16-bit).</summary>
	public ushort DI { get; set; }

	/// <summary>Base pointer register (BP, 16-bit).</summary>
	public ushort BP { get; set; }

	/// <summary>Stack pointer register (SP, 16-bit).</summary>
	public ushort SP { get; set; }

	/// <summary>Code segment register (CS, 16-bit).</summary>
	public ushort CS { get; set; }

	/// <summary>Data segment register (DS, 16-bit).</summary>
	public ushort DS { get; set; }

	/// <summary>Extra segment register (ES, 16-bit).</summary>
	public ushort ES { get; set; }

	/// <summary>Stack segment register (SS, 16-bit).</summary>
	public ushort SS { get; set; }

	/// <summary>Carry flag (CF).</summary>
	public bool CarryFlag { get; set; }

	/// <summary>Zero flag (ZF).</summary>
	public bool ZeroFlag { get; set; }

	/// <summary>Sign flag (SF).</summary>
	public bool SignFlag { get; set; }

	/// <summary>Overflow flag (OF).</summary>
	public bool OverflowFlag { get; set; }

	/// <summary>Parity flag (PF).</summary>
	public bool ParityFlag { get; set; }

	/// <summary>Direction flag (DF), controls string-operation direction.</summary>
	public bool DirectionFlag { get; set; }

	/// <summary>
	/// Computes a linear (physical) address from a segment:offset pair using the
	/// real-mode formula <c>segment × 16 + offset</c>.
	/// </summary>
	/// <param name="segment">16-bit segment register value.</param>
	/// <param name="offset">16-bit intra-segment offset.</param>
	/// <returns>The 20-bit physical address.</returns>
	public static uint LinearAddress(ushort segment, ushort offset) =>
		(uint)(segment * 16 + offset);

	/// <summary>Writes a 16-bit word at the given segment:offset address (little-endian).</summary>
	public void SetMemWord(ushort segment, ushort offset, ushort value) {
		uint addr = LinearAddress(segment, offset);
		_memory[addr] = (byte)(value & 0xFF);
		_memory[addr + 1] = (byte)(value >> 8);
	}

	/// <summary>Reads a 16-bit word from the given segment:offset address (little-endian).</summary>
	public ushort GetMemWord(ushort segment, ushort offset) {
		uint addr = LinearAddress(segment, offset);
		return (ushort)(_memory[addr] | (_memory[addr + 1] << 8));
	}

	/// <summary>Writes a byte at the given segment:offset address.</summary>
	public void SetMemByte(ushort segment, ushort offset, byte value) =>
		_memory[LinearAddress(segment, offset)] = value;

	/// <summary>Reads a byte from the given segment:offset address.</summary>
	public byte GetMemByte(ushort segment, ushort offset) =>
		_memory[LinearAddress(segment, offset)];

	/// <summary>
	/// Writes a flat array of 16-bit words into physical memory at the given linear address.
	/// Words are stored in little-endian order at consecutive even offsets.
	/// </summary>
	/// <param name="linearAddress">Physical start address.</param>
	/// <param name="words">Words to write, in order.</param>
	public void SetWordTable(uint linearAddress, ushort[] words) {
		for (int i = 0; i < words.Length; i++) {
			_memory[linearAddress + (uint)(i * 2)] = (byte)(words[i] & 0xFF);
			_memory[linearAddress + (uint)(i * 2) + 1] = (byte)(words[i] >> 8);
		}
	}

	/// <summary>
	/// Reads a flat array of 16-bit words from physical memory at the given linear address.
	/// </summary>
	/// <param name="linearAddress">Physical start address.</param>
	/// <param name="count">Number of words to read.</param>
	/// <returns>Array of consecutive 16-bit words read from memory.</returns>
	public ushort[] GetWordTable(uint linearAddress, int count) {
		ushort[] result = new ushort[count];
		for (int i = 0; i < count; i++) {
			result[i] = (ushort)(
				_memory[linearAddress + (uint)(i * 2)] |
				(_memory[linearAddress + (uint)(i * 2) + 1] << 8));
		}
		return result;
	}

	/// <summary>Resets all registers, flags, and the full 1 MB memory space to zero.</summary>
	public void Reset() {
		AX = BX = CX = DX = SI = DI = BP = SP = 0;
		CS = DS = ES = SS = 0;
		CarryFlag = ZeroFlag = SignFlag = OverflowFlag = ParityFlag = DirectionFlag = false;
		Array.Clear(_memory, 0, _memory.Length);
	}
}
