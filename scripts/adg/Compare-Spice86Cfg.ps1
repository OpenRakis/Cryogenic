param(
    [Parameter(Mandatory = $true)]
    [string]$BaselineCfgPath,
    [Parameter(Mandatory = $true)]
    [string]$OverrideCfgPath,
    [string]$OutputDir = ""
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot "..\..")).Path
$baselinePath = (Resolve-Path $BaselineCfgPath).Path
$overridePath = (Resolve-Path $OverrideCfgPath).Path

if ([string]::IsNullOrWhiteSpace($OutputDir)) {
    $timestamp = Get-Date -Format "yyyyMMdd-HHmmss"
    $OutputDir = Join-Path $repoRoot ("dump/live/adg388-compare/cfg-diff-" + $timestamp)
}
New-Item -ItemType Directory -Path $OutputDir -Force | Out-Null

$baseline = Get-Content -Raw -Path $baselinePath | ConvertFrom-Json -Depth 100
$override = Get-Content -Raw -Path $overridePath | ConvertFrom-Json -Depth 100

function To-AddressSet {
    param([object]$Cfg)

    $set = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::OrdinalIgnoreCase)
    if ($null -eq $Cfg.Nodes) {
        return $set
    }

    foreach ($node in $Cfg.Nodes) {
        $seg = [int]$node.Address.Segment
        $off = [int]$node.Address.Offset
        $key = "{0:X4}:{1:X4}" -f $seg, $off
        [void]$set.Add($key)
    }

    return $set
}

$baselineSet = To-AddressSet -Cfg $baseline
$overrideSet = To-AddressSet -Cfg $override

$onlyBaseline = [System.Collections.Generic.List[string]]::new()
foreach ($address in $baselineSet) {
    if (-not $overrideSet.Contains($address)) {
        $onlyBaseline.Add($address)
    }
}

$onlyOverride = [System.Collections.Generic.List[string]]::new()
foreach ($address in $overrideSet) {
    if (-not $baselineSet.Contains($address)) {
        $onlyOverride.Add($address)
    }
}

$intersection = [System.Collections.Generic.List[string]]::new()
foreach ($address in $baselineSet) {
    if ($overrideSet.Contains($address)) {
        $intersection.Add($address)
    }
}

$onlyBaselineSorted = $onlyBaseline | Sort-Object
$onlyOverrideSorted = $onlyOverride | Sort-Object
$intersectionSorted = $intersection | Sort-Object

$result = [PSCustomObject]@{
    BaselineCfgPath = $baselinePath
    OverrideCfgPath = $overridePath
    BaselineNodeCount = $baselineSet.Count
    OverrideNodeCount = $overrideSet.Count
    IntersectionCount = $intersectionSorted.Count
    OnlyBaselineCount = $onlyBaselineSorted.Count
    OnlyOverrideCount = $onlyOverrideSorted.Count
    OnlyBaselineAddresses = $onlyBaselineSorted
    OnlyOverrideAddresses = $onlyOverrideSorted
    IntersectionAddresses = $intersectionSorted
}

$jsonPath = Join-Path $OutputDir "cfg-diff.json"
$result | ConvertTo-Json -Depth 20 | Set-Content -Path $jsonPath -Encoding UTF8

$summaryPath = Join-Path $OutputDir "cfg-diff-summary.md"
$summary = @(
    '# CFG Diff Summary',
    '',
    "- Baseline nodes: $($result.BaselineNodeCount)",
    "- Override nodes: $($result.OverrideNodeCount)",
    "- Intersection: $($result.IntersectionCount)",
    "- Only baseline: $($result.OnlyBaselineCount)",
    "- Only override: $($result.OnlyOverrideCount)",
    '',
    '## Baseline-only addresses (first 200)',
    '',
    '```text',
    (($onlyBaselineSorted | Select-Object -First 200) -join [Environment]::NewLine),
    '```',
    '',
    '## Override-only addresses (first 200)',
    '',
    '```text',
    (($onlyOverrideSorted | Select-Object -First 200) -join [Environment]::NewLine),
    '```'
)
$summary -join [Environment]::NewLine | Set-Content -Path $summaryPath -Encoding UTF8

Write-Host "CFG diff complete."
Write-Host "JSON: $jsonPath"
Write-Host "Summary: $summaryPath"
