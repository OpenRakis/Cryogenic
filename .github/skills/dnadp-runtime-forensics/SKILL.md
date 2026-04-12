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

## Knowledge Graph (graphify)

graphify turns the DNADP corpus — disassembly, C# overrides, docs, and dump artifacts — into a
queryable knowledge graph. Use it to find cross-file connections that grep cannot surface: which
C# method corresponds to which disassembly function, which OPL registers share callers, which
instrument-data offsets link runtime writes to player-side reads.

### Build / update the graph

Invoke the graphify skill from your AI assistant. The skill runs local AST extraction (tree-sitter, no LLM) for C# code and semantic extraction for docs and disassembly in parallel:

```
# First build (from workspace root; .graphifyignore excludes build outputs and binary dumps)
/graphify docs/ dump/live/dnadp_full_disasm.asm \
    src/Cryogenic/Overrides/AdpDriverCode.cs \
    src/Cryogenic.AdpPlayer/Services/ \
    --directed --mode deep

# Incremental update after capturing new dump artifacts or editing overrides
/graphify ... --update

# Generate navigable wiki articles per detected subsystem community
/graphify ... --wiki   # output at graphify-out/wiki/index.md
```

### Query patterns for DNADP work

```bash
# Which driver functions touch OPL register 0x40 (KSL/TL)?
python -m graphify query "what writes OPL register 0x40 TL carrier" --graph graphify-out/graph.json

# Trace the connection from ProgramChange to instrument byte offsets
python -m graphify path "ProgramChange" "OplWriteInstrument" --graph graphify-out/graph.json

# Explain the scheduler tick dispatch chain
python -m graphify query "DNADP ProcessTick scheduler channel event dispatch" --graph graphify-out/graph.json

# What connects the C# player RotateRight16 to the disassembly at 09AB?
python -m graphify path "RotateRight16" "0x09AB" --graph graphify-out/graph.json

# Surface surprising cross-document connections
python -m graphify query "surprising connections OPL timing instrument data" --graph graphify-out/graph.json
```

### MCP mode (persistent graph access during a forensics session)

Add `--mcp` when invoking the skill to expose the graph as an MCP stdio server:
```
/graphify ... --mcp
# Provides: query_graph, get_node, get_neighbors, shortest_path
```
Use this when your tooling supports MCP and you need repeated hop-by-hop traversal.

### Wiki mode (navigable community articles per subsystem)

```bash
# Generates index.md + one article per detected community (scheduler, OPL writes, instrument data, etc.)
python -m graphify docs/ ... --wiki
# Then navigate via graphify-out/wiki/index.md
```

## Procedure
1. Baseline and wiring
- collect runtime status (`cryogenic_status`, CPU state, relevant call counts)
- identify the loaded DNADP segment and common-code dispatch slots
- if a graphify graph exists at `graphify-out/graph.json`, query it for the hot path before CFG capture

2. Graph and hot-path discovery
- capture CFG graph with large limits
- list high-call functions and isolate timer/scheduler hot path
- run `graphify query "DNADP tick scheduler hot path"` to cross-reference with graph community structure

3. Payload correspondence
- extract `DNADP.HSQ`
- decompress to `DNADP.UNHSQ`-equivalent bytes
- dump live loaded DNADP segment bytes
- compare runtime bytes to UNHSQ by offset, recording mismatches
- add new disassembly artifacts to graphify with `--update`

4. Timing capture
- measure tick cadence from call counts and timestamps
- capture OPL register write cadence and burst density
- correlate note/control write timings against tick windows
- use `graphify query "OPL write timing cadence tick window"` to surface related timing evidence in docs

5. Side-effect audit before edits
- verify register/FLAGS contracts at export returns
- verify stack behavior for routines that preserve registers or flags
- verify loop/end and restart behavior over long-running captures
- run `graphify path "<function>" "<caller or target>"` to confirm call chain before editing

## Output artifacts
Create/update artifacts under `dump/live/`:
- `mcp_dnadp_cfg_cpu_graph.json`
- `mcp_dnadp_list_functions.json`
- `mcp_dnadp_runtime_segment_dump.bin`
- `mcp_dnadp_unhsq_bytes.bin`
- `mcp_dnadp_runtime_vs_unhsq_diff.json`
- `mcp_dnadp_timing_summary.json`
- `mcp_dnadp_opl_writes_timeline.json`

After capturing new dump artifacts, run `python -m graphify ... --update` to fold them into the graph.

## Timing guardrails
- Keep PIT-domain scheduling behavior unchanged until measured evidence proves mismatch.
- Validate long captures to catch cumulative drift.
- Treat startup silence as ambiguous until warmup/noise-gate/speaker state is checked.
- Never tune note lengths by ear first; prove timestamp/order mismatch from traces.

## Rewrite guardrails
- Preserve function contracts (registers, flags, stack side effects).
- Keep original assembly path available until parity gates pass.
- If a path is unobserved, fail fast instead of guessing.
