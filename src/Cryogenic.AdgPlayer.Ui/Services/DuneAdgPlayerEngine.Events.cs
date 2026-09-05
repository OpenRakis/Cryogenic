namespace Cryogenic.AdgPlayer.Ui.Services;

/// <summary>
/// DNADG event decoding and handler implementations.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
    /// <summary>
    /// Reads a variable-length wait value from the ADG song data stream.
    /// Each byte contributes 7 bits; the high bit signals continuation.
    /// Mirrors AdgReadWaitValue_0E7E: value = (value &lt;&lt; 7) | (byte &amp; 0x7F) until MSB clears.
    /// </summary>
    private void ReadWaitValue(int ch) {
        ushort si = _channelEventPointer[ch];
        uint accumulator = 0;
        bool overflow = false;

        while (true) {
            byte current = SongByte16(si);
            si = (ushort)(si + 1);
            accumulator = (accumulator << 7) | (uint)(current & 0x7F);
            if (accumulator > ushort.MaxValue) {
                overflow = true;
            }
            if ((current & 0x80) == 0) {
                break;
            }
        }

        _channelWait[ch] = overflow ? ushort.MaxValue : (ushort)accumulator;
        _channelEventPointer[ch] = si;
    }

    /// <summary>
    /// NoteOn event handler. Reads velocity byte, sets up envelope,
    /// writes frequency to OPL with key-on.
    /// Mirrors AdpNoteOn_062C.
    /// </summary>
    private void NoteOn(int ch, ushort eventWord) {
        ushort si = _channelEventPointer[ch];
        byte velocity = SongByte16(si);
        si = (ushort)(si + 1);
        _channelEventPointer[ch] = si;

        ReadWaitValue(ch);
        EnvelopeSetup(ch, velocity);

        if (_channelCurrentNote[ch] != 0) {
            AdgNoteOff((ushort)ch);
        }

        byte noteFromEvent = Hi8(eventWord);
        byte note = (byte)(noteFromEvent + _channelPitchTranspose[ch]);
        _channelCurrentNote[ch] = note;
        _channelPitchBendCounter[ch] = (byte)(_channelPitchBendFlag[ch] >> 8);
        _channelPitchAccumulatorHi[ch] = 0x40;
        ushort rawPitch = (ushort)(note - 0x48);

        _channelVibratoCount[ch] = _channelVibratoInit[ch];
        _channelVibratoPhase[ch] = 0x40;

        AdgNoteOn((ushort)ch, rawPitch);
        ChannelEventDispatched?.Invoke(ch, "NoteOn", $"note={note:X2} vel={velocity:X2} raw={rawPitch:X4}", _totalTickCount);
    }

    /// <summary>
    /// NoteOff event handler. Reads wait, clears note if matching.
    /// Mirrors AdgNoteOff_0AB6.
    /// </summary>
    private void NoteOff(int ch, ushort eventWord) {
        _channelEventPointer[ch]++;
        ReadWaitValue(ch);

        byte noteFromEvent = (byte)(Hi8(eventWord) + _channelPitchTranspose[ch]);
        if (_channelCurrentNote[ch] == noteFromEvent) {
            _channelCurrentNote[ch] = 0;
            AdgNoteOff((ushort)ch);
            ChannelEventDispatched?.Invoke(ch, "NoteOff", $"note={noteFromEvent:X2}", _totalTickCount);
        }
    }

    /// <summary>
    /// ProgramChange event handler. Loads instrument patch and writes to OPL.
    /// Mirrors AdgProgramChange_0831.
    /// </summary>
    private void ProgramChange(int ch, ushort eventWord) {
        ReadWaitValue(ch);

        byte instrument = Hi8(eventWord);
        _channelInstrument[ch] = instrument;

        ushort patchOffset = (ushort)(_eventBase + instrument * 0x28);
        byte patchType = SongByte16(patchOffset);
        ConfigureInstrumentRouting(ch, patchType);

        _channelPatchType[ch] = patchType;
        if (patchType == 4) {
            ushort ax = Make16(SongByte16((ushort)(patchOffset + 0x32)), SongByte16((ushort)(patchOffset + 0x3F)));
            ushort bx = Make16(SongByte16((ushort)(patchOffset + 0x2A)), SongByte16((ushort)(patchOffset + 0x37)));
            bx = (ushort)(bx & 0x0303);
            bx = RotateRight16(bx, 2);
            ax = (ushort)(ax | bx);
            _channelPatch4EnvShaping[ch] = ax;
            _channelPatch4TlShaping[ch] = SongWord16((ushort)(patchOffset + 0x46));
            _channelPatch4VolumeModulation[ch] = SongWord16((ushort)(patchOffset + 0x4E));
        }

        ushort pitchModeWord = SongWord16((ushort)(patchOffset + 0x21));
        _channelPitchBendFlag[ch] = pitchModeWord;
        _channelPitchMode[ch] = Lo8(pitchModeWord);
        _channelPitchTranspose[ch] = Hi8(pitchModeWord);

        ushort ax2 = Make16(SongByte16((ushort)(patchOffset + 0x0A)), SongByte16((ushort)(patchOffset + 0x17)));
        ushort bx2 = Make16(SongByte16((ushort)(patchOffset + 0x0F)), SongByte16((ushort)(patchOffset + 0x02)));
        bx2 = (ushort)(bx2 & 0x0303);
        bx2 = RotateRight16(bx2, 2);
        ax2 = (ushort)(ax2 | bx2);
        _channelEnvShaping[ch] = ax2;
        _channelTlShaping[ch] = SongWord16((ushort)(patchOffset + 0x1E));
        _channelVolModShaping[ch] = SongWord16((ushort)(patchOffset + 0x26));

        ushort ax3 = Make16((byte)~SongByte16((ushort)(patchOffset + 0x0E)), SongByte16((ushort)(patchOffset + 0x04)));
        ax3 = RotateRight16(ax3, 1);
        ax3 = (ushort)(ax3 << 1);
        ax3 = Make16(SongByte16((ushort)(patchOffset + 0x20)), Hi8(ax3));
        _channelConnShaping[ch] = ax3;

        ax3 = Make16(SongByte16((ushort)(patchOffset + 0x1B)), Hi8(ax3));
        _channelConnMod[ch] = ax3;

        ushort vibrato = SongWord16((ushort)(patchOffset + 0x23));
        _channelVibratoSpeed[ch] = Hi8(vibrato);
        _channelVibratoCount[ch] = 0;
        _channelVibratoInit[ch] = Lo8(vibrato);

        InstrumentWrite(ch, patchOffset);
        ChannelEventDispatched?.Invoke(ch, "ProgramChange", $"inst={instrument:X2} off=0x{patchOffset:X4}", _totalTickCount);
    }

    /// <summary>
    /// EnvelopeSetup for NoteOn. Adjusts TL and connection registers from velocity.
    /// Mirrors AdgEnvelopeSetup_0C47.
    /// </summary>
    private void EnvelopeSetup(int ch, byte velocity) {
        byte directVelocity = velocity;
        byte inverseVelocity = (byte)(0x80 - velocity);
        ushort operatorLevel = _channelOperatorLevel[ch];
        ushort tlShaping = _channelTlShaping[ch];

        if (Lo8(tlShaping) != 0) {
            byte shaping = Lo8(tlShaping);
            byte scale = inverseVelocity;
            if ((shaping & 0x80) != 0) {
                shaping = (byte)(0 - shaping);
                scale = directVelocity;
            }
            shaping = (byte)(0 - (byte)(shaping - 4));
            scale = (byte)(scale >> shaping);
            byte value = (byte)((Lo8(operatorLevel) & 0x3F) + scale);
            if (value > 0x3F) {
                value = 0x3F;
            }
            value = (byte)((Lo8(operatorLevel) & 0xC0) | value);
            operatorLevel = Make16(value, Hi8(operatorLevel));
            AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)_channelPrimaryOpRoute[ch]));
        }

        if (Hi8(tlShaping) != 0) {
            byte shaping = Hi8(tlShaping);
            byte scale = inverseVelocity;
            if ((shaping & 0x80) != 0) {
                shaping = (byte)(0 - shaping);
                scale = directVelocity;
            }
            byte shift = (byte)(4 - shaping);
            scale = (byte)(scale >> shift);
            byte value = (byte)((Hi8(operatorLevel) & 0x3F) + scale);
            if (value > 0x3F) {
                value = 0x3F;
            }
            value = (byte)((Hi8(operatorLevel) & 0xC0) | value);
            operatorLevel = Make16(Lo8(operatorLevel), value);
            AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)_channelSecondaryOpRoute[ch]));
        }

        _channelOperatorLevel[ch] = operatorLevel;
        if (_channelPatchType[ch] == 4) {
            ushort patch4OperatorLevel = _channelPatch4CurrentOperatorLevel[ch];
            ushort patch4TlShaping = _channelPatch4TlShaping[ch];

            if (Lo8(patch4TlShaping) != 0) {
                byte scale = inverseVelocity;
                byte shaping = Lo8(patch4TlShaping);
                if ((shaping & 0x80) != 0) {
                    shaping = (byte)(0 - shaping);
                    scale = directVelocity;
                }
                shaping = (byte)(0 - (byte)(shaping - 4));
                scale = (byte)(scale >> shaping);
                byte value = (byte)((Lo8(patch4OperatorLevel) & 0x3F) + scale);
                if (value > 0x3F) {
                    value = 0x3F;
                }
                value = (byte)((Lo8(patch4OperatorLevel) & 0xC0) | value);
                patch4OperatorLevel = Make16(value, Hi8(patch4OperatorLevel));
                AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)(_channelPrimaryOpRoute[ch] + 0x08)));
            }

            if (Hi8(patch4TlShaping) != 0) {
                byte scale = inverseVelocity;
                byte shaping = Hi8(patch4TlShaping);
                if ((shaping & 0x80) != 0) {
                    shaping = (byte)(0 - shaping);
                    scale = directVelocity;
                }
                byte shift = (byte)(4 - shaping);
                scale = (byte)(scale >> shift);
                byte value = (byte)((Hi8(patch4OperatorLevel) & 0x3F) + scale);
                if (value > 0x3F) {
                    value = 0x3F;
                }
                value = (byte)((Hi8(patch4OperatorLevel) & 0xC0) | value);
                patch4OperatorLevel = Make16(Lo8(patch4OperatorLevel), value);
                AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)(_channelSecondaryOpRoute[ch] + 0x08)));
            }

            _channelPatch4CurrentOperatorLevel[ch] = patch4OperatorLevel;
        }

        ushort connectionShape = _channelConnShaping[ch];
        if (Lo8(connectionShape) == 0) {
            _channelConnMod[ch] = (ushort)((_channelConnMod[ch] & 0x00FF) | (Hi8(connectionShape) << 8));
            return;
        }

        byte shapingMode = Lo8(connectionShape);
        byte scaleConnection = inverseVelocity;
        if ((shapingMode & 0x80) != 0) {
            shapingMode = (byte)(0 - shapingMode);
            scaleConnection = directVelocity;
        }
        shapingMode = (byte)(0 - (byte)(shapingMode - 6));
        scaleConnection = (byte)(scaleConnection >> shapingMode);
        scaleConnection = (byte)(scaleConnection & 0xFE);
        scaleConnection = (byte)(scaleConnection + Hi8(connectionShape));
        if (scaleConnection > 0x0F) {
            scaleConnection = (byte)((scaleConnection & 0x0F) | 0x0E);
        }
        _channelConnMod[ch] = (ushort)((_channelConnMod[ch] & 0x00FF) | (scaleConnection << 8));
        AdgWriteRelativeGoldRegister(0xC0, scaleConnection, unchecked((sbyte)_channelRoute[ch]));
    }

    /// <summary>
    /// VolumeModulation event handler. Applies velocity-based modulation to TL and connection registers.
    /// Mirrors AdgVolumeModulation_0B2E.
    /// </summary>
    private void VolumeModulation(int ch, ushort eventWord) {
        ReadWaitValue(ch);

        byte directVelocity = Hi8(eventWord);
        byte inverseVelocity = (byte)(0x80 - directVelocity);
        ushort operatorLevel = _channelOperatorLevel[ch];
        ushort volumeShape = _channelVolModShaping[ch];

        sbyte modRoute = unchecked((sbyte)_channelPrimaryOpRoute[ch]);
        sbyte carRoute = unchecked((sbyte)_channelSecondaryOpRoute[ch]);
        sbyte chanRoute = unchecked((sbyte)_channelRoute[ch]);

        if (Lo8(volumeShape) != 0) {
            byte shaping = Lo8(volumeShape);
            byte scale = directVelocity;
            if ((shaping & 0x80) != 0) {
                shaping = (byte)(0 - shaping);
                scale = inverseVelocity;
            }
            shaping = (byte)(0 - (byte)(shaping - 4));
            scale = (byte)(scale >> shaping);
            byte value = (byte)(Lo8(operatorLevel) & 0x3F);
            value = value >= scale ? (byte)(value - scale) : (byte)0;
            value = (byte)((Lo8(operatorLevel) & 0xC0) | value);
            operatorLevel = Make16(value, Hi8(operatorLevel));
            AdgWriteRelativeGoldRegister(0x40, value, modRoute);
        }

        if (Hi8(volumeShape) != 0) {
            byte shaping = Hi8(volumeShape);
            byte scale = directVelocity;
            if ((shaping & 0x80) != 0) {
                shaping = (byte)(0 - shaping);
                scale = inverseVelocity;
            }
            byte shift = (byte)(4 - shaping);
            scale = (byte)(scale >> shift);
            byte value = (byte)(Hi8(operatorLevel) & 0x3F);
            value = value >= scale ? (byte)(value - scale) : (byte)0;
            value = (byte)((Hi8(operatorLevel) & 0xC0) | value);
            operatorLevel = Make16(Lo8(operatorLevel), value);
            AdgWriteRelativeGoldRegister(0x40, value, carRoute);
        }

        _channelOperatorLevel[ch] = operatorLevel;
        if (_channelPatchType[ch] == 4) {
            ushort patch4Level = _channelPatch4CurrentOperatorLevel[ch];
            ushort patch4Shape = _channelPatch4VolumeModulation[ch];

            if (Lo8(patch4Shape) != 0) {
                byte scale = directVelocity;
                byte shaping = Lo8(patch4Shape);
                if ((shaping & 0x80) != 0) {
                    shaping = (byte)(0 - shaping);
                    scale = inverseVelocity;
                }
                shaping = (byte)(0 - (byte)(shaping - 4));
                scale = (byte)(scale >> shaping);
                byte value = (byte)(Lo8(patch4Level) & 0x3F);
                value = value >= scale ? (byte)(value - scale) : (byte)0;
                value = (byte)((Lo8(patch4Level) & 0xC0) | value);
                patch4Level = Make16(value, Hi8(patch4Level));
                byte route = (byte)(_channelPrimaryOpRoute[ch] + 0x08);
                AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)route));
            }

            if (Hi8(patch4Shape) != 0) {
                byte scale = directVelocity;
                byte shaping = Hi8(patch4Shape);
                if ((shaping & 0x80) != 0) {
                    shaping = (byte)(0 - shaping);
                    scale = inverseVelocity;
                }
                byte shift = (byte)(4 - shaping);
                scale = (byte)(scale >> shift);
                byte value = (byte)(Hi8(patch4Level) & 0x3F);
                value = value >= scale ? (byte)(value - scale) : (byte)0;
                value = (byte)((Hi8(patch4Level) & 0xC0) | value);
                patch4Level = Make16(Lo8(patch4Level), value);
                byte route = (byte)(_channelSecondaryOpRoute[ch] + 0x08);
                AdgWriteRelativeGoldRegister(0x40, value, unchecked((sbyte)route));
            }

            _channelPatch4CurrentOperatorLevel[ch] = patch4Level;
        }

        ushort connectionMod = _channelConnMod[ch];
        if (Lo8(connectionMod) != 0) {
            byte shapingMode = Lo8(connectionMod);
            byte scaleConnection = directVelocity;
            if ((shapingMode & 0x80) != 0) {
                shapingMode = (byte)(0 - shapingMode);
                scaleConnection = inverseVelocity;
            }
            shapingMode = (byte)(0 - (byte)(shapingMode - 6));
            scaleConnection = (byte)(scaleConnection >> shapingMode);
            scaleConnection = (byte)(scaleConnection & 0xFE);
            scaleConnection = (byte)(scaleConnection + Hi8(connectionMod));
            if (scaleConnection > 0x0F) {
                scaleConnection = (byte)((scaleConnection & 0x0F) | 0x0E);
            }
            _channelConnMod[ch] = (ushort)((_channelConnMod[ch] & 0x00FF) | (scaleConnection << 8));
            AdgWriteRelativeGoldRegister(0xC0, scaleConnection, chanRoute);
        }
    }

    /// <summary>
    /// PitchBend event handler (from event dispatch).
    /// Mirrors AdgPitchBend_0D86.
    /// </summary>
    private void PitchBend(int ch, ushort eventWord) {
        byte bendValue = Hi8(eventWord);
        ReadWaitValue(ch);
        PitchBendBody(ch, Make16(bendValue, bendValue));
    }

    /// <summary>
    /// Pitch bend computation. Exact ADG driver implementation.
    /// Handles both portamento and non-portamento modes per patch configuration.
    /// Mirrors AdgPitchBendBody_0D8B.
    /// </summary>
    private void PitchBendBody(int ch, ushort input) {
        byte note = _channelCurrentNote[ch];
        if (note == 0) {
            return;
        }

        byte pitchBendValue = Lo8(input);
        int noteVal = pitchBendValue - 0x18;
        int octaveInt = noteVal / 12;
        int semitoneInt = noteVal % 12;
        if (semitoneInt < 0) {
            semitoneInt += 12;
            octaveInt -= 1;
        }
        byte octave = (byte)(octaveInt & 0xFF);
        byte semitone = (byte)(semitoneInt & 0xFF);

        bool portamentoMode = Lo8(_channelPitchBendFlag[ch]) != 0;
        ushort ax = Make16(pitchBendValue, 0);

        if (!portamentoMode) {
            bool negative = ax < 0x0040;
            ax = (ushort)(ax - 0x0040);
            if (negative) {
                ax = (ushort)(0 - ax);
                ax = RotateRight16(ax, 5);
                byte delta = Lo8(ax);
                if (semitone >= delta) {
                    semitone = (byte)(semitone - delta);
                } else {
                    semitone = (byte)(semitone + 12 - delta);
                    octave = (byte)(octave - 1);
                    if ((octave & 0x80) != 0) {
                        octave = 0;
                        semitone = 0;
                    }
                }

                byte fraction = PitchBendFractions[semitone];
                ushort mul = (ushort)(fraction * Hi8(ax));
                byte adjustment = Hi8(mul);
                ushort frequency = FrequencyTable[semitone];
                int result = Lo8(frequency) - adjustment;
                ax = Make16((byte)result, (byte)(Hi8(frequency) - (result < 0 ? 1 : 0)));
            } else {
                ax = (ushort)(ax + 1);
                ax = RotateRight16(ax, 5);
                byte delta = Lo8(ax);
                semitone = (byte)(semitone + delta);
                if (semitone >= 12) {
                    semitone = (byte)(semitone - 12);
                    octave = (byte)(octave + 1);
                }

                byte fraction = PitchBendFractions[semitone + 1];
                ushort mul = (ushort)(fraction * Hi8(ax));
                byte adjustment = Hi8(mul);
                ushort frequency = FrequencyTable[semitone];
                int result = Lo8(frequency) + adjustment;
                ax = Make16((byte)result, (byte)(Hi8(frequency) + (result > 0xFF ? 1 : 0)));
            }
        } else {
            bool negative = ax < 0x0040;
            ax = (ushort)(ax - 0x0040);
            if (negative) {
                ax = (ushort)(0 - ax);
                byte delta = (byte)(ax / 5);
                byte remainderPort = (byte)(ax % 5);
                if (semitone >= delta) {
                    semitone = (byte)(semitone - delta);
                } else {
                    semitone = (byte)(semitone + 12 - delta);
                    octave = (byte)(octave - 1);
                    if ((octave & 0x80) != 0) {
                        octave = 0;
                        semitone = 0;
                    }
                }

                ushort tableBase = (ushort)(semitone >= 6 ? 5 : 0);
                byte adjustment = PortamentoFractions[tableBase + remainderPort];
                ushort frequency = FrequencyTable[semitone];
                int result = Lo8(frequency) - adjustment;
                ax = Make16((byte)result, (byte)(Hi8(frequency) - (result < 0 ? 1 : 0)));
            } else {
                byte delta = (byte)(ax / 5);
                byte remainderPort = (byte)(ax % 5);
                semitone = (byte)(semitone + delta);
                if (semitone >= 12) {
                    semitone = (byte)(semitone - 12);
                    octave = (byte)(octave + 1);
                }

                ushort tableBase = (ushort)(semitone >= 6 ? 5 : 0);
                byte adjustment = PortamentoFractions[tableBase + remainderPort];
                ushort frequency = FrequencyTable[semitone];
                int result = Lo8(frequency) + adjustment;
                ax = Make16((byte)result, (byte)(Hi8(frequency) + (result > 0xFF ? 1 : 0)));
            }
        }

        byte blockBits = (byte)(octave << 2);
        ax = Make16(Lo8(ax), (byte)(Hi8(ax) | blockBits));
        _adgFrequencyWordTable[ch] = ax;
        ax = Make16(Lo8(ax), (byte)(Hi8(ax) | 0x20));
        AdgWriteFrequencyWord((ushort)ch, ax);
    }

    /// <summary>
    /// EndOfTrack event handler. Handles song looping and termination.
    /// Mirrors AdpEndOfTrack_066F.
    /// </summary>
    private void EndOfTrack(int ch) {
        _channelWait[ch] = 0xFFFF;
        ChannelEventDispatched?.Invoke(ch, "EndOfTrack", "", _totalTickCount);
        byte pointerLow = Lo8(_channelEventPointer[ch]);
        pointerLow = (byte)(pointerLow - 2);
        _channelEventPointer[ch] = Make16(pointerLow, Hi8(_channelEventPointer[ch]));

        if (ch != 0) {
            return;
        }

        _tickFlag--;
        if (_tickFlag == 0) {
            for (int i = 0; i < ChannelCount; i++) {
                _channelWait[i] = 0xFFFF;
            }
            AllNotesOff();
            _statusFlags = 0;
            Logger.Information("Song finished (tickFlag reached 0)");
            return;
        }
        if ((_tickFlag & 0x80) != 0) {
            _tickFlag++;
        }

        _measure = 1;
        _subdivision = 0x60;
        for (int i = 0; i < ChannelCount; i++) {
            ushort ptr = _channelStartOffset[i];
            _channelEventPointer[i] = ptr;
            _channelWait[i] = 0xFFFF;
            if (ptr != 0) {
                ReadWaitValue(i);
                _channelWait[i]++;
            }
        }

        LoopPointCheck();
        _channelWait[0]--;
    }
}