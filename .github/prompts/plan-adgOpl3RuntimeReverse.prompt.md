## Plan: ADG388 Driver Reverse And AdgPlayer Fork

Build ADG (AdLib Gold) support in two strict tracks: first a runtime-evidence-driven DNADG override rewrite in Cryogenic using Spice86 MCP (CFG + breakpoints + memory correlation), then a faithful AdgPlayer fork from AdpPlayer where only driver logic changes. This keeps parity risk low and enforces 1:1 behavior before any code-sharing refactor.

## Documentation Standard (Mandatory)

Every ADG override function must use the heavy documentation pattern used in AdpDriverCode.

1. Include a summary that states the exact routine address and behavioral purpose.
2. Include a FULL commented asm block under remarks for the routine, based on live evidence artifacts.
3. Document register, FLAGS, and stack expectations when relevant (push/pop/pushf/popf and near/far return contract).
4. If a routine is intentionally delegated to original machine code, document why, what evidence supports delegation, and what is still missing before full C# port.
5. Keep docs synchronized with implementation changes in the same edit; no routine change is complete until the asm doc block is updated.

## Current Verified Status (2026-05-01)

The current ADG override state is no longer at the initial scaffold stage.

Implemented and build-clean in `src/Cryogenic/Overrides/AdgDriverCode.cs`:
- export wrappers `0100/0103/0106/0109/010C/010F/0112`
- internal overrides `04FF/0561/05AB/05BE/0610/0626/06F6`
- helper coverage through `0ECC`, including Gold init/write helpers, wait decode, channel-table build, identity check, fade step, and reset

What is still preventing true 100% C# runtime coverage:
- `0626` and `06F6` still hand off to the original driver path indirectly because the live scheduler body is larger than just `0756`
- `0756` dispatches through `DS:[BX+0x012E]`, so full C# coverage requires the scheduler plus its opcode-handler table, not only `0756/07DA`

Verified remaining hot runtime surface from live ADG evidence:
- `0756` main scheduler loop
- `07DA` loop snapshot save/restore helper
- opcode handlers rooted at `0831`, `0A82`, `0AB6`, `0AF5`, `0B2E`, `0D86`
- routed OPL write / note-frequency helpers around `10A9`, `10D8`, `10E0`, `10ED`, `1101`, `1112`

Evidence used for this status:
- `dump/live/adg388-compare/headless-0756.json`
- `dump/live/adg388-compare/headless-06F6.json`
- `dump/live/adg388-compare/headless-0730.json`
- `dump/live/adg388-compare/adg564b-hot-disasm.txt`
- `src/5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9/spice86dumpListing.asm`

**Steps**
1. Phase 0 - Setup and evidence harness: lock runtime arguments to -a "ADG388" and --OplMode Opl3Gold, run with --UseCodeOverride false first, and establish artifact naming under dump/live for every capture. This creates a reproducible baseline before touching overrides.
2. Phase 1 - Static DNADG ASM dossier (depends on 1): analyze doc/DUNECDVF/C/DUNECD/DUNE.DAT_/DNADG.UNHSQ first, map export jump stubs, internal routine clusters, suspected scheduler/event/pitch/instrument paths, and candidate breakpoints. Produce an offset map used by live tracing.
3. Phase 2 - Live driver localization and ABI proof (depends on 2): via MCP, confirm where DNADG lives at runtime, verify 7-export ABI wiring and call sites from game code, and persist CFG CPU graph + function table evidence. No rewrite starts before this passes.
4. Phase 3 - Behavioral semantics extraction (depends on 3): trace scheduler cadence, event decoding, wait semantics, loop/end behavior, and OPL3 write sequences with breakpoints and step traces. Build a verified contract table: inputs, side effects, registers/FLAGS/stack, and near/far return behavior per routine. This phase is complete for `0626`, `06F6`, `0730`, `0756`, `07DA`, and the observed hot handler cluster listed above.
5. Phase 4 - C# override rewrite in Cryogenic (depends on 4): implement ADG-specific overrides using existing registration patterns in Overrides partials, preserving exact contracts and side effects. Current implementation status is partial: exported entrypoints and several helpers are in C#, but the scheduler dispatch chain is not yet fully ported.
6. Phase 5 - Complete runtime C# coverage for the scheduler slice (depends on 5): port `0756`, `07DA`, then the handler table rooted at `0831/0A82/0AB6/0AF5/0B2E/0D86`, and replace remaining scheduler-local machine-code execution with direct C# dispatch. Do not mark ADG runtime coverage complete until `0626` and `06F6` no longer depend on original-driver execution through that chain.
7. Phase 6 - Iterative 1:1 parity loop (depends on 6): run repeated baseline vs override captures on identical scenes, compare tick cadence, dispatch ordering, OPL writes, measure/subdivision progression, loop/restart semantics, and call counts until all parity gates pass.
8. Phase 7 - AdgPlayer fork from AdpPlayer (depends on 7): copy AdpPlayer into a new AdgPlayer, keep UI/transport/playlist/logging intact, swap only driver engine + ADG-specific synthesis path through OPL3FM/AdLib Gold emulation surface, and validate playback against the verified Cryogenic override behavior.
9. Phase 8 - Stabilization and deferred sharing boundary (depends on 8): document what is intentionally duplicated now and mark a later shared-core extraction plan only after ADP and ADG are both proven stable.

## Immediate Implementation Order For Full Runtime Coverage

1. Port `AdgCheckLoopPoint_07DA` exactly from the verified live disassembly, including the 36-word snapshot copy between `DI` and `DI+0x01D4` and the repeat-counter transitions using song words at `+0x2A/+0x2C/+0x2E`.
2. Port `AdgSchedulerTick_0756` exactly from the verified live disassembly, including:
	- tempo accumulator update from `ES:[BX+0x30]`
	- per-channel wait decrement
	- vibrato side path at `07AD`
	- event dispatch through a C# opcode table matching the original `DS:[BX+0x012E]`
	- subdivision and measure advancement
3. Port the handler table in original order, not semantic order, so the dispatch contract remains identical:
	- `0831` program/instrument change
	- `0A82` note-on
	- `0AB6` note-off / release gate
	- `0AF5` end-of-track / loop reset
	- `0B2E` volume modulation
	- `0D86` pitch bend
4. Port the routed OPL helpers that those handlers depend on:
	- `090D` instrument routing mask update
	- `10A9` frequency/key-on build
	- `10D8` frequency restore / key-off path
	- `10E0` A0/B0 register write pair
	- `10ED` and `1101` routed register/address writes
5. Remove `NearJump`-based fallback only after the scheduler slice above compiles and the ADG runtime path replays without entering original DNADG code for observed hot paths.

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
6. Scheduler gate: `0626 -> 0756` and `06F6 -> 0756` execute without any remaining `NearJump` or original-driver fallback for the observed hot path.
7. Opcode gate: the C# dispatch table covers the live-observed handler set `0831/0A82/0AB6/0AF5/0B2E/0D86` and reproduces the same call ordering and state mutations.
8. OPL write parity: baseline and override traces match ordering and values for key scenarios (intro, loop transitions, heavy modulation passages).
9. Playback parity: no regressions in note order, timing, loops, fade behavior, or restart behavior across selected ADG tracks.
10. AdgPlayer parity: AdgPlayer output behavior matches validated Cryogenic ADG override behavior for the same inputs.

**Decisions**
- Included scope: ADG388 + Opl3Gold reverse engineering, faithful DNADG override rewrite, then AdgPlayer fork with driver-only adjustments.
- Excluded for now: ADL implementation and shared core refactor between players.
- Strict principle: no implementation hypothesis without live MCP evidence and CFG/breakpoint corroboration.

**Further Considerations**
1. Song corpus for parity loops: recommended minimum set is ARRAKIS, MORNING, WATER plus one loop-heavy track and one modulation-heavy track.
2. Capture format: prefer structured JSON artifacts per gate plus one human-readable gate summary per run for auditability.
3. Failure policy: when parity fails, freeze new feature work and iterate only on the failing gate until resolved.