param(
    [int]$Port = 8083,
    [int]$TimeoutSeconds = 1200,
    [int]$PollIntervalSeconds = 6,
    [string]$OutputRoot = ""
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Continue'

$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
if ([string]::IsNullOrWhiteSpace($OutputRoot)) {
    $OutputRoot = Join-Path $repoRoot 'dump/live/adg388-handoff'
}
New-Item -ItemType Directory -Path $OutputRoot -Force | Out-Null

$mcpUrl = "http://127.0.0.1:$Port/mcp"
$headers = @{ Accept = 'application/json, text/event-stream' }

function Invoke-Mcp {
    param([string]$Body)
    $wr = Invoke-WebRequest -Uri $mcpUrl -Method Post -ContentType "application/json" -Headers $headers -Body $Body -TimeoutSec 15
    $content = [string]$wr.Content
    if ([string]::IsNullOrWhiteSpace($content)) { return $null }
    $t = $content.Trim()
    if ($t.StartsWith('{')) { return $t | ConvertFrom-Json }
    $line = ($content -split "`r?`n" | Where-Object { $_ -like 'data: *' } | Select-Object -Last 1) -replace '^data: ', ''
    return $line | ConvertFrom-Json
}

function Initialize-McpSession {
    [void](Invoke-Mcp '{"jsonrpc":"2.0","id":1,"method":"initialize","params":{"protocolVersion":"2024-11-05","capabilities":{},"clientInfo":{"name":"adg-wait","version":"1"}}}')
    [void](Invoke-Mcp '{"jsonrpc":"2.0","method":"notifications/initialized","params":{}}')
}

function Invoke-Tool {
    param([string]$Name, [string]$ArgsJson = '{}')
    $body = "{`"jsonrpc`":`"2.0`",`"id`":99,`"method`":`"tools/call`",`"params`":{`"name`":`"$Name`",`"arguments`":$ArgsJson}}"
    $msg = Invoke-Mcp $body
    if ($null -ne $msg.result -and $null -ne $msg.result.PSObject.Properties['structuredContent']) {
        return $msg.result.structuredContent
    }
    return $msg.result
}

Write-Host "[$(Get-Date -Format 'HH:mm:ss')] adg-wait connected to $mcpUrl, timeout ${TimeoutSeconds}s"
Initialize-McpSession

$deadline = (Get-Date).AddSeconds($TimeoutSeconds)
[int]$adgSegment = 0
[int]$totalCalls = 0

while ((Get-Date) -lt $deadline) {
    Start-Sleep -Seconds $PollIntervalSeconds
    try {
        Initialize-McpSession
        $counts = Invoke-Tool 'cryogenic_adp_call_counts'
        [int]$lastSeg = 0
        if ($null -ne $counts -and $null -ne $counts.PSObject.Properties['lastSongSegment']) {
            $lastSeg = [int]$counts.lastSongSegment
        }
        # safe sum
        [int]$sum = 0
        if ($null -ne $counts -and $null -ne $counts.PSObject.Properties['entries'] -and $null -ne $counts.entries) {
            $entries = $counts.entries
            foreach ($p in $entries.PSObject.Properties) {
                try { $sum += [int]$p.Value } catch {}
            }
        }
        Write-Host "[$(Get-Date -Format 'HH:mm:ss')] callSum=$sum lastSongSegment=0x$($lastSeg.ToString('X4'))"
        if ($lastSeg -ne 0 -or $sum -gt 0) {
            $adgSegment = $lastSeg
            $totalCalls = $sum
            Write-Host "[$(Get-Date -Format 'HH:mm:ss')] DRIVER ACTIVE — segment=0x$($lastSeg.ToString('X4')) callSum=$sum" -ForegroundColor Green
            break
        }
    }
    catch {
        Write-Host "[$(Get-Date -Format 'HH:mm:ss')] poll err: $($_.Exception.Message)"
    }
}

if ($adgSegment -eq 0 -and $totalCalls -eq 0) {
    # fallback: signature search
    try {
        Initialize-McpSession
        $pattern = 'E9FC03E92005E95804E90405E9AF04E9E405E99604'
        $searchArgs = "{`"pattern`":`"$pattern`",`"startSegment`":0,`"startOffset`":0,`"length`":1048576,`"limit`":4}"
        $search = Invoke-Tool 'search_memory' $searchArgs
        if ($null -ne $search -and $null -ne $search.matches -and $search.matches.Count -gt 0) {
            [int]$sig = [int]$search.matches[0].segment
            [int]$off = [int]$search.matches[0].offset
            if ($off -eq 0) { $adgSegment = ($sig - 0x10) -band 0xFFFF } else { $adgSegment = $sig }
            Write-Host "[$(Get-Date -Format 'HH:mm:ss')] signature found at 0x$($sig.ToString('X4')):0x$($off.ToString('X4')) → segment=0x$($adgSegment.ToString('X4'))" -ForegroundColor Green
        }
    }
    catch { Write-Host "signature search failed: $_" }
}

if ($adgSegment -eq 0) {
    Write-Host "[$(Get-Date -Format 'HH:mm:ss')] timeout, driver not detected" -ForegroundColor Yellow
    exit 1
}

$timestamp = Get-Date -Format 'yyyyMMdd-HHmmss'
$outputDir = Join-Path $OutputRoot "adg-driver-active-$timestamp"
New-Item -ItemType Directory -Path $outputDir -Force | Out-Null
Write-Host "[$(Get-Date -Format 'HH:mm:ss')] capturing evidence into $outputDir"

Initialize-McpSession

# 1. status
$status = Invoke-Tool 'cryogenic_status'
$status | ConvertTo-Json -Depth 6 | Set-Content -Path (Join-Path $outputDir 'cryogenic_status.json') -Encoding UTF8

# 2. call counts (latest)
$counts = Invoke-Tool 'cryogenic_adp_call_counts'
$counts | ConvertTo-Json -Depth 8 | Set-Content -Path (Join-Path $outputDir 'adp_call_counts.json') -Encoding UTF8

# 3. CFG graph
$cfg = Invoke-Tool 'read_cfg_cpu_graph' '{"nodeLimit":300000}'
$cfg | ConvertTo-Json -Depth 80 | Set-Content -Path (Join-Path $outputDir 'cfg_cpu_graph.json') -Encoding UTF8

# 4. Memory dumps centered on the driver (10 KiB) + pre-driver area
$dumpRanges = @(
    @{ Seg = $adgSegment; Off = 0x0000; Len = 0x2800; Name = "dnadg_seg_${($adgSegment.ToString('X4'))}_0000_2800" },
    @{ Seg = $adgSegment; Off = 0x0100; Len = 0x0400; Name = "dnadg_exports_${($adgSegment.ToString('X4'))}_0100_0400" },
    @{ Seg = $adgSegment; Off = 0x01C7; Len = 0x0040; Name = "dnadg_fractions_${($adgSegment.ToString('X4'))}_01C7_0040" }
)
foreach ($r in $dumpRanges) {
    try {
        $ar = "{`"segment`":$($r.Seg),`"offset`":$($r.Off),`"length`":$($r.Len)}"
        $mem = Invoke-Tool 'read_memory' $ar
        if ($null -ne $mem -and $null -ne $mem.PSObject.Properties['data']) {
            $hex = [string]$mem.data
            # write raw bytes
            $bytes = [System.Convert]::FromHexString($hex)
            [System.IO.File]::WriteAllBytes((Join-Path $outputDir ($r.Name + '.bin')), $bytes)
            # pretty hexdump
            $lines = for ($i = 0; $i -lt $bytes.Length; $i += 16) {
                $end = [Math]::Min($i + 15, $bytes.Length - 1)
                $chunk = $bytes[$i..$end]
                $hexs = ($chunk | ForEach-Object { '{0:X2}' -f $_ }) -join ' '
                $asc = -join ($chunk | ForEach-Object { if ($_ -ge 0x20 -and $_ -lt 0x7F) { [char]$_ } else { '.' } })
                '{0:X4}: {1}  {2}' -f ($r.Off + $i), $hexs.PadRight(47), $asc
            }
            $lines | Set-Content -Path (Join-Path $outputDir ($r.Name + '.dump')) -Encoding UTF8
            Write-Host "  saved $($r.Name) ($($bytes.Length) bytes)"
        }
    }
    catch { Write-Host "  read_memory $($r.Name) failed: $_" }
}

# 5. Manifest
$manifest = [PSCustomObject]@{
    Timestamp     = $timestamp
    OutputDir     = $outputDir
    McpUrl        = $mcpUrl
    AdgSegment    = '0x{0:X4}' -f $adgSegment
    TotalAdpCalls = $totalCalls
    Status        = $status
    Notes         = "Captured live ADG driver evidence with --UseCodeOverride false (real ASM). DNADG fraction tables (offset 0x01C7+) populated by the driver at runtime — extracted here for cloud handoff."
}
$manifest | ConvertTo-Json -Depth 8 | Set-Content -Path (Join-Path $outputDir 'manifest.json') -Encoding UTF8

Write-Host "[$(Get-Date -Format 'HH:mm:ss')] capture complete → $outputDir"
