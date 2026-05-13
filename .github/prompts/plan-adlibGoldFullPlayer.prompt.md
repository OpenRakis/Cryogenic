# Plan: Full AdLib Gold Music Player (TDD)

Build a working AdLib Gold (DNADG/OPL3) song player on top of the existing scaffold.
Strategy: port the proven `DuneAdpPlayerEngine` skeleton to `DuneAdgPlayerEngine`,
add OPL3-Gold deltas (dual chip, surround, 4-op pairs), wire it into the
`AdgPlaybackHost` already in the UI, then add a managed OPL3 emulator → audio sink.
All cycles strict red→green→refactor; oracles are `src/Cryogenic/Overrides/AdgDriverCode.cs`
and `DuneAdpPlayerEngine.{Tick,Opl}.cs`.

## Phase A — Song container & header (offline data, no audio)

**A1. UNHSQ loader + raw byte access**
- New: `Cryogenic.AdgPlayer/Song/HsqDecoder.cs` (port from Mt32 or reference C)
- New: `Cryogenic.AdgPlayer/Song/AdgSongImage.cs`: immutable wrapper {Bytes, IsCompressed}
- New: `Cryogenic.AdgPlayer/Song/AdgSongLoader.cs`: `Load(byte[]) → AdgSongImage`, `Load(path)`
- Tests: header signature byte sum == 171, size field, decompressed size matches, throw on truncation, round-trip on a hand-crafted micro stream.

**A2. Header parsing (offsets 0x00..0x32)**
- New: `Cryogenic.AdgPlayer/Song/AdgSongHeader.cs`: TempoWord, EndMeasure, LoopMeasure, LoopRepeat, EventStreamOffset, ChannelPointerTableOffset, InstrumentBankOffset.
- Source-of-truth: mirror `AdpSongHeader` reads (file[0x2A]..[0x32]) plus AdgDriverCode.cs `AdgSongPointerOffset` / `AdgSongSegmentOffset`.
- Tests: parse against fabricated header bytes, reject too-small images, validate header layout matches what `AdgSchedulerTick_0756` reads at song+0x30.

**A3. Channel pointer table + event stream view**
- New: `Cryogenic.AdgPlayer/Song/AdgChannelPointers.cs`: 18 ushort offsets read out of the song image.
- Reuse: existing `IAdgEventStream` consumed by `AdgChannelEventReader`; provide `AdgInMemoryEventStream(byte[])` impl.
- Tests: 18 pointers parse correctly, in-memory stream returns the same words `AdgChannelEventReader.TryReadNext` consumes, end-of-stream when pointer==0.

## Phase B — Engine (driver tick that emits OPL writes; no audio yet)

**B1. Engine `Load(byte[])`**
- Modify `DuneAdgPlayerEngine` (currently a 32-line stub):
  - Constructor: `(IOplBus bus)`; ctor without args keeps backward-compat for existing skeleton tests via overload (no optional args rule).
  - `Load(byte[])`: decompress if HSQ, parse header, seed `AdgDriverState` (channel pointers ← `AdgChannelPointers`, wait counters ← initial deltas, measure clock ← Initialize(), master volume ← header byte, fade pattern ← 0xFFFF, tick divider ← header byte).
  - `HasSongLoaded` flips true.
- Tests: load image → state mirrors expected initial values; reject too-small images; reset clears all components (covers the missing `TickDivider.Reset()` bug found earlier — fix `AdgDriverState.Reset()` here).

**B2. OPL write helper layer (`DuneAdgPlayerEngine.Opl.cs`)**
- New partial: `OplRegisterWrite(int chip, byte reg, byte value)` → forwards to `IOplBus`, raises `OplRegisterWritten` event.
- `OplFrequencyWrite(channel, freqWord)`, `OplNoteOn(channel, rawPitch)` (frequency table + block/octave bits), `OplNoteOff(channel)`.
- `InitOplChip()` writes the OPL3 init sequence including OPL3 enable (0x05 on chip 1 = 0x01) and any AdLib Gold surround init.
- Frequency table = same 12-entry table as Adp (verified against AdgDriverCode disasm).
- Tests: each helper emits the exact byte sequence observed in `AdgDriverCode.cs` for that operation, against `RecordingOplBus`.

**B3. Tick scheduler (`DuneAdgPlayerEngine.Tick.cs`) — DONE.**
- Per-channel wait decrement scaffold + auto-dispatch when wait == 0.
- Subdivision/measure clock advance at end of tick (mirrors dnadg:079D-07A8); clock seeded by `Load` to measure=1, subdivision=0x60 (mirrors `AdgResetSchedulerState_06B9` at dnadg:0573).
- `IsPlaying` flips to false when every channel pointer reaches 0 (end-of-song).

**B4. Event dispatch — IN PROGRESS (per-handler TDD).**

Authoritative oracle: `src/Cryogenic/Overrides/AdgDriverCode.cs` (faithful, runtime-verified port of DNADG; no self-modifying code in the on-disk driver image, so static reading of the override is sufficient — no MCP capture required).

**B4.0 Dispatcher framework — DONE** (commit `460f83e`):
- `DispatchEvents(int channelIndex)` reads event words while wait==0 + pointer != 0; routes via `AdgEventOpcodeClassifier` + `AdgEventOpcodeRouter`.
- `ReadWaitValue` (slots 2/3): 7-bit accumulator decode, sets wait counter, advances pointer.
- Initial `EndOfTrack` (slot 7): zeroes channel pointer (later expanded — see B4.6a).

**B4.x measure clock — DONE** (commit `4b2017a`):
- `Tick()` calls `MeasureClock.AdvanceSubdivision()` mirroring dnadg:079D-07A8.

**B4.1a `AdgClearScratchMask_0ACD` pure component — DONE** (commit `b590e7f`):
- `AdgChannelStateScratch` (18-slot ushort table at DI+0x021C).
- `AdgFadeScratchState` (Primary/Secondary cells at 0x013E/0x0140).
- `AdgScratchMaskClearer` static helper, byte-for-byte mirror of dnadg:0ACD.
- All wired into `AdgDriverState`. 6 AAA tests.

**B4.1 NoteOff — DONE** (commit `a104e79`):
- Faithful port of `AdgNoteOff_0AB6` (line 1948): skip velocity, ReadWaitValue, transposed-note compare against current-note slot, clear current-note on match, ScratchMaskClearer with next-event byte.
- New `_routingTable` field + `SetRoutingTable` engine API; OPL key-off emit via `AdgChannelNoteOffEmitter` gated on routing-table presence.
- `AdgFrequencyWordCache` added to `AdgDriverState`. 4 NoteOff dispatch tests.

**B4.2a NoteOn (state-mutation only) — DONE** (commit `4fa21d4`):
- Faithful port of `AdgNoteOn_0A82` state mutations: skip velocity, ReadWaitValue, key-off previous note (routing-gated), store transposed current-note, recenter pitch accumulator.
- Deferred to **B4.2b**: `AdgEnvelopeSetup_0C47` + `AdgNoteOn_10A9` (full OPL emit chain). 4 NoteOn dispatch tests.

**B4.3 / B4.4 / B4.5 ProgramChange / VolumeModulation / PitchBend (state+wait) — DONE** (commit `4813268`):
- ProgramChange: ReadWaitValue + write instrument byte to instrument slot. Deferred to **B4.3b**: `AdgConfigureInstrumentRouting_090D` + `AdgWriteInstrumentPatch_0F95` (deep patch load + OPL emit).
- VolumeModulation: ReadWaitValue only. Deferred to **B4.4b**: full OPL register-emit chain.
- PitchBend: ReadWaitValue only. Deferred to **B4.5b**: `AdgPitchBendBody_0D8B` (~120 lines).
- All 8 dispatcher slots are now routed end-to-end; the `UnhandledOpcodeEncountered` event was removed (no opcode falls through). 3 dispatch tests.

**B4.6a EndOfTrack faithful state mutations — DONE** (commit `765a1bf`):
- Wait counter set to `0xFFFF` (done sentinel); event pointer zeroed; `AdgScratchMaskClearer.Clear` invoked with terminator byte.
- ~~Deferred to **B4.6b**~~: master-track tick-flag decrement, global silence broadcast on last-channel-ended, `AdgResetSchedulerState_06B9` re-init, `AdgCheckLoopPoint_07DA`.

**B4.6b EndOfTrack master-track loop path — DONE** (commit `c93498a`):
- New `AdgTickEnabledCounter` state cell (byte at 0x01DF) seeded by `Load` to `DefaultSeed = 1`.
- Channel 0 takes the master-track path: decrement counter; on zero, bulk-mark every channel wait counter `0xFFFF`; on underflow, restore via `+1`; otherwise re-seed scheduler state (`MeasureClock.Initialize`), run `AdgLoopPointChecker.Check`, and apply the tail decrement (`0xFFFF → 0xFFFE`) on channel 0.
- Channel != 0 keeps the slave-track path (`AdgScratchMaskClearer.Clear`).
- 5 new tests cover tick-zero bulk reset, tick-positive loop path, underflow restore, slave-track counter integrity, and `Load` seed.

**B4.3b.1 ProgramChange patch emit via pre-bound routing — DONE** (this commit):
- `HandleProgramChange` now slices the 40-byte instrument record at `EventBase + instrumentIndex * 0x28` from the loaded song image and emits the full instrument program via `AdgInstrumentPatchEmitter.Emit` when both an `IOplBus` and an `AdgChannelRoutingTable` are bound.
- Surround-mask state cell added to `AdgDriverState` and threaded through the emitter.
- 3 new tests: routing+patch emits the 11-write instrument program (incl. 0xC0 connection register), no routing → state-only, out-of-range patch index → defensive skip with no 0xC0 write.
- ~~Still deferred~~ to **B4.3b.2**: port `AdgConfigureInstrumentRouting_090D` (the 70-line dynamic operator-slot allocator at dnadg:090D) to actively rewrite the routing entries per ProgramChange; today's wiring assumes a pre-bound routing table.

**B4 dispatcher state-machine: COMPLETE.** All 8 opcode slots advance their cursor and mutate the right per-channel slots faithfully per the oracle. Real audio output requires the deferred `.b` cycles (deep OPL emit chains).

**Pending TDD cycles (deep OPL emit chains; each = one commit):**

> **Resumption plan (tomorrow):** the prior cloud-agent handoff is
> **abandoned** and must not be used. All remaining `.b` cycles will be
> driven from **live Spice86 MCP CFG-CPU execution samples** captured
> while ADG388 is actually playing (`mcp_cfg_cpu_graph.json` +
> targeted breakpoint/step traces over the routines below). Static
> override reads stay as a secondary cross-check; runtime CFG is the
> oracle.

- **B4.2b** `AdgEnvelopeSetup_0C47` + `AdgNoteOn_10A9` (NoteOn final emit).
- **B4.3b.2** `AdgConfigureInstrumentRouting_090D` (~70 lines, dynamic operator-slot allocator). B4.3b.1 (patch emit via pre-bound routing) is done.
- **B4.4b** `AdgVolumeModulation_0B2E` body (velocity-scaled operator TL writes).
- **B4.5b** `AdgPitchBendBody_0D8B` (~120-line pitch-accumulator routine).
- ~~**B4.6b** EndOfTrack master-track loop logic~~ — **DONE** (commit `c93498a`).
- **B4.7 LoopCheck** standalone (port `AdgCheckLoopPoint_07DA`): snapshot save at LoopStartMeasure==Measure && Subdivision==0x60; restore at LoopEndMeasure==Measure with `_repeatCounter` decrement.
- **B4.8 PitchModulation** (port `AdgAdvancePitchModulation_07AD`): vibrato during wait.

Tests: each handler increment ships with at least one AAA test that hand-builds the relevant event word(s) and asserts state mutation + OPL bytes against `RecordingOplBus`. Real-song integration test (load `DNADG.UNHSQ`-decoded asset) added at end of B4 to validate the chain.

## Phase C — UI integration (real Play/Stop button, no audio yet)

**C1. Engine ↔ Host wiring**
- `MainWindowViewModel`: construct `DuneAdgPlayerEngine(OplBus)`, then `AdgPlaybackHost(OplBus, engine.Tick)`.
- New `AdgTransportViewModel` commands: `PlayCommand`, `StopCommand`, `LoadSelectedCommand` (RelayCommand from CommunityToolkit.Mvvm).
- Browser `SelectedIndex` change → `LoadSelected` reads file bytes via `IAdgSongLoader` abstraction.
- Tests: command CanExecute reflects HasSongLoaded/IsPlaying; Play starts host; Stop stops it; Load populates `Transport.HasSongLoaded`.

**C2. UI thread marshaling**
- `AdgPlaybackHost.OnTick` currently runs on ThreadPool. Add an optional `tickPostProcess` callback that the VM uses to push deltas into `ObservableCollection`s on the dispatcher.
- Make `AdgChannelGridViewModel.Refresh()` thread-safe: call from a dispatcher-marshalled tick listener that re-reads `AdgDriverState` snapshots, not from the timer thread.
- Tests: simulate 100 ticks via `host.Tick()` (synchronous path) and verify VMs see updated values without throwing; concurrent stress test reading grid while ticks fire.

**C3. OPL writes plumbed to waveform/spectrum**
- For now (no audio): a placeholder `OplToSampleStub` produces a 1-frame square wave per write so the visualizers show *something* during dev. Mark as `[Obsolete]`-style internal until C-D real audio.
- Better: defer this until Phase D and instead leave the visualizers idle until the synth feeds them.

## Phase D — Real audio (OPL3 emulation + sink) — IMPLEMENTED via Spice86 stack

**Decision (locked in):** AdLib Gold music is rendered through the **OPL3 FM core**.
We do **not** ship a separate AdLib-Gold-specific synth. The dual-bank OPL3 surface
(`chip 0` = primary 9 ch, `chip 1` = secondary 9 ch) is a strict superset of the
AdLib Gold OPL3 use case in DNADG.

**Stack (committed in `7105149`):**
- OPL3 emulation: `NukedOPL3Sharp.Opl3Chip` (NuGet, transitive via `Spice86.Core`).
- Audio pipeline: `Spice86.Core.Emulator.Devices.Sound.SoftwareMixer` + `Spice86.Audio`
  (cross-platform output, resampling 49716 → device rate, master + per-channel gain,
  filter chain).
- Glue: `src/Cryogenic.AdgPlayer/Audio/AdgOplSynthesizer.cs` — implements `IOplBus`.
  Production wires it as the inner sink of `OplCaptureBus`; tests still use `NullOplBus`.

**D1. OPL3 synth — DONE.**
- `AdgOplSynthesizer : IOplBus, IDisposable`
- `WriteRegister(int chip, byte register, byte value)` → `_chip.WriteRegisterBuffered((ushort)((chip << 8) | register), value)`
- `Start()` / `Stop()` toggle the mixer channel; `Dispose()` is idempotent
- `OnBeforeRender` hook fires per render batch (audio-clock locking entry point)
- Native rate: `NativeOplSampleRateConst = 49716`
- 8 unit tests (AAA): ctor, dual-bank dispatch, invalid-chip throw, start/stop, volume clamp, dispose idempotency, hook settable

**D2. Audio output device — DONE (delegated).**
- `Spice86.Audio` provides the cross-platform output device; `SoftwareMixer` owns the ring buffer.
- No Avalonia-side audio code is needed.

**D3. Render pipeline — DONE.**
- `MainWindowViewModel` 5-arg ctor injects an `IOplBus` + optional `AdgOplSynthesizer`.
- `App.axaml.cs` builds `new AdgOplSynthesizer()` once, passes it as both the inner bus and the synth handle, disposes on app exit.
- `AdgPlayerSessionViewModel` raises `PlaybackStarted` / `PlaybackStopped`; main VM hooks them to `synth.Start()` / `synth.Stop()`.
- Test ctors keep `NullOplBus` so unit tests stay headless (no audio device).
- Waveform/Spectrum fan-out: pending (will tap `OnBeforeRender` → push float buffer to view-models).

## Phase E — Hardening

- E1. ~~Bound the inner `RecordingOplBus`~~ — **DONE**. Optional
  `capacity` ctor argument (default unbounded preserves existing
  tests); when set, the recorder evicts oldest entries and exposes a
  `DroppedCount` counter. Five additive tests.
- E2. ~~Cancellation on Stop: drain in-flight ticks, dispose synth
  cleanly~~ — **DONE** (already implemented in `AdgPlaybackHost.Stop`
  via `Timer.Dispose(WaitHandle)` + `ManualResetEvent` drain).
- E3. Replace `OnTick` ThreadPool timer with a periodic
  high-resolution timer (`PeriodicTimer` on a dedicated background
  thread) for jitter < 1 ms. **DEFERRED** — current `Timer` jitter is
  acceptable for the playback host and replacement is risky without a
  jitter-measurement harness.
- E4. ~~Add an integration "smoke test" that loads a real `.UNHSQ`
  asset, ticks 1000 times, asserts state mutation~~ — **DONE**. Three
  tests in `DuneAdgPlayerEngineSmokeTests.cs` load
  `doc/DUNECDVF/C/DUNECD/DUNE.DAT_/ARRAKIS_AGD.HSQ` end-to-end and
  validate Load + 1000-tick dispatch + bounded recording bus.

**Steps**

1. **Phase A** (parallel possible after A1): A1 → A2 → A3
2. **Phase B**: B1 → B2 → B3 → B4 (strict order: each builds on the prior)
3. **Phase C**: C1 → C2 → C3 (C3 optional / deferred)
4. **Phase D**: D1 (decision needed) → D2 → D3
5. **Phase E**: E1, E2, E3, E4 (any order, last)

**Relevant files**
- `src/Cryogenic/Overrides/AdgDriverCode.cs` — oracle for header layout (`AdgSongPointerOffset`), scheduler (`AdgSchedulerTick_0756`), OPL writes (search for register 0xA0/0xB0/0x20–0x80).
- `src/Cryogenic.AdpPlayer/Services/DuneAdpPlayerEngine.{Tick,Opl}.cs` — direct template for the engine.
- `src/Cryogenic.Mt32Player/Services/DuneM32PlayerEngine.cs` — `TryDecompressHsq` reference; reuse decoder.
- `src/Cryogenic.AdgPlayer/Driver/Adg*.cs` — the 14 already-tested components to compose.
- `src/Cryogenic.AdgPlayer/Services/DuneAdgPlayerEngine.cs` — the 32-line stub to flesh out.
- `src/Cryogenic.AdgPlayer.Ui/Playback/AdgPlaybackHost.cs` — already exists; just plug `engine.Tick` into it.
- `src/Cryogenic.AdgPlayer.Ui/ViewModels/MainWindowViewModel.cs` and `AdgTransportViewModel.cs` — add commands.
- `OpenRakis/tools/dune-ds/source/unhsq.c` — UNHSQ reference.
- `doc/DUNECDVF/C/DUNECD/DUNE.DAT_/*.UNHSQ` — already-decompressed assets for offline tests (no DUNE.DAT needed).

**Verification**
1. After each phase: full `dotnet build src/Cryogenic.sln` 0/0, full `dotnet test` green.
2. After A: load every `*.UNHSQ` in `doc/DUNECDVF/C/DUNECD/DUNE.DAT_/` (decompressed bundle present in repo) → no exceptions, 18 channel pointers each.
3. After B: synthesize 2-channel song bytes → `engine.Tick()` → `RecordingOplBus.Writes` contains the OPL sequence we hand-derived from `AdgDriverCode.cs` for that song.
4. After C: launch the app (`dotnet run --project src/Cryogenic.AdgPlayer.Ui`), pick a song in the browser, click Play, observe the channel grid updating live, log panel shows tick events, OPL writes panel scrolls. (No sound yet.)
5. After D: same scenario produces audible audio matching DOSBox-X reference for the same `.UNHSQ`.
6. After E: 60-second playback → < 1 ms jitter (measured via `host.TickIntervalMilliseconds` deltas), no buffer underruns, memory steady.

**Decisions**
- **Game assets ARE in the repo**: `doc/DUNECDVF/C/DUNE.DAT`, `doc/DUNECDVF/C/DNCDPRG.EXE`, and decompressed `doc/DUNECDVF/C/DUNECD/DUNE.DAT_/DNADG.UNHSQ`. Live MCP runtime evidence is therefore obtainable for B4.
- **Audio stack: Spice86.** OPL3/AdLib Gold music goes through `NukedOPL3Sharp.Opl3Chip` + `Spice86.Audio` + `SoftwareMixer`. No custom audio device, no NAudio, no OpenAL.
- **AdLib Gold = OPL3 FM.** Dual-bank OPL3 covers AdLib Gold music output for DNADG; no separate Gold-only synth path.
- **No .Result / no .Wait()** in audio pipeline (async-discipline rule). Render thread is owned by `SoftwareMixer`.
- **Reuse over reimplement**: HSQ decoder, frequency table, dispatch shape come from existing Adp/Mt32 engines.

**Further Considerations**
1. ~~Phase D OPL3 emulator choice~~ — **resolved**: Spice86 stack (NukedOPL3Sharp + Spice86.Audio).
2. `IAdgSongLoader` shape — just a `(string path) → byte[]` wrapper, or a richer one that already returns `AdgSongImage`? Recommend the latter so the VM doesn't see raw bytes.
3. Whether to keep `AdpPlayer` and `AdgPlayer` engines as siblings or extract a shared `DuneTrackerEngineBase`. Recommend siblings until both engines are fully working — premature abstraction risk.
4. **B4 evidence capture**: with `DNCDPRG.EXE` available, drive Spice86 MCP through `adg-opl3-runtime-reverse` agent on a known song, capture per-tick OPL register sequence, port event opcodes from `DuneAdpPlayerEngine.Tick.cs` adapted to dual-bank OPL3.
