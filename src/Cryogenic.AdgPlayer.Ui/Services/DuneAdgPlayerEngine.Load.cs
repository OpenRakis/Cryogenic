namespace Cryogenic.AdgPlayer.Ui.Services;

using System;

/// <summary>
/// Song loading, header parsing, and static metadata extraction for the DNADG engine.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
    /// <summary>
    /// Loads a song from file, applying HSQ decompression if detected.
    /// </summary>
    public void LoadSong(byte[] fileData) {
        bool wasCompressed = false;
        byte[]? decompressed = TryDecompressHsq(fileData);
        byte[] data;
        if (decompressed != null) {
            data = decompressed;
            wasCompressed = true;
        } else {
            data = fileData;
        }
        lock (_lock) {
            bool wasPlaying = _playing;
            if (wasPlaying) {
                StopInternal();
            }

            _songData = data;
            _dataBase = 2;
            _eventBase = SongWord(0);

            HeaderInfo = ParseSongHeader(data, _dataBase, _eventBase, wasCompressed);

            Logger.Information("Song loaded: {Length} bytes, dataBase={DataBase}, eventBase=0x{EventBase:X4}",
                _songData.Length, _dataBase, _eventBase);
        }
    }

    /// <summary>
    /// Parses song header metadata for UI display.
    /// </summary>
    private SongHeaderInfo ParseSongHeader(byte[] data, int dataBase, int eventBase, bool wasCompressed) {
        SongHeaderInfo info = new SongHeaderInfo {
            RawFileSize = data.Length,
            WasHsqCompressed = wasCompressed,
            DataBase = dataBase,
            EventBase = eventBase,
            InstrumentCount = eventBase > dataBase + 0x32 ? (data.Length - eventBase) / 0x28 : 0
        };

        if (data.Length >= dataBase + 0x32) {
            info.Tempo = SongWord(dataBase + 0x30);
            info.LoopStartMeasure = SongWord(dataBase + 0x2A);
            info.LoopEndMeasure = SongWord(dataBase + 0x2C);
            info.LoopCount = SongWord(dataBase + 0x2E);

            int channelSlotsToParse = Math.Min(SongHeaderChannelCount, info.ChannelOffsets.Length);
            for (int i = 0; i < channelSlotsToParse; i++) {
                ushort relative = SongWord(dataBase + i * 2);
                info.ChannelOffsets[i] = relative;
                info.ChannelActive[i] = relative != 0;
            }
        }

        int activeChannels = 0;
        for (int i = 0; i < info.ChannelActive.Length; i++) {
            if (info.ChannelActive[i]) {
                activeChannels++;
            }
        }
        info.ActiveChannelCount = activeChannels;

        Logger.Information("Header: tempo=0x{Tempo:X4}, {ActiveCh} active channels, {InstCount} instruments, loop={LoopStart}-{LoopEnd}x{LoopCount}",
            info.Tempo, activeChannels, info.InstrumentCount, info.LoopStartMeasure, info.LoopEndMeasure, info.LoopCount);

        return info;
    }

    /// <summary>
    /// Extracts song header info from raw file data without loading the full song.
    /// Handles both HSQ-compressed and raw ADG data.
    /// </summary>
    public static bool TryExtractHeaderInfo(byte[] fileData, out SongHeaderInfo? headerInfo) {
        headerInfo = null;
        bool wasCompressed = false;
        byte[] data = fileData;

        byte[]? decompressed = TryDecompressHsq(fileData);
        if (decompressed != null) {
            data = decompressed;
            wasCompressed = true;
        }

        int dataBase = 2;
        int eventBase = (ushort)(data[0] | (data[1] << 8));

        SongHeaderInfo info = new SongHeaderInfo {
            RawFileSize = data.Length,
            WasHsqCompressed = wasCompressed,
            DataBase = dataBase,
            EventBase = eventBase,
            InstrumentCount = eventBase > dataBase + 0x32 ? (data.Length - eventBase) / 0x28 : 0
        };

        if (data.Length >= dataBase + 0x32) {
            info.Tempo = (ushort)(data[dataBase + 0x30] | (data[dataBase + 0x31] << 8));
            info.LoopStartMeasure = (ushort)(data[dataBase + 0x2A] | (data[dataBase + 0x2B] << 8));
            info.LoopEndMeasure = (ushort)(data[dataBase + 0x2C] | (data[dataBase + 0x2D] << 8));
            info.LoopCount = (ushort)(data[dataBase + 0x2E] | (data[dataBase + 0x2F] << 8));

            int channelSlotsToParse = Math.Min(SongHeaderChannelCount, info.ChannelOffsets.Length);
            for (int i = 0; i < channelSlotsToParse; i++) {
                ushort relative = (ushort)(data[dataBase + i * 2] | (data[dataBase + i * 2 + 1] << 8));
                info.ChannelOffsets[i] = relative;
                info.ChannelActive[i] = relative != 0;
            }
        }

        int activeChannels = 0;
        for (int i = 0; i < info.ChannelActive.Length; i++) {
            if (info.ChannelActive[i]) {
                activeChannels++;
            }
        }
        info.ActiveChannelCount = activeChannels;

        headerInfo = info;
        return true;
    }
}

/// <summary>
/// Parsed song header metadata for display.
/// </summary>
public sealed class SongHeaderInfo {
    public int RawFileSize { get; set; }
    public bool WasHsqCompressed { get; set; }
    public int DataBase { get; set; }
    public int EventBase { get; set; }
    public ushort Tempo { get; set; }
    public ushort LoopStartMeasure { get; set; }
    public ushort LoopEndMeasure { get; set; }
    public ushort LoopCount { get; set; }
    public int InstrumentCount { get; set; }
    public int ActiveChannelCount { get; set; }
    public ushort[] ChannelOffsets { get; set; } = new ushort[18];
    public bool[] ChannelActive { get; set; } = new bool[18];
}