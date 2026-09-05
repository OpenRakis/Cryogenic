function Invoke-Mcp {
    param([string]$Port = "8081", [string]$Body)
    $headers = @{ Accept = "application/json, text/event-stream" }
    $wr = Invoke-WebRequest -Uri "http://127.0.0.1:$Port/mcp" -Method Post `
        -ContentType "application/json" -Headers $headers -Body $Body -TimeoutSec 30
    $lines = $wr.Content -split "`r?`n"
    ($lines | Where-Object { $_ -like "data: *" } | Select-Object -Last 1) -replace '^data: ', ''
}

function McpCall {
    param([string]$Name, $Arguments = @{})
    $payload = @{
        jsonrpc = "2.0"
        id      = (Get-Random)
        method  = "tools/call"
        params  = @{ name = $Name; arguments = $Arguments }
    } | ConvertTo-Json -Depth 10 -Compress
    Invoke-Mcp -Body $payload
}

function McpInit {
    Invoke-Mcp -Body '{"jsonrpc":"2.0","id":1,"method":"initialize","params":{"protocolVersion":"2024-11-05","capabilities":{},"clientInfo":{"name":"agent","version":"1.0"}}}' | Out-Null
    Invoke-Mcp -Body '{"jsonrpc":"2.0","method":"notifications/initialized","params":{}}' | Out-Null
}
