---
name: mt32-runtime-forensics
description: "Use when debugging MT-32 music issues, tracing DNMID behavior, validating register/flag side effects, comparing runtime bytes with dumps, or preparing safe C# override rewrites from MCP evidence."
---

# MT-32 Runtime Forensics

## Purpose
Run an evidence-first reverse engineering pass for DNMID using live Spice86 MCP + repository dumps.

## Required Inputs
- Running emulator with `--UseCodeOverride true`
- MCP endpoint available at `http://localhost:8081/mcp`
- Target segment expected near `0x5BAE`

## Procedure
1. Baseline:
- `mcp_about`
- `cryogenic_status`
- `read_cpu_state`
- `read_midi_state`

2. Graph + calls:
- `read_cfg_cpu_graph` with large `nodeLimit`
- `list_functions` with high `limit`
- `cryogenic_mt32_call_counts`

3. Segment evidence:
- `read_memory` at 5BAE:0100 for 1243 bytes
- `search_memory` for signature `4D3332`
- persist all outputs into `dump/live/mcp_*`

4. Step tracing:
- `clear_breakpoints`
- `add_breakpoint` for 5BAE:010F and 5BAE:05D0 (linear addresses)
- `go`, `pause_emulator`, `step`
- capture CPU state and stack snapshots at each checkpoint

5. Side-effect audit before edits:
- Validate AX/BX/CX/DX/SI/DI/BP/SP and flags at returns
- Validate DS/ES/SS integrity across calls
- Validate writes to 0x0115..0x0142, 0x019C, 0x0139..0x013F only when expected

## Output
Create or update:
- `dump/live/mcp_cfg_cpu_graph.json`
- `dump/live/mcp_list_functions_top500.json`
- `dump/live/mcp_mt32_segment_5BAE_0100_len1243.json`
- `dump/live/mcp_mt32_call_counts.json`
- `dump/live/mcp_cpu_state_snapshot.json`
- `dump/live/mcp_midi_state_snapshot.json`

## Guardrails
- Keep original assembly path as fallback until parity is proven.
- Avoid changing tempo/delay semantics (`0x0127`, polling loops) without timing evidence.
- No speculative edits to MIDI output logic.
- Treat stack behavior as part of the function contract: mirror PUSH/POP side effects using `Stack.Push16`/`Stack.Pop16` when the original routine relies on stack-based register preservation or temporary values.
- For `PUSHF`/`POPF`, preserve FLAGS through the real CPU stack path (`Stack.Push16(State.Flags.FlagRegister16)` then restore popped value into `State.Flags.FlagRegister`).
- Do not emulate `PUSHF`/`POPF` with manual per-flag snapshots in MT-32 overrides unless a targeted MCP trace proves full bit-level equivalence on that path.
- Do not "improve" register cleanup: if assembly intentionally leaves AX/BX/CX/DX altered (for example 0592/05A6 not restoring AX), keep the same post-state in C#.
- During parity checks, capture and compare stack snapshots (`read_stack`) at function entry and return for 010F/030F/036F/049B/04D7/0564/0592/05A6.

## CFG CPU Graph — Interpretation Guide

### What the graph represents
The CFG CPU builds a live Control Flow Graph as the emulator executes instructions. It records every instruction actually executed, along with observed predecessor/successor edges. It is **not** a static disassembly — it is a runtime execution trace expressed as a graph.

### `read_cfg_cpu_graph` response fields
| Field | Type | Meaning |
|---|---|---|
| `CurrentContextDepth` | int | 0 = main program; >0 = inside interrupt handler |
| `CurrentContextEntryPoint` | SegmentedAddress | Where the current execution context started |
| `LastExecutedAddress` | SegmentedAddress? | Exact CPU position at `pause_emulator` time |
| `EntryPointAddresses` | SegmentedAddress[] | All context entry points ever created (one per interrupt or main) |
| `Truncated` | bool | `true` when `nodeLimit` was hit; increase limit or omit for full graph |
| `Nodes[].Id` | int | Unique stable node ID |
| `Nodes[].Address` | SegmentedAddress | Where this instruction lives in memory |
| `Nodes[].SuccessorIds` | int[] | Nodes executed after this one (observed at runtime) |
| `Nodes[].PredecessorIds` | int[] | Nodes executed before this one |
| `Nodes[].IsLive` | bool | `true` = bytes still match parse; `false` = self-modifying code changed them |

### Node types (not in JSON but essential context)
- **CfgInstruction** — a parsed x86 instruction node. `IsLive=false` means its bytes were overwritten by SMC after parsing. The node is still in the graph (with its historical edges) but the CPU no longer executes it directly.
- **SelectorNode** — inserted automatically when SMC produces multiple instruction variants at the same address. Always `IsLive=true`. At runtime it re-reads memory to pick the correct variant. If you see a SelectorNode in a JSON dump it means **confirmed self-modifying code** at that address.

### Reading the graph for reverse engineering
- **Address in graph = definitely executed** at least once during the session.
- **Address absent from graph = not observed** — could be data, a dead branch, or a path not yet triggered. Do not assume it is code.
- **`IsLive=false`** at an address = self-modifying code confirmed; the instruction was overwritten at least once. Do not treat the stale bytes as the canonical instruction.
- **Multiple `SuccessorIds`** from one node = conditional branch or computed jump with multiple live targets (or a SelectorNode dispatch).
- **Disconnected graph islands** = interrupt handlers (timer, keyboard, DMA) that ran in an isolated execution context. These are legitimate code but they never link directly to the main graph.
- **`CurrentContextDepth > 0`** when graph was captured = CPU was inside an interrupt handler at snapshot time; the entry point of that handler is in `CurrentContextEntryPoint`.

### Using the graph to find function boundaries
1. Identify the function's known entry address from `list_functions` or `cryogenic_mt32_call_counts`.
2. Find that node in the graph by matching `Address`.
3. Follow `SuccessorIds` transitively (BFS) until you reach a `RET`/`RETF` node (usually a terminal node with no outgoing edges, or edges back to callers).
4. The collected address set is the **observed function body** — every path the function actually took at runtime.
5. Addresses in `PredecessorIds` of the entry node are the call sites.

### Self-modifying code workflow
1. Note addresses where `IsLive=false` — these are SMC hot spots.
2. For those addresses, `read_memory` to get current bytes, then `read_disassembly` scoped to that range.
3. Cross-check against `dump/live/mcp_mt32_function_disasm_clean_latest.json` if available.
4. Never assume the instruction at a `IsLive=false` address has the same encoding it did at game boot.

## Disassembly Hygiene (Hard Rules)
- **`Bytes=0000` is never code.** x86 decodes zero bytes as `add byte ptr DS:[BX+SI],AL` — this is decoder noise from uninitialized or data-filled memory. Discard unconditionally from every analysis artifact before doing anything else.
- **`mcp_cfg_cpu_graph.json` is the oracle.** It records addresses that were actually executed by the CPU. If an address is not in the CFG it was not observed running; treat it as unverified or data.
- **Code and data share the same address space.** This game uses self-modifying code extensively: bytes that look like instructions at rest may be data at run-time and vice versa. Memory disassembly snapshots are therefore inherently suspect — you are reading whatever bytes happen to be there at capture time, not the logical instruction stream.
- **The game edits its own stack constantly.** Stack-pointer manipulation and manual SP arithmetic appear throughout the driver. This produces misleading `read_stack` snapshots; cross-reference every stack observation against the CFG path to determine whether it reflects a known control-flow pattern or driver self-patching.
- **Never do offline or manual disassembly.** Do not attempt to decode instruction bytes by hand or through a static tool applied to a memory dump. Use `read_disassembly` scoped to a known function range confirmed by the CFG, then strip 0000 entries. Static decoding of arbitrary memory is wrong.
- **Scope `read_disassembly` to CFG-confirmed ranges.** Start from the function index (e.g. `mcp_mt32_function_disasm_clean_latest.json`) rather than probing raw segment offsets from 0x0000. Bytes before the first referenced address (typically 0x0100 in segment 5BAE) are uninitialized.
- **Use CFG as an annotation column, not a hard exclusion filter.** A cold path that was not exercised during the capture session may be absent from the CFG but still real code. Tag instructions with CFG Y/N; do not silently drop CFG=N instructions from reports.
- After every new disassembly artifact run `dump/live/remove_0000_from_disasm_json.ps1` or use `mcp_mt32_generate_asm_commentary.ps1` to produce a clean artifact.
