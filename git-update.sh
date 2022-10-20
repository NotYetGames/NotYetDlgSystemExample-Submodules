#!/usr/bin/env bash
set -euo pipefail
SCRIPT_DIR="$(dirname "$(readlink -f "$0")")"

# Update repo
git pull --verbose

# Update subtree
git submodule update --remote
git submodule foreach git pull origin 5.1
