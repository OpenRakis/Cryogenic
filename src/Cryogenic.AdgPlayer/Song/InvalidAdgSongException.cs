namespace Cryogenic.AdgPlayer.Song;

using System;

/// <summary>
/// Thrown when a song image fails ADG/ADP layout invariants
/// (header too short, channel offset out of range, etc.).
/// </summary>
public sealed class InvalidAdgSongException : Exception {
	/// <summary>Builds an exception with the supplied message.</summary>
	public InvalidAdgSongException(string message) : base(message) {
	}

	/// <summary>Builds an exception with a message and inner exception.</summary>
	public InvalidAdgSongException(string message, Exception inner) : base(message, inner) {
	}
}
