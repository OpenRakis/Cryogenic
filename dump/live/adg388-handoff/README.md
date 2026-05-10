# AdLib Gold (DNADG) Cloud Handoff

This folder is the live-evidence package captured for cloud agents to
continue Phase B4 / Phase E of the ADG full-player port without
needing a local Spice86 + DOSBOX rig.

## Launch context

- Branch: `reverse/adlib_gold_driver` (PR https://github.com/OpenRakis/Cryogenic/pull/76)
- Emulator: Spice86 via `Cryogenic.csproj`
- Args: `--UseCodeOverride false -a ADG388 --OplMode Opl3Gold -p 4096 --Cycles 8000 -e DNCDPRG.EXE`
- DNCDPRG.EXE SHA256: `5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9`
- Capture script: `scripts/adg/Wait-AdgDriverActive.ps1`

The intro music begins ~13M instructions in. The first long FMV
follows; music resumes after it. Capture timestamps are encoded in
each `adg-driver-active-<stamp>/` subfolder name.

## What's captured

Each `adg-driver-active-<stamp>/`:

| File | Purpose |
| --- | --- |
| `manifest.json` | Resolved ADG segment + total ADP-call counter at capture time |
| `cryogenic_status.json` | Driver1/2/3 segments, MIDI segment, IRQ handler |
| `adp_call_counts.json` | Per-export hit counts + `lastSongSegment` |
| `cfg_cpu_graph.json` | Live CFG (executed nodes only — the ground truth for code vs. data) |
| `dnadg_seg_<seg>_0000_2800.bin` | Full driver image (10 KiB raw) |
| `dnadg_exports_<seg>_0100_0400.bin` | Export-stub region |
| `dnadg_fractions_<seg>_01C7_0040.bin` | **Runtime-populated fraction tables** at offsets 0x01C7 (PitchBend, 13 bytes) and 0x01D4 (Portamento, 10 bytes) — these are zero in `DNADG.UNHSQ` at-rest |
| `*.dump` | Pretty hex+ASCII view of each `.bin` |

## Why fraction tables matter

`AdgPitchBendComputer` is fully ported but `DefaultAdgPitchBendBody`
only emits musically-correct frequency words once a host injects real
fraction-table contents via:

```csharp
engine.SetPitchBendFractionsTable(new AdgPitchBendFractionsTable(bytes));
engine.SetPortamentoFractionsTable(new AdgPortamentoFractionsTable(bytes));
```

The bytes for both tables live inside
`dnadg_fractions_<seg>_01C7_0040.bin`:
- `[0x00..0x0C]` (13 bytes) → PitchBend fractions (driver offset 0x01C7)
- `[0x0D..0x16]` (10 bytes) → Portamento fractions (driver offset 0x01D4)

## Reference dumps already in repo

For a cloud agent without runtime access, the project also commits
the pre-recorded Spice86 dumps at the repo root and under `src/`:

```
5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9/
  spice86dumpExecutionFlow.json   (CFG)
  spice86dumpGhidraSymbols.txt    (address → name)
  spice86dumpListing.asm          (full disassembly)
  spice86dumpCpuRegisters.json    (entry-state register file)
  spice86dumpMemoryDump.bin       (1 MiB conventional memory)
  Breakpoints.json
```

These are the project's source of truth when a runtime replay is not
available.

## Next-phase pointers

- **B4.3b** ProgramChange deep emit — port `AdgProgramChange_0831`,
  `AdgConfigureInstrumentRouting_090D`, `AdgWriteInstrumentPatch_0F95`.
  Patches at `EventBase + index*0x28` in song image.
- **B4.6b** EndOfTrack master-track loop — `AdgTickEnabled` byte
  (driver offset 0x01DF), `AdgResetSchedulerState_06B9`,
  mass-clear-on-last-channel-finish.
- **Phase E** PeriodicTimer hardening + waveform/spectrum fan-out
  (Avalonia oscilloscope window).

Dispatcher state at the time of this handoff: NoteOn, NoteOff,
PitchBend, VolumeModulation (primary+secondary) emit live. ProgramChange,
4-op patches, ConnectionModulation tail, and EndOfTrack loop are
still gated/wait-only.
