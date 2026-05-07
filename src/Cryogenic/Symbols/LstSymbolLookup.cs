namespace Cryogenic.Symbols;

/// <summary>
/// Result of an address-based symbol lookup against an <see cref="ILstSymbolTable"/>.
/// </summary>
/// <remarks>
/// Callers must inspect <see cref="Found"/> before reading <see cref="Symbol"/>.
/// When <see cref="Found"/> is <c>false</c>, <see cref="Symbol"/> is a non-null placeholder
/// populated with empty values; this avoids exposing a nullable reference.
/// </remarks>
public sealed record LstSymbolLookup {
	/// <summary>Gets whether a symbol was recorded at the queried address.</summary>
	public required bool Found { get; init; }

	/// <summary>
	/// Gets the matched symbol when <see cref="Found"/> is <c>true</c>;
	/// otherwise an empty placeholder whose fields must not be relied upon.
	/// </summary>
	public required LstSymbol Symbol { get; init; }
}
