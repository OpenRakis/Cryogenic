namespace Cryogenic.AdpPlayer.Services;

/// <summary>
/// OPL2 register helpers, data tables, and instrument loading — a faithful
/// translation of the DNADP driver routines decoded from the Dune CD executable.
///
/// All register writes go through OplWrite(register, data) which calls
/// Opl2Synth.WriteRegister(), mirroring the driver's helper at 0x0AA2.
///
/// Tables decoded from live memory at segment 5BAE:
///   - FrequencyTable (0x0147): 12 F-number entries C..B
///   - Op1Map (0x0171): modulator operator offsets per channel
///   - Op2Map (0x017A): carrier operator offsets per channel
///   - OperatorPairTable (0x0135): (mod, car) pairs per channel
/// </summary>
public sealed partial class DuneAdpPlayerEngine {
	// ── F-number table (12 entries, semitones C through B) ──────────────
	// Decoded from CS:0147
	private static readonly ushort[] FrequencyTable = [
		0x0157, // C
		0x016C, // C#
		0x0181, // D
		0x0198, // D#
		0x01B1, // E
		0x01CB, // F
		0x01E6, // F#
		0x0203, // G
		0x0222, // G#
		0x0243, // A
		0x0266, // A#
		0x028A  // B
	];

	// ── Operator offset maps (9 entries each) ──────────────────────────
	// Decoded from CS:0171 (modulator) and CS:017A (carrier)
	private static readonly byte[] Op1Map = [0x00, 0x01, 0x02, 0x08, 0x09, 0x0A, 0x10, 0x11, 0x12]; // modulator
	private static readonly byte[] Op2Map = [0x03, 0x04, 0x05, 0x0B, 0x0C, 0x0D, 0x13, 0x14, 0x15]; // carrier

	/// <summary>
	/// Writes a single OPL2 register. Mirrors the driver helper at 0x0AA2:
	///   out 0x388, register; delay; out 0x389, data; delay
	/// </summary>
	private void OplWrite(byte register, byte data) {
		_synth.WriteRegister(register, data);
		TrackOplWrite(register, data);
	}

	/// <summary>
	/// Note-on: compute F-number and block from MIDI-style note, write freq registers + key-on.
	/// Mirrors 0x0A58 + 0x062C:
	///   note = rawNote + transpose - 0x18 (offset 24)
	///   octave = note / 12,  semitone = note % 12
	///   fnum = FrequencyTable[semitone]
	///   Write 0xA0+ch = fnum low 8 bits
	///   Write 0xB0+ch = 0x20 (key-on) | (octave &lt;&lt; 2) | (fnum >> 8)
	/// </summary>
	private void OplNoteOn(int ch, byte rawNote) {
		int adjusted = rawNote + _channelTranspose[ch] - 0x18;
		if (adjusted < 0) { adjusted = 0; }
		if (adjusted > 95) { adjusted = 95; } // 8 octaves * 12 semitones

		int octave = adjusted / 12;
		int semitone = adjusted % 12;

		ushort fnum = FrequencyTable[semitone];
		byte regALow = (byte)(fnum & 0xFF);
		byte regBHigh = (byte)(0x20 | ((octave & 0x07) << 2) | ((fnum >> 8) & 0x03));

		OplWrite((byte)(0xA0 + ch), regALow);
		OplWrite((byte)(0xB0 + ch), regBHigh);

		_channelStoredFreq[ch] = (ushort)((regBHigh << 8) | regALow);
	}

	/// <summary>
	/// Note-off: clear key-on bit in register 0xB0+ch.
	/// Mirrors 0x0A87: reads stored frequency, clears bit 5 (key-on), rewrites.
	/// </summary>
	private void OplNoteOff(int ch) {
		ushort stored = _channelStoredFreq[ch];
		byte regA = (byte)(stored & 0xFF);
		byte regB = (byte)((stored >> 8) & ~0x20);

		OplWrite((byte)(0xA0 + ch), regA);
		OplWrite((byte)(0xB0 + ch), regB);
	}

	/// <summary>
	/// Sets carrier operator total level (volume) with master volume scaling.
	/// Register 0x40+carrierOp where lower 6 bits = attenuation (0=loudest, 0x3F=silent).
	///
	/// Volume byte from event stream: 0 = silent, 0x7F = loudest.
	/// Conversion: attenuation = 0x3F - (volume * masterScale / 0x7F * 0x3F / 0xFF)
	/// </summary>
	private void OplSetVolume(int ch, byte volume) {
		// Scale by master volume
		int scaled = (volume * _currentVolume) / 0x7F;
		// Convert to OPL attenuation (0x3F = silent, 0 = max)
		int attenuation = 0x3F - ((scaled * 0x3F) / 0x7F);
		if (attenuation < 0) { attenuation = 0; }
		if (attenuation > 0x3F) { attenuation = 0x3F; }

		byte carrierOp = Op2Map[ch];
		// Preserve KSL bits (top 2 bits) set during instrument load.
		byte ksl = _channelCarrierKsl[ch];
		OplWrite((byte)(0x40 + carrierOp), (byte)((ksl & 0xC0) | (attenuation & 0x3F)));
	}

	/// <summary>
	/// Pitch bend: adjusts F-number based on bend value.
	/// Mirrors 0x07EA: modifies frequency registers without affecting key-on state.
	/// </summary>
	private void OplPitchBend(int ch, byte bendValue) {
		if (_channelNote[ch] == 0) {
			return; // No active note to bend
		}

		int adjusted = _channelNote[ch] + _channelTranspose[ch] - 0x18;
		if (adjusted < 0) { adjusted = 0; }
		if (adjusted > 95) { adjusted = 95; }

		int octave = adjusted / 12;
		int semitone = adjusted % 12;

		ushort baseFnum = FrequencyTable[semitone];

		// Bend range: 0x40 = center (no bend), 0x00 = -max, 0x7F = +max
		// Scale: each unit = ~2 F-number units (approximate; ~1 semitone at full range)
		int bendOffset = (int)(bendValue & 0x7F) - 0x40;
		int bentFnum = baseFnum + bendOffset * 2;
		if (bentFnum < 0) { bentFnum = 0; }
		if (bentFnum > 0x3FF) { bentFnum = 0x3FF; }

		byte regA = (byte)(bentFnum & 0xFF);
		// Preserve key-on state from stored frequency
		bool keyOn = (_channelStoredFreq[ch] & 0x2000) != 0;
		byte regB = (byte)((keyOn ? 0x20 : 0x00) | ((octave & 0x07) << 2) | ((bentFnum >> 8) & 0x03));

		OplWrite((byte)(0xA0 + ch), regA);
		OplWrite((byte)(0xB0 + ch), regB);

		_channelStoredFreq[ch] = (ushort)((regB << 8) | regA);
	}

	/// <summary>
	/// Writes a 40-byte instrument definition to OPL2 registers.
	/// Mirrors instwrite_09AB: reads instrument from song data at eventBaseOffset,
	/// writes 6 OPL registers per operator (modulator + carrier).
	///
	/// Instrument data layout (40 bytes, decoded from driver at 0x09AB):
	///   [0x00] KSL/Level modulator       -> reg 0x40+op1
	///   [0x01] AM/VIB/EG/KSR/MULT mod    -> reg 0x20+op1
	///   [0x02] Feedback/Connection bits   -> reg 0xC0+ch (combined with [0x0C])
	///   [0x03] Attack/Decay mod           -> reg 0x60+op1
	///   [0x04] Sustain/Release mod        -> reg 0x80+op1
	///   [0x05] AM/VIB flags mod           (combined into 0x20+op1)
	///   [0x06] Attack/Decay car           -> reg 0x60+op2
	///   [0x07] Sustain/Release car        -> reg 0x80+op2
	///   [0x08] KSL/Level carrier          -> reg 0x40+op2
	///   [0x09] AM/VIB/EG/KSR bits car     (combined into 0x20+op2)
	///   [0x0A] KSR bits mod               (combined into 0x20+op1)
	///   [0x0B] MULT car                   (combined into 0x20+op2)
	///   [0x0C] Connection bit             (combined into 0xC0+ch)
	///   ...
	///   [0x1A] Waveform modulator         -> reg 0xE0+op1
	///   [0x1B] Waveform carrier           -> reg 0xE0+op2
	/// </summary>
	private void OplWriteInstrument(int ch, byte instrumentIndex) {
		// Instrument data starts at eventBaseOffset in the song data
		int instOffset = _eventBaseOffset + instrumentIndex * 40;
		if (instOffset + 40 > _songData.Length) {
			return; // Invalid instrument index
		}

		byte op1 = Op1Map[ch]; // modulator
		byte op2 = Op2Map[ch]; // carrier

		// Feedback/Connection: combine [0x02] bits and [0x0C]
		byte fbConn = (byte)((_songData[instOffset + 0x02] & 0x0E) | (_songData[instOffset + 0x0C] & 0x01));
		OplWrite((byte)(0xC0 + ch), fbConn);

		// Waveform select
		OplWrite((byte)(0xE0 + op1), _songData[instOffset + 0x1A]);
		OplWrite((byte)(0xE0 + op2), _songData[instOffset + 0x1B]);

		// Modulator: KSL/Level
		OplWrite((byte)(0x40 + op1), _songData[instOffset + 0x00]);

		// Carrier: KSL/Level — cache KSL bits for later volume modulation.
		byte carrierKslLevel = _songData[instOffset + 0x08];
		_channelCarrierKsl[ch] = (byte)(carrierKslLevel & 0xC0);
		OplWrite((byte)(0x40 + op2), carrierKslLevel);

		// Modulator: Attack/Decay
		OplWrite((byte)(0x60 + op1), _songData[instOffset + 0x03]);

		// Carrier: Attack/Decay
		OplWrite((byte)(0x60 + op2), _songData[instOffset + 0x06]);

		// Modulator: Sustain/Release
		OplWrite((byte)(0x80 + op1), _songData[instOffset + 0x04]);

		// Carrier: Sustain/Release
		OplWrite((byte)(0x80 + op2), _songData[instOffset + 0x07]);

		// Modulator: AM/VIB/EG/KSR/MULT (combined from [0x01], [0x05], [0x0A])
		byte modChar = (byte)(
			(_songData[instOffset + 0x01] & 0x0F) | // MULT low nibble
			(_songData[instOffset + 0x05] & 0xC0) | // AM/VIB flags
			(_songData[instOffset + 0x0A] & 0x30)   // EG/KSR flags
		);
		OplWrite((byte)(0x20 + op1), modChar);

		// Carrier: AM/VIB/EG/KSR/MULT (combined from [0x09], [0x0B])
		byte carChar = (byte)(
			(_songData[instOffset + 0x0B] & 0x0F) | // MULT low nibble
			(_songData[instOffset + 0x09] & 0xF0)   // AM/VIB/EG/KSR flags
		);
		OplWrite((byte)(0x20 + op2), carChar);
	}

	/// <summary>
	/// Silences all 9 OPL channels by clearing key-on bits.
	/// </summary>
	private void AllNotesOff() {
		for (int ch = 0; ch < 9; ch++) {
			OplNoteOff(ch);
			_channelNote[ch] = 0;
		}
	}

	/// <summary>
	/// Initializes the OPL2 chip: reset all registers, enable waveform select.
	/// Called during Load before any instrument/note writes.
	/// </summary>
	private void InitOpl() {
		// Test register off
		OplWrite(0x01, 0x20); // Enable waveform select (WSE bit)
		OplWrite(0x08, 0x00); // CSW/NOTE-SEL off

		// Clear all channel and operator registers
		for (byte ch = 0; ch < 9; ch++) {
			OplWrite((byte)(0xA0 + ch), 0x00);
			OplWrite((byte)(0xB0 + ch), 0x00);
			OplWrite((byte)(0xC0 + ch), 0x00);
		}
		for (byte op = 0; op < 0x16; op++) {
			// Skip operator offsets that don't exist (0x06, 0x07, 0x0E, 0x0F)
			if ((op & 0x07) >= 0x06) { continue; }
			OplWrite((byte)(0x20 + op), 0x00);
			OplWrite((byte)(0x40 + op), 0x3F); // Max attenuation (silent)
			OplWrite((byte)(0x60 + op), 0xFF); // Fast attack/decay
			OplWrite((byte)(0x80 + op), 0xFF); // Fast sustain/release
			OplWrite((byte)(0xE0 + op), 0x00); // Sine waveform
		}

		// BD register: rhythm mode off, all percussion off
		OplWrite(0xBD, 0x00);
	}
}