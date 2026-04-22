# Cryogenic Workspace Instructions

## Workflow
- Treat reverse engineering as evidence-driven work. Prefer proven behavior from runtime traces, dumps, debugger state, existing overrides, and documented observations over speculation.
- When behavior is unclear, check live Spice86 state first if available. Spice86 now exposes MCP tooling and runtime inspection surfaces; use that, the debugger/GDB flow, or dump artifacts before inventing logic. Reference: https://github.com/OpenRakis/Spice86/blob/master/doc/mcp.md
- Use current repository evidence as the source of truth: `dump/spice86dumpExecutionFlow.json`, `dump/spice86dumpGhidraSymbols.txt`, `dump/CodeGeneratorConfig.json`, generated globals, and any targeted memory dumps captured by the project.
- Preserve observed game behavior, including quirks, unless you have strong runtime evidence that the current behavior is wrong.
- Link to existing docs instead of restating them. Use `README.md` for architecture and run commands, and `CONTRIBUTING.md` for override workflow and coding examples.
- When approaching an architectural question (what functions share state, which data structures cross file boundaries, how a driver subsystem is structured), query the knowledge graph before grepping raw files. See the **Knowledge Graph** section below.

## Knowledge Graph (graphify)

graphify builds a persistent, queryable knowledge graph from the Cryogenic corpus — disassembly, C# override source, documentation, and dump artifacts. Use it as a structural index before diving into raw files.

**Install (already done):**
```bash
pip install graphifyy
python -m graphify copilot install   # writes skill to ~/.copilot/skills/graphify/SKILL.md
```

**Build the graph** — invoke the graphify skill from your AI assistant (VS Code Copilot Chat or GitHub Copilot CLI) with the relevant corpus paths. The skill orchestrates local AST extraction and semantic extraction in parallel:
```
/graphify docs/ dump/live/dnadp_full_disasm.asm src/Cryogenic/Overrides/ src/Cryogenic.AdpPlayer/Services/ --directed --mode deep

# Incremental update after new evidence or overrides change:
/graphify docs/ ... --update

# Generate navigable wiki articles per subsystem community:
/graphify docs/ ... --wiki
```

A `.graphifyignore` at workspace root excludes build outputs, binary dumps, and submodule trees.
See `graphify-out/GRAPH_REPORT.md` for the latest god-nodes and surprising-connection summary.

**Query the graph** (CLI, works after graph.json exists):
```bash
python -m graphify query "DNADP OPL scheduler tick dispatch" --graph graphify-out/graph.json
python -m graphify path "ProgramChange" "OplWriteInstrument" --graph graphify-out/graph.json
python -m graphify explain "RotateRight16" --graph graphify-out/graph.json
```

**Graph edges are tagged** EXTRACTED (found directly in source), INFERRED (confidence score attached), or AMBIGUOUS (flagged for review). Never treat INFERRED edges as ground truth — verify from runtime evidence.

## Architecture
- Cryogenic runs the original `DNCDPRG.EXE` inside Spice86 and replaces routines with C# overrides; always pass `--UseCodeOverride true` when launching or your code will never run.
- The entry chain is `src/Cryogenic/Program.cs` -> `DuneCdOverrideSupplier` -> `Overrides.Overrides`. Extend the existing partial `Overrides` class so override registration stays centralized.
- Segment fields in `Overrides` are address anchors for the entire project. Never change `cs1`, `cs2`, `cs3`, `cs4`, or `cs5` without auditing every `DefineFunction` and `DoOnTopOfInstruction` registration.
- Keep overrides grouped by domain in the existing partial files such as `MapCode`, `DialoguesCode`, `DisplayCode`, `VideoCode`, and `VgaDriverCode`.

## Reverse Engineering Rules
- Register new behavior through `DefineFunction` for call replacements and `DoOnTopOfInstruction` for inline hooks. Do not bypass those registration APIs.
- Keep the existing method naming pattern `{FunctionName}_{Segment}_{Offset}_{LinearAddress}` so each override remains traceable to the DOS disassembly.
- Return with `NearRet()` or `FarRet()` to match the original instruction. Getting this wrong corrupts the emulated stack.
- Treat stack operations as observable behavior: when original assembly uses `PUSH`/`POP` (including temporary register saves), preserve equivalent stack/register effects in overrides (prefer `Stack.Push16`/`Stack.Pop16` where practical).
- Preserve `PUSHF`/`POPF` semantics as well (full FLAGS contract), not only `InterruptFlag`, unless live evidence proves the extra flags are caller-ignored.
- Implement `PUSHF`/`POPF` through the real stack/flags path (`Stack.Push16(State.Flags.FlagRegister16)` and restore popped value into `State.Flags.FlagRegister`) so non-overridden code observes identical FLAGS behavior.
- Do not substitute manual per-flag snapshots for `PUSHF`/`POPF` unless a targeted runtime trace proves strict equivalence for that routine.
- Preserve the original function side effects on registers and flags at function exit. Do not treat AX/BX/CX/DX/SI/DI/BP/SP or FLAGS as scratch unless runtime evidence proves they are caller-ignored.
- Audit caller expectations before changing a function contract: if callers read modified SI/DI/FLAGS (or other registers) after return, the override must expose the same post-state.
- If a computed value is not consumed by any caller, keep it internal to the override; if it is consumed, it must be returned through the same register/flags channel as the original code.
- Use `globalsOnDs` and `globalsOnCsSegment0x2538` accessors for state instead of raw pointer math. Extend `src/Cryogenic/Globals/Extra*.cs` when you need new manual accessors.
- Never hand-edit files under `src/Cryogenic/Generated/`; they come from Spice86 dump tooling and must stay regenerable.
- Reuse existing helpers and constants before introducing new ones, especially in `Overrides/MenuCode.cs` and `Overrides/VgaDriverCode.cs`.
- **Disassembly from memory is suspect.** This game uses self-modifying code: bytes at rest may differ from bytes as executed. Never treat a static memory snapshot as a reliable instruction stream.
- **`Bytes=0000` is never valid code.** x86 decodes zero bytes as `add byte ptr DS:[BX+SI],AL` — this is decoder noise from uninitialized or data-region memory. Discard immediately from any disassembly analysis.
- **The CFG CPU graph is the oracle for real code.** `mcp_cfg_cpu_graph.json` (or `dump/spice86dumpExecutionFlow.json`) only contains addresses that were actually executed. If an address is absent from the CFG it was not observed running; treat as data or unverified cold path.
- **Code and data are not clearly separated** in this binary. Treat boundaries between code and data as soft: confirm with live CFG evidence before assuming any byte range is exclusively code or exclusively data.
- **The game performs constant stack editing.** Manual SP arithmetic and self-patching routines produce misleading stack snapshots in logs. Treat suspicious stack log entries as driver internals, not corruption, unless CFG/live evidence contradicts that.

## Partial Class Architecture and CSharpOverrideHelper

The `Overrides` class is a partial class that inherits from `Spice86.Core.Emulator.Function.CSharpOverrideHelper`. This design accommodates the original DOS code's characteristics: hand-written assembly with self-modifying code, complex control flow, and segments larger than 500 lines that are hard to navigate.

**Why Partial Classes:**
- The original game uses hand-written assembly with self-modifying code patterns that are complex to reverse-engineer
- Splitting overrides by domain (VgaDriverCode, DialoguesCode, MapCode, etc.) keeps each file under 500 lines for IDE performance and readability
- Each partial file focuses on one game subsystem: graphics, dialogue, maps, audio, menus, etc.
- Larger files degrade IDE performance (Intellisense, refactoring) and readability for future maintainers

**Inherited from CSharpOverrideHelper:**

*Registration Methods:*
- `DefineFunction(segment, offset, method)` — replaces CALL targets with C# methods
- `DefineFunction(segment, offset, method, throwIfNotFound, name)` — variant with metadata
- `DoOnTopOfInstruction(segment, offset, hookAction)` — injects inline hooks that run before/after an instruction

*CPU State Access (Registers):*
- `AX`, `BX`, `CX`, `DX`, `SI`, `DI`, `BP`, `SP` — 16-bit register access
- `CS`, `DS`, `ES`, `SS` — segment registers
- `DirectionFlag` — direction for string operations
- All registers are read-write; changes take effect in the next emulated instruction

*Memory and Debugging:*
- `Memory` — access emulated memory via `Memory.UInt8[address]`, `Memory.UInt16[address]`, `Memory.MemCopy()`, `Memory.Memset8()`
- `Machine` — emulated CPU and device state
- `_loggerService` — structured logging via `_loggerService.Debug(...)`
- `FailAsUntested(message)` — throw exception for unobserved code paths; prevents silent failures

*Utility Methods:*
- `NearRet()` — return Action for near CALL/RET (same segment)
- `FarRet()` — return Action for far CALL/RET (across segments)

**File Organization Pattern:**
Each partial file groups related overrides by subsystem:
```csharp
public partial class Overrides {
    public void Define{SubsystemName}CodeOverrides() {
        DefineFunction(segment, offset, methodName);
        // ... more registrations
    }

    /// <summary>Override for {address}.</summary>
    public Action MethodName_Segment_Offset_Linear(int gotoAddress) {
        // Implementation
        return NearRet(); // or FarRet()
    }
    
    // More methods...
}
```

Call `Define{SubsystemName}CodeOverrides()` from `DefineOverrides()` in Overrides.cs to register all overrides in that file. The partial class consolidates registration in one place (main `DefineOverrides()` method) while keeping implementation split across files.

## C# Coding Standards

### Type Safety (No Implicit Typing)
- **No `var` keyword**. Always write explicit types. `var` hides intent and makes reverse-engineering code harder to trace. Example: `uint address = 0x1000;` not `var address = 0x1000;`
- **No nullable types (`string?`, `int?`)**. Use explicit, non-null types. If a value can be absent, use `Optional<T>`, a wrapper type, or guard the code path.
- **No nullable forgiving operator (`!`)**. If you need `!`, you have a design problem. Refactor to eliminate null entirely or use a Result/Option type.
- **Favor strongly typed code over string-based operations**. Use enums, discriminated unions, or sealed classes instead of magic string constants. Example: `enum DriverType { DNVGA, DNPCS2, DNSBP, DNMID }` not string literals like `"DNVGA"`.

### Async / Sync Discipline
- **No sync over async**. Never block async code with `.Result` or `.Wait()`.
- **No async over sync**. Never wrap sync code in unnecessary `Task.Run` or `Task.FromResult` for convenience.
- Match the call site requirements: if calling code is sync, be sync; if async, be async. Pin your design early.

### Method Constraints
- **Every public method must have strong documentation**. Use XML doc comments (`///`) explaining: what the method does, why it exists, pre/post conditions, and any side effects. Not overly verbose; be precise. Example:
  ```csharp
  /// <summary>
  /// Remaps VGA driver to segment 0xD000 and disables allocator bounds.
  /// Called before each driver load to ensure fixed segment addresses.
  /// </summary>
  public void RemapDrivers() { }
  ```
- **No optional arguments**. Use method overloading or a config object if you need flexibility. Optional arguments hide intent and make testing harder.
- **No reflection**. Reflection is fragile, slow, and obscures dependencies. Favor composition, polymorphism, or code generation (Spice86 dumps) instead.
- **No method without practical tests**. If a method is public or complex, it must be testable and have validation logic in-game. Mark unobserved code paths with `FailAsUntested` or guard them.

### Game Memory Structures
- **Represent all game structures in memory using Spice86-based classes**. Inherit from `Spice86.Core.Emulator.ReverseEngineer.DataStructure.MemoryBasedDataStructure` or `MemoryBasedDataStructureWithSegmentRegisterBaseAddress`.
- **Never use raw pointer math**. Use the typed accessor generated or manually written in `Globals/Extra*.cs` files.
- **Example structure definition**:
  ```csharp
  public class GameStateAtDs : MemoryBasedDataStructureWithSegmentRegisterBaseAddress {
      public GameStateAtDs(IByteReaderWriter memory, SegmentRegisters segmentRegisters) 
          : base(memory, segmentRegisters) { }
      
      public uint DialogueCount => UInt32[0x47A8];
      public void SetDialogueCount(uint value) => UInt32[0x47A8] = value;
  }
  ```
- Extend or create new accessor classes in `src/Cryogenic/Globals/Extra*.cs` rather than editing `Generated/`.

### Code Organization
- Group related methods and fields in domain-specific partial override files.
- Use enums and named constants instead of magic numbers. Example: `const int MENU_TYPE_DIALOGUE = 0x1F7E;` then reference `MENU_TYPE_DIALOGUE`.
- Minimize scope of helper methods; keep them private unless reuse is proven.

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
- Run with `dotnet run -p 4096 --Exe C:/path/to/DNCDPRG.EXE --UseCodeOverride true`; add audio arguments only when the scenario needs them.
- The expected `DNCDPRG.EXE` SHA256 is `5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9`. Verify the checksum before debugging version-specific behavior.
- There are no automated tests. Validate by launching the game and exercising the exact scenario you changed, comparing against observed original behavior when possible.

## Audio Driver Launch Configurations

Game data is stored entirely in `DUNE.DAT`, a custom archive format. Each audio configuration triggers different driver loading via `DriverLoadToolbox`.

### MT-32 MIDI + PCM Sound Effects
```
-p 4096 --Cycles 3000 -e "C:\path\to\DNCDPRG.EXE" -a "MID330 SBP2227" -m "C:\Jeux\MT32"
```
- MIDI driver at port 0x330 (MT-32 hardware or emulation)
- PCM Sound Blaster Pro at I/O 0x220, IRQ 7, DMA 1
- MT-32 ROM path in this workspace: `C:\Jeux\MT32`

### AdLib Gold OPL3 + PCM Sound Effects
```
-p 4096 --Cycles 3000 -e "C:\path\to\DNCDPRG.EXE" -a "ADG388 SBP2227" --OplMode Opl3Gold
```
- OPL3 Gold synthesis for music (AdLib Gold compatible)
- PCM Sound Blaster Pro for effects
- `--OplMode Opl3Gold` enables OPL3 Gold emulation

### AdLib Compatible OPL3 Sound Blaster + PCM Sound Effects
```
-p 4096 --Cycles 3000 -e "C:\path\to\DNCDPRG.EXE" -a "ADP330 SBP2227" --OplMode Opl3
```
- Sound Blaster Pro OPL3 synthesis for music (AdLib compatible)
- PCM Sound Blaster Pro for effects
- `-s` silences logs if needed
- `--OplMode Opl3` enables dual-OPL3 emulation

### Driver Loading Relationship
- Each audio driver prefix (MID, ADG, ADP) triggers different MIDI driver loading
- PCM suffix (SBP2227) loads the Sound Blaster Pro driver for effects
- **Without PCM driver**, the sound effects driver does not load; audio will be incomplete
- `DriverLoadToolbox` orchestrates remapping at `CS1:E57B` (RemapDrivers) and `CS1:E593` (ResetAllocator)
