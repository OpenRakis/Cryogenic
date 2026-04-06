---
description: "Use when implementing or modifying C# overrides in Overrides/ files. Covers reverse-engineering workflow, address tracing, naming conventions, return type validation, and dump-first evidence gathering."
applyTo: "src/Cryogenic/Overrides/**"
---

# Override Implementation Guidelines

## Before Writing Code: Gather Evidence

1. **Check live Spice86 state first** (if emulator is running):
   - Use MCP server (http://localhost:8081 by default, see `--mcp-http-port`)
   - Connect via GDB (port 10000 by default) and inspect registers, memory, CS:IP
   - Set breakpoints and step through the relevant code path
   - Use custom GDB commands like `monitor dumpall` to export current runtime state

2. **Use existing dumps** when live inspection is unavailable:
   - [dump/spice86dumpExecutionFlow.json](../../../dump/spice86dumpExecutionFlow.json) — executed code paths, function addresses
   - [dump/spice86dumpGhidraSymbols.txt](../../../dump/spice86dumpGhidraSymbols.txt) — function names and addresses discovered by Ghidra
   - [dump/CodeGeneratorConfig.json](../../../dump/CodeGeneratorConfig.json) — manual instruction replacements and hook injection points
   - Any targeted `MemoryDataExporter` snapshots under `dump/` for the specific code path

3. **Examine existing overrides** in the same file or related domain files for patterns:
   - How do they access game state via `globalsOnDs`?
   - What `NearRet()` or `FarRet()` pattern matches your scenario?
   - Are there helper methods you should reuse?

## Naming and Traceability

All override methods follow: `{FunctionName}_{Segment}_{Offset}_{LinearAddress}`

Example: `SetBackBufferAsActiveFrameBuffer_1000_C085_01C085`

- `Segment`: Hex segment field value (`1000` for cs1, `D000` for cs2, etc.)
- `Offset`: Offset within the segment
- `LinearAddress`: Physical address in memory (segment * 16 + offset in hex)

This naming preserves traceability with the DOS disassembly and helps future developers locate the original assembly.

## Critical Rules: No Exceptions

### Return Type
The chosen return must match the original instruction:
- **`NearRet()`**: Near CALL/RET within the same segment (most common in DOS code)
- **`FarRet()`**: Far CALL/RET across segments (x86 CS:IP indirect)

Wrong choice silently corrupts the emulated stack. If unsure, inspect the original assembly via Ghidra or the GDB disassembly view.

### Segment Field Anchors
Never change `cs1`, `cs2`, `cs3`, `cs4`, or `cs5` without auditing all existing `DefineFunction` and `DoOnTopOfInstruction` registrations. These are immutable anchors for the entire override table. See [Overrides.cs](./Overrides.cs) line numbers where each is declared.

### State Access
- Use `globalsOnDs` and `globalsOnCsSegment0x2538` typed accessors instead of manual pointer math
- Extend `Globals/Extra*.cs` when you need new accessors; never edit `Generated/` directly
- Accessor methods auto-sync with DS/CS base register values

## Implementation Checklist

- [ ] Behavior matches the original assembly exactly (check via step-through or test in-game)
- [ ] Method name follows `{FunctionName}_{Segment}_{Offset}_{LinearAddress}` pattern
- [ ] Return type chosen and validated: `NearRet()` or `FarRet()`
- [ ] All state access uses `globalsOnDs`/`globalsOnCsSegment0x2538` accessors
- [ ] Edge cases from the original assembly are documented
- [ ] Unobserved code paths throw `FailAsUntested` or are guarded; never guess
- [ ] XML doc comment explains what the override does and its original address
- [ ] Logging via `_loggerService.Debug` is terse and structured
- [ ] In-game scenario exercise confirms the behavior against the original

## Documentation Template

```csharp
/// <summary>
/// [Brief description of what the function does in game terms].
/// Original assembly at CS1:XXXX. Replaces [n] instructions.
/// </summary>
public void FunctionName_1000_XXXX_0XXXXX() {
    // Implementation
    NearRet(); // or FarRet()
}
```

## Common Pitfalls

- **Segment field mismatch**: Using hardcoded `0x1000` instead of `cs1` variable breaks relocation
- **FailAsUntested not thrown**: Code path never observed, behavior invented — will fail in-game
- **Helper reuse ignored**: Writing identical pixel-buffer or memory-copy code instead of calling existing helpers in [VgaDriverCode.cs](./VgaDriverCode.cs) or [MenuCode.cs](./MenuCode.cs)
- **Magic numbers**: Using addresses without semantic names; use constants from `globalsOnDs` instead

## Coordination with Reverse-Engineering

This file auto-applies when you edit `src/Cryogenic/Overrides/*`. Before committing, ensure:
- Dumps are current (`dump/CodeGeneratorConfig.json` matches your assumptions)
- GDB/debugger evidence supports the behavior
- In-game test pass; compare behavior frame-by-frame against the original if possible
