# Cryogenic Workspace Instructions

## Workflow
- Treat reverse engineering as evidence-driven work. Prefer proven behavior from runtime traces, dumps, debugger state, existing overrides, and documented observations over speculation.
- When behavior is unclear, check live Spice86 state first if available. Spice86 now exposes MCP tooling and runtime inspection surfaces; use that, the debugger/GDB flow, or dump artifacts before inventing logic. Reference: https://github.com/OpenRakis/Spice86/blob/master/doc/mcp.md
- Use current repository evidence as the source of truth: `dump/spice86dumpExecutionFlow.json`, `dump/spice86dumpGhidraSymbols.txt`, `dump/CodeGeneratorConfig.json`, generated globals, and any targeted memory dumps captured by the project.
- Preserve observed game behavior, including quirks, unless you have strong runtime evidence that the current behavior is wrong.
- Link to existing docs instead of restating them. Use `README.md` for architecture and run commands, and `CONTRIBUTING.md` for override workflow and coding examples.

## Architecture
- Cryogenic runs the original `DNCDPRG.EXE` inside Spice86 and replaces routines with C# overrides; always pass `--UseCodeOverride true` when launching or your code will never run.
- The entry chain is `src/Cryogenic/Program.cs` -> `DuneCdOverrideSupplier` -> `Overrides.Overrides`. Extend the existing partial `Overrides` class so override registration stays centralized.
- Segment fields in `Overrides` are address anchors for the entire project. Never change `cs1`, `cs2`, `cs3`, `cs4`, or `cs5` without auditing every `DefineFunction` and `DoOnTopOfInstruction` registration.
- Keep overrides grouped by domain in the existing partial files such as `MapCode`, `DialoguesCode`, `DisplayCode`, `VideoCode`, and `VgaDriverCode`.

## Reverse Engineering Rules
- Register new behavior through `DefineFunction` for call replacements and `DoOnTopOfInstruction` for inline hooks. Do not bypass those registration APIs.
- Keep the existing method naming pattern `{FunctionName}_{Segment}_{Offset}_{LinearAddress}` so each override remains traceable to the DOS disassembly.
- Return with `NearRet()` or `FarRet()` to match the original instruction. Getting this wrong corrupts the emulated stack.
- Use `globalsOnDs` and `globalsOnCsSegment0x2538` accessors for state instead of raw pointer math. Extend `src/Cryogenic/Globals/Extra*.cs` when you need new manual accessors.
- Never hand-edit files under `src/Cryogenic/Generated/`; they come from Spice86 dump tooling and must stay regenerable.
- Reuse existing helpers and constants before introducing new ones, especially in `Overrides/MenuCode.cs` and `Overrides/VgaDriverCode.cs`.

## Live Data And Dumps
- Prefer live inspection over guessing. If the emulator is running, use Spice86 MCP, debugger, HTTP, or GDB capabilities to inspect registers, memory, stack, control flow, and structures.
- Use dump artifacts to validate reverse-engineering decisions when live inspection is unavailable or insufficient. In particular, rely on `dump/spice86dumpExecutionFlow.json` for executed paths, `dump/spice86dumpGhidraSymbols.txt` for address naming, and `dump/CodeGeneratorConfig.json` for generated hook and patch assumptions.
- `DefineMemoryDumpsMapping()` and `MemoryDataExporter` are the project pattern for targeted snapshots. Follow that pattern when you need fresh evidence from a difficult code path.
- Coordinate any change to dump-generation assumptions with the relevant files under `dump/`, especially `CodeGeneratorConfig.json`, so generated data and manual overrides do not drift apart.

## Driver And Override Pitfalls
- `DriverLoadToolbox` remaps VGA, PCM, and MIDI drivers to stable segments. Keep `RemapDrivers` and `ResetAllocator` paired at `CS1:E57B` and `CS1:E593` whenever you touch driver loading.
- Let `DriverLoadToolbox.ReadDriverFunctionTable` define exported driver functions before adding manual overrides inside remapped driver segments, or you risk duplicate registrations.
- If you hit `FailAsUntested`, treat it as missing evidence. Reproduce the path in-game, inspect it live, or guard the code instead of guessing.
- Keep `_loggerService.Debug` payloads terse and structured so emulator logs remain useful during long play sessions.

## Build And Validation
- Build from `src` with `dotnet build`.
- Run with `dotnet run --Exe C:/path/to/DNCDPRG.EXE --UseCodeOverride true`; add audio arguments only when the scenario needs them.
- The expected `DNCDPRG.EXE` SHA256 is `5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9`. Verify the checksum before debugging version-specific behavior.
- There are no automated tests. Validate by launching the game and exercising the exact scenario you changed, comparing against observed original behavior when possible.
