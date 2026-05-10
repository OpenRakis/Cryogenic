namespace Cryogenic.AdgPlayer.Song;

using System;

/// <summary>
/// Thrown when a buffer presented as HSQ-compressed fails the
/// 6-byte header signature check.
/// </summary>
public sealed class InvalidHsqStreamException : Exception {
	/// <summary>Builds an exception with the supplied message.</summary>
	public InvalidHsqStreamException(string message) : base(message) {
	}

	/// <summary>Builds an exception with a message and inner exception.</summary>
	public InvalidHsqStreamException(string message, Exception inner) : base(message, inner) {
	}
}
