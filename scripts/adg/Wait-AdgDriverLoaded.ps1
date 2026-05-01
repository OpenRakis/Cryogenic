param(
    [int]$Port = 8081,
    [int]$TimeoutSeconds = 300,
    [int]$PollIntervalSeconds = 5,
    [string]$OutputRoot = ""
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
if ([string]::IsNullOrWhiteSpace($OutputRoot)) {
    $OutputRoot = Join-Path $repoRoot 'dump/live/adg388-compare'
}

New-Item -ItemType Directory -Path $OutputRoot -Force | Out-Null

function Invoke-Mcp {
    param([string]$Body)
    $headers = @{ Accept = 'application/json, text/event-stream' }
    $wr = Invoke-WebRequest -Uri "http://127.0.0.1:$Port/mcp" -Method Post `
        -ContentType 'application/json' -Headers $headers -Body $Body -TimeoutSec 30
    $lines = $wr.Content -split "`r?`n"
    ($lines | Where-Object { $_ -like 'data: *' } | Select-Object -Last 1) -replace '^data: ', ''
}

function Initialize-McpSession {
    Invoke-Mcp -Body '{"jsonrpc":"2.0","id":1,"method":"initialize","params":{"protocolVersion":"2024-11-05","capabilities":{},"clientInfo":{"name":"adg-wait","version":"1.0"}}}' | Out-Null
    Invoke-Mcp -Body '{"jsonrpc":"2.0","method":"notifications/initialized","params":{}}' | Out-Null
}

function Invoke-McpTool {
    param([string]$ToolName, [string]$Arguments = '{}', [int]$Id = 10)
    $body = "{`"jsonrpc`":`"2.0`",`"id`":$Id,`"method`":`"tools/call`",`"params`":{`"name`":`"$ToolName`",`"arguments`":$Arguments}}"
    $raw = Invoke-Mcp -Body $body
    $parsed = $raw | ConvertFrom-Json

    if ($null -eq $parsed.result) {
        if ($null -ne $parsed.error) {
            throw "MCP tool '$ToolName' transport error: $($parsed.error.message)"
        }
        throw "MCP tool '$ToolName' returned no result payload"
    }

    if ($parsed.result.isError -eq $true) {
        throw "MCP tool '$ToolName' error: $($parsed.result.content[0].text)"
    }
    return $parsed.result.structuredContent
}

Write-Host "[$(Get-Date -Format 'HH:mm:ss')] Initializing MCP session on port $Port..."
Initialize-McpSession

$deadline = (Get-Date).AddSeconds($TimeoutSeconds)
$driverActive = $false
$lastTotalCalls = 0

Write-Host "[$(Get-Date -Format 'HH:mm:ss')] Waiting for DNADG driver to load (timeout: ${TimeoutSeconds}s, polling every ${PollIntervalSeconds}s)..."
Write-Host "  The game needs ~13M instructions before reaching the intro and loading the ADG driver."

while ((Get-Date) -lt $deadline) {
    Start-Sleep -Seconds $PollIntervalSeconds

    try {
        # Re-initialize session each poll (SSE sessions can expire)
        Initialize-McpSession

        # Poll cryogenic_adp_call_counts for any activity
        $counts = Invoke-McpTool -ToolName 'cryogenic_adp_call_counts' -Id 20
        [int]$totalCalls = 0
        if ($counts.Entries) {
            foreach ($key in ($counts.Entries | Get-Member -MemberType NoteProperty).Name) {
                $totalCalls += $counts.Entries.$key
            }
        }

        $songSeg = if ($counts.LastSongSegment) { '0x{0:X4}' -f $counts.LastSongSegment } else { 'none' }
        Write-Host "[$(Get-Date -Format 'HH:mm:ss')] ADP call total: $totalCalls  LastSongSegment: $songSeg"

        if ($totalCalls -gt 0 -and $totalCalls -ne $lastTotalCalls) {
            $driverActive = $true
            $lastTotalCalls = $totalCalls
            Write-Host "[$(Get-Date -Format 'HH:mm:ss')] Driver is active! Capturing evidence..." -ForegroundColor Green
            break
        }
        $lastTotalCalls = $totalCalls
    }
    catch {
        Write-Host "[$(Get-Date -Format 'HH:mm:ss')] Poll error (game may still be loading): $($_.Exception.Message)"
    }
}

if (-not $driverActive) {
    Write-Host "[$(Get-Date -Format 'HH:mm:ss')] Timeout: driver never became active within ${TimeoutSeconds}s." -ForegroundColor Yellow
    exit 1
}

# Driver is now loaded. Capture full evidence snapshot.
$timestamp = Get-Date -Format 'yyyyMMdd-HHmmss'
$outputDir = Join-Path $OutputRoot "adg-driver-active-$timestamp"
New-Item -ItemType Directory -Path $outputDir -Force | Out-Null

Initialize-McpSession

# 1. cryogenic_status to confirm segments
$status = Invoke-McpTool -ToolName 'cryogenic_status' -Id 30
$status | ConvertTo-Json | Out-File (Join-Path $outputDir 'cryogenic_status.json')
Write-Host "driver3Segment=$($status.driver3Segment)  actualMidiSegment=$($status.actualMidiSegment)"

# 2. adp call counts (has LastSongSegment = actual ADG segment)
$counts = Invoke-McpTool -ToolName 'cryogenic_adp_call_counts' -Id 31
$counts | ConvertTo-Json | Out-File (Join-Path $outputDir 'adp_call_counts.json')
[int]$adgSeg = if ($counts.LastSongSegment) { $counts.LastSongSegment } else { 0x5BAE }
Write-Host "LastSongSegment=0x$($adgSeg.ToString('X4'))"

# 3. Read memory at AdpDefaultSegment:0x0100 (300 bytes - covers all 7 export stubs)
$memBody = "{`"jsonrpc`":`"2.0`",`"id`":32,`"method`":`"tools/call`",`"params`":{`"name`":`"read_memory`",`"arguments`":{`"segment`":$adgSeg,`"offset`":256,`"length`":512}}}"
$memRaw = Invoke-Mcp -Body $memBody | ConvertFrom-Json
$memData = $memRaw.result.structuredContent.Data
$memData | Out-File (Join-Path $outputDir 'dnadg_5BAE_0100_512.hex')

# Format hex dump
$bytes = [System.Convert]::FromHexString($memData)
$hexDump = for ($i = 0; $i -lt $bytes.Length; $i += 16) {
    $chunk = $bytes[$i..([Math]::Min($i + 15, $bytes.Length - 1))]
    $hex = ($chunk | ForEach-Object { '{0:X2}' -f $_ }) -join ' '
    '{0:X4}: {1}' -f (0x100 + $i), $hex
}
$hexDump | Out-File (Join-Path $outputDir 'dnadg_5BAE_0100_512.dump')
Write-Host "Memory dump saved."

# 4. Disassemble at segment:0x0100 (export stubs)
$disasmBody = "{`"jsonrpc`":`"2.0`",`"id`":33,`"method`":`"tools/call`",`"params`":{`"name`":`"read_disassembly`",`"arguments`":{`"segment`":$adgSeg,`"offset`":256,`"instructionCount`":30}}}"
$disasmRaw = Invoke-Mcp -Body $disasmBody | ConvertFrom-Json
$disasmLines = $disasmRaw.result.structuredContent.Instructions | ForEach-Object {
    "$($_.Address.Segment.ToString('X4')):$($_.Address.Offset.ToString('X4'))  $($_.Bytes.PadRight(12))  $($_.Assembly)"
}
$disasmLines | Out-File (Join-Path $outputDir 'dnadg_5BAE_0100_disasm.txt')
$disasmLines | Select-Object -First 30
Write-Host "`nOutput saved to: $outputDir"
