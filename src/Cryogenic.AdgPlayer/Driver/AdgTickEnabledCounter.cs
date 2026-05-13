namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Single-byte master-track event counter mirrored from
/// <c>AdgTickEnabledOffset</c> (0x01DF) in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>. Decremented once
/// per master-track <c>AdgEndOfTrack_0AF5</c> hit; when it reaches
/// zero the driver triggers the final bulk reset path
/// (all channels marked done, full OPL reset). When the decrement
/// underflows below zero the original code restores the counter to
/// zero (<c>add byte ptr [01DF],1</c>), which this class exposes via
/// <see cref="RestoreAfterUnderflow"/>.
/// </summary>
/// <remarks>
/// The original driver does not store this value inside the song
/// image; it is seeded by callers of <c>AdgOpenSong_0626</c> via
/// register <c>AL</c>. The engine seeds <see cref="DefaultSeed"/> on
/// <c>Load(...)</c> to give deterministic single-shot semantics until
/// the live-evidence-driven multi-loop seed value is wired in a
/// future cycle.
/// </remarks>
public sealed class AdgTickEnabledCounter {
    /// <summary>
    /// Default seed applied by <c>DuneAdgPlayerEngine.Load</c> when no
    /// caller-supplied value is available. Mirrors a one-shot song
    /// where the first master-track <c>EndOfTrack</c> triggers the
    /// final reset.
    /// </summary>
    public const byte DefaultSeed = 1;

    private byte _value;

    /// <summary>Reads the current counter value.</summary>
    public byte Value {
        get { return _value; }
    }

    /// <summary>Overwrites the counter (used by <c>Load</c> seeding).</summary>
    public void Set(byte value) {
        _value = value;
    }

    /// <summary>
    /// Mirrors <c>mov AL,[01DF]; dec AL; mov [01DF],AL</c> at
    /// dnadg:0AF5. Returns the post-decrement value so callers can
    /// branch on the zero / sign cases without re-reading.
    /// </summary>
    public byte Decrement() {
        _value = (byte)(_value - 1);
        return _value;
    }

    /// <summary>
    /// Mirrors the underflow fix-up at dnadg:0AF5
    /// (<c>test AL,80; je ...; add byte ptr [01DF],1</c>): when the
    /// previous <see cref="Decrement"/> produced a value with the
    /// sign bit set, the driver restores the counter to zero by
    /// adding one back.
    /// </summary>
    public void RestoreAfterUnderflow() {
        _value = (byte)(_value + 1);
    }

    /// <summary>Resets the counter to zero.</summary>
    public void Reset() {
        _value = 0;
    }
}
