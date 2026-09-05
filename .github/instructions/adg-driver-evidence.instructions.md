---
description: "Use when modifying AdgDriverCode.cs. Enforces DNADG evidence-first workflow, ADG payload correlation from DUNE.DAT, and strict return/register/FLAGS parity checks."
applyTo: "src/Cryogenic/Overrides/AdgDriverCode.cs"
---

# DNADG AdgDriver Override Rules

Apply these rules whenever editing src/Cryogenic/Overrides/AdgDriverCode.cs.

## Evidence First
1. Gather runtime evidence before proposing behavior changes.
2. Use observed execution paths from dump/spice86dumpExecutionFlow.json to constrain analysis.
3. Correlate runtime-consumed bytes with ADG payload bytes from DUNE.DAT before claiming parser/dispatch defects.
4. If evidence is missing, gather more data or fail fast; do not guess.
5. No fallback policy for observed hot paths: do not keep or introduce fallback behavior to original assembly once an evidence-backed C# override path is active.
6. Always ignore stack warnings and missing-file startup warnings as non-blocking noise unless separate live CFG/MCP evidence proves direct causality.

## Driver Scope
1. Treat DNADG as a distinct driver path; do not assume DNADP logic is equivalent.
2. Keep work scoped to DNADG override behavior in this file.
3. Exclude AdgPlayer rewrite tasks from changes made under this instruction.

## Contract Preservation
1. Preserve caller-visible register and FLAGS post-state at function exit.
2. Preserve stack-observable behavior (PUSH/POP ordering and restore points).
3. Implement PUSHF/POPF via stack + full FLAGS register (`Stack.Push16(State.Flags.FlagRegister16)` and restore popped FLAGS).
4. Validate NearRet/FarRet selection against original call/return semantics before changing it.

## Edit Discipline
1. Make the smallest change set that satisfies evidence-backed behavior.
2. Keep naming traceable to original addresses and existing conventions.
3. Reuse existing helpers/constants in this file before adding new ones.
4. Keep logs terse and structured.
5. Reuse suitable existing ADG scripts and documented workflows before writing new helper scripts or automation.

## Required Validation
1. Rebuild after edits.
2. Re-run the exact scenario used for evidence capture.
3. Confirm behavior parity for scheduler cadence, event dispatch order, and OPL write sequence.
4. If parity is unproven, mark path as untested instead of inferring correctness.

## Preferred References
- dump/spice86dumpExecutionFlow.json
- dump/spice86dumpGhidraSymbols.txt
- dump/CodeGeneratorConfig.json
- dump/live/ DNADG runtime artifacts
- src/Cryogenic/Overrides/AdgDriverCode.cs
