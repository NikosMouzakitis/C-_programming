#!/usr/bin/env bash
set -euo pipefail

# Good if healthcheck.txt contains exactly "OK"
if [[ -f healthcheck.txt ]] && grep -qx "OK" healthcheck.txt; then
  echo "[GOOD] healthcheck is OK"
  exit 0
else
  echo "[BAD] healthcheck is not OK"
  exit 1
fi
