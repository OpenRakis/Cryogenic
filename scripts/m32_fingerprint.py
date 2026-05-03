#!/usr/bin/env python3
"""Generate fingerprint JSON from .M32 files.

Scans a folder for files with extension .M32 (case-insensitive),
reads the first two bytes of each file and uses them as a 4-digit
lowercase hex fingerprint (e.g. 'e03d') to build a JSON map:

{
  "e03d": {
    "fingerprint": "e03d",
    "name": "MORNING"
  },
  ...
}

Usage:
  python3 scripts/m32_fingerprint.py /path/to/folder
  python3 scripts/m32_fingerprint.py /path/to/folder -o fingerprints.json
  python3 scripts/m32_fingerprint.py /path/to/folder --stdout --include-file
"""

import argparse
import json
import sys
import logging
from pathlib import Path


def scan_folder(folder_path: Path, include_file: bool = False, uppercase_name: bool = True):
    entries = {}
    for p in sorted(folder_path.iterdir()):
        if not p.is_file():
            continue
        if p.suffix.lower() != ".m32":
            continue
        try:
            data = p.read_bytes()
        except Exception as e:
            logging.warning("Could not read %s: %s", p, e)
            continue
        if len(data) < 2:
            logging.warning("File %s is smaller than 2 bytes; skipping", p.name)
            continue
        fingerprint = data[:2].hex()
        name = p.stem.upper() if uppercase_name else p.stem
        if fingerprint in entries:
            logging.warning("Duplicate fingerprint %s for files %s and %s; keeping first", fingerprint, entries[fingerprint].get("file", entries[fingerprint]["name"]), p.name)
            continue
        obj = {"fingerprint": fingerprint, "name": name}
        if include_file:
            obj["file"] = p.name
        entries[fingerprint] = obj
    return entries


def main():
    logging.basicConfig(level=logging.WARNING, format="%(levelname)s: %(message)s")
    parser = argparse.ArgumentParser(description="Generate JSON mapping of first-2-byte fingerprints for .M32 files.")
    parser.add_argument("folder", nargs="?", default=".", help="Folder to scan for .M32 files.")
    parser.add_argument("-o", "--output", default="fingerprints.json", help="Output JSON file (default: fingerprints.json)")
    parser.add_argument("--stdout", action="store_true", help="Write JSON to stdout instead of file.")
    parser.add_argument("--include-file", action="store_true", help="Include original filename in 'file' field.")
    parser.add_argument("--no-uppercase-name", dest="uppercase_name", action="store_false", help="Do not uppercase the 'name' field.")
    args = parser.parse_args()

    folder = Path(args.folder)
    if not folder.exists() or not folder.is_dir():
        print(f"Error: folder '{folder}' not found or not a directory", file=sys.stderr)
        sys.exit(2)

    entries = scan_folder(folder, include_file=args.include_file, uppercase_name=args.uppercase_name)
    out_json = json.dumps(entries, indent=2, sort_keys=True)
    if args.stdout:
        print(out_json)
    else:
        out_path = Path(args.output)
        out_path.write_text(out_json, encoding="utf-8")
        print(f"Wrote {out_path}")


if __name__ == "__main__":
    main()
