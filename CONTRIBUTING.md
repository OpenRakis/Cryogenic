# Contributing to Cryogenic

Thank you for your interest in contributing to Cryogenic! This document provides guidelines and information to help you contribute effectively to the project.

## Table of Contents

- [Code of Conduct](#code-of-conduct)
- [Getting Started](#getting-started)
- [Development Environment](#development-environment)
- [Project Architecture](#project-architecture)
- [Contributing Guidelines](#contributing-guidelines)
- [Coding Conventions](#coding-conventions)
- [Reverse Engineering Workflow](#reverse-engineering-workflow)
- [Testing Your Changes](#testing-your-changes)
- [Submitting Changes](#submitting-changes)
- [Communication](#communication)

## Code of Conduct

We are committed to providing a welcoming and inclusive environment for all contributors. Please:

- Be respectful and constructive in all interactions
- Welcome newcomers and help them get started
- Focus on what is best for the community and the project
- Show empathy towards other community members
- Provide and gracefully accept constructive feedback

## Getting Started

### Prerequisites

Before you begin, ensure you have:

1. **.NET 8 SDK** - Download from [dotnet.microsoft.com](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
2. **Dune CD Version 3.7** - You must obtain DNCDPRG.EXE and DUNE.DAT separately (copyrighted material)
3. **Git** - For version control
4. **A code editor** - Visual Studio, VS Code, or Rider recommended

### Verify Your Executable

Ensure your DNCDPRG.EXE has the correct SHA256 hash:
```
5f30aeb84d67cf2e053a83c09c2890f010f2e25ee877ebec58ea15c5b30cfff9
```

You can verify with PowerShell:
```powershell
Get-FileHash DNCDPRG.EXE -Algorithm SHA256
```

Or on Linux/Mac:
```bash
sha256sum DNCDPRG.EXE
```

### Fork and Clone

1. Fork the repository on GitHub
2. Clone your fork locally:
```bash
git clone https://github.com/YOUR-USERNAME/Cryogenic.git
cd Cryogenic
```

3. Add the upstream repository:
```bash
git remote add upstream https://github.com/OpenRakis/Cryogenic.git
```

4. Build the project:
```bash
cd src
dotnet build
```

5. Test that it runs:
```bash
dotnet run --Exe /path/to/DNCDPRG.EXE --UseCodeOverride true -p 4096
```

## Development Environment

### Recommended Tools

- **IDE**: Visual Studio 2022, JetBrains Rider, or VS Code with C# extensions
- **Debugger**: Built-in IDE debugger for C# code
- **Ghidra**: For static analysis of assembly code (optional but recommended)
- **Hex Editor**: For examining data files (optional)

### Project Structure

```
Cryogenic/
├── src/
│   └── Cryogenic/
│       ├── Program.cs                 # Entry point
│       ├── DuneCdOverrideSupplier.cs  # Override registration
│       ├── DriverLoadToolbox.cs       # Driver remapping utilities
│       ├── Overrides/                 # C# implementations
│       │   ├── Overrides.cs          # Main override class (partial)
│       │   ├── VgaDriverCode.cs      # VGA driver overrides
│       │   ├── MenuCode.cs           # Menu system overrides
│       │   ├── DialoguesCode.cs      # Dialogue system overrides
│       │   └── ...
│       ├── Generated/                 # Auto-generated code (don't edit)
│       └── Globals/                   # Game state accessors
├── doc/                              # Documentation and screenshots
├── dump/                             # Memory dumps and analysis configs
└── README.md
```

## Project Architecture

### How Cryogenic Works

Cryogenic uses **Spice86** to run the original DNCDPRG.EXE while selectively replacing assembly routines with C# implementations. This hybrid approach allows:

1. **Incremental rewriting** - Replace one function at a time
2. **Immediate testing** - Run the game after each change
3. **Behavioral verification** - Compare C# output with original assembly

### Key Concepts

#### Segments

Memory segments are the foundation of address translation:

- `cs1 = 0x1000` - Main game code
- `cs2, cs3, cs4` - Mapped driver segments
- `cs5 = 0xF000` - BIOS/IRQ handlers

**Important**: Never change segment values without auditing ALL `DefineFunction` and `DoOnTopOfInstruction` calls.

#### Override Registration

Overrides are registered in `Overrides.DefineOverrides()` using:

- `DefineFunction(segment, offset, method)` - Replace CALL targets
- `DoOnTopOfInstruction(segment, offset, method)` - Inline hooks

Example:
```csharp
DefineFunction(cs1, 0xC085, SetBackBufferAsActiveFrameBuffer_1000_C085_01C085, false);
```

#### Generated Code

Files under `Generated/` are produced by Spice86's dump tooling. **Never edit these manually**. Add custom accessors in `Globals/Extra*` files instead.

#### Return Methods

Use the correct return method based on the original assembly:

- `NearRet()` - For near CALL/RET (within same segment)
- `FarRet()` - For far CALL/RET (across segments)

Using the wrong one will corrupt the stack!

## Contributing Guidelines

### Ways to Contribute

#### 1. Reverse Engineering

Analyze assembly code and create C# implementations.

**Skills needed**: Assembly language, debugging, patience

**Example tasks**:
- Identify function boundaries in disassembly
- Document function parameters and return values
- Implement C# equivalent that produces identical behavior

#### 2. Documentation

Document code, game mechanics, and project processes.

**Skills needed**: Technical writing, understanding of the codebase

**Example tasks**:
- Add XML doc comments to override methods
- Document game data structures
- Create tutorials for new contributors
- Explain complex algorithms

#### 3. Testing & Validation

Play the game and verify correct behavior.

**Skills needed**: Attention to detail, systematic testing

**Example tasks**:
- Test specific game scenarios
- Verify that overrides match original behavior
- Report discrepancies or bugs
- Create test cases

#### 4. Code Quality

Improve existing C# implementations.

**Skills needed**: C# programming, refactoring

**Example tasks**:
- Refactor complex methods for clarity
- Add error handling
- Improve performance
- Remove code duplication

## Coding Conventions

### C# Style

Follow standard C# conventions with these project-specific rules:

1. **Keep generated naming** - Override methods use pattern `{Segment}_{Offset}_{Linear}` (e.g., `SetBackBufferAsActiveFrameBuffer_1000_C085_01C085`)

2. **Use provided accessors** - Access game state through `globalsOnDs` and `globalsOnCsSegment0x2538` instead of manual pointer math

3. **Document extensively** - Explain what the override does, not just how:
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

4. **Handle edge cases** - DOS code often has surprising edge cases. Document and handle them:
   ```csharp
   // Original assembly has special handling for value 0xFFFF
   if (value == 0xFFFF) {
       // Special case logic
   }
   ```

5. **Logging** - Use `_loggerService.Debug` for diagnostics:
   ```csharp
   _loggerService.Debug("Loading dialogue {DialogueId}", dialogueId);
   ```

### Override Implementation Guidelines

1. **Match original behavior exactly** - Byte-for-byte compatibility is the goal
2. **Test thoroughly** - Play the game and verify the override works in all scenarios
3. **Add safety checks** - Throw `FailAsUntested` for unobserved code paths
4. **Keep it simple** - Don't over-engineer; match the original logic
5. **Use correct return** - `NearRet()` or `FarRet()` based on original instruction

### File Organization

- **Keep related overrides together** - VGA code in `VgaDriverCode.cs`, menu code in `MenuCode.cs`, etc.
- **Extend partial classes** - Add new overrides to `Overrides` partial class in domain-specific files
- **Don't edit Generated/** - Add custom code in `Globals/Extra*` or new override files

## Reverse Engineering Workflow

### Typical Process

1. **Identify a function** in the assembly code
2. **Understand its behavior** through static analysis or runtime tracing
3. **Document parameters and return values**
4. **Implement in C#** maintaining exact behavior
5. **Register the override** in `DefineOverrides()`
6. **Test thoroughly** by playing the game
7. **Document** with comments explaining the function's purpose

### Tools and Techniques

#### Using Ghidra

1. Load DNCDPRG.EXE in Ghidra
2. Analyze with default settings
3. Use Spice86's Ghidra plugin to import runtime data
4. Navigate to function addresses
5. Understand the logic and data structures

#### Using Spice86 Debugger

1. Run with debugger enabled
2. Set breakpoints at function entry
3. Inspect registers and memory
4. Step through execution
5. Compare with your C# implementation

#### Memory Dumps

The project includes memory dump functionality. Enable in `DefineMemoryDumpsMapping()` to capture game state at specific points.

### Example: Implementing a Simple Override

Let's say you've identified a function at CS1:1234 that clears a buffer:

1. **Analyze the assembly**:
```asm
CS1:1234  mov cx, 0x100    ; Counter
CS1:1237  mov di, 0x0      ; Destination offset
CS1:123A  xor ax, ax       ; Value to write (0)
CS1:123C  rep stosw        ; Fill buffer
CS1:123E  ret              ; Return
```

2. **Implement in C#**:
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

3. **Register in DefineOverrides()**:
```csharp
DefineFunction(cs1, 0x1234, ClearBuffer_1000_1234_011234, false);
```

4. **Test**: Run the game and verify the buffer is cleared at the right time

5. **Document**: Add comments explaining when and why this is called

## Testing Your Changes

### Manual Testing

1. **Build the project**:
```bash
dotnet build
```

2. **Run the game**:
```bash
dotnet run --Exe /path/to/DNCDPRG.EXE --UseCodeOverride true -p 4096
```

3. **Test specific scenarios** that exercise your code:
   - Main menu navigation
   - Dialogue sequences
   - Combat
   - Resource management
   - Save/Load

4. **Compare with original**: If possible, run the original game and compare behavior

### Important Test Cases

- **Main menu** - Navigation, option selection
- **New game start** - Initial setup and intro sequence
- **Dialogue system** - Character conversations
- **Map exploration** - Movement and interactions
- **Resource management** - Spice collection and allocation
- **Combat** - Battle sequences
- **Save/Load** - Game state persistence

### Debugging

Use your IDE's debugger to step through C# code:

1. Set breakpoints in your override methods
2. Run with debugger attached
3. Inspect variables and execution flow
4. Verify behavior matches expectations

## Submitting Changes

### Before You Submit

- [ ] Code builds without errors
- [ ] Game runs and your changes work as expected
- [ ] You've tested relevant game scenarios
- [ ] Code follows project conventions
- [ ] You've added appropriate comments/documentation
- [ ] No unrelated changes or debugging code left in

### Creating a Pull Request

1. **Create a feature branch**:
```bash
git checkout -b feature/your-feature-name
```

2. **Make your changes and commit**:
```bash
git add .
git commit -m "Brief description of changes"
```

3. **Push to your fork**:
```bash
git push origin feature/your-feature-name
```

4. **Open a Pull Request** on GitHub with:
   - **Clear title** describing the change
   - **Description** explaining what and why
   - **Testing notes** describing how you verified it works
   - **Screenshots** if relevant (UI changes, bug fixes)

### Pull Request Template

```markdown
## Description
Brief description of changes

## Changes Made
- List of specific changes
- What was added/modified/removed

## Testing
- [ ] Built successfully
- [ ] Tested in-game
- [ ] Verified correct behavior

## Testing Notes
Describe how you tested and what scenarios work correctly

## Related Issues
Fixes #123 (if applicable)
```

### Code Review

Maintainers will review your PR and may:
- Request changes or clarifications
- Suggest improvements
- Merge when everything looks good

Be patient and responsive to feedback!

## Communication

### GitHub Issues

Use GitHub issues for:
- Bug reports
- Feature requests
- Questions about the code
- Proposals for significant changes

### Discussions

For general discussion, questions, or showing off progress, use GitHub Discussions.

### Finding Tasks

Look for issues labeled:
- `good first issue` - Good for newcomers
- `help wanted` - Community help needed
- `documentation` - Documentation tasks
- `reverse-engineering` - RE work needed

## Additional Resources

- **Spice86 Documentation**: [github.com/OpenRakis/Spice86](https://github.com/OpenRakis/Spice86)
- **Project Website**: [openrakis.github.io/Cryogenic](https://openrakis.github.io/Cryogenic)
- **Copilot Instructions**: See `.github/copilot-instructions.md` for detailed architectural notes

## Questions?

If you have questions:
1. Check existing documentation and issues
2. Open a GitHub issue with the `question` label
3. Reach out in GitHub Discussions

Thank you for contributing to Cryogenic! Your efforts help preserve and modernize this classic game for future generations.
