namespace DuneExtractor;

using Microsoft.VisualBasic.CompilerServices;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

internal class DuneExtractor {
	internal static void Print_Welcome() {
		Console.WriteLine("Unofficial Dune (PC VERSION) Extractor V1.0");
		Console.WriteLine($"Tgames (c) 2019{Environment.NewLine}");
	}

	internal static void Print_Help() {
		Console.WriteLine("Usage : DuneExtractor.exe DUNE.DAT");
		Console.WriteLine("Write the full path to the DUNE.DAT.");
		Console.WriteLine("It will creates a folder with all files extracted.");
	}

	private static string UnicodeBytesToString(byte[] bytes) => Encoding.UTF8.GetString(bytes);

	private static int UnicodeBytesToInteger(byte[] bytes) => BitConverter.ToInt32(bytes, 0);

	public static byte[] ReadData(FileStream DatFile, int size) {
		int index = 0;
		byte[] numArray = new byte[size + 1];
		while (index < DatFile.Length & index < size) {
			numArray[index] = (byte)DatFile.ReadByte();
			++index;
		}
		return numArray;
	}

	public static byte[] ReadDataFileName(FileStream DatFile, int size) {
		int index = 0;
		int newSize = 0;
		byte[] array = new byte[size + 1];
		while (index < DatFile.Length & index < size) {
			byte num = (byte)DatFile.ReadByte();
			if (num > 0) {
				array[index] = num;
				++newSize;
			}
			++index;
		}
		Array.Resize(ref array, newSize);
		return array;
	}

	public static void ReadDatFileSectionHeader(FileStream DatFile, DataSection section) {
		section.NameOfFile = UnicodeBytesToString(DuneExtractor.ReadDataFileName(DatFile, 16));
		section.SizeOfFile = UnicodeBytesToInteger(DuneExtractor.ReadData(DatFile, 4));
		section.OffsetOfFile = UnicodeBytesToInteger(DuneExtractor.ReadData(DatFile, 4));
	}

	private static void WriteDataSectionToDisk(Span<byte> dataInMemory, string outFolder, string outFile, int offset, int size) {
		if (!Directory.Exists(outFolder)) {
			Directory.CreateDirectory(outFolder);
		}
		if (File.Exists(outFile)) {
			File.Delete(outFile);
		}

		string targetPath = Path.Combine(outFolder, outFile);
		if (!Directory.Exists(Path.GetDirectoryName(targetPath))) {
			Directory.CreateDirectory(Path.GetDirectoryName(targetPath));
		}
		File.WriteAllBytes(targetPath, dataInMemory.Slice(offset, size).ToArray());
		Console.WriteLine($"Extracted to {targetPath}");
		Console.WriteLine("");
	}

	public static void ExtractDuneDatFile(string inputFile) {
		Console.WriteLine($"[STARTING] Extraction of the DAT file has started...{Environment.NewLine}");
		var dataInMemory = File.ReadAllBytes(inputFile).AsSpan();
		using FileStream datafile = new FileStream(inputFile, FileMode.Open);
		datafile.Seek(0L, SeekOrigin.Begin);
		Console.WriteLine($"[STEP 1] Reading DatFile header... PLEASE WAIT{Environment.NewLine}");
		byte[] numArray2 = new byte[2] { 61, 10 };
		byte[] numArray3 = ReadData(datafile, 2);
		if (numArray3[0] == numArray2[0] & numArray3[1] == numArray2[1]) {
			Console.WriteLine($"Cryo DatFile Detected... {Environment.NewLine}");
			Console.WriteLine($"[STEP 2] Extracting each files... PLEASE WAIT{Environment.NewLine}");
			var dataList = new List<DataSection>();
			int index = 0;
			do {
				DataSection section = new DataSection();
				ReadDatFileSectionHeader(datafile, section);
				if ((uint)Operators.CompareString(section.NameOfFile, "", false) > 0U) {
					dataList.Add(section);
					datafile.ReadByte();
				} else
					break;
			}
			while (index < dataList[0].OffsetOfFile);
			var outputFolder = $"{Path.GetFileName(inputFile)}_";
			for (int i = 0; i < dataList.Count; i++) {
				DataSection dataSection = dataList[i];
				Console.WriteLine($"Extracting... {dataSection.NameOfFile} ({Math.Round(dataSection.SizeOfFile / 1024.0, 2)} KB)");
				WriteDataSectionToDisk(dataInMemory, outputFolder, dataSection.NameOfFile, dataSection.OffsetOfFile, dataSection.SizeOfFile);
			}
			Console.WriteLine($"{Environment.NewLine}[DONE] Extraction finished !{Environment.NewLine}");
		} else {
			Console.WriteLine($"FATAL ERROR: {inputFile} is not a valid Cryo DatFile !{Environment.NewLine}");
		}
		datafile.Close();
	}
}