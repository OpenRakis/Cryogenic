#!/usr/bin/env pwsh
# Sequential MCP client: writes JSON-RPC requests one at a time
# and reads responses to completion before sending the next. Drives
# the Cryogenic.AdgPlayer.Mcp stdio server to capture audio from
# the player for offline comparison with the live emulator.

[CmdletBinding()]
param(
    [string]$Song = 'doc/DUNECDVF/C/DUNECD/DUNE.DAT_/ARRAKIS_AGD.HSQ',
    [double]$Seconds = 5,
    [string]$WavOut = ''
)

$ErrorActionPreference = 'Stop'
$exe = Join-Path $PSScriptRoot '..\..\src\Cryogenic.AdgPlayer.Mcp\bin\Debug\net10.0\Cryogenic.AdgPlayer.Mcp.exe'
$exe = (Resolve-Path $exe).Path

$psi = New-Object System.Diagnostics.ProcessStartInfo
$psi.FileName = $exe
$psi.RedirectStandardInput = $true
$psi.RedirectStandardOutput = $true
$psi.RedirectStandardError = $true
$psi.UseShellExecute = $false
$proc = [System.Diagnostics.Process]::Start($psi)
$stdin = $proc.StandardInput
$stdout = $proc.StandardOutput

function Send-Notify([string]$method) {
    $obj = @{ jsonrpc = '2.0'; method = $method }
    $stdin.WriteLine(($obj | ConvertTo-Json -Compress -Depth 8))
    $stdin.Flush()
}

function Send-Request([int]$id, [string]$method, $params) {
    $obj = @{ jsonrpc = '2.0'; id = $id; method = $method; params = $params }
    $stdin.WriteLine(($obj | ConvertTo-Json -Compress -Depth 12))
    $stdin.Flush()
    while ($true) {
        $line = $stdout.ReadLine()
        if ($null -eq $line) { throw "MCP server closed stdout" }
        try {
            $resp = $line | ConvertFrom-Json -ErrorAction Stop
            if ($resp.id -eq $id) { return $resp }
        }
        catch { }
    }
}

function Call-Tool([int]$id, [string]$tool, $toolArgs) {
    if ($null -eq $toolArgs) { $toolArgs = [hashtable]@{} }
    return Send-Request $id 'tools/call' @{ name = $tool; arguments = $toolArgs }
}

function Show([int]$id, [string]$label, [scriptblock]$invocation) {
    $r = & $invocation
    Write-Host ("--- {0} ---" -f $label) -ForegroundColor Cyan
    $text = ($r.result.content | Where-Object { $_.type -eq 'text' } | Select-Object -First 1).text
    if ($text) {
        try { ($text | ConvertFrom-Json) | ConvertTo-Json -Depth 10 | Write-Host }
        catch { Write-Host $text }
    }
    elseif ($r.error) {
        $r.error | ConvertTo-Json -Depth 10 | Write-Host -ForegroundColor Red
    }
    else {
        $r.result | ConvertTo-Json -Depth 10 | Write-Host
    }
}

try {
    Send-Request 1 'initialize' @{
        protocolVersion = '2024-11-05'
        capabilities    = @{}
        clientInfo      = @{ name = 'smoke'; version = '1.0' }
    } | Out-Null
    Send-Notify 'notifications/initialized'

    Show 2 'list_songs' { Call-Tool 2 'list_songs' ([hashtable]@{}) }
    Show 3 'load_song' { Call-Tool 3 'load_song' @{ path = $Song } }
    Show 4 'play' { Call-Tool 4 'play' ([hashtable]@{}) }
    Show 5 'tick(200)' { Call-Tool 5 'tick' @{ count = 200 } }
    Show 6 'get_state' { Call-Tool 6 'get_state' ([hashtable]@{}) }
    Show 7 "dump_wav($Seconds s)" { Call-Tool 7 'dump_wav' @{ seconds = $Seconds; outputPath = $WavOut } }
    Show 8 'levels' { Call-Tool 8 'get_audio_levels' @{ frameCount = 16384 } }
    Show 9 'opl(first 8)' { Call-Tool 9 'get_opl_writes' @{ sinceIndex = 0; maxEntries = 8 } }
}
finally {
    if (-not $proc.HasExited) {
        $stdin.Close()
        $proc.WaitForExit(2000) | Out-Null
        if (-not $proc.HasExited) { $proc.Kill() }
    }
}
