namespace Cryogenic.AdgPlayer.Tests.Driver;

using Cryogenic.AdgPlayer.Driver;

using System.IO;

/// <summary>
/// Phase 3 — Driver image loading.
/// <see cref="AdgDriverImage"/> wraps the decompressed DNADG.UNHSQ bytes and
/// exposes typed accessors for offsets matching the runtime segment layout
/// documented in <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>.
/// File offset == segment offset for Cryo audio drivers (loaded as raw blobs
/// by DriverLoadToolbox, no DOS PSP prefix).
/// </summary>
public sealed class AdgDriverImageTests {
	private static readonly string DnadgUnhsq = Path.GetFullPath(Path.Combine(
		AppContext.BaseDirectory, "..", "..", "..", "..", "..",
		"doc", "DUNECDVF", "C", "DUNECD", "DUNE.DAT_", "DNADG.UNHSQ"));

	[Fact]
	public void FromFile_LoadsDnadgImageWithExpectedSize() {
		// Arrange
		Assert.True(File.Exists(DnadgUnhsq), $"Missing test asset: {DnadgUnhsq}");

		// Act
		AdgDriverImage image = AdgDriverImage.FromFile(DnadgUnhsq);

		// Assert
		Assert.Equal(4374, image.Length);
	}

	[Fact]
	public void ReadByte_AtZero_IsNearJumpOpcode() {
		// Arrange — DNADG starts with a Cryo driver function-jump table.
		// First entry at offset 0 is `E9 FC 03` (JMP near +0x03FC).
		AdgDriverImage image = AdgDriverImage.FromFile(DnadgUnhsq);

		// Act
		byte opcode = image.ReadByte(0x0000);

		// Assert
		Assert.Equal((byte)0xE9, opcode);
	}

	[Fact]
	public void ReadWord_AfterJumpOpcode_ReturnsRelativeDisplacement() {
		// Arrange — the 16-bit operand of the first JMP is at file offset 0x0001
		// and equals 0x03FC (little-endian: FC 03).
		AdgDriverImage image = AdgDriverImage.FromFile(DnadgUnhsq);

		// Act
		ushort displacement = image.ReadWord(0x0001);

		// Assert
		Assert.Equal((ushort)0x03FC, displacement);
	}

	[Fact]
	public void ReadByte_FunctionTable_HasSevenJumpEntries() {
		// Arrange — the function table has 7 `E9 ?? ??` entries at offsets
		// 0x00, 0x03, 0x06, 0x09, 0x0C, 0x0F, 0x12. Offset 0x15 is no longer
		// a jump (begins a separate data section, byte 0x88).
		AdgDriverImage image = AdgDriverImage.FromFile(DnadgUnhsq);

		// Act + Assert
		for (int i = 0; i < 7; i++) {
			byte op = image.ReadByte(i * 3);
			Assert.Equal((byte)0xE9, op);
		}
		Assert.NotEqual((byte)0xE9, image.ReadByte(7 * 3));
	}

	[Fact]
	public void ReadByte_OutOfRange_Throws() {
		// Arrange
		AdgDriverImage image = AdgDriverImage.FromFile(DnadgUnhsq);

		// Act + Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => image.ReadByte(image.Length));
	}

	[Fact]
	public void ReadWord_OutOfRange_Throws() {
		// Arrange — a word read needs two bytes; last valid offset is Length-2.
		AdgDriverImage image = AdgDriverImage.FromFile(DnadgUnhsq);

		// Act + Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => image.ReadWord(image.Length - 1));
	}
}