using System.Buffers.Binary;

if (args.Length < 1) {
	Console.WriteLine("Specify at least one file");
	return;
}
foreach (var file in args) {
	//The following is from HSQ.H

	var fullFilePath = Path.GetFullPath(file);
	var fileInfo = new FileInfo(fullFilePath);
	var outFile = Path.Combine(Path.GetDirectoryName(fullFilePath), $"{Path.GetFileNameWithoutExtension(file)}.UNHSQ");
	using var stream = File.OpenRead(fullFilePath);

	int unpackedLength = ReadUInt16LE(stream);
	stream.ReadByte();
	int packedLength = ReadUInt16LE(stream);
	stream.ReadByte();
	if (fileInfo.Length != packedLength) {
		throw new InvalidDataException($"cannot apply UNHSQ algorithm on this file: {file}. Aborted.");
	}
	int[] unpackedBuf = new int[unpackedLength];

	DecompressHSQ(stream, unpackedBuf, unpackedLength);

	await File.WriteAllBytesAsync(outFile, unpackedBuf.Select(x => (byte)x).ToArray());
	Console.WriteLine($"File {file} uncompressed to {outFile}");
}

static ushort ReadUInt16LE(Stream stream) {
	var uintBuffer = new byte[2];
	uintBuffer[0] = (byte)stream.ReadByte();
	uintBuffer[1] = (byte)stream.ReadByte();
	var returnValue = BinaryPrimitives.ReadUInt16LittleEndian(uintBuffer);
	return returnValue;
}

byte DecompressHSQGetBit(ref ushort queue, Stream src) {
	byte bit;

	bit = (byte)(queue & 1);
	queue >>= 1;

	if (queue == 0) {
		queue = ReadUInt16LE(src);
		bit = (byte)(queue & 1);
		queue = (ushort)(0x8000 | (queue >> 1));
	}

	return bit;
}

void DecompressHSQ(FileStream src, int[] buf, int unpackedLength) {
	ushort queue = 0;
	int dst = 0;

	for (; ; )
	{
		if (DecompressHSQGetBit(ref queue, src) != 0) {
			if (!(dst < unpackedLength)) {
				throw new InvalidDataException($"cannot apply UNHSQ algorithm on this file: {src.Name}. Aborted.");

			}
			buf[dst++] = src.ReadByte();
		} else {
			int count;
			int offset;

			if (DecompressHSQGetBit(ref queue, src) != 0) {
				ushort word = ReadUInt16LE(src);

				count = word & 0x07;
				offset = (word >> 3) - 8192;
				if (count == 0) {
					count = src.ReadByte();
				}
				if (count == 0) {
					break;
				}
			} else {
				byte b0 = DecompressHSQGetBit(ref queue, src);
				byte b1 = DecompressHSQGetBit(ref queue, src);

				count = 2 * b0 + b1;
				offset = src.ReadByte() - 256;
			}
			if (!(dst + count + 2 < unpackedLength)) {
				throw new InvalidDataException($"cannot apply UNHSQ algorithm on this file: {src.Name}. Aborted.");
			}
			for (int i = 0; i != count + 2; ++i) {
				buf[dst + i] = buf[dst + i + offset];
			}
			dst += count + 2;
		}
	}
}