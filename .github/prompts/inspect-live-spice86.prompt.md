---
description: "Gather evidence from live Spice86 emulator or dumps before reverse-engineering or debugging a code path. Methodically inspect registers, memory, control flow, and existing overrides."
agent: "agent"
---

# Inspect Live Spice86 State for Evidence

Reverse-engineering decisions must be grounded in evidence. Use this prompt to gather runtime data before hypothesizing about behavior.

## Evidence Gathering Workflow

Follow this sequence to build a complete picture:

### 1. Check Live Emulator State (Preferred)
If Spice86 is running the game:

- **Connect via GDB**: `(gdb) target remote localhost:10000`
- **Set breakpoint** on the target address: `(gdb) break *0xCS_IP_ADDRESS`
- **Inspect registers and memory**:
  - `(gdb) info registers` — see AX, BX, CX, DS, CS state
  - `(gdb) x/10i $pc` — disassemble next 10 instructions
  - `(gdb) x/16bx $ds:0x47A8` — read 16 bytes from DS:47A8
- **Step through**: `(gdb) stepi` to trace execution flow
- **MCP HTTP queries** (if available at http://localhost:8081):
  - `GET /api/status` — pause state, CS:IP, cycles
  - `GET /api/memory/{address}/byte` — read single byte
  - `GET /api/memory/{address}/range/{length}` — read memory block

### 2. Extract Dump Data (When Live Inspection Not Available)
- **[dump/spice86dumpExecutionFlow.json](../../../dump/spice86dumpExecutionFlow.json)** — Find the function address and trace its entry/exit; list all instructions executed in this path
- **[dump/spice86dumpGhidraSymbols.txt](../../../dump/spice86dumpGhidraSymbols.txt)** — Look up semantic names for any addresses; find related functions by prefix
- **[dump/CodeGeneratorConfig.json](../../../dump/CodeGeneratorConfig.json)** — Identify any manual instruction replacements or hook points affecting this code

### 3. Compare Against Existing Overrides
- Search `src/Cryogenic/Overrides/*.cs` for similar patterns (e.g., if modifying a memory copy, check `UnknownCode.cs` or `VgaDriverCode.cs`)
- Note how existing overrides use `globalsOnDs`, access memory, and choose `NearRet()` vs `FarRet()`
- Check if a helper method already exists (e.g., `SetDiFromXYCordsDxBx` in [VgaDriverCode.cs](../Overrides/VgaDriverCode.cs))

### 4. Document Findings
Before editing code, write down:
- What emulator output or dump data shows about the behavior
- Which existing overrides or helpers are relevant
- Whether any edge cases or unobserved paths need guarding

## When You're Ready to Code

Once you have evidence:
- Create the override with confidence, referencing the evidence in code comments
- Throw `FailAsUntested` for any unobserved code paths
- Use the naming pattern `{FunctionName}_{Segment}_{Offset}_{LinearAddress}` for traceability
- Return with the correct `NearRet()` or `FarRet()` matching the original instruction

## Example Questions to Answer First

- Is CS:IP actually reaching this address during gameplay?
- What are the values in AX, BX, CX, DS when this runs?
- Does this function read from or write to `globalsOnDs`? Which fields?
- Is this a near CALL or a far CALL? (affects return type)
- Are there any self-modifying code patterns or conditional branches that change behavior?
- Which existing override or helper is closest to this logic?

Reference: [Spice86 MCP documentation](https://github.com/OpenRakis/Spice86/blob/master/doc/mcp.md) and [GDB remote protocol](https://github.com/OpenRakis/Spice86/wiki/Spice86-internal-debugger)
