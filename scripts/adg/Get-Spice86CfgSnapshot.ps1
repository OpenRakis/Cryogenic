param(
    [int]$Port = 8081,
    [string]$Label = "baseline",
    [int]$NodeLimit = 200000,
    [int]$FunctionLimit = 20000,
    [string]$OutputRoot = ""
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot "..\..")).Path
if ([string]::IsNullOrWhiteSpace($OutputRoot)) {
    $OutputRoot = Join-Path $repoRoot "dump/live/adg388-compare"
}

$timestamp = Get-Date -Format "yyyyMMdd-HHmmss"
$outputDir = Join-Path $OutputRoot ("snapshot-" + $timestamp + "-" + $Label)
New-Item -ItemType Directory -Path $outputDir -Force | Out-Null

$baseUrl = "http://127.0.0.1:$Port"
$mcpUrl = "$baseUrl/mcp"

$healthPath = Join-Path $outputDir ("$Label.health.json")
$statusPath = Join-Path $outputDir ("$Label.cryogenic_status.json")
$cfgPath = Join-Path $outputDir ("$Label.cfg.json")
$functionsPath = Join-Path $outputDir ("$Label.functions.json")
$aboutPath = Join-Path $outputDir ("$Label.mcp_about.json")
$metaPath = Join-Path $outputDir ("$Label.meta.json")

function Invoke-McpPost {
    param([hashtable]$Payload)

    $json = $Payload | ConvertTo-Json -Depth 20 -Compress
    $headers = @{ Accept = "application/json, text/event-stream" }
    $response = Invoke-WebRequest -Uri $mcpUrl -Method Post -ContentType "application/json" -Headers $headers -Body $json
    $responseContent = $response.Content
    $contentText = if ($responseContent -is [byte[]]) {
        [System.Text.Encoding]::UTF8.GetString($responseContent)
    }
    else {
        [string]$responseContent
    }

    if ([string]::IsNullOrWhiteSpace($contentText)) {
        return [PSCustomObject]@{}
    }

    $content = $contentText.Trim()
    if ($content.StartsWith("{")) {
        return ($content | ConvertFrom-Json -Depth 100)
    }

    $lines = $contentText -split "`r?`n"
    $dataLines = @($lines | Where-Object { $_ -like "data:*" })
    if ($dataLines.Count -eq 0) {
        throw "No SSE data lines returned by MCP endpoint $mcpUrl"
    }

    $lastData = $dataLines[$dataLines.Count - 1].Substring(5).Trim()
    return ($lastData | ConvertFrom-Json -Depth 100)
}

function Invoke-McpInitialize {
    $initPayload = @{
        jsonrpc = "2.0"
        id      = 1
        method  = "initialize"
        params  = @{
            protocolVersion = "2024-11-05"
            capabilities    = @{}
            clientInfo      = @{ name = "adg-cfg-capture"; version = "1.0" }
        }
    }
    [void](Invoke-McpPost -Payload $initPayload)

    $notifyPayload = @{
        jsonrpc = "2.0"
        method  = "notifications/initialized"
        params  = @{}
    }
    [void](Invoke-McpPost -Payload $notifyPayload)
}

function Invoke-McpTool {
    param(
        [int]$Id,
        [string]$ToolName,
        [hashtable]$Arguments
    )

    $payload = @{
        jsonrpc = "2.0"
        id      = $Id
        method  = "tools/call"
        params  = @{
            name      = $ToolName
            arguments = $Arguments
        }
    }

    $message = Invoke-McpPost -Payload $payload
    $hasIsError = $false
    if ($null -ne $message.result) {
        $hasIsError = $null -ne ($message.result.PSObject.Properties["isError"])
    }

    if ($hasIsError -and $message.result.isError -eq $true) {
        $errText = "unknown error"
        if ($null -ne $message.result.content -and $message.result.content.Count -gt 0) {
            $errText = $message.result.content[0].text
        }
        throw "MCP tool '$ToolName' failed: $errText"
    }

    if ($null -ne $message.result -and $null -ne ($message.result.PSObject.Properties["structuredContent"])) {
        return $message.result.structuredContent
    }

    return $message.result
}

$health = Invoke-RestMethod -Uri "$baseUrl/health" -Method Get
$health | ConvertTo-Json -Depth 10 | Set-Content -Path $healthPath -Encoding UTF8

Invoke-McpInitialize

$about = Invoke-McpTool -Id 2 -ToolName "mcp_about" -Arguments @{}
$status = Invoke-McpTool -Id 3 -ToolName "cryogenic_status" -Arguments @{}
$cfg = Invoke-McpTool -Id 4 -ToolName "read_cfg_cpu_graph" -Arguments @{ nodeLimit = $NodeLimit }
$functions = Invoke-McpTool -Id 5 -ToolName "list_functions" -Arguments @{ limit = $FunctionLimit }

$about | ConvertTo-Json -Depth 40 | Set-Content -Path $aboutPath -Encoding UTF8
$status | ConvertTo-Json -Depth 40 | Set-Content -Path $statusPath -Encoding UTF8
$cfg | ConvertTo-Json -Depth 80 | Set-Content -Path $cfgPath -Encoding UTF8
$functions | ConvertTo-Json -Depth 80 | Set-Content -Path $functionsPath -Encoding UTF8

$nodeCount = if ($null -ne $cfg.Nodes) { $cfg.Nodes.Count } else { 0 }
$liveCount = if ($null -ne $cfg.Nodes) { ($cfg.Nodes | Where-Object { $_.IsLive }).Count } else { 0 }

$meta = [PSCustomObject]@{
    Label         = $Label
    Port          = $Port
    McpUrl        = $mcpUrl
    Timestamp     = $timestamp
    OutputDir     = $outputDir
    NodeCount     = $nodeCount
    LiveNodeCount = $liveCount
    HealthPath    = $healthPath
    AboutPath     = $aboutPath
    StatusPath    = $statusPath
    CfgPath       = $cfgPath
    FunctionsPath = $functionsPath
}
$meta | ConvertTo-Json -Depth 10 | Set-Content -Path $metaPath -Encoding UTF8

Write-Host "Captured MCP snapshot for '$Label' from port $Port"
Write-Host "CFG nodes: $nodeCount (live: $liveCount)"
Write-Host "Output: $outputDir"
