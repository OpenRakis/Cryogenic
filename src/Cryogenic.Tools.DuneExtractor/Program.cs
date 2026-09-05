using System;
using System.IO;

DuneExtractor.DuneExtractor.Print_Welcome();
if (args.Length != 1) {
	Console.WriteLine($"FATAL Error: too much or not enough arguments.{Environment.NewLine}");
	DuneExtractor.DuneExtractor.Print_Help();
} else {
	string inputFile = Path.GetFullPath(args[0]);
	if (File.Exists(inputFile)) {
		DuneExtractor.DuneExtractor.ExtractDuneDatFile(inputFile);
	} else {
		Console.WriteLine($"FATAL ERROR: {inputFile} file not exist !{Environment.NewLine}");
	}
}
Console.WriteLine($"{Environment.NewLine}Press Enter to exit.");
Console.Read();