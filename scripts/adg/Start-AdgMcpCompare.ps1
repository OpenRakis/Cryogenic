param(
    [Parameter(Mandatory = $true)]
    [string]$ExePath,
    [string]$ProjectPath = "src/Cryogenic/Cryogenic.csproj",
    [string]$AudioArgument = "ADG388",
    [int]$PitPeriod = 4096,
    [int]$Cycles = 8000,
    [string]$OplMode = "Opl3Gold",
    [string]$HeadlessMode = "Minimal",
    [int]$BaselineMcpPort = 8081,
    [int]$OverrideMcpPort = 8082,
    [int]$BaselineHttpApiPort = 20000,
    [int]$OverrideHttpApiPort = 20001,
    [int]$BaselineGdbPort = 10001,
    [int]$OverrideGdbPort = 10002,
    [bool]$NoBuild = $true
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot "..\..")).Path
$projectFullPath = (Resolve-Path (Join-Path $repoRoot $ProjectPath)).Path
$exeFullPath = (Resolve-Path $ExePath).Path

$timestamp = Get-Date -Format "yyyyMMdd-HHmmss"
$outputDir = Join-Path $repoRoot ("dump/live/adg388-compare/" + $timestamp)
New-Item -ItemType Directory -Path $outputDir -Force | Out-Null

function Start-CryogenicInstance {
    param(
        [string]$Name,
        [bool]$UseOverride,
        [int]$McpPort,
        [int]$HttpApiPort,
        [int]$GdbPort
    )

    $overrideValue = if ($UseOverride) { "true" } else { "false" }
    $args = @("run")
    if ($NoBuild) {
        $args += "--no-build"
    }
    $args += @(
        "--project", $projectFullPath,
        "--",
        "--UseCodeOverride", $overrideValue,
        "--HeadlessMode", $HeadlessMode,
        "--Cycles", "$Cycles",
        "-a", $AudioArgument,
        "--OplMode", $OplMode,
        "-e", $exeFullPath,
        "-p", "$PitPeriod",
        "--HttpApiPort", "$HttpApiPort",
        "--McpHttpPort", "$McpPort",
        "--GdbPort", "$GdbPort"
    )

    $stdout = Join-Path $outputDir ("$Name.stdout.log")
    $stderr = Join-Path $outputDir ("$Name.stderr.log")

    $process = Start-Process -FilePath "dotnet" -ArgumentList $args -WorkingDirectory $repoRoot -PassThru -RedirectStandardOutput $stdout -RedirectStandardError $stderr

    [PSCustomObject]@{
        Name            = $Name
        Pid             = $process.Id
        UseCodeOverride = $UseOverride
        McpPort         = $McpPort
        HttpApiPort     = $HttpApiPort
        GdbPort         = $GdbPort
        StdOut          = $stdout
        StdErr          = $stderr
    }
}

$baseline = Start-CryogenicInstance -Name "baseline-asm" -UseOverride:$false -McpPort $BaselineMcpPort -HttpApiPort $BaselineHttpApiPort -GdbPort $BaselineGdbPort
$override = Start-CryogenicInstance -Name "override-csharp" -UseOverride:$true -McpPort $OverrideMcpPort -HttpApiPort $OverrideHttpApiPort -GdbPort $OverrideGdbPort

$session = [PSCustomObject]@{
    Timestamp     = $timestamp
    OutputDir     = $outputDir
    ExePath       = $exeFullPath
    ProjectPath   = $projectFullPath
    AudioArgument = $AudioArgument
    OplMode       = $OplMode
    Baseline      = $baseline
    Override      = $override
    Notes         = "Baseline instance uses --UseCodeOverride false (real ASM). Override instance uses --UseCodeOverride true (C# overrides)."
}

$sessionPath = Join-Path $outputDir "session.json"
$session | ConvertTo-Json -Depth 6 | Set-Content -Path $sessionPath -Encoding UTF8

Write-Host "Started comparison session."
Write-Host "Baseline PID: $($baseline.Pid) MCP: http://127.0.0.1:$BaselineMcpPort/mcp API: http://127.0.0.1:$BaselineHttpApiPort"
Write-Host "Override PID: $($override.Pid) MCP: http://127.0.0.1:$OverrideMcpPort/mcp API: http://127.0.0.1:$OverrideHttpApiPort"
Write-Host "Session file: $sessionPath"
Write-Host "To stop both quickly: Get-Process -Id $($baseline.Pid),$($override.Pid) | Stop-Process"
