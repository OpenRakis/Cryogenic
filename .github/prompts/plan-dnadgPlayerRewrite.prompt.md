---
description: "Plan a full DNADG player rewrite from verified overrides and live traces while keeping one csproj and one partial engine class."
name: "Plan DNADG Player Rewrite"
argument-hint: "Add any extra rewrite constraints or acceptance gates"
agent: "Plan"
---

Plan the DNADG player rewrite under these fixed constraints:

- Single csproj only.
- Single DNADG core engine partial class only.
- Source of truth is the verified DNADG override behavior plus live traces, not the current standalone player.
- Salvage only genuinely generic pieces such as HSQ decompression, PIT/timer cadence logic, and a thin OPL sink.

Use the full plan below as the default implementation strategy unless the user provides stricter constraints in the current chat.

1. Phase 0: Lock the rewrite constraints and boundaries.
2. Keep a single project: c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Cryogenic.AdgPlayer.Ui.csproj remains the only player project. Do not introduce a separate core csproj.
3. Keep a single engine type: retain one DNADG engine partial class as the core implementation surface. Recommended approach: keep the existing DuneAdgPlayerEngine type name to minimize host churn, but replace its behavior completely.
4. Treat the current engine implementation as legacy reference only: c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Services\DuneAdgPlayerEngine.cs, c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Services\DuneAdgPlayerEngine.Tick.cs, and c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Services\DuneAdgPlayerEngine.Opl.cs should be rewritten, not repaired piecemeal.
5. Preserve only audited generic code: c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Services\DuneAdgPlayerEngine.Hsq.cs, the PIT cadence logic in AdvanceSamples/TickInternal, and c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Services\OplSynthesizer.cs if it remains a sink with no DNADG semantics hidden inside it.
6. Fix the single project foundation first: change WinExe to Exe, remove Windows-only assumptions, and keep path defaults out of engine behavior. This should be done before deeper rewrite work because it affects validation and shipping.
7. Phase 1: Build the executable specification from the correct source of truth. Depends on 1-6.
8. Use c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic\Overrides\AdgDriverCode.cs as the semantic specification. Extract the exact state model, exported entrypoints, body targets, event handlers, route-byte semantics, pitch/fade math, loop snapshot behavior, Gold global volume behavior, and surround serialization behavior.
9. Reuse the existing evidence workflow instead of inventing new scripts. Capture golden traces with c:\Users\noalm\source\repos\Cryogenic\scripts\adg\Start-AdgMcpCompare.ps1 and the current live MCP workflow, using override-enabled Cryogenic as expected behavior.
10. Build a fixed corpus from c:\Users\noalm\source\repos\Cryogenic\DUNE.DAT_ and c:\Users\noalm\source\repos\Cryogenic\doc\DUNECDVF\C\DUNECD\DUNE.DAT_. Include at least one basic track, one loop-heavy track, one pitch-bend-heavy track, one patch-type-4 track if identified, and one track exercising Gold surround or secondary-chip routing.
11. Capture golden artifacts per corpus song: open/load state snapshot, per-tick event sequence, per-tick measure/subdivision state, route allocation state, OPL register timeline, secondary-chip write timeline, SetVolume/SetDynamics behavior, and end-of-track/loop behavior.
12. Phase 2: Redesign the engine inside one partial class. Depends on Phase 1.
13. Keep one partial class and organize it by behavior slices instead of multiple engine classes. Recommended file layout inside the same project:
14. DuneAdgPlayerEngine.cs: public API, lifecycle, transport wiring, disposal, top-level fields.
15. DuneAdgPlayerEngine.State.cs: named runtime state, constants, lookup tables, and any data-only nested types needed for parity.
16. DuneAdgPlayerEngine.Load.cs: HSQ/raw song loading, header parse, event base, instrument bank, loop metadata.
17. DuneAdgPlayerEngine.Tick.cs: deterministic Tick entry, scheduler, loop handling, tick-enabled logic, fade rotation.
18. DuneAdgPlayerEngine.Events.cs: NoteOff, NoteOn, ReadWait, ProgramChange, VolumeModulation, PitchBend, EndOfTrack.
19. DuneAdgPlayerEngine.Routing.cs: route allocator, patch-type handling, operator route derivation, primary/secondary routing semantics.
20. DuneAdgPlayerEngine.Gold.cs: command latch/release, ready polling semantics, global volume writes, surround mask serializer.
21. DuneAdgPlayerEngine.Opl.cs: register-write sink glue and chip-aware write helpers.
22. DuneAdgPlayerEngine.Diagnostics.cs: trace capture, parity dump/export, and debug-only observability hooks.
23. Restrict helper types to data-only support where necessary. Do not create a service-class graph for the core behavior. The rewrite should keep the engine logic centralized in one partial class while still separating domains by file.
24. Phase 3: Rebuild the runtime state and song image model first. Depends on Phase 2.
25. Rewrite song loading from scratch based on the proven DNADG layout, not on the assumptions in the current player.
26. Represent the 18-channel state and the global driver state explicitly and traceably back to the DNADG offsets in AdgDriverCode.cs. Avoid the current “bag of unrelated arrays” feeling by grouping fields coherently inside the engine and documenting their driver provenance.
27. Make runtime state snapshot-friendly. The engine must be able to emit deterministic snapshots for parity checks without depending on UI code.
28. Phase 4: Implement Gold hardware semantics correctly inside the same engine. Depends on Phase 3.
29. Do not keep the current single-chip collapse as the core model. The engine must preserve the dual-chip semantics encoded by the signed route byte and the secondary-register XOR behavior.
30. Reimplement Gold-specific behavior as first-class engine logic: initialization command sequence, secondary ready polling semantics, global volume writes to 0x09/0x0A, and register 0x18 surround mask serialization.
31. Keep OplSynthesizer as a playback sink only. DNADG behavior must remain explicit in the engine partial class, not hidden in the synth wrapper.
32. Phase 5: Rebuild behavior in dependency order inside the single engine. Depends on Phase 4.
33. Implement exported behavior in the same order that minimizes ambiguity:
34. Init, OpenSong, Reset.
35. Wait decode and channel-table initialization.
36. NoteOff and NoteOn with frequency-word writes.
37. Scheduler tick, tick-enabled logic, and loop snapshot transitions.
38. SetVolume and SetDynamics with nibble-packed volume and fade-pattern rotation.
39. ProgramChange, operator programming, and route allocation.
40. PitchBend and vibrato paths.
41. Volume modulation and EndOfTrack behavior.
42. Gold surround updates and patch-type-4 branches.
43. After each slice, run the same narrow parity check against the golden traces before moving to the next slice.
44. Phase 6: Rebuild the host/UI adapter in the same project around the rewritten engine. Depends on Phase 5.
45. Rewrite c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\ViewModels\MainWindowViewModel.cs so it becomes a thin adapter around the engine API instead of owning player semantics.
46. Keep only generic UI pieces that remain decoupled from DNADG logic, such as scroll behavior, waveform control, volume meter control, and log sink plumbing.
47. Rewrite branding/status text and remove misleading claims such as the current “secondary-chip routes currently collapsed to primary” identity. The new UI should describe the rewritten engine faithfully.
48. Phase 7: Verification and parity gates, still within the single project. Depends on Phases 1-6.
49. Add trace-comparison support inside the project instead of adding a separate test csproj. Suitable options are debug-only export commands, internal comparison utilities, or a comparison mode reachable from the existing app shell.
50. Required gates per corpus song:
51. Matching event-dispatch order by tick.
52. Matching wait decode results and per-channel pointer progression.
53. Matching measure/subdivision evolution.
54. Matching route allocation state and patch-type behavior.
55. Matching OPL write timeline, including chip selection and register/value ordering.
56. Matching fade, SetVolume, SetDynamics, and end-of-track/loop semantics.
57. Only after trace parity passes should manual listening be used as a final sanity check.
58. Validate the single csproj on Windows, Linux, and macOS. The rewrite is not complete until the same project builds and runs cross-platform.
59. Phase 8: Cutover and cleanup. Depends on Phase 7.
60. Remove or quarantine the old monolithic behavior so only the rewritten engine path remains active. Do not keep two active engine implementations in the same project.
61. Update player documentation and any ADG workflow docs so they point to the override-backed source of truth and the new parity-validation workflow.
62. Defer any ADP/ADL sharing or cross-driver abstractions until DNADG parity is complete. That work is outside this rewrite.

Relevant files

- c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic\Overrides\AdgDriverCode.cs — semantic source of truth for the rewrite.
- c:\Users\noalm\source\repos\Cryogenic\docs\ADP_DRIVER_ADG_FORMAT_AND_ADL_ADG_PLAN.md — song-format, timing, and driver-divergence reference.
- c:\Users\noalm\source\repos\Cryogenic\scripts\adg\Start-AdgMcpCompare.ps1 — existing evidence capture harness to reuse.
- c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Cryogenic.AdgPlayer.Ui.csproj — single project to keep and clean up.
- c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Services\DuneAdgPlayerEngine.cs — top-level engine partial file to rewrite.
- c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Services\DuneAdgPlayerEngine.Tick.cs — scheduler/event slice to replace.
- c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Services\DuneAdgPlayerEngine.Opl.cs — OPL/routing slice to replace.
- c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Services\DuneAdgPlayerEngine.Hsq.cs — salvage candidate for generic HSQ logic.
- c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\Services\OplSynthesizer.cs — salvage candidate as a thin playback sink.
- c:\Users\noalm\source\repos\Cryogenic\src\Cryogenic.AdgPlayer.Ui\ViewModels\MainWindowViewModel.cs — host adapter to simplify around the rewritten engine.
- c:\Users\noalm\source\repos\Cryogenic\DUNE.DAT_\DNADG.UNHSQ — on-disk DNADG image equivalent used as reference input.

Verification

1. Capture golden override-backed traces for the rewrite corpus before rewriting engine behavior.
2. After each engine slice is rewritten, run a narrow trace comparison against the golden baseline before proceeding.
3. After the full rewrite, compare per-tick state, event order, route allocation, and OPL write timelines across the entire corpus.
4. Build and run the single player project cross-platform after changing WinExe to Exe.
5. Use manual listening only after trace parity is already green.

Decisions

- Single csproj only.
- Single DNADG core engine partial class only.
- Source of truth is the working DNADG override behavior plus live traces, not the current standalone player and not CFG CPU output.
- The rewrite is a replacement, not a repair.
- Default salvage set is HSQ decoding, PIT/timer cadence logic, and optionally OplSynthesizer if it stays thin and generic.
- Dual-chip AdLib Gold semantics are in scope and must not be collapsed away in the new design.
- Shared ADP/ADG abstractions are explicitly deferred until DNADG parity is achieved.

Further Considerations

1. If you want the engine type renamed while still staying a single partial class, make that decision at the start; otherwise keep DuneAdgPlayerEngine to reduce churn.
2. If OplSynthesizer cannot cleanly represent chip-aware output, preserve the engine’s chip-aware trace model and treat live audio as a downstream approximation until the sink is upgraded.
3. If the corpus does not quickly surface a patch-type-4 or surround-heavy song, insert a short evidence step to locate one before those branches are implemented.