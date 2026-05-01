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
    $content = [string]$wr.Content
    if ([string]::IsNullOrWhiteSpace($content)) {
        return '{}'
    }
    $trimmed = $content.Trim()
    if ($trimmed.StartsWith('{')) {
        return $trimmed
    }
    $lines = $content -split "`r?`n"
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

    $hasIsError = $null -ne ($parsed.result.PSObject.Properties['isError'])
    if ($hasIsError -and $parsed.result.isError -eq $true) {
        throw "MCP tool '$ToolName' error: $($parsed.result.content[0].text)"
    }
    if ($null -ne ($parsed.result.PSObject.Properties['structuredContent'])) {
        return $parsed.result.structuredContent
    }
    return $parsed.result
}

function Invoke-McpMethod {
    param([string]$MethodName, [string]$ParamsJson = '{}', [int]$Id = 50)
    $body = "{`"jsonrpc`":`"2.0`",`"id`":$Id,`"method`":`"$MethodName`",`"params`":$ParamsJson}"
    $raw = Invoke-Mcp -Body $body
    return ($raw | ConvertFrom-Json)
}

function Resolve-AdgSegmentFromSignature {
    $pattern = 'E9FC03E92005E95804E90405E9AF04E9E405E99604'
    $search = Invoke-McpTool -ToolName 'search_memory' -Arguments "{`"pattern`":`"$pattern`",`"startSegment`":0,`"startOffset`":0,`"length`":1048576,`"limit`":10}" -Id 60
    if ($null -eq $search.Matches -or $search.Matches.Count -eq 0) {
        return 0
    }

    [int]$signatureSegment = $search.Matches[0].Segment
    [int]$signatureOffset = $search.Matches[0].Offset

    # Signature byte 0 can appear at codeSegment:0x0100, exposed as (codeSegment+0x10):0x0000.
    if ($signatureOffset -eq 0) {
        return (($signatureSegment - 0x10) -band 0xFFFF)
    }

    return $signatureSegment
}

Write-Host "[$(Get-Date -Format 'HH:mm:ss')] Initializing MCP session on port $Port..."
Initialize-McpSession

$toolsList = Invoke-McpMethod -MethodName 'tools/list' -ParamsJson '{}' -Id 55
$toolNames = @()
if ($null -ne $toolsList.result -and $null -ne $toolsList.result.tools) {
    $toolNames = @($toolsList.result.tools | ForEach-Object { $_.name })
}
$hasAdpCallCounters = $toolNames -contains 'cryogenic_adp_call_counts'
if ($hasAdpCallCounters) {
    Write-Host "[$(Get-Date -Format 'HH:mm:ss')] Using cryogenic_adp_call_counts polling mode."
}
else {
    Write-Host "[$(Get-Date -Format 'HH:mm:ss')] cryogenic_adp_call_counts not available; using DNADG signature search mode."
}

$deadline = (Get-Date).AddSeconds($TimeoutSeconds)
$driverActive = $false
$lastTotalCalls = 0
[int]$resolvedAdgSegment = 0

Write-Host "[$(Get-Date -Format 'HH:mm:ss')] Waiting for DNADG driver to load (timeout: ${TimeoutSeconds}s, polling every ${PollIntervalSeconds}s)..."
Write-Host "  The game needs ~13M instructions before reaching the intro and loading the ADG driver."

while ((Get-Date) -lt $deadline) {
    Start-Sleep -Seconds $PollIntervalSeconds

    try {
        # Re-initialize session each poll (SSE sessions can expire)
        Initialize-McpSession

        if ($hasAdpCallCounters) {
            # Poll cryogenic_adp_call_counts for activity when the tool is available.
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
                if ($counts.LastSongSegment) {
                    $resolvedAdgSegment = [int]$counts.LastSongSegment
                }
                Write-Host "[$(Get-Date -Format 'HH:mm:ss')] Driver is active! Capturing evidence..." -ForegroundColor Green
                break
            }
            $lastTotalCalls = $totalCalls
        }
        else {
            $candidateSegment = Resolve-AdgSegmentFromSignature
            if ($candidateSegment -ne 0) {
                $resolvedAdgSegment = $candidateSegment
                $driverActive = $true
                Write-Host "[$(Get-Date -Format 'HH:mm:ss')] DNADG signature found at runtime. Segment=0x$($resolvedAdgSegment.ToString('X4'))" -ForegroundColor Green
                break
            }
            Write-Host "[$(Get-Date -Format 'HH:mm:ss')] DNADG signature not found yet."
        }
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
[int]$adgSeg = 0
if ($hasAdpCallCounters) {
    $counts = Invoke-McpTool -ToolName 'cryogenic_adp_call_counts' -Id 31
    $counts | ConvertTo-Json | Out-File (Join-Path $outputDir 'adp_call_counts.json')
    if ($counts.LastSongSegment) {
        $adgSeg = [int]$counts.LastSongSegment
    }
}
if ($adgSeg -eq 0 -and $resolvedAdgSegment -ne 0) {
    $adgSeg = $resolvedAdgSegment
}
if ($adgSeg -eq 0) {
    $adgSeg = 0x5BAE
}
Write-Host "Resolved ADG segment=0x$($adgSeg.ToString('X4'))"

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
