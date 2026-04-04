# Contributing to Cryogenic

Guidelines for contributing to the project.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Setup](#setup)
- [Project Structure](#project-structure)
- [How Overrides Work](#how-overrides-work)
- [Coding Conventions](#coding-conventions)
- [Implementing an Override](#implementing-an-override)
- [Testing](#testing)
- [Submitting Changes](#submitting-changes)

## Prerequisites

1. **.NET 10 SDK** — [dotnet.microsoft.com](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)
2. **Dune CD Version 3.7** — `DNCDPRG.EXE` and `DUNE.DAT` (copyrighted; obtain separately)
3. **Git**
4. **IDE** — Visual Studio, VS Code with C# extensions, or JetBrains Rider

Verify the executable checksum:
```
5f30aeb84d67cf2e053a83c09c2890f010f2e25ee877ebec58ea15c5b30cfff9
```

```bash
# Linux/Mac
sha256sum DNCDPRG.EXE

# PowerShell
Get-FileHash DNCDPRG.EXE -Algorithm SHA256
```

## Setup

1. Fork and clone:
```bash
git clone https://github.com/YOUR-USERNAME/Cryogenic.git
cd Cryogenic
git remote add upstream https://github.com/OpenRakis/Cryogenic.git
```

2. Build:
```bash
cd src
dotnet build
```

3. Run:
```bash
dotnet run --Exe /path/to/DNCDPRG.EXE --UseCodeOverride true -p 4096
```

`--UseCodeOverride true` is required. Without it, no C# overrides execute.

## Project Structure

```
src/Cryogenic/
├── Program.cs                     Entry point; configures args, launches Spice86
├── DuneCdOverrideSupplier.cs      Implements IOverrideSupplier; creates Overrides instance
├── DriverLoadToolbox.cs           Remaps driver segments to 0xD000/0xE000/0xF000
├── Overrides/
│   ├── Overrides.cs               Defines segment fields (cs1–cs5), registers all overrides
│   ├── VgaDriverCode.cs           23 VGA functions (mode, blit, palette, cursor, retrace)
│   ├── MenuCode.cs                14 menu-type constants, 2 menu state overrides
│   ├── DialoguesCode.cs           3 dialogue system functions
│   ├── MapCode.cs                 5 map/cursor functions and click-handler constants
│   ├── DisplayCode.cs             11 framebuffer and font selection functions
│   ├── VideoCode.cs               3 HNM video playback functions
│   ├── HnmCode.cs                 1 HNM file I/O function
│   ├── TimeCode.cs                2 day/night cycle functions
│   ├── TimerCode.cs               1 PIT 8254 timer function
│   ├── ScriptedSceneCode.cs       2 cutscene sequence functions
│   ├── DatastructuresCode.cs      2 memory structure functions
│   ├── InitCode.cs                1 VGA state initialization function
│   ├── MT32DriverCode.cs          3 Roland MT-32 MIDI functions at segment 0xF000
│   ├── UnknownCode.cs             20 partially understood functions
│   └── StaticDefinitions.cs       137+ symbolic names for tracing (not overridden)
├── Globals/                       Typed accessors added manually (Extra* files)
└── Generated/                     Auto-generated memory accessors (do not edit)
```

### Memory Segments

| Field | Address | Purpose |
|-------|---------|---------|
| `cs1` | `0x1000` | Main game code |
| `cs2` | `0xD000` | VGA driver (DNVGA), remapped |
| `cs3` | `0xE000` | PCM audio driver (DNPCS2/DNSBP), remapped |
| `cs4` | `0xE000` | MIDI music driver (DNPCS/DNMID), remapped |
| `cs5` | `0x0800` | Interrupt handlers |

Do not change segment values without auditing all `DefineFunction` and `DoOnTopOfInstruction` calls.

## How Overrides Work

1. `Program.cs` calls `Spice86.Program.RunWithOverrides<DuneCdOverrideSupplier>` with the expected SHA256.
2. `DuneCdOverrideSupplier` instantiates `Overrides.Overrides`, which calls `DefineOverrides()`.
3. `DefineOverrides()` registers C# methods at segment:offset addresses using:
   - `DefineFunction(segment, offset, method)` — replaces CALL targets
   - `DoOnTopOfInstruction(segment, offset, method)` — inline hooks
4. At runtime, when the emulated CPU reaches a registered address, the C# method runs instead of the assembly.
5. The method returns via `NearRet()` (near CALL/RET within same segment) or `FarRet()` (far CALL/RET across segments). Using the wrong one corrupts the stack.
6. Game state is accessed through typed accessors (`globalsOnDs`, `globalsOnCsSegment0x2538`) that map to the emulated memory at DS and CS segment bases.

## Coding Conventions

### Method Naming

Override methods use the pattern `{FunctionName}_{Segment}_{Offset}_{LinearAddress}`:
```csharp
public void SetBackBufferAsActiveFrameBuffer_1000_C085_01C085()
```

Keep this naming convention. It maps the method back to the original assembly address.

### Game State Access

Use the provided accessor classes instead of manual pointer math:
```csharp
// Correct
globalsOnDs.Set(0x47A8, value);

// Incorrect — bypasses synchronization
memory.UInt16[state.DS, 0x47A8] = value;
```

### Documentation

Add XML doc comments stating what the function does and which original address it replaces:
```csharp
/// <summary>
/// Switches the active framebuffer to the back buffer for double-buffered rendering.
/// Original assembly at CS1:C085.
/// </summary>
public void SetBackBufferAsActiveFrameBuffer_1000_C085_01C085() {
    // Implementation
    NearRet();
}
```

### Edge Cases

Document edge cases found in the original assembly:
```csharp
// Original assembly has special handling for value 0xFFFF
if (value == 0xFFFF) {
    // Special case logic
}
```

### Logging

Use `_loggerService.Debug` with structured templates:
```csharp
_loggerService.Debug("Loading dialogue {DialogueId}", dialogueId);
```

### File Organization

- Group related overrides in domain-specific files (VGA in `VgaDriverCode.cs`, menus in `MenuCode.cs`, etc.)
- Extend the `Overrides` partial class — do not create new top-level classes
- Do not edit files in `Generated/`. Add custom accessors in `Globals/Extra*` files.

## Implementing an Override

### Analysis

Use Spice86's CFGCPU (Control Flow Graph CPU) for analyzing the assembly. It handles self-modifying code that Dune uses and integrates with C# overrides.

Use the Spice86 debugger to set breakpoints, inspect registers and memory, and step through execution.

Memory dumps can be captured at specific points using `DefineMemoryDumpsMapping()` with `MemoryDataExporter`.

### Example

Given an assembly function at CS1:1234 that clears a 256-word buffer:

```asm
CS1:1234  mov cx, 0x100    ; Counter
CS1:1237  mov di, 0x0      ; Destination offset
CS1:123A  xor ax, ax       ; Value to write (0)
CS1:123C  rep stosw        ; Fill buffer
CS1:123E  ret              ; Return
```

C# implementation:
```csharp
/// <summary>
/// Clears a 256-word buffer at ES:0000.
/// Original assembly at CS1:1234.
/// </summary>
public void ClearBuffer_1000_1234_011234() {
    var buffer = MemoryUtils.ToMemorySpan(_state.Memory, _state.ES.BaseAddress, 512);
    buffer.Fill(0);
    NearRet();
}
```

Registration in `DefineOverrides()`:
```csharp
DefineFunction(cs1, 0x1234, ClearBuffer_1000_1234_011234, false);
```

Test by running the game and verifying the buffer is cleared at the expected time.

### Checklist

- Match original behavior exactly
- Use the correct return method (`NearRet()` or `FarRet()`)
- Throw `FailAsUntested` for unobserved code paths
- Add XML doc comments
- Test in-game

## Testing

There are no automated tests. Validation is done by running the game.

1. Build:
```bash
cd src
dotnet build
```

2. Run:
```bash
dotnet run --Exe /path/to/DNCDPRG.EXE --UseCodeOverride true -p 4096
```

3. Exercise the relevant game scenarios:
   - Main menu navigation
   - New game intro sequence
   - Dialogue sequences
   - Map exploration and movement
   - Spice collection and shipment
   - Combat
   - Save/Load
   - Game exit

4. Compare behavior against the unmodified game if possible.

## Submitting Changes

### Before submitting

- [ ] Code builds without errors (`dotnet build`)
- [ ] Game runs and changed scenarios work correctly
- [ ] No unrelated changes or leftover debug code
- [ ] XML doc comments added where appropriate

### Process

1. Create a branch:
```bash
git checkout -b feature/your-feature-name
```

2. Commit and push:
```bash
git add .
git commit -m "Brief description of changes"
git push origin feature/your-feature-name
```

3. Open a pull request with:
   - Title describing the change
   - Description of what was changed and why
   - Which game scenarios were tested

### Finding Tasks

Check the [issues page](https://github.com/OpenRakis/Cryogenic/issues) for labels:
- `good first issue`
- `help wanted`
- `documentation`
- `reverse-engineering`

## Resources

- [Spice86](https://github.com/OpenRakis/Spice86)
- [Project page](https://openrakis.github.io/Cryogenic)
