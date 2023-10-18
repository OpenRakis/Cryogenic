![Linux](https://img.shields.io/badge/-Linux-grey?logo=linux)
![OSX](https://img.shields.io/badge/-OSX-black?logo=apple)
![Windows](https://img.shields.io/badge/-Windows-red?logo=windows)

# Cryo dune reverse engineering

Fiddling with [Cryo dune](https://en.wikipedia.org/wiki/Dune_(video_game)) (CD Version) for fun:
 - Trying to understand how the game works with [Spice86 reverse engineering toolkit](https://github.com/OpenRakis/Spice86) which allows to run real mode x86 ASM / C# hybrids.
 - Rewriting the game in C# bit by bit.

SHA256 signature of supported dncdprg.exe: 5f30aeb84d67cf2e053a83c09c2890f010f2e25ee877ebec58ea15c5b30cfff9

This projects requires [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0).

# Download
See the [releases](https://github.com/OpenRakis/Cryogenic/releases) section.

# Status
Thanks to the hybrid ASM / .NET mode provided by [Spice86](https://github.com/OpenRakis/Spice86), the game is fully playable, including sound and music. 

The goal is to have more and more logic written in human readable C#.

# Running it
To run it, just run the project with dune CD exe in parameter:

```
git clone https://github.com/OpenRakis/crygenic
cd cryogenic/src/Cryogenic
dotnet run --Exe C:/path/to/dunecd/DNCDPRG.EXE --UseCodeOverride true
```

# Building it
 - Clone this repo, and build it:

```
git clone https://github.com/OpenRakis/crygenic
cd cryogenic
dotnet build
```

![](doc/cryodune_worm.png)

![](doc/cryodune_chani.PNG)

![](doc/cryodune_send_spice.png)

![](doc/cryodune_harkonen.PNG)
