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

**B3. Tick scheduler (`DuneAdgPlayerEngine.Tick.cs`)**
- Mirror `AdgSchedulerTick_0756`: tempo accumulate, measure clock advance, per-channel wait decrement, dispatch.
- 8-handler switch (NoteOff, NoteOn, Wait1, Wait2, ProgramChange, VolumeModulation, PitchBend, EndOfTrack) — same shape as Adp; implementations use `AdgChannel*` components and the new Opl helpers.
- Tests: feed each handler a hand-built event stream and assert resulting OPL writes + channel state.

**B4. End-of-song & loop**
- `AdgCheckLoopPoint_07DA` mirror: when measure == LoopMeasure, restore snapshot pointers; when all channel pointers == 0, raise `EndOfSong` event and clear `IsPlaying`.
- Tests: synthesized 2-channel song with explicit EndOfTrack words; verify EndOfSong fires, IsPlaying false; verify loop snapshot restoration on a song with LoopMeasure.

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

## Phase D — Real audio (OPL3 emulation + sink)

**D1. OPL3 emulator selection**
- Pick one: (a) port nuked-opl3 from C, (b) integrate via P/Invoke, (c) use Spice86's existing OPL3 implementation if shippable as a library.
- Decision: *use Spice86's `Spice86.Core.Emulator.Devices.Sound.Ymf262Emu`* if exposed publicly; else port nuked-opl3 (smallest pure-C, ~1k lines).
- New: `Cryogenic.AdgPlayer.Ui/Audio/Opl3Synth.cs`: wraps emulator, `Render(float[] interleaved, int frames)`, `WriteRegister(chip, reg, value)`.
- Tests: golden register sequences (note on at A4) produce non-silent buffer; offline render of 100 ms matches expected RMS bracket.

**D2. Audio backend**
- Avalonia 11 has no built-in audio. Pick: NAudio (Win-only) or OpenAL.NET (cross-platform).
- New: `Cryogenic.AdgPlayer.Ui/Audio/AudioOutputDevice.cs`: 44.1 kHz stereo float, ring buffer fed by render thread.
- Tests: write 1 second of silence, no underrun; write known sine, peek output buffer.

**D3. Render pipeline**
- Replace `OplCaptureBus`'s downstream `RecordingOplBus` with `Opl3Synth` once a song plays.
- A render thread pulls samples from `Opl3Synth.Render(...)` at audio rate, pushes to `AudioOutputDevice`, AND fan-outs to `Waveform`/`Spectrum` view-models on the UI thread.
- Tests: integration — load synthesized 2-channel song image, run host for 200 ticks, assert audio buffer non-silent, waveform `HasSignal == true`.

## Phase E — Hardening

- E1. Bound the inner `RecordingOplBus` (current memory leak risk).
- E2. Cancellation on Stop: drain in-flight ticks, dispose synth cleanly.
- E3. Replace `OnTick` ThreadPool timer with a periodic high-resolution timer (`PeriodicTimer` on a dedicated background thread) for jitter < 1 ms.
- E4. Add an integration "smoke test" that loads `DNAGD` test asset (the small one already in `OpenRakis/`), ticks 1000 times, asserts non-silent output and >0 OPL writes per channel.

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
- **No DUNE.DAT, no DNCDPRG.EXE** in this env. We rely on `doc/DUNECDVF/C/DUNECD/DUNE.DAT_/*.UNHSQ` which is committed.
- **No .Result / no .Wait()** in audio pipeline (async-discipline rule). Render loop on a dedicated thread, not async.
- **Reuse over reimplement**: HSQ decoder, frequency table, dispatch shape come from existing Adp/Mt32 engines.
- **Deferred**: real audio (Phase D) is *behind* a working tick-only pipeline (Phase C). The user can see the player "do something" after Phase C without waiting for the synth.

**Further Considerations**
1. Phase D OPL3 emulator choice — three options; recommend (a) check Spice86.Core for an exposed OPL3 type first (cheapest); (b) port nuked-opl3 (cleanest fallback); (c) avoid C P/Invoke (deployment headache).
2. `IAdgSongLoader` shape — just a `(string path) → byte[]` wrapper, or a richer one that already returns `AdgSongImage`? Recommend the latter so the VM doesn't see raw bytes.
3. Whether to keep `AdpPlayer` and `AdgPlayer` engines as siblings or extract a shared `DuneTrackerEngineBase`. Recommend siblings until both engines are fully working — premature abstraction risk.
