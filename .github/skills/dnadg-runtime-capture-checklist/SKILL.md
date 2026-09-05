---
name: dnadg-runtime-capture-checklist
description: "Use when reverse engineering DNADG (AdLib Gold) behavior from live evidence and capturing repeatable runtime artifacts under dump/live before override edits."
---

# DNADG Runtime Capture Checklist

## Purpose
Run a repeatable, evidence-first DNADG investigation and persist comparable artifacts under dump/live before changing overrides.

## Scope
- Target driver: DNADG only (AdLib Gold / OPL3 Gold path)
- Target override file: src/Cryogenic/Overrides/AdgDriverCode.cs
- Data source for music payload correlation: ADG entries from DUNE.DAT
- Out of scope: AdgPlayer rewrite

## Required Inputs
- Emulator launch in ADG mode (for example `-a "ADG388 SBP2227" --OplMode Opl3Gold`)
- `--UseCodeOverride true`
- Spice86 MCP endpoint reachable
- Access to DUNE.DAT extracted ADG files (or equivalent extracted corpus)

## Mandatory Launch Discipline
1. Capture a baseline run with `--UseCodeOverride false` for behavior reference.
2. Run the comparison pass with `--UseCodeOverride true` only after baseline evidence is captured.
3. Keep launch arguments stable between baseline and override-enabled runs except for override toggle.
4. Record exact command lines in the artifact summary.

## Procedure
1. Baseline and wiring
- Verify MCP connectivity and collect initial CPU/runtime status.
- Confirm DNADG segment mapping from runtime state and loader context.
- Confirm scenario/song identity being tested.

2. Hot-path evidence
- Capture executed flow constraints from dump/spice86dumpExecutionFlow.json.
- Focus only on observed DNADG paths for the current scenario.
- Capture function-level hotspots/call frequency for scheduler and dispatch paths.

3. Payload correspondence
- Identify active ADG payload source in DUNE.DAT for the scenario.
- Capture runtime bytes consumed by DNADG and map offsets to payload bytes.
- Record mismatches with offsets, not prose-only conclusions.

4. Timing and dispatch
- Capture scheduler cadence and event dispatch order.
- Capture OPL register writes with timestamps/order.
- Correlate note/control writes to scheduler tick windows.

5. Contract audit before edits
- Verify register and FLAGS post-state at key returns.
- Verify PUSH/POP and PUSHF/POPF behavior through the real stack path.
- Verify near/far return expectations and caller-visible side effects.

## Output Artifacts (dump/live)
Create/update these files for each capture set:
- mcp_dnadg_cfg_cpu_graph.json
- mcp_dnadg_list_functions.json
- mcp_dnadg_runtime_segment_dump.bin
- mcp_dnadg_adg_payload_bytes.bin
- mcp_dnadg_runtime_vs_payload_diff.json
- mcp_dnadg_timing_summary.json
- mcp_dnadg_opl_writes_timeline.json
- mcp_dnadg_capture_notes.md

## Capture Notes Template
Use this structure in mcp_dnadg_capture_notes.md:
- Scenario:
- Song / ADG asset:
- Launch command baseline:
- Launch command override-enabled:
- Driver segment:
- Key functions observed:
- Verified mismatches:
- Ambiguities:
- Safe next override step:

## Guardrails
- Do not assume DNADP behavior applies to DNADG.
- Do not edit overrides before evidence artifacts exist for the target scenario.
- Do not tune by ear first; prove timing/dispatch mismatch from captured data.
- Do not treat inferred graph relationships as proof without runtime confirmation.
- Do not include AdgPlayer rewrite work in this workflow.

## Exit Criteria
- Artifacts exist and are internally consistent.
- Findings separate verified facts from open questions.
- Any proposed patch in src/Cryogenic/Overrides/AdgDriverCode.cs is minimal and trace-backed.
