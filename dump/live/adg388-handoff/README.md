# AdLib Gold (DNADG) Cloud Handoff

This folder is the live-evidence package captured for cloud agents to
continue Phase B4 / Phase E of the ADG full-player port without
needing a local Spice86 + DOSBOX rig.

## Launch context

- Branch: `reverse/adlib_gold_driver` (PR <https://github.com/OpenRakis/Cryogenic/pull/76>)
- Emulator: Spice86 via `Cryogenic.csproj`
- Args: `--UseCodeOverride false -a "ADG388 SBP2227" --OplMode Opl3Gold -p 4096 --Cycles 100000 -e DNCDPRG.EXE`
  - **`SBP2227` PCM suffix is mandatory** — without it the music driver chain isn't fully wired and `cryogenic_status` reports `actualMidiSegment=0x0000`.
  - Single-string `-a` value with the space-delimited prefix+suffix; quote with double quotes.
- DNCDPRG.EXE SHA256: `5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9`
- Capture script: `scripts/adg/Wait-AdgDriverActive.ps1`

The intro music begins ~13M instructions in. The first long FMV
follows; music resumes after it. Capture timestamps are encoded in
each `adg-driver-active-<stamp>/` subfolder name.

> Note: with `--UseCodeOverride=false` the
> `cryogenic_adp_call_counts` MCP tool stays empty (it counts
> override entries, not original ASM execution). Use the
> `search_memory` signature path
> (`E9FC03E92005E95804E90405E9AF04E9E405E99604`) instead — that's
> the export-stub `JMP` table at driver offset 0x0100. When found at
> linear segment `S` with offset 0, the canonical driver segment is
> `S - 0x10` (the resource-header carve-out).

## What's captured

Each `adg-driver-active-<stamp>/`:

| File | Purpose |
| --- | --- |
| `manifest.json` | Resolved ADG segment + capture metadata |
| `cryogenic_status.json` | Driver1/2/3 segments, MIDI segment, IRQ handler |
| `adp_call_counts.json` | Per-export hit counts + `lastSongSegment` |
| `cfg_cpu_graph.json` | Live CFG (executed nodes only — the ground truth for code vs. data) |
| `dnadg_5BAE_image_0100_4374.bin` | **Full driver image** (4374 bytes) read from `0x5BAE:0x0100` — matches `DNADG.UNHSQ` length and headers but with 318 bytes of runtime-populated state |
| `dnadg_5BAE_0100_0400.bin` / `.dump` | First 1 KB of the driver (covers all export stubs + early state) |
| `dnadg_5BAE_01C7_fractions.bin` / `.dump` | **Runtime-populated fraction tables** at offsets 0x01C7 (PitchBend, 13 bytes) and 0x01D4 (Portamento, 10 bytes) — these are zero in `DNADG.UNHSQ` at-rest |
| `at_rest_vs_runtime_diff.json` | Byte-by-byte diff between the at-rest `DNADG.UNHSQ` and the runtime image — pinpoints every byte the driver populates during `Init` |
| `game_seg_0F4B_0000_100.bin` | Game state head (DS=0x0F4B), useful for measuring tick counters |
| `song_seg_5BAE_minus_0_2K.bin` | 2 KB read at `0x5BAE:0x0000` — first 256 bytes are the resource header (mostly `0x80`); after offset 0x100 it is the driver image |

### Captured fraction-table values (recorded from a live run)

```
0x01C7  PitchBend (13 bytes):  13 15 15 17 19 1A 1B 1D 1F 21 23 24 25
0x01D4  Portamento (10 bytes): 00 05 0A 0F 14 00 06 0C 12 18
```

These exact values can be hard-coded into a host harness if the cloud
agent does not replay the emulator.

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
