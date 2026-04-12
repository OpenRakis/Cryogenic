## Plan: Fix DNADP AdLib Player — Exhaustive OPL Parity Fixes

The standalone AdLib player has **three structural bugs** causing ~33% pitch accuracy and wrong timbres. All stem from mismatched instrument data reading vs the real DNADP driver. The fix is surgical: 3 files touched, ~10 lines changed.

---

### Bug A: Instrument Base Offset Is 0x20 Too High

- Player: `_eventBaseOffset = ReadU16(0) = 0x4D84`
- Driver: far pointer at `[0x0119]` = `5C5C:4D64` (0x20 less)
- At `5C5C:4D64`: valid instrument data. At `5C5C:4D84`: garbage/zeros
- **Impact**: ALL instrument reads hit wrong memory — every timbre is broken

**Fix in `Load()`**: `_eventBaseOffset = (ushort)(ReadU16(0) - 0x20);`

### Bug B: Missing +2 SI Adjustment in Instrument OPL Write

The driver does `ADD SI, 2` at `5BAE:0624` before calling the OPL instrument write routine at `09AB`. Inside that routine, all byte references are relative to `SI` (which is already `instBase + 2`):

| What | Player reads | Driver reads | Delta |
|------|-------------|-------------|-------|
| FB byte | `inst[0x02]` | `inst[0x04]` | +2 |
| CNT byte | `inst[0x0C]` | `inst[0x0E]` | +2 |
| Mod base | `instOffset+0x00` | `instOffset+0x02` | +2 |
| Mod waveform | `inst[0x1A]` | `inst[0x1C]` | +2 |
| Car base | `instOffset+0x0D` | `instOffset+0x0F` | +2 |
| Car waveform | `inst[0x1B]` | `inst[0x1D]` | +2 |

**Impact**: Every OPL operator register (E0, 40, 60, 80, 20, C0) gets wrong values.

**Fix in `OplWriteInstrument()`**: Shift all 6 instrument byte references by +2.

### Bug C: Transpose Never Set From Instrument Data

- Driver ProgramChange writes a **word** to `[DI+0x48]`: low byte = `_channelReg48`, **high byte = transpose** (`inst[0x22]`)
- NoteOn at `5BAE:0643`: `ADD AL, [DI+0x49]` — adds transpose to note
- Player's `InitializeRuntimeStateFromInstrument05AA` reads the word but **discards the high byte**
- `_channelTranspose[ch]` stays 0 forever

**Impact**: Notes play at wrong pitch when instrument has non-zero transpose (explains ch3 octave shift, ch2 wrong note).

**Fix in `InitializeRuntimeStateFromInstrument05AA()`**: Extract transpose from high byte.

---

### Steps

| # | Phase | File | Change |
|---|-------|------|--------|
| 1 | Base Offset | [DuneAdpPlayerEngine.cs](src/Cryogenic.AdpPlayer/Services/DuneAdpPlayerEngine.cs) | Apply `-0x20` to `_eventBaseOffset` in `Load()` |
| 2 | SI+2 Adjust | [DuneAdpPlayerEngine.Opl.cs](src/Cryogenic.AdpPlayer/Services/DuneAdpPlayerEngine.Opl.cs) | Shift all 6 byte refs in `OplWriteInstrument()` by +2 |
| 3 | Transpose | [DuneAdpPlayerEngine.Opl.cs](src/Cryogenic.AdpPlayer/Services/DuneAdpPlayerEngine.Opl.cs) | Extract `_channelTranspose[ch]` in `InitializeRuntimeStateFromInstrument05AA()` |
| 4 | Build | — | `dotnet build` from `src/` |

Steps 1 and 2 are independent (parallel). Step 3 depends on 2 (same file).

### Verified Correct (No Changes Needed)

- Frequency table: 12 entries match driver at `5BAE:0147`
- NoteOn math: `note + transpose - 0x18` matches driver
- Operator tables: `Op1Map`/`Op2Map` match driver at `5BAE:0135`
- `HandleNoteOn`/`HandleNoteOff`: already use `_channelTranspose[ch]`

### Decisions

- The 0x20 delta is from SIETCHM.AGD evidence; multi-song validation recommended but not blocking
- `InitOpl` volume writes (0x3F) are overwritten by instrument loads — not priority
- Channel event pointer `SongDataOffset=2` appears correct from header analysis — verify later if issues persist