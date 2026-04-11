---
name: dnadp-runtime-forensics
description: "Use when reverse engineering DNADP (AdLib Pro) music behavior, validating OPL timing, correlating UNHSQ bytes with runtime, and preparing safe override rewrites from live evidence."
---

# DNADP Runtime Forensics

## Purpose
Run an evidence-first reverse engineering pass for DNADP where note timing and scheduler parity are validated before any rewrite.

## Required Inputs
- Emulator launch in ADP mode (for example `-a "ADP220 SBP2227" --OplMode Opl3`)
- `--UseCodeOverride true`
- MCP endpoint available
- Access to DUNE.DAT extracted entries and UNHSQ decompressor

### Driver profile terminology
- ADL = regular AdLib music (`DNADL`), broadly compatible path.
- ADP = Sound Blaster Pro-oriented AdLib music (`DNADP`) and default target for this skill.
- ADG = AdLib Gold music with surround-module behavior (`DNADG`).
- All are FM/OPL-family variants; keep instrumentation and timing analysis in OPL register space.
- For ADG sessions, launch with `--OplMode Opl3Gold` (required).

## Procedure
1. Baseline and wiring
- collect runtime status (`cryogenic_status`, CPU state, relevant call counts)
- identify the loaded DNADP segment and common-code dispatch slots

2. Graph and hot-path discovery
- capture CFG graph with large limits
- list high-call functions and isolate timer/scheduler hot path

3. Payload correspondence
- extract `DNADP.HSQ`
- decompress to `DNADP.UNHSQ`-equivalent bytes
- dump live loaded DNADP segment bytes
- compare runtime bytes to UNHSQ by offset, recording mismatches

4. Timing capture
- measure tick cadence from call counts and timestamps
- capture OPL register write cadence and burst density
- correlate note/control write timings against tick windows

5. Side-effect audit before edits
- verify register/FLAGS contracts at export returns
- verify stack behavior for routines that preserve registers or flags
- verify loop/end and restart behavior over long-running captures

## Output artifacts
Create/update artifacts under `dump/live/`:
- `mcp_dnadp_cfg_cpu_graph.json`
- `mcp_dnadp_list_functions.json`
- `mcp_dnadp_runtime_segment_dump.bin`
- `mcp_dnadp_unhsq_bytes.bin`
- `mcp_dnadp_runtime_vs_unhsq_diff.json`
- `mcp_dnadp_timing_summary.json`
- `mcp_dnadp_opl_writes_timeline.json`

## Timing guardrails
- Keep PIT-domain scheduling behavior unchanged until measured evidence proves mismatch.
- Validate long captures to catch cumulative drift.
- Treat startup silence as ambiguous until warmup/noise-gate/speaker state is checked.
- Never tune note lengths by ear first; prove timestamp/order mismatch from traces.

## Rewrite guardrails
- Preserve function contracts (registers, flags, stack side effects).
- Keep original assembly path available until parity gates pass.
- If a path is unobserved, fail fast instead of guessing.
