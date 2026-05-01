## Plan: ADG388 Driver Reverse And AdgPlayer Fork

Build ADG (AdLib Gold) support in two strict tracks: first a runtime-evidence-driven DNADG override rewrite in Cryogenic using Spice86 MCP (CFG + breakpoints + memory correlation), then a faithful AdgPlayer fork from AdpPlayer where only driver logic changes. This keeps parity risk low and enforces 1:1 behavior before any code-sharing refactor.

**Steps**
1. Phase 0 - Setup and evidence harness: lock runtime arguments to -a "ADG388" and --OplMode Opl3Gold, run with --UseCodeOverride false first, and establish artifact naming under dump/live for every capture. This creates a reproducible baseline before touching overrides.
2. Phase 1 - Static DNADG ASM dossier (depends on 1): analyze doc/DUNECDVF/C/DUNECD/DUNE.DAT_/DNADG.UNHSQ first, map export jump stubs, internal routine clusters, suspected scheduler/event/pitch/instrument paths, and candidate breakpoints. Produce an offset map used by live tracing.
3. Phase 2 - Live driver localization and ABI proof (depends on 2): via MCP, confirm where DNADG lives at runtime, verify 7-export ABI wiring and call sites from game code, and persist CFG CPU graph + function table evidence. No rewrite starts before this passes.
4. Phase 3 - Behavioral semantics extraction (depends on 3): trace scheduler cadence, event decoding, wait semantics, loop/end behavior, and OPL3 write sequences with breakpoints and step traces. Build a verified contract table: inputs, side effects, registers/FLAGS/stack, and near/far return behavior per routine.
5. Phase 4 - C# override rewrite in Cryogenic (depends on 4): implement ADG-specific overrides using existing registration patterns in Overrides partials, preserving exact contracts and side effects. Keep changes minimal and evidence-backed per function.
6. Phase 5 - Iterative 1:1 parity loop (depends on 5): run repeated baseline vs override captures on identical scenes, compare tick cadence, dispatch ordering, OPL writes, measure/subdivision progression, loop/restart semantics, and call counts until all parity gates pass.
7. Phase 6 - AdgPlayer fork from AdpPlayer (depends on 6): copy AdpPlayer into a new AdgPlayer, keep UI/transport/playlist/logging intact, swap only driver engine + ADG-specific synthesis path through OPL3FM/AdLib Gold emulation surface, and validate playback against the verified Cryogenic override behavior.
8. Phase 7 - Stabilization and deferred sharing boundary (depends on 7): document what is intentionally duplicated now and mark a later shared-core extraction plan only after ADP and ADG are both proven stable.

**Relevant files**
- c:/Users/noalm/source/repos/Cryogenic/docs/ADP_DRIVER_ADG_FORMAT_AND_ADL_ADG_PLAN.md — Primary strategy and DNADP/DNADG/DNADL delta baseline; acceptance criteria seed.
- c:/Users/noalm/source/repos/Cryogenic/docs/DNADP_DRIVER_LIVE.md — Existing live-evidence methodology to mirror for ADG.
- c:/Users/noalm/source/repos/Cryogenic/docs/DNADP_REVERSE_PREP.md — Timing and parity gate patterns to reuse.
- c:/Users/noalm/source/repos/Cryogenic/doc/DUNECDVF/C/DUNECD/DUNE.DAT_/DNADG.UNHSQ — First-pass ASM/source-of-truth binary for ADG driver mapping.
- c:/Users/noalm/source/repos/Cryogenic/src/Cryogenic/Overrides/AdpDriverCode.cs — Implementation template for faithful C# override conventions.
- c:/Users/noalm/source/repos/Cryogenic/src/Cryogenic/Overrides/Overrides.cs — Central registration path and segment anchor usage.
- c:/Users/noalm/source/repos/Cryogenic/src/Cryogenic/DriverLoadToolbox.cs — Runtime driver segment/table resolution behaviors.
- c:/Users/noalm/source/repos/Cryogenic/src/Cryogenic/CryogenicMcpTools.cs — Existing runtime capture hooks; extend for ADG capture parity.
- c:/Users/noalm/source/repos/Cryogenic/docs/CRYOGENIC_MCP_TOOLS.md — MCP capability reference for CFG/breakpoints/memory tools.
- c:/Users/noalm/source/repos/Cryogenic/src/Cryogenic.AdpPlayer/Services — Source to fork into AdgPlayer with driver-only replacement.

**Verification**
1. Baseline reproducibility: identical captures across repeated runs with -a "ADG388" and --OplMode Opl3Gold; no drift in initial wiring observations.
2. CFG and export ABI: CFG CPU graph shows expected export/hot paths; breakpoint hit patterns are stable under same scenario.
3. Runtime-vs-UNHSQ correlation: DNADG live bytes are mapped and mismatches explained (self-modifying vs mapping error) before rewrite.
4. Timing gate: measured tick cadence remains in expected band around 200.299 Hz and no long-run phase slip is observed.
5. Contract gate: each rewritten routine matches register/FLAGS/stack side effects and return type expectations from traced ASM.
6. OPL write parity: baseline and override traces match ordering and values for key scenarios (intro, loop transitions, heavy modulation passages).
7. Playback parity: no regressions in note order, timing, loops, fade behavior, or restart behavior across selected ADG tracks.
8. AdgPlayer parity: AdgPlayer output behavior matches validated Cryogenic ADG override behavior for the same inputs.

**Decisions**
- Included scope: ADG388 + Opl3Gold reverse engineering, faithful DNADG override rewrite, then AdgPlayer fork with driver-only adjustments.
- Excluded for now: ADL implementation and shared core refactor between players.
- Strict principle: no implementation hypothesis without live MCP evidence and CFG/breakpoint corroboration.

**Further Considerations**
1. Song corpus for parity loops: recommended minimum set is ARRAKIS, MORNING, WATER plus one loop-heavy track and one modulation-heavy track.
2. Capture format: prefer structured JSON artifacts per gate plus one human-readable gate summary per run for auditability.
3. Failure policy: when parity fails, freeze new feature work and iterate only on the failing gate until resolved.