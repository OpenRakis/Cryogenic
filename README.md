![Linux](https://img.shields.io/badge/-Linux-grey?logo=linux)
![OSX](https://img.shields.io/badge/-OSX-black?logo=apple)
![Windows](https://img.shields.io/badge/-Windows-red?logo=windows)

# CRYOGENIC

**Reverse Engineering the Classic Dune Game**

📚 **[Visit our comprehensive documentation site](https://openrakis.github.io/Cryogenic/)**

---

## Table of Contents

- [About the Project](#about-the-project)
- [Project Goals](#project-goals)
- [Technology - Spice86](#technology---spice86)
- [Status](#status)
- [Prerequisites](#prerequisites)
- [Build & Run](#build--run)
  - [Building](#building)
  - [Running (Basic Mode)](#running-basic-mode)
  - [Running with Audio](#running-with-audio)
- [Screenshots](#screenshots)
- [Contributing](#contributing)
- [Resources](#resources)
- [License](#license)

---

## About the Project

Cryogenic is an ambitious reverse engineering project dedicated to understanding and modernizing **Cryo's Dune** (CD Version, 1992) - one of the most atmospheric adventure games of the early 90s.

Using the powerful [Spice86](https://github.com/OpenRakis/Spice86) reverse engineering toolkit, we're gradually rewriting the game from x86 assembly into readable, maintainable C# code. The game is **fully playable** right now, complete with sound and music support.

As we continue to replace assembly routines with C# implementations, the codebase becomes more accessible to modern developers while preserving the exact behavior of the original DOS executable.

### Supported Version

**SHA256 signature of supported DNCDPRG.EXE:**
```
5f30aeb84d67cf2e053a83c09c2890f010f2e25ee877ebec58ea15c5b30cfff9
```

⚠️ **Note:** The CD release of DUNE (version 3.7, the most widely available one) must be obtained separately, as it is **copyrighted material**.

---

## Project Goals

🔍 **Understand the Game** - Deep dive into the inner workings of Dune's game engine, uncovering how Cryo implemented dialogue systems, resource management, and real-time strategy elements in the DOS era.

🔄 **Incremental Rewriting** - Gradually replace x86 assembly routines with clean, documented C# code while maintaining 100% behavioral compatibility with the original game.

📚 **Document Everything** - Create comprehensive documentation of game mechanics, data structures, and algorithms to preserve this knowledge for future developers and gaming historians.

🎮 **Preserve Gaming History** - Ensure this classic adventure game remains playable on modern systems and provide a foundation for potential future enhancements and ports.

🛠️ **Educational Resource** - Serve as a reference implementation for reverse engineering techniques and demonstrate the power of hybrid emulation approaches.

🌐 **Cross-Platform Support** - Leverage .NET 8's cross-platform capabilities to run the game natively on Windows, macOS, and Linux without emulation layers.

---

## Technology - Spice86

### What is Spice86?

[Spice86](https://github.com/OpenRakis/Spice86) is a revolutionary reverse engineering toolkit and PC emulator specifically designed for 16-bit real mode x86 programs. Unlike traditional emulators that simply run old software, Spice86 enables you to **gradually modernize** legacy DOS applications by replacing assembly code with high-level C# implementations.

Built on .NET 8, Spice86 provides a unique hybrid execution model where the original DOS executable runs alongside your C# overrides, allowing for incremental reverse engineering and testing.

### Key Features

- 🔄 **Hybrid Execution** - Run original DOS binaries while selectively replacing functions with C# implementations. Test your reverse-engineered code against the real thing in real-time.
- 🔬 **Runtime Analysis** - Collect memory dumps, execution traces, and runtime data while the program runs.
- 🎯 **Ghidra Integration** - Import runtime data into Ghidra for static analysis.
- 🐛 **Advanced Debugging** - Built-in debugger with GDB remote protocol support.
- 🎮 **Hardware Emulation** - Complete support for VGA/EGA/CGA graphics, PC Speaker, AdLib, SoundBlaster, keyboard, and mouse.
- 🌍 **Cross-Platform** - Built on .NET 8 for Windows, macOS, and Linux.

### How Cryogenic Uses Spice86

1. **Override Registration** - Cryogenic registers C# function overrides in `DuneCdOverrideSupplier` that replace specific assembly routines at runtime.
2. **Segment Management** - Memory segments (CS1=0x1000 for main code, CS2/3/4 for drivers, CS5=0xF000 for BIOS) are carefully managed.
3. **Hybrid Execution** - When DNCDPRG.EXE calls an overridden function, Spice86 redirects execution to the C# implementation.
4. **State Synchronization** - Global game state accessors like `globalsOnDs` ensure C# code and assembly share the same memory.

---

## Status

Thanks to the hybrid ASM / .NET mode provided by Spice86, the game is **fully playable**, including sound and music.

The goal is to have more and more logic written in human-readable C#, making the codebase accessible to modern developers while preserving the classic gameplay experience.

---

## Prerequisites

Before you begin, ensure you have:

1. **[.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)** - Required to build and run the project
2. **Dune CD Version 3.7** - You must obtain `DNCDPRG.EXE` and `DUNE.DAT` separately (copyrighted material)

You can verify your executable with PowerShell:
```powershell
Get-FileHash DNCDPRG.EXE -Algorithm SHA256
```

Or on Linux/Mac:
```bash
sha256sum DNCDPRG.EXE
```

---

## Build & Run

### Building

Clone the repository and build the project:

```bash
git clone https://github.com/OpenRakis/Cryogenic
cd Cryogenic/src
dotnet build
```

### Running (Basic Mode)

Ensure that `DUNE.DAT` and `DNCDPRG.EXE` are in the same folder, then run:

```bash
cd Cryogenic/src
dotnet run --Exe C:/path/to/dunecd/DNCDPRG.EXE --UseCodeOverride true -p 4096
```

⚠️ **Important:** Always use `--UseCodeOverride true` or your C# code won't execute!

### Running with Audio

For the full experience with AdLib music and PCM sound effects:

```bash
cd Cryogenic/src/Cryogenic
dotnet publish
bin/Release/net8.0/publish/Cryogenic --Exe C:/path/to/dunecd/DNCDPRG.EXE --UseCodeOverride true -p 4096 -a "ADL220 SBP2227"
```

---

## Screenshots

<div align="center">

![Desert Worm](doc/cryodune_worm.png)
*Encounter with the mighty sandworm*

![Chani](doc/cryodune_chani.PNG)
*Meeting with Chani*

![Spice Management](doc/cryodune_send_spice.png)
*Managing spice resources*

![Harkonnen](doc/cryodune_harkonen.PNG)
*Harkonnen confrontation*

</div>

---

## Contributing

We welcome contributions from developers of all skill levels! Whether you're experienced in reverse engineering or just getting started, there's a place for you in this project.

### Ways to Contribute

- 🔍 **Reverse Engineering** - Analyze assembly code, identify functions, and create C# implementations
- 📝 **Documentation** - Help document game mechanics, data structures, and code functionality
- 🧪 **Testing** - Play the game, find bugs, and verify that C# overrides behave identically to the original
- 🛠️ **Code Quality** - Improve existing C# code, refactor for clarity, and add helpful comments

### Getting Started

1. Fork the repository on GitHub
2. Clone your fork locally
3. Read the [CONTRIBUTING.md](CONTRIBUTING.md) file for detailed guidelines
4. Pick an issue labeled `good first issue` or `help wanted`
5. Create a feature branch for your work
6. Make your changes and test thoroughly
7. Submit a pull request

For detailed contribution guidelines, architecture notes, and coding conventions, please see our [CONTRIBUTING.md](CONTRIBUTING.md) file.

---

## Resources

- 🌐 **[Project Website](https://openrakis.github.io/Cryogenic/)** - Comprehensive documentation
- 🐙 **[GitHub Repository](https://github.com/OpenRakis/Cryogenic)** - Source code, issues, and releases
- 🌶️ **[Spice86 Project](https://github.com/OpenRakis/Spice86)** - The reverse engineering toolkit powering Cryogenic
- 📦 **[Releases](https://github.com/OpenRakis/Cryogenic/releases)** - Download the latest version
- 📖 **[Dune (1992) - Wikipedia](https://en.wikipedia.org/wiki/Dune_(video_game))** - Learn about the original game

---

## License

Cryogenic is open-source software licensed under the **Apache License 2.0**.

© 2021-2024 Kevin Ferrare and contributors.

Dune is © Cryo Interactive Entertainment. This project is not affiliated with or endorsed by Cryo Interactive Entertainment or any rights holders.
