# ADG388 MCP Compare Scripts

These scripts automate baseline (real ASM) vs override (C#) comparison runs using two concurrent emulator instances on different ports.

## 1) Start both instances in parallel

```powershell
pwsh -File scripts/adg/Start-AdgMcpCompare.ps1 \
  -ExePath "C:/Jeux/ABWFR/DuneCDVF/C/DUNECD/DNCDPRG.EXE" \
  -AudioArgument "ADG388" \
  -BaselineHttpApiPort 20000 -OverrideHttpApiPort 20001 \\
  -BaselineMcpPort 8081 -OverrideMcpPort 8082 \
  -BaselineGdbPort 10001 -OverrideGdbPort 10002
```

Important:

- Baseline uses `--UseCodeOverride false` (real ASM driver).
- Override uses `--UseCodeOverride true` (C# overrides).
- Both are launched as background processes (`Start-Process`) so your terminal remains free.
- Each instance must also have a unique `--HttpApiPort`; otherwise one process exits with port 20000 collision.

## 2) Capture MCP snapshots (CFG + status)

```powershell
pwsh -File scripts/adg/Get-Spice86CfgSnapshot.ps1 -Port 8081 -Label baseline
pwsh -File scripts/adg/Get-Spice86CfgSnapshot.ps1 -Port 8082 -Label override
```

Artifacts include:

- `*.cfg.json` (from `read_cfg_cpu_graph`)
- `*.cryogenic_status.json` (from `cryogenic_status`)
- `*.functions.json` (from `list_functions`)

## 3) Diff baseline vs override CFG

```powershell
pwsh -File scripts/adg/Compare-Spice86Cfg.ps1 \
  -BaselineCfgPath "dump/live/adg388-compare/snapshot-...-baseline/baseline.cfg.json" \
  -OverrideCfgPath "dump/live/adg388-compare/snapshot-...-override/override.cfg.json"
```

Outputs:

- `cfg-diff.json`
- `cfg-diff-summary.md`

## Notes

- MCP endpoint is `http://127.0.0.1:<port>/mcp`.
- Health endpoint is `http://127.0.0.1:<port>/health`.
- If one instance fails to start, inspect `*.stdout.log` and `*.stderr.log` in the created session folder under `dump/live/adg388-compare/`.
