---
name: dune-dat-and-hsq-decompression
description: 'Extract Cryo DUNE.DAT with the in-repo DuneExtractor, then optionally decompress HSQ files to UNHSQ with Cryogenic.Tools.UnHsq for analysis workflows.'
argument-hint: 'Path to DUNE.DAT, optional HSQ subset, and output policy (skip-existing or overwrite)'
user-invocable: true
---

# DUNE.DAT Extraction And HSQ Decompression

Use this workflow to produce reproducible, tool-backed assets:
1. Extract DUNE.DAT entries.
2. Discover HSQ files.
3. Optionally decompress HSQ to UNHSQ.
4. Validate outputs and summarize results.

This skill must use existing in-solution tools.
Do not reimplement DUNE.DAT extraction or HSQ decompression logic.

## When To Use
- You need raw assets from DUNE.DAT for reverse engineering.
- You need decompressed .UNHSQ files for offline analysis.
- You need a repeatable extraction/decompression report for PR evidence.

## Inputs
- Required: absolute path to DUNE.DAT.
- Optional: specific HSQ files (subset) after extraction.
- Optional output policy:
  - skip-existing (default)
  - overwrite
- Optional mode:
  - extract-only
  - extract-and-decompress

Default policy for this skill:
- If a target .UNHSQ already exists, skip decompression for that file.

## Procedure

### 1. Preflight Checks
1. Confirm DUNE.DAT exists.
2. Confirm tool projects exist:
   - src/Cryogenic.Tools.DuneExtractor/DuneExtractor.csproj
   - src/Cryogenic.Tools.UnHsq/UnHsq.csproj
3. Decide output policy before running.

### 2. Extract DUNE.DAT
1. Run DuneExtractor:
   - dotnet run --project src/Cryogenic.Tools.DuneExtractor/DuneExtractor.csproj -- <path-to-DUNE.DAT>
2. Expected output folder:
   - <DUNE.DAT full filename>_/
3. Count extracted files and record summary.

Decision point:
- If extraction fails, stop and report the exact error and path used.

### 3. Discover HSQ Files
1. Enumerate .HSQ files under the extracted folder.
2. If a subset is provided, filter to that subset.
3. If none are found, finish with a report that extraction succeeded but no HSQ files were present.

### 4. Optional Decompression
1. If mode is extract-only, skip this step.
2. If mode is extract-and-decompress, run UnHsq:
   - dotnet run --project src/Cryogenic.Tools.UnHsq/UnHsq.csproj -- <file1.HSQ> <file2.HSQ> ...
3. For large sets, run in batches and track per-batch outcomes.

Decision points:
- If a file fails validation in UnHsq, continue with remaining files and log failures.
- If skip-existing policy is selected and .UNHSQ exists, skip and count as skipped.

### 5. Validate Outputs
1. For each decompressed HSQ, confirm corresponding .UNHSQ exists.
2. Record counts:
   - total HSQ discovered
   - selected HSQ
   - processed
   - skipped
   - succeeded
   - failed
3. Optionally record size stats (HSQ bytes vs UNHSQ bytes).

### 6. Final Report
Provide a concise report containing:
1. Input DUNE.DAT path.
2. Extraction output path.
3. HSQ discovery counts.
4. Decompression counts (if decompression ran).
5. Failed files (if any).

## Completion Criteria
- DUNE.DAT extraction completed without fatal errors.
- HSQ enumeration completed.
- When decompression mode is enabled, UNHSQ outputs are produced for targeted HSQ files (except explicitly skipped/failed files).
- A structured report is delivered with counts and paths.

## Safety And Consistency Rules
- Always prefer in-repo tools over custom scripts for extraction/decompression.
- Do not modify extracted binary payloads.
- Keep operations idempotent when using skip-existing policy.
- Resolve ambiguous paths to absolute paths before running tools.
