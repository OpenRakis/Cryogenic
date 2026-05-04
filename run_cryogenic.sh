#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
cd "$SCRIPT_DIR" || exit 1

DUNE_DIR="./dune"
MT32_DIR="./mt32rom"

if ! command -v dotnet >/dev/null 2>&1; then
  echo "dotnet CLI not found. Install the .NET SDK to run Cryogenic."
  exit 1
fi

# Finds a file case-insensitively in a directory, prints its status line,
# stores the resolved path in the named variable, and returns 0 if found, 1 if missing.
locate_asset() {
  local label="$1"
  local dir="$2"
  local pattern="$3"
  local var="$4"
  local path
  path="$(find "$dir" -maxdepth 1 -type f -iname "$pattern" -print -quit 2>/dev/null || true)"
  printf '  %-20s -> %s\n' "$label" "${path:+found}${path:-missing}"
  printf -v "$var" '%s' "$path"
  [ -n "$path" ]
}

if [ ! -d "$DUNE_DIR" ]; then
  echo "Directory $DUNE_DIR not found."
  echo "Please create the directory and copy the ENTIRE contents of your Dune CD 3.7 into $DUNE_DIR"
  exit 1
fi

echo "Checking Dune assets..."
dune_ok=true
locate_asset "DNCDPRG.EXE" "$DUNE_DIR" 'dncdprg.exe' DUNE_EXE_PATH || dune_ok=false
locate_asset "DUNE.DAT"    "$DUNE_DIR" 'dune.dat'    DUNE_DAT_PATH || dune_ok=false
if ! $dune_ok; then
  echo "Please copy the entire Dune CD 3.7 into $DUNE_DIR."
  exit 1
fi

echo "Checking MT-32 ROMs..."
mt32_ok=true
locate_asset "MT32_CONTROL.ROM" "$MT32_DIR" 'mt32_control.rom' MT32_CONTROL_PATH || mt32_ok=false
locate_asset "MT32_PCM.ROM"     "$MT32_DIR" 'mt32_pcm.rom'     MT32_PCM_PATH     || mt32_ok=false
if ! $mt32_ok; then
  echo "Extract MT-32_v1.07_legacy_ROM_files.zip into $MT32_DIR and retry."
  exit 1
fi

DEFAULT_ARGS=( -e "$DUNE_EXE_PATH" -a "MID330 SBP2227" -m "$MT32_DIR" -p 4096 --UseCodeOverride true --OplMode Opl3Gold )

echo "Running Cryogenic with arguments: ${DEFAULT_ARGS[*]} $*"

dotnet run --project src/Cryogenic -- "${DEFAULT_ARGS[@]}" "$@"
