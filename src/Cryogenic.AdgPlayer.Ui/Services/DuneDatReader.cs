namespace Cryogenic.AdgPlayer.Ui.Services;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/// <summary>
/// In-memory reader for Cryo's DUNE.DAT archive format.
/// Header table layout:
///   2 bytes signature (0x3D 0x0A)
///   then repeated entries until first data offset is reached:
///     16 bytes name (null-filtered),
///     4 bytes size (Int32 LE),
///     4 bytes offset (Int32 LE),
///     1 byte separator.
/// Mirrors the parsing logic of <c>Cryogenic.Tools.DuneExtractor</c>
/// but never writes anything to disk.
/// </summary>
public sealed class DuneDatReader
{
    /// <summary>One parsed entry from a DUNE.DAT archive.</summary>
    public sealed class DatEntry
    {
        public required string Name { get; init; }
        public required int Offset { get; init; }
        public required int Size { get; init; }
    }

    private readonly byte[] _bytes;
    private readonly List<DatEntry> _entries;
    private readonly Dictionary<string, DatEntry> _byName;

    /// <summary>Parses the whole archive header table from <paramref name="datBytes"/>.</summary>
    public DuneDatReader(byte[] datBytes)
    {
        ArgumentNullException.ThrowIfNull(datBytes);
        if (datBytes.Length < 32)
        {
            throw new InvalidDataException("DUNE.DAT too small to contain a header.");
        }
        if (datBytes[0] != 0x3D || datBytes[1] != 0x0A)
        {
            throw new InvalidDataException("Not a Cryo DAT file: signature mismatch.");
        }

        _bytes = datBytes;
        _entries = new List<DatEntry>();
        _byName = new Dictionary<string, DatEntry>(StringComparer.OrdinalIgnoreCase);

        int index = 2;
        int firstOffset = -1;
        while (true)
        {
            if (index + 25 > datBytes.Length)
            {
                break;
            }

            string name = ReadFilteredName(datBytes, index, 16);
            if (string.IsNullOrEmpty(name))
            {
                break;
            }

            int size = BitConverter.ToInt32(datBytes, index + 16);
            int offset = BitConverter.ToInt32(datBytes, index + 20);
            index += 25;

            if (size < 0 || offset < 0 || offset + size > datBytes.Length)
            {
                break;
            }

            if (firstOffset < 0)
            {
                firstOffset = offset;
            }

            DatEntry entry = new DatEntry { Name = name, Offset = offset, Size = size };
            _entries.Add(entry);
            _byName[name] = entry;

            if (index >= firstOffset)
            {
                break;
            }
        }
    }

    /// <summary>All entries in declaration order.</summary>
    public IReadOnlyList<DatEntry> Entries => _entries;

    /// <summary>True if an entry with that exact name exists.</summary>
    public bool Contains(string name) => _byName.ContainsKey(name);

    /// <summary>
    /// Returns a fresh copy of the bytes for <paramref name="entry"/>.
    /// The caller owns the returned array.
    /// </summary>
    public byte[] ReadEntryBytes(DatEntry entry)
    {
        ArgumentNullException.ThrowIfNull(entry);
        byte[] copy = new byte[entry.Size];
        Buffer.BlockCopy(_bytes, entry.Offset, copy, 0, entry.Size);
        return copy;
    }

    private static string ReadFilteredName(byte[] source, int start, int length)
    {
        Span<byte> buffer = stackalloc byte[length];
        int written = 0;
        for (int i = 0; i < length; i++)
        {
            byte b = source[start + i];
            if (b > 0)
            {
                buffer[written++] = b;
            }
        }
        return Encoding.UTF8.GetString(buffer.Slice(0, written));
    }
}
