namespace Cryogenic.AdgPlayer.Ui.Services;

using System;

/// <summary>
/// Core DNADG runtime state, lookup tables, and low-level helpers shared by the engine partials.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
    // --- Audio pipeline ---
    private readonly OplSynthesizer _opl;
    private volatile bool _disposed;
    private volatile bool _playing;
    private volatile bool _paused;
    private volatile float _outputGain = 1.0f;
    private volatile float _oplVolumeGain = 1.5f;
    private readonly object _lock = new();
    private long _totalTickCount;
    private long _totalSamplesRendered;

    // --- PIT timing ---
    private const int PitInputClock = 1193182;
    private int _pitReloadValue = 0x1745;
    private long _samplesPerTickThreshold;
    private long _sampleAccumulator;

    // --- Song data ---
    private byte[] _songData = Array.Empty<byte>();
    private int _dataBase;
    private ushort _eventBase;

    // --- Global driver state ---
    private ushort _accumulator;
    private byte _statusFlags;
    private byte _tickFlag;
    private ushort _measure;
    private byte _subdivision;
    private ushort _repeatCounter;
    private byte _currentVolume;
    private byte _targetVolume;
    private byte _masterVolume;
    private ushort _fadeBitPattern;

    // --- Per-channel state (18 logical channels, dynamically routed to 9 OPL2 voices) ---
    private const int ChannelCount = 18;

    /// <summary>
    /// Number of runtime channel source offsets read from the ADG song header.
    /// Canonical DNADG build/reset scheduler paths consume 18 entries (CX=0x12).
    /// </summary>
    private const int SongHeaderChannelCount = 18;

    private readonly ushort[] _channelWait = new ushort[ChannelCount];
    private readonly ushort[] _channelEventPointer = new ushort[ChannelCount];
    private readonly ushort[] _channelStartOffset = new ushort[ChannelCount];
    private readonly byte[] _channelInstrument = new byte[ChannelCount];
    private readonly byte[] _channelCurrentNote = new byte[ChannelCount];
    private readonly byte[] _channelPitchBendCounter = new byte[ChannelCount];
    private readonly byte[] _channelPitchAccumulatorHi = new byte[ChannelCount];
    private readonly byte[] _channelPitchTranspose = new byte[ChannelCount];
    private readonly byte[] _channelPitchMode = new byte[ChannelCount];
    private readonly ushort[] _channelPitchBendFlag = new ushort[ChannelCount];
    private readonly byte[] _channelPatchType = new byte[ChannelCount];
    private readonly byte[] _channelVibratoCount = new byte[ChannelCount];
    private readonly byte[] _channelVibratoInit = new byte[ChannelCount];
    private readonly byte[] _channelVibratoPhase = new byte[ChannelCount];
    private readonly byte[] _channelVibratoSpeed = new byte[ChannelCount];
    private readonly ushort[] _channelTlShaping = new ushort[ChannelCount];
    private readonly ushort[] _channelEnvShaping = new ushort[ChannelCount];
    private readonly ushort[] _channelOperatorLevel = new ushort[ChannelCount];
    private readonly ushort[] _channelConnShaping = new ushort[ChannelCount];
    private readonly ushort[] _channelVolModShaping = new ushort[ChannelCount];
    private readonly ushort[] _channelConnMod = new ushort[ChannelCount];
    private readonly ushort[] _channelPatch4TlShaping = new ushort[ChannelCount];
    private readonly ushort[] _channelPatch4EnvShaping = new ushort[ChannelCount];
    private readonly ushort[] _channelPatch4CurrentOperatorLevel = new ushort[ChannelCount];
    private readonly ushort[] _channelPatch4VolumeModulation = new ushort[ChannelCount];

    // --- Dynamic OPL routing (per logical channel) ---
    private readonly byte[] _channelRoute = new byte[ChannelCount];
    private readonly byte[] _channelPrimaryOpRoute = new byte[ChannelCount];
    private readonly byte[] _channelSecondaryOpRoute = new byte[ChannelCount];
    private readonly byte[] _channelRouteShadow = new byte[ChannelCount];
    private readonly ushort[] _channelRouteScratch = new ushort[ChannelCount];
    private ushort _fadeScratch;
    private ushort _fadeScratch2;

    // --- Loop snapshot ---
    private readonly ushort[] _snapshotWait = new ushort[ChannelCount];
    private readonly ushort[] _snapshotPointer = new ushort[ChannelCount];

    // --- Static lookup tables (from driver binary, verified against runtime dump) ---

    /// <summary>OPL2 F-number table for one octave (C through B), 12 entries.</summary>
    private static readonly ushort[] FrequencyTable = {
        0x0157, 0x016C, 0x0181, 0x0198, 0x01B1, 0x01CB,
        0x01E6, 0x0203, 0x0222, 0x0243, 0x0266, 0x028A
    };

    /// <summary>Maps channel (0-8) to OPL register offset for modulator operator.</summary>
    private static readonly byte[] ModulatorOffsets = {
        0x00, 0x01, 0x02, 0x08, 0x09, 0x0A, 0x10, 0x11, 0x12
    };

    /// <summary>Maps channel (0-8) to OPL register offset for carrier operator.</summary>
    private static readonly byte[] CarrierOffsets = {
        0x03, 0x04, 0x05, 0x0B, 0x0C, 0x0D, 0x13, 0x14, 0x15
    };

    /// <summary>
    /// Operator pair table: interleaved (modulator, carrier) per channel.
    /// Channel N modulator = OperatorPairTable[N*2], carrier = OperatorPairTable[N*2+1].
    /// </summary>
    private static readonly byte[] OperatorPairTable = {
        0x00, 0x03, 0x01, 0x04, 0x02, 0x05,
        0x08, 0x0B, 0x09, 0x0C, 0x0A, 0x0D,
        0x10, 0x13, 0x11, 0x14, 0x12, 0x15
    };

    /// <summary>Non-portamento pitch bend fractions (13 entries, indexed 0-12).</summary>
    private static readonly byte[] PitchBendFractions = {
        0x13, 0x15, 0x15, 0x17, 0x19, 0x1A,
        0x1B, 0x1D, 0x1F, 0x21, 0x23, 0x24, 0x25
    };

    /// <summary>Portamento pitch bend fractions (two groups of 5).</summary>
    private static readonly byte[] PortamentoFractions = {
        0x00, 0x05, 0x0A, 0x0F, 0x14,
        0x00, 0x06, 0x0C, 0x12, 0x18
    };

    private static byte Lo8(ushort value) {
        return (byte)(value & 0xFF);
    }

    private static byte Hi8(ushort value) {
        return (byte)(value >> 8);
    }

    private static ushort Make16(byte lo, byte hi) {
        return (ushort)(lo | (hi << 8));
    }

    private static ushort RotateRight16(ushort value, int count) {
        int n = count & 0x0F;
        if (n == 0) {
            return value;
        }
        return (ushort)((value >> n) | (value << (16 - n)));
    }

    private byte SongByte(int offset) {
        return _songData[offset];
    }

    private byte SongByte16(ushort offset) {
        return _songData[offset];
    }

    private ushort SongWord(int offset) {
        return (ushort)(_songData[offset] | (_songData[offset + 1] << 8));
    }

    private ushort SongWord16(ushort offset) {
        byte lo = SongByte16(offset);
        byte hi = SongByte16((ushort)(offset + 1));
        return Make16(lo, hi);
    }
}