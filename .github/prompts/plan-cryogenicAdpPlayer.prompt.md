# Plan: Cryogenic.AdpPlayer — Standalone OPL2 Music Player

## TL;DR
Build a standalone Dune CD OPL2/FM music player as a new Avalonia project, using the **full Spice86 audio stack** (Opl3Fm → SoftwareMixer → Spice86.Audio) to sound identical to the emulator. Copy the MT32 player's UI/MVVM/infrastructure wholesale, replace Mt32MidiSynth with an Opl2Synth that wraps Spice86's Opl3Fm, and rewrite the engine's event dispatch to match the DNADP driver's decoded OPL2 event handlers. Use partial classes throughout to keep files short.

## Key Architectural Decisions
- **Spice86.Audio replaces NAudio** — use AudioEngine.CrossPlatform (WASAPI/ALSA/CoreAudio), not WaveOutEvent
- **Full Spice86 Opl3Fm + SoftwareMixer pipeline** — includes resampling (49716→48000Hz), reverb, chorus, noise gate, master gain — identical to emulator audio
- **Pure OPL2** — DNADP only uses ports 0x388/0x389 (confirmed by live memory search), no SB DSP/mixer/OPL3 bank1
- **Timing: Audio-callback-driven** — SoftwareMixer's AudioCallback drives Opl3Fm, which needs an IEmulatedClock; engine ticks are advanced from a timer or the mixer callback
- **Partial classes** for the engine: `.cs` (fields/load), `.Tick.cs` (scheduler), `.Hsq.cs` (decompress), `.Opl.cs` (OPL2 register write helpers + event handlers), `.Diagnostics.cs` (debug)

## Phase 1 — Project Scaffolding

### Step 1.1: Create project + sln entry
- Create `src/Cryogenic.AdpPlayer/Cryogenic.AdpPlayer.csproj`
- Target: net10.0 WinExe, same analyzer settings as MT32 player
- Dependencies: Spice86 v12.0.0 (brings Spice86.Core + Spice86.Audio transitively), Avalonia 11.3.12, CommunityToolkit.Mvvm, Xaml.Behaviors.Avalonia
- NO NAudio, NO Mt32emu.net
- Add to `src/Cryogenic.sln`

### Step 1.2: Copy generic infrastructure (verbatim from MT32 player, rename namespace)
Files to copy with namespace change `Cryogenic.Mt32Player` → `Cryogenic.AdpPlayer`:
- `Program.cs` — entry point (identical)
- `App.axaml` + `App.axaml.cs` — Avalonia app (rename M32 references to "song")
- `Views/MainWindow.axaml` — UI layout (change title to "Cryogenic ADP Player", rename "ROM Path" → remove, rename "M32 Path" → "Song Path")
- `Views/MainWindow.axaml.cs` — codebehind (identical)
- `Views/WaveformControl.cs` — oscilloscope (identical)
- `Behaviors/ScrollToEndBehavior.cs` — auto-scroll (identical)
- `ViewModels/ViewModelBase.cs` — base (identical)
- `ViewModels/ChannelTrackerRowViewModel.cs` — channel row (identical)
- `ViewModels/LogDisplayItem.cs` — log display (identical)
- `ViewModels/EventFlowDisplayItem.cs` — event display (identical)
- `Services/SongHeaderInfo.cs` — song metadata (identical)
- `Services/EventFlowEntry.cs` — event log entry (identical)
- `Services/PlayerDiagnosticsSnapshot.cs` — diagnostics (identical)
- `Services/AudioDebugInfo.cs` — audio debug (identical)
- `Services/GoldenCaptureModels.cs` — golden capture (identical)
- `Services/PlayerControlServer.cs` — HTTP control API (identical)
- `Services/MidiDeviceBase.cs` — NOT NEEDED (this is MIDI-specific)

### Step 1.3: Copy + adapt ViewModel
- `ViewModels/MainWindowViewModel.cs` — copy from MT32 player:
  - Remove ROM path fields (OPL2 doesn't need ROMs)
  - Rename `M32Path` → `SongPath`
  - Change `EnsurePlayerInitialized()` to create `Opl2Synth` + `DuneAdpPlayerEngine`
  - Remove SendMidi diagnostic methods (replace with OPL-specific diagnostics if needed)

## Phase 2 — Opl2Synth (replaces Mt32MidiSynth)

### Step 2.1: Create `Services/Opl2Synth.cs`
New class wrapping the full Spice86 audio stack:

**Constructor creates:**
1. `IPauseHandler` stub (simple implementation with events)
2. `SoftwareMixer(AudioEngine.CrossPlatform, pauseHandler)` — creates mixer thread + audio backend
3. `State(CpuModel.INTEL_8086)` — minimal CPU state
4. `IEmulatedClock` stub — tracks elapsed time via Stopwatch
5. `AddressReadWriteBreakpoints` — empty (needed by IOPortDispatcher)
6. `IOPortDispatcher(breakpoints, state, logger, failOnUnhandled: false)`
7. `OplConfig(OplMode.Opl2, SbBase: 0x388, SbMixer: false)`
8. `Opl3Fm(config, mixer, state, clock, ioPortDispatcher, false, logger)` — registers OPL channel in mixer

**Public API:**
- `void WriteRegister(byte register, byte value)` — calls `Opl3Fm.WriteByte(0x388, register)` then `Opl3Fm.WriteByte(0x389, value)`
- `Action<int>? OnBeforeRender` — callback for tick advance (same pattern as Mt32MidiSynth)
- `float OutputGain` / `float LastPeak` — audio level monitoring
- `event Action<float>? AudioPeakComputed`
- `event Action<float[], int>? AudioSamplesRendered` — for waveform display
- `void Dispose()`

**Timing model:** The SoftwareMixer's thread drives Opl3Fm's AudioCallback. The engine hooks into timing via the `IEmulatedClock.ElapsedTimeMs` plus a separate timer or periodic check.

### Step 2.2: Create `Services/Opl2Synth.Stubs.cs` (partial)
Minimal stub implementations:
- `StandalonePauseHandler : IPauseHandler` — IsPaused=false, no-op events
- `StandaloneEmulatedClock : IEmulatedClock` — Stopwatch-based ElapsedTimeMs
- `StandaloneLoggerService : ILoggerService` — Serilog console logger

## Phase 3 — Engine Core (DuneAdpPlayerEngine)

### Step 3.1: Create `Services/DuneAdpPlayerEngine.cs` (main partial)
Copy from `DuneM32PlayerEngine.cs`:
- Replace `Mt32MidiSynth _synth` → `Opl2Synth _synth`
- Keep: song data, channel arrays (9 channels), accumulator, measure, subdivision, repeatCounter, tickIncrement, fadeBitPattern, volume state, statusFlags, tickFlag
- Add DNADP-specific channel state per the decoded driver:
  - `byte[] _channelInstrument` (9) — current instrument number
  - `byte[] _channelNote` (9) — current note (0=off)
  - `byte[] _channelTranspose` (9) — transpose offset
  - `ushort[] _channelFreq` (9) — stored F-number per channel (for note-off)
  - `ushort[] _channelEnvelopePhase` (9)
  - `byte[] _channelEnvelopeRate` (9)
  - `byte[] _channelAttackPhase` (9)
  - Per-channel operator config words (mirroring the SOA layout from driver)
- Keep: Load(), Start(), Pause(), Resume(), Stop(), Dispose()
- Adapt Load() to parse song header (same format as M32: eventBase at [0..1], 9 channel offsets at [2..19], endMeasure/loopMeasure/loopRepeat/tickIncrement at [0x2C..0x33])
- Adapt Load() to locate instrument table pointer (from eventBase offset in song data)

### Step 3.2: Create `Services/DuneAdpPlayerEngine.Hsq.cs` (partial)
- **VERBATIM copy** from `DuneM32PlayerEngine.Hsq.cs`
- Only change: namespace + class name

### Step 3.3: Create `Services/DuneAdpPlayerEngine.Tick.cs` (partial)
Copy scheduler from `DuneM32PlayerEngine.Tick.cs`:
- Keep: AdvanceSamples(), TickInternal(), ProcessTick(), AdvanceSubdivision(), CheckSongEnd()
- Keep: Same PIT constants (PitReloadValue=0x1745, PitInputClock=1193182, SampleRate=48000)
- **Rewrite ProcessChannel()**: DNADP event dispatch differs from DNMID
  - Read 2-byte event word (same encoding: status+data)
  - Extract bits 4-6 → handler class index (0-7)
  - Call appropriate handler (different from MIDI handlers)
- **Rewrite event handlers** — 8 classes from DNADP decode:
  - Class 0 (0x8x): HandleNoteOff(ch, statusByte, dataByte)
  - Class 1 (0x9x): HandleNoteOn(ch, statusByte, dataByte)
  - Class 2/3 (0xAx/0xBx): HandleWaitOnly(ch) — delta decoder only
  - Class 4 (0xCx): HandleProgramChange(ch, statusByte, dataByte)
  - Class 5 (0xDx): HandleVolumeModulation(ch, statusByte, dataByte)
  - Class 6 (0xEx): HandlePitchBend(ch, statusByte, dataByte)
  - Class 7 (0xFx): HandleEndOfTrack(ch)
- **Rewrite ReadWait()** — DNADP wait decoder (0x08E1) uses a different VLQ than DNMID:
  - Reads bytes; if bit 7 set, accumulates into multi-byte wait
  - Exact algorithm decoded from disasm at 0x08E1

### Step 3.4: Create `Services/DuneAdpPlayerEngine.Opl.cs` (partial)
DNADP-specific OPL2 register write helpers, all translated from live disassembly:
- `void OplWrite(byte register, byte value)` — calls `_synth.WriteRegister(register, value)`
- `void NoteOn(int channel, int note)` — from 0x0A58: freq table lookup, block calc, write 0xA0+ch, 0xB0+ch|0x20
- `void NoteOff(int channel)` — from 0x0A87: read stored freq, clear key-on bit
- `void WriteFrequency(int channel, ushort freqData)` — from 0x0A8F: split into 0xA0+ch and 0xB0+ch
- `void WriteInstrument(int channel, int instrumentIndex)` — from 0x09AB+0x05AA: read 40-byte instrument data, write 6 OPL regs per operator
- `void SetupOperatorEnvelope(int channel)` — from 0x0740: calculate operator levels based on velocity/expression
- `void HandleVolumeModulation(int channel, byte velocity)` — from 0x06A8: adjust operator levels and feedback
- `void HandlePitchBend(int channel, byte bendValue)` — from 0x07EA: frequency recalculation with semitone table
- `void AllNotesOff()` — silence all 9 channels
- `void InitOpl()` — from 0x02D8: write init sequence (0x2001, 0x00BD, 0x4008)
- Static data tables:
  - `FrequencyTable[12]` — F-numbers from 0x0147
  - `Operator1Map[9]` — modulator offsets from 0x0171
  - `Operator2Map[9]` — carrier offsets from 0x017A
  - `OperatorPairTable[18]` — from 0x0135
  - `NoteTable[24]` — from 0x0183
  - `PitchTable[10]` — from 0x0190 (first 10 valid bytes)

### Step 3.5: Create `Services/DuneAdpPlayerEngine.Diagnostics.cs` (partial)
- Copy from `DuneM32PlayerEngine.Diagnostics.cs` with adaptations
- Replace MIDI-specific histogram/tracking with OPL register tracking
- Keep: golden capture infrastructure, snapshot emission, event flow

## Phase 4 — Integration + UI Polish

### Step 4.1: Wire up ViewModel → Engine → Synth
In MainWindowViewModel.EnsurePlayerInitialized():
1. Create `Opl2Synth()`
2. Create `DuneAdpPlayerEngine(synth)`
3. Wire OnBeforeRender callback for audio-driven ticking
4. Wire AudioPeakComputed/AudioSamplesRendered for waveform
5. Wire engine events (SnapshotProduced, LogProduced, etc.)

### Step 4.2: Adapt UI for OPL2
- MainWindow.axaml: Remove ROM path row, rename "M32 File" → "Song File (HSQ/M32)"
- App.axaml.cs: Change CLI arg from `--m32` to `--song`
- Window title: "Cryogenic ADP Player" or "Cryogenic OPL2 Player"

### Step 4.3: Song file browsing
- File filter for *.HSQ, *.M32 (same decompressed format)
- Could also support raw decompressed data with header detection

## Phase 5 — Verification

### Step 5.1: Build verification
- `dotnet build src/Cryogenic.AdpPlayer/` must succeed
- No warnings (TreatWarningsAsErrors=true)

### Step 5.2: Audio playback test
- Launch player, load a decompressed HSQ song
- Verify OPL2 audio output through speakers
- Compare with emulator playback (launch Spice86 with ADP330 SBP2227 config)

### Step 5.3: Timing verification
- Compare measure/subdivision advancement rate with emulator
- Verify loop behavior matches (endMeasure, loopMeasure, loopRepeat)

### Step 5.4: Instrument verification
- Verify program changes load correct OPL2 instrument patches
- Compare note-on frequencies with emulator OPL register captures

## Relevant Files

### Files to CREATE:
- `src/Cryogenic.AdpPlayer/Cryogenic.AdpPlayer.csproj`
- `src/Cryogenic.AdpPlayer/Program.cs`
- `src/Cryogenic.AdpPlayer/App.axaml` + `App.axaml.cs`
- `src/Cryogenic.AdpPlayer/Views/MainWindow.axaml` + `.axaml.cs`
- `src/Cryogenic.AdpPlayer/Views/WaveformControl.cs`
- `src/Cryogenic.AdpPlayer/Behaviors/ScrollToEndBehavior.cs`
- `src/Cryogenic.AdpPlayer/ViewModels/ViewModelBase.cs`
- `src/Cryogenic.AdpPlayer/ViewModels/MainWindowViewModel.cs`
- `src/Cryogenic.AdpPlayer/ViewModels/ChannelTrackerRowViewModel.cs`
- `src/Cryogenic.AdpPlayer/ViewModels/LogDisplayItem.cs`
- `src/Cryogenic.AdpPlayer/ViewModels/EventFlowDisplayItem.cs`
- `src/Cryogenic.AdpPlayer/Services/Opl2Synth.cs`
- `src/Cryogenic.AdpPlayer/Services/Opl2Synth.Stubs.cs`
- `src/Cryogenic.AdpPlayer/Services/DuneAdpPlayerEngine.cs`
- `src/Cryogenic.AdpPlayer/Services/DuneAdpPlayerEngine.Hsq.cs`
- `src/Cryogenic.AdpPlayer/Services/DuneAdpPlayerEngine.Tick.cs`
- `src/Cryogenic.AdpPlayer/Services/DuneAdpPlayerEngine.Opl.cs`
- `src/Cryogenic.AdpPlayer/Services/DuneAdpPlayerEngine.Diagnostics.cs`
- `src/Cryogenic.AdpPlayer/Services/SongHeaderInfo.cs`
- `src/Cryogenic.AdpPlayer/Services/EventFlowEntry.cs`
- `src/Cryogenic.AdpPlayer/Services/PlayerDiagnosticsSnapshot.cs`
- `src/Cryogenic.AdpPlayer/Services/AudioDebugInfo.cs`
- `src/Cryogenic.AdpPlayer/Services/GoldenCaptureModels.cs`
- `src/Cryogenic.AdpPlayer/Services/PlayerControlServer.cs`

### Files to REFERENCE (not copy):
- `src/Cryogenic.Mt32Player/Services/DuneM32PlayerEngine.cs` — template for engine
- `src/Cryogenic.Mt32Player/Services/DuneM32PlayerEngine.Tick.cs` — template for tick/scheduler
- `src/Cryogenic.Mt32Player/Services/Mt32MidiSynth.cs` — pattern for Opl2Synth
- `Spice86/src/Spice86.Core/Emulator/Devices/Sound/Opl3Fm.cs` — OPL3 synthesis, WriteByte, AudioCallback, AddChannel
- `Spice86/src/Spice86.Core/Emulator/Devices/Sound/SoftwareMixer.cs` — mixer thread, AddChannel()
- Session memory: `/memories/session/dnadp-complete-decode.md` — all DNADP disassembly data tables

### Files to MODIFY:
- `src/Cryogenic.sln` — add Cryogenic.AdpPlayer project entry

## Key Spice86 Dependencies for Opl2Synth

Constructor chain to instantiate standalone OPL2 audio:
```
AudioEngine.CrossPlatform
  → SoftwareMixer(audioEngine, IPauseHandler)
    → AudioPlayerFactory → CrossPlatformAudioPlayer (WASAPI/ALSA/CoreAudio)
  → State(CpuModel.INTEL_8086)
  → AddressReadWriteBreakpoints()
  → IOPortDispatcher(breakpoints, state, logger, false)
  → OplConfig(OplMode.Opl2, 0x388, false)
  → Opl3Fm(config, mixer, state, clock, ioPortDispatcher, false, logger)
    → mixer.AddChannel(AudioCallback, 49716, "Opl3Fm", features)
    → Opl3Chip._chip for NukedOPL3Sharp synthesis
```

OPL register writes: `Opl3Fm.WriteByte(0x388, register)` then `Opl3Fm.WriteByte(0x389, value)`
This triggers `RenderUpToNow()` for cycle-accurate audio, then `PortWrite()` into the NukedOPL3Sharp chip.

## Decisions
- Copy files rather than share code between MT32 player and ADP player — same as MT32 player's philosophy of self-contained copies
- Use Spice86 NuGet v12.0.0 (same as Cryogenic main project) for audio stack
- OplMode.Opl2 (not Opl3) — matches DNADP driver's hardware scope
- SbMixer: false — DNADP never writes SB mixer registers
- Timing: PIT constants are identical between DNMID and DNADP (same song format, same tick model)
- 9 channels only (OPL2 max), matching DNADP driver
