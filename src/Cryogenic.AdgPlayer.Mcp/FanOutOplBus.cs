namespace Cryogenic.AdgPlayer.Mcp;

using Cryogenic.AdgPlayer.Opl;

using System;
using System.Collections.Generic;

/// <summary>
/// Forwards each <see cref="IOplBus.WriteRegister"/> call to every
/// downstream sink. Used by <see cref="AdgMcpSession"/> to mirror
/// the engine's register stream into both the audio synth and the
/// register-write recorder.
/// </summary>
public sealed class FanOutOplBus : IOplBus {
    private readonly IOplBus[] _sinks;

    /// <summary>Wraps the supplied sinks (defensive copy).</summary>
    public FanOutOplBus(IReadOnlyCollection<IOplBus> sinks) {
        ArgumentNullException.ThrowIfNull(sinks);
        _sinks = new IOplBus[sinks.Count];
        int i = 0;
        foreach (IOplBus sink in sinks) {
            _sinks[i++] = sink;
        }
    }

    /// <inheritdoc />
    public void WriteRegister(int chip, byte register, byte value) {
        for (int i = 0; i < _sinks.Length; i++) {
            _sinks[i].WriteRegister(chip, register, value);
        }
    }
}
