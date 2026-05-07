namespace Cryogenic.Symbols;

using System.Collections.Generic;
using System.IO;
using System.Reflection;

/// <summary>
/// Builds an <see cref="ILstSymbolTable"/> from the DNCDPRG.lst file that is embedded
/// as a resource inside the Cryogenic assembly.
/// </summary>
/// <remarks>
/// <para>
/// The factory reads the listing once at startup and delegates parsing to an
/// <see cref="ILstSymbolParser"/> implementation, following the Inversion-of-Control
/// principle so the parser can be swapped or mocked in tests.
/// </para>
/// <para>
/// When the embedded resource is missing the factory returns an empty table rather than
/// throwing, so the MCP tools degrade gracefully when run against a stripped build.
/// </para>
/// </remarks>
public sealed class LstSymbolTableFactory {
	private const string ResourceName = "Cryogenic.DNCDPRG.lst";

	private readonly ILstSymbolParser _parser;

	/// <summary>
	/// Initializes a new factory that will use the supplied parser.
	/// </summary>
	/// <param name="parser">Parser responsible for converting listing lines into symbols.</param>
	public LstSymbolTableFactory(ILstSymbolParser parser) {
		_parser = parser;
	}

	/// <summary>
	/// Reads the embedded DNCDPRG.lst resource and returns a populated symbol table.
	/// </summary>
	/// <returns>
	/// A fully populated <see cref="ILstSymbolTable"/> when the resource is present,
	/// or an empty table when the resource cannot be located.
	/// </returns>
	public ILstSymbolTable Build() {
		Assembly assembly = typeof(LstSymbolTableFactory).Assembly;
		using Stream? stream = assembly.GetManifestResourceStream(ResourceName);
		if (stream is null) {
			return new LstSymbolTable(new List<LstSymbol>());
		}

		using StreamReader reader = new(stream);
		IEnumerable<string> lines = ReadLines(reader);
		IReadOnlyList<LstSymbol> symbols = _parser.Parse(lines);
		return new LstSymbolTable(symbols);
	}

	private static IEnumerable<string> ReadLines(StreamReader reader) {
		while (!reader.EndOfStream) {
			string? line = reader.ReadLine();
			if (line is not null) {
				yield return line;
			}
		}
	}
}