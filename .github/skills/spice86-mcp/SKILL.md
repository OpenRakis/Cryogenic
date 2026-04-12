---
name: spice86-mcp
description: "Use when connecting to the Spice86 MCP server for live emulator inspection: reading CPU state, memory, disassembly, CFG graphs, breakpoints, OPL/MIDI capture, screenshots, and execution control. Covers all 61 tools with exact parameter schemas."
---

# Spice86 MCP Server — Tool Reference

## Connection

| Property | Value |
|---|---|
| Protocol | JSON-RPC 2.0 over SSE (Server-Sent Events) |
| Default URL | `http://127.0.0.1:8081/mcp` |
| Health check | `GET http://127.0.0.1:8081/health` |
| Transport | HTTP POST for requests, SSE `data:` lines for responses |

### Handshake Sequence

```
POST /mcp   → {"jsonrpc":"2.0","id":1,"method":"initialize","params":{"protocolVersion":"2024-11-05","capabilities":{},"clientInfo":{"name":"agent","version":"1.0"}}}
POST /mcp   → {"jsonrpc":"2.0","method":"notifications/initialized","params":{}}
POST /mcp   → {"jsonrpc":"2.0","id":2,"method":"tools/list","params":{}}
```

### Calling a Tool

```json
{
  "jsonrpc": "2.0",
  "id": 42,
  "method": "tools/call",
  "params": {
    "name": "read_memory",
    "arguments": {
      "segment": 4096,
      "offset": 256,
      "length": 64
    }
  }
}
```

**CRITICAL:** `arguments` must be a JSON **object**, never a stringified JSON string. Passing a string yields error `-32603`.

### Response Parsing

Responses arrive as SSE `data:` lines. Parse the last `data:` line as JSON and extract:

- **Success:** `result.structuredContent` — a JSON object with named fields
- **Error:** `result.isError == true`, check `result.content[0].text` for the error message

```python
import json, urllib.request

def call_mcp(session_url, tool_name, arguments, req_id=1):
    payload = json.dumps({
        "jsonrpc": "2.0", "id": req_id,
        "method": "tools/call",
        "params": {"name": tool_name, "arguments": arguments}
    }).encode()
    req = urllib.request.Request(session_url, data=payload,
        headers={"Content-Type": "application/json"})
    with urllib.request.urlopen(req) as resp:
        last_data = ""
        for raw_line in resp:
            line = raw_line.decode().strip()
            if line.startswith("data:"):
                last_data = line[5:].strip()
        msg = json.loads(last_data)
        result = msg.get("result", {})
        if result.get("isError"):
            return None, result.get("content", [{}])[0].get("text", "unknown error")
        return result.get("structuredContent"), None
```

### Auto-Pause Behavior

Most tools automatically pause the emulator before executing, then resume after. Exceptions marked `[McpManualControl]` do NOT auto-pause:
- `pause_emulator`, `resume_emulator`, `go`, `step`, `step_over`

---

## Tool Quick Reference

### CPU & Registers

| Tool | Parameters | Returns |
|---|---|---|
| `read_cpu_state` | — | All registers (EAX…EBP), segments (CS…SS), IP, flags, Cycles |

### Memory

| Tool | Parameters | Returns |
|---|---|---|
| `read_memory` | `segment` (ushort), `offset` (ushort), `length` (int, 1-4096) | `Data` (hex string), `Address` |
| `write_memory` | `segment` (ushort), `offset` (ushort), `data` (hex string) | `Success`, `BytesWritten` |
| `search_memory` | `pattern` (hex), `startSegment` (ushort), `startOffset` (ushort), `length` (int), `limit` (int) | `Matches[]` with `Address` objects |

**⚠ search_memory uses `startSegment`/`startOffset`, NOT `segment`/`offset`.**

### Disassembly & Functions

| Tool | Parameters | Returns |
|---|---|---|
| `read_disassembly` | `segment` (ushort), `offset` (ushort), `instructionCount` (int, 1-500) | `Instructions[]` with `Address`, `Bytes`, `Assembly` |
| `list_functions` | `limit` (int, optional) | `Functions[]` with `Address`, `Name`, `CalledCount`, `HasOverride` |

**⚠ read_disassembly uses `instructionCount`, NOT `length`.**

### CFG (Control Flow Graph)

| Tool | Parameters | Returns |
|---|---|---|
| `read_cfg_cpu_graph` | `nodeLimit` (int, optional; null = all) | `Nodes[]` with `Id`, `Address`, `SuccessorIds`, `PredecessorIds`, `IsLive` |

The CFG only contains addresses that were **actually executed**. Absent addresses = not observed running.

### Execution Control

| Tool | Parameters | Returns |
|---|---|---|
| `pause_emulator` | — | `Success`, `Message` |
| `resume_emulator` | — | `Success`, `Message` |
| `go` | — | `Success`, `Message` |
| `step` | — | `Success`, `Message`, `CpuState` |
| `step_over` | `nextAddress` (long), `isCallOrInterrupt` (bool) | `Success`, `Message`, `CpuState` |
| `read_stack` | `count` (int) | `StackPointer`, `Values[]` |

### Breakpoints

| Tool | Parameters | Returns |
|---|---|---|
| `add_breakpoint` | `address` (long, physical), `type` (string), `condition` (string, optional) | `Id`, `Address`, `Type`, `IsEnabled` |
| `list_breakpoints` | — | `Breakpoints[]` |
| `remove_breakpoint` | `id` (string) | `Success`, `Message` |
| `clear_breakpoints` | — | `Success`, `RemovedCount` |

Breakpoint types: `CPU_EXECUTION_ADDRESS`, `MEMORY_ACCESS`, `MEMORY_WRITE`, `MEMORY_READ`, `IO_ACCESS`, `IO_WRITE`, `IO_READ`

### I/O Ports

| Tool | Parameters | Returns |
|---|---|---|
| `read_io_port` | `port` (int) | `Port`, `Value`, `Description` |
| `write_io_port` | `port` (int), `value` (int) | `Success`, `Message` |
| `list_io_ports` | — | `Ports[]` with `Port`, `Description`, `LastValue` |

### Video / VGA

| Tool | Parameters | Returns |
|---|---|---|
| `read_vga_state` | — | Mode, resolution, palette, sequencer, CRT registers |
| `read_vga_dac_palette` | `startIndex` (int), `count` (int) | `Colors[]` |
| `write_vga_dac_palette` | `startIndex` (int), `colors` (array of {R,G,B}) | `Success` |
| `screenshot` | — | PNG image (base64 in ImageContentBlock) + `Width`, `Height`, `FilePath` |

### Keyboard & Mouse

| Tool | Parameters | Returns |
|---|---|---|
| `read_keyboard_state` | — | `PressedKeys[]`, `BufferCount`, `BufferedKeys[]` |
| `send_key_press` | `key` (PcKeyboardKey enum name) | `Success`, `Message` |
| `send_key_release` | `key` (PcKeyboardKey enum name) | `Success`, `Message` |
| `read_mouse_state` | — | `X`, `Y`, `Buttons`, `Visible` |
| `set_mouse_position` | `x` (int), `y` (int) | `Success`, `Message` |
| `send_mouse_click` | `button` (string), `x` (int), `y` (int) | `Success`, `Message` |

### Sound Blaster

| Tool | Parameters | Returns |
|---|---|---|
| `read_sound_blaster_state` | — | `BaseAddress`, `Irq`, `Dma`, `DspVersion`, `MixerState` |
| `sound_blaster_reset` | — | `Success`, `Message` |
| `read_sound_blaster_dma_state` | — | DMA channel, transfer state |

### OPL (FM Synthesis)

| Tool | Parameters | Returns |
|---|---|---|
| `read_opl_state` | — | `Mode`, `Status`, all 512 register values |
| `write_opl_register` | `register` (int), `value` (int), `chipIndex` (int, optional) | `Success`, `Message` |
| `read_opl_channel` | `channel` (int, 0-17) | Frequency, operator state |
| `opl_reset` | — | `Success`, `Message` |

### PC Speaker

| Tool | Parameters | Returns |
|---|---|---|
| `read_pc_speaker_state` | — | `ControlPort`, `Timer2GateEnabled`, `SpeakerOutputEnabled` |
| `pc_speaker_set_control` | `timer2GateEnabled` (bool), `speakerOutputEnabled` (bool) | `Success` |

### MIDI (MPU-401)

| Tool | Parameters | Returns |
|---|---|---|
| `read_midi_state` | — | `DeviceKind`, `UseMt32`, `State`, `DataPort`, `StatusPort` |
| `midi_reset` | — | `Success`, `Message` |
| `midi_enter_uart_mode` | — | `Success`, `Message` |
| `midi_send_bytes` | `data` (hex string, 1-1024 bytes) | `Success`, `Message` |

### BIOS & Interrupts

| Tool | Parameters | Returns |
|---|---|---|
| `read_bios_data_area` | — | Memory size, video mode, timer, equipment flags |
| `read_interrupt_vector` | `vectorNumber` (int, 0x00-0xFF) | `VectorNumber`, `Address` |

### DOS Kernel

| Tool | Parameters | Returns |
|---|---|---|
| `read_dos_state` | — | `CurrentDrive`, `HasEms`, `HasXms`, `Drives[]` |
| `read_dos_current_directory` | `driveLetter` (string) | `Drive`, `CurrentDirectory` |
| `dos_set_current_directory` | `path` (string) | `Drive`, `CurrentDirectory` |
| `read_dos_program_state` | — | PSP, environment segment, open files |
| `dos_set_default_drive` | `driveLetter` (string) | `Success` |

### EMS (Expanded Memory)

| Tool | Parameters | Returns |
|---|---|---|
| `read_ems_state` | — | Pages, handles, page mappings |
| `read_ems_page_frame` | `page` (int, 0-3), `length` (int, 1-16384) | `Data` (hex) |
| `read_ems_memory` | `handleId` (int), `logicalPage` (int), `offset` (int), `length` (int) | `Data` (hex) |
| `search_ems_memory` | `pattern` (hex), `handleId` (int), `logicalPage` (int), `limit` (int) | `Matches[]` |

### XMS (Extended Memory)

| Tool | Parameters | Returns |
|---|---|---|
| `read_xms_state` | — | `TotalKb`, `FreeKb`, `AllocatedBlocks[]` |
| `read_xms_memory` | `handleId` (int), `offset` (long), `length` (int) | `Data` (hex) |
| `search_xms_memory` | `pattern` (hex), `handleId` (int), `limit` (int) | `Matches[]` |

### Emulator Info

| Tool | Parameters | Returns |
|---|---|---|
| `mcp_about` | — | Emulator name, version, capabilities |

---

## Cryogenic Custom Tools

### Status

| Tool | Parameters | Returns |
|---|---|---|
| `cryogenic_status` | — | `Driver1Segment`, `Driver2Segment`, `Driver3Segment`, `InterruptHandlerSegment`, `ActualMidiSegment` |

### MT-32 MIDI Diagnostics

| Tool | Parameters | Returns |
|---|---|---|
| `cryogenic_mt32_call_counts` | — | Dictionary of entry point → call count |
| `cryogenic_mt32_reset_call_counts` | — | `Success`, `RemovedEntries` |
| `cryogenic_mt32_capture_start` | `maxEvents` (int, optional, default 20000) | Capture state |
| `cryogenic_mt32_capture_stop` | — | Capture state |
| `cryogenic_mt32_capture_reset` | — | Capture state |
| `cryogenic_mt32_capture_dump` | `maxEventCount` (int, optional) | Events with Sequence, ElapsedMs, Port, Cs, Ip, Status, Data1, Data2 |
| `cryogenic_mt32_capture_diagnose` | — | Byte counts, event counts, histogram, signature hash |

### DNADP (AdLib Pro) Diagnostics

| Tool | Parameters | Returns |
|---|---|---|
| `cryogenic_adp_call_counts` | — | `Entries` dict, `LastSongSegment`, `LastMeasure`, `LastSubdivision` |
| `cryogenic_adp_reset_call_counts` | — | Success message |
| `cryogenic_adp_opl_capture_start` | `maxEvents` (int, optional, default 50000) | Status message |
| `cryogenic_adp_opl_capture_stop` | — | Status message |
| `cryogenic_adp_opl_capture_reset` | — | Status message |
| `cryogenic_adp_opl_capture_dump` | `take` (int, optional, default 500) | Events with Sequence, Type, TimestampUs, Port, Register, Value, Channel, Measure, Subdivision |

---

## Shared Data Structures

### SegmentedAddress
```json
{ "Segment": 4096, "Offset": 256 }
```
Physical address = `Segment * 16 + Offset`

### CpuStateSnapshot
Registers: `EAX`, `EBX`, `ECX`, `EDX`, `ESI`, `EDI`, `ESP`, `EBP`, `CS`, `DS`, `ES`, `FS`, `GS`, `SS`, `IP`
Flags: `CarryFlag`, `ParityFlag`, `AuxiliaryFlag`, `ZeroFlag`, `SignFlag`, `DirectionFlag`, `OverflowFlag`, `InterruptFlag`
Counter: `Cycles`

### CfgNodeInfo
```json
{ "Id": 42, "Address": {"Segment": 23470, "Offset": 256}, "SuccessorIds": [43, 44], "PredecessorIds": [41], "IsLive": true }
```

---

## Hex String Rules

- Case-insensitive: `4E5A` = `4e5a`
- `0x` prefix: optional, stripped automatically
- Whitespace: ignored (`4E 5A` → `4E5A`)
- Must be **even length** (2 hex chars per byte)
- Outputs always uppercase, no prefix

---

## Common Workflows

### 1. Health Check → Status
```
GET /health  → 200 OK
tools/call: mcp_about → version info
tools/call: cryogenic_status → driver segments
```

### 2. CFG Capture for a Segment
```python
data, err = call_mcp(url, "read_cfg_cpu_graph", {"nodeLimit": 10000})
nodes = data["Nodes"]
segment_offsets = [n["Address"]["Offset"] for n in nodes if n["Address"]["Segment"] == TARGET_SEGMENT]
```

### 3. Disassemble at Address
```python
data, err = call_mcp(url, "read_disassembly", {
    "segment": 0x5BAE, "offset": 0x0100, "instructionCount": 50
})
for instr in data["Instructions"]:
    print(f"{instr['Address']['Segment']:04X}:{instr['Address']['Offset']:04X}  {instr['Bytes']}  {instr['Assembly']}")
```

### 4. Memory Read at Segment:Offset
```python
data, err = call_mcp(url, "read_memory", {
    "segment": 0x5BAE, "offset": 0x0000, "length": 256
})
hex_bytes = data["Data"]
```

### 5. Set Breakpoint and Step
```python
# Physical address = segment * 16 + offset
call_mcp(url, "add_breakpoint", {
    "address": 0x5BAE * 16 + 0x0100,
    "type": "CPU_EXECUTION_ADDRESS"
})
call_mcp(url, "resume_emulator", {})
# ... wait for break ...
call_mcp(url, "step", {})
call_mcp(url, "read_cpu_state", {})
```

### 6. OPL Capture Session
```python
call_mcp(url, "cryogenic_adp_opl_capture_reset", {})
call_mcp(url, "cryogenic_adp_opl_capture_start", {"maxEvents": 50000})
# ... let music play ...
call_mcp(url, "cryogenic_adp_opl_capture_stop", {})
data, err = call_mcp(url, "cryogenic_adp_opl_capture_dump", {"take": 5000})
```

---

## Known Gotchas

1. **Tool names are exact.** `read_cfg_cpu_graph` not `cfg_cpu_graph`. `read_disassembly` not `disassemble_instructions`.
2. **`read_disassembly` param is `instructionCount`** (int, 1-500), not `length` or `count`.
3. **`search_memory` uses `startSegment`/`startOffset`**, not `segment`/`offset`.
4. **`arguments` must be a JSON object**, never a string. Wrong format yields `-32603`.
5. **CFG is execution-only.** If an address is absent from `read_cfg_cpu_graph`, it was never executed. Do not assume it is code.
6. **`read_disassembly` can fail** on addresses pointing to data or uninitialized memory. Verify against CFG first.
7. **`Bytes=0000` in disassembly is not code.** It decodes as `add byte ptr DS:[BX+SI],AL` — discard as decoder noise.
8. **SSE response parsing:** Read all `data:` lines, use the **last** one. Earlier lines may be partial.
9. **Session URL:** After `initialize`, the SSE response may return a session-scoped URL. Use it for subsequent requests.
10. **Hex outputs are uppercase with no 0x prefix.** Inputs accept any case and optional 0x prefix.
